<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class orderSubForm
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
        Me.btnAddProduct = New System.Windows.Forms.Button()
        Me.cmbxProductName = New System.Windows.Forms.ComboBox()
        Me.lblPriceTotal = New System.Windows.Forms.Label()
        Me.cmbxPaymentType = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnNewOrder = New System.Windows.Forms.Button()
        Me.lblTut1 = New System.Windows.Forms.Label()
        Me.lblTut2 = New System.Windows.Forms.Label()
        Me.btnEditDelete = New System.Windows.Forms.Button()
        Me.lblTut4 = New System.Windows.Forms.Label()
        Me.lblTut3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEmployeeID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtOrderID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'btnAddProduct
        '
        Me.btnAddProduct.Location = New System.Drawing.Point(32, 213)
        Me.btnAddProduct.Name = "btnAddProduct"
        Me.btnAddProduct.Size = New System.Drawing.Size(123, 24)
        Me.btnAddProduct.TabIndex = 0
        Me.btnAddProduct.Text = "Add Product"
        Me.btnAddProduct.UseVisualStyleBackColor = True
        '
        'cmbxProductName
        '
        Me.cmbxProductName.FormattingEnabled = True
        Me.cmbxProductName.Location = New System.Drawing.Point(12, 183)
        Me.cmbxProductName.Name = "cmbxProductName"
        Me.cmbxProductName.Size = New System.Drawing.Size(173, 24)
        Me.cmbxProductName.TabIndex = 1
        '
        'lblPriceTotal
        '
        Me.lblPriceTotal.AutoSize = True
        Me.lblPriceTotal.Location = New System.Drawing.Point(9, 164)
        Me.lblPriceTotal.Name = "lblPriceTotal"
        Me.lblPriceTotal.Size = New System.Drawing.Size(78, 16)
        Me.lblPriceTotal.TabIndex = 3
        Me.lblPriceTotal.Text = "Total Price: "
        '
        'cmbxPaymentType
        '
        Me.cmbxPaymentType.FormattingEnabled = True
        Me.cmbxPaymentType.Items.AddRange(New Object() {"Debit", "Cash", "PayPal"})
        Me.cmbxPaymentType.Location = New System.Drawing.Point(12, 137)
        Me.cmbxPaymentType.Name = "cmbxPaymentType"
        Me.cmbxPaymentType.Size = New System.Drawing.Size(173, 24)
        Me.cmbxPaymentType.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Payment Type"
        '
        'btnNewOrder
        '
        Me.btnNewOrder.Location = New System.Drawing.Point(12, 255)
        Me.btnNewOrder.Name = "btnNewOrder"
        Me.btnNewOrder.Size = New System.Drawing.Size(173, 31)
        Me.btnNewOrder.TabIndex = 6
        Me.btnNewOrder.Text = "Submit Order"
        Me.btnNewOrder.UseVisualStyleBackColor = True
        '
        'lblTut1
        '
        Me.lblTut1.AutoSize = True
        Me.lblTut1.Location = New System.Drawing.Point(191, 175)
        Me.lblTut1.Name = "lblTut1"
        Me.lblTut1.Size = New System.Drawing.Size(217, 32)
        Me.lblTut1.TabIndex = 7
        Me.lblTut1.Text = "*Select the product from the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "combo box, then press add product"
        '
        'lblTut2
        '
        Me.lblTut2.AutoSize = True
        Me.lblTut2.Location = New System.Drawing.Point(191, 140)
        Me.lblTut2.Name = "lblTut2"
        Me.lblTut2.Size = New System.Drawing.Size(134, 16)
        Me.lblTut2.TabIndex = 8
        Me.lblTut2.Text = "*Select payment type"
        '
        'btnEditDelete
        '
        Me.btnEditDelete.Location = New System.Drawing.Point(216, 255)
        Me.btnEditDelete.Name = "btnEditDelete"
        Me.btnEditDelete.Size = New System.Drawing.Size(173, 31)
        Me.btnEditDelete.TabIndex = 9
        Me.btnEditDelete.Text = "Edit or Delete an Order"
        Me.btnEditDelete.UseVisualStyleBackColor = True
        '
        'lblTut4
        '
        Me.lblTut4.AutoSize = True
        Me.lblTut4.Location = New System.Drawing.Point(191, 99)
        Me.lblTut4.Name = "lblTut4"
        Me.lblTut4.Size = New System.Drawing.Size(91, 16)
        Me.lblTut4.TabIndex = 34
        Me.lblTut4.Text = "*Select a date"
        Me.lblTut4.Visible = False
        '
        'lblTut3
        '
        Me.lblTut3.AutoSize = True
        Me.lblTut3.Location = New System.Drawing.Point(191, 43)
        Me.lblTut3.Name = "lblTut3"
        Me.lblTut3.Size = New System.Drawing.Size(73, 16)
        Me.lblTut3.TabIndex = 33
        Me.lblTut3.Text = "*Select IDs"
        Me.lblTut3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(109, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 16)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Employee ID"
        Me.Label4.Visible = False
        '
        'txtEmployeeID
        '
        Me.txtEmployeeID.Location = New System.Drawing.Point(112, 43)
        Me.txtEmployeeID.Name = "txtEmployeeID"
        Me.txtEmployeeID.Size = New System.Drawing.Size(73, 22)
        Me.txtEmployeeID.TabIndex = 31
        Me.txtEmployeeID.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 16)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Order ID"
        Me.Label3.Visible = False
        '
        'txtOrderID
        '
        Me.txtOrderID.Location = New System.Drawing.Point(12, 43)
        Me.txtOrderID.Name = "txtOrderID"
        Me.txtOrderID.Size = New System.Drawing.Size(73, 22)
        Me.txtOrderID.TabIndex = 29
        Me.txtOrderID.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 16)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Date"
        Me.Label2.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(12, 93)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(173, 22)
        Me.DateTimePicker1.TabIndex = 27
        Me.DateTimePicker1.Visible = False
        '
        'orderSubForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 314)
        Me.Controls.Add(Me.lblTut4)
        Me.Controls.Add(Me.lblTut3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtEmployeeID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtOrderID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.btnEditDelete)
        Me.Controls.Add(Me.lblTut2)
        Me.Controls.Add(Me.lblTut1)
        Me.Controls.Add(Me.btnNewOrder)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbxPaymentType)
        Me.Controls.Add(Me.lblPriceTotal)
        Me.Controls.Add(Me.cmbxProductName)
        Me.Controls.Add(Me.btnAddProduct)
        Me.Name = "orderSubForm"
        Me.Text = "Order"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAddProduct As Button
    Friend WithEvents cmbxProductName As ComboBox
    Friend WithEvents lblPriceTotal As Label
    Friend WithEvents cmbxPaymentType As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnNewOrder As Button
    Friend WithEvents lblTut1 As Label
    Friend WithEvents lblTut2 As Label
    Friend WithEvents btnEditDelete As Button
    Friend WithEvents lblTut4 As Label
    Friend WithEvents lblTut3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEmployeeID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtOrderID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
