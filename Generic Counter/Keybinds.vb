Public Class Keybinds
    Private Sub KeyBinds_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateBindText()
    End Sub

    Public Sub KeyBind(key)
        If (CheckBoxIncreaseBind.Checked) Then
            My.Settings.IncreaseKeyBind = key
            UpdateBindText()
            CheckBoxIncreaseBind.Checked = False
        End If
        If (CheckBoxDecreaseBind.Checked) Then
            My.Settings.DecreaseKeyBind = key
            UpdateBindText()
            CheckBoxDecreaseBind.Checked = False
        End If
    End Sub

    Sub UpdateBindText()
        LabelIncreaseBind.Text = My.Settings.IncreaseKeyBind.ToString
        LabelDecreaseBind.Text = My.Settings.DecreaseKeyBind.ToString
        Main.UpdateBindText()
    End Sub

    Private Sub CheckBoxIncreaseBind_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxIncreaseBind.CheckedChanged
        If (CheckBoxIncreaseBind.Checked) Then
            CheckBoxDecreaseBind.Checked = False
            Main.settingBind = True
        Else
            If (CheckBoxDecreaseBind.Checked = False) Then
                Main.settingBind = False
            End If
        End If
    End Sub

    Private Sub CheckBoxDecreaseBind_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxDecreaseBind.CheckedChanged
        If (CheckBoxDecreaseBind.Checked) Then
            CheckBoxIncreaseBind.Checked = False
            Main.settingBind = True
        Else
            If (CheckBoxIncreaseBind.Checked = False) Then
                Main.settingBind = False
            End If
        End If
    End Sub
End Class