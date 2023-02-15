<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Statistics
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Statistics))
        Me.Overlay1 = New stock_control.overlay()
        Me.SuspendLayout()
        '
        'Overlay1
        '
        Me.Overlay1.BackColor = System.Drawing.Color.Transparent
        Me.Overlay1.BackgroundImage = CType(resources.GetObject("Overlay1.BackgroundImage"), System.Drawing.Image)
        Me.Overlay1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Overlay1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Overlay1.Location = New System.Drawing.Point(0, 0)
        Me.Overlay1.Name = "Overlay1"
        Me.Overlay1.Size = New System.Drawing.Size(800, 450)
        Me.Overlay1.TabIndex = 0
        '
        'Statistics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Overlay1)
        Me.Name = "Statistics"
        Me.Text = "Statistics"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Overlay1 As overlay
End Class
