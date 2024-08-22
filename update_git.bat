@echo off
git add .
git commit -m "Daily Challenge"
git push

color 0A
echo Daily Challenge have been pushed!

timeout /t 1 /nobreak >nul