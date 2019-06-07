DROP VIEW IF EXISTS config.db_parameter_scrud_view;

CREATE VIEW config.db_parameter_scrud_view
AS
SELECT 
	key,
	value
FROM
config.db_parameters;
