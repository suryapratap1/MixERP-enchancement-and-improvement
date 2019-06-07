DROP FUNCTION IF EXISTS transactions.get_merge_model(_tran_ids bigint[], _book text);

CREATE FUNCTION transactions.get_merge_model(_tran_ids bigint[], _book text)
RETURNS TABLE
(
    value_date                      date,
    party_id                        bigint,
    party_code                      national character varying(12),
    price_type_id                   integer,
    reference_number                national character varying(24),
    item_code                       national character varying(12),
    item_name                       national character varying(150),
    quantity                        integer,
    unit_name                       national character varying(50),
    price                           public.money_strict,
    discount                        public.money_strict2,
    shipping_charge                 public.money_strict2,
    tax_code                        national character varying,
    tax                             public.money_strict2,
    non_taxable                     boolean,
    salesperson_id                  integer,
    shipper_id                      integer,
    store_id                        integer,
    shipping_addresss_code          text,
    statement_reference             text
)
STABLE AS
$$
BEGIN
    IF
    (
        (
            SELECT 
                COUNT(DISTINCT transactions.non_gl_stock_master.party_id) 
            FROM 
            transactions.non_gl_stock_master 
            WHERE non_gl_stock_master_id = ANY(_tran_ids)
        ) > 1
    )THEN
        RAISE EXCEPTION 'Cannot merge transactions of different parties into a single batch. Please try again.'
        USING ERRCODE = 'P4021';
    END IF;

    IF(transactions.are_sales_quotations_already_merged(VARIADIC _tran_ids)) THEN
        RAISE EXCEPTION 'The selected transactions contain items which have already been merged. Please try again.'
        USING ERRCODE = 'P4022';
    END IF;

    IF(transactions.are_sales_orders_already_merged(VARIADIC _tran_ids)) THEN
        RAISE EXCEPTION 'The selected transactions contain items which have already been merged. Please try again.'
        USING ERRCODE = 'P4022';
    END IF;

    IF(transactions.contains_incompatible_taxes(VARIADIC _tran_ids)) THEN
        RAISE EXCEPTION 'Cannot merge transactions having incompatible tax types. Please try again.'
        USING ERRCODE = 'P4023';
    END IF;

    
    RETURN QUERY
    SELECT
        transactions.non_gl_stock_master.value_date,
        transactions.non_gl_stock_master.party_id,
        core.parties.party_code,
        transactions.non_gl_stock_master.price_type_id,
        transactions.non_gl_stock_master.reference_number,
        core.items.item_code,
        core.items.item_name,
        transactions.non_gl_stock_details.quantity,
        core.units.unit_name,
        transactions.non_gl_stock_details.price,
        transactions.non_gl_stock_details.discount,
        transactions.non_gl_stock_details.shipping_charge,
        core.get_sales_tax_code_by_sales_tax_id(transactions.non_gl_stock_details.sales_tax_id) as tax_code,
        transactions.non_gl_stock_details.tax,
        transactions.non_gl_stock_master.non_taxable,
        transactions.non_gl_stock_master.salesperson_id,
        transactions.non_gl_stock_master.shipper_id,
        transactions.non_gl_stock_master.store_id,
        core.get_shipping_address_code_by_shipping_address_id(transactions.non_gl_stock_master.store_id) AS shipping_address_code,
        transactions.non_gl_stock_master.statement_reference
    FROM
    transactions.non_gl_stock_master
    INNER JOIN
    transactions.non_gl_stock_details
    ON transactions.non_gl_stock_master.non_gl_stock_master_id = transactions.non_gl_stock_details.non_gl_stock_master_id
    INNER JOIN core.items
    ON transactions.non_gl_stock_details.item_id = core.items.item_id
    INNER JOIN core.units
    ON transactions.non_gl_stock_details.unit_id = core.units.unit_id
    INNER JOIN core.parties
    ON transactions.non_gl_stock_master.party_id = core.parties.party_id
    WHERE transactions.non_gl_stock_master.book = _book
    AND transactions.non_gl_stock_master.non_gl_stock_master_id = ANY(_tran_ids);    
END
$$
LANGUAGE plpgsql;


--SELECT * FROM transactions.get_merge_model('{82}', 'Sales.Order');