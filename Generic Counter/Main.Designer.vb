<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main

    Inherits System.Windows.Forms.Form

    Dim red, green, blue As Integer

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.lblName = New System.Windows.Forms.Label()
        Me.EditDirectlyText = New System.Windows.Forms.Label()
        Me.ButtonCommit = New System.Windows.Forms.Button()
        Me.ButtonClearEdit = New System.Windows.Forms.Button()
        Me.TextBoxFilePath = New System.Windows.Forms.TextBox()
        Me.LabelFilePath = New System.Windows.Forms.Label()
        Me.ButtonFindPath = New System.Windows.Forms.Button()
        Me.ButtonShow = New System.Windows.Forms.Button()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.ButtonEnable = New System.Windows.Forms.Button()
        Me.TextBoxEdit = New System.Windows.Forms.MaskedTextBox()
        Me.ToolTipAdd = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTipRemove = New System.Windows.Forms.ToolTip(Me.components)
        Me.LabelVersion = New System.Windows.Forms.Label()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MenuItemAppearance = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemCounterSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemIncrements = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemSound = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemNoSound = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemUwU = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemYouDied = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemOof = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemFlop = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemCustomAudio = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemBrowse = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemKeybinds = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemLogs = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemTutorial = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemDiscord = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonRemove = New System.Windows.Forms.Button()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.CheckBoxSave = New System.Windows.Forms.CheckBox()
        Me.ToolTipSave = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureGenericCounter = New System.Windows.Forms.PictureBox()
        Me.PictureDeaths = New System.Windows.Forms.PictureBox()
        Me.LabelCounter = New System.Windows.Forms.Label()
        Me.PictureAnimalCrossing = New System.Windows.Forms.PictureBox()
        Me.MenuStrip.SuspendLayout()
        CType(Me.PictureGenericCounter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureDeaths, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureAnimalCrossing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = Global.Generic_Counter.My.MySettings.Default.backcolor
        Me.lblName.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.Generic_Counter.My.MySettings.Default, "forecolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.lblName.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Generic_Counter.My.MySettings.Default, "backcolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.lblName.ForeColor = Global.Generic_Counter.My.MySettings.Default.forecolor
        Me.lblName.Location = New System.Drawing.Point(12, 465)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(84, 13)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Generic Counter"
        '
        'EditDirectlyText
        '
        Me.EditDirectlyText.AutoSize = True
        Me.EditDirectlyText.BackColor = Global.Generic_Counter.My.MySettings.Default.backcolor
        Me.EditDirectlyText.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.Generic_Counter.My.MySettings.Default, "forecolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.EditDirectlyText.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Generic_Counter.My.MySettings.Default, "backcolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.EditDirectlyText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditDirectlyText.ForeColor = Global.Generic_Counter.My.MySettings.Default.forecolor
        Me.EditDirectlyText.Location = New System.Drawing.Point(57, 194)
        Me.EditDirectlyText.Name = "EditDirectlyText"
        Me.EditDirectlyText.Size = New System.Drawing.Size(111, 20)
        Me.EditDirectlyText.TabIndex = 3
        Me.EditDirectlyText.Text = "Edit Directly:"
        '
        'ButtonCommit
        '
        Me.ButtonCommit.BackColor = Global.Generic_Counter.My.MySettings.Default.backcolor
        Me.ButtonCommit.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Generic_Counter.My.MySettings.Default, "backcolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ButtonCommit.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.Generic_Counter.My.MySettings.Default, "forecolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ButtonCommit.Enabled = False
        Me.ButtonCommit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonCommit.ForeColor = Global.Generic_Counter.My.MySettings.Default.forecolor
        Me.ButtonCommit.Location = New System.Drawing.Point(174, 226)
        Me.ButtonCommit.Name = "ButtonCommit"
        Me.ButtonCommit.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCommit.TabIndex = 5
        Me.ButtonCommit.Text = "Commit"
        Me.ButtonCommit.UseVisualStyleBackColor = False
        '
        'ButtonClearEdit
        '
        Me.ButtonClearEdit.BackColor = Global.Generic_Counter.My.MySettings.Default.backcolor
        Me.ButtonClearEdit.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.Generic_Counter.My.MySettings.Default, "forecolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ButtonClearEdit.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Generic_Counter.My.MySettings.Default, "backcolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ButtonClearEdit.Enabled = False
        Me.ButtonClearEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonClearEdit.ForeColor = Global.Generic_Counter.My.MySettings.Default.forecolor
        Me.ButtonClearEdit.Location = New System.Drawing.Point(255, 226)
        Me.ButtonClearEdit.Name = "ButtonClearEdit"
        Me.ButtonClearEdit.Size = New System.Drawing.Size(75, 23)
        Me.ButtonClearEdit.TabIndex = 6
        Me.ButtonClearEdit.Text = "Clear"
        Me.ButtonClearEdit.UseVisualStyleBackColor = False
        '
        'TextBoxFilePath
        '
        Me.TextBoxFilePath.BackColor = Global.Generic_Counter.My.MySettings.Default.backcolor
        Me.TextBoxFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxFilePath.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.Generic_Counter.My.MySettings.Default, "forecolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBoxFilePath.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Generic_Counter.My.MySettings.Default, "backcolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBoxFilePath.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Generic_Counter.My.MySettings.Default, "textFilePath", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBoxFilePath.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxFilePath.ForeColor = Global.Generic_Counter.My.MySettings.Default.forecolor
        Me.TextBoxFilePath.Location = New System.Drawing.Point(133, 287)
        Me.TextBoxFilePath.Name = "TextBoxFilePath"
        Me.TextBoxFilePath.ReadOnly = True
        Me.TextBoxFilePath.Size = New System.Drawing.Size(242, 26)
        Me.TextBoxFilePath.TabIndex = 7
        Me.TextBoxFilePath.Text = Global.Generic_Counter.My.MySettings.Default.textFilePath
        Me.TextBoxFilePath.UseSystemPasswordChar = True
        '
        'LabelFilePath
        '
        Me.LabelFilePath.AutoSize = True
        Me.LabelFilePath.BackColor = Global.Generic_Counter.My.MySettings.Default.backcolor
        Me.LabelFilePath.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.Generic_Counter.My.MySettings.Default, "forecolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.LabelFilePath.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Generic_Counter.My.MySettings.Default, "backcolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.LabelFilePath.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFilePath.ForeColor = Global.Generic_Counter.My.MySettings.Default.forecolor
        Me.LabelFilePath.Location = New System.Drawing.Point(3, 290)
        Me.LabelFilePath.Name = "LabelFilePath"
        Me.LabelFilePath.Size = New System.Drawing.Size(124, 20)
        Me.LabelFilePath.TabIndex = 8
        Me.LabelFilePath.Text = "Text File Path:"
        '
        'ButtonFindPath
        '
        Me.ButtonFindPath.BackColor = Global.Generic_Counter.My.MySettings.Default.backcolor
        Me.ButtonFindPath.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.Generic_Counter.My.MySettings.Default, "forecolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ButtonFindPath.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Generic_Counter.My.MySettings.Default, "backcolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ButtonFindPath.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonFindPath.ForeColor = Global.Generic_Counter.My.MySettings.Default.forecolor
        Me.ButtonFindPath.Location = New System.Drawing.Point(133, 319)
        Me.ButtonFindPath.Name = "ButtonFindPath"
        Me.ButtonFindPath.Size = New System.Drawing.Size(75, 23)
        Me.ButtonFindPath.TabIndex = 9
        Me.ButtonFindPath.Text = "Browse"
        Me.ButtonFindPath.UseVisualStyleBackColor = False
        '
        'ButtonShow
        '
        Me.ButtonShow.BackColor = Global.Generic_Counter.My.MySettings.Default.backcolor
        Me.ButtonShow.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.Generic_Counter.My.MySettings.Default, "forecolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ButtonShow.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Generic_Counter.My.MySettings.Default, "backcolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ButtonShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonShow.ForeColor = Global.Generic_Counter.My.MySettings.Default.forecolor
        Me.ButtonShow.Location = New System.Drawing.Point(215, 319)
        Me.ButtonShow.Name = "ButtonShow"
        Me.ButtonShow.Size = New System.Drawing.Size(75, 23)
        Me.ButtonShow.TabIndex = 10
        Me.ButtonShow.Text = "Show"
        Me.ButtonShow.UseVisualStyleBackColor = False
        '
        'ButtonExit
        '
        Me.ButtonExit.BackColor = Global.Generic_Counter.My.MySettings.Default.backcolor
        Me.ButtonExit.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.Generic_Counter.My.MySettings.Default, "forecolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ButtonExit.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Generic_Counter.My.MySettings.Default, "backcolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonExit.ForeColor = Global.Generic_Counter.My.MySettings.Default.forecolor
        Me.ButtonExit.Location = New System.Drawing.Point(292, 452)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(103, 26)
        Me.ButtonExit.TabIndex = 11
        Me.ButtonExit.Text = "Exit"
        Me.ButtonExit.UseVisualStyleBackColor = False
        '
        'ButtonEnable
        '
        Me.ButtonEnable.BackColor = Global.Generic_Counter.My.MySettings.Default.backcolor
        Me.ButtonEnable.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Generic_Counter.My.MySettings.Default, "backcolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ButtonEnable.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.Generic_Counter.My.MySettings.Default, "forecolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ButtonEnable.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonEnable.ForeColor = Global.Generic_Counter.My.MySettings.Default.forecolor
        Me.ButtonEnable.Location = New System.Drawing.Point(300, 319)
        Me.ButtonEnable.Name = "ButtonEnable"
        Me.ButtonEnable.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEnable.TabIndex = 12
        Me.ButtonEnable.Text = "Enable"
        Me.ButtonEnable.UseVisualStyleBackColor = False
        '
        'TextBoxEdit
        '
        Me.TextBoxEdit.AllowPromptAsInput = False
        Me.TextBoxEdit.BackColor = Global.Generic_Counter.My.MySettings.Default.backcolor
        Me.TextBoxEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxEdit.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Generic_Counter.My.MySettings.Default, "backcolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBoxEdit.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.Generic_Counter.My.MySettings.Default, "forecolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBoxEdit.Enabled = False
        Me.TextBoxEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEdit.ForeColor = Global.Generic_Counter.My.MySettings.Default.forecolor
        Me.TextBoxEdit.HidePromptOnLeave = True
        Me.TextBoxEdit.Location = New System.Drawing.Point(174, 194)
        Me.TextBoxEdit.Mask = "999999999"
        Me.TextBoxEdit.Name = "TextBoxEdit"
        Me.TextBoxEdit.Size = New System.Drawing.Size(156, 26)
        Me.TextBoxEdit.TabIndex = 16
        Me.TextBoxEdit.ValidatingType = GetType(Integer)
        '
        'LabelVersion
        '
        Me.LabelVersion.AutoSize = True
        Me.LabelVersion.BackColor = Global.Generic_Counter.My.MySettings.Default.backcolor
        Me.LabelVersion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelVersion.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.Generic_Counter.My.MySettings.Default, "forecolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.LabelVersion.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Generic_Counter.My.MySettings.Default, "backcolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.LabelVersion.ForeColor = Global.Generic_Counter.My.MySettings.Default.forecolor
        Me.LabelVersion.Location = New System.Drawing.Point(97, 463)
        Me.LabelVersion.Name = "LabelVersion"
        Me.LabelVersion.Size = New System.Drawing.Size(30, 15)
        Me.LabelVersion.TabIndex = 19
        Me.LabelVersion.Text = "v1.3"
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemAppearance, Me.MenuItemCounterSettings, Me.MenuItemLogs, Me.MenuItemHelp})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(407, 24)
        Me.MenuStrip.TabIndex = 21
        Me.MenuStrip.Text = "msOptions"
        '
        'MenuItemAppearance
        '
        Me.MenuItemAppearance.Name = "MenuItemAppearance"
        Me.MenuItemAppearance.Size = New System.Drawing.Size(82, 20)
        Me.MenuItemAppearance.Text = "Appearance"
        '
        'MenuItemCounterSettings
        '
        Me.MenuItemCounterSettings.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemIncrements, Me.MenuItemSound, Me.MenuItemKeybinds})
        Me.MenuItemCounterSettings.Name = "MenuItemCounterSettings"
        Me.MenuItemCounterSettings.Size = New System.Drawing.Size(107, 20)
        Me.MenuItemCounterSettings.Text = "Counter Settings"
        '
        'MenuItemIncrements
        '
        Me.MenuItemIncrements.Name = "MenuItemIncrements"
        Me.MenuItemIncrements.Size = New System.Drawing.Size(133, 22)
        Me.MenuItemIncrements.Text = "Increments"
        '
        'MenuItemSound
        '
        Me.MenuItemSound.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemNoSound, Me.MenuItemUwU, Me.MenuItemYouDied, Me.MenuItemOof, Me.MenuItemFlop, Me.MenuItemCustomAudio})
        Me.MenuItemSound.Name = "MenuItemSound"
        Me.MenuItemSound.Size = New System.Drawing.Size(133, 22)
        Me.MenuItemSound.Text = "Sound"
        '
        'MenuItemNoSound
        '
        Me.MenuItemNoSound.Checked = True
        Me.MenuItemNoSound.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MenuItemNoSound.Name = "MenuItemNoSound"
        Me.MenuItemNoSound.Size = New System.Drawing.Size(151, 22)
        Me.MenuItemNoSound.Text = "No Sound"
        '
        'MenuItemUwU
        '
        Me.MenuItemUwU.Name = "MenuItemUwU"
        Me.MenuItemUwU.Size = New System.Drawing.Size(151, 22)
        Me.MenuItemUwU.Text = "UwU"
        '
        'MenuItemYouDied
        '
        Me.MenuItemYouDied.Name = "MenuItemYouDied"
        Me.MenuItemYouDied.Size = New System.Drawing.Size(151, 22)
        Me.MenuItemYouDied.Text = "You Died"
        '
        'MenuItemOof
        '
        Me.MenuItemOof.Name = "MenuItemOof"
        Me.MenuItemOof.Size = New System.Drawing.Size(151, 22)
        Me.MenuItemOof.Text = "Oof"
        '
        'MenuItemFlop
        '
        Me.MenuItemFlop.Name = "MenuItemFlop"
        Me.MenuItemFlop.Size = New System.Drawing.Size(151, 22)
        Me.MenuItemFlop.Text = "Flop"
        '
        'MenuItemCustomAudio
        '
        Me.MenuItemCustomAudio.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemBrowse})
        Me.MenuItemCustomAudio.Name = "MenuItemCustomAudio"
        Me.MenuItemCustomAudio.Size = New System.Drawing.Size(151, 22)
        Me.MenuItemCustomAudio.Text = "Custom Audio"
        '
        'MenuItemBrowse
        '
        Me.MenuItemBrowse.Name = "MenuItemBrowse"
        Me.MenuItemBrowse.Size = New System.Drawing.Size(112, 22)
        Me.MenuItemBrowse.Text = "Browse"
        '
        'MenuItemKeybinds
        '
        Me.MenuItemKeybinds.Name = "MenuItemKeybinds"
        Me.MenuItemKeybinds.Size = New System.Drawing.Size(133, 22)
        Me.MenuItemKeybinds.Text = "Keybinds"
        '
        'MenuItemLogs
        '
        Me.MenuItemLogs.Name = "MenuItemLogs"
        Me.MenuItemLogs.Size = New System.Drawing.Size(44, 20)
        Me.MenuItemLogs.Text = "Logs"
        '
        'MenuItemHelp
        '
        Me.MenuItemHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemTutorial, Me.MenuItemDiscord})
        Me.MenuItemHelp.Name = "MenuItemHelp"
        Me.MenuItemHelp.Size = New System.Drawing.Size(44, 20)
        Me.MenuItemHelp.Text = "Help"
        '
        'MenuItemTutorial
        '
        Me.MenuItemTutorial.Name = "MenuItemTutorial"
        Me.MenuItemTutorial.Size = New System.Drawing.Size(114, 22)
        Me.MenuItemTutorial.Text = "Tutorial"
        '
        'MenuItemDiscord
        '
        Me.MenuItemDiscord.Name = "MenuItemDiscord"
        Me.MenuItemDiscord.Size = New System.Drawing.Size(114, 22)
        Me.MenuItemDiscord.Text = "Discord"
        '
        'ButtonRemove
        '
        Me.ButtonRemove.BackColor = Global.Generic_Counter.My.MySettings.Default.backcolor
        Me.ButtonRemove.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.Generic_Counter.My.MySettings.Default, "forecolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ButtonRemove.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Generic_Counter.My.MySettings.Default, "backcolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ButtonRemove.Enabled = False
        Me.ButtonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRemove.ForeColor = Global.Generic_Counter.My.MySettings.Default.forecolor
        Me.ButtonRemove.Location = New System.Drawing.Point(215, 62)
        Me.ButtonRemove.Name = "ButtonRemove"
        Me.ButtonRemove.Size = New System.Drawing.Size(160, 93)
        Me.ButtonRemove.TabIndex = 2
        Me.ButtonRemove.Text = "Remove"
        Me.ButtonRemove.UseVisualStyleBackColor = False
        '
        'ButtonAdd
        '
        Me.ButtonAdd.BackColor = Global.Generic_Counter.My.MySettings.Default.backcolor
        Me.ButtonAdd.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.Generic_Counter.My.MySettings.Default, "forecolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ButtonAdd.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Generic_Counter.My.MySettings.Default, "backcolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ButtonAdd.Enabled = False
        Me.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAdd.ForeColor = Global.Generic_Counter.My.MySettings.Default.forecolor
        Me.ButtonAdd.Location = New System.Drawing.Point(31, 62)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(160, 93)
        Me.ButtonAdd.TabIndex = 0
        Me.ButtonAdd.Text = "Add"
        Me.ButtonAdd.UseVisualStyleBackColor = False
        '
        'CheckBoxSave
        '
        Me.CheckBoxSave.AutoSize = True
        Me.CheckBoxSave.BackColor = Global.Generic_Counter.My.MySettings.Default.backcolor
        Me.CheckBoxSave.Checked = Global.Generic_Counter.My.MySettings.Default.checked
        Me.CheckBoxSave.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Generic_Counter.My.MySettings.Default, "backcolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBoxSave.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.Generic_Counter.My.MySettings.Default, "forecolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBoxSave.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Generic_Counter.My.MySettings.Default, "checked", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBoxSave.Enabled = False
        Me.CheckBoxSave.ForeColor = Global.Generic_Counter.My.MySettings.Default.forecolor
        Me.CheckBoxSave.Location = New System.Drawing.Point(15, 323)
        Me.CheckBoxSave.Name = "CheckBoxSave"
        Me.CheckBoxSave.Size = New System.Drawing.Size(57, 17)
        Me.CheckBoxSave.TabIndex = 22
        Me.CheckBoxSave.Text = "Save?"
        Me.CheckBoxSave.UseVisualStyleBackColor = False
        '
        'PictureGenericCounter
        '
        Me.PictureGenericCounter.BackColor = Global.Generic_Counter.My.MySettings.Default.backcolor
        Me.PictureGenericCounter.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Generic_Counter.My.MySettings.Default, "backcolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.PictureGenericCounter.Image = CType(resources.GetObject("PictureGenericCounter.Image"), System.Drawing.Image)
        Me.PictureGenericCounter.Location = New System.Drawing.Point(-39, 304)
        Me.PictureGenericCounter.Name = "PictureGenericCounter"
        Me.PictureGenericCounter.Size = New System.Drawing.Size(313, 207)
        Me.PictureGenericCounter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureGenericCounter.TabIndex = 23
        Me.PictureGenericCounter.TabStop = False
        '
        'PictureDeaths
        '
        Me.PictureDeaths.BackColor = Global.Generic_Counter.My.MySettings.Default.backcolor
        Me.PictureDeaths.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Generic_Counter.My.MySettings.Default, "backcolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.PictureDeaths.Image = CType(resources.GetObject("PictureDeaths.Image"), System.Drawing.Image)
        Me.PictureDeaths.Location = New System.Drawing.Point(-9, 313)
        Me.PictureDeaths.Name = "PictureDeaths"
        Me.PictureDeaths.Size = New System.Drawing.Size(313, 207)
        Me.PictureDeaths.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureDeaths.TabIndex = 24
        Me.PictureDeaths.TabStop = False
        '
        'LabelCounter
        '
        Me.LabelCounter.BackColor = Global.Generic_Counter.My.MySettings.Default.backcolor
        Me.LabelCounter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelCounter.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.Generic_Counter.My.MySettings.Default, "forecolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.LabelCounter.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Generic_Counter.My.MySettings.Default, "backcolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.LabelCounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.LabelCounter.ForeColor = Global.Generic_Counter.My.MySettings.Default.forecolor
        Me.LabelCounter.Location = New System.Drawing.Point(234, 390)
        Me.LabelCounter.Name = "LabelCounter"
        Me.LabelCounter.Size = New System.Drawing.Size(96, 27)
        Me.LabelCounter.TabIndex = 25
        Me.LabelCounter.Text = "0"
        Me.LabelCounter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureAnimalCrossing
        '
        Me.PictureAnimalCrossing.BackColor = Global.Generic_Counter.My.MySettings.Default.backcolor
        Me.PictureAnimalCrossing.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Generic_Counter.My.MySettings.Default, "backcolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.PictureAnimalCrossing.Image = CType(resources.GetObject("PictureAnimalCrossing.Image"), System.Drawing.Image)
        Me.PictureAnimalCrossing.Location = New System.Drawing.Point(-39, 304)
        Me.PictureAnimalCrossing.Name = "PictureAnimalCrossing"
        Me.PictureAnimalCrossing.Size = New System.Drawing.Size(313, 207)
        Me.PictureAnimalCrossing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureAnimalCrossing.TabIndex = 26
        Me.PictureAnimalCrossing.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.Generic_Counter.My.MySettings.Default.backcolor
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(407, 487)
        Me.Controls.Add(Me.LabelCounter)
        Me.Controls.Add(Me.CheckBoxSave)
        Me.Controls.Add(Me.LabelVersion)
        Me.Controls.Add(Me.TextBoxEdit)
        Me.Controls.Add(Me.ButtonEnable)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.ButtonShow)
        Me.Controls.Add(Me.ButtonFindPath)
        Me.Controls.Add(Me.LabelFilePath)
        Me.Controls.Add(Me.TextBoxFilePath)
        Me.Controls.Add(Me.ButtonClearEdit)
        Me.Controls.Add(Me.ButtonCommit)
        Me.Controls.Add(Me.EditDirectlyText)
        Me.Controls.Add(Me.ButtonRemove)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.PictureGenericCounter)
        Me.Controls.Add(Me.PictureDeaths)
        Me.Controls.Add(Me.PictureAnimalCrossing)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Generic_Counter.My.MySettings.Default, "backcolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pali's Generic Counter"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        CType(Me.PictureGenericCounter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureDeaths, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureAnimalCrossing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonAdd As Button
    Friend WithEvents lblName As Label
    Friend WithEvents ButtonRemove As Button
    Friend WithEvents EditDirectlyText As Label
    Friend WithEvents ButtonCommit As Button
    Friend WithEvents ButtonClearEdit As Button
    Friend WithEvents TextBoxFilePath As TextBox
    Friend WithEvents LabelFilePath As Label
    Friend WithEvents ButtonFindPath As Button
    Friend WithEvents ButtonShow As Button
    Friend WithEvents ButtonExit As Button
    Friend WithEvents ButtonEnable As Button
    Friend WithEvents TextBoxEdit As MaskedTextBox
    Friend WithEvents ToolTipAdd As ToolTip
    Friend WithEvents ToolTipRemove As ToolTip
    Friend WithEvents LabelVersion As Label
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents MenuItemAppearance As ToolStripMenuItem
    Friend WithEvents MenuItemCounterSettings As ToolStripMenuItem
    Friend WithEvents MenuItemLogs As ToolStripMenuItem
    Friend WithEvents CheckBoxSave As CheckBox
    Friend WithEvents ToolTipSave As ToolTip
    Friend WithEvents PictureGenericCounter As PictureBox
    Friend WithEvents PictureDeaths As PictureBox
    Friend WithEvents MenuItemIncrements As ToolStripMenuItem
    Friend WithEvents MenuItemSound As ToolStripMenuItem
    Friend WithEvents MenuItemHelp As ToolStripMenuItem
    Friend WithEvents MenuItemNoSound As ToolStripMenuItem
    Friend WithEvents MenuItemUwU As ToolStripMenuItem
    Friend WithEvents MenuItemYouDied As ToolStripMenuItem
    Friend WithEvents MenuItemOof As ToolStripMenuItem
    Friend WithEvents MenuItemFlop As ToolStripMenuItem
    Friend WithEvents MenuItemDiscord As ToolStripMenuItem
    Friend WithEvents LabelCounter As Label
    Friend WithEvents MenuItemTutorial As ToolStripMenuItem
    Friend WithEvents PictureAnimalCrossing As PictureBox
    Friend WithEvents MenuItemKeybinds As ToolStripMenuItem
    Friend WithEvents MenuItemCustomAudio As ToolStripMenuItem
    Friend WithEvents MenuItemBrowse As ToolStripMenuItem
End Class
