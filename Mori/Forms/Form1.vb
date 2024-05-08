Imports System.Diagnostics.Eventing
Imports System.Web.UI.WebControls
Imports MySql.Data.MySqlClient

Public Class Login_Form

    'Login
    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Try

            Connect()
            query = "SELECT * FROM `log_in` WHERE Username = @Username AND Password = @Password"
            With Command
                .Connection = conn
                .CommandText = query
                .Parameters.Clear()
                .Parameters.AddWithValue("@Username", txtUsername.Text.Trim)
                .Parameters.AddWithValue("@Password", txtPassword.Text.Trim)
                reader = .ExecuteReader()

            End With

            If reader.Read Then
                MsgBox("Logged In Successfully", MsgBoxStyle.Information)
                Home_Page.Show()
                Me.Hide()
            Else
                MsgBox("Invalid Username or Password", MsgBoxStyle.Critical)
                txtPassword.Clear()
                txtUsername.Clear()
                txtUsername.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)

        End Try

    End Sub
    'Show ChangePassword Form
    Private Sub lblChangePass_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblChangePass.LinkClicked
        ChangePass.Show()
    End Sub
    'When DarkMode is On 
    Private Sub Login_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmForm4.sldbtn.IsOn = SettingsManager.DarkModeEnabled
        DarkModeManager.ToggleDarkMode(Me, SettingsManager.DarkModeEnabled)
    End Sub
    'Exit
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Close()
    End Sub


End Class