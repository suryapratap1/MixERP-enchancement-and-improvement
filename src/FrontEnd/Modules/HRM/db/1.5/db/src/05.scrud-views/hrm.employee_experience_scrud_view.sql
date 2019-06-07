DROP VIEW IF EXISTS hrm.employee_experience_scrud_view;

CREATE VIEW hrm.employee_experience_scrud_view
AS
SELECT
    hrm.employee_experiences.employee_experience_id,
    hrm.employee_experiences.employee_id,
    hrm.employees.employee_name,
    hrm.employee_experiences.organization_name,
    hrm.employee_experiences.title,
    hrm.employee_experiences.started_on,
    hrm.employee_experiences.ended_on
FROM hrm.employee_experiences
INNER JOIN hrm.employees
ON hrm.employee_experiences.employee_id = hrm.employees.employee_id;