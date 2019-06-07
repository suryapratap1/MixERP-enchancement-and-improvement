@echo off
bundler\MixERP.Net.Utility.SqlBundler.exe ..\..\..\ "db/1.x/1.6" false false

copy mixerp.sql mixerp-patch-for-1.5.sql
copy mixerp.sql ..\..\patch.sql

c:\windows\system32\cscript.exe merge-files.vbs mixerp-incremental-blank-db.sql ..\..\1.x\1.5\mixerp-incremental-blank-db.sql mixerp.sql
copy mixerp-incremental-blank-db.sql ..\..\blank-db.sql
del mixerp.sql

pause	