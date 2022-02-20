Imports MySql.Data.MySqlClient

Public Class f_rank_topsis
    Private Sub SetPropertiesDGVBobotAlternatif()
        With DGVBobotKriteria
            '.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader                
            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
            .AllowUserToOrderColumns = False
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .SelectionMode = DataGridViewSelectionMode.CellSelect
        End With

        For Each colom As DataGridViewColumn In DGVBobotKriteria.Columns
            colom.SortMode = DataGridViewColumnSortMode.NotSortable
            colom.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
    End Sub

    Dim JenisKelamin As String
    Dim StrKriteria(), StrAlternatif() As String
    Dim JmlKriteria As Integer = 0
    Dim JmlAlternatif As Integer = 0
    Dim ListKD_KRITERIA As New List(Of String)
    Dim ListKD_ALTERNATIF As New List(Of String)

    Private Function CekKonsistensi() As Boolean
        Dim result As Boolean

        MyConn.Close()
        SQL = "SELECT IS_KONSISTEN FROM TINFO_KONSISTEN"
        MyConn.Open()
        MyCommand = New MySqlCommand(SQL, MyConn)
        MyDataReader = MyCommand.ExecuteReader
        If Not MyDataReader.HasRows Then
            result = False
            Exit Function
        Else
            While MyDataReader.Read
                If MyDataReader!IS_KONSISTEN = "T" Then
                    result = False
                    Exit Function
                Else
                    result = True
                End If
            End While
        End If

        CekKonsistensi = result
    End Function

    Private Sub SetColumnRowBobotAlternatif()
        'Cek Konsistensi
        If CekKonsistensi() = False Then
            MsgBox("Analisa Kriteria dan/atau Analisa Alternatif belum konsisten, silahkan perbaiki nilai analisa keduanya")
            Exit Sub
        End If

        'Membuat Kolom
        MyConn.Close()
        If JenisKelamin = "1" Then
            SQL = "SELECT KD_KRITERIA, NM_KRITERIA FROM T_KRITERIA WHERE JENKEL_SAPI='2' ORDER BY KD_KRITERIA"
        ElseIf JenisKelamin = "0" Then
            SQL = "SELECT KD_KRITERIA, NM_KRITERIA FROM T_KRITERIA ORDER BY KD_KRITERIA"
        End If
        MyConn.Open()
        MyCommand = New MySqlCommand(SQL, MyConn)
        MyDataReader = MyCommand.ExecuteReader
        If Not MyDataReader.HasRows Then
            MsgBox("Anda belum mengisi data kriteria, silahkan isi data kriteria terlebih dahulu.")
            Exit Sub
        End If

        Dim ListKriteria As New List(Of String)

        While MyDataReader.Read
            ListKD_KRITERIA.Add(MyDataReader!KD_KRITERIA)
            ListKriteria.Add(MyDataReader!NM_KRITERIA)
            DGVBobotKriteria.Columns.Add(MyDataReader!NM_KRITERIA, MyDataReader!NM_KRITERIA)
        End While

        StrKriteria = ListKriteria.ToArray
        JmlKriteria = ListKriteria.Count
        MyDataReader.Close()

        'Membuat Baris
        MyConn.Close()
        SQL = "SELECT KD_ALTERNATIF, NM_ALTERNATIF FROM T_ALTERNATIF WHERE JENKEL='" & JenisKelamin & "' " _
            & "AND KD_ALTERNATIF NOT IN (SELECT KD_ALTERNATIF FROM T_RANKING) " _
            & "ORDER BY KD_ALTERNATIF"
        MyConn.Open()
        MyCommand = New MySqlCommand(SQL, MyConn)
        MyDataReader = MyCommand.ExecuteReader
        If Not MyDataReader.HasRows Then
            MsgBox("Anda belum mengisi data alternatif, silahkan isi data alternatif terlebih dahulu.")
            Exit Sub
        End If

        Dim ListAlternatif As New List(Of String)

        ListKD_ALTERNATIF.Clear()
        ListKD_ALTERNATIF.Add(0)
        ListAlternatif.Add("Atribut Kriteria")
        ListKD_ALTERNATIF.Add(1)
        ListAlternatif.Add("Bobot Kriteria")
        Dim i = 2
        While MyDataReader.Read
            ListKD_ALTERNATIF.Add(MyDataReader!KD_ALTERNATIF)
            ListAlternatif.Add(MyDataReader!NM_ALTERNATIF)
            i += 1
        End While

        StrAlternatif = ListAlternatif.ToArray
        JmlAlternatif = ListAlternatif.Count

        DGVBobotKriteria.Rows.Add(JmlAlternatif)
        For baris = 0 To JmlAlternatif - 1
            DGVBobotKriteria.Rows(baris).HeaderCell.Value = ListAlternatif(baris)
            If baris > 1 Then
                DGVBobotKriteria.Rows(baris).ReadOnly = True
            End If
        Next
        MyDataReader.Close()

        'Column Atribut
        For kolom = 0 To JmlKriteria - 1
            Dim ComboColumn As New DataGridViewComboBoxCell
            DGVBobotKriteria.Rows(0).Cells(kolom) = ComboColumn
            ComboColumn.Items.Add("Benefit")
            ComboColumn.Items.Add("Cost")
            ComboColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox
        Next
    End Sub

    Dim NewDataReader As MySqlDataReader
    Dim NormalisasiBobot(,) As Double
    Dim MaxNormal(), MinNormal() As Double

    Private Sub LoadBobotAlternatif()        
        ReDim MaxNormal(JmlKriteria), MinNormal(JmlKriteria)

        RearConn.Close()
        SQL = "SELECT KD_KRITERIA, ATRIBUT, BOBOT_KRITERIA, MAX_NORMALISASI, MIN_NORMALISASI FROM T_NORMALISASI_BOBOT WHERE JENKEL_SAPI='" & JenisKelamin & "'"
        RearConn.Open()
        MyCommand = New MySqlCommand(SQL, RearConn)
        NewDataReader = MyCommand.ExecuteReader
        While NewDataReader.Read()
            For kolom = 0 To JmlKriteria - 1
                If ListKD_KRITERIA(kolom) = NewDataReader!KD_KRITERIA Then
                    DGVBobotKriteria.Item(kolom, 0).Value = NewDataReader!ATRIBUT
                    DGVBobotKriteria.Item(kolom, 1).Value = Double.Parse(NewDataReader!BOBOT_KRITERIA)
                    MaxNormal(kolom) = Double.Parse(NewDataReader!MAX_NORMALISASI)
                    MinNormal(kolom) = Double.Parse(NewDataReader!MIN_NORMALISASI)
                End If
            Next
        End While
        NewDataReader.Close()

        MyConn.Close()
        SQL = "SELECT * FROM T_BOBOT_ALTERNATIF ORDER BY KODE"
        MyConn.Open()
        MyCommand = New MySqlCommand(SQL, MyConn)
        MyDataReader = MyCommand.ExecuteReader
        If Not MyDataReader.HasRows Then
            MsgBox("Data belum lengkap, silahkan melengkapi data pada menu Analisa AHP.")
            Exit Sub
        End If

        While MyDataReader.Read()
            For kolom = 0 To JmlKriteria - 1
                For baris = 2 To JmlAlternatif - 1
                    If ListKD_KRITERIA(kolom) = MyDataReader!KD_KRITERIA And ListKD_ALTERNATIF(baris) = MyDataReader!KD_ALTERNATIF Then
                        DGVBobotKriteria.Item(kolom, baris).Value = MyDataReader!BOBOT_ALTERNATIF
                        DGVBobotKriteria.Item(kolom, baris).Style.BackColor = Color.Cyan
                    End If
                Next
            Next
        End While
    End Sub

    Private Sub f_rank_topsis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ComboSource As New Dictionary(Of String, String)()
        ComboSource.Add("", " --- Pilih Jenis Kelamin --- ")
        ComboSource.Add("0", "0. Jantan")
        ComboSource.Add("1", "1. Betina")
        CbJenis.DataSource = New BindingSource(ComboSource, Nothing)
        CbJenis.DisplayMember = "Value"
        CbJenis.ValueMember = "Key"
    End Sub

    Private Sub DGVBobotKriteria_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs)
        If (e.Context = (DataGridViewDataErrorContexts.Formatting Or DataGridViewDataErrorContexts.PreferredSize)) Then
            e.ThrowException = False
        End If
    End Sub

    Private Sub CbJenis_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbJenis.SelectedIndexChanged
        JenisKelamin = DirectCast(CbJenis.SelectedItem, KeyValuePair(Of String, String)).Key

        DGVBobotKriteria.Columns.Clear()
        DGVTopsis.Columns.Clear()

        If JenisKelamin <> "" Then
            SetColumnRowBobotAlternatif()
            SetPropertiesDGVBobotAlternatif()
            If JmlAlternatif <> 0 Then
                LoadBobotAlternatif()
            End If
        End If
    End Sub

    Private Sub DGVBobotKriteria_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVBobotKriteria.CellEndEdit
        RearConn.Close()
        SQL = "SELECT ATRIBUT, BOBOT_KRITERIA FROM T_NORMALISASI_BOBOT WHERE KD_KRITERIA='" & ListKD_KRITERIA(e.ColumnIndex) & "' AND KD_BARIS='0' AND JENKEL_SAPI='" & JenisKelamin & "'"
        RearConn.Open()
        MyCommand = New MySqlCommand(SQL, RearConn)

        NewDataReader = MyCommand.ExecuteReader
        If NewDataReader.Read Then
            DGVBobotKriteria.Item(e.ColumnIndex, 0).Value = NewDataReader!ATRIBUT
            DGVBobotKriteria.Item(e.ColumnIndex, 1).Value = Double.Parse(NewDataReader!BOBOT_KRITERIA)
        End If
    End Sub

