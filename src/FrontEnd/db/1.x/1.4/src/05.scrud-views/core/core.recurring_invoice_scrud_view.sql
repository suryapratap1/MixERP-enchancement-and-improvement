DROP VIEW IF EXISTS core.recurring_invoice_scrud_view;

CREATE VIEW core.recurring_invoice_scrud_view
AS
SELECT 
  core.recurring_invoices.recurring_invoice_id, 
  core.recurring_invoices.recurring_invoice_code, 
  core.recurring_invoices.recurring_invoice_name,
  core.items.item_code || ' (' || core.items.item_name || ')' AS item,
  core.recurring_invoices.total_duration,
  core.recurrence_types.recurrence_type_code || ' (' || core.recurrence_types.recurrence_type_name || ')' AS recurrence_type,
  core.frequencies.frequency_code || ' (' || core.frequencies.frequency_name ||')' AS recurring_frequency,
  core.recurring_invoices.recurring_duration,
  core.recurring_invoices.recurs_on_same_calendar_date,
  core.recurring_invoices.recurring_amount,
  core.accounts.account_number || ' (' || core.accounts.account_name || ')' AS account,
  core.payment_terms.payment_term_code || ' (' || core.payment_terms.payment_term_name || ')' AS payment_term, 
  core.recurring_invoices.auto_trigger_on_sales,
  core.recurring_invoices.is_active,
  core.recurring_invoices.statement_reference 
FROM 
core.recurring_invoices
LEFT JOIN core.items 
ON core.recurring_invoices.item_id = core.items.item_id
INNER JOIN core.recurrence_types
ON core.recurring_invoices.recurrence_type_id = core.recurrence_types.recurrence_type_id 
LEFT JOIN core.frequencies
ON core.recurring_invoices.recurring_frequency_id = core.frequencies.frequency_id
INNER JOIN core.accounts
ON core.recurring_invoices.account_id = core.accounts.account_id
INNER JOIN core.payment_terms
ON core.recurring_invoices.payment_term_id = core.payment_terms.payment_term_id;


