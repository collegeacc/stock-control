Module SUsername
    Public userLoggedIn As String
End Module

Public Class LogIn
    Dim forgotMode As Boolean = False


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
        txtBoxUsername.Text = "Security Question" 'change to actual question once database is added
        txtBoxPassword.Text = "Enter Answer Here"
        txtBoxPassword.UseSystemPasswordChar = False
        Dim firstClickUser As Boolean = True 'this is to avoid the user from accidentaly removing the data inside the security question box
        txtBoxUsername.Enabled = False

    End Sub
    Dim pass As Boolean = True
    Private Sub verification()
        pass = True
        If presenceCheck(txtBoxPassword.Text) = False Then
            pass = False
        ElseIf presenceCheck(txtBoxUsername.Text) = False Then
            pass = False
        End If
    End Sub
    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        Call verification()
        If pass = False Then
            MsgBox("Please enter information in the text boxes")
        Else

            If forgotMode = True Then

                If txtBoxPassword.Text = "Correct Answer" Then 'change to actual answer once database is added
                    txtBoxPassword.UseSystemPasswordChar = False
                    txtBoxPassword.Text = "Password" 'changes the password box to the users correct password
                    txtBoxUsername.Text = "Enter your username"
                    forgotMode = False
                    btnLogIn.Text = "Log-In"
                    MsgBox("Correct, your password has been entered into the password box automatically, do not share this with anyone")
                    Dim firstClickUser As Boolean = False
                    txtBoxUsername.Enabled = True
                Else
                    MsgBox("Error, this is the wrong answer")
                End If
            Else
                'Log-In mode
                curRow = 0
                Dim userFound As Boolean = False
                While curRow < MaxRows
                    If (txtBoxUsername.Text = ds.Tables("Employee").Rows(curRow).Item(1)) Then
                        If (txtBoxPassword.Text = ds.Tables("Employee").Rows(curRow).Item(2)) Then
                            userLoggedIn = ds.Tables("Employee").Rows(curRow).Item(1)
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

End Class