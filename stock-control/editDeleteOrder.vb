Public Class editDeleteOrder
	Dim productList As New List(Of String)
	Dim priceTotal As Decimal
	Dim orderID As Int32

	Private Sub orderSubForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Call fillCmbx()
	End Sub
	Public Sub fillCmbx()
		simpleSQL("SELECT tblProducts.ProductID, tblProducts.[Product Name], tblProducts.Price FROM tblProducts;", "Products")
		curRow = 0
		cmbxProductName.DataSource = ds.Tables("Products")
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
		productList.Add(cmbxProductName.SelectedValue)
		Dim product As String = productList(productList.Count - 1)
		curRow = 0

		While curRow < MaxRows
			If ds.Tables("Products").Rows(curRow).Item(0) = cmbxProductName.SelectedValue Then 'if the selected product record has the same ID, then select the price and add it to the total
				priceTotal = priceTotal + ds.Tables("Products").Rows(curRow).Item(2)
				lblPriceTotal.Text = "Total Price: " & priceTotal
				Exit While
			Else
				curRow = curRow + 1
			End If
		End While


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


End Class