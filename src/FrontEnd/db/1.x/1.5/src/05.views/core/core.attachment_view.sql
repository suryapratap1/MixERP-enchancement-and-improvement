DROP VIEW IF EXISTS core.attachment_view;

CREATE VIEW core.attachment_view
AS
SELECT 
    core.attachments.attachment_id, 
    core.attachment_lookup.book,
    core.attachments.user_id, 
    core.attachments.resource, 
    core.attachments.resource_key, 
    core.attachments.resource_id, 
    core.attachments.original_file_name, 
    core.attachments.file_extension, 
    core.attachments.file_path, 
    core.attachments.comment, 
    core.attachments.added_on
FROM core.attachments 
INNER JOIN core.attachment_lookup
ON core.attachments.resource = core.attachment_lookup.resource;