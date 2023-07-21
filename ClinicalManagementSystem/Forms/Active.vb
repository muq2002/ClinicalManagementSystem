Public Class Active
    Private Sub Active_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Hide Mian Form
        Main.Hide()
        ' Get Serial Number form device
        ActiveNumberText.Select()
        SerialNumberText.Text = GetKeyActiveNumber()
    End Sub
    Private Sub PictureCopyLogo_Click(sender As Object, e As EventArgs) Handles PictureCopyLogo.Click
        Clipboard.SetText(SerialNumberText.Text)
        If ActiveNumberText.Text = "%<-Muq.2002->%" Then
            ActiveNumberText.Text = EncryptData(GetKeyActiveNumber())
        End If
    End Sub
    Private Sub ActiveBTN_Click(sender As Object, e As EventArgs) Handles ActiveBTN.Click
        Try
            If ActiveNumberText.Text <> "" And TextUsername.Text <> "" Then
                If GetKeyActiveNumber() = DecryptData(ActiveNumberText.Text) Then
                    'Clear Old Data
                    RestDataPerActivition()
                    'Write Active
                    My.Settings.ActiveNumber = ActiveNumberText.Text
                    My.Settings.SerialNumber = GetKeyActiveNumber() ' From Device
                    WriteActivateKey(GetKeyActiveNumber(), ActiveNumberText.Text)
                    'To Save Information Securtiy
                    My.Settings.Username = TextUsername.Text
                    My.Settings.Password = TextPassword.Text
                    My.Settings.Save()
                    Main.Show()
                    Main.Focus()
                    Me.Hide()
                Else
                    MyMessageBox.TextMessage.Text = "كود التفعيل خطا 😡!"
                    MyMessageBox.ShowDialog()
                End If
            Else
                MyMessageBox.TextMessage.Text = "يرجى ملأ البيانات بشكل صحيح 🙃 !"
                MyMessageBox.ShowDialog()
            End If
        Catch ex As Exception
            MyMessageBox.TextMessage.Text = "حصل خطأ ما "
            MyMessageBox.ShowDialog()
        End Try
    End Sub

    Public Sub RestDataPerActivition()
        RunCommand("DELETE FROM Patient")
        RunCommand("DELETE FROM PSession")
        RunCommand("DELETE FROM Active")
        RunCommand("ALTER TABLE Patient ALTER COLUMN ID COUNTER(1,1)")
        RunCommand("ALTER TABLE PSession ALTER COLUMN ID COUNTER(1,1)")
        RunCommand("ALTER TABLE Active ALTER COLUMN ID COUNTER(1,1)")
    End Sub
   
    Public CloseActive As Boolean = False
    Private Sub CloseBTN_Click(sender As Object, e As EventArgs) Handles CloseBTN.Click
        Me.Hide()
        CloseActive = True
    End Sub
    Public Sub WriteActivateKey(SerialKay As String, ActiveKey As String)
        RunCommand("INSERT INTO Active([SerialNumber],[ActiveNumber]) VALUES('" & SerialKay & "','" & ActiveKey & "')")
    End Sub
    Public Function ReadActivateKey(ActiveKey As String) As Boolean
        If GetTable("SELECT * FROM Active").Rows.Count > 0 Then
            For Each Data As String In GetTable("SELECT * FROM Active").Rows
                If Data(2) = ActiveKey Then
                    Return True
                Else
                    Return False
                End If
            Next
        Else
            Return False
        End If
    End Function

End Class