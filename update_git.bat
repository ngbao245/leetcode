@echo off

REM Set colors
set GREEN=0A
set RED=0C

REM Run git commands
git add .
if errorlevel 1 (
    echo ^[[%RED%Failed to add files.
    exit /b 1
)

git commit -m "Daily Challenge"
if errorlevel 1 (
    echo ^[[%RED%Failed to commit changes.
    exit /b 1
)

git push
if errorlevel 1 (
    echo ^[[%RED%Failed to push changes.
    exit /b 1
)

echo ^[[%GREEN%Changes pushed successfully.
