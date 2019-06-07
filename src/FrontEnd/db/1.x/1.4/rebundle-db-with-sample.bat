@echo off

bundler\MixERP.Net.Utility.SqlBundler.exe ..\..\..\ "db/1.x/1.4" false true

c:\windows\system32\cscript.exe merge-files.vbs mixerp-incremental-sample.sql ..\..\1.x\1.2\mixerp-incremental-sample.sql mixerp.sql
del mixerp.sql
copy mixerp-incremental-sample.sql ..\..\sample-db.sql