DROP VIEW IF EXISTS core.salesperson_bonus_setup_scrud_view;

CREATE VIEW core.salesperson_bonus_setup_scrud_view
AS
SELECT
    core.salesperson_bonus_setups.salesperson_bonus_setup_id,
    core.salespersons.salesperson_code || ' (' || core.salespersons.salesperson_name || ')' AS salesperson,
    core.bonus_slabs.bonus_slab_code || ' (' || core.bonus_slabs.bonus_slab_name || ')' AS bonus_slab
FROM
    core.salesperson_bonus_setups
     
INNER JOIN core.salespersons
ON core.salesperson_bonus_setups.salesperson_id = core.salespersons.salesperson_id
INNER JOIN core.bonus_slabs
ON core.salesperson_bonus_setups.bonus_slab_id = core.bonus_slabs.bonus_slab_id;
