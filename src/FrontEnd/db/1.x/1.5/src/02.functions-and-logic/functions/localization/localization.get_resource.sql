DROP FUNCTION IF EXISTS localization.get_resource(_culture_code text, _resource_class text, _key text);

CREATE FUNCTION localization.get_resource(_culture_code text, _resource_class text, _key text)
RETURNS text
STABLE
AS
$$
    DECLARE _resource_id    integer;
    DECLARE _resource       text;
    DECLARE _value          text;
BEGIN
    SELECT 
        resource_id,
        value
    INTO
        _resource_id,
        _resource
    FROM localization.resources
    WHERE resource_class = _resource_class
    AND key = _key;

    SELECT
        value
    INTO
        _value
    FROM localization.localized_resources
    WHERE culture_code = _culture_code
    AND resource_id = _resource_id;


    _resource := COALESCE(_value, _resource);
    
    RETURN _resource;
END
$$
LANGUAGE plpgsql;