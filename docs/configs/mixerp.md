#MixERP Configuration




```sql
SELECT * FROM config.mixerp;
```

| Key                         | Value |
|-----------------------------| -------------|
| MinimumLogLevel             | Information  |
| ApplicationLogDirectory     | C:\mixerp-logs |
| Mode                        | Development |

**MinimumLogLevel**

MixERP uses Serilog logging framework. 

[From Serilog Wiki](https://github.com/serilog/serilog/wiki/Writing-Log-Events#log-event-levels):

Serilog uses levels as the primary means for assigning importance to log events. The levels in increasing order of importance are:

* **Verbose** - tracing information and debugging minutiae; generally only switched on in unusual situations
* **Debug** - internal control flow and diagnostic state dumps to facilitate pinpointing of recognised problems
* **Information** - events of interest or that have relevance to outside observers; the default enabled minimum logging level
* **Warning** - indicators of possible issues or service/functionality degradation
* **Error** - indicating a failure within the application or connected system
* **Fatal** - critical errors causing complete failure of the application


**ApplicationLogDirectory**

Must be a physical path and application pool identity user must be able to write to it.

**Mode**

The default **"Development"** mode restricts elevated tasks such as taking backups, performing 
EOD operation, changing passwords to localhost only. When you deploy MixERP to a production environment,
change this setting to **"Production"**.


##Related Topics
* [Web Configuration File](web.config.md)
* [Administrator Documentation](../admin.md)