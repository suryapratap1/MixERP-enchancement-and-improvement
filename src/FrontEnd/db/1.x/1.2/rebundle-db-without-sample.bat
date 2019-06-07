@echo off
bundler\MixERP.Net.Utility.SqlBundler.exe ..\..\..\ "db/1.x/1.2" false false

copy mixerp.sql mixerp-patch-for-v1.sql

cscript merge-files.vbs mixerp-incremental-blank-db.sql ..\1.1\mixerp-blank.sql mixerp.sql
del mixerp.sql