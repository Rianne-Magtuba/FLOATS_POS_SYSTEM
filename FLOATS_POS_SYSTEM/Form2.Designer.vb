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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.classicTab = New System.Windows.Forms.TabPage()
        Me.caffeineTab = New System.Windows.Forms.TabPage()
        Me.candyTab = New System.Windows.Forms.TabPage()
        Me.listOfItemOrder = New System.Windows.Forms.ListBox()
        Me.ItemNamelbl = New System.Windows.Forms.Label()
        Me.quantityLabel = New System.Windows.Forms.Label()
        Me.sizeLabel = New System.Windows.Forms.Label()
        Me.priceLabel = New System.Windows.Forms.Label()
        Me.sizeLbl = New System.Windows.Forms.Label()
        Me.itemQuantityLbl = New System.Windows.Forms.Label()
        Me.addButt = New System.Windows.Forms.Button()
        Me.minusButt = New System.Windows.Forms.Button()
        Me.itemQuantity = New System.Windows.Forms.Label()
        Me.largeSizeButt = New System.Windows.Forms.Button()
        Me.mediumSizeButt = New System.Windows.Forms.Button()
        Me.totalLbl = New System.Windows.Forms.Label()
        Me.removeButt = New System.Windows.Forms.Button()
        Me.clearButt = New System.Windows.Forms.Button()
        Me.compButt = New System.Windows.Forms.Button()
        Me.totalPriceLbl = New System.Windows.Forms.Label()
        Me.cokeFloat = New System.Windows.Forms.Button()
        Me.spriteFloat = New System.Windows.Forms.Button()
        Me.rootBFloat = New System.Windows.Forms.Button()
        Me.mochaFloat = New System.Windows.Forms.Button()
        Me.cofFloat = New System.Windows.Forms.Button()
        Me.blueOceanFloat = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.backButt = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.classicTab.SuspendLayout()
        Me.caffeineTab.SuspendLayout()
        Me.candyTab.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.classicTab)
        Me.TabControl1.Controls.Add(Me.caffeineTab)
        Me.TabControl1.Controls.Add(Me.candyTab)
        Me.TabControl1.Location = New System.Drawing.Point(42, 148)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(569, 362)
        Me.TabControl1.TabIndex = 1
        '
        'classicTab
        '
        Me.classicTab.Controls.Add(Me.rootBFloat)
        Me.classicTab.Controls.Add(Me.spriteFloat)
        Me.classicTab.Controls.Add(Me.cokeFloat)
        Me.classicTab.Location = New System.Drawing.Point(4, 22)
        Me.classicTab.Name = "classicTab"
        Me.classicTab.Padding = New System.Windows.Forms.Padding(3)
        Me.classicTab.Size = New System.Drawing.Size(561, 336)
        Me.classicTab.TabIndex = 0
        Me.classicTab.Text = "Classic"
        Me.classicTab.UseVisualStyleBackColor = True
        '
        'caffeineTab
        '
        Me.caffeineTab.Controls.Add(Me.mochaFloat)
        Me.caffeineTab.Controls.Add(Me.cofFloat)
        Me.caffeineTab.Location = New System.Drawing.Point(4, 22)
        Me.caffeineTab.Name = "caffeineTab"
        Me.caffeineTab.Padding = New System.Windows.Forms.Padding(3)
        Me.caffeineTab.Size = New System.Drawing.Size(561, 336)
        Me.caffeineTab.TabIndex = 1
        Me.caffeineTab.Text = "Caffeine"
        Me.caffeineTab.UseVisualStyleBackColor = True
        '
        'candyTab
        '
        Me.candyTab.Controls.Add(Me.blueOceanFloat)
        Me.candyTab.Location = New System.Drawing.Point(4, 22)
        Me.candyTab.Name = "candyTab"
        Me.candyTab.Padding = New System.Windows.Forms.Padding(3)
        Me.candyTab.Size = New System.Drawing.Size(561, 336)
        Me.candyTab.TabIndex = 2
        Me.candyTab.Text = "Candy"
        Me.candyTab.UseVisualStyleBackColor = True
        '
        'listOfItemOrder
        '
        Me.listOfItemOrder.Location = New System.Drawing.Point(673, 170)
        Me.listOfItemOrder.Name = "listOfItemOrder"
        Me.listOfItemOrder.Size = New System.Drawing.Size(308, 342)
        Me.listOfItemOrder.TabIndex = 2
        '
        'ItemNamelbl
        '
        Me.ItemNamelbl.AutoSize = True
        Me.ItemNamelbl.BackColor = System.Drawing.Color.Black
        Me.ItemNamelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemNamelbl.ForeColor = System.Drawing.Color.White
        Me.ItemNamelbl.Location = New System.Drawing.Point(670, 154)
        Me.ItemNamelbl.Name = "ItemNamelbl"
        Me.ItemNamelbl.Size = New System.Drawing.Size(67, 13)
        Me.ItemNamelbl.TabIndex = 3
        Me.ItemNamelbl.Text = "Item Name"
        '
        'quantityLabel
        '
        Me.quantityLabel.AutoSize = True
        Me.quantityLabel.BackColor = System.Drawing.Color.Black
        Me.quantityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quantityLabel.ForeColor = System.Drawing.Color.White
        Me.quantityLabel.Location = New System.Drawing.Point(775, 154)
        Me.quantityLabel.Name = "quantityLabel"
        Me.quantityLabel.Size = New System.Drawing.Size(54, 13)
        Me.quantityLabel.TabIndex = 4
        Me.quantityLabel.Text = "Quantity"
        '
        'sizeLabel
        '
        Me.sizeLabel.AutoSize = True
        Me.sizeLabel.BackColor = System.Drawing.Color.Black
        Me.sizeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sizeLabel.ForeColor = System.Drawing.Color.White
        Me.sizeLabel.Location = New System.Drawing.Point(871, 154)
        Me.sizeLabel.Name = "sizeLabel"
        Me.sizeLabel.Size = New System.Drawing.Size(31, 13)
        Me.sizeLabel.TabIndex = 5
        Me.sizeLabel.Text = "Size"
        '
        'priceLabel
        '
        Me.priceLabel.AutoSize = True
        Me.priceLabel.BackColor = System.Drawing.Color.Black
        Me.priceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.priceLabel.ForeColor = System.Drawing.Color.White
        Me.priceLabel.Location = New System.Drawing.Point(945, 154)
        Me.priceLabel.Name = "priceLabel"
        Me.priceLabel.Size = New System.Drawing.Size(36, 13)
        Me.priceLabel.TabIndex = 6
        Me.priceLabel.Text = "Price"
        '
        'sizeLbl
        '
        Me.sizeLbl.AutoSize = True
        Me.sizeLbl.BackColor = System.Drawing.Color.Black
        Me.sizeLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sizeLbl.ForeColor = System.Drawing.Color.White
        Me.sizeLbl.Location = New System.Drawing.Point(39, 517)
        Me.sizeLbl.Name = "sizeLbl"
        Me.sizeLbl.Size = New System.Drawing.Size(31, 13)
        Me.sizeLbl.TabIndex = 7
        Me.sizeLbl.Text = "Size"
        '
        'itemQuantityLbl
        '
        Me.itemQuantityLbl.AutoSize = True
        Me.itemQuantityLbl.BackColor = System.Drawing.Color.Black
        Me.itemQuantityLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemQuantityLbl.ForeColor = System.Drawing.Color.White
        Me.itemQuantityLbl.Location = New System.Drawing.Point(527, 511)
        Me.itemQuantityLbl.Name = "itemQuantityLbl"
        Me.itemQuantityLbl.Size = New System.Drawing.Size(59, 15)
        Me.itemQuantityLbl.TabIndex = 8
        Me.itemQuantityLbl.Text = "Quantity"
        '
        'addButt
        '
        Me.addButt.BackColor = System.Drawing.Color.Black
        Me.addButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addButt.ForeColor = System.Drawing.Color.White
        Me.addButt.Location = New System.Drawing.Point(508, 533)
        Me.addButt.Name = "addButt"
        Me.addButt.Size = New System.Drawing.Size(23, 23)
        Me.addButt.TabIndex = 9
        Me.addButt.Text = "+"
        Me.addButt.UseVisualStyleBackColor = False
        '
        'minusButt
        '
        Me.minusButt.BackColor = System.Drawing.Color.Black
        Me.minusButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.minusButt.ForeColor = System.Drawing.Color.White
        Me.minusButt.Location = New System.Drawing.Point(584, 533)
        Me.minusButt.Name = "minusButt"
        Me.minusButt.Size = New System.Drawing.Size(23, 23)
        Me.minusButt.TabIndex = 10
        Me.minusButt.Text = "-"
        Me.minusButt.UseVisualStyleBackColor = False
        '
        'itemQuantity
        '
        Me.itemQuantity.AutoSize = True
        Me.itemQuantity.BackColor = System.Drawing.Color.Black
        Me.itemQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemQuantity.ForeColor = System.Drawing.Color.White
        Me.itemQuantity.Location = New System.Drawing.Point(548, 533)
        Me.itemQuantity.Name = "itemQuantity"
        Me.itemQuantity.Size = New System.Drawing.Size(21, 24)
        Me.itemQuantity.TabIndex = 11
        Me.itemQuantity.Text = "0"
        '
        'largeSizeButt
        '
        Me.largeSizeButt.BackColor = System.Drawing.Color.Black
        Me.largeSizeButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.largeSizeButt.ForeColor = System.Drawing.Color.White
        Me.largeSizeButt.Location = New System.Drawing.Point(42, 533)
        Me.largeSizeButt.Name = "largeSizeButt"
        Me.largeSizeButt.Size = New System.Drawing.Size(91, 23)
        Me.largeSizeButt.TabIndex = 12
        Me.largeSizeButt.Text = "Large"
        Me.largeSizeButt.UseVisualStyleBackColor = False
        '
        'mediumSizeButt
        '
        Me.mediumSizeButt.BackColor = System.Drawing.Color.Black
        Me.mediumSizeButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mediumSizeButt.ForeColor = System.Drawing.Color.White
        Me.mediumSizeButt.Location = New System.Drawing.Point(148, 533)
        Me.mediumSizeButt.Name = "mediumSizeButt"
        Me.mediumSizeButt.Size = New System.Drawing.Size(91, 23)
        Me.mediumSizeButt.TabIndex = 13
        Me.mediumSizeButt.Text = "Medium"
        Me.mediumSizeButt.UseVisualStyleBackColor = False
        '
        'totalLbl
        '
        Me.totalLbl.AutoSize = True
        Me.totalLbl.BackColor = System.Drawing.Color.Black
        Me.totalLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalLbl.ForeColor = System.Drawing.Color.White
        Me.totalLbl.Location = New System.Drawing.Point(670, 515)
        Me.totalLbl.Name = "totalLbl"
        Me.totalLbl.Size = New System.Drawing.Size(73, 13)
        Me.totalLbl.TabIndex = 14
        Me.totalLbl.Text = "Total Price:"
        '
        'removeButt
        '
        Me.removeButt.BackColor = System.Drawing.Color.Black
        Me.removeButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.removeButt.ForeColor = System.Drawing.Color.White
        Me.removeButt.Location = New System.Drawing.Point(673, 533)
        Me.removeButt.Name = "removeButt"
        Me.removeButt.Size = New System.Drawing.Size(91, 23)
        Me.removeButt.TabIndex = 15
        Me.removeButt.Text = "Remove Item"
        Me.removeButt.UseVisualStyleBackColor = False
        '
        'clearButt
        '
        Me.clearButt.BackColor = System.Drawing.Color.Black
        Me.clearButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clearButt.ForeColor = System.Drawing.Color.White
        Me.clearButt.Location = New System.Drawing.Point(673, 562)
        Me.clearButt.Name = "clearButt"
        Me.clearButt.Size = New System.Drawing.Size(91, 23)
        Me.clearButt.TabIndex = 16
        Me.clearButt.Text = "Clear Order"
        Me.clearButt.UseVisualStyleBackColor = False
        '
        'compButt
        '
        Me.compButt.BackColor = System.Drawing.Color.Black
        Me.compButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.compButt.ForeColor = System.Drawing.Color.White
        Me.compButt.Location = New System.Drawing.Point(890, 533)
        Me.compButt.Name = "compButt"
        Me.compButt.Size = New System.Drawing.Size(91, 23)
        Me.compButt.TabIndex = 17
        Me.compButt.Text = "Complete Order"
        Me.compButt.UseVisualStyleBackColor = False
        '
        'totalPriceLbl
        '
        Me.totalPriceLbl.AutoSize = True
        Me.totalPriceLbl.BackColor = System.Drawing.Color.Black
        Me.totalPriceLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalPriceLbl.ForeColor = System.Drawing.Color.White
        Me.totalPriceLbl.Location = New System.Drawing.Point(967, 517)
        Me.totalPriceLbl.Name = "totalPriceLbl"
        Me.totalPriceLbl.Size = New System.Drawing.Size(14, 13)
        Me.totalPriceLbl.TabIndex = 18
        Me.totalPriceLbl.Text = "0"
        '
        'cokeFloat
        '
        Me.cokeFloat.BackColor = System.Drawing.Color.Black
        Me.cokeFloat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cokeFloat.ForeColor = System.Drawing.Color.White
        Me.cokeFloat.Location = New System.Drawing.Point(26, 37)
        Me.cokeFloat.Name = "cokeFloat"
        Me.cokeFloat.Size = New System.Drawing.Size(132, 99)
        Me.cokeFloat.TabIndex = 0
        Me.cokeFloat.Text = "Coke Float"
        Me.cokeFloat.UseVisualStyleBackColor = False
        '
        'spriteFloat
        '
        Me.spriteFloat.BackColor = System.Drawing.Color.Black
        Me.spriteFloat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.spriteFloat.ForeColor = System.Drawing.Color.White
        Me.spriteFloat.Location = New System.Drawing.Point(191, 37)
        Me.spriteFloat.Name = "spriteFloat"
        Me.spriteFloat.Size = New System.Drawing.Size(132, 99)
        Me.spriteFloat.TabIndex = 1
        Me.spriteFloat.Text = "Sprite Float"
        Me.spriteFloat.UseVisualStyleBackColor = False
        '
        'rootBFloat
        '
        Me.rootBFloat.BackColor = System.Drawing.Color.Black
        Me.rootBFloat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rootBFloat.ForeColor = System.Drawing.Color.White
        Me.rootBFloat.Location = New System.Drawing.Point(353, 37)
        Me.rootBFloat.Name = "rootBFloat"
        Me.rootBFloat.Size = New System.Drawing.Size(132, 99)
        Me.rootBFloat.TabIndex = 2
        Me.rootBFloat.Text = "Rootbeer Float"
        Me.rootBFloat.UseVisualStyleBackColor = False
        '
        'mochaFloat
        '
        Me.mochaFloat.BackColor = System.Drawing.Color.Black
        Me.mochaFloat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mochaFloat.ForeColor = System.Drawing.Color.White
        Me.mochaFloat.Location = New System.Drawing.Point(191, 37)
        Me.mochaFloat.Name = "mochaFloat"
        Me.mochaFloat.Size = New System.Drawing.Size(132, 99)
        Me.mochaFloat.TabIndex = 4
        Me.mochaFloat.Text = "Mocha Float"
        Me.mochaFloat.UseVisualStyleBackColor = False
        '
        'cofFloat
        '
        Me.cofFloat.BackColor = System.Drawing.Color.Black
        Me.cofFloat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cofFloat.ForeColor = System.Drawing.Color.White
        Me.cofFloat.Location = New System.Drawing.Point(26, 37)
        Me.cofFloat.Name = "cofFloat"
        Me.cofFloat.Size = New System.Drawing.Size(132, 99)
        Me.cofFloat.TabIndex = 3
        Me.cofFloat.Text = "Coffee Float"
        Me.cofFloat.UseVisualStyleBackColor = False
        '
        'blueOceanFloat
        '
        Me.blueOceanFloat.BackColor = System.Drawing.Color.Black
        Me.blueOceanFloat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.blueOceanFloat.ForeColor = System.Drawing.Color.White
        Me.blueOceanFloat.Location = New System.Drawing.Point(26, 37)
        Me.blueOceanFloat.Name = "blueOceanFloat"
        Me.blueOceanFloat.Size = New System.Drawing.Size(132, 99)
        Me.blueOceanFloat.TabIndex = 4
        Me.blueOceanFloat.Text = "Blue Ocean Float"
        Me.blueOceanFloat.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FLOATS_POS_SYSTEM.My.Resources.Resources.floatsIcon
        Me.PictureBox1.Location = New System.Drawing.Point(333, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(384, 127)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'backButt
        '
        Me.backButt.AutoSize = True
        Me.backButt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backButt.ForeColor = System.Drawing.Color.White
        Me.backButt.Location = New System.Drawing.Point(39, 27)
        Me.backButt.Name = "backButt"
        Me.backButt.Size = New System.Drawing.Size(58, 16)
        Me.backButt.TabIndex = 19
        Me.backButt.Text = "< Back"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1040, 626)
        Me.Controls.Add(Me.backButt)
        Me.Controls.Add(Me.totalPriceLbl)
        Me.Controls.Add(Me.compButt)
        Me.Controls.Add(Me.clearButt)
        Me.Controls.Add(Me.removeButt)
        Me.Controls.Add(Me.totalLbl)
        Me.Controls.Add(Me.mediumSizeButt)
        Me.Controls.Add(Me.largeSizeButt)
        Me.Controls.Add(Me.itemQuantity)
        Me.Controls.Add(Me.minusButt)
        Me.Controls.Add(Me.addButt)
        Me.Controls.Add(Me.itemQuantityLbl)
        Me.Controls.Add(Me.sizeLbl)
        Me.Controls.Add(Me.priceLabel)
        Me.Controls.Add(Me.sizeLabel)
        Me.Controls.Add(Me.quantityLabel)
        Me.Controls.Add(Me.ItemNamelbl)
        Me.Controls.Add(Me.listOfItemOrder)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.classicTab.ResumeLayout(False)
        Me.caffeineTab.ResumeLayout(False)
        Me.candyTab.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents classicTab As TabPage
    Friend WithEvents caffeineTab As TabPage
    Friend WithEvents candyTab As TabPage
    Friend WithEvents listOfItemOrder As ListBox
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
    Friend WithEvents cofFloat As Button
    Friend WithEvents blueOceanFloat As Button
    Friend WithEvents backButt As Label
End Class
