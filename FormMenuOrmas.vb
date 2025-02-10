Imports System.Data.SqlClient

Public Class FormMenuOrmas
    Private Sub FormMenuOrmas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUser.Text = ModuleApp.Username
        lblLevel.Text = ModuleApp.UserLevel
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        FormDashboardAdmin.Show()
    End Sub


    Private Sub btnOrmas_Click(sender As Object, e As EventArgs) Handles btnOrmas.Click
        FormDataOrmas.Show()
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        FormDataUser.Show()
    End Sub



    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If MsgBox("Apakah anda yakin ingin logout?", vbQuestion + vbYesNo, "Konfirmasi") = vbYes Then
            FormLogin.Show()
            Me.Close()
        End If
    End Sub
End Class