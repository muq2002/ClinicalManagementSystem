<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.TitlePanel = New System.Windows.Forms.Panel()
        Me.TextTitle = New System.Windows.Forms.Label()
        Me.PictureTitleLogo = New System.Windows.Forms.PictureBox()
        Me.MinBTN = New System.Windows.Forms.Button()
        Me.CloseBTN = New System.Windows.Forms.Button()
        Me.RightPanel = New System.Windows.Forms.Panel()
        Me.StaticsBTN = New System.Windows.Forms.Button()
        Me.PatientsNumber = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.PictureMenuLogo = New System.Windows.Forms.PictureBox()
        Me.SettingBTN = New System.Windows.Forms.Button()
        Me.PatientBTN = New System.Windows.Forms.Button()
        Me.LeftPanel = New System.Windows.Forms.Panel()
        Me.PatientsList = New System.Windows.Forms.ListView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AddPatientsBTN = New System.Windows.Forms.Button()
        Me.TextSearch = New System.Windows.Forms.TextBox()
        Me.Container1 = New System.Windows.Forms.Panel()
        Me.Patients1 = New ClinicalManagementSystem.Patients()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TitlePanel.SuspendLayout()
        CType(Me.PictureTitleLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RightPanel.SuspendLayout()
        CType(Me.PictureMenuLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LeftPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Container1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TitlePanel
        '
        Me.TitlePanel.BackColor = System.Drawing.Color.Gainsboro
        Me.TitlePanel.Controls.Add(Me.TextTitle)
        Me.TitlePanel.Controls.Add(Me.PictureTitleLogo)
        Me.TitlePanel.Controls.Add(Me.MinBTN)
        Me.TitlePanel.Controls.Add(Me.CloseBTN)
        Me.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitlePanel.Location = New System.Drawing.Point(0, 0)
        Me.TitlePanel.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.TitlePanel.Name = "TitlePanel"
        Me.TitlePanel.Size = New System.Drawing.Size(1366, 43)
        Me.TitlePanel.TabIndex = 0
        '
        'TextTitle
        '
        Me.TextTitle.AutoSize = True
        Me.TextTitle.Dock = System.Windows.Forms.DockStyle.Right
        Me.TextTitle.Font = New System.Drawing.Font("Cairo SemiBold", 12.9!, System.Drawing.FontStyle.Bold)
        Me.TextTitle.Location = New System.Drawing.Point(1177, 0)
        Me.TextTitle.Name = "TextTitle"
        Me.TextTitle.Size = New System.Drawing.Size(157, 33)
        Me.TextTitle.TabIndex = 5
        Me.TextTitle.Text = "نظام ادراة المرضى"
        '
        'PictureTitleLogo
        '
        Me.PictureTitleLogo.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureTitleLogo.Image = CType(resources.GetObject("PictureTitleLogo.Image"), System.Drawing.Image)
        Me.PictureTitleLogo.Location = New System.Drawing.Point(1334, 0)
        Me.PictureTitleLogo.Name = "PictureTitleLogo"
        Me.PictureTitleLogo.Size = New System.Drawing.Size(32, 43)
        Me.PictureTitleLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureTitleLogo.TabIndex = 4
        Me.PictureTitleLogo.TabStop = False
        '
        'MinBTN
        '
        Me.MinBTN.Dock = System.Windows.Forms.DockStyle.Left
        Me.MinBTN.FlatAppearance.BorderSize = 0
        Me.MinBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MinBTN.Image = CType(resources.GetObject("MinBTN.Image"), System.Drawing.Image)
        Me.MinBTN.Location = New System.Drawing.Point(42, 0)
        Me.MinBTN.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.MinBTN.Name = "MinBTN"
        Me.MinBTN.Size = New System.Drawing.Size(39, 43)
        Me.MinBTN.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.MinBTN, "Minimize")
        Me.MinBTN.UseVisualStyleBackColor = True
        '
        'CloseBTN
        '
        Me.CloseBTN.Dock = System.Windows.Forms.DockStyle.Left
        Me.CloseBTN.FlatAppearance.BorderSize = 0
        Me.CloseBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseBTN.Image = CType(resources.GetObject("CloseBTN.Image"), System.Drawing.Image)
        Me.CloseBTN.Location = New System.Drawing.Point(0, 0)
        Me.CloseBTN.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.CloseBTN.Name = "CloseBTN"
        Me.CloseBTN.Size = New System.Drawing.Size(42, 43)
        Me.CloseBTN.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.CloseBTN, "Close")
        Me.CloseBTN.UseVisualStyleBackColor = True
        '
        'RightPanel
        '
        Me.RightPanel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.RightPanel.Controls.Add(Me.StaticsBTN)
        Me.RightPanel.Controls.Add(Me.PatientsNumber)
        Me.RightPanel.Controls.Add(Me.ProgressBar1)
        Me.RightPanel.Controls.Add(Me.PictureMenuLogo)
        Me.RightPanel.Controls.Add(Me.SettingBTN)
        Me.RightPanel.Controls.Add(Me.PatientBTN)
        Me.RightPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.RightPanel.Location = New System.Drawing.Point(0, 43)
        Me.RightPanel.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.RightPanel.Name = "RightPanel"
        Me.RightPanel.Size = New System.Drawing.Size(189, 706)
        Me.RightPanel.TabIndex = 1
        '
        'StaticsBTN
        '
        Me.StaticsBTN.BackColor = System.Drawing.Color.WhiteSmoke
        Me.StaticsBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.StaticsBTN.FlatAppearance.BorderSize = 0
        Me.StaticsBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.StaticsBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StaticsBTN.Font = New System.Drawing.Font("Cairo SemiBold", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StaticsBTN.Image = CType(resources.GetObject("StaticsBTN.Image"), System.Drawing.Image)
        Me.StaticsBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.StaticsBTN.Location = New System.Drawing.Point(0, 173)
        Me.StaticsBTN.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.StaticsBTN.Name = "StaticsBTN"
        Me.StaticsBTN.Size = New System.Drawing.Size(189, 45)
        Me.StaticsBTN.TabIndex = 48
        Me.StaticsBTN.Text = "الاحصائيات"
        Me.StaticsBTN.UseVisualStyleBackColor = False
        '
        'PatientsNumber
        '
        Me.PatientsNumber.AutoSize = True
        Me.PatientsNumber.Font = New System.Drawing.Font("Cairo SemiBold", 8.749999!)
        Me.PatientsNumber.Location = New System.Drawing.Point(87, 674)
        Me.PatientsNumber.Name = "PatientsNumber"
        Me.PatientsNumber.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PatientsNumber.Size = New System.Drawing.Size(17, 23)
        Me.PatientsNumber.TabIndex = 47
        Me.PatientsNumber.Text = "0"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(9, 643)
        Me.ProgressBar1.Maximum = 50
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(171, 23)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.TabIndex = 5
        '
        'PictureMenuLogo
        '
        Me.PictureMenuLogo.Image = CType(resources.GetObject("PictureMenuLogo.Image"), System.Drawing.Image)
        Me.PictureMenuLogo.Location = New System.Drawing.Point(40, 3)
        Me.PictureMenuLogo.Name = "PictureMenuLogo"
        Me.PictureMenuLogo.Size = New System.Drawing.Size(111, 120)
        Me.PictureMenuLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureMenuLogo.TabIndex = 3
        Me.PictureMenuLogo.TabStop = False
        '
        'SettingBTN
        '
        Me.SettingBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SettingBTN.FlatAppearance.BorderSize = 0
        Me.SettingBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.SettingBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SettingBTN.Image = CType(resources.GetObject("SettingBTN.Image"), System.Drawing.Image)
        Me.SettingBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SettingBTN.Location = New System.Drawing.Point(0, 589)
        Me.SettingBTN.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.SettingBTN.Name = "SettingBTN"
        Me.SettingBTN.Size = New System.Drawing.Size(189, 45)
        Me.SettingBTN.TabIndex = 4
        Me.SettingBTN.Text = "الاعدادت"
        Me.SettingBTN.UseVisualStyleBackColor = True
        '
        'PatientBTN
        '
        Me.PatientBTN.BackColor = System.Drawing.Color.White
        Me.PatientBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PatientBTN.FlatAppearance.BorderSize = 0
        Me.PatientBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.PatientBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PatientBTN.Font = New System.Drawing.Font("Cairo SemiBold", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PatientBTN.Image = CType(resources.GetObject("PatientBTN.Image"), System.Drawing.Image)
        Me.PatientBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PatientBTN.Location = New System.Drawing.Point(0, 126)
        Me.PatientBTN.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.PatientBTN.Name = "PatientBTN"
        Me.PatientBTN.Size = New System.Drawing.Size(189, 45)
        Me.PatientBTN.TabIndex = 1
        Me.PatientBTN.Text = "المرضى"
        Me.PatientBTN.UseVisualStyleBackColor = False
        '
        'LeftPanel
        '
        Me.LeftPanel.BackColor = System.Drawing.Color.DarkGray
        Me.LeftPanel.Controls.Add(Me.PatientsList)
        Me.LeftPanel.Controls.Add(Me.Panel1)
        Me.LeftPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.LeftPanel.Location = New System.Drawing.Point(1093, 43)
        Me.LeftPanel.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.LeftPanel.Name = "LeftPanel"
        Me.LeftPanel.Size = New System.Drawing.Size(273, 706)
        Me.LeftPanel.TabIndex = 2
        '
        'PatientsList
        '
        Me.PatientsList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PatientsList.LargeImageList = Me.ImageList1
        Me.PatientsList.Location = New System.Drawing.Point(0, 37)
        Me.PatientsList.Name = "PatientsList"
        Me.PatientsList.RightToLeftLayout = True
        Me.PatientsList.Size = New System.Drawing.Size(273, 669)
        Me.PatientsList.SmallImageList = Me.ImageList1
        Me.PatientsList.TabIndex = 1
        Me.PatientsList.UseCompatibleStateImageBehavior = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "1_12_120.png")
        Me.ImageList1.Images.SetKeyName(1, "25_49_120_F.png")
        Me.ImageList1.Images.SetKeyName(2, "25_49_120_M.png")
        Me.ImageList1.Images.SetKeyName(3, "50_80_120_F.png")
        Me.ImageList1.Images.SetKeyName(4, "50_80_120_M.png")
        Me.ImageList1.Images.SetKeyName(5, "icons8_boy_120px.png")
        Me.ImageList1.Images.SetKeyName(6, "icons8_girl_120px.png")
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.AddPatientsBTN)
        Me.Panel1.Controls.Add(Me.TextSearch)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(273, 37)
        Me.Panel1.TabIndex = 0
        '
        'AddPatientsBTN
        '
        Me.AddPatientsBTN.Dock = System.Windows.Forms.DockStyle.Left
        Me.AddPatientsBTN.FlatAppearance.BorderSize = 0
        Me.AddPatientsBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddPatientsBTN.Image = CType(resources.GetObject("AddPatientsBTN.Image"), System.Drawing.Image)
        Me.AddPatientsBTN.Location = New System.Drawing.Point(0, 0)
        Me.AddPatientsBTN.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.AddPatientsBTN.Name = "AddPatientsBTN"
        Me.AddPatientsBTN.Size = New System.Drawing.Size(42, 37)
        Me.AddPatientsBTN.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.AddPatientsBTN, "Manage patient table")
        Me.AddPatientsBTN.UseVisualStyleBackColor = True
        '
        'TextSearch
        '
        Me.TextSearch.Location = New System.Drawing.Point(48, 3)
        Me.TextSearch.Name = "TextSearch"
        Me.TextSearch.Size = New System.Drawing.Size(223, 32)
        Me.TextSearch.TabIndex = 0
        Me.TextSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.TextSearch, "Type to apply filter on patients list")
        '
        'Container1
        '
        Me.Container1.BackColor = System.Drawing.Color.White
        Me.Container1.Controls.Add(Me.Patients1)
        Me.Container1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Container1.Location = New System.Drawing.Point(189, 43)
        Me.Container1.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.Container1.Name = "Container1"
        Me.Container1.Size = New System.Drawing.Size(904, 706)
        Me.Container1.TabIndex = 2
        '
        'Patients1
        '
        Me.Patients1.BackColor = System.Drawing.Color.White
        Me.Patients1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Patients1.Font = New System.Drawing.Font("Cairo SemiBold", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.Patients1.Location = New System.Drawing.Point(0, 0)
        Me.Patients1.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.Patients1.Name = "Patients1"
        Me.Patients1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Patients1.Size = New System.Drawing.Size(904, 706)
        Me.Patients1.TabIndex = 0
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1366, 749)
        Me.Controls.Add(Me.Container1)
        Me.Controls.Add(Me.LeftPanel)
        Me.Controls.Add(Me.RightPanel)
        Me.Controls.Add(Me.TitlePanel)
        Me.Font = New System.Drawing.Font("Cairo SemiBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.Name = "Main"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clinical Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TitlePanel.ResumeLayout(False)
        Me.TitlePanel.PerformLayout()
        CType(Me.PictureTitleLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RightPanel.ResumeLayout(False)
        Me.RightPanel.PerformLayout()
        CType(Me.PictureMenuLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LeftPanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Container1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TitlePanel As System.Windows.Forms.Panel
    Friend WithEvents RightPanel As System.Windows.Forms.Panel
    Friend WithEvents LeftPanel As System.Windows.Forms.Panel
    Friend WithEvents Container1 As System.Windows.Forms.Panel
    Friend WithEvents CloseBTN As System.Windows.Forms.Button
    Friend WithEvents SettingBTN As System.Windows.Forms.Button
    Friend WithEvents MinBTN As System.Windows.Forms.Button
    Friend WithEvents PictureMenuLogo As System.Windows.Forms.PictureBox
    Friend WithEvents TextTitle As System.Windows.Forms.Label
    Friend WithEvents PictureTitleLogo As System.Windows.Forms.PictureBox
    Friend WithEvents PatientBTN As System.Windows.Forms.Button
    Friend WithEvents PatientsList As System.Windows.Forms.ListView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TextSearch As System.Windows.Forms.TextBox
    Friend WithEvents AddPatientsBTN As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents PatientsNumber As System.Windows.Forms.Label
    Friend WithEvents StaticsBTN As System.Windows.Forms.Button
    Friend WithEvents Patients1 As ClinicalManagementSystem.Patients

End Class
