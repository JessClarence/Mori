Imports System.Text
Imports System.Text.RegularExpressions
Imports Mysqlx.Crud
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.ComponentModel

Public Class EditForm

    'Price per Fab Con
    Private Function GetFabconPrice(fabcon As String) As Integer
        Select Case fabcon
            Case "Downy"
                Return 10
            Case "Del"
                Return 10
            Case "Surf"
                Return 10
            Case "Colorsafe"
                Return 10
            Case Else
                Return 0
        End Select
    End Function
    'Price per Powder
    Private Function GetPowderPrice(powder As String) As Integer
        Select Case powder
            Case "Ariel"
                Return 20
            Case "Breeze"
                Return 20
            Case "S & R He Powder"
                Return 20
            Case Else
                Return 0
        End Select
    End Function

    Private Sub cmbfabcon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbfabcon.SelectedIndexChanged
        'If cmbfabcon.SelectedItem = "none" Then
        '    fabQty.Value = 0

        'End If
    End Sub

    Private Sub cmbpowder_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbpowder.SelectedIndexChanged
        'If cmbpowder.SelectedItem = "none" Then
        '    powderQty.Value = 0
        'End If
    End Sub

    Private Sub cmbService_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbService.SelectedIndexChanged
        txtTotal.Text = ""
        txtKilogram.Text = ""
        cmbfabcon.SelectedItem = "none"
        cmbpowder.SelectedItem = "none"
        fabQty.Value = 0
        powderQty.Value = 0
        If cmbService.SelectedItem = "Dry" Then
            cmbpowder.Enabled = False
            cmbfabcon.Enabled = False
        Else
            cmbpowder.Enabled = True
            cmbfabcon.Enabled = True
        End If
        If cmbService.SelectedItem = "Complete Service" Then
            cbxSelfService.Enabled = False

        Else
            cbxSelfService.Enabled = True
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim selectedDate As DateTime = dtpDateToPickUp.Value
        emptyName.Text = ""
        emptyAddress.Text = ""
        emptyNumber.Text = ""
        emptyTime.Text = ""
        errordate.Text = ""
        pmam.Text = ""
        If String.IsNullOrWhiteSpace(txtCustomerName.Text) Then
            emptyName.Text = "Please enter customer name."
            txtCustomerName.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtCustomerAddress.Text) Then
            emptyAddress.Text = "Please enter customer address."
            txtCustomerAddress.Focus()
            Return
        End If
        If String.IsNullOrWhiteSpace(txtTimeToPickUp.Text) Then
            emptyTime.Text = "Please enter the time to pick up order"
        ElseIf Not IsValidTime(txtTimeToPickUp.Text) Then
            ' Time format is invalid, display an error message
            pmam.Text = "Please enter a valid time"
            Return
        End If
        If Not IsValidContactNumber(txtCustomerContactNum.Text) Then
            emptyNumber.Text = "Please input valid contact number"
            txtCustomerContactNum.Focus()
            Return
        End If
        Dim dateString As String = selectedDate.ToString("yyyy-MM-dd")
        If selectedDate < DateTime.Today Then
            ' Date is in the past, display an error message
            errordate.Text = "Selected date must be in the future."
            Return
        End If

        If String.IsNullOrEmpty(txtKilogram.Text) Then
            MessageBox.Show("Please select an order before saving.", "No Order Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbService.Focus()
            Return
        End If
        Try
            Connect()
            If String.IsNullOrEmpty(txtTotal.Text) Then
                MessageBox.Show("Compute order before saving", "Compute Order", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbService.Focus()
                Return
            End If
            query = "UPDATE create_order SET CustomerName = @CustomerName, Address = @Address, ContactNum = @ContactNum, " &
                          "DateToPickUp = @DateToPickUp, TimeToPickUp = @TimeToPickUp, PMorAM = @PMorAM, " &
                          "GarmentType = @GarmentType, Service = @Service, Kilogram = @Kilogram, SelfService = @SelfService, fabCon = @fabCon, " &
                          "Powder = @Powder, FabConQty = @FabConQty, PowderQty = @PowderQty, Total = @Total " &
                          "WHERE OrderNumber = @OrderNumber"
            With Command
                .Connection = conn
                .CommandText = query
                .Parameters.Clear()
                .Parameters.AddWithValue("@CustomerName", txtCustomerName.Text)
                .Parameters.AddWithValue("@Address", txtCustomerAddress.Text)
                .Parameters.AddWithValue("@ContactNum", txtCustomerContactNum.Text)
                .Parameters.AddWithValue("@GarmentType", cmbGarments.SelectedItem.ToString())
                .Parameters.AddWithValue("@Service", cmbService.SelectedItem.ToString())
                .Parameters.AddWithValue("@Kilogram", Convert.ToDouble(txtKilogram.Text))
                .Parameters.AddWithValue("@fabCon", cmbfabcon.SelectedItem.Value.ToString())
                .Parameters.AddWithValue("@powder", cmbpowder.SelectedItem.Value.ToString())
                .Parameters.AddWithValue("@FabConQty", Convert.ToInt32(fabQty.Value))
                .Parameters.AddWithValue("@PowderQty", Convert.ToInt32(powderQty.Value))
                .Parameters.AddWithValue("@Total", Convert.ToInt32(txtTotal.Text))
                .Parameters.AddWithValue("@OrderNumber", Convert.ToInt32(txtOrderNum.Text))
                .Parameters.AddWithValue("@SelfService", If(cbxSelfService.Checked, "Yes", "No"))
                .Parameters.AddWithValue("@DateToPickUp", dtpDateToPickUp.Value)
                Command.Parameters.AddWithValue("@TimeToPickUp", txtTimeToPickUp.Text)
                .Parameters.AddWithValue("@PMorAM", dudPmAM.SelectedItem.ToString())
            End With
            Dim rowsAffected As Integer = Command.ExecuteNonQuery()
            If rowsAffected > 0 Then
                MessageBox.Show("Order updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' Update the corresponding row in the DataGridView
                Dim orderNumber As Integer = Convert.ToInt32(txtOrderNum.Text)
                Dim rowIndex As Integer = FindRowIndex(frmForm3.Orders, orderNumber)
                If rowIndex <> -1 Then
                    ' Update DataGridView row with new data
                    Dim updatedRow As DataGridViewRow = frmForm3.Orders.Rows(rowIndex)
                    updatedRow.Cells("CustomerName").Value = txtCustomerName.Text
                    updatedRow.Cells("Address").Value = txtCustomerAddress.Text
                    updatedRow.Cells("ContactNum").Value = txtCustomerContactNum.Text
                    updatedRow.Cells("GarmentType").Value = cmbGarments.SelectedItem.ToString()
                    updatedRow.Cells("Service").Value = cmbService.SelectedItem.ToString()
                    updatedRow.Cells("Kilogram").Value = Convert.ToDouble(txtKilogram.Text)
                    updatedRow.Cells("fabCon").Value = cmbfabcon.SelectedItem.Value.ToString()
                    updatedRow.Cells("Powder").Value = cmbpowder.SelectedItem.Value.ToString()
                    updatedRow.Cells("FabConQty").Value = Convert.ToInt32(fabQty.Value)
                    updatedRow.Cells("PowderQty").Value = Convert.ToInt32(powderQty.Value)
                    updatedRow.Cells("Total").Value = Convert.ToInt32(txtTotal.Text)
                    updatedRow.Cells("SelfService").Value = If(cbxSelfService.Checked, "Yes", "No")
                    updatedRow.Cells("DateToPickUp").Value = dtpDateToPickUp.Value
                    updatedRow.Cells("TimeToPickUp").Value = txtTimeToPickUp.Text
                    updatedRow.Cells("PMorAm").Value = dudPmAM.SelectedItem.ToString()
                    SaveFormDataToFile()
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

    Private Sub SaveFormDataToFile()
        ' Create a Document instance
        Dim doc As New Document()

        ' Showing a save file dialog to allow the user to choose the file location
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*"
        saveFileDialog.DefaultExt = ".pdf"
        saveFileDialog.AddExtension = True
        saveFileDialog.FileName = txtCustomerName.Text & " " & "Order_" & txtOrderNum.Text.Trim() & ".pdf"

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                ' Create a PdfWriter to write to the file
                Dim writer As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(saveFileDialog.FileName, FileMode.Create))

                ' Open the document for writing
                doc.Open()

                ' Create a Paragraph to hold the form data
                Dim paragraph As New Paragraph()
                paragraph.Alignment = Element.ALIGN_LEFT

                ' Add the form data to the Paragraph
                paragraph.Add("Receipt" & vbLf)
                paragraph.Add("---------------------------------------------------------------------------" & vbLf)
                paragraph.Add("Order Number: " & txtOrderNum.Text & vbLf)
                paragraph.Add("Customer Name: " & txtCustomerName.Text & vbLf)
                paragraph.Add("---------------------------------------------------------------------------" & vbLf)
                paragraph.Add("Date To Pick Up: " & dtpDateToPickUp.Value.ToString("dd-MM-yyyy") & vbLf)
                paragraph.Add("Time To Pick Up: " & txtTimeToPickUp.Text & dudPmAM.Text & vbLf)
                paragraph.Add("Service: " & cmbService.Text & vbLf)
                paragraph.Add("Kilogram: " & txtKilogram.Text & vbLf)
                paragraph.Add("Self Service: " & If(cbxSelfService.Checked, "Yes", "No") & vbLf)
                paragraph.Add("FabCon: " & cmbfabcon.Text & vbLf)
                paragraph.Add("FabCon Quantity: " & Convert.ToInt32(fabQty.Value) & vbLf)
                paragraph.Add("Powder: " & cmbpowder.Text & vbLf)
                paragraph.Add("Powder Quantity: " & Convert.ToInt32(powderQty.Value) & vbLf)
                paragraph.Add("---------------------------------------------------------------------------" & vbLf)
                paragraph.Add("Total: " & txtTotal.Text & vbLf)

                ' Add the Paragraph to the document
                doc.Add(paragraph)

                ' Show a message box indicating successful save
                MessageBox.Show("Form data saved successfully as PDF.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                ' Show a message box if there's an error
                MessageBox.Show("Error saving form data as PDF: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Close the document
                doc.Close()
            End Try
        End If
    End Sub

    Private Function IsValidContactNumber(contactNumber As String) As Boolean

        Dim cleanedNumber As String = New String(contactNumber.Where(Function(c) Char.IsDigit(c)).ToArray())

        If cleanedNumber.StartsWith("09") AndAlso cleanedNumber.Length = 11 Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Function IsValidTime(time As String) As Boolean
        ' Define a regular expression pattern for the time format (HH:mm)
        Dim pattern As String = "^([0-1]?[0-9]|2[0-3]):[0-5][0-9]$"

        ' the input matches the regular expression pattern
        Dim regex As New Regex(pattern)
        Return regex.IsMatch(time)
    End Function

    Private Sub txtKilogram_TextChanged(sender As Object, e As EventArgs) Handles txtKilogram.TextChanged
        If Not Regex.IsMatch(txtKilogram.Text, "^\d*$") Then
            ' If non-digit characters are found, display an error message
            lblNoKilo.Text = "Input a valid weight"
        Else
            ' Clear the error message if the entered text contains only digits
            lblNoKilo.Text = ""
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs)
        'Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this order?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        'If result = DialogResult.Yes Then
        '    ' Get the order number to delete
        '    Dim orderNumber As Integer = Convert.ToInt32(txtOrderNum.Text)

        '    ' Construct the DELETE query

        '    Try
        '        Connect()
        '        query = "DELETE FROM create_order WHERE OrderNumber = @OrderNumber"
        '        With Command
        '            .Connection = conn
        '            .CommandText = query
        '            Command.Parameters.AddWithValue("@OrderNumber", orderNumber)
        '            Dim rowsAffected As Integer = Command.ExecuteNonQuery()
        '            If rowsAffected > 0 Then
        '                MessageBox.Show("Order deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '                ' Remove the deleted row from the DataGridView
        '                Dim rowIndex As Integer = FindRowIndex(frmForm3.Orders, orderNumber)
        '                If rowIndex <> -1 Then
        '                    frmForm3.Orders.Rows.RemoveAt(rowIndex)
        '                End If
        '                ' Close the EditForm after successful deletion
        '                Me.Close()
        '            Else
        '                MessageBox.Show("Failed to delete order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '            End If
        '        End With
        '    Catch ex As Exception
        '        MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Finally
        '        conn.Close()
        '    End Try
        'End If

    End Sub


    Private Function FindRowIndex(dataGridView As DataGridView, orderNumber As Integer) As Integer
        For Each row As DataGridViewRow In dataGridView.Rows
            If row.Cells("OrderNumber").Value IsNot Nothing AndAlso Convert.ToInt32(row.Cells("OrderNumber").Value) = orderNumber Then
                Return row.Index
            End If
        Next
        Return -1
    End Function

    Private Sub EditForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmForm4.sldbtn.IsOn = SettingsManager.DarkModeEnabled
        ' Update UI elements based on the dark mode setting
        DarkModeManager.ToggleDarkMode(Me, SettingsManager.DarkModeEnabled)
        If frmForm3.Orders.SelectedRows.Count > 0 Then
            ' Get the selected row from the Orders DataGridView
            Dim selectedRow As DataGridViewRow = frmForm3.Orders.SelectedRows(0)

            ' Populate the form fields with data from the selected row
            txtOrderNum.Text = selectedRow.Cells("OrderNumber").Value.ToString()
            txtCustomerName.Text = selectedRow.Cells("CustomerName").Value.ToString()
            txtCustomerAddress.Text = selectedRow.Cells("Address").Value.ToString()
            txtCustomerContactNum.Text = selectedRow.Cells("ContactNum").Value.ToString()
            cmbGarments.SelectedItem = selectedRow.Cells("GarmentType").Value.ToString()
            cmbGarments.SelectedItem = selectedRow.Cells("Service").Value.ToString()
            txtKilogram.Text = selectedRow.Cells("Kilogram").Value.ToString()
            cmbfabcon.SelectedItem = selectedRow.Cells("fabCon").Value.ToString()
            cmbpowder.SelectedItem = selectedRow.Cells("Powder").Value.ToString()
            fabQty.Value = Convert.ToInt32(selectedRow.Cells("FabConQty").Value)
            powderQty.Value = Convert.ToInt32(selectedRow.Cells("PowderQty").Value)
            txtTotal.Text = selectedRow.Cells("Total").Value.ToString()
            cbxSelfService.Checked = If(selectedRow.Cells("SelfService").Value.ToString() = "Yes", True, False)
            dtpDateToPickUp.Value = Convert.ToDateTime(selectedRow.Cells("DateToPickUp").Value)
            txtTimeToPickUp.Text = selectedRow.Cells("TimeToPickUp").Value.ToString()
            dudPmAM.SelectedItem = selectedRow.Cells("PMorAm").Value.ToString()

            DropDownPopulate(GetFabConProducts(), cmbfabcon)
            DropDownPopulate(GetPowderProducts(), cmbpowder)
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        btnSave.PerformClick()

    End Sub

    Private Sub ComputeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComputeToolStripMenuItem.Click
        btnCompute.PerformClick()
    End Sub
    Private Sub btnCompute_Click_1(sender As Object, e As EventArgs) Handles btnCompute.Click
        lblNoKilo.Text = ""
        lblNoPowderQty.Text = ""
        lblNoFabQty.Text = ""

        ' Validate kilogram input
        Dim kilogram As Double
        If Not Double.TryParse(txtKilogram.Text, kilogram) OrElse kilogram <= 0 Then
            lblNoKilo.Text = "Please input a valid positive value for kilogram."
            Return
        End If

        ' Calculate load count based on garment type and kilogram
        Dim loadCount As Integer = 1
        Select Case cmbGarments.SelectedItem.ToString()
            Case "Regular Clothes"
                loadCount = Math.Ceiling(kilogram / 7) ' 1 load per 7 kilograms
            Case "Thin Blankets, Bed Sheets, Bath Towels, Pillow Case"
                loadCount = Math.Ceiling(kilogram / 4) ' 1 load per 4 kilograms
            Case "Comforters"
                loadCount = Math.Ceiling(kilogram / 3) ' 1 load per 3 kilograms
            Case "Maong Pants"
                loadCount = Math.Ceiling(kilogram / 6) ' 1 load per 6 kilograms
        End Select

        ' Calculate service price based on selected service type
        Dim servicePrice As Integer = 0
        Select Case cmbService.SelectedItem.ToString()
            Case "Wash"
                servicePrice = 80 * loadCount
            Case "Wash And Dry"
                servicePrice = 173 * loadCount
            Case "Complete Service"
                servicePrice = 185 * loadCount
            Case "Dry"
                servicePrice = 93 * loadCount
        End Select

        ' Apply self-service discount if selected
        If cbxSelfService.Checked Then
            servicePrice = CInt(servicePrice * 0.75) ' 25% discount
        End If

        ' Calculate fabcon price
        Dim fabconPrice As Integer = 0
        If cmbfabcon.Enabled AndAlso cmbfabcon.SelectedItem IsNot Nothing AndAlso cmbfabcon.SelectedItem.ToString() <> "none" Then
            Dim selectedFabcon As KeyValuePair(Of Integer, String) = DirectCast(cmbfabcon.SelectedItem, KeyValuePair(Of Integer, String))
            fabconPrice = Convert.ToInt32(fabQty.Value) * selectedFabcon.Key ' Use the Key as the amount
        End If

        ' Calculate powder price
        Dim powderPrice As Integer = 0
        If cmbpowder.Enabled AndAlso cmbpowder.SelectedItem IsNot Nothing AndAlso cmbpowder.SelectedItem.ToString() <> "none" Then
            Dim selectedPowder As KeyValuePair(Of Integer, String) = DirectCast(cmbpowder.SelectedItem, KeyValuePair(Of Integer, String))
            powderPrice = Convert.ToInt32(powderQty.Value) * selectedPowder.Key ' Use the Key as the amount
        End If

        ' Calculate total price
        Dim total As Integer = servicePrice + fabconPrice + powderPrice
        txtTotal.Text = total.ToString()
    End Sub

    Private Sub DropDownPopulate(ByVal products As List(Of KeyValuePair(Of Integer, String)), productcmb As ComboBox)
        Dim bindingList As New BindingList(Of KeyValuePair(Of Integer, String))(products)
        productcmb.DataSource = bindingList
        productcmb.DisplayMember = "Value"
        productcmb.ValueMember = "Key"
    End Sub
End Class
