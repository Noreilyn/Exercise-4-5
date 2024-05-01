<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login_success
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
        Dim ListViewItem1 As ListViewItem = New ListViewItem("")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login_success))
        ex5_view = New ListView()
        Summary_data = New Button()
        ind_data = New Button()
        ind_finder = New ComboBox()
        Logout = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' ex5_view
        ' 
        ex5_view.BackColor = Color.DarkOliveGreen
        ex5_view.FullRowSelect = True
        ex5_view.GridLines = True
        ex5_view.Items.AddRange(New ListViewItem() {ListViewItem1})
        ex5_view.Location = New Point(227, 83)
        ex5_view.Name = "ex5_view"
        ex5_view.RightToLeftLayout = True
        ex5_view.Size = New Size(724, 503)
        ex5_view.TabIndex = 0
        ex5_view.UseCompatibleStateImageBehavior = False
        ex5_view.View = View.Details
        ' 
        ' Summary_data
        ' 
        Summary_data.BackColor = Color.ForestGreen
        Summary_data.Location = New Point(34, 148)
        Summary_data.Name = "Summary_data"
        Summary_data.Size = New Size(175, 57)
        Summary_data.TabIndex = 1
        Summary_data.Text = "Summary"
        Summary_data.UseVisualStyleBackColor = False
        ' 
        ' ind_data
        ' 
        ind_data.BackColor = Color.ForestGreen
        ind_data.Location = New Point(34, 233)
        ind_data.Name = "ind_data"
        ind_data.Size = New Size(175, 57)
        ind_data.TabIndex = 2
        ind_data.Text = "Individual Record"
        ind_data.UseVisualStyleBackColor = False
        ' 
        ' ind_finder
        ' 
        ind_finder.BackColor = Color.DarkKhaki
        ind_finder.FormattingEnabled = True
        ind_finder.Location = New Point(227, 51)
        ind_finder.Name = "ind_finder"
        ind_finder.Size = New Size(377, 26)
        ind_finder.TabIndex = 3
        ' 
        ' Logout
        ' 
        Logout.BackColor = Color.ForestGreen
        Logout.Location = New Point(49, 521)
        Logout.Name = "Logout"
        Logout.Size = New Size(149, 50)
        Logout.TabIndex = 4
        Logout.Text = "Log out"
        Logout.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.DarkOliveGreen
        Label1.Font = New Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(34, 51)
        Label1.Name = "Label1"
        Label1.Size = New Size(175, 68)
        Label1.TabIndex = 5
        Label1.Text = " Database " & vbCrLf & "System"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Login_success
        ' 
        AutoScaleDimensions = New SizeF(8F, 18F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDarkDark
        BackgroundImage = My.Resources.Resources.sr21db939adcaaws3
        ClientSize = New Size(963, 598)
        Controls.Add(Label1)
        Controls.Add(Logout)
        Controls.Add(ind_finder)
        Controls.Add(ind_data)
        Controls.Add(Summary_data)
        Controls.Add(ex5_view)
        Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = SystemColors.ControlText
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Login_success"
        Text = "Welcome"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ex5_view As ListView
    Friend WithEvents Summary_data As Button
    Friend WithEvents ind_data As Button
    Friend WithEvents ind_finder As ComboBox
    Friend WithEvents Logout As Button
    Friend WithEvents Label1 As Label
End Class
