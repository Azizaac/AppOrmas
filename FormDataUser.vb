Imports System.Data.SqlClient

Public Class FormDataUser
    Private Sub FormDataUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KoneksiDB()
        LoadData()
        Clear()
    End Sub

    Private Sub LoadData()
        Try
            Da = New SqlDataAdapter("SELECT * FROM [user]", Conn)
            Ds = New DataSet
            Da.Fill(Ds, "user")
            DGVUser.DataSource = Ds.Tables("user")
        Catch ex As Exception
            MsgBox("Terjadi kesalahan: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Or
           txtNamaLengkap.Text = "" Or txtEmail.Text = "" Or txtNoHP.Text = "" Then
            MsgBox("Data belum lengkap!")
            Exit Sub
        End If

        Try
            If lblID.Text = "" Then
                Cmd = New SqlCommand("SELECT * FROM [user] WHERE username='" & txtUsername.Text & "'", Conn)
                Rd = Cmd.ExecuteReader
                If Rd.HasRows Then
                    MsgBox("Username sudah digunakan!")
                    Rd.Close()
                    Exit Sub
                End If
                Rd.Close()

                Cmd = New SqlCommand("INSERT INTO [user] (username, password, nama_lengkap, email, no_hp, level, status) " &
                                   "VALUES ('" & txtUsername.Text & "', '" & txtPassword.Text & "', '" &
                                   txtNamaLengkap.Text & "', '" & txtEmail.Text & "', '" & txtNoHP.Text & "', '" &
                                   cmbLevel.Text & "', '" & cmbStatus.Text & "')", Conn)
            Else
                Cmd = New SqlCommand("UPDATE [user] SET nama_lengkap='" & txtNamaLengkap.Text & "', " &
                                   "email='" & txtEmail.Text & "', no_hp='" & txtNoHP.Text & "', " &
                                   "level='" & cmbLevel.Text & "', status='" & cmbStatus.Text & "' " &
                                   "WHERE id_user=" & lblID.Text, Conn)
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
                Cmd = New SqlCommand("DELETE FROM [user] WHERE id_user=" & lblID.Text, Conn)
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
        txtUsername.Clear()
        txtPassword.Clear()
        txtNamaLengkap.Clear()
        txtEmail.Clear()
        txtNoHP.Clear()
        cmbLevel.SelectedIndex = -1
        cmbStatus.SelectedIndex = -1
        txtUsername.Focus()
    End Sub

    Private Sub DGVUser_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVUser.CellClick
        If e.RowIndex >= 0 Then
            lblID.Text = DGVUser.Rows(e.RowIndex).Cells(0).Value.ToString()
            txtUsername.Text = DGVUser.Rows(e.RowIndex).Cells(1).Value.ToString()
            txtPassword.Text = DGVUser.Rows(e.RowIndex).Cells(2).Value.ToString()
            txtNamaLengkap.Text = DGVUser.Rows(e.RowIndex).Cells(3).Value.ToString()
            txtEmail.Text = DGVUser.Rows(e.RowIndex).Cells(4).Value.ToString()
            txtNoHP.Text = DGVUser.Rows(e.RowIndex).Cells(5).Value.ToString()
            cmbLevel.Text = DGVUser.Rows(e.RowIndex).Cells(6).Value.ToString()
            cmbStatus.Text = DGVUser.Rows(e.RowIndex).Cells(7).Value.ToString()
        End If
    End Sub
End Class
