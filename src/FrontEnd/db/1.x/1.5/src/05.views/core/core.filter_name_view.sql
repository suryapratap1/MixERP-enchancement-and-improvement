DROP VIEW IF EXISTS core.filter_name_view;

CREATE VIEW core.filter_name_view
AS
SELECT
    DISTINCT
    object_name,
    filter_name,
    is_default
FROM core.filters;