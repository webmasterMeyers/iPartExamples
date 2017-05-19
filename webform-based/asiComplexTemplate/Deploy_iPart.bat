REM Set WEB_ROOT and SCHEDULER_BIN to values appropriate for your environment. 
REM WEB_ROOT = path to your web root folder
REM AsiSchedulerPoolName = name of the ASI Scheduler Application pool

set PROJ_DIR=%1

set WEB_ROOT=C:\Program Files (x86)\ASI\iMIS15\Net

set IPART_DEPLOY_PATH="%WEB_ROOT%\iParts\$safeprojectname$"
set WEB_BIN="%WEB_ROOT%\bin"

set SCHEDULER_BIN=C:\AsiPlatform\Asi.Scheduler_iMIS\bin

SET AsiSchedulerPoolName=AsiSchedulerPool

REM Define the appcmd utility
SET appcmd="ECHO APPCMD NOT FOUND - cannot "
IF EXIST "c:\windows\system32\inetsrv\appcmd.exe" (
SET appcmd="c:\windows\system32\inetsrv\appcmd.exe"
) ELSE (
IF EXIST "d:\windows\system32\inetsrv\appcmd.exe" SET appcmd="d:\windows\system32\inetsrv\appcmd.exe"
)

@ECHO Stopping the ASI scheduler app pool
%appcmd% stop apppool %AsiSchedulerPoolName%
ECHO Stopped.

cd %PROJ_DIR%

REM Create iPart directory if it does not exist
IF NOT EXIST %IPART_DEPLOY_PATH% (MD %IPART_DEPLOY_PATH%)

xcopy /y /r $safeprojectname$Display.ascx %IPART_DEPLOY_PATH%
xcopy /y /r $safeprojectname$ConfigEdit.ascx %IPART_DEPLOY_PATH%
xcopy /y /r $safeprojectname$Help.htm %IPART_DEPLOY_PATH%
xcopy /y /r bin\$safeprojectname$.dll %WEB_BIN%
xcopy /y /r bin\$safeprojectname$.pdb %WEB_BIN%
xcopy /y /r bin\$safeprojectname$.dll %SCHEDULER_BIN%
xcopy /y /r bin\$safeprojectname$.pdb %SCHEDULER_BIN%

@ECHO Re-starting the ASI scheduler app pool...
%appcmd% start apppool %AsiSchedulerPoolName%
ECHO Started.

pause
