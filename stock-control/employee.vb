Public Class employee
    Private Sub employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_stock_controlDBDataSet.qEmployeeQ' table. You can move, or remove it, as needed.
        Me.QEmployeeQTableAdapter.Fill(Me._stock_controlDBDataSet.qEmployeeQ)

    End Sub
End Class