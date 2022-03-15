Imports System.Runtime.InteropServices


'=============================
'           Main
'=============================


Public Class Main

    ReadOnly placeholders As New Dictionary(Of String, ValueDelegate)()

    ReadOnly audios = New List(Of Audio)

    Public hook = False
    Public settingBind = False

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LogEvent("Loading...")

        placeholders.Add("<c>", AddressOf GetCounting)

        audios.Add(New Audio("No Sound", MenuItemNoSound))
        audios.Add(New Audio("UwU", MenuItemUwU))
        audios.Add(New Audio("You Died", MenuItemYouDied))
        audios.Add(New Audio("Oof", MenuItemOof))
        audios.Add(New Audio("Flop", MenuItemFlop))
        audios.Add(New Audio("Custom Audio", MenuItemCustomAudio))

        SetAudio(My.Settings.selectedAudio, False)

        SetValueFromFile()

        UpdateBindText()

        ToolTipSave.SetToolTip(CheckBoxSave, "UNCHECKING THIS WILL DISABLE ALL ACTIVE FEATURES!")

        Appearance.SetTheme(Appearance.Themes(My.Settings.ThemeNumber), Nothing, False)

        UpdateCounting()

        If CheckBoxSave.Checked = False Then
            TextBoxFilePath.Text = ""
        End If

        LogEvent("Loaded")

        If TextBoxFilePath.Text IsNot "" Then
            Enable()
        End If
    End Sub

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub



    Function GetCounting() As String
        Return My.Settings.name
    End Function

    Sub SetCounting(new_counting)
        My.Settings.name = new_counting
        My.Settings.Save()
        UpdateCounting()
        LogEvent("New Counting Name set to: " & My.Settings.name)
    End Sub

    Sub UpdateCounting()
        ButtonAdd.Text = Fix("Add <c>")
        ButtonRemove.Text = Fix("Remove <c>")
        LogEvent("Counting Updated...")
    End Sub

    Sub UpdateBindText()
        ToolTipAdd.SetToolTip(ButtonAdd, "Shortcut: [" & My.Settings.IncreaseKeyBind.ToString & "]")
        ToolTipRemove.SetToolTip(ButtonRemove, "Shortcut: [" & My.Settings.DecreaseKeyBind.ToString & "]")
    End Sub

    Private Sub ButtonFindPath_Click(sender As Object, e As EventArgs) Handles ButtonFindPath.Click
        Dim fd As New OpenFileDialog With {
            .Title = "Open File Dialog",
            .InitialDirectory = "C:\",
            .Filter = "Text files (*.txt)|*.txt|Text files (*.txt)|*.txt",
            .FilterIndex = 2,
            .RestoreDirectory = True
        }
        If Not TextBoxFilePath.Text = "" Then
            fd.InitialDirectory = TextBoxFilePath.Text
        End If

        If fd.ShowDialog() = DialogResult.OK Then
            TextBoxFilePath.Text = fd.FileName
        Else
            LogEvent("Text File Path ERROR")
        End If
        LogEvent("Text File Path Found.")
    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Me.Close()
    End Sub

    Dim hidden As Boolean = True

    Private Sub ButtonShow_Click(sender As Object, e As EventArgs) Handles ButtonShow.Click
        If (hidden) Then
            hidden = False
            ButtonShow.Text = "Hide"
            LogEvent("Text File Path Shown")
        Else
            hidden = True
            ButtonShow.Text = "Show"
            LogEvent("Text File Path Hidden")
        End If
        TextBoxFilePath.UseSystemPasswordChar = hidden
    End Sub

    Private Sub ButtonEnable_Click(sender As Object, e As EventArgs) Handles ButtonEnable.Click
        If (ButtonEnable.Text = "Enable") Then
            If TextBoxFilePath.Text IsNot "" Then
                Enable()
            Else
                MsgBox("Text File Path Cannot be blank!")
                LogEvent("Tried to enable without specifying text file path")
            End If
        Else
            'txtTextFilePath.Text = ""
            Disable()
        End If
    End Sub

    Sub Enable()
        hook = True
        settingBind = False
        TextBoxEdit.Enabled = True
        ButtonCommit.Enabled = True
        ButtonAdd.Enabled = True
        ButtonRemove.Enabled = True
        CheckBoxSave.Enabled = True
        ButtonClearEdit.Enabled = True
        SetValueFromFile()
        ButtonEnable.Text = "Disable"

        LogEvent("Enabled")
    End Sub

    Sub Disable()
        hook = False
        settingBind = False
        TextBoxEdit.Enabled = False
        ButtonCommit.Enabled = False
        ButtonAdd.Enabled = False
        ButtonRemove.Enabled = False
        CheckBoxSave.Enabled = False
        ButtonClearEdit.Enabled = False
        ButtonEnable.Text = "Enable"

        LogEvent("Disabled")
    End Sub

    Sub SetValueFromFile()
        If TextBoxFilePath.Text IsNot "" Then
            Dim file = My.Computer.FileSystem.OpenTextFileReader(TextBoxFilePath.Text)
            LabelCounter.Text = file.ReadLine()
            file.Close()
        End If
    End Sub

    Private Sub ButtonRemove_Click(sender As Object, e As EventArgs) Handles ButtonRemove.Click
        Dim file As System.IO.StreamWriter
        Dim readFile As System.IO.StreamReader
        Dim ctx As String
        readFile = My.Computer.FileSystem.OpenTextFileReader(TextBoxFilePath.Text)
        ctx = readFile.ReadLine()
        readFile.Close()
        If ctx = "" Then
            ctx = 0
        End If
        file = My.Computer.FileSystem.OpenTextFileWriter(TextBoxFilePath.Text, False)
        file.Write(Convert.ToInt32(ctx) - My.Settings.stepAmount)
        file.Close()
        LogEvent("Removed " & My.Settings.stepAmount & " from total")
        LabelCounter.Text = Convert.ToInt32(ctx) - My.Settings.stepAmount

        PlaySound()

    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        Dim file As System.IO.StreamWriter
        Dim readFile As System.IO.StreamReader
        Dim ctx As String
        readFile = My.Computer.FileSystem.OpenTextFileReader(TextBoxFilePath.Text)
        ctx = readFile.ReadLine()
        readFile.Close()
        If ctx = "" Then
            ctx = 0
        End If
        file = My.Computer.FileSystem.OpenTextFileWriter(TextBoxFilePath.Text, False)
        file.Write(Convert.ToInt32(ctx) + My.Settings.stepAmount)
        file.Close()
        LabelCounter.Text = Convert.ToInt32(ctx) + My.Settings.stepAmount
        LogEvent("Added " & My.Settings.stepAmount & " to total")

        PlaySound()

    End Sub

    Sub SetAudio(audio As Integer, play As Boolean)
        UncheckAllBut(audio)
        My.Settings.selectedAudio = audio
        My.Settings.Save()

        If play Then
            PlaySound()
        End If
    End Sub

    Sub UncheckAllBut(this As Integer)
        For i As Integer = 0 To audios.Count - 1
            audios(i).MenuItem.Checked = False
        Next i
        audios(this).MenuItem.Checked = True
    End Sub

    Private Sub ButtonCommit_Click(sender As Object, e As EventArgs) Handles ButtonCommit.Click
        Dim file As System.IO.StreamWriter
        If TextBoxEdit.Text = "" Then
            MsgBox("Death's Cannot be blank!")
            LogEvent("Tried to edit count but cannot send NULL data to file")
        Else
            file = My.Computer.FileSystem.OpenTextFileWriter(TextBoxFilePath.Text, False)
            file.Write(TextBoxEdit.Text)
            file.Close()
            LabelCounter.Text = TextBoxEdit.Text
            LogEvent("Changed count to: " & TextBoxEdit.Text)
        End If


    End Sub

    Private WithEvents KeyboardHook As New KeyboardHook

    Private Sub KeyboardHook_KeyDown(ByVal Key As System.Windows.Forms.Keys) Handles KeyboardHook.KeyDown
        Debug.WriteLine(Key.ToString)
        If (hook) Then
            If settingBind Then
                Keybinds.KeyBind(Key)
            Else
                Select Case Key
                    Case My.Settings.IncreaseKeyBind
                        ButtonAdd.PerformClick()
                    Case My.Settings.DecreaseKeyBind
                        ButtonRemove.PerformClick()
                End Select
            End If
        End If
    End Sub

    Private Sub TextBoxEdit_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxEdit.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                ButtonCommit.PerformClick()
        End Select
    End Sub


    Function Fix(str As String)
        Dim str1 As String = str
        For i = 0 To placeholders.Count - 1
            str1 = Strings.Replace(str1, placeholders.Keys(i), placeholders.Values(i)())
        Next i
        Return str1
    End Function

    Delegate Function ValueDelegate() As String

    Private Sub MenuItemAppearance_Click(sender As Object, e As EventArgs) Handles MenuItemAppearance.Click
        appearance.Location = New Point(MyBase.Location.X + MyBase.Width / 2 - appearance.Width / 2, MyBase.Location.Y + MyBase.Height / 2 - appearance.Height / 2)
        Appearance.ShowDialog()
        Appearance.BringToFront()
    End Sub

    Private Sub LabelCounter_TextChanged(sender As Object, e As EventArgs) Handles LabelCounter.TextChanged

    End Sub

    Private Sub CheckBoxSave_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxSave.CheckedChanged
        If CheckBoxSave.Checked = True Then
            My.Settings.checked = True
            My.Settings.textFilePath = TextBoxFilePath.Text
            My.Settings.Save()
            LogEvent("Text file path saved for next session")
        Else
            My.Settings.checked = False
            My.Settings.textFilePath = ""
            My.Settings.Save()
            TextBoxEdit.Enabled = False
            ButtonCommit.Enabled = False
            ButtonAdd.Enabled = False
            ButtonRemove.Enabled = False
            CheckBoxSave.Enabled = False
            ButtonClearEdit.Enabled = False
            LogEvent("Text file path will not be saved. ")
            LogEvent("Disabling all assets until text file path Is specified And enabled.")
        End If
    End Sub

    Private Sub MenuItemIncrements_Click(sender As Object, e As EventArgs) Handles MenuItemIncrements.Click
        Dim result = InputBox("Enter Increment Rate:", "Change Counting Increment", My.Settings.stepAmount)
        If (result = "" Or Not IsNumeric(result)) Then
            result = My.Settings.stepAmount
        End If
        My.Settings.stepAmount = Integer.Parse(result)
        My.Settings.Save()

        LogEvent("Step Amount changed to: " & My.Settings.stepAmount)
    End Sub

    Sub LogEvent(str As String)
        Logs.ListBoxLogs.Items.Add(str)
    End Sub

    Private Sub MenuItemLogs_Click(sender As Object, e As EventArgs) Handles MenuItemLogs.Click
        Logs.Location = New Point(MyBase.Location.X - Logs.Width, MyBase.Location.Y + MyBase.Height / 2 - Logs.Height / 2)
        Logs.Show()
        Logs.BringToFront()
    End Sub

    Private Sub ButtonClearEdit_Click(sender As Object, e As EventArgs) Handles ButtonClearEdit.Click
        TextBoxEdit.Clear()
        LogEvent("Edit Directly Cleared.")
    End Sub

    Private Sub MenuItemDiscord_Click(sender As Object, e As EventArgs) Handles MenuItemDiscord.Click
        System.Diagnostics.Process.Start("https://discord.gg/cmbVRDUyt2")
    End Sub

    Private Sub MenuItemTutorial_Click(sender As Object, e As EventArgs) Handles MenuItemTutorial.Click
        MsgBox("To get started, hit the browse button and find an empty text file that you want to save your count to." & Environment.NewLine & Environment.NewLine &
                "After you set the text file, hit the 'Enable' button. This will enable the rest of the applications features. You can also hit the SAVE check box to save your file path on next launch. (Recommended)" & Environment.NewLine & Environment.NewLine &
                "After all of that is done you can add counts manually with the 'Edit Directly' text box or you can click the 'Add' or 'Remove' buttons to change your count." & Environment.NewLine & Environment.NewLine &
                "Alternatively, You can also use the keybinds (Default PgUp and PgDn) to add or remove a count (NOTE: The PgUp and PgDn WILL STILL work when minimized!)" & Environment.NewLine & Environment.NewLine &
                "If you need help, add me on Discord! : PaliKai#7707")
        LogEvent("Help Loaded")
    End Sub


    '===============================
    '       SOUND GOES HERE
    '===============================


    Sub PlaySound()
        If Not audios(My.Settings.selectedAudio).Name = "No Sound" Then
            Try
                My.Computer.Audio.Play(audios(My.Settings.selectedAudio).File(), AudioPlayMode.Background)
            Catch ex As InvalidOperationException
                MsgBox("Invalid Audio File Type, Sound API only supports playing PCM wave files.", MsgBoxStyle.Critical, "ERROR")
                My.Settings.customSoundFilePath = ""
                SetAudio(0, False)
            End Try
        End If
    End Sub

    Private Sub NoSoundToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuItemNoSound.Click
        SetAudio(0, False)
    End Sub
    Private Sub UwUToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuItemUwU.Click
        SetAudio(1, True)
    End Sub
    Private Sub YouDiedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuItemYouDied.Click
        SetAudio(2, True)
    End Sub
    Private Sub OofToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuItemOof.Click
        SetAudio(3, True)
    End Sub
    Private Sub FlopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuItemFlop.Click
        SetAudio(4, True)
    End Sub

    Private Sub KeybindsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuItemKeybinds.Click
        Keybinds.Location = New Point(MyBase.Location.X + MyBase.Width / 2 - appearance.Width / 2, MyBase.Location.Y + MyBase.Height / 2 - appearance.Height / 2)
        Keybinds.Show()
        Keybinds.BringToFront()
    End Sub

    Private Sub BrowseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuItemBrowse.Click
        Dim fd As New OpenFileDialog With {
            .Title = "Open File Dialog",
            .InitialDirectory = "C:\",
            .Filter = "WAV Files(*.wav)|*.wav",
            .FilterIndex = 1,
            .RestoreDirectory = True
        }
        If Not My.Settings.customSoundFilePath = "" Then
            fd.InitialDirectory = My.Settings.customSoundFilePath
        End If

        If fd.ShowDialog() = DialogResult.OK Then
            My.Settings.customSoundFilePath = fd.FileName
            SetAudio(5, True)
        Else
            LogEvent("Custom Sound Path ERROR")
        End If
        LogEvent("Custom Sound Set.")
    End Sub

    Private Sub CustomAudioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuItemCustomAudio.Click
        If Not (My.Settings.customSoundFilePath = "") Then
            SetAudio(5, True)
            MenuItemCounterSettings.HideDropDown()
        End If
    End Sub
