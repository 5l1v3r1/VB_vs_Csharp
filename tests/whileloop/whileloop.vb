Imports System
Imports System.Diagnostics

Public Class whileloop
    Public Shared Sub Main()
        Dim timer As Stopwatch = New Stopwatch()
        timer.Start()
        whilelooptest()
        timer.Stop()
        Console.Write(timer.ElapsedMilliseconds.ToString())
    End Sub

    Shared Sub whilelooptest()
        Dim heavyNo As Long = 1000000000
        Dim i As Long = 0
        While i < heavyNo
            i += 1
        End While
    End Sub
End Class
