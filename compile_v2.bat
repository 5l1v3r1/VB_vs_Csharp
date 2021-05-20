@echo off

set "v2=C:\Windows\Microsoft.NET\Framework\v2.0.50727"

set "vb=%v2%\vbc.exe"
set "cs=%v2%\csc.exe"


For /R .\tests\ %%G IN (*.cs) do (
  %cs% /nologo /out:Bin\%%~nG_cs.exe %%G
)

For /R .\tests\ %%G IN (*.vb) do (
  %vb% /nologo /out:Bin\%%~nG_vb.exe %%G
)
