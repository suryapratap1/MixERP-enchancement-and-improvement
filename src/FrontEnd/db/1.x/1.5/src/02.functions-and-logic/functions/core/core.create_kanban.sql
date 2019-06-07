DROP FUNCTION IF EXISTS core.create_kanban
(
    _object_name                        national character varying(128),
    _user_id                            integer,
    _kanban_name                        national character varying(128),
    _description                        text
);

CREATE FUNCTION core.create_kanban
(
    _object_name                        national character varying(128),
    _user_id                            integer,
    _kanban_name                        national character varying(128),
    _description                        text = ''
)
RETURNS void
AS
$$
BEGIN
    IF EXISTS
    (
        SELECT 1 FROM core.kanbans
        WHERE object_name = _object_name
        AND user_id = _user_id
        AND kanban_name = _kanban_name
    ) THEN
        UPDATE core.kanbans
        SET description = _description
        WHERE object_name = _object_name
        AND user_id = _user_id
        AND _kanban_name = _kanban_name;

        RETURN;
    END IF;

    INSERT INTO core.kanbans(object_name, user_id, kanban_name, description)
    SELECT _object_name, _user_id, _kanban_name, _description;
END
$$
LANGUAGE plpgsql;