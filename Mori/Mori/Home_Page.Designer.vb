<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home_Page
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
        Me.components = New System.ComponentModel.Container()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btnSignout = New System.Windows.Forms.Button()
        Me.btnAboutus = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PanelContainer = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.PanelMenu.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.PanelMenu.Controls.Add(Me.btnSignout)
        Me.PanelMenu.Controls.Add(Me.btnAboutus)
        Me.PanelMenu.Controls.Add(Me.btnSettings)
        Me.PanelMenu.Controls.Add(Me.btnUpdate)
        Me.PanelMenu.Controls.Add(Me.btnCreate)
        Me.PanelMenu.Controls.Add(Me.btnDashboard)
        Me.PanelMenu.Controls.Add(Me.Panel1)
        Me.PanelMenu.Controls.Add(Me.Panel2)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(234, 772)
        Me.PanelMenu.TabIndex = 0
        '
        'btnSignout
        '
        Me.btnSignout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnSignout.FlatAppearance.BorderSize = 0
        Me.btnSignout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSignout.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignout.ForeColor = System.Drawing.Color.Navy
        Me.btnSignout.Image = Global.Mori.My.Resources.Resources.icons8_sign_out_50
        Me.btnSignout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSignout.Location = New System.Drawing.Point(0, 711)
        Me.btnSignout.Name = "btnSignout"
        Me.btnSignout.Size = New System.Drawing.Size(234, 61)
        Me.btnSignout.TabIndex = 7
        Me.btnSignout.Text = "Sign out"
        Me.btnSignout.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSignout.UseVisualStyleBackColor = True
        '
        'btnAboutus
        '
        Me.btnAboutus.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAboutus.FlatAppearance.BorderSize = 0
        Me.btnAboutus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAboutus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAboutus.ForeColor = System.Drawing.Color.Navy
        Me.btnAboutus.Image = Global.Mori.My.Resources.Resources.icons8_queue_48
        Me.btnAboutus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAboutus.Location = New System.Drawing.Point(0, 391)
        Me.btnAboutus.Name = "btnAboutus"
        Me.btnAboutus.Size = New System.Drawing.Size(234, 61)
        Me.btnAboutus.TabIndex = 6
        Me.btnAboutus.Text = "About us"
        Me.btnAboutus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAboutus.UseVisualStyleBackColor = True
        '
        'btnSettings
        '
        Me.btnSettings.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSettings.FlatAppearance.BorderSize = 0
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.ForeColor = System.Drawing.Color.Navy
        Me.btnSettings.Image = Global.Mori.My.Resources.Resources.icons8_add_key_48
        Me.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSettings.Location = New System.Drawing.Point(0, 330)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(234, 61)
        Me.btnSettings.TabIndex = 5
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.Navy
        Me.btnUpdate.Image = Global.Mori.My.Resources.Resources.icons8_rotate_left_48
        Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdate.Location = New System.Drawing.Point(0, 269)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(234, 61)
        Me.btnUpdate.TabIndex = 4
        Me.btnUpdate.Text = "Update Order"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnCreate
        '
        Me.btnCreate.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCreate.FlatAppearance.BorderSize = 0
        Me.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.ForeColor = System.Drawing.Color.Navy
        Me.btnCreate.Image = Global.Mori.My.Resources.Resources.icons8_add_administrator_48
        Me.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCreate.Location = New System.Drawing.Point(0, 208)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(234, 61)
        Me.btnCreate.TabIndex = 3
        Me.btnCreate.Text = "Create Order"
        Me.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnDashboard
        '
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.Navy
        Me.btnDashboard.Image = Global.Mori.My.Resources.Resources.icons8_user_menu_female_48
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.Location = New System.Drawing.Point(0, 147)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(234, 61)
        Me.btnDashboard.TabIndex = 2
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDashboard.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 75)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(234, 72)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel2.Controls.Add(Me.btnMenu)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(234, 75)
        Me.Panel2.TabIndex = 0
        '
        'btnMenu
        '
        Me.btnMenu.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnMenu.FlatAppearance.BorderSize = 0
        Me.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenu.ForeColor = System.Drawing.Color.Navy
        Me.btnMenu.Image = Global.Mori.My.Resources.Resources.icons8_hamburger_50__1_
        Me.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMenu.Location = New System.Drawing.Point(12, 0)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(222, 75)
        Me.btnMenu.TabIndex = 3
        Me.btnMenu.Text = "Mori laundry"
        Me.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Teal
        Me.Panel3.Location = New System.Drawing.Point(234, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(810, 35)
        Me.Panel3.TabIndex = 1
        '
        'PanelContainer
        '
        Me.PanelContainer.BackColor = System.Drawing.Color.White
        Me.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContainer.ForeColor = System.Drawing.Color.Navy
        Me.PanelContainer.Location = New System.Drawing.Point(234, 0)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.Size = New System.Drawing.Size(810, 772)
        Me.PanelContainer.TabIndex = 2
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Home_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1044, 772)
        Me.Controls.Add(Me.PanelContainer)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PanelMenu)
        Me.Name = "Home_Page"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home_Page"
        Me.PanelMenu.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PanelContainer As Panel
    Friend WithEvents btnMenu As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents btnSignout As Button
    Friend WithEvents btnAboutus As Button
    Friend WithEvents btnSettings As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents Panel1 As Panel
End Class
