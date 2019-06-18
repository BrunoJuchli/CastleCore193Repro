@ECHO OFF

SET StartDate=%date%
SET StartTime=%time%

:loop
echo Run castle tests (.net framework 4.8
echo %StartDate% %StartTime% (first run)
echo %date% %time% (this run)
.\NetCoreRepro\bin\Debug\net48\win10-x64\NetCoreRepro.exe

IF ERRORLEVEL 1 GOTO Failed

goto loop

:Failed
PAUSE