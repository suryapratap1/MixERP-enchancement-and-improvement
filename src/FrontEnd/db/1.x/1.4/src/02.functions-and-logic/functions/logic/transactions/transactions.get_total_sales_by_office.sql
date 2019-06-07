DROP FUNCTION IF EXISTS transactions.get_total_sales_by_office(_office_id integer);

CREATE FUNCTION transactions.get_total_sales_by_office(_office_id integer)
RETURNS TABLE
(
    office_id               integer,
    office_code             national character varying(12),
    office_name             national character varying(150),
    total_sales             decimal(24, 4)
)
AS
$$
    DECLARE _start_date     date;
    DECLARE _end_date       date;
BEGIN
    SELECT
        core.get_fiscal_year_start_date(_office_id),
        core.get_fiscal_year_end_date(_office_id)
    INTO
        _start_date,
        _end_date;
    
    DROP TABLE IF EXISTS temp_sales;
    CREATE TEMPORARY TABLE temp_sales
    (
        office_id               integer,
        office_code             national character varying(12),
        office_name             national character varying(150),
        total_sales             decimal(24, 4)
    ) ON COMMIT DROP;


    INSERT INTO temp_sales(office_id, total_sales)
    SELECT
        transactions.verified_transaction_mat_view.office_id,
        SUM(amount_in_local_currency) AS total_sales
    FROM transactions.verified_transaction_mat_view
    WHERE book IN ('Sales.Direct', 'Sales.Delivery')
    AND account_master_id = 20100
    AND value_date BETWEEN _start_date AND _end_date
    GROUP BY transactions.verified_transaction_mat_view.office_id;

    UPDATE temp_sales
    SET 
        office_code = office.offices.office_code,
        office_name = office.offices.office_name
    FROM office.offices
    WHERE office.offices.office_id = temp_sales.office_id;

    RETURN QUERY
    SELECT * FROM temp_sales;
END
$$
LANGUAGE plpgsql;

--SELECT * FROM transactions.get_total_sales_by_office(2);