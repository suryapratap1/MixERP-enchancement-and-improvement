DROP FUNCTION IF EXISTS transactions.is_verified_stock_transaction(_stock_master_id bigint);

CREATE FUNCTION transactions.is_verified_stock_transaction(_stock_master_id bigint)
RETURNS boolean
STABLE
AS
$$
BEGIN
    RETURN transactions.transaction_master.verification_status_id > 0
    FROM transactions.transaction_master
    INNER JOIN transactions.stock_master
    ON transactions.stock_master.transaction_master_id = transactions.transaction_master.transaction_master_id
    WHERE transactions.stock_master.stock_master_id = _stock_master_id;
END
$$
LANGUAGE plpgsql;