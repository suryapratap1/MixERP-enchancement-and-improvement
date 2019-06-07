CREATE OR REPLACE FUNCTION core.get_shipping_address_by_shipping_address_id(bigint)
RETURNS text
AS
$$
BEGIN
        IF($1 IS NULL OR $1 <=0) THEN
                RETURN '';
        END IF;


        RETURN
                core.append_if_not_null(zip_code, '&lt;br /&gt;') || 
                core.append_if_not_null(address_line_1, '&lt;br /&gt;') || 
                core.append_if_not_null(address_line_2, '&lt;br /&gt;') || 
                core.append_if_not_null(street, '&lt;br /&gt;') ||
                city  || '&lt;br /&gt;' ||
                core.states.state_name  || '&lt;br /&gt;' ||
                core.countries.country_name 
        FROM core.shipping_addresses
        INNER JOIN core.states
        ON core.shipping_addresses.state_id = core.states.state_id
        INNER JOIN core.countries
        ON core.shipping_addresses.country_id = core.countries.country_id
        WHERE shipping_address_id=$1;
        
END
$$
LANGUAGE plpgsql;

--SELECT * FROM core.get_shipping_address_by_shipping_address_id(1);