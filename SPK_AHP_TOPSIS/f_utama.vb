Public Class f_utama

    Private Sub f_utama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Sistem Pendukung Keputusan - Pemilihan Bibit Unggul Sapi Bali"
        MenuStrip1.Visible = False

        ToolStripStatusLabel1.Text = "Tanggal : " & Format(Date.Today, "dd/MM/yyyy")
        ToolStripStatusLabel3.Visible = False
        Timer1.Start()

        'menyiapkan string untuk menampung lokasi file .ini 
        Dim FilePath As String = Application.StartupPath & "\setting.ini"

        Dim Server = ReadIni(FilePath, "ConfigDB", "Server", "")
        Dim Port = ReadIni(FilePath, "ConfigDB", "Port", "")
        Dim User = ReadIni(FilePath, "ConfigDB", "User", "")
        Dim Pass = ReadIni(FilePath, "ConfigDB", "Password", "")
        Dim DBName = ReadIni(FilePath, "ConfigDB", "DBName", "")

        If cek_koneksi(Server, Port, User, Pass, DBName) = True Then
            f_login.ShowDialog()
        Else
            f_dbconfig.ShowDialog()
            MsgBox("Database tidak ditemukan.", MsgBoxStyle.Exclamation, "Error Database")
            End
        End If        
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel2.Text = "Jam : " & Format(TimeOfDay, "hh:mm:ss")
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        MenuStrip1.Visible = False
        ToolStripStatusLabel3.Text = "Login as : "
        ToolStripStatusLabel3.Visible = False

        For Each frm As Form In Me.MdiChildren
            frm.Close()
        Next

        f_login.ShowDialog()
    End Sub

    Public Sub LogoutClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LogoutToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub DataUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataUserToolStripMenuItem.Click
        For Each frm As Form In Me.MdiChildren
            frm.Close()
        Next

        f_user.MdiParent = Me
        f_user.Show()        
    End Sub

    Private Sub GantiPasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GantiPasswordToolStripMenuItem.Click
        For Each frm As Form In Me.MdiChildren
            frm.Close()
        Next

        f_ganti_paswd.MdiParent = Me
        f_ganti_paswd.Show()
    End Sub

    Private Sub LaporanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanToolStripMenuItem.Click
        For Each frm As Form In Me.MdiChildren
            frm.Close()
        Next

        f_laporan.MdiParent = Me
        f_laporan.WindowState = FormWindowState.Maximized
        f_laporan.Show()
    End Sub

    Private Sub DataAlternatifSapiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataAlternatifSapiToolStripMenuItem.Click
        For Each frm As Form In Me.MdiChildren
            frm.Close()
        Next

        f_alternatif.MdiParent = Me
        f_alternatif.Show()
    End Sub

    Private Sub DataKriteriaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataKriteriaToolStripMenuItem.Click
        For Each frm As Form In Me.MdiChildren
            frm.Close()
        Next

        f_kriteria.MdiParent = Me
        f_kriteria.Show()
    End Sub

    Private Sub AnalisaAHPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnalisaAHPToolStripMenuItem.Click
        For Each frm As Form In Me.MdiChildren
            frm.Close()
        Next

        f_analisa_ahp.MdiParent = Me
        f_analisa_ahp.WindowState = FormWindowState.Maximized
        f_analisa_ahp.Show()
    End Sub

    Private Sub PerankinganTOPSISToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PerankinganTOPSISToolStripMenuItem.Click
        For Each frm As Form In Me.MdiChildren
            frm.Close()
        Next

        f_rank_topsis.MdiParent = Me
        f_rank_topsis.WindowState = FormWindowState.Maximized
        f_rank_topsis.Show()
    End Sub
End Class
