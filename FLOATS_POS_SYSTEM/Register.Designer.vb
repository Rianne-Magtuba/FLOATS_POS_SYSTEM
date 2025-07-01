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
        btnGoLogin = New Button()
        Label1 = New Label()
        btnSignUp = New Button()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        lblUsername = New Label()
        btnClear = New Button()
        lblPassword = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnGoLogin
        ' 
        btnGoLogin.BackgroundImageLayout = ImageLayout.None
        btnGoLogin.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnGoLogin.ForeColor = SystemColors.ActiveCaptionText
        btnGoLogin.Location = New Point(177, 350)
        btnGoLogin.Name = "btnGoLogin"
        btnGoLogin.Size = New Size(173, 27)
        btnGoLogin.TabIndex = 12
        btnGoLogin.Text = "Already an admin?"
        btnGoLogin.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(183, 66)
        Label1.Name = "Label1"
        Label1.Size = New Size(167, 54)
        Label1.TabIndex = 8
        Label1.Text = "Register"
        ' 
        ' btnSignUp
        ' 
        btnSignUp.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSignUp.ForeColor = SystemColors.ActiveCaptionText
        btnSignUp.Location = New Point(271, 296)
        btnSignUp.Name = "btnSignUp"
        btnSignUp.Size = New Size(100, 35)
        btnSignUp.TabIndex = 16
        btnSignUp.Text = "Sign Up"
        btnSignUp.UseVisualStyleBackColor = True
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPassword.Location = New Point(141, 231)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(230, 34)
        txtPassword.TabIndex = 15
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsername.Location = New Point(141, 165)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(230, 34)
        txtUsername.TabIndex = 14
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUsername.ForeColor = SystemColors.Control
        lblUsername.Location = New Point(25, 168)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(99, 28)
        lblUsername.TabIndex = 17
        lblUsername.Text = "Username"
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnClear.ForeColor = SystemColors.ActiveCaptionText
        btnClear.Location = New Point(141, 296)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(100, 35)
        btnClear.TabIndex = 18
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPassword.ForeColor = SystemColors.Control
        lblPassword.Location = New Point(25, 234)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(93, 28)
        lblPassword.TabIndex = 19
        lblPassword.Text = "Password"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.floatsIcon
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(45, 7)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(150, 158)
        PictureBox1.TabIndex = 20
        PictureBox1.TabStop = False
        ' 
        ' Register
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(444, 406)
        Controls.Add(PictureBox1)
        Controls.Add(lblPassword)
        Controls.Add(btnClear)
        Controls.Add(lblUsername)
        Controls.Add(btnSignUp)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(btnGoLogin)
        Controls.Add(Label1)
        Name = "Register"
        Text = "Register"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnGoLogin As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSignUp As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents lblPassword As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
