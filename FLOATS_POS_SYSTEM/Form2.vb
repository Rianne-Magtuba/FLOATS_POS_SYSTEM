Imports System.Data.SqlClient
Imports System.Net.Quic
Public Class Form2
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setupDataGridView()

    End Sub
    Dim connectionString As String = "Data Source=DESKTOP-OJ35B1P\SQLEXPRESS;Initial Catalog=FLOATS_POS_SYSTEM;Integrated Security=True"
    Private Sub setupDataGridView()
        ' Clear any existing columns/rows
        DataGridView1.Columns.Clear()
        DataGridView1.Rows.Clear()


        With DataGridView1
            .BackgroundColor = Color.White
            .EnableHeadersVisualStyles = False
            .ColumnHeadersDefaultCellStyle.BackColor = Color.White
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
            .RowHeadersVisible = False
            .AllowUserToAddRows = False
            .AllowUserToResizeRows = False
            .AllowUserToResizeColumns = False
            .GridColor = Color.Black
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .DefaultCellStyle.BackColor = Color.White
            .DefaultCellStyle.ForeColor = Color.Black
            .DefaultCellStyle.SelectionBackColor = Color.LightGray
            .DefaultCellStyle.SelectionForeColor = Color.Black
        End With

        ' Add Columns
        Dim colProductId As New DataGridViewTextBoxColumn()
        colProductId.Name = "productId"
        colProductId.HeaderText = "Product ID"
        colProductId.Visible = False

        Dim colProductName As New DataGridViewTextBoxColumn()
        colProductName.Name = "productName"
        colProductName.HeaderText = "Product Name"
        colProductName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        Dim colQuantity As New DataGridViewTextBoxColumn()
        colQuantity.Name = "quantity"
        colQuantity.HeaderText = "Quantity"
        colQuantity.Width = 80

        Dim colSize As New DataGridViewTextBoxColumn()
        colSize.Name = "size"
        colSize.HeaderText = "Size"
        colSize.Width = 80

        Dim colPrice As New DataGridViewTextBoxColumn()
        colPrice.Name = "price"
        colPrice.HeaderText = "Price"
        colPrice.Width = 80

        ' Add the columns to the DataGridView
        With DataGridView1.Columns
            .Add(colProductId)
            .Add(colProductName)
            .Add(colQuantity)
            .Add(colSize)
            .Add(colPrice)
        End With

        ' Add default row
        DataGridView1.Rows.Add("", "Please order items", "", "", "")
    End Sub


    Private Sub addProductToDataGridView(baseProductId As Integer, pSize As String, qty As Integer)
        ' Derive actual productId based on size
        Dim actualProductId As Integer = If(pSize = "Regular", baseProductId, baseProductId + 1)

        ' SQL query to fetch product data
        Dim query As String = "SELECT product_name, product_price FROM product_table WHERE product_id = @productId"

        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@productId", actualProductId)

                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim productName As String = reader("product_name").ToString()
                            Dim unitPrice As Decimal = Convert.ToDecimal(reader("product_price"))

                            ' ✅ Check if this exact product (by productId and size) already exists
                            Dim foundRowIndex As Integer = -1

                            For i As Integer = 0 To DataGridView1.Rows.Count - 1
                                Dim rowIdObj = DataGridView1.Rows(i).Cells("productId").Value
                                Dim rowSizeObj = DataGridView1.Rows(i).Cells("size").Value

                                If rowIdObj IsNot Nothing AndAlso rowSizeObj IsNot Nothing Then
                                    Dim rowId As Integer
                                    If Integer.TryParse(rowIdObj.ToString(), rowId) Then
                                        If rowId = actualProductId AndAlso rowSizeObj.ToString() = pSize Then
                                            foundRowIndex = i
                                            Exit For
                                        End If
                                    End If
                                End If
                            Next

                            ' Remove placeholder row if it's still there
                            If DataGridView1.Rows.Count = 1 AndAlso DataGridView1.Rows(0).Cells("productName").Value.ToString() = "Please order items" Then
                                DataGridView1.Rows.Clear()
                            End If

                            If foundRowIndex <> -1 Then
                                ' ✅ Add to existing quantity and update total price
                                Dim currentQty As Integer = Convert.ToInt32(DataGridView1.Rows(foundRowIndex).Cells("quantity").Value)
                                Dim newQty As Integer = currentQty + qty
                                Dim newTotalPrice As Decimal = unitPrice * newQty

                                DataGridView1.Rows(foundRowIndex).Cells("quantity").Value = newQty
                                DataGridView1.Rows(foundRowIndex).Cells("price").Value = Format(newTotalPrice, "0.00")
                            Else
                                ' ✅ Add new row
                                Dim totalPrice As Decimal = unitPrice * qty
                                DataGridView1.Rows.Add(actualProductId, productName, qty, pSize, Format(totalPrice, "0.00"))
                            End If
                        Else
                            MessageBox.Show("Product not found in database.", "Product Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub





    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_2(sender As Object, e As EventArgs) Handles quantityLabel.Click

    End Sub

    Private Sub Label1_Click_3(sender As Object, e As EventArgs) Handles totalPriceLbl.Click

    End Sub


    Private Sub UpdateTotal()
        Dim total As Decimal = 0

        ' Loop through each row in the DataGridView
        For Each row As DataGridViewRow In DataGridView1.Rows
            ' Skip new row placeholder if it exists
            If Not row.IsNewRow Then
                ' Try to read and sum the "totalPrice" cell
                Dim cellValue As Object = row.Cells("Price").Value
                If cellValue IsNot Nothing AndAlso IsNumeric(cellValue) Then
                    total += Convert.ToDecimal(cellValue)
                End If
            End If
        Next

        ' Update the label
        totalPriceLbl.Text = "₱" & total.ToString("N2") ' Formats with 2 decimal places and peso sign
    End Sub

    Private Sub addButt_Click(sender As Object, e As EventArgs) Handles addButt.Click

        Dim qty As Integer = CInt(itemQuantity.Text)
        qty = qty + 1
        itemQuantity.Text = qty.ToString()
    End Sub

    Private Sub minusButt_Click(sender As Object, e As EventArgs) Handles minusButt.Click
        Dim qty As Integer = CInt(itemQuantity.Text)
        If qty <> 1 Then
            qty = qty - 1
            itemQuantity.Text = qty.ToString()
        End If
    End Sub

    Private Sub mediumSizeButt_Click(sender As Object, e As EventArgs) Handles mediumSizeButt.Click
        selectedSize.Text = "Regular"
    End Sub

    Private Sub largeSizeButt_Click(sender As Object, e As EventArgs) Handles largeSizeButt.Click
        selectedSize.Text = "Large"
    End Sub

    Private Sub cokeFloat_Click(sender As Object, e As EventArgs) Handles cokeFloat.Click
        Dim size As String = selectedSize.Text
        Dim qty As Integer = CInt(itemQuantity.Text)
        addProductToDataGridView(1, size, qty)
        UpdateTotal()
    End Sub

    Private Sub spriteFloat_Click(sender As Object, e As EventArgs) Handles spriteFloat.Click
        Dim size As String = selectedSize.Text
        Dim qty As Integer = CInt(itemQuantity.Text)
        addProductToDataGridView(14, size, qty)
        UpdateTotal()
    End Sub

    Private Sub rootBFloat_Click(sender As Object, e As EventArgs) Handles rootBFloat.Click
        Dim size As String = selectedSize.Text
        Dim qty As Integer = CInt(itemQuantity.Text)
        addProductToDataGridView(3, size, qty)
        UpdateTotal()
    End Sub


    Private Sub mochaFloat_Click(sender As Object, e As EventArgs) Handles mochaFloat.Click
        Dim size As String = selectedSize.Text
        Dim qty As Integer = CInt(itemQuantity.Text)
        addProductToDataGridView(16, size, qty)
        UpdateTotal()
    End Sub

    Private Sub blueOceanFloat_Click(sender As Object, e As EventArgs) Handles blueOceanFloat.Click
        Dim size As String = selectedSize.Text
        Dim qty As Integer = CInt(itemQuantity.Text)
        addProductToDataGridView(7, size, qty)
        UpdateTotal()
    End Sub

    Private Sub cofCaramelFloat_Click(sender As Object, e As EventArgs) Handles cofCaramelFloat.Click
        Dim size As String = selectedSize.Text
        Dim qty As Integer = CInt(itemQuantity.Text)
        addProductToDataGridView(20, size, qty)
        UpdateTotal()
    End Sub

    Private Sub removeButt_Click(sender As Object, e As EventArgs) Handles removeButt.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            ' Confirm deletion (optional)
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the selected row?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ' Remove the selected row
                DataGridView1.Rows.RemoveAt(DataGridView1.SelectedRows(0).Index)
                UpdateTotal()
            End If
        Else
            MessageBox.Show("Please select a row to delete.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub compButt_Click(sender As Object, e As EventArgs) Handles compButt.Click
        Using con As New SqlConnection(connectionString)
            con.Open()

            ' Begin a transaction to ensure atomicity
            Dim transaction As SqlTransaction = con.BeginTransaction()

            Try
                ' 1. Insert into order_table
                Dim insertOrderCmd As New SqlCommand("
                INSERT INTO order_table (date_ordered, total)
                VALUES (@date_ordered, @total);
                SELECT SCOPE_IDENTITY();", con, transaction)

                insertOrderCmd.Parameters.AddWithValue("@date_ordered", DateTime.Now)
                insertOrderCmd.Parameters.AddWithValue("@total", Decimal.Parse(totalPriceLbl.Text.Replace("₱", "").Trim()))

                ' Get the new order_id
                Dim newOrderId As Integer = Convert.ToInt32(insertOrderCmd.ExecuteScalar())

                ' 2. Insert into order_details_table for each item in the DataGridView
                For Each row As DataGridViewRow In DataGridView1.Rows
                    If row.IsNewRow Then Continue For

                    Dim productId = Convert.ToInt32(row.Cells("productId").Value)
                    Dim qty = Convert.ToInt32(row.Cells("quantity").Value)

                    Dim insertDetailCmd As New SqlCommand("
                    INSERT INTO order_details_table (order_id, product_id, qty)
                    VALUES (@order_id, @product_id, @qty)", con, transaction)

                    insertDetailCmd.Parameters.AddWithValue("@order_id", newOrderId)
                    insertDetailCmd.Parameters.AddWithValue("@product_id", productId)
                    insertDetailCmd.Parameters.AddWithValue("@qty", qty)

                    insertDetailCmd.ExecuteNonQuery()
                Next

                ' Commit the transaction
                transaction.Commit()
                MessageBox.Show("Order completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                DataGridView1.Rows.Clear()
            Catch ex As Exception
                ' Rollback on error
                transaction.Rollback()
                MessageBox.Show("An error occurred while completing the order: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
End Class
