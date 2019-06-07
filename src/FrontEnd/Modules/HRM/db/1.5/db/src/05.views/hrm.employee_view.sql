DROP VIEW IF EXISTS hrm.employee_view;

CREATE VIEW hrm.employee_view
AS
SELECT
    hrm.employees.employee_id,
    hrm.employees.first_name,
    hrm.employees.middle_name,
    hrm.employees.last_name,
    hrm.employees.employee_code,
    hrm.employees.employee_name,
    hrm.employees.gender_code,
    core.genders.gender_name,
    core.marital_statuses.marital_status_code || ' (' || core.marital_statuses.marital_status_name || ')' AS marital_status,
    hrm.employees.joined_on,
    hrm.employees.office_id,
    office.offices.office_code || ' (' || office.offices.office_name || ')' AS office,
    hrm.employees.user_id,
    office.users.user_name,
    hrm.employees.employee_type_id,
    hrm.employee_types.employee_type_code || ' (' || hrm.employee_types.employee_type_name || ')' AS employee_type,
    hrm.employees.current_department_id,
    office.departments.department_code || ' (' || office.departments.department_name || ')' AS current_department,    
    hrm.employees.current_role_id,
    office.roles.role_code || ' (' || office.roles.role_name || ')' AS role,
    hrm.employees.current_employment_status_id,
    hrm.employment_statuses.employment_status_code || ' (' || employment_status_name || ')' AS employment_status,
    hrm.employees.current_job_title_id,
    hrm.job_titles.job_title_code || ' (' || hrm.job_titles.job_title_name || ')' AS job_title,
    hrm.employees.current_pay_grade_id,
    hrm.pay_grades.pay_grade_code || ' (' || hrm.pay_grades.pay_grade_name || ')' AS pay_grade,
    hrm.employees.current_shift_id,
    hrm.shifts.shift_code || ' (' || hrm.shifts.shift_name || ')' AS shift,
    hrm.employees.nationality_code,
    core.nationalities.nationality_code || ' (' || core.nationalities.nationality_name || ')' AS nationality,
    hrm.employees.date_of_birth,
    hrm.employees.photo,
    hrm.employees.zip_code,
    hrm.employees.address_line_1,
    hrm.employees.address_line_2,
    hrm.employees.street,
    hrm.employees.city,
    hrm.employees.state,
    hrm.employees.country_id,
    core.countries.country_name AS country,
    hrm.employees.phone_home,
    hrm.employees.phone_cell,
    hrm.employees.phone_office_extension,
    hrm.employees.phone_emergency,
    hrm.employees.phone_emergency2,
    hrm.employees.email_address,
    hrm.employees.website,
    hrm.employees.blog,
    hrm.employees.is_smoker,
    hrm.employees.is_alcoholic,
    hrm.employees.with_disabilities,
    hrm.employees.low_vision,
    hrm.employees.uses_wheelchair,
    hrm.employees.hard_of_hearing,
    hrm.employees.is_aphonic,
    hrm.employees.is_cognitively_disabled,
    hrm.employees.is_autistic
FROM hrm.employees
INNER JOIN core.genders
ON hrm.employees.gender_code = core.genders.gender_code
INNER JOIN core.marital_statuses
ON hrm.employees.marital_status_id = core.marital_statuses.marital_status_id
INNER JOIN office.offices
ON hrm.employees.office_id = office.offices.office_id
INNER JOIN office.departments
ON hrm.employees.current_department_id = office.departments.department_id
INNER JOIN hrm.employee_types
ON hrm.employee_types.employee_type_id = hrm.employees.employee_type_id
INNER JOIN hrm.employment_statuses
ON hrm.employees.current_employment_status_id = hrm.employment_statuses.employment_status_id
INNER JOIN hrm.job_titles
ON hrm.employees.current_job_title_id = hrm.job_titles.job_title_id
INNER JOIN hrm.pay_grades
ON hrm.employees.current_pay_grade_id = hrm.pay_grades.pay_grade_id
INNER JOIN hrm.shifts
ON hrm.employees.current_shift_id = hrm.shifts.shift_id
LEFT JOIN office.users
ON hrm.employees.user_id = office.users.user_id
LEFT JOIN office.roles
ON hrm.employees.current_role_id = office.roles.role_id
LEFT JOIN core.nationalities
ON hrm.employees.nationality_code = core.nationalities.nationality_code
LEFT JOIN core.countries
ON hrm.employees.country_id = core.countries.country_id
WHERE COALESCE(service_ended_on, 'infinity') >= NOW();