DROP INDEX IF EXISTS policy.menu_access_uix;


CREATE UNIQUE INDEX menu_access_uix
ON policy.menu_access(office_id, menu_id, user_id);

DO
$$
    DECLARE index_name      text;
    DECLARE sql             text;
BEGIN
    SELECT i.relname::text INTO index_name
    FROM pg_class
    INNER JOIN pg_attribute
    ON pg_attribute.attrelid = pg_class.oid
    INNER JOIN pg_index
    ON pg_class.oid = pg_index.indrelid 
    AND pg_attribute.attnum = ANY(pg_index.indkey)
    INNER JOIN pg_class i
    ON i.oid = pg_index.indexrelid
    WHERE pg_index.indrelid = 'policy.auto_verification_policy'::regclass
    AND pg_index.indisprimary;

    IF(index_name IS NOT NULL) THEN
        sql := 'ALTER TABLE policy.auto_verification_policy DROP CONSTRAINT IF EXISTS ' || quote_ident(index_name) || ';';
        EXECUTE sql;
    END IF;

    ALTER TABLE policy.auto_verification_policy
    ADD PRIMARY KEY(user_id, office_id);    
END
$$
LANGUAGE plpgsql;

DO
$$
BEGIN
    IF
    (
        SELECT count(*)
        FROM   pg_attribute 
        WHERE  attrelid = 'core.parties'::regclass
        AND    attname IN ('party_name', 'company_name')
        AND    NOT attisdropped
    ) = 1 THEN
        ALTER TABLE core.parties
        RENAME COLUMN party_name to company_name;
        
        ALTER TABLE core.parties
        ADD COLUMN party_name text;
        
        UPDATE core.parties
        SET party_name = company_name;

        ALTER TABLE core.parties
        ALTER COLUMN company_name DROP NOT NULL;
        
        UPDATE core.parties
        SET company_name = NULL;

        ALTER TABLE core.parties
        DROP CONSTRAINT IF EXISTS parties_customer_name_chk;

        ALTER TABLE core.parties
        ADD CONSTRAINT parties_customer_name_chk
        CHECK(CASE WHEN COALESCE(company_name, '') = '' THEN  COALESCE(first_name, '') != '' AND COALESCE(last_name, '') != '' END);
    END IF;
END
$$
LANGUAGE plpgsql;

ALTER TABLE core.parties
ALTER COLUMN first_name DROP NOT NULL;

ALTER TABLE core.parties
ALTER COLUMN last_name DROP NOT NULL;

ALTER TABLE core.parties
ALTER COLUMN company_name DROP NOT NULL;


