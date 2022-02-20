Imports MySql.Data.MySqlClient

Public Class f_proses_topsis
    Public jenis_panel As String
    Public jenis_kelamin As String

    Public Sub LoadForm()        
        If jenis_panel = "Alternatif" Then
            GBDataViewer.Visible = True
            GBViewerNormalisasi.Visible = False
            GBDataViewer.Text = "   Matriks Alternatif   "
            GBViewerNormalisasi.Text = "   Matriks Normalisasi   "

            show_alternatif()
        ElseIf jenis_panel = "Normalisasi" Then
            GBDataViewer.Visible = True
            GBViewerNormalisasi.Visible = True
            GBDataViewer.Text = "   Matriks Normalisasi   "
            GBViewerNormalisasi.Text = "   Matriks Normalisasi Terbobot   "

            show_normalisasi()
            show_normalisasi_terbobot()
        ElseIf jenis_panel = "Perankingan" Then
            GBDataViewer.Visible = True
            GBViewerNormalisasi.Visible = True
            GBDataViewer.Text = "   Matriks Solusi Positif & Negatif   "
            GBViewerNormalisasi.Text = "   Perankingan   "

            show_perankingan()
        End If
    End Sub

#Region "Alternatif dan Normalisasi"
    Dim StrKriteria() As String
    Dim StrAlternatif() As String
    Dim ListKD_KRITERIA As New List(Of String)
    Dim ListNM_KRITERIA As New List(Of String)
    Dim ListKD_ALTERNATIF As New List(Of String)
    Dim ListNM_ALTERNATIF As New List(Of String)
    Dim JmlKriteria As Integer = 0
    Dim JmlAlternatif As Integer = 0

    Private Sub show_alternatif()
        'Membuat Kolom
        If jenis_kelamin = "jantan" Then
            SQL = "SELECT KD_KRITERIA, NM_KRITERIA FROM T_KRITERIA ORDER BY KD_KRITERIA"
        ElseIf jenis_kelamin = "betina" Then
            SQL = "SELECT KD_KRITERIA, NM_KRITERIA FROM T_KRITERIA WHERE JENKEL_SAPI='2' ORDER BY KD_KRITERIA"
        End If


        MyCommand = New MySqlCommand(SQL, MyConn)
        MyDataReader = MyCommand.ExecuteReader
        If Not MyDataReader.HasRows Then
            MsgBox("Anda belum mengisi data kriteria, silahkan isi data kriteria terlebih dahulu.")

            Exit Sub
        End If

        'Membuat Header Column
        While MyDataReader.Read
            ListKD_KRITERIA.Add(MyDataReader!KD_KRITERIA)
            ListNM_KRITERIA.Add(MyDataReader!NM_KRITERIA)
            DataGridView1.Columns.Add(MyDataReader!KD_KRITERIA + " " + MyDataReader!NM_KRITERIA, MyDataReader!KD_KRITERIA + vbLf + MyDataReader!NM_KRITERIA)
        End While

        StrKriteria = ListNM_KRITERIA.ToArray
        JmlKriteria = ListNM_KRITERIA.Count
        MyDataReader.Close()
        MyConn.Close()
        MyConn.Open()

        'Membuat Baris
        If jenis_kelamin = "jantan" Then
            SQL = "SELECT KD_ALTERNATIF, NM_ALTERNATIF FROM T_ALTERNATIF WHERE JENKEL='0' AND IS_AKTIF= 'A' ORDER BY KD_ALTERNATIF"
        ElseIf jenis_kelamin = "betina" Then
            SQL = "SELECT KD_ALTERNATIF, NM_ALTERNATIF FROM T_ALTERNATIF WHERE JENKEL='1' AND IS_AKTIF= 'A' ORDER BY KD_ALTERNATIF"
        End If

        MyCommand = New MySqlCommand(SQL, MyConn)
        MyDataReader = MyCommand.ExecuteReader
        If Not MyDataReader.HasRows Then
            MsgBox("Anda belum mengisi data alternatif, silahkan isi data alternatif terlebih dahulu.")
            f_analisa_ahp.BtnNormalisasiTerbobot.Enabled = False
            f_analisa_ahp.BtnPerankingan.Enabled = False
            MyConn.Close()
            MyConn.Open()
            Exit Sub
        End If

        While MyDataReader.Read
            ListKD_ALTERNATIF.Add(MyDataReader!KD_ALTERNATIF)
            ListNM_ALTERNATIF.Add(MyDataReader!NM_ALTERNATIF)
        End While

        StrAlternatif = ListNM_ALTERNATIF.ToArray
        JmlAlternatif = ListNM_ALTERNATIF.Count
        MyDataReader.Close()
        MyConn.Close()
        MyConn.Open()

        'Membuat Header Row
        DataGridView1.Rows.Add(JmlAlternatif)
        For i = 0 To JmlAlternatif - 1
            'Alternatif
            DataGridView1.Rows(i).HeaderCell.Value = "(" + ListKD_ALTERNATIF(i) + ") " + ListNM_ALTERNATIF(i)
        Next

        'Isi Data
        For kolom = 0 To JmlKriteria - 1
            For baris = 0 To JmlAlternatif - 1
                SQL = "SELECT KD_" + ListNM_KRITERIA(kolom).Replace(" ", "_") + " FROM T_ALTERNATIF WHERE KD_ALTERNATIF='" + ListKD_ALTERNATIF(baris) + "'"
                MyCommand = New MySqlCommand(SQL, MyConn)
                MyDataReader = MyCommand.ExecuteReader
                If MyDataReader.HasRows Then
                    While MyDataReader.Read
                        If MyDataReader(0) >= 0 Then
                            'Alternatif (+2 adalah trik karena masing2 kode diberikan +2 sebagai bobot alternatif)
                            DataGridView1.Item(kolom, baris).Value = MyDataReader(0) + 2
                        End If
                    End While
                Else
                    Exit Sub
                End If
                MyDataReader.Close()
                MyConn.Close()
                MyConn.Open()
            Next
        Next

        'Properti DataGridView1
        DataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.SelectAll()
        DataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        For Each colom As DataGridViewColumn In DataGridView1.Columns()
            colom.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
    End Sub
