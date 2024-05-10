<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditProducts
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAmount = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtProduct = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnBack = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbfabcon = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblNoFabQty = New System.Windows.Forms.Label()
        Me.lblNoPowderQty = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtId = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtId)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtAmount)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtProduct)
        Me.Panel1.Controls.Add(Me.btnBack)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cmbfabcon)
        Me.Panel1.Controls.Add(Me.lblNoFabQty)
        Me.Panel1.Controls.Add(Me.lblNoPowderQty)
        Me.Panel1.Controls.Add(Me.txtTotal)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1229, 628)
        Me.Panel1.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(44, 227)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 20)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "Type:"
        '
        'txtAmount
        '
        Me.txtAmount.BorderColor = System.Drawing.SystemColors.Control
        Me.txtAmount.BorderRadius = 8
        Me.txtAmount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAmount.DefaultText = ""
        Me.txtAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAmount.FillColor = System.Drawing.SystemColors.Control
        Me.txtAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAmount.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAmount.ForeColor = System.Drawing.Color.Black
        Me.txtAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAmount.Location = New System.Drawing.Point(138, 283)
        Me.txtAmount.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAmount.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAmount.PlaceholderText = ""
        Me.txtAmount.SelectedText = ""
        Me.txtAmount.Size = New System.Drawing.Size(296, 32)
        Me.txtAmount.TabIndex = 60
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(44, 288)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 20)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Amount:"
        '
        'txtProduct
        '
        Me.txtProduct.BorderColor = System.Drawing.SystemColors.Control
        Me.txtProduct.BorderRadius = 8
        Me.txtProduct.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtProduct.DefaultText = ""
        Me.txtProduct.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProduct.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProduct.FillColor = System.Drawing.SystemColors.Control
        Me.txtProduct.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProduct.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtProduct.ForeColor = System.Drawing.Color.Black
        Me.txtProduct.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProduct.Location = New System.Drawing.Point(138, 165)
        Me.txtProduct.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtProduct.Name = "txtProduct"
        Me.txtProduct.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtProduct.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtProduct.PlaceholderText = ""
        Me.txtProduct.SelectedText = ""
        Me.txtProduct.Size = New System.Drawing.Size(296, 32)
        Me.txtProduct.TabIndex = 58
        '
        'btnBack
        '
        Me.btnBack.Animated = True
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.BorderColor = System.Drawing.Color.LightCoral
        Me.btnBack.BorderRadius = 4
        Me.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnBack.FillColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnBack.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnBack.Location = New System.Drawing.Point(169, 353)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.PressedColor = System.Drawing.Color.AliceBlue
        Me.btnBack.Size = New System.Drawing.Size(97, 37)
        Me.btnBack.TabIndex = 57
        Me.btnBack.Text = "Back"
        Me.btnBack.UseTransparentBackground = True
        '
        'btnSave
        '
        Me.btnSave.Animated = True
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.BorderColor = System.Drawing.Color.LightCoral
        Me.btnSave.BorderRadius = 4
        Me.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSave.FillColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Image = Global.Mori.My.Resources.Resources.icons8_save_24
        Me.btnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSave.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnSave.Location = New System.Drawing.Point(48, 353)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.PressedColor = System.Drawing.Color.AliceBlue
        Me.btnSave.Size = New System.Drawing.Size(97, 37)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "Edit"
        Me.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnSave.UseTransparentBackground = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 170)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Product:"
        '
        'cmbfabcon
        '
        Me.cmbfabcon.BackColor = System.Drawing.Color.Transparent
        Me.cmbfabcon.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbfabcon.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbfabcon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbfabcon.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbfabcon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbfabcon.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbfabcon.ForeColor = System.Drawing.Color.Black
        Me.cmbfabcon.ItemHeight = 30
        Me.cmbfabcon.Items.AddRange(New Object() {"FabCon", "Powder"})
        Me.cmbfabcon.Location = New System.Drawing.Point(138, 219)
        Me.cmbfabcon.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbfabcon.Name = "cmbfabcon"
        Me.cmbfabcon.Size = New System.Drawing.Size(206, 36)
        Me.cmbfabcon.StartIndex = 0
        Me.cmbfabcon.TabIndex = 9
        '
        'lblNoFabQty
        '
        Me.lblNoFabQty.AutoSize = True
        Me.lblNoFabQty.ForeColor = System.Drawing.Color.Red
        Me.lblNoFabQty.Location = New System.Drawing.Point(1153, 486)
        Me.lblNoFabQty.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNoFabQty.Name = "lblNoFabQty"
        Me.lblNoFabQty.Size = New System.Drawing.Size(0, 13)
        Me.lblNoFabQty.TabIndex = 39
        '
        'lblNoPowderQty
        '
        Me.lblNoPowderQty.AutoSize = True
        Me.lblNoPowderQty.ForeColor = System.Drawing.Color.Red
        Me.lblNoPowderQty.Location = New System.Drawing.Point(1153, 578)
        Me.lblNoPowderQty.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNoPowderQty.Name = "lblNoPowderQty"
        Me.lblNoPowderQty.Size = New System.Drawing.Size(0, 13)
        Me.lblNoPowderQty.TabIndex = 40
        '
        'txtTotal
        '
        Me.txtTotal.AutoSize = True
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(940, 621)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(0, 18)
        Me.txtTotal.TabIndex = 41
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1227, 113)
        Me.Panel3.TabIndex = 27
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.DodgerBlue
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2CustomGradientPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(1227, 113)
        Me.Guna2CustomGradientPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(76, 125)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 20)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "ID:"
        '
        'txtId
        '
        Me.txtId.BorderColor = System.Drawing.SystemColors.Control
        Me.txtId.BorderRadius = 8
        Me.txtId.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtId.DefaultText = ""
        Me.txtId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtId.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtId.Enabled = False
        Me.txtId.FillColor = System.Drawing.SystemColors.Control
        Me.txtId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtId.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtId.ForeColor = System.Drawing.Color.Black
        Me.txtId.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtId.Location = New System.Drawing.Point(138, 118)
        Me.txtId.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtId.Name = "txtId"
        Me.txtId.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtId.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtId.PlaceholderText = ""
        Me.txtId.SelectedText = ""
        Me.txtId.Size = New System.Drawing.Size(83, 32)
        Me.txtId.TabIndex = 63
        '
        'EditProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1229, 628)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "EditProducts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditProducts"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAmount As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtProduct As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnBack As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbfabcon As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblNoFabQty As Label
    Friend WithEvents lblNoPowderQty As Label
    Friend WithEvents txtTotal As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtId As Guna.UI2.WinForms.Guna2TextBox
End Class
