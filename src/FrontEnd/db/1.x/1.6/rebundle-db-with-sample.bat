@echo off

bundler\MixERP.Net.Utility.SqlBundler.exe ..\..\..\ "db/1.x/1.6" false true

c:\windows\system32\cscript.exe merge-files.vbs mixerp-incremental-sample.sql ..\..\1.x\1.5\mixerp-incremental-sample.sql mixerp.sql
copy mixerp-incremental-sample.sql ..\..\sample-db.sql
del mixerp.sql

pause