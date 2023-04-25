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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LogIn))
        Me.btnForgotPassword = New System.Windows.Forms.Button()
        Me.txtBoxPassword = New System.Windows.Forms.TextBox()
        Me.txtBoxUsername = New System.Windows.Forms.TextBox()
        Me.btnHideShow = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnLogin = New System.Windows.Forms.PictureBox()
        Me.btnStudent = New System.Windows.Forms.Button()
        Me.btnStaff = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSJR = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnForgotPassword
        '
        Me.btnForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnForgotPassword.Location = New System.Drawing.Point(63, 172)
        Me.btnForgotPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.btnForgotPassword.Name = "btnForgotPassword"
        Me.btnForgotPassword.Size = New System.Drawing.Size(96, 19)
        Me.btnForgotPassword.TabIndex = 37
        Me.btnForgotPassword.Text = "Forgot Password"
        Me.btnForgotPassword.UseVisualStyleBackColor = True
        Me.btnForgotPassword.Visible = False
        '
        'txtBoxPassword
        '
        Me.txtBoxPassword.BackColor = System.Drawing.Color.IndianRed
        Me.txtBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxPassword.Location = New System.Drawing.Point(70, 151)
        Me.txtBoxPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBoxPassword.Name = "txtBoxPassword"
        Me.txtBoxPassword.Size = New System.Drawing.Size(254, 13)
        Me.txtBoxPassword.TabIndex = 33
        Me.txtBoxPassword.Text = "Password"
        Me.txtBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtBoxPassword.UseSystemPasswordChar = True
        Me.txtBoxPassword.Visible = False
        '
        'txtBoxUsername
        '
        Me.txtBoxUsername.BackColor = System.Drawing.Color.IndianRed
        Me.txtBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxUsername.Location = New System.Drawing.Point(70, 124)
        Me.txtBoxUsername.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBoxUsername.Name = "txtBoxUsername"
        Me.txtBoxUsername.Size = New System.Drawing.Size(254, 13)
        Me.txtBoxUsername.TabIndex = 32
        Me.txtBoxUsername.Text = "Username"
        Me.txtBoxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtBoxUsername.Visible = False
        '
        'btnHideShow
        '
        Me.btnHideShow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHideShow.Location = New System.Drawing.Point(254, 172)
        Me.btnHideShow.Margin = New System.Windows.Forms.Padding(2)
        Me.btnHideShow.Name = "btnHideShow"
        Me.btnHideShow.Size = New System.Drawing.Size(76, 19)
        Me.btnHideShow.TabIndex = 38
        Me.btnHideShow.Text = "Hide/Show"
        Me.btnHideShow.UseVisualStyleBackColor = True
        Me.btnHideShow.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.stock_control.My.Resources.Resources.text_box
        Me.PictureBox2.Location = New System.Drawing.Point(62, 121)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(267, 19)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 41
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.stock_control.My.Resources.Resources.text_box
        Me.PictureBox3.Location = New System.Drawing.Point(63, 149)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(266, 19)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 42
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'btnLogin
        '
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.Image = Global.stock_control.My.Resources.Resources.log_in
        Me.btnLogin.Location = New System.Drawing.Point(117, 196)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(166, 50)
        Me.btnLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnLogin.TabIndex = 43
        Me.btnLogin.TabStop = False
        Me.btnLogin.Visible = False
        '
        'btnStudent
        '
        Me.btnStudent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStudent.Location = New System.Drawing.Point(117, 120)
        Me.btnStudent.Name = "btnStudent"
        Me.btnStudent.Size = New System.Drawing.Size(75, 23)
        Me.btnStudent.TabIndex = 45
        Me.btnStudent.Text = "Customer"
        Me.btnStudent.UseVisualStyleBackColor = True
        '
        'btnStaff
        '
        Me.btnStaff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStaff.Location = New System.Drawing.Point(208, 120)
        Me.btnStaff.Name = "btnStaff"
        Me.btnStaff.Size = New System.Drawing.Size(75, 23)
        Me.btnStaff.TabIndex = 46
        Me.btnStaff.Text = "Staff"
        Me.btnStaff.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Museo Slab 300", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(67, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(274, 18)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Are you a staff member or customer?"
        '
        'lblSJR
        '
        Me.lblSJR.AutoSize = True
        Me.lblSJR.Font = New System.Drawing.Font("Times New Roman", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSJR.ForeColor = System.Drawing.Color.White
        Me.lblSJR.Location = New System.Drawing.Point(12, 9)
        Me.lblSJR.Name = "lblSJR"
        Me.lblSJR.Size = New System.Drawing.Size(376, 73)
        Me.lblSJR.TabIndex = 48
        Me.lblSJR.Text = "Wigan News"
        '
        'LogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.BackgroundImage = Global.stock_control.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(414, 273)
        Me.Controls.Add(Me.lblSJR)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnStaff)
        Me.Controls.Add(Me.btnStudent)
        Me.Controls.Add(Me.btnForgotPassword)
        Me.Controls.Add(Me.txtBoxPassword)
        Me.Controls.Add(Me.txtBoxUsername)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.btnHideShow)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "LogIn"
        Me.Text = "Log-In"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnLogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnForgotPassword As Button
    Friend WithEvents txtBoxPassword As TextBox
    Friend WithEvents txtBoxUsername As TextBox
    Friend WithEvents btnHideShow As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnLogin As PictureBox
    Friend WithEvents btnStudent As Button
    Friend WithEvents btnStaff As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblSJR As Label
End Class
