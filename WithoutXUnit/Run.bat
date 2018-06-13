@ECHO OFF

:loop
echo Run castle tests
.\CastleProblem\bin\Debug\CastleProblem.exe

IF ERRORLEVEL 1 GOTO Failed

goto loop

:Failed
PAUSE