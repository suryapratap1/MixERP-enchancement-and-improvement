DROP VIEW IF EXISTS hrm.resignation_verification_scrud_view;

CREATE VIEW hrm.resignation_verification_scrud_view
AS
SELECT
    hrm.resignations.resignation_id,
    office.users.user_name AS entered_by,
    hrm.resignations.notice_date,
    hrm.resignations.desired_resign_date,
    hrm.employees.employee_code || ' (' || hrm.employees.employee_name || ')' AS employee,
    hrm.employees.photo,
    forward_to.employee_code || ' (' || forward_to.employee_name || ')' AS forward_to,
    hrm.resignations.reason
FROM hrm.resignations
INNER JOIN office.users
ON office.users.user_id = hrm.resignations.entered_by
INNER JOIN hrm.employees
ON hrm.employees.employee_id = hrm.resignations.employee_id
INNER JOIN hrm.employees AS forward_to
ON forward_to.employee_id = hrm.resignations.forward_to
WHERE verification_status_id = 0;