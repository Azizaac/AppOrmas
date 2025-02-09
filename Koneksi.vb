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
End Module