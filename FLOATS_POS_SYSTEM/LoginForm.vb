Imports System.Data.SqlClient

Public Class LoginForm
    'method for connecting to the database named "FLOATS_POS_SYSTEM" to the table "Admins"
    Private Function AdminLogin(username As String, password As String) As Boolean
        Dim connectionString As String = "Data Source=localhost;Initial Catalog=Floats_POS_System;Integrated Security=True"
        Dim query As String = "SELECT COUNT(*) FROM Admins WHERE Username = @Username AND Password = @Password"
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Username", username)
                cmd.Parameters.AddWithValue("@Password", password)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If AdminLogin(txtUsername.Text, txtPassword.Text) Then
            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtUsername.Text = ""
            txtPassword.Text = ""
        Else
            MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim Register As New Register()
        Register.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtUsername.Text = ""
        txtPassword.Text = ""

    End Sub
End Class
