DROP VIEW IF EXISTS core.sales_return_account_selector_view;

CREATE VIEW core.sales_return_account_selector_view
AS
SELECT * FROM core.account_scrud_view
--Current Liabilities, Accounts Payable
WHERE account_master_id = ANY(ARRAY[15000, 15010])
ORDER BY account_id;