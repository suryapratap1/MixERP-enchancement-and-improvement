DO
$$
    DECLARE _constraint_name text;
BEGIN
    SELECT constraint_name INTO _constraint_name
    FROM information_schema.table_constraints
    WHERE table_name ='auto_verification_policy'
    AND constraint_type = 'PRIMARY KEY';

    IF(_constraint_name IS NOT NULL) THEN
        EXECUTE 'ALTER TABLE policy.auto_verification_policy DROP CONSTRAINT ' || _constraint_name;
    END IF;

    ALTER TABLE policy.auto_verification_policy
    ADD CONSTRAINT auto_verification_policy_pkey PRIMARY KEY(policy_id);
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
        AND    c.relname = 'filters'
        AND    c.relkind = 'r'
    ) THEN
        CREATE TABLE core.filters
        (
            filter_id                       BIGSERIAL NOT NULL PRIMARY KEY,
            object_name                     text NOT NULL,
            filter_name                     text NOT NULL,
            is_default                      boolean NOT NULL DEFAULT(false),
            is_default_admin                boolean NOT NULL DEFAULT(false),
            filter_statement                national character varying(12) NOT NULL DEFAULT('WHERE'),
            column_name                     text NOT NULL,
            filter_condition                integer NOT NULL,
            filter_value                    text,
            filter_and_value                text,
            audit_user_id                   integer NULL REFERENCES office.users(user_id),
            audit_ts                        TIMESTAMP WITH TIME ZONE NULL 
                                            DEFAULT(NOW())
        );

        CREATE INDEX filters_object_name_inx
        ON core.filters(object_name);
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
        WHERE  n.nspname = 'policy'
        AND    c.relname = 'access_types'
        AND    c.relkind = 'r'
    ) THEN
        CREATE TABLE policy.access_types
        (
            access_type_id                  integer NOT NULL PRIMARY KEY,
            access_type_name                national character varying(48) NOT NULL UNIQUE
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
        WHERE  n.nspname = 'policy'
        AND    c.relname = 'default_entity_access'
        AND    c.relkind = 'r'
    ) THEN
        CREATE TABLE policy.default_entity_access
        (
            default_entity_access_id        SERIAL NOT NULL PRIMARY KEY,
            entity_name                     national character varying(128) NULL,
            role_id                         integer NOT NULL REFERENCES office.roles(role_id),
            access_type_id                  integer NULL REFERENCES policy.access_types(access_type_id),
            allow_access                    boolean NOT NULL,
            audit_user_id                   integer NULL REFERENCES office.users(user_id),
            audit_ts                        TIMESTAMP WITH TIME ZONE NULL 
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
        WHERE  n.nspname = 'policy'
        AND    c.relname = 'entity_access'
        AND    c.relkind = 'r'
    ) THEN
        CREATE TABLE policy.entity_access
        (
            entity_access_id                SERIAL NOT NULL PRIMARY KEY,
            entity_name                     national character varying(128) NULL,
            user_id                         integer NOT NULL REFERENCES office.users(user_id),
            access_type_id                  integer NULL REFERENCES policy.access_types(access_type_id),
            allow_access                    boolean NOT NULL,
            audit_user_id                   integer NULL REFERENCES office.users(user_id),
            audit_ts                        TIMESTAMP WITH TIME ZONE NULL 
                                            DEFAULT(NOW())
        );
    END IF;
END
$$
LANGUAGE plpgsql;

DROP INDEX IF EXISTS policy.default_entity_access_entity_name_role_id_access_type_id_uix;

CREATE UNIQUE INDEX default_entity_access_entity_name_role_id_access_type_id_uix
ON policy.default_entity_access(lower(entity_name), role_id, access_type_id);



