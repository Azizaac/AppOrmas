Imports System.Data.SqlClient

Public Class FormKelurahan
    Private Sub FormKelurahan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KoneksiDB()
        LoadKecamatan()
        LoadData()
        Clear()
    End Sub

    Private Sub LoadKecamatan()
        cmbKecamatan.Items.Clear()
        Cmd = New SqlCommand("SELECT nama_kecamatan FROM kecamatan", Conn)
        Rd = Cmd.ExecuteReader
        Do While Rd.Read
            cmbKecamatan.Items.Add(Rd.Item("nama_kecamatan"))
        Loop
        Rd.Close()
    End Sub

    Private Sub LoadData()
        Try
            Da = New SqlDataAdapter("SELECT k.id_kelurahan, kc.nama_kecamatan, k.nama_kelurahan " &
                                  "FROM kelurahan k INNER JOIN kecamatan kc ON k.id_kecamatan = kc.id_kecamatan", Conn)
            Ds = New DataSet
            Da.Fill(Ds, "kelurahan")
            DGVKelurahan.DataSource = Ds.Tables("kelurahan")
        Catch ex As Exception
            MsgBox("Terjadi kesalahan: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtNamaKelurahan.Text = "" Or cmbKecamatan.Text = "" Then
            MsgBox("Data belum lengkap!")
            Exit Sub
        End If

        Try
            ' Get id_kecamatan
            Cmd = New SqlCommand("SELECT id_kecamatan FROM kecamatan WHERE nama_kecamatan='" & cmbKecamatan.Text & "'", Conn)
            Dim idKecamatan As Integer = Cmd.ExecuteScalar()

            If lblID.Text = "" Then
                ' Insert
                Cmd = New SqlCommand("INSERT INTO kelurahan (id_kecamatan, nama_kelurahan) VALUES (" &
                                   idKecamatan & ", '" & txtNamaKelurahan.Text & "')", Conn)
            Else
                ' Update
                Cmd = New SqlCommand("UPDATE kelurahan SET id_kecamatan=" & idKecamatan & ", " &
                                   "nama_kelurahan='" & txtNamaKelurahan.Text & "' " &
                                   "WHERE id_kelurahan=" & lblID.Text, Conn)
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
                Cmd = New SqlCommand("DELETE FROM kelurahan WHERE id_kelurahan=" & lblID.Text, Conn)
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
        txtNamaKelurahan.Clear()
        cmbKecamatan.SelectedIndex = -1
        txtNamaKelurahan.Focus()
    End Sub

    Private Sub DGVKelurahan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVKelurahan.CellClick
        If e.RowIndex >= 0 Then
            lblID.Text = DGVKelurahan.Rows(e.RowIndex).Cells(0).Value.ToString()
            cmbKecamatan.Text = DGVKelurahan.Rows(e.RowIndex).Cells(1).Value.ToString()
            txtNamaKelurahan.Text = DGVKelurahan.Rows(e.RowIndex).Cells(2).Value.ToString()
        End If
    End Sub
End Class