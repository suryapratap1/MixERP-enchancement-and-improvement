DROP FUNCTION IF EXISTS core.get_current_fiscal_year_code(_office_id integer);

CREATE FUNCTION core.get_current_fiscal_year_code(_office_id integer)
RETURNS national character varying(12)
AS
$$
    DECLARE _today date = core.get_date(_office_id);
BEGIN
    RETURN fiscal_year_code 
    FROM core.fiscal_year
    WHERE _today >= starts_from
    AND _today <= ends_on
    ORDER BY ends_on DESC
    LIMIT 1;
END
$$
LANGUAGE plpgsql;