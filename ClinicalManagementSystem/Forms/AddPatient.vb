Public Class AddPatient

    Private Sub AddPatient_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If MangePatient.EditItem Then
            MangePatient.EditItem = False
        End If
    End Sub

    Private Sub AddPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If MangePatient.EditItem = False Then
            TextNamePatient.Text = ""
            TextNamePatient.Select()
            AddPatientBTN.Text = "اضافة"
        Else
            AddPatientBTN.Text = "تعديل"
        End If
    End Sub
    Private Sub CloseBTN_Click(sender As Object, e As EventArgs) Handles CloseBTN.Click
        Me.Close()
    End Sub
    Private Sub TrackBarAge_Scroll(sender As Object, e As EventArgs) Handles TrackBarAge.Scroll, ComboGender.SelectedIndexChanged
        TextAge.Text = TrackBarAge.Value
        Select Case TrackBarAge.Value
            Case 1 To 12
                PictureNameLogo.ImageLocation = Application.StartupPath & "\data\icons\120\1_12_120.png"
                If ComboGender.Text = "انثى" Then
                    PictureGenderLogo.ImageLocation = Application.StartupPath & "\data\icons\sys\female.png"
                Else
                    PictureGenderLogo.ImageLocation = Application.StartupPath & "\data\icons\sys\male.png"
                End If
            Case 13 To 24
                If ComboGender.Text = "انثى" Then
                    PictureNameLogo.ImageLocation = Application.StartupPath & "\data\icons\120\13_24_120_F.png"
                    PictureGenderLogo.ImageLocation = Application.StartupPath & "\data\icons\sys\female.png"
                Else
                    PictureNameLogo.ImageLocation = Application.StartupPath & "\data\icons\120\13_24_120_M.png"
                    PictureGenderLogo.ImageLocation = Application.StartupPath & "\data\icons\sys\male.png"
                End If
            Case 25 To 49
                If ComboGender.Text = "انثى" Then
                    PictureNameLogo.ImageLocation = Application.StartupPath & "\data\icons\120\25_49_120_F.png"
                    PictureGenderLogo.ImageLocation = Application.StartupPath & "\data\icons\sys\female.png"
                Else
                    PictureNameLogo.ImageLocation = Application.StartupPath & "\data\icons\120\25_49_120_M.png"
                    PictureGenderLogo.ImageLocation = Application.StartupPath & "\data\icons\sys\male.png"
                End If
            Case 50 To 80
                If ComboGender.Text = "انثى" Then
                    PictureNameLogo.ImageLocation = Application.StartupPath & "\data\icons\120\50_80_120_F.png"
                    PictureGenderLogo.ImageLocation = Application.StartupPath & "\data\icons\sys\female.png"
                Else
                    PictureNameLogo.ImageLocation = Application.StartupPath & "\data\icons\120\50_80_120_M.png"
                    PictureGenderLogo.ImageLocation = Application.StartupPath & "\data\icons\sys\male.png"
                End If
        End Select
    End Sub

    Private Sub AddPatientBTN_Click(sender As Object, e As EventArgs) Handles AddPatientBTN.Click
        Try
            If MangePatient.EditItem = False Then
                If TextNamePatient.Text.Trim.Length > 2 And TextNamePatient.Text.Trim <> "" And TextAge.Text.Trim <> "" And ComboGender.Text.Trim <> "" Then
                    RunCommand("INSERT INTO Patient (NamePatient,  Age, Gender, RegisterDate) VALUES ('" & TextNamePatient.Text & "', '" & TextAge.Text & "', '" & ComboGender.Text & "', '" & TextDate.Text & Format(Now, " hh:mm") & "')")
                    If CheckProgress Then
                        MyMessageBox.TextMessage.Text = "🙂تم الاضافة بنجاح"
                        MyMessageBox.ShowDialog()
                    End If
                    ' Refresh DataGirdView
                    GetTableMangePatinet(True)
                    MangePatient.StylePatientTable()
                    Me.Close()
                Else
                    MyMessageBox.TextMessage.Text = "يرجى ملا البيانات بشكل صحيح 🙃 "
                    MyMessageBox.ShowDialog()
                End If
            Else
                Dim EditID As Integer
                If MangePatient.PatientDGV.SelectedRows.Count > 0 Then
                    EditID = MangePatient.PatientDGV.SelectedRows(0).Cells(0).Value()
                    If TextNamePatient.Text.Trim <> "" And TextAge.Text.Trim <> "" And ComboGender.Text.Trim <> "" Then
                        RunCommand("UPDATE Patient SET NamePatient='" & TextNamePatient.Text & "',  Age='" & TextAge.Text & "', Gender='" & ComboGender.Text & "', RegisterDate='" & TextDate.Text & Format(Now, " hh:mm") & "' WHERE ID=" & EditID)
                        If CheckProgress Then
                            MyMessageBox.TextMessage.Text = "تم التعديل بنجاح🙂"
                            MyMessageBox.ShowDialog()
                        End If
                        ' Refresh DataGirdView
                        GetTableMangePatinet(True)
                        MangePatient.StylePatientTable()
                        Me.Close()
                    Else
                        MyMessageBox.TextMessage.Text = " 🙃 يرجى ملا البيانات بشكل صحيح"
                        MyMessageBox.ShowDialog()

                    End If
                End If
            End If
        Catch ex As Exception
            MyMessageBox.TextMessage.Text = " 🙃 حصل خطا ما!"
            MyMessageBox.AgreeBTN.BackColor = Color.FromArgb(225, 200, 34, 51)
            MyMessageBox.ShowDialog()
        End Try
    End Sub

    Private Sub TextAge_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextAge.KeyPress
        Try
            If Not Char.IsControl(e.KeyChar) And Not Char.IsDigit(e.KeyChar) And e.KeyChar <> "." Then
                If e.KeyChar.ToString > 0 And e.KeyChar.ToString < 100 Then
                    e.Handled = True
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub TextAge_TextChanged(sender As Object, e As EventArgs) Handles TextAge.TextChanged
        Try
            If TextAge.Text <> "" Then
                TrackBarAge.Value = TextAge.Text
                TrackBarAge.Update()
                PictureNameLogo.Update()
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class