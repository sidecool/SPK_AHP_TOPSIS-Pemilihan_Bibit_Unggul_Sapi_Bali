<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_dbconfig
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
        Me.btnTutup = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnSimpan = New System.Windows.Forms.Button
        Me.btnCek = New System.Windows.Forms.Button
        Me.TBDatabase = New System.Windows.Forms.TextBox
        Me.TBPass = New System.Windows.Forms.TextBox
        Me.TBUser = New System.Windows.Forms.TextBox
        Me.TBPort = New System.Windows.Forms.TextBox
        Me.TBServer = New System.Windows.Forms.TextBox
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnTutup
        '
        Me.btnTutup.Location = New System.Drawing.Point(279, 207)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(75, 23)
        Me.btnTutup.TabIndex = 33
        Me.btnTutup.TabStop = False
        Me.btnTutup.Text = "&Tutup"
        Me.btnTutup.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(34, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 13)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "NAMA DATABASE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(34, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "PASSWORD"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(34, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 13)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "USER DATABASE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(34, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "PORT NUMBER"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(34, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "SERVER HOST"
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(198, 207)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 32
        Me.btnSimpan.TabStop = False
        Me.btnSimpan.Text = "&Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnCek
        '
        Me.btnCek.Location = New System.Drawing.Point(37, 207)
        Me.btnCek.Name = "btnCek"
        Me.btnCek.Size = New System.Drawing.Size(122, 23)
        Me.btnCek.TabIndex = 31
        Me.btnCek.TabStop = False
        Me.btnCek.Text = "&Cek Koneksi"
        Me.btnCek.UseVisualStyleBackColor = True
        '
        'TBDatabase
        '
        Me.TBDatabase.Location = New System.Drawing.Point(151, 156)
        Me.TBDatabase.Name = "TBDatabase"
        Me.TBDatabase.Size = New System.Drawing.Size(203, 20)
        Me.TBDatabase.TabIndex = 30
        '
        'TBPass
        '
        Me.TBPass.Location = New System.Drawing.Point(151, 130)
        Me.TBPass.Name = "TBPass"
        Me.TBPass.Size = New System.Drawing.Size(203, 20)
        Me.TBPass.TabIndex = 29
        '
        'TBUser
        '
        Me.TBUser.Location = New System.Drawing.Point(151, 104)
        Me.TBUser.Name = "TBUser"
        Me.TBUser.Size = New System.Drawing.Size(203, 20)
        Me.TBUser.TabIndex = 28
        '
        'TBPort
        '
        Me.TBPort.Location = New System.Drawing.Point(151, 78)
        Me.TBPort.Name = "TBPort"
        Me.TBPort.Size = New System.Drawing.Size(96, 20)
        Me.TBPort.TabIndex = 27
        '
        'TBServer
        '
        Me.TBServer.Location = New System.Drawing.Point(151, 52)
        Me.TBServer.Name = "TBServer"
        Me.TBServer.Size = New System.Drawing.Size(203, 20)
        Me.TBServer.TabIndex = 26
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'f_dbconfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(388, 282)
        Me.Controls.Add(Me.btnTutup)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnCek)
        Me.Controls.Add(Me.TBDatabase)
        Me.Controls.Add(Me.TBPass)
        Me.Controls.Add(Me.TBUser)
        Me.Controls.Add(Me.TBPort)
        Me.Controls.Add(Me.TBServer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "f_dbconfig"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Config Database"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnTutup As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnCek As System.Windows.Forms.Button
    Friend WithEvents TBDatabase As System.Windows.Forms.TextBox
    Friend WithEvents TBPass As System.Windows.Forms.TextBox
    Friend WithEvents TBUser As System.Windows.Forms.TextBox
    Friend WithEvents TBPort As System.Windows.Forms.TextBox
    Friend WithEvents TBServer As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
