Public Class MyMessageBox
    Public ShowBTN As Integer = 0
    Private Sub NoBTN_Click(sender As Object, e As EventArgs) Handles NoBTN.Click
        CheckClick.Text = "0"
        Me.Close()
    End Sub

    Private Sub YesBTN_Click(sender As Object, e As EventArgs) Handles YesBTN.Click
        CheckClick.Text = "1"
        Me.Close()
    End Sub

    Private Sub MyMessageBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        If ShowBTN = 0 Then
            AgreeBTN.Visible = True
            YesBTN.Visible = False
            NoBTN.Visible = False
            AgreeBTN.Select()
        Else
            YesBTN.Visible = True
            NoBTN.Visible = True
            AgreeBTN.Visible = False
            YesBTN.Select()
        End If
    End Sub

    Private Sub AgreeBTN_Click(sender As Object, e As EventArgs) Handles AgreeBTN.Click
        Me.Close()
    End Sub


End Class