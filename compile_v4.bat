@echo off

set "v4=C:\Windows\Microsoft.NET\Framework\v4.0.30319"

set "vb=%v4%\vbc.exe"
set "cs=%v4%\csc.exe"


For /R .\tests\ %%G IN (*.cs) do (
  %cs% -w:0 /nologo /out:Bin\%%~nG_cs.exe %%G
)

For /R .\tests\ %%G IN (*.vb) do (
  %vb% -w:0 /nologo /out:Bin\%%~nG_vb.exe %%G
)
