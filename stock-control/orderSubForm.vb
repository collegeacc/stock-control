Public Class orderSubForm
    Dim productList As New List(Of String)
    Dim priceTotal As Decimal
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

    End Sub
End Class