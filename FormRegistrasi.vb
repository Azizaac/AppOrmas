Imports System.Data.SqlClient

Public Class FormRegistrasi
    Private Sub FormRegistrasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KoneksiDB()
        txtNamaLengkap.Focus()
    End Sub

    Private Sub btnDaftar_Click(sender As Object, e As EventArgs) Handles btnDaftar.Click
        If txtNamaLengkap.Text = "" Or txtUsername.Text = "" Or txtPassword.Text = "" Or
           txtEmail.Text = "" Or txtNoHP.Text = "" Then
            MsgBox("Semua data harus diisi!", vbExclamation, "Peringatan")
            Exit Sub
        End If

        Try
            ' Cek username sudah ada atau belum
            Cmd = New SqlCommand("SELECT * FROM [user] WHERE username='" & txtUsername.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()

            If Rd.HasRows Then
                MsgBox("Username sudah digunakan!", vbExclamation, "Peringatan")
                txtUsername.Focus()
                Rd.Close()
                Exit Sub
            End If
            Rd.Close()

            ' Simpan data user baru
            Dim sql As String = "INSERT INTO [user] (username, password, nama_lengkap, email, no_hp, level, status) " &
                               "VALUES ('" & txtUsername.Text & "', '" & txtPassword.Text & "', '" &
                               txtNamaLengkap.Text & "', '" & txtEmail.Text & "', '" & txtNoHP.Text & "', 'Ormas', 'Aktif')"

            Cmd = New SqlCommand(sql, Conn)
            Cmd.ExecuteNonQuery()

            MsgBox("Registrasi berhasil! Silahkan login.", vbInformation, "Informasi")
            Call Clear()
            FormLogin.Show()
            Me.Hide()

        Catch ex As Exception
            MsgBox("Terjadi kesalahan: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        If MsgBox("Apakah anda yakin ingin membatalkan?", vbQuestion + vbYesNo, "Konfirmasi") = vbYes Then
            FormLogin.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Clear()
        txtNamaLengkap.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
        txtEmail.Clear()
        txtNoHP.Clear()
        txtNamaLengkap.Focus()
    End Sub

    ' Validasi input nomor HP hanya angka
    Private Sub txtNoHP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoHP.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class