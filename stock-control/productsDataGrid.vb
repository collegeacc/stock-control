Public Class productsDataGrid
    Private Sub TblProductsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblProductsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblProductsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._stock_controlDBDataSet)

    End Sub

    Private Sub productsDataGrid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_stock_controlDBDataSet.tblProducts' table. You can move, or remove it, as needed.
        Me.TblProductsTableAdapter.Fill(Me._stock_controlDBDataSet.tblProducts)

    End Sub
End Class