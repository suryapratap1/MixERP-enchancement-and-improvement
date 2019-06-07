DROP VIEW IF EXISTS config.mixerp_scrud_view;

CREATE VIEW config.mixerp_scrud_view
AS
SELECT 
	key,
	value,
	description
FROM
config.mixerp;
