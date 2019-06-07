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