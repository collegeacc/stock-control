<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class overlay
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pbBtnUserManag = New System.Windows.Forms.PictureBox()
        Me.pbBtnSuppliers = New System.Windows.Forms.PictureBox()
        Me.pbBtnStatistics = New System.Windows.Forms.PictureBox()
        Me.pbBtnProducts = New System.Windows.Forms.PictureBox()
        Me.pbBtnOrder = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        CType(Me.pbBtnUserManag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBtnSuppliers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBtnStatistics, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBtnProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBtnOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel2.Controls.Add(Me.pbBtnUserManag)
        Me.Panel2.Controls.Add(Me.pbBtnSuppliers)
        Me.Panel2.Controls.Add(Me.pbBtnStatistics)
        Me.Panel2.Controls.Add(Me.pbBtnProducts)
        Me.Panel2.Controls.Add(Me.pbBtnOrder)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 140)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(148, 396)
        Me.Panel2.TabIndex = 3
        '
        'pbBtnUserManag
        '
        Me.pbBtnUserManag.Image = Global.stock_control.My.Resources.Resources.userManag
        Me.pbBtnUserManag.Location = New System.Drawing.Point(8, 268)
        Me.pbBtnUserManag.Margin = New System.Windows.Forms.Padding(2)
        Me.pbBtnUserManag.Name = "pbBtnUserManag"
        Me.pbBtnUserManag.Size = New System.Drawing.Size(133, 48)
        Me.pbBtnUserManag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbBtnUserManag.TabIndex = 4
        Me.pbBtnUserManag.TabStop = False
        '
        'pbBtnSuppliers
        '
        Me.pbBtnSuppliers.Image = Global.stock_control.My.Resources.Resources.suppliers
        Me.pbBtnSuppliers.Location = New System.Drawing.Point(8, 208)
        Me.pbBtnSuppliers.Margin = New System.Windows.Forms.Padding(2)
        Me.pbBtnSuppliers.Name = "pbBtnSuppliers"
        Me.pbBtnSuppliers.Size = New System.Drawing.Size(133, 48)
        Me.pbBtnSuppliers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbBtnSuppliers.TabIndex = 3
        Me.pbBtnSuppliers.TabStop = False
        '
        'pbBtnStatistics
        '
        Me.pbBtnStatistics.Image = Global.stock_control.My.Resources.Resources.statistics
        Me.pbBtnStatistics.Location = New System.Drawing.Point(8, 148)
        Me.pbBtnStatistics.Margin = New System.Windows.Forms.Padding(2)
        Me.pbBtnStatistics.Name = "pbBtnStatistics"
        Me.pbBtnStatistics.Size = New System.Drawing.Size(133, 48)
        Me.pbBtnStatistics.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbBtnStatistics.TabIndex = 2
        Me.pbBtnStatistics.TabStop = False
        '
        'pbBtnProducts
        '
        Me.pbBtnProducts.Image = Global.stock_control.My.Resources.Resources.products
        Me.pbBtnProducts.Location = New System.Drawing.Point(8, 88)
        Me.pbBtnProducts.Margin = New System.Windows.Forms.Padding(2)
        Me.pbBtnProducts.Name = "pbBtnProducts"
        Me.pbBtnProducts.Size = New System.Drawing.Size(133, 48)
        Me.pbBtnProducts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbBtnProducts.TabIndex = 1
        Me.pbBtnProducts.TabStop = False
        '
        'pbBtnOrder
        '
        Me.pbBtnOrder.Image = Global.stock_control.My.Resources.Resources.Orders1
        Me.pbBtnOrder.Location = New System.Drawing.Point(8, 28)
        Me.pbBtnOrder.Margin = New System.Windows.Forms.Padding(2)
        Me.pbBtnOrder.Name = "pbBtnOrder"
        Me.pbBtnOrder.Size = New System.Drawing.Size(134, 48)
        Me.pbBtnOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbBtnOrder.TabIndex = 0
        Me.pbBtnOrder.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel1.Controls.Add(Me.pbLogo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(666, 140)
        Me.Panel1.TabIndex = 2
        '
        'pbLogo
        '
        Me.pbLogo.BackColor = System.Drawing.Color.Transparent
        Me.pbLogo.Image = Global.stock_control.My.Resources.Resources.sjr_logo
        Me.pbLogo.Location = New System.Drawing.Point(14, 2)
        Me.pbLogo.Margin = New System.Windows.Forms.Padding(2)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(116, 138)
        Me.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLogo.TabIndex = 0
        Me.pbLogo.TabStop = False
        '
        'overlay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BackgroundImage = Global.stock_control.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "overlay"
        Me.Size = New System.Drawing.Size(666, 536)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.pbBtnUserManag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBtnSuppliers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBtnStatistics, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBtnProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBtnOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents pbBtnOrder As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents pbBtnProducts As PictureBox
    Friend WithEvents pbBtnStatistics As PictureBox
    Friend WithEvents pbBtnSuppliers As PictureBox
    Friend WithEvents pbBtnUserManag As PictureBox
End Class
