@ECHO OFF

cd .\CastleProblem\bin\Debug\

:loop
echo Run castle tests (single mock access per class)
xunit.console.exe CastleProblem.dll -nologo -noshadow -noappdomain

IF ERRORLEVEL 1 GOTO Failed

goto loop

:Failed
PAUSE