DROP FUNCTION IF EXISTS office.add_office
(
    _office_code            national character varying(12),
    _office_name            national character varying(150),
    _nick_name              national character varying(50),
    _registration_date      date,
    _currency_code          national character varying(12),
    _currency_symbol        national character varying(12),
    _currency_name          national character varying(48),
    _hundredth_name         national character varying(48),
    _admin_name             national character varying(100),
    _user_name              national character varying(50),
    _password               national character varying(48)
);

DROP FUNCTION IF EXISTS office.add_office
(
    _office_code            national character varying(12),
    _office_name            national character varying(150),
    _nick_name              national character varying(50),
    _registration_date      date,
    _currency_code          national character varying(12),
    _currency_symbol        national character varying(12),
    _currency_name          national character varying(48),
    _hundredth_name         national character varying(48),
    _fiscal_year_code       national character varying(12),
    _fiscal_year_name       national character varying(50),
    _starts_from            date,
    _ends_on                date,
    _admin_name             national character varying(100),
    _user_name              national character varying(50),
    _password               national character varying(48)
);

DROP FUNCTION IF EXISTS office.add_office
(
    _office_code            national character varying(12),
    _office_name            national character varying(150),
    _nick_name              national character varying(50),
    _registration_date      date,
    _currency_code          national character varying(12),
    _currency_symbol        national character varying(12),
    _currency_name          national character varying(48),
    _hundredth_name         national character varying(48),
    _fiscal_year_code       national character varying(12),
    _fiscal_year_name       national character varying(50),
    _starts_from            date,
    _ends_on                date,
    _income_tax_rate        decimal(24, 4),
    _week_start_day         integer,
    _transaction_start_date date,
    _admin_name             national character varying(100),
    _user_name              national character varying(50),
    _password               national character varying(48)
);

DROP FUNCTION IF EXISTS office.add_office
(
    _office_code            national character varying(12),
    _office_name            national character varying(150),
    _nick_name              national character varying(50),
    _registration_date      date,
    _currency_code          national character varying(12),
    _currency_symbol        national character varying(12),
    _currency_name          national character varying(48),
    _hundredth_name         national character varying(48),
    _fiscal_year_code       national character varying(12),
    _fiscal_year_name       national character varying(50),
    _starts_from            date,
    _ends_on                date,
    _sales_tax_is_vat       boolean,
    _has_state_sales_tax    boolean,
    _has_county_sales_tax   boolean,
    _income_tax_rate        decimal(24, 4),
    _week_start_day         integer,
    _transaction_start_date date,
    _is_perpetual           boolean,
    _inv_valuation_method   national character varying(5),
    _logo_file              text,
    _admin_name             national character varying(100),
    _user_name              national character varying(50),
    _password               national character varying(48)
);

DROP FUNCTION IF EXISTS office.add_office
(
    _office_code            national character varying(12),
    _office_name            national character varying(150),
    _nick_name              national character varying(50),
    _registration_date      date,
    _currency_code          national character varying(12),
    _currency_symbol        national character varying(12),
    _currency_name          national character varying(48),
    _hundredth_name         national character varying(48),
    _fiscal_year_code       national character varying(12),
    _fiscal_year_name       national character varying(50),
    _starts_from            date,
    _ends_on                date,
    _sales_tax_is_vat       boolean,
    _has_state_sales_tax    boolean,
    _has_county_sales_tax   boolean,
    _quotation_valid_days   integer,
    _income_tax_rate        decimal(24, 4),
    _week_start_day         integer,
    _transaction_start_date date,
    _is_perpetual           boolean,
    _inv_valuation_method   national character varying(5),
    _logo_file              text,
    _admin_name             national character varying(100),
    _user_name              national character varying(50),
    _password               national character varying(48)
);

CREATE FUNCTION office.add_office
(
    _office_code            national character varying(12),
    _office_name            national character varying(150),
    _nick_name              national character varying(50),
    _registration_date      date,
    _currency_code          national character varying(12),
    _currency_symbol        national character varying(12),
    _currency_name          national character varying(48),
    _hundredth_name         national character varying(48),
    _fiscal_year_code       national character varying(12),
    _fiscal_year_name       national character varying(50),
    _starts_from            date,
    _ends_on                date,
    _sales_tax_is_vat       boolean,
    _has_state_sales_tax    boolean,
    _has_county_sales_tax   boolean,
    _quotation_valid_days   integer,
    _income_tax_rate        decimal(24, 4),
    _week_start_day         integer,
    _transaction_start_date date,
    _is_perpetual           boolean,
    _inv_valuation_method   national character varying(5),
    _logo_file              text,
    _admin_name             national character varying(100),
    _user_name              national character varying(50),
    _password               national character varying(48)
)
RETURNS void 
VOLATILE AS
$$
    DECLARE _office_id          integer;
    DECLARE _user_id		    integer;
    DECLARE _inventory_system   national character varying(12) = 'Perpetual';
