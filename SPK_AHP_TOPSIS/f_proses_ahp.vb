Imports MySql.Data.MySqlClient

Public Class f_proses_ahp
    Public jenis_panel As String
    Public JumlahKriteria As Integer
    Public ConsistencyIndex As Double

    Public Sub LoadForm()
        If jenis_panel = "Matriks Perbandingan" Then
            GBDataViewer.Visible = True
            GBInformasi.Visible = False
            GBViewerNormalisasi.Visible = False
            GBDataViewer.Text = "   Matriks Perbandingan Kriteria   "

            show_matriks_perbandingan()
        ElseIf jenis_panel = "Matriks Bobot Prioritas" Then
            GBDataViewer.Visible = False
            GBInformasi.Visible = False
            GBViewerNormalisasi.Visible = True
            GBViewerNormalisasi.Text = "   Matriks Bobot Prioritas Kriteria   "

            show_matriks_perbandingan()
            show_matriks_bobot_prioritas()
        ElseIf jenis_panel = "Konsistensi Kriteria" Then
            GBDataViewer.Visible = True
            GBInformasi.Visible = True
            GBViewerNormalisasi.Visible = False
            GBDataViewer.Text = "   Ordo Matriks - Ratio Index   "

            show_ordomatriks()
        End If
    End Sub

#Region "Matriks Perbandingan"
    Dim StrKriteria() As String
    Dim ListKD_KRITERIA As New List(Of String)
    Dim ListNM_KRITERIA As New List(Of String)
    Dim JmlKriteria As Integer = 0

    Private Sub show_matriks_perbandingan()
        SQL = "SELECT KD_KRITERIA, NM_KRITERIA FROM T_KRITERIA ORDER BY KD_KRITERIA"

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

        'Membuat Header Row
        DataGridView1.Rows.Add(JmlKriteria + 1) 'Menambah satu baris untuk baris jumlah
        For i = 0 To JmlKriteria - 1
            DataGridView1.Rows(i).HeaderCell.Value = ListKD_KRITERIA(i) + " " + ListNM_KRITERIA(i)
            DataGridView1.Rows(i).Height = 50
        Next
        'Membuat header row jumlah
        DataGridView1.Rows(JmlKriteria).HeaderCell.Value = "Jumlah"
        DataGridView1.Rows(JmlKriteria).Height = 50

        'Menampilkan data        
        For kolom = 0 To DataGridView1.ColumnCount - 1
            Dim TotalKolom As Double = 0
            For baris = 0 To DataGridView1.RowCount - 2
                SQL = "SELECT N_COMPARE FROM TCOMP_KRITERIA WHERE KD_KOLOM='" & ListKD_KRITERIA(kolom) & "' AND KD_BARIS='" & ListKD_KRITERIA(baris) & "'"
                MyCommand = New MySqlCommand(SQL, MyConn)

                MyDataReader = MyCommand.ExecuteReader
                If MyDataReader.Read Then
                    Dim Value As Integer
                    If Integer.TryParse(MyDataReader!N_COMPARE, Value) Then
                        DataGridView1.Item(kolom, baris).Value = Integer.Parse(MyDataReader!N_COMPARE)
                    Else
                        DataGridView1.Item(kolom, baris).Value = MyDataReader!N_COMPARE
                    End If
                    TotalKolom += MyDataReader!N_COMPARE
                End If
                MyDataReader.Close()
                MyConn.Close()
                MyConn.Open()
            Next
            DataGridView1.Item(kolom, JmlKriteria).Value = TotalKolom
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

