Public Class CustomMessageBox

    Public Shared Function Show(message As String, Optional title As String = "Message", Optional type As String = "OK") As DialogResult
        Dim box As New CustomMessageBox()
        box.Text = title
        box.lbl_msg.Text = message
        box.StartPosition = FormStartPosition.CenterScreen

        If type = "OK" Then
            box.btn_ok.Visible = True
            box.btn_yes.Visible = False
            box.btn_no.Visible = False
        ElseIf type = "YES/NO" Then
            box.btn_ok.Visible = False
            box.btn_yes.Visible = True
            box.btn_no.Visible = True
        End If

        box.ShowDialog()
        Return box.DialogResult
    End Function

    Private Sub btn_yes_Click(sender As Object, e As EventArgs) Handles btn_yes.Click
        DialogResult = DialogResult.Yes
        Close()
    End Sub

    Private Sub btn_no_Click(sender As Object, e As EventArgs) Handles btn_no.Click
        Me.DialogResult = DialogResult.No
        Me.Close()
    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class