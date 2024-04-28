Public Class Home_Page
    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        If PanelMenu.Width = 220 Then
            Timer2.Enabled = True
        ElseIf PanelMenu.Width = 60 Then
            Timer1.Enabled = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If PanelMenu.Width >= 220 Then
            Me.Timer1.Enabled = False
        Else
            Me.PanelMenu.Width = PanelMenu.Width + 5

        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If PanelMenu.Width <= 60 Then
            Me.Timer2.Enabled = False
        Else
            Me.PanelMenu.Width = PanelMenu.Width - 5

        End If
    End Sub


    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        ShowFormInPanel(frmForm1)
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        ShowFormInPanel(frmForm2)
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
    Private Sub ShowFormInPanel(formToShow As Form)
        PanelContainer.Controls.Clear()

        If Not PanelContainer.Controls.Contains(formToShow) Then
            formToShow.TopLevel = False
            PanelContainer.Controls.Add(formToShow)
            formToShow.Dock = DockStyle.Fill
            formToShow.BringToFront()
            formToShow.Show()
        End If
    End Sub


End Class


