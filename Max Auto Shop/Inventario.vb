Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class frmInventario
    Dim errorProvider1 As New ErrorProvider
    Private con As SqlConnection
    Private selectedId As Integer


    Private Sub frmInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Francisco Hernandez\Documents\Visual Studio 2019\Projects\Max Auto Shop\Max Auto Shop\MaxAutoShop.mdf;Integrated Security=True;")
        'Open the connection.
        con.Open()
        Using sda As SqlDataAdapter = New SqlDataAdapter("SELECT *, CONCAT(CONCAT(descripcion, ' - ' ), precio) detalle FROM dbo.vehiculos", con)
            'Fill the DataTable with records from Table.
            Dim dt As DataTable = New DataTable()
            sda.Fill(dt)

            'Assign DataTable as DataSource.
            dgvVehiculos.DataSource = dt
        End Using

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

        con.Close()
    End Sub

    Private Sub dgvVehiculos_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVehiculos.RowEnter
        If sender.CurrentRow IsNot Nothing Then
            If dgvVehiculos.CurrentRow.Cells("id").Value Then
                btnGuardar.Enabled = True
                btnEliminar.Enabled = True
                selectedId = Integer.Parse(dgvVehiculos.CurrentRow.Cells("id").Value.ToString())
                cmbMarca.SelectedValue = dgvVehiculos.CurrentRow.Cells("idMarca").Value.ToString()
                cmbModelo.SelectedValue = dgvVehiculos.CurrentRow.Cells("idModelo").Value.ToString()
                txtColor.Text = dgvVehiculos.CurrentRow.Cells("Color").Value.ToString()
                txtTablilla.Text = dgvVehiculos.CurrentRow.Cells("Tablilla").Value.ToString()
                txtLicencia.Text = dgvVehiculos.CurrentRow.Cells("Licencia").Value.ToString()
                txtPrecio.Text = dgvVehiculos.CurrentRow.Cells("Precio").Value.ToString()
                txtDescripcion.Text = dgvVehiculos.CurrentRow.Cells("Descripcion").Value.ToString()
                txtCantidad.Text = dgvVehiculos.CurrentRow.Cells("Stock").Value.ToString()
            End If
        End If
    End Sub

    Private Sub limpiar()
        selectedId = 0
        cmbMarca.SelectedIndex = 0
        cmbModelo.SelectedIndex = 0
        txtColor.Text = ""
        txtTablilla.Text = ""
        txtLicencia.Text = ""
        txtPrecio.Text = ""
        txtDescripcion.Text = ""
        txtCantidad.Text = ""
        btnGuardar.Enabled = False
        btnEliminar.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        limpiar()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If Not Regex.IsMatch(txtPrecio.Text, "^\d+(\.\d+)+$") Then
            errorProvider1.SetError(txtPrecio,
                                    "Digite un precio valido")
        ElseIf Not Regex.IsMatch(txtCantidad.Text, "^[0-9]\d*$") Then
            errorProvider1.SetError(txtCantidad,
                                    "Digite una cantidad valida")
        Else
            errorProvider1.SetError(txtPrecio, String.Empty)
            errorProvider1.SetError(txtCantidad, String.Empty)
            errorProvider1.Clear()
            con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Francisco Hernandez\Documents\Visual Studio 2019\Projects\Max Auto Shop\Max Auto Shop\MaxAutoShop.mdf;Integrated Security=True;")
            Dim cmd As New SqlCommand
            Dim reader As SqlDataReader

            Try

                cmd.CommandText = "INSERT INTO dbo.vehiculos (idMarca, idModelo, Color, Tablilla, Licencia, Precio, Descripcion, Stock) VALUES" &
            "( '" & cmbMarca.SelectedValue.ToString() & "', '" & cmbModelo.SelectedValue.ToString() & "', '" & txtColor.Text & "', '" & txtTablilla.Text & "', '" & txtLicencia.Text & "', '" & txtPrecio.Text & "', '" & txtDescripcion.Text & "-" & txtLicencia.Text & "', '" & txtCantidad.Text & "' )"
                cmd.Connection = con
                'Open the connection.
                con.Open()
                reader = cmd.ExecuteReader()

                reader.Close()
                frmInventario_Load(e, e)
                limpiar()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub cmbMarca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMarca.SelectedIndexChanged
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

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim result As DialogResult = MessageBox.Show("¿Desea actualizar el vehículo seleccionado?",
                              "Confirmar Actualizar Vehiculo",
                              MessageBoxButtons.YesNo)

        If result <> DialogResult.Yes Then
            Return
        Else
            con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Francisco Hernandez\Documents\Visual Studio 2019\Projects\Max Auto Shop\Max Auto Shop\MaxAutoShop.mdf;Integrated Security=True;")
            Dim cmd As New SqlCommand
            Dim reader As SqlDataReader

            Try

                cmd.CommandText = "UPDATE dbo.vehiculos set idMarca = '" & cmbMarca.SelectedValue.ToString() & "'," &
                                                           "idModelo = '" & cmbModelo.SelectedValue.ToString() & "'," &
                                                           "color = '" & txtColor.Text & "'," &
                                                           "tablilla = '" & txtTablilla.Text & "'," &
                                                           "licencia = '" & txtLicencia.Text & "'," &
                                                           "precio = '" & txtPrecio.Text & "'," &
                                                           "descripcion = '" & txtDescripcion.Text & "'," &
                                                           "stock = '" & txtCantidad.Text & "'" &
                                                           "where id = '" & selectedId & "'"
                cmd.Connection = con
                'Open the connection.
                con.Open()
                reader = cmd.ExecuteReader()

                reader.Close()
                frmInventario_Load(e, e)
                limpiar()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Francisco Hernandez\Documents\Visual Studio 2019\Projects\Max Auto Shop\Max Auto Shop\MaxAutoShop.mdf;Integrated Security=True;")
        Dim cmd As New SqlCommand
        Dim reader As SqlDataReader

        Try

            cmd.CommandText = "DELETE FROM dbo.vehiculos where id = '" & selectedId & "'"
            cmd.Connection = con
            'Open the connection.
            con.Open()
            reader = cmd.ExecuteReader()

            reader.Close()
            frmInventario_Load(e, e)
            limpiar()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub TiendaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiendaToolStripMenuItem.Click
        frmMain.Show()
        Me.Close()
    End Sub

    Private Sub InventaioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventaioToolStripMenuItem.Click
        frmTienda.Show()
        Me.Close()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        frmLogin.Show()
        frmMain.Close()
        Me.Close()
    End Sub
End Class
