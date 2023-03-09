<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Statistics
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Statistics))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Overlay1 = New stock_control.overlay()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me._stock_controlDBDataSet = New stock_control._stock_controlDBDataSet()
        Me.QReviewsPerEmpBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QReviewsPerEmpTableAdapter = New stock_control._stock_controlDBDataSetTableAdapters.qReviewsPerEmpTableAdapter()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me._stock_controlDBDataSet1 = New stock_control._stock_controlDBDataSet()
        Me.QStockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QStockTableAdapter = New stock_control._stock_controlDBDataSetTableAdapters.qStockTableAdapter()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._stock_controlDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QReviewsPerEmpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._stock_controlDBDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QStockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Overlay1
        '
        Me.Overlay1.BackColor = System.Drawing.Color.Transparent
        Me.Overlay1.BackgroundImage = CType(resources.GetObject("Overlay1.BackgroundImage"), System.Drawing.Image)
        Me.Overlay1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Overlay1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Overlay1.Location = New System.Drawing.Point(0, 0)
        Me.Overlay1.Name = "Overlay1"
        Me.Overlay1.Size = New System.Drawing.Size(1332, 931)
        Me.Overlay1.TabIndex = 0
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.IndianRed
        Me.Chart1.BorderlineColor = System.Drawing.Color.Black
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.DataSource = Me.QReviewsPerEmpBindingSource
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(830, 149)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Reviews per Employee"
        Series1.XValueMember = "Full Name"
        Series1.YValueMembers = "Reviews Per Employee"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(462, 300)
        Me.Chart1.TabIndex = 1
        Me.Chart1.Text = "Chart1"
        '
        '_stock_controlDBDataSet
        '
        Me._stock_controlDBDataSet.DataSetName = "_stock_controlDBDataSet"
        Me._stock_controlDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'QReviewsPerEmpBindingSource
        '
        Me.QReviewsPerEmpBindingSource.DataMember = "qReviewsPerEmp"
        Me.QReviewsPerEmpBindingSource.DataSource = Me._stock_controlDBDataSet
        '
        'QReviewsPerEmpTableAdapter
        '
        Me.QReviewsPerEmpTableAdapter.ClearBeforeFill = True
        '
        'Chart2
        '
        Me.Chart2.BackColor = System.Drawing.Color.IndianRed
        ChartArea2.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea2)
        Me.Chart2.DataSource = Me.QStockBindingSource
        Legend2.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend2)
        Me.Chart2.Location = New System.Drawing.Point(179, 149)
        Me.Chart2.Name = "Chart2"
        Me.Chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series2.Legend = "Legend1"
        Series2.Name = "Stock"
        Series2.XValueMember = "Product Name"
        Series2.YValueMembers = "Stock"
        Me.Chart2.Series.Add(Series2)
        Me.Chart2.Size = New System.Drawing.Size(645, 770)
        Me.Chart2.TabIndex = 2
        Me.Chart2.Text = "Chart2"
        '
        '_stock_controlDBDataSet1
        '
        Me._stock_controlDBDataSet1.DataSetName = "_stock_controlDBDataSet"
        Me._stock_controlDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'QStockBindingSource
        '
        Me.QStockBindingSource.DataMember = "qStock"
        Me.QStockBindingSource.DataSource = Me._stock_controlDBDataSet1
        '
        'QStockTableAdapter
        '
        Me.QStockTableAdapter.ClearBeforeFill = True
        '
        'Statistics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(1332, 931)
        Me.Controls.Add(Me.Chart2)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Overlay1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Statistics"
        Me.Text = "Statistics"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._stock_controlDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QReviewsPerEmpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._stock_controlDBDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QStockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Overlay1 As overlay
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents _stock_controlDBDataSet As _stock_controlDBDataSet
    Friend WithEvents QReviewsPerEmpBindingSource As BindingSource
    Friend WithEvents QReviewsPerEmpTableAdapter As _stock_controlDBDataSetTableAdapters.qReviewsPerEmpTableAdapter
    Friend WithEvents Chart2 As DataVisualization.Charting.Chart
    Friend WithEvents _stock_controlDBDataSet1 As _stock_controlDBDataSet
    Friend WithEvents QStockBindingSource As BindingSource
    Friend WithEvents QStockTableAdapter As _stock_controlDBDataSetTableAdapters.qStockTableAdapter
End Class
