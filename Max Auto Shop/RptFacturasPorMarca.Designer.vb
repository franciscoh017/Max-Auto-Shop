<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RptFacturasPorMarca
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
        Me.cmbMarca = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.FacturasPorMarcaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MaxAutoShopDataSet = New Max_Auto_Shop.MaxAutoShopDataSet()
        Me.CantidadVentasDelDiaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CantidadVentasDelDiaTableAdapter = New Max_Auto_Shop.MaxAutoShopDataSetTableAdapters.CantidadVentasDelDiaTableAdapter()
        Me.FacturasPorMarcaTableAdapter = New Max_Auto_Shop.MaxAutoShopDataSetTableAdapters.FacturasPorMarcaTableAdapter()
        CType(Me.FacturasPorMarcaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaxAutoShopDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CantidadVentasDelDiaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.FacturasPorMarcaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Max_Auto_Shop.FacturasPorMarca.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 57)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1075, 485)
        Me.ReportViewer1.TabIndex = 0
        '
        'cmbMarca
        '
        Me.cmbMarca.FormattingEnabled = True
        Me.cmbMarca.Location = New System.Drawing.Point(77, 12)
        Me.cmbMarca.Name = "cmbMarca"
        Me.cmbMarca.Size = New System.Drawing.Size(121, 21)
        Me.cmbMarca.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Marca"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(214, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Cargar Facturas"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FacturasPorMarcaBindingSource
        '
        Me.FacturasPorMarcaBindingSource.DataMember = "FacturasPorMarca"
        Me.FacturasPorMarcaBindingSource.DataSource = Me.MaxAutoShopDataSet
        '
        'MaxAutoShopDataSet
        '
        Me.MaxAutoShopDataSet.DataSetName = "MaxAutoShopDataSet"
        Me.MaxAutoShopDataSet.EnforceConstraints = False
        Me.MaxAutoShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CantidadVentasDelDiaBindingSource
        '
        Me.CantidadVentasDelDiaBindingSource.DataMember = "CantidadVentasDelDia"
        Me.CantidadVentasDelDiaBindingSource.DataSource = Me.MaxAutoShopDataSet
        '
        'CantidadVentasDelDiaTableAdapter
        '
        Me.CantidadVentasDelDiaTableAdapter.ClearBeforeFill = True
        '
        'FacturasPorMarcaTableAdapter
        '
        Me.FacturasPorMarcaTableAdapter.ClearBeforeFill = True
        '
        'RptFacturasPorMarca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1099, 554)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbMarca)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "RptFacturasPorMarca"
        Me.Text = "RptFacturasPorMarca"
        CType(Me.FacturasPorMarcaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaxAutoShopDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CantidadVentasDelDiaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents CantidadVentasDelDiaBindingSource As BindingSource
    Friend WithEvents MaxAutoShopDataSet As MaxAutoShopDataSet
    Friend WithEvents CantidadVentasDelDiaTableAdapter As MaxAutoShopDataSetTableAdapters.CantidadVentasDelDiaTableAdapter
    Friend WithEvents FacturasPorMarcaBindingSource As BindingSource
    Friend WithEvents FacturasPorMarcaTableAdapter As MaxAutoShopDataSetTableAdapters.FacturasPorMarcaTableAdapter
    Friend WithEvents cmbMarca As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
