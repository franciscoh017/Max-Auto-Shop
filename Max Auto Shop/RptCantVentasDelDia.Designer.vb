<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RptCantVentasDelDia
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
        Me.MaxAutoShopDataSet = New Max_Auto_Shop.MaxAutoShopDataSet()
        Me.CantidadVentasDelDiaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CantidadVentasDelDiaTableAdapter = New Max_Auto_Shop.MaxAutoShopDataSetTableAdapters.CantidadVentasDelDiaTableAdapter()
        CType(Me.MaxAutoShopDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CantidadVentasDelDiaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.CantidadVentasDelDiaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Max_Auto_Shop.CantVentasDelDia.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(776, 426)
        Me.ReportViewer1.TabIndex = 0
        '
        'MaxAutoShopDataSet
        '
        Me.MaxAutoShopDataSet.DataSetName = "MaxAutoShopDataSet"
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
        'RptCantVentasDelDia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "RptCantVentasDelDia"
        Me.Text = "RptCantVentasDelDia"
        CType(Me.MaxAutoShopDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CantidadVentasDelDiaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents CantidadVentasDelDiaBindingSource As BindingSource
    Friend WithEvents MaxAutoShopDataSet As MaxAutoShopDataSet
    Friend WithEvents CantidadVentasDelDiaTableAdapter As MaxAutoShopDataSetTableAdapters.CantidadVentasDelDiaTableAdapter
End Class
