-->-->-- C:/Users/nirvan/Desktop/mixerp/0. GitHub/src/FrontEnd/Modules/HRM/db/1.5/db/src/01.types-domains-tables-and-constraints/tables-and-constraints.sql --<--<--
 /********************************************************************************
Copyright (C) MixERP Inc. (http://mixof.org).
This file is part of MixERP.
MixERP is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, version 2 of the License.
MixERP is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.
You should have received a copy of the GNU General Public License
along with MixERP.  If not, see <http://www.gnu.org/licenses/>.
***********************************************************************************/

DROP SCHEMA IF EXISTS hrm CASCADE;
CREATE SCHEMA hrm;

CREATE TABLE hrm.education_levels
(
    education_level_id                      SERIAL NOT NULL PRIMARY KEY,
    education_level_name                    national character varying(50) NOT NULL UNIQUE,
    audit_user_id                           integer NULL REFERENCES office.users(user_id),
    audit_ts                                TIMESTAMP WITH TIME ZONE NULL 
                                            DEFAULT(NOW())    
);

CREATE TABLE hrm.employment_status_codes
(
    employment_status_code_id               integer NOT NULL PRIMARY KEY,
    status_code                             national character varying(12) NOT NULL UNIQUE,
    status_code_name                        national character varying(100) NOT NULL,
    audit_user_id                           integer NULL REFERENCES office.users(user_id),
    audit_ts                                TIMESTAMP WITH TIME ZONE NULL 
                                            DEFAULT(NOW())    
);

CREATE TABLE hrm.employment_statuses
(
    employment_status_id                    SERIAL NOT NULL PRIMARY KEY,
    employment_status_code                  national character varying(12) NOT NULL UNIQUE,
    employment_status_name                  national character varying(100) NOT NULL,
    is_contract                             boolean NOT NULL DEFAULT(false),
    default_employment_status_code_id       integer NOT NULL REFERENCES hrm.employment_status_codes,
    description                             text DEFAULT(''),    
    audit_user_id                           integer NULL REFERENCES office.users(user_id),
    audit_ts                                TIMESTAMP WITH TIME ZONE NULL 
                                            DEFAULT(NOW())    
);

CREATE TABLE hrm.job_titles
(
    job_title_id                            SERIAL NOT NULL PRIMARY KEY,
    job_title_code                          national character varying(12) NOT NULL UNIQUE,
    job_title_name                          national character varying(100) NOT NULL,
    description                             text DEFAULT(''),
    audit_user_id                           integer NULL REFERENCES office.users(user_id),
    audit_ts                                TIMESTAMP WITH TIME ZONE NULL 
                                            DEFAULT(NOW())    
);

CREATE TABLE hrm.pay_grades
(
    pay_grade_id                            SERIAL NOT NULL PRIMARY KEY,
    pay_grade_code                          national character varying(12) NOT NULL UNIQUE,
    pay_grade_name                          national character varying(100) NOT NULL,
    minimum_salary                          decimal(24, 4) NOT NULL,
    maximum_salary                          decimal(24, 5) NOT NULL
                                            CHECK(maximum_salary >= minimum_salary),
    description                             text DEFAULT(''),
    audit_user_id                           integer NULL REFERENCES office.users(user_id),
    audit_ts                                TIMESTAMP WITH TIME ZONE NULL 
                                            DEFAULT(NOW())    
);

CREATE TABLE hrm.shifts
(
    shift_id                            SERIAL NOT NULL PRIMARY KEY,
    shift_code                          national character varying(12) NOT NULL UNIQUE,
    shift_name                          national character varying(100) NOT NULL,
    begins_from                         time NOT NULL,
    ends_on                             time NOT NULL,
    description                         text DEFAULT(''),
    audit_user_id                       integer NULL REFERENCES office.users(user_id),
    audit_ts                            TIMESTAMP WITH TIME ZONE NULL 
                                        DEFAULT(NOW())    
);

CREATE TABLE hrm.leave_types
(
    leave_type_id                           SERIAL NOT NULL PRIMARY KEY,
    leave_type_code                         national character varying(12) NOT NULL UNIQUE,
    leave_type_name                         national character varying(100) NOT NULL,
    description                             text DEFAULT(''),
    audit_user_id                           integer NULL REFERENCES office.users(user_id),
    audit_ts                                TIMESTAMP WITH TIME ZONE NULL 
                                            DEFAULT(NOW())    
);

CREATE TABLE hrm.office_hours
(
    office_hour_id                          SERIAL NOT NULL PRIMARY KEY,
    office_id                               integer NOT NULL REFERENCES office.offices(office_id),
    shift_id                                integer NOT NULL REFERENCES hrm.shifts,
    week_day_id                             integer NOT NULL REFERENCES core.week_days(week_day_id),
    begins_from                             time NOT NULL,
    ends_on                                 time NOT NULL,
    audit_user_id                           integer NULL REFERENCES office.users(user_id),
    audit_ts                                TIMESTAMP WITH TIME ZONE NULL    
);

CREATE TABLE hrm.leave_benefits
(
    leave_benefit_id                       SERIAL NOT NULL PRIMARY KEY,
    leave_benefit_code                     national character varying(12) NOT NULL UNIQUE,
    leave_benefit_name                     national character varying(128) NOT NULL,
    total_days                              public.integer_strict NOT NULL,
    audit_user_id                           integer NULL REFERENCES office.users(user_id),
    audit_ts                                TIMESTAMP WITH TIME ZONE NULL 
                                            DEFAULT(NOW())    
);

CREATE TABLE hrm.employee_types
(
    employee_type_id                        SERIAL NOT NULL PRIMARY KEY,
    employee_type_code                      national character varying(12) NOT NULL UNIQUE,
    employee_type_name                      national character varying(128) NOT NULL,
    account_id                              bigint NOT NULL REFERENCES core.accounts(account_id),
    audit_user_id                           integer NULL REFERENCES office.users(user_id),
    audit_ts                                TIMESTAMP WITH TIME ZONE NULL 
                                            DEFAULT(NOW())    
);