DO
$$
BEGIN
    IF NOT EXISTS
    (
        SELECT 1
        FROM   pg_attribute 
        WHERE  attrelid = 'office.users'::regclass
        AND    attname = 'store_id'
        AND    NOT attisdropped
    ) THEN
        ALTER TABLE office.users
        ADD COLUMN store_id integer REFERENCES office.stores(store_id)
        CONSTRAINT users_store_id_chk 
        CHECK
        (
            office.get_office_id_by_store_id(store_id) IS NULL OR
            office.get_office_id_by_store_id(store_id) = office_id
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
        WHERE  n.nspname = 'transactions'
        AND    c.relname = 'inventory_transfer_requests'
        AND    c.relkind = 'r'
    ) THEN
        CREATE TABLE transactions.inventory_transfer_requests
        (
            inventory_transfer_request_id               BIGSERIAL NOT NULL PRIMARY KEY,
            office_id                                   integer NOT NULL REFERENCES office.offices(office_id),
            user_id                                     integer NOT NULL REFERENCES office.users(user_id),
            login_id                                    bigint NOT NULL REFERENCES audit.logins(login_id),
            store_id                                    integer NOT NULL REFERENCES office.stores(store_id),
            value_date                                  date NOT NULL,
            transaction_ts                              TIMESTAMP WITH TIME ZONE DEFAULT(now()),
            reference_number                            national character varying(24) NOT NULL,
            statement_reference                         text,
            authorization_status_id                     smallint NOT NULL REFERENCES core.verification_statuses(verification_status_id)
                                                        DEFAULT(0)
                                                        CONSTRAINT inventory_transfer_requests_withdrawn_chk
                                                        CHECK(CASE WHEN authorization_status_id = -1 THEN delivered=false AND received=false AND user_id = authorized_by_user_id END),
            authorized_by_user_id                       integer REFERENCES office.users(user_id),
            authorized_on                               TIMESTAMP WITH TIME ZONE,
            authorization_reason                        national character varying(128),
            received                                    boolean NOT NULL DEFAULT(FALSE),
            received_by_user_id                         integer REFERENCES office.users(user_id),
            received_on                                 TIMESTAMP WITH TIME ZONE,
            delivered                                   boolean NOT NULL DEFAULT(FALSE),
            delivered_by_user_id                        integer REFERENCES office.users(user_id),
            delivered_on                                TIMESTAMP WITH TIME ZONE,
            audit_ts                                    TIMESTAMP WITH TIME ZONE DEFAULT(now())
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
        WHERE  n.nspname = 'transactions'
        AND    c.relname = 'inventory_transfer_request_details'
        AND    c.relkind = 'r'
    ) THEN
        CREATE TABLE transactions.inventory_transfer_request_details
        (
            inventory_transfer_request_detail_id        BIGSERIAL NOT NULL PRIMARY KEY,
            inventory_transfer_request_id               bigint NOT NULL REFERENCES transactions.inventory_transfer_requests(inventory_transfer_request_id),
            value_date                                  date NOT NULL,
            item_id                                     integer NOT NULL REFERENCES core.items(item_id),
            quantity                                    integer NOT NULL,
            unit_id                                     integer NOT NULL REFERENCES core.units(unit_id),
            base_quantity                               numeric NOT NULL,
            base_unit_id                                integer NOT NULL REFERENCES core.units(unit_id)
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
        WHERE  n.nspname = 'config'
        AND    c.relname = 'attachment_factory'
        AND    c.relkind = 'r'
    ) THEN
        CREATE TABLE config.attachment_factory
        (
            key                 text PRIMARY KEY,
            value               text,
            audit_user_id       integer NULL REFERENCES office.users(user_id),
            audit_ts            TIMESTAMP WITH TIME ZONE NULL 
                                DEFAULT(NOW())
        );

        INSERT INTO config.attachment_factory
        SELECT 'AttachmentsDirectory',              '/Resource/Static/Attachments/' UNION ALL
        SELECT 'UploadHandlerUrl',                  '~/FileUploadHanlder.ashx' UNION ALL
        SELECT 'UndoUploadServiceUrl',              '~/FileUploadHanlder.asmx/UndoUpload' UNION ALL
        SELECT 'AllowedExtensions',                 'jpg,jpeg,gif,png,tif,doc,docx,xls,xlsx,pdf';
    END IF;


    IF NOT EXISTS (
        SELECT 1 
        FROM   pg_catalog.pg_class c
        JOIN   pg_catalog.pg_namespace n ON n.oid = c.relnamespace
        WHERE  n.nspname = 'config'
        AND    c.relname = 'currency_layer'
        AND    c.relkind = 'r'
    ) THEN
        CREATE TABLE config.currency_layer
        (
            key                 text PRIMARY KEY,
            value               text,
            description         text,
            audit_user_id       integer NULL REFERENCES office.users(user_id),
            audit_ts            TIMESTAMP WITH TIME ZONE NULL 
                                DEFAULT(NOW())
        );

        INSERT INTO config.currency_layer
        SELECT 'Enabled',                           'true', '' UNION ALL
        SELECT 'UserAgent',                         'MixERP', '' UNION ALL
        SELECT 'MediaType',                         'application/json', '' UNION ALL
        SELECT 'APIAccessKey',                      '', '' UNION ALL
        SELECT 'APIUrl',                            'http://apilayer.net/api/live', '' UNION ALL
        SELECT 'AccessKeyName',                     'access_key', '' UNION ALL
        SELECT 'CurrenciesKey',                     'currencies', '' UNION ALL
        SELECT 'SourceKey',                         'source', '' UNION ALL
        SELECT 'FormatKey',                         'format', '' UNION ALL
        SELECT 'DecimalPlaces',                     '4', '' UNION ALL
        SELECT 'DefaultFormat',                     '1', '1 = JSON' UNION ALL
        SELECT 'ResultSubKey',                      'quotes', 'The sub-key which contains list of converted currencies' UNION ALL
        SELECT 'RemoveSourceCurrencyFromResult',    'true', 'Currencylayer prepends source currency on all result items. This must be set to true unless this behavior is changed in the future.';
    END IF;

    IF NOT EXISTS (
        SELECT 1 
        FROM   pg_catalog.pg_class c
        JOIN   pg_catalog.pg_namespace n ON n.oid = c.relnamespace
        WHERE  n.nspname = 'config'
        AND    c.relname = 'db_parameters'
        AND    c.relkind = 'r'
    ) THEN
        CREATE TABLE config.db_parameters
        (
            key                 text PRIMARY KEY,
            value               text,
            audit_user_id       integer NULL REFERENCES office.users(user_id),
            audit_ts            TIMESTAMP WITH TIME ZONE NULL 
                                DEFAULT(NOW())
        );

        INSERT INTO config.db_parameters
        SELECT 'AccountMasterDisplayField', 'account_master_code + '' ('' + account_master_name + '')''' UNION ALL
        SELECT 'AccountDisplayField', 'account_number + '' ('' + account_name + '')''' UNION ALL
        SELECT 'SalespersonDisplayField', 'salesperson_code + '' ('' + salesperson_name + '')''' UNION ALL
        SELECT 'SalesTeamDisplayField', 'sales_team_code + '' ('' + sales_team_name + '')''' UNION ALL
        SELECT 'BankAccountDisplayField', 'bank_name + '' ('' + bank_branch + '')''' UNION ALL
        SELECT 'BonusSlabDisplayField', 'bonus_slab_name' UNION ALL
        SELECT 'BrandDisplayField', 'brand_code + '' ('' + brand_name + '')''' UNION ALL
        SELECT 'CardTypeDisplayField', 'card_type_code + '' ('' + card_type_name + '')''' UNION ALL
        SELECT 'CashRepositoryDisplayField', 'cash_repository_code + '' ('' + cash_repository_name + '')''' UNION ALL
        SELECT 'CashFlowHeadingDisplayField', 'cash_flow_heading_code + '' ('' + cash_flow_heading_name + '')''' UNION ALL
        SELECT 'CompoundItemDisplayField', 'compound_item_code + '' ('' + compound_item_name + '')''' UNION ALL
        SELECT 'CostCenterDisplayField', 'cost_center_code + '' ('' + cost_center_name + '')''' UNION ALL
        SELECT 'CountryDisplayField', 'country_code + '' ('' + country_name + '')''' UNION ALL
        SELECT 'CountyDisplayField', 'county_code + '' ('' + county_name + '')''' UNION ALL
        SELECT 'CountySalesTaxDisplayField', 'county_sales_tax_code + '' ('' + county_sales_tax_name + '')''' UNION ALL
        SELECT 'CurrencyDisplayField', 'currency_symbol + '' ('' + currency_code + ''/'' + currency_name + '')''' UNION ALL
        SELECT 'CustomerDisplayField', 'last_name + '', '' + fist_name + '' '' + middle_name' UNION ALL
        SELECT 'DepartmentDisplayField', 'department_code + '' ('' + department_name + '')''' UNION ALL
        SELECT 'EntityDisplayField', 'entity_name' UNION ALL
        SELECT 'FrequencyDisplayField', 'frequency_code' UNION ALL
        SELECT 'FiscalYearDisplayField', 'fiscal_year_code + '' ('' + fiscal_year_name + '')''' UNION ALL
        SELECT 'IndustryDisplayField', 'industry_name' UNION ALL
        SELECT 'ItemDisplayField', 'item_code + '' ('' + item_name + '')''' UNION ALL
        SELECT 'ItemTypeDisplayField', 'item_type_code + '' ('' + item_type_name + '')''' UNION ALL
        SELECT 'ItemGroupDisplayField', 'item_group_code + '' ('' + item_group_name + '')''' UNION ALL
        SELECT 'LateFeeDisplayField', 'late_fee_code + '' ('' + late_fee_name + '')''' UNION ALL
        SELECT 'OfficeDisplayField', 'office_code + '' ('' + office_name + '')''' UNION ALL
        SELECT 'PartyDisplayField', 'party_code + '' ('' + party_name + '')''' UNION ALL
        SELECT 'PartyTypeDisplayField', 'party_type_code + '' ('' + party_type_name + '')''' UNION ALL
        SELECT 'PaymentCardDisplayField', 'payment_card_code + '' ('' + payment_card_name + '')''' UNION ALL
        SELECT 'PaymentTermDisplayField', 'payment_term_code + '' ('' + payment_term_name + '')''' UNION ALL
        SELECT 'PriceTypeDisplayField', 'price_type_code + '' ('' + price_type_name + '')''' UNION ALL
        SELECT 'RecurrenceTypeDisplayField', 'recurrence_type_code + '' ('' + recurrence_type_name + '')''' UNION ALL
        SELECT 'RecurringInvoiceDisplayField', 'recurring_invoice_code + '' ('' + recurring_invoice_name + '')''' UNION ALL
        SELECT 'RoleDisplayField', 'role_code + '' ('' + role_name + '')''' UNION ALL
        SELECT 'RoundingMethodCodeDisplayField', 'rounding_method_code + '' ('' + rounding_method_name + '')''' UNION ALL
        SELECT 'SalesTaxDisplayField', 'sales_tax_code + '' ('' + sales_tax_name + '')''' UNION ALL
        SELECT 'SalesTaxExemptDisplayField', 'sales_tax_exempt_code + '' ('' + sales_tax_exempt_name + '')''' UNION ALL
        SELECT 'SalesTaxTypeDisplayField', 'sales_tax_type_code + '' ('' + sales_tax_type_name + '')''' UNION ALL
        SELECT 'StateSalesTaxDisplayField', 'state_sales_tax_code + '' ('' + state_sales_tax_name + '')''' UNION ALL
        SELECT 'ShipperDisplayField', 'company_name' UNION ALL
        SELECT 'ShippingMailTypeDisplayField', 'shipping_mail_type_code + '' ('' + shipping_mail_type_name + '')''' UNION ALL
        SELECT 'ShippingPackageShapeDisplayField', 'shipping_package_shape_code + '' ('' + shipping_package_shape_name + '')''' UNION ALL
        SELECT 'StateDisplayField', 'state_code + '' ('' + state_name + '')''' UNION ALL
        SELECT 'StoreDisplayField', 'store_name' UNION ALL
        SELECT 'StoreTypeDisplayField', 'store_type_name' UNION ALL
        SELECT 'TaxAuthorityDisplayField', 'tax_authority_code + '' ('' + tax_authority_name + '')''' UNION ALL
        SELECT 'TaxBaseAmountTypeDisplayField', 'tax_base_amount_type_code + '' ('' + tax_base_amount_type_name + '')''' UNION ALL
        SELECT 'TaxExemptTypeDisplayField', 'tax_exempt_type_code + '' ('' + tax_exempt_type_name + '')''' UNION ALL
        SELECT 'TaxRateTypeDisplayField', 'tax_rate_type_code + '' ('' + tax_rate_type_name + '')''' UNION ALL
        SELECT 'TaxDisplayField', 'tax_name' UNION ALL
        SELECT 'TaxTypeDisplayField', 'tax_type_code + '' ('' + tax_type_name + '')''' UNION ALL
        SELECT 'TaxMasterDisplayField', 'tax_master_code + '' ('' + tax_master_name + '')''' UNION ALL
        SELECT 'TransactionTypeDisplayField', 'transaction_type_code + '' ('' + transaction_type_name + '')''' UNION ALL
        SELECT 'UnitDisplayField', 'unit_name' UNION ALL
        SELECT 'UserDisplayField', 'user_name';
    END IF;


    IF NOT EXISTS (
        SELECT 1 
        FROM   pg_catalog.pg_class c
        JOIN   pg_catalog.pg_namespace n ON n.oid = c.relnamespace
        WHERE  n.nspname = 'config'
        AND    c.relname = 'messaging'
        AND    c.relkind = 'r'
    ) THEN
        CREATE TABLE config.messaging
        (
            key                 text PRIMARY KEY,
            value               text,
            audit_user_id       integer NULL REFERENCES office.users(user_id),
            audit_ts            TIMESTAMP WITH TIME ZONE NULL 
                                DEFAULT(NOW())
        );

        INSERT INTO config.messaging
        SELECT 'FromDisplayName',                   'MixERP' UNION ALL
        SELECT 'FromEmailAddress',                  'mixerp@localhost' UNION ALL
        SELECT 'SmtpDeliveryMethod',                'SpecifiedPickupDirectory' UNION ALL
        SELECT 'SpecifiedPickupDirectoryLocation',  '~/Resource/Static/Emails' UNION ALL
        SELECT 'SMTPHost',                          'smtp-mail.outlook.com' UNION ALL
        SELECT 'SMTPPort',                          '587' UNION ALL
        SELECT 'SMTPEnableSSL',                     'false' UNION ALL
        SELECT 'SMTPUserName',                      '' UNION ALL
        SELECT 'SMTPPassword',                      '';
    END IF;


    IF NOT EXISTS (
        SELECT 1 
        FROM   pg_catalog.pg_class c
        JOIN   pg_catalog.pg_namespace n ON n.oid = c.relnamespace
        WHERE  n.nspname = 'config'
        AND    c.relname = 'mixerp'
        AND    c.relkind = 'r'
    ) THEN
        CREATE TABLE config.mixerp
        (
            key                 text PRIMARY KEY,
            value               text,
            description         text,
            audit_user_id       integer NULL REFERENCES office.users(user_id),
            audit_ts            TIMESTAMP WITH TIME ZONE NULL 
                                DEFAULT(NOW())
        );

        INSERT INTO config.mixerp
        SELECT 'MinimumLogLevel', 'Information', '' UNION ALL
        SELECT 'ApplicationLogDirectory', 'C:\mixerp-logs', 'Must be a physical path and application pool identity user must be able to write to it.' UNION ALL
        SELECT 'Mode', 'Development', '';
    END IF;


    IF NOT EXISTS (
        SELECT 1 
        FROM   pg_catalog.pg_class c
        JOIN   pg_catalog.pg_namespace n ON n.oid = c.relnamespace
        WHERE  n.nspname = 'config'
        AND    c.relname = 'open_exchange_rates'
        AND    c.relkind = 'r'
    ) THEN
        CREATE TABLE config.open_exchange_rates
        (
            key                 text PRIMARY KEY,
            value               text,
            description         text,
            audit_user_id       integer NULL REFERENCES office.users(user_id),
            audit_ts            TIMESTAMP WITH TIME ZONE NULL 
                                DEFAULT(NOW())
        );

        INSERT INTO config.open_exchange_rates
        SELECT 'Enabled', 'true', '' UNION ALL
        SELECT 'UserAgent', 'MixERP', '' UNION ALL
        SELECT 'MediaType', 'application/json', '' UNION ALL
        SELECT 'AppId', '', '' UNION ALL
        SELECT 'APIUrl', 'http://openexchangerates.org/api/latest.json', '' UNION ALL
        SELECT 'AppIdKey', 'app_id', '' UNION ALL
        SELECT 'CurrenciesKey', 'symbols', '' UNION ALL
        SELECT 'SpecificCurrencies', 'false', '' UNION ALL
        SELECT 'BaseCurrencyKey', 'base', '' UNION ALL
        SELECT 'DecimalPlaces', '4', '' UNION ALL
        SELECT 'ResultSubKey', 'rates', 'The sub-key which contains list of converted currencies';
    END IF;

    IF NOT EXISTS (
        SELECT 1 
        FROM   pg_catalog.pg_class c
        JOIN   pg_catalog.pg_namespace n ON n.oid = c.relnamespace
        WHERE  n.nspname = 'config'
        AND    c.relname = 'scrud_factory'
        AND    c.relkind = 'r'
    ) THEN
        CREATE TABLE config.scrud_factory
        (
            key                 text PRIMARY KEY,
            value               text,
            audit_user_id       integer NULL REFERENCES office.users(user_id),
            audit_ts            TIMESTAMP WITH TIME ZONE NULL 
                                DEFAULT(NOW())
        );

        INSERT INTO config.scrud_factory
        SELECT 'CommandPanelCssClass', 'vpad16' UNION ALL
        SELECT 'CommandPanelButtonCssClass', 'small ui button' UNION ALL
        SELECT 'SelectButtonIconCssClass', '' UNION ALL
        SELECT 'CompactButtonIconCssClass', '' UNION ALL
        SELECT 'AllButtonIconCssClass', '' UNION ALL
        SELECT 'AddButtonIconCssClass', '' UNION ALL
        SELECT 'EditButtonIconCssClass', '' UNION ALL
        SELECT 'DeleteButtonIconCssClass', '' UNION ALL
        SELECT 'PrintButtonIconCssClass', '' UNION ALL
        SELECT 'DescriptionCssClass', 'ui large purple header' UNION ALL
        SELECT 'ErrorCssClass', 'error-message' UNION ALL
        SELECT 'ExpressionSeparator', '-->' UNION ALL
        SELECT 'FailiureCssClass', 'big error' UNION ALL
        SELECT 'FormCssClass', 'form-panel ui segment' UNION ALL
        SELECT 'FormPanelCssClass', 'ui form' UNION ALL
        SELECT 'GridPanelCssClass', 'segment' UNION ALL
        SELECT 'GridViewAlternateRowCssClass', '' UNION ALL
        SELECT 'GridViewCssClass', 'ui celled striped definition sortable table segment' UNION ALL
        SELECT 'GridViewDefaultWidth', '100%' UNION ALL
        SELECT 'GridPanelDefaultWidth', '1000px' UNION ALL
        SELECT 'GridPanelStyle', 'padding:2px;overflow:auto;' UNION ALL
        SELECT 'GridViewRowCssClass', 'gridview-row pointer' UNION ALL
        SELECT 'HeaderPath', '~/Reports/Assets/Header.aspx' UNION ALL
        SELECT 'ItemSelectorAnchorCssClass', '' UNION ALL
        SELECT 'ItemSelectorPath', '~/General/ItemSelector.aspx' UNION ALL
        SELECT 'ItemSelectorSelectAnchorCssClass', 'linkbutton' UNION ALL
        SELECT 'ItemSeparator', ',' UNION ALL
        SELECT 'PagerCssClass', 'ui pagination menu vmargin8' UNION ALL
        SELECT 'PagerCurrentPageCssClass', 'active item' UNION ALL
        SELECT 'PagerPageButtonCssClass', 'item' UNION ALL
        SELECT 'PageSize', '10' UNION ALL
        SELECT 'ResourceClassName', 'ScrudResource' UNION ALL
        SELECT 'ButtonCssClass', 'small ui button' UNION ALL
        SELECT 'SaveButtonCssClass', 'small ui button' UNION ALL
        SELECT 'SuccessCssClass', 'ui large green header' UNION ALL
        SELECT 'TemplatePath', '~/Reports/Print.html' UNION ALL
        SELECT 'TempMediaPath', '~/Media/Temp' UNION ALL
        SELECT 'TitleLabelCssClass', 'title' UNION ALL
        SELECT 'UpdateProgressSpinnerImageCssClass', 'ajax-loader' UNION ALL
        SELECT 'UpdateProgressSpinnerImagePath', '~/Static/images/spinner.gif' UNION ALL
        SELECT 'UpdateProgressTemplateCssClass', 'ajax-container';
    END IF;


    IF NOT EXISTS (
        SELECT 1 
        FROM   pg_catalog.pg_class c
        JOIN   pg_catalog.pg_namespace n ON n.oid = c.relnamespace
        WHERE  n.nspname = 'config'
        AND    c.relname = 'switches'
        AND    c.relkind = 'r'
    ) THEN
        CREATE TABLE config.switches
        (
            key                 text PRIMARY KEY,
            value               boolean,
            audit_user_id       integer NULL REFERENCES office.users(user_id),
            audit_ts            TIMESTAMP WITH TIME ZONE NULL 
                                DEFAULT(NOW())
        );

        INSERT INTO config.switches
        SELECT 'AllowParentAccountInGLTransaction', false UNION ALL
        SELECT 'AllowMultipleOpeningInventory', false;
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
        WHERE  n.nspname = 'transactions'
        AND    c.relname = 'inventory_transfer_deliveries'
        AND    c.relkind = 'r'
    ) THEN
        CREATE TABLE transactions.inventory_transfer_deliveries
        (
            inventory_transfer_delivery_id              BIGSERIAL NOT NULL PRIMARY KEY,
            inventory_transfer_request_id               bigint NOT NULL REFERENCES transactions.inventory_transfer_requests(inventory_transfer_request_id),
            office_id                                   integer NOT NULL REFERENCES office.offices(office_id),
            user_id                                     integer NOT NULL REFERENCES office.users(user_id),
            login_id                                    bigint NOT NULL REFERENCES audit.logins(login_id),
            source_store_id                             integer NOT NULL REFERENCES office.stores(store_id),
            destination_store_id                        integer NOT NULL REFERENCES office.stores(store_id)
                                                        CONSTRAINT inventory_transfer_deliveries_store_chk
                                                        CHECK(source_store_id <> destination_store_id),
            value_date                                  date NOT NULL,
            transaction_ts                              TIMESTAMP WITH TIME ZONE DEFAULT(now()),
            reference_number                            national character varying(24) NOT NULL,
            statement_reference                         text,
            audit_ts                                    TIMESTAMP WITH TIME ZONE DEFAULT(now())
        );

        CREATE UNIQUE INDEX inventory_transfer_deliveries_inventory_transfer_request_id_uix
        ON transactions.inventory_transfer_deliveries(inventory_transfer_request_id);

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
        WHERE  n.nspname = 'transactions'
        AND    c.relname = 'inventory_transfer_delivery_details'
        AND    c.relkind = 'r'
    ) THEN
        CREATE TABLE transactions.inventory_transfer_delivery_details
        (
            inventory_transfer_delivery_detail_id       BIGSERIAL NOT NULL PRIMARY KEY,
            inventory_transfer_delivery_id              bigint NOT NULL REFERENCES transactions.inventory_transfer_deliveries(inventory_transfer_delivery_id),
            value_date                                  date NOT NULL,
            item_id                                     integer NOT NULL REFERENCES core.items(item_id),
            quantity                                    integer NOT NULL,
            unit_id                                     integer NOT NULL REFERENCES core.units(unit_id),
            base_quantity                               numeric NOT NULL,
            base_unit_id                                integer NOT NULL REFERENCES core.units(unit_id)
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
        SELECT *
        FROM   pg_attribute 
        WHERE  attrelid = 'office.offices'::regclass
        AND    attname IN ('transaction_start_date')
        AND    NOT attisdropped
    ) THEN

        ALTER TABLE office.offices
        ADD COLUMN transaction_start_date DATE NOT NULL DEFAULT(NOW());
    END IF;
