Imports MySql.Data.MySqlClient

Public Class f_alternatif
    Dim IsDataBaru As Boolean

    Private Sub f_alternatif_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CBJenisKelamin.Items.Clear()
        CBJenisKelamin.Items.Insert(0, "0. Jantan")
        CBJenisKelamin.Items.Insert(1, "1. Betina")
        CBJenisKelamin.SelectedIndex = 0

        CBUmur.Items.Clear()
        CBUmur.Items.Insert(0, "18 ≤ 21")
        CBUmur.Items.Insert(1, "22 ≤ 25")
        CBUmur.Items.Insert(2, "26 ≤ 29")
        CBUmur.Items.Insert(3, "30 ≤ 34")
        CBUmur.SelectedIndex = 0

        BtnHapus.Enabled = False
        BtnBatal.Enabled = False

        TampilData()

        KodeBaru()
        TBKode.Focus()
        TBNama.Focus()
    End Sub

    Private Sub KodeBaru()
        MyConn.Close()
        SQL = "SELECT KD_ALTERNATIF FROM T_ALTERNATIF " _
            & "WHERE KD_ALTERNATIF IN (SELECT MAX(KD_ALTERNATIF) FROM T_ALTERNATIF)"
        MyConn.Open()
        MyCommand = New MySql.Data.MySqlClient.MySqlCommand(SQL, MyConn)
        Dim urut As String
        Dim hitung As Long
        MyDataReader = MyCommand.ExecuteReader
        MyDataReader.Read()
        If Not MyDataReader.HasRows Then
            urut = "A" + "001"
        Else
            hitung = Microsoft.VisualBasic.Right(MyDataReader.GetString(0), 3) + 1
            urut = "A" + Microsoft.VisualBasic.Right("000" & hitung, 3)
        End If

        TBKode.Text = urut
    End Sub

    Private Sub TampilData()
        MyConn.Close()
        SQL = "SELECT KD_ALTERNATIF, PETERNAK, NM_ALTERNATIF, " _
            & "CASE WHEN JENKEL=0 THEN 'Jantan' ELSE 'Betina' END AS JENIS_KELAMIN, " _
            & "UMUR, TINGGI_GUMBA, LINGKAR_DADA, PANJANG_BADAN, LINGKAR_SKROTUM " _
            & "FROM T_ALTERNATIF " _
            & "WHERE IS_AKTIF='A' " _
            & "ORDER BY KD_ALTERNATIF"
        MyConn.Open()
        MyDataAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter(SQL, MyConn)
        DS = New DataSet
        MyDataAdapter.Fill(DS, "T_ALTERNATIF")
        DataGridView1.DataSource = DS.Tables("T_ALTERNATIF")

        Try
            'DataGridView1.Columns(0).Width = 50
            'DataGridView1.Columns(1).Width = 150
            'DataGridView1.Columns(2).Width = 150
            DataGridView1.Columns(3).Width = 50
            DataGridView1.Columns(4).Width = 50
            DataGridView1.Columns(5).Width = 50
            DataGridView1.Columns(6).Width = 50
            DataGridView1.Columns(7).Width = 50
            DataGridView1.Columns(8).Width = 50
            DataGridView1.Columns(0).HeaderText = "KODE"
            DataGridView1.Columns(1).HeaderText = "NAMA PETERNAK"
            DataGridView1.Columns(2).HeaderText = "NAMA ALTERNATIF"
            DataGridView1.Columns(3).HeaderText = "JENIS KELAMIN"
            DataGridView1.Columns(4).HeaderText = "UMUR"
            DataGridView1.Columns(5).HeaderText = "TINGGI GUMBA"
            DataGridView1.Columns(6).HeaderText = "LINGKAR DADA"
            DataGridView1.Columns(7).HeaderText = "PANJANG BADAN"
            DataGridView1.Columns(8).HeaderText = "LINGKAR SKROTUM"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BtnTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTutup.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub TBKode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TBKode.KeyDown, TBPeternak.KeyDown, TBNama.KeyDown, CBJenisKelamin.KeyDown, CBUmur.KeyDown, CBGumba.KeyDown, CBBadan.KeyDown, CBDada.KeyDown, CBSkrotum.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            If sender Is TBKode Then
                TBPeternak.Focus()
            ElseIf sender Is TBPeternak Then
                TBNama.Focus()
            ElseIf sender Is TBNama Then
                CBJenisKelamin.Focus()
            ElseIf sender Is CBJenisKelamin Then
                CBUmur.Focus()
            ElseIf sender Is CBUmur Then
                CBGumba.Focus()
            ElseIf sender Is CBGumba Then
                CBBadan.Focus()
            ElseIf sender Is CBBadan Then
                CBDada.Focus()
            ElseIf sender Is CBDada Then
                CBSkrotum.Focus()
            ElseIf sender Is CBSkrotum Then
                BtnSimpan_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub CBJenisKelamin_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBJenisKelamin.SelectedIndexChanged
        If CBJenisKelamin.SelectedIndex = 0 Then 'Kriteria Jantan
            CBGumba.Items.Clear()
            CBGumba.Items.Insert(0, "105 ≤ 109")
            CBGumba.Items.Insert(1, "110 ≤ 114")
            CBGumba.Items.Insert(2, "115 ≤ 119")
            CBGumba.Items.Insert(3, "120 ≤ 127")
            CBGumba.SelectedIndex = 0

            CBDada.Items.Clear()
            CBDada.Items.Insert(0, "142 ≤ 146")
            CBDada.Items.Insert(1, "147 ≤ 154")
            CBDada.Items.Insert(2, "155 ≤ 157")
            CBDada.Items.Insert(3, "158 ≤ 159")
            CBDada.SelectedIndex = 0

            CBBadan.Items.Clear()
            CBBadan.Items.Insert(0, "115 ≤ 119")
            CBBadan.Items.Insert(1, "120 ≤ 124")
            CBBadan.Items.Insert(2, "125 ≤ 133")
            CBBadan.SelectedIndex = 0

            CBSkrotum.Items.Clear()
            CBSkrotum.Items.Insert(0, "25")
            CBSkrotum.Items.Insert(1, "26")
            CBSkrotum.SelectedIndex = 0

            CBSkrotum.Enabled = True
        ElseIf CBJenisKelamin.SelectedIndex = 1 Then 'Kriteria Betina
            CBGumba.Items.Clear()
            CBGumba.Items.Insert(0, "100 ≤ 103")
            CBGumba.Items.Insert(1, "104 ≤ 107")
            CBGumba.Items.Insert(2, "108 ≤ 110")
            CBGumba.SelectedIndex = 0

            CBDada.Items.Clear()
            CBDada.Items.Insert(0, "124 ≤ 129")
            CBDada.Items.Insert(1, "130 ≤ 138")
            CBDada.Items.Insert(2, "139 ≤ 147")
            CBDada.SelectedIndex = 0

            CBBadan.Items.Clear()
            CBBadan.Items.Insert(0, "101 ≤ 104")
            CBBadan.Items.Insert(1, "105 ≤ 110")
            CBBadan.Items.Insert(2, "111 ≤ 114")
            CBBadan.SelectedIndex = 0


            CBSkrotum.Text = ""
            CBSkrotum.Items.Clear()

            CBSkrotum.Enabled = False
        End If
    End Sub

    Dim B_UMUR, B_GUMBA, B_DADA, B_BADAN, B_SKROTUM As String
    Private Sub Pengisian_Bobot()
        Select Case Me.CBUmur.SelectedIndex
            Case 0
                Me.B_UMUR = "2"
            Case 1
                Me.B_UMUR = "3"
            Case 2
                Me.B_UMUR = "4"
            Case 3
                Me.B_UMUR = "5"
        End Select

        Select Case Me.CBGumba.SelectedIndex
            Case 0
                Me.B_GUMBA = "2"
            Case 1
                Me.B_GUMBA = "3"
            Case 2
                Me.B_GUMBA = "4"
            Case 3
                Me.B_GUMBA = "5"
        End Select

        Select Case Me.CBDada.SelectedIndex
            Case 0
                Me.B_DADA = "2"
            Case 1
                Me.B_DADA = "3"
            Case 2
                Me.B_DADA = "4"
            Case 3
                Me.B_DADA = "5"
        End Select

        Select Case Me.CBBadan.SelectedIndex
            Case 0
                Me.B_BADAN = "2"
            Case 1
                Me.B_BADAN = "3"
            Case 2
                Me.B_BADAN = "4"
        End Select

        Select Case Me.CBSkrotum.SelectedIndex
            Case 0
                Me.B_SKROTUM = "2"
            Case 1
                Me.B_SKROTUM = "3"
        End Select
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        ErrorProvider1.Clear()
        If TBKode.Text = "" Then
            ErrorProvider1.SetError(TBKode, "Kode tidak boleh kosong.")
            TBKode.Focus()
        ElseIf TBPeternak.Text = "" Then
            ErrorProvider1.SetError(TBPeternak, "Peternak tidak boleh kosong.")
            TBPeternak.Focus()
        ElseIf TBNama.Text = "" Then
            ErrorProvider1.SetError(TBNama, "Alternatif tidak boleh kosong.")
            TBNama.Focus()
        Else
            'pengisian bobot masing2 alternatif
            Call Pengisian_Bobot()

            MyConn.Close()
            If IsDataBaru = True Then
                SQL = "INSERT INTO T_ALTERNATIF VALUES ('" & TBKode.Text & "'," _
                                                     & "'" & TBNama.Text & "'," _
                                                     & "'" & CBJenisKelamin.SelectedIndex & "'," _
                                                     & "'" & CBUmur.Text & "'," _
                                                     & "'" & CBGumba.Text & "'," _
                                                     & "'" & CBDada.Text & "'," _
                                                     & "'" & CBBadan.Text & "'," _
                                                     & "'" & CBSkrotum.Text & "'," _
                                                     & "'" & TBPeternak.Text & "', " _
                                                     & "'" & CBUmur.SelectedIndex & "'," _
                                                     & "'" & CBGumba.SelectedIndex & "'," _
                                                     & "'" & CBDada.SelectedIndex & "'," _
                                                     & "'" & CBBadan.SelectedIndex & "'," _
                                                     & "'" & CBSkrotum.SelectedIndex & "'," _
                                                     & "'A')"

            ElseIf IsDataBaru = False Then
                SQL = "UPDATE T_ALTERNATIF SET NM_ALTERNATIF='" & TBNama.Text & "'," _
                    & "JENKEL='" & CBJenisKelamin.SelectedIndex & "', " _
                    & "UMUR='" & CBUmur.Text & "', " _
                    & "TINGGI_GUMBA='" & CBGumba.Text & "', " _
                    & "LINGKAR_DADA='" & CBDada.Text & "', " _
                    & "PANJANG_BADAN='" & CBBadan.Text & "', " _
                    & "LINGKAR_SKROTUM='" & CBSkrotum.Text & "', " _
                    & "KD_UMUR='" & CBUmur.SelectedIndex & "', " _
                    & "KD_TINGGI_GUMBA='" & CBGumba.SelectedIndex & "', " _
                    & "KD_LINGKAR_DADA='" & CBDada.SelectedIndex & "', " _
                    & "KD_PANJANG_BADAN='" & CBBadan.SelectedIndex & "', " _
                    & "KD_LINGKAR_SKROTUM='" & CBSkrotum.SelectedIndex & "', " _
                    & "PETERNAK='" & TBPeternak.Text & "' " _
                    & "WHERE KD_ALTERNATIF='" & TBKode.Text & "'"
            End If
            MyConn.Open()
            MyCommand = New MySql.Data.MySqlClient.MySqlCommand(SQL, MyConn)

            Try
                MyCommand.ExecuteNonQuery()
                If IsDataBaru = True Then
                    MsgBox("Data '" & TBKode.Text & "' berhasil ditambahkan.", MsgBoxStyle.Information, "Berhasil")
                ElseIf IsDataBaru = False Then
                    MsgBox("Data '" & TBKode.Text & "' berhasil diperbaharui.", MsgBoxStyle.Information, "Berhasil")
                End If

                TampilData()
                BtnBatal_Click(sender, e)
            Catch ex As MySql.Data.MySqlClient.MySqlException
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Gagal")
            End Try
        End If
    End Sub

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        If TBKode.Text = "" Then
            MsgBox("Tidak ada data yang akan dihapus.", MsgBoxStyle.Exclamation, "Error")
            TBKode.Focus()
        Else
            If MessageBox.Show("Apakah Anda ingin menghapus data '" & TBKode.Text & "' ?", "Konfirmasi", _
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                MyConn.Close()
                SQL = "DELETE FROM T_ALTERNATIF WHERE KD_ALTERNATIF='" & TBKode.Text & "'"
                MyConn.Open()
                MyCommand = New MySql.Data.MySqlClient.MySqlCommand(SQL, MyConn)

                Try
                    MyCommand.ExecuteNonQuery()
                    MsgBox("Data '" & TBKode.Text & "' berhasil dihapus.", MsgBoxStyle.Information, "Berhasil")
                    TampilData()
                    BtnBatal_Click(sender, e)
                Catch ex As MySql.Data.MySqlClient.MySqlException
                    MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Gagal")
                End Try
            End If
        End If
    End Sub

    Private Sub BtnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBatal.Click
        TBKode.Clear()
        TBNama.Clear()
        TBPeternak.Clear()
        CBJenisKelamin.SelectedIndex = 0
        CBUmur.SelectedIndex = 0
        CBGumba.SelectedIndex = 0
        CBDada.SelectedIndex = 0
        CBBadan.SelectedIndex = 0
        CBSkrotum.SelectedIndex = 0

        KodeBaru()
        IsDataBaru = True

        BtnHapus.Enabled = False
        BtnBatal.Enabled = False

        TBPeternak.Focus()
    End Sub

    Private Sub TBKode_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBKode.Leave
        If TBKode.Text <> "" Then
            MyConn.Close()
            SQL = "SELECT * FROM T_ALTERNATIF WHERE KD_ALTERNATIF='" & TBKode.Text & "'"
            MyConn.Open()
            MyCommand = New MySql.Data.MySqlClient.MySqlCommand(SQL, MyConn)
            MyDataReader = MyCommand.ExecuteReader()

            If MyDataReader.HasRows = 0 Then
                TBNama.Clear()
                TBPeternak.Clear()
                CBJenisKelamin.SelectedIndex = 0
                CBUmur.SelectedIndex = 0
                CBGumba.SelectedIndex = 0
                CBDada.SelectedIndex = 0
                CBBadan.SelectedIndex = 0
                CBSkrotum.SelectedIndex = 0

                IsDataBaru = True
                BtnHapus.Enabled = False
                BtnBatal.Enabled = False
            Else
                MyDataReader.Read()
                TBNama.Text = MyDataReader!NM_ALTERNATIF
                TBPeternak.Text = MyDataReader!PETERNAK
                CBJenisKelamin.SelectedIndex = MyDataReader!JENKEL
                CBJenisKelamin_SelectedIndexChanged(sender, e)
                CBUmur.SelectedIndex = MyDataReader!KD_UMUR
                CBGumba.SelectedIndex = MyDataReader!KD_TINGGI_GUMBA
                CBDada.SelectedIndex = MyDataReader!KD_LINGKAR_DADA
                CBBadan.SelectedIndex = MyDataReader!KD_PANJANG_BADAN
                If MyDataReader!JENKEL = "0" Then
                    CBSkrotum.SelectedIndex = MyDataReader!KD_LINGKAR_SKROTUM
                End If

                IsDataBaru = False
                BtnHapus.Enabled = True
                BtnBatal.Enabled = True
            End If
        Else
            TBNama.Clear()
            TBPeternak.Clear()
            CBJenisKelamin.SelectedIndex = 0
            CBUmur.SelectedIndex = 0
            CBGumba.SelectedIndex = 0
            CBDada.SelectedIndex = 0
            CBBadan.SelectedIndex = 0
            CBSkrotum.SelectedIndex = 0

            IsDataBaru = True
            BtnHapus.Enabled = False
            BtnBatal.Enabled = False
        End If
    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        If e.RowIndex >= 0 Then
            If Not IsDBNull(DataGridView1.Rows(e.RowIndex).Cells(1).Value) Then
                TBKode.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
                TBKode_Leave(sender, e)
                TBPeternak.Focus()
            End If
        End If
    End Sub
End Class