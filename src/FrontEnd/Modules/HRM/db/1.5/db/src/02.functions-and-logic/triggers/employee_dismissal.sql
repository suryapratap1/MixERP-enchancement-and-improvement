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