END
$$
LANGUAGE plpgsql;


DO
$$
BEGIN
    IF NOT EXISTS
    (
        SELECT *
        FROM   pg_attribute 
        WHERE  attrelid = 'office.offices'::regclass
        AND    attname IN ('week_start_day')
        AND    NOT attisdropped
    ) THEN

        ALTER TABLE office.offices
        ADD COLUMN week_start_day int NOT NULL
        CHECK (week_start_day > 0 AND week_start_day < 8)
        DEFAULT(2);
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
        WHERE  n.nspname = 'office'
        AND    c.relname = 'holidays'
        AND    c.relkind = 'r'
    ) THEN
        CREATE TABLE office.holidays
        (
            holiday_id                          integer NOT NULL PRIMARY KEY,
            office_id                           integer NOT NULL REFERENCES office.offices(office_id),
            falls_on                            date,
            holiday_name                        national character varying(100) NOT NULL,
            description                         text,
            recurs_next_year                    boolean NOT NULL DEFAULT(true),
            audit_user_id                       integer NULL REFERENCES office.users(user_id),
            audit_ts                            TIMESTAMP WITH TIME ZONE NULL        
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
        AND    c.relname = 'custom_field_data_types'
        AND    c.relkind = 'r'
    ) THEN
        CREATE TABLE core.custom_field_data_types
        (
            data_type               national character varying(50) NOT NULL PRIMARY KEY,
            is_number               boolean DEFAULT(false),
            is_date                 boolean DEFAULT(false),
            is_boolean              boolean DEFAULT(false),
            is_long_text            boolean DEFAULT(false)
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
        AND    c.relname = 'custom_field_forms'
        AND    c.relkind = 'r'
    ) THEN
        CREATE TABLE core.custom_field_forms
        (
            form_name                   national character varying(100) NOT NULL PRIMARY KEY,
            table_name                  national character varying(100) NOT NULL UNIQUE,
            key_name                    national character varying(100) NOT NULL        
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
        AND    c.relname = 'custom_field_setup'
        AND    c.relkind = 'r'
    ) THEN
        CREATE TABLE core.custom_field_setup
        (
            custom_field_setup_id       SERIAL NOT NULL PRIMARY KEY,
            form_name                   national character varying(100) NOT NULL
                                        REFERENCES core.custom_field_forms,
            field_order                 integer NOT NULL DEFAULT(0),
            field_name                  national character varying(100) NOT NULL,
            field_label                 national character varying(100) NOT NULL,                   
            data_type                   national character varying(50)
                                        REFERENCES core.custom_field_data_types,
            description                 text NOT NULL
        );

        CREATE UNIQUE INDEX custom_field_setup_uix
        ON core.custom_field_setup(UPPER(form_name), UPPER(field_label));
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
        AND    c.relname = 'custom_fields'
        AND    c.relkind = 'r'
    ) THEN
        CREATE TABLE core.custom_fields
        (
            custom_field_id             BIGSERIAL NOT NULL PRIMARY KEY,
            custom_field_setup_id       integer NOT NULL REFERENCES core.custom_field_setup,
            resource_id                 text NOT NULL,
            value                       text
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
        SELECT * FROM config.scrud_factory
        WHERE key = 'ExportTemplatePath'
    ) THEN
        INSERT INTO config.scrud_factory
        SELECT 'ExportTemplatePath', '~/Reports/Export.html';
    END IF;
