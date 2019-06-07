DROP VIEW IF EXISTS core.merchant_fee_setup_scrud_view CASCADE;

CREATE VIEW core.merchant_fee_setup_scrud_view
AS
SELECT 
core.merchant_fee_setup.merchant_fee_setup_id,
core.bank_accounts.bank_name || ' (' || core.bank_accounts.bank_account_number || ')' AS merchant_account,
core.payment_cards.payment_card_code || ' ( '|| core.payment_cards.payment_card_name || ')' AS payment_card,
core.merchant_fee_setup.rate,
core.merchant_fee_setup.customer_pays_fee,
core.accounts.account_number || ' (' || core.accounts.account_name || ')' As account,
core.merchant_fee_setup.statement_reference
FROM
core.merchant_fee_setup
INNER JOIN 
core.bank_accounts
ON core.merchant_fee_setup.merchant_account_id = core.bank_accounts.account_id
INNER JOIN
core.payment_cards
ON core.merchant_fee_setup.payment_card_id = core.payment_cards.payment_card_id
INNER JOIN
core.accounts
ON core.merchant_fee_setup.account_id = core.accounts.account_id;