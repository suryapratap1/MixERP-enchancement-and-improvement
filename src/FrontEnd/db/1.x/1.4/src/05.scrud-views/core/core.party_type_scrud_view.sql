DROP VIEW IF EXISTS core.party_type_scrud_view;

CREATE VIEW core.party_type_scrud_view
AS
SELECT 
        core.party_types.party_type_id,
        core.party_types.party_type_code,
        core.party_types.party_type_name,
        core.party_types.is_supplier,
        core.accounts.account_number || ' (' || core.accounts.account_name || ')' AS account
FROM core.party_types
INNER JOIN core.accounts
ON core.party_types.account_id = core.accounts.account_id;