#End Region

#Region "Normalisasi"
    Private Sub show_normalisasi()
        show_alternatif()

        'Kuadrat data
        DataGridView1.Rows.Add(1)
        DataGridView1.Rows(JmlAlternatif).HeaderCell.Value = "Jumlah"
        DataGridView1.Rows(JmlAlternatif).Visible = False
        Dim JumlahKolom As Integer = 0
        Dim Kuadrat(JmlKriteria, JmlAlternatif) As Double
        For kolom = 0 To JmlKriteria - 1
            JumlahKolom = 0
            For baris = 0 To JmlAlternatif - 1
                If DataGridView1.Item(kolom, baris).Value > 0 Then
                    DataGridView1.Item(kolom, baris).Value = DataGridView1.Item(kolom, baris).Value
                    Kuadrat(kolom, baris) = DataGridView1.Item(kolom, baris).Value ^ 2
                End If
                JumlahKolom += Kuadrat(kolom, baris)
            Next
            DataGridView1.Item(kolom, JmlAlternatif).Value = JumlahKolom
        Next

        For kolom = 0 To JmlKriteria - 1
            For baris = 0 To JmlAlternatif - 1
                If DataGridView1.Item(kolom, baris).Value > 0 Then
                    DataGridView1.Item(kolom, baris).Value = DataGridView1.Item(kolom, baris).Value / Math.Sqrt(DataGridView1.Item(kolom, JmlAlternatif).Value)
                End If
            Next            
        Next
    End Sub
#End Region

