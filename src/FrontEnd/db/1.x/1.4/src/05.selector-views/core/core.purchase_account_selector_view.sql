DROP VIEW IF EXISTS core.purchase_account_selector_view;

CREATE VIEW core.purchase_account_selector_view
AS
SELECT * FROM core.account_scrud_view
WHERE account_master_id = 15010
ORDER BY account_id;