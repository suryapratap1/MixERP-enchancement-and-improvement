DROP VIEW IF EXISTS core.item_variant_scrud_view;

CREATE VIEW core.item_variant_scrud_view
AS
SELECT
    core.item_variants.item_variant_id,
    core.items.item_code || ' (' || core.items.item_name || ')' AS item,
    core.variants.variant_code || ' (' || core.variants.variant_name || ')' AS variant
FROM core.item_variants
INNER JOIN core.items
ON core.items.item_id = core.item_variants.item_id
INNER JOIN core.variants
ON core.variants.variant_id = core.item_variants.variant_id;