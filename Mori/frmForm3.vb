'Update Order
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports Mysqlx.Crud
Imports System.Data.SqlClient

Public Class frmForm3


    Private Sub frmForm3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmForm4.sldbtn.IsOn = SettingsManager.DarkModeEnabled
        DarkModeManager.ToggleDarkMode(Me, SettingsManager.DarkModeEnabled)
        Orders.ReadOnly = True
        GetOrders(Orders)

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

    Private Sub Orders_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Orders.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            ' Check if the clicked cell belongs to the column with the name "btnEdit"
            If Orders.Columns(e.ColumnIndex).Name = "btnEdit" Then
                ' Get the value from the corresponding row
                Dim orderNumber As Integer = Convert.ToInt32(Orders.Rows(e.RowIndex).Cells("OrderNumber").Value)
                Dim query As String = "SELECT * FROM create_order WHERE OrderNumber = @OrderNumber"
                Try
                    Connect()
                    With Command
                        .Connection = conn
                        .CommandText = query
                        .Parameters.Clear()
                        Command.Parameters.AddWithValue("@OrderNumber", orderNumber)
                        reader = Command.ExecuteReader()
                        If reader.Read Then
                            ' Populate the edit form with data from the database
                            EditForm.txtOrderNum.Text = reader("OrderNumber").ToString()
                            EditForm.txtCustomerName.Text = reader("CustomerName").ToString()
                            EditForm.txtCustomerAddress.Text = reader("Address").ToString()
                            EditForm.txtCustomerContactNum.Text = reader("ContactNum").ToString()
                            EditForm.dtpDateToPickUp.Value = Convert.ToDateTime(reader("DateToPickUp"))
                            EditForm.txtTimeToPickUp.Text = reader("TimeToPickUp").ToString()
                            EditForm.dudPmAM.SelectedItem = reader("PMorAM").ToString()
                            EditForm.cmbGarments.SelectedItem = reader("GarmentType").ToString()
                            EditForm.cmbService.SelectedItem = reader("Service").ToString()
                            EditForm.txtKilogram.Text = reader("Kilogram").ToString()
                            EditForm.cbxSelfService.Checked = If(reader("SelfService").ToString().ToLower() = "yes", True, False)
                            EditForm.cmbfabcon.SelectedItem = reader("fabCon").ToString()
                            EditForm.cmbpowder.SelectedItem = reader("Powder").ToString()
                            EditForm.fabQty.Value = Convert.ToInt32(reader("FabConQty"))
                            EditForm.powderQty.Value = Convert.ToInt32(reader("PowderQty"))
                            EditForm.txtTotal.Text = reader("Total").ToString()
                            EditForm.Show()
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
                GetOrders(Orders)
            ElseIf Orders.Columns(e.ColumnIndex).Name = "btnDelete" Then
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this order?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    ' Get the order number to delete
                    Dim orderNumber As Integer = Convert.ToInt32(Orders.Rows(e.RowIndex).Cells("OrderNumber").Value)
                    Dim query As String = "DELETE FROM create_order WHERE OrderNumber = @OrderNumber"
                    Try
                        Connect()
                        With Command
                            .Connection = conn
                            .CommandText = query
                            .Parameters.Clear()
                            .Parameters.AddWithValue("@OrderNumber", orderNumber)
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
                GetOrders(Orders)
            ElseIf Orders.Columns(e.ColumnIndex).Name = "btnPayment" Then
                Dim result As DialogResult = MessageBox.Show("Confirmation to proceed to payment?", "Confirm Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    Dim orderNumber As Integer = Convert.ToInt32(Orders.Rows(e.RowIndex).Cells("OrderNumber").Value)
                    Dim customerName As String = Orders.Rows(e.RowIndex).Cells("CustomerName").Value.ToString()
                    Dim total As Decimal = Convert.ToDecimal(Orders.Rows(e.RowIndex).Cells("Total").Value)

                    ' Update payment status
                    Dim updateQuery As String = "UPDATE create_order SET payment = @payment WHERE OrderNumber = @OrderNumber"
                    Try
                        Connect()
                        With Command
                            .Connection = conn
                            .CommandText = updateQuery
                            .Parameters.Clear()
                            .Parameters.AddWithValue("@OrderNumber", orderNumber)
                            .Parameters.AddWithValue("@payment", "complete")
                            Dim rowsAffected As Integer = .ExecuteNonQuery()
                            If rowsAffected > 0 Then
                                MessageBox.Show("Order successfully paid.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                ' Insert into transaction history
                                Dim insertQuery As String = "INSERT INTO transac_history (orders_id, customer_name, total) VALUES (@order_id, @customer_name, @total)"
                                .CommandText = insertQuery
                                .Parameters.Clear()
                                .Parameters.AddWithValue("@order_id", orderNumber)
                                .Parameters.AddWithValue("@customer_name", customerName)
                                .Parameters.AddWithValue("@total", total)
                                .ExecuteNonQuery()

                                ' Refresh DataGridView to reflect changes
                                ' Or you can update the DataGridView cell directly if needed
                                ' Example: Orders.Rows(e.RowIndex).Cells("Payment").Value = "complete"
                            Else
                                MessageBox.Show("Failed to mark order as paid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End With
                    Catch ex As Exception
                        MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Finally
                        conn.Close()
                    End Try
                End If
                GetOrders(Orders)
            End If

        End If
    End Sub

    Private Sub RefreshOrdersDataGridView()
        Try
            Connect()

            Dim query As String = "SELECT * FROM create_order WHERE payment = 'process'"
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

    Private Function FindRowIndex(dataGridView As DataGridView, orderNumber As Integer) As Integer
        For Each row As DataGridViewRow In dataGridView.Rows
            If row.Cells("OrderNumber").Value IsNot Nothing AndAlso Convert.ToInt32(row.Cells("OrderNumber").Value) = orderNumber Then
                Return row.Index
            End If
        Next
        Return -1
    End Function

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Guna2CustomGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2CustomGradientPanel1.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Home_Page.ShowFormInPanel(CreateOrder)
    End Sub
End Class