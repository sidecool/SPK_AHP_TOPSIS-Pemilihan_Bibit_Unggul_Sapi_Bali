<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_ganti_paswd
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
        Me.BtnTutup = New System.Windows.Forms.Button
        Me.CekTampil = New System.Windows.Forms.CheckBox
        Me.TBPassKonf = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TBPassBaru = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnSimpan = New System.Windows.Forms.Button
        Me.TBPassLama = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PScreen.SuspendLayout()
        Me.PForm.SuspendLayout()
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
        Me.PScreen.Size = New System.Drawing.Size(427, 168)
        Me.PScreen.TabIndex = 2
        '
        'PForm
        '
        Me.PForm.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PForm.Controls.Add(Me.BtnTutup)
        Me.PForm.Controls.Add(Me.CekTampil)
        Me.PForm.Controls.Add(Me.TBPassKonf)
        Me.PForm.Controls.Add(Me.Label3)
        Me.PForm.Controls.Add(Me.TBPassBaru)
        Me.PForm.Controls.Add(Me.Label1)
        Me.PForm.Controls.Add(Me.BtnSimpan)
        Me.PForm.Controls.Add(Me.TBPassLama)
        Me.PForm.Controls.Add(Me.Label2)
        Me.PForm.Location = New System.Drawing.Point(13, 11)
        Me.PForm.Name = "PForm"
        Me.PForm.Size = New System.Drawing.Size(400, 144)
        Me.PForm.TabIndex = 2
        '
        'BtnTutup
        '
        Me.BtnTutup.Location = New System.Drawing.Point(309, 106)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.Size = New System.Drawing.Size(60, 23)
        Me.BtnTutup.TabIndex = 10
        Me.BtnTutup.Text = "&Tutup"
        Me.BtnTutup.UseVisualStyleBackColor = True
        '
        'CekTampil
        '
        Me.CekTampil.AutoSize = True
        Me.CekTampil.Location = New System.Drawing.Point(17, 110)
        Me.CekTampil.Name = "CekTampil"
        Me.CekTampil.Size = New System.Drawing.Size(124, 17)
        Me.CekTampil.TabIndex = 9
        Me.CekTampil.Text = "Tampilkan Password"
        Me.CekTampil.UseVisualStyleBackColor = True
        '
        'TBPassKonf
        '
        Me.TBPassKonf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBPassKonf.Location = New System.Drawing.Point(194, 69)
        Me.TBPassKonf.Name = "TBPassKonf"
        Me.TBPassKonf.Size = New System.Drawing.Size(175, 20)
        Me.TBPassKonf.TabIndex = 8
        Me.TBPassKonf.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(14, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "KONFIRMASI PASSWORD"
        '
        'TBPassBaru
        '
        Me.TBPassBaru.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBPassBaru.Location = New System.Drawing.Point(194, 43)
        Me.TBPassBaru.Name = "TBPassBaru"
        Me.TBPassBaru.Size = New System.Drawing.Size(175, 20)
        Me.TBPassBaru.TabIndex = 6
        Me.TBPassBaru.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(14, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "PASSWORD BARU"
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Location = New System.Drawing.Point(194, 106)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(109, 23)
        Me.BtnSimpan.TabIndex = 4
        Me.BtnSimpan.TabStop = False
        Me.BtnSimpan.Text = "&Ganti Password"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'TBPassLama
        '
        Me.TBPassLama.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBPassLama.Location = New System.Drawing.Point(194, 17)
        Me.TBPassLama.Name = "TBPassLama"
        Me.TBPassLama.Size = New System.Drawing.Size(175, 20)
        Me.TBPassLama.TabIndex = 3
        Me.TBPassLama.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(14, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "PASSWORD LAMA"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'f_ganti_paswd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 168)
        Me.Controls.Add(Me.PScreen)
        Me.Name = "f_ganti_paswd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ganti Password"
        Me.PScreen.ResumeLayout(False)
        Me.PForm.ResumeLayout(False)
        Me.PForm.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PScreen As System.Windows.Forms.Panel
    Friend WithEvents PForm As System.Windows.Forms.Panel
    Friend WithEvents BtnTutup As System.Windows.Forms.Button
    Friend WithEvents CekTampil As System.Windows.Forms.CheckBox
    Friend WithEvents TBPassKonf As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TBPassBaru As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnSimpan As System.Windows.Forms.Button
    Friend WithEvents TBPassLama As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