#Region "TOPSIS"
    Private Sub TOPSIS()
        ReDim NormalisasiBobot(JmlKriteria, JmlAlternatif)
        ReDim MaxNormal(JmlKriteria), MinNormal(JmlKriteria)

        For column = 0 To DGVBobotKriteria.ColumnCount - 1
            Dim bobot As Double = DGVBobotKriteria.Item(column, 1).Value
            If CStr(bobot) <> "" Then
                'Perkalian Normalisasi Bobot
                For baris = 2 To JmlAlternatif - 1
                    NormalisasiBobot(column, baris) = bobot * DGVBobotKriteria.Item(column, baris).Value
                Next

                'Mencari Nilai Maximal
                Dim tempMax As Double = 0
                For baris = 2 To JmlAlternatif - 1
                    If tempMax < NormalisasiBobot(column, baris) Then
                        tempMax = NormalisasiBobot(column, baris)
                    End If
                Next
                MaxNormal(column) = tempMax

                Dim tempMin As Double = MaxNormal(column)
                'Mencari Nilai Minimal
                For baris = 2 To JmlAlternatif - 1
                    If tempMin > NormalisasiBobot(column, baris) Then
                        tempMin = NormalisasiBobot(column, baris)
                    End If
                Next
                MinNormal(column) = tempMin

                MyConn.Close()
                SQL = "INSERT INTO T_NORMALISASI_BOBOT(KODE, KD_KRITERIA, KD_BARIS, ATRIBUT, BOBOT_KRITERIA, MAX_NORMALISASI, MIN_NORMALISASI, JENKEL_SAPI) " _
                    & "VALUES (?, ?, ?, ?, ?, ?, ?, ?) ON DUPLICATE KEY UPDATE ATRIBUT=VALUES(ATRIBUT), BOBOT_KRITERIA=VALUES(BOBOT_KRITERIA), MAX_NORMALISASI=VALUES(MAX_NORMALISASI), MIN_NORMALISASI=VALUES(MIN_NORMALISASI), JENKEL_SAPI=VALUES(JENKEL_SAPI)"
                MyConn.Open()
                MyCommand = New MySqlCommand(SQL, MyConn)
                MyCommand.Parameters.Add("@KODE", MySqlDbType.VarString).Value = ListKD_KRITERIA(column) + ListKD_ALTERNATIF(0) + JenisKelamin
                MyCommand.Parameters.Add("@KD_KRITERIA", MySqlDbType.VarString).Value = ListKD_KRITERIA(column)
                MyCommand.Parameters.Add("@KD_BARIS", MySqlDbType.VarString).Value = ListKD_ALTERNATIF(0)
                MyCommand.Parameters.Add("@ATRIBUT", MySqlDbType.VarString).Value = DGVBobotKriteria.Item(column, 0).Value
                MyCommand.Parameters.Add("@BOBOT_KRITERIA", MySqlDbType.Float).Value = Double.Parse(bobot)
                MyCommand.Parameters.Add("@MAX_NORMALISASI", MySqlDbType.Float).Value = Double.Parse(MaxNormal(column))
                MyCommand.Parameters.Add("@MIN_NORMALISASI", MySqlDbType.Float).Value = Double.Parse(MinNormal(column))
                MyCommand.Parameters.Add("@JENKEL_SAPI", MySqlDbType.VarString).Value = JenisKelamin
                Try
                    MyCommand.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                'Mencari Nilai Positif dan Negatif
                Dim Positif(JmlKriteria), Negatif(JmlKriteria) As Double

                If CStr(DGVBobotKriteria.Item(column, 0).Value) = "Benefit" Then
                    Positif(column) = MaxNormal(column)
                    Negatif(column) = MinNormal(column)
                ElseIf CStr(DGVBobotKriteria.Item(column, 0).Value) = "Cost" Then
                    Positif(column) = MinNormal(column)
                    Negatif(column) = MaxNormal(column)
                End If

                'Hitung Jarak Ideal Positif            
                Dim JarakPositif(JmlKriteria, JmlAlternatif) As Double
                For baris = 2 To JmlAlternatif - 1
                    JarakPositif(column, baris) = (DGVBobotKriteria.Item(column, baris).Value - Positif(column)) ^ 2
                Next
                Dim TotalPositif(JmlAlternatif) As Double
                If JarakPositif(JmlKriteria - 1, JmlAlternatif - 1) <> 0 Then
                    For baris = 2 To JmlAlternatif - 1
                        TotalPositif(baris) = 0
                        For kolom = 0 To JmlKriteria - 1
                            TotalPositif(baris) += JarakPositif(kolom, baris)
                        Next
                        TotalPositif(baris) = Math.Sqrt(TotalPositif(baris))
                    Next
                End If

                'Hitung Jarak Ideal Negatif
                Dim JarakNegatif(JmlKriteria, JmlAlternatif) As Double
                For baris = 2 To JmlAlternatif - 1
                    JarakNegatif(column, baris) = (DGVBobotKriteria.Item(column, baris).Value - Negatif(column)) ^ 2
                Next
                Dim TotalNegatif(JmlAlternatif) As Double
                If JarakNegatif(JmlKriteria - 1, JmlAlternatif - 1) <> 0 Then
                    For baris = 2 To JmlAlternatif - 1
                        TotalNegatif(baris) = 0
                        For kolom = 0 To JmlKriteria - 1
                            TotalNegatif(baris) += JarakNegatif(kolom, baris)
                        Next
                        TotalNegatif(baris) = Math.Sqrt(TotalNegatif(baris))
                    Next
                End If

                'Hitung Preferensi            
                Dim Preferensi(JmlAlternatif) As Double
                For baris = 2 To JmlAlternatif
                    If TotalPositif(baris) <> 0 And TotalNegatif(baris) <> 0 Then
                        Preferensi(baris) = TotalNegatif(baris) / (TotalPositif(baris) + TotalNegatif(baris))

                        MyConn.Close()
                        SQL = "INSERT INTO T_RANKING (KD_ALTERNATIF, POSITIF, NEGATIF, PREFERENSI, TANGGAL) " _
                            & "VALUES (?, ?, ?, ?, ?)  ON DUPLICATE KEY UPDATE POSITIF=VALUES(POSITIF), NEGATIF=VALUES(NEGATIF), PREFERENSI=VALUES(PREFERENSI)"
                        MyConn.Open()
                        MyCommand = New MySqlCommand(SQL, MyConn)
                        MyCommand.Parameters.Add("@KD_ALTERNATIF", MySqlDbType.String).Value = ListKD_ALTERNATIF(baris)
                        MyCommand.Parameters.Add("@POSITIF", MySqlDbType.Float).Value = Double.Parse(TotalPositif(baris))
                        MyCommand.Parameters.Add("@NEGATIF", MySqlDbType.Float).Value = Double.Parse(TotalNegatif(baris))
                        MyCommand.Parameters.Add("@PREFERENSI", MySqlDbType.Float).Value = Double.Parse(Preferensi(baris))
                        MyCommand.Parameters.Add("@TANGGAL", MySqlDbType.Date).Value = Format(Today, "yyyy-MM-dd")
                        Try
                            MyCommand.ExecuteNonQuery()
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                    End If
                Next

                'Ranking Topsis
                MyConn.Close()
                SQL = "SELECT * FROM T_RANKING WHERE KD_ALTERNATIF IN " _
                    & "(SELECT KD_ALTERNATIF FROM T_ALTERNATIF WHERE JENKEL='" & JenisKelamin & "') " _
                    & "AND TANGGAL='" & Format(Today, "yyyy-MM-dd") & "' " _
                    & "ORDER BY PREFERENSI DESC"
                MyConn.Open()
                MyCommand = New MySqlCommand(SQL, MyConn)
                MyDataReader = MyCommand.ExecuteReader
                Dim rank = 1
                While MyDataReader.Read
                    RearConn.Close()
                    SQL = "UPDATE T_RANKING SET RANK='" & rank & "' WHERE KD_ALTERNATIF='" & MyDataReader!KD_ALTERNATIF & "'"
                    RearConn.Open()
                    MyCommand = New MySqlCommand(SQL, RearConn)
                    MyCommand.ExecuteNonQuery()
                    rank += 1
                End While
            End If
        Next        
    End Sub
