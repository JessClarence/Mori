Imports MySql.Data.MySqlClient

Public Class TransactionHistory
    Private Sub Orders_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Orders.CellContentClick

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
        RefreshOrdersDataGridView()
    End Sub


    Private Sub RefreshOrdersDataGridView()
        Try
            Connect()

            Dim query As String = "SELECT * FROM transac_history"
            With Command
                .Connection = conn
                .CommandText = query
            End With
            Dim adapter As New MySqlDataAdapter
            adapter.SelectCommand = Command
            Dim table As New DataTable()
            adapter.Fill(table)
            If table.Rows.Count > 0 Then
                Orders.DataSource = table
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred while refreshing the orders: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If ConnectionState.Open Then
                conn.Close()
            End If
        End Try

    End Sub
End Class