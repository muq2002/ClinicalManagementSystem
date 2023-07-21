<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Filter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Filter))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AddPatientBTN = New System.Windows.Forms.Button()
        Me.CloseBTN = New System.Windows.Forms.Button()
        Me.ComboAge = New System.Windows.Forms.ComboBox()
        Me.ComboGender = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(586, 179)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.AddPatientBTN)
        Me.GroupBox1.Controls.Add(Me.CloseBTN)
        Me.GroupBox1.Controls.Add(Me.ComboAge)
        Me.GroupBox1.Controls.Add(Me.ComboGender)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(584, 177)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "التصفية"
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
        Me.AddPatientBTN.Location = New System.Drawing.Point(58, 43)
        Me.AddPatientBTN.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.AddPatientBTN.Name = "AddPatientBTN"
        Me.AddPatientBTN.Size = New System.Drawing.Size(103, 45)
        Me.AddPatientBTN.TabIndex = 44
        Me.AddPatientBTN.Text = "تطبيق "
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
        Me.CloseBTN.Location = New System.Drawing.Point(58, 100)
        Me.CloseBTN.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.CloseBTN.Name = "CloseBTN"
        Me.CloseBTN.Size = New System.Drawing.Size(103, 45)
        Me.CloseBTN.TabIndex = 43
        Me.CloseBTN.Text = "اغلاق"
        Me.CloseBTN.UseVisualStyleBackColor = False
        '
        'ComboAge
        '
        Me.ComboAge.FormattingEnabled = True
        Me.ComboAge.Location = New System.Drawing.Point(291, 107)
        Me.ComboAge.Name = "ComboAge"
        Me.ComboAge.Size = New System.Drawing.Size(220, 32)
        Me.ComboAge.TabIndex = 2
        Me.ComboAge.Text = "غير محدد"
        '
        'ComboGender
        '
        Me.ComboGender.FormattingEnabled = True
        Me.ComboGender.Items.AddRange(New Object() {"غير محدد", "انثى", "ذكر"})
        Me.ComboGender.Location = New System.Drawing.Point(291, 43)
        Me.ComboGender.Name = "ComboGender"
        Me.ComboGender.Size = New System.Drawing.Size(220, 32)
        Me.ComboGender.TabIndex = 2
        Me.ComboGender.Text = "غير محدد"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(517, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "العمر:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(517, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "الجنس:"
        '
        'Filter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(586, 179)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Cairo SemiBold", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.Name = "Filter"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Filter"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents AddPatientBTN As System.Windows.Forms.Button
    Friend WithEvents CloseBTN As System.Windows.Forms.Button
    Friend WithEvents ComboAge As System.Windows.Forms.ComboBox
    Friend WithEvents ComboGender As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
