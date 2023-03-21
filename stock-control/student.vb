Imports FxResources.System

Public Class student
    Dim studentMaxRow As Integer
    Private Sub student_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        simpleSQL("SELECT * FROM tblStudent", "DSStudent")
        studentMaxRow = MaxRows
    End Sub
    Function findID()
        Dim lastID As String = ds.Tables("DSStudent").Rows(studentMaxRow - 1).Item(0)
        Dim ID As Integer = CInt(lastID.Remove(0, 1)) + 1 'remove the first character from the most recent student's student ID, then add one and convert to an integer
        Return "S" & ID 'creates the new string for student ID
    End Function
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If validation() Then
            Dim cb As New OleDb.OleDbCommandBuilder(da)
            cb.QuotePrefix = "["
            cb.QuoteSuffix = "]"
            Dim dsNewRow As DataRow
            dsNewRow = ds.Tables("DSStudent").NewRow()
            ds.Tables("DSStudent").Rows.Add(dsNewRow)
            'now we need to fill out the new prices of data
            dsNewRow.Item("StudentID") = findID()
            dsNewRow.Item("FirstName") = txtFirstName.Text
            dsNewRow.Item("LastName") = txtLastName.Text
            dsNewRow.Item("SecID") = cmbxSecID.SelectedIndex + 1
            dsNewRow.Item("Security Answer") = txtAnswer.Text


            da.Update(ds, "DSStudent")
            MsgBox("New student added")
        Else
            MsgBox("Please fill text in all appropriate text boxes")
        End If
    End Sub
    Function validation() 'validation cannot use the usual functions since nothing is a text box
        If presenceCheck(txtFirstName.Text) = False Then
            Return False
        ElseIf presenceCheck(txtLastName.Text) = False Then
            Return False
        ElseIf presenceCheck(txtAnswer.Text) = False Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub pbBtnShutdown_Click(sender As Object, e As EventArgs) Handles pbBtnShutdown.Click
        Me.Hide()
    End Sub

    Private Sub btnEditView_Click(sender As Object, e As EventArgs) Handles btnEditView.Click

        swapVisible()

        curRow = 0
        navigateRecords()
    End Sub
    Private Sub swapVisible()
        For Each c As TextBox In Panel2.Controls.OfType(Of TextBox)
            c.Visible = c.Visible <> True
        Next

        For Each c As Label In Panel2.Controls.OfType(Of Label)
            c.Visible = c.Visible <> True
        Next

        For Each c As Button In Panel2.Controls.OfType(Of Button)
            c.Visible = c.Visible <> True
        Next

        For Each c As ComboBox In Panel2.Controls.OfType(Of ComboBox)
            c.Visible = c.Visible <> True
        Next

        For Each c As NumericUpDown In Panel2.Controls.OfType(Of NumericUpDown)
            c.Visible = c.Visible <> True
        Next
    End Sub
    Private Sub navigateRecords()
        txtBoxStudentIDView.Text = ds.Tables("DSStudent").Rows(curRow).Item(0)
        txtFirstNameView.Text = ds.Tables("DSStudent").Rows(curRow).Item(1)
        txtLastNameView.Text = ds.Tables("DSStudent").Rows(curRow).Item(2)
        cmbxSecIDV.SelectedIndex = ds.Tables("DSStudent").Rows(curRow).Item(3) - 1
        txtAnswerV.Text = ds.Tables("DSStudent").Rows(curRow).Item(4)
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If curRow = studentMaxRow - 1 Then
            MsgBox("This is the last row")
        Else
            curRow = curRow + 1
            navigateRecords()
        End If
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        If curRow = 0 Then
            MsgBox("This is the first row")
        Else
            curRow = curRow - 1
            navigateRecords()
        End If
    End Sub

    Private Function presenceCheckView()
        If presenceCheck(txtFirstNameView.Text) = False Then
            Return False
        ElseIf presenceCheck(txtLastNameView.Text) = False Then
            Return False
        ElseIf presenceCheck(txtAnswerV.Text) = False Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim cb As New OleDb.OleDbCommandBuilder(da)

        If presenceCheckView() = True Then

            ' sql will not work without prefixes and suffixes
            cb.QuotePrefix = "["
            cb.QuoteSuffix = "]"

            'Updates the dataset to whats written in the text boxes            
            ds.Tables("DSStudent").Rows(curRow).Item(0) = txtBoxStudentIDView.Text
            ds.Tables("DSStudent").Rows(curRow).Item(1) = txtFirstNameView.Text
            ds.Tables("DSStudent").Rows(curRow).Item(2) = txtLastNameView.Text
            ds.Tables("DSStudent").Rows(curRow).Item(3) = cmbxSecIDV.SelectedIndex + 1
            ds.Tables("DSStudent").Rows(curRow).Item(4) = txtAnswerV.Text



            da.Update(ds, "DSStudent") 'Updates the database with new data

            MsgBox("Data updated") 'this message gives user confimation that an action has taken place (Data updated)
        Else
            MsgBox("Please enter data in all fields")
        End If
    End Sub
End Class