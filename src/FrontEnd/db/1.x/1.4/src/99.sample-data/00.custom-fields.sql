DO
$$
BEGIN
    IF(core.get_locale() = 'en-US') THEN
        IF NOT EXISTS(SELECT * FROM core.custom_field_data_types WHERE data_type='Text') THEN
            INSERT INTO core.custom_field_data_types(data_type, is_number)
            SELECT 'Text', true;
        END IF;

        IF NOT EXISTS(SELECT * FROM core.custom_field_data_types WHERE data_type='Number') THEN
            INSERT INTO core.custom_field_data_types(data_type, is_number)
            SELECT 'Number', true;
        END IF;

        IF NOT EXISTS(SELECT * FROM core.custom_field_data_types WHERE data_type='Date') THEN
            INSERT INTO core.custom_field_data_types(data_type, is_date)
            SELECT 'Date', true;
        END IF;

        IF NOT EXISTS(SELECT * FROM core.custom_field_data_types WHERE data_type='True/False') THEN
            INSERT INTO core.custom_field_data_types(data_type, is_boolean)
            SELECT 'True/False', true;
        END IF;

        IF NOT EXISTS(SELECT * FROM core.custom_field_data_types WHERE data_type='Long Text') THEN
            INSERT INTO core.custom_field_data_types(data_type, is_long_text)
            SELECT 'Long Text', true;
        END IF;


        PERFORM core.add_custom_field_form('Accounts', 'core.accounts', 'account_id');
        PERFORM core.add_custom_field_form('Items', 'core.items', 'item_id');
        PERFORM core.add_custom_field_form('Parties', 'core.parties', 'party_id');
    END IF;
END
$$
LANGUAGE plpgsql;