DROP VIEW IF EXISTS core.default_widget_setup_view;

CREATE VIEW core.default_widget_setup_view
AS
SELECT
    core.widget_setup.widget_setup_id,
    core.widget_setup.widget_order,
    core.widget_setup.widget_group_name,
    core.widget_setup.widget_name,
    core.widgets.widget_source
FROM core.widget_setup
INNER JOIN core.widgets
ON core.widgets.widget_name = core.widget_setup.widget_name
WHERE widget_group_name =
(
    SELECT widget_group_name
    FROM core.widget_groups
    WHERE is_default
    LIMIT 1
);