#Region "Normalisasi Terbobot"
    Private Sub show_normalisasi_terbobot()
        For i = 0 To JmlKriteria - 1
            'Membuat Header Kolom
            DataGridView2.Columns.Add(ListKD_KRITERIA(i) + " " + ListNM_KRITERIA(i), ListKD_KRITERIA(i) + vbLf + ListNM_KRITERIA(i))
        Next

        'Mengeset jumlah row
        DataGridView2.Rows.Add(JmlAlternatif + 1)
        DataGridView2.Rows(0).HeaderCell.Value = "Bobot Kriteria"
        For i = 1 To JmlAlternatif
            'Membuat Header Row
            DataGridView2.Rows(i).HeaderCell.Value = "(" + ListKD_ALTERNATIF(i - 1) + ") " + ListNM_ALTERNATIF(i - 1)
        Next

        SQL = "TRUNCATE T_NORMALISASI_TERBOBOT"
        MyCommand = New MySqlCommand(SQL, MyConn)
        MyCommand.ExecuteNonQuery()
        MyConn.Close()
        MyConn.Open()

        'Isi Data Bobot Prioritas Kriteria
        For kolom = 0 To JmlKriteria - 1            
            SQL = "SELECT BOBOT_PRIORITAS FROM T_BOBOT_PRIORITAS WHERE KD_KRITERIA='" + ListKD_KRITERIA(kolom) + "'"
            MyCommand = New MySqlCommand(SQL, MyConn)
            MyDataReader = MyCommand.ExecuteReader
            If MyDataReader.HasRows Then
                While MyDataReader.Read
                    DataGridView2.Item(kolom, 0).Value = MyDataReader(0)
                End While
            Else
                Exit Sub
            End If
            MyDataReader.Close()
            MyConn.Close()
            MyConn.Open()

            'Isi data normalisasi terbobot            
            For baris = 1 To JmlAlternatif
                If DataGridView1.Item(kolom, baris - 1).Value > 0 Then
                    DataGridView2.Item(kolom, baris).Value = DataGridView1.Item(kolom, baris - 1).Value * DataGridView2.Item(kolom, 0).Value

                    SQL = "INSERT INTO T_NORMALISASI_TERBOBOT VALUES (?, ?, ?) " _
                        & "ON DUPLICATE KEY UPDATE VALUE_CELL=VALUES(VALUE_CELL)"
                    MyCommand = New MySqlCommand(SQL, MyConn)
                    MyCommand.Parameters.Add("@KOLOM", MySqlDbType.VarString).Value = DataGridView2.Columns(kolom).Name
                    MyCommand.Parameters.Add("@BARIS", MySqlDbType.VarString).Value = CStr(baris) + "-" + DataGridView2.Rows(baris).HeaderCell.Value
                    MyCommand.Parameters.Add("@VALUE_CELL", MySqlDbType.Float).Value = DataGridView2.Item(kolom, baris).Value
                    MyCommand.ExecuteNonQuery()
                    MyConn.Close()
                    MyConn.Open()
                End If
            Next
        Next

        show_solusi_ideal()

        'Properti DataGridView2
        DataGridView2.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView2.SelectAll()
        DataGridView2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        For Each colom As DataGridViewColumn In DataGridView2.Columns()
            colom.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
    End Sub
#End Region

