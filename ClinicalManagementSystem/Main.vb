Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions

Public Class Main
    <DllImport("gdi32")> _
    Public Shared Function AddFontResource(ByVal lpFileName As String) As Integer
    End Function

    <DllImport("user32.dll")> _
    Public Shared Function SendMessage(ByVal hWnd As Integer, ByVal Msg As UInteger, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function

    <DllImport("kernel32.dll", SetLastError:=True)> _
    Shared Function WriteProfileString(ByVal lpszSection As String, ByVal lpszKeyName As String, ByVal lpszString As String) As Integer
    End Function


    Private Sub CloseBTN_Click(sender As Object, e As EventArgs) Handles CloseBTN.Click
        Application.Exit()
    End Sub

    Private Sub SettingBTN_Click(sender As Object, e As EventArgs) Handles SettingBTN.Click
        Settings.ShowDialog()
    End Sub

    Private Sub MinBTN_Click(sender As Object, e As EventArgs) Handles MinBTN.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Minimized
        Else
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub AddPatientsBTN_Click(sender As Object, e As EventArgs) Handles AddPatientsBTN.Click
        MangePatient.ShowDialog()
    End Sub

    Private Sub Main_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If Active.CloseActive <> True And Security.CloseSecurity <> True Then
            If My.Settings.ActiveNumber <> "" And My.Settings.SerialNumber <> "" Then
                If My.Settings.Logged = False And My.Settings.Password <> "" Then
                    Security.ShowDialog()
                End If
                Application.DoEvents()
            Else
                If Active.ReadActivateKey(EncryptData(GetKeyActiveNumber())) = False Then
                    Me.Hide()
                    Active.ShowDialog()
                End If
            End If
        Else
            Me.Close()
        End If
    End Sub

    Private Sub Main_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        My.Settings.Logged = False
    End Sub
    Dim Thread As System.Threading.Thread
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Now.Date.Year = "2021" Or Now.Date.Year = "2020" Then
            TextSearch.Select()
            LoadPatientsName()
            InstallFonts()
        Else
            Application.Exit()
        End If
    End Sub
    Public Sub InstallFonts()
        Dim Ret As Integer
        Dim Res As Integer
        Dim FontPath, FontFileName, FontName As String
        Const WM_FONTCHANGE As Integer = &H1D
        Const HWND_BROADCAST As Integer = &HFFFF
        FontFileName = Application.StartupPath & "\data\fonts\"
        FontName = "Cairo-SemiBold.ttf"
        FontPath = FontFileName & FontFileName
        Ret = AddFontResource(FontPath)
        Res = SendMessage(HWND_BROADCAST, WM_FONTCHANGE, 0, 0)
        Ret = WriteProfileString("fonts", FontName & " (TrueType)", FontFileName)
    End Sub
    Private Sub PatientsList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PatientsList.SelectedIndexChanged
        If PatientsList.SelectedItems.Count > 0 Then
            SelectedItem()
        End If
    End Sub

    Private Sub TextSearch_TextChanged(sender As Object, e As EventArgs) Handles TextSearch.TextChanged
        ProgressBar1.Visible = True
        PatientsList.Items.Clear()
        If TextSearch.Text <> "" Then
            LoadPatientsName(TextSearch.Text)
        Else
            LoadPatientsName()
        End If
        ProgressBar1.Visible = False
    End Sub

    Private Sub StaticsBTN_Click(sender As Object, e As EventArgs) Handles StaticsBTN.Click
        StaticsManage.Show()
    End Sub
    Sub SelectedItem()
        ''Set Patients  Information
        Try

            LoadSpecificPatients(Integer.Parse(Regex.Replace(PatientsList.SelectedItems(0).ToString, "[^\d]", "")))
            Patients1.IdCodeLbl.Text = Integer.Parse(Regex.Replace(PatientsList.SelectedItems(0).ToString, "[^\d]", "")).ToString
            Select Case Patients1.TextPatientAge.Text
                Case 1 To 12
                    Patients1.PictureNameLogo.ImageLocation = Application.StartupPath & "\data\icons\120\1_12_120.png"
                    If Patients1.TextPatientGender.Text = "انثى" Then
                        Patients1.PictureGenderLogo.ImageLocation = Application.StartupPath & "\data\icons\sys\female.png"
                    Else
                        Patients1.PictureGenderLogo.ImageLocation = Application.StartupPath & "\data\icons\sys\male.png"
                    End If
                Case 13 To 24
                    If Patients1.TextPatientGender.Text = "انثى" Then
                        Patients1.PictureNameLogo.ImageLocation = Application.StartupPath & "\data\icons\120\13_24_120_F.png"
                        Patients1.PictureGenderLogo.ImageLocation = Application.StartupPath & "\data\icons\sys\female.png"
                    Else
                        Patients1.PictureNameLogo.ImageLocation = Application.StartupPath & "\data\icons\120\13_24_120_M.png"
                        Patients1.PictureGenderLogo.ImageLocation = Application.StartupPath & "\data\icons\sys\male.png"
                    End If
                Case 25 To 49
                    If Patients1.TextPatientGender.Text = "انثى" Then
                        Patients1.PictureNameLogo.ImageLocation = Application.StartupPath & "\data\icons\120\25_49_120_F.png"
                        Patients1.PictureGenderLogo.ImageLocation = Application.StartupPath & "\data\icons\sys\female.png"
                    Else
                        Patients1.PictureNameLogo.ImageLocation = Application.StartupPath & "\data\icons\120\25_49_120_M.png"
                        Patients1.PictureGenderLogo.ImageLocation = Application.StartupPath & "\data\icons\sys\male.png"
                    End If
                Case 50 To 80
                    If Patients1.TextPatientGender.Text = "انثى" Then
                        Patients1.PictureNameLogo.ImageLocation = Application.StartupPath & "\data\icons\120\50_80_120_F.png"
                        Patients1.PictureGenderLogo.ImageLocation = Application.StartupPath & "\data\icons\sys\female.png"
                    Else
                        Patients1.PictureNameLogo.ImageLocation = Application.StartupPath & "\data\icons\120\50_80_120_M.png"
                        Patients1.PictureGenderLogo.ImageLocation = Application.StartupPath & "\data\icons\sys\male.png"
                    End If
            End Select
            'Set Session Information

            LoadSpecificSession(Patients1.IdCodeLbl.Text.Trim)
            Patients1.GroupBox2.Visible = True
            If Patients1.ListSessions.Items.Count > 0 Then
                Patients1.GroupBox1.Visible = True
            Else
                Patients1.GroupBox1.Visible = False
            End If
        Catch ex As Exception
            'MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub PatientsList_DoubleClick(sender As Object, e As EventArgs) Handles PatientsList.DoubleClick
        If PatientsList.SelectedItems.Count > 0 Then
            SelectedItem()
        End If
    End Sub
End Class
