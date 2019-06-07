DROP FUNCTION IF EXISTS office.can_login(user_id public.integer_strict, office_id public.integer_strict, OUT result boolean, OUT message text);
DROP FUNCTION IF EXISTS office.can_login(user_id public.integer_strict, office_id public.integer_strict);

CREATE FUNCTION office.can_login(user_id public.integer_strict, office_id public.integer_strict)
RETURNS TABLE
(
    result              boolean,
    message             text
)
AS
$$
DECLARE _office_id      integer;
DECLARE _result         boolean;
DECLARE _message        text = '';
BEGIN
    _office_id  := office.get_office_id_by_user_id($1);

    IF $1 = office.get_sys_user_id() THEN
        _result = false;
    END IF;

    IF $2=_office_id THEN
        _result = true;
    ELSE
        IF office.is_parent_office(_office_id,$2) THEN
            _result = true;
        END IF;
    END IF;

    IF(_result) THEN
        IF(policy.is_restricted_mode() AND NOT policy.is_elevated_user($1)) THEN
            _result := false;
            _message := 'You need to have an elevated priviledge to login interactively during end of day operation';
            RAISE WARNING '%', _message;
        END IF;
    END IF;

    RETURN QUERY
    SELECT _result, _message;
END;
$$
LANGUAGE plpgsql;