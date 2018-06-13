@ECHO OFF

echo Run castle tests
:loop
.\CastleProblem\bin\Debug\CastleProblem.exe

IF ERRORLEVEL 1 GOTO Failed

goto loop

:Failed
PAUSE