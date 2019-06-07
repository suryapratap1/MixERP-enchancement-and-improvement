DROP VIEW IF EXISTS transactions.sales_order_view;

CREATE VIEW transactions.sales_order_view
AS
SELECT
transactions.non_gl_stock_master.non_gl_stock_master_id,
transactions.non_gl_stock_master.non_gl_stock_master_id AS tran_id,
transactions.non_gl_stock_master.transaction_ts,
transactions.non_gl_stock_master.value_date,
core.get_quotation_valid_duration(transactions.non_gl_stock_master.office_id) AS quotation_valid_duration,
office.users.user_name AS entered_by,
office.offices.office_name,
transactions.non_gl_stock_master.statement_reference,
core.parties.party_name AS customer_name,
core.price_types.price_type_name
FROM transactions.non_gl_stock_master
INNER JOIN office.offices
ON transactions.non_gl_stock_master.office_id = office.offices.office_id
INNER JOIN office.users
ON transactions.non_gl_stock_master.user_id = office.users.user_id
INNER JOIN core.parties
ON transactions.non_gl_stock_master.party_id = core.parties.party_id
INNER JOIN core.price_types
ON transactions.non_gl_stock_master.price_type_id = core.price_types.price_type_id
WHERE transactions.non_gl_stock_master.book = 'Sales.Order';