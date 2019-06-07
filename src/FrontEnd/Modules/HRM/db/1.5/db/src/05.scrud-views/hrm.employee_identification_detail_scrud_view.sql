DROP VIEW IF EXISTS hrm.employee_identification_detail_scrud_view;

CREATE VIEW hrm.employee_identification_detail_scrud_view
AS
SELECT
    hrm.employee_identification_details.employee_identification_detail_id,
    hrm.employee_identification_details.employee_id,
    hrm.employees.employee_name,
    hrm.employee_identification_details.identification_type_code,
    core.identification_types.identification_type_name,
    hrm.employee_identification_details.identification_number,
    hrm.employee_identification_details.expires_on
FROM hrm.employee_identification_details
INNER JOIN hrm.employees
ON hrm.employee_identification_details.employee_id = hrm.employees.employee_id
INNER JOIN core.identification_types
ON hrm.employee_identification_details.identification_type_code = core.identification_types.identification_type_code;


