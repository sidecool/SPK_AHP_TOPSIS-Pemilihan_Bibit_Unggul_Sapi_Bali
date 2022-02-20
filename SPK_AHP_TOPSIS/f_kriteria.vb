Public Class f_kriteria
    Dim IsDataBaru As Boolean

    Private Sub f_kriteria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CBJenisKelamin.Items.Clear()
        CBJenisKelamin.Items.Insert(0, "0. Jantan")
        CBJenisKelamin.Items.Insert(1, "1. Betina")
        CBJenisKelamin.Items.Insert(2, "2. Keduanya")
        CBJenisKelamin.SelectedIndex = 0

        CBAtribut.Items.Clear()
        CBAtribut.Items.Insert(0, "0. Benefit")
        CBAtribut.Items.Insert(1, "1. Cost")
        CBAtribut.SelectedIndex = 0

        BtnHapus.Enabled = False
        BtnBatal.Enabled = False

        TampilData()

        KodeBaru()
        TBKode.Focus()
        TBNama.Focus()
    End Sub

    Private Sub KodeBaru()
        MyConn.Close()
        SQL = "SELECT KD_KRITERIA FROM T_KRITERIA " _
            & "WHERE KD_KRITERIA IN (SELECT MAX(KD_KRITERIA) FROM T_KRITERIA)"
        MyConn.Open()
        MyCommand = New MySql.Data.MySqlClient.MySqlCommand(SQL, MyConn)
        Dim urut As String
        Dim hitung As Long
        MyDataReader = MyCommand.ExecuteReader
        MyDataReader.Read()
        If Not MyDataReader.HasRows Then
            urut = "C" + "001"
        Else
            hitung = Microsoft.VisualBasic.Right(MyDataReader.GetString(0), 3) + 1
            urut = "C" + Microsoft.VisualBasic.Right("000" & hitung, 3)
        End If

        TBKode.Text = urut
    End Sub

    Private Sub TampilData()
        MyConn.Close()
        SQL = "SELECT KD_KRITERIA, NM_KRITERIA, " _
            & "CASE WHEN JENKEL_SAPI=0 THEN 'Jantan' " _
            & "WHEN JENKEL_SAPI=1 THEN 'Betina' " _
            & "ELSE 'Keduanya' END AS JENIS_KELAMIN, " _
            & "CASE WHEN ATRIBUT=0 THEN 'Benefit' " _
            & "ELSE 'Cost' END AS ATRIBUT, BOBOT " _
            & "FROM T_KRITERIA ORDER BY KD_KRITERIA"
        MyConn.Open()
        MyDataAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter(SQL, MyConn)
        DS = New DataSet
        MyDataAdapter.Fill(DS, "T_KRITERIA")
        DataGridView1.DataSource = DS.Tables("T_KRITERIA")

        DataGridView1.Columns(0).Width = 50
        'DataGridView1.Columns(1).Width = 250
        'DataGridView1.Columns(2).Width = 100
        'DataGridView1.Columns(3).Width = 100
        DataGridView1.Columns(0).HeaderText = "KODE"
        DataGridView1.Columns(1).HeaderText = "NAMA KRITERIA"
        DataGridView1.Columns(2).HeaderText = "JENIS KELAMIN SAPI"
        DataGridView1.Columns(2).HeaderCell.Style.WrapMode = DataGridViewTriState.True
        DataGridView1.Columns(3).HeaderText = "ATRIBUT"
        DataGridView1.Columns(4).HeaderText = "BOBOT"
    End Sub

    Private Sub BtnTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTutup.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub TBKode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TBKode.KeyDown, TBNama.KeyDown, CBJenisKelamin.KeyDown, CBAtribut.KeyDown, TBBobot.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            If sender Is TBKode Then
                TBNama.Focus()
            ElseIf sender Is TBNama Then
                CBJenisKelamin.Focus()
            ElseIf sender Is CBJenisKelamin Then
                CBAtribut.Focus()
            ElseIf sender Is CBAtribut Then
                TBBobot.Focus()
            ElseIf sender Is TBBobot Then
                BtnSimpan_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        ErrorProvider1.Clear()
        If TBKode.Text = "" Then
            ErrorProvider1.SetError(TBKode, "Kode tidak boleh kosong.")
            TBKode.Focus()
        ElseIf TBNama.Text = "" Then
            ErrorProvider1.SetError(TBNama, "Kriteria tidak boleh kosong.")
            TBNama.Focus()
        ElseIf TBBobot.Text = "" Then
            ErrorProvider1.SetError(TBBobot, "Bobot tidak boleh kosong.")
            TBBobot.Focus()
        Else
            MyConn.Close()
            If IsDataBaru = True Then
                SQL = "INSERT INTO T_KRITERIA VALUES ('" & TBKode.Text & "'," _
                                                   & "'" & TBNama.Text & "'," _
                                                   & "'" & CBJenisKelamin.SelectedIndex & "'," _
                                                   & "'" & CBAtribut.SelectedIndex & "'," _
                                                   & "'" & TBBobot.Text & "')"
            ElseIf IsDataBaru = False Then
                SQL = "UPDATE T_KRITERIA SET NM_KRITERIA='" & TBNama.Text & "', " _
                    & "JENKEL_SAPI='" & CBJenisKelamin.SelectedIndex & "', " _
                    & "ATRIBUT='" & CBAtribut.SelectedIndex & "', " _
                    & "BOBOT=" & TBBobot.Text & " " _
                    & "WHERE KD_KRITERIA='" & TBKode.Text & "'"
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
                SQL = "DELETE FROM T_KRITERIA WHERE KD_KRITERIA='" & TBKode.Text & "'"
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
        CBJenisKelamin.SelectedIndex = 0
        CBAtribut.SelectedIndex = 0
        TBBobot.Clear()
        KodeBaru()
        IsDataBaru = True

        BtnHapus.Enabled = False
        BtnBatal.Enabled = False

        TBNama.Focus()
    End Sub

    Private Sub TBKode_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBKode.Leave
        If TBKode.Text <> "" Then
            MyConn.Close()
            SQL = "SELECT * FROM T_KRITERIA WHERE KD_KRITERIA='" & TBKode.Text & "'"
            MyConn.Open()
            MyCommand = New MySql.Data.MySqlClient.MySqlCommand(SQL, MyConn)
            MyDataReader = MyCommand.ExecuteReader()

            If MyDataReader.HasRows = 0 Then
                TBNama.Clear()
                CBJenisKelamin.SelectedIndex = 0
                CBAtribut.SelectedIndex = 0
                TBBobot.Clear()
                IsDataBaru = True
                BtnHapus.Enabled = False
                BtnBatal.Enabled = False
            Else
                MyDataReader.Read()
                TBNama.Text = MyDataReader!NM_KRITERIA
                CBJenisKelamin.SelectedIndex = MyDataReader!JENKEL_SAPI
                CBAtribut.SelectedIndex = MyDataReader!ATRIBUT
                TBBobot.Text = MyDataReader!BOBOT
                IsDataBaru = False
                BtnHapus.Enabled = True
                BtnBatal.Enabled = True
            End If
        Else
            TBNama.Clear()
            CBJenisKelamin.SelectedIndex = 0
            CBAtribut.SelectedIndex = 0
            TBBobot.Clear()
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
                TBNama.Focus()
            End If
        End If
    End Sub

    Private Sub TBBobot_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBBobot.KeyPress
        Select Case e.KeyChar
            Case CChar(vbBack) 'JIKA TOMBOL BACKSPACE
                e.Handled = False 'LANJUT INPUT
            Case "0"c, "1"c, "2"c, "3"c, "4"c, "5"c, "6"c, "7"c, "8"c, "9"c 'JIKA TOMBOL 0-9
                e.Handled = False
            Case "-"c 'JIKA TOMBOL - (MINUS)
                If Me.TBBobot.Text.Contains("-"c) = True Then 'JIKA TEXTBOX SUDAH PUNYA HURUF MINUS
                    e.Handled = True 'STOP INPUT
                Else 'JIKA TEXTBOX BELUM ADA HURUF MINUS
                    If Me.TBBobot.Text = String.Empty Then 'JIKA TEXTBOX MASIH KOSONG
                        e.Handled = False 'LANJUT INPUT HURUF MINUS
                    Else 'JIKA BELUM ADA HURUF MINUS TAPI SUDAH ADA ANGKA
                        e.Handled = True 'STOP INPUT HURUF MINUS
                    End If
                End If
            Case CChar(System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator) 'JIKA TOMBOL PEMISAH DESIMAL
                'JIKA SUDAH ADA HURUF PEMISAH DESIMAL
                If Me.TBBobot.Text.Contains(CChar(System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator)) = True Then
                    e.Handled = True 'STOP INPUT
                Else 'JIKA BELUM ADA HURUF PEMISAH DESIMAL
                    If Me.TBBobot.Text = String.Empty Then 'JIKA TEXTBOX MASIH KOSONG
                        'TAMBAHKAN O (NOL) DIDEPAN HURUF PEMISAH DESIMAL
                        Me.TBBobot.Text = "0"c & CChar(System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator)
                        'STOP INPUT
                        e.Handled = True
                        'PINDAHKAN CURSOR DITEXTBOX KE BELAKANG TEXT
                        Me.TBBobot.Select(Me.TBBobot.Text.Length, 0)
                    Else 'JIKA BELUM ADA HURUF PEMISAH DESIMAL TAPI SUDAH ADA ANGKA
                        e.Handled = False 'LANJUT INPUT
                    End If
                End If
            Case CChar(System.Globalization.NumberFormatInfo.CurrentInfo.NumberGroupSeparator) 'JIKA TOMBOL PEMISAH RIBUAN
                'JIKA SUDAH ADA HURUF PEMISAH DESIMAL
                If Me.TBBobot.Text.Contains(CChar(System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator)) = True Then
                    e.Handled = True 'STOP INPUT
                Else 'JIKA BELUM ADA HURUF PEMISAH DESIMAL
                    If Me.TBBobot.Text = String.Empty Then 'JIKA TEXTBOX MASIH KOSONG
                        'TAMBAHKAN O (NOL) DIDEPAN HURUF PEMISAH DESIMAL
                        Me.TBBobot.Text = "0"c & CChar(System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator)
                        'STOP INPUT
                        e.Handled = True
                        'PINDAHKAN CURSOR DITEXTBOX KE BELAKANG TEXT
                        Me.TBBobot.Select(Me.TBBobot.Text.Length, 0)
                    Else 'JIKA BELUM ADA HURUF PEMISAH DESIMAL TAPI SUDAH ADA ANGKA
                        e.KeyChar = CChar(System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator) 'LANJUT INPUT TAPI HURUFNYA DIUBAH
                    End If
                End If
            Case Else 'JIKA BUKA TOMBOL BACKSPACE, 0-9, -, PEMISAH DESIMAL, PEMISAH RIBUAN
                e.Handled = True 'STOP INPUT
        End Select
    End Sub
End Class