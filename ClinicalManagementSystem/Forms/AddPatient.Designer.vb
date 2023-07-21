<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddPatient
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddPatient))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextDate = New System.Windows.Forms.DateTimePicker()
        Me.PictureNameLogo = New System.Windows.Forms.PictureBox()
        Me.TextAge = New System.Windows.Forms.TextBox()
        Me.AddPatientBTN = New System.Windows.Forms.Button()
        Me.CloseBTN = New System.Windows.Forms.Button()
        Me.TrackBarAge = New System.Windows.Forms.TrackBar()
        Me.ComboGender = New System.Windows.Forms.ComboBox()
        Me.PictureGenderLogo = New System.Windows.Forms.PictureBox()
        Me.TextNamePatient = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureNameLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBarAge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureGenderLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(761, 384)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextDate)
        Me.GroupBox1.Controls.Add(Me.PictureNameLogo)
        Me.GroupBox1.Controls.Add(Me.TextAge)
        Me.GroupBox1.Controls.Add(Me.AddPatientBTN)
        Me.GroupBox1.Controls.Add(Me.CloseBTN)
        Me.GroupBox1.Controls.Add(Me.TrackBarAge)
        Me.GroupBox1.Controls.Add(Me.ComboGender)
        Me.GroupBox1.Controls.Add(Me.PictureGenderLogo)
        Me.GroupBox1.Controls.Add(Me.TextNamePatient)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(759, 382)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "اضافة وتعديل بيانات المرضى"
        '
        'TextDate
        '
        Me.TextDate.Location = New System.Drawing.Point(422, 237)
        Me.TextDate.Name = "TextDate"
        Me.TextDate.Size = New System.Drawing.Size(214, 32)
        Me.TextDate.TabIndex = 5
        '
        'PictureNameLogo
        '
        Me.PictureNameLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureNameLogo.Location = New System.Drawing.Point(42, 52)
        Me.PictureNameLogo.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.PictureNameLogo.Name = "PictureNameLogo"
        Me.PictureNameLogo.Size = New System.Drawing.Size(128, 160)
        Me.PictureNameLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureNameLogo.TabIndex = 54
        Me.PictureNameLogo.TabStop = False
        '
        'TextAge
        '
        Me.TextAge.Location = New System.Drawing.Point(587, 93)
        Me.TextAge.Name = "TextAge"
        Me.TextAge.Size = New System.Drawing.Size(51, 32)
        Me.TextAge.TabIndex = 2
        Me.TextAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AddPatientBTN
        '
        Me.AddPatientBTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.AddPatientBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AddPatientBTN.FlatAppearance.BorderSize = 0
        Me.AddPatientBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddPatientBTN.ForeColor = System.Drawing.Color.White
        Me.AddPatientBTN.Image = CType(resources.GetObject("AddPatientBTN.Image"), System.Drawing.Image)
        Me.AddPatientBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddPatientBTN.Location = New System.Drawing.Point(160, 326)
        Me.AddPatientBTN.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.AddPatientBTN.Name = "AddPatientBTN"
        Me.AddPatientBTN.Size = New System.Drawing.Size(103, 45)
        Me.AddPatientBTN.TabIndex = 42
        Me.AddPatientBTN.Text = "اضافة"
        Me.AddPatientBTN.UseVisualStyleBackColor = False
        '
        'CloseBTN
        '
        Me.CloseBTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.CloseBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CloseBTN.FlatAppearance.BorderSize = 0
        Me.CloseBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseBTN.ForeColor = System.Drawing.Color.White
        Me.CloseBTN.Image = CType(resources.GetObject("CloseBTN.Image"), System.Drawing.Image)
        Me.CloseBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CloseBTN.Location = New System.Drawing.Point(41, 326)
        Me.CloseBTN.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.CloseBTN.Name = "CloseBTN"
        Me.CloseBTN.Size = New System.Drawing.Size(103, 45)
        Me.CloseBTN.TabIndex = 40
        Me.CloseBTN.Text = "اغلاق"
        Me.CloseBTN.UseVisualStyleBackColor = False
        '
        'TrackBarAge
        '
        Me.TrackBarAge.Location = New System.Drawing.Point(176, 131)
        Me.TrackBarAge.Maximum = 100
        Me.TrackBarAge.Minimum = 1
        Me.TrackBarAge.Name = "TrackBarAge"
        Me.TrackBarAge.Size = New System.Drawing.Size(462, 45)
        Me.TrackBarAge.TabIndex = 3
        Me.TrackBarAge.Value = 1
        '
        'ComboGender
        '
        Me.ComboGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboGender.FormattingEnabled = True
        Me.ComboGender.Items.AddRange(New Object() {"انثى", "ذكر"})
        Me.ComboGender.Location = New System.Drawing.Point(470, 185)
        Me.ComboGender.Name = "ComboGender"
        Me.ComboGender.Size = New System.Drawing.Size(167, 32)
        Me.ComboGender.TabIndex = 4
        Me.ComboGender.Text = "انثى"
        '
        'PictureGenderLogo
        '
        Me.PictureGenderLogo.Location = New System.Drawing.Point(422, 185)
        Me.PictureGenderLogo.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.PictureGenderLogo.Name = "PictureGenderLogo"
        Me.PictureGenderLogo.Size = New System.Drawing.Size(42, 32)
        Me.PictureGenderLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureGenderLogo.TabIndex = 50
        Me.PictureGenderLogo.TabStop = False
        '
        'TextNamePatient
        '
        Me.TextNamePatient.Location = New System.Drawing.Point(423, 55)
        Me.TextNamePatient.Name = "TextNamePatient"
        Me.TextNamePatient.Size = New System.Drawing.Size(215, 32)
        Me.TextNamePatient.TabIndex = 1
        Me.TextNamePatient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(685, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 24)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "الجنس:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(646, 234)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 24)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "تاريخ المراجعة:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(690, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 24)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "العمر: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(685, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 24)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "الاسم : "
        '
        'AddPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(761, 384)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Cairo SemiBold", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.Name = "AddPatient"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add Patient"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureNameLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBarAge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureGenderLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CloseBTN As System.Windows.Forms.Button
    Friend WithEvents AddPatientBTN As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextAge As System.Windows.Forms.TextBox
    Friend WithEvents TrackBarAge As System.Windows.Forms.TrackBar
    Friend WithEvents ComboGender As System.Windows.Forms.ComboBox
    Friend WithEvents PictureGenderLogo As System.Windows.Forms.PictureBox
    Friend WithEvents TextNamePatient As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureNameLogo As System.Windows.Forms.PictureBox
    Friend WithEvents TextDate As System.Windows.Forms.DateTimePicker
End Class