CREATE TABLE hrm.employees
(
    employee_id                             SERIAL NOT NULL PRIMARY KEY,
    employee_code                           national character varying(12) NOT NULL UNIQUE,
    first_name                              national character varying(50) NOT NULL,
    middle_name                             national character varying(50) DEFAULT(''),
    last_name                               national character varying(50) DEFAULT(''),
    employee_name                           national character varying(160) NOT NULL,
    gender_code                             national character varying(4) NOT NULL 
                                            REFERENCES core.genders(gender_code),
    marital_status_id                       integer NOT NULL REFERENCES core.marital_statuses(marital_status_id),
    joined_on                               date NULL,
    office_id                               integer NOT NULL REFERENCES office.offices(office_id),
    user_id                                 integer REFERENCES office.users(user_id),
    employee_type_id                        integer NOT NULL REFERENCES hrm.employee_types(employee_type_id),
    current_department_id                   integer NOT NULL REFERENCES office.departments(department_id),
    current_role_id                         integer REFERENCES office.roles(role_id),
    current_employment_status_id            integer NOT NULL REFERENCES hrm.employment_statuses(employment_status_id),
    current_job_title_id                    integer NOT NULL REFERENCES hrm.job_titles(job_title_id),
    current_pay_grade_id                    integer NOT NULL REFERENCES hrm.pay_grades(pay_grade_id),
    current_shift_id                        integer NOT NULL REFERENCES hrm.shifts(shift_id),
    nationality_code                        national character varying(12) REFERENCES core.nationalities(nationality_code),
    date_of_birth                           date,
    photo                                   public.image,
    bank_account_number                     national character varying(128) DEFAULT(''),
    bank_name                               national character varying(128) DEFAULT(''),
    bank_branch_name                        national character varying(128) DEFAULT(''),
    bank_reference_number                   national character varying(128) DEFAULT(''),
    account_id                              bigint NULL REFERENCES core.accounts(account_id),
    zip_code                                national character varying(128) DEFAULT(''),
    address_line_1                          national character varying(128) DEFAULT(''),
    address_line_2                          national character varying(128) DEFAULT(''),
    street                                  national character varying(128) DEFAULT(''),
    city                                    national character varying(128) DEFAULT(''),
    state                                   national character varying(128) DEFAULT(''),    
    country_id                              integer REFERENCES core.countries(country_id),
    phone_home                              national character varying(128) DEFAULT(''),
    phone_cell                              national character varying(128) DEFAULT(''),
    phone_office_extension                  national character varying(128) DEFAULT(''),
    phone_emergency                         national character varying(128) DEFAULT(''),
    phone_emergency2                        national character varying(128) DEFAULT(''),
    email_address                           national character varying(128) DEFAULT(''),
    website                                 national character varying(128) DEFAULT(''),
    blog                                    national character varying(128) DEFAULT(''),
    is_smoker                               boolean,
    is_alcoholic                            boolean,
    with_disabilities                       boolean,
    low_vision                              boolean,
    uses_wheelchair                         boolean,
    hard_of_hearing                         boolean,
    is_aphonic                              boolean,
    is_cognitively_disabled                 boolean,
    is_autistic                             boolean,
    service_ended_on                        date NULL,
    audit_user_id                           integer NULL REFERENCES office.users(user_id),
    audit_ts                                TIMESTAMP WITH TIME ZONE NULL 
                                            DEFAULT(NOW())    
);

CREATE TABLE hrm.employee_identification_details
(
    employee_identification_detail_id       BIGSERIAL NOT NULL PRIMARY KEY,
    employee_id                             integer NOT NULL REFERENCES hrm.employees(employee_id),
    identification_type_code                national character varying(12) NOT NULL 
                                            REFERENCES core.identification_types(identification_type_code),
    identification_number                   national character varying(128) NOT NULL,
    expires_on                              date,
    audit_user_id                           integer NULL REFERENCES office.users(user_id),
    audit_ts                                TIMESTAMP WITH TIME ZONE NULL 
                                            DEFAULT(NOW())                                          
);

CREATE UNIQUE INDEX employee_identification_details_employee_id_itc_uix
ON hrm.employee_identification_details(employee_id, UPPER(identification_type_code));



CREATE TABLE hrm.employee_social_network_details
(
    employee_social_network_detail_id       BIGSERIAL NOT NULL PRIMARY KEY,
    employee_id                             integer NOT NULL REFERENCES hrm.employees(employee_id),
    social_network_name                     national character varying(128) NOT NULL
                                            REFERENCES core.social_networks(social_network_name),
    social_network_id                       national character varying(128) NOT NULL,
    audit_user_id                           integer NULL REFERENCES office.users(user_id),
    audit_ts                                TIMESTAMP WITH TIME ZONE NULL 
                                            DEFAULT(NOW())    
);

CREATE TABLE hrm.contracts
(
    contract_id                             BIGSERIAL NOT NULL PRIMARY KEY,
    employee_id                             integer NOT NULL REFERENCES hrm.employees(employee_id),
    office_id                               integer NOT NULL REFERENCES office.offices(office_id),
    department_id                           integer NOT NULL REFERENCES office.departments(department_id),
    role_id                                 integer REFERENCES office.roles(role_id),
    leave_benefit_id                        integer REFERENCES hrm.leave_benefits(leave_benefit_id),
    began_on                                date,
    ended_on                                date,
    employment_status_code_id               integer NOT NULL REFERENCES hrm.employment_status_codes(employment_status_code_id),
    verification_status_id                  integer NOT NULL REFERENCES core.verification_statuses(verification_status_id),
    verified_by_user_id                     integer REFERENCES office.users(user_id),
    verified_on                             date,
    verification_reason                     national character varying(128) NULL,
    audit_user_id                           integer NULL REFERENCES office.users(user_id),
    
    audit_ts                                TIMESTAMP WITH TIME ZONE NULL 
                                            DEFAULT(NOW())    
);

CREATE TABLE hrm.employee_experiences
(
    employee_experience_id                  BIGSERIAL NOT NULL PRIMARY KEY,
    employee_id                             integer NOT NULL REFERENCES hrm.employees(employee_id),
    organization_name                       national character varying(128) NOT NULL,
    title                                   national character varying(128) NOT NULL,
    started_on                              date,
    ended_on                                date,
    details                                 text,
    audit_user_id                           integer NULL REFERENCES office.users(user_id),    
    audit_ts                                TIMESTAMP WITH TIME ZONE NULL 
                                            DEFAULT(NOW())    
);

CREATE TABLE hrm.employee_qualifications
(
    employee_qualification_id               BIGSERIAL NOT NULL PRIMARY KEY,
    employee_id                             integer NOT NULL REFERENCES hrm.employees(employee_id),
    education_level_id                      integer NOT NULL REFERENCES hrm.education_levels(education_level_id),
    institution                             national character varying(128) NOT NULL,
    majors                                  national character varying(128) NOT NULL,
    total_years                             integer,
    score                                   numeric,
    started_on                              date,
    completed_on                            date,
    details                                 text,
    audit_user_id                           integer NULL REFERENCES office.users(user_id),    
    audit_ts                                TIMESTAMP WITH TIME ZONE NULL 
                                            DEFAULT(NOW())    
);

CREATE TABLE hrm.leave_applications
(
    leave_application_id                    BIGSERIAL NOT NULL PRIMARY KEY,
    employee_id                             integer NOT NULL REFERENCES hrm.employees(employee_id),
    leave_type_id                           integer NOT NULL REFERENCES hrm.leave_types(leave_type_id),
    entered_by                              integer NOT NULL REFERENCES office.users(user_id),
    applied_on                              date DEFAULT(NOW()),
    reason                                  text,
    start_date                              date,
    end_date                                date,
    verification_status_id                  integer NOT NULL REFERENCES core.verification_statuses(verification_status_id),
    verified_by_user_id                     integer REFERENCES office.users(user_id),
    verified_on                             date,
    verification_reason                     national character varying(128) NULL,
    audit_user_id                           integer NULL REFERENCES office.users(user_id),    
    audit_ts                                TIMESTAMP WITH TIME ZONE NULL 
                                            DEFAULT(NOW())    
);

CREATE TABLE hrm.resignations
(
    resignation_id                          SERIAL NOT NULL PRIMARY KEY,
    entered_by                              integer NOT NULL REFERENCES office.users(user_id),
    notice_date                             date NOT NULL,
    desired_resign_date                     date NOT NULL,
    employee_id                             integer NOT NULL REFERENCES hrm.employees(employee_id),
    forward_to                              integer REFERENCES hrm.employees(employee_id),
    reason                                  national character varying(128) NOT NULL,
    details                                 text,
    verification_status_id                  integer NOT NULL REFERENCES core.verification_statuses(verification_status_id),
    verified_by_user_id                     integer REFERENCES office.users(user_id),
    verified_on                             date,
    verification_reason                     national character varying(128) NULL,
    audit_user_id                           integer NULL REFERENCES office.users(user_id),    
    audit_ts                                TIMESTAMP WITH TIME ZONE NULL 
                                            DEFAULT(NOW())    
);

