Public Class fromMain
    Private Sub fromMain_Load(sender As Object, e As EventArgs) Handles Me.Load

        'check to see if this is the first time the program has been run
        GUse.aFunc.CheckForFirstRun()

        'check to see if playback.json exists and set its path
        If GUse.aFunc.DoesPlaybackJSONExist() Then
            GUse.aFunc.SetPlaybackJSONPath()
            txtJSONDir.Text = My.Settings.JSONPath
            lblJSON.ForeColor = Color.Green
            GVar.jrdy = True
        Else
            txtJSONDir.Text = "Find playback.json!"
            lblJSON.ForeColor = Color.Red
        End If

        'check to see if the output path is valid and set its path
        If GUse.aFunc.CheckForOutputPath() Then
            txtOutputDir.Text = My.Settings.OutputPath
            lblOutput.ForeColor = Color.Green
            GVar.ordy = True
        Else
            txtOutputDir.Text = "Choose valid output path!"
            lblOutput.ForeColor = Color.Red
        End If

        'if playback.json has been found and a valid path is set, enable start button
        btnStart.Enabled = GUse.aFunc.AllReady()

    End Sub

    Private Sub btnChangeOutputPath_Click(sender As Object, e As EventArgs) Handles btnChangeOutputPath.Click
        'get new dir and print
        My.Settings.OutputPath = GUse.aFunc.ChooseOutputFolder
        txtOutputDir.Text = My.Settings.OutputPath

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'clears stored paths and resets timer interval to 5 secs
        If MsgBox("This will clear all stored paths and reset the timer interval to 5 seconds." & vbNewLine & "Are you sure?", MsgBoxStyle.YesNo, "Reset?") = MsgBoxResult.Yes Then
            My.Settings.Reset()
            MsgBox("Settings reset!", vbCritical)
        End If

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        'calls the converter once and then enables the timer & stop, disables start & file funcs
        GUse.aFunc.Converter()
        btnStart.Enabled = False
        btnFindJSON.Enabled = False
        btnChangeOutputPath.Enabled = False
        btnReset.Enabled = False
        btnStop.Enabled = True
        tInterval.Enabled = True

    End Sub

    Private Sub btnFindJSON_Click(sender As Object, e As EventArgs) Handles btnFindJSON.Click
        'shouldn't be needed, but allows custom playback.json dir
        My.Settings.JSONPath = GUse.aFunc.FindPlaybackFile

    End Sub

    Private Sub nudInterval_ValueChanged(sender As Object, e As EventArgs) Handles nudInterval.ValueChanged
        'changes the interval at which playback.json is checked
        My.Settings.TimerInterval = nudInterval.Value * 1000
        tInterval.Interval = My.Settings.TimerInterval

    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        'disables the timer & stop, enables the start & file funcs, writes " - " to txt file
        tInterval.Enabled = False
        btnStop.Enabled = False
        btnStart.Enabled = True
        btnFindJSON.Enabled = True
        btnChangeOutputPath.Enabled = True
        btnReset.Enabled = True

        Using sw As New IO.StreamWriter(My.Settings.OutputPath & "\playback.txt")
            sw.WriteLine(" - ")
        End Using

    End Sub

    Private Sub tInterval_Tick(sender As Object, e As EventArgs) Handles tInterval.Tick
        'calls the converter each tick
        'interval is settings.timerinterval
        GUse.aFunc.Converter()

    End Sub

    Private Sub fromMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'if the program is exited, click the stop button
        btnStop.PerformClick()

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

    Function DoesPlaybackJSONExist() As Boolean
        'checks if playback.json exists in the default location
        If My.Computer.FileSystem.FileExists(GVar.defjsonloc) Then
            Return True
        Else
            Return False
        End If

    End Function

    Sub SetPlaybackJSONPath()
        'sets settings.jsonpath to GPMDP's default json store
        If My.Computer.FileSystem.FileExists(GVar.defjsonloc) Then
            My.Settings.JSONPath = GVar.defjsonloc
        End If

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

    Function FindPlaybackFile() As String
        'should never be needed; GPMDP only stores playback.json in one place
        Dim filedlog As New OpenFileDialog()

        filedlog.InitialDirectory = GVar.defjsondir
        filedlog.Filter = "playback.json|playback.json"
        filedlog.RestoreDirectory = True
        filedlog.Multiselect = False

        If filedlog.ShowDialog() = DialogResult.OK Then
            If Dir(filedlog.FileName) <> "" Then
                Return filedlog.FileName
            Else
                Return GVar.defjsonloc
            End If
        Else
            Return GVar.defjsonloc
        End If

    End Function

    Function AllReady() As Boolean
        'has the json been found AND there's a valid output path?
        If GVar.jrdy And GVar.ordy Then
            Return True
        Else
            Return False
        End If

    End Function

    Function Stringalizer() As String
        'converts playback.json to a "song - artist" string and returns it
        Dim stringJSON As String = GUse.aFunc.JSONtoString()
        Dim parsedNP = JsonConvert.DeserializeObject(Of NowPlaying)(stringJSON)
        Dim strtowrite As String = parsedNP.song.title & " - " & parsedNP.song.artist

        Return strtowrite

    End Function

    Function JSONtoString() As String
        'class-ify the json
        Dim filereader As String = ""

        Try
            filereader = My.Computer.FileSystem.ReadAllText(My.Settings.JSONPath)
        Catch ex As Exception
        End Try

        Return filereader

    End Function

    Sub Converter()
        'writes output text to playback.txt
        Using sw As New IO.StreamWriter(My.Settings.OutputPath & "\playback.txt")
            sw.WriteLine(GUse.aFunc.Stringalizer())
        End Using

    End Sub

End Class

Public Class GUse
    'creates aFunc object used to call functions from the AppFunctions class
    'use by calling GUse.aFunc.[function]
    Public Shared aFunc As New AppFunctions

End Class

Public Class GVar
    'global variables
    Public Shared homedirpath As String = My.Application.Info.DirectoryPath
    Public Shared defjsonloc As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Google Play Music Desktop Player\json_store\playback.json"
    Public Shared defjsondir As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Google Play Music Desktop Player\json_store"
    Public Shared jrdy As Boolean = False
    Public Shared ordy As Boolean = False

End Class

Public Class Song
    Public Property title As String
    Public Property artist As String
    Public Property album As String
    Public Property albumArt As String
End Class

Public Class Rating
    Public Property liked As Boolean
    Public Property disliked As Boolean
End Class

Public Class Time
    Public Property current As Integer
    Public Property total As Integer
End Class

Public Class NowPlaying
    Public Property playing As Boolean
    Public Property song As Song
    Public Property rating As Rating
    Public Property time As Time
    Public Property songLyrics As String
    Public Property shuffle As String
    Public Property repeat As String
    Public Property volume As Integer
End Class