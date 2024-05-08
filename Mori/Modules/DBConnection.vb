Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Module DBConnection
    Public query As String
    Public conn As MySqlConnection
    Public reader As MySqlDataReader
    Public Command As New MySqlCommand

    Public Sub Connect()
        Try
            conn = New MySqlConnection With {
                    .ConnectionString = "server=localhost;userid=root;password=;database=mori_laundry;sslmode=none;pooling=false"
                    }
            conn.Open()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

    End Sub
End Module
