Public Class f_ganti_paswd
    Private Sub f_ganti_paswd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TBPassLama.Focus()
    End Sub

    Private Sub CekTampil_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CekTampil.CheckedChanged
        If CekTampil.Checked Then
            TBPassLama.UseSystemPasswordChar = False
            TBPassBaru.UseSystemPasswordChar = False
            TBPassKonf.UseSystemPasswordChar = False
        Else
            TBPassLama.UseSystemPasswordChar = True
            TBPassBaru.UseSystemPasswordChar = True
            TBPassKonf.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub BtnTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTutup.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        ErrorProvider1.Clear()
        If TBPassLama.Text = "" Then
            ErrorProvider1.SetError(TBPassLama, "Password Lama tidak boleh kosong.")
            TBPassLama.Focus()
        ElseIf TBPassBaru.Text = "" Then
            ErrorProvider1.SetError(TBPassBaru, "Password Baru tidak boleh kosong.")
            TBPassBaru.Focus()
        ElseIf TBPassKonf.Text <> TBPassBaru.Text Then
            ErrorProvider1.SetError(TBPassKonf, "Konfirmasi Password tidak sama dengan Password Baru, silahkan diisi dengan benar.")
            TBPassKonf.Clear()
            TBPassKonf.Focus()
        Else
            MyConn.Close()
            SQL = "SELECT PASSWORD FROM T_USER WHERE USERNAME='" & USERLOGIN & "'"
            MyConn.Open()
            MyCommand = New MySql.Data.MySqlClient.MySqlCommand(SQL, MyConn)
            MyDataReader = MyCommand.ExecuteReader()

            If MyDataReader.HasRows Then
                MyDataReader.Read()

                If TBPassLama.Text = MyDataReader!PASSWORD Then
                    MyConn.Close()
                    SQL = "UPDATE T_USER SET PASSWORD='" & TBPassKonf.Text & "' WHERE USERNAME='" & USERLOGIN & "'"
                    MyCommand = New MySql.Data.MySqlClient.MySqlCommand(SQL, MyConn)
                    MyConn.Open()
                    Try
                        MyCommand.ExecuteNonQuery()
                        MsgBox("Password berhasil diperbaharui.", MsgBoxStyle.Information, "Berhasil")
                        TBPassLama.Clear()
                        TBPassBaru.Clear()
                        TBPassKonf.Clear()
                        TBPassLama.Focus()                        
                        f_utama.LogoutClick(sender, e)
                    Catch ex As MySql.Data.MySqlClient.MySqlException
                        MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Gagal")
                    End Try
                Else
                    ErrorProvider1.SetError(TBPassLama, "Password Lama tidak sesuai, silahkan diisi dengan benar.")
                    TBPassLama.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub TBPassLama_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TBPassLama.KeyDown, TBPassKonf.KeyDown, TBPassBaru.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            If sender Is TBPassLama Then
                TBPassBaru.Focus()
            ElseIf sender Is TBPassBaru Then
                TBPassKonf.Focus()
            ElseIf sender Is TBPassKonf Then
                BtnSimpan_Click(sender, e)
            End If
        End If
    End Sub
End Class