#Region "Matriks Solusi Ideal"
    Private Sub show_solusi_ideal()
        'Menambahkan baris solusi ideal
        DataGridView2.Rows.Add(3)
        DataGridView2.Rows(JmlAlternatif + 1).HeaderCell.Value = "ATRIBUT"
        DataGridView2.Rows(JmlAlternatif + 2).HeaderCell.Value = "POSITIF"
        DataGridView2.Rows(JmlAlternatif + 3).HeaderCell.Value = "NEGATIF"

        'Isi Data
        For kolom = 0 To JmlKriteria - 1
            SQL = "SELECT IF(ATRIBUT='0', 'Benefit', 'Cost') FROM T_KRITERIA WHERE KD_KRITERIA='" + ListKD_KRITERIA(kolom) + "'"
            MyCommand = New MySqlCommand(SQL, MyConn)
            MyDataReader = MyCommand.ExecuteReader
            If MyDataReader.HasRows Then
                While MyDataReader.Read
                    DataGridView2.Item(kolom, JmlAlternatif + 1).Value = MyDataReader(0)
                End While
            Else
                Exit Sub
            End If
            MyDataReader.Close()
            MyConn.Close()
            MyConn.Open()

            'Cari nilai maksimal
            Dim Max As Double = 0
            For baris = 1 To JmlAlternatif
                If Max < DataGridView2.Item(kolom, baris).Value Then
                    Max = DataGridView2.Item(kolom, baris).Value
                End If
            Next

            'Cari nilai minimal
            Dim Min As Double = 1.0E+30
            For baris = 1 To JmlAlternatif
                If Min > DataGridView2.Item(kolom, baris).Value Then
                    Min = DataGridView2.Item(kolom, baris).Value
                End If
            Next
            If DataGridView2.Item(kolom, JmlAlternatif + 1).Value = "Benefit" Then
                DataGridView2.Item(kolom, JmlAlternatif + 2).Value = Max
                DataGridView2.Item(kolom, JmlAlternatif + 3).Value = Min
            Else
                DataGridView2.Item(kolom, JmlAlternatif + 2).Value = Min
                DataGridView2.Item(kolom, JmlAlternatif + 3).Value = Max
            End If

            'Baris Positif
            SQL = "INSERT INTO T_NORMALISASI_TERBOBOT VALUES (?, ?, ?) " _
                & "ON DUPLICATE KEY UPDATE VALUE_CELL=VALUES(VALUE_CELL)"
            MyCommand = New MySqlCommand(SQL, MyConn)
            MyCommand.Parameters.Add("@KOLOM", MySqlDbType.VarString).Value = DataGridView2.Columns(kolom).Name
            MyCommand.Parameters.Add("@BARIS", MySqlDbType.VarString).Value = CStr(JmlAlternatif + 1) + "-" + DataGridView2.Rows(JmlAlternatif + 2).HeaderCell.Value
            MyCommand.Parameters.Add("@VALUE_CELL", MySqlDbType.Float).Value = DataGridView2.Item(kolom, JmlAlternatif + 2).Value
            MyCommand.ExecuteNonQuery()
            MyConn.Close()
            MyConn.Open()

            'Baris Negatif
            SQL = "INSERT INTO T_NORMALISASI_TERBOBOT VALUES (?, ?, ?) " _
                & "ON DUPLICATE KEY UPDATE VALUE_CELL=VALUES(VALUE_CELL)"
            MyCommand = New MySqlCommand(SQL, MyConn)
            MyCommand.Parameters.Add("@KOLOM", MySqlDbType.VarString).Value = DataGridView2.Columns(kolom).Name
            MyCommand.Parameters.Add("@BARIS", MySqlDbType.VarString).Value = CStr(JmlAlternatif + 2) + "-" + DataGridView2.Rows(JmlAlternatif + 3).HeaderCell.Value
            MyCommand.Parameters.Add("@VALUE_CELL", MySqlDbType.Float).Value = DataGridView2.Item(kolom, JmlAlternatif + 3).Value
            MyCommand.ExecuteNonQuery()
            MyConn.Close()
            MyConn.Open()
        Next
    End Sub
#End Region

