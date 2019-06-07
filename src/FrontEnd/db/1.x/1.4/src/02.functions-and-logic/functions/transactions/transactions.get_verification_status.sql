DROP FUNCTION IF EXISTS transactions.get_verification_status
(
    _tran_id              BIGINT
);

CREATE FUNCTION transactions.get_verification_status
(
    _tran_id              BIGINT
)
RETURNS smallint
STABLE
AS
$$
BEGIN
    RETURN verification_status_id
    FROM transactions.transaction_master
    WHERE transaction_master_id = _tran_id;
END
$$
LANGUAGE plpgsql;

