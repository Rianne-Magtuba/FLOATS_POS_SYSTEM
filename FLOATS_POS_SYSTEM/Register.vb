Imports System.Runtime.CompilerServices
Imports System.Data.SqlClient

Public Class Register
    Private Function UserExists(username As String) As Boolean
        Dim ConnectionString As String = "Data Source=localhost;Initial Catalog=Floats_POS_System;Integrated Security=True"
        Dim query As String = "SELECT COUNT(*) FROM Users WHERE Username = @Username"
        Using conn As New SqlConnection(ConnectionString)
            conn.Open()
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Username", username)
            End Using
        End Using
    End Function
    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        If username = "" Or password = "" Then
            MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If UserExists(username) Then
            MessageBox.Show("Username already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim connectionString As String = "Data Source=localhost;Initial Catalog=Floats_POS_System;Integrated Security=True"
        Dim query As String = "INSERT INTO Admins (Username, Password) VALUES (@Username, @Password)"
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Username", username)
                cmd.Parameters.AddWithValue("@Password", password)
                cmd.ExecuteNonQuery()
            End Using
        End Using
        txtUsername.Text = ""
        txtPassword.Text = ""
        MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnGoLogin.Click
        Dim Login As New LoginForm()
        Login.Show()
        Me.Hide()

    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtUsername.Text = ""
        txtPassword.Text = ""


    End Sub
End Class