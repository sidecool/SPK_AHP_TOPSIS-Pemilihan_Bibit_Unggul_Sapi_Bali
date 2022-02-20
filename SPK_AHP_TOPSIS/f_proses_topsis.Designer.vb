<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_proses_topsis
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.PScreen = New System.Windows.Forms.Panel
        Me.PForm = New System.Windows.Forms.Panel
        Me.GBDataViewer = New System.Windows.Forms.GroupBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.GBViewerNormalisasi = New System.Windows.Forms.GroupBox
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.PScreen.SuspendLayout()
        Me.PForm.SuspendLayout()
        Me.GBDataViewer.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBViewerNormalisasi.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PScreen.Size = New System.Drawing.Size(626, 518)
        Me.PScreen.TabIndex = 5
        '
        'PForm
        '
        Me.PForm.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PForm.Controls.Add(Me.GBDataViewer)
        Me.PForm.Controls.Add(Me.GBViewerNormalisasi)
        Me.PForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PForm.Location = New System.Drawing.Point(10, 10)
        Me.PForm.Name = "PForm"
        Me.PForm.Padding = New System.Windows.Forms.Padding(10)
        Me.PForm.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PForm.Size = New System.Drawing.Size(606, 498)
        Me.PForm.TabIndex = 2
        '
        'GBDataViewer
        '
        Me.GBDataViewer.Controls.Add(Me.DataGridView1)
        Me.GBDataViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GBDataViewer.Location = New System.Drawing.Point(10, 10)
        Me.GBDataViewer.Name = "GBDataViewer"
        Me.GBDataViewer.Size = New System.Drawing.Size(586, 182)
        Me.GBDataViewer.TabIndex = 20
        Me.GBDataViewer.TabStop = False
        Me.GBDataViewer.Text = "  Data Viewer  "
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowCellToolTips = False
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(580, 163)
        Me.DataGridView1.TabIndex = 15
        '
        'GBViewerNormalisasi
        '
        Me.GBViewerNormalisasi.Controls.Add(Me.DataGridView2)
        Me.GBViewerNormalisasi.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GBViewerNormalisasi.Location = New System.Drawing.Point(10, 192)
        Me.GBViewerNormalisasi.Name = "GBViewerNormalisasi"
        Me.GBViewerNormalisasi.Size = New System.Drawing.Size(586, 296)
        Me.GBViewerNormalisasi.TabIndex = 19
        Me.GBViewerNormalisasi.TabStop = False
        Me.GBViewerNormalisasi.Text = "  Data Viewer  "
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeColumns = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(3, 16)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.ShowCellToolTips = False
        Me.DataGridView2.ShowEditingIcon = False
        Me.DataGridView2.Size = New System.Drawing.Size(580, 277)
        Me.DataGridView2.TabIndex = 15
        '
        'f_proses_topsis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 518)
        Me.Controls.Add(Me.PScreen)
        Me.Name = "f_proses_topsis"
        Me.Text = "f_proses_topsis"
        Me.PScreen.ResumeLayout(False)
        Me.PForm.ResumeLayout(False)
        Me.GBDataViewer.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBViewerNormalisasi.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PScreen As System.Windows.Forms.Panel
    Friend WithEvents PForm As System.Windows.Forms.Panel
    Friend WithEvents GBViewerNormalisasi As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents GBDataViewer As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
