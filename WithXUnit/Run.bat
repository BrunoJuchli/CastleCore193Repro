@ECHO OFF

:loop
echo Run castle tests
.\CastleProblem\bin\Debug\xunit.console.exe CastleProblem\bin\Debug\CastleProblem.dll -nologo -noshadow -noappdomain

IF ERRORLEVEL 1 GOTO Failed

goto loop

:Failed
PAUSE