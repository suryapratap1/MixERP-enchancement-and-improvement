#Web Configuration File (web.config)

Web.config is the default configuration file of an IIS site. It is an XML document that provides numerous
configuration possibilities for a web application. Let's dive deeper into the required sections
and settings related to MixERP application configuration.

##No Viewstate

Yes, that's right, no more ViewState craziness!!!

```xml
<system.web>
<pages enableViewState="false" enableViewStateMac="false" enableEventValidation="false" />
</system.web>
```


##No Dynamic ClientID

Turn off the magic "dynamic ClientIDs" that ASP.net produces.

```xml
<system.web>
<pages clientIDMode="Static" />
</system.web>
```



##Configure IIS to Serve *.backup Files

MixERP creates database backups using [custom pg_dump format](http://www.postgresql.org/docs/9.4/static/backup-dump.html)
with **zlib compression library**. Since IIS does not understand how to serve ***.backup** file extension, an administrator
has to ensure that the backup files are properly being served as static contents.

**Create a static file handler for** ***.backup file extension**

```xml
<system.webServer>
<handlers>
<add name="StaticHandler" verb="*" path="*.backup" type="System.Web.StaticFileHandler" preCondition="integratedMode" />
</handlers>
</system.webServer>
```

**Create a Mime Map for** ***.backup file extension**

```xml
<system.webServer>
<staticContent>
<mimeMap fileExtension=".backup" mimeType="application/octet-stream" />
</staticContent>
</system.webServer>
```

<div class="ui info message">
    This document assumes that your organization's policy allows downloading backups using a web browser
    software. If your organization does not allow backup files to be served via http(s),
    you may have to undertake extra steps to configure that, which is out of the scope of this document.
</div>


##Register AttachmentFactory Upload Handlers and Services

AttachmentFactory exposes a couple of HTTP handlers and WebServices.

**HTTP Handler**

``MixERP.Net.WebControls.AttachmentFactory.FileUploadHanlder``

**XML Web Service**

``MixERP.Net.WebControls.AttachmentFactory.Handlers.UploadService``

**Create Handlers**

```xml
<system.webServer>
<handlers>
<add name="FileUploadHanlder" path="FileUploadHanlder.ashx" verb="*" type="MixERP.Net.WebControls.AttachmentFactory.FileUploadHanlder, MixERP.Net.WebControls.AttachmentFactory, Version=1.0.0.0, Culture=neutral" />
<add name="FileUploadService" path="FileUploadHanlder.asmx" verb="*" type="MixERP.Net.WebControls.AttachmentFactory.Handlers.UploadService, MixERP.Net.WebControls.AttachmentFactory, Version=1.0.0.0, Culture=neutral" preCondition="integratedMode" />
</handlers>
</system.webServer>
```

<div class="ui info message">
    <p>
        You need to instruct IIS to serve the above handlers on the paths you configured in
        <a href="attachment-factory-parameters.md">AttachmentFactoryParameters</a>, namely:
    </p>
    <ul>
        <li>UploadHandlerUrl</li>
        <li>UndoUploadServiceUrl</li>
    </ul>
</div>


##Configure AppSettings

The **appSettings** section is the one and only place that contains information about other configuration files.

```xml
<appSettings>
<add key="SupressMissingResourceException" value="true" />
<add key="DisplayErrorDetails" value="false" />
<add key="MaxInvalidPasswordAttempts" value="10" />
<add key="ReportAPIConfigFileLocation" value="/Resource/Configs/ReportApiConfiguration.config" />
<add key="DbServerConfigFileLocation" value="/Resource/Configs/DbServer.config" />
<add key="PartyControlConfigFileLocation" value="/Resource/Configs/PartyControlParameters.config" />
<add key="TransactionChecklistConfigFileLocation" value="/Resource/Configs/TransactionChecklistParameters.config" />
<add key="ParameterConfigFileLocation" value="/Resource/Configs/Parameters.config" />
<add key="ReportConfigFileLocation" value="/Resource/Configs/ReportParameters.config" />
<add key="StockTransactionFactoryConfigFileLocation" value="/Resource/Configs/StockTransactionFactoryParameters.config" />
<add key="UpdaterConfigFileLocation" value="/Resource/Configs/Updater.config" />
</appSettings>
```

**SupressMissingResourceException**

Set this true if you want to supress "MissingManifestResourceException" when
an i18n resource key is not found. Turn this on (true) on production site.

**DisplayErrorDetails**

Set this to true if you do not want to display the complete exception stack trace
to the application user. Turn this off (false) on production site.

**MaxInvalidPasswordAttempts**

Maximum number of invalid password attempts, after which no more sign in attempt will be allowed.

**APIConfigFileLocation .. SwitchConfigFileLocation**

The path of configuration files relative to web application root directory.

##Related Topics
* [Administrator Documentation](../admin.md)