END
$$
LANGUAGE plpgsql;

DO
$$
BEGIN
    IF NOT EXISTS
    (
        SELECT *
        FROM   pg_attribute 
        WHERE  attrelid = 'office.offices'::regclass
        AND    attname IN ('primary_sales_tax_is_vat')
        AND    NOT attisdropped
    ) THEN
        ALTER TABLE office.offices
        ADD COLUMN primary_sales_tax_is_vat bool NOT NULL DEFAULT(false);
    END IF;
END
$$
LANGUAGE plpgsql;

DO
$$
BEGIN
    IF NOT EXISTS
    (
        SELECT *
        FROM   pg_attribute 
        WHERE  attrelid = 'office.offices'::regclass
        AND    attname IN ('has_state_sales_tax')
        AND    NOT attisdropped
    ) THEN
        ALTER TABLE office.offices
        ADD COLUMN has_state_sales_tax bool NOT NULL DEFAULT(false);
    END IF;
END
$$
LANGUAGE plpgsql;

DO
$$
BEGIN
    IF NOT EXISTS
    (
        SELECT *
        FROM   pg_attribute 
        WHERE  attrelid = 'office.offices'::regclass
        AND    attname IN ('has_county_sales_tax')
        AND    NOT attisdropped
    ) THEN
        ALTER TABLE office.offices
        ADD COLUMN has_county_sales_tax bool NOT NULL DEFAULT(false);
    END IF;
