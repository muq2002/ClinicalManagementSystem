Imports System.Data.OleDb
Module AccessTools
    Dim Conn As New OleDbConnection("provider=microsoft.ace.oledb.12.0; data source=" & Application.StartupPath & "\data\ClinicalBase.accdb")
    Dim cmd As New OleDbCommand("", Conn)
    Dim SQL As String
    Public CheckProgress As Boolean = True
    Public Sub RunCommand(SQLCommand As String, Optional Message As String = "")
        Try
            If Conn.State = ConnectionState.Closed Then Conn.Open()

            cmd.CommandText = SQLCommand
            cmd.ExecuteNonQuery()

            If Message <> "" Then MsgBox(Message)

        Catch ex As Exception
            MyMessageBox.TextMessage.Text = " 🙃 حصل خطا ما!" & vbNewLine & ex.ToString
            MyMessageBox.AgreeBTN.BackColor = Color.FromArgb(225, 200, 34, 51)
            MyMessageBox.ShowDialog()
            CheckProgress = False
        Finally
            If Conn.State = ConnectionState.Open Then Conn.Close()
        End Try
    End Sub

    Public Function GetTable(SelectCommand As String) As DataTable
        Try
            Dim tbl As New DataTable
            If Conn.State = ConnectionState.Closed Then Conn.Open()
            cmd.CommandText = SelectCommand
            tbl.Load(cmd.ExecuteReader)
            Return tbl

        Catch ex As Exception
            MyMessageBox.TextMessage.Text = " 🙃 حصل خطا ما!" & vbNewLine & ex.ToString
            MyMessageBox.AgreeBTN.BackColor = Color.FromArgb(225, 200, 34, 51)
            MyMessageBox.ShowDialog()
            CheckProgress = False
            Return New DataTable
        Finally
            If Conn.State = ConnectionState.Open Then Conn.Close()

        End Try
    End Function

    Public Sub DisposeConnection()
        Conn.Dispose()
        'cmd.Dispose()
    End Sub
   
    Public Sub GetTableMangePatinet(Optional RefreshListPatient As Boolean = False, Optional SearchText As String = "")
        If SearchText = "" Then
            SQL = "SELECT * FROM Patient"
        Else
            SQL = "SELECT * FROM Patient WHERE [NamePatient] LIKE '%" & SearchText & "%'"
        End If
        Application.DoEvents()
        MangePatient.PatientDGV.DataSource = GetTable(SQL)
        If RefreshListPatient Then
            Main.PatientsList.Items.Clear()
            LoadPatientsName()
        End If
    End Sub
    Public Sub LoadPatientsName(Optional SearchText As String = "")
        If SearchText = "" Then
            SQL = "SELECT * FROM Patient ORDER BY ID DESC;"
        Else
            SQL = "SELECT * FROM Patient WHERE [NamePatient] LIKE '%" & SearchText & "%'"
        End If
        Main.PatientsNumber.Text = GetTable(SQL).Rows.Count
        For Each Data As DataRow In GetTable(SQL).Rows
            If Main.PatientsList.Items.Count < 50 Then
                Select Case Val(Data(3).ToString)
                    Case 1 To 12
                        Main.PatientsList.Items.Add(Data(1).ToString & vbNewLine & Data(0).ToString, 0)
                    Case 13 To 24
                        If Data(2).ToString = "انثى" Then
                            Main.PatientsList.Items.Add(Data(1).ToString & vbNewLine & Data(0).ToString, 6)
                        Else
                            Main.PatientsList.Items.Add(Data(1).ToString & vbNewLine & Data(0).ToString, 5)
                        End If
                    Case 25 To 49
                        If Data(2).ToString = "انثى" Then
                            Main.PatientsList.Items.Add(Data(1).ToString & vbNewLine & Data(0).ToString, 1)
                        Else
                            Main.PatientsList.Items.Add(Data(1).ToString & vbNewLine & Data(0).ToString, 2)
                        End If
                    Case 50 To 80
                        If Data(2).ToString = "انثى" Then
                            Main.PatientsList.Items.Add(Data(1).ToString & vbNewLine & Data(0).ToString, 3)
                        Else
                            Main.PatientsList.Items.Add(Data(1).ToString & vbNewLine & Data(0).ToString, 4)
                        End If
                End Select
                Main.ProgressBar1.Value = Main.PatientsList.Items.Count
            Else
                Exit For
            End If

            Application.DoEvents()
        Next
        Main.ProgressBar1.Visible = False
    End Sub
    Sub LoadSpecificPatients(ID As String)

        SQL = "SElECT * FROM Patient WHERE ID=" & ID
        For Each Data As DataRow In GetTable(SQL).Rows
            Main.Patients1.TextPatientName.Text = Data(1).ToString
            Main.Patients1.TextPatientAge.Text = Data(3).ToString
            Main.Patients1.TextPatientGender.Text = Data(2).ToString
            Main.Patients1.TextLastDate.Text = Data(4).ToString
            Application.DoEvents()
        Next
    End Sub
    Sub LoadSpecificSession(ID As String)
        SQL = "SElECT * FROM PSession WHERE PatientID='" & ID & "'"
        If GetTable(SQL).Rows.Count > 0 Then
            Main.Patients1.ListSessions.ValueMember = "ID"
            Main.Patients1.ListSessions.DisplayMember = "SessionName"
        Else
            Main.Patients1.GroupBox1.Visible = False
        End If
        Main.Patients1.ListSessions.DataSource = GetTable(SQL)
        Application.DoEvents()
    End Sub
    Sub LoadDataSpecificSession(ID As String)
        SQL = "SElECT * FROM PSession WHERE ID=" & ID
        For Each MyRow As DataRow In GetTable(SQL).Rows
            Main.Patients1.TextSessionName.Text = MyRow(2).ToString
            Main.Patients1.TextConjName.Text = MyRow(3).ToString
            If MyRow(4).ToString <> "" Then
                Main.Patients1.TextSessionDate.Text = MyRow(4).ToString
                Main.Patients1.Timer1.Stop()
            Else
                Main.Patients1.Timer1.Start()
            End If
            Main.Patients1.ComboTeethNumber.Text = MyRow(5).ToString
            Main.Patients1.RichTextNote.Text = MyRow(6).ToString
            Application.DoEvents()
        Next
    End Sub
    Public Sub RestDataBaseSetting()
        MyMessageBox.TextMessage.Text = "هل تريد حذف جميع البيانات "
        MyMessageBox.ShowBTN = 1
        MyMessageBox.ShowDialog()
        If MyMessageBox.CheckClick.Text = "1" Then
            RunCommand("DELETE FROM Patient")
            RunCommand("DELETE FROM PSession")
            RunCommand("ALTER TABLE Patient ALTER COLUMN ID COUNTER(1,1)")
            RunCommand("ALTER TABLE PSession ALTER COLUMN ID COUNTER(1,1)")
            LoadPatientsName()
        End If
    End Sub

End Module
