@ECHO OFF
setlocal enabledelayedexpansion
for %%f in (.\Bin\*.exe) do (
  %%f > .\Results\%%~nxf.txt
)