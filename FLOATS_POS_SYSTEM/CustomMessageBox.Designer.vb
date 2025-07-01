<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomMessageBox
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
        lbl_msg = New Label()
        btn_yes = New Button()
        btn_no = New Button()
        btn_ok = New Button()
        SuspendLayout()
        ' 
        ' lbl_msg
        ' 
        lbl_msg.AutoSize = True
        lbl_msg.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_msg.Location = New Point(16, 15)
        lbl_msg.MinimumSize = New Size(270, 65)
        lbl_msg.Name = "lbl_msg"
        lbl_msg.Size = New Size(270, 65)
        lbl_msg.TabIndex = 0
        lbl_msg.Text = "Label"
        lbl_msg.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btn_yes
        ' 
        btn_yes.BackColor = Color.Black
        btn_yes.FlatStyle = FlatStyle.Flat
        btn_yes.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_yes.ForeColor = Color.White
        btn_yes.Location = New Point(40, 90)
        btn_yes.Name = "btn_yes"
        btn_yes.Padding = New Padding(1)
        btn_yes.Size = New Size(100, 40)
        btn_yes.TabIndex = 5
        btn_yes.Text = "Yes"
        btn_yes.UseVisualStyleBackColor = False
        btn_yes.Visible = False
        ' 
        ' btn_no
        ' 
        btn_no.BackColor = Color.Black
        btn_no.FlatStyle = FlatStyle.Flat
        btn_no.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_no.ForeColor = Color.White
        btn_no.Location = New Point(161, 90)
        btn_no.Name = "btn_no"
        btn_no.Padding = New Padding(1)
        btn_no.Size = New Size(100, 40)
        btn_no.TabIndex = 6
        btn_no.Text = "No"
        btn_no.UseVisualStyleBackColor = False
        btn_no.Visible = False
        ' 
        ' btn_ok
        ' 
        btn_ok.BackColor = Color.Black
        btn_ok.FlatStyle = FlatStyle.Flat
        btn_ok.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_ok.ForeColor = Color.White
        btn_ok.Location = New Point(99, 90)
        btn_ok.Name = "btn_ok"
        btn_ok.Padding = New Padding(1)
        btn_ok.Size = New Size(100, 40)
        btn_ok.TabIndex = 7
        btn_ok.Text = "OK"
        btn_ok.UseVisualStyleBackColor = False
        btn_ok.Visible = False
        ' 
        ' CustomMessageBox
        ' 
        AutoScaleDimensions = New SizeF(9F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(302, 153)
        Controls.Add(btn_ok)
        Controls.Add(btn_no)
        Controls.Add(btn_yes)
        Controls.Add(lbl_msg)
        Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.White
        MaximizeBox = False
        MdiChildrenMinimizedAnchorBottom = False
        MinimizeBox = False
        Name = "CustomMessageBox"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CustomMessageBox"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbl_msg As Label
    Friend WithEvents btn_yes As Button
    Friend WithEvents btn_no As Button
    Friend WithEvents btn_ok As Button
End Class
