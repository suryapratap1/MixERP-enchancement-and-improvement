DROP FUNCTION IF EXISTS transactions.get_order_summary(_party_id bigint, _office_id integer);

CREATE FUNCTION transactions.get_order_summary(_party_id bigint, _office_id integer)
RETURNS TABLE
(
    sales_order_id                              bigint,
    order_date                                  date,
    tran_id                                     bigint,
    sales_id                                    bigint,
    delivered_date                              date,
    lead_time                                   integer,
    items                                       text,
    total_ordered                               integer,
    delivered                                   integer,
    undelivered                                 integer
)
AS
$$
BEGIN
    DROP TABLE IF EXISTS temp_orders;
    CREATE TEMPORARY TABLE temp_orders
    (
        sales_order_id                              bigint,
        order_date                                  date,
        tran_id                                     bigint,
        sales_id                                    bigint,
        delivered_date                              date,
        lead_time                                   integer,
        items                                       text,
        total_ordered                               integer,
        delivered                                   integer,
        undelivered                                 integer
    ) ON COMMIT DROP;

    INSERT INTO temp_orders(sales_order_id, order_date)
    SELECT non_gl_stock_master_id, value_date
    FROM transactions.non_gl_stock_master
    WHERE transactions.non_gl_stock_master.book = 'Sales.Order'
    AND transactions.non_gl_stock_master.office_id = _office_id
    AND transactions.non_gl_stock_master.party_id = _party_id;

    WITH order_summary
    AS
    (
        SELECT 
            transactions.non_gl_stock_details.non_gl_stock_master_id,            
            array_to_string(array_agg(core.get_item_name_by_item_id(transactions.non_gl_stock_details.item_id)), ', ') AS items,
            SUM(transactions.non_gl_stock_details.base_quantity) AS total_ordered
        FROM transactions.non_gl_stock_details
        WHERE non_gl_stock_master_id IN
        (
            SELECT temp_orders.sales_order_id
            FROM temp_orders
        )
        GROUP BY non_gl_stock_master_id 
    )

    UPDATE temp_orders
    SET
        items           = order_summary.items,
        total_ordered   = order_summary.total_ordered
    FROM order_summary
    WHERE order_summary.non_gl_stock_master_id = temp_orders.sales_order_id;

    UPDATE temp_orders
    SET
        sales_id = transactions.stock_master_non_gl_relations.stock_master_id
    FROM transactions.stock_master_non_gl_relations
    WHERE temp_orders.sales_order_id = transactions.stock_master_non_gl_relations.non_gl_stock_master_id
    AND transactions.is_verified_stock_transaction(transactions.stock_master_non_gl_relations.stock_master_id);

    UPDATE temp_orders
    SET
        tran_id  = transactions.stock_master.transaction_master_id
    FROM transactions.stock_master
    WHERE transactions.stock_master.stock_master_id = temp_orders.sales_id;

    WITH sales_summary
    AS
    (
        SELECT
            transactions.stock_details.stock_master_id,
            transactions.stock_details.value_date,
            SUM(transactions.stock_details.base_quantity) AS total_delivered
        FROM transactions.stock_details
        WHERE transactions.stock_details.stock_master_id IN
        (
            SELECT temp_orders.sales_id
            FROM temp_orders
        )
        GROUP BY transactions.stock_details.stock_master_id, transactions.stock_details.value_date
    )

    UPDATE temp_orders
    SET
        delivered_date  = sales_summary.value_date,
        delivered       = sales_summary.total_delivered
    FROM sales_summary
    WHERE sales_summary.stock_master_id = temp_orders.sales_id;

    UPDATE temp_orders
    SET
        undelivered     = COALESCE(temp_orders.total_ordered, 0) - COALESCE(temp_orders.delivered, 0),
        lead_time       = temp_orders.delivered_date - temp_orders.order_date;
    
    RETURN QUERY
    SELECT * FROM temp_orders
    ORDER BY order_date DESC, sales_order_id DESC;
END
$$
LANGUAGE plpgsql;



--SELECT * FROM transactions.get_order_summary(1, 3);