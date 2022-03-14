<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Logs
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Logs))
        Me.ListBoxLogs = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'ListBoxLogs
        '
        Me.ListBoxLogs.BackColor = Global.Generic_Counter.My.MySettings.Default.backcolor
        Me.ListBoxLogs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBoxLogs.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Generic_Counter.My.MySettings.Default, "backcolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ListBoxLogs.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.Generic_Counter.My.MySettings.Default, "forecolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ListBoxLogs.ForeColor = Global.Generic_Counter.My.MySettings.Default.forecolor
        Me.ListBoxLogs.FormattingEnabled = True
        Me.ListBoxLogs.Location = New System.Drawing.Point(12, 12)
        Me.ListBoxLogs.Name = "ListBoxLogs"
        Me.ListBoxLogs.Size = New System.Drawing.Size(355, 431)
        Me.ListBoxLogs.TabIndex = 0
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.Generic_Counter.My.MySettings.Default.backcolor
        Me.ClientSize = New System.Drawing.Size(379, 454)
        Me.Controls.Add(Me.ListBoxLogs)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.Generic_Counter.My.MySettings.Default, "forecolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Generic_Counter.My.MySettings.Default, "backcolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ForeColor = Global.Generic_Counter.My.MySettings.Default.forecolor
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Generic Counter Logs"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBoxLogs As ListBox
End Class
