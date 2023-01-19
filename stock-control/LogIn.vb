Public Class LogIn
    Dim forgotMode As Boolean = False
    Private Sub LogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click

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

            If txtBoxUsername.Text = "Username" Then ' this is all dumby code, will be replaced
                If txtBoxPassword.Text = "Password" Then
                    MsgBox("yay correct")
                Else
                    MsgBox("oh no incorrect")
                End If
            Else
                MsgBox("oh no incorrect")
            End If

        End If
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