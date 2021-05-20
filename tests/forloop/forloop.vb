Imports System
Imports System.Diagnostics
Imports System.IO

Public Class forloop
    Public Shared Sub Main()
        Dim timer As Stopwatch = New Stopwatch()
        timer.Start()
        forlooptest()
        timer.Stop()
        Console.Write(timer.ElapsedMilliseconds.ToString())
    End Sub

    Private Shared Sub forlooptest()
        Dim heavyNo As Long = 100000000
        For i As Integer = 0 To heavyNo - 1
		
        Next
    End Sub
End Class
