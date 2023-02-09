<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class products
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(products))
        Me.Overlay1 = New stock_control.overlay()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.lblSupplier = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.numQuant = New System.Windows.Forms.NumericUpDown()
        Me.numPrice = New System.Windows.Forms.NumericUpDown()
        Me.cmbxSupplier = New System.Windows.Forms.ComboBox()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        CType(Me.numQuant, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPrice, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Overlay1.Size = New System.Drawing.Size(800, 450)
        Me.Overlay1.TabIndex = 0
        '
        'lblProductName
        '
        Me.lblProductName.AutoSize = True
        Me.lblProductName.BackColor = System.Drawing.Color.IndianRed
        Me.lblProductName.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductName.Location = New System.Drawing.Point(167, 185)
        Me.lblProductName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(119, 21)
        Me.lblProductName.TabIndex = 6
        Me.lblProductName.Text = "Product Name:"
        '
        'lblSupplier
        '
        Me.lblSupplier.AutoSize = True
        Me.lblSupplier.BackColor = System.Drawing.Color.IndianRed
        Me.lblSupplier.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSupplier.Location = New System.Drawing.Point(167, 215)
        Me.lblSupplier.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSupplier.Name = "lblSupplier"
        Me.lblSupplier.Size = New System.Drawing.Size(76, 21)
        Me.lblSupplier.TabIndex = 7
        Me.lblSupplier.Text = "Supplier:"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.BackColor = System.Drawing.Color.IndianRed
        Me.lblPrice.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(167, 245)
        Me.lblPrice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(50, 21)
        Me.lblPrice.TabIndex = 8
        Me.lblPrice.Text = "Price:"
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.BackColor = System.Drawing.Color.IndianRed
        Me.lblQuantity.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.Location = New System.Drawing.Point(167, 277)
        Me.lblQuantity.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(76, 21)
        Me.lblQuantity.TabIndex = 9
        Me.lblQuantity.Text = "Quantity:"
        '
        'numQuant
        '
        Me.numQuant.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.numQuant.Location = New System.Drawing.Point(248, 281)
        Me.numQuant.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.numQuant.Name = "numQuant"
        Me.numQuant.Size = New System.Drawing.Size(59, 16)
        Me.numQuant.TabIndex = 10
        Me.numQuant.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'numPrice
        '
        Me.numPrice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.numPrice.DecimalPlaces = 2
        Me.numPrice.Increment = New Decimal(New Integer() {10, 0, 0, 131072})
        Me.numPrice.Location = New System.Drawing.Point(248, 250)
        Me.numPrice.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.numPrice.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.numPrice.Name = "numPrice"
        Me.numPrice.Size = New System.Drawing.Size(59, 16)
        Me.numPrice.TabIndex = 11
        Me.numPrice.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'cmbxSupplier
        '
        Me.cmbxSupplier.FormattingEnabled = True
        Me.cmbxSupplier.Location = New System.Drawing.Point(248, 215)
        Me.cmbxSupplier.Name = "cmbxSupplier"
        Me.cmbxSupplier.Size = New System.Drawing.Size(121, 21)
        Me.cmbxSupplier.TabIndex = 12
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(291, 189)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(100, 20)
        Me.txtProductName.TabIndex = 13
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(171, 319)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(155, 72)
        Me.btnAdd.TabIndex = 14
        Me.btnAdd.Text = "Add Product"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'products
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.cmbxSupplier)
        Me.Controls.Add(Me.numPrice)
        Me.Controls.Add(Me.numQuant)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblSupplier)
        Me.Controls.Add(Me.lblProductName)
        Me.Controls.Add(Me.Overlay1)
        Me.Name = "products"
        Me.Text = "products"
        CType(Me.numQuant, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPrice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Overlay1 As overlay
    Friend WithEvents lblProductName As Label
    Friend WithEvents lblSupplier As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents numQuant As NumericUpDown
    Friend WithEvents numPrice As NumericUpDown
    Friend WithEvents cmbxSupplier As ComboBox
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents btnAdd As Button
End Class
