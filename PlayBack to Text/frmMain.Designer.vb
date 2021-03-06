﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formMain))
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
        Me.lblString = New System.Windows.Forms.Label()
        Me.txtString = New System.Windows.Forms.TextBox()
        Me.ttpStringArgs = New System.Windows.Forms.ToolTip(Me.components)
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
        Me.btnReset.Location = New System.Drawing.Point(257, 58)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(43, 23)
        Me.btnReset.TabIndex = 1
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Enabled = False
        Me.btnStart.Location = New System.Drawing.Point(8, 84)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(145, 23)
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
        Me.nudInterval.Location = New System.Drawing.Point(195, 59)
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
        Me.lblInterval.Location = New System.Drawing.Point(152, 61)
        Me.lblInterval.Name = "lblInterval"
        Me.lblInterval.Size = New System.Drawing.Size(42, 13)
        Me.lblInterval.TabIndex = 3
        Me.lblInterval.Text = "Interval"
        '
        'btnStop
        '
        Me.btnStop.Enabled = False
        Me.btnStop.Location = New System.Drawing.Point(155, 84)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(145, 23)
        Me.btnStop.TabIndex = 1
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'lblString
        '
        Me.lblString.AutoSize = True
        Me.lblString.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblString.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblString.Location = New System.Drawing.Point(5, 62)
        Me.lblString.Name = "lblString"
        Me.lblString.Size = New System.Drawing.Size(34, 13)
        Me.lblString.TabIndex = 5
        Me.lblString.Text = "String"
        Me.ttpStringArgs.SetToolTip(Me.lblString, "%song% or %title% - song title" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "%artist% - artist" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "%album% - album title")
        '
        'txtString
        '
        Me.txtString.Location = New System.Drawing.Point(46, 58)
        Me.txtString.Name = "txtString"
        Me.txtString.Size = New System.Drawing.Size(100, 20)
        Me.txtString.TabIndex = 6
        Me.ttpStringArgs.SetToolTip(Me.txtString, "%title% - song title" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "%artist% - artist" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "%album% - album title")
        '
        'formMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 116)
        Me.Controls.Add(Me.txtString)
        Me.Controls.Add(Me.lblString)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formMain"
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
    Friend WithEvents lblString As Label
    Friend WithEvents txtString As TextBox
    Friend WithEvents ttpStringArgs As ToolTip
End Class
