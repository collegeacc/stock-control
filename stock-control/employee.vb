Imports FxResources.System

Public Class employee
    Dim employeeMaxRow As Integer
    Private Sub employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        simpleSQL("SELECT * FROM tblEmployee", "DSEmployee")
        employeeMaxRow = MaxRows
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If validation() = True Then
            Dim cb As New OleDb.OleDbCommandBuilder(da)
            cb.QuotePrefix = "["
            cb.QuoteSuffix = "]"
            Dim dsNewRow As DataRow
            dsNewRow = ds.Tables("DSEmployee").NewRow()
            ds.Tables("DSEmployee").Rows.Add(dsNewRow)
            'now we need to fill out the new prices of data
            dsNewRow.Item("EmployeeID") = 0 'autonumber
            dsNewRow.Item("Username") = txtUsername.Text
            dsNewRow.Item("Password") = txtPassword.Text
            dsNewRow.Item("First Name") = txtFirstName.Text
            dsNewRow.Item("Last Name") = txtLastName.Text
            dsNewRow.Item("Access Level") = numAccessLevel.Value
            dsNewRow.Item("Email") = txtFirstName.Text & txtLastName.Text.Substring(0, 1) & "@email.com"


            da.Update(ds, "DSEmployee")
            MsgBox("New employee added")
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
        ElseIf presenceCheck(txtUsername.Text) = False Then
            Return False
        ElseIf presenceCheck(txtPassword.Text) = False Then
            Return False
        ElseIf presenceCheck(numAccessLevel.Value) = False Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub pbBtnShutdown_Click(sender As Object, e As EventArgs) Handles pbBtnShutdown.Click
        Me.Hide()
    End Sub
    Private Sub swapVisible()
        For Each c As TextBox In Panel2.Controls.OfType(Of TextBox)
            If c.Visible = True Then
                c.Visible = False
            Else
                c.Visible = True
            End If
        Next

        For Each c As Label In Panel2.Controls.OfType(Of Label)
            If c.Visible = True Then
                c.Visible = False
            Else
                c.Visible = True
            End If
        Next

        For Each c As Button In Panel2.Controls.OfType(Of Button)
            If c.Visible = True Then
                c.Visible = False
            Else
                c.Visible = True
            End If
        Next

        For Each c As ComboBox In Panel2.Controls.OfType(Of ComboBox)
            If c.Visible = True Then
                c.Visible = False
            Else
                c.Visible = True
            End If
        Next
    End Sub
    Private Sub btnEditView_Click(sender As Object, e As EventArgs) Handles btnEditView.Click

        swapVisible()



        curRow = 0
        navigateRecords()
    End Sub

    Private Sub navigateRecords()
        txtBoxEmployeeIDView.Text = ds.Tables("DSEmployee").Rows(curRow).Item(0)
        txtUsernameV.Text = ds.Tables("DSEmployee").Rows(curRow).Item(1)
        txtPasswordV.Text = ds.Tables("DSEmployee").Rows(curRow).Item(2)
        txtFirstNameView.Text = ds.Tables("DSEmployee").Rows(curRow).Item(3)
        txtLastNameView.Text = ds.Tables("DSEmployee").Rows(curRow).Item(4)
        numAccessLevelV.Text = ds.Tables("DSEmployee").Rows(curRow).Item(5)
        txtEmailV.Text = ds.Tables("DSEmployee").Rows(curRow).Item(6)
        cmbxSecIDV.SelectedIndex = ds.Tables("DSEmployee").Rows(curRow).Item(7) - 1
        txtAnswerV.Text = ds.Tables("DSEmployee").Rows(curRow).Item(8)
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If curRow = employeeMaxRow - 1 Then
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
            ds.Tables("DSEmployee").Rows(curRow).Item(0) = txtBoxEmployeeIDView.Text
            ds.Tables("DSEmployee").Rows(curRow).Item(1) = txtUsernameV.Text
            ds.Tables("DSEmployee").Rows(curRow).Item(2) = txtPasswordV.Text
            ds.Tables("DSEmployee").Rows(curRow).Item(3) = txtFirstNameView.Text
            ds.Tables("DSEmployee").Rows(curRow).Item(4) = txtLastNameView.Text
            ds.Tables("DSEmployee").Rows(curRow).Item(5) = numAccessLevelV.Value
            ds.Tables("DSEmployee").Rows(curRow).Item(6) = txtEmailV.Text
            ds.Tables("DSEmployee").Rows(curRow).Item(7) = cmbxSecIDV.SelectedIndex + 1
            ds.Tables("DSEmployee").Rows(curRow).Item(8) = txtAnswerV.Text



            da.Update(ds, "DSEmployee") 'Updates the database with new data

            MsgBox("Data updated") 'this message gives user confimation that an action has taken place (Data updated)
        Else
            MsgBox("Please enter data in all fields")
        End If
    End Sub
End Class