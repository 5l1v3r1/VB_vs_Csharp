Imports System
Imports System.Diagnostics
Imports System.IO

Public Class forloopeach
    Public Shared Sub Main()
        Dim timer As Stopwatch = New Stopwatch()
        timer.Start()
        forloopeachtest()
        timer.Stop()
        Console.WriteLine(timer.ElapsedMilliseconds.ToString())
    End Sub

    Private Shared Sub forloopeachtest()
        Dim heavycars As String() = New String() {"Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda","Volvo", "BMW", "Ford", "Mazda", "Mazda","Volvo"} 
        For each car As String In heavycars
		
        Next
        For each car As String In heavycars
		
        Next
        For each car As String In heavycars
		
        Next
        For each car As String In heavycars
		
        Next
        For each car As String In heavycars
		
        Next
    End Sub
End Class
