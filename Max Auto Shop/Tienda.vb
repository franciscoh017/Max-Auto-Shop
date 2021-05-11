Imports System.Data.SqlClient

Public Class frmTienda

    Private con As SqlConnection

    Private Sub frmTienda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            cmbMarca.ValueMember = "id"
        End Using

        Using sda As SqlDataAdapter = New SqlDataAdapter("SELECT id, descripcion FROM Modelos", con)
            'Fill the DataTable with records from Table.
            Dim dt As DataTable = New DataTable()
            sda.Fill(dt)

            'Insert the Default Item to DataTable.
            Dim row As DataRow = dt.NewRow()
            row(0) = 0
            row(1) = "Please select"
            dt.Rows.InsertAt(row, 0)

            'Assign DataTable as DataSource.
            cmbModelo.DataSource = dt
            cmbModelo.DisplayMember = "descripcion"
            cmbModelo.ValueMember = "id"
        End Using

        Using sda As SqlDataAdapter = New SqlDataAdapter("SELECT *, CONCAT(CONCAT(descripcion, ' - ' ), precio) detalle FROM dbo.vehiculos where stock > 0", con)
            'Fill the DataTable with records from Table.
            Dim dt As DataTable = New DataTable()
            sda.Fill(dt)

            'Assign DataTable as DataSource.
            lstVehiculos.DataSource = dt
            lstVehiculos.DisplayMember = "detalle"
        End Using

        con.Close()
    End Sub

    Private Sub TiendaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiendaToolStripMenuItem.Click
        frmMain.Show()
        Me.Close()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub ComboBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbMarca.SelectedValueChanged
        If (TypeOf sender.SelectedValue IsNot DataRowView) Then
            con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Francisco Hernandez\Documents\Visual Studio 2019\Projects\Max Auto Shop\Max Auto Shop\MaxAutoShop.mdf;Integrated Security=True;")
            'Open the connection.
            con.Open()
            If Integer.Parse(sender.SelectedValue) > 0 Then
                cmbModelo.Enabled = True
                Using sda As SqlDataAdapter = New SqlDataAdapter("SELECT id, descripcion FROM Modelos Where IdMarca =" & sender.SelectedValue.ToString(), con)
                    'Fill the DataTable with records from Table.
                    Dim dt As DataTable = New DataTable()
                    sda.Fill(dt)

                    'Insert the Default Item to DataTable.
                    Dim row As DataRow = dt.NewRow()
                    row(0) = 0
                    row(1) = "Please select"
                    dt.Rows.InsertAt(row, 0)

                    'Assign DataTable as DataSource.
                    cmbModelo.DataSource = dt
                    cmbModelo.DisplayMember = "descripcion"
                    cmbModelo.ValueMember = "id"
                End Using
            Else
                cmbModelo.Enabled = False
            End If
        End If
        con.Close()
    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Francisco Hernandez\Documents\Visual Studio 2019\Projects\Max Auto Shop\Max Auto Shop\MaxAutoShop.mdf;Integrated Security=True;")
        'Open the connection.
        con.Open()
        Using sda As SqlDataAdapter = New SqlDataAdapter("SELECT id, descripcion FROM Vehiculos Where idMarca =" & cmbMarca.SelectedValue.ToString() & " and IdModelo =" & cmbModelo.SelectedValue.ToString(), con)
            'Fill the DataTable with records from Table.
            Dim dt As DataTable = New DataTable()
            sda.Fill(dt)

            'Assign DataTable as DataSource.
            lstVehiculos.DataSource = dt
            lstVehiculos.DisplayMember = "descripcion"
            lstVehiculos.ValueMember = "id"
        End Using
        con.Close()
    End Sub

    Private Sub cmbModelo_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbModelo.SelectedValueChanged
        If (TypeOf sender.SelectedValue IsNot DataRowView) Then
            If Integer.Parse(sender.SelectedValue) > 0 Then
                btnFiltrar.Enabled = True
            End If
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Francisco Hernandez\Documents\Visual Studio 2019\Projects\Max Auto Shop\Max Auto Shop\MaxAutoShop.mdf;Integrated Security=True;")
        'Open the connection.
        con.Open()
        Using sda As SqlDataAdapter = New SqlDataAdapter("SELECT *, CONCAT(CONCAT(descripcion, ' - ' ), precio) detalle FROM dbo.vehiculos", con)
            'Fill the DataTable with records from Table.
            Dim dt As DataTable = New DataTable()
            sda.Fill(dt)

            'Assign DataTable as DataSource.
            lstVehiculos.DataSource = dt
            lstVehiculos.DisplayMember = "detalle"
        End Using
        con.Close()
    End Sub

    Private Sub lstVehiculos_SelectedValueChanged(sender As Object, e As EventArgs) Handles lstVehiculos.SelectedValueChanged

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        For Each Row As DataRowView In lstVehiculos.SelectedItems.OfType(Of DataRowView)()
            lstDetalle.Items.Add(Row)
            lstDetalle.DisplayMember = "detalle"

            Dim total As Double = Double.Parse(txtTotal.Text)
            total = total + Double.Parse(Row.Item("precio"))
            If total > 0 Then
                btnGenerar.Enabled = True
            Else
                btnGenerar.Enabled = False
            End If
            txtTotal.Text = total.ToString()
        Next

        If lstDetalle.Items.Count > 0 Then
            btnEliminar.Enabled = True
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        For Each Row As DataRowView In lstDetalle.SelectedItems.OfType(Of DataRowView)()
            Dim total As Double = Double.Parse(txtTotal.Text)
            total = total - Double.Parse(Row.Item("precio"))
            If total > 0 Then
                btnGenerar.Enabled = True
            Else
                btnGenerar.Enabled = False
            End If
            txtTotal.Text = total.ToString()
        Next

        lstDetalle.Items.Remove(lstDetalle.SelectedItem)

        If lstDetalle.Items.Count < 1 Then
            btnEliminar.Enabled = False
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtNombre.Text = ""
        txtLicencia.Text = ""
        txtTelefono.Text = ""
        txtTotal.Text = "0.00"
        lstDetalle.Items.Clear()
        cmbMarca.SelectedIndex = 0
        cmbModelo.SelectedIndex = 0
        btnEliminar.Enabled = False
        btnFiltrar.Enabled = False
        btnGenerar.Enabled = False
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Francisco Hernandez\Documents\Visual Studio 2019\Projects\Max Auto Shop\Max Auto Shop\MaxAutoShop.mdf;Integrated Security=True;")
        Dim cmd As New SqlCommand
        Dim reader As SqlDataReader
        Dim noFactura As Integer

        Try

            cmd.CommandText = "INSERT INTO dbo.facturas (NombreCliente, Licencia, Telefono, Total, FechaCompra) VALUES( '" & txtNombre.Text & "', '" & txtLicencia.Text & "', '" & txtTelefono.Text & "' , '" & txtTotal.Text & "', '" & Now & "' )"
            cmd.Connection = con
            'Open the connection.
            con.Open()
            reader = cmd.ExecuteReader()

            cmd.CommandText = "SELECT TOP 1 * from dbo.facturas order by FechaCompra DESC"



            reader.Close()
            reader = cmd.ExecuteReader()

            While reader.Read
                noFactura = reader.Item(0)
            End While
            reader.Close()

            For Each Row As DataRowView In lstDetalle.Items.OfType(Of DataRowView)()
                cmd.CommandText = "INSERT INTO dbo.detallesfacturas (idFactura, IdVehiculo) VALUES( '" & noFactura & "', '" & Row.Item("Id") & "' )"
                reader = cmd.ExecuteReader()
                reader.Close()
                cmd.CommandText = "UPDATE dbo.vehiculos set stock = stock - 1  where id = '" & Row.Item("Id") & "'"
                reader = cmd.ExecuteReader()
                reader.Close()
            Next

            MsgBox("Factura creada exitosamente")
            frmTienda_Load(e, e)
            btnLimpiar.PerformClick()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        frmLogin.Show()
        frmMain.Close()
        Me.Close()
    End Sub

    Private Sub InventaioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventaioToolStripMenuItem.Click
        frmInventario.Show()
        Me.Close()
    End Sub

    Private Sub cmbMarca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMarca.SelectedIndexChanged

    End Sub
End Class