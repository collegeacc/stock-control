Public Class student
    Private Sub student_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_stock_controlDBDataSet.qStudentQ' table. You can move, or remove it, as needed.
        Me.QStudentQTableAdapter.Fill(Me._stock_controlDBDataSet.qStudentQ)

    End Sub
End Class