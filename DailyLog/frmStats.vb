' Started December 4th 2010

'Option Strict On
Imports System.IO
Public Class frmStats

#Region "//---------- STRINGS AND STUFF ------------------------------"
    Private iProgress As Integer = 0 ' ProgressBar Maximum extracted from .dlf Files.Count.
    Private dtFile As Date
    Private sFileName As String = "" ' for manipulating FileName.
    Private sHtmlContent As String = "" ' main String to Save to File.
    Private sStatsViewerLines As String = "" ' for Stats Viewer.
    Private sStatsReportNameForStatsViewerLines As String = ""
    Private colDate As String = "#B0C4DE" ' COLOR for  Top Row that includes all days.
    Private colEvenRow As String = "#EFF3F8" ' COLOR for every Even numbered Row.
    Private colOddRow As String = "#D8E2EE" ' COLOR for every Odd numbered Row.
    Private nL As String = vbNewLine, t As String = vbTab ' new line and tab for file.
    ' Private myFavicon As String = "file:///" & x.myIconFullPath ' Icon on WebBrowser.
    ' Private myLogo As String = "file:///" & x.myLogoImage ' Logo on Webpage.
    Private sX As String = Nothing
    Private sEvenRowStatName As String = t & t & "</tr>" & nL & t & t & "<tr>" & nL & t & t & t & "<td id=""statName"" bgcolor=" & """" & colEvenRow & """" & ">"
    Private sOddRowStatName As String = t & t & "</tr>" & nL & t & t & "<tr>" & nL & t & t & t & "<td id=""statName"" bgcolor=" & """" & colOddRow & """" & ">"
    ' set color for Stats.
    Private sEvenRowStat As String = t & t & t & "<td class=" & """" & "evenRow" & """" & ">"
    Private sOddRowStat As String = t & t & t & "<td class=" & """" & "oddRow" & """" & ">"
    Private iCounter As Integer = 0, dCounter As Decimal = 0, sTotalHours As String = 0 ' used in Functions to Total Stats and Times.
    Private currentFolderDirectory As String
    Public sTemp, sTemp2, arTemp() As String

