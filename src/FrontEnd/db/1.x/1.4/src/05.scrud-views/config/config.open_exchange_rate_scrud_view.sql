DROP VIEW IF EXISTS config.open_exchange_rate_scrud_view;

CREATE VIEW config.open_exchange_rate_scrud_view
AS
SELECT 
	key,
	value,
	description
FROM
config.open_exchange_rates;
