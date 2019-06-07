DROP FUNCTION IF EXISTS transactions.get_order_summary_info(_sales_order_id bigint, _sales_id bigint);

CREATE FUNCTION transactions.get_order_summary_info(_sales_order_id bigint, _sales_id bigint)
RETURNS TABLE
(
    row_number                      integer,
    item_id                         integer,
    item_name                       text,
    unit_id                         integer,
    unit_name                       text,
    ordered                         integer,
    delivered                       integer,
    remaining                       integer
)
AS
$$
BEGIN

    DROP TABLE IF EXISTS temp_info;
    CREATE TEMPORARY TABLE temp_info
    (
        row_number                      SERIAL,
        item_id                         integer,
        item_name                       text,
        unit_id                         integer,
        unit_name                       text,
        ordered                         integer,
        delivered                       integer,
        remaining                       integer
    ) ON COMMIT DROP;

    INSERT INTO temp_info(item_id, unit_id, ordered)
    SELECT 
        transactions.non_gl_stock_details.item_id,
        transactions.non_gl_stock_details.base_unit_id, 
        transactions.non_gl_stock_details.quantity
    FROM transactions.non_gl_stock_details
    WHERE non_gl_stock_master_id = _sales_order_id;

    UPDATE temp_info
    SET 
        delivered = transactions.stock_details.base_quantity
    FROM transactions.stock_details
    WHERE transactions.stock_details.stock_master_id = _sales_id
    AND transactions.stock_details.item_id = temp_info.item_id;

    UPDATE temp_info
    SET
        remaining   = COALESCE(temp_info.ordered, 0) - COALESCE(temp_info.delivered, 0),
        unit_name   = core.get_unit_name_by_unit_id(temp_info.unit_id),
        item_name   = core.get_item_name_by_item_id(temp_info.item_id);


    RETURN QUERY
    SELECT * FROM temp_info
    ORDER BY 1;
END
$$
LANGUAGE plpgsql;

--SELECT * FROM transactions.get_order_summary_info(82, 93);
