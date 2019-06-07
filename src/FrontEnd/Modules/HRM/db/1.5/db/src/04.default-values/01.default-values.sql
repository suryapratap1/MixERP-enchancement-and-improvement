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