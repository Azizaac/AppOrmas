Imports System.Data.SqlClient

Public Class FormDataOrmas
    Private Sub FormDataOrmas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KoneksiDB()
        LoadData()
    End Sub

    Private Sub LoadData()
        Try
            Dim sql As String = "SELECT o.id_ormas, o.nama_ormas, o.status_legalitas, " &
                               "kc.nama_kecamatan, k.nama_kelurahan, " &
                               "o.nama_ketua, o.no_hp_ketua, o.status " &
                               "FROM ormas o " &
                               "INNER JOIN kecamatan kc ON o.id_kecamatan = kc.id_kecamatan " &
                               "INNER JOIN kelurahan k ON o.id_kelurahan = k.id_kelurahan"

            If cmbStatus.Text <> "" Then
                sql &= " WHERE o.status='" & cmbStatus.Text & "'"
            End If

            Da = New SqlDataAdapter(sql, Conn)
            Ds = New DataSet
            Da.Fill(Ds, "ormas")
            DGVOrmas.DataSource = Ds.Tables("ormas")
        Catch ex As Exception
            MsgBox("Terjadi kesalahan: " & ex.Message)
        End Try
    End Sub

    Private Sub btnProsesVerifikasi_Click(sender As Object, e As EventArgs) Handles btnProsesVerifikasi.Click
        If lblID.Text = "" Then
            MsgBox("Pilih data ormas terlebih dahulu!")
            Exit Sub
        End If

        Try
            Dim status As String = If(btnProsesVerifikasi.Text = "Verifikasi", "Proses", "Aktif")
            Cmd = New SqlCommand("UPDATE ormas SET status='" & status & "' WHERE id_ormas=" & lblID.Text, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Status ormas berhasil diubah")
            LoadData()
            Clear()
        Catch ex As Exception
            MsgBox("Terjadi kesalahan: " & ex.Message)
        End Try
    End Sub

    Private Sub Clear()
        lblID.Text = ""
        btnProsesVerifikasi.Text = "Verifikasi"
    End Sub

    Private Sub DGVOrmas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVOrmas.CellClick
        If e.RowIndex >= 0 Then
            lblID.Text = DGVOrmas.Rows(e.RowIndex).Cells(0).Value.ToString()
            Dim status As String = DGVOrmas.Rows(e.RowIndex).Cells(7).Value.ToString()

            If status = "Daftar" Then
                btnProsesVerifikasi.Text = "Verifikasi"
                btnProsesVerifikasi.Enabled = True
            ElseIf status = "Proses" Then
                btnProsesVerifikasi.Text = "Aktivasi"
                btnProsesVerifikasi.Enabled = True
            Else
                btnProsesVerifikasi.Text = "Verifikasi"
                btnProsesVerifikasi.Enabled = False
            End If
        End If
    End Sub

    Private Sub cmbStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStatus.SelectedIndexChanged
        LoadData()
    End Sub
End Class