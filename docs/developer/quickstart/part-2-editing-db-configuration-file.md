#Editing DB Configuration

Edit one of the following files using Visual Studio or any text editor of your choice.

**WebForms**


``src/FrontEnd/Resource/Configs/DbServer.xml``


**MVC**

``src-beta2/Web/MixERP.Net.Web.UI/Resource/Configs/DbServer.xml``

##File Contents

```xml
<configuration>
  <appSettings>
    <add key="Server" value="localhost" />
    <add key="Port" value="5432" />
    <add key="Database" value="mixerp" />
    <add key="UserId" value="mix_erp" />
    <add key="Password" value="change-on-deployment" />
    <add key="Catalogs" value="mixerp, mixerp2, mixerp4" />
    <add key="MetaDatabase" value="postgres" />
    <add key="ReportUserId" value="report_user" />
    <add key="ReportUserPassword" value="change-on-deployment" />
    <add key="AutoBackupEveryNMinutes" value="720" />
    
    <add key="PostgreSQLBinDirectory" value="C:\Program Files\PostgreSQL\9.4\bin\" />
    <add key="DatabaseBackupDirectory" value="/Backups/" />
  </appSettings>
</configuration>
```

###Configuration Explained

| Key                         | Configuration |
|-----------------------------| -------------|
| Server                      | The hostname or IP address of your development PostgreSQL Server instance. Usually "localhost". |
| Port                        | The port on which the PostgreSQL server is listening. Usually "5432". |
| Database                    | The default MixERP database. |
| UserId                      | MixERP database script will create a user mix_erp. Leave it as it is unless you are sure what you are doing. |
| Password                    | Password for the above user. The default password is "change-on-deployment". If you happen to change the password, change it here as well. |
| Catalogs                    | Comma separated list of MixERP databases including the default database. These databases will be shown on the ***sign in page***. |
| MetaCatalog                 | The **master database** which contains multi-company meta information. |
| ReportUserId                | MixERP database script will create a user report_user. This user **must have a read-only access to the database**.|
| ReportUserPassword          | Password for the above user. The default password is "change-on-deployment". If you happen to change the password, change it here as well. |
| AutoBackupEveryNMinutes     | By default, MixERP performs automated backups every 12 hours or 720 minutes. |
| PostgreSQLBinDirectory      | Depending upon where you installed PostgreSQL server, enter the correct location of the bin directory. |
| DatabaseBackupDirectory     | Enter the path where you want to keep your database backups. If you host MixERP on IIS, make sure that the ApplicationPoolIdentity/IIS user has write access to the path. |

##Related Topics
* [Part 1: Installing Database](part-1-installing-database.md)
* [Documentation Home](../../../index.md)