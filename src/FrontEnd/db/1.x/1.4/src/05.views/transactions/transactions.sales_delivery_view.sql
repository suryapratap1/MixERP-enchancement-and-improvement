DROP VIEW IF EXISTS transactions.sales_delivery_view;

CREATE VIEW transactions.sales_delivery_view
AS
SELECT
    transactions.transaction_master.transaction_master_id AS tran_id,
    transactions.transaction_master.transaction_ts,
    transactions.transaction_master.value_date,
    office.users.user_name AS entered_by,
    core.verification_statuses.verification_status_name AS status,
    transactions.get_due_date(transactions.transaction_master.value_date, transactions.stock_master.payment_term_id) AS due_date,
    transactions.transaction_master.reference_number,
    transactions.transaction_master.statement_reference,
    core.parties.party_code AS customer_code,
    core.parties.party_name AS customer_name,
    core.parties.pan_number,
    core.parties.sst_number,
    core.parties.cst_number,
    office.stores.store_name,
    core.get_shipping_address_by_shipping_address_id(transactions.stock_master.shipping_address_id) AS shipping_address,
    core.shippers.shipper_name,
    transactions.stock_master.shipping_charge,
    transactions.get_invoice_amount(transactions.transaction_master.transaction_master_id) AS invoice_amount
FROM transactions.transaction_master
INNER JOIN transactions.stock_master
ON transactions.transaction_master.transaction_master_id=transactions.stock_master.transaction_master_id
INNER JOIN office.users
ON transactions.transaction_master.user_id = office.users.user_id
INNER JOIN core.verification_statuses
ON transactions.transaction_master.verification_status_id = core.verification_statuses.verification_status_id
INNER JOIN core.parties
ON transactions.stock_master.party_id=core.parties.party_id
LEFT JOIN core.shippers
ON transactions.stock_master.shipper_id = core.shippers.shipper_id
LEFT JOIN office.stores
ON transactions.stock_master.store_id = office.stores.store_id
WHERE transactions.transaction_master.book='Sales.Delivery'
AND transactions.transaction_master.verification_status_id > 0;


--SELECT * FROM transactions.sales_delivery_view;