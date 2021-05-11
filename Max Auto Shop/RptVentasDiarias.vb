Public Class RptVentasDiarias
    Private Sub RptVentasDiarias_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Hasta.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'TODO: This line of code loads data into the 'MaxAutoShopDataSet.VentasDiariasPorMarca' table. You can move, or remove it, as needed.
        Me.VentasDiariasPorMarcaTableAdapter.Fill(Me.MaxAutoShopDataSet.VentasDiariasPorMarca, fechaDesde:=dtpDesde.Value, fechaHasta:=dtpHasta.Value)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class