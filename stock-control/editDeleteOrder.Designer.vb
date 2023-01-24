<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class editDeleteOrder
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
        Me.lblTut2 = New System.Windows.Forms.Label()
        Me.lblTut1 = New System.Windows.Forms.Label()
        Me.btnNewOrder = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbxPaymentType = New System.Windows.Forms.ComboBox()
        Me.lblPriceTotal = New System.Windows.Forms.Label()
        Me.cmbxProductName = New System.Windows.Forms.ComboBox()
        Me.btnAddProduct = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtOrderID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEmployeeID = New System.Windows.Forms.TextBox()
        Me.lblTut3 = New System.Windows.Forms.Label()
        Me.lblTut4 = New System.Windows.Forms.Label()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnMode = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTut2
        '
        Me.lblTut2.AutoSize = True
        Me.lblTut2.Location = New System.Drawing.Point(194, 148)
        Me.lblTut2.Name = "lblTut2"
        Me.lblTut2.Size = New System.Drawing.Size(134, 16)
        Me.lblTut2.TabIndex = 17
        Me.lblTut2.Text = "*Select payment type"
        '
        'lblTut1
        '
        Me.lblTut1.AutoSize = True
        Me.lblTut1.Location = New System.Drawing.Point(194, 183)
        Me.lblTut1.Name = "lblTut1"
        Me.lblTut1.Size = New System.Drawing.Size(217, 32)
        Me.lblTut1.TabIndex = 16
        Me.lblTut1.Text = "*Select the product from the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "combo box, then press add product"
        '
        'btnNewOrder
        '
        Me.btnNewOrder.Location = New System.Drawing.Point(90, 221)
        Me.btnNewOrder.Name = "btnNewOrder"
        Me.btnNewOrder.Size = New System.Drawing.Size(98, 24)
        Me.btnNewOrder.TabIndex = 15
        Me.btnNewOrder.Text = "Submit Order"
        Me.btnNewOrder.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Payment Type"
        '
        'cmbxPaymentType
        '
        Me.cmbxPaymentType.FormattingEnabled = True
        Me.cmbxPaymentType.Items.AddRange(New Object() {"Debit", "Cash", "PayPal"})
        Me.cmbxPaymentType.Location = New System.Drawing.Point(15, 145)
        Me.cmbxPaymentType.Name = "cmbxPaymentType"
        Me.cmbxPaymentType.Size = New System.Drawing.Size(173, 24)
        Me.cmbxPaymentType.TabIndex = 13
        '
        'lblPriceTotal
        '
        Me.lblPriceTotal.AutoSize = True
        Me.lblPriceTotal.Location = New System.Drawing.Point(12, 172)
        Me.lblPriceTotal.Name = "lblPriceTotal"
        Me.lblPriceTotal.Size = New System.Drawing.Size(78, 16)
        Me.lblPriceTotal.TabIndex = 12
        Me.lblPriceTotal.Text = "Total Price: "
        '
        'cmbxProductName
        '
        Me.cmbxProductName.FormattingEnabled = True
        Me.cmbxProductName.Location = New System.Drawing.Point(15, 191)
        Me.cmbxProductName.Name = "cmbxProductName"
        Me.cmbxProductName.Size = New System.Drawing.Size(173, 24)
        Me.cmbxProductName.TabIndex = 11
        '
        'btnAddProduct
        '
        Me.btnAddProduct.Location = New System.Drawing.Point(12, 221)
        Me.btnAddProduct.Name = "btnAddProduct"
        Me.btnAddProduct.Size = New System.Drawing.Size(72, 24)
        Me.btnAddProduct.TabIndex = 10
        Me.btnAddProduct.Text = "Add Product"
        Me.btnAddProduct.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(15, 101)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(173, 22)
        Me.DateTimePicker1.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 16)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Date"
        '
        'txtOrderID
        '
        Me.txtOrderID.Location = New System.Drawing.Point(15, 51)
        Me.txtOrderID.Name = "txtOrderID"
        Me.txtOrderID.Size = New System.Drawing.Size(73, 22)
        Me.txtOrderID.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 16)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Order ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(112, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 16)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Employee ID"
        '
        'txtEmployeeID
        '
        Me.txtEmployeeID.Location = New System.Drawing.Point(115, 51)
        Me.txtEmployeeID.Name = "txtEmployeeID"
        Me.txtEmployeeID.Size = New System.Drawing.Size(73, 22)
        Me.txtEmployeeID.TabIndex = 22
        '
        'lblTut3
        '
        Me.lblTut3.AutoSize = True
        Me.lblTut3.Location = New System.Drawing.Point(194, 51)
        Me.lblTut3.Name = "lblTut3"
        Me.lblTut3.Size = New System.Drawing.Size(73, 16)
        Me.lblTut3.TabIndex = 24
        Me.lblTut3.Text = "*Select IDs"
        '
        'lblTut4
        '
        Me.lblTut4.AutoSize = True
        Me.lblTut4.Location = New System.Drawing.Point(194, 107)
        Me.lblTut4.Name = "lblTut4"
        Me.lblTut4.Size = New System.Drawing.Size(91, 16)
        Me.lblTut4.TabIndex = 25
        Me.lblTut4.Text = "*Select a date"
        '
        'btnPrev
        '
        Me.btnPrev.Location = New System.Drawing.Point(15, 251)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(80, 43)
        Me.btnPrev.TabIndex = 26
        Me.btnPrev.Text = "Previous"
        Me.btnPrev.UseVisualStyleBackColor = True
        Me.btnPrev.Visible = False
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(108, 251)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(80, 43)
        Me.btnNext.TabIndex = 27
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        Me.btnNext.Visible = False
        '
        'btnMode
        '
        Me.btnMode.Location = New System.Drawing.Point(15, 300)
        Me.btnMode.Name = "btnMode"
        Me.btnMode.Size = New System.Drawing.Size(173, 31)
        Me.btnMode.TabIndex = 28
        Me.btnMode.Text = "Change to edit/delete"
        Me.btnMode.UseVisualStyleBackColor = True
        '
        'editDeleteOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 391)
        Me.Controls.Add(Me.btnMode)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.lblTut4)
        Me.Controls.Add(Me.lblTut3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtEmployeeID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtOrderID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lblTut2)
        Me.Controls.Add(Me.lblTut1)
        Me.Controls.Add(Me.btnNewOrder)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbxPaymentType)
        Me.Controls.Add(Me.lblPriceTotal)
        Me.Controls.Add(Me.cmbxProductName)
        Me.Controls.Add(Me.btnAddProduct)
        Me.Enabled = False
        Me.Name = "editDeleteOrder"
        Me.Text = "editDeleteOrder"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTut2 As Label
    Friend WithEvents lblTut1 As Label
    Friend WithEvents btnNewOrder As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbxPaymentType As ComboBox
    Friend WithEvents lblPriceTotal As Label
    Friend WithEvents cmbxProductName As ComboBox
    Friend WithEvents btnAddProduct As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents txtOrderID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEmployeeID As TextBox
    Friend WithEvents lblTut3 As Label
    Friend WithEvents lblTut4 As Label
    Friend WithEvents btnPrev As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnMode As Button
End Class
