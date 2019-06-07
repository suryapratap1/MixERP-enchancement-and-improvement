DROP VIEW IF EXISTS transactions.non_gl_stock_detail_view CASCADE;

CREATE VIEW transactions.non_gl_stock_detail_view
AS
SELECT
    transactions.non_gl_stock_details.non_gl_stock_detail_id,
    transactions.non_gl_stock_details.non_gl_stock_master_id,
    transactions.non_gl_stock_master.value_date,
    transactions.non_gl_stock_master.book,
    transactions.non_gl_stock_master.party_id,
    transactions.non_gl_stock_master.shipping_address_id,
    core.get_shipping_address_code_by_shipping_address_id(transactions.non_gl_stock_master.shipping_address_id) AS shipping_address_code,
    core.get_party_code_by_party_id(transactions.non_gl_stock_master.party_id) AS party_code,
    core.get_party_name_by_party_id(transactions.non_gl_stock_master.party_id) AS party_name,
    transactions.non_gl_stock_master.price_type_id,
    core.get_price_type_name_by_price_type_id(transactions.non_gl_stock_master.price_type_id) AS price_type_name,
    transactions.non_gl_stock_master.transaction_ts,
    transactions.non_gl_stock_master.non_taxable,
    transactions.non_gl_stock_master.user_id,
    office.get_user_name_by_user_id(transactions.non_gl_stock_master.user_id) AS user_name,
    transactions.non_gl_stock_master.reference_number,
    transactions.non_gl_stock_master.statement_reference,
    transactions.non_gl_stock_master.office_id,
    office.get_office_name_by_id(transactions.non_gl_stock_master.office_id) AS office_name,
    transactions.non_gl_stock_master.salesperson_id,
    core.get_salesperson_name_by_salesperson_id(transactions.non_gl_stock_master.salesperson_id) AS salesperson_name,
    transactions.non_gl_stock_master.shipper_id,
    core.get_shipper_name_by_shipper_id(transactions.non_gl_stock_master.shipper_id) AS shipper_name,
    transactions.non_gl_stock_master.store_id,
    office.get_store_name_by_store_id(transactions.non_gl_stock_master.store_id) AS store_name,    
    transactions.non_gl_stock_details.item_id,
    core.get_item_code_by_item_id(transactions.non_gl_stock_details.item_id) AS item_code,
    core.get_item_name_by_item_id(transactions.non_gl_stock_details.item_id) AS item_name,
    transactions.non_gl_stock_details.quantity,
    transactions.non_gl_stock_details.unit_id,
    core.get_unit_name_by_unit_id(transactions.non_gl_stock_details.unit_id) AS unit_name,
    transactions.non_gl_stock_details.base_quantity,
    transactions.non_gl_stock_details.base_unit_id,
    core.get_unit_name_by_unit_id(transactions.non_gl_stock_details.base_unit_id) AS base_unit_name,
    transactions.non_gl_stock_details.price,
    transactions.non_gl_stock_details.discount,
    transactions.non_gl_stock_details.shipping_charge,
    transactions.non_gl_stock_details.sales_tax_id,
    core.get_sales_tax_code_by_sales_tax_id(transactions.non_gl_stock_details.sales_tax_id) as tax_code,
    transactions.non_gl_stock_details.tax
FROM transactions.non_gl_stock_master
INNER JOIN transactions.non_gl_stock_details
ON transactions.non_gl_stock_master.non_gl_stock_master_id = transactions.non_gl_stock_details.non_gl_stock_master_id;
