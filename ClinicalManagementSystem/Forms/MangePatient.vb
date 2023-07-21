Public Class MangePatient

    Private Sub CloseBTN_Click(sender As Object, e As EventArgs) Handles CloseBTN.Click
        Me.Close()
    End Sub

    Private Sub AddPatientsBTN_Click(sender As Object, e As EventArgs) Handles AddPatientsBTN.Click
        AddPatient.ShowDialog()
        AddPatient.ShowInTaskbar = False
    End Sub

    Private Sub MangePatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetTableMangePatinet()
        StylePatientTable()
        'TextSearch.Select()
    End Sub
    Public EditItem As Boolean = False
    Private Sub EditPatientBTN_Click(sender As Object, e As EventArgs) Handles EditPatientBTN.Click
        If PatientDGV.SelectedRows.Count > 0 Then
            EditItem = True
            AddPatient.TextNamePatient.Text = PatientDGV.SelectedRows(0).Cells(1).Value()
            AddPatient.ComboGender.Text = PatientDGV.SelectedRows(0).Cells(2).Value()
            AddPatient.TrackBarAge.Value = PatientDGV.SelectedRows(0).Cells(3).Value()
            AddPatient.TextAge.Text = PatientDGV.SelectedRows(0).Cells(3).Value()
            AddPatient.TextDate.Text = PatientDGV.SelectedRows(0).Cells(4).Value()
            AddPatient.ShowDialog()
        Else
            EditItem = False
        End If
    End Sub

    Private Sub RemovePatientBTN_Click(sender As Object, e As EventArgs) Handles RemovePatientBTN.Click
        Try
            If PatientDGV.SelectedRows.Count > 0 Then
                MyMessageBox.TextMessage.Text = "هل تريد حذف المريض 😳"
                MyMessageBox.ShowBTN = 1
                MyMessageBox.ShowDialog()
                If MyMessageBox.CheckClick.Text = "1" Then
                    RunCommand("DELETE FROM Patient WHERE [ID]=" & PatientDGV.SelectedRows(0).Cells(0).Value)
                    'Refresh  Table
                    RestDataInControllPatient()
                    GetTableMangePatinet(True)
                    StylePatientTable()
                    PatientDGV.ClearSelection()
                End If
            End If
        Catch ex As Exception
            MyMessageBox.TextMessage.Text = " 🙃 حصل خطا ما!"
            MyMessageBox.AgreeBTN.BackColor = Color.FromArgb(225, 200, 34, 51)
            MyMessageBox.ShowDialog()
        End Try
    End Sub
    Sub RestDataInControllPatient()
        If Main.Patients1.IdCodeLbl.Text = PatientDGV.SelectedRows(0).Cells(0).Value Then
            For Each MyControll In Main.Patients1.GroupBox3.Controls
                If MyControll.GetType.ToString = "System.Windows.Forms.TextBox" Then
                    CType(MyControll, TextBox).Text = ""
                End If
            Next
            Main.Patients1.GroupBox2.Visible = False
            Main.Patients1.GroupBox1.Visible = False
            Main.Patients1.PictureNameLogo.Image = Nothing
        End If
    End Sub
    Private Sub SearchBTN_Click(sender As Object, e As EventArgs) Handles SearchBTN.Click
        Filter.Show()
    End Sub
    Sub StylePatientTable()
        PatientDGV.Columns(0).Width = 40
        PatientDGV.Columns(1).Width = 200
        PatientDGV.Columns(2).Width = 80
        PatientDGV.Columns(3).Width = 80
        PatientDGV.Columns(4).Width = 200
        ' Text Header 
        PatientDGV.Columns(0).HeaderText = "*"
        PatientDGV.Columns(1).HeaderText = "اسم المريض"
        PatientDGV.Columns(2).HeaderText = "الجنس"
        PatientDGV.Columns(3).HeaderText = "العمر"
        PatientDGV.Columns(4).HeaderText = "تاريخ التسجيل"
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Try
            If PatientDGV.SelectedRows.Count > 0 Then
                Main.Patients1.IdCodeLbl.Text = PatientDGV.SelectedRows(0).Cells(0).Value
                LoadSpecificPatients(Main.Patients1.IdCodeLbl.Text)
                LoadSpecificSession(Main.Patients1.IdCodeLbl.Text)
                Main.Patients1.GroupBox2.Visible = True
                If Main.Patients1.ListSessions.Items.Count > 0 Then
                    Main.Patients1.GroupBox1.Visible = True
                Else
                    Main.Patients1.GroupBox1.Visible = False
                End If
                Me.Close()
            End If
        Catch ex As Exception
            MyMessageBox.TextMessage.Text = " 🙃 حصل خطا ما!"
            MyMessageBox.AgreeBTN.BackColor = Color.FromArgb(225, 200, 34, 51)
            MyMessageBox.ShowDialog()
        End Try
    End Sub

    Private Sub TextSearch_TextChanged(sender As Object, e As EventArgs)
        'If TextSearch.Text <> "" Then
        '    GetTableMangePatinet(True, TextSearch.Text)
        'Else
        '    GetTableMangePatinet(True)
        'End If
        'StylePatientTable()
    End Sub
End Class