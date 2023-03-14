<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class userMgmt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(userMgmt))
        Me.btnStudent = New System.Windows.Forms.Button()
        Me.btnEmployee = New System.Windows.Forms.Button()
        Me.Overlay1 = New stock_control.overlay()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnStudent
        '
        Me.btnStudent.Location = New System.Drawing.Point(194, 194)
        Me.btnStudent.Name = "btnStudent"
        Me.btnStudent.Size = New System.Drawing.Size(186, 110)
        Me.btnStudent.TabIndex = 3
        Me.btnStudent.Text = "Students"
        Me.btnStudent.UseVisualStyleBackColor = True
        '
        'btnEmployee
        '
        Me.btnEmployee.Location = New System.Drawing.Point(386, 194)
        Me.btnEmployee.Name = "btnEmployee"
        Me.btnEmployee.Size = New System.Drawing.Size(186, 110)
        Me.btnEmployee.TabIndex = 4
        Me.btnEmployee.Text = "Employees"
        Me.btnEmployee.UseVisualStyleBackColor = True
        '
        'Overlay1
        '
        Me.Overlay1.BackColor = System.Drawing.Color.Transparent
        Me.Overlay1.BackgroundImage = CType(resources.GetObject("Overlay1.BackgroundImage"), System.Drawing.Image)
        Me.Overlay1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Overlay1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Overlay1.Location = New System.Drawing.Point(0, 0)
        Me.Overlay1.Name = "Overlay1"
        Me.Overlay1.Size = New System.Drawing.Size(732, 480)
        Me.Overlay1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Museo Slab 500", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(166, 166)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(554, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Please select what type of users you'd like to manage"
        '
        'userMgmt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(732, 480)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEmployee)
        Me.Controls.Add(Me.btnStudent)
        Me.Controls.Add(Me.Overlay1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "userMgmt"
        Me.Text = "User Management"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Overlay1 As overlay
    Friend WithEvents btnStudent As Button
    Friend WithEvents btnEmployee As Button
    Friend WithEvents Label1 As Label
End Class