END
$$
LANGUAGE plpgsql;

DO
$$
BEGIN
    IF NOT EXISTS
    (
        SELECT *
        FROM   pg_attribute 
        WHERE  attrelid = 'office.offices'::regclass
        AND    attname IN ('logo_file')
        AND    NOT attisdropped
    ) THEN
        ALTER TABLE office.offices
        ADD COLUMN logo_file text NOT NULL DEFAULT('');
    END IF;
END
$$
LANGUAGE plpgsql;

DROP INDEX IF EXISTS core.salespersons_salesperson_name_uix;
DROP INDEX IF EXISTS core.salespersons_salesperson_code_uix;

CREATE UNIQUE INDEX salespersons_salesperson_code_uix
ON core.salespersons(salesperson_code);

DROP INDEX IF EXISTS core.cash_flow_setup_cash_flow_heading_id_account_master_id_uix;

CREATE UNIQUE INDEX cash_flow_setup_cash_flow_heading_id_account_master_id_uix
ON core.cash_flow_setup (account_master_id,cash_flow_heading_id);

DROP INDEX IF EXISTS core.frequency_setups_frequency_setup_code_uix;

CREATE UNIQUE INDEX frequency_setups_frequency_setup_code_uix
ON core.frequency_setups(UPPER(fiscal_year_code), UPPER(frequency_setup_code));

