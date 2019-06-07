DROP VIEW IF EXISTS config.scrud_factory_scrud_view;

CREATE VIEW config.scrud_factory_scrud_view
AS
SELECT 
	key,
	value	
FROM
config.scrud_factory;
