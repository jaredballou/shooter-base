@echo off
for /f "delims=" %%x in (settings.ini) do (set "%%x")
"%SDK_TOOLS_PATH%\hlmv.exe" -game "%MOD_PATH%" %1 %2 %3 %4 %5 %6 %7 %8 %9