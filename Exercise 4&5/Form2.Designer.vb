<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registration_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registration_Form))
        back_to_login = New Button()
        Register_button = New Button()
        firstname_Register = New TextBox()
        surname_Register = New TextBox()
        username_Register = New TextBox()
        password_Register = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' back_to_login
        ' 
        back_to_login.BackColor = Color.ForestGreen
        back_to_login.Location = New Point(542, 397)
        back_to_login.Name = "back_to_login"
        back_to_login.Size = New Size(189, 47)
        back_to_login.TabIndex = 3
        back_to_login.Text = "Back to Log In"
        back_to_login.UseVisualStyleBackColor = False
        ' 
        ' Register_button
        ' 
        Register_button.BackColor = Color.ForestGreen
        Register_button.Location = New Point(33, 386)
        Register_button.Name = "Register_button"
        Register_button.Size = New Size(322, 58)
        Register_button.TabIndex = 2
        Register_button.Text = "Register"
        Register_button.UseVisualStyleBackColor = False
        ' 
        ' firstname_Register
        ' 
        firstname_Register.BackColor = Color.DarkKhaki
        firstname_Register.Location = New Point(33, 83)
        firstname_Register.Name = "firstname_Register"
        firstname_Register.Size = New Size(322, 25)
        firstname_Register.TabIndex = 4
        ' 
        ' surname_Register
        ' 
        surname_Register.BackColor = Color.DarkKhaki
        surname_Register.Location = New Point(33, 138)
        surname_Register.Name = "surname_Register"
        surname_Register.Size = New Size(322, 25)
        surname_Register.TabIndex = 5
        ' 
        ' username_Register
        ' 
        username_Register.BackColor = Color.DarkKhaki
        username_Register.Location = New Point(33, 200)
        username_Register.Name = "username_Register"
        username_Register.Size = New Size(322, 25)
        username_Register.TabIndex = 6
        ' 
        ' password_Register
        ' 
        password_Register.BackColor = Color.DarkKhaki
        password_Register.Location = New Point(33, 263)
        password_Register.Name = "password_Register"
        password_Register.Size = New Size(322, 25)
        password_Register.TabIndex = 7
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.DarkOliveGreen
        Label2.Font = New Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(375, 138)
        Label2.Name = "Label2"
        Label2.Size = New Size(103, 28)
        Label2.TabIndex = 9
        Label2.Text = "Surname"
        Label2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.DarkOliveGreen
        Label1.Font = New Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(375, 83)
        Label1.Name = "Label1"
        Label1.Size = New Size(129, 28)
        Label1.TabIndex = 8
        Label1.Text = "Firstname"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.DarkOliveGreen
        Label3.Font = New Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(375, 263)
        Label3.Name = "Label3"
        Label3.Size = New Size(116, 28)
        Label3.TabIndex = 10
        Label3.Text = "Password"
        Label3.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.DarkOliveGreen
        Label4.Font = New Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(375, 200)
        Label4.Name = "Label4"
        Label4.Size = New Size(116, 28)
        Label4.TabIndex = 11
        Label4.Text = "Username"
        Label4.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Registration_Form
        ' 
        AutoScaleDimensions = New SizeF(8F, 18F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GrayText
        BackgroundImage = My.Resources.Resources.sr21db939adcaaws3
        ClientSize = New Size(765, 500)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(password_Register)
        Controls.Add(username_Register)
        Controls.Add(surname_Register)
        Controls.Add(firstname_Register)
        Controls.Add(back_to_login)
        Controls.Add(Register_button)
        Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Registration_Form"
        Text = "REGISTRATION"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents back_to_login As Button
    Friend WithEvents Register_button As Button
    Friend WithEvents firstname_Register As TextBox
    Friend WithEvents surname_Register As TextBox
    Friend WithEvents username_Register As TextBox
    Friend WithEvents password_Register As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
