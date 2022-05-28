'  Welcome to DailyLog
'  Created by R. Taylor
'  Started sometime around June 2010, and never ending...
'  ===== LINKS ON IMPORTING DATA
'  http://www.daniweb.com/software-development/vbnet/threads/205132
'  http://vbdotnet.canbal.com/index.php?/Using-VisualBasic-net/resolved-filling-textbox-with-mysql-data.html
'  http://www.vbforums.com/showthread.php?t=468649
'  http://neuronex.co.uk/documents/hints_tips/path_strings.html Application Strings


Imports System
Imports System.IO
Imports System.Text
Imports System.Drawing.Printing
Imports System.Windows.Forms
Imports System.Net
Imports System.Drawing.Imaging
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices
Imports Word = Microsoft.Office.Interop.Word
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Word




Public Class FrmMain

#Region "//================ STRINGS-N-STUFF ======================================================="

    Private WithEvents TmrMain As New Timer With {.Interval = 100, .Enabled = True} '  Timer to Display Current Time.

#End Region

#Region "//================ FORM LOADING ============================================"

    Public Sub FrmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Try

            ' Hide this main form on startup to try to give it the appearance of a cleaner startup
            ' so the user doesn't see everything getting generated. It will open back up at the end of this sub 
            Me.Hide()

            Dim frmLogin As New frmLogin
            frmLogin.Show()


            frmLogin.LoginProgressBar1.Increment(10)

            Control.CheckForIllegalCrossThreadCalls = False

            ' Load Settings and Data File.
            x.loadSettingsAndDataFile()

            Me.Text = "DailyLog " & x.displayAppVersion & "" & "  " & " " & lblOfficer.Text & "  " & lblAgency.Text & ""

            ' hide the reporting tab for now
            Me.TabControl1.TabPages.Remove(Me.TabReporting)
            'Me.TabControl1.TabPages.Add(Me.TabReporting)

            frmLogin.LoginProgressBar1.Increment(20)

            ' Clean up title bar in case the name and agency doesn't come through.
            If Me.Text = "DailyLog " & x.displayAppVersion & "" & "  " & " " & "lblOfficer" & "  " & "lblAgency" Then
                Me.Text = "DailyLog " & x.displayAppVersion & "" & "  " & ""
            End If

            ' Load the per-user backup files 
            loadBackupIDlist(myBackupRestoreListFile)

            frmLogin.LoginProgressBar1.Increment(30)
            'Threading.Thread.Sleep(2000)

            ' Hide the repoprting tab for now. I'll work on reporting later
            Me.TabReporting.Visible = False

            frmLogin.LoginProgressBar1.Increment(40)

            '' Create the Global Data and Settingsfile
            'Dim load2 As New ClsLocationsCallTypes
            'ClsLocationsCallTypes.CreateGlobalDataAndSettings()

            frmLogin.LoginProgressBar1.Increment(50)
            'Threading.Thread.Sleep(2000)

            ' Play the Welcome Voice
            'Dim cls As New ClsAudio
            'cls.WelcomeSound()


            ' --------- set lblFileDate.Text/lvMain.Tag as Today - Load Today's File if File.Exists. ---------
            set_lblFileDate_lvMainTag_asToday()
            If Directory.Exists(currentUserFilesFolder) Then
                For Each DailyLogFile As String In My.Computer.FileSystem.GetFiles(currentUserFilesFolder, FileIO.SearchOption.SearchAllSubDirectories, "*.DLF")
                    If lblFileDate.Text = Path.GetFileNameWithoutExtension(DailyLogFile) Then
                        x.loadFile(Path.GetFullPath(DailyLogFile)) ' Load File if File.Exists(for same Day)
                        Exit For
                    End If
                Next
            End If





            frmLogin.LoginProgressBar1.Increment(60)

            ' Color Theme
            If frmOptions.cbNightMode.Checked = True Then x.theme() ' Start in Night Mode if checked
            x.theme()

            frmLogin.LoginProgressBar1.Increment(70)
            'Threading.Thread.Sleep(2000)

            x.moveFilesToUserFolder("2010") : x.moveFilesToUserFolder("2011") : x.moveFilesToUserFolder("2012")
            'MsgBox("done")

            ' Loading this into reporting
            Me.TxtPrimaryOfficer_.Text = frmOptions.txtAddOfficer.Text
            Me.TxtPrimaryID1_.Text = frmOptions.txtAddID.Text


            ' Load up the backup file
            x.loadBackupIDlist(myBackupRestoreListFile)

            frmLogin.LoginProgressBar1.Increment(80)

            ' Limit numbers in the mileage. Never would need 7 decimal points...
            txtStartMiles.MaxLength = 6 : txtEndMiles.MaxLength = 6

            frmLogin.LoginProgressBar1.Increment(90)

            ' Close frmLogin on a sucessful login.
            frmLogin.Close()

            frmLogin.LoginProgressBar1.Increment(100)
            'Threading.Thread.Sleep(2000)


            ' Ok, lets show the form now that everything is drawn.
            Me.Visible = True

            ' If the file date is 0's, automatically open the Open Log window. Looks better. 
            If lblFileDate.Text = "00.00.0000" Then
                ' pop this from up top from the main form
                frmOpenLog.TopMost = True
                frmOpenLog.Show()
            End If

            If Me.Text = "DailyLog " & x.displayAppVersion & "" & " " & "" Then
                MsgBox("If this is the first time starting DailyLog Basic, please enter your information in the Options screen. Items in red are required. Make sure you RESTART DailyLog after you enter your information. ")
                frmOptions.ShowDialog()
            End If

            If frmOptions.txtAddOfficer.Text = "" Then
                MsgBox("It appears you are missing your name in the Options. Items in red are required. Make sure you RESTART DailyLog after you enter your information. ")
                frmOptions.ShowDialog()

                'MsgBox("Please enter an officer", MsgBoxStyle.Critical, "Required Field")
                frmOptions.tcMain.SelectedIndex = 0
                frmOptions.txtAddOfficer.Select()
                frmOptions.txtAddOfficer.BackColor = Color.Red
            End If

            If frmOptions.txtAddID.Text = "" Then
                MsgBox("It appears you are missing your ID in the Options. Items in red are required. Make sure you RESTART DailyLog after you enter your information. ")
                frmOptions.ShowDialog()

                'MsgBox("Please enter your ID", MsgBoxStyle.Critical, "Required Field")
                frmOptions.tcMain.SelectedIndex = 0
                frmOptions.txtAddID.Select()
                frmOptions.txtAddID.BackColor = Color.Red
            End If

            If frmOptions.txtAddAgency.Text = "" Then
                MsgBox("It appears you are missing your agency in the Options. Items in red are required. Make sure you RESTART DailyLog after you enter your information. ")
                frmOptions.ShowDialog()

                'MsgBox("Please enter your agency", MsgBoxStyle.Critical, "Required Field")
                frmOptions.tcMain.SelectedIndex = 0
                frmOptions.txtAddAgency.Select()
                frmOptions.txtAddAgency.BackColor = Color.Red
            End If

            If frmOptions.txtAddSupervisor.Text = "" Then
                MsgBox("It appears you are missing your supervisor in the Options. Items in red are required. Make sure you RESTART DailyLog after you enter your information. ")
                frmOptions.ShowDialog()

                'MsgBox("Please enter your supervisor", MsgBoxStyle.Critical, "Required Field")
                frmOptions.tcMain.SelectedIndex = 0
                frmOptions.txtAddSupervisor.Select()
                frmOptions.txtAddSupervisor.BackColor = Color.Red
            End If

            If frmOptions.txtAddArea.Text = "" Then
                MsgBox("It appears you are missing your patrol area in the Options. Items in red are required. Make sure you RESTART DailyLog after you enter your information. ")
                frmOptions.ShowDialog()

                'MsgBox("Please enter your patrol area", MsgBoxStyle.Critical, "Required Field")
                frmOptions.tcMain.SelectedIndex = 0
                frmOptions.txtAddArea.Select()
                frmOptions.txtAddArea.BackColor = Color.Red
            End If

            ' A couple of installed in the past have been missing the favicon.ico for some reason
            ' Lets put this try-catch in here and prompt the user to reinstall
            ' and shut the app down
        Catch ex As Exception
            If MsgBox("An exception occurred- please re-install DailyLog" & vbCrLf & ex.Message) Then
                System.Windows.Forms.Application.Exit()

                ' 'If MsgBox("It appears your install had an issue. Please re-install DailyLog from your install file or download it again.", MsgBoxStyle.OkCancel, "Re-Install DailyLog") = MsgBoxResult.Ok Then
                ' 'Application.Exit()

            End If



        End Try

        ' Need to be moved to form load for REPORTING
        LblDateTimeReporting.Text = DateTime.Now.ToString("hh:mm:ss tt")
        TxtPrimaryOfficer_.Text = frmOptions.txtAddOfficer.Text
    End Sub

