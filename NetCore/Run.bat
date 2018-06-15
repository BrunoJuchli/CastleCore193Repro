@ECHO OFF

:loop
echo Run castle tests
.\NetCoreRepro\bin\Debug\netcoreapp2.1\win10-x64\NetCoreRepro.exe

IF ERRORLEVEL 1 GOTO Failed

goto loop

:Failed
PAUSE