DO
$$
BEGIN
    IF NOT EXISTS (
        SELECT 1 
        FROM   pg_catalog.pg_class c
        JOIN   pg_catalog.pg_namespace n ON n.oid = c.relnamespace
        WHERE  n.nspname = 'core'
        AND    c.relname = 'email_queue'
        AND    c.relkind = 'r'
    ) THEN
        CREATE TABLE core.email_queue
        (
            queue_id                BIGSERIAL NOT NULL PRIMARY KEY,
            subject                 national character varying(256) NOT NULL,
            send_to                 national character varying(256) NOT NULL,
            attachments             text,
            message                 text NOT NULL,
            added_on                TIMESTAMP WITH TIME ZONE NOT NULL DEFAULT(NOW()),
            delivered               boolean NOT NULL DEFAULT(false),
            delivered_on            TIMESTAMP WITH TIME ZONE
        );
    END IF;
END
$$
LANGUAGE plpgsql;

DROP INDEX IF EXISTS office.configuration_config_id_office_id_uix;

CREATE UNIQUE INDEX configuration_config_id_office_id_uix
ON office.configuration(config_id, office_id);



DO
$$
BEGIN
    IF NOT EXISTS
    (
        SELECT typname FROM pg_catalog.pg_type 
        WHERE typname = 'image'
    ) THEN
        CREATE DOMAIN public.image AS text;
    END IF;
