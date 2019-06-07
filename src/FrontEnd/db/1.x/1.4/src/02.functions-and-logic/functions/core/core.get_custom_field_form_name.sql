DROP FUNCTION IF EXISTS core.get_custom_field_form_name
(
    _schema_name national character varying(100), 
    _table_name national character varying(100)
);

CREATE FUNCTION core.get_custom_field_form_name
(
    _schema_name national character varying(100), 
    _table_name national character varying(100)
)
RETURNS national character varying(100)
AS
$$
BEGIN
    RETURN form_name 
    FROM core.custom_field_forms
    WHERE table_name = _schema_name || '.' || _table_name;
END
$$
LANGUAGE plpgsql;
