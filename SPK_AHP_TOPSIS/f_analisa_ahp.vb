Imports MySql.Data.MySqlClient

Public Class f_analisa_ahp

    Dim Loaded As Boolean = False
    Private Sub f_analisa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Loaded = False
        LoadKriteria()
        Loaded = True
    End Sub

    Public Sub LoadPanel(ByVal _Form As System.Windows.Forms.Form)
        PViewer.Controls.Clear()
        For Each FormCtrl As Control In _Form.Controls
            PViewer.Controls.Add(FormCtrl)
        Next
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 0 Then
            Loaded = False
            LoadKriteria()
            Loaded = True            
        ElseIf TabControl1.SelectedIndex = 1 Then
            PViewer.Controls.Clear()
        ElseIf TabControl1.SelectedIndex = 2 Then

        End If
    End Sub

#Region "Analisa Kriteria"

    Dim StrKriteria() As String
    Dim ListKD_KRITERIA As New List(Of String)
    Dim JmlKriteria As Integer = 0

    Private Sub SetPropertiesDGVKriteria()
        With DGVKriteria
            '.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader                
            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
            .AllowUserToOrderColumns = False
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .SelectionMode = DataGridViewSelectionMode.CellSelect
        End With

        For Each colom As DataGridViewColumn In DGVKriteria.Columns
            colom.SortMode = DataGridViewColumnSortMode.NotSortable
            colom.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
    End Sub

    Private Sub SetColumnRowKriteria()
        SQL = "SELECT KD_KRITERIA, NM_KRITERIA FROM T_KRITERIA ORDER BY KD_KRITERIA"

        MyCommand = New MySqlCommand(SQL, MyConn)
        MyDataReader = MyCommand.ExecuteReader
        If Not MyDataReader.HasRows Then
            MsgBox("Anda belum mengisi data kriteria, silahkan isi data kriteria terlebih dahulu.")
            Exit Sub
        End If

        Dim ListKriteria As New List(Of String)

        'Membuat Matriks Perbandingan Berpasangan
        While MyDataReader.Read
            ListKD_KRITERIA.Add(MyDataReader!KD_KRITERIA)
            ListKriteria.Add(MyDataReader!NM_KRITERIA)
            DGVKriteria.Columns.Add(MyDataReader!NM_KRITERIA, MyDataReader!NM_KRITERIA)
        End While

        StrKriteria = ListKriteria.ToArray
        JmlKriteria = ListKriteria.Count
        MyDataReader.Close()
        MyConn.Close()
        MyConn.Open()

        'ComboBox Untuk Semua Kolom
        'For i = 0 To JmlKriteria - 1
        'Dim ComboColumn As New DataGridViewComboBoxColumn
        'With ComboColumn
        'For n = 1 To 9
        '.Items.Add(n)
        'Next
        '.HeaderText = ListKriteria(i).ToString
        '.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox
        'End With
        'DGVKriteria.Columns.AddRange(ComboColumn)
        'Next

        'Membuat Header Row
        DGVKriteria.Rows.Add(JmlKriteria + 1) 'Menambah satu baris untuk baris jumlah
        For i = 0 To JmlKriteria - 1
            DGVKriteria.Rows(i).HeaderCell.Value = DGVKriteria.Columns(i).HeaderText
        Next
        'Membuat header row jumlah
        DGVKriteria.Rows(JmlKriteria).HeaderCell.Value = "Jumlah"
        DGVKriteria.Rows(JmlKriteria).ReadOnly = True        

        'ComboBox untuk baris tertentu        
        For i = 0 To JmlKriteria - 1
            'Merubah warna pada baris Jumlah
            DGVKriteria.Item(i, JmlKriteria).Style.BackColor = Color.LightGray
            For j = i + 1 To JmlKriteria - 1
                Dim ComboColumn As New DataGridViewComboBoxCell
                DGVKriteria.Rows(i).Cells(j) = ComboColumn
                With ComboColumn
                    For n = 1 To 9
                        .Items.Add(n)
                    Next
                    .DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
                End With
            Next
        Next
    End Sub

    Dim KD_BARIS, KD_KOLOM As String
    Dim NewDataReader As MySqlDataReader

    Private Sub LoadKriteria()
        'Set Table Analisa Kriteria
        DGVKriteria.Columns.Clear()
        MyConn.Close()
        MyConn.Open()
        RearConn.Close()
        RearConn.Open()
        SetColumnRowKriteria()
        SetPropertiesDGVKriteria()

        'Menampilkan data dari tabel tcomp_kriteria ke tabel
        For kolom = 0 To DGVKriteria.ColumnCount - 1
            For baris = 0 To DGVKriteria.RowCount - 2
                If Not IsDBNull(DGVKriteria.Item(kolom, baris)) Then
                    KD_KOLOM = ListKD_KRITERIA(kolom)
                    KD_BARIS = ListKD_KRITERIA(baris)

                    'Insert nilai perbandingan kriteria yang sama dengan nilai 1
                    If KD_KOLOM = KD_BARIS Then
                        DGVKriteria.Item(kolom, baris).Value = 1
                        DGVKriteria.Item(kolom, baris).Style.BackColor = Color.LightGray
                        DGVKriteria.Item(kolom, baris).ReadOnly = True

                        SQL = "INSERT INTO TCOMP_KRITERIA(KD_COMP_KRITERIA, KD_KOLOM, KD_BARIS, N_COMPARE) " _
                            & "VALUES (?, ?, ?, ?) ON DUPLICATE KEY UPDATE N_COMPARE=VALUES(N_COMPARE)"
                        MyCommand = New MySqlCommand(SQL, MyConn)
                        MyCommand.Parameters.Add("@KD_COMP_KRITERIA", MySqlDbType.VarString).Value = KD_KOLOM + KD_BARIS
                        MyCommand.Parameters.Add("@KD_KOLOM", MySqlDbType.VarString).Value = KD_KOLOM
                        MyCommand.Parameters.Add("@KD_BARIS", MySqlDbType.VarString).Value = KD_BARIS
                        MyCommand.Parameters.Add("@N_COMPARE", MySqlDbType.Float).Value = Integer.Parse(DGVKriteria.Item(kolom, baris).Value)
                        Try
                            MyCommand.ExecuteNonQuery()
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                        MyConn.Close()
                        MyConn.Open()
                    Else
                        'Membuat kolom readonly dan berwarna lightgray
                        'DGVKriteria.Item(kolom, baris).Style.BackColor = Color.LightGray
                        'DGVKriteria.Item(kolom, baris).ReadOnly = True

                        'Jika sudah punya data nilai untuk perbandingan kriteria yang lain maka akan ditampilkan dengan kode ini
                        SQL = "SELECT N_COMPARE FROM TCOMP_KRITERIA WHERE KD_KOLOM='" & KD_KOLOM & "' AND KD_BARIS='" & KD_BARIS & "'"
                        MyCommand = New MySqlCommand(SQL, RearConn)

                        NewDataReader = MyCommand.ExecuteReader                        
                        If NewDataReader.Read Then
                            Dim Value As Integer
                            If Integer.TryParse(NewDataReader!N_COMPARE, Value) Then                                
                                DGVKriteria.Item(kolom, baris).Value = Integer.Parse(NewDataReader!N_COMPARE)
                            Else                                
                                DGVKriteria.Item(kolom, baris).Value = NewDataReader!N_COMPARE                                
                            End If
                        End If
                        RearConn.Close()
                        RearConn.Open()
                    End If
                End If
            Next

            'Membuat kolom kebalikan menjadi readonly dan berwarna cyan
            For baris = DGVKriteria.RowCount - 2 To kolom + 1 Step -1
                DGVKriteria.Item(kolom, baris).Style.BackColor = Color.Cyan
                DGVKriteria.Item(kolom, baris).ReadOnly = True
            Next
        Next

        'Perhitungan Normalisasi Bobot Kriteria
        NormalisasiBobotKriteria()
        'Mencari Konsistensi Kriteria
        KonsistensiKriteria()
    End Sub

    Private Sub DGVKriteria_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVKriteria.CellValueChanged
        Dim Tot_Baris As Double
        For kolom = 0 To DGVKriteria.ColumnCount - 1
            Tot_Baris = 0
            For baris = 0 To DGVKriteria.RowCount - 2
                Tot_Baris += DGVKriteria.Item(kolom, baris).Value
            Next
            DGVKriteria.Item(kolom, DGVKriteria.RowCount - 1).Value = Tot_Baris
        Next
    End Sub

    Private Sub DGVKriteria_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVKriteria.CellEndEdit
        Dim InputanBaru As Integer = DGVKriteria.Item(e.ColumnIndex, e.RowIndex).Value
        If InputanBaru < 1 Or InputanBaru > 9 Then
            DGVKriteria.Item(e.ColumnIndex, e.RowIndex).Value = InputanLama
            MsgBox("Inputan hanya boleh diisi dengan angka 1 s/d 9")
            Exit Sub
        End If

        KD_KOLOM = ListKD_KRITERIA(e.ColumnIndex)
        KD_BARIS = ListKD_KRITERIA(e.RowIndex)

        If CStr(DGVKriteria.Item(e.ColumnIndex, e.RowIndex).Value) <> "" Then
            SQL = "INSERT INTO TCOMP_KRITERIA(KD_COMP_KRITERIA, KD_KOLOM, KD_BARIS, N_COMPARE) " _
            & "VALUES (?, ?, ?, ?) ON DUPLICATE KEY UPDATE N_COMPARE=VALUES(N_COMPARE)"
            MyCommand = New MySqlCommand(SQL, MyConn)
            MyCommand.Parameters.Add("@KD_COMP_KRITERIA", MySqlDbType.VarString).Value = KD_KOLOM + KD_BARIS
            MyCommand.Parameters.Add("@KD_KOLOM", MySqlDbType.VarString).Value = KD_KOLOM
            MyCommand.Parameters.Add("@KD_BARIS", MySqlDbType.VarString).Value = KD_BARIS
            MyCommand.Parameters.Add("@N_COMPARE", MySqlDbType.Float).Value = Double.Parse(DGVKriteria.Item(e.ColumnIndex, e.RowIndex).Value)
            Try
                MyCommand.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            MyConn.Close()
            MyConn.Open()

            SQL = "SELECT N_COMPARE FROM TCOMP_KRITERIA WHERE KD_KOLOM='" & KD_KOLOM & "' AND KD_BARIS='" & KD_BARIS & "'"
            MyCommand = New MySqlCommand(SQL, RearConn)

            NewDataReader = MyCommand.ExecuteReader
            If NewDataReader.Read Then
                Dim Value As Integer
                If Integer.TryParse(NewDataReader!N_COMPARE, Value) Then
                    DGVKriteria.Item(e.ColumnIndex, e.RowIndex).Value = Integer.Parse(NewDataReader!N_COMPARE)
                Else
                    DGVKriteria.Item(e.ColumnIndex, e.RowIndex).Value = NewDataReader!N_COMPARE
                End If
                'DGVKriteria.Item(e.ColumnIndex, e.RowIndex).Value = Integer.Parse(NewDataReader!N_COMPARE)
            End If
            RearConn.Close()
            RearConn.Open()

            'Insert Kebalikan
            SQL = "INSERT INTO TCOMP_KRITERIA(KD_COMP_KRITERIA, KD_KOLOM, KD_BARIS, N_COMPARE) " _
            & "VALUES (?, ?, ?, ?) ON DUPLICATE KEY UPDATE N_COMPARE=VALUES(N_COMPARE)"
            MyCommand = New MySqlCommand(SQL, MyConn)
            MyCommand.Parameters.Add("@KD_COMP_KRITERIA", MySqlDbType.VarString).Value = KD_BARIS + KD_KOLOM
            MyCommand.Parameters.Add("@KD_KOLOM", MySqlDbType.VarString).Value = KD_BARIS
            MyCommand.Parameters.Add("@KD_BARIS", MySqlDbType.VarString).Value = KD_KOLOM
            MyCommand.Parameters.Add("@N_COMPARE", MySqlDbType.Float).Value = Double.Parse(1 / DGVKriteria.Item(e.ColumnIndex, e.RowIndex).Value)
            Try
                MyCommand.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            MyConn.Close()
            MyConn.Open()

            'Tampil Kebalikan
            RearConn.Close()
            SQL = "SELECT N_COMPARE FROM TCOMP_KRITERIA WHERE KD_KOLOM='" & KD_BARIS & "' AND KD_BARIS='" & KD_KOLOM & "'"
            RearConn.Open()
            MyCommand = New MySqlCommand(SQL, RearConn)

            NewDataReader = MyCommand.ExecuteReader
            If NewDataReader.Read Then
                Dim Value As Integer
                If Integer.TryParse(NewDataReader!N_COMPARE, Value) Then
                    DGVKriteria.Item(e.RowIndex, e.ColumnIndex).Value = Integer.Parse(NewDataReader!N_COMPARE)
                Else
                    DGVKriteria.Item(e.RowIndex, e.ColumnIndex).Value = NewDataReader!N_COMPARE
                End If
                'DGVKriteria.Item(e.RowIndex, e.ColumnIndex).Value = NewDataReader!N_COMPARE
            End If
            RearConn.Close()
            RearConn.Open()
        End If

        NormalisasiBobotKriteria()
        KonsistensiKriteria()

        If LbKonsisten.ForeColor = Color.Red Then
            MsgBox("Nilai yang diinputkan tidak konsisten, Silahkan Revisi inputan Anda.")
            Exit Sub
        End If
    End Sub

    Dim ShowingMessage As String
    Dim BobotPrioritas() As Double
    Private Sub NormalisasiBobotKriteria()
        Dim jmlBaris, jmlKolom As Integer
        jmlBaris = DGVKriteria.ColumnCount
        jmlKolom = DGVKriteria.ColumnCount

        Dim Normalisasi(jmlBaris, jmlKolom) As Double
        ReDim BobotPrioritas(jmlBaris)

        ShowingMessage = ""
        'Menghitung normalisasi bobot kriteria
        For baris = 0 To jmlBaris - 1
            BobotPrioritas(baris) = 0
            For kolom = 0 To jmlKolom - 1
                Normalisasi(baris, kolom) = DGVKriteria.Item(kolom, baris).Value / DGVKriteria.Item(kolom, jmlBaris).Value
                'MsgBox("Baris : " & baris & " Kolom : " & kolom & " Hasil : " & Normalisasi(baris, kolom))
                BobotPrioritas(baris) += Normalisasi(baris, kolom)

                ShowingMessage += "|" & Normalisasi(baris, kolom)
            Next
            BobotPrioritas(baris) = BobotPrioritas(baris) / jmlKolom
            'MsgBox("Baris : " & baris & " Hasil : " & BobotPrioritas(baris))
            ShowingMessage += "|" & BobotPrioritas(baris) & "|" & vbLf
        Next
        'MsgBox(ShowingMessage)
    End Sub

    Private Sub KonsistensiKriteria()
        Dim jmlBaris, jmlKolom As Integer
        jmlBaris = DGVKriteria.ColumnCount
        jmlKolom = DGVKriteria.ColumnCount
        Dim PerkalianBaris As Double
        Dim SumCM As Double
        Dim CM(jmlBaris) As Double 'Consistency Measure
        Dim LamdaMax As Double
        Dim RI As Double 'RatioIndex
        Dim CI As Double 'ConsistencyIndex
        Dim CR As Double 'ConsistencyRatio

        RI = 0
        CI = 0
        SumCM = 0
        For baris = 0 To jmlBaris - 1
            PerkalianBaris = 0
            For kolom = 0 To jmlKolom - 1
                PerkalianBaris += (DGVKriteria.Item(kolom, baris).Value * BobotPrioritas(kolom))
            Next
            CM(baris) = PerkalianBaris / BobotPrioritas(baris)
            SumCM += CM(baris)
        Next

        LamdaMax = SumCM / jmlKolom
        CI = (LamdaMax - jmlKolom) / (jmlKolom - 1)
        RI = getRatioIndex(jmlKolom)
        CR = CI / RI

        TbLamda.Text = LamdaMax
        TbCI.Text = CI
        TbRI.Text = RI

        If CR >= 0 And CR <= 0.1 Then
            LbKonsisten.Text = "Konsisten"
            LbKonsisten.ForeColor = Color.Green
        Else
            LbKonsisten.Text = "Tidak Konsisten"
            LbKonsisten.ForeColor = Color.Red
        End If
    End Sub
