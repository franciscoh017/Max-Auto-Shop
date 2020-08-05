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
End Class