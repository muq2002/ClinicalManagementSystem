<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Patients
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Patients))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextSessionName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureTeethLogo = New System.Windows.Forms.PictureBox()
        Me.SaveBTN = New System.Windows.Forms.Button()
        Me.HideBTN = New System.Windows.Forms.Button()
        Me.ComboTeethNumber = New System.Windows.Forms.ComboBox()
        Me.RichTextNote = New System.Windows.Forms.RichTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextConjName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ListSessions = New System.Windows.Forms.ListBox()
        Me.PanelTitle = New System.Windows.Forms.Panel()
        Me.RemoveSessionBTN = New System.Windows.Forms.Button()
        Me.AddSessionBTN = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.IdCodeLbl = New System.Windows.Forms.TextBox()
        Me.PictureGenderLogo = New System.Windows.Forms.PictureBox()
        Me.PictureCode = New System.Windows.Forms.PictureBox()
        Me.TextLastDate = New System.Windows.Forms.TextBox()
        Me.TextPatientGender = New System.Windows.Forms.TextBox()
        Me.TextPatientAge = New System.Windows.Forms.TextBox()
        Me.TextPatientName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureNameLogo = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TextSessionDate = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureTeethLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.PanelTitle.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureGenderLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureNameLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextSessionDate)
        Me.GroupBox1.Controls.Add(Me.TextSessionName)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.PictureTeethLogo)
        Me.GroupBox1.Controls.Add(Me.SaveBTN)
        Me.GroupBox1.Controls.Add(Me.HideBTN)
        Me.GroupBox1.Controls.Add(Me.ComboTeethNumber)
        Me.GroupBox1.Controls.Add(Me.RichTextNote)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TextConjName)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(272, 204)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(632, 508)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "تفاصيل الجلسة"
        '
        'TextSessionName
        '
        Me.TextSessionName.Location = New System.Drawing.Point(297, 25)
        Me.TextSessionName.Name = "TextSessionName"
        Me.TextSessionName.Size = New System.Drawing.Size(215, 32)
        Me.TextSessionName.TabIndex = 37
        Me.TextSessionName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextSessionName.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(523, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 24)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "اسم الجلسة:"
        Me.Label9.Visible = False
        '
        'PictureTeethLogo
        '
        Me.PictureTeethLogo.Image = CType(resources.GetObject("PictureTeethLogo.Image"), System.Drawing.Image)
        Me.PictureTeethLogo.Location = New System.Drawing.Point(297, 159)
        Me.PictureTeethLogo.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.PictureTeethLogo.Name = "PictureTeethLogo"
        Me.PictureTeethLogo.Size = New System.Drawing.Size(42, 32)
        Me.PictureTeethLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureTeethLogo.TabIndex = 20
        Me.PictureTeethLogo.TabStop = False
        Me.PictureTeethLogo.Visible = False
        '
        'SaveBTN
        '
        Me.SaveBTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.SaveBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SaveBTN.FlatAppearance.BorderSize = 0
        Me.SaveBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveBTN.ForeColor = System.Drawing.Color.White
        Me.SaveBTN.Image = CType(resources.GetObject("SaveBTN.Image"), System.Drawing.Image)
        Me.SaveBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SaveBTN.Location = New System.Drawing.Point(118, 454)
        Me.SaveBTN.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.SaveBTN.Name = "SaveBTN"
        Me.SaveBTN.Size = New System.Drawing.Size(97, 45)
        Me.SaveBTN.TabIndex = 35
        Me.SaveBTN.Text = "حفظ"
        Me.ToolTip1.SetToolTip(Me.SaveBTN, "Save changes")
        Me.SaveBTN.UseVisualStyleBackColor = False
        Me.SaveBTN.Visible = False
        '
        'HideBTN
        '
        Me.HideBTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.HideBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HideBTN.FlatAppearance.BorderSize = 0
        Me.HideBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HideBTN.ForeColor = System.Drawing.Color.White
        Me.HideBTN.Image = CType(resources.GetObject("HideBTN.Image"), System.Drawing.Image)
        Me.HideBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.HideBTN.Location = New System.Drawing.Point(6, 454)
        Me.HideBTN.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.HideBTN.Name = "HideBTN"
        Me.HideBTN.Size = New System.Drawing.Size(97, 45)
        Me.HideBTN.TabIndex = 34
        Me.HideBTN.Text = "الغاء"
        Me.ToolTip1.SetToolTip(Me.HideBTN, "Cancel changes ")
        Me.HideBTN.UseVisualStyleBackColor = False
        Me.HideBTN.Visible = False
        '
        'ComboTeethNumber
        '
        Me.ComboTeethNumber.FormattingEnabled = True
        Me.ComboTeethNumber.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32"})
        Me.ComboTeethNumber.Location = New System.Drawing.Point(349, 161)
        Me.ComboTeethNumber.Name = "ComboTeethNumber"
        Me.ComboTeethNumber.Size = New System.Drawing.Size(162, 32)
        Me.ComboTeethNumber.TabIndex = 29
        Me.ComboTeethNumber.Text = "1"
        Me.ComboTeethNumber.Visible = False
        '
        'RichTextNote
        '
        Me.RichTextNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RichTextNote.Location = New System.Drawing.Point(126, 209)
        Me.RichTextNote.Name = "RichTextNote"
        Me.RichTextNote.Size = New System.Drawing.Size(386, 213)
        Me.RichTextNote.TabIndex = 28
        Me.RichTextNote.Text = ""
        Me.RichTextNote.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(533, 209)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 24)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "الملاحظات:"
        Me.Label7.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(536, 159)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 24)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "رقم السن:"
        Me.Label8.Visible = False
        '
        'TextConjName
        '
        Me.TextConjName.Location = New System.Drawing.Point(297, 69)
        Me.TextConjName.Name = "TextConjName"
        Me.TextConjName.Size = New System.Drawing.Size(215, 32)
        Me.TextConjName.TabIndex = 22
        Me.TextConjName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextConjName.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(516, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 24)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "تاريخ  الجلسة :"
        Me.Label5.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(516, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 24)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "اسم المرافق:"
        Me.Label6.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ListSessions)
        Me.GroupBox2.Controls.Add(Me.PanelTitle)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 204)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(266, 508)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "الجلسات  السابقة "
        '
        'ListSessions
        '
        Me.ListSessions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListSessions.FormattingEnabled = True
        Me.ListSessions.ItemHeight = 24
        Me.ListSessions.Location = New System.Drawing.Point(3, 69)
        Me.ListSessions.Name = "ListSessions"
        Me.ListSessions.Size = New System.Drawing.Size(260, 436)
        Me.ListSessions.TabIndex = 1
        '
        'PanelTitle
        '
        Me.PanelTitle.Controls.Add(Me.RemoveSessionBTN)
        Me.PanelTitle.Controls.Add(Me.AddSessionBTN)
        Me.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitle.Location = New System.Drawing.Point(3, 28)
        Me.PanelTitle.Name = "PanelTitle"
        Me.PanelTitle.Size = New System.Drawing.Size(260, 41)
        Me.PanelTitle.TabIndex = 0
        '
        'RemoveSessionBTN
        '
        Me.RemoveSessionBTN.Dock = System.Windows.Forms.DockStyle.Right
        Me.RemoveSessionBTN.FlatAppearance.BorderSize = 0
        Me.RemoveSessionBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RemoveSessionBTN.Image = CType(resources.GetObject("RemoveSessionBTN.Image"), System.Drawing.Image)
        Me.RemoveSessionBTN.Location = New System.Drawing.Point(180, 0)
        Me.RemoveSessionBTN.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.RemoveSessionBTN.Name = "RemoveSessionBTN"
        Me.RemoveSessionBTN.Size = New System.Drawing.Size(42, 41)
        Me.RemoveSessionBTN.TabIndex = 33
        Me.ToolTip1.SetToolTip(Me.RemoveSessionBTN, "Delete Session")
        Me.RemoveSessionBTN.UseVisualStyleBackColor = True
        '
        'AddSessionBTN
        '
        Me.AddSessionBTN.BackColor = System.Drawing.Color.White
        Me.AddSessionBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AddSessionBTN.Dock = System.Windows.Forms.DockStyle.Right
        Me.AddSessionBTN.FlatAppearance.BorderSize = 0
        Me.AddSessionBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddSessionBTN.ForeColor = System.Drawing.Color.White
        Me.AddSessionBTN.Image = CType(resources.GetObject("AddSessionBTN.Image"), System.Drawing.Image)
        Me.AddSessionBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddSessionBTN.Location = New System.Drawing.Point(222, 0)
        Me.AddSessionBTN.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.AddSessionBTN.Name = "AddSessionBTN"
        Me.AddSessionBTN.Size = New System.Drawing.Size(38, 41)
        Me.AddSessionBTN.TabIndex = 32
        Me.ToolTip1.SetToolTip(Me.AddSessionBTN, "Add Session")
        Me.AddSessionBTN.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.IdCodeLbl)
        Me.GroupBox3.Controls.Add(Me.PictureGenderLogo)
        Me.GroupBox3.Controls.Add(Me.PictureCode)
        Me.GroupBox3.Controls.Add(Me.TextLastDate)
        Me.GroupBox3.Controls.Add(Me.TextPatientGender)
        Me.GroupBox3.Controls.Add(Me.TextPatientAge)
        Me.GroupBox3.Controls.Add(Me.TextPatientName)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.PictureNameLogo)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(904, 209)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "معلومات المريض"
        '
        'IdCodeLbl
        '
        Me.IdCodeLbl.Location = New System.Drawing.Point(27, 110)
        Me.IdCodeLbl.Name = "IdCodeLbl"
        Me.IdCodeLbl.ReadOnly = True
        Me.IdCodeLbl.Size = New System.Drawing.Size(65, 32)
        Me.IdCodeLbl.TabIndex = 32
        Me.IdCodeLbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureGenderLogo
        '
        Me.PictureGenderLogo.Location = New System.Drawing.Point(478, 107)
        Me.PictureGenderLogo.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.PictureGenderLogo.Name = "PictureGenderLogo"
        Me.PictureGenderLogo.Size = New System.Drawing.Size(42, 32)
        Me.PictureGenderLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureGenderLogo.TabIndex = 31
        Me.PictureGenderLogo.TabStop = False
        '
        'PictureCode
        '
        Me.PictureCode.Image = CType(resources.GetObject("PictureCode.Image"), System.Drawing.Image)
        Me.PictureCode.Location = New System.Drawing.Point(16, 23)
        Me.PictureCode.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.PictureCode.Name = "PictureCode"
        Me.PictureCode.Size = New System.Drawing.Size(86, 86)
        Me.PictureCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureCode.TabIndex = 29
        Me.PictureCode.TabStop = False
        '
        'TextLastDate
        '
        Me.TextLastDate.Location = New System.Drawing.Point(436, 151)
        Me.TextLastDate.Name = "TextLastDate"
        Me.TextLastDate.ReadOnly = True
        Me.TextLastDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextLastDate.Size = New System.Drawing.Size(215, 32)
        Me.TextLastDate.TabIndex = 28
        Me.TextLastDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextPatientGender
        '
        Me.TextPatientGender.Location = New System.Drawing.Point(526, 107)
        Me.TextPatientGender.Name = "TextPatientGender"
        Me.TextPatientGender.ReadOnly = True
        Me.TextPatientGender.Size = New System.Drawing.Size(125, 32)
        Me.TextPatientGender.TabIndex = 27
        Me.TextPatientGender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextPatientAge
        '
        Me.TextPatientAge.Location = New System.Drawing.Point(436, 69)
        Me.TextPatientAge.Name = "TextPatientAge"
        Me.TextPatientAge.ReadOnly = True
        Me.TextPatientAge.Size = New System.Drawing.Size(215, 32)
        Me.TextPatientAge.TabIndex = 26
        Me.TextPatientAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextPatientName
        '
        Me.TextPatientName.Location = New System.Drawing.Point(436, 23)
        Me.TextPatientName.Name = "TextPatientName"
        Me.TextPatientName.ReadOnly = True
        Me.TextPatientName.Size = New System.Drawing.Size(215, 32)
        Me.TextPatientName.TabIndex = 25
        Me.TextPatientName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(690, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 24)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "الجنس:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(657, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 24)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "اول زيارة في :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(694, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 24)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "العمر: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(689, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 24)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "الاسم : "
        '
        'PictureNameLogo
        '
        Me.PictureNameLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureNameLogo.Location = New System.Drawing.Point(760, 23)
        Me.PictureNameLogo.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.PictureNameLogo.Name = "PictureNameLogo"
        Me.PictureNameLogo.Size = New System.Drawing.Size(128, 160)
        Me.PictureNameLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureNameLogo.TabIndex = 20
        Me.PictureNameLogo.TabStop = False
        '
        'TextSessionDate
        '
        Me.TextSessionDate.Location = New System.Drawing.Point(297, 109)
        Me.TextSessionDate.Name = "TextSessionDate"
        Me.TextSessionDate.Size = New System.Drawing.Size(215, 32)
        Me.TextSessionDate.TabIndex = 38
        '
        'Patients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Cairo SemiBold", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.Name = "Patients"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Size = New System.Drawing.Size(904, 730)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureTeethLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.PanelTitle.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureGenderLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureNameLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PanelTitle As System.Windows.Forms.Panel
    Friend WithEvents ListSessions As System.Windows.Forms.ListBox
    Friend WithEvents AddSessionBTN As System.Windows.Forms.Button
    Friend WithEvents RemoveSessionBTN As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextConjName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ComboTeethNumber As System.Windows.Forms.ComboBox
    Friend WithEvents RichTextNote As System.Windows.Forms.RichTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents SaveBTN As System.Windows.Forms.Button
    Friend WithEvents HideBTN As System.Windows.Forms.Button
    Friend WithEvents PictureTeethLogo As System.Windows.Forms.PictureBox
    Friend WithEvents TextSessionName As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureGenderLogo As System.Windows.Forms.PictureBox
    Friend WithEvents PictureCode As System.Windows.Forms.PictureBox
    Friend WithEvents TextLastDate As System.Windows.Forms.TextBox
    Friend WithEvents TextPatientGender As System.Windows.Forms.TextBox
    Friend WithEvents TextPatientAge As System.Windows.Forms.TextBox
    Friend WithEvents TextPatientName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureNameLogo As System.Windows.Forms.PictureBox
    Friend WithEvents IdCodeLbl As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents TextSessionDate As System.Windows.Forms.DateTimePicker

End Class