#End Region

    Private Sub BtnProses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProses.Click
        For column = 0 To DGVBobotKriteria.ColumnCount - 1
            For row = 0 To DGVBobotKriteria.RowCount - 1
                If CStr(DGVBobotKriteria.Item(column, row).Value) = "" Then
                    MsgBox("Tabel Bobot Kriteria belum lengkap, silahkan lengkapi terlebih dahulu.")
                    Exit Sub
                Else
                    'Perankingan TOPSIS
                    TOPSIS()

                    'Menampilkan Hasil Perankingan
                    MyConn.Close()
                    SQL = "SELECT RANK, KD_ALTERNATIF, POSITIF, NEGATIF, PREFERENSI, TANGGAL FROM T_RANKING " _
                        & "WHERE KD_ALTERNATIF IN (SELECT KD_ALTERNATIF FROM T_ALTERNATIF WHERE JENKEL='" & JenisKelamin & "') " _
                        & "AND TANGGAL='" & Format(Today, "yyyy-MM-dd") & "' " _
                        & "ORDER BY RANK"
                    MyConn.Open()
                    MyDataAdapter = New MySqlDataAdapter(SQL, MyConn)
                    DS = New DataSet
                    MyDataAdapter.Fill(DS, "T_RANKING")
                    DGVTopsis.DataSource = DS.Tables("T_RANKING")

                    Try
                        DGVTopsis.Columns(0).HeaderText = "RANKING"
                        DGVTopsis.Columns(1).HeaderText = "ALTERNATIF"
                        DGVTopsis.Columns(2).HeaderText = "POSITIF"
                        DGVTopsis.Columns(3).HeaderText = "NEGATIF"
                        DGVTopsis.Columns(4).HeaderText = "PREFERENSI"
                    Catch ex As Exception
                    End Try

                    With DGVTopsis
                        '.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader                
                        .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
                        .AllowUserToOrderColumns = False
                        .AllowUserToAddRows = False
                        .AllowUserToDeleteRows = False
                        .SelectionMode = DataGridViewSelectionMode.CellSelect
                    End With

                    For Each colom As DataGridViewColumn In DGVTopsis.Columns
                        colom.SortMode = DataGridViewColumnSortMode.NotSortable
                        colom.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Next
                End If
            Next
        Next
    End Sub
End Class