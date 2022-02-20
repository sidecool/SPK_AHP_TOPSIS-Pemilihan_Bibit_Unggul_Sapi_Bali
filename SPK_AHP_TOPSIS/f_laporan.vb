Imports MySql.Data.MySqlClient

Public Class f_laporan
    Private SQLText, SQLClause, SQLOrder, SQLLimit As String

    Private Sub f_laporan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CBJenisKelamin.Items.Clear()
        CBJenisKelamin.Items.Insert(0, "0. Jantan")
        CBJenisKelamin.Items.Insert(1, "1. Betina")
        CBJenisKelamin.Items.Insert(2, "2. Keduanya")
        CBJenisKelamin.SelectedIndex = 2

        SQLText = "SELECT * FROM V_LAPORAN"
        SQLClause = ""
        SQLOrder = "ORDER BY TANGGAL, JENKEL, RANK"
        SQLLimit = ""
    End Sub

    Private Sub BtnCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCetak.Click
        SQLClause = "WHERE TANGGAL='" & DateTimePicker1.Text & "'"

        If CBJenisKelamin.SelectedIndex < 2 Then
            SQLClause = SQLClause + " AND JENKEL='" & CBJenisKelamin.SelectedIndex & "'"
        Else
            SQLClause = SQLClause + ""
        End If

        Dim DS As New DSLaporan
        MyConn.Close()
        MyDataAdapter = New MySqlDataAdapter(SQLText & " " & SQLClause & " " & SQLOrder & " " & SQLLimit, MyConn)
        'MsgBox(SQLText & " " & SQLClause & " " & SQLOrder & " " & SQLLimit)        
        MyDataAdapter.Fill(DS, "V_LAPORAN")
        Dim Report As New Laporan
        Report.SetDataSource(DS)
        CrystalReportViewer1.ReportSource = Report
        CrystalReportViewer1.Refresh()
    End Sub
End Class