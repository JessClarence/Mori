Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing.Reader
Imports System.Drawing.Printing
Imports System.Globalization
Imports System.Text.RegularExpressions
Imports Guna.UI2.WinForms
Imports K4os.Compression.LZ4.Streams.Adapters
Imports System.IO
Imports System.Text
Imports Mysqlx.Crud
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Menu
Imports System.ComponentModel

Public Class CreateOrder
    Private Sub btnCompute_Click(sender As Object, e As EventArgs)
        lblNoKilo.Text = ""
        lblNoPowderQty.Text = ""
        lblNoFabQty.Text = ""
        emptyName.Text = ""
        emptyAddress.Text = ""
        emptyNumber.Text = ""
        emptyTime.Text = ""
        errordate.Text = ""
        pmam.Text = ""

        Const LOAD_THRESHOLD As Integer = 7
        Const ADDITIONAL_LOAD_PRICE As Integer = 0.25

        Dim kilogram As Double

        ' Check if kilogram input is valid
        If Not Double.TryParse(txtKilogram.Text, kilogram) Then
            lblNoKilo.Text = "Please input a valid value for kilogram."
            Return
        End If

        ' Check if kilogram is empty
        If kilogram <= 0 Then
            lblNoKilo.Text = "Please input a value for kilogram."
            Return
        End If

        ' Calculate load count based on garment type
        Dim loadCount As Integer = 1
        Select Case cmbGarments.SelectedItem.ToString()
            Case "Regular Clothes"
                ' Check if kilogram exceeds threshold, increment loadCount accordingly
                If kilogram > LOAD_THRESHOLD Then
                    loadCount = Math.Ceiling(kilogram / LOAD_THRESHOLD)
                    If kilogram > 7 Then
                        loadCount += 1 ' Additional load for excess weight
                    End If
                End If
            Case "Thin Blankets, Bed Sheets, Bath Towels, Pillow Case"
                loadCount = Math.Ceiling(kilogram / 4)
                If kilogram > 4 Then
                    loadCount += 1 ' Additional load for excess weight
                End If
            Case "Comforters"
                loadCount = Math.Ceiling(kilogram / 3)
                If kilogram > 3 Then
                    loadCount += 1 ' Additional load for excess weight
                End If
            Case "Maong Pants"
                loadCount = Math.Ceiling(kilogram / 6)
                If kilogram > 6 Then
                    loadCount += 1 ' Additional load for excess weight
                End If
        End Select

        ' Calculate service price
        Dim servicePrice As Integer = 0
        Select Case cmbService.SelectedItem.ToString()
            Case "Wash"
                servicePrice = 80
            Case "Wash And Dry"
                servicePrice = 173
            Case "Complete Service"
                servicePrice = 185
            Case "Dry"
                servicePrice = 93
        End Select

        ' Apply load count to service price
        servicePrice *= loadCount

        ' Check if self-service discount applies
        If cbxSelfService.Checked Then
            servicePrice -= CInt(servicePrice * 0.25)
        End If

        ' Calculate fabcon price
        Dim fabconPrice As Integer = 0
        If cmbfabcon.Enabled AndAlso cmbfabcon.SelectedItem.ToString() <> "none" Then
            If Convert.ToInt32(fabQty.Value) = 0 Then
                lblNoFabQty.Text = "Quantity for fabcon cannot be empty."
                Return
            End If
            fabconPrice = Convert.ToInt32(fabQty.Value) * GetFabconPrice(cmbfabcon.SelectedItem.ToString())
        End If

        ' Calculate powder price
        Dim powderPrice As Integer = 0
        If cmbpowder.Enabled AndAlso cmbpowder.SelectedItem.ToString() <> "none" Then
            If Convert.ToInt32(powderQty.Value) = 0 Then
                lblNoPowderQty.Text = "Quantity for powder cannot be empty."
                Return
            End If
            powderPrice = Convert.ToInt32(powderQty.Value) * GetPowderPrice(cmbpowder.SelectedItem.ToString())
        End If

        ' Calculate total price
        Dim total As Integer = servicePrice + fabconPrice + powderPrice
        txtTotal.Text = total.ToString()
    End Sub
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
            ' display an error message
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
            'display an error message if date is in the past, 
            errordate.Text = "Selected date must be in the future."
            Return
        End If

        If String.IsNullOrEmpty(txtKilogram.Text) Then
            MessageBox.Show("Please select an order before saving.", "No Order Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbService.Focus()
            Return
        End If

        ' Connect to database and insert data
        Try
            Connect()
            If String.IsNullOrEmpty(txtTotal.Text) Then
                MessageBox.Show("Compute order before saving", "Compute Order", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                btnCompute.Focus()
                Return
            End If
            query = "INSERT INTO create_order (CustomerName, Address, ContactNum,GarmentType, Service, Kilogram, fabCon, powder, FabConQty, PowderQty, Total, OrderNumber, SelfService, TimeToPickUp, DateToPickUp,PMorAM,payment) VALUES (@CustomerName, @Address, @ContactNum,@GarmentType, @Service, @Kilogram, @fabCon, @powder, @FabConQty, @PowderQty, @Total, @OrderNumber, @SelfService, @TimeToPickUp, @DateToPickUp, @PMorAM,@payment)"
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
                Command.Parameters.AddWithValue("@payment", "process")
                .Parameters.AddWithValue("@PMorAM", dudPmAM.SelectedItem.ToString())
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
        SaveFormDataToFile()
        ResetForm()
    End Sub
    Private Sub RefreshData()
        Try
            frmForm3.Orders.Rows.Clear()

            Dim query As String = "SELECT * FROM create_order"
            Connect()
            Command.CommandText = query
            reader = Command.ExecuteReader()

            While reader.Read()
                Dim index As Integer = frmForm3.Orders.Rows.Add()
                ' Populate DataGridView columns with data from database reader
                frmForm3.Orders.Rows(index).Cells("OrderNumber").Value = reader("OrderNumber").ToString()
                frmForm3.Orders.Rows(index).Cells("CustomerName").Value = reader("CustomerName").ToString()
                frmForm3.Orders.Rows(index).Cells("Address").Value = reader("Address").ToString()
                frmForm3.Orders.Rows(index).Cells("ContactNum").Value = reader("ContactNum").ToString()
                frmForm3.Orders.Rows(index).Cells("DateToPickUp").Value = Convert.ToDateTime(reader("DateToPickUp"))
                frmForm3.Orders.Rows(index).Cells("TimeToPickUp").Value = reader("TimeToPickUp").ToString()
                frmForm3.Orders.Rows(index).Cells("PMorAM").Value = reader("PMorAM").ToString()
                frmForm3.Orders.Rows(index).Cells("GarmentType").Value = reader("GarmentType").ToString()
                frmForm3.Orders.Rows(index).Cells("Service").Value = reader("Service").ToString()
                frmForm3.Orders.Rows(index).Cells("Kilogram").Value = reader("Kilogram").ToString()
                frmForm3.Orders.Rows(index).Cells("SelfService").Value = If(reader("SelfService").ToString().ToLower() = "yes", True, False)
                frmForm3.Orders.Rows(index).Cells("fabCon").Value = reader("fabCon").ToString()
                frmForm3.Orders.Rows(index).Cells("Powder").Value = reader("Powder").ToString()
                frmForm3.Orders.Rows(index).Cells("FabConQty").Value = Convert.ToInt32(reader("FabConQty"))
                frmForm3.Orders.Rows(index).Cells("PowderQty").Value = Convert.ToInt32(reader("PowderQty"))
                frmForm3.Orders.Rows(index).Cells("Total").Value = reader("Total").ToString()
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

    'If ContactNumber is not valid
    Private Function IsValidContactNumber(contactNumber As String) As Boolean
        Dim cleanedNumber As String = New String(contactNumber.Where(Function(c) Char.IsDigit(c)).ToArray())

        ' Check if the cleaned number starts with "09" and has a length of 11 digits
        If cleanedNumber.StartsWith("09") AndAlso cleanedNumber.Length = 11 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub ResetForm()
        txtCustomerName.Text = ""
        txtCustomerAddress.Text = ""
        txtCustomerContactNum.Text = ""
        cmbService.SelectedIndex = 0
        txtKilogram.Text = ""
        cmbfabcon.SelectedIndex = 0
        fabQty.Value = 0
        cmbpowder.SelectedIndex = 0
        powderQty.Value = 0
        txtTotal.Text = ""
        cbxSelfService.Checked = False
        dtpDateToPickUp.Value = Date.Now
        txtTimeToPickUp.Text = ""

        ' Generate a new order number
        Dim rnd As New Random()
        Dim orderNumber As Integer = rnd.Next(100000, 999999)
        txtOrderNum.Text = orderNumber.ToString()

        ' Set focus on the first empty field
        If String.IsNullOrWhiteSpace(txtCustomerName.Text) Then
            txtCustomerName.Focus()
        ElseIf String.IsNullOrWhiteSpace(txtCustomerAddress.Text) Then
            txtCustomerAddress.Focus()
        ElseIf String.IsNullOrWhiteSpace(txtCustomerContactNum.Text) Then
            txtCustomerContactNum.Focus()
        ElseIf cmbService.SelectedIndex = -1 Then
            cmbService.Focus()
        ElseIf String.IsNullOrWhiteSpace(txtKilogram.Text) Then
            txtKilogram.Focus()
        ElseIf cmbfabcon.SelectedIndex = -1 Then
            cmbfabcon.Focus()
        ElseIf cmbpowder.SelectedIndex = -1 Then
            cmbpowder.Focus()
        End If
    End Sub
    Private Sub frmForm2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Generate the random order number when the form loads
        frmForm4.sldbtn.IsOn = SettingsManager.DarkModeEnabled
        DarkModeManager.ToggleDarkMode(Me, SettingsManager.DarkModeEnabled)
        AutoScroll = True
        Dim rnd As New Random()
        Dim orderNumber As Integer = rnd.Next(100000, 999999)
        'added code '
        Dim startdate_v As Date = Date.Parse(dtpDateToPickUp.Value)
        txtOrderNum.Text = orderNumber.ToString()
        dtpDateToPickUp.Value = Date.Now
        dudPmAM.SelectedItem = "AM"
        'dropdown'
        DropDownPopulate(GetFabConProducts(), cmbfabcon)
        DropDownPopulate(GetPowderProducts(), cmbpowder)

    End Sub

    Private Function IsValidTime(time As String) As Boolean
        ' Define a regular expression pattern for the time format (HH:mm)
        Dim pattern As String = "^([0-1]?[0-9]|2[0-3]):[0-5][0-9]$"

        ' Check if the input matches the regular expression pattern
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

    Private Sub btnCompute_Click_1(sender As Object, e As EventArgs) Handles btnCompute.Click
        lblNoKilo.Text = ""
        lblNoPowderQty.Text = ""
        lblNoFabQty.Text = ""
        emptyName.Text = ""
        emptyAddress.Text = ""
        emptyNumber.Text = ""
        emptyTime.Text = ""
        errordate.Text = ""
        pmam.Text = ""

        Const LOAD_THRESHOLD As Integer = 7
        Const ADDITIONAL_LOAD_PRICE As Integer = 0.25

        Dim kilogram As Double

        ' Check if kilogram input is valid
        If Not Double.TryParse(txtKilogram.Text, kilogram) Then
            lblNoKilo.Text = "Please input a valid value for kilogram."
            Return
        End If

        ' Check if kilogram is empty
        If kilogram <= 0 Then
            lblNoKilo.Text = "Please input a value for kilogram."
            Return
        End If

        Dim loadCount As Integer = 1
        Select Case cmbGarments.SelectedItem.ToString()
            Case "Regular Clothes"
                If kilogram > LOAD_THRESHOLD Then
                    loadCount = Math.Ceiling(kilogram / LOAD_THRESHOLD)
                End If
            Case "Thin Blankets, Bed Sheets, Bath Towels, Pillow Case"
                loadCount = Math.Ceiling(kilogram / 4)
            Case "Comforters"
                loadCount = Math.Ceiling(kilogram / 3)
            Case "Maong Pants"
                loadCount = Math.Ceiling(kilogram / 6)
        End Select

        ' Calculate service price
        Dim servicePrice As Integer = 0
        Select Case cmbService.SelectedItem.ToString()
            Case "Wash"
                servicePrice = 80
            Case "Wash And Dry"
                servicePrice = 173
            Case "Complete Service"
                servicePrice = 185
            Case "Dry"
                servicePrice = 93
        End Select

        ' Apply load count to service price
        servicePrice *= loadCount

        ' Check if self-service discount applies
        If cbxSelfService.Checked Then
            servicePrice -= CInt(servicePrice * 0.25)
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

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        btnSave.PerformClick()
    End Sub

    Private Sub ComputeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComputeToolStripMenuItem.Click
        btnCompute.PerformClick()
    End Sub

    Private Sub Guna2CustomGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2CustomGradientPanel1.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Home_Page.ShowFormInPanel(frmForm3)
        GetOrders(frmForm3.Orders)
    End Sub

    Private Sub DropDownPopulate(ByVal products As List(Of KeyValuePair(Of Integer, String)), productcmb As ComboBox)
        Dim bindingList As New BindingList(Of KeyValuePair(Of Integer, String))(products)
        productcmb.DataSource = bindingList
        productcmb.DisplayMember = "Value"
        productcmb.ValueMember = "Key"
    End Sub

End Class

