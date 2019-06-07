DROP VIEW IF EXISTS core.bonus_slab_detail_scrud_view;

CREATE VIEW core.bonus_slab_detail_scrud_view
AS
SELECT
    core.bonus_slab_details.bonus_slab_detail_id,
    core.bonus_slabs.bonus_slab_code || ' (' || core.bonus_slabs.bonus_slab_name || ')' AS bonus_slab,
    core.bonus_slab_details.amount_from,
    core.bonus_slab_details.amount_to,
    core.bonus_slab_details.bonus_rate
FROM
    core.bonus_slab_details
INNER JOIN core.bonus_slabs
ON core.bonus_slab_details.bonus_slab_id = core.bonus_slabs.bonus_slab_id;