#End Region

    Private Sub frmStats_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = x.centerForm(Me) ' Center Form of FrmMain.
        ProgressBar1.Value = 0 ' reset if needed.
        dtpFrom.Value = dtpTo.Value.AddDays(-1) ' set day to -1 for the FROM dtp.
        currentFolderDirectory = x.currentUserFilesFolder
        'Msgbox(currentFolderDirectory)
    End Sub


    ' Reset ProgressBar.
    Private Sub dtpValue_rbChecked_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs) _
                                    Handles dtpFrom.ValueChanged, dtpTo.ValueChanged, rbCityStats.CheckedChanged, rbCountyStats.CheckedChanged
        If Not ProgressBar1.Value = 0 Then ProgressBar1.Value = 0
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        ProgressBar1.Value = 0
        If rbCityStats.Checked = True Then : saveReportAsHTML("CITY")
        ElseIf rbCountyStats.Checked = True Then : saveReportAsHTML("COUNTY")
        ElseIf rbBoth.Checked = True Then : saveReportAsHTML("CITY & COUNTY")
        End If

        ' Open the new Stats Report form
        'frmShiftStatsReport.Show()
    End Sub

    Public Sub saveReportAsHTML(ByVal ReportName As String)
        If Directory.Exists(currentFolderDirectory) Then ' check if "Files" folder exists.


            Dim fbd As New FolderBrowserDialog
            fbd.Description = "Select a location to Save ( " & ReportName & ".html ) To..."
            ' check if report name contains "&" and add "&&" to display the "&" char. properly.
            If ReportName = "CITY & COUNTY" Then fbd.Description = "Select a location to Save ( CITY && COUNTY.html ) To..."
            If fbd.ShowDialog = DialogResult.OK Then
                Try
                    setProgressBar() ' ---- set ProgressBar Maximum.
                    If Not ReportName = "CITY & COUNTY" Then
                        setHtmlFormat(ReportName) ' <head> title / favicon / CSS </head>
                        setHtmlContent(ReportName) ' Stats.
                    Else
                        ProgressBar1.Maximum = iProgress * 2 ' set max value multiplied by 2.
                        setHtmlFormat(ReportName) ' <head> title / favicon / CSS </head>
                        ReportName = "CITY"
                        setHtmlContent(ReportName) ' Stats.
                        sHtmlContent &= "<br /><br />"
                        sStatsViewerLines &= nL
                        ReportName = "COUNTY"
                        setHtmlContent(ReportName) ' Stats.
                        ReportName = "CITY & COUNTY"
                    End If
                    sHtmlContent &= t & t & "</td>" & nL & t & "</tr>" & nL & "</table>" & nL ' END table for top content. logo, print, etc.
                    ' ========================= STATS VIEWER CODE
                    sHtmlContent &= "<!--- START  STATS VIEWER CODE ---" & nL & nL
                    sHtmlContent &= sStatsViewerLines & nL & nL
                    sHtmlContent &= "------ END  STATS VIEWER CODE --->" & nL '=========================\\

                    sHtmlContent &= "</body>" & nL & "</html>" & nL
                    '-------------------------------------------------------------------------------\\
                    sTemp2 = DateTime.Now.ToString("MMddyy.HHmmss")

                    If Not frmOptions.txtAddOfficer.Text = "" Then
                        sFileName = fbd.SelectedPath & "\" & ReportName & " - (" & FrmMain.lblOfficer.Text.ToString & ") - STATS REPORT (" & sTemp2 & ").html"
                    Else
                        sFileName = fbd.SelectedPath & "\" & ReportName & " - (Name Not Available) - STATS REPORT (" & sTemp2 & ").html"
                    End If

                    ' //--- SAVE FILE AS .HTML.
                    IO.File.WriteAllText(sFileName, sHtmlContent)
                    ' confirm File Saved and option to Preview.
                    iProgress -= 20 ' "-" for ArrayLists. preset in setProgressBar().
                    Dim sTotalFiles As String = "Located ( " & iProgress & " ) Daily Log Files."
                    If iProgress = 1 Then sTotalFiles = "Located ( " & iProgress & " ) Daily Log File."
                    If MessageBox.Show(ReportName & " Stats Saved." & nL & nL & Format(dtpFrom.Value, "MMMM dd, yyyy") & " - " & Format(dtpTo.Value, "MMMM dd, yyyy") & nL & sTotalFiles & nL & nL & "Preview File?", "Daily Log Statistics", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                        Process.Start(sFileName)
                    End If
                Catch ex As Exception
                    MsgBox("Error saving the " & ReportName & " Report." & vbNewLine & "This is caused by an illegal character in the Shift Stats box, which is typically not allowed.", MsgBoxStyle.Critical)
                End Try
            End If
        End If
    End Sub

    Private Sub setProgressBar()
        iProgress = 20 ' preset to count of ArrayLists.
        For Each DailyLogFile As String In My.Computer.FileSystem.GetFiles _
                                                  (currentFolderDirectory, FileIO.SearchOption.SearchAllSubDirectories, "*.DLF")
            sFileName = Path.GetFileNameWithoutExtension(DailyLogFile) ' get FileName.
            sFileName = sFileName.Replace(".", "/") ' replace the . with /.
            dtFile = CDate(sFileName) ' set FileName as Date to Format.
            If dtFile >= CDate(Format(dtpFrom.Value, "MM/dd/yyyy")) AndAlso dtFile <= CDate(Format(dtpTo.Value, "MM/dd/yyyy")) Then
                iProgress += 1
            End If
        Next
        ProgressBar1.Maximum = iProgress ' set max value.
    End Sub

    Private Sub setHtmlFormat(ByVal ReportName As String)
        ' Title.
        sHtmlContent = "<html>" & nL & t & "<head>" & nL & t & t & "<title>" & ReportName & " - Daily Log Stats Report</title>" & nL
        ' favicon.
        sHtmlContent &= t & t & "<link rel=" & """" & "shortcut icon" & """" & "href = " & """" & """" & ">" & nL
        ' -- CSS.
        sHtmlContent &= "<style type=" & """" & "text/css" & """" & ">" & nL
        sHtmlContent &= t & "td.topRow {text-align: center; background-color: " & colDate & ";}" & nL
        sHtmlContent &= t & "span.reportName {font-size:32px; font-weight:bolder;}" & nL
        sHtmlContent &= t & "span.dayNumber {font-size:20px; font-weight:bolder;}" & nL
        sHtmlContent &= t & "span.dayName {font-size:10px; font-weight:bold;}" & nL
        sHtmlContent &= t & "span.year {font-size:9px; font-weight:bold;}" & nL
        sHtmlContent &= t & "span.total {font-size:18px;font-weight:bolder;}" & nL
        sHtmlContent &= t & "td.evenRow {text-align: center; background-color: " & colEvenRow & ";}" & nL
        sHtmlContent &= t & "td.oddRow {text-align: center; background-color: " & colOddRow & ";}" & nL
        sHtmlContent &= "</style>" & nL
        '----\\
        sHtmlContent &= t & "</head>" & nL & "<body>" & nL
        ' ============ BODY CONTENT =========================
        ' ----- PRINT CODE --------
        sHtmlContent &= "<form><input type=" & """" & "button" & """" & " value=" & """" & " Print this page " & """" & "onclick=" & """" & "this.style.display='none'; window.print();return false;" & """" & " /></form> " & nL
        '--------------------\\
        ' main Table.
        sHtmlContent &= "<table border=" & """" & "0" & """" & " cellspacing=" & """" & "0" & """" & ">" & nL
        sHtmlContent &= t & "<tr>" & nL & t & t & "<td>" & nL
        ' ------- table for LOGO and Agency. -----------
        sHtmlContent &= t & "<table border=" & """" & "0" & """" & " cellspacing=" & """" & "0" & """" & ">" & nL
        ' sHtmlContent &= t & t & "<tr>" & nL & t & t & t & "<td>" & "<img src=" & """" & myLogo & """" & " width=" & """" & "169" & """" & " height=" & """" & "48" & """" & "></td>" & nL
        sHtmlContent &= t & t & t & "<td width=" & """" & "90%" & """" & "><center>&nbsp;&nbsp;&nbsp;<span style=" & """" & "font-size:28px;font-weight:bolder;" & """" & ">" & FrmMain.lblAgency.Text & "</span></center></td>" & nL
        sHtmlContent &= t & t & "</tr>" & nL & t & "</table>" & nL ' table for top content. logo, print, etc.
        '---------\\
        ' ------- table for Officer and STATS DATES "FROM" - "TO". --------------
        sHtmlContent &= t & "<table border=" & """" & "0" & """" & " cellspacing=" & """" & "0" & """" & " width=" & """" & "100%" & """" & ">" & nL
        'sHtmlContent &= t & t & "<tr>" & nL & t & t & t & "<td align=" & """" & "right" & """" & "><h3>Officer: " & FrmMain.cmbOfficer.Text & "</h3></td>" & nL & t & t & "</tr>"
        sHtmlContent &= t & t & "<tr>" & nL & t & t & t & "<td><h3>Stats Report: " & Format(dtpFrom.Value, "MMMM dd, yyyy") & " - " & Format(dtpTo.Value, "MMMM dd, yyyy") & "</h3></td>" & "<td>&nbsp;</td>" & nL & t & t & "<td align=" & """" & "Left" & """" & "><h3>Officer: " & FrmMain.lblOfficer.Text.ToString & "</h3></td>" & nL & t & t & "</tr>" & nL
        sHtmlContent &= t & t & "</tr>" & nL & t & "</table>" & nL ' table for top content. logo, print, etc.
        '---------\\
        sStatsViewerLines = "" ' clear for new Stats(commented lines).
    End Sub

    Private Sub setHtmlContent(ByVal ReportName As String)
        sHtmlContent &= t & "<table border=" & """" & "1" & """" & " cellspacing=" & """" & "0" & """" & ">" & nL
        sHtmlContent &= t & t & "<tr>" & nL & t & t & t & "<td width=" & """" & "165" & """" & " class=" & """" & "topRow" & """" & "><span class=" & """" & "reportName" & """" & ">" & ReportName & "</span></td>" & nL
        ' --------- DAYS -----------------
        Dim arDayOfWeek() As String = {"Su", "Mo", "Tu", "We", "Th", "Fr", "Sa"} ' array to set day of week since extracting day of week returns a # from 0-6.
        '--//----------- ARRAY LISTS & stuff to Read Files.
        Dim arlStat1, arlStat2, arlStat3, arlStat4, arlStat5, arlStat6, arlStat7, arlStat8, arlStat9, arlStat10, arlStat11, arlStat12, arlStat13, arlStat14 As New ArrayList ' For Stat Names.
        Dim arObligatedHours, arNonObligatedHours, arTOTALTIMES, arJusticeCourtHours, arDistrictCourtHours, arTOTALHOURS As New ArrayList

        Dim arFile(), arLine() As String : Dim sTopRowDays As String = "", sTopRow As String = ""
        '                ------------------\\--
        ' retrieve all Files from Folders/SubFolders.
        'For Each DailyLogFile As String In My.Computer.FileSystem.GetFiles(x.myFilesFolder, FileIO.SearchOption.SearchAllSubDirectories, "*.DLF")
        For Each DailyLogFile As String In My.Computer.FileSystem.GetFiles(currentFolderDirectory, FileIO.SearchOption.SearchAllSubDirectories, "*.DLF")


            sFileName = Path.GetFileNameWithoutExtension(DailyLogFile) ' get FileName.
            sFileName = sFileName.Replace(".", "/") ' replace the . with /.
            dtFile = CDate(sFileName) ' set FileName as Date to Format.
            If dtFile >= CDate(Format(dtpFrom.Value, "MM/dd/yyyy")) AndAlso dtFile <= CDate(Format(dtpTo.Value, "MM/dd/yyyy")) Then ' compare if greater/less than.
                sFileName = Format(dtFile, "MMMddyyyy") ' Format.
                ' -- sFileName.Substring(0, 3)='s First 3 letters of Month, -- sFileName.Substring(3, 2)='s Day in ## format,
                sHtmlContent &= t & t & t & "<td class=" & """" & "topRow" & """" & ">" & sFileName.Substring(0, 3) & "<br /><span class=" & """" & "dayNumber" & """" & ">" & sFileName.Substring(3, 2) & "</span><br /><span class=" & """" & "dayName" & """" & ">(" & arDayOfWeek(dtFile.DayOfWeek) & ")</span><br /><span class=" & """" & "year" & """" & ">" & sFileName.Substring(5, 4) & "</span></td>" & nL '--\\
                ' -- save Top Row for later use in HTML.
                sTopRowDays &= t & t & t & "<td class=" & """" & "topRow" & """" & ">" & sFileName.Substring(0, 3) & "<br /><span class=" & """" & "dayNumber" & """" & ">" & sFileName.Substring(3, 2) & "</span><br /><span class=" & """" & "dayName" & """" & ">(" & arDayOfWeek(dtFile.DayOfWeek) & ")</span><br /><span class=" & """" & "year" & """" & ">" & sFileName.Substring(5, 4) & "</span></td>" & nL '--\\
                ' -- Stats Viewer
                sX = Format(dtFile, "MMddyy")
                If Not sStatsViewerLines.Contains(sX) Then ' only add Days once.
                    If Not sStatsViewerLines = "" Then
                        sStatsViewerLines &= "/" & sX
                    Else
                        sStatsViewerLines &= sX
                    End If
                End If '--\\
                ' READ FILE and Extract STATS.
                arFile = File.ReadAllLines(Path.GetFullPath(DailyLogFile))
                For Each line As String In arFile
                    If line.StartsWith("Shift-Stats:") Then : arLine = line.Split("‡"c)
                        If ReportName = "CITY" Then
                            arlStat1.Add(arLine(1)) : arlStat2.Add(arLine(3)) : arlStat3.Add(arLine(5)) : arlStat4.Add(arLine(7))
                            arlStat5.Add(arLine(9)) : arlStat6.Add(arLine(11)) : arlStat7.Add(arLine(13)) : arlStat8.Add(arLine(21))
                            arlStat9.Add(arLine(23)) : arlStat10.Add(arLine(25)) : arlStat11.Add(arLine(27)) : arlStat12.Add(arLine(29))
                            arlStat13.Add(arLine(31)) : arlStat14.Add(arLine(33))
                            arObligatedHours.Add(arLine(15)) : arNonObligatedHours.Add(arLine(17))
                            If arLine(15) = Nothing Then arLine(15) = "0"
                            If arLine(17) = Nothing Then arLine(17) = "0"
                            arTOTALTIMES.Add(CDec(arLine(15).Replace(":", ".")) + CDec(arLine(17).Replace(":", ".")))
                            arJusticeCourtHours.Add(arLine(35)) : arDistrictCourtHours.Add("0") : arTOTALHOURS.Add(arLine(35))
                            Exit For
                        ElseIf ReportName = "COUNTY" Then
                            arlStat1.Add(arLine(2)) : arlStat2.Add(arLine(4)) : arlStat3.Add(arLine(6)) : arlStat4.Add(arLine(8))
                            arlStat5.Add(arLine(10)) : arlStat6.Add(arLine(12)) : arlStat7.Add(arLine(14)) : arlStat8.Add(arLine(22))
                            arlStat9.Add(arLine(24)) : arlStat10.Add(arLine(26)) : arlStat11.Add(arLine(28)) : arlStat12.Add(arLine(30))
                            arlStat13.Add(arLine(32)) : arlStat14.Add(arLine(34))
                            arObligatedHours.Add(arLine(16)) : arNonObligatedHours.Add(arLine(18))
                            If arLine(16) = Nothing Then arLine(16) = "0"
                            If arLine(18) = Nothing Then arLine(18) = "0"
                            arTOTALTIMES.Add(CDec(arLine(16).Replace(":", ".")) + CDec(arLine(18).Replace(":", ".")))
                            arJusticeCourtHours.Add(arLine(36)) : arDistrictCourtHours.Add(arLine(37))
                            If arLine(36) = Nothing Then arLine(36) = "0"
                            If arLine(37) = Nothing Then arLine(37) = "0"
                            arTOTALHOURS.Add(CDbl(arLine(36).Replace(":", ".")) + CDec(arLine(37).Replace(":", ".")))
                        End If
                    End If
                Next
                ProgressBar1.Value += 1
            End If
        Next
        ' add TOTAL column.
        sHtmlContent &= t & t & t & "<td class=" & """" & "topRow" & """" & "><span class=" & """" & "total" & """" & ">&nbsp;TOTAL&nbsp;</span></td>" & nL
        '---------------------------------------------------------\\
        sStatsReportNameForStatsViewerLines = ReportName
        ' =============== Stats Rows ==============================
        With FrmMain
            Me.getStats(.txtStat1.Text, True, arlStat1)
            Me.getStats(.txtStat2.Text, False, arlStat2)
            Me.getStats(.txtStat3.Text, True, arlStat3)
            Me.getStats(.txtStat4.Text, False, arlStat4)
            Me.getStats(.txtStat5.Text, True, arlStat5)
            Me.getStats(.txtStat6.Text, False, arlStat6)
            Me.getStats(.txtStat7.Text, True, arlStat7)
            Me.getStats(.txtStat8.Text, False, arlStat8)
            Me.getStats(.txtStat9.Text, True, arlStat9)
            Me.getStats(.txtStat10.Text, False, arlStat10)
            Me.getStats(.txtStat11.Text, True, arlStat11)
            Me.getStats(.txtStat12.Text, False, arlStat12)
            Me.getStats(.txtStat13.Text, True, arlStat13)
            Me.getStats(.txtStat14.Text, False, arlStat14)
        End With
        '========\\
        ' ===================== SHIFT TIMES ===================================
        sTopRow = t & t & "<tr>" & nL & t & t & t & "<td width=" & """" & "165" & """" & " class=" & """" & "topRow" & """" & "><span class=" & """" & "reportName" & """" & ">" & ReportName & "</span></td>" & nL & sTopRowDays & nL & t & t & t & "<td class=" & """" & "topRow" & """" & "><span class=" & """" & "total" & """" & ">&nbsp;TOTAL&nbsp;</span></td>" & nL
        '-------------------------------------------------------------------------------
        sHtmlContent &= sTopRow   ' top row w/Days.
        Me.getHours("Obligated Hours", True, arObligatedHours)
        Me.getHours("Non Obligated Hours", False, arNonObligatedHours)
        Me.getTotal("TOTAL TIMES", True, arTOTALTIMES)
        sHtmlContent &= sTopRow ' top row w/Days.
        Me.getHours("Justice Court Hours", False, arJusticeCourtHours)
        If Not ReportName = "CITY" Then
            Me.getHours("District Court Hours", True, arDistrictCourtHours)
            Me.getTotal("TOTAL HOURS", False, arTOTALHOURS)
        Else
            ProgressBar1.Value += 2 ' +2 since the Functions adds +1
        End If
        '-------------------------------------------------------------------------------
        sHtmlContent &= t & t & "</tr>" & nL & t & "</table>" & nL
        '================\\
    End Sub

    Private Function getStats(ByVal StatName As String, ByVal isEVENrow As Boolean, ByVal selArrayList As ArrayList) As String
        iCounter = 0 ' reset Counter.
        sStatsViewerLines &= nL & sStatsReportNameForStatsViewerLines & ":" & StatName & ":"
        If isEVENrow Then
            sHtmlContent &= sEvenRowStatName & StatName & "</td>" & nL : sX = sEvenRowStat
        Else : sHtmlContent &= sOddRowStatName & StatName & "</td>" & nL : sX = sOddRowStat
        End If
        For i As Integer = 0 To selArrayList.Count - 1
            If Not selArrayList(i).ToString = Nothing Then
                sHtmlContent &= sX & selArrayList(i).ToString & "</td>" & nL
                Try
                    iCounter += CInt(selArrayList(i))
                Catch ex As Exception
                    'MsgBox("Error") This was giving an error on some files. It's skipping the error. You can see the printout
                    ' is a bit goofy when you print it, like an empty box isn't showing the -UPDATE 04/10/12- this happens when
                    ' a 'space' is entered into a box. When the space is removed, the box prints normally. The space creates
                    ' the error.
                End Try

                sStatsViewerLines &= "/" & selArrayList(i).ToString
            Else
                sHtmlContent &= sX & "-</td>" & nL
                sStatsViewerLines &= "/"
            End If
        Next
        ' -- Total
        sHtmlContent &= sX & "<strong>" & iCounter & "</strong></td>" & nL
        ProgressBar1.Value += 1
        Return Nothing
    End Function

    Private Function getHours(ByVal StatName As String, ByVal isEVENrow As Boolean, ByVal selArrayList As ArrayList) As String
        dCounter = 0 ' reset Counter.
        sStatsViewerLines &= nL & sStatsReportNameForStatsViewerLines & ":" & StatName & ":"
        If isEVENrow Then
            sHtmlContent &= sEvenRowStatName & StatName & "</td>" & nL : sX = sEvenRowStat
        Else : sHtmlContent &= sOddRowStatName & StatName & "</td>" & nL : sX = sOddRowStat
        End If
        For i As Integer = 0 To selArrayList.Count - 1
            If Not selArrayList(i).ToString = Nothing Then
                selArrayList(i) = selArrayList(i).ToString.Replace(":", ".")
                sTemp = timeFormat(CStr(FrmCallDetails.roundTime(CDec(selArrayList(i)))).ToString.Replace(".", ":"))
                If sTemp = "0" Then sTemp = "-"
                sHtmlContent &= sX & sTemp & "</td>" & nL
                dCounter += CDec(selArrayList(i))
                sStatsViewerLines &= "/" & selArrayList(i).ToString
            Else
                sHtmlContent &= sX & "-</td>" & nL
                sStatsViewerLines &= "/"
            End If
        Next
        ' -- Total Hours.
        sHtmlContent &= sX & "<strong>" & getTotalHours(selArrayList) & "</strong></td>" & nL
        ProgressBar1.Value += 1
        Return Nothing
    End Function

    Private Function getTotal(ByVal StatName As String, ByVal isEVENrow As Boolean, ByVal selArrayList As ArrayList) As String
        dCounter = 0 ' reset Counter.
        sStatsViewerLines &= nL & sStatsReportNameForStatsViewerLines & ":" & StatName & ":"
        If isEVENrow Then
            sHtmlContent &= sEvenRowStatName & StatName & "</td>" & nL : sX = sEvenRowStat
        Else : sHtmlContent &= sOddRowStatName & StatName & "</td>" & nL : sX = sOddRowStat
        End If
        For i As Integer = 0 To selArrayList.Count - 1
            If Not selArrayList(i).ToString = Nothing Then
                sTemp = timeFormat(CStr(FrmCallDetails.roundTime(CDec(selArrayList(i)))).ToString.Replace(".", ":"))
                If sTemp = "0" Then sTemp = "-"
                sHtmlContent &= sX & sTemp & "</td>" & nL
                dCounter += CDec(selArrayList(i))
                sStatsViewerLines &= "/" & selArrayList(i).ToString
            Else
                sHtmlContent &= sX & "-</td>" & nL
                sStatsViewerLines &= "/"
            End If
        Next
        ' -- Total Hours.
        sHtmlContent &= sX & "<strong>" & getTotalHours(selArrayList) & "</strong></td>" & nL
        ProgressBar1.Value += 1
        Return Nothing
    End Function

    Private Function getTotalHours(ByVal selArrayList As ArrayList) As String
        sTotalHours = 0 ' reset.
        For Each itm As String In selArrayList
            If Not itm = Nothing Then
                sTotalHours += CDbl(itm)
                If sTotalHours.Contains(".") Then ' Check if String contains a dot.
                    Dim dHr As Decimal = CDec(sTotalHours.Substring(0, sTotalHours.IndexOf("."))) ' get all #'s before the dot.
                    Dim dMin As Decimal = CDec(sTotalHours.Substring(sTotalHours.IndexOf("."))) ' get all #'s after the dot.
                    If dMin >= 0.6 Then ' check if # after dot is greater than .6, or 60 Minutes.
                        dMin = dMin - 0.6 ' if so, subtract 60 from Minutes.
                        dHr += 1 ' and add +=1 to the Hour.
                    End If
                    sTotalHours = dHr + dMin ' set the time back as Decimal.
                End If
            End If
        Next
        If sTotalHours.Contains(".") Then ' check if it contains the dot.
            sTotalHours = sTotalHours.Replace(".", ":") ' replace it w/the ":".
            ' add a "0" if only 1 char. after the dot.
            If sTotalHours.Substring(sTotalHours.IndexOf(":") + 1).Length = 1 Then sTotalHours &= "0"
        Else ' if no dot.
            sTotalHours &= ":00"
        End If
        If sTotalHours = "0:00" Then sTotalHours = "-" ' if a "0" for Total.
        Return sTotalHours
    End Function

    ' Add a "0" to time if it is #.# and not #.##.
    Private Function timeFormat(ByVal sTimeToFormat As String) As String
        If sTimeToFormat.Contains(":") Then
            arTemp = sTimeToFormat.Split(":"c)
            If arTemp(1).Length = 1 Then arTemp(1) = arTemp(1) & "0"
            sTimeToFormat = arTemp(0) & ":" & arTemp(1)
        Else
            sTimeToFormat &= ":00"
        End If
        If sTimeToFormat = "0:00" Then sTimeToFormat = "-" ' if a "0" for Total.
        Return sTimeToFormat
    End Function

End Class