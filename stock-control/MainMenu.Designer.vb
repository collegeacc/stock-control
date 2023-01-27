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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmbxProduct = New System.Windows.Forms.ComboBox()
        Me.lblSelectProduct = New System.Windows.Forms.Label()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TblProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._stock_controlDBDataSet = New stock_control._stock_controlDBDataSet()
        Me.TblProductsTableAdapter = New stock_control._stock_controlDBDataSetTableAdapters.tblProductsTableAdapter()
        Me.pbBtnOrder = New System.Windows.Forms.PictureBox()
        Me.pbMainMenu = New System.Windows.Forms.PictureBox()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._stock_controlDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBtnOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMainMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Brown
        Me.Panel1.Controls.Add(Me.pbMainMenu)
        Me.Panel1.Controls.Add(Me.lblName)
        Me.Panel1.Controls.Add(Me.lblUsername)
        Me.Panel1.Controls.Add(Me.pbLogo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(944, 140)
        Me.Panel1.TabIndex = 0
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(753, 90)
        Me.lblName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(114, 13)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "First & Last Name Failed"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(769, 47)
        Me.lblUsername.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(86, 13)
        Me.lblUsername.TabIndex = 1
        Me.lblUsername.Text = "Username Failed"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Brown
        Me.Panel2.Controls.Add(Me.pbBtnOrder)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 140)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(140, 397)
        Me.Panel2.TabIndex = 1
        '
        'cmbxProduct
        '
        Me.cmbxProduct.FormattingEnabled = True
        Me.cmbxProduct.Location = New System.Drawing.Point(180, 407)
        Me.cmbxProduct.Name = "cmbxProduct"
        Me.cmbxProduct.Size = New System.Drawing.Size(119, 21)
        Me.cmbxProduct.TabIndex = 2
        '
        'lblSelectProduct
        '
        Me.lblSelectProduct.AutoSize = True
        Me.lblSelectProduct.Location = New System.Drawing.Point(177, 390)
        Me.lblSelectProduct.Name = "lblSelectProduct"
        Me.lblSelectProduct.Size = New System.Drawing.Size(77, 13)
        Me.lblSelectProduct.TabIndex = 3
        Me.lblSelectProduct.Text = "Select Product"
        '
        'txtStock
        '
        Me.txtStock.Enabled = False
        Me.txtStock.Location = New System.Drawing.Point(305, 407)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(103, 20)
        Me.txtStock.TabIndex = 4
        '
        'lblStock
        '
        Me.lblStock.AutoSize = True
        Me.lblStock.Location = New System.Drawing.Point(302, 391)
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
        Me.Chart1.Location = New System.Drawing.Point(99, 145)
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
        'pbBtnOrder
        '
        Me.pbBtnOrder.Image = Global.stock_control.My.Resources.Resources.orderplacholder
        Me.pbBtnOrder.Location = New System.Drawing.Point(14, 33)
        Me.pbBtnOrder.Margin = New System.Windows.Forms.Padding(2)
        Me.pbBtnOrder.Name = "pbBtnOrder"
        Me.pbBtnOrder.Size = New System.Drawing.Size(104, 60)
        Me.pbBtnOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbBtnOrder.TabIndex = 0
        Me.pbBtnOrder.TabStop = False
        '
        'pbMainMenu
        '
        Me.pbMainMenu.Image = Global.stock_control.My.Resources.Resources.house_and_home_icon_symbol_sign_free_png
        Me.pbMainMenu.Location = New System.Drawing.Point(160, 90)
        Me.pbMainMenu.Name = "pbMainMenu"
        Me.pbMainMenu.Size = New System.Drawing.Size(41, 40)
        Me.pbMainMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbMainMenu.TabIndex = 3
        Me.pbMainMenu.TabStop = False
        '
        'pbLogo
        '
        Me.pbLogo.BackColor = System.Drawing.Color.Transparent
        Me.pbLogo.Image = Global.stock_control.My.Resources.Resources.sjr_logo
        Me.pbLogo.Location = New System.Drawing.Point(2, 0)
        Me.pbLogo.Margin = New System.Windows.Forms.Padding(2)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(109, 135)
        Me.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLogo.TabIndex = 0
        Me.pbLogo.TabStop = False
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(944, 537)
        Me.Controls.Add(Me.lblStock)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtStock)
        Me.Controls.Add(Me.cmbxProduct)
        Me.Controls.Add(Me.lblSelectProduct)
        Me.Controls.Add(Me.Chart1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(960, 574)
        Me.Name = "MainMenu"
        Me.Text = "MainMenu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._stock_controlDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBtnOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMainMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblName As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents pbBtnOrder As PictureBox
    Friend WithEvents cmbxProduct As ComboBox
    Friend WithEvents lblSelectProduct As Label
    Friend WithEvents txtStock As TextBox
    Friend WithEvents lblStock As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents _stock_controlDBDataSet As _stock_controlDBDataSet
    Friend WithEvents TblProductsBindingSource As BindingSource
    Friend WithEvents TblProductsTableAdapter As _stock_controlDBDataSetTableAdapters.tblProductsTableAdapter
    Friend WithEvents pbMainMenu As PictureBox
End Class
