Public Class orderSubForm
	Dim productList As New List(Of String)
	Dim priceTotal As Decimal
	Dim orderID As Int32


	Private Sub orderSubForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Call fillCmbx()
		If MainMenu.accessLevel = 1 Then
			btnEditDelete.Visible = False
		End If

	End Sub
	Public Sub fillCmbx()
		simpleSQL("SELECT tblProducts.ProductID, tblProducts.[Product Name], tblProducts.Price FROM tblProducts;", "ProductsPrice")
		curRow = 0
		cmbxProductName.DataSource = ds.Tables("ProductsPrice")
		cmbxProductName.DisplayMember = "Product Name"
		cmbxProductName.ValueMember = "ProductID"
	End Sub

	Function validation() 'validation cannot use the usual functions since nothing is a text box
		If priceTotal = 0 Then
			Return False
		ElseIf cmbxPaymentType.SelectedItem = "" Then
			Return False
		Else
			Return True
		End If
	End Function


	Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
		Dim intCounter As Integer = 0

		While intCounter < numQuant.Value
			productList.Add(cmbxProductName.SelectedValue)
			intCounter = intCounter + 1

			curRow = 0

		While curRow < MaxRows
			If ds.Tables("ProductsPrice").Rows(curRow).Item(0) = cmbxProductName.SelectedValue Then 'if the selected product record has the same ID, then select the price and add it to the total
				priceTotal = priceTotal + ds.Tables("ProductsPrice").Rows(curRow).Item(2)
				lblPriceTotal.Text = "Total Price: " & FormatCurrency(priceTotal)
				Exit While
			Else
				curRow = curRow + 1
			End If
		End While
		End While
		intCounter = 0
	End Sub

	Private Sub btnNewOrder_Click(sender As Object, e As EventArgs) Handles btnNewOrder.Click
		If validation() = True Then 'checks to see if data has been entered
			'create record in order table
			simpleSQL("SELECT * FROM tblOrder", "DSOrder")
			'first we need to create a new blank record
			Dim cb As New OleDb.OleDbCommandBuilder(da)
			cb.QuotePrefix = "["
			cb.QuoteSuffix = "]"
			Dim dsNewRow As DataRow
			dsNewRow = ds.Tables("DSOrder").NewRow()
			ds.Tables("DSOrder").Rows.Add(dsNewRow)
			'now we need to fill out the new prices of data
			dsNewRow.Item("OrderID") = 0 'autonumber cringe
			dsNewRow.Item("Order Date") = Today 'grabs current date as value
			dsNewRow.Item("EmployeeID") = employeeID 'this is the current user logged in
			dsNewRow.Item("Payment Type") = cmbxPaymentType.SelectedItem
			dsNewRow.Item("Cost") = priceTotal 'this is the total price of all added items
			da.Update(ds, "DSOrder")

			'orderLine section :)
			simpleSQL("SELECT OrderID FROM tblOrder", "orderID")
			orderID = ds.Tables("orderID").Rows(MaxRows - 1).Item(0) 'this small bit grabs the correct orderID that is needed for the orderLine table
			Call orderLine()
		Else
			MsgBox("Please enter a valid payment type and/or add atleast one product")
		End If
	End Sub
	Sub orderLine()
		simpleSQL("SELECT * FROM tblOrderLine", "DSOrderLine")
		Dim cb As New OleDb.OleDbCommandBuilder(da)
		cb.QuotePrefix = "["
		cb.QuoteSuffix = "]"
		Dim dsNewRow As DataRow
		Dim intCounter As Integer = 0
		While intCounter < productList.Count
			dsNewRow = ds.Tables("DSOrderLine").NewRow()
			ds.Tables("DSOrderLine").Rows.Add(dsNewRow)
			dsNewRow.Item("OrderLineID") = 0
			dsNewRow.Item("OrderID") = orderID 'adds the ID of the current order
			MsgBox(productList(intCounter))
			dsNewRow.Item("ProductID") = productList(intCounter) 'adds the ID of one of the selected products
			da.Update(ds, "DSOrderLine")
			intCounter = intCounter + 1
		End While
		MsgBox("Order has been added succesfully")
		Call Clear()
	End Sub
	Sub Clear()
		priceTotal = 0
		lblPriceTotal.Text = "Total Price: "
		productList.Clear() 'clears the list so new product can be added
	End Sub

	Private Sub btnEditDelete_Click(sender As Object, e As EventArgs) Handles btnEditDelete.Click 'may be replaced for automatically grabbing the user ID and then showing, but for right now the button will have to do
		btnPrev.Visible = True
		btnNext.Visible = True
		DateTimePicker1.Visible = True
		txtEmployeeID.Visible = True
		txtOrderID.Visible = True
		lblDate.Visible = True
		lblEmp.Visible = True
		lblOrder.Visible = True
		'shows all of the admin tools

		'now we are in edit and delete mode, this means we need to fill these data entry points with data from the order table (tblOrder)

		simpleSQL("SELECT * FROM tblOrder", "DSOrder") 'this selects all of the order table, now the thing with editing orders is that when an order needs to be deleted, it needs to delete all respected entries in orderLine, this may be replaced by a query combing both tables but right now that is not necessary
		Call NavigateRecords()
	End Sub
	Sub NavigateRecords()
		txtOrderID.Text = ds.Tables("DSOrder").Rows(curRow).Item(0)
		txtEmployeeID.Text = ds.Tables("DSOrder").Rows(curRow).Item(2)
		DateTimePicker1.Value = ds.Tables("DSOrder").Rows(curRow).Item(1)
		cmbxPaymentType.SelectedItem = ds.Tables("DSOrder").Rows(curRow).Item(3)
		priceTotal = ds.Tables("DSOrder").Rows(curRow).Item(4)
		lblPriceTotal.Text = "Total Price: " & FormatCurrency(priceTotal)
	End Sub

	Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
		curRow = curRow - 1
		If curRow < 0 Then 'checks if the current row is lower than the first available row, which will always be 0, it then changes it back to 0 and exits the sub before the NavigateRecords sub can be called, this avoid an error
			MsgBox("This is the first order")
			curRow = 0
			Exit Sub
		End If
		Call NavigateRecords()
	End Sub

	Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
		curRow = curRow + 1
		If curRow > MaxRows - 1 Then 'checks if the current row is higher than the last available row, which will always be MaxRows, it then changes it to -1 itself so that an error does not occur
			MsgBox("This is the last order")
			curRow = curRow - 1
			Exit Sub
		End If
		Call NavigateRecords()
	End Sub

End Class