Imports System.Windows
Imports System.Windows.Forms.DataVisualization.Charting

Public Class MainMenu
    Public accessLevel As Integer
    Dim firstOpen As Boolean = True
    'Private Sub frmProgram_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    '    Application.Exit() 'closes everything when form is closed
    'End Sub



    Public Sub fillCmbx()
        simpleSQL("SELECT tblProducts.[Product Name], tblProducts.Stock, IIf([Stock]=0,'OUT OF STOCK',[Stock] & ' left In stock') AS [Ammount Left In Stock] FROM tblProducts;", "Products")
        curRow = 0
        cmbxProduct.DataSource = ds.Tables("Products")
        cmbxProduct.DisplayMember = "Product Name"
        cmbxProduct.ValueMember = "Ammount Left In Stock"
    End Sub
    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call fillCmbx()

        Me.TblProductsTableAdapter.Fill(Me._stock_controlDBDataSet.tblProducts)

        Chart1.ChartAreas(0).AxisX.Interval = 1

        LogIn.Close()
        'lblUsername.Text = userLoggedIn
        'sql = "SELECT tblEmployee.Username, tblEmployee.[First Name], tblEmployee.[Last Name] FROM tblEmployee WHERE tblEmployee.Username ='" & userLoggedIn & "'"
        'da = New OleDb.OleDbDataAdapter(sql, conn)
        'da.Fill(ds, "temp")
        'lblName.Text = ds.Tables("temp").Rows(0).Item(1) & " " & ds.Tables("temp").Rows(0).Item(2)
        ''btw this is sql injection proof - trust me bro

        simpleSQL("SELECT tblEmployee.EmployeeID, tblEmployee.[Access Level] FROM tblEmployee;", "accessLevels")
        While curRow < MaxRows
            If ds.Tables("accessLevels").Rows(curRow).Item(0) = employeeID Then 'this checks in the current row has the employee ID that is logged in, then grabs that employees access level
                accessLevel = ds.Tables("accessLevels").Rows(curRow).Item(0)
                Exit While
            Else
                curRow = curRow + 1
            End If
        End While

        If curRow = MaxRows Then
            accessLevel = 0
        End If

        If accessLevel = 0 Then 'this is for customer, will be set up later
            'pbBtnOrder.Visible = False
        ElseIf accessLevel > 1 Then 'all things users with access level 1 and above can do
            'hide everything except the order button

        ElseIf accessLevel > 2 Then 'all things users with access level 2 and above can do
            'hide everything but order, product, supplier
        ElseIf accessLevel > 3 Then 'all things users with access level 3 and above can do
            'hide nothing
        End If



    End Sub


    '    Private Sub Graph_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    '        sql = "SELECT tblProducts.[Product Name], tblProducts.Stock
    'FROM tblProducts;
    '"
    '        conn.Open()
    '        da = New OleDb.OleDbDataAdapter(sql, conn)
    '        Dim ds As New DataSet()
    '        da.Fill(ds, "DSStock") 'this is the dataset made from the table "Products"

    '        MaxRows = ds.Tables("DSStock").Rows.Count
    '        curRow = 0
    '        MaxCol = ds.Tables("DSStock").Columns.Count

    '        Dim ChartArea1 As ChartArea = New ChartArea()
    '        Dim Legend1 As Legend = New Legend()
    '        Dim Series1 As Series = New Series()
    '        Dim Chart1 = New Chart()
    '        Me.Controls.Add(Chart1)

    '        Series1.ChartType = SeriesChartType.Bar
    '        ChartArea1.Name = "ChartArea1"
    '        Chart1.ChartAreas.Add(ChartArea1)
    '        Legend1.Name = "Legend1"
    '        Chart1.Legends.Add(Legend1)
    '        Chart1.Location = New System.Drawing.Point(140, 150)
    '        Series1.Name = "Product Stock"
    '        Chart1.Titles.Add("Product Stock")
    '        Series1.Name = "Product Stock"
    '        Chart1.Series.Add(Series1)
    '        Chart1.Size = New System.Drawing.Size(370, 368)

    '        Chart1.Series("Product Stock").XValueMember = "Product Name"
    '        Chart1.Series("Product Stock").YValueMembers = "Stock"

    '        Chart1.DataSource = ds.Tables("DSStock")
    '        Chart1.Palette = ChartColorPalette.Chocolate
    '        Chart1.BackColor = System.Drawing.Color.Transparent
    '        Chart1.Cursor = System.Windows.Forms.Cursors.No
    '        conn.Close()
    '    End Sub

    Sub swapVisible()
        If Chart1.Visible = True Then
            Chart1.Visible = False
            cmbxProduct.Visible = False
            txtStock.Visible = False
            lblSelectProduct.Visible = False
            lblStock.Visible = False
        Else
            Chart1.Visible = True
            cmbxProduct.Visible = True
            txtStock.Visible = True
            lblSelectProduct.Visible = True
            lblStock.Visible = True
        End If
    End Sub

    Private Sub pbBtnOrder_Click(sender As Object, e As EventArgs)
        firstOpen = False
        Call swapVisible()
        Me.IsMdiContainer = True
        For Each ctl As Control In Me.Controls 'changes the ugly Mdi colour to the colour that the form is actually set to
            If TypeOf ctl Is MdiClient Then
                ctl.BackColor = Me.BackColor
            End If
        Next ctl
        'Here the Mdi container is set up so that a user can have multiple of these windows open if they so choose
        With orderSubForm
            'sets the current multiple-document interface(MDI) parent form of this form
            .MdiParent = Me
            'show the form2
            .Show()
        End With
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtStock.TextChanged

    End Sub

    Private Sub cmbxProduct_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbxProduct.SelectedValueChanged
        txtStock.Text = cmbxProduct.SelectedValue.ToString
    End Sub

    Private Sub pbMainMenu_Click(sender As Object, e As EventArgs)
        If firstOpen = False Then
            Call swapVisible()
            Me.IsMdiContainer = False
        End If
    End Sub


End Class