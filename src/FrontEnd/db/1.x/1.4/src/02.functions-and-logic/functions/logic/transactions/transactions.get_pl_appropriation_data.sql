DROP FUNCTION IF EXISTS transactions.get_pl_appropriation_data(_office_id integer);

CREATE FUNCTION transactions.get_pl_appropriation_data(_office_id integer)
RETURNS TABLE
(
    account_id          bigint,
    account_number      text,
    account_name        text,
    debit               decimal(24, 4),
    credit              decimal(24, 4)
)
AS
$$
    DECLARE _start_date  date = core.get_fiscal_year_start_date(_office_id);
    DECLARE _end_date    date = core.get_fiscal_year_end_date(_office_id);
    DECLARE _value_date  date = transactions.get_value_date(_office_id);
BEGIN
    IF(_value_date <> _end_date) THEN
        RAISE EXCEPTION 'Access is denied.'
        USING ERRCODE='P9001';
    END IF;    

    IF EXISTS
    (
        SELECT * FROM transactions.transaction_master
        WHERE verification_status_id = 0
        AND value_date <= _end_date
        LIMIT 1
    ) THEN
        RAISE EXCEPTION 'There are still transactions in verification queue.'
        USING ERRCODE='P5105';
    END IF;

    IF EXISTS
    (
        SELECT * FROM office.offices
        WHERE parent_office_id = _office_id
    ) THEN
        RAISE EXCEPTION 'You cannot perform PL appropriation on an office group.'
        USING ERRCODE='P5106';
    END IF;

    DROP TABLE IF EXISTS temp_pl_appropriation;
    CREATE TEMPORARY TABLE temp_pl_appropriation
    (
        account_id          bigint,
        account_number      text,
        account_name        text,
        has_children        boolean,
        balance             decimal(24, 4),
        debit               decimal(24, 4),
        credit              decimal(24, 4)
    ) ON COMMIT DROP;

    INSERT INTO temp_pl_appropriation(account_id, account_number, account_name)
    SELECT 
        core.accounts.account_id, 
        core.accounts.account_number, 
        core.accounts.account_name
    FROM core.accounts
    WHERE account_master_id >= 20100
    ORDER BY account_id;

    UPDATE temp_pl_appropriation
    SET has_children = true
    WHERE temp_pl_appropriation.account_id IN
    (
        SELECT distinct parent_account_id FROM core.accounts
        WHERE parent_account_id IS NOT NULL
    );

    UPDATE temp_pl_appropriation
    SET balance = summary.balance
    FROM
    (
        SELECT
            transactions.verified_transaction_view.account_id,
            SUM
            (
                CASE tran_type 
                WHEN 'Cr' 
                THEN amount_in_local_currency 
                ELSE amount_in_local_currency * -1 
                END
            ) AS balance
        FROM transactions.verified_transaction_view
        WHERE account_master_id >= 20100
        AND office_id = _office_id
        AND transactions.verified_transaction_view.value_date BETWEEN _start_date AND _end_date
        GROUP BY transactions.verified_transaction_view.account_id
    ) AS summary
    WHERE temp_pl_appropriation.account_id = summary.account_id;

    UPDATE temp_pl_appropriation
    SET debit = balance
    WHERE balance >=0;

    UPDATE temp_pl_appropriation
    SET credit = balance * -1
    WHERE balance < 0;

    DELETE FROM temp_pl_appropriation
    WHERE COALESCE(balance, 0) = 0;
    
    RETURN QUERY
    SELECT
        temp_pl_appropriation.account_id,
        temp_pl_appropriation.account_number,
        temp_pl_appropriation.account_name,
        temp_pl_appropriation.debit,
        temp_pl_appropriation.credit
    FROM temp_pl_appropriation;
END
$$
LANGUAGE plpgsql;

--SELECT * FROM transactions.get_pl_appropriation_data(2);