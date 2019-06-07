--This table should not be localized.
SELECT * FROM core.recreate_menu('Employees', '~/Modules/HRM/Index.mix', 'HRM', 0, NULL);

SELECT * FROM core.recreate_menu('Tasks', NULL, 'HRMTA', 1, core.get_menu_id('HRM'));
SELECT * FROM core.recreate_menu('Attendance', '~/Modules/HRM/Tasks/Attendance.mix', 'ATTNDCE', 2, core.get_menu_id('HRMTA'));
SELECT * FROM core.recreate_menu('Employees', '~/Modules/HRM/Tasks/Employees.mix', 'EMPL', 2, core.get_menu_id('HRMTA'));
SELECT * FROM core.recreate_menu('Contracts', '~/Modules/HRM/Tasks/Contracts.mix', 'CTRCT', 2, core.get_menu_id('HRMTA'));
SELECT * FROM core.recreate_menu('Leave Application', '~/Modules/HRM/Tasks/LeaveApplications.mix', 'LEVAPP', 2, core.get_menu_id('HRMTA'));
SELECT * FROM core.recreate_menu('Resignations', '~/Modules/HRM/Tasks/Resignations.mix', 'RESIGN', 2, core.get_menu_id('HRMTA'));
SELECT * FROM core.recreate_menu('Terminations', '~/Modules/HRM/Tasks/Terminations.mix', 'TERMIN', 2, core.get_menu_id('HRMTA'));
SELECT * FROM core.recreate_menu('Exits', '~/Modules/HRM/Tasks/Exits.mix', 'EXIT', 2, core.get_menu_id('HRMTA'));

SELECT * FROM core.recreate_menu('Verification', NULL, 'HRMVER', 1, core.get_menu_id('HRM'));
SELECT * FROM core.recreate_menu('Verify Contracts', '~/Modules/HRM/Verification/Contracts.mix', 'VERCTRCT', 2, core.get_menu_id('HRMVER'));
SELECT * FROM core.recreate_menu('Verify Leave Applications', '~/Modules/HRM/Verification/LeaveApplications.mix', 'VERLEVAPP', 2, core.get_menu_id('HRMVER'));
SELECT * FROM core.recreate_menu('Verify Resignations', '~/Modules/HRM/Verification/Resignations.mix', 'VERRESIGN', 2, core.get_menu_id('HRMVER'));
SELECT * FROM core.recreate_menu('Verify Terminations', '~/Modules/HRM/Verification/Terminations.mix', 'VERTERMIN', 2, core.get_menu_id('HRMVER'));
SELECT * FROM core.recreate_menu('Verify Exits', '~/Modules/HRM/Verification/Exits.mix', 'VEREXIT', 2, core.get_menu_id('HRMVER'));


SELECT * FROM core.recreate_menu('Setup & Maintenance', NULL, 'HRMSSM', 1, core.get_menu_id('HRM'));
SELECT * FROM core.recreate_menu('Employment Statuses', '~/Modules/HRM/Setup/EmploymentStatuses.mix', 'EMPSTA', 2, core.get_menu_id('HRMSSM'));
SELECT * FROM core.recreate_menu('Employee Types', '~/Modules/HRM/Setup/EmployeeTypes.mix', 'EMPTYP', 2, core.get_menu_id('HRMSSM'));
SELECT * FROM core.recreate_menu('Education Levels', '~/Modules/HRM/Setup/EducationLevels.mix', 'EDULVL', 2, core.get_menu_id('HRMSSM'));
SELECT * FROM core.recreate_menu('Job Titles', '~/Modules/HRM/Setup/JobTitles.mix', 'JOBTA', 2, core.get_menu_id('HRMSSM'));
SELECT * FROM core.recreate_menu('Pay Grades', '~/Modules/HRM/Setup/PayGrades.mix', 'PATGR', 2, core.get_menu_id('HRMSSM'));
SELECT * FROM core.recreate_menu('Shifts', '~/Modules/HRM/Setup/Shifts.mix', 'SHIFT', 2, core.get_menu_id('HRMSSM'));
SELECT * FROM core.recreate_menu('Office Hours', '~/Modules/HRM/Setup/OfficeHours.mix', 'OFFHRS', 2, core.get_menu_id('HRMSSM'));
SELECT * FROM core.recreate_menu('Leave Types', '~/Modules/HRM/Setup/LeaveTypes.mix', 'LEVTYP', 2, core.get_menu_id('HRMSSM'));
SELECT * FROM core.recreate_menu('Leave Benefits', '~/Modules/HRM/Setup/LeaveBenefits.mix', 'LEVBEN', 2, core.get_menu_id('HRMSSM'));
SELECT * FROM core.recreate_menu('Exit Types', '~/Modules/HRM/Setup/ExitTypes.mix', 'EXITTYP', 2, core.get_menu_id('HRMSSM'));

SELECT * FROM core.recreate_menu('HRM Reports', NULL, 'HRMRPT', 1, core.get_menu_id('HRM'));
SELECT * FROM core.recreate_menu('Attendances', '~/Modules/HRM/Reports/Attendances.mix', 'HRMRPTAT', 2, core.get_menu_id('HRMRPT'));




UPDATE core.menus SET sort= 1, icon = 'users' WHERE menu_code = 'HRM';
UPDATE core.menus SET sort = 2, icon = 'settings' WHERE menu_code = 'HRMSSM';
UPDATE core.menus SET sort = 3, icon = 'bar chart' WHERE menu_code = 'HRMRPT';


UPDATE core.menus SET sort = 0, icon = 'bar chart' WHERE parent_menu_id IN
(
    SELECT menu_id 
    FROM core.menus 
    WHERE menu_code ='HRMRPT'
);

UPDATE core.menus SET sort = 2, icon = 'tasks' WHERE menu_code ='HRMTA';