Public Class AddSession

    Private Sub CancelBTN_Click(sender As Object, e As EventArgs) Handles CancelBTN.Click
        Me.Close()
    End Sub

    Private Sub AddSession_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextNameSession.Select()
        TextNameSession.Text = "الجلسة " & Main.Patients1.ListSessions.Items.Count + 1
    End Sub

    Private Sub SaveBTN_Click(sender As Object, e As EventArgs) Handles SaveBTN.Click
        If TextNameSession.Text <> "" Then
            RunCommand("INSERT INTO PSession ([PatientID], [SessionName]) VALUES ('" & Main.Patients1.IdCodeLbl.Text & "', '" & TextNameSession.Text & "')")
            LoadSpecificSession(Main.Patients1.IdCodeLbl.Text)
            If CheckProgress Then
                MyMessageBox.TextMessage.Text = "تم الاضافة بنجاح"
                MyMessageBox.ShowBTN = 0
                MyMessageBox.ShowDialog()
                Main.Patients1.GroupBox2.Visible = True
                If Main.Patients1.ListSessions.Items.Count > 0 Then
                    Main.Patients1.GroupBox1.Visible = True
                Else
                    Main.Patients1.GroupBox1.Visible = False
                End If
                Me.Close()
            End If
        End If
    End Sub
End Class