﻿Public Class overlay

    Private Sub overlay_Load(sender As Object, e As EventArgs) Handles Me.Load

        Select Case openForm
            Case "Order"
                pbBtnOrder.Image = stock_control.My.Resources.Resources.pressedOrders
            Case "Products"
                pbBtnProducts.Image = stock_control.My.Resources.Resources.pressedProducts
            Case "Statistics"
                pbBtnStatistics.Image = stock_control.My.Resources.Resources.pressedStatistics
            Case "Suppliers"
                pbBtnSuppliers.Image = stock_control.My.Resources.Resources.pressedSuppliers
            Case "Users"
                pbBtnUserManag.Image = stock_control.My.Resources.Resources.pressedUserManag
        End Select

    End Sub
    Private Sub pbBtnOrder_Click(sender As Object, e As EventArgs) Handles pbBtnOrder.Click
        openForm = "Order"
        ParentForm.Close()
        orderSubForm.Show()
    End Sub
    Private Sub pbBtnProducts_Click(sender As Object, e As EventArgs) Handles pbBtnProducts.Click
        openForm = "Products"
        ParentForm.Close()
        products.Show()
    End Sub

    Private Sub pbBtnStatistics_Click(sender As Object, e As EventArgs) Handles pbBtnStatistics.Click
        openForm = "Statistics"
        ParentForm.Close()
        Statistics.Show()
    End Sub

    Private Sub pbLogo_Click(sender As Object, e As EventArgs) Handles pbLogo.Click
        openForm = ""
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
End Class
