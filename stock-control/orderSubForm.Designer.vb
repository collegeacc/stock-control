﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(orderSubForm))
        Me.cmbxProductName = New System.Windows.Forms.ComboBox()
        Me.lblPriceTotal = New System.Windows.Forms.Label()
        Me.cmbxPaymentType = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnNewOrder = New System.Windows.Forms.Button()
        Me.btnEditDelete = New System.Windows.Forms.Button()
        Me.lblEmp = New System.Windows.Forms.Label()
        Me.txtEmployeeID = New System.Windows.Forms.TextBox()
        Me.lblOrder = New System.Windows.Forms.Label()
        Me.txtOrderID = New System.Windows.Forms.TextBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.lblProd = New System.Windows.Forms.Label()
        Me.numQuant = New System.Windows.Forms.NumericUpDown()
        Me.listBoxName = New System.Windows.Forms.ListBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.listBoxNameView = New System.Windows.Forms.ListBox()
        Me.btnAddProduct = New System.Windows.Forms.PictureBox()
        Me.lblStudentID = New System.Windows.Forms.Label()
        Me.maskTxtStudentID = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Overlay1 = New stock_control.overlay()
        CType(Me.numQuant, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAddProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbxProductName
        '
        Me.cmbxProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxProductName.FormattingEnabled = True
        Me.cmbxProductName.Location = New System.Drawing.Point(183, 236)
        Me.cmbxProductName.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbxProductName.Name = "cmbxProductName"
        Me.cmbxProductName.Size = New System.Drawing.Size(139, 21)
        Me.cmbxProductName.TabIndex = 1
        '
        'lblPriceTotal
        '
        Me.lblPriceTotal.AutoSize = True
        Me.lblPriceTotal.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPriceTotal.Location = New System.Drawing.Point(326, 283)
        Me.lblPriceTotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPriceTotal.Name = "lblPriceTotal"
        Me.lblPriceTotal.Size = New System.Drawing.Size(93, 21)
        Me.lblPriceTotal.TabIndex = 3
        Me.lblPriceTotal.Text = "Total Price: "
        '
        'cmbxPaymentType
        '
        Me.cmbxPaymentType.FormattingEnabled = True
        Me.cmbxPaymentType.Items.AddRange(New Object() {"Debit", "Cash", "PayPal"})
        Me.cmbxPaymentType.Location = New System.Drawing.Point(183, 182)
        Me.cmbxPaymentType.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbxPaymentType.Name = "cmbxPaymentType"
        Me.cmbxPaymentType.Size = New System.Drawing.Size(139, 21)
        Me.cmbxPaymentType.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(179, 159)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 21)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Payment Type"
        '
        'btnNewOrder
        '
        Me.btnNewOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewOrder.Location = New System.Drawing.Point(183, 373)
        Me.btnNewOrder.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNewOrder.Name = "btnNewOrder"
        Me.btnNewOrder.Size = New System.Drawing.Size(187, 57)
        Me.btnNewOrder.TabIndex = 6
        Me.btnNewOrder.Text = "Submit Order"
        Me.btnNewOrder.UseVisualStyleBackColor = True
        '
        'btnEditDelete
        '
        Me.btnEditDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditDelete.Location = New System.Drawing.Point(452, 373)
        Me.btnEditDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEditDelete.Name = "btnEditDelete"
        Me.btnEditDelete.Size = New System.Drawing.Size(190, 55)
        Me.btnEditDelete.TabIndex = 9
        Me.btnEditDelete.Text = "View Orders"
        Me.btnEditDelete.UseVisualStyleBackColor = True
        Me.btnEditDelete.Visible = False
        '
        'lblEmp
        '
        Me.lblEmp.AutoSize = True
        Me.lblEmp.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblEmp.Location = New System.Drawing.Point(540, 188)
        Me.lblEmp.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEmp.Name = "lblEmp"
        Me.lblEmp.Size = New System.Drawing.Size(102, 21)
        Me.lblEmp.TabIndex = 32
        Me.lblEmp.Text = "Employee ID"
        Me.lblEmp.Visible = False
        '
        'txtEmployeeID
        '
        Me.txtEmployeeID.Location = New System.Drawing.Point(544, 211)
        Me.txtEmployeeID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmployeeID.Name = "txtEmployeeID"
        Me.txtEmployeeID.Size = New System.Drawing.Size(69, 20)
        Me.txtEmployeeID.TabIndex = 31
        Me.txtEmployeeID.Visible = False
        '
        'lblOrder
        '
        Me.lblOrder.AutoSize = True
        Me.lblOrder.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblOrder.Location = New System.Drawing.Point(463, 188)
        Me.lblOrder.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOrder.Name = "lblOrder"
        Me.lblOrder.Size = New System.Drawing.Size(73, 21)
        Me.lblOrder.TabIndex = 30
        Me.lblOrder.Text = "Order ID"
        Me.lblOrder.Visible = False
        '
        'txtOrderID
        '
        Me.txtOrderID.Location = New System.Drawing.Point(467, 211)
        Me.txtOrderID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtOrderID.Name = "txtOrderID"
        Me.txtOrderID.Size = New System.Drawing.Size(69, 20)
        Me.txtOrderID.TabIndex = 29
        Me.txtOrderID.Visible = False
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblDate.Location = New System.Drawing.Point(463, 233)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(44, 21)
        Me.lblDate.TabIndex = 28
        Me.lblDate.Text = "Date"
        Me.lblDate.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(467, 256)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(146, 20)
        Me.DateTimePicker1.TabIndex = 27
        Me.DateTimePicker1.Visible = False
        '
        'btnPrev
        '
        Me.btnPrev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrev.Location = New System.Drawing.Point(467, 281)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(69, 20)
        Me.btnPrev.TabIndex = 35
        Me.btnPrev.Text = "Previous"
        Me.btnPrev.UseVisualStyleBackColor = True
        Me.btnPrev.Visible = False
        '
        'btnNext
        '
        Me.btnNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNext.Location = New System.Drawing.Point(544, 281)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(69, 20)
        Me.btnNext.TabIndex = 36
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        Me.btnNext.Visible = False
        '
        'lblProd
        '
        Me.lblProd.AutoSize = True
        Me.lblProd.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblProd.Location = New System.Drawing.Point(179, 211)
        Me.lblProd.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblProd.Name = "lblProd"
        Me.lblProd.Size = New System.Drawing.Size(135, 21)
        Me.lblProd.TabIndex = 39
        Me.lblProd.Text = "Select product(s)"
        '
        'numQuant
        '
        Me.numQuant.Location = New System.Drawing.Point(329, 319)
        Me.numQuant.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.numQuant.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numQuant.Name = "numQuant"
        Me.numQuant.Size = New System.Drawing.Size(46, 20)
        Me.numQuant.TabIndex = 41
        Me.numQuant.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'listBoxName
        '
        Me.listBoxName.FormattingEnabled = True
        Me.listBoxName.Location = New System.Drawing.Point(330, 159)
        Me.listBoxName.Name = "listBoxName"
        Me.listBoxName.Size = New System.Drawing.Size(120, 95)
        Me.listBoxName.TabIndex = 42
        '
        'btnUpdate
        '
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.Location = New System.Drawing.Point(502, 307)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 47
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        Me.btnUpdate.Visible = False
        '
        'listBoxNameView
        '
        Me.listBoxNameView.FormattingEnabled = True
        Me.listBoxNameView.Location = New System.Drawing.Point(647, 159)
        Me.listBoxNameView.Name = "listBoxNameView"
        Me.listBoxNameView.Size = New System.Drawing.Size(120, 95)
        Me.listBoxNameView.TabIndex = 48
        Me.listBoxNameView.Visible = False
        '
        'btnAddProduct
        '
        Me.btnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddProduct.Image = Global.stock_control.My.Resources.Resources.addproduct
        Me.btnAddProduct.Location = New System.Drawing.Point(183, 309)
        Me.btnAddProduct.Name = "btnAddProduct"
        Me.btnAddProduct.Size = New System.Drawing.Size(139, 40)
        Me.btnAddProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnAddProduct.TabIndex = 40
        Me.btnAddProduct.TabStop = False
        '
        'lblStudentID
        '
        Me.lblStudentID.AutoSize = True
        Me.lblStudentID.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblStudentID.Location = New System.Drawing.Point(179, 259)
        Me.lblStudentID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblStudentID.Name = "lblStudentID"
        Me.lblStudentID.Size = New System.Drawing.Size(88, 21)
        Me.lblStudentID.TabIndex = 50
        Me.lblStudentID.Text = "Student ID"
        '
        'maskTxtStudentID
        '
        Me.maskTxtStudentID.Location = New System.Drawing.Point(183, 283)
        Me.maskTxtStudentID.Mask = "S0000"
        Me.maskTxtStudentID.Name = "maskTxtStudentID"
        Me.maskTxtStudentID.Size = New System.Drawing.Size(45, 20)
        Me.maskTxtStudentID.TabIndex = 51
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(158, 182)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 25)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Lime
        Me.Label3.Location = New System.Drawing.Point(158, 236)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 25)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Lime
        Me.Label4.Location = New System.Drawing.Point(158, 283)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 25)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Lime
        Me.Label5.Location = New System.Drawing.Point(381, 319)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 25)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "*"
        '
        'Overlay1
        '
        Me.Overlay1.BackColor = System.Drawing.Color.Transparent
        Me.Overlay1.BackgroundImage = CType(resources.GetObject("Overlay1.BackgroundImage"), System.Drawing.Image)
        Me.Overlay1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Overlay1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Overlay1.Location = New System.Drawing.Point(0, 0)
        Me.Overlay1.Name = "Overlay1"
        Me.Overlay1.Size = New System.Drawing.Size(800, 461)
        Me.Overlay1.TabIndex = 38
        '
        'orderSubForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(800, 461)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.maskTxtStudentID)
        Me.Controls.Add(Me.lblStudentID)
        Me.Controls.Add(Me.listBoxNameView)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.listBoxName)
        Me.Controls.Add(Me.numQuant)
        Me.Controls.Add(Me.btnAddProduct)
        Me.Controls.Add(Me.lblProd)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.lblEmp)
        Me.Controls.Add(Me.txtEmployeeID)
        Me.Controls.Add(Me.lblOrder)
        Me.Controls.Add(Me.txtOrderID)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.btnEditDelete)
        Me.Controls.Add(Me.btnNewOrder)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbxPaymentType)
        Me.Controls.Add(Me.lblPriceTotal)
        Me.Controls.Add(Me.cmbxProductName)
        Me.Controls.Add(Me.Overlay1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "orderSubForm"
        Me.Text = "Order"
        CType(Me.numQuant, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAddProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbxProductName As ComboBox
    Friend WithEvents lblPriceTotal As Label
    Friend WithEvents cmbxPaymentType As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnNewOrder As Button
    Friend WithEvents btnEditDelete As Button
    Friend WithEvents lblEmp As Label
    Friend WithEvents txtEmployeeID As TextBox
    Friend WithEvents lblOrder As Label
    Friend WithEvents txtOrderID As TextBox
    Friend WithEvents lblDate As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btnPrev As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents Overlay1 As overlay
    Friend WithEvents lblProd As Label
    Friend WithEvents btnAddProduct As PictureBox
    Friend WithEvents numQuant As NumericUpDown
    Friend WithEvents listBoxName As ListBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents listBoxNameView As ListBox
    Friend WithEvents lblStudentID As Label
    Friend WithEvents maskTxtStudentID As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