#Region "Perankingan"
    Private Sub show_perankingan()
        'Membuat Header Column
        SQL = "SELECT KOLOM FROM T_NORMALISASI_TERBOBOT GROUP BY KOLOM ORDER BY KOLOM"

        MyCommand = New MySqlCommand(SQL, MyConn)
        MyDataReader = MyCommand.ExecuteReader
        If Not MyDataReader.HasRows Then
            MsgBox("Data tidak ditemukan.")
            Exit Sub
        End If

        While MyDataReader.Read
            DataGridView1.Columns.Add(MyDataReader!KOLOM, MyDataReader!KOLOM)
        End While

        MyDataReader.Close()
        MyConn.Close()
        MyConn.Open()

        'Membuat Header Row
        SQL = "SELECT BARIS FROM T_NORMALISASI_TERBOBOT GROUP BY BARIS"

        MyCommand = New MySqlCommand(SQL, MyConn)
        MyDataReader = MyCommand.ExecuteReader
        If Not MyDataReader.HasRows Then
            MsgBox("Data tidak ditemukan.")
            Exit Sub
        End If

        Dim JumlahBaris As Integer = 0
        Dim ListBaris As New List(Of String)
        While MyDataReader.Read
            JumlahBaris += 1
            ListBaris.Add(MyDataReader!BARIS)
        End While

        DataGridView1.Rows.Add(JumlahBaris)
        For i = 0 To JumlahBaris - 1
            DataGridView1.Rows(i).HeaderCell.Value = ListBaris(i)
        Next        

        MyDataReader.Close()
        MyConn.Close()
        MyConn.Open()

        'Isi Data
        For kolom = 0 To DataGridView1.Columns.Count - 1
            For baris = 0 To DataGridView1.Rows.Count - 1
                SQL = "SELECT VALUE_CELL FROM T_NORMALISASI_TERBOBOT " _
                    & "WHERE KOLOM='" + DataGridView1.Columns(kolom).Name + "'" _
                    & "AND BARIS='" + DataGridView1.Rows(baris).HeaderCell.Value + "'" _
                    & "ORDER BY KOLOM, BARIS"

                MyCommand = New MySqlCommand(SQL, MyConn)
                MyDataReader = MyCommand.ExecuteReader
                
                If MyDataReader.Read Then
                    DataGridView1.Item(kolom, baris).Value = MyDataReader!VALUE_CELL
                End If
                MyDataReader.Close()
                MyConn.Close()
                MyConn.Open()
            Next
        Next

        DataGridView1.Rows(DataGridView1.Rows.Count - 2).HeaderCell.Value = "POSITIF"
        DataGridView1.Rows(DataGridView1.Rows.Count - 1).HeaderCell.Value = "NEGATIF"

        'Properti DataGridView1
        DataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.SelectAll()
        DataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        For Each colom As DataGridViewColumn In DataGridView1.Columns()
            colom.SortMode = DataGridViewColumnSortMode.NotSortable
        Next

        'Membuat tabel preferensi
        'DataGridView2.Columns.Add("Jarak Solusi Ideal Positif", "Jarak Solusi Ideal Positif")
        'DataGridView2.Columns.Add("Jarak Solusi Ideal Negatif", "Jarak Solusi Ideal Negatif")
        'DataGridView2.Columns.Add("Preferensi", "Preferensi")

        'DataGridView2.Rows.Add(JumlahBaris - 2)
        'For i = 0 To JumlahBaris - 3
        'DataGridView2.Rows(i).HeaderCell.Value = ListBaris(i)
        'Next

        'Isi Jarak Solusi Ideal
        For baris = 0 To DataGridView1.Rows.Count - 3
            Dim JSIPositif As Double = 0
            Dim JSINegatif As Double = 0
            For kolom = 0 To DataGridView1.Columns.Count - 1
                JSIPositif += ((DataGridView1.Item(kolom, baris).Value - DataGridView1.Item(kolom, JumlahBaris - 2).Value) ^ 2)
                JSINegatif += ((DataGridView1.Item(kolom, baris).Value - DataGridView1.Item(kolom, JumlahBaris - 1).Value) ^ 2)
            Next

            SQL = "INSERT INTO T_RANKING (KD_ALTERNATIF, POSITIF, NEGATIF, PREFERENSI, TANGGAL) " _
                & "VALUES (?, ?, ?, ?, ?)  ON DUPLICATE KEY UPDATE POSITIF=VALUES(POSITIF), NEGATIF=VALUES(NEGATIF), PREFERENSI=VALUES(PREFERENSI)"
            MyCommand = New MySqlCommand(SQL, MyConn)
            MyCommand.Parameters.Add("@KD_ALTERNATIF", MySqlDbType.String).Value = m_addon.Between(ListBaris(baris), "(", ")")
            MyCommand.Parameters.Add("@POSITIF", MySqlDbType.Float).Value = Double.Parse(Math.Sqrt(JSIPositif))
            MyCommand.Parameters.Add("@NEGATIF", MySqlDbType.Float).Value = Double.Parse(Math.Sqrt(JSINegatif))
            MyCommand.Parameters.Add("@PREFERENSI", MySqlDbType.Float).Value = Double.Parse(Math.Sqrt(JSINegatif) / (Math.Sqrt(JSIPositif) + Math.Sqrt(JSINegatif)))
            MyCommand.Parameters.Add("@TANGGAL", MySqlDbType.Date).Value = Format(Today, "yyyy-MM-dd")
            MyCommand.ExecuteNonQuery()
            MyConn.Close()
            MyConn.Open()

            SQL = "UPDATE T_ALTERNATIF SET IS_AKTIF='N' WHERE KD_ALTERNATIF='" + m_addon.Between(ListBaris(baris), "(", ")") + "'"
            MyCommand = New MySqlCommand(SQL, MyConn)
            MyCommand.ExecuteNonQuery()
            MyConn.Close()
            MyConn.Open()

            'DataGridView2.Rows(baris).HeaderCell.Value = m_addon.Between(DataGridView2.Rows(baris).HeaderCell.Value, "(", ")")
            'DataGridView2.Item(0, baris).Value = Math.Sqrt(JSIPositif)
            'DataGridView2.Item(1, baris).Value = Math.Sqrt(JSINegatif)
            'DataGridView2.Item(2, baris).Value = DataGridView2.Item(1, baris).Value / (DataGridView2.Item(0, baris).Value + DataGridView2.Item(1, baris).Value)
        Next

        'Ranking Topsis        
        Dim JK As String = ""
        If jenis_kelamin = "jantan" Then
            JK = 0
        ElseIf jenis_kelamin = "betina" Then
            JK = 1
        End If

        SQL = "SELECT * FROM T_RANKING WHERE KD_ALTERNATIF IN " _
            & "(SELECT KD_ALTERNATIF FROM T_ALTERNATIF WHERE JENKEL='" & JK & "') " _
            & "AND TANGGAL='" & Format(Today, "yyyy-MM-dd") & "' " _
            & "ORDER BY PREFERENSI DESC"
        MyCommand = New MySqlCommand(SQL, MyConn)
        MyDataReader = MyCommand.ExecuteReader
        Dim rank = 1
        While MyDataReader.Read
            SQL = "UPDATE T_RANKING SET RANK='" & rank & "' WHERE KD_ALTERNATIF='" & MyDataReader!KD_ALTERNATIF & "'"
            MyCommand = New MySqlCommand(SQL, RearConn)
            MyCommand.ExecuteNonQuery()
            rank += 1
            RearConn.Close()
            RearConn.Open()
        End While
        MyConn.Close()
        MyConn.Open()

        'Menampilkan Hasil Perankingan
        SQL = "SELECT RANK, KD_ALTERNATIF, POSITIF, NEGATIF, PREFERENSI, TANGGAL FROM T_RANKING " _
            & "WHERE KD_ALTERNATIF IN (SELECT KD_ALTERNATIF FROM T_ALTERNATIF WHERE JENKEL='" & JK & "') " _
            & "ORDER BY RANK"
        MyDataAdapter = New MySqlDataAdapter(SQL, MyConn)
        DS = New DataSet
        MyDataAdapter.Fill(DS, "T_RANKING")
        DataGridView2.DataSource = DS.Tables("T_RANKING")

        DataGridView2.Columns(0).HeaderText = "RANKING"
        DataGridView2.Columns(1).HeaderText = "ALTERNATIF"
        DataGridView2.Columns(2).HeaderText = "POSITIF"
        DataGridView2.Columns(3).HeaderText = "NEGATIF"
        DataGridView2.Columns(4).HeaderText = "PREFERENSI"

        MyConn.Close()
        MyConn.Open()

        MsgBox("Data Ranking telah disimpan. Anda dapat melihat hasil ranking pada menu laporan." + vbLf _
             & "Data Sapi yang sudah diranking akan dianggap telah selesai perhitungan." + vbLf _
             & "Jika ingin mengulangi Data Sapi yang sama, dapat menginputkan kembali ke Data Alternatif dengan Kode Alternatif yang berbeda.")

        'Properti DataGridView2
        DataGridView2.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView2.SelectAll()
        DataGridView2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        For Each colom As DataGridViewColumn In DataGridView2.Columns()
            colom.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
    End Sub
#End Region

    Private Sub DataGridView1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged, DataGridView2.SelectionChanged
        If sender Is DataGridView1 Then
            DataGridView1.SelectAll()
        ElseIf sender Is DataGridView2 Then
            DataGridView2.SelectAll()
        End If
    End Sub

End Class