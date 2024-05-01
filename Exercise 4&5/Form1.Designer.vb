<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login_Form))
        Login_button = New Button()
        Register = New Button()
        username_login = New TextBox()
        password_login = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        exit_btn = New Button()
        SuspendLayout()
        ' 
        ' Login_button
        ' 
        Login_button.BackColor = Color.ForestGreen
        Login_button.Location = New Point(39, 342)
        Login_button.Name = "Login_button"
        Login_button.Size = New Size(322, 58)
        Login_button.TabIndex = 0
        Login_button.Text = "Log In"
        Login_button.UseVisualStyleBackColor = False
        ' 
        ' Register
        ' 
        Register.BackColor = Color.ForestGreen
        Register.Location = New Point(106, 406)
        Register.Name = "Register"
        Register.Size = New Size(189, 47)
        Register.TabIndex = 1
        Register.Text = "Registration"
        Register.UseVisualStyleBackColor = False
        ' 
        ' username_login
        ' 
        username_login.BackColor = Color.DarkKhaki
        username_login.Location = New Point(39, 70)
        username_login.Name = "username_login"
        username_login.Size = New Size(268, 25)
        username_login.TabIndex = 2
        ' 
        ' password_login
        ' 
        password_login.BackColor = Color.DarkKhaki
        password_login.Location = New Point(39, 136)
        password_login.Name = "password_login"
        password_login.Size = New Size(268, 25)
        password_login.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.DarkOliveGreen
        Label1.Font = New Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(356, 67)
        Label1.Name = "Label1"
        Label1.Size = New Size(116, 28)
        Label1.TabIndex = 4
        Label1.Text = "Username"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.DarkOliveGreen
        Label2.Font = New Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(356, 136)
        Label2.Name = "Label2"
        Label2.Size = New Size(116, 28)
        Label2.TabIndex = 5
        Label2.Text = "Password"
        Label2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' exit_btn
        ' 
        exit_btn.BackColor = Color.ForestGreen
        exit_btn.Location = New Point(648, 441)
        exit_btn.Name = "exit_btn"
        exit_btn.Size = New Size(105, 47)
        exit_btn.TabIndex = 6
        exit_btn.Text = "Exit"
        exit_btn.UseVisualStyleBackColor = False
        ' 
        ' Login_Form
        ' 
        AutoScaleDimensions = New SizeF(8F, 18F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GrayText
        BackgroundImage = My.Resources.Resources.sr21db939adcaaws3
        ClientSize = New Size(765, 500)
        Controls.Add(exit_btn)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(password_login)
        Controls.Add(username_login)
        Controls.Add(Register)
        Controls.Add(Login_button)
        Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = SystemColors.ControlText
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Login_Form"
        Text = "LOGIN FORM"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Login_button As Button
    Friend WithEvents Register As Button
    Friend WithEvents username_login As TextBox
    Friend WithEvents password_login As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents exit_btn As Button

End Class
