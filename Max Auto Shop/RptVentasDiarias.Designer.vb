<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RptVentasDiarias
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Hasta = New System.Windows.Forms.Label()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MaxAutoShopDataSet = New Max_Auto_Shop.MaxAutoShopDataSet()
        Me.VentasDiariasPorMarcaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentasDiariasPorMarcaTableAdapter = New Max_Auto_Shop.MaxAutoShopDataSetTableAdapters.VentasDiariasPorMarcaTableAdapter()
        CType(Me.MaxAutoShopDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasDiariasPorMarcaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.VentasDiariasPorMarcaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Max_Auto_Shop.VentasDiariasPorMarca.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 66)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(776, 372)
        Me.ReportViewer1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Desde"
        '
        'Hasta
        '
        Me.Hasta.AutoSize = True
        Me.Hasta.Location = New System.Drawing.Point(262, 12)
        Me.Hasta.Name = "Hasta"
        Me.Hasta.Size = New System.Drawing.Size(35, 13)
        Me.Hasta.TabIndex = 3
        Me.Hasta.Text = "Hasta"
        '
        'dtpDesde
        '
        Me.dtpDesde.Location = New System.Drawing.Point(56, 12)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(200, 20)
        Me.dtpDesde.TabIndex = 5
        '
        'dtpHasta
        '
        Me.dtpHasta.Location = New System.Drawing.Point(303, 12)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(200, 20)
        Me.dtpHasta.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(509, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Cargar Ventas"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MaxAutoShopDataSet
        '
        Me.MaxAutoShopDataSet.DataSetName = "MaxAutoShopDataSet"
        Me.MaxAutoShopDataSet.EnforceConstraints = False
        Me.MaxAutoShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VentasDiariasPorMarcaBindingSource
        '
        Me.VentasDiariasPorMarcaBindingSource.DataMember = "VentasDiariasPorMarca"
        Me.VentasDiariasPorMarcaBindingSource.DataSource = Me.MaxAutoShopDataSet
        '
        'VentasDiariasPorMarcaTableAdapter
        '
        Me.VentasDiariasPorMarcaTableAdapter.ClearBeforeFill = True
        '
        'RptVentasDiarias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dtpHasta)
        Me.Controls.Add(Me.dtpDesde)
        Me.Controls.Add(Me.Hasta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "RptVentasDiarias"
        Me.Text = "RptVentasDiarias"
        CType(Me.MaxAutoShopDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasDiariasPorMarcaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Label1 As Label
    Friend WithEvents Hasta As Label
    Friend WithEvents dtpDesde As DateTimePicker
    Friend WithEvents dtpHasta As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents VentasDiariasPorMarcaBindingSource As BindingSource
    Friend WithEvents MaxAutoShopDataSet As MaxAutoShopDataSet
    Friend WithEvents VentasDiariasPorMarcaTableAdapter As MaxAutoShopDataSetTableAdapters.VentasDiariasPorMarcaTableAdapter
End Class