#End Region

#Region "//================ FORM CLOSING ============================================"

    Private Sub FrmMain_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Deactivate
        ' A couple of installed in the past have been missing the favicon.ico for some reason
        ' Lets put this try-catch in here and prompt the user to reinstall
        ' and shut the app down
        Try
            ' Save the per user setting backup file
            saveFile(x.currentUserBackupFile())
        Catch ex As Exception
            If MsgBox("An exception occurred- please re-install DailyLog" & vbCrLf & ex.Message) Then
                System.Windows.Forms.Application.Exit()
            End If

        End Try

    End Sub

    Public Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        ' A couple of installed in the past have been missing the favicon.ico for some reason
        ' Lets put this try-catch in here and prompt the user to reinstall
        ' and shut the app down
        Try

            xSetBusyCursor()

            ' Go right back to todays file when the app closes.
            ' This is so it closes and uploads TODAYS mileage to MySQL
            ' UPDATE- this caused a problem after midnight. It jumped to the next day (today) and forced to save a 
            ' blank file, but asked for mileage. It messed me up.
            'btnToday_Click(sender, e)

            ' Deal with the blank end mileage box, so the blank box doesn't get saved in the DB.
            If txtEndMiles.Text = vbNullString Then
                txtEndMiles.BackColor = Color.Red
                ClsTopMostMessageBox.Show("Mileage ERROR", "End Mileage REQUIRED", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                e.Cancel = True
                Exit Sub
            End If

            ' Description, please
            x.saveBackupIDlist(myBackupRestoreListFile)

            ' Jump to the entire shutdown sequence in x.vb
            x.ShutdownSequence()
        Catch ex As Exception
            ' A couple of installed in the past have been missing the favicon.ico for some reason
            ' Lets put this try-catch in here and prompt the user to reinstall
            ' and shut the app down
        End Try
    End Sub

#End Region

#Region "//================ MISC CODE, INCLUDING CALCULATE SHIFT TIMES/RESIZE COLUMN CODE ========="

    Private Sub mDownloadUpdate_Help_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start(x.urlManualUpdate)

    End Sub


    Private sStatsTime, sStatsTime2 As String
    ' Calculate the shift times every 1 second instead of manually doing it...
    Private Sub TmrStats_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrStats.Tick
        '//Lets calculate all of our times, shall we?-
        sStatsTime = Format(CDbl(FrmCallDetails.roundTime(Str(Val(cmbObligatedCity.Text.Replace(":", ".")) + Val(cmbNonObligatedCity.Text.Replace(":", ".")) + Val(cmbStat15City.Text.Replace(":", "."))))), "0.00")
        lblTotalCityTime.Text = sStatsTime.Replace(".", ":")
        sStatsTime = Format(CDbl(FrmCallDetails.roundTime(Str(Val(cmbObligatedCounty.Text.Replace(":", ".")) + Val(cmbNonObligatedCounty.Text.Replace(":", ".")) + Val(cmbStat15County.Text.Replace(":", ".")) + Val(cmbStat16County.Text.Replace(":", "."))))), "0.00")
        lblTotalCountyTime.Text = sStatsTime.Replace(".", ":")
        sStatsTime = lblTotalCountyTime.Text.Replace(":", ".") '// replace back to "."
        sStatsTime2 = lblTotalCityTime.Text.Replace(":", ".")
        lblTotalStats.Text = Format(CDbl(FrmCallDetails.roundTime(Str(Val(CDbl(sStatsTime)) + Val(CDbl(sStatsTime2))))), "0.00").Replace(".", ":") '// add the dots and replace back to ":".
    End Sub

    ' Display current time and Save BackupFile.
    Private Sub TmrMain_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TmrMain.Tick
        lblTime.Text = Format(TimeOfDay, "HH:mm:ss")
        Static i As Integer = 0
        If Not i = 250 Then
            i += 1
            Exit Sub
        End If
        If i = 250 Then
            x.saveFile(currentUserBackupFile())
            i = 0
        End If
    End Sub


    Private Sub set_lblFileDate_lvMainTag_asToday()
        Dim sTemp As String = Date.Now.Month & "." & Date.Now.Day & "." & Date.Now.Year
        Dim arTemp() As String = sTemp.Split(".")
        If arTemp(1).Length = 1 Then ' check if Length is 1, for Files less than 10 for Day.
            sTemp = arTemp(0) & ".0" & arTemp(1) & "." & arTemp(2) ' add a "0" to day.
        End If
        lblFileDate.Text = sTemp
        lvMain.Tag = sTemp ' used for FileName when Saving File.
    End Sub

    Private Sub _lvMain_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvMain.DoubleClick
        If Not lvMain.SelectedItems.Count = 0 Then
            x.bAllowEntryEditing = True ' set True to edit selection.
            Dim newfrmCallDetails As New FrmCallDetails ' new FrmCallDetails.
            newfrmCallDetails.ShowDialog()
        End If
    End Sub

    ' Numeric Mileage.
    'Private Sub _txtMileage_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    If Not IsNumeric(e.KeyChar) Then e.Handled = True ' block Non-Numeric.
    '    If e.KeyChar = vbBack Then e.Handled = False ' allow backspace key.
    'End Sub

    Private Sub txtStartMiles_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStartMiles.KeyPress
        Try
            Dim allowedChars As String = "0123456789"
            If allowedChars.IndexOf(e.KeyChar) = -1 AndAlso
                        Not e.KeyChar = ChrW(8) Then
                ' Invalid Character
                e.Handled = True
            End If
        Catch ex As Exception
            'MsgBox(ex.Message, "MESSAGE", ex)
        End Try
    End Sub

    Private Sub txtEndMiles_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEndMiles.KeyPress
        Try
            Dim allowedChars As String = "0123456789"
            If allowedChars.IndexOf(e.KeyChar) = -1 AndAlso
                        Not e.KeyChar = ChrW(8) Then
                ' Invalid Character
                e.Handled = True
            End If
        Catch ex As Exception
            'MsgBox(ex.Message, "MESSAGE", ex)
        End Try
    End Sub


    ' Empty the start, end mileage and trainning expiration with a mouse click
    Private Sub _txtMileage_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) _
                                            Handles txtStartMiles.MouseDown, txtEndMiles.MouseDown
        CType(sender, TextBox).Clear()
    End Sub


    Private Sub txtShiftNotes_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtShiftNotes.KeyDown
        ' Error #22
        ' Prevent the enter key from being used, which stops a line break, also
        ' prevent copying and pasting into the text box which can still do the same thing *sigh*
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
        ' Prevent pasting into the box
        If ModifierKeys = Keys.Control Then
            e.Handled = True
            txtShiftNotes.ReadOnly = True
        Else
            txtShiftNotes.ReadOnly = False
        End If
    End Sub

    Private Sub txtEndMiles_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEndMiles.TextChanged
        'Change text box back to white when mileage is entered
        txtEndMiles.BackColor = Color.White
    End Sub
    Private Sub txtEndMiles_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEndMiles.KeyUp
        'Allow ENTER to submit the mileage
        If e.KeyCode = Keys.Enter Then
            Me.Close()
        End If
    End Sub

    ''// only numeric, backspace and : for all the combo boxes
    Private Sub cmb_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim allowedChars As String = "0123456789:"
        If allowedChars.IndexOf(e.KeyChar) = -1 AndAlso
                    Not e.KeyChar = ChrW(8) Then
            ' Invalid Character
            e.Handled = True
        End If
    End Sub

    'Private Sub tmrRefreshCustomMessage_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrRefreshCustomMessage.Tick
    '    lblCustomMessage.Refresh()
    'End Sub


    Private Sub txtShiftNotes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtShiftNotes.Click
        ' Remove the ---NONE--- and allow the addition ofnotes after the date
        ' txtShiftNotes.Text = "Shift notes for " & DateTime.Today.ToShortDateString() & " -- "
        'Position the cursor after the text
        txtShiftNotes.Select(txtShiftNotes.Text.Length, 0)
    End Sub



