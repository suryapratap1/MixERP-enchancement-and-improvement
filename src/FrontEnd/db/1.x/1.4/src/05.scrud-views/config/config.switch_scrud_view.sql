DROP VIEW IF EXISTS config.switch_scrud_view;

CREATE VIEW config.switch_scrud_view
AS
SELECT 
	key,
	value	
FROM
config.switches;
