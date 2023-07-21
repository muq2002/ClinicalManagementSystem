Public Class Patients
    Private Sub RemoveSessionBTN_Click(sender As Object, e As EventArgs) Handles RemoveSessionBTN.Click
        Try
            If ListSessions.SelectedItems.Count > 0 Then
                MyMessageBox.TextMessage.Text = "هل تريد حذف الجلسة "
                MyMessageBox.ShowBTN = 1
                MyMessageBox.ShowDialog()
                If MyMessageBox.CheckClick.Text = "1" Then
                    RunCommand("DELETE FROM PSession WHERE [ID]=" & ListSessions.SelectedValue.ToString())
                    ' Refresh  ListView 
                    LoadSpecificSession(IdCodeLbl.Text)
                End If
                If ListSessions.Items.Count = 0 Then
                    GroupBox1.Visible = False
                End If
            End If
        Catch ex As Exception
            MyMessageBox.TextMessage.Text = " 🙃 حصل خطا ما!"
            MyMessageBox.AgreeBTN.BackColor = Color.FromArgb(225, 200, 34, 51)
            MyMessageBox.ShowDialog()
        End Try
    End Sub

    Private Sub AddSessionBTN_Click(sender As Object, e As EventArgs) Handles AddSessionBTN.Click
        AddSession.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TextSessionDate.Text = Date.Now
    End Sub

    Private Sub Patients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Visible = False
        GroupBox2.Visible = False
        Timer1.Enabled = True
        Timer1.Start()
    End Sub

    Private Sub ListSessions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListSessions.SelectedIndexChanged
        '  Show Controls
        For Each MyControl In GroupBox1.Controls
            CType(MyControl, Control).Visible = True
            If Not CType(MyControl, Control).Name.First = "L" And CType(MyControl, Control).Name.First <> "S" _
               And CType(MyControl, Control).Name.First <> "H" Then
                CType(MyControl, Control).Text = ""
            End If
        Next
        LoadDataSpecificSession(ListSessions.SelectedValue.ToString())
    End Sub

    Private Sub CancelBTN_Click(sender As Object, e As EventArgs) Handles HideBTN.Click
        For Each MyControl In GroupBox1.Controls
            CType(MyControl, Control).Visible = False
        Next
    End Sub

    Private Sub SaveBTN_Click(sender As Object, e As EventArgs) Handles SaveBTN.Click
        Try
            Dim EditID As Integer = ListSessions.SelectedValue.ToString()
            If TextSessionName.Text <> "" And ComboTeethNumber.Text <> "" And TextSessionDate.Text <> "" Then
                Dim Note As String = RichTextNote.Text
                If RichTextNote.Text = "" Then Note = "لا يوجد"
                RunCommand("UPDATE PSession SET [SessionName]='" & TextSessionName.Text & "',[ConjName]='" & TextConjName.Text & "',[SessionDate]='" & TextSessionDate.Text & Format(Now, " hh:mm") & "',[NumberTeeth]='" & ComboTeethNumber.Text & "', [Note]='" & Note & "' WHERE ID=" & EditID)
                If CheckProgress Then
                    MyMessageBox.TextMessage.Text = "تم الحفظ بنجاح😃"
                    MyMessageBox.ShowDialog()
                End If
            Else
                MyMessageBox.TextMessage.Text = "يرجى ملا البيانات بشكل صحيح🙃"
                MyMessageBox.ShowDialog()
            End If
        Catch ex As Exception
            MyMessageBox.TextMessage.Text = " 🙃 حصل خطا ما!"
            MyMessageBox.AgreeBTN.BackColor = Color.FromArgb(225, 200, 34, 51)
            MyMessageBox.ShowDialog()
        End Try
    End Sub
End Class
