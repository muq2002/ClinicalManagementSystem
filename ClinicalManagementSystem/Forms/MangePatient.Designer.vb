<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MangePatient
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MangePatient))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PatientDGV = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CloseBTN = New System.Windows.Forms.Button()
        Me.TitlePanel = New System.Windows.Forms.Panel()
        Me.SearchBTN = New System.Windows.Forms.Button()
        Me.EditPatientBTN = New System.Windows.Forms.Button()
        Me.RemovePatientBTN = New System.Windows.Forms.Button()
        Me.AddPatientsBTN = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PatientDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TitlePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1000, 567)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PatientDGV)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.TitlePanel)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(998, 565)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "سجل المرضى"
        '
        'PatientDGV
        '
        Me.PatientDGV.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.PatientDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PatientDGV.ContextMenuStrip = Me.ContextMenuStrip1
        Me.PatientDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PatientDGV.Location = New System.Drawing.Point(3, 69)
        Me.PatientDGV.MultiSelect = False
        Me.PatientDGV.Name = "PatientDGV"
        Me.PatientDGV.RowHeadersVisible = False
        Me.PatientDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PatientDGV.Size = New System.Drawing.Size(992, 446)
        Me.PatientDGV.TabIndex = 56
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(104, 26)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(103, 22)
        Me.ToolStripMenuItem1.Text = "Open"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.CloseBTN)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(3, 515)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(992, 47)
        Me.Panel2.TabIndex = 55
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
        Me.CloseBTN.Location = New System.Drawing.Point(3, 2)
        Me.CloseBTN.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.CloseBTN.Name = "CloseBTN"
        Me.CloseBTN.Size = New System.Drawing.Size(118, 45)
        Me.CloseBTN.TabIndex = 54
        Me.CloseBTN.Text = "اغلاق"
        Me.CloseBTN.UseVisualStyleBackColor = False
        '
        'TitlePanel
        '
        Me.TitlePanel.Controls.Add(Me.SearchBTN)
        Me.TitlePanel.Controls.Add(Me.EditPatientBTN)
        Me.TitlePanel.Controls.Add(Me.RemovePatientBTN)
        Me.TitlePanel.Controls.Add(Me.AddPatientsBTN)
        Me.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitlePanel.Location = New System.Drawing.Point(3, 28)
        Me.TitlePanel.Name = "TitlePanel"
        Me.TitlePanel.Size = New System.Drawing.Size(992, 41)
        Me.TitlePanel.TabIndex = 54
        '
        'SearchBTN
        '
        Me.SearchBTN.Dock = System.Windows.Forms.DockStyle.Left
        Me.SearchBTN.FlatAppearance.BorderSize = 0
        Me.SearchBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchBTN.Image = CType(resources.GetObject("SearchBTN.Image"), System.Drawing.Image)
        Me.SearchBTN.Location = New System.Drawing.Point(0, 0)
        Me.SearchBTN.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.SearchBTN.Name = "SearchBTN"
        Me.SearchBTN.Size = New System.Drawing.Size(42, 41)
        Me.SearchBTN.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.SearchBTN, "Search")
        Me.SearchBTN.UseVisualStyleBackColor = True
        '
        'EditPatientBTN
        '
        Me.EditPatientBTN.Dock = System.Windows.Forms.DockStyle.Right
        Me.EditPatientBTN.FlatAppearance.BorderSize = 0
        Me.EditPatientBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditPatientBTN.Image = CType(resources.GetObject("EditPatientBTN.Image"), System.Drawing.Image)
        Me.EditPatientBTN.Location = New System.Drawing.Point(866, 0)
        Me.EditPatientBTN.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.EditPatientBTN.Name = "EditPatientBTN"
        Me.EditPatientBTN.Size = New System.Drawing.Size(42, 41)
        Me.EditPatientBTN.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.EditPatientBTN, "Edit patient")
        Me.EditPatientBTN.UseVisualStyleBackColor = True
        '
        'RemovePatientBTN
        '
        Me.RemovePatientBTN.Dock = System.Windows.Forms.DockStyle.Right
        Me.RemovePatientBTN.FlatAppearance.BorderSize = 0
        Me.RemovePatientBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RemovePatientBTN.Image = CType(resources.GetObject("RemovePatientBTN.Image"), System.Drawing.Image)
        Me.RemovePatientBTN.Location = New System.Drawing.Point(908, 0)
        Me.RemovePatientBTN.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.RemovePatientBTN.Name = "RemovePatientBTN"
        Me.RemovePatientBTN.Size = New System.Drawing.Size(42, 41)
        Me.RemovePatientBTN.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.RemovePatientBTN, "Delete patient")
        Me.RemovePatientBTN.UseVisualStyleBackColor = True
        '
        'AddPatientsBTN
        '
        Me.AddPatientsBTN.Dock = System.Windows.Forms.DockStyle.Right
        Me.AddPatientsBTN.FlatAppearance.BorderSize = 0
        Me.AddPatientsBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddPatientsBTN.Image = CType(resources.GetObject("AddPatientsBTN.Image"), System.Drawing.Image)
        Me.AddPatientsBTN.Location = New System.Drawing.Point(950, 0)
        Me.AddPatientsBTN.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.AddPatientsBTN.Name = "AddPatientsBTN"
        Me.AddPatientsBTN.Size = New System.Drawing.Size(42, 41)
        Me.AddPatientsBTN.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.AddPatientsBTN, "Add patient")
        Me.AddPatientsBTN.UseVisualStyleBackColor = True
        '
        'MangePatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 567)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Cairo SemiBold", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.Name = "MangePatient"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MangePatient"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PatientDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.TitlePanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PatientDGV As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents CloseBTN As System.Windows.Forms.Button
    Friend WithEvents TitlePanel As System.Windows.Forms.Panel
    Friend WithEvents EditPatientBTN As System.Windows.Forms.Button
    Friend WithEvents RemovePatientBTN As System.Windows.Forms.Button
    Friend WithEvents AddPatientsBTN As System.Windows.Forms.Button
    Friend WithEvents SearchBTN As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
End Class
