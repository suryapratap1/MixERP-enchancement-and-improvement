#AttachmentFactory Parameters

This configuration file is related to the module [AttachmentFactory](../user-guide/core-concepts/attachment-factory.md).

```sql
SELECT * FROM config.attachment_factory;
```

| Key                         | Value |
|-----------------------------| -------------|
| AttachmentsDirectory        | /Resource/Static/Attachments/ |
| UploadHandlerUrl            | ~/FileUploadHanlder.ashx |
| UndoUploadServiceUrl        | ~/FileUploadHanlder.asmx/UndoUpload |
| AllowedExtensions           | jpg,jpeg,gif,png,tif,doc,docx,xls,xlsx,pdf |

##AttachmentsDirectory
This instructs attachment factory to upload attachments to the specified directory. 
You must **ensure that the the directory is writable** by  IIS user or IIS Application Pool identity 
or whatever user account that your site is running under.

##UploadHandlerUrl
The attachment factory Javascript Ajax library will upload attachments to this url. Make sure that you
create handler a mapping in [web.config](web.config.md) file which matches this location.

##UndoUploadServiceUrl
The attachment factory Javascript Ajax library will request this url to undo upload. Make sure that you
create handler mapping in [web.config](web.config.md) file which matches this location.

##AllowedExtensions
List of allowed extensions that would be allowed as attachments.


##Related Topics
* [Web Configuration File](web.config.md)
* [Administrator Documentation](../admin.md)