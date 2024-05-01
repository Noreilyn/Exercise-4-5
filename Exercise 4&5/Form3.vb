Imports Microsoft.Office.Interop
Imports Excel = Microsoft.Office.Interop.Excel

Public Class Login_success
    Private Sub ex5_view_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ex5_view.SelectedIndexChanged

    End Sub

    Private Sub Login_success_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ex5_view.Columns.Add("ID", 150, HorizontalAlignment.Center)
        ex5_view.Columns.Add("First Name", 180, HorizontalAlignment.Center)
        ex5_view.Columns.Add("Last Name", 180, HorizontalAlignment.Center)
        ex5_view.Columns.Add("Username", 180, HorizontalAlignment.Center)
        ex5_view.Columns.Add("Password", 180, HorizontalAlignment.Center)

        LoadDataFromExcel()

        Dim applicxl As Excel.Application = Nothing
        Dim wrkbk As Excel.Workbook = Nothing
        Dim sheet As Excel.Worksheet = Nothing

        Try
            Dim savePath As String = System.IO.Path.Combine(Application.StartupPath, "EX5.xlsx")

            applicxl = New Excel.Application
            applicxl.Visible = False

            If System.IO.File.Exists(savePath) Then
                wrkbk = applicxl.Workbooks.Open(savePath)
                sheet = wrkbk.ActiveSheet

                Dim range As Excel.Range = sheet.UsedRange

                Dim row As Integer
                For row = 2 To range.Rows.Count
                    ind_finder.Items.Add(range.Cells(row, 1).Value)
                Next

                wrkbk.Close(False)
                applicxl.Quit()
            Else
                MessageBox.Show("There is No Database.")
            End If
        Catch ex As Exception
            MessageBox.Show("ERROR: " & ex.Message)
        Finally
            ReleaseObject(sheet)
            ReleaseObject(wrkbk)
            ReleaseObject(applicxl)
        End Try
    End Sub
    Private Sub LoadDataFromExcel()
        Dim applicxl As Excel.Application = Nothing
        Dim wrkbk As Excel.Workbook = Nothing
        Dim sheet As Excel.Worksheet = Nothing
        Dim savePath As String

        Try
            savePath = System.IO.Path.Combine(Application.StartupPath, "EX5.xlsx")

            applicxl = New Excel.Application
            applicxl.Visible = False

            If System.IO.File.Exists(savePath) Then
                wrkbk = applicxl.Workbooks.Open(savePath)
                sheet = wrkbk.ActiveSheet

                Dim lastRow As Integer = sheet.Cells(sheet.Rows.Count, 1).End(Excel.XlDirection.xlUp).Row
                For i As Integer = 1 To lastRow
                    Dim item As New ListViewItem(sheet.Cells(i, 1).Value.ToString())
                    item.SubItems.Add(sheet.Cells(i, 2).Value.ToString())
                    item.SubItems.Add(sheet.Cells(i, 3).Value.ToString())
                    item.SubItems.Add(sheet.Cells(i, 4).Value.ToString())
                    item.SubItems.Add(sheet.Cells(i, 5).Value.ToString())

                    ex5_view.Items.Add(item)
                Next
            Else
                MsgBox("There is No Database.")
            End If
        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message)
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

    Private Sub ind_finder_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ind_finder.SelectedIndexChanged
        ex5_view.Items.Clear()

        Dim applicxl As Excel.Application = Nothing
        Dim wrkbk As Excel.Workbook = Nothing
        Dim sheet As Excel.Worksheet = Nothing

        Try
            Dim selectedValue As String = ind_finder.SelectedItem.ToString()

            Dim savePath = System.IO.Path.Combine(Application.StartupPath, "EX5.xlsx")

            applicxl = New Excel.Application
            applicxl.Visible = False

            If System.IO.File.Exists(savePath) Then
                wrkbk = applicxl.Workbooks.Open(savePath)
                sheet = wrkbk.ActiveSheet

                Dim range As Excel.Range = sheet.UsedRange

                Dim row As Integer
                For row = 1 To range.Rows.Count
                    If range.Cells(row, 1).Value = selectedValue Then
                        Dim rowData As New ListViewItem()

                        For col As Integer = 2 To range.Columns.Count
                            rowData.SubItems.Add(range.Cells(row, col).Value.ToString())
                        Next
                        ex5_view.Items.Add(rowData)


                        Exit For
                    End If
                Next

                wrkbk.Close(False)
                applicxl.Quit()
            Else
                MessageBox.Show("No Database.")
            End If
        Catch ex As Exception
            MessageBox.Show("ERROR: " & ex.Message)
        Finally
            ReleaseObject(sheet)
            ReleaseObject(wrkbk)
            ReleaseObject(applicxl)
        End Try
    End Sub

    Private Sub Summary_data_Click(sender As Object, e As EventArgs) Handles Summary_data.Click
        ex5_view.Items.Clear()

        Dim applicxl As Excel.Application = Nothing
        Dim wrkbk As Excel.Workbook = Nothing
        Dim sheet As Excel.Worksheet = Nothing
        Dim savePath As String

        Try
            savePath = System.IO.Path.Combine(Application.StartupPath, "EX5.xlsx")

            applicxl = New Excel.Application
            applicxl.Visible = False

            If System.IO.File.Exists(savePath) Then
                wrkbk = applicxl.Workbooks.Open(savePath)
                sheet = wrkbk.ActiveSheet

                Dim lastRow As Integer = sheet.Cells(sheet.Rows.Count, 1).End(Excel.XlDirection.xlUp).Row
                For i As Integer = 2 To lastRow
                    Dim item As New ListViewItem(sheet.Cells(i, 1).Value.ToString())
                    item.SubItems.Add(sheet.Cells(i, 2).Value.ToString())
                    item.SubItems.Add(sheet.Cells(i, 3).Value.ToString())
                    item.SubItems.Add(sheet.Cells(i, 4).Value.ToString())
                    item.SubItems.Add(sheet.Cells(i, 5).Value.ToString())

                    ex5_view.Items.Add(item)
                Next
            Else
                MsgBox("There is No Database.")
            End If
        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message)
        Finally
            ReleaseObject(sheet)
            ReleaseObject(wrkbk)
            ReleaseObject(applicxl)
        End Try
    End Sub

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click
        Login_Form.Show()
        Me.Hide()

    End Sub
End Class