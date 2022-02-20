Public Class f_user
    Dim IsDataBaru As Boolean

    Private Sub f_user_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CBLevel.Items.Clear()
        CBLevel.Items.Insert(0, "0. ADMINISTRATOR")
        CBLevel.Items.Insert(1, "1. KEPALA")
        CBLevel.SelectedIndex = 0

        BtnHapus.Enabled = False
        BtnBatal.Enabled = False

        TampilData()

        TBUser.Focus()
    End Sub

    Private Sub TampilData()
        MyConn.Close()
        SQL = "SELECT NM_USER, USERNAME, LEVEL FROM T_USER ORDER BY NM_USER"
        MyConn.Open()
        MyDataAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter(SQL, MyConn)
        DS = New DataSet
        MyDataAdapter.Fill(DS, "T_USER")
        DataGridView1.DataSource = DS.Tables("T_USER")

        Try
            DataGridView1.Columns(0).Width = 250
            DataGridView1.Columns(1).Width = 250
            DataGridView1.Columns(2).Width = 50
            DataGridView1.Columns(0).HeaderText = "NAMA PENGGUNA"
            DataGridView1.Columns(1).HeaderText = "USER LOGIN"
            DataGridView1.Columns(2).HeaderText = "LEVEL USER"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BtnTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTutup.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub TBUser_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TBUser.KeyDown, TBPass.KeyDown, TBNama.KeyDown, TBKonf.KeyDown, CBLevel.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            If sender Is TBUser Then
                TBNama.Focus()
            ElseIf sender Is TBNama Then
                TBPass.Focus()
            ElseIf sender Is TBPass Then
                TBKonf.Focus()
            ElseIf sender Is TBKonf Then
                CBLevel.Focus()
            ElseIf sender Is CBLevel Then
                BtnSimpan_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        ErrorProvider1.Clear()
        If TBUser.Text = "" Then
            ErrorProvider1.SetError(TBUser, "Username tidak boleh kosong.")
            TBUser.Focus()
        ElseIf TBNama.Text = "" Then
            ErrorProvider1.SetError(TBNama, "Nama tidak boleh kosong.")
            TBNama.Focus()
        ElseIf TBPass.Text = "" Then
            ErrorProvider1.SetError(TBPass, "Password tidak boleh kosong.")
            TBPass.Focus()
        ElseIf TBKonf.Text <> TBPass.Text Then
            ErrorProvider1.SetError(TBKonf, "Konfirmasi Password tidak sama dengan Password, silahkan diisi dengan benar.")
            TBKonf.Clear()
            TBKonf.Focus()
        Else
            MyConn.Close()
            If IsDataBaru = True Then
                SQL = "INSERT INTO T_USER VALUES ('" & TBUser.Text & "'," _
                                               & "'" & TBNama.Text & "'," _
                                               & "'" & TBKonf.Text & "'," _
                                               & "'" & CBLevel.SelectedIndex & "')"
            ElseIf IsDataBaru = False Then
                SQL = "UPDATE T_USER SET NM_USER='" & TBNama.Text & "'," _
                    & "PASSWORD='" & TBKonf.Text & "'," _
                    & "LEVEL='" & CBLevel.SelectedIndex & "' " _
                    & "WHERE USERNAME='" & TBUser.Text & "'"
            End If
            MyConn.Open()
            MyCommand = New MySql.Data.MySqlClient.MySqlCommand(SQL, MyConn)

            Try
                MyCommand.ExecuteNonQuery()
                If IsDataBaru = True Then
                    MsgBox("Data '" & TBUser.Text & "' berhasil ditambahkan.", MsgBoxStyle.Information, "Berhasil")
                ElseIf IsDataBaru = False Then
                    MsgBox("Data '" & TBUser.Text & "' berhasil diperbaharui.", MsgBoxStyle.Information, "Berhasil")
                End If
                TampilData()
                BtnBatal_Click(sender, e)
            Catch ex As MySql.Data.MySqlClient.MySqlException
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Gagal")
            End Try
        End If
    End Sub

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        If TBUser.Text = "" Then
            MsgBox("Tidak ada data yang akan dihapus.", MsgBoxStyle.Exclamation, "Error")
            TBUser.Focus()
        Else
            If MessageBox.Show("Apakah Anda ingin menghapus data '" & TBUser.Text & "' ?", "Konfirmasi", _
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                MyConn.Close()
                SQL = "DELETE FROM T_USER WHERE USERNAME='" & TBUser.Text & "'"
                MyConn.Open()
                MyCommand = New MySql.Data.MySqlClient.MySqlCommand(SQL, MyConn)

                Try
                    MyCommand.ExecuteNonQuery()
                    MsgBox("Data '" & TBUser.Text & "' berhasil dihapus.", MsgBoxStyle.Information, "Berhasil")
                    TampilData()
                    BtnBatal_Click(sender, e)
                Catch ex As MySql.Data.MySqlClient.MySqlException
                    MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Gagal")
                End Try
            End If
        End If
    End Sub

    Private Sub BtnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBatal.Click
        TBUser.Clear()
        TBNama.Clear()
        TBPass.Clear()
        TBKonf.Clear()
        CBLevel.SelectedIndex = 0

        BtnHapus.Enabled = False
        BtnBatal.Enabled = False
    End Sub

    Private Sub CekPass_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CekPass.CheckedChanged
        If CekPass.Checked Then
            TBPass.UseSystemPasswordChar = False
        Else
            TBPass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub CekKonf_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CekKonf.CheckedChanged
        If CekKonf.Checked Then
            TBKonf.UseSystemPasswordChar = False
        Else
            TBKonf.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub TBUser_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBUser.Leave
        If TBUser.Text <> "" Then
            MyConn.Close()
            SQL = "SELECT * FROM T_USER WHERE USERNAME='" & TBUser.Text & "'"
            MyConn.Open()
            MyCommand = New MySql.Data.MySqlClient.MySqlCommand(SQL, MyConn)
            MyDataReader = MyCommand.ExecuteReader()

            If MyDataReader.HasRows = 0 Then
                TBNama.Clear()
                TBPass.Clear()
                TBKonf.Clear()
                CBLevel.SelectedIndex = 0
                IsDataBaru = True

                BtnHapus.Enabled = False
                BtnBatal.Enabled = False
            Else
                MyDataReader.Read()
                TBNama.Text = MyDataReader!NM_USER
                TBPass.Text = MyDataReader!PASSWORD
                TBKonf.Text = MyDataReader!PASSWORD
                CBLevel.SelectedIndex = MyDataReader!LEVEL
                IsDataBaru = False

                BtnHapus.Enabled = True
                BtnBatal.Enabled = True
            End If
        Else
            TBNama.Clear()
            TBPass.Clear()
            TBKonf.Clear()
            CBLevel.SelectedIndex = 0

            BtnHapus.Enabled = False
            BtnBatal.Enabled = False
        End If
    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        If e.RowIndex >= 0 Then
            If Not IsDBNull(DataGridView1.Rows(e.RowIndex).Cells(1).Value) Then
                TBUser.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
                TBUser_Leave(sender, e)
                TBUser.Focus()
            End If
        End If        
    End Sub
End Class