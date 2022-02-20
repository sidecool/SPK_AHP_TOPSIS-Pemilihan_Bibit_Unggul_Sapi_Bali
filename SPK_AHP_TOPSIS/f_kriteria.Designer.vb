<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_kriteria
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
        Me.Label4 = New System.Windows.Forms.Label
        Me.TBBobot = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.CBAtribut = New System.Windows.Forms.ComboBox
        Me.BtnTutup = New System.Windows.Forms.Button
        Me.BtnBatal = New System.Windows.Forms.Button
        Me.BtnHapus = New System.Windows.Forms.Button
        Me.BtnSimpan = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
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
        Me.PScreen.Size = New System.Drawing.Size(408, 466)
        Me.PScreen.TabIndex = 4
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
        Me.PForm.Size = New System.Drawing.Size(388, 446)
        Me.PForm.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(10, 223)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(368, 213)
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
        Me.DataGridView1.Size = New System.Drawing.Size(362, 194)
        Me.DataGridView1.TabIndex = 15
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TBBobot)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.CBAtribut)
        Me.GroupBox1.Controls.Add(Me.BtnTutup)
        Me.GroupBox1.Controls.Add(Me.BtnBatal)
        Me.GroupBox1.Controls.Add(Me.BtnHapus)
        Me.GroupBox1.Controls.Add(Me.BtnSimpan)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.CBJenisKelamin)
        Me.GroupBox1.Controls.Add(Me.TBNama)
        Me.GroupBox1.Controls.Add(Me.TBKode)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(368, 213)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "  Form Inputan  "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(24, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "BOBOT"
        '
        'TBBobot
        '
        Me.TBBobot.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBBobot.Location = New System.Drawing.Point(129, 137)
        Me.TBBobot.MaxLength = 250
        Me.TBBobot.Name = "TBBobot"
        Me.TBBobot.Size = New System.Drawing.Size(68, 20)
        Me.TBBobot.TabIndex = 30
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(23, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "ATRIBUT"
        '
        'CBAtribut
        '
        Me.CBAtribut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBAtribut.FormattingEnabled = True
        Me.CBAtribut.Location = New System.Drawing.Point(128, 109)
        Me.CBAtribut.Name = "CBAtribut"
        Me.CBAtribut.Size = New System.Drawing.Size(216, 21)
        Me.CBAtribut.TabIndex = 28
        '
        'BtnTutup
        '
        Me.BtnTutup.Location = New System.Drawing.Point(269, 173)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.Size = New System.Drawing.Size(75, 25)
        Me.BtnTutup.TabIndex = 27
        Me.BtnTutup.Text = "&Tutup"
        Me.BtnTutup.UseVisualStyleBackColor = True
        '
        'BtnBatal
        '
        Me.BtnBatal.Location = New System.Drawing.Point(188, 173)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(75, 25)
        Me.BtnBatal.TabIndex = 26
        Me.BtnBatal.Text = "&Batal"
        Me.BtnBatal.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(107, 173)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(75, 25)
        Me.BtnHapus.TabIndex = 25
        Me.BtnHapus.Text = "&Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Location = New System.Drawing.Point(26, 173)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(75, 25)
        Me.BtnSimpan.TabIndex = 24
        Me.BtnSimpan.Text = "&Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(23, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "JENIS KELAMIN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(23, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "KRITERIA"
        '
        'CBJenisKelamin
        '
        Me.CBJenisKelamin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBJenisKelamin.FormattingEnabled = True
        Me.CBJenisKelamin.Location = New System.Drawing.Point(128, 82)
        Me.CBJenisKelamin.Name = "CBJenisKelamin"
        Me.CBJenisKelamin.Size = New System.Drawing.Size(216, 21)
        Me.CBJenisKelamin.TabIndex = 19
        '
        'TBNama
        '
        Me.TBNama.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBNama.Location = New System.Drawing.Point(128, 56)
        Me.TBNama.MaxLength = 250
        Me.TBNama.Name = "TBNama"
        Me.TBNama.Size = New System.Drawing.Size(216, 20)
        Me.TBNama.TabIndex = 16
        '
        'TBKode
        '
        Me.TBKode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBKode.Location = New System.Drawing.Point(128, 30)
        Me.TBKode.MaxLength = 25
        Me.TBKode.Name = "TBKode"
        Me.TBKode.ReadOnly = True
        Me.TBKode.Size = New System.Drawing.Size(108, 20)
        Me.TBKode.TabIndex = 15
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
        'f_kriteria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 466)
        Me.Controls.Add(Me.PScreen)
        Me.Name = "f_kriteria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Master Data Kriteria"
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TBNama As System.Windows.Forms.TextBox
    Friend WithEvents TBKode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CBJenisKelamin As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CBAtribut As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TBBobot As System.Windows.Forms.TextBox
End Class
