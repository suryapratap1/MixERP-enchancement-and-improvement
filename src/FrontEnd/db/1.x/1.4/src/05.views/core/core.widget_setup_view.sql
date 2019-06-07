DROP VIEW IF EXISTS core.widget_setup_view;

CREATE OR REPLACE VIEW core.widget_setup_view
AS
SELECT
    core.widget_setup.widget_setup_id,
    core.widget_setup.widget_order,
    core.widget_setup.widget_group_name,
    core.widget_setup.widget_name,
    core.widgets.widget_source
FROM core.widget_setup
INNER JOIN core.widgets
ON core.widgets.widget_name = core.widget_setup.widget_name;