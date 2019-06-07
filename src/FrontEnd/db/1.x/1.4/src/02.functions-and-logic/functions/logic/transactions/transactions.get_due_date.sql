DROP FUNCTION IF EXISTS transactions.get_due_date(_value_date date, _payment_term_id integer) CASCADE;

CREATE FUNCTION transactions.get_due_date(_value_date date, _payment_term_id integer)
RETURNS date
STABLE
AS
$$
    DECLARE _frequency_id       integer;
    DECLARE _due_days           integer;
BEGIN
    IF(_payment_term_id IS NULL OR _value_date IS NULL) THEN
        RETURN NULL;
    END IF;

    SELECT
        due_frequency_id,
        due_days
    INTO
        _frequency_id,
        _due_days
    FROM core.payment_terms
    WHERE payment_term_id = _payment_term_id;

    IF(_frequency_id IS NOT NULL) THEN
        RETURN core.get_frequency_end_date(_frequency_id, _value_date);
    END IF;

    RETURN _value_date + INTERVAL '1 day' * _due_days;
END
$$
LANGUAGE plpgsql;