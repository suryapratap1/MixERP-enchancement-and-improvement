DROP VIEW IF EXISTS core.recurring_invoice_setup_scrud_view;

CREATE VIEW core.recurring_invoice_setup_scrud_view
AS
SELECT 
  core.recurring_invoice_setup.recurring_invoice_setup_id, 
  core.recurring_invoices.recurring_invoice_code || ' (' || core.recurring_invoices.recurring_invoice_name || ')' AS recurring_invoice,
  core.parties.party_code || ' (' || core.parties.party_name || ')' AS party,
  core.recurring_invoice_setup.starts_from,
  core.recurring_invoice_setup.ends_on, 
  core.recurrence_types.recurrence_type_code || ' (' || core.recurrence_types.recurrence_type_name || ')' AS recurrence_type,
  core.frequencies.frequency_code || ' (' || core.frequencies.frequency_name ||')' AS recurring_frequency,
  core.recurring_invoice_setup.recurring_duration,
  core.recurring_invoice_setup.recurs_on_same_calendar_date,
  core.recurring_invoice_setup.recurring_amount,
  core.accounts.account_number || ' (' || core.accounts.account_name || ')' AS account,
  core.payment_terms.payment_term_code || ' (' || core.payment_terms.payment_term_name || ')' AS payment_term, 
  core.recurring_invoice_setup.is_active,
  core.recurring_invoice_setup.statement_reference 
FROM 
core.recurring_invoice_setup
INNER JOIN core.recurring_invoices
ON core.recurring_invoice_setup.recurring_invoice_id = core.recurring_invoices.recurring_invoice_id
INNER JOIN core.parties 
ON core.recurring_invoice_setup.party_id = core.parties.party_id
INNER JOIN core.recurrence_types
ON core.recurring_invoice_setup.recurrence_type_id = core.recurrence_types.recurrence_type_id 
LEFT JOIN core.frequencies
ON core.recurring_invoice_setup.recurring_frequency_id = core.frequencies.frequency_id
INNER JOIN core.accounts
ON core.recurring_invoice_setup.account_id = core.accounts.account_id
INNER JOIN core.payment_terms 
ON core.recurring_invoice_setup.payment_term_id = core.payment_terms.payment_term_id;
