Public Class overlay

    Private Sub overlay_Load(sender As Object, e As EventArgs) Handles Me.Load
        Select Case openForm
            Case "Order"
                pbBtnOrder.Image = stock_control.My.Resources.Resources.pressedOrders 'this case is when the order form is clicked, this shows the pressed in button to show that the current form is infact the order form.
            Case "Products"
                pbBtnProducts.Image = stock_control.My.Resources.Resources.pressedProducts 'does the same but prodcuts not order
            Case "Statistics"
                pbBtnStatistics.Image = stock_control.My.Resources.Resources.pressedStatistics '⬆️⬆️⬆️
            Case "Suppliers"
                pbBtnSuppliers.Image = stock_control.My.Resources.Resources.pressedSuppliers
            Case "Users"
                pbBtnUserManag.Image = stock_control.My.Resources.Resources.pressedUserManag
        End Select

    End Sub
    Private Sub pbBtnOrder_Click(sender As Object, e As EventArgs) Handles pbBtnOrder.Click
        openForm = "Order" 'changes the variable "openForm" to be whatever form is selected
        ParentForm.Close() 'closes the form that was last opened
        orderSubForm.Show() 'opens the order form
    End Sub
    Private Sub pbBtnProducts_Click(sender As Object, e As EventArgs) Handles pbBtnProducts.Click
        openForm = "Products" 'same but products
        ParentForm.Close()
        products.Show()
    End Sub

    Private Sub pbBtnStatistics_Click(sender As Object, e As EventArgs) Handles pbBtnStatistics.Click
        openForm = "Statistics"
        ParentForm.Close()
        Statistics.Show()
    End Sub

    Private Sub pbLogo_Click(sender As Object, e As EventArgs) Handles pbLogo.Click
        openForm = "" 'this is when the logo/home button is pressed, since no buttons need to be pressed, it changes the variable to be empty
        ParentForm.Close()
        MainMenu.Show()
    End Sub

    Private Sub pbBtnSuppliers_Click(sender As Object, e As EventArgs) Handles pbBtnSuppliers.Click
        openForm = "Suppliers"
        ParentForm.Close()
        Suppliers.Show()
    End Sub

    Private Sub pbBtnUserManag_Click(sender As Object, e As EventArgs) Handles pbBtnUserManag.Click
        openForm = "Users"
        ParentForm.Close()
        userMgmt.Show()
    End Sub

    Private Sub pbLogo_MouseHover(sender As Object, e As EventArgs) Handles pbLogo.MouseHover
        pbLogo.Image = stock_control.My.Resources.Resources.sjr_logo_black 'makes the logo black to show it is a button more clearly
    End Sub

    Private Sub pbLogo_MouseLeave(sender As Object, e As EventArgs) Handles pbLogo.MouseLeave
        pbLogo.Image = stock_control.My.Resources.Resources.sjr_logo
    End Sub
End Class
