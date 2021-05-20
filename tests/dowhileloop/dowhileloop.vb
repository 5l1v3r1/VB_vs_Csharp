Imports System
Imports System.Diagnostics

Public Class dowhileloop
    Public Shared Sub Main()
        Dim timer As Stopwatch = New Stopwatch()
        timer.Start()
        dowhilelooptest()
        timer.Stop()
        Console.Write(timer.ElapsedMilliseconds.ToString())
    End Sub

    Shared Sub dowhilelooptest()
        Dim heavyNo As Long = 1000000000
        Dim i As Long = 0
        Do 
            i += 1
        Loop While i < heavyNo
    End Sub
End Class
