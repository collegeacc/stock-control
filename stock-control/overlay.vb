Public Class overlay

    'Private Sub overlay_Load(sender As Object, e As EventArgs) Handles Me.Load
    '    lblUsername.Text = userLoggedIn
    '    simpleSQL("SELECT tblEmployee.EmployeeID, tblEmployee.[First Name], tblEmployee.[Last Name], [First Name] & ' ' & [Last Name] AS [Full Name] FROM tblEmployee WHERE tblEmployee.EmployeeID=" & employeeID, "DSNames")
    '    lblName.Text = ds.Tables("DSNames").Rows(0).Item(3)
    'End Sub

    Private Sub pbBtnOrder_Click(sender As Object, e As EventArgs) Handles pbBtnOrder.Click
        openForm = "Order"
        ParentForm.Close()
        orderSubForm.Show()
    End Sub

    Private Sub overlay_Load(sender As Object, e As EventArgs) Handles Me.Load
        Panel1.BackColor = ColorTranslator.FromHtml("#D35354") 'translates hexadecimal to the correct colour value
        Panel2.BackColor = ColorTranslator.FromHtml("#D35354")
        If openForm = "Order" Then
            pbBtnOrder.Image = stock_control.My.Resources.Resources.pressedOrders
        ElseIf openForm = "Products" Then
            pbBtnProducts.Image = stock_control.My.Resources.Resources.pressedProducts
        End If

    End Sub

    Private Sub pbBtnProducts_Click(sender As Object, e As EventArgs) Handles pbBtnProducts.Click
        openForm = "Products"
        ParentForm.Close()
        products.Show()
    End Sub
End Class
