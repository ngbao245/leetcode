@echo off
git add .
git commit -m "Daily Challenge"
git push

if %ERRORLEVEL% NEQ 0 (
    echo An error occurred.
    exit /b %ERRORLEVEL%
)

echo ^[[32mUpdate successful!^[[0m