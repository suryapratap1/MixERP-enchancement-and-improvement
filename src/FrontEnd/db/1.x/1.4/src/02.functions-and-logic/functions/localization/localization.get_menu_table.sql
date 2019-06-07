DROP FUNCTION IF EXISTS localization.get_menu_table(_culture_code text);

CREATE FUNCTION localization.get_menu_table(_culture_code text)
RETURNS TABLE
(
    menu_code           text,
    invariant           text,
    localized           text
)
AS
$$
BEGIN
    RETURN QUERY
    SELECT
        core.menus.menu_code::text,
        core.menus.menu_text::text,
        core.menu_locale.menu_text::text AS translated
    FROM core.menus
    LEFT JOIN core.menu_locale
    ON core.menus.menu_id = core.menu_locale.menu_id
    AND core.menu_locale.culture = _culture_code
    ORDER BY 3 DESC, 2, 1;
END
$$
LANGUAGE plpgsql;