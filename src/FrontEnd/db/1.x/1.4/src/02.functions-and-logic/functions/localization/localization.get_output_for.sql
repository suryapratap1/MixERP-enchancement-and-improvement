DROP FUNCTION IF EXISTS localization.get_output_for(national character varying(3));

CREATE FUNCTION localization.get_output_for(national character varying(3))
RETURNS text
AS
$$
BEGIN
    RETURN array_to_string(array_agg(i18n.resource), E'\n')
    FROM
    (
        SELECT
            
            'SELECT * FROM localization.add_localized_resource(''' ||
            localization.resources.resource_class || ''', ''' || $1 || ''', ''' ||
            localization.resources.key || ''', ''' ||
            REPLACE(localization.localized_resources.value, '''', '''''') || ''');--' ||
            localization.resources.value AS resource
        FROM localization.localized_resources
        LEFT JOIN localization.resources
        ON localization.localized_resources.resource_id = localization.resources.resource_id
        WHERE culture_code = $1
        ORDER BY localization.resources.resource_class, localization.resources.key
    )
    i18n;
END
$$
LANGUAGE plpgsql;

--SELECT * FROM localization.get_output_for('de');
--SELECT * FROM localization.get_output_for('es');