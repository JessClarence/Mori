'Settings
Imports System.Web.Configuration
Imports AltoControls

Public Class frmForm4

    Private Sub sldbtn_Click(sender As Object, e As EventArgs) Handles sldbtn.Click
        SettingsManager.DarkModeEnabled = sldbtn.IsOn
        ' Toggle dark mode based on the new setting
        DarkModeManager.ToggleDarkMode(Me, sldbtn.IsOn)
    End Sub
    Private Sub frmForm4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sldbtn.IsOn = SettingsManager.DarkModeEnabled
        ' Update UI elements based on the dark mode setting
        DarkModeManager.ToggleDarkMode(Me, SettingsManager.DarkModeEnabled)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        ChangePass.Show()
    End Sub
End Class