DO
$$
BEGIN
    IF NOT EXISTS (
        SELECT 1 
        FROM   pg_catalog.pg_class c
        JOIN   pg_catalog.pg_namespace n ON n.oid = c.relnamespace
        WHERE  n.nspname = 'core'
        AND    c.relname = 'genders'
        AND    c.relkind = 'r'
    ) THEN
        CREATE TABLE core.genders
        (
            gender_code                             national character varying(4) NOT NULL PRIMARY KEY,
            gender_name                             national character varying(50) NOT NULL UNIQUE,
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
        AND    c.relname = 'identification_types'
        AND    c.relkind = 'r'
    ) THEN
        CREATE TABLE core.identification_types
        (
            identification_type_code                national character varying(12) NOT NULL PRIMARY KEY,
            identification_type_name                national character varying(100) NOT NULL UNIQUE,
            can_expire                              boolean NOT NULL DEFAULT(false),
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
        AND    c.relname = 'nationalities'
        AND    c.relkind = 'r'
    ) THEN
        CREATE TABLE core.nationalities
        (
            nationality_code                        national character varying(12) NOT NULL PRIMARY KEY,
            nationality_name                        national character varying(100) NOT NULL UNIQUE,
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
        AND    c.relname = 'social_networks'
        AND    c.relkind = 'r'
    ) THEN
        CREATE TABLE core.social_networks
        (
            social_network_name                     national character varying(128) NOT NULL PRIMARY KEY,
            semantic_css_class                      national character varying(128),
            base_url                                national character varying(128) DEFAULT(''),
            profile_url                             national character varying(128) DEFAULT(''),
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
        WHERE  attrelid = 'localization.localized_resources'::regclass
        AND    attname = 'localized_resource_id'
        AND    NOT attisdropped
    ) THEN
        ALTER TABLE localization.localized_resources
        ADD COLUMN localized_resource_id BIGSERIAL PRIMARY KEY;
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
        WHERE  attrelid = 'transactions.non_gl_stock_tax_details'::regclass
        AND    attname = 'non_gl_stock_tax_detail_id'
        AND    NOT attisdropped
    ) THEN
        ALTER TABLE transactions.non_gl_stock_tax_details
        ADD COLUMN non_gl_stock_tax_detail_id BIGSERIAL PRIMARY KEY;
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
        WHERE  attrelid = 'transactions.stock_tax_details'::regclass
        AND    attname = 'stock_tax_detail_id'
        AND    NOT attisdropped
    ) THEN
        ALTER TABLE transactions.stock_tax_details
        ADD COLUMN stock_tax_detail_id BIGSERIAL PRIMARY KEY;
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
        AND    c.relname = 'week_days'
        AND    c.relkind = 'r'
    ) THEN
        CREATE TABLE core.week_days
        (
            week_day_id                 integer NOT NULL CHECK(week_day_id>=1 AND week_day_id<=7) PRIMARY KEY,
            week_day_code               national character varying(12) NOT NULL UNIQUE,
            week_day_name               national character varying(50) NOT NULL UNIQUE
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
        AND    c.relname = 'kanbans'
        AND    c.relkind = 'r'
    ) THEN
        CREATE TABLE core.kanbans
        (
            kanban_id                               BIGSERIAL NOT NULL PRIMARY KEY,
            object_name                             national character varying(128) NOT NULL,
            user_id                                 integer NOT NULL REFERENCES office.users(user_id),
            kanban_name                             national character varying(128) NOT NULL,
            description                             text,
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
        AND    c.relname = 'kanban_details'
        AND    c.relkind = 'r'
    ) THEN
        CREATE TABLE core.kanban_details
        (
            kanban_detail_id                        BIGSERIAL NOT NULL PRIMARY KEY,
            kanban_id                               bigint NOT NULL REFERENCES core.kanbans(kanban_id),
            rating                                  smallint CHECK(rating>=0 AND rating<=5),
            resource_id                             national character varying(128) NOT NULL,
            audit_user_id                           integer NULL REFERENCES office.users(user_id),
            audit_ts                                TIMESTAMP WITH TIME ZONE NULL 
                                                    DEFAULT(NOW())    
        );
        
        CREATE UNIQUE INDEX kanban_details_kanban_id_resource_id_uix
        ON core.kanban_details(kanban_id, resource_id);
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
        WHERE  attrelid = 'core.filters'::regclass
        AND    attname = 'filter_statement'
        AND    NOT attisdropped
    ) THEN
        ALTER TABLE core.filters
        ADD COLUMN filter_statement national character varying(12) NOT NULL DEFAULT('WHERE');    
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
        WHERE  attrelid = 'core.menus'::regclass
        AND    attname = 'sort'
        AND    NOT attisdropped
    ) THEN
        ALTER TABLE core.menus
        ADD COLUMN sort integer NOT NULL DEFAULT(0);
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
        WHERE  attrelid = 'core.menus'::regclass
        AND    attname = 'icon'
        AND    NOT attisdropped
    ) THEN
        ALTER TABLE core.menus
        ADD COLUMN icon national character varying(48) NOT NULL DEFAULT('');
    END IF;
