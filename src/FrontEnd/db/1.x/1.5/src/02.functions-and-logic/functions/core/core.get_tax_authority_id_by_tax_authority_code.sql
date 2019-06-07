DROP FUNCTION IF EXISTS core.get_tax_authority_id_by_tax_authority_code(_tax_authority_code national character varying(12));

CREATE FUNCTION core.get_tax_authority_id_by_tax_authority_code(_tax_authority_code national character varying(12))
RETURNS integer
AS
$$
BEGIN
    RETURN tax_authority_id
    FROM core.tax_authorities
    WHERE tax_authority_code = $1;
END
$$
LANGUAGE plpgsql;

