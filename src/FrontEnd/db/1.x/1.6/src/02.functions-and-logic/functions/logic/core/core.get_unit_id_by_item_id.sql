DROP FUNCTION IF EXISTS core.get_unit_id_by_item_id(_item_id integer);

CREATE FUNCTION core.get_unit_id_by_item_id(_item_id integer)
RETURNS integer
AS
$$
BEGIN
    RETURN
        core.items.unit_id
    FROM core.items
    WHERE core.items.item_id = _item_id;
END
$$
LANGUAGE plpgsql;