CREATE TABLE hrm.terminations
(
    termination_id                          SERIAL NOT NULL PRIMARY KEY,
    notice_date                             date NOT NULL,
    employee_id                             integer NOT NULL REFERENCES hrm.employees(employee_id) UNIQUE,
    forward_to                              integer REFERENCES hrm.employees(employee_id),
    change_status_to                        integer NOT NULL REFERENCES hrm.employment_statuses(employment_status_id),
    reason                                  national character varying(128) NOT NULL,
    details                                 text,
    service_end_date                        date NOT NULL,
    verification_status_id                  integer NOT NULL REFERENCES core.verification_statuses(verification_status_id),
    verified_by_user_id                     integer REFERENCES office.users(user_id),
    verified_on                             date,
    verification_reason                     national character varying(128) NULL,
    audit_user_id                           integer NULL REFERENCES office.users(user_id),    
    audit_ts                                TIMESTAMP WITH TIME ZONE NULL 
                                            DEFAULT(NOW())    
    
);

CREATE TABLE hrm.exit_types
(
    exit_type_id                            SERIAL NOT NULL PRIMARY KEY,
    exit_type_code                          national character varying(12) NOT NULL UNIQUE,
    exit_type_name                          national character varying(128) NOT NULL,
    audit_user_id                           integer NULL REFERENCES office.users(user_id),    
    audit_ts                                TIMESTAMP WITH TIME ZONE NULL 
                                            DEFAULT(NOW())    
);

CREATE TABLE hrm.exits
(
    exit_id                                 BIGSERIAL NOT NULL PRIMARY KEY,
    employee_id                             integer NOT NULL REFERENCES hrm.employees(employee_id),
    forward_to                              integer REFERENCES hrm.employees(employee_id),
    change_status_to                        integer NOT NULL REFERENCES hrm.employment_statuses(employment_status_id),
    exit_type_id                            integer NOT NULL REFERENCES hrm.exit_types(exit_type_id),
    exit_interview_details                  text,
    reason                                  national character varying(128) NOT NULL,
    details                                 text,
    verification_status_id                  integer NOT NULL REFERENCES core.verification_statuses(verification_status_id),
    verified_by_user_id                     integer REFERENCES office.users(user_id),
    verified_on                             date,
    verification_reason                     national character varying(128) NULL,
    service_end_date                        date NOT NULL,
    audit_user_id                           integer NULL REFERENCES office.users(user_id),    
    audit_ts                                TIMESTAMP WITH TIME ZONE NULL 
                                            DEFAULT(NOW())    
);


CREATE TABLE hrm.attendances
(
    attendance_id                           BIGSERIAL NOT NULL PRIMARY KEY,
    office_id                               integer NOT NULL REFERENCES office.offices(office_id),
    employee_id                             integer NOT NULL REFERENCES hrm.employees(employee_id),
    attendance_date                         date NOT NULL,
    was_present                             boolean NOT NULL,
    check_in_time                           time NULL,
    check_out_time                          time NULL,
    overtime_hours                          numeric NOT NULL,
    was_absent                              boolean NOT NULL CHECK(was_absent != was_present),
    reason_for_absenteeism                  text,
    audit_user_id                           integer NULL REFERENCES office.users(user_id),
    audit_ts                                TIMESTAMP WITH TIME ZONE NULL 
                                            DEFAULT(NOW())    
);

CREATE UNIQUE INDEX attendance_date_employee_id_uix
ON hrm.attendances(attendance_date, employee_id);


-->-->-- C:/Users/nirvan/Desktop/mixerp/0. GitHub/src/FrontEnd/Modules/HRM/db/1.5/db/src/02.functions-and-logic/functions/hrm.get_employee_by_employee_id.sql --<--<--
DROP FUNCTION IF EXISTS hrm.get_employee_by_employee_id(_employee_id integer);

CREATE FUNCTION hrm.get_employee_by_employee_id(_employee_id integer)
RETURNS text
STABLE
AS
$$
BEGIN
    RETURN
        employee_code || ' (' || employee_name || ')'      
    FROM hrm.employees
    WHERE employee_id = $1;    
END
$$
LANGUAGE plpgsql;

-->-->-- C:/Users/nirvan/Desktop/mixerp/0. GitHub/src/FrontEnd/Modules/HRM/db/1.5/db/src/02.functions-and-logic/functions/hrm.get_employee_code_by_employee_id.sql --<--<--
DROP FUNCTION IF EXISTS hrm.get_employee_code_by_employee_id(_employee_id integer);

CREATE FUNCTION hrm.get_employee_code_by_employee_id(_employee_id integer)
RETURNS text
STABLE
AS
$$
BEGIN
    RETURN
        employee_code
    FROM hrm.employees
    WHERE employee_id = $1;    
END
$$
LANGUAGE plpgsql;

-->-->-- C:/Users/nirvan/Desktop/mixerp/0. GitHub/src/FrontEnd/Modules/HRM/db/1.5/db/src/02.functions-and-logic/functions/hrm.get_employee_name_by_employee_id.sql --<--<--
DROP FUNCTION IF EXISTS hrm.get_employee_name_by_employee_id(_employee_id integer);

CREATE FUNCTION hrm.get_employee_name_by_employee_id(_employee_id integer)
RETURNS text
STABLE
AS
$$
BEGIN
    RETURN
        employee_name
    FROM hrm.employees
    WHERE employee_id = $1;    
END
$$
LANGUAGE plpgsql;

-->-->-- C:/Users/nirvan/Desktop/mixerp/0. GitHub/src/FrontEnd/Modules/HRM/db/1.5/db/src/02.functions-and-logic/triggers/employee_dismissal.sql --<--<--
DROP FUNCTION IF EXISTS hrm.dismiss_employee() CASCADE;

CREATE FUNCTION hrm.dismiss_employee()
RETURNS trigger
AS
$$
    DECLARE _service_end        date;
    DECLARE _new_status_id      integer;
BEGIN
    IF(hstore(NEW) ? 'change_status_to') THEN
        _new_status_id := NEW.change_status_to;
    END IF;

    IF(hstore(NEW) ? 'service_end_date') THEN
        _service_end := NEW.service_end_date;
    END IF;

    IF(_service_end = NULL) THEN
        IF(hstore(NEW) ? 'desired_resign_date') THEN
            _service_end := NEW.desired_resign_date;
        END IF;
    END IF;
    
    IF(NEW.verification_status_id > 0) THEN        
        UPDATE hrm.employees
        SET
            service_ended_on = NEW.service_end_date
        WHERE employee_id = NEW.employee_id;

        IF(_new_status_id IS NOT NULL) THEN
            UPDATE hrm.employees
            SET
                current_employment_status_id = _new_status_id
            WHERE employee_id = NEW.employee_id;
        END IF;        
    END IF;

    RETURN NEW;
END
$$
LANGUAGE plpgsql;

DROP FUNCTION IF EXISTS hrm.undismiss_employee() CASCADE;

CREATE FUNCTION hrm.undismiss_employee()
RETURNS trigger
AS
$$
BEGIN
    UPDATE hrm.employees
    SET
        service_ended_on = NULL
    WHERE employee_id = OLD.employee_id;

    RETURN OLD;    
END
$$
LANGUAGE plpgsql;

CREATE TRIGGER dismiss_employee_trigger BEFORE INSERT OR UPDATE ON hrm.resignations FOR EACH ROW EXECUTE PROCEDURE hrm.dismiss_employee();
CREATE TRIGGER dismiss_employee_trigger BEFORE INSERT OR UPDATE ON hrm.terminations FOR EACH ROW EXECUTE PROCEDURE hrm.dismiss_employee();
CREATE TRIGGER dismiss_employee_trigger BEFORE INSERT OR UPDATE ON hrm.exits FOR EACH ROW EXECUTE PROCEDURE hrm.dismiss_employee();

