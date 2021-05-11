Public Class frmMain
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub TiendaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiendaToolStripMenuItem.Click
        frmTienda.Show()
    End Sub

    Private Sub InventaioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventaioToolStripMenuItem.Click
        frmInventario.Show()
    End Sub

    Private Sub CantVentasDelDiaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CantVentasDelDiaToolStripMenuItem.Click
        RptCantVentasDelDia.Show()
    End Sub

    Private Sub FacturasPorMarcaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturasPorMarcaToolStripMenuItem.Click
        RptFacturasPorMarca.Show()
    End Sub

    Private Sub VentasDiariasPorMarcaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasDiariasPorMarcaToolStripMenuItem.Click
        RptVentasDiarias.Show()
    End Sub
End Class