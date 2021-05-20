@ECHO OFF
setlocal enabledelayedexpansion
for %%f in (.\Bin\*.exe) do (
echo|set /p="%%~nf: "
%%f
%%f > .\Results\%%~nxf.txt
echo ms
)