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
            Dim foundMatch As Boolean = False
            ' Loop through each cell in the row
            For Each cell As DataGridViewCell In row.Cells
                ' Check if cell value contains the search term
                If cell.Value IsNot Nothing AndAlso cell.Value.ToString().ToLower().Contains(searchTerm) Then
                    foundMatch = True
                    Exit For ' Exit loop once a match is found in this row
                End If
            Next

            ' Set the row's visibility based on whether a match was found
            row.Visible = foundMatch
        Next
    End Sub

    Private Sub Orders_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Orders.CellContentClick

        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            ' Get the selected row
            Dim selectedRow As DataGridViewRow = Orders.Rows(e.RowIndex)

            ' Retrieve OrderNumber from the selected row
            Dim orderNumber As Integer = Convert.ToInt32(selectedRow.Cells("OrderNumber").Value)
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

        End If
    End Sub
    Private Sub RefreshOrdersDataGridView()
        Try
            Connect()

            Dim query As String = "SELECT * FROM create_order"
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