#End Region

#Region "//================ MENU: All Options ====================================================="

    Private Sub mTools_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mTools.Click
        If Not lvMain.SelectedItems.Count = 0 Then : mDeleteSingleEntry_Tools.Enabled = True
        Else : mDeleteSingleEntry_Tools.Enabled = False
        End If
    End Sub

    Private Sub mNew_File_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mNew_File.Click
        Dim newfrmCallDetails As New FrmCallDetails '  new FrmCallDetails.
        newfrmCallDetails.Show()
    End Sub

    Private Sub mOpen_File_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mOpen_File.Click
        If Directory.Exists(currentUserFilesFolder) Then
            x.saveLogFile() : frmOpenLog.ShowDialog()
        Else : MsgBox("There are no previously saved files to process.", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub mExit_File_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mExit_File.Click
        '  Deal with the blank end mileage box, so the blank box doesn't get saved in the DB.
        If txtEndMiles.Text = vbNullString Then
            txtEndMiles.BackColor = Color.Red
            ClsTopMostMessageBox.Show("Mileage ERROR", "End Mileage REQUIRED", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Me.Close() ' Close Application
    End Sub
    Private Sub mSave_File_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mSave_File.Click
        xSetBusyCursor()
        System.Windows.Forms.Application.DoEvents()
        If lblFileDate.Text = "Backup File" Then
            'MsgBox("")
            btnToday_Click(sender, e)
        End If
        TmrStats_Tick(sender, e) ' Calculate Shift Stats time when the file is saved...

        x.saveLogFile() '  save current Log File LOCALLY
        'mSave_File_Click(sender, e) ' Save to Disk
    End Sub

    Private Sub mOptions_Tools_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mOptions_Tools.Click
        '  Enable/Disable mDeleteSingleEntry_Tools if item in lvMain is selected/not selected.
        frmOptions.ShowDialog()
        If Not lvMain.SelectedItems.Count = 0 Then : mDeleteSingleEntry_Tools.Enabled = True
        Else : mDeleteSingleEntry_Tools.Enabled = False
        End If
    End Sub
    Private Sub lvMain_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        '  Code to fix a bug with deleting any individual line
        If Not lvMain.SelectedItems.Count = 0 Then : mDeleteSingleEntry_Tools.Enabled = True
        Else : mDeleteSingleEntry_Tools.Enabled = False
        End If
    End Sub

    Public Sub mDayNight_Tools_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mDayNight_Tools.Click
        x.theme()
    End Sub

    Private Sub mCodes_Online_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' --Sterling Codifiers Website
        Process.Start(urlCodes)
    End Sub

    Private Sub mViewLogsHTML_Tools_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mViewLogsHTML_Tools.Click
        '  Open logs in HTML
        Try
            Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\DailyLog\HTML_Files\" & "" & lblID.Text & "")
        Catch ex As Exception
            MsgBox("                This folder has not been created yet. " _
     & vbNewLine & "       It will be created the first time you print a log. ")
        End Try
    End Sub

    Private Sub mStats_Tools_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mStats_Tools.Click
        ' Opens shift stats
        If Not frmStats.Visible = True Then
            frmStats.Show(Me)
        Else
            frmStats.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub mEditCallTypes_Tools_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mEditCallTypes_Tools.Click
        ' Edit Call Types/Locations
        frmEditCallDetails.Show()
    End Sub


    Private Sub mNewLogEntryOnPreviousDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mNewLogEntryOnPreviousDate.Click
        '  Create a new log based on a previous date
        frmNewDay.Show()
    End Sub

    Private Sub mSupport_Help_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '  Send Feedback to the web form
        '  Process.Start(urlSupport)
    End Sub

    Private Sub mUsingDailyLog_Help_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '  Send Feedback to the web form
        ' Process.Start(urlUsingDL)
    End Sub

    Private Sub mAbout_Help_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mAbout_Help.Click
        ' Top menu about menu
        frmAbout.Show()
    End Sub
    Private Sub m_AppDataFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m_AppDataFolder.Click
        Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\DailyLog")
    End Sub

    Private Sub mDelete_Single_Log_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mDeleteSingleEntry_Tools.Click
        If lvMain.SelectedItems.Count = 0 Then Exit Sub
        '  Asks if the user wants to CLEAR INDIVIDUAL LOG LINES
        Dim myDeleteMessage As String = "Are you sure? This will delete the selected log entry." '  a very cool message. :)
        Dim myDeleteTitle As String = "Delete Log Item" '  title of the message box(es).
        Dim myDeleteMsgBox As DialogResult '  declare a message box.

        myDeleteMsgBox = MessageBox.Show(myDeleteMessage, myDeleteTitle,
        MessageBoxButtons.OKCancel, MessageBoxIcon.Question) '  customize the message box.

        Select Case myDeleteMsgBox '  option to select a command for which button clicked.
            Case DialogResult.OK '  if pressed OK
                ' Delete last item in the listview
                If Not lvMain.SelectedItems.Count = 0 Then
                    lvMain.SelectedItems(0).Remove()
                End If
        End Select
    End Sub

    Private Sub mClearEntireLog_Tools_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mClearEntireLog_Tools.Click
        '  Asks if the user wants to CLEAR THE WHOLE LOG
        Dim myDeleteMessage As String = "Are you sure? This will delete ALL the log entrys." _
                                       & vbNewLine & "" '  a very cool message. :)
        Dim myDeleteTitle As String = "Delete Entire Log" '  title of the message box(es).
        Dim myDeleteMsgBox As DialogResult '  declare a message box.

        myDeleteMsgBox = MessageBox.Show(myDeleteMessage, myDeleteTitle,
        MessageBoxButtons.OKCancel, MessageBoxIcon.Question) '  customize the message box.

        Select Case myDeleteMsgBox '  option to select a command for which button clicked.
            Case DialogResult.OK '  if pressed OK
                clearForNewFile()
        End Select
    End Sub
    Public Sub clearForNewFile()
        lvMain.Items.Clear() ' Delete the whole listview
        ' Clear all the combo boxes and stuff now
        For Each ctl As Control In gbShiftStats.Controls
            If TypeOf (ctl) Is ComboBox Then ctl.Text = Nothing
        Next
        cmbStat1City.Text = ""
        cmbStat1County.Text = ""
        cmbStat2City.Text = ""
        cmbStat2County.Text = ""
        cmbStat3City.Text = ""
        cmbStat3County.Text = ""
        cmbStat4City.Text = ""
        cmbStat4County.Text = ""
        cmbStat5City.Text = ""
        cmbStat5County.Text = ""
        cmbStat6City.Text = ""
        cmbStat6County.Text = ""
        cmbStat7City.Text = ""
        cmbStat7County.Text = ""
        cmbObligatedCity.Text = ""
        cmbObligatedCounty.Text = ""
        cmbNonObligatedCity.Text = ""
        cmbNonObligatedCounty.Text = ""
        cmbStat8City.Text = ""
        cmbStat8County.Text = ""
        cmbStat9City.Text = ""
        cmbStat9County.Text = ""
        cmbStat10City.Text = ""
        cmbStat10County.Text = ""
        cmbStat11City.Text = ""
        cmbStat11County.Text = ""
        cmbStat12City.Text = ""
        cmbStat12County.Text = ""
        cmbStat13City.Text = ""
        cmbStat13County.Text = ""
        cmbStat14City.Text = ""
        cmbStat14County.Text = ""
        cmbStat15City.Text = ""
        cmbStat15County.Text = ""
        cmbStat16County.Text = ""
        lblTotalCityTime.Text = "0"
        lblTotalCountyTime.Text = "0"
        lblTotalStats.Text = "0"
        txtEndMiles.Text = ""
        txtShiftNotes.Text = ""
    End Sub
#End Region

#Region "//================ TOOLBAR: All Buttons =================================================="
    Private Sub Toolbar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnNew.Click, btnSave.Click, btnOpen.Click, btnPrint.Click, btnTheme.Click,
        btnOptions.Click, btnClose.Click


        '  Show WAIT cursor
        xSetBusyCursor()


        Dim btn As Button = CType(sender, Button)
        Select Case btn.Name
            Case "btnNew"
                ' Play the Click sound
                ' Dim cls As New ClsAudio
                'cls.ClickSound()
                ' Show WAIT cursor
                xSetBusyCursor()
                mNew_File_Click(sender, e) '  Open the Call Details form


            Case "btnPrint"
                ' Play the Click sound
                ' Dim cls As New ClsAudio
                'cls.ClickSound()
                ' Show WAIT cursor
                xSetBusyCursor()
                'mPrint_File_Click(sender, e) '  Quick Print
                '  Deal with the blank end mileage box, so the blank box doesn't get saved in the DB.
                If txtEndMiles.Text = vbNullString Then
                    txtEndMiles.BackColor = Color.Red
                    ClsTopMostMessageBox.Show("Mileage ERROR", "End Mileage REQUIRED", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If

                TmrStats_Tick(sender, e) '  Calculate Shift Stats time when the app is closed
                mSave_File_Click(sender, e) '  Save to Disk
                '  Because the print form uploads an HTML copy of the log file to the server, when
                '  log files are being uploaded at the same time, the form won't load the preview.
                '  So while log files are being uploaded, prevent a print preview untill the backup
                '  is complete.

                '  Print HTML log
                'Dim prt As New frmPrint
                'prt.printLogToHtml()
                frmPrint.ShowDialog()

            Case "btnSave"
                ' Play the Click sound
                'Dim cls As New ClsAudio
                'cls.ClickSound()
                ' Show WAIT cursor
                xSetBusyCursor()
                If lblFileDate.Text = "Backup File" Then
                    'MsgBox("")
                    btnToday_Click(sender, e)
                End If
                TmrStats_Tick(sender, e) ' Calculate Shift Stats time when the file is saved...
                mSave_File_Click(sender, e) ' Save to Disk


            Case "btnOpen"
                ' Play the Click sound
                ' Dim cls As New ClsAudio
                'cls.ClickSound()
                ' Show WAIT cursor
                xSetBusyCursor()
                mOpen_File_Click(sender, e) '  Open File
            Case "btnNew_Date"
                ' Play the Click sound
                'Dim cls As New ClsAudio
                'cls.ClickSound()
                ' Show WAIT cursor
                xSetBusyCursor()
                frmNewDay.Show() '  Open File

            Case "btnTheme"
                ' Play the Click sound
                'Dim cls As New ClsAudio
                ' cls.ClickSound()
                ' Show WAIT cursor
                xSetBusyCursor()
                x.theme() '  Change color (day/night)

            Case "btnOptions"
                ' Play the Click sound
                ' Dim cls As New ClsAudio
                'cls.ClickSound()
                '  Show WAIT cursor
                xSetBusyCursor()


                Try
                    frmOptions.ShowDialog() '  Opens Options Screen
                Catch ex As Exception
                End Try
            Case "btnOfficerInfo"
                ' Play the Click sound
                ' Dim cls As New ClsAudio
                ' cls.ClickSound()
                frmOptions.Show() '  Opens Options Screen
                frmOptions.tcMain.SelectedIndex = 0 '  Go straight to Officer Options

            Case "btnDonate"
                ' Play the Click sound
                'Dim cls As New ClsAudio
                ' cls.ClickSound()
                Dim url As String = x.urlDonate
                Process.Start(url) 'Opens Donation Screen

            Case "btnClose"
                ' Play the Click sound
                ' Dim cls As New ClsAudio
                'cls.ClickSound()
                ' Show WAIT cursor
                xSetBusyCursor()
                TmrStats_Tick(sender, e) '  Calculate Shift Stats time when the file is saved...
                mSave_File_Click(sender, e) '  Save to Disk
                Try
                    Me.Close() ' Close Application
                Catch ex As Exception
                End Try
        End Select
    End Sub
#End Region

#Region "//================ ALL EXCEL AND PRINTING FUNCTIONS ======================================"

    Private Sub mPrint_File_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        TmrStats_Tick(sender, e) '  Calculate Shift Stats just before printing
        'Dim cls As New clsPrint
        'cls.printDailyLog()

        '  Print HTML log
        Dim prt As New frmPrint
        prt.printLogToHtml()

    End Sub

#End Region

#Region "//================ btnBACK / btnFwd / btnToday ======================================="

    '  All of the code below is traken straight from a legacy version, version 2.8
    '  Version 3.8.367 was using the more current code written by CodyZ, but there were still
    '  some minor issues here and there, so the decision was made to go back to a code section
    '  that was working good "back in the day", so lets try the old code for a while
    '  and see how it performs. It will not save the logs anywhere however, that log saving
    '  seemed to create a lot of problems with saving todays log with old log data.
    '  This old legacy code is still good, solid code that seems to work pretty fine.
    '  UPDATE as of version 6.0 it's still working fine with no issues.


    ''  Show WAIT cursor
    '                xSetBusyCursor()
    '                



    Private arList_Files As New ArrayList '  store Available Files from Folders.
    Private iArListIndex As Integer = 0 '  index to select item in ArrayList.

    Private Sub btnBackForward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
                                               Handles btnBack.Click, btnFwd.Click
        Dim btn As Button = CType(sender, Button)
        Select Case btn.Name
            Case "btnBack"
                If Not iArListIndex = 0 Then '  check if Not First Item.
                    iArListIndex -= 1 '  -1 for Index of ArrayList.
                    loadFileFromArrayList(arList_Files(iArListIndex))
                End If
            Case "btnFwd"
                If Not iArListIndex = arList_Files.Count - 1 Then '  check if Not Last Item.
                    iArListIndex += 1 '  +1 for Index of ArrayList.
                    loadFileFromArrayList(arList_Files(iArListIndex))
                End If
        End Select
    End Sub

    '  toggle btnToday ( Enabled/Disabled )
    Private Sub lblFileDate_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblFileDate.TextChanged
        Dim sTemp As String = Date.Now.Month & "." & Date.Now.Day & "." & Date.Now.Year
        Dim arTemp() As String = sTemp.Split(".")
        If arTemp(1).Length = 1 Then sTemp = arTemp(0) & ".0" & arTemp(1) & "." & arTemp(2) '  add a "0" to day if less than 10.
        If Not lblFileDate.Text = sTemp Then : btnToday.Enabled = True : Else : btnToday.Enabled = False : End If '  disable btnToday if "Today".
    End Sub

    Private Sub loadFileFromArrayList(ByRef arListSelection As String)
        lblFileDate.Text = Path.GetFileNameWithoutExtension(arListSelection) '  set only FileName.
        lvMain.Tag = Path.GetFileNameWithoutExtension(arListSelection) '  set only FileName.
        loadFile(arListSelection) '  Load File.
    End Sub

    '  load ArrayList if Empty.
    Private Sub btnBackForward_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) _
                                                Handles btnBack.MouseDown, btnFwd.MouseDown
        loadArrayList()
    End Sub

    Private Sub loadArrayList()
        If arList_Files.Count = 0 Then '  check if empty to not reload.
            If Directory.Exists(currentUserFilesFolder) Then '  check if "Files" folder exists.
                '  retrieve all Files from Folders/SubFolders.
                For Each DailyLogFile As String In My.Computer.FileSystem.GetFiles _
                                                                    (currentUserFilesFolder, FileIO.SearchOption.SearchAllSubDirectories, "*.DLF")
                    arList_Files.Add(Path.GetFullPath(DailyLogFile)) '  add FullPath to ArrayList.
                Next
                '  loop thru ArrayList to get current File's index.
                For i As Integer = 0 To arList_Files.Count - 1
                    '  check if FileName(not FullPath)=Label's.Text.
                    If Path.GetFileNameWithoutExtension(arList_Files(i)) = lblFileDate.Text Then
                        iArListIndex = i '  add Index of item in ArrayList.
                        Exit For
                    End If
                Next
            End If
        End If
    End Sub

    '  Enable/Disable Buttons depending if First/Last File Selected.
    Private Sub btnBackForward_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) _
                                    Handles btnBack.MouseUp, btnFwd.MouseUp
        If iArListIndex = 0 Then : btnBack.Enabled = False : Else : btnBack.Enabled = True : End If '  if First item in ArrayList.
        If iArListIndex = arList_Files.Count - 1 Then : btnFwd.Enabled = False : Else : btnFwd.Enabled = True : End If '  if Last item in ArrayList.
    End Sub


    Private Sub btnToday_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnToday.Click
        arList_Files.Clear()
        loadArrayList()
        Try
            For Each DailyLogFile As String In My.Computer.FileSystem.GetFiles _
                                            (currentUserFilesFolder, FileIO.SearchOption.SearchAllSubDirectories, "*.DLF")
                If Not File.Exists(DailyLogFile) Then
                    set_lblFileDate_lvMainTag_asToday()
                    Exit Sub
                End If
            Next
        Catch ex As Exception

        End Try
        Try
            For Each DailyLogFile As String In My.Computer.FileSystem.GetFiles _
                                                        (currentUserFilesFolder, FileIO.SearchOption.SearchAllSubDirectories, "*.DLF")
                If Not File.Exists(DailyLogFile) Then
                    set_lblFileDate_lvMainTag_asToday()
                    Exit Sub
                End If
            Next
        Catch ex As Exception

        End Try

        Dim sTemp As String = Date.Now.Month & "." & Date.Now.Day & "." & Date.Now.Year
        Dim arTemp() As String = sTemp.Split(".")
        If arTemp(1).Length = 1 Then
            sTemp = arTemp(0) & ".0" & arTemp(1) & "." & arTemp(2) '  add a "0" to day.
        End If
        '  get Index in ArrayList.
        For i As Integer = 0 To arList_Files.Count - 1
            If Path.GetFileNameWithoutExtension(arList_Files(i)) = sTemp Then
                iArListIndex = i
                Exit For
            End If
        Next
        Try
            loadFileFromArrayList(arList_Files(iArListIndex))
            If Path.GetFileNameWithoutExtension(arList_Files(iArListIndex)) = sTemp Then btnFwd.Enabled = False
        Catch ex As Exception
            'Removing log files but having a backup file causes it to crash here. Export log files, then delete them
            'Load up DL and this is where it crashed.
        End Try
    End Sub

#End Region

#Region "//================ REMOVE THE RED X UPPER RIGHT CORNER (REFERENCE ONLY) =================="

    ''  http://stackoverflow.com/questions/1743433/visually-remove-disable-close-button-from-title-bar-net
    'Private Const CP_NOCLOSE_BUTTON As Integer = &H200
    'Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
    '    Get
    '        Dim myCp As CreateParams = MyBase.CreateParams
    '        myCp.ClassStyle = myCp.ClassStyle Or CP_NOCLOSE_BUTTON
    '        Return myCp
    '    End Get
    'End Property

#End Region

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim oWord As Word.Application
        Dim oDoc As Word.Document
        Dim oRng As Word.Range


        'OPENS TEMPLATE
        'Start Word and open the document template.
        oWord = CreateObject("Word.Application")
        'oWord.Visible = True
        oDoc = oWord.Documents.Add("C:\DailyLog\Report_Template.docx")
        ' ("C:\Users\robrt\AppData\Local\DailyLog\Critical\Report_Template.dotx")


        ' CASE DETAILS
        oDoc.Content.Find.Execute(FindText:="blankagency_", ReplaceWith:=Me.lblAgency.Text)
        oDoc.Content.Find.Execute(FindText:="reporttype_", ReplaceWith:="INCIDENT REPORT")
        oDoc.Content.Find.Execute(FindText:="casenumber_", ReplaceWith:=Me.Txt_Case.Text)
        oDoc.Content.Find.Execute(FindText:="datereported_", ReplaceWith:=DateTime.Now.ToString("hh:mm:ss tt"))
        oDoc.Content.Find.Execute(FindText:="dateoccurred_", ReplaceWith:=Me.TxtOffence_Date.Text)
        oDoc.Content.Find.Execute(FindText:="primaryofficer_", ReplaceWith:=frmOptions.txtAddOfficer.Text)
        oDoc.Content.Find.Execute(FindText:="assistingofficer_", ReplaceWith:=Me.TxtSecondaryOfficer1_.Text)

        ' Officer ID's
        oDoc.Content.Find.Execute(FindText:="Id1_", ReplaceWith:=Me.TxtPrimaryID1_.Text)
        oDoc.Content.Find.Execute(FindText:="Id2_", ReplaceWith:=Me.TxtPrimaryID2_.Text)

        ' This little section for the report checkboxes 
        If Not CbVideoAttached1_.Checked Then
            oDoc.Content.Find.Execute(FindText:="video1_", ReplaceWith:="Video NOT Attached")
        Else
            oDoc.Content.Find.Execute(FindText:="video1_", ReplaceWith:="Video Attached")
        End If

        If Not CbVideoAttached2_.Checked Then
            oDoc.Content.Find.Execute(FindText:="video2_", ReplaceWith:="Video NOT Attached")
        End If

        If Me.TxtSecondaryOfficer1_.Text = "" Then
            oDoc.Content.Find.Execute(FindText:="video2_", ReplaceWith:="")
        End If
        ' End report checkboxes


        oDoc.Content.Find.Execute(FindText:="IncidentLocationAddress_", ReplaceWith:=Me.TxtIncidentAddress.Text)
        oDoc.Content.Find.Execute(FindText:="assistingofficer_", ReplaceWith:=Me.TxtSecondaryOfficer1_.Text)
        oDoc.Content.Find.Execute(FindText:="additionalreports_", ReplaceWith:=Me.CmbAdditionalReports.Text)

        ' Offences
        oDoc.Content.Find.Execute(FindText:="offence1_", ReplaceWith:=Me.TxtOffence1_.Text)
        oDoc.Content.Find.Execute(FindText:="offence2_", ReplaceWith:=Me.TxtOffence2_.Text)
        oDoc.Content.Find.Execute(FindText:="offence3_", ReplaceWith:=Me.TxtOffence3_.Text)

        ' Law Codes
        oDoc.Content.Find.Execute(FindText:="lawcd1_", ReplaceWith:=Me.TxtLawCode1_.Text)
        oDoc.Content.Find.Execute(FindText:="lawcd2_", ReplaceWith:=Me.TxtLawCode2_.Text)
        oDoc.Content.Find.Execute(FindText:="lawcd3_", ReplaceWith:=Me.TxtLawCode3_.Text)

        ' Counts

        oDoc.Content.Find.Execute(FindText:="counts1_", ReplaceWith:=Me.TxtCounts1_.Text)
        oDoc.Content.Find.Execute(FindText:="counts2_", ReplaceWith:=Me.TxtCounts2_.Text)
        oDoc.Content.Find.Execute(FindText:="counts3_", ReplaceWith:=Me.TxtCounts3_.Text)

        ' Offence Severity
        If CbFelony_.Checked Then
            oDoc.Content.Find.Execute(FindText:="offencetype1_", ReplaceWith:="Felony")
        End If

        If CbMisd_.Checked Then
            oDoc.Content.Find.Execute(FindText:="offencetype1_", ReplaceWith:="Misdemeanor")
        End If

        If CbCivilWarrant_.Checked Then
            oDoc.Content.Find.Execute(FindText:="offencetype1_", ReplaceWith:="Civil Warrant")
        End If

        If CbCrimWarrant_.Checked Then
            oDoc.Content.Find.Execute(FindText:="offencetype1_", ReplaceWith:="Criminal Warrant")
        End If

        If CbNonCrim_.Checked Then
            oDoc.Content.Find.Execute(FindText:="offencetype1_", ReplaceWith:="Non Criminal")
        End If

        If CbDocumentation_.Checked Then
            oDoc.Content.Find.Execute(FindText:="offencetype1_", ReplaceWith:="Documentation Only")
        End If

        If CmbAdditionalReports.Text = "Select" Then
            oDoc.Content.Find.Execute(FindText:="additionalreports_", ReplaceWith:="None")
        End If


        ' PERSON 1 INFO
        oDoc.Content.Find.Execute(FindText:="person1_", ReplaceWith:=Me.Txtname1_.Text)
        oDoc.Content.Find.Execute(FindText:="Id1_", ReplaceWith:=Me.TxtID1_.Text)
        oDoc.Content.Find.Execute(FindText:="DOB1_", ReplaceWith:=Me.TxtDOB1_.Text)
        oDoc.Content.Find.Execute(FindText:="sex1_", ReplaceWith:=Me.CmbSex1_.Text)
        oDoc.Content.Find.Execute(FindText:="height1_", ReplaceWith:=Me.CmbHeight1_.Text)
        oDoc.Content.Find.Execute(FindText:="weight1_", ReplaceWith:=Me.TxtWeight1.Text)
        oDoc.Content.Find.Execute(FindText:="hair1_", ReplaceWith:=Me.CmbHair1_.Text)
        oDoc.Content.Find.Execute(FindText:="eyes1_", ReplaceWith:=Me.CmbEyes1_.Text)
        oDoc.Content.Find.Execute(FindText:="birth1_", ReplaceWith:=Me.TxtPlaceofBirth1_.Text)
        oDoc.Content.Find.Execute(FindText:="citizen1_", ReplaceWith:=Me.TxtCitizenship1_.Text)
        oDoc.Content.Find.Execute(FindText:="phone1_", ReplaceWith:=Me.TxtPhone1_.Text)
        oDoc.Content.Find.Execute(FindText:="occupation1_", ReplaceWith:=Me.TxtOccupation1_.Text)
        oDoc.Content.Find.Execute(FindText:="alias1_", ReplaceWith:=Me.TxtAlias1_.Text)
        oDoc.Content.Find.Execute(FindText:="drugalc1_", ReplaceWith:=Me.CmbDrugAlcohol1_.Text)
        oDoc.Content.Find.Execute(FindText:="address1_", ReplaceWith:=Me.TxtPersonAddress1_.Text)
        oDoc.Content.Find.Execute(FindText:="scarstats1_", ReplaceWith:=Me.TxtScarsTats1_.Text)

        If CmbRace1_.Text = "White" Then
            oDoc.Content.Find.Execute(FindText:="race1_", ReplaceWith:="W")
        End If

        If CmbRace1_.Text = "Black or African American" Then
            oDoc.Content.Find.Execute(FindText:="race1_", ReplaceWith:="B")
        End If

        If CmbRace1_.Text = "American Indian or Alaska Native" Then
            oDoc.Content.Find.Execute(FindText:="race1_", ReplaceWith:="I")
        End If

        If CmbRace1_.Text = "Asian" Then
            oDoc.Content.Find.Execute(FindText:="race1_", ReplaceWith:="A")
        End If

        If CmbRace1_.Text = "Native Hawaiian or Other Pacific Islander" Then
            oDoc.Content.Find.Execute(FindText:="race1_", ReplaceWith:="N")
        End If

        If CmbRace1_.Text = "Unknown" Then
            oDoc.Content.Find.Execute(FindText:="race1_", ReplaceWith:="U")
        End If

        ' VEHICLE 1 INFO
        ' oDoc.Content.Find.Execute(FindText:="V1make_", ReplaceWith:=Me.CmbV1Make.Text)
        'oDoc.Content.Find.Execute(FindText:="CmbV1Color_", ReplaceWith:=Me.CmbV2Make_.Text.ToString)

        ' Open word, all filled out and hiding the document bookmarks
        oWord.Visible = True

        ' ("C:\Users\robrt\AppData\Local\DailyLog\Critical\Report_Template.dotx")

        ' oDoc.Content.Find.Execute(FindText:="Txt_Incident_time", ReplaceWith:=Me.lblDateTime.Text)


    End Sub

End Class



' Need to be moved to form load DONT I THINK
'LblDateTimeReporting.Text = DateTime.Now.ToString("hh:mm:ss tt")
'TxtPrimaryOfficer_.Text = frmOptions.txtAddOfficer.Text



