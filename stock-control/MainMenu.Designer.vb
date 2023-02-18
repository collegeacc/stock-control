<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.cmbxProduct = New System.Windows.Forms.ComboBox()
        Me.lblSelectProduct = New System.Windows.Forms.Label()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TblProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._stock_controlDBDataSet = New stock_control._stock_controlDBDataSet()
        Me.TblProductsTableAdapter = New stock_control._stock_controlDBDataSetTableAdapters.tblProductsTableAdapter()
        Me.Overlay1 = New stock_control.overlay()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._stock_controlDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbxProduct
        '
        Me.cmbxProduct.FormattingEnabled = True
        Me.cmbxProduct.Location = New System.Drawing.Point(584, 434)
        Me.cmbxProduct.Name = "cmbxProduct"
        Me.cmbxProduct.Size = New System.Drawing.Size(119, 21)
        Me.cmbxProduct.TabIndex = 2
        '
        'lblSelectProduct
        '
        Me.lblSelectProduct.AutoSize = True
        Me.lblSelectProduct.Location = New System.Drawing.Point(581, 417)
        Me.lblSelectProduct.Name = "lblSelectProduct"
        Me.lblSelectProduct.Size = New System.Drawing.Size(77, 13)
        Me.lblSelectProduct.TabIndex = 3
        Me.lblSelectProduct.Text = "Select Product"
        '
        'txtStock
        '
        Me.txtStock.Enabled = False
        Me.txtStock.Location = New System.Drawing.Point(709, 434)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(103, 20)
        Me.txtStock.TabIndex = 4
        '
        'lblStock
        '
        Me.lblStock.AutoSize = True
        Me.lblStock.Location = New System.Drawing.Point(706, 418)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(35, 13)
        Me.lblStock.TabIndex = 5
        Me.lblStock.Text = "Stock"
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.Transparent
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.DataSource = Me.TblProductsBindingSource
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(199, 153)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate
        Series1.ChartArea = "ChartArea1"
        Series1.CustomProperties = "LabelStyle=Bottom, DrawingStyle=Wedge"
        Series1.Font = New System.Drawing.Font("Microsoft Sans Serif", 2.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series1.Legend = "Legend1"
        Series1.Name = "Stock"
        Series1.XValueMember = "Product Name"
        Series1.YValueMembers = "Stock"
        Series1.YValuesPerPoint = 6
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(979, 245)
        Me.Chart1.TabIndex = 6
        Me.Chart1.Text = "Chart1"
        '
        'TblProductsBindingSource
        '
        Me.TblProductsBindingSource.DataMember = "tblProducts"
        Me.TblProductsBindingSource.DataSource = Me._stock_controlDBDataSet
        '
        '_stock_controlDBDataSet
        '
        Me._stock_controlDBDataSet.DataSetName = "_stock_controlDBDataSet"
        Me._stock_controlDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblProductsTableAdapter
        '
        Me.TblProductsTableAdapter.ClearBeforeFill = True
        '
        'Overlay1
        '
        Me.Overlay1.BackColor = System.Drawing.Color.Transparent
        Me.Overlay1.BackgroundImage = Global.stock_control.My.Resources.Resources.background
        Me.Overlay1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Overlay1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Overlay1.Location = New System.Drawing.Point(0, 0)
        Me.Overlay1.Name = "Overlay1"
        Me.Overlay1.Size = New System.Drawing.Size(1236, 537)
        Me.Overlay1.TabIndex = 7
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(1236, 537)
        Me.Controls.Add(Me.lblStock)
        Me.Controls.Add(Me.txtStock)
        Me.Controls.Add(Me.cmbxProduct)
        Me.Controls.Add(Me.lblSelectProduct)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Overlay1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(960, 574)
        Me.Name = "MainMenu"
        Me.Text = "Main Menu"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._stock_controlDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbxProduct As ComboBox
    Friend WithEvents lblSelectProduct As Label
    Friend WithEvents txtStock As TextBox
    Friend WithEvents lblStock As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents _stock_controlDBDataSet As _stock_controlDBDataSet
    Friend WithEvents TblProductsBindingSource As BindingSource
    Friend WithEvents TblProductsTableAdapter As _stock_controlDBDataSetTableAdapters.tblProductsTableAdapter
    Friend WithEvents Overlay1 As overlay
End Class
