DROP VIEW IF EXISTS core.frequency_setup_scrud_view;

CREATE VIEW core.frequency_setup_scrud_view
AS
SELECT 
    frequency_setup_id,
    frequency_setup_code,
    fiscal_year_code,
    value_date,
    core.get_frequency_code_by_frequency_id(frequency_id) AS frequency_code
FROM core.frequency_setups;
