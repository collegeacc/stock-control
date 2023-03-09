Module SUsername
    Public userLoggedIn As String
    Public employeeID As Int32
End Module

Public Class LogIn
    Dim forgotMode As Boolean = False
    Dim recoveryMode As Boolean = False


    Private Sub LogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        simpleSQL("SELECT * FROM tblEmployee", "Employee")
    End Sub
    Private Sub HideShow(sender As Object, e As EventArgs) Handles btnHideShow.Click
        If txtBoxPassword.UseSystemPasswordChar = True Then
            txtBoxPassword.UseSystemPasswordChar = False
        Else
            txtBoxPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnForgotPassword_Click(sender As Object, e As EventArgs) Handles btnForgotPassword.Click
        forgotMode = True
        btnLogIn.Text = "Request Password"
        txtBoxUsername.Text = "Enter Username" 'change to actual question once database is added
        txtBoxPassword.Text = "Press log-in to get question"
        txtBoxPassword.UseSystemPasswordChar = False
        Dim firstClickUser As Boolean = True 'this is to avoid the user from accidentaly removing the data inside the security question box

    End Sub
    Dim pass As Boolean = True
    Private Sub verification() 'checks if username and password box contains data
        pass = True
        If presenceCheck(txtBoxPassword.Text) = False Then
            pass = False
        ElseIf presenceCheck(txtBoxUsername.Text) = False Then
            pass = False
        End If
    End Sub
    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Call verification()
        Dim question As String
        If pass = False Then
            MsgBox("Please enter information in the text boxes")
        Else

            If forgotMode = True Then


                simpleSQL("SELECT tblEmployee.EmployeeID, tblEmployee.Username, tblEmployee.Password, tblPRecovery.SecID, tblPRecovery.[Security Question], tblEmployee.[Security Answer] FROM tblPRecovery INNER JOIN tblEmployee ON tblPRecovery.SecID = tblEmployee.SecID;", "DSRecovery")
                curRow = 0
                While curRow < MaxRows
                    If (txtBoxUsername.Text = ds.Tables("DSRecovery").Rows(curRow).Item(1)) Then
                        txtBoxUsername.Text = ds.Tables("DSRecovery").Rows(curRow).Item(4)
                        txtBoxPassword.Text = "Please enter answer"
                        recoveryMode = True
                        forgotMode = False
                        Exit While
                    Else
                        MsgBox("Please enter a valid username")
                        Exit While
                    End If
                    curRow = curRow + 1
                End While

            ElseIf forgotMode = False And recoveryMode = False Then 'this is when the user is logging in normally, it checks if it is not in forgot mode and not in recovery mode
                'Log-In mode
                curRow = 0
                Dim userFound As Boolean = False
                While curRow < MaxRows
                    If (txtBoxUsername.Text = ds.Tables("Employee").Rows(curRow).Item(1)) Then
                        If (txtBoxPassword.Text = ds.Tables("Employee").Rows(curRow).Item(2)) Then
                            userLoggedIn = ds.Tables("Employee").Rows(curRow).Item(1)
                            employeeID = ds.Tables("Employee").Rows(curRow).Item(0)
                            accessLevel = ds.Tables("Employee").Rows(curRow).Item(5)
                            Me.Hide()
                            MainMenu.Show()
                            userFound = True
                            Exit While

                        End If
                    End If
                    curRow = curRow + 1
                End While

                If userFound = False Then
                    MsgBox("Error, username or password incorrect")
                End If

            ElseIf recoveryMode = True Then 'this is executed when the user has been given their security question
                If ds.Tables("DSRecovery").Rows(curRow).Item(5) = txtBoxPassword.Text Then
                    txtBoxUsername.Text = ds.Tables("DSRecovery").Rows(curRow).Item(1)
                    txtBoxPassword.Text = ds.Tables("DSRecovery").Rows(curRow).Item(2)
                    forgotMode = False
                    recoveryMode = False
                    MsgBox("Correct answer, username and password have been added.")
                    curRow = 0
                Else
                    MsgBox("Incorrect answer, username and password have not been added.")
                    curRow = 0
                    recoveryMode = False
                End If
            End If

            End If

        'this is sql injection proof - trust me bro



    End Sub

    Dim firstClickUser As Boolean = False
    Dim firstClickPass As Boolean = False

    Private Sub txtBoxUsername_Click(sender As Object, e As EventArgs) Handles txtBoxUsername.Click 'Clears the box upon click, but only the first click

        If firstClickUser = False Then
            txtBoxUsername.Text = ""
            firstClickUser = True
        End If
    End Sub
    Private Sub txtBoxPassword_Click(sender As Object, e As EventArgs) Handles txtBoxPassword.Click 'Clears the box upon click, but only the first click

        If firstClickPass = False Then
            txtBoxPassword.Text = ""
            firstClickPass = True
        End If
    End Sub



    Private Sub btnStaff_Click(sender As Object, e As EventArgs) Handles btnStaff.Click
        txtBoxUsername.Visible = True
        txtBoxPassword.Visible = True
        btnLogin.Visible = True
        btnForgotPassword.Visible = True
        btnLogin.Visible = True
        btnHideShow.Visible = True
        PictureBox2.Visible = True
        PictureBox3.Visible = True
        Label1.Visible = False
        btnStaff.Visible = False
        btnStudent.Visible = False
    End Sub

    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnStudent.Click
        accessLevel = 0
        Me.Hide()
        MainMenu.Show()
    End Sub


    Private Sub txtBoxPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBoxPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call btnLogIn_Click(sender, e) 'makes it so you can log in by pressing the enter key
        End If
    End Sub


End Class