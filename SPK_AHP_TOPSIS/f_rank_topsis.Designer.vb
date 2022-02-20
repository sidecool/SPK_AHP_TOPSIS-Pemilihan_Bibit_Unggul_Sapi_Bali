<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_rank_topsis
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.PScreen = New System.Windows.Forms.Panel
        Me.PForm = New System.Windows.Forms.Panel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.DGVBobotKriteria = New System.Windows.Forms.DataGridView
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.LbJenis = New System.Windows.Forms.Label
        Me.CbJenis = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.DGVTopsis = New System.Windows.Forms.DataGridView
        Me.BtnProses = New System.Windows.Forms.Button
        Me.PScreen.SuspendLayout()
        Me.PForm.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGVBobotKriteria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DGVTopsis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PScreen
        '
        Me.PScreen.BackColor = System.Drawing.Color.Transparent
        Me.PScreen.Controls.Add(Me.PForm)
        Me.PScreen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PScreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PScreen.Location = New System.Drawing.Point(0, 0)
        Me.PScreen.Name = "PScreen"
        Me.PScreen.Padding = New System.Windows.Forms.Padding(10)
        Me.PScreen.Size = New System.Drawing.Size(728, 497)
        Me.PScreen.TabIndex = 7
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
        Me.PForm.Size = New System.Drawing.Size(708, 477)
        Me.PForm.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DGVTopsis)
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(268, 299)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(430, 168)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "  Hasil Perankingan TOPSIS "
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DGVBobotKriteria)
        Me.GroupBox3.Controls.Add(Me.Panel3)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(268, 10)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(430, 289)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "  Nilai Bobot Kriteria   "
        '
        'DGVBobotKriteria
        '
        Me.DGVBobotKriteria.AllowUserToAddRows = False
        Me.DGVBobotKriteria.AllowUserToDeleteRows = False
        Me.DGVBobotKriteria.AllowUserToResizeRows = False
        Me.DGVBobotKriteria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVBobotKriteria.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVBobotKriteria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVBobotKriteria.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVBobotKriteria.Location = New System.Drawing.Point(3, 77)
        Me.DGVBobotKriteria.MultiSelect = False
        Me.DGVBobotKriteria.Name = "DGVBobotKriteria"
        Me.DGVBobotKriteria.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DGVBobotKriteria.ShowEditingIcon = False
        Me.DGVBobotKriteria.Size = New System.Drawing.Size(424, 209)
        Me.DGVBobotKriteria.TabIndex = 24
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.LbJenis)
        Me.Panel3.Controls.Add(Me.CbJenis)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(3, 19)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(424, 58)
        Me.Panel3.TabIndex = 23
        '
        'LbJenis
        '
        Me.LbJenis.AutoSize = True
        Me.LbJenis.Location = New System.Drawing.Point(5, 20)
        Me.LbJenis.Name = "LbJenis"
        Me.LbJenis.Size = New System.Drawing.Size(145, 17)
        Me.LbJenis.TabIndex = 23
        Me.LbJenis.Text = "Jenis Kelamin Sapi"
        '
        'CbJenis
        '
        Me.CbJenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbJenis.FormattingEnabled = True
        Me.CbJenis.Location = New System.Drawing.Point(156, 17)
        Me.CbJenis.Name = "CbJenis"
        Me.CbJenis.Size = New System.Drawing.Size(263, 24)
        Me.CbJenis.TabIndex = 22
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RichTextBox1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(258, 457)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "  Informasi  "
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(3, 19)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(252, 435)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = "- Isikan pada baris Atribut antara Benefit dan Cost" & Global.Microsoft.VisualBasic.ChrW(10) & "- Isikan bobot kriteria pada " & _
            "masing-masing kriteria" & Global.Microsoft.VisualBasic.ChrW(10) & "- ...."
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnProses)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 19)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(424, 43)
        Me.Panel1.TabIndex = 24
        '
        'DGVTopsis
        '
        Me.DGVTopsis.AllowUserToAddRows = False
        Me.DGVTopsis.AllowUserToDeleteRows = False
        Me.DGVTopsis.AllowUserToResizeRows = False
        Me.DGVTopsis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVTopsis.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVTopsis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVTopsis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVTopsis.Location = New System.Drawing.Point(3, 62)
        Me.DGVTopsis.MultiSelect = False
        Me.DGVTopsis.Name = "DGVTopsis"
        Me.DGVTopsis.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DGVTopsis.ShowEditingIcon = False
        Me.DGVTopsis.Size = New System.Drawing.Size(424, 103)
        Me.DGVTopsis.TabIndex = 25
        '
        'BtnProses
        '
        Me.BtnProses.Location = New System.Drawing.Point(8, 3)
        Me.BtnProses.Name = "BtnProses"
        Me.BtnProses.Size = New System.Drawing.Size(201, 36)
        Me.BtnProses.TabIndex = 0
        Me.BtnProses.Text = "Proses Perankingan"
        Me.BtnProses.UseVisualStyleBackColor = True
        '
        'f_rank_topsis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 497)
        Me.Controls.Add(Me.PScreen)
        Me.Name = "f_rank_topsis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Perankingan TOPSIS"
        Me.PScreen.ResumeLayout(False)
        Me.PForm.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DGVBobotKriteria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.DGVTopsis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PScreen As System.Windows.Forms.Panel
    Friend WithEvents PForm As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DGVBobotKriteria As System.Windows.Forms.DataGridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents LbJenis As System.Windows.Forms.Label
    Friend WithEvents CbJenis As System.Windows.Forms.ComboBox
    Friend WithEvents DGVTopsis As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BtnProses As System.Windows.Forms.Button
End Class
