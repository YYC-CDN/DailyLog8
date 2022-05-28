'Option Strict On
Imports System.IO
Public Class frmOpenLog

    Private myFilesFolderPath As String = x.currentUserFilesFolder
    Private mySelection() As String = {"year", "month"} ' store FullPath locations for Years and Months
    Private myImageList As New ImageList With _
                                  {.ColorDepth = ColorDepth.Depth32Bit, .ImageSize = New Size(22, 22)} ' ImageList for lvFiles Icons.

    Private Sub frmOpenLog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = x.centerForm(Me) ' Center Form of FrmMain.
        ' customize lvFiles.
        With lvFiles
            If Not lvFiles.Columns.Count = 1 Then ' check if column already exists.
                With lvFiles ' customize lvFiles.
                    .Columns.Add("Folders", .Width - 21) : .Font = New Font("Eras ITC", 12, FontStyle.Bold)
                    .View = View.Details : .FullRowSelect = True : .MultiSelect = False : .Cursor = Cursors.Hand : .HoverSelection = True
                    .SmallImageList = myImageList
                End With
            End If
        End With
        ' add images to image list.
        'With myImageList.Images
        '   .Add(Bitmap.FromFile(FrmMain.myFolder & "fileIcon.png")) ' File Icon.
        '   .Add(Bitmap.FromFile(FrmMain.myFolder & "folderFilesIcon.png")) ' Folder with Files Icon.
        '   .Add(Bitmap.FromFile(FrmMain.myFolder & "folderEmptyIcon.png")) ' Empty Folder Icon.
        With myImageList.Images
            .Add(My.Resources.fileIcon) ' File Icon.
            .Add(My.Resources.folderFileIcon) ' Folder with Files Icon.
            .Add(My.Resources.folderEmptyIcon) ' Empty Folder Icon.
            ' set keys to use #'s when changing images.
            .SetKeyName(0, My.Resources.folderFileIcon.ToString)
            ' set keys to use #'s when changing images.
            .SetKeyName(0, x.myFolder & "fileIcon.png")
            .SetKeyName(1, x.myFolder & "folderFilesIcon.png")
            .SetKeyName(2, x.myFolder & "folderEmptyIcon.png")
        End With
        lvFiles.Tag = "years"
        loadYearFolders()
        btnBack.Enabled = False : btnBack.Cursor = Cursors.Hand
    End Sub
    Private Sub loadYearFolders()
        lvFiles.Items.Clear()
        If Directory.Exists(myFilesFolderPath) Then
            Dim dir As New DirectoryInfo(myFilesFolderPath)
            For Each myDirFolder As DirectoryInfo In dir.GetDirectories
                Dim newItem As New ListViewItem(myDirFolder.Name, 2)
                lvFiles.Items.Add(newItem)
            Next
        Else
            MsgBox("All Folders have been recently moved or deleted.", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub loadMonthFolders()
        lvFiles.Items.Clear()
        Dim myDirectory As String = myFilesFolderPath & mySelection(0) & "\"
        Dim dir As New DirectoryInfo(myDirectory)
        If Directory.Exists(myDirectory) Then
            Dim ar() As String : Dim iIcon As Integer = 2
            For Each myDirFolder As DirectoryInfo In dir.GetDirectories
                If Not Directory.GetFiles(myDirectory & myDirFolder.Name).Length = 0 Then : iIcon = 1
                Else : iIcon = 2
                End If
                ar = myDirFolder.Name.Split(" "c)
                Try
                    Dim newItem As New ListViewItem(ar(2), iIcon)
                    newItem.Tag = myDirFolder.Name
                    lvFiles.Items.Add(newItem)
                Catch ex As Exception

                End Try

            Next
        Else
            MsgBox("All Folders have been recently moved or deleted.", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub loadFiles()
        lvFiles.Items.Clear()
        Dim myDirectory As String = myFilesFolderPath & mySelection(0) & "\" & mySelection(1) & "\"
        If Directory.Exists(myDirectory) Then
            For Each DailyLogFile As String In My.Computer.FileSystem.GetFiles _
          (myDirectory, FileIO.SearchOption.SearchTopLevelOnly, "*.DLF")
                Dim newItem As New ListViewItem(Path.GetFileNameWithoutExtension(DailyLogFile), 0)
                newItem.Tag = Path.GetFullPath(DailyLogFile)
                lvFiles.Items.Add(newItem)
            Next
        Else
            MsgBox("All Files have been recently moved or deleted.", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub lvFiles_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvFiles.Click
        FrmMain.lblFileDate.Text = lvFiles.SelectedItems(0).Text

        If Not lvFiles.SelectedItems.Count = 0 Then
            Select Case lvFiles.Tag.ToString
                Case "years"
                    lvFiles.Columns(0).Text = lvFiles.SelectedItems(0).Text & " - Folders"
                    mySelection(0) = lvFiles.SelectedItems(0).Text
                    loadMonthFolders()
                    lblInfo.Text = "Select a Month"
                    lvFiles.Tag = "months"
                    btnBack.Enabled = True
                Case "months"
                    lvFiles.Columns(0).Text = mySelection(0) & " - " & lvFiles.SelectedItems(0).Text & " - Files"
                    lvFiles.Tag = "files"
                    mySelection(1) = lvFiles.SelectedItems(0).Tag.ToString
                    loadFiles()
                    lblInfo.Text = "Select a Daily Log File"
                Case "files"
                    If File.Exists(lvFiles.SelectedItems(0).Tag.ToString) Then
                        x.loadFile(lvFiles.SelectedItems(0).Tag.ToString) ' load file full path from .Tag option since it only displays FileName in lvFiles.
                        FrmMain.lvMain.Tag = lvFiles.SelectedItems(0).Text
                        Me.Close()
                    Else
                        MsgBox("This File has been recently moved or deleted.", MsgBoxStyle.Critical)
                    End If
            End Select
        End If
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Select Case lvFiles.Tag.ToString
            Case "months"
                lvFiles.Columns(0).Text = "Folders"
                loadYearFolders()
                lblInfo.Text = "Select a Year"
                lvFiles.Tag = "years"
                btnBack.Enabled = False
            Case "files"
                lvFiles.Columns(0).Text = mySelection(0) & " - Folders"
                loadMonthFolders()
                lblInfo.Text = "Select a Month"
                lvFiles.Tag = "months"
        End Select
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class