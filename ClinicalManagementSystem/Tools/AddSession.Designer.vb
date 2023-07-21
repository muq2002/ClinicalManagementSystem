<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddSession
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddSession))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextNameSession = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SaveBTN = New System.Windows.Forms.Button()
        Me.CancelBTN = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TextNameSession)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.SaveBTN)
        Me.Panel1.Controls.Add(Me.CancelBTN)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(438, 177)
        Me.Panel1.TabIndex = 0
        '
        'TextNameSession
        '
        Me.TextNameSession.Location = New System.Drawing.Point(63, 57)
        Me.TextNameSession.Name = "TextNameSession"
        Me.TextNameSession.Size = New System.Drawing.Size(296, 32)
        Me.TextNameSession.TabIndex = 41
        Me.TextNameSession.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(183, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 24)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "اسم الجلسة:"
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
        Me.SaveBTN.Location = New System.Drawing.Point(261, 124)
        Me.SaveBTN.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.SaveBTN.Name = "SaveBTN"
        Me.SaveBTN.Size = New System.Drawing.Size(97, 45)
        Me.SaveBTN.TabIndex = 39
        Me.SaveBTN.Text = "حفظ"
        Me.SaveBTN.UseVisualStyleBackColor = False
        '
        'CancelBTN
        '
        Me.CancelBTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.CancelBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CancelBTN.FlatAppearance.BorderSize = 0
        Me.CancelBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelBTN.ForeColor = System.Drawing.Color.White
        Me.CancelBTN.Image = CType(resources.GetObject("CancelBTN.Image"), System.Drawing.Image)
        Me.CancelBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CancelBTN.Location = New System.Drawing.Point(62, 124)
        Me.CancelBTN.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.CancelBTN.Name = "CancelBTN"
        Me.CancelBTN.Size = New System.Drawing.Size(97, 45)
        Me.CancelBTN.TabIndex = 38
        Me.CancelBTN.Text = "الغاء"
        Me.CancelBTN.UseVisualStyleBackColor = False
        '
        'AddSession
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(438, 177)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Cairo SemiBold", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.Name = "AddSession"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Session"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SaveBTN As System.Windows.Forms.Button
    Friend WithEvents CancelBTN As System.Windows.Forms.Button
    Friend WithEvents TextNameSession As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
