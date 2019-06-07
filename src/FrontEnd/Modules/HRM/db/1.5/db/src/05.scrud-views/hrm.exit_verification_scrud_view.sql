DROP VIEW IF EXISTS hrm.exit_scrud_view;

CREATE VIEW hrm.exit_scrud_view
AS
SELECT
    hrm.exits.exit_id,
    hrm.exits.employee_id,
    hrm.employees.employee_code || ' (' || hrm.employees.employee_name || ')' AS employee,
    hrm.employees.photo,
    hrm.exits.reason,
    forwarded_to.employee_code || ' (' || forwarded_to.employee_name || ' )' AS forward_to,
    hrm.employment_statuses.employment_status_code || ' (' || hrm.employment_statuses.employment_status_name || ')' AS employment_status,
    hrm.exit_types.exit_type_code || ' (' || hrm.exit_types.exit_type_name || ')' AS exit_type,
    hrm.exits.details,
    hrm.exits.exit_interview_details
FROM hrm.exits
INNER JOIN hrm.employees
ON hrm.employees.employee_id = hrm.exits.employee_id
INNER JOIN hrm.employment_statuses
ON hrm.employment_statuses.employment_status_id = hrm.exits.change_status_to
INNER JOIN hrm.exit_types
ON hrm.exit_types.exit_type_id = hrm.exits.exit_type_id
INNER JOIN hrm.employees AS forwarded_to
ON forwarded_to.employee_id = hrm.exits.forward_to
WHERE verification_status_id = 0;
