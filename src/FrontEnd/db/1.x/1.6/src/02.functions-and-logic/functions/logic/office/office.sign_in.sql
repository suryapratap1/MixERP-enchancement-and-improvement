DROP FUNCTION IF EXISTS office.sign_in
(
    office_id       public.integer_strict, 
    user_name       text, 
    password        text, 
    browser         text, 
    ip_address      text, 
    remote_user     text, 
    culture         text, 
    challenge       text
);

DROP FUNCTION IF EXISTS office.sign_in
(
    office_id       public.integer_strict, 
    user_name       text, 
    password        text, 
    browser         text, 
    ip_address      text, 
    remote_user     text, 
    culture         text
);

CREATE FUNCTION office.sign_in
(
    office_id       public.integer_strict, 
    user_name       text, 
    password        text, 
    browser         text, 
    ip_address      text, 
    remote_user     text, 
    culture         text
)
RETURNS TABLE
(
    login_id        bigint,
    message         text
)
AS
$$
    DECLARE _user_id            integer;
    DECLARE _lock_out_till      TIMESTAMP WITH TIME ZONE;
    DECLARE result              boolean;
    DECLARE _login_id           bigint = 0;
    DECLARE _message            text;
BEGIN
    _user_id        :=office.get_user_id_by_user_name($2);
    
    IF _user_id IS NULL THEN
        INSERT INTO audit.failed_logins(user_name,browser,ip_address,remote_user,details)
        SELECT $2, $4, $5, $6, 'Invalid user name.';
        _message := 'Invalid login attempt.';
    ELSE
        _lock_out_till:=policy.is_locked_out_till(_user_id);


        IF NOT ((_lock_out_till IS NOT NULL) AND (_lock_out_till>NOW())) THEN
            IF(office.validate_login(user_name, password)) THEN

                SELECT * FROM office.can_login(_user_id,$1) 
                INTO result, _message;

                IF(result) THEN
                    INSERT INTO audit.logins(office_id,user_id,browser,ip_address,remote_user, culture)
                    SELECT $1, _user_id, $4, $5, $6, $7;

                    _login_id := currval('audit.logins_login_id_seq')::bigint;
                ELSE
                    IF(COALESCE(_message, '') = '') THEN
                        _message := format('A user from %1$s cannot login to %2$s.', office.get_office_name_by_id(office.get_office_id_by_user_id(_user_id)), office.get_office_name_by_id($1));
                    END IF;

                    INSERT INTO audit.failed_logins(office_id,user_id,user_name,browser,ip_address,remote_user,details)
                    SELECT $1, _user_id, $2, $4, $5, $6, _message;
                END IF;
            ELSE
                IF(COALESCE(_message, '') = '') THEN
                    _message := 'Invalid login attempt.';
                END IF;
                
                INSERT INTO audit.failed_logins(office_id,user_id,user_name,browser,ip_address,remote_user,details)
                SELECT $1, _user_id, $2, $4, $5, $6, _message;
            END IF;
        ELSE
             _message        := format('You are locked out till %1$s.', _lock_out_till);

            INSERT INTO audit.failed_logins(office_id,user_id,user_name,browser,ip_address,remote_user,details)
            SELECT $1, _user_id, $2, $4, $5, $6, _message;
        END IF;
    END IF;

    RETURN QUERY
    SELECT _login_id, _message;
END
$$
LANGUAGE plpgsql;