CREATE TRIGGER undismiss_employee_trigger BEFORE DELETE ON hrm.resignations FOR EACH ROW EXECUTE PROCEDURE hrm.undismiss_employee();
CREATE TRIGGER undismiss_employee_trigger BEFORE DELETE ON hrm.terminations FOR EACH ROW EXECUTE PROCEDURE hrm.undismiss_employee();
CREATE TRIGGER undismiss_employee_trigger BEFORE DELETE ON hrm.exits FOR EACH ROW EXECUTE PROCEDURE hrm.undismiss_employee();

-->-->-- C:/Users/nirvan/Desktop/mixerp/0. GitHub/src/FrontEnd/Modules/HRM/db/1.5/db/src/03.menus/0.menus.sql --<--<--
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

-->-->-- C:/Users/nirvan/Desktop/mixerp/0. GitHub/src/FrontEnd/Modules/HRM/db/1.5/db/src/04.default-values/01.default-values.sql --<--<--
DO
$$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM core.attachment_lookup WHERE book = 'employee') THEN
        INSERT INTO core.attachment_lookup(book, resource, resource_key)
        SELECT 'employee',           'core.employees',  'employee_id';
    END IF;
END
$$
LANGUAGE plpgsql;

-->-->-- C:/Users/nirvan/Desktop/mixerp/0. GitHub/src/FrontEnd/Modules/HRM/db/1.5/db/src/05.scrud-views/hrm.contract_scrud_view.sql --<--<--
DROP VIEW IF EXISTS hrm.contract_scrud_view;

CREATE VIEW hrm.contract_scrud_view
AS
SELECT
    hrm.contracts.contract_id,
    hrm.employees.employee_id,
    hrm.employees.employee_code || ' (' || hrm.employees.employee_name || ')' AS employee,
    hrm.employees.photo,
    office.offices.office_code || ' (' || office.offices.office_name || ')' AS office,
    office.departments.department_code || ' (' || office.departments.department_name || ')' AS department,
    office.roles.role_code || ' (' || office.roles.role_name || ')' AS role,
    hrm.leave_benefits.leave_benefit_code || ' (' || hrm.leave_benefits.leave_benefit_name || ')' AS leave_benefit,
    hrm.employment_status_codes.status_code || ' (' || hrm.employment_status_codes.status_code_name || ')' AS employment_status_code,
    hrm.contracts.began_on,
    hrm.contracts.ended_on
FROM hrm.contracts
INNER JOIN hrm.employees
ON hrm.employees.employee_id = hrm.contracts.employee_id
INNER JOIN office.offices
ON office.offices.office_id = hrm.contracts.office_id
INNER JOIN office.departments
ON office.departments.department_id = hrm.contracts.department_id
INNER JOIN office.roles
ON office.roles.role_id = hrm.contracts.role_id
INNER JOIN hrm.employment_status_codes
ON hrm.employment_status_codes.employment_status_code_id = hrm.contracts.employment_status_code_id
LEFT JOIN hrm.leave_benefits
ON hrm.leave_benefits.leave_benefit_id = hrm.contracts.leave_benefit_id;

-->-->-- C:/Users/nirvan/Desktop/mixerp/0. GitHub/src/FrontEnd/Modules/HRM/db/1.5/db/src/05.scrud-views/hrm.contract_verification_scrud_view.sql --<--<--
DROP VIEW IF EXISTS hrm.contract_verification_scrud_view;

CREATE VIEW hrm.contract_verification_scrud_view
AS
SELECT
    hrm.contracts.contract_id,
    hrm.employees.employee_id,
    hrm.employees.employee_code || ' (' || hrm.employees.employee_name || ')' AS employee,
    hrm.employees.photo,
    office.offices.office_code || ' (' || office.offices.office_name || ')' AS office,
    office.departments.department_code || ' (' || office.departments.department_name || ')' AS department,
    office.roles.role_code || ' (' || office.roles.role_name || ')' AS role,
    hrm.leave_benefits.leave_benefit_code || ' (' || hrm.leave_benefits.leave_benefit_name || ')' AS leave_benefit,
    hrm.employment_status_codes.status_code || ' (' || hrm.employment_status_codes.status_code_name || ')' AS employment_status_code,
    hrm.contracts.began_on,
    hrm.contracts.ended_on
FROM hrm.contracts
INNER JOIN hrm.employees
ON hrm.employees.employee_id = hrm.contracts.employee_id
INNER JOIN office.offices
ON office.offices.office_id = hrm.contracts.office_id
INNER JOIN office.departments
ON office.departments.department_id = hrm.contracts.department_id
INNER JOIN office.roles
ON office.roles.role_id = hrm.contracts.role_id
INNER JOIN hrm.employment_status_codes
ON hrm.employment_status_codes.employment_status_code_id = hrm.contracts.employment_status_code_id
LEFT JOIN hrm.leave_benefits
ON hrm.leave_benefits.leave_benefit_id = hrm.contracts.leave_benefit_id
WHERE verification_status_id = 0;

-->-->-- C:/Users/nirvan/Desktop/mixerp/0. GitHub/src/FrontEnd/Modules/HRM/db/1.5/db/src/05.scrud-views/hrm.employee_experience_scrud_view.sql --<--<--
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

-->-->-- C:/Users/nirvan/Desktop/mixerp/0. GitHub/src/FrontEnd/Modules/HRM/db/1.5/db/src/05.scrud-views/hrm.employee_identification_detail_scrud_view.sql --<--<--
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




-->-->-- C:/Users/nirvan/Desktop/mixerp/0. GitHub/src/FrontEnd/Modules/HRM/db/1.5/db/src/05.scrud-views/hrm.employee_qualification_scrud_view.sql --<--<--
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



-->-->-- C:/Users/nirvan/Desktop/mixerp/0. GitHub/src/FrontEnd/Modules/HRM/db/1.5/db/src/05.scrud-views/hrm.employee_social_network_detail_scrud_view.sql --<--<--
DROP VIEW IF EXISTS hrm.employee_social_network_detail_scrud_view;

CREATE VIEW hrm.employee_social_network_detail_scrud_view
AS
SELECT
    hrm.employee_social_network_details.employee_social_network_detail_id,
    hrm.employee_social_network_details.employee_id,
    hrm.employees.employee_name,
    hrm.employee_social_network_details.social_network_name,
    hrm.employee_social_network_details.social_network_id,
    core.social_networks.semantic_css_class,
    core.social_networks.base_url,
    core.social_networks.profile_url
FROM hrm.employee_social_network_details
INNER JOIN hrm.employees
ON hrm.employee_social_network_details.employee_id = hrm.employees.employee_id
INNER JOIN core.social_networks
ON core.social_networks.social_network_name = hrm.employee_social_network_details.social_network_name;



-->-->-- C:/Users/nirvan/Desktop/mixerp/0. GitHub/src/FrontEnd/Modules/HRM/db/1.5/db/src/05.scrud-views/hrm.employee_type_scrud_view.sql --<--<--
DROP VIEW IF EXISTS hrm.employee_type_scrud_view;

CREATE VIEW hrm.employee_type_scrud_view
AS
SELECT
    employee_type_id,
    employee_type_code,
    employee_type_name
FROM hrm.employee_types;

-->-->-- C:/Users/nirvan/Desktop/mixerp/0. GitHub/src/FrontEnd/Modules/HRM/db/1.5/db/src/05.scrud-views/hrm.exit_verification_scrud_view.sql --<--<--
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


