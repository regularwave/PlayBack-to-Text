Public Class fromMain
    Private Sub fromMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        If 
    End Sub
End Class

Public Class AppFunctions
    'a class for different functions
    'use by calling Globals.FuncHold.[function]

    Function CheckForOutputPath() As Boolean
        If My.Settings.OutputhPath = "" Or vbNullString Then
            Return False
        Else
            Return True
        End If

    End Function


End Class

Public Class Globals
    Public Shared FuncHold As New AppFunctions


End Class