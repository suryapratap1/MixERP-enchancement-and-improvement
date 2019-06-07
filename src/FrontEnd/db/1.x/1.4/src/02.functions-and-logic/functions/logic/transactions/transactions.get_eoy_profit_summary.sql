DROP FUNCTION IF EXISTS transactions.get_eoy_profit_summary
(
    _office_id              integer
);

CREATE FUNCTION transactions.get_eoy_profit_summary
(
    _office_id              integer
)
RETURNS TABLE
(
    profit_before_tax       decimal(24, 4),
    tax_rate                decimal(24, 4),
    tax                     decimal(24, 4)
)
AS
$$
    DECLARE _date_from      date = core.get_fiscal_year_start_date(_office_id);
    DECLARE _date_to        date = core.get_fiscal_year_end_date(_office_id);
    DECLARE _profit         decimal(24, 4);
    DECLARE _tax_rate       decimal(24, 4);
    DECLARE _tax            decimal(24, 4);
BEGIN
    REFRESH MATERIALIZED VIEW transactions.verified_transaction_mat_view;
    _profit := transactions.get_net_profit(_date_from, _date_to, _office_id, 1, true);

    SELECT income_tax_rate INTO _tax_rate
    FROM office.offices
    WHERE office_id = _office_id;

    _tax = (_profit * _tax_rate) / 100;

    RETURN QUERY
    SELECT _profit, _tax_rate, _tax;
END
$$
LANGUAGE plpgsql;