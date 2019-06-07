DROP VIEW IF EXISTS policy.default_entity_access_scrud_view;

CREATE VIEW policy.default_entity_access_scrud_view
AS
SELECT
    default_entity_access_id,
    CASE WHEN COALESCE(TRIM(entity_name), '') = '' THEN '*' ELSE entity_name END AS entity_name,
    office.roles.role_name,
    COALESCE(policy.access_types.access_type_name, '*') AS access_type_name,
    allow_access
FROM policy.default_entity_access
INNER JOIN office.roles
ON office.roles.role_id = policy.default_entity_access.role_id
LEFT JOIN policy.access_types
ON policy.access_types.access_type_id = policy.default_entity_access.access_type_id;