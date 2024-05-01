Imports Microsoft.Office.Interlop.Excel
Imports Excel = Microsoft.Office.Interop.Excel
Public Class Registration_Form
    Private Sub Registration_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Register_button_Click(sender As Object, e As EventArgs) Handles Register_button.Click
        If firstname_Register.Text = "" Then
            MsgBox("Input Firstname.")
            Exit Sub
        End If

        If surname_Register.Text = "" Then
            MsgBox("Input Surname.")
            Exit Sub
        End If

        If username_Register.Text = "" Then
            MsgBox("Input Username.")
            Exit Sub
        End If

        If password_Register.Text = "" Then
            MsgBox("Input Password.")
            Exit Sub
        End If

        Dim applicxl As Excel.Application = Nothing
        Dim wrkbk As Excel.Workbook = Nothing
        Dim sheet As Excel.Worksheet = Nothing
        Dim savePath As String

        Try
            savePath = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "EX5.xlsx")

            applicxl = New Excel.Application
            applicxl.Visible = False

            If System.IO.File.Exists(savePath) Then
                wrkbk = applicxl.Workbooks.Open(savePath)
                sheet = wrkbk.ActiveSheet
            Else
                wrkbk = applicxl.Workbooks.Add
                sheet = wrkbk.ActiveSheet

                sheet.Cells(1, 1).Value = "ID"
                sheet.Cells(1, 2).Value = "Surname"
                sheet.Cells(1, 3).Value = "First Name"
                sheet.Cells(1, 4).Value = "Username"
                sheet.Cells(1, 5).Value = "Password"
                sheet.Cells(1, 6).Value = "Date"
                sheet.Cells(1, 7).Value = "Time"
            End If

            If sheet.Cells(11, 1).Value IsNot Nothing Then
                MsgBox("Database is Full (10).")
                Exit Sub
            End If

            Dim newRow As Integer
            newRow = sheet.Cells(sheet.Rows.Count, 1).End(Excel.XlDirection.xlUp).Row + 1

            Dim Reg_ID As String = GenerateID()

            sheet.Cells(newRow, 1).Value = Reg_ID
            sheet.Cells(newRow, 2).Value = firstname_Register.Text
            sheet.Cells(newRow, 3).Value = surname_Register.Text
            sheet.Cells(newRow, 4).Value = username_Register.Text
            sheet.Cells(newRow, 5).Value = password_Register.Text
            sheet.Cells(newRow, 6).Value = Date.Now.ToShortDateString()
            sheet.Cells(newRow, 7).Value = TimeOfDay.ToString("h:mm:ss tt")

            wrkbk.SaveAs(savePath)
            wrkbk.Close(False)
            applicxl.Quit()

            MsgBox("Registration Successful! Your ID is " & Reg_ID)
        Catch ex As Exception
            MsgBox("ERROR " & ex.Message)
        Finally
            ReleaseObject(sheet)
            ReleaseObject(wrkbk)
            ReleaseObject(applicxl)
        End Try
    End Sub
    Private Sub ReleaseObject(ByVal obj As Object)
        Try
            If obj IsNot Nothing Then
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
                obj = Nothing
            End If
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Function GenerateID() As String
        Dim random As New Random()
        Dim idList As New List(Of String)() '

        For i As Integer = 1 To 100
            Dim randomNum As Integer = random.Next(600, 800)
            Dim randomID As Integer = random.Next(1, 10)
            Dim id As String = "A-" & randomID & "-S-" & randomNum.ToString()

            If Not idList.Contains(id) Then
                idList.Add(id)
                Return id
            End If
        Next

        Return ""
    End Function




    Private Sub back_to_login_Click(sender As Object, e As EventArgs) Handles back_to_login.Click
        Login_Form.Show()
        Me.Hide()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class