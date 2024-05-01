Imports Microsoft.Office.Interop
Public Class Login_Form
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Back_to_login_Click(sender As Object, e As EventArgs) Handles Register.Click
        Registration_Form.Show
        Hide

    End Sub

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login_button.Click
        If username_login.Text = "" Then
            MsgBox("Input Username.")
            Exit Sub
        End If
        If password_login.Text = "" Then
            MsgBox("Input Password.")
            Exit Sub
        End If

        Dim username = username_login.Text
        Dim password = password_login.Text
        Dim savePath = IO.Path.Combine(Application.StartupPath, "EX5.xlsx")

        If Not IO.File.Exists(savePath) Then
            MessageBox.Show("There's no database. Register first.")
            Exit Sub
        End If

        Dim applicxl As New Excel.Application
        applicxl.Visible = False
        Dim wrkbk = applicxl.Workbooks.Open(savePath)
        Dim sheet As Excel.Worksheet = wrkbk.Sheets(1)

        Dim found = False
        Dim lastRow As Integer = sheet.Cells(sheet.Rows.Count, 3).End(Excel.XlDirection.xlUp).Row
        For i = 2 To lastRow
            Dim storedUsername = sheet.Cells(i, 4).Value.ToString
            Dim storedPassword = sheet.Cells(i, 5).Value.ToString

            If storedUsername = username AndAlso storedPassword = password Then
                found = True
                Exit For
            End If
        Next

        wrkbk.Close(False)
        applicxl.Quit()

        If found Then
            MessageBox.Show("Login Successful!")
            Login_success.Show()
            Hide()
        Else
            MessageBox.Show("Wrong Username or Password!")
        End If
    End Sub

    Private Sub Login_user_TextChanged(sender As Object, e As EventArgs) Handles username_login.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub exit_btn_Click(sender As Object, e As EventArgs) Handles exit_btn.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class