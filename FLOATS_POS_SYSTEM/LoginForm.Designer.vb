<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        PictureBox1 = New PictureBox()
        lblLogin = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        Button1 = New Button()
        btnRegister = New Button()
        Label2 = New Label()
        lblUsername = New Label()
        lblPassword = New Label()
        btnClear = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Left
        PictureBox1.BackgroundImage = My.Resources.Resources.floatsIcon
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(436, 35)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(478, 410)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' lblLogin
        ' 
        lblLogin.AutoSize = True
        lblLogin.Font = New Font("Segoe UI", 24.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblLogin.Location = New Point(93, 35)
        lblLogin.Name = "lblLogin"
        lblLogin.Size = New Size(250, 54)
        lblLogin.TabIndex = 1
        lblLogin.Text = "Admin Login"
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsername.Location = New Point(159, 144)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(230, 34)
        txtUsername.TabIndex = 2
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPassword.Location = New Point(159, 213)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(230, 34)
        txtPassword.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ActiveCaptionText
        Button1.Location = New Point(287, 289)
        Button1.Name = "Button1"
        Button1.Size = New Size(102, 35)
        Button1.TabIndex = 4
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btnRegister
        ' 
        btnRegister.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRegister.ForeColor = SystemColors.ActiveCaptionText
        btnRegister.Location = New Point(223, 396)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(100, 29)
        btnRegister.TabIndex = 5
        btnRegister.Text = "Register"
        btnRegister.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(93, 398)
        Label2.Name = "Label2"
        Label2.Size = New Size(124, 23)
        Label2.TabIndex = 6
        Label2.Text = "Not an admin?"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUsername.Location = New Point(32, 147)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(99, 28)
        lblUsername.TabIndex = 7
        lblUsername.Text = "Username"
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPassword.Location = New Point(32, 216)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(93, 28)
        lblPassword.TabIndex = 8
        lblPassword.Text = "Password"
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnClear.ForeColor = SystemColors.ActiveCaptionText
        btnClear.Location = New Point(159, 289)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(102, 35)
        btnClear.TabIndex = 9
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(958, 477)
        Controls.Add(btnClear)
        Controls.Add(lblPassword)
        Controls.Add(lblUsername)
        Controls.Add(Label2)
        Controls.Add(btnRegister)
        Controls.Add(Button1)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(lblLogin)
        Controls.Add(PictureBox1)
        ForeColor = SystemColors.Control
        Name = "LoginForm"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblLogin As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents btnClear As Button

End Class
