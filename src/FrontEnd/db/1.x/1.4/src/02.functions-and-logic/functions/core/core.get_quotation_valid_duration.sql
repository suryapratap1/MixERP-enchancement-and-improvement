DROP FUNCTION IF EXISTS core.get_quotation_valid_duration(_office_id integer) CASCADE;

CREATE FUNCTION core.get_quotation_valid_duration(_office_id integer)
RETURNS integer
STABLE
AS
$$
BEGIN
    RETURN value::varchar::integer
    FROM office.configuration
    WHERE office_id = _office_id
    AND config_id = 3
    LIMIT 1;
END
$$
LANGUAGE plpgsql;

--SELECT * FROM core.get_quotation_valid_duration(2);