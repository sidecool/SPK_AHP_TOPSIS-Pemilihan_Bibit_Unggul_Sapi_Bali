<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_login
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
        Me.BtnLogin = New System.Windows.Forms.Button
        Me.TBPass = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TBUser = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnTutup = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'BtnLogin
        '
        Me.BtnLogin.Location = New System.Drawing.Point(119, 115)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(75, 23)
        Me.BtnLogin.TabIndex = 9
        Me.BtnLogin.TabStop = False
        Me.BtnLogin.Text = "&Login"
        Me.BtnLogin.UseVisualStyleBackColor = True
        '
        'TBPass
        '
        Me.TBPass.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBPass.Location = New System.Drawing.Point(119, 78)
        Me.TBPass.Name = "TBPass"
        Me.TBPass.Size = New System.Drawing.Size(216, 20)
        Me.TBPass.TabIndex = 8
        Me.TBPass.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(23, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "PASSWORD"
        '
        'TBUser
        '
        Me.TBUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBUser.Location = New System.Drawing.Point(119, 42)
        Me.TBUser.Name = "TBUser"
        Me.TBUser.Size = New System.Drawing.Size(216, 20)
        Me.TBUser.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(23, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "USERNAME"
        '
        'BtnTutup
        '
        Me.BtnTutup.Location = New System.Drawing.Point(260, 115)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.Size = New System.Drawing.Size(75, 23)
        Me.BtnTutup.TabIndex = 10
        Me.BtnTutup.Text = "&Tutup"
        Me.BtnTutup.UseVisualStyleBackColor = True
        '
        'f_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(359, 181)
        Me.Controls.Add(Me.BtnTutup)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.TBPass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TBUser)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "f_login"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnLogin As System.Windows.Forms.Button
    Friend WithEvents TBPass As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TBUser As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnTutup As System.Windows.Forms.Button
End Class
