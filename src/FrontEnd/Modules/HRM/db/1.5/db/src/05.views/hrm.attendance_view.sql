DROP VIEW IF EXISTS hrm.attendance_view;

CREATE VIEW hrm.attendance_view
AS
SELECT
    hrm.attendances.attendance_id,
    hrm.attendances.office_id,
    office.offices.office_code || ' (' || office.offices.office_name || ')' AS office,
    hrm.attendances.employee_id,
    hrm.employees.employee_code || ' (' || hrm.employees.employee_name || ')' AS employee,
    hrm.employees.photo,
    hrm.attendances.attendance_date,
    hrm.attendances.was_present,
    hrm.attendances.check_in_time,
    hrm.attendances.check_out_time,
    hrm.attendances.overtime_hours,
    hrm.attendances.was_absent,
    hrm.attendances.reason_for_absenteeism
FROM hrm.attendances
INNER JOIN office.offices
ON office.offices.office_id = hrm.attendances.office_id
INNER JOIN hrm.employees
ON hrm.employees.employee_id = hrm.attendances.employee_id;