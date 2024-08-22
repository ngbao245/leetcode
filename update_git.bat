@echo off
git add .
git commit -m "Daily Challenge"
git push

for /f "tokens=2 delims==" %%I in ('"prompt $E&for %%A in (C) do @echo prompt $E"') do set "ORIG_COLOR=%%I"

color 0A
echo Daily Challenge have been pushed!

color %ORIG_COLOR%

pause