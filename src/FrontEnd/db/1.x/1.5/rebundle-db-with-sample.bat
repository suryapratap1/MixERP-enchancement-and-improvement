@echo off

bundler\MixERP.Net.Utility.SqlBundler.exe ..\..\..\ "db/1.x/1.5" false true

c:\windows\system32\cscript.exe merge-files.vbs mixerp-incremental-sample.sql ..\..\1.x\1.4\mixerp-incremental-sample.sql mixerp.sql
del mixerp.sql

c:\windows\system32\cscript.exe merge-files.vbs ..\..\sample-db.sql mixerp-incremental-sample.sql ..\..\..\Modules\HRM\db\1.5\db\hrm-with-sample-data.sql

pause