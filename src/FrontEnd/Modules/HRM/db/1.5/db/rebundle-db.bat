@echo off
bundler\MixERP.Net.Utility.SqlBundler.exe ..\ "db" false false
copy mixerp.sql hrm-blank.sql
del mixerp.sql
pause