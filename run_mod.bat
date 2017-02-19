@echo off
call settings.cmd
echo "%GAME_EXE_PATH%" -dev -game "%MOD_PATH%" -allowdebug %1 %2 %3 %4 %5 %6 %7 %8 %9
pause