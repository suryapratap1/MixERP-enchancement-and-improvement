DROP VIEW IF EXISTS core.flag_view;

CREATE VIEW core.flag_view
AS
SELECT
    core.flags.flag_id,
    core.flags.user_id,
    core.flags.flag_type_id,
    core.flags.resource_id,
    core.flags.resource,
    core.flags.resource_key,
    core.flags.flagged_on,
    core.flag_types.flag_type_name,
    core.flag_types.background_color,
    core.flag_types.foreground_color
FROM core.flags
INNER JOIN core.flag_types
ON core.flags.flag_type_id = core.flag_types.flag_type_id;