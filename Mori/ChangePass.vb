Public Class ChangePass
    Private Sub btnChangePass_Click(sender As Object, e As EventArgs) Handles btnChangePass.Click
        Try
            COnnect()
            Dim newPassword As String = txtNewPass.Text.Trim()
            Dim oldPassword As String = txtOldPass.Text.Trim()
            Dim retypePassword As String = txtReType.Text.Trim()

            ' Check if the old password matches
            query = "SELECT * FROM `log_in` WHERE Password = @Password"
            With Command
                Command.Connection = conn
                Command.CommandText = query
                Command.Parameters.Clear()
                Command.Parameters.AddWithValue("@Password", oldPassword)
                reader = Command.ExecuteReader()
            End With
            If reader.Read Then
                reader.Close()
                If newPassword = retypePassword Then
                    If HasSpecialCharacters(newPassword) Then
                        query = "UPDATE `log_in` SET `Password` = @NewPassword WHERE Password = @OldPassword"
                        With Command
                            Command.Connection = conn
                            Command.CommandText = query
                            Command.Parameters.Clear()
                            Command.Parameters.AddWithValue("@NewPassword", newPassword)
                            Command.Parameters.AddWithValue("@OldPassword", oldPassword)
                            Command.ExecuteNonQuery()
                        End With

                        MsgBox("Changed Password Successfully", MsgBoxStyle.Information)
                        txtNewPass.Clear()
                        txtOldPass.Clear()
                        txtReType.Clear()
                        Login_Form.Show()
                        Me.Hide()
                    Else
                        MsgBox("Password should contain at least one special character.", MsgBoxStyle.Critical)
                        txtNewPass.Clear()
                        txtReType.Clear()
                        txtNewPass.Focus()
                    End If
                Else
                        MsgBox("New passwords do not match", MsgBoxStyle.Critical)
                    txtNewPass.Clear()
                    txtReType.Clear()
                    txtNewPass.Focus()
                End If
            Else
                MsgBox("Old password is incorrect", MsgBoxStyle.Critical)
                txtNewPass.Clear()
                txtReType.Clear()
                txtOldPass.Clear()
                txtOldPass.Focus()
            End If
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub ChangePass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartPosition = FormStartPosition.CenterScreen
        frmForm4.sldbtn.IsOn = SettingsManager.DarkModeEnabled
        DarkModeManager.ToggleDarkMode(Me, SettingsManager.DarkModeEnabled)
    End Sub

    Private Function HasSpecialCharacters(ByVal password As String) As Boolean
        Dim specialChars As String = "!@#$%^&*()_+-=[]{}|;:,.<>/?"

        ' Check if the password contains any special character
        For Each c As Char In specialChars
            If password.Contains(c) Then
                Return True
            End If
        Next

        Return False
    End Function
    'Exit
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()
    End Sub


End Class