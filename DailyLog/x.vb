'  Started February 1st 2011
'  New color options started December 26th 2011

Option Strict Off
Imports System.IO
Imports System.Environment

Module x

#Region "//================== STRINGS / DECLARATIONS ============================"

#Region "//--------- DAILYLOG FOLDER FILES --------------------------"

    Public myFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) & "\DailyLog\" '  Main Directory in Program Files"
    ' Public myFolder As String = "C:\Program Files\DailyLog\" '  Main Directory in Program Files"
    Public myAppDataFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\DailyLog\" '  Main Directory in App Data
    '  Public myAppDataFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Files\"


    ' ------------- CRITICAL Folder FILES
    Public myCriticalFolder As String = myAppDataFolder & "Critical\"
    Public myBackupFile As String = myCriticalFolder & "Backup File Basic.txt" '  File to save as Backup.
    Public myDetailsFile As String = myCriticalFolder & "Details.txt" '  Details file- area, department, officer, etc.
    Public myLocationsAndCallTypesFile As String = myCriticalFolder & "Locations and Call Types.txt" ' -- File to load Locations / Call Types.
    'Public mySettingsFile As String = myCriticalFolder & "System Settings.ini" '  Settings file for Forms.  Size/Location/etc..
    Public mySettingsAndDataFile As String = myCriticalFolder & "Global Data and Settings Basic.ini" '  Data and Settings for frmOptions.
    Public myQuickPickFile As String = myCriticalFolder & "\" & "Call Details Quick Pick.txt" ' Quick Pick dropdown in call details


    ' -------------- BACKUP log files folder
    Public myBackupLogsFolder As String = myAppDataFolder & "HTML_Files\"
    Public myBackupRestoreListFile As String = myCriticalFolder & "Backup List.ini"

    ' ------------- FILES Folder FILES
    Public myFilesFolder As String = myAppDataFolder & "Files\"

    ' ------------- GRAPHICS Folder FILES
    ' Public myGraphicsFolder As String = myFolder & "Graphics\"
    ' Public myIconFullPath As String = myGraphicsFolder & "favicon.ico" '  needed on frmStats to display as Favicon.
    ' Public myIcon As New System.Drawing.Icon(myIconFullPath) '  application Icon.
    ' Public myLogoImage As String = myGraphicsFolder & "logo.png" '  application Logo.
    Public myLogoBitmap As Bitmap '  store Logo as Bitmap.

    ' ------------- AUDIO FILES
    ' Public myAudioFolder As String = myFolder & "\" & "Sounds\"
    Public myAudioFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)
    Public myWelcomeSound As String = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) & "\DailyLog\welcome.wav"
    Public myClickSound As String = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) & "\DailyLog\click.wav"
    Public myErrorSound As String = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) & "\DailyLog\error.wav"




#End Region

#Region "//--------- OTHER FILES ( INTERFACE file / .exe ) --------------------------"
    
    Public xChrMain As Char = CChar("‡") '  MOVE TO "x.Mod". thanx. :)

#End Region '----- OTHER FILES ( INTERFACE file / .exe ) -----\\

#Region "//--------- DECLARATIONS ( theme / etc. ) --------------------------"

    Public sTemp, sTemp2, arTemp(), arTemp2() As String '  TEMP String and Arrays to use
    Public toggle_DayNight As String = "night" '  determine Toggle for theme.
    Public colBg1, colFc1, col3, colGb1 As New Color ' colGb1 is for the Groupbox Containers.
    Public sColBg, sColFc As String '  store the frmColors as ARGB to save/load.
    Public fontLvFont As New Font("Eras ITC", 10) '  Font for ListViews.
    Public bAllowEntryEditing As Boolean = False '  Edit Entry Option from Double-Clicking lvMain.
    Public bUpdate_HelpOnLoad As Boolean = True '  enable/disable Prompt for Update onLoad.
    Public bDisableSavePrompt As Boolean = False '  disable the SavePrompt for Updating
    Public iFrmCallDetailsRbStatus As Integer = 0 '  keep status of which rb is selected on FrmCallDetails.



#End Region '----- DECLARATIONS ( theme / etc. ) -----\\

#Region "//--------- UPDATE LINKS / ONLINE LINKS / SQL Server Connection String --------------------------"
    ' -- Online Links.
    ' Private urlDailyLog As String = "http://www.dailylog.net"
    ' Public urlFeedback As String = "" 
    Public urlCodes As String = "http://www.sterlingcodifiers.com/codes-online" '  Sterling Codifiers
    Public urlUsingDL As String = "" '  Users guide online
    ' Public urlUsingTrainingtracker As String = ""
    ' Public urlHelpLocationsAndCallTypes As String = ""
    ' Public urlFacebook As String = "http://facebook.com/DailyLog"
    Public urlSupport As String = ""


    Public urlManualUpdate As String = "https://dl.orangedox.com/Z3VeAqUuJyIz6YHK0s/DailyLog%20Setup.exe"
    '---\\

    ' Public urlUCJIS_Crash_Cite As String = "https://traffic.ps.utah.gov/entry/" '  UCJIS Crash and Traffic
    ' Public urlUCJIS As String = "https://ucjis.ps.utah.gov/webfront/aasShowLogin.do" '  UCJIS main Site
    '  https://traffic-test.ps.utah.gov/entry/ for test server
    Public urlDonate As String = "https://PayPal.Me/robrtaylor"


#End Region '----- UPDATE LINKS / ONLINE LINKS -----\\

#End Region '===== STRINGS / DECLARATIONS =====\\

