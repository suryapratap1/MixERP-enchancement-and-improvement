DROP VIEW IF EXISTS hrm.employee_type_scrud_view;

CREATE VIEW hrm.employee_type_scrud_view
AS
SELECT
    employee_type_id,
    employee_type_code,
    employee_type_name
FROM hrm.employee_types;