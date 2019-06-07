@echo off
bundler\MixERP.Net.Utility.SqlBundler.exe ..\..\..\ "db/1.x/1.4" false false

copy mixerp.sql mixerp-patch-for-rc.sql
copy mixerp.sql ..\..\patch.sql

c:\windows\system32\cscript.exe merge-files.vbs mixerp-incremental-blank-db.sql ..\..\1.x\1.2\mixerp-incremental-blank-db.sql mixerp.sql
del mixerp.sql
copy mixerp-incremental-blank-db.sql ..\..\blank-db.sql