END
$$
LANGUAGE plpgsql;

DO
$$
BEGIN
    IF EXISTS
    (
        SELECT *
        FROM   pg_attribute 
        WHERE  attrelid = 'office.offices'::regclass
        AND    attname IN ('logo_file')
        AND    NOT attisdropped
    ) THEN
        DROP VIEW IF EXISTS office.sign_in_view;
        ALTER TABLE office.offices
        ALTER COLUMN logo_file TYPE public.image;
    END IF;
END
$$
LANGUAGE plpgsql;

DO
$$
BEGIN
    IF
    (
        SELECT a.attname
        FROM   pg_index i
        JOIN   pg_attribute a ON a.attrelid = i.indrelid
                             AND a.attnum = ANY(i.indkey)
        WHERE  i.indrelid = 'core.widgets'::regclass
        AND    i.indisprimary
    ) = 'widget_id' THEN
        ALTER TABLE core.widgets
        DROP CONSTRAINT IF EXISTS widgets_pkey;

        ALTER TABLE core.widgets
        ADD PRIMARY KEY(widget_name);

        ALTER TABLE core.widgets
        DROP COLUMN IF EXISTS row_number;

        ALTER TABLE core.widgets
        DROP COLUMN IF EXISTS column_number;
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
        AND    c.relname = 'widget_groups'
        AND    c.relkind = 'r'
    ) THEN
        CREATE TABLE core.widget_groups
        (
            widget_group_name       national character varying(100) NOT NULL PRIMARY KEY,
            is_default              boolean NOT NULL DEFAULT(false)
        );

        INSERT INTO core.widget_groups
        SELECT 'Default', true;
    END IF;
    
    IF NOT EXISTS (
        SELECT 1 
        FROM   pg_catalog.pg_class c
        JOIN   pg_catalog.pg_namespace n ON n.oid = c.relnamespace
        WHERE  n.nspname = 'core'
        AND    c.relname = 'widget_setup'
        AND    c.relkind = 'r'
    ) THEN
        CREATE TABLE core.widget_setup
        (
            widget_setup_id         SERIAL NOT NULL PRIMARY KEY,
            widget_order            integer NOT NULL,
            widget_group_name       national character varying(100) NOT NULL REFERENCES core.widget_groups,
            widget_name             national character varying(100) NOT NULL REFERENCES core.widgets
        );

        CREATE INDEX widget_setup_widget_order_inx
        ON core.widget_setup(widget_order);

        INSERT INTO core.widget_setup(widget_order, widget_group_name, widget_name)
        SELECT 1, 'Default', 'SalesByGeographyWidget' UNION ALL
        SELECT 2, 'Default', 'SalesByOfficeWidget' UNION ALL
        SELECT 3, 'Default', 'CurrentOfficeSalesByMonthWidget' UNION ALL
        SELECT 4, 'Default', 'OfficeInformationWidget' UNION ALL
        SELECT 5, 'Default', 'LinksWidget' UNION ALL
        SELECT 6, 'Default', 'WorkflowWidget' UNION ALL
        SELECT 7, 'Default', 'TopSellingProductOfAllTimeWidget' UNION ALL
        SELECT 8, 'Default', 'TopSellingProductOfAllTimeCurrentWidget';
    END IF;
END
$$
LANGUAGE plpgsql;

DROP TABLE IF EXISTS config.messaging CASCADE;

