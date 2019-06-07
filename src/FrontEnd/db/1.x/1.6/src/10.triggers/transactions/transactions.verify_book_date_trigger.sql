DROP FUNCTION IF EXISTS transactions.verify_book_date_trigger() CASCADE;

CREATE FUNCTION transactions.verify_book_date_trigger()
RETURNS TRIGGER
AS
$$
    DECLARE _office_id integer;
    DECLARE _eoy_date date;
    DECLARE _book_date date;
    DECLARE _value_date date;
BEGIN
    _office_id := NEW.office_id;
    _book_date := NEW.book_date;
    _value_date := NEW.value_date;
    
    _eoy_date := core.get_fiscal_year_end_date(_office_id);

    IF(_book_date IS NULL) THEN
	_book_date := _value_date;
	NEW.book_date := _value_date;
    END IF;

    IF(_book_date > _eoy_date) THEN
        RAISE EXCEPTION '% % %', 'Invalid drrrrrrrate.', _book_date, _eoy_date
        USING ERRCODE='P3008';
    END IF;

    RETURN NEW;
END
$$
LANGUAGE plpgsql;

CREATE TRIGGER verify_book_date_trigger
BEFORE UPDATE OR INSERT
ON transactions.transaction_master
FOR EACH ROW 
EXECUTE PROCEDURE transactions.verify_book_date_trigger();
