Imports System.IO




Public Class orderSubForm
	Dim productList As New List(Of String)
	Dim productListName As New List(Of String)
	Dim priceTotal As Decimal
	Dim orderID As Int32
	Dim productMaxRow As Integer
	Dim uniqueProductNames() As String
	Dim uniqueProductQuantities() As Integer


	Private Sub orderSubForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		If accessLevel > 1 Then
			btnEditDelete.Visible = True
		End If
		Call fillCmbx()
		If MainMenu.accessLevel = 1 Then
			btnEditDelete.Visible = False
		End If
		simpleSQL2("SELECT * FROM tblProducts", "DStblProducts")
		productMaxRow = MaxRows2
	End Sub
	Public Sub fillCmbx()
		simpleSQL("SELECT tblProducts.ProductID, tblProducts.[Product Name], tblProducts.Price FROM tblProducts;", "ProductsPrice")
		curRow = 0
		cmbxProductName.DataSource = ds.Tables("ProductsPrice")
		cmbxProductName.DisplayMember = "Product Name"
		cmbxProductName.ValueMember = "Product Name"
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


		While intCounter < MaxRows 'linear searches for the correct ID, adds the ID to the list
			If ds.Tables("ProductsPrice").Rows(intCounter).Item(1) = cmbxProductName.SelectedValue Then



				If ds2.Tables("DStblProducts").Rows(intCounter).Item(4) > 0 Then
					productList.Add(ds.Tables("ProductsPrice").Rows(intCounter).Item(0))
					ds2.Tables("DStblProducts").Rows(intCounter).Item(4) = ds2.Tables("DStblProducts").Rows(intCounter).Item(4) - numQuant.Value
				Else
					MsgBox("This item is currently out of stock, we have added the remainder of available stock, we apologise for the inconvenience")
					Exit Sub
				End If





				Exit While
			End If
			intCounter = intCounter + 1
		End While
		intCounter = 0
		While intCounter < numQuant.Value
			intCounter = intCounter + 1
			listBoxName.DataSource = Nothing
			productListName.Add(cmbxProductName.SelectedValue)
			listBoxName.DataSource = productListName
			listBoxName.DisplayMember = (0)
			curRow = 0

			While curRow < MaxRows
				If ds.Tables("ProductsPrice").Rows(curRow).Item(0) = productList(productList.Count - 1) Then 'if the selected product record has the same ID, then select the price and add it to the total
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
			dsNewRow.Item("StudentID") = maskTxtStudentID.Text
			da.Update(ds, "DSOrder")

			Dim cb2 As New OleDb.OleDbCommandBuilder(da2)
			cb2.QuotePrefix = "["
			cb2.QuoteSuffix = "]"
			da2.Update(ds2, "DStblProducts")

			'orderLine section :)
			simpleSQL("SELECT OrderID FROM tblOrder", "orderID")
			orderID = ds.Tables("orderID").Rows(MaxRows - 1).Item(0) 'this small bit grabs the correct orderID that is needed for the orderLine table
			Call receiptMake()
			Call orderLine()
		Else
			MsgBox("Please enter a valid payment type and/or add atleast one product")
		End If
	End Sub

	Sub receiptMake()
		Dim FileToCopy As String
		Dim NewCopy As String
		Dim dateTimeNow As String


		FileToCopy = "..\..\receipt\devrec\TEMPATE_receipt.txt" 'here we copy the template receipt to the folder which holds ordinary receipts
		dateTimeNow = Today & "_" & TimeString
		dateTimeNow = dateTimeNow.Replace(":", "-")
		dateTimeNow = dateTimeNow.Replace("/", "-")
		NewCopy = "..\..\receipt\" & dateTimeNow & "_receipt.txt" 'names the file the current date and time, so that duplicate filename issues arent a problem

		If System.IO.File.Exists(FileToCopy) = True Then

			System.IO.File.Copy(FileToCopy, NewCopy)
			Console.WriteLine("DEV// receipt made succesfuly")

		End If

		File.AppendAllText("..\..\receipt\" & dateTimeNow & "_receipt.txt", Environment.NewLine + "") 'new line
		File.AppendAllText("..\..\receipt\" & dateTimeNow & "_receipt.txt", Environment.NewLine + "Order ID: " & orderID & " | Cashier: " & userLoggedFullName & " | Student: " & maskTxtStudentID.Text & " | Payment Method: " & cmbxPaymentType.SelectedItem & " | Date Ordered : " & dateTimeNow)
		File.AppendAllText("..\..\receipt\" & dateTimeNow & "_receipt.txt", Environment.NewLine + "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -")

		'we need to create a seperate list that is sorted so we can calculate the quantity of all products bought
		Dim receiptList As List(Of String) = productListName
		receiptList.Sort()
		' now we need to count the products in the list, so if the first object is "A" we up the quantity of "A" +1, if the next one is "A", the quantity of A increases again. If "B" or any other object is seen, "A" is to be printed.
		Dim ProductDictionary As New Dictionary(Of String, Integer)


		Call productListToDictionary(ProductDictionary)

		Dim lengthString As String
		For Each kvp In ProductDictionary

			lengthString = StrDup(60 - kvp.Key.Length, " ")

			File.AppendAllText("..\..\receipt\" & dateTimeNow & "_receipt.txt", Environment.NewLine + kvp.Key & lengthString & "| " & kvp.Value & "x " & FormatCurrency(getPrice(kvp.Key, kvp.Value)))

		Next
		lengthString = StrDup(60 - 13, " ")
		File.AppendAllText("..\..\receipt\" & dateTimeNow & "_receipt.txt", Environment.NewLine + "Total Price: " & lengthString & "| " & FormatCurrency(priceTotal))

	End Sub

	Function getPrice(productName As String, Quantity As Integer)
		Dim intCounter As Integer
		While intCounter < ds.Tables("ProductsPrice").Rows.Count


			If ds.Tables("ProductsPrice").Rows(intCounter).Item(1) = productName Then
				Return Quantity * ds.Tables("ProductsPrice").Rows(intCounter).Item(2)
			End If

			intCounter = intCounter + 1
		End While
	End Function

	Sub productListToDictionary(ProductDictionary As Dictionary(Of String, Integer))
		' Initialize the ProductDictionary


		' Loop through each item in the ProductList
		For Each item In productListName
			' Check if the item is already in the ProductDictionary
			If ProductDictionary.ContainsKey(item) Then
				' If it is, increment the value of that key by 1
				ProductDictionary(item) += 1
			Else
				' If it isn't, add it to the ProductDictionary as a new key with a value of 1
				ProductDictionary.Add(item, 1)
			End If
		Next

		' Display the contents of the ProductDictionary as a receipt
		Console.WriteLine("Product    Quantity")
		Console.WriteLine("-------------------")
		For Each kvp In ProductDictionary
			Console.WriteLine(kvp.Key.PadRight(10) & kvp.Value)
		Next
	End Sub


	'Function count(receiptList As List(Of String))
	'	Dim intCounter As Integer
	'	Dim quantity As Integer
	'	While intCounter < receiptList.Count - 1
	'		If receiptList(intCounter) = receiptList(intCounter + 1) Then 'here we know that location 0 and 1 are the same. We do need to add +1 IF intCounter is 0
	'			If intCounter = 0 Then
	'				quantity = quantity + 1
	'			End If
	'			quantity = quantity + 1 'increments the quantity
	'		Else
	'			Return 0 '0 is used as a null, if it is 0 we next line
	'		End If
	'		intCounter = intCounter + 1
	'	End While
	'	Return quantity  'returns the quantity of product bought
	'End Function

	'Function productNameAndQuantity(receiptList As List(Of String), quantity As Integer)
	'	Dim intCounter As Integer
	'	While intCounter < receiptList.Count - 1
	'		If intCounter = 0 Then
	'			Return receiptList(intCounter) & " " * 60 - productList(intCounter).Length & "| " & quantity & " " & quantity
	'		End If
	'	End While
	'End Function

	'Function priceXQ(receiptList As List(Of String), quantity As Integer)
	'	While curRow < MaxRows
	'		If ds.Tables("ProductsPrice").Rows(curRow).Item(0) = receiptList(receiptList.Count - 1) Then 'if the selected product record has the same ID, then select the price and add it to the total
	'			priceTotal = priceTotal + ds.Tables("ProductsPrice").Rows(curRow).Item(2)
	'			lblPriceTotal.Text = "Total Price: " & FormatCurrency(priceTotal)
	'			Exit While
	'		Else
	'			curRow = curRow + 1
	'		End If
	'	End While
	'End Function
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
		lblPriceTotal.Text = "Total Price:  "
		productList.Clear() 'clears the list so new product can be added
	End Sub

	Private Sub btnEditDelete_Click(sender As Object, e As EventArgs) Handles btnEditDelete.Click 'may be replaced for automatically grabbing the user ID and then showing, but for right now the button will have to do
		curRow = 0
		btnPrev.Visible = True
		btnNext.Visible = True
		DateTimePicker1.Visible = True
		txtEmployeeID.Visible = True
		txtOrderID.Visible = True
		lblDate.Visible = True
		lblEmp.Visible = True
		lblOrder.Visible = True
		btnUpdate.Visible = True
		listBoxNameView.Visible = True

		lblStudentID.Visible = False
		maskTxtStudentID.Visible = False
		lblProd.Visible = False
		btnAddProduct.Visible = False
		numQuant.Visible = False
		btnNewOrder.Visible = False
		cmbxProductName.Visible = False
		listBoxName.Visible = False
		lblPriceTotal.Location = New Point(643, 280)
		cmbxPaymentType.Location = New Point(313, 209)
		Label1.Location = New Point(347, 188)
		'lblPriceTotal.Location = (643, 280)
		'shows all of the admin tools

		'now we are in edit and delete mode, this means we need to fill these data entry points with data from the order table (tblOrder)

		simpleSQL("SELECT * FROM tblOrder", "DSOrder") 'this selects all of the order table, now the thing with editing orders is that when an order needs to be deleted, it needs to delete all respected entries in orderLine, this may be replaced by a query combing both tables but right now that is not necessary

		Call NavigateRecords()
	End Sub
	Sub NavigateRecords()
		Try

			listBoxNameView.DataSource = Nothing

			txtOrderID.Text = ds.Tables("DSOrder").Rows(curRow).Item(0)
			txtEmployeeID.Text = ds.Tables("DSOrder").Rows(curRow).Item(2)
			DateTimePicker1.Value = ds.Tables("DSOrder").Rows(curRow).Item(1)
			cmbxPaymentType.SelectedItem = ds.Tables("DSOrder").Rows(curRow).Item(3)
			priceTotal = ds.Tables("DSOrder").Rows(curRow).Item(4)
			lblPriceTotal.Text = "Total Price: " & FormatCurrency(priceTotal)

			simpleSQL("SELECT tblOrder.OrderID, tblOrderLine.OrderLineID, tblOrderLine.ProductID, tblProducts.[Product Name]
FROM tblProducts INNER JOIN (tblOrder INNER JOIN tblOrderLine ON tblOrder.OrderID = tblOrderLine.OrderID) ON tblProducts.ProductID = tblOrderLine.ProductID WHERE tblOrder.OrderID = " & ds.Tables("DSOrder").Rows(curRow).Item(0) & ";
", "DSListNameView")

			listBoxNameView.DataSource = ds.Tables("DSListNameView")
			listBoxNameView.DisplayMember = "Product Name"

			ds.Tables.Remove("DSListNameView")

			'Dim foundRows() As Data.DataRow
			'foundRows = ds.Tables("DSListNameView").Select("OrderID = '" & ds.Tables("DSOrder").Rows(curRow).Item(0) & "'")
			''("OrderID = '" & ds.Tables("DSOrder").Rows(curRow).Item(0) & "'")
			'listBoxNameView.DataSource = foundRows
		Catch ex As Exception
			MsgBox("There are no more orders")
			curRow = curRow - 1
			Call NavigateRecords()
		End Try
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

	Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
		Dim cb As New OleDb.OleDbCommandBuilder(da)

		If presenceCheck(txtOrderID.Text) And presenceCheck(txtEmployeeID.Text) = True Then

			' sql will not work without prefixes and suffixes
			cb.QuotePrefix = "["
			cb.QuoteSuffix = "]"

			'Updates the dataset to whats written in the text boxes            
			ds.Tables("DSOrder").Rows(curRow).Item(0) = 0 'autonumber cringe
			ds.Tables("DSOrder").Rows(curRow).Item(1) = DateTimePicker1.Value
			ds.Tables("DSOrder").Rows(curRow).Item(2) = txtEmployeeID.Text

			da.Update(ds, "DSOrder") 'Updates the database with new data

			MsgBox("Data updated") 'this message gives user confimation that an action has taken place (Data updated)
		Else
			MsgBox("Please enter data in all fields")
		End If
	End Sub

	Private Sub listBoxName_MouseClick(sender As Object, e As MouseEventArgs) Handles listBoxName.MouseClick
		While curRow < MaxRows
			If ds.Tables("ProductsPrice").Rows(curRow).Item(1) = listBoxName.SelectedItem Then 'if the selected product record has the same ID, then select the price and add it to the total
				priceTotal = priceTotal - ds.Tables("ProductsPrice").Rows(curRow).Item(2)
				lblPriceTotal.Text = "Total Price: " & FormatCurrency(priceTotal)
				Exit While
			Else
				curRow = curRow + 1
			End If
		End While
		productList.Remove(listBoxName.SelectedIndex)
		productListName.Remove(listBoxName.SelectedItem)
		listBoxName.DataSource = Nothing 'refreshing datasource
		listBoxName.DataSource = productListName
		curRow = 0



		Dim intCounter As Integer
		While intCounter < productMaxRow 'linear searches for the correct ID, adds the ID to the list
			If ds.Tables("ProductsPrice").Rows(intCounter).Item(1) = listBoxName.SelectedItem Then

				ds2.Tables("DStblProducts").Rows(intCounter).Item(4) = ds2.Tables("DStblProducts").Rows(intCounter).Item(4) + 1

				Exit While
			End If
			intCounter = intCounter + 1
		End While


	End Sub

	Private Sub listBoxNameView_MouseClick(sender As Object, e As MouseEventArgs) Handles listBoxNameView.MouseClick
		While curRow < MaxRows
			If ds.Tables("ProductsPrice").Rows(curRow).Item(1) = listBoxName.SelectedItem Then 'if the selected product record has the same ID, then select the price and add it to the total
				priceTotal = priceTotal - ds.Tables("ProductsPrice").Rows(curRow).Item(2)
				lblPriceTotal.Text = "Total Price: " & FormatCurrency(priceTotal)
				Exit While
			Else
				curRow = curRow + 1
			End If
		End While
		productList.Remove(listBoxName.SelectedIndex)
		productListName.Remove(listBoxName.SelectedItem)
		listBoxName.DataSource = Nothing 'refreshing datasource
		listBoxName.DataSource = productListName
		curRow = 0





	End Sub








	'Private Sub listBoxName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listBoxName.SelectedIndexChanged

	'	productList.Remove(listBoxName.SelectedIndex)
	'		productListName.Remove(listBoxName.SelectedItem)
	'		listBoxName.DataSource = Nothing 'refreshing datasource
	'	listBoxName.DataSource = productListName
	'End Sub

End Class