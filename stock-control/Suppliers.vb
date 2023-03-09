Imports FxResources.System
Public Class Suppliers
	Private Sub Suppliers_Load(sender As Object, e As EventArgs) Handles Me.Load
		simpleSQL("SELECT * FROM tblSupplier", "DSSupplier")

		If accessLevel = 2 Then
			btnEditDelete.Visible = False
		End If
	End Sub


	Private Sub newRecord()
		Dim cb As New OleDb.OleDbCommandBuilder(da)
		cb.QuotePrefix = "["
		cb.QuoteSuffix = "]"
		Dim dsNewRow As DataRow
		dsNewRow = ds.Tables("DSSupplier").NewRow()

		'now we need to fill out the new prices of data
		dsNewRow.Item("SupplierID") = 0 'autonumber cringe
		dsNewRow.Item("Supplier Name") = txtSupplierName.Text
		dsNewRow.Item("Email") = txtEmail.Text
		ds.Tables("DSSupplier").Rows.Add(dsNewRow)
		da.Update(ds, "DSSupplier")
		MsgBox("New supplier added")
	End Sub

	Function typeCheck()
		Dim searchWithinThis As String = txtEmail.Text
		Dim searchForThis As String = "@"
		Dim firstCharacter As Integer = searchWithinThis.IndexOf(searchForThis)

		If firstCharacter = -1 Then
			Return False
		Else
			Return True
		End If

	End Function


	Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
		If presenceCheck(txtEmail.Text) And presenceCheck(txtSupplierName.Text) = True Then
			If typeCheck() = True Then
				Call newRecord()
			Else
				MsgBox("Please enter an email following this format 'email@email.com'")
			End If
		Else
			MsgBox("Please enter a value in all text boxes")
		End If
	End Sub

	Private Sub btnEditDelete_Click(sender As Object, e As EventArgs) Handles btnEditDelete.Click 'may be replaced for automatically grabbing the user ID and then showing, but for right now the button will have to do
		btnPrev.Visible = True
		btnNext.Visible = True
		txtSupplierNameView.Visible = True
		txtEmailView.Visible = True
		lblEmailView.Visible = True
		lblSupplierIDView.Visible = True
		lblSupplierName2.Visible = True
		txtBoxSupplierIDView.Visible = True
		btnUpdate.Visible = True
		'shows all of the admin tools
		curRow = 0
		'now we are in edit and delete mode, this means we need to fill these data entry points with data from the order table (tblOrder)
		Call NavigateRecords()
	End Sub
	Sub NavigateRecords()
		txtBoxSupplierIDView.Text = ds.Tables("DSSupplier").Rows(curRow).Item(0)
		txtSupplierNameView.Text = ds.Tables("DSSupplier").Rows(curRow).Item(1)
		txtEmailView.Text = ds.Tables("DSSupplier").Rows(curRow).Item(2)
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

		If presenceCheck(txtBoxSupplierIDView.Text) And presenceCheck(txtEmailView.Text) = True Then

			' sql will not work without prefixes and suffixes
			cb.QuotePrefix = "["
			cb.QuoteSuffix = "]"

			'Updates the dataset to whats written in the text boxes            
			ds.Tables("DSSupplier").Rows(curRow).Item(0) = 0 'autonumber cringe
			ds.Tables("DSSupplier").Rows(curRow).Item(1) = txtSupplierNameView.Text
			ds.Tables("DSSupplier").Rows(curRow).Item(2) = txtEmailView.Text

			da.Update(ds, "DSSupplier") 'Updates the database with new data

			MsgBox("Data updated") 'this message gives user confimation that an action has taken place (Data updated)
		Else
			MsgBox("Please enter data in all fields")
		End If
	End Sub
End Class