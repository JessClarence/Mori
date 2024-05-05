'About us
Public Class frmForm5
    Private Sub cmbService_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmForm5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmForm4.sldbtn.IsOn = SettingsManager.DarkModeEnabled
        ' Update UI elements based on the dark mode setting
        DarkModeManager.ToggleDarkMode(Me, SettingsManager.DarkModeEnabled)
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub
End Class