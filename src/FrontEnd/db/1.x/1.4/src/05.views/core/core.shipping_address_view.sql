DROP VIEW IF EXISTS core.shipping_address_view;

CREATE VIEW core.shipping_address_view
AS
SELECT
    core.shipping_addresses.shipping_address_id,
    core.shipping_addresses.shipping_address_code,
    core.shipping_addresses.zip_code,
    core.shipping_addresses.party_id,
    core.countries.country_id,
    core.states.state_id,
    core.countries.country_name,
    core.states.state_name,
    core.shipping_addresses.address_line_1,
    core.shipping_addresses.address_line_2,
    core.shipping_addresses.street,
    core.shipping_addresses.city
FROM core.shipping_addresses
INNER JOIN core.states
ON core.shipping_addresses.state_id = core.states.state_id
INNER JOIN core.countries
ON core.shipping_addresses.country_id = core.countries.country_id;