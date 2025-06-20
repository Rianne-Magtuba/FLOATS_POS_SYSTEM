<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Label2 = New Label()
        btnRegister = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        btnSignUp = New Button()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.Control
        Label2.Location = New Point(36, 397)
        Label2.Name = "Label2"
        Label2.Size = New Size(152, 23)
        Label2.TabIndex = 13
        Label2.Text = "Already an admin?"
        ' 
        ' btnRegister
        ' 
        btnRegister.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRegister.ForeColor = SystemColors.ActiveCaptionText
        btnRegister.Location = New Point(194, 394)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(100, 29)
        btnRegister.TabIndex = 12
        btnRegister.Text = "Login"
        btnRegister.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(102, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(167, 54)
        Label1.TabIndex = 8
        Label1.Text = "Register"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(417, 33)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(478, 410)
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' btnSignUp
        ' 
        btnSignUp.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSignUp.ForeColor = SystemColors.ActiveCaptionText
        btnSignUp.Location = New Point(102, 275)
        btnSignUp.Name = "btnSignUp"
        btnSignUp.Size = New Size(156, 35)
        btnSignUp.TabIndex = 16
        btnSignUp.Text = "Sign Up"
        btnSignUp.UseVisualStyleBackColor = True
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPassword.Location = New Point(64, 206)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(230, 43)
        txtPassword.TabIndex = 15
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsername.Location = New Point(64, 137)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(230, 43)
        txtUsername.TabIndex = 14
        ' 
        ' Register
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(958, 477)
        Controls.Add(btnSignUp)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(Label2)
        Controls.Add(btnRegister)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Register"
        Text = "Register"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents btnRegister As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnSignUp As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
End Class
