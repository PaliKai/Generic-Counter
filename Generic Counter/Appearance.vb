Public Class Appearance
    Public ReadOnly GenericTheme = New Theme("", Color.FromArgb(69, 69, 69), Color.FromArgb(192, 255, 255), Main.PictureGenericCounter)
    Public ReadOnly DeathTheme = New Theme("Deaths", Color.FromArgb(69, 69, 69), Color.FromArgb(255, 192, 192), Main.PictureDeaths)
    Public ReadOnly AnimalCrossingLightTheme = New Theme("Islands", Color.FromArgb(166, 247, 220), Color.FromArgb(224, 177, 0), Main.PictureAnimalCrossing)
    Public ReadOnly AnimalCrossingDarkTheme = New Theme("Islands", Color.FromArgb(196, 141, 63), Color.FromArgb(255, 195, 0), Main.PictureAnimalCrossing)

    Public ReadOnly Themes = New List(Of Theme)({GenericTheme, DeathTheme, AnimalCrossingLightTheme, AnimalCrossingDarkTheme})

    Private Sub Appearance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.ThemeNumber > 0 Then
            Dim a = My.Settings.forecolor
            Dim b = My.Settings.backcolor

            Dim CBs = {CheckBoxSwitchDeathMode, CheckBoxAnimalCrossing, CheckBoxAnimalCrossingDark}
            CBs(My.Settings.ThemeNumber - 1).Checked = True

            My.Settings.forecolor = a
            My.Settings.backcolor = b
        End If
    End Sub

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub ButtonRename_Click(sender As Object, e As EventArgs) Handles ButtonRename.Click
        My.Settings.name = InputBox("Enter new counting name:", "New Name")
        Main.SetCounting(My.Settings.name)
        My.Settings.Save()
    End Sub

    Private Sub CheckBoxSwitchDeathMode_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxSwitchDeathMode.CheckedChanged
        If CheckBoxSwitchDeathMode.Checked = True Then
            SetTheme(DeathTheme, CheckBoxSwitchDeathMode, True)
        Else
            CheckedOff()
        End If
    End Sub

    Private Sub CheckBoxAnimalCrossing_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxAnimalCrossing.CheckedChanged
        If CheckBoxAnimalCrossing.Checked = True Then
            SetTheme(AnimalCrossingLightTheme, CheckBoxAnimalCrossing, True)
        Else
            CheckedOff()
        End If
    End Sub
    Private Sub CheckBoxAnimalCrossingDark_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxAnimalCrossingDark.CheckedChanged
        If CheckBoxAnimalCrossingDark.Checked = True Then
            SetTheme(AnimalCrossingDarkTheme, CheckBoxAnimalCrossingDark, True)
        Else
            CheckedOff()
        End If
    End Sub

    Sub CheckedOff()
        Dim yes = False
        For Each CB In GetCheckBoxList()
            If CB.Checked Then
                yes = True
                Exit For
            End If
        Next
        If Not yes Then
            SetTheme(GenericTheme, Nothing, True)
        End If
    End Sub

    Function GetCheckBoxList() As CheckBox()
        Return {CheckBoxSwitchDeathMode, CheckBoxAnimalCrossing, CheckBoxAnimalCrossingDark}
    End Function

    Private Sub ButtonChangeBackground_Click(sender As Object, e As EventArgs) Handles ButtonChangeBackground.Click
        If ColorDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            My.Settings.backcolor = ColorDialog.Color
            My.Settings.Save()
        End If
    End Sub

    Private Sub ButtonChangeForeground_Click(sender As Object, e As EventArgs) Handles ButtonChangeForeground.Click
        If ColorDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            My.Settings.forecolor = ColorDialog.Color
            My.Settings.Save()
        End If
    End Sub

    ReadOnly Images() = {Main.PictureGenericCounter, Main.PictureDeaths, Main.PictureAnimalCrossing}

    Sub SetTheme(th As Theme, thCheckBox As CheckBox, ResetColors As Boolean)

        For Each CB As CheckBox In {CheckBoxSwitchDeathMode, CheckBoxAnimalCrossing, CheckBoxAnimalCrossingDark}
            If thCheckBox Is Nothing Then
                CB.Checked = False
            Else
                If Not CB.Equals(thCheckBox) Then
                    CB.Checked = False
                End If
            End If
        Next

        My.Settings.ThemeNumber = Themes.IndexOf(th)
        If ResetColors Then
            My.Settings.backcolor = th.BackColor
            My.Settings.forecolor = th.ForeColor
            Main.SetCounting(th.Counting)
        End If
        My.Settings.Save()

        For Each Image As Control In Images
            If Not Image.Equals(th.Image) Then
                Image.Visible = False
            Else
                th.Image.Visible = True
            End If
        Next
    End Sub

End Class

Public Class Theme
    Public Property Counting As String
    Public Property BackColor As Color
    Public Property ForeColor As Color
    Public Property Image As Control

    Public Sub New(c As String, b As Color, f As Color, i As Control)
        Counting = c
        BackColor = b
        ForeColor = f
        Image = i
    End Sub

End Class