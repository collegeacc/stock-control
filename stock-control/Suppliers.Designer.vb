<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Suppliers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Suppliers))
        Me.txtSupplierName = New System.Windows.Forms.TextBox()
        Me.lblSupplierName = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.lblEmailView = New System.Windows.Forms.Label()
        Me.txtEmailView = New System.Windows.Forms.TextBox()
        Me.lblSupplierName2 = New System.Windows.Forms.Label()
        Me.txtSupplierNameView = New System.Windows.Forms.TextBox()
        Me.btnEditDelete = New System.Windows.Forms.Button()
        Me.lblSupplierIDView = New System.Windows.Forms.Label()
        Me.txtBoxSupplierIDView = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Overlay1 = New stock_control.overlay()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtSupplierName
        '
        Me.txtSupplierName.Location = New System.Drawing.Point(318, 198)
        Me.txtSupplierName.Name = "txtSupplierName"
        Me.txtSupplierName.Size = New System.Drawing.Size(100, 20)
        Me.txtSupplierName.TabIndex = 15
        '
        'lblSupplierName
        '
        Me.lblSupplierName.AutoSize = True
        Me.lblSupplierName.BackColor = System.Drawing.Color.IndianRed
        Me.lblSupplierName.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSupplierName.Location = New System.Drawing.Point(191, 195)
        Me.lblSupplierName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSupplierName.Name = "lblSupplierName"
        Me.lblSupplierName.Size = New System.Drawing.Size(122, 21)
        Me.lblSupplierName.TabIndex = 14
        Me.lblSupplierName.Text = "Supplier Name:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(248, 233)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(100, 20)
        Me.txtEmail.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.IndianRed
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(191, 230)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 21)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Email:"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(195, 301)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(190, 58)
        Me.btnAdd.TabIndex = 18
        Me.btnAdd.Text = "Add Supplier"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(583, 301)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(69, 20)
        Me.btnNext.TabIndex = 42
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        Me.btnNext.Visible = False
        '
        'btnPrev
        '
        Me.btnPrev.Location = New System.Drawing.Point(472, 301)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(69, 20)
        Me.btnPrev.TabIndex = 41
        Me.btnPrev.Text = "Previous"
        Me.btnPrev.UseVisualStyleBackColor = True
        Me.btnPrev.Visible = False
        '
        'lblEmailView
        '
        Me.lblEmailView.AutoSize = True
        Me.lblEmailView.BackColor = System.Drawing.Color.IndianRed
        Me.lblEmailView.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblEmailView.Location = New System.Drawing.Point(468, 240)
        Me.lblEmailView.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEmailView.Name = "lblEmailView"
        Me.lblEmailView.Size = New System.Drawing.Size(48, 21)
        Me.lblEmailView.TabIndex = 40
        Me.lblEmailView.Text = "Email"
        Me.lblEmailView.Visible = False
        '
        'txtEmailView
        '
        Me.txtEmailView.Location = New System.Drawing.Point(472, 263)
        Me.txtEmailView.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmailView.Name = "txtEmailView"
        Me.txtEmailView.Size = New System.Drawing.Size(180, 20)
        Me.txtEmailView.TabIndex = 39
        Me.txtEmailView.Visible = False
        '
        'lblSupplierName2
        '
        Me.lblSupplierName2.AutoSize = True
        Me.lblSupplierName2.BackColor = System.Drawing.Color.IndianRed
        Me.lblSupplierName2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblSupplierName2.Location = New System.Drawing.Point(468, 195)
        Me.lblSupplierName2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSupplierName2.Name = "lblSupplierName2"
        Me.lblSupplierName2.Size = New System.Drawing.Size(118, 21)
        Me.lblSupplierName2.TabIndex = 38
        Me.lblSupplierName2.Text = "Supplier Name"
        Me.lblSupplierName2.Visible = False
        '
        'txtSupplierNameView
        '
        Me.txtSupplierNameView.Location = New System.Drawing.Point(472, 218)
        Me.txtSupplierNameView.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSupplierNameView.Name = "txtSupplierNameView"
        Me.txtSupplierNameView.Size = New System.Drawing.Size(180, 20)
        Me.txtSupplierNameView.TabIndex = 37
        Me.txtSupplierNameView.Visible = False
        '
        'btnEditDelete
        '
        Me.btnEditDelete.Location = New System.Drawing.Point(195, 373)
        Me.btnEditDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEditDelete.Name = "btnEditDelete"
        Me.btnEditDelete.Size = New System.Drawing.Size(190, 55)
        Me.btnEditDelete.TabIndex = 43
        Me.btnEditDelete.Text = "View Suppliers"
        Me.btnEditDelete.UseVisualStyleBackColor = True
        '
        'lblSupplierIDView
        '
        Me.lblSupplierIDView.AutoSize = True
        Me.lblSupplierIDView.BackColor = System.Drawing.Color.IndianRed
        Me.lblSupplierIDView.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblSupplierIDView.Location = New System.Drawing.Point(674, 195)
        Me.lblSupplierIDView.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSupplierIDView.Name = "lblSupplierIDView"
        Me.lblSupplierIDView.Size = New System.Drawing.Size(91, 21)
        Me.lblSupplierIDView.TabIndex = 45
        Me.lblSupplierIDView.Text = "Supplier ID"
        Me.lblSupplierIDView.Visible = False
        '
        'txtBoxSupplierIDView
        '
        Me.txtBoxSupplierIDView.Location = New System.Drawing.Point(678, 218)
        Me.txtBoxSupplierIDView.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBoxSupplierIDView.Name = "txtBoxSupplierIDView"
        Me.txtBoxSupplierIDView.Size = New System.Drawing.Size(69, 20)
        Me.txtBoxSupplierIDView.TabIndex = 44
        Me.txtBoxSupplierIDView.Visible = False
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(523, 336)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 46
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        Me.btnUpdate.Visible = False
        '
        'Overlay1
        '
        Me.Overlay1.BackColor = System.Drawing.Color.Transparent
        Me.Overlay1.BackgroundImage = CType(resources.GetObject("Overlay1.BackgroundImage"), System.Drawing.Image)
        Me.Overlay1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Overlay1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Overlay1.Location = New System.Drawing.Point(0, 0)
        Me.Overlay1.Name = "Overlay1"
        Me.Overlay1.Size = New System.Drawing.Size(800, 461)
        Me.Overlay1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(424, 198)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 25)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Lime
        Me.Label3.Location = New System.Drawing.Point(354, 233)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 25)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "*"
        '
        'Suppliers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(800, 461)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.lblSupplierIDView)
        Me.Controls.Add(Me.txtBoxSupplierIDView)
        Me.Controls.Add(Me.btnEditDelete)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.lblEmailView)
        Me.Controls.Add(Me.txtEmailView)
        Me.Controls.Add(Me.lblSupplierName2)
        Me.Controls.Add(Me.txtSupplierNameView)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSupplierName)
        Me.Controls.Add(Me.lblSupplierName)
        Me.Controls.Add(Me.Overlay1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Suppliers"
        Me.Text = "Suppliers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Overlay1 As overlay
    Friend WithEvents txtSupplierName As TextBox
    Friend WithEvents lblSupplierName As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrev As Button
    Friend WithEvents lblEmailView As Label
    Friend WithEvents txtEmailView As TextBox
    Friend WithEvents lblSupplierName2 As Label
    Friend WithEvents txtSupplierNameView As TextBox
    Friend WithEvents btnEditDelete As Button
    Friend WithEvents lblSupplierIDView As Label
    Friend WithEvents txtBoxSupplierIDView As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
