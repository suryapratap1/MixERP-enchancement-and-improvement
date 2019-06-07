DROP FUNCTION IF EXISTS core.delete_variant_item(_item_id integer);

CREATE FUNCTION core.delete_variant_item(_item_id integer)
RETURNS boolean
AS
$$
BEGIN
    DELETE FROM core.item_variants WHERE item_id = _item_id;
    DELETE FROM core.items WHERE item_id = _item_id;
    RETURN true;
END
$$
LANGUAGE plpgsql;