DROP FUNCTION IF EXISTS core.recreate_menu
(
    _menu_text          text,
    _url                text,
    _menu_code          text,
    _level              integer,
    _parent_menu_id     integer
);

CREATE FUNCTION core.recreate_menu
(
    _menu_text          text,
    _url                text,
    _menu_code          text,
    _level              integer,
    _parent_menu_id     integer
)
RETURNS void
VOLATILE
AS
$$
    DECLARE _menu_id        integer;
    DECLARE _child_menus    integer[];
BEGIN
    SELECT menu_id INTO _menu_id
    FROM core.menus
    WHERE menu_code=_menu_code;
    
    WITH RECURSIVE menu_cte(menu_id, path) AS (
     SELECT
        tn.menu_id,  tn.menu_id::TEXT AS path
        FROM core.menus AS tn WHERE tn.menu_id =_menu_id
    UNION ALL
     SELECT
        c.menu_id, (p.path || '->' || c.menu_id::TEXT)
        FROM menu_cte AS p, core.menus AS c WHERE parent_menu_id = p.menu_id
    )
    
    SELECT array_agg(menu_id) INTO _child_menus FROM menu_cte;

    DELETE FROM policy.menu_access
    WHERE menu_id = ANY(_child_menus);

    DELETE FROM core.menu_locale
    WHERE menu_id = ANY(_child_menus);


    DELETE FROM core.menus
    WHERE menu_id = ANY(_child_menus);
    
    INSERT INTO core.menus(menu_text, url, menu_code, level, parent_menu_id)
    SELECT _menu_text, _url, _menu_code, _level, _parent_menu_id;
END
$$
LANGUAGE plpgsql;