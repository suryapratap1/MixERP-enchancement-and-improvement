DO
$$
BEGIN    
    IF NOT EXISTS (
        SELECT 1 
        FROM   pg_catalog.pg_class c
        JOIN   pg_catalog.pg_namespace n ON n.oid = c.relnamespace
        WHERE  n.nspname = 'core'
        AND    c.relname = 'attributes'
        AND    c.relkind = 'r'
    ) THEN
        CREATE TABLE core.attributes
        (
            attribute_id                            SERIAL NOT NULL PRIMARY KEY,
            attribute_code                          national character varying(12) NOT NULL UNIQUE,
            attribute_name                          national character varying(100) NOT NULL,
            audit_user_id                           integer NULL REFERENCES office.users(user_id),    
            audit_ts                                TIMESTAMP WITH TIME ZONE NULL 
                                                    DEFAULT(NOW())   
        );
    END IF;    
END
$$
LANGUAGE plpgsql;

DO
$$
BEGIN    
    IF NOT EXISTS (
        SELECT 1 
        FROM   pg_catalog.pg_class c
        JOIN   pg_catalog.pg_namespace n ON n.oid = c.relnamespace
        WHERE  n.nspname = 'core'
        AND    c.relname = 'variants'
        AND    c.relkind = 'r'
    ) THEN
        CREATE TABLE core.variants
        (
            variant_id                              SERIAL NOT NULL PRIMARY KEY,
            variant_code                            national character varying(12) NOT NULL UNIQUE,
            variant_name                            national character varying(100) NOT NULL,
            attribute_id                            integer NOT NULL REFERENCES core.attributes(attribute_id),
            attribute_value                         national character varying(200) NOT NULL,
            audit_user_id                           integer NULL REFERENCES office.users(user_id),    
            audit_ts                                TIMESTAMP WITH TIME ZONE NULL 
                                                    DEFAULT(NOW())   
        );
    END IF;    
END
$$
LANGUAGE plpgsql;


DO
$$
BEGIN    
    IF NOT EXISTS (
        SELECT 1 
        FROM   pg_catalog.pg_class c
        JOIN   pg_catalog.pg_namespace n ON n.oid = c.relnamespace
        WHERE  n.nspname = 'core'
        AND    c.relname = 'item_variants'
        AND    c.relkind = 'r'
    ) THEN
        CREATE TABLE core.item_variants
        (
            item_variant_id                         SERIAL NOT NULL PRIMARY KEY,
            item_id                                 integer NOT NULL REFERENCES core.items(item_id),
            variant_id                              integer NOT NULL REFERENCES core.variants(variant_id),
            audit_user_id                           integer NULL REFERENCES office.users(user_id),    
            audit_ts                                TIMESTAMP WITH TIME ZONE NULL 
                                                    DEFAULT(NOW())    
        );
    END IF;    
END
$$
LANGUAGE plpgsql;

DO
$$
BEGIN
    IF NOT EXISTS
    (
        SELECT 1
        FROM   pg_attribute 
        WHERE  attrelid = 'core.items'::regclass
        AND    attname = 'is_variant_of'
        AND    NOT attisdropped
    ) THEN
        ALTER TABLE core.items
        ADD COLUMN is_variant_of integer
        REFERENCES core.items(item_id);
    END IF;
END
$$
LANGUAGE plpgsql;


DO
$$
BEGIN
    IF NOT EXISTS
    (
        SELECT 1
        FROM   pg_attribute 
        WHERE  attrelid = 'core.items'::regclass
        AND    attname = 'allow_sales'
        AND    NOT attisdropped
    ) THEN
        ALTER TABLE core.items
        ADD COLUMN allow_sales boolean NOT NULL DEFAULT(true);
    END IF;
END
$$
LANGUAGE plpgsql;


DO
$$
BEGIN
    IF NOT EXISTS
    (
        SELECT 1
        FROM   pg_attribute 
        WHERE  attrelid = 'core.items'::regclass
        AND    attname = 'allow_purchase'
        AND    NOT attisdropped
    ) THEN
        ALTER TABLE core.items
        ADD COLUMN allow_purchase boolean NOT NULL DEFAULT(true);
    END IF;
END
$$
LANGUAGE plpgsql;

DROP VIEW IF EXISTS core.item_scrud_view;
DROP VIEW IF EXISTS core.item_selector_view;
DROP VIEW IF EXISTS core.item_view;

ALTER TABLE core.items
ALTER COLUMN selling_price TYPE public.money_strict2;

DO
$$
BEGIN
    IF NOT EXISTS
    (
        SELECT 1
        FROM   pg_attribute 
        WHERE  attrelid = 'core.item_types'::regclass
        AND    attname = 'is_component'
        AND    NOT attisdropped
    ) THEN
        ALTER TABLE core.item_types
        ADD COLUMN is_component boolean NOT NULL DEFAULT(false);
    END IF;
END
$$
LANGUAGE plpgsql;

DO
$$
BEGIN    
    IF NOT EXISTS (
        SELECT 1 
        FROM   pg_catalog.pg_class c
        JOIN   pg_catalog.pg_namespace n ON n.oid = c.relnamespace
        WHERE  n.nspname = 'core'
        AND    c.relname = 'printed_reports'
        AND    c.relkind = 'r'
    ) THEN
		CREATE TABLE core.printed_reports(
			id                      BIGSERIAL NOT NULL PRIMARY KEY,
			report_title            national character varying(100) NOT NULL,
			tran_id                 bigint NOT NULL,
			description             text,
			audit_user_id           integer NOT NULL REFERENCES office.users,
			audit_ts                TIMESTAMP WITH TIME ZONE NOT NULL DEFAULT(NOW())
		);
    END IF;    
END
$$
LANGUAGE plpgsql;


ALTER TABLE transactions.transaction_master
ALTER COLUMN book_date
DROP DEFAULT;

DO
$$
BEGIN
    IF NOT EXISTS
    (
        SELECT 1
        FROM   pg_attribute 
        WHERE  attrelid = 'core.bank_accounts'::regclass
        AND    attname = 'bank_account_id'
        AND    NOT attisdropped
    ) THEN
        ALTER TABLE core.bank_accounts
        ADD COLUMN bank_account_id SERIAL;
    END IF;
END
$$
LANGUAGE plpgsql;
