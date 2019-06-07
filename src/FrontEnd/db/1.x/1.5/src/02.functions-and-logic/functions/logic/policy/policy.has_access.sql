DROP FUNCTION IF EXISTS policy.has_access(_user_id integer, _entity text, _access_type_id integer);

CREATE FUNCTION policy.has_access(_user_id integer, _entity text, _access_type_id integer)
RETURNS boolean
AS
$$
    DECLARE _role_id                    integer;
    DECLARE _group_policy               boolean = NULL;
    DECLARE _user_policy                boolean = NULL;
    DECLARE _policy                     boolean = true;
BEGIN
    SELECT role_id INTO _role_id FROM office.users WHERE user_id = _user_id;

    --GROUP POLICY BASED ON ALL ENTITIES AND ALL ACCESS TYPES
    IF EXISTS
    (
        SELECT * FROM policy.default_entity_access
        WHERE role_id = _role_id
        AND NOT allow_access
        AND access_type_id IS NULL
        AND COALESCE(entity_name, '') = ''
    ) THEN
        _group_policy = false;
    END IF;

    --GROUP POLICY BASED ON ALL ENTITIES AND SPECIFIED ACCESS TYPE
    IF EXISTS
    (
        SELECT * FROM policy.default_entity_access
        WHERE role_id = _role_id
        AND NOT allow_access
        AND access_type_id = _access_type_id
        AND COALESCE(entity_name, '') = ''
    ) THEN
        _group_policy = false;
    END IF;
 

    --GROUP POLICY BASED ON SPECIFIED ENTITY AND ALL ACCESS TYPES
    IF EXISTS
    (
        SELECT * FROM policy.default_entity_access
        WHERE role_id = _role_id
        AND NOT allow_access
        AND access_type_id IS NULL
        AND entity_name = _entity
    ) THEN
        _group_policy = false;
    END IF;

    --GROUP POLICY BASED ON SPECIFIED ENTITY AND SPECIFIED ACCESS TYPE
    IF EXISTS
    (
        SELECT * FROM policy.default_entity_access
        WHERE role_id = _role_id
        AND NOT allow_access
        AND access_type_id = _access_type_id
        AND entity_name = _entity
    ) THEN
        _group_policy = false;
    END IF;


    --USER POLICY BASED ON ALL ENTITIES AND ALL ACCESS TYPES
    SELECT allow_access INTO _user_policy FROM policy.entity_access
    WHERE user_id = _user_id
    AND access_type_id IS NULL
    AND COALESCE(entity_name, '') = '';

    --USER POLICY BASED ON SPECIFIED ENTITY AND ALL ACCESS TYPES
    IF(_user_policy IS NULL) THEN
        SELECT allow_access INTO _user_policy 
        FROM policy.entity_access
        WHERE user_id = _user_id
        AND access_type_id IS NULL
        AND entity_name = _entity;
    END IF;
 
    --USER POLICY BASED ON ALL ENTITIES AND SPECIFIED ACCESS TYPE
    IF(_user_policy IS NULL) THEN
        SELECT allow_access INTO _user_policy FROM policy.entity_access
        WHERE user_id = _user_id
        AND access_type_id = _access_type_id
        AND COALESCE(entity_name, '') = '';
    END IF;
 

    --USER POLICY BASED ON SPECIFIED ENTITY AND SPECIFIED ACCESS TYPE
    IF(_user_policy IS NULL) THEN
        SELECT allow_access INTO _user_policy FROM policy.entity_access
        WHERE user_id = _user_id
        AND access_type_id = _access_type_id
        AND entity_name = _entity;
    END IF;

    IF(_group_policy IS NOT NULL) THEN
        _policy := _group_policy;
    END IF;

    IF(_user_policy IS NOT NULL) THEN
        _policy := _user_policy;
    END IF;

    RETURN _policy;
END
$$
LANGUAGE plpgsql;