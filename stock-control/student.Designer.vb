<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class student
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(student))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pbBtnShutdown = New System.Windows.Forms.PictureBox()
        Me.lblSJR = New System.Windows.Forms.Label()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lblStudentIDView = New System.Windows.Forms.Label()
        Me.txtBoxStudentIDView = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.btnEditView = New System.Windows.Forms.Button()
        Me.lblFirstLastV = New System.Windows.Forms.Label()
        Me.txtLastNameView = New System.Windows.Forms.TextBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.lblFirstNameV = New System.Windows.Forms.Label()
        Me.txtFirstNameView = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.cmbxSecID = New System.Windows.Forms.ComboBox()
        Me.lblSecurityQ = New System.Windows.Forms.Label()
        Me.lblSecurityA = New System.Windows.Forms.Label()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.txtAnswerV = New System.Windows.Forms.TextBox()
        Me.lblSecQV = New System.Windows.Forms.Label()
        Me.cmbxSecIDV = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.pbBtnShutdown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel1.Controls.Add(Me.pbBtnShutdown)
        Me.Panel1.Controls.Add(Me.lblSJR)
        Me.Panel1.Controls.Add(Me.pbLogo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 140)
        Me.Panel1.TabIndex = 3
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
        'lblSJR
        '
        Me.lblSJR.AutoSize = True
        Me.lblSJR.Font = New System.Drawing.Font("Museo Slab 700", 47.99999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSJR.ForeColor = System.Drawing.Color.White
        Me.lblSJR.Location = New System.Drawing.Point(144, 32)
        Me.lblSJR.Name = "lblSJR"
        Me.lblSJR.Size = New System.Drawing.Size(479, 77)
        Me.lblSJR.TabIndex = 1
        Me.lblSJR.Text = "St John Rigby"
        '
        'pbLogo
        '
        Me.pbLogo.BackColor = System.Drawing.Color.Transparent
        Me.pbLogo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbLogo.Image = Global.stock_control.My.Resources.Resources.sjr_logo
        Me.pbLogo.Location = New System.Drawing.Point(14, 2)
        Me.pbLogo.Margin = New System.Windows.Forms.Padding(2)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(116, 138)
        Me.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLogo.TabIndex = 0
        Me.pbLogo.TabStop = False
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(555, 324)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 54
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        Me.btnUpdate.Visible = False
        '
        'lblStudentIDView
        '
        Me.lblStudentIDView.AutoSize = True
        Me.lblStudentIDView.BackColor = System.Drawing.Color.IndianRed
        Me.lblStudentIDView.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblStudentIDView.Location = New System.Drawing.Point(681, 191)
        Me.lblStudentIDView.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblStudentIDView.Name = "lblStudentIDView"
        Me.lblStudentIDView.Size = New System.Drawing.Size(88, 21)
        Me.lblStudentIDView.TabIndex = 53
        Me.lblStudentIDView.Text = "Student ID"
        Me.lblStudentIDView.Visible = False
        '
        'txtBoxStudentIDView
        '
        Me.txtBoxStudentIDView.Location = New System.Drawing.Point(685, 214)
        Me.txtBoxStudentIDView.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBoxStudentIDView.Name = "txtBoxStudentIDView"
        Me.txtBoxStudentIDView.Size = New System.Drawing.Size(69, 20)
        Me.txtBoxStudentIDView.TabIndex = 52
        Me.txtBoxStudentIDView.Visible = False
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.BackColor = System.Drawing.Color.IndianRed
        Me.lblFirstName.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblFirstName.Location = New System.Drawing.Point(47, 191)
        Me.lblFirstName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(88, 21)
        Me.lblFirstName.TabIndex = 49
        Me.lblFirstName.Text = "First Name"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(51, 214)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(84, 20)
        Me.txtFirstName.TabIndex = 48
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.BackColor = System.Drawing.Color.IndianRed
        Me.lblLastName.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblLastName.Location = New System.Drawing.Point(139, 191)
        Me.lblLastName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(86, 21)
        Me.lblLastName.TabIndex = 56
        Me.lblLastName.Text = "Last Name"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(143, 214)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(84, 20)
        Me.txtLastName.TabIndex = 55
        '
        'btnEditView
        '
        Me.btnEditView.Location = New System.Drawing.Point(66, 366)
        Me.btnEditView.Name = "btnEditView"
        Me.btnEditView.Size = New System.Drawing.Size(140, 23)
        Me.btnEditView.TabIndex = 59
        Me.btnEditView.Text = "Edit/View Students"
        Me.btnEditView.UseVisualStyleBackColor = True
        '
        'lblFirstLastV
        '
        Me.lblFirstLastV.AutoSize = True
        Me.lblFirstLastV.BackColor = System.Drawing.Color.IndianRed
        Me.lblFirstLastV.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblFirstLastV.Location = New System.Drawing.Point(591, 191)
        Me.lblFirstLastV.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFirstLastV.Name = "lblFirstLastV"
        Me.lblFirstLastV.Size = New System.Drawing.Size(86, 21)
        Me.lblFirstLastV.TabIndex = 65
        Me.lblFirstLastV.Text = "Last Name"
        Me.lblFirstLastV.Visible = False
        '
        'txtLastNameView
        '
        Me.txtLastNameView.Location = New System.Drawing.Point(595, 214)
        Me.txtLastNameView.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLastNameView.Name = "txtLastNameView"
        Me.txtLastNameView.Size = New System.Drawing.Size(84, 20)
        Me.txtLastNameView.TabIndex = 64
        Me.txtLastNameView.Visible = False
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(615, 298)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(69, 20)
        Me.btnNext.TabIndex = 63
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        Me.btnNext.Visible = False
        '
        'btnPrev
        '
        Me.btnPrev.Location = New System.Drawing.Point(504, 298)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(69, 20)
        Me.btnPrev.TabIndex = 62
        Me.btnPrev.Text = "Previous"
        Me.btnPrev.UseVisualStyleBackColor = True
        Me.btnPrev.Visible = False
        '
        'lblFirstNameV
        '
        Me.lblFirstNameV.AutoSize = True
        Me.lblFirstNameV.BackColor = System.Drawing.Color.IndianRed
        Me.lblFirstNameV.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblFirstNameV.Location = New System.Drawing.Point(499, 191)
        Me.lblFirstNameV.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFirstNameV.Name = "lblFirstNameV"
        Me.lblFirstNameV.Size = New System.Drawing.Size(88, 21)
        Me.lblFirstNameV.TabIndex = 61
        Me.lblFirstNameV.Text = "First Name"
        Me.lblFirstNameV.Visible = False
        '
        'txtFirstNameView
        '
        Me.txtFirstNameView.Location = New System.Drawing.Point(503, 214)
        Me.txtFirstNameView.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFirstNameView.Name = "txtFirstNameView"
        Me.txtFirstNameView.Size = New System.Drawing.Size(84, 20)
        Me.txtFirstNameView.TabIndex = 60
        Me.txtFirstNameView.Visible = False
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(99, 337)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 68
        Me.btnAdd.Text = "Add Student"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'cmbxSecID
        '
        Me.cmbxSecID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxSecID.FormattingEnabled = True
        Me.cmbxSecID.Items.AddRange(New Object() {"What was your childhood pet's name?", "What was your primary school called?", "What is your mother's maiden name?", "How old where you when you had your first kiss?", "What was your favourite childhood hobby?"})
        Me.cmbxSecID.Location = New System.Drawing.Point(51, 260)
        Me.cmbxSecID.Name = "cmbxSecID"
        Me.cmbxSecID.Size = New System.Drawing.Size(174, 21)
        Me.cmbxSecID.TabIndex = 69
        '
        'lblSecurityQ
        '
        Me.lblSecurityQ.AutoSize = True
        Me.lblSecurityQ.BackColor = System.Drawing.Color.IndianRed
        Me.lblSecurityQ.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblSecurityQ.Location = New System.Drawing.Point(47, 236)
        Me.lblSecurityQ.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSecurityQ.Name = "lblSecurityQ"
        Me.lblSecurityQ.Size = New System.Drawing.Size(139, 21)
        Me.lblSecurityQ.TabIndex = 70
        Me.lblSecurityQ.Text = "Security Question"
        '
        'lblSecurityA
        '
        Me.lblSecurityA.AutoSize = True
        Me.lblSecurityA.BackColor = System.Drawing.Color.IndianRed
        Me.lblSecurityA.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblSecurityA.Location = New System.Drawing.Point(47, 284)
        Me.lblSecurityA.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSecurityA.Name = "lblSecurityA"
        Me.lblSecurityA.Size = New System.Drawing.Size(127, 21)
        Me.lblSecurityA.TabIndex = 71
        Me.lblSecurityA.Text = "Security Answer"
        '
        'txtAnswer
        '
        Me.txtAnswer.Location = New System.Drawing.Point(51, 307)
        Me.txtAnswer.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(174, 20)
        Me.txtAnswer.TabIndex = 72
        '
        'txtAnswerV
        '
        Me.txtAnswerV.Location = New System.Drawing.Point(580, 251)
        Me.txtAnswerV.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAnswerV.Name = "txtAnswerV"
        Me.txtAnswerV.Size = New System.Drawing.Size(174, 20)
        Me.txtAnswerV.TabIndex = 76
        Me.txtAnswerV.Visible = False
        '
        'lblSecQV
        '
        Me.lblSecQV.AutoSize = True
        Me.lblSecQV.BackColor = System.Drawing.Color.IndianRed
        Me.lblSecQV.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblSecQV.Location = New System.Drawing.Point(360, 227)
        Me.lblSecQV.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSecQV.Name = "lblSecQV"
        Me.lblSecQV.Size = New System.Drawing.Size(139, 21)
        Me.lblSecQV.TabIndex = 74
        Me.lblSecQV.Text = "Security Question"
        Me.lblSecQV.Visible = False
        '
        'cmbxSecIDV
        '
        Me.cmbxSecIDV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxSecIDV.FormattingEnabled = True
        Me.cmbxSecIDV.Items.AddRange(New Object() {"What was your childhood pet's name?", "What was your primary school called?", "What is your mother's maiden name?", "How old where you when you had your first kiss?", "What was your favourite childhood hobby?"})
        Me.cmbxSecIDV.Location = New System.Drawing.Point(401, 251)
        Me.cmbxSecIDV.Name = "cmbxSecIDV"
        Me.cmbxSecIDV.Size = New System.Drawing.Size(174, 21)
        Me.cmbxSecIDV.TabIndex = 73
        Me.cmbxSecIDV.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.txtAnswerV)
        Me.Panel2.Controls.Add(Me.lblLastName)
        Me.Panel2.Controls.Add(Me.lblSecQV)
        Me.Panel2.Controls.Add(Me.txtFirstName)
        Me.Panel2.Controls.Add(Me.cmbxSecIDV)
        Me.Panel2.Controls.Add(Me.lblFirstName)
        Me.Panel2.Controls.Add(Me.txtAnswer)
        Me.Panel2.Controls.Add(Me.txtBoxStudentIDView)
        Me.Panel2.Controls.Add(Me.lblSecurityA)
        Me.Panel2.Controls.Add(Me.lblStudentIDView)
        Me.Panel2.Controls.Add(Me.lblSecurityQ)
        Me.Panel2.Controls.Add(Me.btnUpdate)
        Me.Panel2.Controls.Add(Me.cmbxSecID)
        Me.Panel2.Controls.Add(Me.txtLastName)
        Me.Panel2.Controls.Add(Me.btnAdd)
        Me.Panel2.Controls.Add(Me.btnEditView)
        Me.Panel2.Controls.Add(Me.lblFirstLastV)
        Me.Panel2.Controls.Add(Me.txtFirstNameView)
        Me.Panel2.Controls.Add(Me.txtLastNameView)
        Me.Panel2.Controls.Add(Me.lblFirstNameV)
        Me.Panel2.Controls.Add(Me.btnNext)
        Me.Panel2.Controls.Add(Me.btnPrev)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 450)
        Me.Panel2.TabIndex = 77
        '
        'student
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
        Me.Name = "student"
        Me.Text = "Student"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbBtnShutdown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents pbBtnShutdown As PictureBox
    Friend WithEvents lblSJR As Label
    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents lblStudentIDView As Label
    Friend WithEvents txtBoxStudentIDView As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents btnEditView As Button
    Friend WithEvents lblFirstLastV As Label
    Friend WithEvents txtLastNameView As TextBox
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrev As Button
    Friend WithEvents lblFirstNameV As Label
    Friend WithEvents txtFirstNameView As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents cmbxSecID As ComboBox
    Friend WithEvents lblSecurityQ As Label
    Friend WithEvents lblSecurityA As Label
    Friend WithEvents txtAnswer As TextBox
    Friend WithEvents txtAnswerV As TextBox
    Friend WithEvents lblSecQV As Label
    Friend WithEvents cmbxSecIDV As ComboBox
    Friend WithEvents Panel2 As Panel
End Class
