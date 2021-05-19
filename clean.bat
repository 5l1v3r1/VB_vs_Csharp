@ECHO OFF
setlocal enabledelayedexpansion
for %%f in (.\Bin\*.exe) do (
  del %%f
)

for %%f in (.\Results\*.txt) do (
  del %%f
)