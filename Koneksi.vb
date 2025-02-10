Imports System.Data.SqlClient

Module Koneksi
    Public Conn As SqlConnection
    Public Da As SqlDataAdapter
    Public Ds As DataSet
    Public Rd As SqlDataReader
    Public Cmd As SqlCommand
    Public Mydb As String

    Public Sub KoneksiDB()
        Mydb = "data source=MDK\SQLEXPRESS;initial catalog=DB_Ormas;integrated security=true"
        Conn = New SqlConnection(Mydb)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub

    ' Fungsi untuk mengeksekusi query SELECT dan mengembalikan DataTable
    Public Function ExecuteQuery(query As String, Optional parameters() As SqlParameter = Nothing) As DataTable
        Dim dt As New DataTable()

        Try
            Using conn As New SqlConnection("data source=MDK\SQLEXPRESS;initial catalog=DB_Ormas;integrated security=true")
                conn.Open()
                Using cmd As New SqlCommand(query, conn)
                    ' Jika ada parameter, tambahkan ke SqlCommand
                    If parameters IsNot Nothing Then
                        cmd.Parameters.AddRange(parameters)
                    End If

                    Using da As New SqlDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        End Try

        Return dt
    End Function

End Module