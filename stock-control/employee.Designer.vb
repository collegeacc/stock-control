<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class employee
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(employee))
        Me.txtAnswerV = New System.Windows.Forms.TextBox()
        Me.lblSecQV = New System.Windows.Forms.Label()
        Me.cmbxSecIDV = New System.Windows.Forms.ComboBox()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.lblSecurityA = New System.Windows.Forms.Label()
        Me.lblSecurityQ = New System.Windows.Forms.Label()
        Me.cmbxSecID = New System.Windows.Forms.ComboBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblFirstLastV = New System.Windows.Forms.Label()
        Me.txtFirstNameView = New System.Windows.Forms.TextBox()
        Me.pbBtnShutdown = New System.Windows.Forms.PictureBox()
        Me.btnEditView = New System.Windows.Forms.Button()
        Me.txtLastNameView = New System.Windows.Forms.TextBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.lblFirstNameV = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lblEmployeeIDView = New System.Windows.Forms.Label()
        Me.txtBoxEmployeeIDView = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblSJR = New System.Windows.Forms.Label()
        Me.lblAccessLevel = New System.Windows.Forms.Label()
        Me.txtEmailV = New System.Windows.Forms.TextBox()
        Me.lblEmailV = New System.Windows.Forms.Label()
        Me.txtUsernameV = New System.Windows.Forms.TextBox()
        Me.lblUsernameV = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblAccess = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblPasswordV = New System.Windows.Forms.Label()
        Me.txtPasswordV = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.numAccessLevel = New System.Windows.Forms.NumericUpDown()
        Me.numAccessLevelV = New System.Windows.Forms.NumericUpDown()
        CType(Me.pbBtnShutdown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.numAccessLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numAccessLevelV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtAnswerV
        '
        Me.txtAnswerV.Location = New System.Drawing.Point(576, 306)
        Me.txtAnswerV.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAnswerV.Name = "txtAnswerV"
        Me.txtAnswerV.Size = New System.Drawing.Size(174, 20)
        Me.txtAnswerV.TabIndex = 99
        Me.txtAnswerV.Visible = False
        '
        'lblSecQV
        '
        Me.lblSecQV.AutoSize = True
        Me.lblSecQV.BackColor = System.Drawing.Color.IndianRed
        Me.lblSecQV.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblSecQV.Location = New System.Drawing.Point(356, 282)
        Me.lblSecQV.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSecQV.Name = "lblSecQV"
        Me.lblSecQV.Size = New System.Drawing.Size(139, 21)
        Me.lblSecQV.TabIndex = 98
        Me.lblSecQV.Text = "Security Question"
        Me.lblSecQV.Visible = False
        '
        'cmbxSecIDV
        '
        Me.cmbxSecIDV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxSecIDV.FormattingEnabled = True
        Me.cmbxSecIDV.Items.AddRange(New Object() {"What was your childhood pet's name?", "What was your primary school called?", "What is your mother's maiden name?", "How old where you when you had your first kiss?", "What was your favourite childhood hobby?"})
        Me.cmbxSecIDV.Location = New System.Drawing.Point(397, 306)
        Me.cmbxSecIDV.Name = "cmbxSecIDV"
        Me.cmbxSecIDV.Size = New System.Drawing.Size(174, 21)
        Me.cmbxSecIDV.TabIndex = 97
        Me.cmbxSecIDV.Visible = False
        '
        'txtAnswer
        '
        Me.txtAnswer.Location = New System.Drawing.Point(47, 324)
        Me.txtAnswer.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(174, 20)
        Me.txtAnswer.TabIndex = 96
        '
        'lblSecurityA
        '
        Me.lblSecurityA.AutoSize = True
        Me.lblSecurityA.BackColor = System.Drawing.Color.IndianRed
        Me.lblSecurityA.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblSecurityA.Location = New System.Drawing.Point(43, 301)
        Me.lblSecurityA.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSecurityA.Name = "lblSecurityA"
        Me.lblSecurityA.Size = New System.Drawing.Size(127, 21)
        Me.lblSecurityA.TabIndex = 95
        Me.lblSecurityA.Text = "Security Answer"
        '
        'lblSecurityQ
        '
        Me.lblSecurityQ.AutoSize = True
        Me.lblSecurityQ.BackColor = System.Drawing.Color.IndianRed
        Me.lblSecurityQ.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblSecurityQ.Location = New System.Drawing.Point(43, 253)
        Me.lblSecurityQ.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSecurityQ.Name = "lblSecurityQ"
        Me.lblSecurityQ.Size = New System.Drawing.Size(139, 21)
        Me.lblSecurityQ.TabIndex = 94
        Me.lblSecurityQ.Text = "Security Question"
        '
        'cmbxSecID
        '
        Me.cmbxSecID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxSecID.FormattingEnabled = True
        Me.cmbxSecID.Items.AddRange(New Object() {"What was your childhood pet's name?", "What was your primary school called?", "What is your mother's maiden name?", "How old where you when you had your first kiss?", "What was your favourite childhood hobby?"})
        Me.cmbxSecID.Location = New System.Drawing.Point(47, 277)
        Me.cmbxSecID.Name = "cmbxSecID"
        Me.cmbxSecID.Size = New System.Drawing.Size(174, 21)
        Me.cmbxSecID.TabIndex = 93
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(95, 354)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 92
        Me.btnAdd.Text = "Add Employee"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblFirstLastV
        '
        Me.lblFirstLastV.AutoSize = True
        Me.lblFirstLastV.BackColor = System.Drawing.Color.IndianRed
        Me.lblFirstLastV.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblFirstLastV.Location = New System.Drawing.Point(587, 171)
        Me.lblFirstLastV.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFirstLastV.Name = "lblFirstLastV"
        Me.lblFirstLastV.Size = New System.Drawing.Size(86, 21)
        Me.lblFirstLastV.TabIndex = 91
        Me.lblFirstLastV.Text = "Last Name"
        Me.lblFirstLastV.Visible = False
        '
        'txtFirstNameView
        '
        Me.txtFirstNameView.Location = New System.Drawing.Point(499, 194)
        Me.txtFirstNameView.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFirstNameView.Name = "txtFirstNameView"
        Me.txtFirstNameView.Size = New System.Drawing.Size(84, 20)
        Me.txtFirstNameView.TabIndex = 86
        Me.txtFirstNameView.Visible = False
        '
        'pbBtnShutdown
        '
        Me.pbBtnShutdown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbBtnShutdown.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbBtnShutdown.Image = Global.stock_control.My.Resources.Resources.exit_app
        Me.pbBtnShutdown.Location = New System.Drawing.Point(717, 48)
        Me.pbBtnShutdown.Name = "pbBtnShutdown"
        Me.pbBtnShutdown.Size = New System.Drawing.Size(47, 51)
        Me.pbBtnShutdown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbBtnShutdown.TabIndex = 2
        Me.pbBtnShutdown.TabStop = False
        '
        'btnEditView
        '
        Me.btnEditView.Location = New System.Drawing.Point(62, 383)
        Me.btnEditView.Name = "btnEditView"
        Me.btnEditView.Size = New System.Drawing.Size(140, 23)
        Me.btnEditView.TabIndex = 85
        Me.btnEditView.Text = "Edit/View Employee"
        Me.btnEditView.UseVisualStyleBackColor = True
        '
        'txtLastNameView
        '
        Me.txtLastNameView.Location = New System.Drawing.Point(591, 194)
        Me.txtLastNameView.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLastNameView.Name = "txtLastNameView"
        Me.txtLastNameView.Size = New System.Drawing.Size(84, 20)
        Me.txtLastNameView.TabIndex = 90
        Me.txtLastNameView.Visible = False
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(611, 381)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(69, 20)
        Me.btnNext.TabIndex = 89
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        Me.btnNext.Visible = False
        '
        'btnPrev
        '
        Me.btnPrev.Location = New System.Drawing.Point(500, 381)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(69, 20)
        Me.btnPrev.TabIndex = 88
        Me.btnPrev.Text = "Previous"
        Me.btnPrev.UseVisualStyleBackColor = True
        Me.btnPrev.Visible = False
        '
        'lblFirstNameV
        '
        Me.lblFirstNameV.AutoSize = True
        Me.lblFirstNameV.BackColor = System.Drawing.Color.IndianRed
        Me.lblFirstNameV.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblFirstNameV.Location = New System.Drawing.Point(495, 171)
        Me.lblFirstNameV.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFirstNameV.Name = "lblFirstNameV"
        Me.lblFirstNameV.Size = New System.Drawing.Size(88, 21)
        Me.lblFirstNameV.TabIndex = 87
        Me.lblFirstNameV.Text = "First Name"
        Me.lblFirstNameV.Visible = False
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(551, 407)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 82
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        Me.btnUpdate.Visible = False
        '
        'lblEmployeeIDView
        '
        Me.lblEmployeeIDView.AutoSize = True
        Me.lblEmployeeIDView.BackColor = System.Drawing.Color.IndianRed
        Me.lblEmployeeIDView.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblEmployeeIDView.Location = New System.Drawing.Point(393, 171)
        Me.lblEmployeeIDView.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEmployeeIDView.Name = "lblEmployeeIDView"
        Me.lblEmployeeIDView.Size = New System.Drawing.Size(102, 21)
        Me.lblEmployeeIDView.TabIndex = 81
        Me.lblEmployeeIDView.Text = "Employee ID"
        Me.lblEmployeeIDView.Visible = False
        '
        'txtBoxEmployeeIDView
        '
        Me.txtBoxEmployeeIDView.Location = New System.Drawing.Point(426, 194)
        Me.txtBoxEmployeeIDView.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBoxEmployeeIDView.Name = "txtBoxEmployeeIDView"
        Me.txtBoxEmployeeIDView.Size = New System.Drawing.Size(69, 20)
        Me.txtBoxEmployeeIDView.TabIndex = 80
        Me.txtBoxEmployeeIDView.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblSJR)
        Me.Panel1.Controls.Add(Me.pbBtnShutdown)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 140)
        Me.Panel1.TabIndex = 77
        '
        'lblSJR
        '
        Me.lblSJR.AutoSize = True
        Me.lblSJR.Font = New System.Drawing.Font("Times New Roman", 72.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSJR.ForeColor = System.Drawing.Color.White
        Me.lblSJR.Location = New System.Drawing.Point(15, 9)
        Me.lblSJR.Name = "lblSJR"
        Me.lblSJR.Size = New System.Drawing.Size(560, 109)
        Me.lblSJR.TabIndex = 3
        Me.lblSJR.Text = "Wigan News"
        '
        'lblAccessLevel
        '
        Me.lblAccessLevel.AutoSize = True
        Me.lblAccessLevel.BackColor = System.Drawing.Color.IndianRed
        Me.lblAccessLevel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblAccessLevel.Location = New System.Drawing.Point(677, 171)
        Me.lblAccessLevel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAccessLevel.Name = "lblAccessLevel"
        Me.lblAccessLevel.Size = New System.Drawing.Size(102, 21)
        Me.lblAccessLevel.TabIndex = 101
        Me.lblAccessLevel.Text = "Access Level"
        Me.lblAccessLevel.Visible = False
        '
        'txtEmailV
        '
        Me.txtEmailV.Location = New System.Drawing.Point(360, 357)
        Me.txtEmailV.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmailV.Name = "txtEmailV"
        Me.txtEmailV.Size = New System.Drawing.Size(390, 20)
        Me.txtEmailV.TabIndex = 102
        Me.txtEmailV.Visible = False
        '
        'lblEmailV
        '
        Me.lblEmailV.AutoSize = True
        Me.lblEmailV.BackColor = System.Drawing.Color.IndianRed
        Me.lblEmailV.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblEmailV.Location = New System.Drawing.Point(356, 330)
        Me.lblEmailV.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEmailV.Name = "lblEmailV"
        Me.lblEmailV.Size = New System.Drawing.Size(112, 21)
        Me.lblEmailV.TabIndex = 103
        Me.lblEmailV.Text = "Email Address"
        Me.lblEmailV.Visible = False
        '
        'txtUsernameV
        '
        Me.txtUsernameV.Location = New System.Drawing.Point(576, 219)
        Me.txtUsernameV.Margin = New System.Windows.Forms.Padding(2)
        Me.txtUsernameV.Name = "txtUsernameV"
        Me.txtUsernameV.Size = New System.Drawing.Size(174, 20)
        Me.txtUsernameV.TabIndex = 104
        Me.txtUsernameV.Visible = False
        '
        'lblUsernameV
        '
        Me.lblUsernameV.AutoSize = True
        Me.lblUsernameV.BackColor = System.Drawing.Color.IndianRed
        Me.lblUsernameV.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblUsernameV.Location = New System.Drawing.Point(492, 219)
        Me.lblUsernameV.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUsernameV.Name = "lblUsernameV"
        Me.lblUsernameV.Size = New System.Drawing.Size(83, 21)
        Me.lblUsernameV.TabIndex = 105
        Me.lblUsernameV.Text = "Username"
        Me.lblUsernameV.Visible = False
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(47, 184)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(84, 20)
        Me.txtFirstName.TabIndex = 106
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.BackColor = System.Drawing.Color.IndianRed
        Me.lblFirstName.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblFirstName.Location = New System.Drawing.Point(43, 161)
        Me.lblFirstName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(88, 21)
        Me.lblFirstName.TabIndex = 107
        Me.lblFirstName.Text = "First Name"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.BackColor = System.Drawing.Color.IndianRed
        Me.lblLastName.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblLastName.Location = New System.Drawing.Point(135, 161)
        Me.lblLastName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(86, 21)
        Me.lblLastName.TabIndex = 109
        Me.lblLastName.Text = "Last Name"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(139, 184)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(84, 20)
        Me.txtLastName.TabIndex = 108
        '
        'lblAccess
        '
        Me.lblAccess.AutoSize = True
        Me.lblAccess.BackColor = System.Drawing.Color.IndianRed
        Me.lblAccess.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblAccess.Location = New System.Drawing.Point(225, 161)
        Me.lblAccess.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAccess.Name = "lblAccess"
        Me.lblAccess.Size = New System.Drawing.Size(102, 21)
        Me.lblAccess.TabIndex = 111
        Me.lblAccess.Text = "Access Level"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.IndianRed
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblUsername.Location = New System.Drawing.Point(44, 208)
        Me.lblUsername.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(83, 21)
        Me.lblUsername.TabIndex = 113
        Me.lblUsername.Text = "Username"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(128, 208)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(2)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(174, 20)
        Me.txtUsername.TabIndex = 112
        '
        'lblPasswordV
        '
        Me.lblPasswordV.AutoSize = True
        Me.lblPasswordV.BackColor = System.Drawing.Color.IndianRed
        Me.lblPasswordV.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPasswordV.Location = New System.Drawing.Point(492, 243)
        Me.lblPasswordV.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPasswordV.Name = "lblPasswordV"
        Me.lblPasswordV.Size = New System.Drawing.Size(79, 21)
        Me.lblPasswordV.TabIndex = 115
        Me.lblPasswordV.Text = "Password"
        Me.lblPasswordV.Visible = False
        '
        'txtPasswordV
        '
        Me.txtPasswordV.Location = New System.Drawing.Point(576, 243)
        Me.txtPasswordV.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPasswordV.Name = "txtPasswordV"
        Me.txtPasswordV.Size = New System.Drawing.Size(174, 20)
        Me.txtPasswordV.TabIndex = 114
        Me.txtPasswordV.Visible = False
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.IndianRed
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPassword.Location = New System.Drawing.Point(44, 231)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(79, 21)
        Me.lblPassword.TabIndex = 117
        Me.lblPassword.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(128, 231)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(174, 20)
        Me.txtPassword.TabIndex = 116
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = Global.stock_control.My.Resources.Resources.background
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.numAccessLevel)
        Me.Panel2.Controls.Add(Me.numAccessLevelV)
        Me.Panel2.Controls.Add(Me.lblPassword)
        Me.Panel2.Controls.Add(Me.lblEmployeeIDView)
        Me.Panel2.Controls.Add(Me.txtPassword)
        Me.Panel2.Controls.Add(Me.txtBoxEmployeeIDView)
        Me.Panel2.Controls.Add(Me.lblPasswordV)
        Me.Panel2.Controls.Add(Me.btnUpdate)
        Me.Panel2.Controls.Add(Me.txtPasswordV)
        Me.Panel2.Controls.Add(Me.lblFirstNameV)
        Me.Panel2.Controls.Add(Me.lblUsername)
        Me.Panel2.Controls.Add(Me.btnPrev)
        Me.Panel2.Controls.Add(Me.txtUsername)
        Me.Panel2.Controls.Add(Me.btnNext)
        Me.Panel2.Controls.Add(Me.lblAccess)
        Me.Panel2.Controls.Add(Me.txtLastNameView)
        Me.Panel2.Controls.Add(Me.btnEditView)
        Me.Panel2.Controls.Add(Me.lblLastName)
        Me.Panel2.Controls.Add(Me.txtFirstNameView)
        Me.Panel2.Controls.Add(Me.txtLastName)
        Me.Panel2.Controls.Add(Me.lblFirstLastV)
        Me.Panel2.Controls.Add(Me.txtFirstName)
        Me.Panel2.Controls.Add(Me.btnAdd)
        Me.Panel2.Controls.Add(Me.lblFirstName)
        Me.Panel2.Controls.Add(Me.cmbxSecID)
        Me.Panel2.Controls.Add(Me.lblUsernameV)
        Me.Panel2.Controls.Add(Me.lblSecurityQ)
        Me.Panel2.Controls.Add(Me.txtUsernameV)
        Me.Panel2.Controls.Add(Me.lblSecurityA)
        Me.Panel2.Controls.Add(Me.lblEmailV)
        Me.Panel2.Controls.Add(Me.txtAnswer)
        Me.Panel2.Controls.Add(Me.txtEmailV)
        Me.Panel2.Controls.Add(Me.cmbxSecIDV)
        Me.Panel2.Controls.Add(Me.lblAccessLevel)
        Me.Panel2.Controls.Add(Me.lblSecQV)
        Me.Panel2.Controls.Add(Me.txtAnswerV)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 450)
        Me.Panel2.TabIndex = 118
        '
        'numAccessLevel
        '
        Me.numAccessLevel.Location = New System.Drawing.Point(228, 184)
        Me.numAccessLevel.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.numAccessLevel.Name = "numAccessLevel"
        Me.numAccessLevel.Size = New System.Drawing.Size(30, 20)
        Me.numAccessLevel.TabIndex = 119
        Me.numAccessLevel.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'numAccessLevelV
        '
        Me.numAccessLevelV.Location = New System.Drawing.Point(681, 194)
        Me.numAccessLevelV.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.numAccessLevelV.Name = "numAccessLevelV"
        Me.numAccessLevelV.Size = New System.Drawing.Size(30, 20)
        Me.numAccessLevelV.TabIndex = 118
        Me.numAccessLevelV.Value = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numAccessLevelV.Visible = False
        '
        'employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.BackgroundImage = Global.stock_control.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "employee"
        Me.Text = "Employee"
        CType(Me.pbBtnShutdown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.numAccessLevel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numAccessLevelV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtAnswerV As TextBox
    Friend WithEvents lblSecQV As Label
    Friend WithEvents cmbxSecIDV As ComboBox
    Friend WithEvents txtAnswer As TextBox
    Friend WithEvents lblSecurityA As Label
    Friend WithEvents lblSecurityQ As Label
    Friend WithEvents cmbxSecID As ComboBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblFirstLastV As Label
    Friend WithEvents txtFirstNameView As TextBox
    Friend WithEvents pbBtnShutdown As PictureBox
    Friend WithEvents btnEditView As Button
    Friend WithEvents txtLastNameView As TextBox
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrev As Button
    Friend WithEvents lblFirstNameV As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents lblEmployeeIDView As Label
    Friend WithEvents txtBoxEmployeeIDView As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblAccessLevel As Label
    Friend WithEvents txtEmailV As TextBox
    Friend WithEvents lblEmailV As Label
    Friend WithEvents txtUsernameV As TextBox
    Friend WithEvents lblUsernameV As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lblAccess As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblPasswordV As Label
    Friend WithEvents txtPasswordV As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents numAccessLevel As NumericUpDown
    Friend WithEvents numAccessLevelV As NumericUpDown
    Friend WithEvents lblSJR As Label
End Class
