Public Class Filter

    Private Sub CloseBTN_Click(sender As Object, e As EventArgs) Handles CloseBTN.Click
        Me.Close()
    End Sub

    Private Sub Filter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboAge.Items.Add("غير محدد")
        For L = 1 To 100
            ComboAge.Items.Add(L)
        Next
    End Sub

    Private Sub AddPatientBTN_Click(sender As Object, e As EventArgs) Handles AddPatientBTN.Click
        Dim SQL As String = ""
        If ComboGender.Text = "غير محدد" And ComboAge.Text = "غير محدد" Then ' F F
            SQL = "SELECT * FROM Patient"
        ElseIf ComboGender.Text <> "غير محدد" And ComboAge.Text <> "غير محدد" Then ' T T
            SQL = "SELECT * FROM Patient WHERE [Gender]='" & ComboGender.Text & "' And [Age]='" & ComboAge.Text & "'"
        ElseIf ComboGender.Text <> "غير محدد" And ComboAge.Text = "غير محدد" Then ' T F
            SQL = "SELECT * FROM Patient WHERE [Gender]='" & ComboGender.Text & "'"
        Else
            SQL = "SELECT * FROM Patient WHERE [Age]='" & ComboAge.Text & "'"
        End If
        MangePatient.PatientDGV.DataSource = GetTable(SQL)
    End Sub
End Class