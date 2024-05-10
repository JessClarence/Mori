Public Class EditProducts
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Connect()
            query = "UPDATE product SET product = @Product, type = @Type, amount = @Amount " &
              "WHERE id = @Id"

            With Command
                .Connection = conn
                .CommandText = query
                .Parameters.Clear()
                .Parameters.AddWithValue("@Id", Convert.ToInt32(txtId.Text))
                .Parameters.AddWithValue("@Product", txtProduct.Text)
                .Parameters.AddWithValue("@Type", cmbfabcon.SelectedItem.ToString())
                .Parameters.AddWithValue("@Amount", Convert.ToInt32(txtAmount.Text))
            End With
            Dim rowsAffected As Integer = Command.ExecuteNonQuery()
            If rowsAffected > 0 Then
                MessageBox.Show("Order updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' Update the corresponding row in the DataGridView
                Dim id As Integer = Convert.ToInt32(txtId.Text)
                Dim rowIndex As Integer = FindRowIndex(Products.Orders, id)
                If rowIndex <> -1 Then
                    ' Update DataGridView row with new data
                    Dim updatedRow As DataGridViewRow = Products.Orders.Rows(rowIndex)
                    updatedRow.Cells("id").Value = txtId.Text
                    updatedRow.Cells("product").Value = txtProduct.Text
                    updatedRow.Cells("type").Value = cmbfabcon.SelectedItem.ToString()
                    updatedRow.Cells("amount").Value = txtAmount.Text

                    ' Update other cells similarly for the rest of the columns
                End If
                ' Close the EditForm after successful update
                Me.Close()
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()

        End Try
    End Sub

    Private Function FindRowIndex(dataGridView As DataGridView, orderNumber As Integer) As Integer
        For Each row As DataGridViewRow In dataGridView.Rows
            If row.Cells("id").Value IsNot Nothing AndAlso Convert.ToInt32(row.Cells("id").Value) = orderNumber Then
                Return row.Index
            End If
        Next
        Return -1
    End Function
End Class