Imports System.Data.SqlClient
Imports NamaNamespace.ModuleApp


Public Class FormLogin
    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KoneksiDB()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Username dan Password harus diisi!", vbExclamation, "Peringatan")
            Exit Sub
        End If

        Try
            Cmd = New SqlCommand("SELECT * FROM [user] WHERE username='" & txtUsername.Text & "' AND password='" & txtPassword.Text & "' AND status='Aktif'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()

            If Rd.HasRows Then
                Dim level As String = Rd.Item("level")
                Dim nama As String = Rd.Item("nama_lengkap")
                MsgBox("Selamat datang " & nama, vbInformation, "Login Berhasil")

                ' Simpan data user yang sedang login
                ModuleApp.UserID = Rd.Item("id_user")
                ModuleApp.Username = Rd.Item("username")
                ModuleApp.UserLevel = level

                If level = "Admin" Then
                    FormMenuAdmin.Show()
                Else
                    FormMenuOrmas.Show()
                End If

                Me.Hide()
                Rd.Close()
            Else
                MsgBox("Username atau Password salah!", vbCritical, "Login Gagal")
                txtUsername.Text = ""
                txtPassword.Text = ""
                txtUsername.Focus()
                Rd.Close()
            End If

        Catch ex As Exception
            MsgBox("Terjadi kesalahan: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub lnkDaftar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        FormRegistrasi.Show()
        Me.Hide()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs)
        If MsgBox("Apakah anda yakin ingin keluar?", vbQuestion + vbYesNo, "Konfirmasi") = vbYes Then
            End
        End If
    End Sub

    Private Sub lnkDaftar_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkDaftar.LinkClicked
        FormRegistrasi.Show()
        Me.Hide()
    End Sub


End Class

' Module untuk menyimpan data user yang sedang login
Module ModuleApp
    Public UserID As Integer
    Public Username As String
    Public UserLevel As String
End Module