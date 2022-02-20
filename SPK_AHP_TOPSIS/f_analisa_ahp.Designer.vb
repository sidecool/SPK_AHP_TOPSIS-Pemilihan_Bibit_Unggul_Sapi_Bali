<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_analisa_ahp
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(f_analisa_ahp))
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.PViewer = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.RBBetina = New System.Windows.Forms.RadioButton
        Me.RBJantan = New System.Windows.Forms.RadioButton
        Me.BtnMatriksAlternatif = New System.Windows.Forms.Button
        Me.BtnNormalisasiTerbobot = New System.Windows.Forms.Button
        Me.BtnPerankingan = New System.Windows.Forms.Button
        Me.BtnKonsistensiKriteria = New System.Windows.Forms.Button
        Me.BtnMatriksBobotPrioritasKriteria = New System.Windows.Forms.Button
        Me.BtnMatriksPerbandinganKriteria = New System.Windows.Forms.Button
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.PScreen = New System.Windows.Forms.Panel
        Me.PForm = New System.Windows.Forms.Panel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DGVKriteria = New System.Windows.Forms.DataGridView
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.TbRI = New System.Windows.Forms.TextBox
        Me.TbCI = New System.Windows.Forms.TextBox
        Me.TbLamda = New System.Windows.Forms.TextBox
        Me.LbKonsisten = New System.Windows.Forms.Label
        Me.LbRI = New System.Windows.Forms.Label
        Me.LbCI = New System.Windows.Forms.Label
        Me.LbLamda = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.PScreen.SuspendLayout()
        Me.PForm.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGVKriteria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.PViewer)
        Me.TabPage3.Controls.Add(Me.Panel2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(742, 482)
        Me.TabPage3.TabIndex = 3
        Me.TabPage3.Text = "Proses Perhitungan AHP - TOPSIS"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'PViewer
        '
        Me.PViewer.BackColor = System.Drawing.Color.Black
        Me.PViewer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PViewer.Location = New System.Drawing.Point(274, 3)
        Me.PViewer.Name = "PViewer"
        Me.PViewer.Size = New System.Drawing.Size(465, 476)
        Me.PViewer.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.BtnMatriksAlternatif)
        Me.Panel2.Controls.Add(Me.BtnNormalisasiTerbobot)
        Me.Panel2.Controls.Add(Me.BtnPerankingan)
        Me.Panel2.Controls.Add(Me.BtnKonsistensiKriteria)
        Me.Panel2.Controls.Add(Me.BtnMatriksBobotPrioritasKriteria)
        Me.Panel2.Controls.Add(Me.BtnMatriksPerbandinganKriteria)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(0, 40, 0, 40)
        Me.Panel2.Size = New System.Drawing.Size(271, 476)
        Me.Panel2.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RBBetina)
        Me.Panel1.Controls.Add(Me.RBJantan)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 263)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(267, 46)
        Me.Panel1.TabIndex = 12
        '
        'RBBetina
        '
        Me.RBBetina.AutoSize = True
        Me.RBBetina.Location = New System.Drawing.Point(138, 13)
        Me.RBBetina.Name = "RBBetina"
        Me.RBBetina.Size = New System.Drawing.Size(109, 21)
        Me.RBBetina.TabIndex = 13
        Me.RBBetina.TabStop = True
        Me.RBBetina.Text = "Sapi Betina"
        Me.RBBetina.UseVisualStyleBackColor = True
        '
        'RBJantan
        '
        Me.RBJantan.AutoSize = True
        Me.RBJantan.Location = New System.Drawing.Point(20, 13)
        Me.RBJantan.Name = "RBJantan"
        Me.RBJantan.Size = New System.Drawing.Size(112, 21)
        Me.RBJantan.TabIndex = 12
        Me.RBJantan.TabStop = True
        Me.RBJantan.Text = "Sapi Jantan"
        Me.RBJantan.UseVisualStyleBackColor = True
        '
        'BtnMatriksAlternatif
        '
        Me.BtnMatriksAlternatif.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnMatriksAlternatif.Enabled = False
        Me.BtnMatriksAlternatif.Location = New System.Drawing.Point(0, 309)
        Me.BtnMatriksAlternatif.Name = "BtnMatriksAlternatif"
        Me.BtnMatriksAlternatif.Size = New System.Drawing.Size(267, 41)
        Me.BtnMatriksAlternatif.TabIndex = 7
        Me.BtnMatriksAlternatif.Text = "4. Matriks Alternatif"
        Me.BtnMatriksAlternatif.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMatriksAlternatif.UseVisualStyleBackColor = True
        '
        'BtnNormalisasiTerbobot
        '
        Me.BtnNormalisasiTerbobot.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnNormalisasiTerbobot.Enabled = False
        Me.BtnNormalisasiTerbobot.Location = New System.Drawing.Point(0, 350)
        Me.BtnNormalisasiTerbobot.Name = "BtnNormalisasiTerbobot"
        Me.BtnNormalisasiTerbobot.Size = New System.Drawing.Size(267, 41)
        Me.BtnNormalisasiTerbobot.TabIndex = 8
        Me.BtnNormalisasiTerbobot.Text = "5. Matriks Normalisasi Terbobot"
        Me.BtnNormalisasiTerbobot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNormalisasiTerbobot.UseVisualStyleBackColor = True
        '
        'BtnPerankingan
        '
        Me.BtnPerankingan.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnPerankingan.Enabled = False
        Me.BtnPerankingan.Location = New System.Drawing.Point(0, 391)
        Me.BtnPerankingan.Name = "BtnPerankingan"
        Me.BtnPerankingan.Size = New System.Drawing.Size(267, 41)
        Me.BtnPerankingan.TabIndex = 9
        Me.BtnPerankingan.Text = "6. Perankingan TOPSIS"
        Me.BtnPerankingan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPerankingan.UseVisualStyleBackColor = True
        '
        'BtnKonsistensiKriteria
        '
        Me.BtnKonsistensiKriteria.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnKonsistensiKriteria.Location = New System.Drawing.Point(0, 122)
        Me.BtnKonsistensiKriteria.Name = "BtnKonsistensiKriteria"
        Me.BtnKonsistensiKriteria.Size = New System.Drawing.Size(267, 41)
        Me.BtnKonsistensiKriteria.TabIndex = 6
        Me.BtnKonsistensiKriteria.Text = "3. Konsistensi Kriteria"
        Me.BtnKonsistensiKriteria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnKonsistensiKriteria.UseVisualStyleBackColor = True
        '
        'BtnMatriksBobotPrioritasKriteria
        '
        Me.BtnMatriksBobotPrioritasKriteria.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnMatriksBobotPrioritasKriteria.Location = New System.Drawing.Point(0, 81)
        Me.BtnMatriksBobotPrioritasKriteria.Name = "BtnMatriksBobotPrioritasKriteria"
        Me.BtnMatriksBobotPrioritasKriteria.Size = New System.Drawing.Size(267, 41)
        Me.BtnMatriksBobotPrioritasKriteria.TabIndex = 5
        Me.BtnMatriksBobotPrioritasKriteria.Text = "2. Matriks Bobot Prioritas Kriteria"
        Me.BtnMatriksBobotPrioritasKriteria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMatriksBobotPrioritasKriteria.UseVisualStyleBackColor = True
        '
        'BtnMatriksPerbandinganKriteria
        '
        Me.BtnMatriksPerbandinganKriteria.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnMatriksPerbandinganKriteria.Location = New System.Drawing.Point(0, 40)
        Me.BtnMatriksPerbandinganKriteria.Name = "BtnMatriksPerbandinganKriteria"
        Me.BtnMatriksPerbandinganKriteria.Size = New System.Drawing.Size(267, 41)
        Me.BtnMatriksPerbandinganKriteria.TabIndex = 4
        Me.BtnMatriksPerbandinganKriteria.Text = "1. Matriks Perbandingan Kriteria"
        Me.BtnMatriksPerbandinganKriteria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMatriksPerbandinganKriteria.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PScreen)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(742, 482)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Analisa Nilai Kriteria"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'PScreen
        '
        Me.PScreen.BackColor = System.Drawing.Color.Transparent
        Me.PScreen.Controls.Add(Me.PForm)
        Me.PScreen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PScreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PScreen.Location = New System.Drawing.Point(3, 3)
        Me.PScreen.Name = "PScreen"
        Me.PScreen.Padding = New System.Windows.Forms.Padding(10)
        Me.PScreen.Size = New System.Drawing.Size(736, 476)
        Me.PScreen.TabIndex = 6
        '
        'PForm
        '
        Me.PForm.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PForm.Controls.Add(Me.GroupBox2)
        Me.PForm.Controls.Add(Me.GroupBox3)
        Me.PForm.Controls.Add(Me.GroupBox1)
        Me.PForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PForm.Location = New System.Drawing.Point(10, 10)
        Me.PForm.Name = "PForm"
        Me.PForm.Padding = New System.Windows.Forms.Padding(10)
        Me.PForm.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PForm.Size = New System.Drawing.Size(716, 456)
        Me.PForm.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DGVKriteria)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(263, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(443, 274)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "  Pengisian Nilai Kriteria  "
        '
        'DGVKriteria
        '
        Me.DGVKriteria.AllowUserToAddRows = False
        Me.DGVKriteria.AllowUserToDeleteRows = False
        Me.DGVKriteria.AllowUserToResizeRows = False
        Me.DGVKriteria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVKriteria.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVKriteria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVKriteria.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVKriteria.Location = New System.Drawing.Point(3, 19)
        Me.DGVKriteria.MultiSelect = False
        Me.DGVKriteria.Name = "DGVKriteria"
        Me.DGVKriteria.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DGVKriteria.ShowEditingIcon = False
        Me.DGVKriteria.Size = New System.Drawing.Size(437, 252)
        Me.DGVKriteria.TabIndex = 15
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TbRI)
        Me.GroupBox3.Controls.Add(Me.TbCI)
        Me.GroupBox3.Controls.Add(Me.TbLamda)
        Me.GroupBox3.Controls.Add(Me.LbKonsisten)
        Me.GroupBox3.Controls.Add(Me.LbRI)
        Me.GroupBox3.Controls.Add(Me.LbCI)
        Me.GroupBox3.Controls.Add(Me.LbLamda)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(263, 284)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(443, 162)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "  Perhitungan Analisa Kriteria  "
        '
        'TbRI
        '
        Me.TbRI.Location = New System.Drawing.Point(199, 86)
        Me.TbRI.Name = "TbRI"
        Me.TbRI.ReadOnly = True
        Me.TbRI.Size = New System.Drawing.Size(212, 23)
        Me.TbRI.TabIndex = 6
        '
        'TbCI
        '
        Me.TbCI.Location = New System.Drawing.Point(199, 59)
        Me.TbCI.Name = "TbCI"
        Me.TbCI.ReadOnly = True
        Me.TbCI.Size = New System.Drawing.Size(212, 23)
        Me.TbCI.TabIndex = 5
        '
        'TbLamda
        '
        Me.TbLamda.Location = New System.Drawing.Point(199, 32)
        Me.TbLamda.Name = "TbLamda"
        Me.TbLamda.ReadOnly = True
        Me.TbLamda.Size = New System.Drawing.Size(212, 23)
        Me.TbLamda.TabIndex = 4
        '
        'LbKonsisten
        '
        Me.LbKonsisten.AutoSize = True
        Me.LbKonsisten.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbKonsisten.Location = New System.Drawing.Point(16, 130)
        Me.LbKonsisten.Name = "LbKonsisten"
        Me.LbKonsisten.Size = New System.Drawing.Size(88, 20)
        Me.LbKonsisten.TabIndex = 3
        Me.LbKonsisten.Text = "Konsisten"
        '
        'LbRI
        '
        Me.LbRI.AutoSize = True
        Me.LbRI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbRI.Location = New System.Drawing.Point(16, 86)
        Me.LbRI.Name = "LbRI"
        Me.LbRI.Size = New System.Drawing.Size(111, 20)
        Me.LbRI.TabIndex = 2
        Me.LbRI.Text = "Ratio Index :"
        '
        'LbCI
        '
        Me.LbCI.AutoSize = True
        Me.LbCI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCI.Location = New System.Drawing.Point(16, 59)
        Me.LbCI.Name = "LbCI"
        Me.LbCI.Size = New System.Drawing.Size(165, 20)
        Me.LbCI.TabIndex = 1
        Me.LbCI.Text = "Consistency Index :"
        '
        'LbLamda
        '
        Me.LbLamda.AutoSize = True
        Me.LbLamda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbLamda.Location = New System.Drawing.Point(16, 32)
        Me.LbLamda.Name = "LbLamda"
        Me.LbLamda.Size = New System.Drawing.Size(61, 20)
        Me.LbLamda.TabIndex = 0
        Me.LbLamda.Text = "λMax :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RichTextBox1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(253, 436)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "  Cara Pengisian  "
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(3, 19)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(247, 414)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(60, 3)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(750, 511)
        Me.TabControl1.TabIndex = 0
        '
        'f_analisa_ahp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 511)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "f_analisa_ahp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Perhitungan AHP - TOPSIS"
        Me.TabPage3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.PScreen.ResumeLayout(False)
        Me.PForm.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGVKriteria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents PViewer As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BtnKonsistensiKriteria As System.Windows.Forms.Button
    Friend WithEvents BtnMatriksBobotPrioritasKriteria As System.Windows.Forms.Button
    Friend WithEvents BtnMatriksPerbandinganKriteria As System.Windows.Forms.Button
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents PScreen As System.Windows.Forms.Panel
    Friend WithEvents PForm As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DGVKriteria As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TbRI As System.Windows.Forms.TextBox
    Friend WithEvents TbCI As System.Windows.Forms.TextBox
    Friend WithEvents TbLamda As System.Windows.Forms.TextBox
    Friend WithEvents LbKonsisten As System.Windows.Forms.Label
    Friend WithEvents LbRI As System.Windows.Forms.Label
    Friend WithEvents LbCI As System.Windows.Forms.Label
    Friend WithEvents LbLamda As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents BtnMatriksAlternatif As System.Windows.Forms.Button
    Friend WithEvents BtnNormalisasiTerbobot As System.Windows.Forms.Button
    Friend WithEvents BtnPerankingan As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RBBetina As System.Windows.Forms.RadioButton
    Friend WithEvents RBJantan As System.Windows.Forms.RadioButton
End Class
