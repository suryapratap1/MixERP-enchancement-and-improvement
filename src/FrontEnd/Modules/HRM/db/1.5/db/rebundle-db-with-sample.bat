@echo off
copy "..\regional-data\en-US\Retail Industry.sql" "src\99.regional-data\Retail Industry.sample"
bundler\MixERP.Net.Utility.SqlBundler.exe ..\ "db" true true
copy mixerp.sql hrm-with-sample-data.sql
del mixerp.sql
pause