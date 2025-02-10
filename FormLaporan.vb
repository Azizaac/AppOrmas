Imports System.Data.SqlClient

Public Class FormLaporan
    Private Sub FormLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IsiComboKecamatan()

        ' Pastikan ComboBox Kelurahan hanya terisi jika kecamatan dipilih
        If CmbKecamatan.SelectedIndex <> -1 Then
            IsiComboKelurahan(CmbKecamatan.SelectedValue)
        Else
            IsiComboKelurahan(0) ' Isi default jika tidak ada kecamatan yang dipilih
        End If

        TampilkanLaporan()
    End Sub


    Private Sub TampilkanLaporan()
        Dim query As String = "SELECT o.id_ormas, u.username, o.nama_ormas, o.status_legalitas, " &
                              "k.nama_kecamatan, l.nama_kelurahan, o.status " &
                              "FROM ormas o " &
                              "JOIN [user] u ON o.id_user = u.id_user " &
                              "JOIN kecamatan k ON o.id_kecamatan = k.id_kecamatan " &
                              "JOIN kelurahan l ON o.id_kelurahan = l.id_kelurahan"
        Dim dt As DataTable = ExecuteQuery(query)
        DataGridView1.DataSource = dt

        ' Hitung total Ormas
        LblTotalOrmas.Text = "Total Ormas: " & dt.Rows.Count.ToString()
    End Sub

    Private Sub BtnFilter_Click(sender As Object, e As EventArgs) Handles BtnFilter.Click
        Dim filterQuery As String = "SELECT o.id_ormas, u.username, o.nama_ormas, o.status_legalitas, " &
                                    "k.nama_kecamatan, l.nama_kelurahan, o.status " &
                                    "FROM ormas o " &
                                    "JOIN [user] u ON o.id_user = u.id_user " &
                                    "JOIN kecamatan k ON o.id_kecamatan = k.id_kecamatan " &
                                    "JOIN kelurahan l ON o.id_kelurahan = l.id_kelurahan WHERE 1=1"

        Dim parameters As New List(Of SqlParameter)

        If CmbKecamatan.SelectedIndex <> -1 AndAlso Not IsDBNull(CmbKecamatan.SelectedValue) Then
            filterQuery &= " AND k.id_kecamatan = @idKecamatan"
            parameters.Add(New SqlParameter("@idKecamatan", CmbKecamatan.SelectedValue))
        End If

        If CmbKelurahan.SelectedIndex <> -1 AndAlso Not IsDBNull(CmbKelurahan.SelectedValue) Then
            filterQuery &= " AND l.id_kelurahan = @idKelurahan"
            parameters.Add(New SqlParameter("@idKelurahan", CmbKelurahan.SelectedValue))
        End If

        Dim dt As DataTable = ExecuteQuery(filterQuery, parameters.ToArray())
        DataGridView1.DataSource = dt
        LblTotalOrmas.Text = "Total Ormas: " & dt.Rows.Count.ToString()
    End Sub

    Private Sub IsiComboKecamatan()
        Dim query As String = "SELECT id_kecamatan, nama_kecamatan FROM kecamatan"
        Dim dt As DataTable = ExecuteQuery(query)
        CmbKecamatan.DataSource = dt
        CmbKecamatan.DisplayMember = "nama_kecamatan"
        CmbKecamatan.ValueMember = "id_kecamatan"
        CmbKecamatan.SelectedIndex = -1
    End Sub

    Private Sub IsiComboKelurahan(Optional idKecamatan As Integer = 0)
        Dim query As String = "SELECT id_kelurahan, nama_kelurahan FROM kelurahan"

        If idKecamatan > 0 Then
            query &= " WHERE id_kecamatan = @idKecamatan"
        End If

        Dim parameters As New List(Of SqlParameter)
        If idKecamatan > 0 Then
            parameters.Add(New SqlParameter("@idKecamatan", idKecamatan))
        End If

        Dim dt As DataTable = ExecuteQuery(query, parameters.ToArray())
        CmbKelurahan.DataSource = dt
        CmbKelurahan.DisplayMember = "nama_kelurahan"
        CmbKelurahan.ValueMember = "id_kelurahan"
        CmbKelurahan.SelectedIndex = -1
    End Sub



    Private Sub CmbKecamatan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbKecamatan.SelectedIndexChanged
        If CmbKecamatan.SelectedIndex <> -1 AndAlso Not IsDBNull(CmbKecamatan.SelectedValue) Then
            Dim idKecamatan As Integer
            If Integer.TryParse(CmbKecamatan.SelectedValue.ToString(), idKecamatan) Then
                IsiComboKelurahan(idKecamatan)
            End If
        End If
    End Sub


End Class
