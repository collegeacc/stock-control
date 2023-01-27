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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnLogin = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnForgotPassword
        '
        Me.btnForgotPassword.Location = New System.Drawing.Point(416, 158)
        Me.btnForgotPassword.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnForgotPassword.Name = "btnForgotPassword"
        Me.btnForgotPassword.Size = New System.Drawing.Size(96, 19)
        Me.btnForgotPassword.TabIndex = 37
        Me.btnForgotPassword.Text = "Forgot Password"
        Me.btnForgotPassword.UseVisualStyleBackColor = True
        '
        'txtBoxPassword
        '
        Me.txtBoxPassword.BackColor = System.Drawing.Color.IndianRed
        Me.txtBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxPassword.Location = New System.Drawing.Point(423, 137)
        Me.txtBoxPassword.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtBoxPassword.Name = "txtBoxPassword"
        Me.txtBoxPassword.Size = New System.Drawing.Size(254, 13)
        Me.txtBoxPassword.TabIndex = 33
        Me.txtBoxPassword.Text = "Password"
        Me.txtBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtBoxPassword.UseSystemPasswordChar = True
        '
        'txtBoxUsername
        '
        Me.txtBoxUsername.BackColor = System.Drawing.Color.IndianRed
        Me.txtBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxUsername.Location = New System.Drawing.Point(423, 110)
        Me.txtBoxUsername.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtBoxUsername.Name = "txtBoxUsername"
        Me.txtBoxUsername.Size = New System.Drawing.Size(254, 13)
        Me.txtBoxUsername.TabIndex = 32
        Me.txtBoxUsername.Text = "Username"
        Me.txtBoxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnHideShow
        '
        Me.btnHideShow.Location = New System.Drawing.Point(607, 158)
        Me.btnHideShow.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnHideShow.Name = "btnHideShow"
        Me.btnHideShow.Size = New System.Drawing.Size(76, 19)
        Me.btnHideShow.TabIndex = 38
        Me.btnHideShow.Text = "Hide/Show"
        Me.btnHideShow.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.stock_control.My.Resources.Resources.sjr_logo
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(-79, -45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(449, 552)
        Me.PictureBox1.TabIndex = 40
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.stock_control.My.Resources.Resources.text_box
        Me.PictureBox2.Location = New System.Drawing.Point(415, 107)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(267, 19)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 41
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.stock_control.My.Resources.Resources.text_box
        Me.PictureBox3.Location = New System.Drawing.Point(416, 135)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(266, 19)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 42
        Me.PictureBox3.TabStop = False
        '
        'btnLogin
        '
        Me.btnLogin.Image = Global.stock_control.My.Resources.Resources.log_in
        Me.btnLogin.Location = New System.Drawing.Point(470, 182)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(166, 50)
        Me.btnLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnLogin.TabIndex = 43
        Me.btnLogin.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = Global.stock_control.My.Resources.Resources.title
        Me.PictureBox4.Location = New System.Drawing.Point(314, 10)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(414, 57)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 44
        Me.PictureBox4.TabStop = False
        '
        'LogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.stock_control.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(741, 356)
        Me.Controls.Add(Me.btnForgotPassword)
        Me.Controls.Add(Me.txtBoxPassword)
        Me.Controls.Add(Me.txtBoxUsername)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnHideShow)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "LogIn"
        Me.Text = "Log-In"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnLogin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnForgotPassword As Button
    Friend WithEvents txtBoxPassword As TextBox
    Friend WithEvents txtBoxUsername As TextBox
    Friend WithEvents btnHideShow As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnLogin As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
End Class
