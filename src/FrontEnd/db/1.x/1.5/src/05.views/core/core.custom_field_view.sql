DROP VIEW IF EXISTS core.custom_field_view;

CREATE VIEW core.custom_field_view
AS
SELECT
    core.custom_field_forms.table_name,
    core.custom_field_forms.key_name,
    core.custom_field_setup.custom_field_setup_id,
    core.custom_field_setup.form_name,
    core.custom_field_setup.field_order,
    core.custom_field_setup.field_name,
    core.custom_field_setup.field_label,
    core.custom_field_setup.description,
    core.custom_field_data_types.data_type,
    core.custom_field_data_types.is_number,
    core.custom_field_data_types.is_date,
    core.custom_field_data_types.is_boolean,
    core.custom_field_data_types.is_long_text,
    core.custom_fields.resource_id,
    core.custom_fields.value
FROM core.custom_field_setup
INNER JOIN core.custom_field_data_types
ON core.custom_field_data_types.data_type = core.custom_field_setup.data_type
INNER JOIN core.custom_field_forms
ON core.custom_field_forms.form_name = core.custom_field_setup.form_name
INNER JOIN core.custom_fields
ON core.custom_fields.custom_field_setup_id = core.custom_field_setup.custom_field_setup_id
ORDER BY field_order;
