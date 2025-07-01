Imports Microsoft.Data.SqlClient

Public Class OrderDetails

    Private sortAscending As Boolean = True
    Private hasSortedOnce As Boolean = False
    Private currentTable As DataGridView

    Private Sub OrderDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        currentTable = dgvProducts
        GetAllProducts()
    End Sub

    Private Sub GetAllProducts()

        Dim connectionString As String = "Data Source=DESKTOP-FOAVQMH\SQLEXPRESS; Initial Catalog=FLOATS_POS_SYSTEM; Integrated Security=True; TrustServerCertificate=True;"

        Dim selectQuery As String = "SELECT product_id, category, item_name, size, price FROM Products"

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Using command As New SqlCommand(selectQuery, connection)
                Using reader As SqlDataReader = command.ExecuteReader()
                    dgvProducts.Rows.Clear()

                    While reader.Read()
                        dgvProducts.Rows.Add(
                            Int(reader("product_id")),
                            reader("category").ToString(),
                            reader("item_name").ToString(),
                            reader("size").ToString(),
                            (FormatCurrency(reader("price")).Replace("$", "₱ "))
                        )
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub SortAllProducts()

        Dim connectionString As String = "Data Source=DESKTOP-FOAVQMH\SQLEXPRESS; Initial Catalog=FLOATS_POS_SYSTEM; Integrated Security=True; TrustServerCertificate=True;"

        Dim selectQuery As String

        If (sortAscending) Then
            selectQuery = "SELECT product_id, category, item_name, size, price FROM Products ORDER BY product_id ASC"
        Else
            selectQuery = "SELECT product_id, category, item_name, size, price FROM Products ORDER BY product_id DESC"
        End If

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Using command As New SqlCommand(selectQuery, connection)
                Using reader As SqlDataReader = command.ExecuteReader()
                    dgvProducts.Rows.Clear()

                    While reader.Read()
                        dgvProducts.Rows.Add(
                            Int(reader("product_id")),
                            reader("category").ToString(),
                            reader("item_name").ToString(),
                            reader("size").ToString(),
                            (FormatCurrency(reader("price")).Replace("$", "₱ "))
                        )
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub GetAllOrderDetails()

        Dim connectionString As String = "Data Source=DESKTOP-FOAVQMH\SQLEXPRESS; Initial Catalog=FLOATS_POS_SYSTEM; Integrated Security=True; TrustServerCertificate=True;"

        Dim selectQuery As String = "SELECT order_id, product_id, quantity, total_price, date_ordered, time_ordered FROM OrderDetails"

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Using command As New SqlCommand(selectQuery, connection)
                Using reader As SqlDataReader = command.ExecuteReader()
                    dgvOrderDetails.Rows.Clear()

                    While reader.Read()
                        dgvOrderDetails.Rows.Add(
                            reader("order_id").ToString(),
                            reader("product_id").ToString(),
                            reader("quantity").ToString(),
                            (FormatCurrency(reader("total_price")).Replace("$", "₱ ")),
                            CDate(reader("date_ordered")).ToString("MMMM d, yyyy"),
                            DateTime.Today.Add(CType(reader("time_ordered"), TimeSpan)).ToString("h:mm tt")
                        )
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub SortAllOrderDetails()

        Dim connectionString As String = "Data Source=DESKTOP-FOAVQMH\SQLEXPRESS; Initial Catalog=FLOATS_POS_SYSTEM; Integrated Security=True; TrustServerCertificate=True;"

        Dim selectQuery As String

        If (sortAscending) Then
            selectQuery = "SELECT order_id, product_id, quantity, total_price, date_ordered, time_ordered FROM OrderDetails ORDER BY order_id ASC"
        Else
            selectQuery = "SELECT order_id, product_id, quantity, total_price, date_ordered, time_ordered FROM OrderDetails ORDER BY order_id DESC"
        End If

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Using command As New SqlCommand(selectQuery, connection)
                Using reader As SqlDataReader = command.ExecuteReader()
                    dgvOrderDetails.Rows.Clear()

                    While reader.Read()
                        dgvOrderDetails.Rows.Add(
                            reader("order_id").ToString(),
                            reader("product_id").ToString(),
                            reader("quantity").ToString(),
                            (FormatCurrency(reader("total_price")).Replace("$", "₱ ")),
                            CDate(reader("date_ordered")).ToString("MMMM d, yyyy"),
                            DateTime.Today.Add(CType(reader("time_ordered"), TimeSpan)).ToString("h:mm tt")
                        )
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub dgvProducts_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducts.CellContentClick

    End Sub

    Private Sub dgvOrderDetails_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOrderDetails.CellContentClick

    End Sub

    Private Sub btn_products_Click(sender As Object, e As EventArgs) Handles btn_products.Click
        dgvOrderDetails.Visible = False
        dgvProducts.Visible = True

        currentTable = dgvProducts
        GetAllProducts()
    End Sub

    Private Sub btn_orders_Click(sender As Object, e As EventArgs) Handles btn_orders.Click
        dgvOrderDetails.Visible = True
        dgvProducts.Visible = False

        currentTable = dgvOrderDetails
        GetAllOrderDetails()
    End Sub

    Private Sub btn_sort_Click(sender As Object, e As EventArgs) Handles btn_sort.Click

        If sortAscending Then
            btn_sort.Text = "🔽 Sort"
            If currentTable Is dgvProducts Then
                SortAllProducts()
            Else
                SortAllOrderDetails()
            End If
        Else
            btn_sort.Text = "🔼 Sort"
            If currentTable Is dgvProducts Then
                SortAllProducts()
            Else
                SortAllOrderDetails()
            End If
        End If

        sortAscending = Not sortAscending
    End Sub

    Private Sub tb_search_TextChanged(sender As Object, e As EventArgs) Handles tb_search.TextChanged
        Dim searchText As String = tb_search.Text.ToLower()

        For Each row As DataGridViewRow In dgvProducts.Rows
            row.Visible = row.Cells.Cast(Of DataGridViewCell)().
                Any(Function(cell) cell.Value IsNot Nothing AndAlso
                    cell.Value.ToString().ToLower().Contains(searchText))
        Next

        For Each row As DataGridViewRow In dgvOrderDetails.Rows
            row.Visible = row.Cells.Cast(Of DataGridViewCell)().
                Any(Function(cell) cell.Value IsNot Nothing AndAlso
                    cell.Value.ToString().ToLower().Contains(searchText))
        Next
    End Sub

    Private Sub btn_remove_Click(sender As Object, e As EventArgs) Handles btn_remove.Click
        If dgvOrderDetails.SelectedRows.Count > 0 Then
            ' Get the primary key (e.g., order_id) from the selected row
            Dim orderID As Integer = Convert.ToInt32(dgvOrderDetails.SelectedRows(0).Cells("orderID").Value)

            ' Confirm delete
            If CustomMessageBox.Show("Are you sure?", "CONFIRMATION", "YES/NO") = DialogResult.Yes Then
                Dim connectionString As String = "Data Source=DESKTOP-FOAVQMH\SQLEXPRESS; Initial Catalog=FLOATS_POS_SYSTEM; Integrated Security=True; TrustServerCertificate=True;"
                Using connection As New SqlConnection(connectionString)
                    connection.Open()

                    Dim deleteQuery As String = "DELETE FROM OrderDetails WHERE order_id = @order_id"
                    Using command As New SqlCommand(deleteQuery, connection)
                        command.Parameters.AddWithValue("@order_id", orderID)
                        command.ExecuteNonQuery()
                    End Using
                End Using

                If currentTable Is dgvProducts Then
                    SortAllProducts()
                Else
                    SortAllOrderDetails()
                End If
            End If
        Else
            CustomMessageBox.Show("Please select a row to delete.", "ERROR", "OK")
        End If
    End Sub
End Class