-->-->-- C:/Users/nirvan/Desktop/mixerp/0. GitHub/src/FrontEnd/Modules/HRM/db/1.5/db/src/05.scrud-views/hrm.leave_application_scrud_view.sql --<--<--
DROP VIEW IF EXISTS hrm.leave_application_scrud_view;

CREATE VIEW hrm.leave_application_scrud_view
AS
SELECT
    hrm.leave_applications.leave_application_id,
    hrm.employees.employee_code || ' (' || hrm.employees.employee_name || ')' AS employee,
    hrm.employees.photo,
    hrm.leave_types.leave_type_code || ' (' || hrm.leave_types.leave_type_name || ')' AS leave_type,
    office.users.user_name AS entered_by,
    hrm.leave_applications.applied_on,
    hrm.leave_applications.reason,
    hrm.leave_applications.start_date,
    hrm.leave_applications.end_date
FROM hrm.leave_applications
INNER JOIN hrm.employees
ON hrm.employees.employee_id = hrm.leave_applications.employee_id
INNER JOIN hrm.leave_types
ON hrm.leave_types.leave_type_id = hrm.leave_applications.leave_type_id
INNER JOIN office.users
ON office.users.user_id = hrm.leave_applications.entered_by;

-->-->-- C:/Users/nirvan/Desktop/mixerp/0. GitHub/src/FrontEnd/Modules/HRM/db/1.5/db/src/05.scrud-views/hrm.leave_application_verification_scrud_view.sql --<--<--
DROP VIEW IF EXISTS hrm.leave_application_verification_scrud_view;

CREATE VIEW hrm.leave_application_verification_scrud_view
AS
SELECT
    hrm.leave_applications.leave_application_id,
    hrm.employees.employee_code || ' (' || hrm.employees.employee_name || ')' AS employee,
    hrm.employees.photo,
    hrm.leave_types.leave_type_code || ' (' || hrm.leave_types.leave_type_name || ')' AS leave_type,
    office.users.user_name AS entered_by,
    hrm.leave_applications.applied_on,
    hrm.leave_applications.reason,
    hrm.leave_applications.start_date,
    hrm.leave_applications.end_date
FROM hrm.leave_applications
INNER JOIN hrm.employees
ON hrm.employees.employee_id = hrm.leave_applications.employee_id
INNER JOIN hrm.leave_types
ON hrm.leave_types.leave_type_id = hrm.leave_applications.leave_type_id
INNER JOIN office.users
ON office.users.user_id = hrm.leave_applications.entered_by
WHERE verification_status_id = 0;

-->-->-- C:/Users/nirvan/Desktop/mixerp/0. GitHub/src/FrontEnd/Modules/HRM/db/1.5/db/src/05.scrud-views/hrm.office_hour_scrud_view.sql --<--<--
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

-->-->-- C:/Users/nirvan/Desktop/mixerp/0. GitHub/src/FrontEnd/Modules/HRM/db/1.5/db/src/05.scrud-views/hrm.resignation_verification_view.sql --<--<--
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

-->-->-- C:/Users/nirvan/Desktop/mixerp/0. GitHub/src/FrontEnd/Modules/HRM/db/1.5/db/src/05.scrud-views/hrm.resignation_view.sql --<--<--
DROP VIEW IF EXISTS hrm.resignation_scrud_view;

CREATE VIEW hrm.resignation_scrud_view
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
ON forward_to.employee_id = hrm.resignations.forward_to;

-->-->-- C:/Users/nirvan/Desktop/mixerp/0. GitHub/src/FrontEnd/Modules/HRM/db/1.5/db/src/05.scrud-views/hrm.termination_scrud_view.sql --<--<--
DROP VIEW IF EXISTS hrm.termination_scrud_view;

CREATE VIEW hrm.termination_scrud_view
AS
SELECT
    hrm.terminations.termination_id,
    hrm.employees.employee_code || ' (' || hrm.employees.employee_name || ')' AS employee,
    hrm.employees.photo,
    hrm.terminations.notice_date,
    hrm.terminations.service_end_date,
    forwarded_to.employee_code || ' (' || forwarded_to.employee_name || ' )' AS forward_to,
    hrm.employment_statuses.employment_status_code || ' (' || hrm.employment_statuses.employment_status_name || ')' AS employment_status,
    hrm.terminations.reason,
    hrm.terminations.details
FROM hrm.terminations
INNER JOIN hrm.employees
ON hrm.employees.employee_id = hrm.terminations.employee_id
INNER JOIN hrm.employment_statuses
ON hrm.employment_statuses.employment_status_id = hrm.terminations.change_status_to
INNER JOIN hrm.employees AS forwarded_to
ON forwarded_to.employee_id = hrm.terminations.forward_to;

-->-->-- C:/Users/nirvan/Desktop/mixerp/0. GitHub/src/FrontEnd/Modules/HRM/db/1.5/db/src/05.scrud-views/hrm.termination_verification_scrud_view.sql --<--<--
DROP VIEW IF EXISTS hrm.termination_verification_scrud_view;

CREATE VIEW hrm.termination_verification_scrud_view
AS
SELECT
    hrm.terminations.termination_id,
    hrm.employees.employee_code || ' (' || hrm.employees.employee_name || ')' AS employee,
    hrm.employees.photo,
    hrm.terminations.notice_date,
    hrm.terminations.service_end_date,
    forwarded_to.employee_code || ' (' || forwarded_to.employee_name || ' )' AS forward_to,
    hrm.employment_statuses.employment_status_code || ' (' || hrm.employment_statuses.employment_status_name || ')' AS employment_status,
    hrm.terminations.reason,
    hrm.terminations.details
FROM hrm.terminations
INNER JOIN hrm.employees
ON hrm.employees.employee_id = hrm.terminations.employee_id
INNER JOIN hrm.employment_statuses
ON hrm.employment_statuses.employment_status_id = hrm.terminations.change_status_to
INNER JOIN hrm.employees AS forwarded_to
ON forwarded_to.employee_id = hrm.terminations.forward_to
WHERE verification_status_id = 0;

-->-->-- C:/Users/nirvan/Desktop/mixerp/0. GitHub/src/FrontEnd/Modules/HRM/db/1.5/db/src/05.views/hrm.attendance_view.sql --<--<--
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

-->-->-- C:/Users/nirvan/Desktop/mixerp/0. GitHub/src/FrontEnd/Modules/HRM/db/1.5/db/src/05.views/hrm.employee_view.sql --<--<--
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

-->-->-- C:/Users/nirvan/Desktop/mixerp/0. GitHub/src/FrontEnd/Modules/HRM/db/1.5/db/src/99.ownership.sql --<--<--
DO
$$
    DECLARE this record;
BEGIN
    IF(CURRENT_USER = 'mix_erp') THEN
        RETURN;
    END IF;

    FOR this IN 
    SELECT * FROM pg_tables 
    WHERE NOT schemaname = ANY(ARRAY['pg_catalog', 'information_schema'])
    AND tableowner <> 'mix_erp'
    LOOP
        EXECUTE 'ALTER TABLE '|| this.schemaname || '.' || this.tablename ||' OWNER TO mix_erp;';
    END LOOP;
END
$$
LANGUAGE plpgsql;

DO
$$
    DECLARE this record;
