DROP VIEW IF EXISTS core.late_fee_scrud_view;

CREATE VIEW core.late_fee_scrud_view
AS
SELECT 
  core.late_fee.late_fee_id, 
  core.late_fee.late_fee_code, 
  core.late_fee.late_fee_name, 
  core.late_fee.is_flat_amount, 
  core.late_fee.rate,
  core.accounts.account_number || ' (' || core.accounts.account_name || ')' AS account
FROM 
core.late_fee
INNER JOIN core.accounts
ON core.late_fee.account_id = core.accounts.account_id;

