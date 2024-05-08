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

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim searchTerm As String = txtSearch.Text.Trim().ToLower()

        ' Check if search term is empty
        If String.IsNullOrEmpty(searchTerm) Then
            ' If search term is empty, show all data
            For Each row As DataGridViewRow In Orders.Rows
                row.Visible = True
            Next
            Return
        End If

        For Each row As DataGridViewRow In Orders.Rows
            Dim orderNumber As String = row.Cells("OrderNumber").Value.ToString().ToLower()
            Dim customerName As String = row.Cells("CustomerName").Value.ToString().ToLower()

            ' Check if the order number or customer name contains the search term
            If orderNumber.Contains(searchTerm) OrElse customerName.Contains(searchTerm) Then
                row.Visible = True
            Else
                row.Visible = False
            End If
        Next
    End Sub
End Class