DROP FUNCTION IF EXISTS public.poco_get_table_function_annotation(_schema_name text, _table_name text);

CREATE FUNCTION public.poco_get_table_function_annotation(_schema_name text, _table_name text)
RETURNS TABLE
(
    id                      integer,
    column_name             text,
    is_nullable             text,
    udt_name                text,
    column_default          text,
    max_length              integer,
    is_primary_key          text
)
AS
$$
    DECLARE _args           text;
BEGIN
    DROP TABLE IF EXISTS temp_annonation;
    CREATE TEMPORARY TABLE temp_annonation
    (
        id                      SERIAL,
        column_name             text,
        is_nullable             text DEFAULT('NO'),
        udt_name                text,
        column_default          text,
        max_length              integer DEFAULT(0),
        is_primary_key          text DEFAULT('NO')
    ) ON COMMIT DROP;


    SELECT
        pg_catalog.pg_get_function_arguments(pg_proc.oid) AS arguments
    INTO
        _args
    FROM pg_proc
    INNER JOIN pg_namespace
    ON pg_proc.pronamespace = pg_namespace.oid
    INNER JOIN pg_type
    ON pg_proc.prorettype = pg_type.oid
    INNER JOIN pg_namespace type_namespace
    ON pg_type.typnamespace = type_namespace.oid
    WHERE typname != ANY(ARRAY['trigger'])
    AND pg_namespace.nspname = _schema_name
    AND proname::text = _table_name;

    INSERT INTO temp_annonation(column_name, udt_name)
    SELECT split_part(trim(unnest(regexp_split_to_array(_args, ','))), ' ', 1), trim(unnest(regexp_split_to_array(_args, ',')));

    UPDATE temp_annonation
    SET udt_name = TRIM(REPLACE(temp_annonation.udt_name, temp_annonation.column_name, ''));

    
    RETURN QUERY
    SELECT * FROM temp_annonation;
END
$$
LANGUAGE plpgsql;

--SELECT * FROM public.poco_get_table_function_annotation('transactions', 'get_product_view');
