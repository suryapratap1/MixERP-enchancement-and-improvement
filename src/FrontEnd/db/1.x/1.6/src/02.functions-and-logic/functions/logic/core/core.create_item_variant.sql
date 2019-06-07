DROP FUNCTION IF EXISTS core.create_item_variant
(
    _variant_of             integer,
    _item_id                integer,
    _item_code              national character varying(12),
    _item_name              national character varying(100),
    _variant_ids            integer[],
    _user_id                integer
);

CREATE FUNCTION core.create_item_variant
(
    _variant_of             integer,
    _item_id                integer,
    _item_code              national character varying(12),
    _item_name              national character varying(100),
    _variant_ids            integer[],
    _user_id                integer
)
RETURNS integer
AS
$$
BEGIN
    IF(COALESCE(_item_id, 0) = 0) THEN
        INSERT INTO core.items
        (
            item_code, 
            item_name, 
            item_group_id, 
            item_type_id, 
            brand_id, 
            preferred_supplier_id, 
            lead_time_in_days, 
            weight_in_grams, 
            width_in_centimeters, 
            height_in_centimeters, 
            length_in_centimeters,
            machinable,
            preferred_shipping_mail_type_id,
            shipping_package_shape_id,
            unit_id,
            hot_item,
            cost_price,
            selling_price,
            selling_price_includes_tax,
            sales_tax_id,
            reorder_unit_id,
            reorder_level,
            reorder_quantity,
            maintain_stock,
            audit_user_id,
            photo,
            is_variant_of
        )
        SELECT
                _item_code, 
                _item_name, 
                item_group_id, 
                item_type_id, 
                brand_id, 
                preferred_supplier_id, 
                lead_time_in_days, 
                weight_in_grams, 
                width_in_centimeters, 
                height_in_centimeters, 
                length_in_centimeters,
                machinable,
                preferred_shipping_mail_type_id,
                shipping_package_shape_id,
                unit_id,
                hot_item,
                cost_price,
                selling_price,
                selling_price_includes_tax,
                sales_tax_id,
                reorder_unit_id,
                reorder_level,
                reorder_quantity,
                maintain_stock,
                _user_id,
                photo,
                _variant_of
        FROM core.items
        WHERE item_id = _variant_of
        RETURNING item_id
        INTO _item_id;
    END IF;

    DELETE FROM core.item_variants
    WHERE item_id = _item_id
    AND variant_id NOT IN
    (
        SELECT explode_array(_variant_ids)
    );

    WITH variants
    AS
    (
        SELECT explode_array(_variant_ids) AS variant_id
    ),
    new
    AS
    (
        SELECT variant_id FROM variants WHERE
        variant_id NOT IN
        (
            SELECT core.item_variants.variant_id
            FROM core.item_variants
            WHERE item_id = _item_id
        )
    )
    
    INSERT INTO core.item_variants(item_id, variant_id, audit_user_id)
    SELECT _item_id, variant_id, _user_id
    FROM new;
    

    RETURN _item_id;
END
$$
LANGUAGE plpgsql;
