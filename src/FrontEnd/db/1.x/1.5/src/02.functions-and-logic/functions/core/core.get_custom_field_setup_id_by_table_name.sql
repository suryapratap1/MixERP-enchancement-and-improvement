DROP FUNCTION IF EXISTS core.get_custom_field_setup_id_by_table_name
(
    _table_name character varying,
    _field_name character varying
);

CREATE FUNCTION core.get_custom_field_setup_id_by_table_name
(
    _table_name character varying,
    _field_name character varying
)
RETURNS integer 
STABLE
AS
$$
BEGIN
    RETURN custom_field_setup_id
    FROM core.custom_field_setup
    WHERE form_name = core.get_custom_field_form_name(_table_name)
    AND field_name = _field_name;
END
$$
LANGUAGE plpgsql;