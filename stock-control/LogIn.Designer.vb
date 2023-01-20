<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogIn
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnForgotPassword = New System.Windows.Forms.Button()
        Me.txtBoxPassword = New System.Windows.Forms.TextBox()
        Me.txtBoxUsername = New System.Windows.Forms.TextBox()
        Me.btnHideShow = New System.Windows.Forms.Button()
        Me.btnLogIn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnForgotPassword
        '
        Me.btnForgotPassword.Location = New System.Drawing.Point(116, 190)
        Me.btnForgotPassword.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnForgotPassword.Name = "btnForgotPassword"
        Me.btnForgotPassword.Size = New System.Drawing.Size(104, 19)
        Me.btnForgotPassword.TabIndex = 37
        Me.btnForgotPassword.Text = "Forgot Password"
        Me.btnForgotPassword.UseVisualStyleBackColor = True
        '
        'txtBoxPassword
        '
        Me.txtBoxPassword.Location = New System.Drawing.Point(116, 167)
        Me.txtBoxPassword.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtBoxPassword.Name = "txtBoxPassword"
        Me.txtBoxPassword.Size = New System.Drawing.Size(336, 20)
        Me.txtBoxPassword.TabIndex = 33
        Me.txtBoxPassword.Text = "Password"
        Me.txtBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtBoxPassword.UseSystemPasswordChar = True
        '
        'txtBoxUsername
        '
        Me.txtBoxUsername.Location = New System.Drawing.Point(116, 142)
        Me.txtBoxUsername.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtBoxUsername.Name = "txtBoxUsername"
        Me.txtBoxUsername.Size = New System.Drawing.Size(336, 20)
        Me.txtBoxUsername.TabIndex = 32
        Me.txtBoxUsername.Text = "Username"
        Me.txtBoxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnHideShow
        '
        Me.btnHideShow.Location = New System.Drawing.Point(455, 166)
        Me.btnHideShow.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnHideShow.Name = "btnHideShow"
        Me.btnHideShow.Size = New System.Drawing.Size(76, 19)
        Me.btnHideShow.TabIndex = 38
        Me.btnHideShow.Text = "Hide/Show"
        Me.btnHideShow.UseVisualStyleBackColor = True
        '
        'btnLogIn
        '
        Me.btnLogIn.Location = New System.Drawing.Point(235, 215)
        Me.btnLogIn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(115, 30)
        Me.btnLogIn.TabIndex = 39
        Me.btnLogIn.Text = "Log In"
        Me.btnLogIn.UseVisualStyleBackColor = True
        '
        'LogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.btnLogIn)
        Me.Controls.Add(Me.btnHideShow)
        Me.Controls.Add(Me.btnForgotPassword)
        Me.Controls.Add(Me.txtBoxPassword)
        Me.Controls.Add(Me.txtBoxUsername)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "LogIn"
        Me.Text = "Log-In"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnForgotPassword As Button
    Friend WithEvents txtBoxPassword As TextBox
    Friend WithEvents txtBoxUsername As TextBox
    Friend WithEvents btnHideShow As Button
    Friend WithEvents btnLogIn As Button
End Class
