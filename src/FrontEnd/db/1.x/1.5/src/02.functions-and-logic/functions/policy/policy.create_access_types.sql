DROP FUNCTION IF EXISTS policy.create_access_types(_access_type_id integer, _access_type_name national character varying(48));

CREATE FUNCTION policy.create_access_types(_access_type_id integer, _access_type_name national character varying(48))
RETURNS void
AS
$$
BEGIN
    IF EXISTS
    (
        SELECT 1 FROM policy.access_types
        WHERE access_type_id = _access_type_id
    ) THEN
        UPDATE policy.access_types
        SET access_type_name = _access_type_name
        WHERE access_type_id = _access_type_id;

        RETURN;
    END IF;

    INSERT INTO policy.access_types(access_type_id, access_type_name)
    SELECT _access_type_id, _access_type_name;
END
$$
LANGUAGE plpgsql;