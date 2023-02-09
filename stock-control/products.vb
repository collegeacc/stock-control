﻿Public Class products
    Private Sub products_Load(sender As Object, e As EventArgs) Handles Me.Load
		simpleSQL("SELECT * FROM tblProducts", "DSProduct")
		simpleSQL("SELECT tblSupplier.SupplierID, tblSupplier.[Supplier Name] FROM tblSupplier;", "DSSupplierID")
		cmbxSupplier.DataSource = ds.Tables("DSSupplierID")
		cmbxSupplier.DisplayMember = "Supplier Name"
        cmbxSupplier.ValueMember = "SupplierID"

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
		Dim cb As New OleDb.OleDbCommandBuilder(da)
		cb.QuotePrefix = "["
		cb.QuoteSuffix = "]"
		Dim dsNewRow As DataRow
		dsNewRow = ds.Tables("DSProduct").NewRow()
		ds.Tables("DSProduct").Rows.Add(dsNewRow)
		'now we need to fill out the new prices of data
		dsNewRow.Item("ProductID") = 0 'autonumber cringe
		dsNewRow.Item("Product Name") = txtProductName.Text
		dsNewRow.Item("SupplierID") = cmbxSupplier.SelectedValue
		dsNewRow.Item("Price") = numPrice.Value
		dsNewRow.Item("Stock") = numQuant.Value
		da.Update(ds, "DSProduct")
		MsgBox("New product added")
	End Sub
End Class