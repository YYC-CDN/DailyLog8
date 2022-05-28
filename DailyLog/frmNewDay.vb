' STARTED JANUARY 3RD 2011

'Option Strict On
Imports System.IO
Public Class frmNewDay
    Public sTemp, sTemp2, arTemp(), arTemp2() As String

    Private Sub frmNewDay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MinimizeBox = False : Me.MaximizeBox = False : Me.Location = x.centerForm(Me) ' Center Form of FrmMain.
        MonthCalendar1.MaxSelectionCount = 1
    End Sub

    Public Sub btnNewDay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewDay.Click
        arTemp = CStr(MonthCalendar1.SelectionStart).Split("/"c)
        If arTemp(0).Length = 1 Then arTemp(0) = "" & arTemp(0) ' Removed a 0 in front of single month date
        If arTemp(1).Length = 1 Then arTemp(1) = "0" & arTemp(1) ' add a "0" to day.
        With FrmMain
            .lvMain.Tag = arTemp(0) & "." & arTemp(1) & "." & arTemp(2) ' used for FileName when Saving File.
            .lblFileDate.Text = .lvMain.Tag.ToString
            For Each DailyLogFile As String In My.Computer.FileSystem.GetFiles(myFilesFolder, FileIO.SearchOption.SearchAllSubDirectories, "*.DLF")
                sTemp = Path.GetFileNameWithoutExtension(DailyLogFile)
                If sTemp = .lblFileDate.Text Then
                    x.loadFile(DailyLogFile)
                    Me.Close()
                    Exit Sub
                End If
            Next
            FrmMain.clearForNewFile()
            'x.saveLogFile()
            ' .loadFilesToArrayList(.arlFiles)
            'Me.Close()
            MsgBox("New Day Created for " & FrmMain.lblFileDate.Text & vbNewLine & " Also check your mileage, it may need to be changed or adjusted ", MsgBoxStyle.OkOnly, "New Day Created")
        End With
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub


End Class