<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Security
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Security))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LoginBTN = New System.Windows.Forms.Button()
        Me.CloseBTN = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PasswordText = New System.Windows.Forms.TextBox()
        Me.PictureSecuityLogo = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureSecuityLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(439, 475)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.LoginBTN)
        Me.GroupBox1.Controls.Add(Me.CloseBTN)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PasswordText)
        Me.GroupBox1.Controls.Add(Me.PictureSecuityLogo)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(437, 473)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "تسجيل الدخول"
        '
        'LoginBTN
        '
        Me.LoginBTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.LoginBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LoginBTN.FlatAppearance.BorderSize = 0
        Me.LoginBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoginBTN.ForeColor = System.Drawing.Color.White
        Me.LoginBTN.Image = CType(resources.GetObject("LoginBTN.Image"), System.Drawing.Image)
        Me.LoginBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LoginBTN.Location = New System.Drawing.Point(129, 342)
        Me.LoginBTN.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.LoginBTN.Name = "LoginBTN"
        Me.LoginBTN.Size = New System.Drawing.Size(170, 45)
        Me.LoginBTN.TabIndex = 51
        Me.LoginBTN.Text = "تسجيل الدخول"
        Me.LoginBTN.UseVisualStyleBackColor = False
        '
        'CloseBTN
        '
        Me.CloseBTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.CloseBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CloseBTN.FlatAppearance.BorderSize = 0
        Me.CloseBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseBTN.ForeColor = System.Drawing.Color.White
        Me.CloseBTN.Image = CType(resources.GetObject("CloseBTN.Image"), System.Drawing.Image)
        Me.CloseBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CloseBTN.Location = New System.Drawing.Point(155, 399)
        Me.CloseBTN.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.CloseBTN.Name = "CloseBTN"
        Me.CloseBTN.Size = New System.Drawing.Size(118, 45)
        Me.CloseBTN.TabIndex = 50
        Me.CloseBTN.Text = "اغلاق"
        Me.CloseBTN.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(176, 249)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 24)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "كلمة المرور"
        '
        'PasswordText
        '
        Me.PasswordText.Location = New System.Drawing.Point(39, 276)
        Me.PasswordText.Name = "PasswordText"
        Me.PasswordText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.PasswordText.Size = New System.Drawing.Size(350, 32)
        Me.PasswordText.TabIndex = 48
        Me.PasswordText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureSecuityLogo
        '
        Me.PictureSecuityLogo.Image = CType(resources.GetObject("PictureSecuityLogo.Image"), System.Drawing.Image)
        Me.PictureSecuityLogo.Location = New System.Drawing.Point(138, 43)
        Me.PictureSecuityLogo.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.PictureSecuityLogo.Name = "PictureSecuityLogo"
        Me.PictureSecuityLogo.Size = New System.Drawing.Size(152, 200)
        Me.PictureSecuityLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureSecuityLogo.TabIndex = 47
        Me.PictureSecuityLogo.TabStop = False
        '
        'Security
        '
        Me.AcceptButton = Me.LoginBTN
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 475)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Cairo SemiBold", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.Name = "Security"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Security"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureSecuityLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LoginBTN As System.Windows.Forms.Button
    Friend WithEvents CloseBTN As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PasswordText As System.Windows.Forms.TextBox
    Friend WithEvents PictureSecuityLogo As System.Windows.Forms.PictureBox
End Class
