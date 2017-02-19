@echo off
rem Settings for Shooter Base tools
set MOD_NAME=Shooter Base
set MOD_DIR=shooterbase
set SOURCEMODS_PATH=C:\Program Files (x86)\Steam\SteamApps\sourcemods
set MOD_PATH=%SOURCEMODS_PATH%\%MOD_DIR%
set SDK_TOOLS_PATH=D:\Steam\steamapps\common\insurgency2\bin
set GAME_PATH=D:\Steam\steamapps\common\insurgency2
set GAME_EXE_FILE=insurgency.exe
set GAME_EXE_PATH=%GAME_PATH%\%GAME_EXE_FILE%
rem D:\Steam\steamapps\common\Source SDK Base 2013 Singleplayer

rem Include settings.local.cmd which allows developers to override these values
rem without having their changes blown away during pulls
if exist settings.local.cmd (call settings.local.cmd) else (echo @echo off > settings.local.cmd)