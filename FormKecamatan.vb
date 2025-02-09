Imports System.Data.SqlClient

Public Class FormKecamatan
    Private Sub FormKecamatan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KoneksiDB()
        LoadData()
        Clear()
    End Sub

    Private Sub LoadData()
        Try
            Da = New SqlDataAdapter("SELECT * FROM kecamatan", Conn)
            Ds = New DataSet
            Da.Fill(Ds, "kecamatan")
            DGVKecamatan.DataSource = Ds.Tables("kecamatan")
        Catch ex As Exception
            MsgBox("Terjadi kesalahan: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtNamaKecamatan.Text = "" Then
            MsgBox("Nama Kecamatan harus diisi!")
            Exit Sub
        End If

        Try
            If lblID.Text = "" Then
                ' Insert
                Cmd = New SqlCommand("INSERT INTO kecamatan (nama_kecamatan) VALUES ('" & txtNamaKecamatan.Text & "')", Conn)
            Else
                ' Update
                Cmd = New SqlCommand("UPDATE kecamatan SET nama_kecamatan='" & txtNamaKecamatan.Text & "' " &
                                   "WHERE id_kecamatan=" & lblID.Text, Conn)
            End If
            Cmd.ExecuteNonQuery()

            MsgBox("Data berhasil disimpan")
            LoadData()
            Clear()
        Catch ex As Exception
            MsgBox("Terjadi kesalahan: " & ex.Message)
        End Try
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If lblID.Text = "" Then
            MsgBox("Pilih data yang akan dihapus!")
            Exit Sub
        End If

        If MsgBox("Yakin akan menghapus data ini?", vbQuestion + vbYesNo) = vbYes Then
            Try
                Cmd = New SqlCommand("DELETE FROM kecamatan WHERE id_kecamatan=" & lblID.Text, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Data berhasil dihapus")
                LoadData()
                Clear()
            Catch ex As Exception
                MsgBox("Terjadi kesalahan: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub Clear()
        lblID.Text = ""
        txtNamaKecamatan.Clear()
        txtNamaKecamatan.Focus()
    End Sub

    Private Sub DGVKecamatan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVKecamatan.CellClick
        If e.RowIndex >= 0 Then
            lblID.Text = DGVKecamatan.Rows(e.RowIndex).Cells(0).Value.ToString()
            txtNamaKecamatan.Text = DGVKecamatan.Rows(e.RowIndex).Cells(1).Value.ToString()
        End If
    End Sub
End Class