BEGIN
    IF(_starts_from > _ends_on) THEN
        RAISE EXCEPTION 'The start date cannot be greater than end date.'
        USING ERRCODE='P5208';
    END IF;

    IF(NOT _is_perpetual) THEN
        _inventory_system := 'Periodic';
    END IF;

    IF NOT EXISTS
    (
        SELECT 0 
        FROM core.currencies
        WHERE currency_code=_currency_code
    ) THEN
        INSERT INTO core.currencies(currency_code, currency_symbol, currency_name, hundredth_name)
        SELECT _currency_code, _currency_symbol, _currency_name, _hundredth_name;
    END IF;

    UPDATE core.accounts
    SET currency_code = _currency_code;

    INSERT INTO office.offices(office_code, office_name, nick_name, registration_date, currency_code, income_tax_rate, transaction_start_date, week_start_day, primary_sales_tax_is_vat, has_state_sales_tax, has_county_sales_tax, logo_file)
    SELECT _office_code, _office_name, _nick_name, _registration_date, _currency_code, _income_tax_rate, _transaction_start_date, _week_start_day, _sales_tax_is_vat, _has_state_sales_tax, _has_county_sales_tax, _logo_file
    RETURNING office_id INTO _office_id;

    --Inventory System
    IF EXISTS(SELECT * FROM office.configuration WHERE config_id = 1 AND office_id = _office_id) THEN
        UPDATE office.configuration
        SET value = _inventory_system
        WHERE config_id = 1 AND office_id = _office_id;
    ELSE
        INSERT INTO office.configuration(config_id, office_id, value, configuration_details)
        SELECT 1, _office_id, _inventory_system, '';
    END IF;

    IF(COALESCE(_quotation_valid_days, 0) = 0) THEN
        _quotation_valid_days = 15;
    END IF;
    
    --Quotation valid duration
    IF EXISTS(SELECT * FROM office.configuration WHERE config_id = 3 AND office_id = _office_id) THEN
        UPDATE office.configuration
        SET value = _quotation_valid_days::text
        WHERE config_id = 3 AND office_id = _office_id;
    ELSE
        INSERT INTO office.configuration(config_id, office_id, value, configuration_details)
        SELECT 3, _office_id, _quotation_valid_days::text, '';
    END IF;

    --COGS Calculation Method/Inventory Valuation Method
    IF EXISTS(SELECT * FROM office.configuration WHERE config_id = 2 AND office_id = _office_id) THEN
        UPDATE office.configuration
        SET value = _inv_valuation_method
        WHERE config_id = 2 AND office_id = _office_id;
    ELSE
        INSERT INTO office.configuration(config_id, office_id, value, configuration_details)
        SELECT 2, _office_id, _inv_valuation_method, '';
    END IF;
    
    IF NOT EXISTS(SELECT 0 FROM office.users WHERE user_name='sys') THEN
        INSERT INTO office.users(role_id, department_id, office_id, user_name, password, full_name)
        SELECT office.get_role_id_by_role_code('SYST'), office.get_department_id_by_department_code('SUP'), _office_id, 'sys', '', 'System';
    END IF;
        
    INSERT INTO office.users(role_id, department_id, office_id,user_name,password, full_name, elevated)
    SELECT office.get_role_id_by_role_code('ADMN'), office.get_department_id_by_department_code('SUP'), _office_id, _user_name, _password, _admin_name, true
    RETURNING user_id INTO _user_id;

    INSERT INTO policy.auto_verification_policy
    (
        office_id,
        user_id, 
        verify_sales_transactions, 
        sales_verification_limit,
        verify_purchase_transactions,
        purchase_verification_limit,
        verify_gl_transactions,
        gl_verification_limit,
        effective_from,
        ends_on,
        is_active
    )
    SELECT 
        _office_id,
        _user_id,
        true,
        0,
        true,
        0,
        true,
        0,
        _starts_from,
        _ends_on,
        true;
        
    INSERT INTO core.fiscal_year(fiscal_year_code, fiscal_year_name, starts_from, ends_on, audit_user_id)
    SELECT _fiscal_year_code, _fiscal_year_name, _starts_from, _ends_on, _user_id;

    INSERT INTO policy.menu_access(office_id, menu_id, user_id)
    SELECT _office_id, core.menus.menu_id, _user_id
    FROM core.menus;

    RETURN;
END;
$$
LANGUAGE plpgsql;