End Class

Public Class Audio
    Public Property Name As String
    Public Property MenuItem As ToolStripMenuItem

    Public Sub New(a As String, b As ToolStripMenuItem)
        Name = a
        MenuItem = b
    End Sub

    Public Function File() As Object 'IO.UnmanagedMemoryStream
        Select Case (Name)
            Case "UwU"
                Return My.Resources.uwu
            Case "You Died"
                Return My.Resources.youdied
            Case "Oof"
                Return My.Resources.oof
            Case "Flop"
                Return My.Resources.flop
            Case "Custom Audio"
                Return My.Settings.customSoundFilePath
        End Select
        Return Nothing
    End Function

End Class


'=============================
'       KeyBoard Hook
'=============================


Public Class KeyboardHook

    <DllImport("User32.dll", CharSet:=CharSet.Auto, CallingConvention:=CallingConvention.StdCall)>
    Private Overloads Shared Function SetWindowsHookEx(ByVal idHook As Integer, ByVal HookProc As KBDLLHookProc, ByVal hInstance As IntPtr, ByVal wParam As Integer) As Integer
    End Function
    <DllImport("User32.dll", CharSet:=CharSet.Auto, CallingConvention:=CallingConvention.StdCall)>
    Private Overloads Shared Function CallNextHookEx(ByVal idHook As Integer, ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As Integer
    End Function
    <DllImport("User32.dll", CharSet:=CharSet.Auto, CallingConvention:=CallingConvention.StdCall)>
    Private Overloads Shared Function UnhookWindowsHookEx(ByVal idHook As Integer) As Boolean
    End Function

    <StructLayout(LayoutKind.Sequential)>
    Private Structure KBDLLHOOKSTRUCT
        Public vkCode As UInt32
        Public scanCode As UInt32
        Public flags As KBDLLHOOKSTRUCTFlags
        Public time As UInt32
        Public dwExtraInfo As UIntPtr
    End Structure

    <Flags()>
    Private Enum KBDLLHOOKSTRUCTFlags As UInt32
        LLKHF_EXTENDED = &H1
        LLKHF_INJECTED = &H10
        LLKHF_ALTDOWN = &H20
        LLKHF_UP = &H80
    End Enum

    Public Shared Event KeyDown(ByVal Key As Keys)
    Public Shared Event KeyUp(ByVal Key As Keys)

    Private Const WH_KEYBOARD_LL As Integer = 13
    Private Const HC_ACTION As Integer = 0
    Private Const WM_KEYDOWN = &H100
    Private Const WM_KEYUP = &H101
    Private Const WM_SYSKEYDOWN = &H104
    Private Const WM_SYSKEYUP = &H105

    Private Delegate Function KBDLLHookProc(ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As Integer

    ReadOnly KBDLLHookProcDelegate As New KBDLLHookProc(AddressOf KeyboardProc)
    ReadOnly HHookID As IntPtr = IntPtr.Zero

    Private Function KeyboardProc(ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As Integer
        If (nCode = HC_ACTION) Then
            Dim struct As KBDLLHOOKSTRUCT
            Select Case wParam
                Case WM_KEYDOWN, WM_SYSKEYDOWN
                    RaiseEvent KeyDown(CType(CType(Marshal.PtrToStructure(lParam, struct.GetType()), KBDLLHOOKSTRUCT).vkCode, Keys))
                Case WM_KEYUP, WM_SYSKEYUP
                    RaiseEvent KeyUp(CType(CType(Marshal.PtrToStructure(lParam, struct.GetType()), KBDLLHOOKSTRUCT).vkCode, Keys))
            End Select
        End If
        Return CallNextHookEx(IntPtr.Zero, nCode, wParam, lParam)
    End Function

    Public Sub New()
        HHookID = SetWindowsHookEx(WH_KEYBOARD_LL, KBDLLHookProcDelegate, System.Runtime.InteropServices.Marshal.GetHINSTANCE(System.Reflection.Assembly.GetExecutingAssembly.GetModules()(0)).ToInt32, 0)
        If HHookID = IntPtr.Zero Then
            Throw New Exception("Could not set keyboard hook")
        End If
    End Sub

    Protected Overrides Sub Finalize()
        If Not HHookID = IntPtr.Zero Then
            UnhookWindowsHookEx(HHookID)
        End If
        MyBase.Finalize()
    End Sub

End Class