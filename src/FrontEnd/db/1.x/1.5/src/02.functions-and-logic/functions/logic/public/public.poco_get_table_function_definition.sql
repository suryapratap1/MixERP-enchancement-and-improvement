DROP FUNCTION IF EXISTS public.poco_get_table_function_definition
(
    _schema         text,
    _name           text
);

CREATE FUNCTION public.poco_get_table_function_definition
(
    _schema                 text,
    _name                   text
)
RETURNS TABLE
(
    id                      bigint,
    column_name             text,
    is_nullable             text,
    udt_name                text,
    column_default          text,
    max_length              integer,
    is_primary_key          text
)
VOLATILE
AS
$$
    DECLARE _oid            oid;
    DECLARE _typoid         oid;
BEGIN
    CREATE TEMPORARY TABLE temp_poco
    (
        id                      bigint,
        column_name             text,
        is_nullable             text,
        udt_name                text,
        column_default          text,
        max_length              integer default(0),
        is_primary_key          text
    ) ON COMMIT DROP;

    SELECT        
        pg_proc.oid,
        pg_proc.prorettype
    INTO 
        _oid,
        _typoid
    FROM pg_proc
    INNER JOIN pg_namespace
    ON pg_proc.pronamespace = pg_namespace.oid
    WHERE pg_proc.proname=_name
    AND pg_namespace.nspname=_schema
    LIMIT 1;


    IF EXISTS
    (
        SELECT 1
        FROM information_schema.columns 
        WHERE table_schema=_schema 
        AND table_name=_name
    ) THEN
        INSERT INTO temp_poco
        SELECT
            row_number() OVER(ORDER BY attnum),
            attname AS column_name,
            CASE WHEN attnotnull THEN 'NO' ELSE 'YES' END,
            pg_type.typname,
            public.parse_default(adsrc),
            CASE WHEN atttypmod <> -1 
            THEN atttypmod - 4
            ELSE 0 END,
            CASE WHEN indisprimary THEN 'YES' ELSE 'NO' END
        FROM   pg_attribute
        LEFT JOIN pg_index
        ON pg_attribute.ATTRELID = pg_index.indrelid
        AND pg_attribute.attnum = ANY(pg_index.indkey)
        AND pg_index.indisprimary
        INNER JOIN pg_type
        ON pg_attribute.atttypid = pg_type.oid
        LEFT   JOIN pg_catalog.pg_attrdef
        ON (pg_attribute.attrelid, pg_attribute.attnum) = (pg_attrdef.adrelid,  pg_attrdef.adnum)
        WHERE  attrelid = (_schema || '.' || _name)::regclass
        AND    attnum > 0
        AND    NOT attisdropped
        ORDER  BY attnum;
        
        RETURN QUERY
        SELECT * FROM temp_poco;
        RETURN;
    END IF;

    IF EXISTS(SELECT * FROM pg_type WHERE oid = _typoid AND typtype='c') THEN
        --Composite Type
        INSERT INTO temp_poco
        SELECT
            row_number() OVER(ORDER BY attnum),
            attname::text               AS column_name,
            'NO'::text                  AS is_nullable, 
            format_type(t.oid,NULL)     AS udt_name,
            ''::text                    AS column_default
        FROM pg_attribute att
        JOIN pg_type t ON t.oid=atttypid
        JOIN pg_namespace nsp ON t.typnamespace=nsp.oid
        LEFT OUTER JOIN pg_type b ON t.typelem=b.oid
        LEFT OUTER JOIN pg_collation c ON att.attcollation=c.oid
        LEFT OUTER JOIN pg_namespace nspc ON c.collnamespace=nspc.oid
        WHERE att.attrelid=(SELECT typrelid FROM pg_type WHERE pg_type.oid = _typoid)
        AND att.attnum > 0
        ORDER by attnum;

        RETURN QUERY
        SELECT * FROM temp_poco;
        RETURN;
    END IF;

    IF(_oid IS NOT NULL) THEN
        INSERT INTO temp_poco
        WITH procs
        AS
        (
            SELECT 
            row_number() OVER(ORDER BY proallargtypes),
            explode_array(proargnames) as column_name,
            explode_array(proargmodes) as column_mode,
            explode_array(proallargtypes) as argument_type
            FROM pg_proc
            WHERE oid = _oid
        )
        SELECT
            row_number() OVER(ORDER BY 1),
            procs.column_name::text,
            'NO'::text AS is_nullable, 
            format_type(procs.argument_type, null) as udt_name,
            ''::text AS column_default
        FROM procs
        WHERE column_mode=ANY(ARRAY['t', 'o']);

        RETURN QUERY
        SELECT * FROM temp_poco;
        RETURN;
    END IF;

    INSERT INTO temp_poco
    SELECT 
        row_number() OVER(ORDER BY attnum),
        attname::text               AS column_name,
        'NO'::text                  AS is_nullable, 
        format_type(t.oid,NULL)     AS udt_name,
        ''::text                    AS column_default
    FROM pg_attribute att
    JOIN pg_type t ON t.oid=atttypid
    JOIN pg_namespace nsp ON t.typnamespace=nsp.oid
    LEFT OUTER JOIN pg_type b ON t.typelem=b.oid
    LEFT OUTER JOIN pg_collation c ON att.attcollation=c.oid
    LEFT OUTER JOIN pg_namespace nspc ON c.collnamespace=nspc.oid
    WHERE att.attrelid=
    (
        SELECT typrelid 
        FROM pg_type
        INNER JOIN pg_namespace
        ON pg_type.typnamespace = pg_namespace.oid
        WHERE typname=_name
        AND pg_namespace.nspname=_schema
    )
    AND att.attnum > 0
    ORDER by attnum;

    RETURN QUERY
    SELECT * FROM temp_poco;
END;
$$
LANGUAGE plpgsql;

--SELECT * FROM public.poco_get_table_function_definition('hrm', 'employment_statuses');
