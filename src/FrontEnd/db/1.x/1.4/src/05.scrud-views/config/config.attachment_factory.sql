DROP VIEW IF EXISTS config.attachment_factory_scrud_view;

CREATE VIEW config.attachment_factory_scrud_view
AS
SELECT 
	key,
	value
FROM
config.attachment_factory;
