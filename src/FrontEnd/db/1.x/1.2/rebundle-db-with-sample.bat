@echo off

bundler\MixERP.Net.Utility.SqlBundler.exe ..\..\..\ "db/1.x/1.2" false true

cscript merge-files.vbs mixerp-incremental-sample.sql ..\1.1\mixerp-sample.sql mixerp.sql
del mixerp.sql
pause