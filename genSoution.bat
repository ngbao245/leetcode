@echo off
setlocal enabledelayedexpansion

:: ==========================
:: SETUP
:: ==========================
color 0A
set "basepath=%~dp0"
set "path=%basepath%LeetCodeCS"

:: ==========================
:: INPUT
:: ==========================
set /p rawname=Please enter topic: 

for /f "tokens=1* delims=." %%a in ("%rawname%") do (
    set num=%%a
    set title=%%b
)

set num=%num: =%
set title=%title: = %

:: ==========================
:: FORMAT NUMBER
:: ==========================
set "num=0000%num%"
set "num=!num:~-4!"

:: ==========================
:: FORMAT TITLE
:: ==========================
set formattedTitle=
for %%w in (%title%) do (
    set word=%%w
    set first=!word:~0,1!
    set rest=!word:~1!
    set formattedTitle=!formattedTitle!!first!!rest!
)
set formattedTitle=%formattedTitle: =%

:: ==========================
:: CREATE FILE
:: ==========================
if not exist "%path%" mkdir "%path%"
set "filename=!num!_!formattedTitle!.cs"
set "fullpath=%path%\!filename!"

if exist "!fullpath!" (
    color 0A
    echo =====================================================
    echo  File already exists: "!filename!"
    echo  No new file created.
    echo =====================================================
    echo.
    pause
    exit
)

:: ==========================
:: WRITE FILE (safe)
:: ==========================
type nul > "!fullpath!"
color 0A
echo =====================================================
echo  File created successfully!
echo  !fullpath!
echo =====================================================
echo.
pause

endlocal
exit

