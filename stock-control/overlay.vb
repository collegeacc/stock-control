Public Class overlay

    'Private Sub overlay_Load(sender As Object, e As EventArgs) Handles Me.Load
    '    lblUsername.Text = userLoggedIn
    '    simpleSQL("SELECT tblEmployee.EmployeeID, tblEmployee.[First Name], tblEmployee.[Last Name], [First Name] & ' ' & [Last Name] AS [Full Name] FROM tblEmployee WHERE tblEmployee.EmployeeID=" & employeeID, "DSNames")
    '    lblName.Text = ds.Tables("DSNames").Rows(0).Item(3)
    'End Sub

    Private Sub pbBtnOrder_Click(sender As Object, e As EventArgs) Handles pbBtnOrder.Click
        ParentForm.Close()
        orderSubForm.Show()
    End Sub


End Class
