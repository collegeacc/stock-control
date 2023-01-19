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
        Me.btnForgotPassword.Location = New System.Drawing.Point(154, 234)
        Me.btnForgotPassword.Name = "btnForgotPassword"
        Me.btnForgotPassword.Size = New System.Drawing.Size(139, 23)
        Me.btnForgotPassword.TabIndex = 37
        Me.btnForgotPassword.Text = "Forgot Passoword"
        Me.btnForgotPassword.UseVisualStyleBackColor = True
        '
        'txtBoxPassword
        '
        Me.txtBoxPassword.Location = New System.Drawing.Point(154, 205)
        Me.txtBoxPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBoxPassword.Name = "txtBoxPassword"
        Me.txtBoxPassword.Size = New System.Drawing.Size(447, 22)
        Me.txtBoxPassword.TabIndex = 33
        Me.txtBoxPassword.Text = "Password"
        Me.txtBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtBoxPassword.UseSystemPasswordChar = True
        '
        'txtBoxUsername
        '
        Me.txtBoxUsername.Location = New System.Drawing.Point(154, 175)
        Me.txtBoxUsername.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBoxUsername.Name = "txtBoxUsername"
        Me.txtBoxUsername.Size = New System.Drawing.Size(447, 22)
        Me.txtBoxUsername.TabIndex = 32
        Me.txtBoxUsername.Text = "Username"
        Me.txtBoxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnHideShow
        '
        Me.btnHideShow.Location = New System.Drawing.Point(607, 204)
        Me.btnHideShow.Name = "btnHideShow"
        Me.btnHideShow.Size = New System.Drawing.Size(102, 23)
        Me.btnHideShow.TabIndex = 38
        Me.btnHideShow.Text = "Hide/Show"
        Me.btnHideShow.UseVisualStyleBackColor = True
        '
        'btnLogIn
        '
        Me.btnLogIn.Location = New System.Drawing.Point(313, 265)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(153, 37)
        Me.btnLogIn.TabIndex = 39
        Me.btnLogIn.Text = "Log In"
        Me.btnLogIn.UseVisualStyleBackColor = True
        '
        'LogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnLogIn)
        Me.Controls.Add(Me.btnHideShow)
        Me.Controls.Add(Me.btnForgotPassword)
        Me.Controls.Add(Me.txtBoxPassword)
        Me.Controls.Add(Me.txtBoxUsername)
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
