Public Class Products
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Home_Page.ShowFormInPanel(CreateProducts)
    End Sub

    Private Sub Orders_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Orders.CellContentClick

        If Orders.Columns(e.ColumnIndex).Name = "btnEdit" Then
            Dim orderNumber As Integer = Convert.ToInt32(Orders.Rows(e.RowIndex).Cells("id").Value)
            Dim query As String = "SELECT * FROM product WHERE id = @Id"
            Try
                Connect()
                With Command
                    .Connection = conn
                    .CommandText = query
                    .Parameters.Clear()
                    Command.Parameters.AddWithValue("@Id", orderNumber)
                    reader = Command.ExecuteReader()
                    If reader.Read Then
                        EditProducts.txtId.Text = reader("id").ToString()
                        EditProducts.txtProduct.Text = reader("product").ToString()
                        EditProducts.cmbfabcon.SelectedItem = reader("type").ToString()
                        EditProducts.txtAmount.Text = reader("amount").ToString()
                        EditProducts.Show()
                    Else
                        MessageBox.Show("Order not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End With
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Closing of database connection and dispose of resources
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
                Command.Parameters.Clear()
                reader.Close()
            End Try
        ElseIf Orders.Columns(e.ColumnIndex).Name = "btnDelete" Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this order?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                ' Get the order number to delete
                Dim orderNumber As Integer = Convert.ToInt32(Orders.Rows(e.RowIndex).Cells("id").Value)
                Dim query As String = "DELETE FROM product WHERE id = @Id"
                Try
                    Connect()
                    With Command
                        .Connection = conn
                        .CommandText = query
                        .Parameters.Clear()
                        .Parameters.AddWithValue("@Id", orderNumber)
                        Dim rowsAffected As Integer = .ExecuteNonQuery()
                        If rowsAffected > 0 Then
                            MessageBox.Show("Order deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            ' Remove the deleted row from the DataGridView
                            Orders.Rows.RemoveAt(e.RowIndex)
                        Else
                            MessageBox.Show("Failed to delete order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End With
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    conn.Close()
                End Try
            End If
        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
        GetProducts(Orders)
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
            Dim orderNumber As String = row.Cells("id").Value.ToString().ToLower()
            Dim customerName As String = row.Cells("product").Value.ToString().ToLower()

            ' Check if the order number or customer name contains the search term
            If orderNumber.Contains(searchTerm) OrElse customerName.Contains(searchTerm) Then
                row.Visible = True
            Else
                row.Visible = False
            End If
        Next
    End Sub
End Class