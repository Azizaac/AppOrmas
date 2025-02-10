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
        ' Validasi apakah ada ID yang dipilih
        If String.IsNullOrEmpty(lblID.Text) Then
            MsgBox("Pilih data yang akan dihapus!", vbExclamation)
            Exit Sub
        End If

        ' Validasi apakah ID adalah angka
        Dim idKecamatan As Integer
        If Not Integer.TryParse(lblID.Text, idKecamatan) Then
            MsgBox("ID tidak valid!", vbExclamation)
            Exit Sub
        End If

        ' Konfirmasi sebelum menghapus
        If MsgBox("Yakin akan menghapus data ini?", vbQuestion + vbYesNo) = vbYes Then
            Try
                ' Cek apakah ada data terkait di tabel kelurahan
                Dim cekQuery As String = "SELECT COUNT(*) FROM kelurahan WHERE id_kecamatan = @id"
                Using CekCmd As New SqlCommand(cekQuery, Conn)
                    CekCmd.Parameters.AddWithValue("@id", idKecamatan)
                    Dim jumlahTerkait As Integer = Convert.ToInt32(CekCmd.ExecuteScalar())

                    ' Jika masih ada data terkait, batalkan penghapusan
                    If jumlahTerkait > 0 Then
                        MsgBox("Tidak bisa menghapus! Data masih digunakan di tabel kelurahan.", vbCritical)
                        Exit Sub
                    End If
                End Using

                ' Jika tidak ada data terkait, lanjut hapus
                Dim deleteQuery As String = "DELETE FROM kecamatan WHERE id_kecamatan = @id"
                Using Cmd As New SqlCommand(deleteQuery, Conn)
                    Cmd.Parameters.AddWithValue("@id", idKecamatan)
                    Cmd.ExecuteNonQuery()
                End Using

                MsgBox("Data berhasil dihapus!", vbInformation)

                ' Refresh data dan bersihkan input
                LoadData()
                Clear()
            Catch ex As SqlException
                ' Tangani error jika ada foreign key constraint atau lainnya
                MsgBox("Terjadi kesalahan saat menghapus data: " & ex.Message, vbCritical)
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
