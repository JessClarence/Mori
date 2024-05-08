<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmForm3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Orders = New System.Windows.Forms.DataGridView()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Guna2CustomGradientPanel2 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.btnCreate = New Guna.UI2.WinForms.Guna2Button()
        Me.OrderNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GarmentType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Service = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kilogram = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SelfService = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fabCon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FabConQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Powder = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PowderQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateToPickUp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeToPickUp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PMorAM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnPayment = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnEdit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel2.SuspendLayout()
        CType(Me.Orders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        Me.Guna2CustomGradientPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Orders)
        Me.Panel2.Controls.Add(Me.Guna2Button3)
        Me.Panel2.Controls.Add(Me.Guna2Button2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 113)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1488, 522)
        Me.Panel2.TabIndex = 1
        '
        'Orders
        '
        Me.Orders.AllowUserToAddRows = False
        Me.Orders.AllowUserToDeleteRows = False
        Me.Orders.AllowUserToResizeColumns = False
        Me.Orders.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Orders.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Orders.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OrderNumber, Me.CustomerName, Me.Address, Me.ContactNum, Me.GarmentType, Me.Service, Me.Kilogram, Me.SelfService, Me.fabCon, Me.FabConQty, Me.Powder, Me.PowderQty, Me.DateToPickUp, Me.TimeToPickUp, Me.PMorAM, Me.Total, Me.btnPayment, Me.btnEdit, Me.btnDelete})
        Me.Orders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Orders.Location = New System.Drawing.Point(0, 0)
        Me.Orders.Margin = New System.Windows.Forms.Padding(2)
        Me.Orders.Name = "Orders"
        Me.Orders.ReadOnly = True
        Me.Orders.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.Orders.RowHeadersVisible = False
        Me.Orders.RowHeadersWidth = 51
        Me.Orders.RowTemplate.Height = 24
        Me.Orders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Orders.Size = New System.Drawing.Size(1488, 522)
        Me.Orders.TabIndex = 6
        '
        'Guna2Button3
        '
        Me.Guna2Button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Guna2Button3.Animated = True
        Me.Guna2Button3.BorderRadius = 8
        Me.Guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button3.FillColor = System.Drawing.Color.Olive
        Me.Guna2Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button3.ForeColor = System.Drawing.Color.White
        Me.Guna2Button3.Image = Global.Mori.My.Resources.Resources.icons8_edit_50
        Me.Guna2Button3.Location = New System.Drawing.Point(1044, 658)
        Me.Guna2Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.PressedColor = System.Drawing.Color.Blue
        Me.Guna2Button3.Size = New System.Drawing.Size(78, 26)
        Me.Guna2Button3.TabIndex = 5
        Me.Guna2Button3.Text = "Edit"
        '
        'Guna2Button2
        '
        Me.Guna2Button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Guna2Button2.Animated = True
        Me.Guna2Button2.BorderRadius = 8
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.Image = Global.Mori.My.Resources.Resources.icons8_delete_24
        Me.Guna2Button2.Location = New System.Drawing.Point(962, 658)
        Me.Guna2Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.PressedColor = System.Drawing.Color.Blue
        Me.Guna2Button2.Size = New System.Drawing.Size(64, 26)
        Me.Guna2Button2.TabIndex = 4
        Me.Guna2Button2.Text = "Delete"
        '
        'txtSearch
        '
        Me.txtSearch.Animated = True
        Me.txtSearch.AutoSize = True
        Me.txtSearch.BackColor = System.Drawing.Color.Transparent
        Me.txtSearch.BorderColor = System.Drawing.Color.BlueViolet
        Me.txtSearch.BorderRadius = 8
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.DefaultText = ""
        Me.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.Location = New System.Drawing.Point(18, 59)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PlaceholderForeColor = System.Drawing.Color.Navy
        Me.txtSearch.PlaceholderText = "Search"
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.Size = New System.Drawing.Size(244, 28)
        Me.txtSearch.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(11, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = " Records"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1488, 113)
        Me.Panel1.TabIndex = 0
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Guna2CustomGradientPanel2)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label1)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.txtSearch)
        Me.Guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.DodgerBlue
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2CustomGradientPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(1488, 113)
        Me.Guna2CustomGradientPanel1.TabIndex = 0
        '
        'Guna2CustomGradientPanel2
        '
        Me.Guna2CustomGradientPanel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.btnCreate)
        Me.Guna2CustomGradientPanel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2CustomGradientPanel2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2CustomGradientPanel2.FillColor2 = System.Drawing.Color.Transparent
        Me.Guna2CustomGradientPanel2.FillColor3 = System.Drawing.Color.Transparent
        Me.Guna2CustomGradientPanel2.FillColor4 = System.Drawing.Color.Transparent
        Me.Guna2CustomGradientPanel2.Location = New System.Drawing.Point(1363, 0)
        Me.Guna2CustomGradientPanel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2CustomGradientPanel2.Name = "Guna2CustomGradientPanel2"
        Me.Guna2CustomGradientPanel2.Size = New System.Drawing.Size(125, 113)
        Me.Guna2CustomGradientPanel2.TabIndex = 7
        '
        'btnCreate
        '
        Me.btnCreate.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCreate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCreate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCreate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCreate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCreate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCreate.ForeColor = System.Drawing.Color.White
        Me.btnCreate.Location = New System.Drawing.Point(20, 32)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(93, 45)
        Me.btnCreate.TabIndex = 2
        Me.btnCreate.Text = "CREATE"
        '
        'OrderNumber
        '
        Me.OrderNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.OrderNumber.Frozen = True
        Me.OrderNumber.HeaderText = "Order Number"
        Me.OrderNumber.MinimumWidth = 6
        Me.OrderNumber.Name = "OrderNumber"
        Me.OrderNumber.ReadOnly = True
        Me.OrderNumber.Width = 90
        '
        'CustomerName
        '
        Me.CustomerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CustomerName.Frozen = True
        Me.CustomerName.HeaderText = "Customer Name"
        Me.CustomerName.MinimumWidth = 6
        Me.CustomerName.Name = "CustomerName"
        Me.CustomerName.ReadOnly = True
        Me.CustomerName.Width = 98
        '
        'Address
        '
        Me.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Address.Frozen = True
        Me.Address.HeaderText = "Address"
        Me.Address.MinimumWidth = 6
        Me.Address.Name = "Address"
        Me.Address.ReadOnly = True
        Me.Address.Width = 70
        '
        'ContactNum
        '
        Me.ContactNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.ContactNum.Frozen = True
        Me.ContactNum.HeaderText = "Contact Number"
        Me.ContactNum.MinimumWidth = 6
        Me.ContactNum.Name = "ContactNum"
        Me.ContactNum.ReadOnly = True
        '
        'GarmentType
        '
        Me.GarmentType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.GarmentType.Frozen = True
        Me.GarmentType.HeaderText = "Garment Type"
        Me.GarmentType.MinimumWidth = 6
        Me.GarmentType.Name = "GarmentType"
        Me.GarmentType.ReadOnly = True
        Me.GarmentType.Width = 91
        '
        'Service
        '
        Me.Service.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Service.Frozen = True
        Me.Service.HeaderText = "Service"
        Me.Service.MinimumWidth = 6
        Me.Service.Name = "Service"
        Me.Service.ReadOnly = True
        Me.Service.Width = 68
        '
        'Kilogram
        '
        Me.Kilogram.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Kilogram.Frozen = True
        Me.Kilogram.HeaderText = "Kilogram"
        Me.Kilogram.MinimumWidth = 6
        Me.Kilogram.Name = "Kilogram"
        Me.Kilogram.ReadOnly = True
        Me.Kilogram.Width = 72
        '
        'SelfService
        '
        Me.SelfService.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SelfService.Frozen = True
        Me.SelfService.HeaderText = "Self Service"
        Me.SelfService.MinimumWidth = 6
        Me.SelfService.Name = "SelfService"
        Me.SelfService.ReadOnly = True
        Me.SelfService.Width = 82
        '
        'fabCon
        '
        Me.fabCon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.fabCon.Frozen = True
        Me.fabCon.HeaderText = "FabCon"
        Me.fabCon.MinimumWidth = 6
        Me.fabCon.Name = "fabCon"
        Me.fabCon.ReadOnly = True
        Me.fabCon.Width = 69
        '
        'FabConQty
        '
        Me.FabConQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.FabConQty.Frozen = True
        Me.FabConQty.HeaderText = "FabCon Qty"
        Me.FabConQty.MinimumWidth = 6
        Me.FabConQty.Name = "FabConQty"
        Me.FabConQty.ReadOnly = True
        Me.FabConQty.Width = 81
        '
        'Powder
        '
        Me.Powder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Powder.Frozen = True
        Me.Powder.HeaderText = "Powder"
        Me.Powder.MinimumWidth = 6
        Me.Powder.Name = "Powder"
        Me.Powder.ReadOnly = True
        Me.Powder.Width = 68
        '
        'PowderQty
        '
        Me.PowderQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.PowderQty.Frozen = True
        Me.PowderQty.HeaderText = "Powder Qty"
        Me.PowderQty.MinimumWidth = 6
        Me.PowderQty.Name = "PowderQty"
        Me.PowderQty.ReadOnly = True
        Me.PowderQty.Width = 80
        '
        'DateToPickUp
        '
        Me.DateToPickUp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle2.Format = "MM-dd-yyyy"
        Me.DateToPickUp.DefaultCellStyle = DataGridViewCellStyle2
        Me.DateToPickUp.HeaderText = "Date To Pick Up"
        Me.DateToPickUp.MinimumWidth = 6
        Me.DateToPickUp.Name = "DateToPickUp"
        Me.DateToPickUp.ReadOnly = True
        Me.DateToPickUp.Width = 90
        '
        'TimeToPickUp
        '
        Me.TimeToPickUp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TimeToPickUp.HeaderText = "Time to Pick Up"
        Me.TimeToPickUp.MinimumWidth = 6
        Me.TimeToPickUp.Name = "TimeToPickUp"
        Me.TimeToPickUp.ReadOnly = True
        Me.TimeToPickUp.Width = 87
        '
        'PMorAM
        '
        Me.PMorAM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.PMorAM.HeaderText = "AM/PM"
        Me.PMorAM.MinimumWidth = 6
        Me.PMorAM.Name = "PMorAM"
        Me.PMorAM.ReadOnly = True
        Me.PMorAM.Width = 69
        '
        'Total
        '
        Me.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Total.HeaderText = "Total"
        Me.Total.MinimumWidth = 6
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'btnPayment
        '
        Me.btnPayment.HeaderText = "Payment"
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.ReadOnly = True
        Me.btnPayment.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.btnPayment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.btnPayment.Text = "PAYMENT"
        Me.btnPayment.UseColumnTextForButtonValue = True
        '
        'btnEdit
        '
        Me.btnEdit.HeaderText = "Edit"
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.ReadOnly = True
        Me.btnEdit.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.btnEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.btnEdit.Text = "EDIT"
        Me.btnEdit.UseColumnTextForButtonValue = True
        '
        'btnDelete
        '
        Me.btnDelete.HeaderText = "Delete"
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.ReadOnly = True
        Me.btnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.btnDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseColumnTextForButtonValue = True
        '
        'frmForm3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1488, 635)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmForm3"
        Me.Text = "frmForm3"
        Me.Panel2.ResumeLayout(False)
        CType(Me.Orders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.Guna2CustomGradientPanel1.PerformLayout()
        Me.Guna2CustomGradientPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Orders As DataGridView
    Friend WithEvents btnCreate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2CustomGradientPanel2 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents OrderNumber As DataGridViewTextBoxColumn
    Friend WithEvents CustomerName As DataGridViewTextBoxColumn
    Friend WithEvents Address As DataGridViewTextBoxColumn
    Friend WithEvents ContactNum As DataGridViewTextBoxColumn
    Friend WithEvents GarmentType As DataGridViewTextBoxColumn
    Friend WithEvents Service As DataGridViewTextBoxColumn
    Friend WithEvents Kilogram As DataGridViewTextBoxColumn
    Friend WithEvents SelfService As DataGridViewTextBoxColumn
    Friend WithEvents fabCon As DataGridViewTextBoxColumn
    Friend WithEvents FabConQty As DataGridViewTextBoxColumn
    Friend WithEvents Powder As DataGridViewTextBoxColumn
    Friend WithEvents PowderQty As DataGridViewTextBoxColumn
    Friend WithEvents DateToPickUp As DataGridViewTextBoxColumn
    Friend WithEvents TimeToPickUp As DataGridViewTextBoxColumn
    Friend WithEvents PMorAM As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents btnPayment As DataGridViewButtonColumn
    Friend WithEvents btnEdit As DataGridViewButtonColumn
    Friend WithEvents btnDelete As DataGridViewButtonColumn
End Class
