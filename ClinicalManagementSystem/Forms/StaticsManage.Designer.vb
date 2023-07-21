<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaticsManage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StaticsManage))
        Me.Statics1 = New ClinicalManagementSystem.Statics()
        Me.SuspendLayout()
        '
        'Statics1
        '
        Me.Statics1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Statics1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Statics1.Font = New System.Drawing.Font("Cairo SemiBold", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.Statics1.Location = New System.Drawing.Point(0, 0)
        Me.Statics1.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.Statics1.Name = "Statics1"
        Me.Statics1.Size = New System.Drawing.Size(904, 481)
        Me.Statics1.TabIndex = 0
        '
        'StaticsManage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(904, 481)
        Me.Controls.Add(Me.Statics1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "StaticsManage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StaticsManage"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Statics1 As ClinicalManagementSystem.Statics
End Class