BEGIN
    IF(CURRENT_USER = 'mix_erp') THEN
        RETURN;
    END IF;

    FOR this IN 
    SELECT 'ALTER '
        || CASE WHEN p.proisagg THEN 'AGGREGATE ' ELSE 'FUNCTION ' END
        || quote_ident(n.nspname) || '.' || quote_ident(p.proname) || '(' 
        || pg_catalog.pg_get_function_identity_arguments(p.oid) || ') OWNER TO mix_erp;' AS sql
    FROM   pg_catalog.pg_proc p
    JOIN   pg_catalog.pg_namespace n ON n.oid = p.pronamespace
    WHERE  NOT n.nspname = ANY(ARRAY['pg_catalog', 'information_schema'])
    LOOP        
        EXECUTE this.sql;
    END LOOP;
END
$$
LANGUAGE plpgsql;


DO
$$
    DECLARE this record;
BEGIN
    IF(CURRENT_USER = 'mix_erp') THEN
        RETURN;
    END IF;

    FOR this IN 
    SELECT * FROM pg_views
    WHERE NOT schemaname = ANY(ARRAY['pg_catalog', 'information_schema'])
    AND viewowner <> 'mix_erp'
    LOOP
        EXECUTE 'ALTER VIEW '|| this.schemaname || '.' || this.viewname ||' OWNER TO mix_erp;';
    END LOOP;
END
$$
LANGUAGE plpgsql;


DO
$$
    DECLARE this record;
BEGIN
    IF(CURRENT_USER = 'mix_erp') THEN
        RETURN;
    END IF;

    FOR this IN 
    SELECT 'ALTER SCHEMA ' || nspname || ' OWNER TO mix_erp;' AS sql FROM pg_namespace
    WHERE nspname NOT LIKE 'pg_%'
    AND nspname <> 'information_schema'
    LOOP
        EXECUTE this.sql;
    END LOOP;
END
$$
LANGUAGE plpgsql;



DO
$$
    DECLARE this record;
BEGIN
    IF(CURRENT_USER = 'mix_erp') THEN
        RETURN;
    END IF;

    FOR this IN 
    SELECT      'ALTER TYPE ' || n.nspname || '.' || t.typname || ' OWNER TO mix_erp;' AS sql
    FROM        pg_type t 
    LEFT JOIN   pg_catalog.pg_namespace n ON n.oid = t.typnamespace 
    WHERE       (t.typrelid = 0 OR (SELECT c.relkind = 'c' FROM pg_catalog.pg_class c WHERE c.oid = t.typrelid)) 
    AND         NOT EXISTS(SELECT 1 FROM pg_catalog.pg_type el WHERE el.oid = t.typelem AND el.typarray = t.oid)
    AND         typtype NOT IN ('b')
    AND         n.nspname NOT IN ('pg_catalog', 'information_schema')
    LOOP
        EXECUTE this.sql;
    END LOOP;
END
$$
LANGUAGE plpgsql;


DO
$$
    DECLARE this record;
BEGIN
    IF(CURRENT_USER = 'report_user') THEN
        RETURN;
    END IF;

    FOR this IN 
    SELECT * FROM pg_tables 
    WHERE NOT schemaname = ANY(ARRAY['pg_catalog', 'information_schema'])
    AND tableowner <> 'report_user'
    LOOP
        EXECUTE 'GRANT SELECT ON TABLE '|| this.schemaname || '.' || this.tablename ||' TO report_user;';
    END LOOP;
END
$$
LANGUAGE plpgsql;

DO
$$
    DECLARE this record;
BEGIN
    IF(CURRENT_USER = 'report_user') THEN
        RETURN;
    END IF;

    FOR this IN 
    SELECT 'GRANT EXECUTE ON '
        || CASE WHEN p.proisagg THEN 'AGGREGATE ' ELSE 'FUNCTION ' END
        || quote_ident(n.nspname) || '.' || quote_ident(p.proname) || '(' 
        || pg_catalog.pg_get_function_identity_arguments(p.oid) || ') TO report_user;' AS sql
    FROM   pg_catalog.pg_proc p
    JOIN   pg_catalog.pg_namespace n ON n.oid = p.pronamespace
    WHERE  NOT n.nspname = ANY(ARRAY['pg_catalog', 'information_schema'])
    LOOP        
        EXECUTE this.sql;
    END LOOP;
END
$$
LANGUAGE plpgsql;


DO
$$
    DECLARE this record;
BEGIN
    IF(CURRENT_USER = 'report_user') THEN
        RETURN;
    END IF;

    FOR this IN 
    SELECT * FROM pg_views
    WHERE NOT schemaname = ANY(ARRAY['pg_catalog', 'information_schema'])
    AND viewowner <> 'report_user'
    LOOP
        EXECUTE 'GRANT SELECT ON '|| this.schemaname || '.' || this.viewname ||' TO report_user;';
    END LOOP;
END
$$
LANGUAGE plpgsql;


DO
$$
    DECLARE this record;
BEGIN
    IF(CURRENT_USER = 'report_user') THEN
        RETURN;
    END IF;

    FOR this IN 
    SELECT 'GRANT USAGE ON SCHEMA ' || nspname || ' TO report_user;' AS sql FROM pg_namespace
    WHERE nspname NOT LIKE 'pg_%'
    AND nspname <> 'information_schema'
    LOOP
        EXECUTE this.sql;
    END LOOP;
END
$$
LANGUAGE plpgsql;



-->-->-- C:/Users/nirvan/Desktop/mixerp/0. GitHub/src/FrontEnd/Modules/HRM/db/1.5/db/src/99.regional-data/Retail Industry.sample --<--<--
-->-->-- C:/Users/nirvan/Desktop/mixerp/0. GitHub/src/Modules/HRM/db/1.5/db/src/01.types-domains-tables-and-constraints/tables-and-constraints.sql --<--<--
/********************************************************************************
Copyright (C) MixERP Inc. (http://mixof.org).
This file is part of MixERP.
MixERP is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, version 2 of the License.
MixERP is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.
You should have received a copy of the GNU General Public License
along with MixERP.  If not, see <http://www.gnu.org/licenses/>.
***********************************************************************************/

--The meaning of the following should not change
INSERT INTO hrm.employment_status_codes
SELECT -7, 'DEC', 'Deceased'                UNION ALL
SELECT -6, 'DEF', 'Defaulter'               UNION ALL
SELECT -5, 'TER', 'Terminated'              UNION ALL
SELECT -4, 'RES', 'Resigned'                UNION ALL
SELECT -3, 'EAR', 'Early Retirement'        UNION ALL
SELECT -2, 'RET', 'Normal Retirement'       UNION ALL
SELECT -1, 'CPO', 'Contract Period Over'    UNION ALL
SELECT  0, 'NOR', 'Normal Employment'       UNION ALL
SELECT  1, 'OCT', 'On Contract'             UNION ALL
SELECT  2, 'PER', 'Permanent Job'           UNION ALL
SELECT  3, 'RTG', 'Retiring';

INSERT INTO hrm.employment_statuses(employment_status_code, employment_status_name, default_employment_status_code_id, is_contract)
SELECT 'EMP', 'Employee',       0, false UNION ALL
SELECT 'INT', 'Intern',         1, true UNION ALL
SELECT 'CON', 'Contract Basis', 1, true UNION ALL
SELECT 'PER', 'Permanent',      2, false;

INSERT INTO hrm.job_titles(job_title_code, job_title_name)
SELECT 'INT', 'Internship'                      UNION ALL
SELECT 'DEF', 'Default'                         UNION ALL
SELECT 'EXC', 'Executive'                       UNION ALL
SELECT 'MAN', 'Manager'                         UNION ALL
SELECT 'GEM', 'General Manager'                 UNION ALL
SELECT 'BME', 'Board Member'                    UNION ALL
SELECT 'CEO', 'Chief Executive Officer'         UNION ALL
SELECT 'CTO', 'Chief Technology Officer';

