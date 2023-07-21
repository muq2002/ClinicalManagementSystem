Public Class Settings

    Private Sub CloseBTN_Click(sender As Object, e As EventArgs) Handles CloseBTN.Click
        Me.Close()
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextUsername.Select()
        ' Loading Information
        SerialNumberText.Text = My.Settings.SerialNumber
        ActiveNumberText.Text = My.Settings.ActiveNumber
        TextUsername.Text = My.Settings.Username
        TextPassword.Text = My.Settings.Password
     
    End Sub

    Private Sub SaveBTN_Click(sender As Object, e As EventArgs) Handles SaveBTN.Click
        If TextUsername.Text <> "" Then
            My.Settings.Username = TextUsername.Text
            My.Settings.Password = TextPassword.Text
            My.Settings.Logged = True
            MyMessageBox.TextMessage.Text = "تم حفظ الاعدادت بنجاح"
            MyMessageBox.ShowDialog()
            My.Settings.Save()
        End If
    End Sub

    Private Sub RestoreBTN_Click(sender As Object, e As EventArgs) Handles RestoreBTN.Click
        RestDataBaseSetting()
        Application.Restart()
    End Sub
End Class