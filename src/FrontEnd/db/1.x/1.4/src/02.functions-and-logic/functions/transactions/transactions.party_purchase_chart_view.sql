DROP VIEW IF EXISTS transactions.party_purchase_chart_view;

CREATE VIEW transactions.party_purchase_chart_view
AS
SELECT
    NULL::bigint AS row_number,
    transactions.transaction_master.transaction_master_id,
    transactions.stock_master.party_id,
    transactions.transaction_master.book, 
    transactions.transaction_master.value_date, 
    SUM(transactions.stock_details.price * transactions.stock_details.quantity + tax - discount)::decimal(24, 4) AS amount
FROM transactions.stock_details 
INNER JOIN transactions.stock_master
ON transactions.stock_master.stock_master_id = transactions.stock_details.stock_master_id
INNER JOIN transactions.transaction_master
ON transactions.transaction_master.transaction_master_id = transactions.stock_master.transaction_master_id
WHERE transactions.transaction_master.verification_status_id > 0
AND book like 'Purchase%'
GROUP BY
    transactions.stock_master.party_id,
    transactions.transaction_master.book, 
    transactions.transaction_master.value_date, 
    transactions.transaction_master.transaction_master_id;