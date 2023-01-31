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
        Me.lblEmp = New System.Windows.Forms.Label()
        Me.txtEmployeeID = New System.Windows.Forms.TextBox()
        Me.lblOrder = New System.Windows.Forms.Label()
        Me.txtOrderID = New System.Windows.Forms.TextBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.Overlay1 = New stock_control.overlay()
        Me.SuspendLayout()
        '
        'btnAddProduct
        '
        Me.btnAddProduct.Location = New System.Drawing.Point(191, 318)
        Me.btnAddProduct.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddProduct.Name = "btnAddProduct"
        Me.btnAddProduct.Size = New System.Drawing.Size(92, 20)
        Me.btnAddProduct.TabIndex = 0
        Me.btnAddProduct.Text = "Add Product"
        Me.btnAddProduct.UseVisualStyleBackColor = True
        '
        'cmbxProductName
        '
        Me.cmbxProductName.FormattingEnabled = True
        Me.cmbxProductName.Location = New System.Drawing.Point(176, 294)
        Me.cmbxProductName.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbxProductName.Name = "cmbxProductName"
        Me.cmbxProductName.Size = New System.Drawing.Size(131, 21)
        Me.cmbxProductName.TabIndex = 1
        '
        'lblPriceTotal
        '
        Me.lblPriceTotal.AutoSize = True
        Me.lblPriceTotal.Location = New System.Drawing.Point(174, 278)
        Me.lblPriceTotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPriceTotal.Name = "lblPriceTotal"
        Me.lblPriceTotal.Size = New System.Drawing.Size(64, 13)
        Me.lblPriceTotal.TabIndex = 3
        Me.lblPriceTotal.Text = "Total Price: "
        '
        'cmbxPaymentType
        '
        Me.cmbxPaymentType.FormattingEnabled = True
        Me.cmbxPaymentType.Items.AddRange(New Object() {"Debit", "Cash", "PayPal"})
        Me.cmbxPaymentType.Location = New System.Drawing.Point(176, 256)
        Me.cmbxPaymentType.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbxPaymentType.Name = "cmbxPaymentType"
        Me.cmbxPaymentType.Size = New System.Drawing.Size(131, 21)
        Me.cmbxPaymentType.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(174, 241)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Payment Type"
        '
        'btnNewOrder
        '
        Me.btnNewOrder.Location = New System.Drawing.Point(176, 352)
        Me.btnNewOrder.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNewOrder.Name = "btnNewOrder"
        Me.btnNewOrder.Size = New System.Drawing.Size(130, 25)
        Me.btnNewOrder.TabIndex = 6
        Me.btnNewOrder.Text = "Submit Order"
        Me.btnNewOrder.UseVisualStyleBackColor = True
        '
        'lblTut1
        '
        Me.lblTut1.AutoSize = True
        Me.lblTut1.Location = New System.Drawing.Point(310, 287)
        Me.lblTut1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTut1.Name = "lblTut1"
        Me.lblTut1.Size = New System.Drawing.Size(174, 26)
        Me.lblTut1.TabIndex = 7
        Me.lblTut1.Text = "*Select the product from the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "combo box, then press add product"
        '
        'lblTut2
        '
        Me.lblTut2.AutoSize = True
        Me.lblTut2.Location = New System.Drawing.Point(310, 259)
        Me.lblTut2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTut2.Name = "lblTut2"
        Me.lblTut2.Size = New System.Drawing.Size(107, 13)
        Me.lblTut2.TabIndex = 8
        Me.lblTut2.Text = "*Select payment type"
        '
        'btnEditDelete
        '
        Me.btnEditDelete.Location = New System.Drawing.Point(329, 352)
        Me.btnEditDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEditDelete.Name = "btnEditDelete"
        Me.btnEditDelete.Size = New System.Drawing.Size(130, 25)
        Me.btnEditDelete.TabIndex = 9
        Me.btnEditDelete.Text = "View Orders"
        Me.btnEditDelete.UseVisualStyleBackColor = True
        '
        'lblTut4
        '
        Me.lblTut4.AutoSize = True
        Me.lblTut4.Location = New System.Drawing.Point(310, 225)
        Me.lblTut4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTut4.Name = "lblTut4"
        Me.lblTut4.Size = New System.Drawing.Size(74, 13)
        Me.lblTut4.TabIndex = 34
        Me.lblTut4.Text = "*Select a date"
        Me.lblTut4.Visible = False
        '
        'lblTut3
        '
        Me.lblTut3.AutoSize = True
        Me.lblTut3.Location = New System.Drawing.Point(310, 180)
        Me.lblTut3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTut3.Name = "lblTut3"
        Me.lblTut3.Size = New System.Drawing.Size(60, 13)
        Me.lblTut3.TabIndex = 33
        Me.lblTut3.Text = "*Select IDs"
        Me.lblTut3.Visible = False
        '
        'lblEmp
        '
        Me.lblEmp.AutoSize = True
        Me.lblEmp.Location = New System.Drawing.Point(249, 165)
        Me.lblEmp.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEmp.Name = "lblEmp"
        Me.lblEmp.Size = New System.Drawing.Size(67, 13)
        Me.lblEmp.TabIndex = 32
        Me.lblEmp.Text = "Employee ID"
        Me.lblEmp.Visible = False
        '
        'txtEmployeeID
        '
        Me.txtEmployeeID.Location = New System.Drawing.Point(251, 180)
        Me.txtEmployeeID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmployeeID.Name = "txtEmployeeID"
        Me.txtEmployeeID.Size = New System.Drawing.Size(56, 20)
        Me.txtEmployeeID.TabIndex = 31
        Me.txtEmployeeID.Visible = False
        '
        'lblOrder
        '
        Me.lblOrder.AutoSize = True
        Me.lblOrder.Location = New System.Drawing.Point(171, 165)
        Me.lblOrder.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOrder.Name = "lblOrder"
        Me.lblOrder.Size = New System.Drawing.Size(47, 13)
        Me.lblOrder.TabIndex = 30
        Me.lblOrder.Text = "Order ID"
        Me.lblOrder.Visible = False
        '
        'txtOrderID
        '
        Me.txtOrderID.Location = New System.Drawing.Point(176, 180)
        Me.txtOrderID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtOrderID.Name = "txtOrderID"
        Me.txtOrderID.Size = New System.Drawing.Size(56, 20)
        Me.txtOrderID.TabIndex = 29
        Me.txtOrderID.Visible = False
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(174, 200)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(30, 13)
        Me.lblDate.TabIndex = 28
        Me.lblDate.Text = "Date"
        Me.lblDate.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(176, 221)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(131, 20)
        Me.DateTimePicker1.TabIndex = 27
        Me.DateTimePicker1.Visible = False
        '
        'btnPrev
        '
        Me.btnPrev.Location = New System.Drawing.Point(329, 327)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(62, 20)
        Me.btnPrev.TabIndex = 35
        Me.btnPrev.Text = "Previous"
        Me.btnPrev.UseVisualStyleBackColor = True
        Me.btnPrev.Visible = False
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(397, 327)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(62, 20)
        Me.btnNext.TabIndex = 36
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        Me.btnNext.Visible = False
        '
        'Overlay1
        '
        Me.Overlay1.BackColor = System.Drawing.Color.Transparent
        Me.Overlay1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Overlay1.Location = New System.Drawing.Point(0, 0)
        Me.Overlay1.Name = "Overlay1"
        Me.Overlay1.Size = New System.Drawing.Size(1224, 501)
        Me.Overlay1.TabIndex = 38
        '
        'orderSubForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(1224, 501)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.lblTut4)
        Me.Controls.Add(Me.lblTut3)
        Me.Controls.Add(Me.lblEmp)
        Me.Controls.Add(Me.txtEmployeeID)
        Me.Controls.Add(Me.lblOrder)
        Me.Controls.Add(Me.txtOrderID)
        Me.Controls.Add(Me.lblDate)
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
        Me.Controls.Add(Me.Overlay1)
        Me.Margin = New System.Windows.Forms.Padding(2)
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
    Friend WithEvents lblEmp As Label
    Friend WithEvents txtEmployeeID As TextBox
    Friend WithEvents lblOrder As Label
    Friend WithEvents txtOrderID As TextBox
    Friend WithEvents lblDate As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btnPrev As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents Overlay1 As overlay
End Class
