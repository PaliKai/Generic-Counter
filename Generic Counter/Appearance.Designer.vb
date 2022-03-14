<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Appearance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Appearance))
        Me.ButtonChangeForeground = New System.Windows.Forms.Button()
        Me.ColorDialog = New System.Windows.Forms.ColorDialog()
        Me.ButtonChangeBackground = New System.Windows.Forms.Button()
        Me.ButtonRename = New System.Windows.Forms.Button()
        Me.CheckBoxSwitchDeathMode = New System.Windows.Forms.CheckBox()
        Me.CheckBoxAnimalCrossing = New System.Windows.Forms.CheckBox()
        Me.CheckBoxAnimalCrossingDark = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'btnChangeForeground
        '
        Me.ButtonChangeForeground.BackColor = Global.Generic_Counter.My.MySettings.Default.backcolor
        Me.ButtonChangeForeground.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.Generic_Counter.My.MySettings.Default, "forecolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ButtonChangeForeground.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Generic_Counter.My.MySettings.Default, "backcolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ButtonChangeForeground.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonChangeForeground.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonChangeForeground.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonChangeForeground.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonChangeForeground.ForeColor = Global.Generic_Counter.My.MySettings.Default.forecolor
        Me.ButtonChangeForeground.Location = New System.Drawing.Point(23, 12)
        Me.ButtonChangeForeground.Name = "btnChangeForeground"
        Me.ButtonChangeForeground.Size = New System.Drawing.Size(149, 26)
        Me.ButtonChangeForeground.TabIndex = 0
        Me.ButtonChangeForeground.Text = "Change Text Color"
        Me.ButtonChangeForeground.UseVisualStyleBackColor = False
        '
        'btnChangeBackground
        '
        Me.ButtonChangeBackground.BackColor = Global.Generic_Counter.My.MySettings.Default.backcolor
        Me.ButtonChangeBackground.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.Generic_Counter.My.MySettings.Default, "forecolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ButtonChangeBackground.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Generic_Counter.My.MySettings.Default, "backcolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ButtonChangeBackground.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonChangeBackground.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonChangeBackground.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonChangeBackground.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonChangeBackground.ForeColor = Global.Generic_Counter.My.MySettings.Default.forecolor
        Me.ButtonChangeBackground.Location = New System.Drawing.Point(23, 44)
        Me.ButtonChangeBackground.Name = "btnChangeBackground"
        Me.ButtonChangeBackground.Size = New System.Drawing.Size(149, 26)
        Me.ButtonChangeBackground.TabIndex = 1
        Me.ButtonChangeBackground.Text = "Change Background Color"
        Me.ButtonChangeBackground.UseVisualStyleBackColor = False
        '
        'btnRename
        '
        Me.ButtonRename.BackColor = Global.Generic_Counter.My.MySettings.Default.backcolor
        Me.ButtonRename.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.Generic_Counter.My.MySettings.Default, "forecolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ButtonRename.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Generic_Counter.My.MySettings.Default, "backcolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ButtonRename.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonRename.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonRename.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonRename.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRename.ForeColor = Global.Generic_Counter.My.MySettings.Default.forecolor
        Me.ButtonRename.Location = New System.Drawing.Point(23, 76)
        Me.ButtonRename.Name = "btnRename"
        Me.ButtonRename.Size = New System.Drawing.Size(149, 26)
        Me.ButtonRename.TabIndex = 2
        Me.ButtonRename.Text = "Rename Counting Word"
        Me.ButtonRename.UseVisualStyleBackColor = False
        '
        'cbSwitchDeathMode
        '
        Me.CheckBoxSwitchDeathMode.AutoSize = True
        Me.CheckBoxSwitchDeathMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxSwitchDeathMode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CheckBoxSwitchDeathMode.Location = New System.Drawing.Point(23, 109)
        Me.CheckBoxSwitchDeathMode.Name = "cbSwitchDeathMode"
        Me.CheckBoxSwitchDeathMode.Size = New System.Drawing.Size(155, 20)
        Me.CheckBoxSwitchDeathMode.TabIndex = 3
        Me.CheckBoxSwitchDeathMode.Text = "Switch to Death Mode"
        Me.CheckBoxSwitchDeathMode.UseVisualStyleBackColor = True
        '
        'cbAnimalCrossing
        '
        Me.CheckBoxAnimalCrossing.AutoSize = True
        Me.CheckBoxAnimalCrossing.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxAnimalCrossing.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CheckBoxAnimalCrossing.Location = New System.Drawing.Point(21, 135)
        Me.CheckBoxAnimalCrossing.Name = "cbAnimalCrossing"
        Me.CheckBoxAnimalCrossing.Size = New System.Drawing.Size(161, 20)
        Me.CheckBoxAnimalCrossing.TabIndex = 4
        Me.CheckBoxAnimalCrossing.Text = "Animal Counting (Light)"
        Me.CheckBoxAnimalCrossing.UseVisualStyleBackColor = True
        '
        'cbAnimalCrossingDark
        '
        Me.CheckBoxAnimalCrossingDark.AutoSize = True
        Me.CheckBoxAnimalCrossingDark.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxAnimalCrossingDark.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CheckBoxAnimalCrossingDark.Location = New System.Drawing.Point(20, 158)
        Me.CheckBoxAnimalCrossingDark.Name = "cbAnimalCrossingDark"
        Me.CheckBoxAnimalCrossingDark.Size = New System.Drawing.Size(162, 20)
        Me.CheckBoxAnimalCrossingDark.TabIndex = 5
        Me.CheckBoxAnimalCrossingDark.Text = "Animal Counting (Dark)"
        Me.CheckBoxAnimalCrossingDark.UseVisualStyleBackColor = True
        '
        'appearance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.Generic_Counter.My.MySettings.Default.backcolor
        Me.ClientSize = New System.Drawing.Size(194, 190)
        Me.Controls.Add(Me.CheckBoxAnimalCrossingDark)
        Me.Controls.Add(Me.CheckBoxAnimalCrossing)
        Me.Controls.Add(Me.CheckBoxSwitchDeathMode)
        Me.Controls.Add(Me.ButtonRename)
        Me.Controls.Add(Me.ButtonChangeBackground)
        Me.Controls.Add(Me.ButtonChangeForeground)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Generic_Counter.My.MySettings.Default, "backcolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "appearance"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Appearance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonChangeForeground As Button
    Friend WithEvents ColorDialog As ColorDialog
    Friend WithEvents ButtonChangeBackground As Button
    Friend WithEvents ButtonRename As Button
    Friend WithEvents CheckBoxSwitchDeathMode As CheckBox
    Friend WithEvents CheckBoxAnimalCrossing As CheckBox
    Friend WithEvents CheckBoxAnimalCrossingDark As CheckBox
End Class
