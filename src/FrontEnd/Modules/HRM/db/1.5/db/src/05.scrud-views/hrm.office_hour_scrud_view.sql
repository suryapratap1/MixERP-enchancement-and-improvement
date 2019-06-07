DROP VIEW IF EXISTS hrm.office_hour_scrud_view;

CREATE VIEW hrm.office_hour_scrud_view
AS
SELECT
    hrm.office_hours.office_hour_id,
    office.offices.office_code || ' (' || office.offices.office_name || ')' AS office,
    office.offices.logo_file as photo,
    hrm.shifts.shift_code || ' (' || hrm.shifts.shift_name || ')' AS shift,
    core.week_days.week_day_code || ' (' || core.week_days.week_day_name || ')' AS week_day,
    hrm.office_hours.begins_from,
    hrm.office_hours.ends_on
FROM hrm.office_hours
INNER JOIN office.offices
ON office.offices.office_id = hrm.office_hours.office_id
INNER JOIN hrm.shifts
ON hrm.shifts.shift_id = hrm.office_hours.shift_id
INNER JOIN core.week_days
ON core.week_days.week_day_id = hrm.office_hours.week_day_id;