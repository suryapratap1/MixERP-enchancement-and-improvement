DROP FUNCTION IF EXISTS core.get_custom_field_form_name
(
    _table_name character varying
);

CREATE FUNCTION core.get_custom_field_form_name
(
    _table_name character varying
)
RETURNS character varying
STABLE
AS
$$
BEGIN
    RETURN form_name 
    FROM core.custom_field_forms
    WHERE table_name = _table_name;
END
$$
LANGUAGE plpgsql;