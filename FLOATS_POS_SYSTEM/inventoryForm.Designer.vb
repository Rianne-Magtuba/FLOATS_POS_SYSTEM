﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class inventoryForm
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
        Me.lblFloats = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.tableOrderedDrinks = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TabPage1.SuspendLayout()
        Me.tableOrderedDrinks.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFloats
        '
        Me.lblFloats.AutoSize = True
        Me.lblFloats.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFloats.Location = New System.Drawing.Point(199, 31)
        Me.lblFloats.Name = "lblFloats"
        Me.lblFloats.Size = New System.Drawing.Size(492, 42)
        Me.lblFloats.TabIndex = 0
        Me.lblFloats.Text = "FLOATS' Inventory System"
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(776, 276)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Materials"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(776, 276)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Ingredients"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.tableOrderedDrinks)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(776, 276)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Ordered Drinks"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'tableOrderedDrinks
        '
        Me.tableOrderedDrinks.AccessibleName = ""
        Me.tableOrderedDrinks.AllowDrop = True
        Me.tableOrderedDrinks.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tableOrderedDrinks.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.tableOrderedDrinks.ColumnCount = 4
        Me.tableOrderedDrinks.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tableOrderedDrinks.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tableOrderedDrinks.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tableOrderedDrinks.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tableOrderedDrinks.Controls.Add(Me.Label1, 0, 0)
        Me.tableOrderedDrinks.Location = New System.Drawing.Point(0, 0)
        Me.tableOrderedDrinks.Name = "tableOrderedDrinks"
        Me.tableOrderedDrinks.RowCount = 2
        Me.tableOrderedDrinks.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tableOrderedDrinks.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableOrderedDrinks.Size = New System.Drawing.Size(776, 276)
        Me.tableOrderedDrinks.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Ordered Drink"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(55, 100)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(784, 302)
        Me.TabControl1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(455, 440)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(177, 35)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Sort by Date"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(658, 440)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(177, 35)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Sort by Time"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(258, 440)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(177, 35)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Sort by Name"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(55, 440)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(177, 35)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Add Data"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(897, 527)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lblFloats)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabPage1.ResumeLayout(False)
        Me.tableOrderedDrinks.ResumeLayout(False)
        Me.tableOrderedDrinks.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFloats As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tableOrderedDrinks As TableLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
End Class
