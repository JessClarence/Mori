Public Class SettingsManager
    Public Shared Property DarkModeEnabled As Boolean
        Get
            Return My.Settings.DarkModeEnabled
        End Get
        Set(value As Boolean)
            My.Settings.DarkModeEnabled = value
            My.Settings.Save()
        End Set
    End Property

End Class
