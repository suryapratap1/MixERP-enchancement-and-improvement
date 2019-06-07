DROP FUNCTION IF EXISTS core.add_custom_field_form
(
    _form_name              national character varying(100),
    _table_name             national character varying(100),
    _key_name               national character varying(100)
);

CREATE FUNCTION core.add_custom_field_form
(
    _form_name              national character varying(100),
    _table_name             national character varying(100),
    _key_name               national character varying(100)
)
RETURNS void
AS
$$
BEGIN
    IF NOT EXISTS
    (
        SELECT * FROM core.custom_field_forms
        WHERE form_name = _form_name
    ) THEN
        INSERT INTO core.custom_field_forms(form_name, table_name, key_name)
        SELECT _form_name, _table_name, _key_name;

        RETURN;
    END IF;

    UPDATE core.custom_field_forms
    SET
        table_name = _table_name,
        key_name = _key_name
    WHERE
        form_name = _form_name;
        
END
$$
LANGUAGE plpgsql;