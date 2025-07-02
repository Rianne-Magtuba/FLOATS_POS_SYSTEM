<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderDetails
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
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As DataGridViewCellStyle = New DataGridViewCellStyle()
        PictureBox1 = New PictureBox()
        dgvOrderDetails = New DataGridView()
        orderID = New DataGridViewTextBoxColumn()
        productID = New DataGridViewTextBoxColumn()
        quantity = New DataGridViewTextBoxColumn()
        totalPrice = New DataGridViewTextBoxColumn()
        date_ordered = New DataGridViewTextBoxColumn()
        time_ordered = New DataGridViewTextBoxColumn()
        dgvProducts = New DataGridView()
        productID2 = New DataGridViewTextBoxColumn()
        category = New DataGridViewTextBoxColumn()
        itemName = New DataGridViewTextBoxColumn()
        size = New DataGridViewTextBoxColumn()
        price = New DataGridViewTextBoxColumn()
        btn_products = New Button()
        btn_orders = New Button()
        btn_sort = New Button()
        btn_remove = New Button()
        tb_search = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvOrderDetails, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvProducts, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.floatsIcon
        PictureBox1.Location = New Point(500, -25)
        PictureBox1.Margin = New Padding(4, 5, 4, 5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(400, 350)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' dgvOrderDetails
        ' 
        dgvOrderDetails.AllowUserToAddRows = False
        dgvOrderDetails.AllowUserToResizeRows = False
        dgvOrderDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvOrderDetails.BackgroundColor = Color.Gainsboro
        dgvOrderDetails.BorderStyle = BorderStyle.None
        dgvOrderDetails.CellBorderStyle = DataGridViewCellBorderStyle.Raised
        dgvOrderDetails.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = Color.Black
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle6.ForeColor = Color.White
        DataGridViewCellStyle6.SelectionBackColor = Color.Black
        DataGridViewCellStyle6.SelectionForeColor = Color.White
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        dgvOrderDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        dgvOrderDetails.ColumnHeadersHeight = 40
        dgvOrderDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvOrderDetails.Columns.AddRange(New DataGridViewColumn() {orderID, productID, quantity, totalPrice, date_ordered, time_ordered})
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = Color.White
        DataGridViewCellStyle7.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle7.ForeColor = Color.Black
        DataGridViewCellStyle7.SelectionBackColor = Color.Yellow
        DataGridViewCellStyle7.SelectionForeColor = Color.Black
        DataGridViewCellStyle7.WrapMode = DataGridViewTriState.False
        dgvOrderDetails.DefaultCellStyle = DataGridViewCellStyle7
        dgvOrderDetails.EnableHeadersVisualStyles = False
        dgvOrderDetails.GridColor = Color.White
        dgvOrderDetails.Location = New Point(150, 335)
        dgvOrderDetails.Name = "dgvOrderDetails"
        dgvOrderDetails.RightToLeft = RightToLeft.No
        dgvOrderDetails.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        dgvOrderDetails.RowHeadersVisible = False
        dgvOrderDetails.RowHeadersWidth = 51
        dgvOrderDetails.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        dgvOrderDetails.ScrollBars = ScrollBars.Vertical
        dgvOrderDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvOrderDetails.Size = New Size(1100, 450)
        dgvOrderDetails.TabIndex = 2
        dgvOrderDetails.TabStop = False
        dgvOrderDetails.Visible = False
        ' 
        ' orderID
        ' 
        orderID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        orderID.FillWeight = 70F
        orderID.HeaderText = "Order ID"
        orderID.MinimumWidth = 6
        orderID.Name = "orderID"
        orderID.ReadOnly = True
        orderID.Resizable = DataGridViewTriState.False
        orderID.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' productID
        ' 
        productID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        productID.FillWeight = 70F
        productID.HeaderText = "Product ID"
        productID.MinimumWidth = 6
        productID.Name = "productID"
        productID.ReadOnly = True
        productID.Resizable = DataGridViewTriState.False
        productID.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' quantity
        ' 
        quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        quantity.HeaderText = "Quantity"
        quantity.MinimumWidth = 6
        quantity.Name = "quantity"
        quantity.ReadOnly = True
        quantity.Resizable = DataGridViewTriState.False
        quantity.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' totalPrice
        ' 
        totalPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        totalPrice.HeaderText = "Total Price"
        totalPrice.MinimumWidth = 6
        totalPrice.Name = "totalPrice"
        totalPrice.ReadOnly = True
        totalPrice.Resizable = DataGridViewTriState.False
        totalPrice.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' date_ordered
        ' 
        date_ordered.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        date_ordered.HeaderText = "Date"
        date_ordered.MinimumWidth = 6
        date_ordered.Name = "date_ordered"
        date_ordered.ReadOnly = True
        date_ordered.Resizable = DataGridViewTriState.False
        date_ordered.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' time_ordered
        ' 
        time_ordered.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        time_ordered.HeaderText = "TIime"
        time_ordered.MinimumWidth = 6
        time_ordered.Name = "time_ordered"
        time_ordered.ReadOnly = True
        time_ordered.Resizable = DataGridViewTriState.False
        time_ordered.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' dgvProducts
        ' 
        dgvProducts.AllowUserToAddRows = False
        dgvProducts.AllowUserToResizeRows = False
        dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvProducts.BackgroundColor = Color.Gainsboro
        dgvProducts.BorderStyle = BorderStyle.None
        dgvProducts.CellBorderStyle = DataGridViewCellBorderStyle.Raised
        dgvProducts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = Color.Black
        DataGridViewCellStyle8.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle8.ForeColor = Color.White
        DataGridViewCellStyle8.SelectionBackColor = Color.Black
        DataGridViewCellStyle8.SelectionForeColor = Color.White
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.True
        dgvProducts.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        dgvProducts.ColumnHeadersHeight = 40
        dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvProducts.Columns.AddRange(New DataGridViewColumn() {productID2, category, itemName, size, price})
        DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = SystemColors.Window
        DataGridViewCellStyle9.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle9.ForeColor = Color.Black
        DataGridViewCellStyle9.SelectionBackColor = Color.Yellow
        DataGridViewCellStyle9.SelectionForeColor = Color.Black
        DataGridViewCellStyle9.WrapMode = DataGridViewTriState.False
        dgvProducts.DefaultCellStyle = DataGridViewCellStyle9
        dgvProducts.EnableHeadersVisualStyles = False
        dgvProducts.GridColor = Color.White
        dgvProducts.Location = New Point(150, 335)
        dgvProducts.Name = "dgvProducts"
        dgvProducts.RightToLeft = RightToLeft.No
        dgvProducts.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = Color.White
        DataGridViewCellStyle10.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle10.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = DataGridViewTriState.True
        dgvProducts.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        dgvProducts.RowHeadersVisible = False
        dgvProducts.RowHeadersWidth = 40
        dgvProducts.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        dgvProducts.ScrollBars = ScrollBars.Vertical
        dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvProducts.Size = New Size(1100, 450)
        dgvProducts.TabIndex = 0
        dgvProducts.TabStop = False
        ' 
        ' productID2
        ' 
        productID2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        productID2.FillWeight = 60F
        productID2.HeaderText = "Product ID"
        productID2.MinimumWidth = 6
        productID2.Name = "productID2"
        productID2.ReadOnly = True
        productID2.Resizable = DataGridViewTriState.False
        productID2.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' category
        ' 
        category.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        category.HeaderText = "Category"
        category.MinimumWidth = 6
        category.Name = "category"
        category.ReadOnly = True
        category.Resizable = DataGridViewTriState.False
        category.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' itemName
        ' 
        itemName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        itemName.HeaderText = "Item Name"
        itemName.MinimumWidth = 6
        itemName.Name = "itemName"
        itemName.ReadOnly = True
        itemName.Resizable = DataGridViewTriState.False
        itemName.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' size
        ' 
        size.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        size.HeaderText = "Size"
        size.MinimumWidth = 6
        size.Name = "size"
        size.ReadOnly = True
        size.Resizable = DataGridViewTriState.False
        size.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' price
        ' 
        price.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        price.HeaderText = "Price"
        price.MinimumWidth = 6
        price.Name = "price"
        price.ReadOnly = True
        price.Resizable = DataGridViewTriState.False
        price.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' btn_products
        ' 
        btn_products.BackColor = Color.Black
        btn_products.FlatStyle = FlatStyle.Flat
        btn_products.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_products.ForeColor = Color.White
        btn_products.Location = New Point(150, 805)
        btn_products.Name = "btn_products"
        btn_products.Padding = New Padding(1)
        btn_products.Size = New Size(381, 50)
        btn_products.TabIndex = 4
        btn_products.Text = "Products"
        btn_products.UseVisualStyleBackColor = False
        ' 
        ' btn_orders
        ' 
        btn_orders.BackColor = Color.Black
        btn_orders.FlatStyle = FlatStyle.Flat
        btn_orders.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_orders.ForeColor = Color.White
        btn_orders.Location = New Point(537, 805)
        btn_orders.Name = "btn_orders"
        btn_orders.Padding = New Padding(1)
        btn_orders.Size = New Size(381, 50)
        btn_orders.TabIndex = 5
        btn_orders.Text = "Orders"
        btn_orders.UseVisualStyleBackColor = False
        ' 
        ' btn_sort
        ' 
        btn_sort.BackColor = Color.Black
        btn_sort.FlatStyle = FlatStyle.Flat
        btn_sort.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_sort.ForeColor = Color.White
        btn_sort.Location = New Point(1090, 805)
        btn_sort.Name = "btn_sort"
        btn_sort.Padding = New Padding(1)
        btn_sort.Size = New Size(160, 50)
        btn_sort.TabIndex = 6
        btn_sort.Text = "🔼 Sort"
        btn_sort.UseVisualStyleBackColor = False
        ' 
        ' btn_remove
        ' 
        btn_remove.BackColor = Color.Black
        btn_remove.FlatStyle = FlatStyle.Flat
        btn_remove.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_remove.ForeColor = Color.White
        btn_remove.Location = New Point(924, 805)
        btn_remove.Name = "btn_remove"
        btn_remove.Padding = New Padding(1)
        btn_remove.Size = New Size(160, 50)
        btn_remove.TabIndex = 7
        btn_remove.Text = "Remove"
        btn_remove.UseVisualStyleBackColor = False
        ' 
        ' tb_search
        ' 
        tb_search.Font = New Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tb_search.Location = New Point(400, 278)
        tb_search.Name = "tb_search"
        tb_search.PlaceholderText = "Search 🔍"
        tb_search.Size = New Size(600, 37)
        tb_search.TabIndex = 1
        tb_search.TabStop = False
        tb_search.TextAlign = HorizontalAlignment.Center
        ' 
        ' OrderDetails
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(1382, 953)
        Controls.Add(tb_search)
        Controls.Add(btn_remove)
        Controls.Add(btn_sort)
        Controls.Add(btn_orders)
        Controls.Add(btn_products)
        Controls.Add(dgvProducts)
        Controls.Add(dgvOrderDetails)
        Controls.Add(PictureBox1)
        ForeColor = Color.Black
        MaximizeBox = False
        MinimizeBox = False
        Name = "OrderDetails"
        StartPosition = FormStartPosition.CenterScreen
        Text = "OrderDetails"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvOrderDetails, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvProducts, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dgvOrderDetails As DataGridView
    Friend WithEvents dgvProducts As DataGridView
    Friend WithEvents btn_products As Button
    Friend WithEvents btn_orders As Button
    Friend WithEvents btn_sort As Button
    Friend WithEvents btn_remove As Button
    Friend WithEvents tb_search As TextBox
    Friend WithEvents proudctID As DataGridViewTextBoxColumn
    Friend WithEvents prouductID As DataGridViewTextBoxColumn
    Friend WithEvents productID2 As DataGridViewTextBoxColumn
    Friend WithEvents category As DataGridViewTextBoxColumn
    Friend WithEvents itemName As DataGridViewTextBoxColumn
    Friend WithEvents size As DataGridViewTextBoxColumn
    Friend WithEvents price As DataGridViewTextBoxColumn
    Friend WithEvents orderID As DataGridViewTextBoxColumn
    Friend WithEvents productID As DataGridViewTextBoxColumn
    Friend WithEvents quantity As DataGridViewTextBoxColumn
    Friend WithEvents totalPrice As DataGridViewTextBoxColumn
    Friend WithEvents date_ordered As DataGridViewTextBoxColumn
    Friend WithEvents time_ordered As DataGridViewTextBoxColumn
End Class
