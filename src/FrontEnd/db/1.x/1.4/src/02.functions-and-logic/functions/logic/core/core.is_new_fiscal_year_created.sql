DROP FUNCTION IF EXISTS core.is_new_fiscal_year_created
(
    _office_id              integer
);

CREATE FUNCTION core.is_new_fiscal_year_created
(
    _office_id              integer
)
RETURNS boolean
AS
$$
    DECLARE _eoy_date       date;
BEGIN
    _eoy_date               := core.get_fiscal_year_end_date(_office_id);

    IF EXISTS
    (
        SELECT 1 FROM core.fiscal_year
        WHERE ends_on > _eoy_date
    ) THEN
        RETURN true;
    END IF;
    
    RETURN false;
END
$$
LANGUAGE plpgsql;