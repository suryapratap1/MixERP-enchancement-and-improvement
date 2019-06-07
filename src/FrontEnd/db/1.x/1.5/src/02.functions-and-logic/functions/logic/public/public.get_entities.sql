DROP FUNCTION IF EXISTS public.get_entities();

CREATE FUNCTION public.get_entities()
RETURNS TABLE
(
    table_schema name, 
    table_name name, 
    table_type text, 
    has_duplicate boolean
)
AS
$$
    DECLARE _ignored_schemas text[] = '{pg_catalog, information_schema}';
BEGIN
    CREATE TEMPORARY TABLE _t
    (
        table_schema            name,
        table_name              name,
        table_type              text,
        has_duplicate           boolean DEFAULT(false)
    ) ON COMMIT DROP;

    INSERT INTO _t
    SELECT 
        information_schema.tables.table_schema, 
        information_schema.tables.table_name, 
        information_schema.tables.table_type
    FROM information_schema.tables 
    WHERE (information_schema.tables.table_type='BASE TABLE' OR information_schema.tables.table_type='VIEW')
    AND information_schema.tables.table_schema != ALL(_ignored_schemas)
    UNION ALL
    SELECT DISTINCT 
        pg_namespace.nspname::text, 
        pg_proc.proname::text, 
        'FUNCTION' AS table_type
    FROM pg_proc
    INNER JOIN pg_namespace
    ON pg_proc.pronamespace = pg_namespace.oid
    INNER JOIN pg_language 
    ON pg_proc.prolang = pg_language .oid
    INNER JOIN pg_type
    ON pg_proc.prorettype=pg_type.oid
    WHERE ('t' = ANY(pg_proc.proargmodes) OR 'o' = ANY(pg_proc.proargmodes) OR pg_type.typtype = 'c')
    AND lanname NOT IN ('c','internal')
    AND nspname != ALL(_ignored_schemas)
    UNION ALL
    SELECT 
        pg_namespace.nspname, 
        pg_class.relname, 
        'TYPE'
    FROM pg_class
    INNER JOIN pg_namespace
    ON pg_class.relnamespace=pg_namespace.oid
    WHERE relkind IN('c', 'm')
    AND nspname != ALL(_ignored_schemas);


    UPDATE _t
    SET has_duplicate = TRUE
    FROM
    (
        SELECT
            information_schema.tables.table_name,
            COUNT(information_schema.tables.table_name) AS table_count
        FROM information_schema.tables
        GROUP BY information_schema.tables.table_name
        
    ) subquery
    WHERE subquery.table_name = _t.table_name
    AND subquery.table_count > 1;

    

    RETURN QUERY
    SELECT * FROM _t
    ORDER BY 2;
END
$$
LANGUAGE plpgsql;