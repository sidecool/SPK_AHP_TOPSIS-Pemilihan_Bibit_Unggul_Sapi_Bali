<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_alternatif
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
        Me.PScreen = New System.Windows.Forms.Panel
        Me.PForm = New System.Windows.Forms.Panel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.TBPeternak = New System.Windows.Forms.TextBox
        Me.CBSkrotum = New System.Windows.Forms.ComboBox
        Me.CBBadan = New System.Windows.Forms.ComboBox
        Me.CBDada = New System.Windows.Forms.ComboBox
        Me.CBGumba = New System.Windows.Forms.ComboBox
        Me.CBUmur = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.BtnTutup = New System.Windows.Forms.Button
        Me.BtnBatal = New System.Windows.Forms.Button
        Me.BtnHapus = New System.Windows.Forms.Button
        Me.BtnSimpan = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.CBJenisKelamin = New System.Windows.Forms.ComboBox
        Me.TBNama = New System.Windows.Forms.TextBox
        Me.TBKode = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PScreen.SuspendLayout()
        Me.PForm.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PScreen
        '
        Me.PScreen.BackColor = System.Drawing.Color.Transparent
        Me.PScreen.Controls.Add(Me.PForm)
        Me.PScreen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PScreen.Location = New System.Drawing.Point(0, 0)
        Me.PScreen.Name = "PScreen"
        Me.PScreen.Padding = New System.Windows.Forms.Padding(10)
        Me.PScreen.Size = New System.Drawing.Size(605, 584)
        Me.PScreen.TabIndex = 3
        '
        'PForm
        '
        Me.PForm.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PForm.Controls.Add(Me.GroupBox2)
        Me.PForm.Controls.Add(Me.GroupBox1)
        Me.PForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PForm.Location = New System.Drawing.Point(10, 10)
        Me.PForm.Name = "PForm"
        Me.PForm.Padding = New System.Windows.Forms.Padding(10)
        Me.PForm.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PForm.Size = New System.Drawing.Size(585, 564)
        Me.PForm.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(10, 282)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(565, 272)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "  Data Viewer  "
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 16)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(559, 253)
        Me.DataGridView1.TabIndex = 15
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.TBPeternak)
        Me.GroupBox1.Controls.Add(Me.CBSkrotum)
        Me.GroupBox1.Controls.Add(Me.CBBadan)
        Me.GroupBox1.Controls.Add(Me.CBDada)
        Me.GroupBox1.Controls.Add(Me.CBGumba)
        Me.GroupBox1.Controls.Add(Me.CBUmur)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.BtnTutup)
        Me.GroupBox1.Controls.Add(Me.BtnBatal)
        Me.GroupBox1.Controls.Add(Me.BtnHapus)
        Me.GroupBox1.Controls.Add(Me.BtnSimpan)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.CBJenisKelamin)
        Me.GroupBox1.Controls.Add(Me.TBNama)
        Me.GroupBox1.Controls.Add(Me.TBKode)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(565, 272)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "  Form Inputan  "
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label14.Location = New System.Drawing.Point(23, 58)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(73, 13)
        Me.Label14.TabIndex = 49
        Me.Label14.Text = "PETERNAK"
        '
        'TBPeternak
        '
        Me.TBPeternak.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBPeternak.Location = New System.Drawing.Point(128, 54)
        Me.TBPeternak.MaxLength = 250
        Me.TBPeternak.Name = "TBPeternak"
        Me.TBPeternak.Size = New System.Drawing.Size(216, 20)
        Me.TBPeternak.TabIndex = 48
        '
        'CBSkrotum
        '
        Me.CBSkrotum.FormattingEnabled = True
        Me.CBSkrotum.Location = New System.Drawing.Point(386, 183)
        Me.CBSkrotum.Name = "CBSkrotum"
        Me.CBSkrotum.Size = New System.Drawing.Size(88, 21)
        Me.CBSkrotum.TabIndex = 47
        '
        'CBBadan
        '
        Me.CBBadan.FormattingEnabled = True
        Me.CBBadan.Location = New System.Drawing.Point(386, 158)
        Me.CBBadan.Name = "CBBadan"
        Me.CBBadan.Size = New System.Drawing.Size(88, 21)
        Me.CBBadan.TabIndex = 46
        '
        'CBDada
        '
        Me.CBDada.FormattingEnabled = True
        Me.CBDada.Location = New System.Drawing.Point(128, 183)
        Me.CBDada.Name = "CBDada"
        Me.CBDada.Size = New System.Drawing.Size(88, 21)
        Me.CBDada.TabIndex = 45
        '
        'CBGumba
        '
        Me.CBGumba.FormattingEnabled = True
        Me.CBGumba.Location = New System.Drawing.Point(128, 157)
        Me.CBGumba.Name = "CBGumba"
        Me.CBGumba.Size = New System.Drawing.Size(88, 21)
        Me.CBGumba.TabIndex = 44
        '
        'CBUmur
        '
        Me.CBUmur.FormattingEnabled = True
        Me.CBUmur.Location = New System.Drawing.Point(128, 131)
        Me.CBUmur.Name = "CBUmur"
        Me.CBUmur.Size = New System.Drawing.Size(88, 21)
        Me.CBUmur.TabIndex = 43
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(476, 186)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(23, 13)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = "cm"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label13.Location = New System.Drawing.Point(476, 159)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(23, 13)
        Me.Label13.TabIndex = 41
        Me.Label13.Text = "cm"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(216, 187)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(23, 13)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "cm"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(217, 160)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(23, 13)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "cm"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(217, 134)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "tahun"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(258, 186)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(126, 13)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "LINGKAR SKROTUM"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(258, 161)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 13)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "PANJANG BADAN"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(23, 187)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 13)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "LINGKAR DADA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(23, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "TINGGI GUMBA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(23, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "UMUR"
        '
        'BtnTutup
        '
        Me.BtnTutup.Location = New System.Drawing.Point(369, 229)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.Size = New System.Drawing.Size(75, 25)
        Me.BtnTutup.TabIndex = 11
        Me.BtnTutup.Text = "&Tutup"
        Me.BtnTutup.UseVisualStyleBackColor = True
        '
        'BtnBatal
        '
        Me.BtnBatal.Location = New System.Drawing.Point(288, 229)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(75, 25)
        Me.BtnBatal.TabIndex = 10
        Me.BtnBatal.Text = "&Batal"
        Me.BtnBatal.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(207, 229)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(75, 25)
        Me.BtnHapus.TabIndex = 9
        Me.BtnHapus.Text = "&Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Location = New System.Drawing.Point(126, 229)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(75, 25)
        Me.BtnSimpan.TabIndex = 8
        Me.BtnSimpan.Text = "&Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(23, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "JENIS KELAMIN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(23, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "ALTERNATIF"
        '
        'CBJenisKelamin
        '
        Me.CBJenisKelamin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBJenisKelamin.FormattingEnabled = True
        Me.CBJenisKelamin.Location = New System.Drawing.Point(128, 104)
        Me.CBJenisKelamin.Name = "CBJenisKelamin"
        Me.CBJenisKelamin.Size = New System.Drawing.Size(216, 21)
        Me.CBJenisKelamin.TabIndex = 2
        '
        'TBNama
        '
        Me.TBNama.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBNama.Location = New System.Drawing.Point(128, 78)
        Me.TBNama.MaxLength = 250
        Me.TBNama.Name = "TBNama"
        Me.TBNama.Size = New System.Drawing.Size(216, 20)
        Me.TBNama.TabIndex = 1
        '
        'TBKode
        '
        Me.TBKode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBKode.Location = New System.Drawing.Point(128, 30)
        Me.TBKode.MaxLength = 25
        Me.TBKode.Name = "TBKode"
        Me.TBKode.ReadOnly = True
        Me.TBKode.Size = New System.Drawing.Size(108, 20)
        Me.TBKode.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(23, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "KODE"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'f_alternatif
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 584)
        Me.Controls.Add(Me.PScreen)
        Me.Name = "f_alternatif"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Master Data Alternatif"
        Me.PScreen.ResumeLayout(False)
        Me.PForm.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PScreen As System.Windows.Forms.Panel
    Friend WithEvents PForm As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnTutup As System.Windows.Forms.Button
    Friend WithEvents BtnBatal As System.Windows.Forms.Button
    Friend WithEvents BtnHapus As System.Windows.Forms.Button
    Friend WithEvents BtnSimpan As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CBJenisKelamin As System.Windows.Forms.ComboBox
    Friend WithEvents TBNama As System.Windows.Forms.TextBox
    Friend WithEvents TBKode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents CBSkrotum As System.Windows.Forms.ComboBox
    Friend WithEvents CBBadan As System.Windows.Forms.ComboBox
    Friend WithEvents CBDada As System.Windows.Forms.ComboBox
    Friend WithEvents CBGumba As System.Windows.Forms.ComboBox
    Friend WithEvents CBUmur As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TBPeternak As System.Windows.Forms.TextBox
End Class
