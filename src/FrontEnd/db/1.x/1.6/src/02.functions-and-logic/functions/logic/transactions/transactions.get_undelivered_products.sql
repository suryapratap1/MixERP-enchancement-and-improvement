DROP FUNCTION IF EXISTS transactions.get_undelivered_products(_office_id integer, _party_id bigint, _store_id integer);

CREATE FUNCTION transactions.get_undelivered_products(_office_id integer, _party_id bigint, _store_id integer)
RETURNS TABLE
(
    item_id                     integer,
    item_code                   text,
    item_name                   text,
    total_ordered_in_base_unit  integer,
    total_sold_in_base_unit     integer,
    quantity                    integer,
    unit_id                     integer,
    unit_name                   text,
    price                       numeric(30, 6),
    sales_tax_id                integer,
    sales_tax_code              text,
    tax                         numeric(30, 6)
)
AS
$$
    DECLARE _value_date             date        = transactions.get_value_date(_office_id);
    DECLARE _party_type_id          integer     = core.get_party_type_id_by_party_id(_party_id);
    DECLARE _price_type_id          integer;
    DECLARE _sales_tax_id           integer;
    DECLARE _party_code             text        = core.get_party_code_by_party_id(_party_id);
BEGIN
    DROP TABLE IF EXISTS temp_order_info;
    CREATE TEMPORARY TABLE temp_order_info
    (
        item_id                     integer,
        item_code                   text,
        item_name                   text,
        total_ordered_in_base_unit  integer,
        total_sold_in_base_unit     integer,
        quantity                    integer,
        unit_id                     integer,
        unit_name                   text,
        price                       numeric(30, 6),
        sales_tax_id                integer,
        sales_tax_code              text,
        tax                         numeric(30, 6)
    ) ON COMMIT DROP;

    
    SELECT
        transactions.stock_transaction_view.price_type_id
    INTO
        _price_type_id
    FROM transactions.stock_transaction_view
    WHERE transactions.stock_transaction_view.verification_status_id > 0
    AND transactions.stock_transaction_view.tran_type = 'Cr'
    AND transactions.stock_transaction_view.office_id = _office_id
    AND transactions.stock_transaction_view.party_id = _party_id
    GROUP BY transactions.stock_transaction_view.price_type_id
    ORDER BY COUNT(transactions.stock_transaction_view.price_type_id) DESC
    LIMIT 1;

    IF(_price_type_id IS NULL) THEN
        SELECT core.price_types.price_type_id 
        INTO _price_type_id 
        FROM core.price_types
        ORDER BY price_type_id
        LIMIT 1;
    END IF;
    
    SELECT
        transactions.stock_transaction_view.sales_tax_id
    INTO
        _sales_tax_id
    FROM transactions.stock_transaction_view
    WHERE transactions.stock_transaction_view.verification_status_id > 0 
    AND transactions.stock_transaction_view.tran_type = 'Cr'
    AND transactions.stock_transaction_view.office_id = _office_id
    AND transactions.stock_transaction_view.party_id = _party_id
    GROUP BY transactions.stock_transaction_view.sales_tax_id
    ORDER BY COUNT(transactions.stock_transaction_view.sales_tax_id) DESC
    LIMIT 1;


    IF(_sales_tax_id IS NULL) THEN
        SELECT core.sales_taxes.sales_tax_id 
        INTO _sales_tax_id
        FROM core.sales_taxes
        ORDER BY sales_tax_id
        LIMIT 1;
    END IF;
    

    INSERT INTO temp_order_info(item_id, total_ordered_in_base_unit)
    SELECT
        transactions.non_gl_stock_details.item_id,
        SUM(transactions.non_gl_stock_details.base_quantity)
    FROM transactions.non_gl_stock_master
    INNER JOIN transactions.non_gl_stock_details
    ON transactions.non_gl_stock_details.non_gl_stock_master_id = transactions.non_gl_stock_master.non_gl_stock_master_id
    WHERE transactions.non_gl_stock_master.party_id = _party_id
    AND transactions.non_gl_stock_master.office_id = _office_id
    AND transactions.non_gl_stock_master.book = 'Sales.Order'
    GROUP BY transactions.non_gl_stock_details.item_id;

    WITH sales_summary
    AS
    (
        SELECT
            transactions.stock_transaction_view.item_id,
            SUM(transactions.stock_transaction_view.base_quantity) AS total_sold
        FROM transactions.stock_transaction_view
        WHERE transactions.stock_transaction_view.verification_status_id > 0 
        AND transactions.stock_transaction_view.party_id = _party_id
        AND transactions.stock_transaction_view.office_id = _office_id
        AND transactions.stock_transaction_view.tran_type = 'Cr' --Sales
        AND transactions.stock_transaction_view.item_id IN
        (
            SELECT temp_order_info.item_id
            FROM temp_order_info
        )
        GROUP BY transactions.stock_transaction_view.item_id
    )

    UPDATE temp_order_info
    SET 
        total_sold_in_base_unit = sales_summary.total_sold
    FROM sales_summary
    WHERE sales_summary.item_id = temp_order_info.item_id;

    UPDATE temp_order_info
    SET
        quantity        = COALESCE(temp_order_info.total_ordered_in_base_unit, 0) - COALESCE(temp_order_info.total_sold_in_base_unit, 0);

    DELETE FROM temp_order_info
    WHERE temp_order_info.quantity <= 0;
    
    UPDATE temp_order_info
    SET
        item_code       = core.get_item_code_by_item_id(temp_order_info.item_id),
        item_name       = core.get_item_name_by_item_id(temp_order_info.item_id),
        unit_id         = core.get_root_unit_id(core.get_unit_id_by_item_id(temp_order_info.item_id));

    UPDATE temp_order_info
    SET
        price           = core.get_item_selling_price(temp_order_info.item_id, _party_type_id, _price_type_id, temp_order_info.unit_id),
        unit_name       = core.get_unit_name_by_unit_id(temp_order_info.unit_id),
        sales_tax_id    = _sales_tax_id,
        sales_tax_code  = core.get_sales_tax_code_by_sales_tax_id(_sales_tax_id);

    UPDATE temp_order_info
    SET tax =   (
                    SELECT COALESCE(SUM(result.tax), 0) 
                    FROM transactions.get_sales_tax('Sales', _store_id, _party_code, '', _price_type_id, temp_order_info.item_code, temp_order_info.price, temp_order_info.quantity, 0, 0, temp_order_info.sales_tax_id) AS result
                );
    
    RETURN QUERY
    SELECT * FROM temp_order_info;
END
$$
LANGUAGE plpgsql;


--SELECT * FROM transactions.get_undelivered_products(3, 1, 1);