DROP VIEW IF EXISTS policy.entity_access_scrud_view;

CREATE VIEW policy.entity_access_scrud_view
AS
SELECT
    entity_access_id,
    CASE WHEN COALESCE(TRIM(entity_name), '') = '' THEN '*' ELSE entity_name END AS entity_name,
    office.users.user_name,
    COALESCE(policy.access_types.access_type_name, '*') AS access_type_name,
    allow_access
FROM policy.entity_access
INNER JOIN office.users
ON office.users.user_id = policy.entity_access.user_id
LEFT JOIN policy.access_types
ON policy.access_types.access_type_id = policy.entity_access.access_type_id;