INSERT INTO hrm.pay_grades(pay_grade_code, pay_grade_name, minimum_salary, maximum_salary)
SELECT 'L-1', 'Level 1', 0, 0;

INSERT INTO hrm.shifts(shift_code, shift_name, begins_from, ends_on)
SELECT 'MOR', 'Morning Shift',  '6:00'::time,   '14:00'::time   UNION ALL
SELECT 'DAY', 'Day Shift',      '14:00',        '20:00'         UNION ALL
SELECT 'NIT', 'Night Shift',    '20:00',        '6:00';

INSERT INTO hrm.employee_types(employee_type_code, employee_type_name, account_id)
SELECT 'DEF', 'Default',            core.get_account_id_by_account_number('20100') UNION ALL
SELECT 'OUE', 'Outdoor Employees',  core.get_account_id_by_account_number('20100') UNION ALL
SELECT 'PRO', 'Project Employees',  core.get_account_id_by_account_number('20100') UNION ALL
SELECT 'SUP', 'Support Staffs',     core.get_account_id_by_account_number('20100') UNION ALL
SELECT 'ENG', 'Engineers',          core.get_account_id_by_account_number('20100');

INSERT INTO hrm.leave_types(leave_type_code, leave_type_name)
SELECT 'NOR', 'Normal' UNION ALL
SELECT 'EME', 'Emergency' UNION ALL
SELECT 'ILL', 'Illness';

INSERT INTO hrm.exit_types(exit_type_code, exit_type_name)
SELECT 'COE', 'Contract Period Over' UNION ALL
SELECT 'RET', 'Retirement' UNION ALL
SELECT 'RES', 'Resignation' UNION ALL
SELECT 'TER', 'Termination' UNION ALL
SELECT 'DEC', 'Deceased';

-->-->-- C:/Users/nirvan/Desktop/mixerp/0. GitHub/src/FrontEnd/Modules/HRM/db/1.5/db/src/99.sample/employees.sample --<--<--
INSERT INTO hrm.employees(employee_code, first_name, middle_name, last_name, employee_name, gender_code, marital_status_id, joined_on, office_id, user_id, employee_type_id, current_department_id, current_role_id, current_employment_status_id, current_job_title_id, current_pay_grade_id, current_shift_id, date_of_birth, photo, bank_account_number, bank_name, bank_branch_name)
SELECT 'MI-0001', 'Micheal', '', 'Paul', 'Paul, Micheal', 'M', '1'::int, '2015-09-12'::date, '2'::int, '2'::int, '1'::int, '1'::int, '1'::int, '1'::int, '1'::int, '1'::int, '2'::int, '1997-07-01'::date, 'sample/man-838636_640.jpg', '1-2939-3944-03', 'Bank of America', 'Myrtle Ave' UNION ALL
SELECT 'AR-0001', 'Arjun', '', 'Rivers', 'Rivers, Arjun', 'M', '2', '2015-09-05', '2', '2', '2', '2', '2', '2', '2', '1', '2', '2006-11-04', 'sample/beautiful-19075_640.jpg', '1-2939-3944-04', 'Bank of America', 'Myrtle Ave' UNION ALL
SELECT 'LA-0001', 'Lamar', '', 'Hull', 'Hull, Lamar', 'M', '3', '2015-09-24', '2', '2', '3', '3', '3', '3', '3', '1', '2', '1998-03-05', 'sample/beautiful-653317_640.jpg', '1-2939-3944-05', 'Bank of America', 'Myrtle Ave' UNION ALL
SELECT 'BE-0001', 'Beau', '', 'Stokes', 'Stokes, Beau', 'M', '4', '2015-09-21', '2', '2', '4', '4', '4', '4', '4', '1', '2', '1982-09-20', 'sample/beauty-20150_640.jpg', '1-2939-3944-06', 'Bank of America', 'Myrtle Ave' UNION ALL
SELECT 'KY-0001', 'Kyan', '', 'Barr', 'Barr, Kyan', 'M', '5', '2015-10-03', '2', '2', '5', '1', '5', '1', '5', '1', '2', '1978-10-21', 'sample/beauty-739667_640.jpg', '1-2939-3944-07', 'Bank of America', 'Myrtle Ave' UNION ALL
SELECT 'AR-0002', 'Arturo', '', 'Newman', 'Newman, Arturo', 'M', '6', '2015-09-12', '2', '2', '1', '2', '6', '2', '6', '1', '2', '2001-10-16', 'sample/brunette-15963_640.jpg', '1-2939-3944-08', 'Bank of America', 'Myrtle Ave' UNION ALL
SELECT 'MA-0001', 'Mateo', '', 'Mcdaniel', 'Mcdaniel, Mateo', 'F', '7', '2015-09-22', '2', '2', '2', '3', '7', '3', '7', '1', '2', '2013-12-13', 'sample/businessman-805770_640.jpg', '1-2939-3944-09', 'Bank of America', 'Myrtle Ave' UNION ALL
SELECT 'LA-0002', 'Larry', '', 'Farmer', 'Farmer, Larry', 'F', '1', '2015-10-06', '2', '2', '3', '4', '8', '4', '8', '1', '2', '2001-03-23', 'sample/chinese-572945_640.jpg', '1-2939-3944-10', 'Bank of America', 'Myrtle Ave' UNION ALL
SELECT 'BR-0001', 'Bryce', '', 'West', 'West, Bryce', 'M', '2', '2015-09-26', '2', '2', '4', '1', '9', '1', '1', '1', '2', '2012-09-18', 'sample/cowboy-67630_640.jpg', '1-2939-3944-11', 'Bank of America', 'Myrtle Ave' UNION ALL
SELECT 'DA-0001', 'Dalton', '', 'Cunningham', 'Cunningham, Dalton', 'F', '3', '2015-10-02', '2', '2', '5', '2', '10', '2', '2', '1', '2', '1980-10-02', 'sample/eyes-622355_640.jpg', '1-2939-3944-12', 'Bank of America', 'Myrtle Ave' UNION ALL
SELECT 'CH-0001', 'Chaz', '', 'Cote', 'Cote, Chaz', 'F', '4', '2015-10-02', '2', '2', '1', '3', '11', '3', '3', '1', '2', '1987-10-08', 'sample/fairy-tales-636649_640.jpg', '1-2939-3944-13', 'Bank of America', 'Myrtle Ave' UNION ALL
SELECT 'SY-0001', 'Sydney', '', 'Holley', 'Holley, Sydney', 'F', '5', '2015-09-08', '2', '2', '2', '4', '12', '4', '4', '1', '2', '1978-03-02', 'sample/friend-762590_640.jpg', '1-2939-3944-14', 'Bank of America', 'Myrtle Ave' UNION ALL
SELECT 'KA-0001', 'Karter', '', 'Barrera', 'Barrera, Karter', 'M', '6', '2015-10-01', '2', '2', '3', '1', '1', '1', '5', '1', '2', '1979-10-18', 'sample/girl-102829_640.jpg', '1-2939-3944-15', 'Bank of America', 'Myrtle Ave' UNION ALL
SELECT 'GU-0001', 'Gunner', '', 'Moses', 'Moses, Gunner', 'M', '7', '2015-09-14', '2', '2', '4', '2', '2', '2', '6', '1', '2', '1991-12-01', 'sample/girl-518321_640.jpg', '1-2939-3944-16', 'Bank of America', 'Myrtle Ave' UNION ALL
SELECT 'MA-0002', 'Marlon', '', 'Gates', 'Gates, Marlon', 'M', '1', '2015-09-11', '2', '2', '5', '3', '3', '3', '7', '1', '2', '1996-04-26', 'sample/girl-518331_640.jpg', '1-2939-3944-17', 'Bank of America', 'Myrtle Ave' UNION ALL
SELECT 'FI-0001', 'Fisher', '', 'Velazquez', 'Velazquez, Fisher', 'M', '2', '2015-09-12', '2', '2', '1', '4', '4', '4', '8', '1', '2', '1982-01-20', 'sample/girl-602177_640.jpg', '1-2939-3944-18', 'Bank of America', 'Myrtle Ave' UNION ALL
SELECT 'JA-0001', 'Jayce', '', 'Marsh', 'Marsh, Jayce', 'M', '3', '2015-08-31', '2', '2', '2', '1', '5', '1', '1', '1', '2', '1986-04-28', 'sample/girl-637568_640.jpg', '1-2939-3944-19', 'Bank of America', 'Myrtle Ave' UNION ALL
SELECT 'BE-0002', 'Bernardo', '', 'Franks', 'Franks, Bernardo', 'M', '4', '2015-09-12', '2', '2', '3', '2', '6', '2', '2', '1', '2', '2003-10-01', 'sample/girl-803179_640.jpg', '1-2939-3944-20', 'Bank of America', 'Myrtle Ave' UNION ALL
SELECT 'VI-0001', 'Victoria', '', 'Bland', 'Bland, Victoria', 'M', '5', '2015-10-01', '2', '2', '4', '3', '7', '3', '3', '1', '2', '1986-10-18', 'sample/girl-846991_640.jpg', '1-2939-3944-21', 'Bank of America', 'Myrtle Ave' UNION ALL
SELECT 'LE-0001', 'Lewis', '', 'Farrell', 'Farrell, Lewis', 'M', '6', '2015-08-28', '2', '2', '5', '4', '8', '4', '4', '1', '2', '1981-11-08', 'sample/girls-602168_640.jpg', '1-2939-3944-22', 'Bank of America', 'Myrtle Ave' UNION ALL
SELECT 'MA-0003', 'Maurice', '', 'Gibbs', 'Gibbs, Maurice', 'F', '7', '2015-10-10', '2', '2', '1', '1', '9', '1', '5', '1', '2', '1997-07-14', 'sample/guy-549173_640.jpg', '1-2939-3944-23', 'Bank of America', 'Myrtle Ave' UNION ALL
SELECT 'LE-0002', 'Lee', '', 'Mueller', 'Mueller, Lee', 'F', '1', '2015-10-01', '2', '2', '2', '2', '10', '2', '6', '1', '2', '1986-11-30', 'sample/indian-627831_640.jpg', '1-2939-3944-24', 'Bank of America', 'Myrtle Ave' UNION ALL
SELECT 'HA-0001', 'Hassan', '', 'Hendricks', 'Hendricks, Hassan', 'M', '2', '2015-09-21', '2', '2', '3', '3', '11', '3', '7', '1', '2', '1979-03-28', 'sample/james-stewart-392932_640.jpg', '1-2939-3944-25', 'Bank of America', 'Myrtle Ave' UNION ALL
SELECT 'IS-0001', 'Isabella', '', 'Rankin', 'Rankin, Isabella', 'F', '3', '2015-09-22', '2', '2', '4', '4', '12', '4', '8', '1', '2', '2010-08-31', 'sample/male-777913_640.jpg', '1-2939-3944-26', 'Bank of America', 'Myrtle Ave' UNION ALL
SELECT 'MA-0004', 'Matthias', '', 'Fitzpatrick', 'Fitzpatrick, Matthias', 'F', '4', '2015-10-06', '2', '2', '5', '1', '1', '1', '1', '1', '2', '1989-09-19', 'sample/man-140547_640.jpg', '1-2939-3944-27', 'Bank of America', 'Myrtle Ave';


