<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fromMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtOutputDir = New System.Windows.Forms.TextBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnChangeOutputPath = New System.Windows.Forms.Button()
        Me.txtJSONDir = New System.Windows.Forms.TextBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.btnFindJSON = New System.Windows.Forms.Button()
        Me.lblJSON = New System.Windows.Forms.Label()
        Me.tInterval = New System.Windows.Forms.Timer(Me.components)
        Me.nudInterval = New System.Windows.Forms.NumericUpDown()
        Me.lblInterval = New System.Windows.Forms.Label()
        Me.btnStop = New System.Windows.Forms.Button()
        CType(Me.nudInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtOutputDir
        '
        Me.txtOutputDir.Location = New System.Drawing.Point(46, 32)
        Me.txtOutputDir.Name = "txtOutputDir"
        Me.txtOutputDir.ReadOnly = True
        Me.txtOutputDir.Size = New System.Drawing.Size(222, 20)
        Me.txtOutputDir.TabIndex = 0
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(277, 58)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(20, 23)
        Me.btnReset.TabIndex = 1
        Me.btnReset.Text = "X"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Enabled = False
        Me.btnStart.Location = New System.Drawing.Point(103, 58)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(79, 23)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnChangeOutputPath
        '
        Me.btnChangeOutputPath.Location = New System.Drawing.Point(274, 33)
        Me.btnChangeOutputPath.Name = "btnChangeOutputPath"
        Me.btnChangeOutputPath.Size = New System.Drawing.Size(26, 20)
        Me.btnChangeOutputPath.TabIndex = 1
        Me.btnChangeOutputPath.Text = "..."
        Me.btnChangeOutputPath.UseVisualStyleBackColor = True
        '
        'txtJSONDir
        '
        Me.txtJSONDir.Location = New System.Drawing.Point(46, 6)
        Me.txtJSONDir.Name = "txtJSONDir"
        Me.txtJSONDir.ReadOnly = True
        Me.txtJSONDir.Size = New System.Drawing.Size(222, 20)
        Me.txtJSONDir.TabIndex = 2
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Location = New System.Drawing.Point(5, 35)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(39, 13)
        Me.lblOutput.TabIndex = 3
        Me.lblOutput.Text = "Output"
        '
        'btnFindJSON
        '
        Me.btnFindJSON.Location = New System.Drawing.Point(274, 7)
        Me.btnFindJSON.Name = "btnFindJSON"
        Me.btnFindJSON.Size = New System.Drawing.Size(26, 20)
        Me.btnFindJSON.TabIndex = 1
        Me.btnFindJSON.Text = "..."
        Me.btnFindJSON.UseVisualStyleBackColor = True
        '
        'lblJSON
        '
        Me.lblJSON.AutoSize = True
        Me.lblJSON.Location = New System.Drawing.Point(5, 9)
        Me.lblJSON.Name = "lblJSON"
        Me.lblJSON.Size = New System.Drawing.Size(35, 13)
        Me.lblJSON.TabIndex = 3
        Me.lblJSON.Text = "JSON"
        '
        'tInterval
        '
        Me.tInterval.Interval = 5000
        '
        'nudInterval
        '
        Me.nudInterval.Location = New System.Drawing.Point(48, 59)
        Me.nudInterval.Maximum = New Decimal(New Integer() {180, 0, 0, 0})
        Me.nudInterval.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudInterval.Name = "nudInterval"
        Me.nudInterval.Size = New System.Drawing.Size(49, 20)
        Me.nudInterval.TabIndex = 4
        Me.nudInterval.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'lblInterval
        '
        Me.lblInterval.AutoSize = True
        Me.lblInterval.Location = New System.Drawing.Point(5, 61)
        Me.lblInterval.Name = "lblInterval"
        Me.lblInterval.Size = New System.Drawing.Size(42, 13)
        Me.lblInterval.TabIndex = 3
        Me.lblInterval.Text = "Interval"
        '
        'btnStop
        '
        Me.btnStop.Enabled = False
        Me.btnStop.Location = New System.Drawing.Point(189, 58)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(79, 23)
        Me.btnStop.TabIndex = 1
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'fromMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 89)
        Me.Controls.Add(Me.nudInterval)
        Me.Controls.Add(Me.lblJSON)
        Me.Controls.Add(Me.lblInterval)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.txtJSONDir)
        Me.Controls.Add(Me.btnFindJSON)
        Me.Controls.Add(Me.btnChangeOutputPath)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.txtOutputDir)
        Me.Name = "fromMain"
        Me.Text = "PlayBack to Text"
        CType(Me.nudInterval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtOutputDir As TextBox
    Friend WithEvents btnReset As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents btnChangeOutputPath As Button
    Friend WithEvents txtJSONDir As TextBox
    Friend WithEvents lblOutput As Label
    Friend WithEvents btnFindJSON As Button
    Friend WithEvents lblJSON As Label
    Friend WithEvents tInterval As Timer
    Friend WithEvents nudInterval As NumericUpDown
    Friend WithEvents lblInterval As Label
    Friend WithEvents btnStop As Button
End Class