END
$$
LANGUAGE plpgsql;

DROP VIEW IF EXISTS core.item_cost_price_scrud_view;
DROP VIEW IF EXISTS core.item_scrud_view;
DROP VIEW IF EXISTS core.item_view;
DROP VIEW IF EXISTS core.party_view;
DROP VIEW IF EXISTS core.party_scrud_view;
DROP VIEW IF EXISTS core.party_selector_view;
DROP VIEW IF EXISTS core.recurring_invoice_setup_scrud_view;
DROP VIEW IF EXISTS core.sales_tax_exempt_detail_scrud_view;
DROP VIEW IF EXISTS core.shipping_address_scrud_view;
DROP VIEW IF EXISTS core.supplier_view;
DROP VIEW IF EXISTS core.supplier_selector_view;
DROP VIEW IF EXISTS transactions.sales_quotation_view;
DROP VIEW IF EXISTS transactions.sales_order_view;
DROP VIEW IF EXISTS transactions.sales_delivery_view;
DROP VIEW IF EXISTS transactions.receipt_view;

ALTER TABLE core.parties
ALTER COLUMN company_name TYPE national character varying(128);

ALTER TABLE core.parties
ALTER COLUMN party_name TYPE national character varying(150);

DO
$$
BEGIN    
    IF NOT EXISTS (
        SELECT 1 
        FROM   pg_catalog.pg_class c
        JOIN   pg_catalog.pg_namespace n ON n.oid = c.relnamespace
        WHERE  n.nspname = 'core'
        AND    c.relname = 'marital_statuses'
        AND    c.relkind = 'r'
    ) THEN
        CREATE TABLE core.marital_statuses
        (
            marital_status_id                       SERIAL NOT NULL PRIMARY KEY,
            marital_status_code                     national character varying(12) NOT NULL UNIQUE,
            marital_status_name                     national character varying(128) NOT NULL,
            is_legally_recognized_marriage          boolean NOT NULL DEFAULT(false),
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
        WHERE  attrelid = 'core.salespersons'::regclass
        AND    attname = 'photo'
        AND    NOT attisdropped
    ) THEN
        ALTER TABLE core.salespersons
        ADD COLUMN photo public.image;
    END IF;
END
$$
LANGUAGE plpgsql;

ALTER TABLE office.holidays
DROP COLUMN IF EXISTS falls_on;

ALTER TABLE office.holidays
DROP COLUMN IF EXISTS recurs_next_year;


DO
$$
BEGIN
    IF NOT EXISTS
    (
        SELECT 1
        FROM   pg_attribute 
        WHERE  attrelid = 'office.holidays'::regclass
        AND    attname = 'occurs_on'
        AND    NOT attisdropped
    ) THEN
        ALTER TABLE office.holidays
        ADD COLUMN occurs_on date NOT NULL;
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
        WHERE  attrelid = 'office.holidays'::regclass
        AND    attname = 'ends_on'
        AND    NOT attisdropped
    ) THEN
        ALTER TABLE office.holidays
        ADD COLUMN ends_on date NOT NULL CHECK(ends_on >= occurs_on);
    END IF;
END
$$
LANGUAGE plpgsql;

DO
$$
BEGIN
    IF NOT EXISTS(SELECT 0 FROM pg_class where oid::regclass::text = 'office.holidays_holiday_id_seq') THEN
        CREATE SEQUENCE office.holidays_holiday_id_seq;
        ALTER SEQUENCE office.holidays_holiday_id_seq OWNER TO mix_erp;

        ALTER TABLE office.holidays
        ALTER COLUMN holiday_id SET DEFAULT(nextval('office.holidays_holiday_id_seq'));

        ALTER SEQUENCE office.holidays_holiday_id_seq OWNED BY office.holidays.holiday_id;
    END IF;
END
$$
LANGUAGE plpgsql;