Public Class StaticsManage
    Public Sub WeeklyChart()
        Dim SQL As String = ""
        Dim SUM As Integer = 0
        For L = 1 To 32
            SQL = "SELECT * FROM PSession WHERE [NumberTeeth]='" & L & " '"
            SUM += GetTable(SQL).Rows.Count
            Application.DoEvents()
        Next
        Statics1.Chart1.Series(0).Points.Clear()
        For J = 1 To 32
            SQL = "SELECT * FROM PSession WHERE [NumberTeeth]='" & J & "'"
            If GetTable(SQL).Rows.Count > 0 Then
                Dim row As String() = New String() {"السن رقم " & J, GetTable(SQL).Rows.Count, Fix(((GetTable(SQL).Rows.Count / SUM) * 100)) & "%"}
                Statics1.DataGridView1.Rows.Add(row)
                Statics1.Chart1.Series(0).Points.AddXY(Fix((GetTable(SQL).Rows.Count / SUM) * 100) & "%; " & J, GetTable(SQL).Rows.Count / SUM)
                Application.DoEvents()
                MsgBox(GetTable(SQL).Rows.Count & " SUM:" & SUM)
            End If
        Next

    End Sub
    Public Sub GenderChart()
        Dim SQL1 As String = "SELECT * FROM Patient WHERE [Gender]='ذكر'"
        Dim SQL2 As String = "SELECT * FROM Patient WHERE [Gender]='انثى'"
        Dim SUM As Integer = GetTable(SQL1).Rows.Count + GetTable(SQL2).Rows.Count

        Statics1.ChartGender.Series(0).Points.AddXY(Fix((GetTable(SQL1).Rows.Count / SUM) * 100) & "% ذكر", GetTable(SQL1).Rows.Count / SUM)
        Statics1.ChartGender.Series(0).Points.AddXY(Fix((GetTable(SQL2).Rows.Count / SUM) * 100) & "% انثى", GetTable(SQL2).Rows.Count / SUM)

    End Sub

    Private Sub StaticsManage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenderChart()
        WeeklyChart()
    End Sub

End Class