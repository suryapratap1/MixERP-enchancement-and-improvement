@echo off
SET builddir=%~dp0
rmdir "%~dp0..\src\FrontEnd\bin" /Q /S
del "%~dp0..\src\FrontEnd\Backups\*.zip"


rmdir "C:\inetpub\wwwroot\mixerp\Modules\Payroll" /Q /S
if exist "../src/MixERP.Net.sln" (
	@echo Building MixERP.Net.sln
	"%programfiles(x86)%\MSBuild\14.0\Bin\MSBuild.exe" /verbosity:quiet /nologo /property:Configuration=Release ../src/MixERP.Net.sln
)

if exist "../src/FrontEnd/Modules/HRM/MixERP.Net.Core.Modules.HRM.sln" (
	@echo Building HRM
	"%programfiles(x86)%\MSBuild\14.0\Bin\MSBuild.exe" /verbosity:quiet /nologo /property:Configuration=Release ../src/FrontEnd/Modules/HRM/MixERP.Net.Core.Modules.HRM.sln
)

rmdir "C:\inetpub\wwwroot\mixerp" /Q /S
mkdir "C:\inetpub\wwwroot\mixerp"

icacls "C:\inetpub\wwwroot\mixerp" /grant "IIS AppPool\MixERPTest":(OI)(CI)M /T
icacls "C:\inetpub\wwwroot\mixerp" /grant "Authenticated Users":(OI)(CI)F /T

xcopy  "%~dp0..\src\FrontEnd" "C:\inetpub\wwwroot\mixerp\" /s/h/e/c
rmdir "C:\inetpub\wwwroot\mixerp\Modules\Payroll" /Q /S
rmdir "C:\inetpub\wwwroot\mixerp\Modules\Payroll.API" /Q /S
rmdir "C:\inetpub\wwwroot\mixerp\Modules\Payroll.Data" /Q /S
rmdir "C:\inetpub\wwwroot\mixerp\Modules\Payroll.Entities" /Q /S
rmdir "C:\inetpub\wwwroot\mixerp\Modules\Production" /Q /S
rmdir "C:\inetpub\wwwroot\mixerp\Modules\Production.API" /Q /S
rmdir "C:\inetpub\wwwroot\mixerp\Modules\Production.Data" /Q /S
rmdir "C:\inetpub\wwwroot\mixerp\Modules\Production.Entities" /Q /S
rmdir "C:\inetpub\wwwroot\mixerp\db\1.x\1.1" /Q /S
rmdir "C:\inetpub\wwwroot\mixerp\db\1.x\1.2" /Q /S
rmdir "C:\inetpub\wwwroot\mixerp\db\1.x\1.3" /Q /S
rmdir "C:\inetpub\wwwroot\mixerp\db\1.x\1.4" /Q /S
rmdir "C:\inetpub\wwwroot\mixerp\db\1.x\1.5" /Q /S
rmdir "C:\inetpub\wwwroot\mixerp\db\1.x\1.6\bundler" /Q /S
rmdir "C:\inetpub\wwwroot\mixerp\db\1.x\1.6\dumps" /Q /S
rmdir "C:\inetpub\wwwroot\mixerp\db\1.x\1.6\src" /Q /S
rmdir "C:\inetpub\wwwroot\mixerp\obj" /Q /S
rmdir "C:\inetpub\wwwroot\mixerp\Modules\HRM\packages" /Q /S


cd "C:\inetpub\wwwroot\mixerp"
del /s /q *.cs
del /s /q *.bat
del /s /q *.vbs
del /s /q *.sqlbundle
del /s /q *.csproj
del /s /q *.user
del /s /q *.psd
del /s /q *.cache
del /s /q *.FileListAbsolute.txt
del /s /q *.log
del /s /q *.force

cd "C:\inetpub\wwwroot\mixerp\Modules"
del /s /q *.dll
del /s /q *.pdb


@echo OK
