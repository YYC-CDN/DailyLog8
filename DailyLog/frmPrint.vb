'  Started August 1st 2011

Imports System.IO

Public Class frmPrint
    Private sT As String = Nothing '  TEMP String, just min. from sTemp to sT. :)


#Region "====================== PRINT CURRENT LOG VARIABLES ======================"

    Private myHTMLlogFile As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) _
                                       & "\DailyLog\HTML_Files" & "\" & "" & FrmMain.lblID.Text & "" & "\" & FrmMain.lblFileDate.Text & " " & FrmMain.lblOfficer.Text & ".html"

    Private Sub frmPrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Me.Text = "DailyLog Print Screen"
        Me.Location = x.centerForm(Me) '  Center Form of FrmMain.

        Dim LogFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\DailyLog\HTML_Files" '  your folder.
        If Not IO.Directory.Exists(LogFolder) Then '  if folder does not exist,
            IO.Directory.CreateDirectory(LogFolder) '  create folder.
        Else
        End If

        printLogToHtml()
    End Sub

#End Region

#Region "====================== PRINT CURRENT LOG ================================"

    Private sHtmlContent As String = Nothing, nL As String = vbNewLine, t As String = vbTab '  HTML stuff.
    ' Private myFavicon As String = "file:///" & x.myIconFullPath '  Icon on WebBrowser.
    ' Private myLogo As String = "file:///" & x.myLogoImage '  Logo on Webpage.
    Private mySelectedLogFileLines() As String = Nothing '  load log file lines.
    Private sOfficer, sLocation, sRadar, sSupervisor, sDate, sAgency, sMileage, sNotes, sStats, sContractCities As String '  set values from file.
    Private arlEntries As New ArrayList '  loads all entiries for later use.
    Private arEntries() As String = Nothing '  .Split each entry.

    Public Sub printLogToHtml()
        x.saveFile(myBackupFile) '  save backup to use the file.
        Application.DoEvents() '  give it time if needed.
        mySelectedLogFileLines = File.ReadAllLines(myBackupFile) '  load backupFile into Array.
        arlEntries.Clear() '  clear ArrayList of entries.
        For Each fileLine As String In mySelectedLogFileLines '  blah blah, loop thru file lines.
            With fileLine '  set values to Strings.
                'If .StartsWith("Officers:") Then sOfficer = .Substring(.IndexOf("‡") + 1)
                If .StartsWith("Officers:") Then sOfficer = frmOptions.txtAddOfficer.Text.ToString
                If .StartsWith("Patrol Areas:") Then sLocation = .Substring(.IndexOf("‡") + 1)
                If .StartsWith("Supervisors:") Then sSupervisor = .Substring(.IndexOf("‡") + 1)
                If .StartsWith("Backup-Restore FileName:") Then sDate = .Substring(.IndexOf("‡") + 1)
                If .StartsWith("Agency/Department:") Then sAgency = .Substring(.IndexOf("‡") + 1)
                If .StartsWith("Shift-Notes:") Then sNotes = .Substring(.IndexOf("‡") + 1)
                If .StartsWith("Mileage:") Then sMileage = .Substring(.IndexOf("‡") + 1)
                If .StartsWith("Equipment Verified:") Then sRadar = .Substring(.IndexOf("‡") + 1)
                If .StartsWith("Entry:") Then arlEntries.Add(.Substring(.IndexOf("‡") + 1))
                If .StartsWith("Shift-Stats:") Then sStats = .Substring(.IndexOf("‡") + 1)
                If .StartsWith("Contract-Cities:") Then sContractCities = .Substring(.IndexOf("‡") + 1)
            End With
        Next
        arlEntries.Sort() '  sort ArrayList from 1 to whatever.
        setHtml(sDate & " - " & sOfficer) '  set Content and Title.
    End Sub

    Private Sub setHtml(ByVal ReportName As String)
        '  Title.
        sHtmlContent = "<html>" & nL & t & "<head>" & nL & t & t & "<title>" & ReportName & " - Daily Log</title>" & nL
        '  favicon.
        sHtmlContent &= t & t & "<link rel=" & """" & "shortcut icon" & """" & " href=" & """" & """" & ">" & nL
        ' -- CSS.
        sHtmlContent &= "<style type=" & """" & "text/css" & """" & ">" & nL
        sHtmlContent &= t & "td.info {font-size:12px; font-weight:bold;}" & nL
        sHtmlContent &= t & "td.entry {font-size:12px; font-weight:bold; text-align:left;}" & nL
        sHtmlContent &= t & "td.entryLT {font-size:12px; font-weight:bold; text-align:center; width:95px;}" & nL
        sHtmlContent &= t & "td.entryMTsm {font-size:12px; font-weight:bold; text-align:center; width:25%;}" & nL
        sHtmlContent &= t & "td.entryMT {font-size:12px; font-weight:bold; text-align:center; width:65%;}" & nL
        sHtmlContent &= t & "td.mileage {font-size:12px; font-weight:bold;}" & nL
        sHtmlContent &= t & "td.stats {font-size:12px; font-weight:bold;}" & nL
        sHtmlContent &= t & "td.contract {font-size:12px; font-weight:bold;}" & nL

        sHtmlContent &= "</style>" & nL
        '------------\\
        sHtmlContent &= t & "</head>" & nL & "<body>" & nL


        ' ============ BODY CONTENT =======================================
        ' ----- PRINT CODE --------
        sHtmlContent &= "<form><input type=" & """" & "button" & """" & " value=" & """" & " Print this page " & """" & "onclick=" & """" & "this.style.display='none'; window.print();return false;" & """" & " /></form> " & nL
        '--------------------\\
        With FrmMain


            ' ----- AGENCY--------
            '  sHtmlContent &= t & t & "<tr>" & nL & t & t & t & "<td>" & "<img src=" & """" & myLogo & """" & " width=" & """" & "169" & """" & " height=" & """" & "48" & """" & "></td>" & nL
            sHtmlContent &= "<center><span style=""" & "font-size:28px;font-weight:bold;" & """" & ">" & frmOptions.txtAddAgency.Text & "</span></center> " & nL
            '--------------------\\
            ' ------ Agency Header Table.
            sHtmlContent &= "<center>" & nL & "<table border=""0"" cellspacing=""0"" width=""100%"">" & nL
            sHtmlContent &= t & "<tr>" & nL
            sHtmlContent &= t & t & "<td class=""info"">Officer: " & frmOptions.txtAddOfficer.Text.ToString & "</td>" & nL
            sHtmlContent &= t & t & "<td class=""info"">Location: " & frmOptions.txtAddArea.Text.ToString & "</td>" & nL
            sHtmlContent &= t & t & "<td class=""info"">Equipment Verified: " & sRadar & "</td>" & nL
            sHtmlContent &= t & t & "<td class=""info"">Supervisor: " & frmOptions.txtAddSupervisor.Text.ToString & "</td>" & nL
            'sHtmlContent &= t & t & "<td class=""info"">Date: " & sDate & "</td>" & nL
            sHtmlContent &= t & t & "<td class=""info"">Date: " & FrmMain.lblFileDate.Text & "</td>" & nL
            sHtmlContent &= t & "</tr>" & nL & "</table>" & nL & "</center>" & nL & "<br />" & nL
            '----------\\
            ' ------ Entry(s) Header Table.
            sHtmlContent &= "<table border=""1"" cellspacing=""1"" width=""100%"">" & nL
            sHtmlContent &= t & "<tr>" & nL
            sHtmlContent &= t & t & "<td class=""entryLT"">ASSIGNED</td>" & nL
            sHtmlContent &= t & t & "<td class=""entryLT"">CLEARED</td>" & nL
            sHtmlContent &= t & t & "<td class=""entryLT"">TOTAL TIME</td>" & nL
            sHtmlContent &= t & t & "<td class=""entryMTsm"">LOCATION / CALL TYPE</td>" & nL
            sHtmlContent &= t & t & "<td class=""entryMT"">TYPE OF ACTIVITY AND DISPOSITION</td>" & nL
            sHtmlContent &= t & t & "<td class=""entryLT"">CASE #</td>" & nL
            sHtmlContent &= t & "</tr>" & nL
            '----------\\
            ' ------ Entry(s).
            For Each itm As String In arlEntries
                sHtmlContent &= t & "<tr>" & nL
                arEntries = itm.Split("‡"c)

                If arEntries(1) = "" Then arEntries(1) = "&nbsp;"
                If arEntries(2) = "" Then arEntries(2) = "&nbsp;"
                If arEntries(3) = "" Then arEntries(3) = "&nbsp;"
                If arEntries(4) = "" Then arEntries(5) = "&nbsp;"
                If arEntries(5) = "" Then arEntries(5) = "&nbsp;"
                If arEntries(6) = "" Then arEntries(6) = "&nbsp;"


                sHtmlContent &= t & t & "<td class=""entry"">" & arEntries(1) & "</td>" & nL
                sHtmlContent &= t & t & "<td class=""entry"">" & arEntries(2) & "</td>" & nL
                sHtmlContent &= t & t & "<td class=""entry"">" & arEntries(3) & "</td>" & nL
                sHtmlContent &= t & t & "<td class=""entry"">" & arEntries(4) & "</td>" & nL
                sHtmlContent &= t & t & "<td class=""entry"">" & arEntries(5) & "</td>" & nL
                sHtmlContent &= t & t & "<td class=""entry"">" & arEntries(6) & "</td>" & nL
                sHtmlContent &= t & "</tr>" & nL
            Next
            sHtmlContent &= "</table>" & nL
            '----------\\
            sHtmlContent &= "<br /><br />" & nL

            ' ================== MILEAGE / NOTES / STATS==================================
            sHtmlContent &= "<center>" & nL & "<table border=""0"" cellspacing=""0"" width=""100%"">" & nL
            sHtmlContent &= t & "<tr>" & nL
            sHtmlContent &= t & t & "<td valign=""top"">" & nL
            sHtmlContent &= t & t & "<table width=""145px"">" & nL  '  Mileage / Notes
            sHtmlContent &= t & t & t & "<tr>" & nL
            sHtmlContent &= t & t & t & t & "<td class=""mileage"">" & nL
            sHtmlContent &= t & t & t & t & "Miles End:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" & vbTab & sMileage.Split("‡"c).GetValue(1) & nL
            sHtmlContent &= t & t & t & t & "<br />" & nL
            sHtmlContent &= t & t & t & t & "Miles Start:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" & vbTab & sMileage.Split("‡"c).GetValue(0) & nL
            sHtmlContent &= t & t & t & t & "<br />" & nL
            Try
                sHtmlContent &= t & t & t & t & "Total Miles:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" & vbTab & (CInt(sMileage.Split("‡"c).GetValue(1)) - CInt(sMileage.Split("‡"c).GetValue(0))).ToString & nL
            Catch ex As Exception
                sHtmlContent &= t & t & t & t & "Total Miles:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" & "No Mileage" & nL
            End Try
            sHtmlContent &= t & t & t & t & "</td>" & nL
            sHtmlContent &= t & t & t & "</tr>" & nL
            sHtmlContent &= t & t & t & "<tr>" & nL
            sHtmlContent &= t & t & t & t & "<td class=""mileage"">&nbsp;</td>" & nL
            sHtmlContent &= t & t & t & "</tr>" & nL
            sHtmlContent &= t & t & t & "<tr>" & nL
            sHtmlContent &= t & t & t & t & "<td class=""mileage""><center>Notes / Remarks</center></td>" & nL
            sHtmlContent &= t & t & t & "</tr>" & nL
            sHtmlContent &= t & t & t & "<tr>" & nL
            sHtmlContent &= t & t & t & t & "<td class=""mileage"">" & sNotes & "</td>" & nL
            sHtmlContent &= t & t & t & "</tr>" & nL
            sHtmlContent &= t & t & "</table>" & nL '  END Mileage / Notes

            '' ================== CONTRACT CITIES ==============================
            'sHtmlContent &= t & t & "<td valign=""top"">" & nL '  start new <table> cell next to Mileage/Notes.
            'If Not sContractCities = "" Then '  check if values in sContractCities.
            '    sHtmlContent &= t & t & "<table width=""100%""><tr>" '  add.Title to <table>, as <table>;to center on 2 cell <table> below.
            '    sHtmlContent &= "<td class=""contract""><center>Contract Cities</center>"
            '    sHtmlContent &= "</td></tr></table>"
            '    With sContractCities.Split("‡"c) '  If Values in sContractCities, create <table> with rows for each city.
            '        sHtmlContent &= t & t & "<table width=""150px"" border=""1"">" & nL  '  Contract Cities
            '        sHtmlContent &= t & t & t & "</tr><tr>" & nL '  end row/new row.
            '        sHtmlContent &= setContracts(FrmMain.txtContractCity1.Text, .GetValue(0))
            '        sHtmlContent &= t & t & t & "</tr><tr>" & nL '  end row/new row.
            '        sHtmlContent &= setContracts(FrmMain.txtContractCity2.Text, .GetValue(1))
            '        sHtmlContent &= t & t & t & "</tr><tr>" & nL '  end row/new row.
            '        sHtmlContent &= setContracts(FrmMain.txtContractCity3.Text, .GetValue(2))
            '        sHtmlContent &= t & t & t & "</tr><tr>" & nL '  end row/new row.
            '        sHtmlContent &= setContracts(FrmMain.txtContractCity4.Text, .GetValue(3))
            '        sHtmlContent &= t & t & t & "</tr><tr>" & nL '  end row/new row.
            '        sHtmlContent &= setContracts(FrmMain.txtContractCity5.Text, .GetValue(4))
            '        sHtmlContent &= t & t & t & "</tr><tr>" & nL '  end row/new row.
            '        sHtmlContent &= setContracts(FrmMain.txtContractCity6.Text, .GetValue(5))
            '        sHtmlContent &= t & t & t & "</tr><tr>" & nL '  end row/new row.
            '        sHtmlContent &= setContracts(FrmMain.txtContractCity7.Text, .GetValue(6))
            '        sHtmlContent &= t & t & t & "</tr><tr>" & nL '  end row/new row.
            '        sHtmlContent &= setContracts(FrmMain.txtContractCity8.Text, .GetValue(7))
            '        sHtmlContent &= t & t & t & "</tr><tr>" & nL '  end row/new row.
            '        sHtmlContent &= setContracts(FrmMain.txtContractCity9.Text, .GetValue(8))
            '        sHtmlContent &= t & t & t & "</tr><tr>" & nL '  end row.
            '        sHtmlContent &= t & t & "</table>" & nL  '  END CONTRACT CITIES
            '    End With
            'End If
            'sHtmlContent &= t & t & "</td>" & nL
            ''  END CONTRACT CITIES ==============================



            sHtmlContent &= t & t & "</td>" & nL
            sHtmlContent &= t & t & "<td width=""70%"" valign=""top"">" & nL '  Stats
            sHtmlContent &= t & t & "<table border=""1""  width=""100%"">" & nL ' 
            sHtmlContent &= t & t & t & "<tr>" & nL
            sHtmlContent &= t & t & t & t & "<td class=""stats"">&nbsp;</td>" & nL
            sHtmlContent &= t & t & t & t & "<td class=""stats""><center>City</center></td>" & nL
            sHtmlContent &= t & t & t & t & "<td class=""stats""><center>County</center></td>" & nL
            sHtmlContent &= t & t & t & t & "<td class=""stats"">&nbsp;</td>" & nL
            sHtmlContent &= t & t & t & t & "<td class=""stats""><center>City</center></td>" & nL
            sHtmlContent &= t & t & t & t & "<td class=""stats""><center>County</center></td>" & nL
            sHtmlContent &= t & t & t & "</tr>" & nL
            Dim sContent As String = "" '  set and check if value is "".
            With FrmMain
                sHtmlContent &= t & t & t & "<tr>" & nL
                sHtmlContent &= t & t & t & t & "<td class=""stats"">" & .txtStat1.Text & "</td>" & nL
                sContent = sStats.Split("‡"c).GetValue(0)
                If sContent = "" Then sContent = "&nbsp;"
                sHtmlContent &= t & t & t & t & "<td class=""stats""><center>" & sContent & "</center></td>" & nL
                sContent = sStats.Split("‡"c).GetValue(1)
                If sContent = "" Then sContent = "&nbsp;"
                sHtmlContent &= t & t & t & t & "<td class=""stats""><center>" & sContent & "</center></td>" & nL
                sHtmlContent &= t & t & t & t & "<td class=""stats"">" & .txtStat8.Text & "</td>" & nL
                sContent = sStats.Split("‡"c).GetValue(20)
                If sContent = "" Then sContent = "&nbsp;"
                sHtmlContent &= t & t & t & t & "<td class=""stats""><center>" & sContent & "</center></td>" & nL
                sContent = sStats.Split("‡"c).GetValue(21)
                If sContent = "" Then sContent = "&nbsp;"
                sHtmlContent &= t & t & t & t & "<td class=""stats""><center>" & sContent & "</center></td>" & nL
                sHtmlContent &= t & t & t & "</tr>" & nL
                sHtmlContent &= t & t & t & "<tr>" & nL
                sHtmlContent &= t & t & t & t & "<td class=""stats"">" & .txtStat2.Text & "</td>" & nL
                sContent = sStats.Split("‡"c).GetValue(2)
                If sContent = "" Then sContent = "&nbsp;"
                sHtmlContent &= t & t & t & t & "<td class=""stats""><center>" & sContent & "</center></td>" & nL
                sContent = sStats.Split("‡"c).GetValue(3)
                If sContent = "" Then sContent = "&nbsp;"
                sHtmlContent &= t & t & t & t & "<td class=""stats""><center>" & sContent & "</center></td>" & nL
                sHtmlContent &= t & t & t & t & "<td class=""stats"">" & .txtStat9.Text & "</td>" & nL
                sContent = sStats.Split("‡"c).GetValue(22)
                If sContent = "" Then sContent = "&nbsp;"
                sHtmlContent &= t & t & t & t & "<td class=""stats""><center>" & sContent & "</center></td>" & nL
                sContent = sStats.Split("‡"c).GetValue(23)
                If sContent = "" Then sContent = "&nbsp;"
                sHtmlContent &= t & t & t & t & "<td class=""stats""><center>" & sContent & "</center></td>" & nL
                sHtmlContent &= t & t & t & "</tr>" & nL
                sHtmlContent &= t & t & t & "<tr>" & nL
                sHtmlContent &= t & t & t & t & "<td class=""stats"">" & .txtStat3.Text & "</td>" & nL
                sContent = sStats.Split("‡"c).GetValue(4)
                If sContent = "" Then sContent = "&nbsp;"
                sHtmlContent &= t & t & t & t & "<td class=""stats""><center>" & sContent & "</center></td>" & nL
                sContent = sStats.Split("‡"c).GetValue(5)
                If sContent = "" Then sContent = "&nbsp;"
                sHtmlContent &= t & t & t & t & "<td class=""stats""><center>" & sContent & "</center></td>" & nL
                sHtmlContent &= t & t & t & t & "<td class=""stats"">" & .txtStat10.Text & "</td>" & nL
                sContent = sStats.Split("‡"c).GetValue(24)
                If sContent = "" Then sContent = "&nbsp;"
                sHtmlContent &= t & t & t & t & "<td class=""stats""><center>" & sContent & "</center></td>" & nL
                sContent = sStats.Split("‡"c).GetValue(25)
                If sContent = "" Then sContent = "&nbsp;"
                sHtmlContent &= t & t & t & t & "<td class=""stats""><center>" & sContent & "</center></td>" & nL
                sHtmlContent &= t & t & t & "</tr>" & nL
                sHtmlContent &= t & t & t & "<tr>" & nL
                sHtmlContent &= t & t & t & t & "<td class=""stats"">" & .txtStat4.Text & "</td>" & nL
                sContent = sStats.Split("‡"c).GetValue(6)
                If sContent = "" Then sContent = "&nbsp;"
                sHtmlContent &= t & t & t & t & "<td class=""stats""><center>" & sContent & "</center></td>" & nL
                sContent = sStats.Split("‡"c).GetValue(7)
                If sContent = "" Then sContent = "&nbsp;"
                sHtmlContent &= t & t & t & t & "<td class=""stats""><center>" & sContent & "</center></td>" & nL
                sHtmlContent &= t & t & t & t & "<td class=""stats"">" & .txtStat11.Text & "</td>" & nL
                sContent = sStats.Split("‡"c).GetValue(26)
                If sContent = "" Then sContent = "&nbsp;"
                sHtmlContent &= t & t & t & t & "<td class=""stats""><center>" & sContent & "</center></td>" & nL
                sContent = sStats.Split("‡"c).GetValue(27)
                If sContent = "" Then sContent = "&nbsp;"
                sHtmlContent &= t & t & t & t & "<td class=""stats""><center>" & sContent & "</center></td>" & nL
                sHtmlContent &= t & t & t & "</tr>" & nL
                sHtmlContent &= t & t & t & "<tr>" & nL
                sHtmlContent &= t & t & t & t & "<td class=""stats"">" & .txtStat5.Text & "</td>" & nL
                sContent = sStats.Split("‡"c).GetValue(8)
                If sContent = "" Then sContent = "&nbsp;"
                sHtmlContent &= t & t & t & t & "<td class=""stats""><center>" & sContent & "</center></td>" & nL
                sContent = sStats.Split("‡"c).GetValue(9)
                If sContent = "" Then sContent = "&nbsp;"
                sHtmlContent &= t & t & t & t & "<td class=""stats""><center>" & sContent & "</center></td>" & nL
                sHtmlContent &= t & t & t & t & "<td class=""stats"">" & .txtStat12.Text & "</td>" & nL
                sContent = sStats.Split("‡"c).GetValue(28)
                If sContent = "" Then sContent = "&nbsp;"
                sHtmlContent &= t & t & t & t & "<td class=""stats""><center>" & sContent & "</center></td>" & nL
                sContent = sStats.Split("‡"c).GetValue(29)
                If sContent = "" Then sContent = "&nbsp;"
                sHtmlContent &= t & t & t & t & "<td class=""stats""><center>" & sContent & "</center></td>" & nL
                sHtmlContent &= t & t & t & "</tr>" & nL
                sHtmlContent &= t & t & t & "<tr>" & nL
                sHtmlContent &= t & t & t & t & "<td class=""stats"">" & .txtStat6.Text & "</td>" & nL
                sContent = sStats.Split("‡"c).GetValue(10)
                If sContent = "" Then sContent = "&nbsp;"
                sHtmlContent &= t & t & t & t & "<td class=""stats""><center>" & sContent & "</center></td>" & nL
                sContent = sStats.Split("‡"c).GetValue(11)
                If sContent = "" Then sContent = "&nbsp;"
                sHtmlContent &= t & t & t & t & "<td class=""stats""><center>" & sContent & "</center></td>" & nL
                sHtmlContent &= t & t & t & t & "<td class=""stats"">" & .txtStat13.Text & "</td>" & nL
                sContent = sStats.Split("‡"c).GetValue(30)
                If sContent = "" Then sContent = "&nbsp;"
                sHtmlContent &= t & t & t & t & "<td class=""stats""><center>" & sContent & "</center></td>" & nL
                sContent = sStats.Split("‡"c).GetValue(31)
                If sContent = "" Then sContent = "&nbsp;"
                sHtmlContent &= t & t & t & t & "<td class=""stats""><center>" & sContent & "</center></td>" & nL
                sHtmlContent &= t & t & t & "</tr>" & nL
                sHtmlContent &= t & t & t & "<tr>" & nL
                sHtmlContent &= t & t & t & t & "<td class=""stats"">" & .txtStat7.Text & "</td>" & nL
                sContent = sStats.Split("‡"c).GetValue(12)
                If sContent = "" Then sContent = "&nbsp;"
                sHtmlContent &= t & t & t & t & "<td class=""stats""><center>" & sContent & "</center></td>" & nL
                sContent = sStats.Split("‡"c).GetValue(13)
                If sContent = "" Then sContent = "&nbsp;"
                sHtmlContent &= t & t & t & t & "<td class=""stats""><center>" & sContent & "</center></td>" & nL
                sHtmlContent &= t & t & t & t & "<td class=""stats"">" & .txtStat14.Text & "</td>" & nL
                sContent = sStats.Split("‡"c).GetValue(32)
                If sContent = "" Then sContent = "&nbsp;"
                sHtmlContent &= t & t & t & t & "<td class=""stats""><center>" & sContent & "</center></td>" & nL
                sContent = sStats.Split("‡"c).GetValue(33)
                If sContent = "" Then sContent = "&nbsp;"
                sHtmlContent &= t & t & t & t & "<td class=""stats""><center>" & sContent & "</center></td>" & nL
                sHtmlContent &= t & t & t & "</tr>" & nL









                ' ===================================

                sHtmlContent &= t & t & t & t & "<td class=""stats"">" & .lblObligated.Text & "</td>" & nL
                sContent = sStats.Split("‡"c).GetValue(14)
                If sContent = "" Then sContent = "&nbsp;"
                sHtmlContent &= t & t & t & t & "<td class=""stats""><center>" & sContent & "</center></td>" & nL
                sContent = sStats.Split("‡"c).GetValue(15)
                If sContent = "" Then sContent = "&nbsp;"
                sHtmlContent &= t & t & t & t & "<td class=""stats""><center>" & sContent & "</center></td>" & nL
                sHtmlContent &= t & t & t & t & "<td class=""stats"">" & .txtStat15.Text & "</td>" & nL
                sContent = sStats.Split("‡"c).GetValue(34)
                If sContent = "" Then sContent = "&nbsp;"
                sHtmlContent &= t & t & t & t & "<td class=""stats""><center>" & sContent & "</center></td>" & nL
                sContent = sStats.Split("‡"c).GetValue(35)
                If sContent = "" Then sContent = "&nbsp;"
                sHtmlContent &= t & t & t & t & "<td class=""stats""><center>" & sContent & "</center></td>" & nL
                sHtmlContent &= t & t & t & "</tr>" & nL
                sHtmlContent &= t & t & t & "<tr>" & nL
                sHtmlContent &= t & t & t & t & "<td class=""stats"">" & .lblNonObligated.Text & "</td>" & nL
                sContent = sStats.Split("‡"c).GetValue(16)
                If sContent = "" Then sContent = "&nbsp;"
                sHtmlContent &= t & t & t & t & "<td class=""stats""><center>" & sContent & "</center></td>" & nL
                sContent = sStats.Split("‡"c).GetValue(17)
                If sContent = "" Then sContent = "&nbsp;"
                sHtmlContent &= t & t & t & t & "<td class=""stats""><center>" & sContent & "</center></td>" & nL
                sHtmlContent &= t & t & t & t & "<td class=""stats"">" & .txtStat16.Text & "</td>" & nL
                sHtmlContent &= t & t & t & t & "<td class=""stats""><center>&nbsp;</center></td>" & nL
                sContent = sStats.Split("‡"c).GetValue(36)
                If sContent = "" Then sContent = "&nbsp;"
                sHtmlContent &= t & t & t & t & "<td class=""stats""><center>" & sContent & "</center></td>" & nL
                sHtmlContent &= t & t & t & "</tr>" & nL

                ' =============================================


                sHtmlContent &= t & t & t & "<tr>" & nL
                sHtmlContent &= t & t & t & "<tr>" & nL '  added in
                sHtmlContent &= t & t & t & t & "<td class=""stats"">" & .lblTotalTimes.Text & "</td>" & nL
                sContent = sStats.Split("‡"c).GetValue(18)
                If sContent = "" Then sContent = "&nbsp;"
                sHtmlContent &= t & t & t & t & "<td class=""stats""><center>" & sContent & "</center></td>" & nL
                sContent = sStats.Split("‡"c).GetValue(19)
                If sContent = "" Then sContent = "&nbsp;"
                sHtmlContent &= t & t & t & t & "<td class=""stats""><center>" & sContent & "</center></td>" & nL
                sHtmlContent &= t & t & t & t & "<td class=""stats"">" & .lblTotalHours.Text & "</td>" & nL
                sContent = sStats.Split("‡"c).GetValue(37)
                If sContent = "" Then sContent = "&nbsp;"
                sHtmlContent &= t & t & t & t & "<td class=""stats""><center>" & sContent & "</center></td>" & nL
                sHtmlContent &= t & t & t & "</tr>" & nL
                sHtmlContent &= t & t & t & "</tr>" & nL
                sHtmlContent &= t & t & "<br />" & nL
                '--------------------
                sHtmlContent &= t & t & "<table border=""1""  width=""100%"">" & nL '  Total Hours / Times

            End With
            sHtmlContent &= t & t & "</td>" & nL
            sHtmlContent &= t & "</tr>" & nL & "</table>" & nL & "</center>" & nL
            '----------\\
            sHtmlContent &= "</body>" & nL & "</html>"
        End With
        Try
            File.WriteAllText(myHTMLlogFile, sHtmlContent) '  SAVE file.
        Catch ex As Exception
            'MsgBox("Can't find todays log")
        End Try

        Application.DoEvents()
        Try
            PrintBrowser.Navigate(myHTMLlogFile) '  LOAD in frm Browser.
        Catch ex As Exception

        End Try

    End Sub

    Private Function setContracts(ByVal selContractCity As String, ByVal selContractTime As String) As String
        sT = ""
        If Not selContractCity = "" OrElse selContractCity = "..." Then '  check if txtContractCity#.Text has a proper value.
            If selContractTime = "" Then selContractTime = "0:00" '  add 0's if needed instead of no value.
            '  create 2 <table> cells and add values to them.
            sT = t & t & t & t & "<tdcontract"">" & selContractCity & "</td>" & nL & _
        t & t & t & t & "<tdcontract""><center>" & selContractTime & "</center></td>" & nL
        End If
        Return sT
    End Function

#End Region

End Class