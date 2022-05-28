' Options Window
'  Image stuff lifted from http://www.vbforums.com/showthread.php?t=629310
'  New color options started December 26th 2011

Imports System
Imports System.IO
Imports System.Text
Imports System.Drawing.Printing
Imports System.Xml
Imports System.Windows.Forms


Public Class frmOptions

#Region "//================ STRINGS ===================================================================="

    Private bThemeUpdated As Boolean = False

#End Region

#Region "//================ FORM LOAD =================================================================="


    Private Sub frmOptions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Control.CheckForIllegalCrossThreadCalls = False '  allow cross threading.

        Me.Text = "DailyLog " & x.displayAppVersion & "  "
        Me.MinimizeBox = False : Me.MaximizeBox = False : Me.Location = x.centerForm(Me) '  Center Form of FrmMain.
        ProgressBar1.Value = 0 : Me.bThemeUpdated = False : btnApply.Enabled = True

        With tbAgency ' --- REMOVE TABCONTROL PAGES HEADERS and select first tabPage.
            tcMain.Region = New Region(New Rectangle(.Left, .Top, .Width, .Height))
        End With
        tvMain.SelectedNode = tvMain.Nodes(0) '  select first tab.
        tvMain.Focus() '---\\

        '  Load settings and data from the text file in the Critical folder
        x.loadSettingsAndDataFile()

        '// ========================== LOAD QUICK NOTES SECTION =======================================
        loadFile(x.myQuickPickFile, lvCallQuickPick) '// Load Quick Picks



    End Sub

    Private Sub frmOptions_FormClosing(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosing

        ' Reload the officer info to the forms so the app doesn't need to be shut down
        x.loadSettingsAndDataFile()

    End Sub

#End Region

#Region "//================ MISC CODE =================================================================="

    Private Sub _tvMain_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvMain.AfterSelect
        Select Case tvMain.SelectedNode.Text '  get .Text and select a tab.
            Case "Agency Information" : tcMain.SelectedIndex = 0
            Case "Global Options" : tcMain.SelectedIndex = 1
            Case "Backup/Restore" : tcMain.SelectedIndex = 2
            Case "Theme Preferences" : tcMain.SelectedIndex = 3
            Case "Shift Stats" : tcMain.SelectedIndex = 4
            Case "Edit Quick Picks" : tcMain.SelectedIndex = 5
        End Select
        For Each n As TreeNode In tvMain.Nodes
            If n.IsSelected = False Then n.BackColor = Color.White Else n.BackColor = Color.LightSteelBlue
        Next
        Me.Text = tvMain.SelectedNode.Text '  TESTING - see which node clicked.
    End Sub

    Private Sub btnSaveOfficerInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        '  Show WAIT cursor
        xSetBusyCursor()


    End Sub

    '  Empty the area, password and supervisor fields with a mouse click
    Private Sub _txtAddArea_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) _
                                            Handles txtAddArea.MouseDown, txtAddSupervisor.MouseDown
        CType(sender, TextBox).Clear()
    End Sub

    Private Sub btnStatsClearAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStatsClearAll.Click
        '// ======= CLEAR THE STATS TEXT BOXES ====================
        Dim myDeleteMessage As String = "Are you sure? This will delete the stats you need to collect. Maybe you should contact your supervisor first. Click Cancel to keep your stats, and OK to delete them." '// a very cool message. :)
        Dim myDeleteTitle As String = "Delete Statistics" '// title of the message box(es).
        Dim myDeleteMsgBox As DialogResult '// declare a message box.

        myDeleteMsgBox = MessageBox.Show(myDeleteMessage, myDeleteTitle, _
        MessageBoxButtons.OKCancel, MessageBoxIcon.Question) '// customize the message box.

        Select Case myDeleteMsgBox '// option to select a command for which button clicked.
            Case DialogResult.OK '// if pressed OK
                '//Delete last item in the listview
                txtStat1.Clear() : txtStat2.Clear() : txtStat3.Clear() : txtStat4.Clear()
                txtStat5.Clear() : txtStat6.Clear() : txtStat7.Clear() : txtStat8.Clear()
                txtStat9.Clear() : txtStat10.Clear() : txtStat11.Clear() : txtStat12.Clear()
                txtStat13.Clear() : txtStat14.Clear() : txtStat15.Clear() : txtStat16.Clear()
        End Select

    End Sub

    ' Make sure the inportant fields are filled out.


    ' Change textbpox fields back to white
    Private Sub txtAddOfficer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAddOfficer.TextChanged
        txtAddOfficer.BackColor = Color.White
    End Sub
    Private Sub txtAddAgency_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAddAgency.TextChanged
        txtAddAgency.BackColor = Color.White
    End Sub
    Private Sub txtAddSupervisor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAddSupervisor.TextChanged
        txtAddSupervisor.BackColor = Color.White
    End Sub
    Private Sub txtAddArea_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAddArea.TextChanged
        txtAddArea.BackColor = Color.White
    End Sub
    Private Sub txtAddID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAddID.TextChanged
        txtAddID.BackColor = Color.White
    End Sub