DO
$$
    DECLARE _attendance_date date;
    DECLARE _employee_ids integer[];
    DECLARE _employee_id integer;
    DECLARE _was_present boolean;
    DECLARE _was_absent boolean;
    DECLARE _reason text;
    DECLARE _check_in time;
    DECLARE _check_out time;
    DECLARE _overtime_hours numeric;
BEGIN
    SELECT 
        array_agg(employee_id) 
    INTO
        _employee_ids
    FROM hrm.employees;
    
    DELETE FROM hrm.attendances;
    FOR _attendance_date IN
    SELECT * FROM generate_series('2015-9-29', '2016-9-1', INTERVAL '1 day') D
    LOOP
        FOREACH _employee_id IN ARRAY _employee_ids
        LOOP
            _was_present := cast(cast(random() as integer) as boolean);
            _was_absent := NOT _was_present;
            _check_in := NULL;
            _check_out := NULL;
            _overtime_hours := 0;
            _reason := '';
            
            IF(_was_present) THEN
                _check_in := ('2015-09-30 09:46:19.443+00'::timestamp - '1 minute'::INTERVAL * ROUND(RANDOM() * 100))::time;
                _check_out := ('2015-09-30 16:46:19.443+00'::timestamp - '1 minute'::INTERVAL * ROUND(RANDOM() * 100))::time;
                _overtime_hours := round(random());
            ELSE
                _reason := '';
            END IF;
            
            
            RAISE NOTICE '% %', _employee_id, _attendance_date;
            INSERT INTO hrm.attendances(office_id, employee_id, attendance_date, was_present, check_in_time, check_out_time, overtime_hours, was_absent, reason_for_absenteeism)
            SELECT 2, _employee_id, _attendance_date, _was_present, _check_in, _check_out, _overtime_hours, _was_absent, _reason;
        END LOOP;        
    END LOOP;
END
$$
LANGUAGE plpgsql;


-->-->-- C:/Users/nirvan/Desktop/mixerp/0. GitHub/src/FrontEnd/Modules/HRM/db/1.5/db/src/99.sample/kanban.sql --<--<--
DO
$$
    DECLARE objects text[];
    DECLARE users int[];
    DECLARE _user_id int;
    DECLARE _obj text;
BEGIN
    SELECT array_agg(user_id)
        INTO users
    FROM office.users INNER JOIN office.roles ON office.users.role_id = office.roles.role_id AND NOT is_system;

    objects := array[
        'hrm.employees', 
        'hrm.employment_statuses',
        'hrm.salaries',
        'hrm.wage_setup',
        'hrm.employee_type_scrud_view',
        'hrm.employee_identification_detail_scrud_view',
        'hrm.employee_social_network_detail_scrud_view',
        'hrm.employee_experience_scrud_view',
        'hrm.employee_qualification_scrud_view',
        'hrm.employee_wage_scrud_view',
        'hrm.leave_application_scrud_view',
        'hrm.contract_scrud_view',
        'hrm.exit_scrud_view',
        'hrm.education_levels',
        'hrm.job_titles',
        'hrm.pay_grades',
        'hrm.salary_types',
        'hrm.shifts',
        'hrm.office_hour_scrud_view',
        'hrm.leave_types',
        'hrm.leave_benefits',
        'hrm.exit_types',
        ''
        
        
        ];

    IF(_user_id IS NULL) THEN
        RETURN;
    END IF;

    FOREACH _user_id IN ARRAY users
    LOOP
        FOREACH _obj IN ARRAY objects
        LOOP
            PERFORM core.create_kanban(_obj, _user_id, 'Checklist');
            PERFORM core.create_kanban(_obj, _user_id, 'High Priority');
            PERFORM core.create_kanban(_obj, _user_id, 'Done');
        END LOOP;
    END LOOP;
END
$$
LANGUAGE plpgsql;
