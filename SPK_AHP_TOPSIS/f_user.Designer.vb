<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_user
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
        Me.CekKonf = New System.Windows.Forms.CheckBox
        Me.CekPass = New System.Windows.Forms.CheckBox
        Me.BtnTutup = New System.Windows.Forms.Button
        Me.BtnBatal = New System.Windows.Forms.Button
        Me.BtnHapus = New System.Windows.Forms.Button
        Me.BtnSimpan = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.CBLevel = New System.Windows.Forms.ComboBox
        Me.TBKonf = New System.Windows.Forms.TextBox
        Me.TBPass = New System.Windows.Forms.TextBox
        Me.TBNama = New System.Windows.Forms.TextBox
        Me.TBUser = New System.Windows.Forms.TextBox
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
        Me.PScreen.Size = New System.Drawing.Size(625, 442)
        Me.PScreen.TabIndex = 2
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
        Me.PForm.Size = New System.Drawing.Size(605, 422)
        Me.PForm.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(10, 233)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(585, 179)
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
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(579, 160)
        Me.DataGridView1.TabIndex = 15
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CekKonf)
        Me.GroupBox1.Controls.Add(Me.CekPass)
        Me.GroupBox1.Controls.Add(Me.BtnTutup)
        Me.GroupBox1.Controls.Add(Me.BtnBatal)
        Me.GroupBox1.Controls.Add(Me.BtnHapus)
        Me.GroupBox1.Controls.Add(Me.BtnSimpan)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.CBLevel)
        Me.GroupBox1.Controls.Add(Me.TBKonf)
        Me.GroupBox1.Controls.Add(Me.TBPass)
        Me.GroupBox1.Controls.Add(Me.TBNama)
        Me.GroupBox1.Controls.Add(Me.TBUser)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(585, 223)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "  Form Inputan  "
        '
        'CekKonf
        '
        Me.CekKonf.AutoSize = True
        Me.CekKonf.Location = New System.Drawing.Point(452, 111)
        Me.CekKonf.Name = "CekKonf"
        Me.CekKonf.Size = New System.Drawing.Size(75, 17)
        Me.CekKonf.TabIndex = 29
        Me.CekKonf.Text = "Tampilkan"
        Me.CekKonf.UseVisualStyleBackColor = True
        '
        'CekPass
        '
        Me.CekPass.AutoSize = True
        Me.CekPass.Location = New System.Drawing.Point(452, 84)
        Me.CekPass.Name = "CekPass"
        Me.CekPass.Size = New System.Drawing.Size(75, 17)
        Me.CekPass.TabIndex = 28
        Me.CekPass.Text = "Tampilkan"
        Me.CekPass.UseVisualStyleBackColor = True
        '
        'BtnTutup
        '
        Me.BtnTutup.Location = New System.Drawing.Point(269, 180)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.Size = New System.Drawing.Size(75, 25)
        Me.BtnTutup.TabIndex = 27
        Me.BtnTutup.Text = "&Tutup"
        Me.BtnTutup.UseVisualStyleBackColor = True
        '
        'BtnBatal
        '
        Me.BtnBatal.Location = New System.Drawing.Point(188, 180)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(75, 25)
        Me.BtnBatal.TabIndex = 26
        Me.BtnBatal.Text = "&Batal"
        Me.BtnBatal.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(107, 180)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(75, 25)
        Me.BtnHapus.TabIndex = 25
        Me.BtnHapus.Text = "&Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Location = New System.Drawing.Point(26, 180)
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
        Me.Label5.Location = New System.Drawing.Point(23, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "LEVEL USER"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(23, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(158, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "KONFIRMASI PASSWORD"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(23, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "PASSWORD"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(23, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "NAMA"
        '
        'CBLevel
        '
        Me.CBLevel.FormattingEnabled = True
        Me.CBLevel.Location = New System.Drawing.Point(195, 134)
        Me.CBLevel.Name = "CBLevel"
        Me.CBLevel.Size = New System.Drawing.Size(216, 21)
        Me.CBLevel.TabIndex = 19
        '
        'TBKonf
        '
        Me.TBKonf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBKonf.Location = New System.Drawing.Point(195, 108)
        Me.TBKonf.MaxLength = 25
        Me.TBKonf.Name = "TBKonf"
        Me.TBKonf.Size = New System.Drawing.Size(216, 20)
        Me.TBKonf.TabIndex = 18
        Me.TBKonf.UseSystemPasswordChar = True
        '
        'TBPass
        '
        Me.TBPass.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBPass.Location = New System.Drawing.Point(195, 82)
        Me.TBPass.MaxLength = 25
        Me.TBPass.Name = "TBPass"
        Me.TBPass.Size = New System.Drawing.Size(216, 20)
        Me.TBPass.TabIndex = 17
        Me.TBPass.UseSystemPasswordChar = True
        '
        'TBNama
        '
        Me.TBNama.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBNama.Location = New System.Drawing.Point(195, 56)
        Me.TBNama.MaxLength = 250
        Me.TBNama.Name = "TBNama"
        Me.TBNama.Size = New System.Drawing.Size(216, 20)
        Me.TBNama.TabIndex = 16
        '
        'TBUser
        '
        Me.TBUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBUser.Location = New System.Drawing.Point(195, 30)
        Me.TBUser.MaxLength = 25
        Me.TBUser.Name = "TBUser"
        Me.TBUser.Size = New System.Drawing.Size(216, 20)
        Me.TBUser.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(23, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "USERNAME"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'f_user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 442)
        Me.Controls.Add(Me.PScreen)
        Me.Name = "f_user"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data User"
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
    Friend WithEvents CekKonf As System.Windows.Forms.CheckBox
    Friend WithEvents CekPass As System.Windows.Forms.CheckBox
    Friend WithEvents BtnTutup As System.Windows.Forms.Button
    Friend WithEvents BtnBatal As System.Windows.Forms.Button
    Friend WithEvents BtnHapus As System.Windows.Forms.Button
    Friend WithEvents BtnSimpan As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CBLevel As System.Windows.Forms.ComboBox
    Friend WithEvents TBKonf As System.Windows.Forms.TextBox
    Friend WithEvents TBPass As System.Windows.Forms.TextBox
    Friend WithEvents TBNama As System.Windows.Forms.TextBox
    Friend WithEvents TBUser As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
