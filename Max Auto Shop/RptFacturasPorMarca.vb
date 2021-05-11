Imports System.Data.SqlClient

Public Class RptFacturasPorMarca
    Private con As SqlConnection
    Private Sub RptFacturasPorMarca_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Francisco Hernandez\Documents\Visual Studio 2019\Projects\Max Auto Shop\Max Auto Shop\MaxAutoShop.mdf;Integrated Security=True;")
        'Open the connection.
        con.Open()
        Using sda As SqlDataAdapter = New SqlDataAdapter("SELECT id, descripcion FROM Marcas", con)
            'Fill the DataTable with records from Table.
            Dim dt As DataTable = New DataTable()
            sda.Fill(dt)

            'Insert the Default Item to DataTable.
            Dim row As DataRow = dt.NewRow()
            row(0) = 0
            row(1) = "Please select"
            dt.Rows.InsertAt(row, 0)

            'Assign DataTable as DataSource.
            cmbMarca.DataSource = dt
            cmbMarca.DisplayMember = "descripcion"
            cmbMarca.ValueMember = "descripcion"
        End Using

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.FacturasPorMarcaTableAdapter.Fill(Me.MaxAutoShopDataSet.FacturasPorMarca, marca:=cmbMarca.Text)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class