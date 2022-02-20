<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_utama
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(f_utama))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GantiPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MasterDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataKriteriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.DataAlternatifSapiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AnalisaAHPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PerankinganTOPSISToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserToolStripMenuItem, Me.MasterDataToolStripMenuItem, Me.AnalisaAHPToolStripMenuItem, Me.PerankinganTOPSISToolStripMenuItem, Me.LaporanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(671, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataUserToolStripMenuItem, Me.GantiPasswordToolStripMenuItem, Me.ToolStripMenuItem1, Me.LogoutToolStripMenuItem})
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.UserToolStripMenuItem.Text = "User"
        '
        'DataUserToolStripMenuItem
        '
        Me.DataUserToolStripMenuItem.Name = "DataUserToolStripMenuItem"
        Me.DataUserToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.DataUserToolStripMenuItem.Text = "Data User"
        '
        'GantiPasswordToolStripMenuItem
        '
        Me.GantiPasswordToolStripMenuItem.Name = "GantiPasswordToolStripMenuItem"
        Me.GantiPasswordToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.GantiPasswordToolStripMenuItem.Text = "Ganti Password"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(152, 6)
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'MasterDataToolStripMenuItem
        '
        Me.MasterDataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataKriteriaToolStripMenuItem, Me.ToolStripMenuItem2, Me.DataAlternatifSapiToolStripMenuItem})
        Me.MasterDataToolStripMenuItem.Name = "MasterDataToolStripMenuItem"
        Me.MasterDataToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.MasterDataToolStripMenuItem.Text = "Master Data"
        '
        'DataKriteriaToolStripMenuItem
        '
        Me.DataKriteriaToolStripMenuItem.Name = "DataKriteriaToolStripMenuItem"
        Me.DataKriteriaToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.DataKriteriaToolStripMenuItem.Text = "Data Kriteria"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(172, 6)
        '
        'DataAlternatifSapiToolStripMenuItem
        '
        Me.DataAlternatifSapiToolStripMenuItem.Name = "DataAlternatifSapiToolStripMenuItem"
        Me.DataAlternatifSapiToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.DataAlternatifSapiToolStripMenuItem.Text = "Data Alternatif Sapi"
        '
        'AnalisaAHPToolStripMenuItem
        '
        Me.AnalisaAHPToolStripMenuItem.Name = "AnalisaAHPToolStripMenuItem"
        Me.AnalisaAHPToolStripMenuItem.Size = New System.Drawing.Size(158, 20)
        Me.AnalisaAHPToolStripMenuItem.Text = "Perhitungan AHP - TOPSIS"
        '
        'PerankinganTOPSISToolStripMenuItem
        '
        Me.PerankinganTOPSISToolStripMenuItem.Name = "PerankinganTOPSISToolStripMenuItem"
        Me.PerankinganTOPSISToolStripMenuItem.Size = New System.Drawing.Size(124, 20)
        Me.PerankinganTOPSISToolStripMenuItem.Text = "Perankingan TOPSIS"
        Me.PerankinganTOPSISToolStripMenuItem.Visible = False
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 445)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(671, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Padding = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(77, 17)
        Me.ToolStripStatusLabel1.Text = "Tanggal : "
        Me.ToolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Padding = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(57, 17)
        Me.ToolStripStatusLabel2.Text = "Jam : "
        Me.ToolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Padding = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(80, 17)
        Me.ToolStripStatusLabel3.Text = "Login as : "
        Me.ToolStripStatusLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Timer1
        '
        '
        'f_utama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(671, 467)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "f_utama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents UserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GantiPasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataAlternatifSapiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DataKriteriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PerankinganTOPSISToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents AnalisaAHPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
