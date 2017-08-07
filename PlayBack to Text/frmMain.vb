Public Class fromMain
    Private Sub fromMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        'check to see if this is the first time the program has been run
        GUse.aFunc.CheckForFirstRun()
        GUse.aFunc.SetPlaybackJSONPath()

        'if this is the first time the program is run, my.settings.outputpath is blank
        'so set it to program directory; after first run, don't change
        If GUse.aFunc.CheckForOutputPath() Then
            txtOutputDir.Text = My.Settings.OutputPath
            lblOutput.ForeColor = Color.Green
        Else
            txtOutputDir.Text = "output path isn't set"
            lblOutput.ForeColor = Color.Red
        End If
    End Sub

    Private Sub btnChangeOutputPath_Click(sender As Object, e As EventArgs) Handles btnChangeOutputPath.Click, btnFindJSON.Click
        'get new dir and print
        My.Settings.OutputPath = GUse.aFunc.ChooseOutputFolder
        txtOutputDir.Text = My.Settings.OutputPath
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'clears stored paths and resets timer interval to 5 secs
        My.Settings.Reset()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'check outputpath
        If GUse.aFunc.CheckForOutputPath() Then
            txtOutputDir.Text = My.Settings.OutputPath
            lblOutput.ForeColor = Color.Green
        Else
            txtOutputDir.Text = "output path isn't set"
            lblOutput.ForeColor = Color.Red
        End If
    End Sub
End Class

Public Class AppFunctions
    'a class for different functions
    'use by calling GUse.aFunc.[function]

    Sub CheckForFirstRun() 'As Boolean
        'default for settings.firstrun = true
        'if it's true, set the output path to the program's dir and set to false
        If My.Settings.firstrun = True Then
            My.Settings.OutputPath = GVar.homedirpath
            My.Settings.firstrun = False
        End If
    End Sub

    Function CheckForOutputPath() As Boolean
        'checks to see if a path is set in my.settings.outputpath
        If My.Settings.OutputPath = "" Then
            Return False
        Else
            Return True
        End If

    End Function

    Sub SetPlaybackJSONPath()
        'sets settings.jsonpath to GPMDP's default json store
        Dim appdata As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
        My.Settings.JSONPath = appdata & "\Google Play Music Desktop Player\json_store"
    End Sub

    Function ChooseOutputFolder() As String
        Dim folderdlog As New FolderBrowserDialog()
        folderdlog.ShowNewFolderButton = True

        'return chosen file directory if OK is clicked, program dir if anything else
        If folderdlog.ShowDialog() = DialogResult.OK Then
            Return folderdlog.SelectedPath
        Else
            Return GVar.homedirpath
        End If
    End Function
End Class

Public Class GUse
    'creates aFunc object used to call functions from the AppFunctions class
    'use by calling GUse.aFunc.[function]
    Public Shared aFunc As New AppFunctions

End Class

Public Class GVar
    'global variables
    Public Shared homedirpath As String = My.Application.Info.DirectoryPath

End Class