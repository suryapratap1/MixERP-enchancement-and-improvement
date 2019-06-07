@echo off
copy "..\regional-data\en-US\Retail Industry.sql" "src\99.regional-data\Retail Industry.sample"
bundler\MixERP.Net.Utility.SqlBundler.exe ..\ "db" false true
copy mixerp.sql hrm-with-regional-data.sql
del mixerp.sql
pause