DROP VIEW IF EXISTS hrm.employee_qualification_scrud_view;

CREATE VIEW hrm.employee_qualification_scrud_view
AS
SELECT
    hrm.employee_qualifications.employee_qualification_id,
    hrm.employee_qualifications.employee_id,
    hrm.employees.employee_name,
    hrm.education_levels.education_level_name,
    hrm.employee_qualifications.institution,
    hrm.employee_qualifications.majors,
    hrm.employee_qualifications.total_years,
    hrm.employee_qualifications.score,
    hrm.employee_qualifications.started_on,
    hrm.employee_qualifications.completed_on
FROM hrm.employee_qualifications
INNER JOIN hrm.employees
ON hrm.employee_qualifications.employee_id = hrm.employees.employee_id
INNER JOIN hrm.education_levels
ON hrm.employee_qualifications.education_level_id = hrm.education_levels.education_level_id;

