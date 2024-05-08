Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Guna.UI2.WinForms

Public Class Home_Page
    'Showing Panels for Create Order, Update Records, Settings and About Us
    Private Sub btnCreate_Click(sender As Object, e As EventArgs)
        ShowFormInPanel(CreateOrder)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ShowFormInPanel(frmForm3)
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        ShowFormInPanel(frmForm4)
    End Sub

    Private Sub btnAboutus_Click(sender As Object, e As EventArgs) Handles btnAboutus.Click
        ShowFormInPanel(frmForm5)
    End Sub
    Public Sub ShowFormInPanel(formToShow As Form)
        PanelContainer.Controls.Clear()

        If Not PanelContainer.Controls.Contains(formToShow) Then
            formToShow.TopLevel = False
            PanelContainer.Controls.Add(formToShow)
            formToShow.Dock = DockStyle.Fill
            formToShow.BringToFront()
            formToShow.Show()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()
        Login_Form.Show()
    End Sub

    Private Sub Home_Page_FormClosed(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        HorizontalScroll.Visible = True
        SettingsManager.DarkModeEnabled = frmForm4.sldbtn.IsOn
    End Sub

    Private Sub Home_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        frmForm4.sldbtn.IsOn = SettingsManager.DarkModeEnabled
        DarkModeManager.ToggleDarkMode(Me, SettingsManager.DarkModeEnabled)
    End Sub

    Private Sub btnTransHistory_Click(sender As Object, e As EventArgs) Handles btnTransHistory.Click
        ShowFormInPanel(TransactionHistory)
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Guna2CustomGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2CustomGradientPanel1.Paint

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
        Login_Form.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click
        ShowFormInPanel(Products)
    End Sub
End Class


