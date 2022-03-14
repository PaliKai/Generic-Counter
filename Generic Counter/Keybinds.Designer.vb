<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Keybinds
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
        Me.CheckBoxIncreaseBind = New System.Windows.Forms.CheckBox()
        Me.LabelIncreaseBind = New System.Windows.Forms.Label()
        Me.LabelDecreaseBind = New System.Windows.Forms.Label()
        Me.CheckBoxDecreaseBind = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'cbIncreaseBind
        '
        Me.CheckBoxIncreaseBind.AutoSize = True
        Me.CheckBoxIncreaseBind.BackColor = Global.Generic_Counter.My.MySettings.Default.backcolor
        Me.CheckBoxIncreaseBind.ForeColor = Global.Generic_Counter.My.MySettings.Default.forecolor
        Me.CheckBoxIncreaseBind.Location = New System.Drawing.Point(12, 16)
        Me.CheckBoxIncreaseBind.Name = "cbIncreaseBind"
        Me.CheckBoxIncreaseBind.Size = New System.Drawing.Size(94, 17)
        Me.CheckBoxIncreaseBind.TabIndex = 0
        Me.CheckBoxIncreaseBind.Text = "Increase Bind:"
        Me.CheckBoxIncreaseBind.UseVisualStyleBackColor = False
        '
        'lblIncreaseBind
        '
        Me.LabelIncreaseBind.AutoSize = True
        Me.LabelIncreaseBind.BackColor = Global.Generic_Counter.My.MySettings.Default.backcolor
        Me.LabelIncreaseBind.ForeColor = Global.Generic_Counter.My.MySettings.Default.forecolor
        Me.LabelIncreaseBind.Location = New System.Drawing.Point(111, 17)
        Me.LabelIncreaseBind.Name = "lblIncreaseBind"
        Me.LabelIncreaseBind.Size = New System.Drawing.Size(46, 13)
        Me.LabelIncreaseBind.TabIndex = 1
        Me.LabelIncreaseBind.Text = "PageUp"
        '
        'lblDecreaseBind
        '
        Me.LabelDecreaseBind.AutoSize = True
        Me.LabelDecreaseBind.BackColor = Global.Generic_Counter.My.MySettings.Default.backcolor
        Me.LabelDecreaseBind.ForeColor = Global.Generic_Counter.My.MySettings.Default.forecolor
        Me.LabelDecreaseBind.Location = New System.Drawing.Point(111, 40)
        Me.LabelDecreaseBind.Name = "lblDecreaseBind"
        Me.LabelDecreaseBind.Size = New System.Drawing.Size(29, 13)
        Me.LabelDecreaseBind.TabIndex = 3
        Me.LabelDecreaseBind.Text = "Next"
        '
        'cbDecreaseBind
        '
        Me.CheckBoxDecreaseBind.AutoSize = True
        Me.CheckBoxDecreaseBind.BackColor = Global.Generic_Counter.My.MySettings.Default.backcolor
        Me.CheckBoxDecreaseBind.ForeColor = Global.Generic_Counter.My.MySettings.Default.forecolor
        Me.CheckBoxDecreaseBind.Location = New System.Drawing.Point(12, 39)
        Me.CheckBoxDecreaseBind.Name = "cbDecreaseBind"
        Me.CheckBoxDecreaseBind.Size = New System.Drawing.Size(99, 17)
        Me.CheckBoxDecreaseBind.TabIndex = 2
        Me.CheckBoxDecreaseBind.Text = "Decrease Bind:"
        Me.CheckBoxDecreaseBind.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.Generic_Counter.My.MySettings.Default.backcolor
        Me.ClientSize = New System.Drawing.Size(194, 190)
        Me.Controls.Add(Me.LabelDecreaseBind)
        Me.Controls.Add(Me.CheckBoxDecreaseBind)
        Me.Controls.Add(Me.LabelIncreaseBind)
        Me.Controls.Add(Me.CheckBoxIncreaseBind)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Generic_Counter.My.MySettings.Default, "backcolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form4"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Keybinds"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CheckBoxIncreaseBind As CheckBox
    Friend WithEvents LabelIncreaseBind As Label
    Friend WithEvents LabelDecreaseBind As Label
    Friend WithEvents CheckBoxDecreaseBind As CheckBox
End Class
