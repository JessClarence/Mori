Public Class CreateProducts
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Home_Page.ShowFormInPanel(Products)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If String.IsNullOrWhiteSpace(txtProduct.Text) Then
            MessageBox.Show("Product is Empty", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        If String.IsNullOrWhiteSpace(txtAmount.Text) Then
            MessageBox.Show("Amount is Empty", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Try
            Connect()
            query = "INSERT INTO product (product,type,amount) VALUES (@Product,@Type,@Amount)"
            With Command
                .Connection = conn
                .CommandText = query
                .Parameters.Clear()
                .Parameters.AddWithValue("@Product", txtProduct.Text)
                .Parameters.AddWithValue("@Type", cmbfabcon.SelectedItem.ToString())
                .Parameters.AddWithValue("@Amount", Convert.ToInt32(txtAmount.Text))
                Command.ExecuteNonQuery()
            End With
            RefreshData()

            MessageBox.Show("Order successfully saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("An error occurred while saving the order: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If ConnectionState.Open Then
                conn.Close()
            End If
        End Try
        ResetForm()
    End Sub


    Private Sub RefreshData()
        Try
            Products.Orders.Rows.Clear()

            Dim query As String = "SELECT * FROM product"
            Connect()
            Command.CommandText = query
            reader = Command.ExecuteReader()

            While reader.Read()
                Dim index As Integer = Products.Orders.Rows.Add()
                ' Populate DataGridView columns with data from database reader
                Products.Orders.Rows(index).Cells("id").Value = reader("id").ToString()
                Products.Orders.Rows(index).Cells("product").Value = reader("product").ToString()
                Products.Orders.Rows(index).Cells("type").Value = reader("type").ToString()
                Products.Orders.Rows(index).Cells("amount").Value = reader("amount").ToString()

            End While
        Catch ex As Exception
            MessageBox.Show("Error refreshing DataGridView: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            Command.Parameters.Clear()
            reader.Close()
        End Try
    End Sub

    Private Sub ResetForm()
        txtProduct.Text = ""
        txtAmount.Text = ""

        ' Set focus on the first empty field
        If String.IsNullOrWhiteSpace(txtProduct.Text) Then
            txtProduct.Focus()
        ElseIf String.IsNullOrWhiteSpace(txtAmount.Text) Then
            txtAmount.Focus()
        End If
    End Sub
End Class