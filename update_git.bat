@echo off
git add .
git commit -m "Daily Challenge"
git push

echo [102;30m"Daily Challenge have been pushed!"[0m

timeout /t 1 /nobreak >nul