#Region "Matriks Bobot Prioritas"
    Private Sub show_matriks_bobot_prioritas()        
        For i = 0 To JmlKriteria - 1
            'Membuat Header Kolom
            DataGridView2.Columns.Add(ListKD_KRITERIA(i) + " " + ListNM_KRITERIA(i), ListKD_KRITERIA(i) + vbLf + ListNM_KRITERIA(i))
        Next
        'Membuat Header Kolom Bobot Prioritas dan Consistency Measure
        DataGridView2.Columns.Add("Bobot Prioritas", "Bobot Prioritas")
        DataGridView2.Columns.Add("Consistency Measure", "Consistency Measure")

        'Mengeset jumlah row
        DataGridView2.Rows.Add(JmlKriteria)
        For i = 0 To JmlKriteria - 1
            'Membuat Header Row
            DataGridView2.Rows(i).HeaderCell.Value = ListKD_KRITERIA(i) + " " + ListNM_KRITERIA(i)
            DataGridView2.Rows(i).Height = 50
        Next

        'Menampilkan data       
        Dim DataNormalisasi As Double = 0
        Dim DataCellMatriks As Double = 0
        Dim DataTotalKolom As Double = 0
        For kolom = 0 To DataGridView1.ColumnCount - 1            
            For baris = 0 To DataGridView1.RowCount - 2
                DataCellMatriks = DataGridView1.Item(kolom, baris).Value
                DataTotalKolom = DataGridView1.Item(kolom, JmlKriteria).Value

                'Menghitung Normalisasi Bobot tiap Cell
                DataNormalisasi = DataCellMatriks / DataTotalKolom
                DataGridView2.Item(kolom, baris).Value = DataNormalisasi
            Next
        Next

        'Menghitung Bobot Prioritas masing-masing baris
        Dim DataSumCellMatriks As Double = 0
        Dim DataBobotPrioritas As Double = 0
        For baris = 0 To DataGridView2.RowCount - 1
            DataSumCellMatriks = 0
            For kolom = 0 To DataGridView2.ColumnCount - 3
                DataSumCellMatriks += DataGridView2.Item(kolom, baris).Value
            Next
            DataBobotPrioritas = DataSumCellMatriks / JmlKriteria
            DataGridView2.Item(JmlKriteria, baris).Value = DataBobotPrioritas

            SQL = "INSERT INTO T_BOBOT_PRIORITAS VALUES (?, ?) " _
                & "ON DUPLICATE KEY UPDATE BOBOT_PRIORITAS=VALUES(BOBOT_PRIORITAS)"
            MyCommand = New MySqlCommand(SQL, MyConn)
            MyCommand.Parameters.Add("@KD_KRITERIA", MySqlDbType.VarString).Value = ListKD_KRITERIA(baris)
            MyCommand.Parameters.Add("@BOBOT_PRIORITAS", MySqlDbType.Float).Value = DataBobotPrioritas
            MyCommand.ExecuteNonQuery()
            MyConn.Close()
            MyConn.Open()
        Next

        'Menghitung Consistency Measure
        Dim DataPerkalianCellMatriks As Double = 0
        Dim DataConsistencyMeasure As Double = 0
        For baris = 0 To DataGridView2.RowCount - 1            
            DataPerkalianCellMatriks = 0
            For kolom = 0 To DataGridView2.ColumnCount - 3
                DataCellMatriks = DataGridView1.Item(kolom, baris).Value
                DataBobotPrioritas = DataGridView2.Item(JmlKriteria, kolom).Value
                DataPerkalianCellMatriks += (DataCellMatriks * DataBobotPrioritas)
            Next
            DataConsistencyMeasure = DataPerkalianCellMatriks / DataGridView2.Item(JmlKriteria, baris).Value
            DataGridView2.Item(JmlKriteria + 1, baris).Value = DataConsistencyMeasure
        Next

        'Properti DataGridView1
        DataGridView2.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView2.SelectAll()
        DataGridView2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        For Each colom As DataGridViewColumn In DataGridView2.Columns()
            colom.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
    End Sub
#End Region

#Region "Konsistensi Kriteria"
    Public Function getRatioIndex(ByVal jmlKolom As Integer) As String
        Select Case jmlKolom
            Case 1 Or 2
                getRatioIndex = "0"
            Case 3
                getRatioIndex = "0.58"
            Case 4
                getRatioIndex = "0.9"
            Case 5
                getRatioIndex = "1.12"
            Case 6
                getRatioIndex = "1.24"
            Case 7
                getRatioIndex = "1.32"
            Case 8
                getRatioIndex = "1.41"
            Case 9
                getRatioIndex = "1.46"
            Case Else
                getRatioIndex = "1.49"
        End Select
    End Function

    Private Sub show_ordomatriks()
        DataGridView1.Columns.Add("Ordo Matriks", "Ordo Matriks")
        DataGridView1.Columns.Add("1", "1")
        DataGridView1.Columns.Add("2", "2")
        DataGridView1.Columns.Add("3", "3")
        DataGridView1.Columns.Add("4", "4")
        DataGridView1.Columns.Add("5", "5")
        DataGridView1.Columns.Add("6", "6")
        DataGridView1.Columns.Add("7", "7")
        DataGridView1.Columns.Add("8", "8")
        DataGridView1.Columns.Add("9", "9")
        DataGridView1.Columns.Add("10", "10")

        DataGridView1.Rows.Add(1)
        DataGridView1.Item(0, 0).Value = "Ratio Index"
        DataGridView1.Item(1, 0).Value = "0"
        DataGridView1.Item(2, 0).Value = "0"
        DataGridView1.Item(3, 0).Value = "0.58"
        DataGridView1.Item(4, 0).Value = "0.9"
        DataGridView1.Item(5, 0).Value = "1.12"
        DataGridView1.Item(6, 0).Value = "1.24"
        DataGridView1.Item(7, 0).Value = "1.32"
        DataGridView1.Item(8, 0).Value = "1.41"
        DataGridView1.Item(9, 0).Value = "1.46"
        DataGridView1.Item(10, 0).Value = "1.49"

        DataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView1.Rows(0).Height = 50

        Dim is_konsisten As String = ""
        If (ConsistencyIndex / getRatioIndex(JumlahKriteria) > 0) Then
            is_konsisten = " (Konsisten)"
        ElseIf (ConsistencyIndex / getRatioIndex(JumlahKriteria) > 0.1) Then
            is_konsisten = " (Tidak Konsisten)"
        End If

        RichTextBox1.Text = "Consistency Index : " + CStr(ConsistencyIndex) + vbLf _
                          & "Ratio Index : " + getRatioIndex(JumlahKriteria) + vbLf _
                          & "Consistency Ratio : " + CStr(ConsistencyIndex / getRatioIndex(JumlahKriteria)) + is_konsisten
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