#End Region

#Region "//================ BACKUP FILES BUTTON ========================================================"

    Public Sub btnBackupFiles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackupFiles.Click
        ProgressBar1.Value = 0
        Dim sOriginalFolder As String = (Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\DailyLog\Files\" & "" & FrmMain.lblID.Text & "\")
        Dim fbd As New FolderBrowserDialog
        fbd.Description = "Select a location to save your log files to..."
        If fbd.ShowDialog = Windows.Forms.DialogResult.OK Then
            ' ---- Create Folder for Files.
            Dim sNewFilesFolder As String = fbd.SelectedPath & "\DailyLog Backup Log Files\"
            If Not Directory.Exists(sNewFilesFolder) Then Directory.CreateDirectory(sNewFilesFolder) '  create if it does not exist.
            '--------\\
            ' ---------- get ProgressBar Maximum -------------\\
            Dim iProgress As Integer = 0
            For Each myCoolFile As String In My.Computer.FileSystem.GetFiles _
                                                        (sOriginalFolder, FileIO.SearchOption.SearchAllSubDirectories, "*.DLF")
                iProgress += 1
            Next
            ProgressBar1.Maximum = iProgress * 2 '  multiply by 2 to use when getting files/and when copying files.
            ' ---------- create Year/Months Folder -------------\\
            '  string arrays to create all subfolders.
            Dim xMonths() As String = {"01 - January", "02 - February", "03 - March", "04 - April", "05 - May", "06 - June", _
                                       "07 - July", "08 - August", "09 - September", "10 - October", "11 - November", "12 - December"}

            If IO.Directory.Exists(sOriginalFolder) Then '  check if folder exists.
                For Each strFolder As String In Directory.GetDirectories(sOriginalFolder) '  get all Year folders.
                    '  get only Year from fullpath of folder.
                    Dim sYearFolder As String = sNewFilesFolder & strFolder.Substring(strFolder.LastIndexOf("\") + 1, strFolder.Length - strFolder.LastIndexOf("\") - 1) & "\"
                    If Not Directory.Exists(sYearFolder) Then '  check if Year folder does Not exist.
                        Directory.CreateDirectory(sYearFolder) '  create Year folder.
                        For Each itm As String In xMonths '  create SubFolders for each month.
                            Directory.CreateDirectory(sYearFolder & itm)
                        Next
                    End If
                Next
            End If
            ' ---------- get all Original Files from "Files" folder  -------------\\
            Dim arOriginalFiles As New ArrayList
            For Each myOriginalFile As String In My.Computer.FileSystem.GetFiles(sOriginalFolder, FileIO.SearchOption.SearchAllSubDirectories, "*.DLF")
                arOriginalFiles.Add(Path.GetFileNameWithoutExtension(myOriginalFile))
                ProgressBar1.Value += 1
            Next
            ' ---------- Copy all files to new Folder Locations  -------------\\
            For Each itm As String In arOriginalFiles '  loop thru Original Files.
                Dim arTemp() As String = itm.Split("."c) '  get month/day/year
                Dim iTemp As Integer = CInt(arTemp(0)) - 1 '  month number -1 to locate xMonths folder by index.
                '  get Original File Path.
                Dim sOriginalFilePath As String = sOriginalFolder & arTemp(2) & "\" & xMonths(iTemp) & "\" & itm & ".DLF"
                'MsgBox(sOriginalFilePath)
                '  set New Path for File to be copied.
                Dim sNewFilePath As String = sNewFilesFolder & arTemp(2) & "\" & xMonths(iTemp) & "\" & itm & ".DLF"
                'MsgBox(sNewFilePath)
                Try
                    If Not File.Exists(sNewFilePath) Then '  if new File does not exist.
                        File.Copy(sOriginalFilePath, sNewFilePath) '  copy.
                    Else
                        File.Delete(sNewFilePath) '  delete.
                        File.Copy(sOriginalFilePath, sNewFilePath) '  & copy.
                    End If
                    ProgressBar1.Value += 1
                Catch ex As Exception
                End Try
            Next
            MsgBox("All Files Copied Sucessfully.", MsgBoxStyle.Information)
        End If




    End Sub
#End Region

#Region "//================ RESTORE FILES BUTTON ======================================================="

    Public Sub btnRestoreFiles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestoreFiles.Click
        ProgressBar1.Value = 0
        Dim sDestinationFolder As String = (Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\DailyLog\Files\" & "" & FrmMain.lblID.Text & "\") '  your Destination folder.

        Dim fbd As New FolderBrowserDialog
        fbd.Description = "Select a location to restore your log files from..."
        If fbd.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim sTemp As String = fbd.SelectedPath
            If Not sTemp.EndsWith("\DailyLog Backup Log Files") Then
                MsgBox("Please select the Folder named: DailyLog Backup Log Files" & vbNewLine & vbNewLine & "Restoring Files was Aborted.", MsgBoxStyle.Critical)
                Exit Sub
            Else
                Try
                    ' ---------- get ProgressBar Maximum -------------\\
                    Dim iProgress As Integer = 0
                    For Each myCoolFile In My.Computer.FileSystem.GetFiles _
                                                                (fbd.SelectedPath, FileIO.SearchOption.SearchAllSubDirectories, "*.DLF")
                        iProgress += 1
                    Next
                    ProgressBar1.Maximum = iProgress * 2 '  multiply by 2 to use when getting files/and when copying files to Destination Folder.

                    ' ---------- create Year/Months Folder -------------\\
                    '  string arrays to create all subfolders.
                    Dim xMonths() As String = {"01 - January", "02 - February", "03 - March", "04 - April", "05 - May", "06 - June", _
                                               "07 - July", "08 - August", "09 - September", "10 - October", "11 - November", "12 - December"}

                    If IO.Directory.Exists(fbd.SelectedPath) Then '  check if folder exists.
                        For Each strFolder As String In Directory.GetDirectories(fbd.SelectedPath) '  get all Year folders.
                            '  get only Year from fullpath of folder.
                            Dim sYearFolder As String = sDestinationFolder & "\" & strFolder.Substring(strFolder.LastIndexOf("\") + 1, strFolder.Length - strFolder.LastIndexOf("\") - 1) & "\"
                            If Not Directory.Exists(sYearFolder) Then '  check if Year folder does Not exist.
                                Directory.CreateDirectory(sYearFolder) '  create Year folder.
                                For Each itm As String In xMonths '  create SubFolders for each month.
                                    Directory.CreateDirectory(sYearFolder & itm)
                                Next
                            End If
                        Next
                    End If

                    ' ---------- get all Original Files from "Files" folder  -------------\\
                    Dim arOriginalFiles As New ArrayList
                    For Each myOriginalFile As String In My.Computer.FileSystem.GetFiles _
                                                                (fbd.SelectedPath, FileIO.SearchOption.SearchAllSubDirectories, "*.DLF")
                        arOriginalFiles.Add(Path.GetFileNameWithoutExtension(myOriginalFile))
                        ProgressBar1.Value += 1
                    Next

                    ' ---------- Copy all files to new Folder Locations  -------------\\
                    For Each itm As String In arOriginalFiles
                        Dim arTemp() As String = itm.Split("."c) '  get month/day/year
                        Dim iTemp As Integer = CInt(arTemp(0)) - 1 '  month number -1 to locate xMonths folder by index.
                        '  get Original File Path.
                        Dim sOriginalFilePath As String = fbd.SelectedPath & "\" & arTemp(2) & "\" & xMonths(iTemp) & "\" & itm & ".DLF"
                        '  set New Path for File to be copied.
                        Dim sNewFilePath As String = sDestinationFolder & arTemp(2) & "\" & xMonths(iTemp) & "\" & itm & ".DLF"
                        If Not File.Exists(sNewFilePath) Then '  if new File does not exist.
                            File.Copy(sOriginalFilePath, sNewFilePath) '  copy.
                        Else
                            File.Delete(sNewFilePath) '  delete.
                            File.Copy(sOriginalFilePath, sNewFilePath) '  & copy.
                        End If
                        ProgressBar1.Value += 1
                    Next
                    MsgBox("All Files Restored Sucessfully.", MsgBoxStyle.Information)
                    MsgBox("You should save your work, close DailyLog and restart. ", MsgBoxStyle.Information)
                Catch ex As Exception
                    MsgBox("Error Restoring Files.", MsgBoxStyle.Critical, "DailyLog Error")
                End Try
            End If
        End If
    End Sub
#End Region

#Region "//================ OK/APPLY BUTTONS  =========================================================="

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

        '  Show WAIT cursor
        xSetBusyCursor()

        For Each txt In New TextBox() {txtAddOfficer, txtAddAgency, txtAddSupervisor, txtAddArea, txtAddID}
            If txt.Text = "" Then
                If Not tcMain.SelectedTab Is tbAgency Then tcMain.SelectedTab = tbAgency '// select tab if not selected.
                txt.BackColor = Color.Red
                Exit Sub '// skip remaing.code.
            End If
        Next


        SaveRequiredFields()

        Me.Options() ' Save details

        Me.Close() ' Close this form

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click

        '  Show WAIT cursor
        xSetBusyCursor()

        SaveRequiredFields()

        Me.Options() ' Save details

    End Sub

    Private Sub Options()
        x.saveSettingsAndDataFile()
        saveFile(x.myQuickPickFile, lvCallQuickPick)
        If bThemeUpdated = True Then x.theme()
    End Sub

    Public Sub SaveRequiredFields()



        If txtAddOfficer.Text = vbNullString Then
            txtAddOfficer.BackColor = Color.Red
            MsgBox("Please enter an officer", MsgBoxStyle.Critical, "Required Field")
            tcMain.SelectedIndex = 0
            txtAddOfficer.Select()
            Exit Sub
        End If

        If txtAddAgency.Text = vbNullString Then
            txtAddAgency.BackColor = Color.Red
            MsgBox("Please enter an agency", MsgBoxStyle.Critical, "Required Field")
            tcMain.SelectedIndex = 0
            txtAddAgency.Select()
            Exit Sub
        End If

        If txtAddSupervisor.Text = vbNullString Then
            txtAddSupervisor.BackColor = Color.Red
            MsgBox("Please enter an supervisor", MsgBoxStyle.Critical, "Required Field")
            tcMain.SelectedIndex = 0
            txtAddSupervisor.Select()
            Exit Sub
        End If


        If txtAddArea.Text = vbNullString Then
            txtAddArea.BackColor = Color.Red
            MsgBox("Please enter a patrol area", MsgBoxStyle.Critical, "Required Field")
            tcMain.SelectedIndex = 0
            txtAddArea.Select()
            Exit Sub
        End If

        If txtAddID.Text = vbNullString Then
            txtAddID.BackColor = Color.Red
            MsgBox("Please enter your ID.", MsgBoxStyle.Critical, "Required Field")
            tcMain.SelectedIndex = 0
            txtAddID.Select()
            Exit Sub
        End If

    End Sub

#End Region

#Region "//================ THEME SWITCHING FUNCTIONS =================================================="

    Private Sub addRbThemeHandlers()
        For Each rb In New RadioButton() _
            {rbBlackBackground, rbOliveGreenBackground, rbOrangeBackground, rbBlueBackground, rbWhiteBackground, rbGreyBackground, rbLightBlueBackground, rbDarkRedBackground, _
             rbYellowText, rbRedText, rbWhiteText, rbGreenText, rbOrangeText, rbBlackText}
            AddHandler rb.CheckedChanged, AddressOf _rbThemes_CheckedChanged
        Next
    End Sub

    Private Sub _rbThemes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        x.theme()
    End Sub

#End Region

#Region "//================ CALL DETAILS QUICK NOTES SECTION ==========================================="

    ' Add the quick note to the text file
    Private Sub btnAddCallQuickNotes_Click(sender As Object, e As EventArgs) Handles btnAddCallQuickNotes.Click
        If Not txtCallQuickNotes.Text = "" Then
            Dim newItem As New ListViewItem(txtCallQuickNotes.Text)
            lvCallQuickPick.Items.Add(newItem)
        Else
            MsgBox("Values cannot be empty.", MsgBoxStyle.Critical)
        End If
        '// ======= CLEAR THE TEXT BOXES ====================
        txtCallQuickNotes.Text = ""
    End Sub

    ' Delete the selected note
    Private Sub btnDeleteCallQuickNotes_Click(sender As Object, e As EventArgs) Handles btnDeleteCallQuickNotes.Click
        If Not lvCallQuickPick.SelectedItems.Count = 0 Then
            If MessageBox.Show("Delete selected Quick Pick?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                lvCallQuickPick.Items.Remove(lvCallQuickPick.SelectedItems(0))
            End If
        Else
            MsgBox("Please select a Quick Pick to delete.", MsgBoxStyle.Information)
        End If
    End Sub

    Public Sub loadFile(ByVal FileToLoad As String, ByVal selectedListView As ListView)

        selectedListView.Items.Clear() ' Clear the listview first
        lvCallQuickPick.View = View.Details
        lvCallQuickPick.Columns.Add("Description", 400)
        'lvCallQuickPick.FullRowSelect = True
        If IO.File.Exists(myQuickPickFile) Then '// check if file exists.
            Dim myCoolFileLines() As String = IO.File.ReadAllLines(myQuickPickFile) '// load your file as a string array.
            For Each line As String In myCoolFileLines '// loop thru array list.
                Dim lineArray() As String = line.Split("") '// 
                Dim newItem As New ListViewItem(lineArray(0)) '// add Call Details Quick Pick
                selectedListView.Items.Add(newItem) '// add Item to ListView.

            Next
        End If
    End Sub

    Public Sub saveFile(ByVal FileToSave As String, ByVal selectedListView As ListView)
        Dim myWriter As New IO.StreamWriter(myQuickPickFile)
        For Each myItem As ListViewItem In lvCallQuickPick.Items
            myWriter.WriteLine(myItem.Text) '// write Item 
        Next
        myWriter.Close()
    End Sub

    Private Sub lvCallQuickPick_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvCallQuickPick.Click, lvCallQuickPick.SelectedIndexChanged
        If Not lvCallQuickPick.SelectedItems.Count = 0 Then
            Try
                With lvCallQuickPick.SelectedItems(0)
                    txtCallQuickNotes.Text = .Text
                End With
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub btnQuickPickUp_Click(sender As Object, e As EventArgs) Handles btnQuickPickUp.Click
        x.moveListViewItemUP(lvCallQuickPick)
        lvCallQuickPick_Click(sender, e)
    End Sub

    Private Sub btnQuickPickDown_Click(sender As Object, e As EventArgs) Handles btnQuickPickDown.Click
        x.moveListViewItemDOWN(lvCallQuickPick)
        lvCallQuickPick_Click(sender, e)
    End Sub



#End Region

    Private Sub btnDonate_Click(sender As Object, e As EventArgs)
        'Open the donation form
        Dim url As String = x.urlDonate
        Process.Start(url)
    End Sub

End Class