#End Region

    Private Function getRatioIndex(ByVal jmlKolom As Integer) As Double
        Select Case jmlKolom
            Case 1 Or 2
                getRatioIndex = 0
            Case 3
                getRatioIndex = 0.58
            Case 4
                getRatioIndex = 0.9
            Case 5
                getRatioIndex = 1.12
            Case 6
                getRatioIndex = 1.24
            Case 7
                getRatioIndex = 1.32
            Case 8
                getRatioIndex = 1.41
            Case 9
                getRatioIndex = 1.46
            Case Else
                getRatioIndex = 1.49
        End Select
    End Function

    Private Sub DGVKriteria_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DGVKriteria.DataError
        If (e.Context = (DataGridViewDataErrorContexts.Formatting Or DataGridViewDataErrorContexts.PreferredSize)) Then
            e.ThrowException = False
        End If
    End Sub

    Dim InputanLama As String
    Private Sub DGVKriteria_CellBeginEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles DGVKriteria.CellBeginEdit
        If sender Is DGVKriteria Then
            InputanLama = DGVKriteria.Item(e.ColumnIndex, e.RowIndex).Value            
        End If
    End Sub

    Private Sub LbKonsisten_ForeColorChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim is_konsisten As String = ""
        'Masukkan hasil konsisten
        If is_konsisten <> "" Then
            SQL = "INSERT INTO TINFO_KONSISTEN(NM_COMPARE, IS_KONSISTEN) " _
            & "VALUES ('TCOMP_KRITERIA', '" & is_konsisten & "') ON DUPLICATE KEY UPDATE IS_KONSISTEN=VALUES(IS_KONSISTEN)"
            MyCommand = New MySqlCommand(SQL, MyConn)
            Try
                MyCommand.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

        MyConn.Close()
        MyConn.Open()
    End Sub


    Private Sub BtnMatriksPerbandinganKriteria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMatriksPerbandinganKriteria.Click, BtnMatriksBobotPrioritasKriteria.Click, BtnKonsistensiKriteria.Click
        LoadPanel(f_proses_ahp)
        If sender Is BtnMatriksPerbandinganKriteria Then
            f_proses_ahp.jenis_panel = "Matriks Perbandingan"
        ElseIf sender Is BtnMatriksBobotPrioritasKriteria Then
            f_proses_ahp.jenis_panel = "Matriks Bobot Prioritas"
        ElseIf sender Is BtnKonsistensiKriteria Then
            f_proses_ahp.jenis_panel = "Konsistensi Kriteria"
            f_proses_ahp.JumlahKriteria = JmlKriteria
            f_proses_ahp.ConsistencyIndex = TbCI.Text
        End If
        f_proses_ahp.LoadForm()
        f_proses_ahp.Dispose()
    End Sub

    Private Sub BtnMatriksAlternatif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMatriksAlternatif.Click, BtnNormalisasiTerbobot.Click, BtnPerankingan.Click
        LoadPanel(f_proses_topsis)
        If sender Is BtnMatriksAlternatif Then
            f_proses_topsis.jenis_panel = "Alternatif"
        ElseIf sender Is BtnNormalisasiTerbobot Then
            BtnPerankingan.Enabled = True
            f_proses_topsis.jenis_panel = "Normalisasi"
        ElseIf sender Is BtnPerankingan Then
            f_proses_topsis.jenis_panel = "Perankingan"
        End If
        If RBJantan.Checked = True Then
            f_proses_topsis.jenis_kelamin = "jantan"
        ElseIf RBBetina.Checked = True Then
            f_proses_topsis.jenis_kelamin = "betina"
        End If
        f_proses_topsis.LoadForm()
        f_proses_topsis.Dispose()
    End Sub

    Private Sub RBJantan_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBJantan.CheckedChanged, RBBetina.CheckedChanged
        If (RBJantan.Checked = True) Or (RBBetina.Checked = True) Then
            BtnMatriksAlternatif.Enabled = True
            BtnNormalisasiTerbobot.Enabled = True
            BtnPerankingan.Enabled = False
        End If
    End Sub
End Class