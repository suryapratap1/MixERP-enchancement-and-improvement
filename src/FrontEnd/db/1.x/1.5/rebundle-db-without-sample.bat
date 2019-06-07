@echo off
bundler\MixERP.Net.Utility.SqlBundler.exe ..\..\..\ "db/1.x/1.5" false false

copy mixerp.sql mixerp-patch-for-1.4.sql

c:\windows\system32\cscript.exe merge-files.vbs ..\..\patch.sql mixerp.sql ..\..\..\Modules\HRM\db\1.5\db\hrm-blank.sql

c:\windows\system32\cscript.exe merge-files.vbs mixerp-incremental-blank-db.sql ..\..\1.x\1.4\mixerp-incremental-blank-db.sql mixerp.sql
del mixerp.sql

c:\windows\system32\cscript.exe merge-files.vbs ..\..\blank-db.sql mixerp-incremental-blank-db.sql ..\..\..\Modules\HRM\db\1.5\db\hrm-blank.sql
pause