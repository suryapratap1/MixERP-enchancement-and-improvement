DROP FUNCTION IF EXISTS public.parse_default(text);

CREATE FUNCTION public.parse_default(text)
RETURNS text
AS
$$
DECLARE _sql text;
DECLARE _val text;
BEGIN
    IF($1 LIKE '%::%' AND $1 NOT LIKE 'nextval%') THEN
        _sql := 'SELECT ' || $1;
        EXECUTE _sql INTO _val;
        RETURN _val;
    END IF;

    IF($1 = 'now()') THEN
        RETURN '';
    END IF;

    RETURN $1;
END
$$
LANGUAGE plpgsql;

