Module Module1
    Public Sub Loadform(ByRef nf As Form)
        While frmMain.Panel1.Controls.Count > 0
            frmMain.Panel1.Controls(0).Dispose()
        End While
        With nf
            .TopMost = False
            .AutoSize = False

        End With
        nf.TopLevel = False
        nf.WindowState = FormWindowState.Maximized
        nf.FormBorderStyle = FormBorderStyle.None
        nf.Dock = DockStyle.Fill
        frmMain.Panel1.Controls.Add(nf)
        nf.Show()
    End Sub

End Module
