Public Class Products
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Home_Page.ShowFormInPanel(CreateProducts)
    End Sub

    Private Sub Orders_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Orders.CellContentClick

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
        GetProducts(Orders)
    End Sub
End Class