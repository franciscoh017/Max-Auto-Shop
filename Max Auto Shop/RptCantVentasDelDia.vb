Public Class RptCantVentasDelDia
    Private Sub RptCantVentasDelDia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MaxAutoShopDataSet.CantidadVentasDelDia' table. You can move, or remove it, as needed.
        Me.CantidadVentasDelDiaTableAdapter.Fill(Me.MaxAutoShopDataSet.CantidadVentasDelDia)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class