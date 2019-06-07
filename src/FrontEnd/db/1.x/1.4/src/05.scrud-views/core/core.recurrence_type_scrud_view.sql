DROP VIEW IF EXISTS core.recurrence_type_scrud_view;

CREATE VIEW core.recurrence_type_scrud_view
AS
SELECT
core.recurrence_types.recurrence_type_id,
core.recurrence_types.recurrence_type_code,
core.recurrence_types.recurrence_type_name,
core.recurrence_types.is_frequency

FROM
core.recurrence_types;