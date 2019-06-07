DROP FUNCTION IF EXISTS transactions.get_party_transaction_summary
(
    office_id integer, 
    party_id bigint
);

DROP FUNCTION IF EXISTS transactions.get_party_transaction_summary
(
    office_id integer, 
    party_id bigint, 
    OUT currency_code text, 
    OUT currency_symbol text, 
    OUT total_due_amount decimal(24, 4), 
    OUT office_due_amount decimal(24, 4), 
    OUT last_receipt_date date, 
    OUT transaction_value decimal(24, 4)
);

CREATE FUNCTION transactions.get_party_transaction_summary
(
    office_id integer, 
    party_id bigint
)
RETURNS TABLE
(
    currency_code               text, 
    currency_symbol             text, 
    total_due_amount            decimal(24, 4), 
    office_due_amount           decimal(24, 4), 
    last_receipt_date           date, 
    transaction_value           decimal(24, 4)
)
AS
$$
    DECLARE root_office_id      integer = 0;
    DECLARE _currency_code      text; 
    DECLARE _currency_symbol    text;
    DECLARE _total_due_amount   decimal(24, 4); 
    DECLARE _office_due_amount  decimal(24, 4); 
    DECLARE _last_receipt_date  date;
    DECLARE _transaction_value  decimal(24, 4);
BEGIN
    _currency_code := core.get_currency_code_by_party_id(party_id);

    SELECT core.currencies.currency_symbol 
    INTO _currency_symbol
    FROM core.currencies
    WHERE core.currencies.currency_code = $3;

    SELECT office.offices.office_id INTO root_office_id
    FROM office.offices
    WHERE parent_office_id IS NULL;

    _total_due_amount := transactions.get_total_due(root_office_id, party_id);
    _office_due_amount := transactions.get_total_due(office_id, party_id);
    _last_receipt_date := transactions.get_last_receipt_date(office_id, party_id);
    _transaction_value := transactions.get_average_party_transaction(party_id, office_id);

    RETURN QUERY
    SELECT _currency_code, _currency_symbol, _total_due_amount, _office_due_amount, _last_receipt_date, _transaction_value;
END
$$
LANGUAGE plpgsql;

--select * from transactions.get_party_transaction_summary(2,1);