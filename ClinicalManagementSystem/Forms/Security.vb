Public Class Security

    Private Sub Security_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Main.Hide()
        PasswordText.Select()
      
    End Sub
    Private Sub LoginBTN_Click(sender As Object, e As EventArgs) Handles LoginBTN.Click
        If PasswordText.Text.Trim <> "" & PasswordText.Text = My.Settings.Password Then
            My.Settings.Logged = True
            Me.Hide()
            Main.Show()
            Main.Focus()
        End If
    End Sub
    Public CloseSecurity As Boolean = False
    Private Sub CloseBTN_Click(sender As Object, e As EventArgs) Handles CloseBTN.Click
        Me.Hide()
        CloseSecurity = True
    End Sub
End Class