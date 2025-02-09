Imports System.Data.SqlClient

Public Class FormDashboardAdmin
    Private Sub FormDashboardAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KoneksiDB()
        LoadStatistik()
    End Sub

    Private Sub LoadStatistik()
        Try
            ' Hitung total ormas berdasarkan status
            Dim sqlDaftar As String = "SELECT COUNT(*) FROM ormas WHERE status='Daftar'"
            Dim sqlProses As String = "SELECT COUNT(*) FROM ormas WHERE status='Proses'"
            Dim sqlAktif As String = "SELECT COUNT(*) FROM ormas WHERE status='Aktif'"

            Cmd = New SqlCommand(sqlDaftar, Conn)
            lblDaftar.Text = Cmd.ExecuteScalar().ToString()

            Cmd = New SqlCommand(sqlProses, Conn)
            lblProses.Text = Cmd.ExecuteScalar().ToString()

            Cmd = New SqlCommand(sqlAktif, Conn)
            lblAktif.Text = Cmd.ExecuteScalar().ToString()

        Catch ex As Exception
            MsgBox("Terjadi kesalahan: " & ex.Message)
        End Try
    End Sub

    Private Sub lblDaftar_Click(sender As Object, e As EventArgs) Handles lblDaftar.Click, Label1.Click

    End Sub
End Class