#Region "//================== Daily Log Files(.DLF) / BACKUP Files =============="

    Public Sub saveLogFile()
        'MsgBox(FrmMain.lvMain.Tag.ToString)
        '  Show WAIT cursor
        xSetBusyCursor()
        Try
            Dim xYear As String = CStr(Year(Now))
            Dim xMonths() As String = {"01 - January", "02 - February", "03 - March", "04 - April", "05 - May", "06 - June", _
                                                   "07 - July", "08 - August", "09 - September", "10 - October", "11 - November", "12 - December"}

            '  --------- Create Folders (current Year Folder and subfolder for each month) --------------
            If Not Directory.Exists(myFilesFolder) Then Directory.CreateDirectory(myFilesFolder)
            'Dim myFolderStr As String = myFilesFolder & xYear & "\"
            '  --------- Create Folders (current Year Folder and subfolder for each month) --------------
            Dim myFolderStr As String = currentUserFilesFolder() & xYear & "\"

            If Not Directory.Exists(myFolderStr) Then
                Directory.CreateDirectory(myFolderStr)
                For Each itm As String In xMonths
                    Directory.CreateDirectory(myFolderStr & itm)
                Next
            End If
            '---------------------------------------\\
            '  Locate Folder.
            Dim xMonth As String = CStr(Date.Now.Month)
            Dim xFolder As String = ""
            For i As Integer = 0 To xMonths.Length
                If xMonth = CStr(i) Then
                    xFolder = xMonths(i - 1)
                    Exit For
                End If
            Next
            '  Save File.
            Dim ar() As String = FrmMain.lvMain.Tag.ToString.Split("."c)
            Dim iTemp As Integer = CInt(ar(0)) - 1
            Dim xFileName As String = x.currentUserFilesFolder & ar(2) & "\" & xMonths(iTemp) & "\" & FrmMain.lvMain.Tag.ToString & ".DLF" '   .DLF
            saveFile(xFileName)
        Catch ex As Exception
            MsgBox("Error while Saving File.  Error #20.", MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub saveFile(ByRef myFileToSave As String)
        With FrmMain
            Try
                'MsgBox(myFileToSave)
                Dim myWriter As New StreamWriter(myFileToSave)
                Dim xToolbar As String = ""
                xToolbar = "Radar Verified:‡"
                If .cbRadarVer.Checked = True Then : xToolbar &= "YES" : Else : xToolbar &= "NO" : End If
                myWriter.WriteLine(xToolbar)
                '  lvMain
                For Each item As ListViewItem In .lvMain.Items
                    myWriter.WriteLine("Entry:‡" & item.Text & "‡" & item.SubItems(1).Text & "‡" & item.SubItems(2).Text & "‡" & item.SubItems(3).Text & "‡" & item.SubItems(4).Text & "‡" & item.SubItems(5).Text & "‡" & item.SubItems(6).Text)
                Next
                '  Shift Notes
                Dim xShiftNotes As String = .txtShiftNotes.Text
                xShiftNotes = xShiftNotes.Replace(vbNewLine, "¨")
                myWriter.WriteLine("Shift-Notes:‡" & xShiftNotes)
                '  Mileage
                myWriter.WriteLine("Mileage:‡" & .txtStartMiles.Text & "‡" & .txtEndMiles.Text)
                '  Shift Stats
                Dim xShiftStats As String = ""
                xShiftStats = .cmbStat1City.Text : xShiftStats &= "‡" & .cmbStat1County.Text
                xShiftStats &= "‡" & .cmbStat2City.Text : xShiftStats &= "‡" & .cmbStat2County.Text
                xShiftStats &= "‡" & .cmbStat3City.Text : xShiftStats &= "‡" & .cmbStat3County.Text
                xShiftStats &= "‡" & .cmbStat4City.Text : xShiftStats &= "‡" & .cmbStat4County.Text
                xShiftStats &= "‡" & .cmbStat5City.Text : xShiftStats &= "‡" & .cmbStat5County.Text
                xShiftStats &= "‡" & .cmbStat6City.Text : xShiftStats &= "‡" & .cmbStat6County.Text
                xShiftStats &= "‡" & .cmbStat7City.Text : xShiftStats &= "‡" & .cmbStat7County.Text
                xShiftStats &= "‡" & .cmbObligatedCity.Text : xShiftStats &= "‡" & .cmbObligatedCounty.Text
                xShiftStats &= "‡" & .cmbNonObligatedCity.Text : xShiftStats &= "‡" & .cmbNonObligatedCounty.Text
                xShiftStats &= "‡" & .lblTotalCityTime.Text : xShiftStats &= "‡" & .lblTotalCountyTime.Text

                xShiftStats &= "‡" & .cmbStat8City.Text : xShiftStats &= "‡" & .cmbStat8County.Text
                xShiftStats &= "‡" & .cmbStat9City.Text : xShiftStats &= "‡" & .cmbStat9County.Text
                xShiftStats &= "‡" & .cmbStat10City.Text : xShiftStats &= "‡" & .cmbStat10County.Text
                xShiftStats &= "‡" & .cmbStat11City.Text : xShiftStats &= "‡" & .cmbStat11County.Text
                xShiftStats &= "‡" & .cmbStat12City.Text : xShiftStats &= "‡" & .cmbStat12County.Text
                xShiftStats &= "‡" & .cmbStat13City.Text : xShiftStats &= "‡" & .cmbStat13County.Text
                xShiftStats &= "‡" & .cmbStat14City.Text : xShiftStats &= "‡" & .cmbStat14County.Text
                xShiftStats &= "‡" & .cmbStat15City.Text : xShiftStats &= "‡" & .cmbStat15County.Text
                xShiftStats &= "‡" & .cmbStat16County.Text
                xShiftStats &= "‡" & .lblTotalStats.Text

                myWriter.WriteLine("Shift-Stats:‡" & xShiftStats)


                'If myFileToSave = myBackupFile Then myWriter.WriteLine("Backup-Restore FileName:‡" & .lblFileDate.Text)
                'If myFileToSave = currentUserBackupFile() Then
                '    myWriter.WriteLine("Backup-Restore FileName:‡" & .lblFileDate.Text)
                '    myWriter.WriteLine("Current User:‡" & .lblID.Text)
                'End If
                myWriter.Close()
            Catch ex As Exception
                'MsgBox("Error saving the File. Error #21", MsgBoxStyle.Critical, ex.Message)
            End Try
        End With
    End Sub

    Public Sub loadFile(ByRef myFileToLoad As String)
        If File.Exists(myFileToLoad) Then
            With FrmMain
                .lvMain.Items.Clear()
                Dim myFileLines() As String = File.ReadAllLines(myFileToLoad)
                .lblFileDate.Text = Path.GetFileNameWithoutExtension(myFileToLoad) '// load your file as a string array.
                '// strings to store values from the For/Next loop.
                Dim xAreas As String = "", xOfficers As String = "", xSupervisors As String = "", xRadarVerified As String = ""
                Dim xShiftNotes As String = "", xAgency As String = "", xShiftStats As String = "", xMileage As String = "", xContractCities As String = ""
                Dim xArray() As String
                'Try
                For Each itm As String In myFileLines
                    Dim ar() As String = itm.Split("‡"c)
                    If ar(0) = "Entry:" Then
                        Dim newItem As New ListViewItem(ar(1))
                        With newItem.SubItems
                            .Add(ar(2)) : .Add(ar(3)) : .Add(ar(4)) : .Add(ar(5)) : .Add(ar(6)) : .Add(ar(7))
                        End With
                        newItem.Font = x.fontLvFont
                        .lvMain.Items.Add(newItem)
                    End If
                    If ar(0) = "Radar Verified:" Then xRadarVerified = itm
                    If ar(0) = "Shift-Notes:" Then xShiftNotes = itm
                    If ar(0) = "Mileage:" Then xMileage = itm
                    If ar(0) = "Shift-Stats:" Then xShiftStats = itm
                    If ar(0) = "Contract-Cities:" Then xContractCities = itm
                    '//-- restore FileName from BackupFile.
                    If myFileToLoad = currentUserBackupFile() Then
                        If ar(0) = "Backup-Restore FileName:" Then
                            .lblFileDate.Text = ar(1)
                            .lvMain.Tag = ar(1)
                        End If

                        'If ar(0) = "Current User:" Then
                        '    .lblID.Text = ar(1)
                        '    .lvMain.Tag = ar(1)
                        'End If
                    End If
                Next
                If Not xRadarVerified = Nothing Then : xArray = xRadarVerified.Split("‡"c)
                    If xArray(1) = "YES" Then : .cbRadarVer.Checked = True : Else : .cbRadarVer.Checked = False : End If
                End If
                '// Shift Notes
                If Not xShiftNotes = Nothing Then : xArray = xShiftNotes.Split("‡"c) : .txtShiftNotes.Text = xArray(1).Replace("¨", vbNewLine)
                End If
                ''// Mileage
                If Not xMileage = Nothing Then : xArray = xMileage.Split("‡"c) : .txtStartMiles.Text = xArray(1) : .txtEndMiles.Text = xArray(2) : End If

                '// Shift Stats
                If Not xShiftStats = Nothing Then
                    xArray = xShiftStats.Split("‡"c)
                    .cmbStat1City.Text = xArray(1) : .cmbStat1County.Text = xArray(2)
                    .cmbStat2City.Text = xArray(3) : .cmbStat2County.Text = xArray(4)
                    .cmbStat3City.Text = xArray(5) : .cmbStat3County.Text = xArray(6)
                    .cmbStat4City.Text = xArray(7) : .cmbStat4County.Text = xArray(8)
                    .cmbStat5City.Text = xArray(9) : .cmbStat5County.Text = xArray(10)
                    .cmbStat6City.Text = xArray(11) : .cmbStat6County.Text = xArray(12)
                    .cmbStat7City.Text = xArray(13) : .cmbStat7County.Text = xArray(14)
                    .cmbObligatedCity.Text = xArray(15) : .cmbObligatedCounty.Text = xArray(16)
                    .cmbNonObligatedCity.Text = xArray(17) : .cmbNonObligatedCounty.Text = xArray(18)
                    .lblTotalCityTime.Text = xArray(19) : .lblTotalCountyTime.Text = xArray(20)


                    .cmbStat8City.Text = xArray(21) : .cmbStat8County.Text = xArray(22)
                    .cmbStat9City.Text = xArray(23) : .cmbStat9County.Text = xArray(24)
                    .cmbStat10City.Text = xArray(25) : .cmbStat10County.Text = xArray(26)
                    .cmbStat11City.Text = xArray(27) : .cmbStat11County.Text = xArray(28)
                    .cmbStat12City.Text = xArray(29) : .cmbStat12County.Text = xArray(30)
                    .cmbStat13City.Text = xArray(31) : .cmbStat13County.Text = xArray(32)
                    .cmbStat14City.Text = xArray(33) : .cmbStat14County.Text = xArray(34)
                    .cmbStat15City.Text = xArray(35) : .cmbStat15County.Text = xArray(36)
                    .cmbStat16County.Text = xArray(37)
                    .lblTotalStats.Text = xArray(38)
                End If

                'Catch ex As Exception
                '    MsgBox("There was a error loading the File." & vbNewLine & "Error #22", _
                '           MsgBoxStyle.Critical, "File Loading Failed.")
                '    '// option to load the file as is.
                'End Try
            End With
        End If
    End Sub

#End Region

#Region "//================== SETTINGS File ====================================="

    Public Sub saveSettingsAndDataFile()
        Dim w As New StreamWriter(mySettingsAndDataFile)
        With frmOptions
            w.WriteLine("DailyLog Settings")
            w.WriteLine("© 2010-2019 Rob R Taylor")
            w.WriteLine("") '//================= AGENCY INFORMATION =================\\
            w.WriteLine("Agency Information")
            w.WriteLine("Officer = " & .txtAddOfficer.Text)
            w.WriteLine("ID = " & .txtAddID.Text)
            w.WriteLine("POST ID# = " & .txtPOSTID.Text)
            w.WriteLine("Supervisor = " & .txtAddSupervisor.Text)
            w.WriteLine("Patrol Area = " & .txtAddArea.Text)
            w.WriteLine("Agency/Department = " & .txtAddAgency.Text)
            w.WriteLine("Address = " & .txtAddAddress.Text)
            w.WriteLine("City = " & .txtAddCity.Text)
            w.WriteLine("State = " & .txtAddState.Text)
            w.WriteLine("Zip = " & .txtAddZip.Text)
            w.WriteLine("County = " & .txtAddCounty.Text)
            w.WriteLine("Phone = " & .txtAddPhone.Text)
            w.WriteLine("FAX = " & .txtAddFax.Text)
            w.WriteLine("ORI = " & .txtAddORI.Text)
            w.WriteLine("URL = " & .txtAddURL.Text)
            w.WriteLine("")  '//================= SHIFT STATS =================\\
            w.WriteLine("Shift Statistics")
            w.WriteLine("Stat 1 = " & .txtStat1.Text)
            w.WriteLine("Stat 2 = " & .txtStat2.Text)
            w.WriteLine("Stat 3 = " & .txtStat3.Text)
            w.WriteLine("Stat 4 = " & .txtStat4.Text)
            w.WriteLine("Stat 5 = " & .txtStat5.Text)
            w.WriteLine("Stat 6 = " & .txtStat6.Text)
            w.WriteLine("Stat 7 = " & .txtStat7.Text)
            w.WriteLine("Stat 8 = " & .txtStat8.Text)
            w.WriteLine("Stat 9 = " & .txtStat9.Text)
            w.WriteLine("Stat 10 = " & .txtStat10.Text)
            w.WriteLine("Stat 11 = " & .txtStat11.Text)
            w.WriteLine("Stat 12 = " & .txtStat12.Text)
            w.WriteLine("Stat 13 = " & .txtStat13.Text)
            w.WriteLine("Stat 14 = " & .txtStat14.Text)
            w.WriteLine("Stat 15 = " & .txtStat15.Text)
            w.WriteLine("Stat 16 = " & .txtStat16.Text)
            w.WriteLine("") ' ================= GLOBAL OPTIONS =================\\
            w.WriteLine("Global Program Options")
            w.WriteLine("Start DailyLog in Night Mode = " & CBool(.cbNightMode.CheckState).ToString)
            w.WriteLine("Show Total Mileage = " & CBool(.cbShowTotalMileage.CheckState).ToString)
            w.WriteLine("") ' ================= TODAYS MILEAGE =================\\
            w.WriteLine("Mileage")
            w.WriteLine("Mileage = " & FrmMain.txtEndMiles.Text)
            w.WriteLine("")
            'w.WriteLine("") ' ================= BACK COLOR =================\\
            sTemp2 = ""
            If .rbBlackBackground.Checked Then sTemp2 = "Black"
            If .rbOliveGreenBackground.Checked Then sTemp2 = "Green"
            If .rbOrangeBackground.Checked Then sTemp2 = "Orange"
            If .rbBlueBackground.Checked Then sTemp2 = "Blue"
            If .rbRedBackground.Checked Then sTemp2 = "Red"
            If .rbWhiteBackground.Checked Then sTemp2 = "White"
            If .rbGreyBackground.Checked Then sTemp2 = "Grey"
            If .rbLightBlueBackground.Checked Then sTemp2 = "Light Blue"
            If .rbDarkRedBackground.Checked Then sTemp2 = "Dark Red"
            w.WriteLine("Default Back Color = " & sTemp2)
            'w.WriteLine("") ' ================= TEXT COLOR =================\\
            sTemp = ""
            If .rbYellowText.Checked Then sTemp = "Yellow"
            If .rbRedText.Checked Then sTemp = "Red"
            If .rbWhiteText.Checked Then sTemp = "White"
            If .rbGreenText.Checked Then sTemp = "Green"
            If .rbOrangeText.Checked Then sTemp = "Orange"
            If .rbBlackText.Checked Then sTemp = "Black"
            w.WriteLine("Default Text Color = " & sTemp)
            w.WriteLine("") ' ================= END =================\\

            w.WriteLine("Main Form Settings")
            With FrmMain
                w.WriteLine("Main.Location = " & .Location.X & "," & .Location.Y)
                w.WriteLine("Main.Size = " & .Width & "," & .Height)
                w.WriteLine("Main.WindowState = " & .WindowState.ToString)
                w.WriteLine("Mileage = " & .txtEndMiles.Text)
                w.WriteLine("")
            End With
            w.WriteLine("System Colours")
            w.WriteLine("Custom BackColor = " & x.colBg1.ToArgb.ToString)
            w.WriteLine("Custom ForeColor = " & x.colFc1.ToArgb.ToString)
            w.WriteLine("")
            'w.Close()
        End With
        w.Close()
    End Sub
    Public Sub loadSettingsAndDataFile()
        If File.Exists(mySettingsAndDataFile) Then
            Dim arFileLines() As String = IO.File.ReadAllLines(mySettingsAndDataFile)
            For i As Integer = 0 To arFileLines.Length - 1
                Try
                    With arFileLines(i)

                        ' ================= GLOBAL OPTIONS =================\\
                        If .StartsWith("Start DailyLog in Night Mode =") Then
                            If .Substring(.IndexOf("=") + 2) = "True" Then frmOptions.cbNightMode.Checked = True
                        End If
                        If .StartsWith("Show Total Mileage =") Then
                            If .Substring(.IndexOf("=") + 2) = "True" Then frmOptions.cbShowTotalMileage.Checked = True
                        End If

                        '//================= AGENCY INFORMATION =================\\
                        If .StartsWith("Officer =") Then frmOptions.txtAddOfficer.Text = .Substring(.IndexOf("=") + 2)
                        If .StartsWith("Officer =") Then FrmMain.lblOfficer.Text = .Substring(.IndexOf("=") + 2)

                        If .StartsWith("ID =") Then frmOptions.txtAddID.Text = .Substring(.IndexOf("=") + 2)
                        If .StartsWith("ID =") Then FrmMain.lblID.Text = .Substring(.IndexOf("=") + 2)

                        If .StartsWith("POST ID# =") Then frmOptions.txtPOSTID.Text = .Substring(.IndexOf("=") + 2)

                        If .StartsWith("Supervisor =") Then frmOptions.txtAddSupervisor.Text = .Substring(.IndexOf("=") + 2)
                        If .StartsWith("Supervisor =") Then FrmMain.lblSupervisor.Text = .Substring(.IndexOf("=") + 2)

                        If .StartsWith("Patrol Area =") Then frmOptions.txtAddArea.Text = .Substring(.IndexOf("=") + 2)
                        If .StartsWith("Patrol Area =") Then FrmMain.lblArea.Text = .Substring(.IndexOf("=") + 2)

                        If .StartsWith("Agency/Department =") Then frmOptions.txtAddAgency.Text = .Substring(.IndexOf("=") + 2)
                        If .StartsWith("Agency/Department =") Then FrmMain.lblAgency.Text = .Substring(.IndexOf("=") + 2)

                        If .StartsWith("Address =") Then frmOptions.txtAddAddress.Text = .Substring(.IndexOf("=") + 2)


                        If .StartsWith("City =") Then frmOptions.txtAddCity.Text = .Substring(.IndexOf("=") + 2)
                        If .StartsWith("State =") Then frmOptions.txtAddState.Text = .Substring(.IndexOf("=") + 2)
                        If .StartsWith("Zip =") Then frmOptions.txtAddZip.Text = .Substring(.IndexOf("=") + 2)
                        If .StartsWith("County =") Then frmOptions.txtAddCounty.Text = .Substring(.IndexOf("=") + 2)
                        If .StartsWith("Phone =") Then frmOptions.txtAddPhone.Text = .Substring(.IndexOf("=") + 2)
                        If .StartsWith("FAX =") Then frmOptions.txtAddFax.Text = .Substring(.IndexOf("=") + 2)
                        If .StartsWith("ORI =") Then frmOptions.txtAddORI.Text = .Substring(.IndexOf("=") + 2)
                        If .StartsWith("URL =") Then frmOptions.txtAddURL.Text = .Substring(.IndexOf("=") + 2)
                        '//================= SHIFT STATS =================\\
                        If .StartsWith("Stat 1 =") Then
                            frmOptions.txtStat1.Text = .Substring(.IndexOf("=") + 2)
                            FrmMain.txtStat1.Text = .Substring(.IndexOf("=") + 2)
                        End If
                        If .StartsWith("Stat 2 =") Then
                            frmOptions.txtStat2.Text = .Substring(.IndexOf("=") + 2)
                            FrmMain.txtStat2.Text = .Substring(.IndexOf("=") + 2)
                        End If
                        If .StartsWith("Stat 3 =") Then
                            frmOptions.txtStat3.Text = .Substring(.IndexOf("=") + 2)
                            FrmMain.txtStat3.Text = .Substring(.IndexOf("=") + 2)
                        End If
                        If .StartsWith("Stat 4 =") Then
                            frmOptions.txtStat4.Text = .Substring(.IndexOf("=") + 2)
                            FrmMain.txtStat4.Text = .Substring(.IndexOf("=") + 2)
                        End If
                        If .StartsWith("Stat 5 =") Then
                            frmOptions.txtStat5.Text = .Substring(.IndexOf("=") + 2)
                            FrmMain.txtStat5.Text = .Substring(.IndexOf("=") + 2)
                        End If
                        If .StartsWith("Stat 6 =") Then
                            frmOptions.txtStat6.Text = .Substring(.IndexOf("=") + 2)
                            FrmMain.txtStat6.Text = .Substring(.IndexOf("=") + 2)
                        End If
                        If .StartsWith("Stat 7 =") Then
                            frmOptions.txtStat7.Text = .Substring(.IndexOf("=") + 2)
                            FrmMain.txtStat7.Text = .Substring(.IndexOf("=") + 2)
                        End If
                        If .StartsWith("Stat 8 =") Then
                            frmOptions.txtStat8.Text = .Substring(.IndexOf("=") + 2)
                            FrmMain.txtStat8.Text = .Substring(.IndexOf("=") + 2)
                        End If
                        If .StartsWith("Stat 9 =") Then
                            frmOptions.txtStat9.Text = .Substring(.IndexOf("=") + 2)
                            FrmMain.txtStat9.Text = .Substring(.IndexOf("=") + 2)
                        End If
                        If .StartsWith("Stat 10 =") Then
                            frmOptions.txtStat10.Text = .Substring(.IndexOf("=") + 2)
                            FrmMain.txtStat10.Text = .Substring(.IndexOf("=") + 2)
                        End If
                        If .StartsWith("Stat 11 =") Then
                            frmOptions.txtStat11.Text = .Substring(.IndexOf("=") + 2)
                            FrmMain.txtStat11.Text = .Substring(.IndexOf("=") + 2)
                        End If
                        If .StartsWith("Stat 12 =") Then
                            frmOptions.txtStat12.Text = .Substring(.IndexOf("=") + 2)
                            FrmMain.txtStat12.Text = .Substring(.IndexOf("=") + 2)
                        End If
                        If .StartsWith("Stat 13 =") Then
                            frmOptions.txtStat13.Text = .Substring(.IndexOf("=") + 2)
                            FrmMain.txtStat13.Text = .Substring(.IndexOf("=") + 2)
                        End If
                        If .StartsWith("Stat 14 =") Then
                            frmOptions.txtStat14.Text = .Substring(.IndexOf("=") + 2)
                            FrmMain.txtStat14.Text = .Substring(.IndexOf("=") + 2)
                        End If
                        If .StartsWith("Stat 15 =") Then
                            frmOptions.txtStat15.Text = .Substring(.IndexOf("=") + 2)
                            FrmMain.txtStat15.Text = .Substring(.IndexOf("=") + 2)
                        End If
                        If .StartsWith("Stat 16 =") Then
                            frmOptions.txtStat16.Text = .Substring(.IndexOf("=") + 2)
                            FrmMain.txtStat16.Text = .Substring(.IndexOf("=") + 2)
                        End If
                        ' MILEAGE
                        If .StartsWith("Mileage =") Then
                            'FrmMain.txtEndMiles.Text = .Substring(.IndexOf("=") + 2)
                            FrmMain.txtStartMiles.Text = .Substring(.IndexOf("=") + 2)
                        End If
                        '  Background Colors
                        If .StartsWith("Default Back Color =") Then
                            Select Case .Substring(.IndexOf("=") + 2)
                                Case "Black" : frmOptions.rbBlackBackground.Checked = True
                                Case "Green" : frmOptions.rbOliveGreenBackground.Checked = True
                                Case "Orange" : frmOptions.rbOrangeBackground.Checked = True
                                Case "Blue" : frmOptions.rbBlueBackground.Checked = True
                                Case "Red" : frmOptions.rbRedBackground.Checked = True
                                Case "White" : frmOptions.rbWhiteBackground.Checked = True
                                Case "Grey" : frmOptions.rbGreyBackground.Checked = True
                                Case "Light Blue" : frmOptions.rbLightBlueBackground.Checked = True
                                Case "Dark Red" : frmOptions.rbDarkRedBackground.Checked = True
                            End Select
                        End If

                        '  Text Colors
                        If .StartsWith("Default Text Color =") Then
                            Select Case .Substring(.IndexOf("=") + 2)
                                Case "Yellow" : frmOptions.rbYellowText.Checked = True
                                Case "Red" : frmOptions.rbRedText.Checked = True
                                Case "White" : frmOptions.rbWhiteText.Checked = True
                                Case "Green" : frmOptions.rbGreenText.Checked = True
                                Case "Orange" : frmOptions.rbOrangeText.Checked = True
                                Case "Black" : frmOptions.rbBlackText.Checked = True
                            End Select
                        End If


                        For Each line As String In arFileLines
                            ' With FrmMain
                            With frmLogin
                                'If line.StartsWith("Mileage =") Then .txtStartMiles.Text = line.Substring(line.IndexOf("=") + 2)
                                'If line.StartsWith("Login ID = ") Then .txtUserID.Text = line.Substring(line.IndexOf("=") + 2)
                                'If line.StartsWith("Password = ") Then .txtUserPassword.Text = line.Substring(line.IndexOf("=") + 2)
                                'If line.StartsWith("ServerIP = ") Then .txtServerIP.Text = line.Substring(line.IndexOf("=") + 2)
                                'If line.StartsWith("ServerPort = ") Then .txtServerPort.Text = line.Substring(line.IndexOf("=") + 2)
                            End With
                            'With frmServerIP
                            '    If line.StartsWith("ServerIP = ") Then .txtServerIP.Text = line.Substring(line.IndexOf("=") + 2)
                            'End With
                        Next



                    End With
                Catch ex As Exception
                    MsgBox("Error loading: " & mySettingsAndDataFile & vbNewLine & "Error #30", MsgBoxStyle.Critical)
                End Try
            Next
        End If

    End Sub

#End Region

#Region "//================== MISCELLANEOUS ( centerForm / displayAppVersion ) =="

    Function centerForm(ByVal Form_to_Center As Form) As Point
        Dim pLocation As New Point
        pLocation.X = CInt((FrmMain.Left + (FrmMain.Width - Form_to_Center.Width) / 2)) '  set the X coordinates.
        pLocation.Y = CInt((FrmMain.Top + (FrmMain.Height - Form_to_Center.Height) / 2)) '  set the Y coordinates.
        Return pLocation '  return the Location to the Form it was called from.
    End Function

    Function displayAppVersion() As String '  Displays only the first 3 #'s.
        Dim sAppVersion As String = String.Format("{0}", My.Application.Info.Version.ToString)
        Dim arVersionNumber() As String = sAppVersion.Split("."c)
        'Return arVersionNumber(0) & "." & arVersionNumber(1) & "." & arVersionNumber(2) & "." & arVersionNumber(3)
        Return arVersionNumber(0) & "." & arVersionNumber(1) & "." & arVersionNumber(2)
    End Function

    Public Function currentUserFilesFolder() As String
        Application.DoEvents()
        Return myFilesFolder & FrmMain.lblID.Text.ToString & "\"
    End Function

    ' For the per-user Backup File Basic in the Critical folder
    Public Function currentUserBackupFile() As String
        Return myCriticalFolder & "Backup File Basic" & " " & FrmMain.lblID.Text & ".txt"
    End Function


    Public Sub xSetBusyCursor()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
    End Sub

    Public Sub ShowIPAddress()

        'Dim strHostName As String
        'Dim strIPAddress As String
        'strHostName = System.Net.Dns.GetHostName()
        'strIPAddress = System.Net.Dns.Resolve(strHostName).AddressList(0).ToString()
        'MessageBox.Show("Host Name: " & strHostName & ", IP Address: " & strIPAddress)
        'About Box
        'frmAbout.lblIP.Text = strIPAddress
        'frmAbout.lblHostName.Text = strHostName

    End Sub

#End Region '===== MISCELLANEOUS =====\\

#Region "//================== THEME ( toggle DAY / NIGHT ) ======================"


    Public Sub theme()
        If toggle_DayNight = "day" Then
            '  BELOW ARE NIGHT COLORS
            'colBg1 = Color.FromArgb(10, 13, 14) '  BLACK BACKGROUND
            'colBg1 = Color.FromArgb(85, 107, 47) '  OLIVE DRAB GREEN

            If frmOptions.rbBlackBackground.Checked = True Then
                colBg1 = Color.FromArgb(10, 13, 14) '  Black
            ElseIf frmOptions.rbOliveGreenBackground.Checked = True Then
                colBg1 = Color.OliveDrab '  Olive Drab
            ElseIf frmOptions.rbOrangeBackground.Checked = True Then
                colBg1 = Color.DarkOrange '  Dark Orange
            ElseIf frmOptions.rbBlueBackground.Checked = True Then
                colBg1 = Color.FromArgb(40, 55, 82) '  Blue
            ElseIf frmOptions.rbRedBackground.Checked = True Then
                colBg1 = Color.Crimson '  Red
            ElseIf frmOptions.rbWhiteBackground.Checked = True Then
                colBg1 = Color.White '  White High Contrast Background
            ElseIf frmOptions.rbGreyBackground.Checked = True Then
                colBg1 = Color.Gray '  Grey Background
            ElseIf frmOptions.rbLightBlueBackground.Checked = True Then
                colBg1 = Color.LightSteelBlue '  Light Blue Background
            ElseIf frmOptions.rbDarkRedBackground.Checked = True Then
                colBg1 = Color.DarkRed '  Dark Red Background
            End If



            If frmOptions.rbYellowText.Checked = True Then
                colFc1 = Color.Yellow
            ElseIf frmOptions.rbRedText.Checked = True Then
                colFc1 = Color.Red
            ElseIf frmOptions.rbWhiteText.Checked = True Then
                colFc1 = Color.White
            ElseIf frmOptions.rbGreenText.Checked = True Then
                colFc1 = Color.FromArgb(60, 229, 40)
            ElseIf frmOptions.rbOrangeText.Checked = True Then
                colFc1 = Color.Orange
            ElseIf frmOptions.rbBlackText.Checked = True Then
                colFc1 = Color.Black
            End If
            toggle_DayNight = "night"
        Else

            '  BELOW ARE DAY COLORS
            colBg1 = Color.Empty
            colFc1 = Color.Black
            toggle_DayNight = "day"
        End If
        x.setTheme()
    End Sub
    Public Sub setTheme()

        x.frmMain_theme(colBg1, colFc1)

    End Sub


    Public Sub frmMain_theme(ByVal selectedBgColor As Color, ByVal selectedFcColor As Color)
        '------------------------------------- MAIN FORM -------------------------------------
        With FrmMain
            .BackColor = selectedBgColor : .lblTime.BackColor = selectedBgColor : .lblTime.ForeColor = selectedFcColor
            .TabControl1.TabPages(0).BackColor = selectedBgColor
            .m_Menu.BackColor = selectedBgColor : .m_Menu.ForeColor = selectedFcColor
            ' -- Toolbar TextBoxes and CheckBox.
            .gbMileage.ForeColor = selectedFcColor : .gbMileage.BackColor = selectedBgColor
            .cbRadarVer.ForeColor = selectedFcColor : .cbRadarVer.BackColor = selectedBgColor


            .lvMain.ForeColor = selectedFcColor : .lvMain.BackColor = selectedBgColor '  Listview.
            .lblFileDate.ForeColor = selectedFcColor : .lblFileDate.BackColor = selectedBgColor  '  FileDate in toolbar
            .lblTime.ForeColor = selectedFcColor : .lblTime.BackColor = selectedBgColor    '  Clock in upper right

            '  This section is for the Notes Box
            .gbShiftNotes.BackColor = selectedBgColor : .gbShiftNotes.ForeColor = selectedFcColor : .txtShiftNotes.BackColor = selectedBgColor : .txtShiftNotes.ForeColor = selectedFcColor
            '  Shift Stats.
            .gbShiftStats.BackColor = selectedBgColor : .gbShiftStats.ForeColor = selectedFcColor


            For Each ctl As Control In .gbShiftStats.Controls : ctl.BackColor = selectedBgColor : ctl.ForeColor = selectedFcColor : Next
            '  All controls on main Form, including Buttons, GroupBoxes, etc.
            For Each ctl As Control In .Controls : ctl.BackColor = selectedBgColor : ctl.ForeColor = selectedFcColor : Next

            '.txtStartMiles.BackColor = selectedBgColor : .txtStartMiles.ForeColor = selectedFcColor ' Start Miles Box
            '.txtEndMiles.BackColor = selectedBgColor : .txtEndMiles.ForeColor = selectedFcColor ' End Miles Box
            .cmbObligatedCity.BackColor = selectedBgColor : .cmbObligatedCity.ForeColor = selectedFcColor
            .lblObligated.BackColor = selectedBgColor : .lblObligated.ForeColor = selectedFcColor
            .cmbNonObligatedCity.BackColor = selectedBgColor : .cmbNonObligatedCity.ForeColor = selectedFcColor
            .lblNonObligated.BackColor = selectedBgColor : .lblNonObligated.ForeColor = selectedFcColor
            .cmbObligatedCounty.BackColor = selectedBgColor : .cmbObligatedCounty.ForeColor = selectedFcColor
            .lblObligated.BackColor = selectedBgColor : .lblObligated.ForeColor = selectedFcColor
            .cmbNonObligatedCounty.BackColor = selectedBgColor : .cmbNonObligatedCounty.ForeColor = selectedFcColor
            .lblNonObligated.BackColor = selectedBgColor : .lblNonObligated.ForeColor = selectedFcColor
            .cmbStat15City.BackColor = selectedBgColor : .cmbStat15City.ForeColor = selectedFcColor
            .txtStat15.BackColor = selectedBgColor : .txtStat15.ForeColor = selectedFcColor
            .cmbStat15County.BackColor = selectedBgColor : .cmbStat15County.ForeColor = selectedFcColor
            .cmbStat16County.BackColor = selectedBgColor : .cmbStat16County.ForeColor = selectedFcColor
            .txtStat16.BackColor = selectedBgColor : .txtStat16.ForeColor = selectedFcColor
            '.txtJuvenileCourt.BackColor = selectedBgColor : .txtJuvenileCourt.ForeColor = selectedFcColor '  Not Used Yet

           

        End With
    End Sub '  FrmMain

#End Region '===== THEME =====\\  '===== THEME =====\\ 

#Region "//================== LISTVIEWS Move Item UP / DOWN ====================="
    Public Sub moveListViewItemUP(ByVal selectedListView As ListView)
        Dim iSelectedIndex As Integer = 0 '  get selected item's Index.
        With selectedListView
            .Select() '  select to keep focus.
            If Not .SelectedItems.Count = 0 Then '  check if item is selected.
                Dim lvItem As ListViewItem = .SelectedItems(0) '  declare new item as selected item.
                iSelectedIndex = .SelectedItems(0).Index '  set index of the item's location.
                .Items.Remove(.SelectedItems(0)) '  remove selected item.
                '  if First item.
                If iSelectedIndex = 0 Then
                    .Items.Insert(.Items.Count, lvItem) '  if First item, insert item Last.
                ElseIf Not iSelectedIndex = 0 Then '  if Not First item.
                    .Items.Insert(iSelectedIndex - 1, lvItem) '  insert item at preset index -1 to move "Up".
                End If
                lvItem.EnsureVisible() '  keep item in Focus.
            End If
        End With
    End Sub
    Public Sub moveListViewItemDOWN(ByVal selectedListView As ListView)
        Dim iSelectedIndex As Integer = 0 '  get selected item's Index.
        With selectedListView
            .Select() '  select to keep focus.
            If Not .SelectedItems.Count = 0 Then '  check if item is selected.
                Dim lvItem As ListViewItem = .SelectedItems(0) '  declare new item as selected item.
                iSelectedIndex = .SelectedItems(0).Index '  set index of the item's location.
                .Items.Remove(.SelectedItems(0)) '  remove selected item.
                '  if Last item.
                If iSelectedIndex = .Items.Count Then
                    .Items.Insert(0, lvItem) '  if Last item, insert item First.
                ElseIf iSelectedIndex <= .Items.Count - 1 Then    '  if Not Last item.
                    .Items.Insert(iSelectedIndex + 1, lvItem) '  insert item at preset index +1 to move "Down".
                End If
                lvItem.EnsureVisible() '  keep item in Focus.
            End If
        End With
    End Sub
#End Region

#Region "//========================= MODULE x ==================================="

    Public xnL As String = vbNewLine, xarlT As New ArrayList

    Public Function xLoadArrayFile(ByVal selFile As String) As Array
        If File.Exists(selFile) Then Return File.ReadAllLines(selFile) Else Return Nothing
    End Function
    Public Function xLoadFile(ByVal selFile As String) As String
        If File.Exists(selFile) Then Return File.ReadAllText(selFile) Else Return Nothing
    End Function
    Public Sub xSaveFile(ByVal selFile As String, ByVal selContent As String)
        File.WriteAllText(selFile, selContent)
    End Sub
    Public Sub xSaveArrayFile(ByVal selFile As String, ByVal selArray As Array)
        Dim x As String = ""
        If Not selArray.Length = 0 Then
            For Each itm As String In selArray
                If Not x = "" Then x &= xnL & itm Else x = itm
            Next
        End If
        xSaveFile(selFile, x)
    End Sub

    Sub loadBackupIDlist(ByVal selFile As String)
        With FrmMain.lblID
            If File.Exists(selFile) Then
                xarlT.AddRange(xLoadArrayFile(selFile)) '// read file into ArrayList.
                If xarlT.Contains(.Text) Then '// if List.Contains ID then load the backup.File.
                    x.loadFile(currentUserBackupFile)
                Else '// if Not List.Contains ID.
                    xarlT.Add(.Text) '// add ID to list; will be removed on Form.Closing, otherwise it will load the backup.File.
                    xSaveArrayFile(selFile, xarlT.ToArray) '// save ArrayList.Items to file.
                End If
                xarlT.Clear() '// just because.
            End If
        End With
    End Sub
    Sub saveBackupIDlist(ByVal selFile As String)
        With FrmMain.lblID
            If File.Exists(selFile) Then
                xarlT.AddRange(xLoadArrayFile(selFile)) '// read file into ArrayList.
                Dim x As String = "" '// string to add content to.
                For Each itm As String In xarlT '// loop thru ArrayList and add each itm to each line.
                    If Not itm = .Text Then '// if the ID does not match the current.user's ID, append other users back to list.
                        If Not x = "" Then x &= xnL & itm Else x = itm
                    End If
                Next
                xSaveFile(selFile, x) '// save File.
                xarlT.Clear()
            End If
        End With
    End Sub

#End Region

#Region "//========================= ENTIRE SHUTDOWN SEQUENCE ==================="


    Public Sub ShutdownSequence()

        ' Show todays miles if the box is checked in the frmOptions on shutdown
        ' so the user knows. 
        If frmOptions.cbShowTotalMileage.Checked = True Then
            ClsTopMostMessageBox.Show("Todays Total Miles", "Todays mileage is " & Str(Val(FrmMain.txtEndMiles.Text) - Val(FrmMain.txtStartMiles.Text)) & " miles." _
                                      & vbNewLine & "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        ' Hide the main form so it's not visible during shutdown.
        ' Make the shutdown process look shorter to the end user
        ' while shit is getting uploaded and backup, etc...
        FrmMain.Hide()

        ' Fixes a bug with minimizing (closing the X then trying to open the app again).
        If FrmMain.WindowState = FormWindowState.Minimized Then FrmMain.WindowState = FormWindowState.Maximized
        x.saveLogFile()

        ' Now save this again, just to be sure.
        saveSettingsAndDataFile() ' =========== Save Settings and Data. ===========\\

        With My.Settings : .bLoadBackupFile = False : .Save() : End With ' set to False, Not to load the BackupFile.

        ' ================ UPDATE CODE- MOVING FOLDERS, ETC ====================
        ' Create the new folder on officer ID for the new multi user app
        x.Housekeeping()

    End Sub

#End Region

#Region "//========================= STUFF TO DELETE- HOUSEKEEPING =============="

    Public Sub Housekeeping()

        ' Delete the *old* settings file. It's now a part of the Global Data and Settings.ini file. As of 4.0...
        Dim FileToDelete As String
        FileToDelete = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\DailyLog Basic\Critical\System Settings.ini"
        If System.IO.File.Exists(FileToDelete) = True Then
            System.IO.File.Delete(FileToDelete)
            'MsgBox("File Deleted")
        End If

        ' Ditch this lblID file from when the app is started up before a user is created.
        Dim FileToDelete0 As String
        FileToDelete0 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\DailyLog\Critical\Backup File Basic lblID.txt"
        If System.IO.File.Exists(FileToDelete0) = True Then
            System.IO.File.Delete(FileToDelete0)
            'MsgBox("File Deleted")
        End If

        ' Ditch this lblID file from when the app is started up before a user is created.
        Dim FileToDelete18 As String
        FileToDelete18 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\DailyLog\Critical\Backup File Basic .txt"
        If System.IO.File.Exists(FileToDelete18) = True Then
            System.IO.File.Delete(FileToDelete18)
            'MsgBox("File Deleted")
        End If

        ' Ditch this backup file that has no ID associated with it.
        Dim FileToDelete32 As String
        FileToDelete32 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\DailyLog\Critical\Backup File Basic.txt"
        If System.IO.File.Exists(FileToDelete32) = True Then
            System.IO.File.Delete(FileToDelete32)
            'MsgBox("File Deleted")
        End If


        ' Leftovers from DevExpress
        Dim FileToDelete33 As String
        FileToDelete33 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) & "\DailyLog Basic\de"
        If System.IO.Directory.Exists(FileToDelete33) = True Then
            System.IO.Directory.Delete(FileToDelete33, CBool(FileIO.DeleteDirectoryOption.DeleteAllContents))
            'MsgBox("File Deleted")
        End If

        Dim FileToDelete34 As String
        FileToDelete34 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) & "\DailyLog Basic\es"
        If System.IO.Directory.Exists(FileToDelete34) = True Then
            System.IO.Directory.Delete(FileToDelete34, CBool(FileIO.DeleteDirectoryOption.DeleteAllContents))
            'MsgBox("File Deleted")
        End If

        Dim FileToDelete35 As String
        FileToDelete35 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) & "\DailyLog Basic\ja"
        If System.IO.Directory.Exists(FileToDelete35) = True Then
            System.IO.Directory.Delete(FileToDelete35, CBool(FileIO.DeleteDirectoryOption.DeleteAllContents))
            'MsgBox("File Deleted")
        End If

        Dim FileToDelete36 As String
        FileToDelete36 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) & "\DailyLog Basic\ru"
        If System.IO.Directory.Exists(FileToDelete36) = True Then
            System.IO.Directory.Delete(FileToDelete36, CBool(FileIO.DeleteDirectoryOption.DeleteAllContents))
            'MsgBox("File Deleted")
        End If

        Dim FileToDelete37 As String
        FileToDelete37 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) & "\DailyLog Basic\False"
        If System.IO.Directory.Exists(FileToDelete37) = True Then
            System.IO.Directory.Delete(FileToDelete37, CBool(FileIO.DeleteDirectoryOption.DeleteAllContents))
            'MsgBox("File Deleted")
        End If



        '// ============================= END OF THE FOLDERS ========================================



        '// ============================= DITCH THE DEVEXPRESS STUFF ========================================
        Dim FileToDelete8 As String
        FileToDelete8 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) & "\DailyLog Basic\DevExpress.Data.v11.2.dll"
        If System.IO.Directory.Exists(FileToDelete8) = True Then
            System.IO.Directory.Delete(FileToDelete8)
            'MsgBox("File Deleted")
        End If

        Dim FileToDelete9 As String
        FileToDelete9 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) & "\DailyLog Basic\DevExpress.Data.v11.2.xml"
        If System.IO.Directory.Exists(FileToDelete9) = True Then
            System.IO.Directory.Delete(FileToDelete9)
            'MsgBox("File Deleted")
        End If

        Dim FileToDelete10 As String
        FileToDelete10 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) & "\DailyLog Basic\DevExpress.Printing.v11.2.Core.dll"
        If System.IO.Directory.Exists(FileToDelete10) = True Then
            System.IO.Directory.Delete(FileToDelete10)
            'MsgBox("File Deleted")
        End If

        Dim FileToDelete11 As String
        FileToDelete11 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) & "\DailyLog Basic\DevExpress.Utils.v11.2.dll"
        If System.IO.Directory.Exists(FileToDelete11) = True Then
            System.IO.Directory.Delete(FileToDelete11)
            'MsgBox("File Deleted")
        End If

        Dim FileToDelete12 As String
        FileToDelete12 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) & "\DailyLog Basic\DevExpress.Utils.v11.2.xml"
        If System.IO.Directory.Exists(FileToDelete12) = True Then
            System.IO.Directory.Delete(FileToDelete12)
            'MsgBox("File Deleted")
        End If

        Dim FileToDelete13 As String
        FileToDelete13 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) & "\DailyLog Basic\DevExpress.XtraEditors.v11.2.dll"
        If System.IO.Directory.Exists(FileToDelete13) = True Then
            System.IO.Directory.Delete(FileToDelete13)
            'MsgBox("File Deleted")
        End If

        Dim FileToDelete14 As String
        FileToDelete14 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) & "\DailyLog Basic\DevExpress.XtraEditors.v11.2.xml"
        If System.IO.Directory.Exists(FileToDelete14) = True Then
            System.IO.Directory.Delete(FileToDelete14)
            'MsgBox("File Deleted")
        End If

        ' Old Report Viewer Files ----------------------------------------
        Dim FileToDelete15 As String
        FileToDelete15 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) & "\DailyLog Basic\Microsoft.ReportViewer.Common.dll"
        If System.IO.Directory.Exists(FileToDelete15) = True Then
            System.IO.Directory.Delete(FileToDelete15)
            'MsgBox("File Deleted")
        End If

        ' Old Report Viewer Files ----------------------------------------
        Dim FileToDelete16 As String
        FileToDelete16 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) & "\DailyLog Basic\Microsoft.ReportViewer.WinForms.dll"
        If System.IO.Directory.Exists(FileToDelete16) = True Then
            System.IO.Directory.Delete(FileToDelete16)
            'MsgBox("File Deleted")
        End If

        ' Old Report Viewer Files ----------------------------------------
        Dim FileToDelete17 As String
        FileToDelete17 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) & "\DailyLog Basic\Microsoft.ReportViewer.WinForms.xml"
        If System.IO.Directory.Exists(FileToDelete17) = True Then
            System.IO.Directory.Delete(FileToDelete17)
            'MsgBox("File Deleted")
        End If


        'Old PC Affidavit. Ditch it.
        Dim FileToDelete20 As String
        FileToDelete20 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) & "\DailyLog Basic\Templates\PC_Affidavit.xlsx"
        If System.IO.File.Exists(FileToDelete20) = True Then
            System.IO.File.Delete(FileToDelete20)
            'MsgBox("File Deleted PC_Affidavit.xlsx")
        End If

        'WyUpdate Files -------------------------
        Dim FileToDelete100 As String
        FileToDelete100 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) & "\DailyLog Basic\client.wyc"
        If System.IO.File.Exists(FileToDelete100) = True Then
            System.IO.File.Delete(FileToDelete100)
            'MsgBox("File Deleted PC_Affidavit.xlsx")
        End If


        ' Kill wyUpdate so it can be deleted and no access violation error
        Dim Processes() As Process = Process.GetProcessesByName("wyUpdate")
        For Each Process As Process In Processes
            Process.Kill()
        Next

        ' Sleep for three seconds. Make sure it's gone
        Threading.Thread.Sleep(3000)

        'WyUpdate Files -------------------------
        Try
            Dim FileToDelete101 As String
            FileToDelete101 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) & "\DailyLog Basic\wyUpdate.exe"
            If System.IO.File.Exists(FileToDelete101) = True Then

                System.IO.File.Delete(FileToDelete101)
            End If
        Catch ex As Exception
            'MsgBox(ex.ToString)
        End Try

        'WyUpdate Files -------------------------
        Dim FileToDelete102 As String
        FileToDelete102 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) & "\DailyLog Basic\AutomaticUpdater.dll"
        If System.IO.File.Exists(FileToDelete102) = True Then
            System.IO.File.Delete(FileToDelete102)
            'MsgBox("File Deleted PC_Affidavit.xlsx")
        End If

        'WyUpdate Files -------------------------
        Dim FileToDelete103 As String
        FileToDelete103 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) & "\DailyLog Basic\AutomaticUpdater.xml"
        If System.IO.File.Exists(FileToDelete103) = True Then
            System.IO.File.Delete(FileToDelete103)
            'MsgBox("File Deleted PC_Affidavit.xlsx")
        End If

        'Old chat files files -------------------------
        Dim FileToDelete104 As String
        FileToDelete104 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) & "\DailyLog Basic\CommandClient.dll"
        If System.IO.File.Exists(FileToDelete104) = True Then
            System.IO.File.Delete(FileToDelete104)
            'MsgBox("File Deleted PC_Affidavit.xlsx")
        End If

        'Only need 1 favicon. Get rid of the other -------------------------
        Dim FileToDelete105 As String
        FileToDelete105 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) & "\DailyLog Basic\favicon2012.ico"
        If System.IO.File.Exists(FileToDelete105) = True Then
            System.IO.File.Delete(FileToDelete105)
            'MsgBox("File Deleted PC_Affidavit.xlsx")
        End If

        ' Get rid of the updater icon on the desktop. 
        Dim FileToDelete106 As String
        FileToDelete106 = Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory) & "\DailyLog Updater.lnk"
        If System.IO.File.Exists(FileToDelete106) = True Then
            System.IO.File.Delete(FileToDelete106)
            'MsgBox("Shortcut Deleted")
        End If

        ' Visual Studio Powerpacks. No longer wanted. 
        Dim FileToDelete107 As String
        FileToDelete107 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) & "\DailyLog Basic\Microsoft.VisualBasic.PowerPacks.Vs.dll"
        If System.IO.File.Exists(FileToDelete107) = True Then
            System.IO.File.Delete(FileToDelete107)
            'MsgBox("Shortcut Deleted")
        End If

        ' Visual Studio Powerpacks. No longer wanted. 
        Dim FileToDelete108 As String
        FileToDelete108 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) & "\DailyLog Basic\Microsoft.VisualBasic.PowerPacks.Vs.xml"
        If System.IO.File.Exists(FileToDelete108) = True Then
            System.IO.File.Delete(FileToDelete108)
            'MsgBox("Shortcut Deleted")
        End If


        ' Old BackupFile
        Dim FileToDelete7 As String
        FileToDelete7 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\DailyLog Basic\Critical\Backup File.txt"
        If System.IO.File.Exists(FileToDelete7) = True Then
            System.IO.File.Delete(FileToDelete7)
            'MsgBox("File Deleted")
        End If

        ' Create a folder based in officer ID Inside the FILES folder. Logs will go there.
        Try
            If Not Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\DailyLog\Files\" & "" & FrmMain.lblID.Text & "") Then
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\DailyLog\Files\" & "" & FrmMain.lblID.Text & "")
            End If
        Catch ex As Exception
            'MsgBox("")
        End Try

        ' Create a new folder called HTML_Files, formally HTMLlogs. 
        Try
            If Not Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\DailyLog\HTML_Files\" & "" & FrmMain.lblID.Text & "") Then
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\DailyLog\HTML_Files\" & "" & FrmMain.lblID.Text & "")
            End If
        Catch ex As Exception
            'MsgBox("")
        End Try

        ' Delete the old HTMLLogs file, and everything in it. We can download all the HTML files with a restore.
        Dim HTMLlogs As String
        HTMLlogs = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\DailyLog\HTMLlogs"
        If System.IO.Directory.Exists(HTMLlogs) = True Then
            System.IO.Directory.Delete(HTMLlogs, CBool(FileIO.DeleteDirectoryOption.DeleteAllContents))
            'MsgBox("HTMLlogs Deleted")
        End If

        ' Delete the Graphics folder. Not needed as of November 15 2015
        Dim Graphics As String
        Graphics = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\DailyLog\Graphics"
        If System.IO.Directory.Exists(Graphics) = True Then
            System.IO.Directory.Delete(Graphics, CBool(FileIO.DeleteDirectoryOption.DeleteAllContents))
            'MsgBox("Graphics Deleted")
        End If


        ' Move current .DLF files into the new folder- the log files based on year.
        Try
            'Move 2010
            Directory.Move(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\DailyLog\Files\2010", _
            (Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\DailyLog\Files\" & "" & FrmMain.lblID.Text & "" & "\2010"))

            'Move 2011
            Directory.Move(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\DailyLog\Files\2011", _
            (Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\DailyLog\Files\" & "" & FrmMain.lblID.Text & "" & "\2011"))

            'Move 2012
            Directory.Move(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\DailyLog\Files\2012", _
            (Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\DailyLog\Files\" & "" & FrmMain.lblID.Text & "" & "\2012"))

            'Move 2013
            Directory.Move(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\DailyLog\Files\2013", _
            (Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\DailyLog\Files\" & "" & FrmMain.lblID.Text & "" & "\2013"))

            'Move 2014
            Directory.Move(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\DailyLog\Files\2014", _
            (Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\DailyLog\Files\" & "" & FrmMain.lblID.Text & "" & "\2014"))


        Catch ex As Exception
        End Try

        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)

    End Sub

    ' Move current .DLF files into the new folder- the log files based on year.
    Public Sub moveFilesToUserFolder(ByVal selYear As String)
        If Directory.Exists(myFilesFolder & selYear) Then '/ check if folder exists in myFilesFolder.
            selYear &= "\" '// add a dash, in case of anything.
            Dim sOriginalFolder As String = x.currentUserFilesFolder & selYear
            If Not Directory.Exists(sOriginalFolder) Then '// create folder and sub.folders.
                Directory.CreateDirectory(sOriginalFolder)
                Dim xMonths() As String = {"01 - January", "02 - February", "03 - March", "04 - April", "05 - May", "06 - June", _
                                           "07 - July", "08 - August", "09 - September", "10 - October", "11 - November", "12 - December"}
                For Each itm As String In xMonths : Directory.CreateDirectory(sOriginalFolder & itm) : Next '// create sub.folders.
            End If
            Dim ar() As String = Directory.GetFiles(myFilesFolder & selYear, "*", SearchOption.AllDirectories) '// get files in current folder.
            For Each itm As String In ar
                '// save file w/.Default encoding, should keep the special little char of "‡" w/out fuggin' it up.
                File.WriteAllText(x.currentUserFilesFolder & itm.Substring(itm.IndexOf(selYear)), File.ReadAllText(itm), System.Text.Encoding.Default)
                File.Delete(itm) '// delete file from folder, to empty folder.
            Next
            ar = Directory.GetDirectories(myFilesFolder & selYear) '// get folders in year.folder.
            For Each itm As String In ar : Directory.Delete(itm) : Next '// delete empty month folders.
            Directory.Delete(myFilesFolder & selYear) '// delete empty Year folder.
        End If
    End Sub




#End Region

#Region "//========================= LICENSING ============================"





#End Region




End Module