DO
$$
BEGIN
    IF NOT EXISTS (
        SELECT 1 
        FROM   pg_catalog.pg_class c
        JOIN   pg_catalog.pg_namespace n ON n.oid = c.relnamespace
        WHERE  n.nspname = 'config'
        AND    c.relname = 'smtp'
        AND    c.relkind = 'r'
    ) THEN
        CREATE TABLE config.smtp
        (
            smtp_id                             SERIAL NOT NULL PRIMARY KEY,
            configuration_name                  national character varying(256) NOT NULL UNIQUE,
            enabled                             boolean NOT NULL DEFAULT(false),
            is_default                          boolean NOT NULL DEFAULT(false),
            from_display_name                   national character varying(256) NOT NULL,
            from_email_address                  national character varying(256) NOT NULL,
            smtp_host                           national character varying(256) NOT NULL,
            smtp_port                           public.integer_strict NOT NULL,
            smtp_enable_ssl                     boolean NOT NULL DEFAULT(true),
            smtp_username                       national character varying(256) NOT NULL,
            smtp_password                       national character varying(256) NOT NULL,
            audit_user_id                       integer NULL REFERENCES office.users(user_id),
            audit_ts                            TIMESTAMP WITH TIME ZONE NULL 
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
        WHERE  attrelid = 'core.email_queue'::regclass
        AND    attname = 'transaction_master_id'
        AND    NOT attisdropped
    ) THEN
        ALTER TABLE core.email_queue
        ADD COLUMN transaction_master_id bigint REFERENCES transactions.transaction_master;
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
        WHERE  attrelid = 'core.email_queue'::regclass
        AND    attname = 'canceled'
        AND    NOT attisdropped
    ) THEN
        ALTER TABLE core.email_queue
        ADD COLUMN canceled BOOLEAN NOT NULL DEFAULT(false);
    END IF;
END
$$
LANGUAGE plpgsql;


DO
$$
BEGIN
    IF NOT EXISTS
    (
        SELECT *
        FROM   pg_attribute 
        WHERE  attrelid = 'core.parties'::regclass
        AND    attname IN ('photo')
        AND    NOT attisdropped
    ) THEN
        ALTER TABLE core.parties
        ADD COLUMN photo public.image;
    END IF;
END
$$
LANGUAGE plpgsql;


DO
$$
BEGIN
    IF NOT EXISTS
    (
        SELECT *
        FROM   pg_attribute 
        WHERE  attrelid = 'core.items'::regclass
        AND    attname IN ('photo')
        AND    NOT attisdropped
    ) THEN
        ALTER TABLE core.items
        ADD COLUMN photo public.image;
    END IF;
END
$$
LANGUAGE plpgsql;


DO
$$
BEGIN
    IF EXISTS
    (
        SELECT 1
        FROM   pg_attribute 
        WHERE  attrelid = 'config.smtp'::regclass
        AND    attname = 'smp_host'
        AND    NOT attisdropped
    ) THEN
        ALTER TABLE config.smtp
        RENAME COLUMN smp_host TO smtp_host;
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
        WHERE  attrelid = 'config.smtp'::regclass
        AND    attname = 'smtp_port'
        AND    NOT attisdropped
    ) THEN
        ALTER TABLE config.smtp
        ADD COLUMN smtp_port public.integer_strict NOT NULL DEFAULT(587);
    END IF;
END
$$
LANGUAGE plpgsql;


DROP VIEW IF EXISTS core.item_view;
DROP VIEW IF EXISTS core.item_selector_view;
DROP VIEW IF EXISTS core.item_scrud_view;

ALTER TABLE core.items
ALTER COLUMN cost_price TYPE public.money_strict2;

ALTER TABLE core.parties
ALTER COLUMN state_id DROP NOT NULL;

DO
$$
BEGIN
    IF NOT EXISTS
    (
        SELECT 1
        FROM   pg_attribute 
        WHERE  attrelid = 'policy.auto_verification_policy'::regclass
        AND    attname = 'policy_id'
        AND    NOT attisdropped
    ) THEN
        ALTER TABLE IF EXISTS policy.auto_verification_policy
        RENAME TO auto_verification_policy_temp;


        CREATE TABLE policy.auto_verification_policy
        (
          policy_id                     SERIAL NOT NULL PRIMARY KEY,
          user_id                       integer NOT NULL REFERENCES office.users (user_id),
          office_id                     integer NOT NULL REFERENCES office.offices (office_id),
          verify_sales_transactions     boolean NOT NULL DEFAULT false,
          sales_verification_limit      public.money_strict2 NOT NULL DEFAULT 0,
          verify_purchase_transactions  boolean NOT NULL DEFAULT false,
          purchase_verification_limit   public.money_strict2 NOT NULL DEFAULT 0,
          verify_gl_transactions        boolean NOT NULL DEFAULT false,
          gl_verification_limit         public.money_strict2 NOT NULL DEFAULT 0,
          effective_from                date NOT NULL,
          ends_on                       date NOT NULL,
          is_active                     boolean NOT NULL,
          audit_user_id                 integer REFERENCES office.users (user_id),
          audit_ts                      timestamp with time zone DEFAULT now()
        );

        CREATE UNIQUE INDEX auto_verification_policy_office_id_user_id_uix
        ON policy.auto_verification_policy(office_id, user_id)
        WHERE is_active;
        
        INSERT INTO policy.auto_verification_policy
        (
            user_id, 
            office_id,
            verify_sales_transactions, 
            sales_verification_limit, 
            verify_purchase_transactions, 
            purchase_verification_limit, 
            verify_gl_transactions,  
            gl_verification_limit,
            effective_from,
            ends_on,
            is_active,
            audit_user_id,
            audit_ts
        )
        SELECT
            user_id, 
            office_id,
            verify_sales_transactions, 
            sales_verification_limit, 
            verify_purchase_transactions, 
            purchase_verification_limit, 
            verify_gl_transactions,  
            gl_verification_limit,
            effective_from,
            ends_on,
            is_active,
            audit_user_id,
            audit_ts
        FROM policy.auto_verification_policy_temp;

        DROP TABLE policy.auto_verification_policy_temp CASCADE;
    END IF;
END
$$
LANGUAGE plpgsql;


