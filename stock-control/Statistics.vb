
Public Class Statistics
    Private Sub Button1_Click(sender As Object, e As EventArgs) 
        Call Sample.Sample.MailMergeUsingDatabase()
    End Sub

    Private Sub Statistics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_stock_controlDBDataSet.qReviewsPerEmp' table. You can move, or remove it, as needed.
        Me.QReviewsPerEmpTableAdapter.Fill(Me._stock_controlDBDataSet.qReviewsPerEmp)

    End Sub
End Class