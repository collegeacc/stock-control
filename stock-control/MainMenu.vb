Imports System.Windows

Public Class MainMenu
    Private Sub frmProgram_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit() 'closes everything when form is closed
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LogIn.Close()
        lblUsername.Text = userLoggedIn
        sql = "SELECT tblEmployee.Username, tblEmployee.[First Name], tblEmployee.[Last Name] FROM tblEmployee WHERE tblEmployee.Username ='" & userLoggedIn & "'"
        da = New OleDb.OleDbDataAdapter(sql, conn)
        da.Fill(ds, "temp")
        lblName.Text = ds.Tables("temp").Rows(0).Item(1) & " " & ds.Tables("temp").Rows(0).Item(2)
        'btw this is sql injection proof - trust me bro



        For Each ctl As Control In Me.Controls 'changes the ugly Mdi colour to the colour that the form is actually set to
            If TypeOf ctl Is MdiClient Then
                ctl.BackColor = Me.BackColor
            End If
        Next ctl
    End Sub

    Private Sub pbBtnOrder_Click(sender As Object, e As EventArgs) Handles pbBtnOrder.Click
        'Here the Mdi container is set up so that a user can have multiple of these windows open if they so choose
        With orderSubForm
            'sets the current multiple-document interface(MDI) parent form of this form
            .MdiParent = Me
            'show the form2
            .Show()
        End With
    End Sub
End Class