<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        TabControl1 = New TabControl()
        classicTab = New TabPage()
        rootBFloat = New Button()
        spriteFloat = New Button()
        cokeFloat = New Button()
        caffeineTab = New TabPage()
        mochaFloat = New Button()
        cofCaramelFloat = New Button()
        candyTab = New TabPage()
        blueOceanFloat = New Button()
        ItemNamelbl = New Label()
        quantityLabel = New Label()
        sizeLabel = New Label()
        priceLabel = New Label()
        sizeLbl = New Label()
        itemQuantityLbl = New Label()
        addButt = New Button()
        minusButt = New Button()
        itemQuantity = New Label()
        largeSizeButt = New Button()
        mediumSizeButt = New Button()
        totalLbl = New Label()
        removeButt = New Button()
        clearButt = New Button()
        compButt = New Button()
        totalPriceLbl = New Label()
        PictureBox1 = New PictureBox()
        backButt = New Label()
        DataGridView1 = New DataGridView()
        selectedSize = New Label()
        TabControl1.SuspendLayout()
        classicTab.SuspendLayout()
        caffeineTab.SuspendLayout()
        candyTab.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(classicTab)
        TabControl1.Controls.Add(caffeineTab)
        TabControl1.Controls.Add(candyTab)
        TabControl1.Location = New Point(70, 223)
        TabControl1.Margin = New Padding(5, 6, 5, 6)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(948, 634)
        TabControl1.TabIndex = 1
        ' 
        ' classicTab
        ' 
        classicTab.Controls.Add(rootBFloat)
        classicTab.Controls.Add(spriteFloat)
        classicTab.Controls.Add(cokeFloat)
        classicTab.Location = New Point(4, 34)
        classicTab.Margin = New Padding(5, 6, 5, 6)
        classicTab.Name = "classicTab"
        classicTab.Padding = New Padding(5, 6, 5, 6)
        classicTab.Size = New Size(940, 596)
        classicTab.TabIndex = 0
        classicTab.Text = "Classic"
        classicTab.UseVisualStyleBackColor = True
        ' 
        ' rootBFloat
        ' 
        rootBFloat.BackColor = Color.Black
        rootBFloat.FlatStyle = FlatStyle.Flat
        rootBFloat.ForeColor = Color.White
        rootBFloat.Location = New Point(588, 71)
        rootBFloat.Margin = New Padding(5, 6, 5, 6)
        rootBFloat.Name = "rootBFloat"
        rootBFloat.Size = New Size(220, 190)
        rootBFloat.TabIndex = 2
        rootBFloat.Text = "Rootbeer Float"
        rootBFloat.UseVisualStyleBackColor = False
        ' 
        ' spriteFloat
        ' 
        spriteFloat.BackColor = Color.Black
        spriteFloat.FlatStyle = FlatStyle.Flat
        spriteFloat.ForeColor = Color.White
        spriteFloat.Location = New Point(318, 71)
        spriteFloat.Margin = New Padding(5, 6, 5, 6)
        spriteFloat.Name = "spriteFloat"
        spriteFloat.Size = New Size(220, 190)
        spriteFloat.TabIndex = 1
        spriteFloat.Text = "Sprite Float"
        spriteFloat.UseVisualStyleBackColor = False
        ' 
        ' cokeFloat
        ' 
        cokeFloat.BackColor = Color.Black
        cokeFloat.FlatStyle = FlatStyle.Flat
        cokeFloat.ForeColor = Color.White
        cokeFloat.Location = New Point(43, 71)
        cokeFloat.Margin = New Padding(5, 6, 5, 6)
        cokeFloat.Name = "cokeFloat"
        cokeFloat.Size = New Size(220, 190)
        cokeFloat.TabIndex = 0
        cokeFloat.Text = "Coke Float"
        cokeFloat.UseVisualStyleBackColor = False
        ' 
        ' caffeineTab
        ' 
        caffeineTab.Controls.Add(mochaFloat)
        caffeineTab.Controls.Add(cofCaramelFloat)
        caffeineTab.Location = New Point(4, 34)
        caffeineTab.Margin = New Padding(5, 6, 5, 6)
        caffeineTab.Name = "caffeineTab"
        caffeineTab.Padding = New Padding(5, 6, 5, 6)
        caffeineTab.Size = New Size(940, 596)
        caffeineTab.TabIndex = 1
        caffeineTab.Text = "Caffeine"
        caffeineTab.UseVisualStyleBackColor = True
        ' 
        ' mochaFloat
        ' 
        mochaFloat.BackColor = Color.Black
        mochaFloat.FlatStyle = FlatStyle.Flat
        mochaFloat.ForeColor = Color.White
        mochaFloat.Location = New Point(318, 71)
        mochaFloat.Margin = New Padding(5, 6, 5, 6)
        mochaFloat.Name = "mochaFloat"
        mochaFloat.Size = New Size(220, 190)
        mochaFloat.TabIndex = 4
        mochaFloat.Text = "Dark Mocha Float"
        mochaFloat.UseVisualStyleBackColor = False
        ' 
        ' cofCaramelFloat
        ' 
        cofCaramelFloat.BackColor = Color.Black
        cofCaramelFloat.FlatStyle = FlatStyle.Flat
        cofCaramelFloat.ForeColor = Color.White
        cofCaramelFloat.Location = New Point(43, 71)
        cofCaramelFloat.Margin = New Padding(5, 6, 5, 6)
        cofCaramelFloat.Name = "cofCaramelFloat"
        cofCaramelFloat.Size = New Size(220, 190)
        cofCaramelFloat.TabIndex = 3
        cofCaramelFloat.Text = "Coffee Caramel Float"
        cofCaramelFloat.UseVisualStyleBackColor = False
        ' 
        ' candyTab
        ' 
        candyTab.Controls.Add(blueOceanFloat)
        candyTab.Location = New Point(4, 34)
        candyTab.Margin = New Padding(5, 6, 5, 6)
        candyTab.Name = "candyTab"
        candyTab.Padding = New Padding(5, 6, 5, 6)
        candyTab.Size = New Size(940, 596)
        candyTab.TabIndex = 2
        candyTab.Text = "Candy"
        candyTab.UseVisualStyleBackColor = True
        ' 
        ' blueOceanFloat
        ' 
        blueOceanFloat.BackColor = Color.Black
        blueOceanFloat.FlatStyle = FlatStyle.Flat
        blueOceanFloat.ForeColor = Color.White
        blueOceanFloat.Location = New Point(43, 71)
        blueOceanFloat.Margin = New Padding(5, 6, 5, 6)
        blueOceanFloat.Name = "blueOceanFloat"
        blueOceanFloat.Size = New Size(220, 190)
        blueOceanFloat.TabIndex = 4
        blueOceanFloat.Text = "Ocean Float"
        blueOceanFloat.UseVisualStyleBackColor = False
        ' 
        ' ItemNamelbl
        ' 
        ItemNamelbl.AutoSize = True
        ItemNamelbl.BackColor = Color.Black
        ItemNamelbl.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ItemNamelbl.ForeColor = Color.White
        ItemNamelbl.Location = New Point(1117, 223)
        ItemNamelbl.Margin = New Padding(5, 0, 5, 0)
        ItemNamelbl.Name = "ItemNamelbl"
        ItemNamelbl.Size = New Size(99, 20)
        ItemNamelbl.TabIndex = 3
        ItemNamelbl.Text = "Item Name"
        ' 
        ' quantityLabel
        ' 
        quantityLabel.AutoSize = True
        quantityLabel.BackColor = Color.Black
        quantityLabel.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        quantityLabel.ForeColor = Color.White
        quantityLabel.Location = New Point(1292, 223)
        quantityLabel.Margin = New Padding(5, 0, 5, 0)
        quantityLabel.Name = "quantityLabel"
        quantityLabel.Size = New Size(79, 20)
        quantityLabel.TabIndex = 4
        quantityLabel.Text = "Quantity"
        ' 
        ' sizeLabel
        ' 
        sizeLabel.AutoSize = True
        sizeLabel.BackColor = Color.Black
        sizeLabel.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        sizeLabel.ForeColor = Color.White
        sizeLabel.Location = New Point(1452, 223)
        sizeLabel.Margin = New Padding(5, 0, 5, 0)
        sizeLabel.Name = "sizeLabel"
        sizeLabel.Size = New Size(46, 20)
        sizeLabel.TabIndex = 5
        sizeLabel.Text = "Size"
        ' 
        ' priceLabel
        ' 
        priceLabel.AutoSize = True
        priceLabel.BackColor = Color.Black
        priceLabel.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        priceLabel.ForeColor = Color.White
        priceLabel.Location = New Point(1575, 223)
        priceLabel.Margin = New Padding(5, 0, 5, 0)
        priceLabel.Name = "priceLabel"
        priceLabel.Size = New Size(53, 20)
        priceLabel.TabIndex = 6
        priceLabel.Text = "Price"
        ' 
        ' sizeLbl
        ' 
        sizeLbl.AutoSize = True
        sizeLbl.BackColor = Color.Black
        sizeLbl.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        sizeLbl.ForeColor = Color.White
        sizeLbl.Location = New Point(70, 885)
        sizeLbl.Margin = New Padding(5, 0, 5, 0)
        sizeLbl.Name = "sizeLbl"
        sizeLbl.Size = New Size(46, 20)
        sizeLbl.TabIndex = 7
        sizeLbl.Text = "Size"
        ' 
        ' itemQuantityLbl
        ' 
        itemQuantityLbl.AutoSize = True
        itemQuantityLbl.BackColor = Color.Black
        itemQuantityLbl.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        itemQuantityLbl.ForeColor = Color.White
        itemQuantityLbl.Location = New Point(864, 883)
        itemQuantityLbl.Margin = New Padding(5, 0, 5, 0)
        itemQuantityLbl.Name = "itemQuantityLbl"
        itemQuantityLbl.Size = New Size(85, 22)
        itemQuantityLbl.TabIndex = 8
        itemQuantityLbl.Text = "Quantity"
        ' 
        ' addButt
        ' 
        addButt.BackColor = Color.Black
        addButt.FlatStyle = FlatStyle.Flat
        addButt.ForeColor = Color.White
        addButt.Location = New Point(951, 925)
        addButt.Margin = New Padding(5, 6, 5, 6)
        addButt.Name = "addButt"
        addButt.Size = New Size(38, 44)
        addButt.TabIndex = 9
        addButt.Text = "+"
        addButt.UseVisualStyleBackColor = False
        ' 
        ' minusButt
        ' 
        minusButt.BackColor = Color.Black
        minusButt.FlatStyle = FlatStyle.Flat
        minusButt.ForeColor = Color.White
        minusButt.Location = New Point(842, 925)
        minusButt.Margin = New Padding(5, 6, 5, 6)
        minusButt.Name = "minusButt"
        minusButt.Size = New Size(38, 44)
        minusButt.TabIndex = 10
        minusButt.Text = "-"
        minusButt.UseVisualStyleBackColor = False
        ' 
        ' itemQuantity
        ' 
        itemQuantity.AutoSize = True
        itemQuantity.BackColor = Color.Black
        itemQuantity.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        itemQuantity.ForeColor = Color.White
        itemQuantity.Location = New Point(899, 925)
        itemQuantity.Margin = New Padding(5, 0, 5, 0)
        itemQuantity.Name = "itemQuantity"
        itemQuantity.Size = New Size(32, 33)
        itemQuantity.TabIndex = 11
        itemQuantity.Text = "1"
        ' 
        ' largeSizeButt
        ' 
        largeSizeButt.BackColor = Color.Black
        largeSizeButt.FlatStyle = FlatStyle.Flat
        largeSizeButt.ForeColor = Color.White
        largeSizeButt.Location = New Point(263, 925)
        largeSizeButt.Margin = New Padding(5, 6, 5, 6)
        largeSizeButt.Name = "largeSizeButt"
        largeSizeButt.Size = New Size(152, 44)
        largeSizeButt.TabIndex = 12
        largeSizeButt.Text = "Large"
        largeSizeButt.UseVisualStyleBackColor = False
        ' 
        ' mediumSizeButt
        ' 
        mediumSizeButt.BackColor = Color.Black
        mediumSizeButt.FlatStyle = FlatStyle.Flat
        mediumSizeButt.ForeColor = Color.White
        mediumSizeButt.Location = New Point(70, 925)
        mediumSizeButt.Margin = New Padding(5, 6, 5, 6)
        mediumSizeButt.Name = "mediumSizeButt"
        mediumSizeButt.Size = New Size(152, 44)
        mediumSizeButt.TabIndex = 13
        mediumSizeButt.Text = "Regular"
        mediumSizeButt.UseVisualStyleBackColor = False
        ' 
        ' totalLbl
        ' 
        totalLbl.AutoSize = True
        totalLbl.BackColor = Color.Black
        totalLbl.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        totalLbl.ForeColor = Color.White
        totalLbl.Location = New Point(1341, 878)
        totalLbl.Margin = New Padding(5, 0, 5, 0)
        totalLbl.Name = "totalLbl"
        totalLbl.Size = New Size(148, 29)
        totalLbl.TabIndex = 14
        totalLbl.Text = "Total Price:"
        ' 
        ' removeButt
        ' 
        removeButt.BackColor = Color.Black
        removeButt.FlatStyle = FlatStyle.Flat
        removeButt.ForeColor = Color.White
        removeButt.Location = New Point(1108, 925)
        removeButt.Margin = New Padding(5, 6, 5, 6)
        removeButt.Name = "removeButt"
        removeButt.Size = New Size(152, 44)
        removeButt.TabIndex = 15
        removeButt.Text = "Remove Item"
        removeButt.UseVisualStyleBackColor = False
        ' 
        ' clearButt
        ' 
        clearButt.BackColor = Color.Black
        clearButt.FlatStyle = FlatStyle.Flat
        clearButt.ForeColor = Color.White
        clearButt.Location = New Point(1122, 1081)
        clearButt.Margin = New Padding(5, 6, 5, 6)
        clearButt.Name = "clearButt"
        clearButt.Size = New Size(152, 44)
        clearButt.TabIndex = 16
        clearButt.Text = "Clear Order"
        clearButt.UseVisualStyleBackColor = False
        ' 
        ' compButt
        ' 
        compButt.BackColor = Color.Black
        compButt.FlatStyle = FlatStyle.Flat
        compButt.ForeColor = Color.White
        compButt.Location = New Point(1467, 925)
        compButt.Margin = New Padding(5, 6, 5, 6)
        compButt.Name = "compButt"
        compButt.Size = New Size(152, 44)
        compButt.TabIndex = 17
        compButt.Text = "Complete Order"
        compButt.UseVisualStyleBackColor = False
        ' 
        ' totalPriceLbl
        ' 
        totalPriceLbl.AutoSize = True
        totalPriceLbl.BackColor = Color.Black
        totalPriceLbl.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        totalPriceLbl.ForeColor = Color.White
        totalPriceLbl.Location = New Point(1499, 876)
        totalPriceLbl.Margin = New Padding(5, 0, 5, 0)
        totalPriceLbl.Name = "totalPriceLbl"
        totalPriceLbl.Size = New Size(27, 29)
        totalPriceLbl.TabIndex = 18
        totalPriceLbl.Text = "0"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.floatsIcon
        PictureBox1.Location = New Point(555, 0)
        PictureBox1.Margin = New Padding(5, 6, 5, 6)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(640, 162)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' backButt
        ' 
        backButt.AutoSize = True
        backButt.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        backButt.ForeColor = Color.White
        backButt.Location = New Point(65, 52)
        backButt.Margin = New Padding(5, 0, 5, 0)
        backButt.Name = "backButt"
        backButt.Size = New Size(79, 25)
        backButt.TabIndex = 19
        backButt.Text = "< Back"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.GridColor = SystemColors.Menu
        DataGridView1.Location = New Point(1108, 257)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(511, 595)
        DataGridView1.TabIndex = 20
        ' 
        ' selectedSize
        ' 
        selectedSize.AutoSize = True
        selectedSize.BackColor = Color.Black
        selectedSize.Font = New Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        selectedSize.ForeColor = Color.White
        selectedSize.Location = New Point(147, 880)
        selectedSize.Margin = New Padding(5, 0, 5, 0)
        selectedSize.Name = "selectedSize"
        selectedSize.Size = New Size(95, 26)
        selectedSize.TabIndex = 21
        selectedSize.Text = "Regular"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(1667, 1002)
        Controls.Add(selectedSize)
        Controls.Add(DataGridView1)
        Controls.Add(backButt)
        Controls.Add(totalPriceLbl)
        Controls.Add(compButt)
        Controls.Add(clearButt)
        Controls.Add(removeButt)
        Controls.Add(totalLbl)
        Controls.Add(mediumSizeButt)
        Controls.Add(largeSizeButt)
        Controls.Add(itemQuantity)
        Controls.Add(minusButt)
        Controls.Add(addButt)
        Controls.Add(itemQuantityLbl)
        Controls.Add(sizeLbl)
        Controls.Add(priceLabel)
        Controls.Add(sizeLabel)
        Controls.Add(quantityLabel)
        Controls.Add(ItemNamelbl)
        Controls.Add(TabControl1)
        Controls.Add(PictureBox1)
        Margin = New Padding(5, 6, 5, 6)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        TabControl1.ResumeLayout(False)
        classicTab.ResumeLayout(False)
        caffeineTab.ResumeLayout(False)
        candyTab.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents classicTab As TabPage
    Friend WithEvents caffeineTab As TabPage
    Friend WithEvents candyTab As TabPage
    Friend WithEvents ItemNamelbl As Label
    Friend WithEvents quantityLabel As Label
    Friend WithEvents sizeLabel As Label
    Friend WithEvents priceLabel As Label
    Friend WithEvents sizeLbl As Label
    Friend WithEvents itemQuantityLbl As Label
    Friend WithEvents addButt As Button
    Friend WithEvents minusButt As Button
    Friend WithEvents itemQuantity As Label
    Friend WithEvents largeSizeButt As Button
    Friend WithEvents mediumSizeButt As Button
    Friend WithEvents totalLbl As Label
    Friend WithEvents removeButt As Button
    Friend WithEvents clearButt As Button
    Friend WithEvents compButt As Button
    Friend WithEvents totalPriceLbl As Label
    Friend WithEvents cokeFloat As Button
    Friend WithEvents rootBFloat As Button
    Friend WithEvents spriteFloat As Button
    Friend WithEvents mochaFloat As Button
    Friend WithEvents cofCaramelFloat As Button
    Friend WithEvents blueOceanFloat As Button
    Friend WithEvents backButt As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents selectedSize As Label
End Class
