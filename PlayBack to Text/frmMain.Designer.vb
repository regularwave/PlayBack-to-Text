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
        Me.txtOutputDir = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnChangeOutputPath = New System.Windows.Forms.Button()
        Me.txtJSONDir = New System.Windows.Forms.TextBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.btnFindJSON = New System.Windows.Forms.Button()
        Me.lblJSON = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtOutputDir
        '
        Me.txtOutputDir.Location = New System.Drawing.Point(51, 12)
        Me.txtOutputDir.Name = "txtOutputDir"
        Me.txtOutputDir.ReadOnly = True
        Me.txtOutputDir.Size = New System.Drawing.Size(147, 20)
        Me.txtOutputDir.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(21, 413)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 85)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "reset"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(21, 322)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(135, 85)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "check"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnChangeOutputPath
        '
        Me.btnChangeOutputPath.Location = New System.Drawing.Point(204, 12)
        Me.btnChangeOutputPath.Name = "btnChangeOutputPath"
        Me.btnChangeOutputPath.Size = New System.Drawing.Size(26, 20)
        Me.btnChangeOutputPath.TabIndex = 1
        Me.btnChangeOutputPath.Text = "..."
        Me.btnChangeOutputPath.UseVisualStyleBackColor = True
        '
        'txtJSONDir
        '
        Me.txtJSONDir.Location = New System.Drawing.Point(51, 38)
        Me.txtJSONDir.Name = "txtJSONDir"
        Me.txtJSONDir.ReadOnly = True
        Me.txtJSONDir.Size = New System.Drawing.Size(147, 20)
        Me.txtJSONDir.TabIndex = 2
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Location = New System.Drawing.Point(9, 15)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(39, 13)
        Me.lblOutput.TabIndex = 3
        Me.lblOutput.Text = "Output"
        '
        'btnFindJSON
        '
        Me.btnFindJSON.Location = New System.Drawing.Point(204, 38)
        Me.btnFindJSON.Name = "btnFindJSON"
        Me.btnFindJSON.Size = New System.Drawing.Size(26, 20)
        Me.btnFindJSON.TabIndex = 1
        Me.btnFindJSON.Text = "..."
        Me.btnFindJSON.UseVisualStyleBackColor = True
        '
        'lblJSON
        '
        Me.lblJSON.AutoSize = True
        Me.lblJSON.Location = New System.Drawing.Point(10, 42)
        Me.lblJSON.Name = "lblJSON"
        Me.lblJSON.Size = New System.Drawing.Size(35, 13)
        Me.lblJSON.TabIndex = 3
        Me.lblJSON.Text = "JSON"
        '
        'fromMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 559)
        Me.Controls.Add(Me.lblJSON)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.txtJSONDir)
        Me.Controls.Add(Me.btnFindJSON)
        Me.Controls.Add(Me.btnChangeOutputPath)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtOutputDir)
        Me.Name = "fromMain"
        Me.Text = "PlayBack to Text"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtOutputDir As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnChangeOutputPath As Button
    Friend WithEvents txtJSONDir As TextBox
    Friend WithEvents lblOutput As Label
    Friend WithEvents btnFindJSON As Button
    Friend WithEvents lblJSON As Label
End Class
