DROP FUNCTION IF EXISTS core.create_new_fiscal_year
(
    _office_id                          integer,
    _user_id                            integer,
    _fiscal_year_code                   national character varying(12),
    _fiscal_year_name                   national character varying(50)
);

CREATE FUNCTION core.create_new_fiscal_year
(
    _office_id                          integer,
    _user_id                            integer,
    _fiscal_year_code                   national character varying(12),
    _fiscal_year_name                   national character varying(50)
)
RETURNS void
AS
$$
    DECLARE _value_date                 date;
    DECLARE _eoy_date                   date;
    DECLARE _current_fiscal_year_code   national character varying(12);
BEGIN
    _current_fiscal_year_code   := core.get_current_fiscal_year_code(_office_id);
    _value_date                 := core.get_date(_office_id);
    _eoy_date                   := core.get_fiscal_year_end_date(_office_id);

    IF(_value_date <> _eoy_date) THEN
        RAISE EXCEPTION 'Access is denied.'
        USING ERRCODE='P9001';
    END IF;

    IF EXISTS
    (
        SELECT 1
        FROM core.fiscal_year
        WHERE ends_on > _eoy_date
    ) THEN
        --One of the other branch offices had already created a new fiscal year.
        RETURN;
    END IF;

    INSERT INTO core.fiscal_year(fiscal_year_code, fiscal_year_name, starts_from, ends_on, audit_user_id)
    SELECT 
        _fiscal_year_code, 
        _fiscal_year_name, 
        starts_from + interval '1 year', 
        ends_on + interval '1 year',
        _user_id
    FROM core.fiscal_year
    WHERE fiscal_year_code = _current_fiscal_year_code;

    INSERT INTO core.frequency_setups(fiscal_year_code, frequency_setup_code, value_date, frequency_id, audit_user_id)
    SELECT 
        _fiscal_year_code, 
        frequency_setup_code, 
        value_date + interval '1 year',
        frequency_id,
        _user_id
    FROM core.frequency_setups
    WHERE fiscal_year_code = _current_fiscal_year_code;
END
$$
LANGUAGE plpgsql;