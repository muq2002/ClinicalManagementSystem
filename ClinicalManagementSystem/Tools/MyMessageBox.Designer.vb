<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyMessageBox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MyMessageBox))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AgreeBTN = New System.Windows.Forms.Button()
        Me.CheckClick = New System.Windows.Forms.Label()
        Me.PictureCode = New System.Windows.Forms.PictureBox()
        Me.TextMessage = New System.Windows.Forms.TextBox()
        Me.YesBTN = New System.Windows.Forms.Button()
        Me.NoBTN = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.AgreeBTN)
        Me.Panel1.Controls.Add(Me.CheckClick)
        Me.Panel1.Controls.Add(Me.PictureCode)
        Me.Panel1.Controls.Add(Me.TextMessage)
        Me.Panel1.Controls.Add(Me.YesBTN)
        Me.Panel1.Controls.Add(Me.NoBTN)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(438, 177)
        Me.Panel1.TabIndex = 0
        '
        'AgreeBTN
        '
        Me.AgreeBTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.AgreeBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AgreeBTN.FlatAppearance.BorderSize = 0
        Me.AgreeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AgreeBTN.ForeColor = System.Drawing.Color.White
        Me.AgreeBTN.Image = CType(resources.GetObject("AgreeBTN.Image"), System.Drawing.Image)
        Me.AgreeBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AgreeBTN.Location = New System.Drawing.Point(161, 124)
        Me.AgreeBTN.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.AgreeBTN.Name = "AgreeBTN"
        Me.AgreeBTN.Size = New System.Drawing.Size(107, 45)
        Me.AgreeBTN.TabIndex = 37
        Me.AgreeBTN.Text = "موافق"
        Me.AgreeBTN.UseVisualStyleBackColor = False
        '
        'CheckClick
        '
        Me.CheckClick.AutoSize = True
        Me.CheckClick.Location = New System.Drawing.Point(11, 94)
        Me.CheckClick.Name = "CheckClick"
        Me.CheckClick.Size = New System.Drawing.Size(17, 24)
        Me.CheckClick.TabIndex = 36
        Me.CheckClick.Text = "0"
        Me.CheckClick.Visible = False
        '
        'PictureCode
        '
        Me.PictureCode.Image = CType(resources.GetObject("PictureCode.Image"), System.Drawing.Image)
        Me.PictureCode.Location = New System.Drawing.Point(291, 26)
        Me.PictureCode.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.PictureCode.Name = "PictureCode"
        Me.PictureCode.Size = New System.Drawing.Size(86, 86)
        Me.PictureCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureCode.TabIndex = 35
        Me.PictureCode.TabStop = False
        '
        'TextMessage
        '
        Me.TextMessage.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextMessage.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextMessage.Location = New System.Drawing.Point(51, 25)
        Me.TextMessage.Multiline = True
        Me.TextMessage.Name = "TextMessage"
        Me.TextMessage.Size = New System.Drawing.Size(242, 81)
        Me.TextMessage.TabIndex = 34
        Me.TextMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'YesBTN
        '
        Me.YesBTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.YesBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.YesBTN.FlatAppearance.BorderSize = 0
        Me.YesBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.YesBTN.ForeColor = System.Drawing.Color.White
        Me.YesBTN.Image = CType(resources.GetObject("YesBTN.Image"), System.Drawing.Image)
        Me.YesBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.YesBTN.Location = New System.Drawing.Point(280, 124)
        Me.YesBTN.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.YesBTN.Name = "YesBTN"
        Me.YesBTN.Size = New System.Drawing.Size(97, 45)
        Me.YesBTN.TabIndex = 33
        Me.YesBTN.Text = "نعم"
        Me.YesBTN.UseVisualStyleBackColor = False
        '
        'NoBTN
        '
        Me.NoBTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.NoBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NoBTN.FlatAppearance.BorderSize = 0
        Me.NoBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NoBTN.ForeColor = System.Drawing.Color.White
        Me.NoBTN.Image = CType(resources.GetObject("NoBTN.Image"), System.Drawing.Image)
        Me.NoBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NoBTN.Location = New System.Drawing.Point(51, 124)
        Me.NoBTN.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.NoBTN.Name = "NoBTN"
        Me.NoBTN.Size = New System.Drawing.Size(97, 45)
        Me.NoBTN.TabIndex = 32
        Me.NoBTN.Text = "كلا"
        Me.NoBTN.UseVisualStyleBackColor = False
        '
        'MyMessageBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 177)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Cairo SemiBold", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.Name = "MyMessageBox"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MyMessageBox"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents NoBTN As System.Windows.Forms.Button
    Friend WithEvents TextMessage As System.Windows.Forms.TextBox
    Friend WithEvents YesBTN As System.Windows.Forms.Button
    Friend WithEvents PictureCode As System.Windows.Forms.PictureBox
    Friend WithEvents CheckClick As System.Windows.Forms.Label
    Friend WithEvents AgreeBTN As System.Windows.Forms.Button
End Class
