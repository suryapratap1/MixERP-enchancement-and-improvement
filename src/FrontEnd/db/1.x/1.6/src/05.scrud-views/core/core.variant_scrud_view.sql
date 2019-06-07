DROP VIEW IF EXISTS core.variant_scrud_view;

CREATE VIEW core.variant_scrud_view
AS
SELECT
    core.variants.variant_id,
    core.variants.variant_code,
    core.variants.variant_name,
    core.attributes.attribute_code || ' (' || core.attributes.attribute_name || ')' AS attribute,
    core.variants.attribute_value    
FROM core.variants
INNER JOIN core.attributes
ON core.attributes.attribute_id = core.variants.attribute_id;