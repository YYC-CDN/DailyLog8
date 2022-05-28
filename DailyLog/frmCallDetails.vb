' Call details page

Imports System
Imports System.IO
Imports System.Text

Public Class FrmCallDetails


#Region "//================ STRINGS & DECLARATIONS =================================================="

    Private WithEvents tmrEndTime As New Timer With {.Interval = 100} '  Timer.
    Private arLocationsAndCallTypes_FileLines() As String '  arrays for Locations and Call Types.
    Private sStartTime, sEndTime, arStartHoursMinutes(), arEndHoursMinutes() As String '  used in Time.
    Private iStartHours, iStartMinutes, iEndHours, iEndMinutes As Integer, sTotalHours, sTotalMinutes As String
    Public iColumnClickCounter As Integer = 0, arDefaultLocations() As String, iLvColumnsClicked As Boolean = False '  sort items on ListViews Column Click.


#End Region

#Region "//------ Form Load/Closing/Theme - add Locations - Controls selected by arrow keys / btnSubmit clicked on Enter key --------"
    Private Sub frmCallDetails_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing


        x.bAllowEntryEditing = False ' What is this? <--- That is to Disable the Form from Loading info from lvMain.
        x.saveFile(currentUserBackupFile())

    End Sub

    Private Sub theme()
        Me.BackColor = x.colBg1
        gbOptions.BackColor = x.colBg1
        For Each ctl As Control In Me.Controls : ctl.BackColor = x.colBg1 : ctl.ForeColor = x.colFc1 : Next
        ' ListViews Items.
        For Each itm As ListViewItem In lvAreaLocations.Items ' change all items colors.
            itm.BackColor = x.colBg1 : itm.ForeColor = x.colFc1
        Next
        If Not lvAreaLocations.Items.Count = 0 Then
            With lvAreaLocations.SelectedItems(0) ' set selected item's colors.
                .BackColor = Color.SteelBlue : .ForeColor = Color.White
            End With
        End If

        For Each itm As ListViewItem In lvCallTypes.Items ' change all items colors.
            itm.BackColor = x.colBg1 : itm.ForeColor = x.colFc1
        Next
        If Not lvCallTypes.Items.Count = 0 Then
            With lvCallTypes.SelectedItems(0) ' set selected item's colors.
                .BackColor = Color.SteelBlue : .ForeColor = Color.White
            End With
        End If
    End Sub

    Private Sub frmCallDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try ' This entire section needs a try catch, in case for WHATEVER reason the Call Types/Location file gets corrupted.

            Me.Location = x.centerForm(Me) '// Center Form of FrmMain.
            '// set theme Locally.

            Me.KeyPreview = True

            Me.theme()

            '// allow only 4 characters per Start/End time TextBox and disable the end time TextBox from editing.
            txtStart.MaxLength = 4 : txtEnd.MaxLength = 4 : txtTotalTime.ReadOnly = True


            Select Case x.bAllowEntryEditing

                Case False '// just regular entry.
                    btnEditTime.Enabled = True : tmrEndTime.Start()
                    'txtEnd.Enabled = True : tmrEndTime.Start()
                    '// add times to start/end time TextBoxes.
                    If Not FrmMain.lvMain.Items.Count = 0 Then : txtStart.Text = FrmMain.lvMain.Items(0).SubItems(2).Text
                    Else : time_Start()
                    End If
                    '// add End Time and populate lvLocations.
                    time_End() : Add_Locations()
                    lvAreaLocations.Select() '// pre-select the Locations ListView.
                    lvAreaLocations.Items(0).Selected = True '// select first item.


                Case True '// Entry being edited.
                    btnEditTime.Enabled = False
                    'txtEnd.Enabled = False
                    tmrEndTime.Enabled = False '// set timer off to not continue adding time to End time.
                    Me.Text = "Call Details - Editing Daily Log Entry: " & FrmMain.lvMain.SelectedItems(0).SubItems(0).Text
                    Add_Locations() '// add Locations from File to callDetailsForm.
                    lvAreaLocations.Select() '// pre-select the Locations ListView.
                    lvAreaLocations.Items(0).Selected = True '// select first item to start index in the For/Next loop.

                    With FrmMain.lvMain.SelectedItems(0)
                        txtStart.Text = .SubItems(1).Text : txtEnd.Text = .SubItems(2).Text : txtTotalTime.Text = .SubItems(3).Text
                        txtCallNotes.Text = .SubItems(5).Text : txtCase.Text = .SubItems(6).Text

                        '// PRE - SELECT LISTVIEWS ITEMS. :)
                        Try
                            '//----------- more tests needed here since "somehow" there might not be a Location or Call Type available ------------\\
                            Dim strTemp As String = .SubItems(4).Text.Replace(" ~ ", "~")
                            Dim tempArray() As String = strTemp.Split("~")
                            '//----------- -------------------------------------------------------------------------------------------- ------------\\
                            For i As Integer = 0 To lvAreaLocations.Items.Count - 1
                                lvAreaLocations.Items(i).Selected = True
                                lvAreaLocations.SelectedItems(0).EnsureVisible()
                                If lvAreaLocations.Items(i).Text = tempArray(0) Then Exit For
                            Next
                            For i As Integer = 0 To lvCallTypes.Items.Count - 1
                                lvCallTypes.Items(i).Selected = True
                                lvCallTypes.SelectedItems(0).EnsureVisible()
                                If lvCallTypes.Items(i).Text = tempArray(1) Then Exit For
                            Next
                        Catch ex As Exception
                            '// to get this error, access the Backup File and remove the "~" from a line.
                            MsgBox("Error pre-selecting the Location and/or Call Type.", MsgBoxStyle.Information, "Error Message")
                        End Try
                    End With
            End Select
        Catch ex As Exception
            MsgBox("Sorry, it looks like your Locations and Call Types file is either missing or corrupt. Contact DailyLog for assistance in resolving this issue. ", MsgBoxStyle.Critical, "Error Loading File")
        End Try

        ' Load in the quick picks for the call details dropdown
        Try
            Dim sr As StreamReader = New StreamReader(x.myQuickPickFile)
            Dim line As String
            Do While Not sr.EndOfStream
                line = sr.ReadLine()
                If line = Nothing Then Continue Do ' This line skips blanks
                cbCallNotesPrefills.Items.Add(line)
            Loop
            sr.Close()
        Catch ex As Exception
            MsgBox("Is the Quick Pick file present? ")
        End Try


    End Sub
    '// populate lvLocations.
    Private Sub Add_Locations()
        lvAreaLocations.Items.Clear() '// clear.
        Dim tempLocations As String = "" '// for adding locations to a string array, used in column click.
        If IO.File.Exists(x.myLocationsAndCallTypesFile) Then '// check if file exists.
            arLocationsAndCallTypes_FileLines = IO.File.ReadAllLines(x.myLocationsAndCallTypesFile) '// load your file as a string array.
            For Each itm As String In arLocationsAndCallTypes_FileLines '// loop thru string arrays.
                Dim ar() As String = itm.Split("~")
                Dim newItem As New ListViewItem(ar(0))
                newItem.Font = New Font("Eras ITC", 16, FontStyle.Regular)
                lvAreaLocations.Items.Add(newItem) '// load only the Locations.
                If Not tempLocations = "" Then
                    tempLocations &= "~" & ar(0)
                Else
                    tempLocations = ar(0)
                End If
            Next
        End If
        arDefaultLocations = tempLocations.Split("~") '// add Locations to xDefaultLocations for ListView Locations Column Click.
        lvAreaLocations.Select() '// pre-select the Locations ListView.
        lvAreaLocations.Items(0).Selected = True '// select first item.
    End Sub
    '// populate lvCallTypes.
    Sub add_CallTypes()
        lvCallTypes.Items.Clear() '// clear.
        Dim selectedArea As String = lvAreaLocations.SelectedItems(0).Text '// get selected area.
        For Each itm As String In arLocationsAndCallTypes_FileLines '// loop thru pre-loaded File lines to located the Selected Area.
            Dim ar() As String = itm.Split("~")
            If ar(0) = selectedArea Then '// if ar(0) equals the ListView's selected area.
                For i As Integer = 1 To ar.Length - 1
                    Dim newItem As New ListViewItem(ar(i))
                    newItem.Font = New Font("Eras ITC", 16, FontStyle.Regular)
                    lvCallTypes.Items.Add(newItem) '// load the remaining string arrays as Call Types.
                Next
                Exit For '// exit the loop since you are done with what was needed.
            End If
        Next


    End Sub
    '//================ PLAYING WITH A DROP SHADOW =========================
    Protected Overrides ReadOnly Property CreateParams() As System.Windows.Forms.CreateParams

        Get
            Const CS_DROPSHADOW = &H20000
            Dim cParam As CreateParams = MyBase.CreateParams
            cParam.ClassStyle = cParam.ClassStyle Or CS_DROPSHADOW
            Return cParam
        End Get

    End Property


    '// Arrow Keys to navigate controls and press btnSubmit on Enter key.
    Private Sub Controls_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
                                 Handles txtStart.KeyUp, txtEnd.KeyUp, txtCase.KeyUp, txtCallNotes.KeyUp, lvAreaLocations.KeyUp, lvCallTypes.KeyUp
        Dim selectedControl As Control = CType(sender, Control) '// get sender.
        Select Case selectedControl.Name
            Case "lvAreaLocations" : If e.KeyCode = Keys.Right Then lvCallTypes.Select()
            Case "lvCallTypes" : If e.KeyCode = Keys.Left Then lvAreaLocations.Select()
            Case "txtStart" : If e.KeyCode = Keys.Down Then txtCallNotes.Select()
            Case "txtEnd" : If e.KeyCode = Keys.Down Then txtCallNotes.Select()
            Case "txtCase" : If e.KeyCode = Keys.Down Then txtCallNotes.Select()
            Case "txtCallNotes" : If e.KeyCode = Keys.Up Then txtCase.Select() : If e.KeyCode = Keys.Down Then lvAreaLocations.Select()
        End Select
        'If e.KeyCode = Keys.Enter Then btnSubmit_Click(sender, e)
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub




#End Region

#Region "//================ LISTVIEW OPTIONS ========================================================"

    '// add Call Types for each selected Location and keep selected item visible by changing BackColor and ForeColor.
    Public Sub ListViews_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) _
                                                                 Handles lvAreaLocations.SelectedIndexChanged, lvCallTypes.SelectedIndexChanged
        If iLvColumnsClicked = True Then Exit Sub '// exit to not reload lvCallTypes
        Dim selectedListView As ListView = CType(sender, Control) '// get sender.
        Select Case selectedListView.Name
            Case "lvAreaLocations"
                If Not lvAreaLocations.SelectedItems.Count = 0 Then
                    lvCallTypes.Items.Clear() '// clear Call Types.
                    add_CallTypes()
                    '// set the Call Types ListView Column to display the area and information for the ListView items.
                    lvCallTypes.Columns(0).Text = lvAreaLocations.SelectedItems(0).Text & " - CALL TYPES"
                    lvCallTypes.Items(0).Selected = True '// select first item.
                End If
        End Select

        '// highlight selected items for ListViews.
        If Not selectedListView.SelectedItems.Count = 0 Then '// check if sender has an item selected to not crash the app.
            For Each itm As ListViewItem In selectedListView.Items '// loop thru all items to reset BackColor and ForeColor to original state.
                itm.BackColor = x.colBg1 : itm.ForeColor = x.colFc1
            Next
            With selectedListView.SelectedItems(0) '// set only the selected item's BackColor and ForeColor for LostFocus of selected ListView.
                .BackColor = Color.SteelBlue : .ForeColor = Color.White
            End With
        End If
    End Sub

    '// sort items.
    Public Sub ListViews_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) _
                                                     Handles lvAreaLocations.ColumnClick, lvCallTypes.ColumnClick
        Dim selectedListView As ListView = CType(sender, ListView) '// get sender.
        iLvColumnsClicked = True '// disable loading the lvCallDetails constantly since the lvAreaLocations index changes.
        Select Case iColumnClickCounter
            Case 0 '// sort from A to Z.
                selectedListView.Sorting = SortOrder.Ascending : iColumnClickCounter = 1
            Case 1 '// sort from Z to A.
                selectedListView.Sorting = SortOrder.Descending : iColumnClickCounter = 2
            Case 2 '// sort in original order.
                selectedListView.Sorting = SortOrder.None '// set to none to be able to add items from a list.
                Dim tempStr As String = ""
                If Not selectedListView.SelectedItems.Count = 0 Then tempStr = selectedListView.SelectedItems(0).Text
                Select Case selectedListView.Name
                    Case "lvAreaLocations"
                        Add_Locations()
                        For i As Integer = 0 To lvAreaLocations.Items.Count - 1
                            lvAreaLocations.Items(i).Selected = True
                            If lvAreaLocations.Items(i).Text = tempStr Then Exit For
                        Next
                    Case "lvCallTypes"
                        add_CallTypes()
                        For i As Integer = 0 To lvCallTypes.Items.Count - 1
                            lvCallTypes.Items(i).Selected = True
                            If lvCallTypes.Items(i).Text = tempStr Then Exit For
                        Next
                End Select
                iColumnClickCounter = 0
        End Select
        iLvColumnsClicked = False
    End Sub
    '// select ListView.
    Private Sub ListViews_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) _
                                                 Handles lvAreaLocations.MouseEnter, lvCallTypes.MouseEnter
        Dim selectedListView As ListView = CType(sender, ListView) '// get sender.
        selectedListView.Select() '// select.
    End Sub
#End Region

#Region "//================ TEXTBOX OPTIONS ========================================================="

    '// only numeric and backspace for txtStart and txtEnd.
    Private Sub txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txtStart.KeyPress, txtEnd.KeyPress
        Select Case e.KeyChar
            Case "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", vbBack
                Exit Sub
            Case Else
                e.Handled = True
        End Select
    End Sub
    '// change Start/End time TextBox colors.
    Private Sub txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
                                        Handles txtStart.TextChanged, txtEnd.TextChanged
        Dim txt As TextBox = CType(sender, TextBox)
        If txt.TextLength = 4 Then : txt.BackColor = Color.LightGreen : txt.ForeColor = Color.Black
        Else : txt.BackColor = Color.Red : txt.ForeColor = Color.Black : txtTotalTime.Text = "----"
        End If
        time_Total()
    End Sub
    '// highlight textboxes on tab Focus.
    Private Sub txt_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) _
                                 Handles txtStart.GotFocus, txtEnd.GotFocus, txtTotalTime.GotFocus, txtCase.GotFocus, txtCallNotes.GotFocus, _
                                 txtStart.MouseDoubleClick, txtEnd.MouseDoubleClick, txtTotalTime.MouseDoubleClick, txtCase.MouseDoubleClick, txtCallNotes.MouseDoubleClick
        '// Gives the text box focus
        Dim txt As TextBox = CType(sender, TextBox) '// get sender.
        txt.SelectAll() '// select all.
        'txt.BackColor = Color.Orange : txt.ForeColor = Color.White ' This changed the text color on highlight, but officers requested it be removed.
    End Sub
    '// highlight textboxes on tab LOST FOCUS
    Private Sub txt_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) _
                                 Handles txtStart.LostFocus, txtEnd.LostFocus, txtTotalTime.LostFocus, txtCase.LostFocus, txtCallNotes.LostFocus

        '// Gives the text box focus
        Dim txt As TextBox = CType(sender, TextBox) '// get sender.
        txt.SelectAll() '// select all.
        txt.BackColor = x.colBg1 : txt.ForeColor = x.colFc1

    End Sub

    '// Empty the start and end times with a mouse click
    Private Sub _txtStart_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) _
                                            Handles txtStart.MouseDown, txtEnd.MouseDown
        CType(sender, TextBox).Clear()
    End Sub

    ' Empty the end times when on focus
    Private Sub txtEnd_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEnd.GotFocus
        tmrEndTime.Stop()
        CType(sender, TextBox).Clear()
    End Sub

    Private Sub txtCallNotes_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCallNotes.KeyDown


        ''// Error #22
        ''// Prevent the enter key from being used, which stops a line break, also
        ''// prevent copying and pasting into the text box which can still do the same thing *sigh*
        'If e.KeyCode = Keys.Enter Then
        '    e.SuppressKeyPress = True
        'End If
        ''// Prevent pasting into the box
        'If ModifierKeys = Keys.Control Then
        '    e.Handled = True
        '    txtCallNotes.ReadOnly = True
        'Else
        '    txtCallNotes.ReadOnly = False
        'End If


    End Sub

    ' http://social.msdn.microsoft.com/Forums/en-US/4617ae2d-ad43-4d69-8641-14ccfc84e8a8/having-problems-preventing-a-hard-carriage-return-in-multi-line-text-box

    Private Sub txtCallNotes_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCallNotes.KeyPress
        If e.KeyChar = ChrW(13) OrElse e.KeyChar = ChrW(10) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCallNotes_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCallNotes.TextChanged
        Dim originalString As String = txtCallNotes.Text
        Dim newString As String = originalString.Replace(ChrW(13), String.Empty).Replace(ChrW(10), String.Empty)
        If originalString.Length <> newString.Length Then 'Changes made!
            txtCallNotes.Text = newString
        End If
    End Sub


#End Region

#Region "//================ TIME AND TIMER RELLATED FUNCTIONS ======================================="
    Private Sub time_Start()
        sStartTime = Format(TimeOfDay, "HH:mm:ss")
        arStartHoursMinutes = sStartTime.Split(":") '  split into arrays.
        txtStart.Text = arStartHoursMinutes(0) & arStartHoursMinutes(1) '  display only Hours and Minutes.
    End Sub
    Private Sub time_End()
        sEndTime = Format(TimeOfDay, "HH:mm:ss")
        arEndHoursMinutes = sEndTime.Split(":") '  split into arrays.
        txtEnd.Text = arEndHoursMinutes(0) & arEndHoursMinutes(1) '  display only Hours and Minutes.
    End Sub
    Private Sub time_Total()
        '  if not correct time format, Exit Sub to not display Total Time.
        If Not txtStart.TextLength = 4 Then Exit Sub : If Not txtEnd.TextLength = 4 Then Exit Sub
        Try '  since it calls the sub on form load after loading one TextBox, not both.
            iStartHours = txtStart.Text.Substring(0, 2) : iStartMinutes = txtStart.Text.Substring(2, 2) '  get start Hours : get start Minutes
            iEndHours = txtEnd.Text.Substring(0, 2) : iEndMinutes = txtEnd.Text.Substring(2, 2) '  get end Hours : get end Minutes
            If iStartHours > iEndHours Then iEndHours += 24 '  check if start hours is greater than end hours, if so, add 24 hours.
            If iStartMinutes > iEndMinutes Then
                iEndMinutes += 60 '  add 60 minutes to be able to subtract without getting a negative number returned.
                If iStartHours < iEndHours Then iEndHours -= 1 '  subtract an hour from end Hours if end Hours is greater than start hours.
            End If
            '  subtract hours and  minutes to get Total Time.
            sTotalHours = iEndHours - iStartHours
            sTotalMinutes = iEndMinutes - iStartMinutes
            If txtStart.Text.Substring(0, 2) = txtEnd.Text.Substring(0, 2) Then '  check if same hours for start and end times.
                If txtStart.Text.Substring(2, 2) > txtEnd.Text.Substring(2, 2) Then '  if start minutes is greater than end minutes.
                    sTotalHours += 23 '  add 23 hours to total hours.
                End If
            End If
            '  convert from # to ## if less than 10.
            If sTotalHours < 10 Then sTotalHours = "0" & sTotalHours
            If sTotalMinutes < 10 Then sTotalMinutes = "0" & sTotalMinutes
            txtTotalTime.Text = sTotalHours & sTotalMinutes '  display result.
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tmrEndTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrEndTime.Tick

        time_End()

    End Sub
#End Region

#Region "//================ SUBMIT/SAVE/EDIT TIME ===== SQL ENTRIES ================================="

    '  "Submit Information" to mainForm and Save to Backup File Basic.
    Public Sub btnSubmit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSubmit.Click

        If txtCallNotes.Text = "" Then
            txtCallNotes.Text = "General Patrol"
        End If

        Dim sLvLocationsTemp As String = "", sLvCallTypesTemp As String = ""
        If lvAreaLocations.SelectedItems.Count = 0 Then
            For i As Integer = 0 To lvAreaLocations.Items.Count
                With lvAreaLocations
                    If Not .Items(i).BackColor = .BackColor Then
                        sLvLocationsTemp = .Items(i).Text
                        Exit For
                    End If
                End With
            Next
        Else
            sLvLocationsTemp = lvAreaLocations.SelectedItems(0).Text
        End If

        If lvCallTypes.SelectedItems.Count = 0 Then
            For i As Integer = 0 To lvCallTypes.Items.Count
                With lvCallTypes
                    If Not .Items(i).BackColor = .BackColor Then
                        sLvCallTypesTemp = .Items(i).Text
                        Exit For
                    End If
                End With
            Next
        Else
            sLvCallTypesTemp = lvCallTypes.SelectedItems(0).Text
        End If



        Select Case x.bAllowEntryEditing
            Case False '  if normal entry add.
                '  configure the text for lvMain # column.
                Dim number As String = FrmMain.lvMain.Items.Count
                If number = 0 Then : number = 1 : Else : number += 1 : End If '  if no entries, set # to 1, else add +1 to #.
                If number < 10 Then : number = "00" & number : ElseIf number < 100 Then : number = "0" & number : End If '  format to ###.

                Dim newItem As New ListViewItem(number) '  declare a new ListView item.
                With newItem.SubItems
                    '  add Start/End Time.
                    .Add(txtStart.Text) : .Add(txtEnd.Text)
                    '  add Total Time.
                    If Not txtTotalTime.Text = "0000" Then : .Add(txtTotalTime.Text)
                    Else : .Add("0001")
                    End If
                    '  add Location and Call Type.
                    If Not lvCallTypes.SelectedItems.Count = 0 Then '  check if Call Types has a selection.
                        .Add(sLvLocationsTemp & " ~ " & sLvCallTypesTemp)
                    Else : If Not lvAreaLocations.SelectedItems.Count = 0 Then '  check if Location has a selection.
                            .Add(sLvLocationsTemp & " ~ ") '  only add Location.
                        Else : .Add("") '  add empty value if No Location Or Call Type selected.
                        End If
                    End If
                    '  add Notes and Case number.
                    .Add(txtCallNotes.Text) : .Add(txtCase.Text)
                End With
                newItem.Font = x.fontLvFont '  set Font.
                'If frmOptions.cbLogOrder.Checked Then
                '    FrmMain.lvMain.Items.Add(newItem) '  add new items as the *last* item, in reverse order
                'Else
                FrmMain.lvMain.Items.Insert(0, newItem) '  add new item as the First item in main Form's ListView.
                'End If
            Case True '  if edited.
                With FrmMain.lvMain.SelectedItems(0)
                    .SubItems(1).Text = txtStart.Text
                    .SubItems(2).Text = txtEnd.Text
                    .SubItems(3).Text = txtTotalTime.Text
                    If Not lvCallTypes.SelectedItems.Count = 0 Then '  check if Call Types has a selection.
                        '  add Location and Call Type.
                        .SubItems(4).Text = sLvLocationsTemp & " ~ " & sLvCallTypesTemp
                    Else
                        If Not lvAreaLocations.SelectedItems.Count = 0 Then '  check if Location has a selection.
                            .SubItems(4).Text = sLvLocationsTemp & " ~ " '  only add Location.
                        Else
                            .SubItems(4).Text = "" '  add empty value.
                        End If
                    End If
                    .SubItems(5).Text = txtCallNotes.Text
                    .SubItems(6).Text = txtCase.Text
                End With
        End Select
        '  Save/overwrite Backup File Basic.
        x.saveFile(x.myBackupFile)
        x.saveLogFile() '  save current Log File LOCALLY
        Me.Close() '  close the callDetailsForm.
    End Sub


    Public Function roundTime(ByRef dTimeToRound As Decimal) As Decimal
        Dim sTempTime As String = dTimeToRound '// change Decimal to String.
        Try '// do not want to crash, although it should not.
            If sTempTime.Contains(".") Then '// Check if String contains a dot.
                Dim dHr As Decimal = CDec(sTempTime.Substring(0, sTempTime.IndexOf("."))) '// get all #'s before the dot.
                Dim dMin As Decimal = CDec(sTempTime.Substring(sTempTime.IndexOf("."))) '// get all #'s after the dot.
                If dMin >= 0.6 Then '// check if # after dot is greater than .6, or 60 Minutes.
                    dMin = dMin - 0.6 '// if so, subtract 60 from Minutes.
                    dHr += 1 '// and add +=1 to the Hour.
                End If
                dTimeToRound = dHr + dMin '// set the time back as Decimal.
            End If
            sTempTime = dTimeToRound '// change to String from Decimal.
            If sTempTime.Substring(sTempTime.IndexOf(".") + 1) > 2 Then '// check if Decimal point has more values than 2, ex: if it is: #.#### and NOT #.##.
                sTempTime = sTempTime.Substring(0, sTempTime.IndexOf(".") + 3) '// get only the #'s needed, 2 places after the dot, not more.
                dTimeToRound = CDec(sTempTime) '// set time back to Decimal.
            End If
        Catch ex As Exception
        End Try
        Return dTimeToRound '// Return Formatted Time.
    End Function

    Private Sub btnEditTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        tmrEndTime.Enabled = False '  Stop timer to edit time
    End Sub

    '  =========== REMOVE THE EDIT TIME AND JUST DO IT ON MOUSE CLICK =======================
    Private Sub txtEnd_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtEnd.MouseClick
        tmrEndTime.Enabled = False '  Stop timer to edit time
    End Sub


#End Region

#Region "//================ SIDEBAR- QUICK LINK BUTTONS ON RIGHT ===================================="

    Private Sub Sidebar_Buttons_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
                               Handles btnClose.Click
        Dim btn As Button = CType(sender, Button)
        Select Case btn.Name

            Case "btnClose"
                Me.Close()
        End Select
    End Sub
#End Region

#Region "//================ REFRESH NOTES FROM DROPDOWN ============================================="

    '    Private Sub tmrRefreshNotesText_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrRefreshNotesText.Tick
    '        '  Add the word PATROL or WHATEVER ELSE to the call notes if this is checked, to eliminate typing it in.
    '        '  I am getting tired of typing it in...
    '        '  Or am I just getting lazy??

    '        If cbCallNotesPrefills.Text = "General patrol" Then
    '            txtCallNotes.Text = "General patrol"
    '            tmrRefreshNotesText.Stop() '  Stop the timer so more notes can be added if needed
    '        End If

    '        If cbCallNotesPrefills.Text = "Phone call- spoke with complainant" Then
    '            txtCallNotes.Text = "Phone call- spoke with complainant"
    '            tmrRefreshNotesText.Stop()
    '        End If

    '        If cbCallNotesPrefills.Text = "Remarks added via MDT" Then
    '            txtCallNotes.Text = "Remarks added via MDT"
    '            tmrRefreshNotesText.Stop()
    '        End If

    '        If cbCallNotesPrefills.Text = "Went through the area and unable to locate" Then
    '            txtCallNotes.Text = "Went through the area and unable to locate"
    '            tmrRefreshNotesText.Stop()
    '        End If

    '        If cbCallNotesPrefills.Text = "Unfounded- everything fine" Then
    '            txtCallNotes.Text = "Unfounded- everything fine"
    '            tmrRefreshNotesText.Stop()
    '        End If

    '        If cbCallNotesPrefills.Text = "Administrative Detail" Then
    '            txtCallNotes.Text = "Administrative Detail"
    '            tmrRefreshNotesText.Stop()
    '        End If

    '        If cbCallNotesPrefills.Text = "Patrol" Then
    '            txtCallNotes.Text = "Patrol"
    '            tmrRefreshNotesText.Stop()
    '        End If

    '        If cbCallNotesPrefills.Text = "Speeding/Radar Enforcement" Then
    '            txtCallNotes.Text = "Speeding/Radar Enforcement"
    '            tmrRefreshNotesText.Stop()
    '        End If

    '        If cbCallNotesPrefills.Text = "Lunch Break" Then
    '            txtCallNotes.Text = "Lunch Break"
    '            tmrRefreshNotesText.Stop()
    '        End If

    '        If cbCallNotesPrefills.Text = "Out at Office" Then
    '            txtCallNotes.Text = "Out at Office"
    '            tmrRefreshNotesText.Stop()
    '        End If

    '        If cbCallNotesPrefills.Text = "Begin Shift-Verified Radar" Then
    '            txtCallNotes.Text = "Begin Shift-Verified Radar"
    '            tmrRefreshNotesText.Stop()
    '        End If

    '        If cbCallNotesPrefills.Text = "Fuel" Then
    '            txtCallNotes.Text = "Fuel"
    '            tmrRefreshNotesText.Stop()
    '        End If

    '        If cbCallNotesPrefills.Text = "Premise Check(s)- All Secure" Then
    '            txtCallNotes.Text = "Premise Check(s)- All Secure"
    '            tmrRefreshNotesText.Stop()
    '        End If

    '        If cbCallNotesPrefills.Text = "Directed Patrol" Then
    '            txtCallNotes.Text = "Directed Patrol"
    '            tmrRefreshNotesText.Stop()
    '        End If

    '        If cbCallNotesPrefills.Text = "At the Gym for PT" Then
    '            txtCallNotes.Text = "At the Gym for PT"
    '            tmrRefreshNotesText.Stop()
    '        End If


    '        txtCallNotes.Refresh()
    '    End Sub

    '    Private Sub cbCallNotesPrefills_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCallNotesPrefills.SelectedIndexChanged
    '        tmrRefreshNotesText.Start() '  Start the timer again when someone selectes something different from
    '        '  the dropdown- then it will be added to the notes section.
    '    End Sub

    'Private Sub tmrRefreshNotesText_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrRefreshNotesText.Tick
    '    'tmrRefreshNotesText.Stop() '// Stop the timer so more notes can be added if needed
    '    'txtCallNotes.Refresh()
    'End Sub

    Private Sub cbCallNotesPrefills_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCallNotesPrefills.SelectedIndexChanged

        txtCallNotes.Text = cbCallNotesPrefills.Text
        txtCallNotes.Refresh()

        'tmrRefreshNotesText.Start() '// Start the timer again when someone selectes something different from
        '// the dropdown- then it will be added to the notes section.
    End Sub


    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        ' Play the Click sound
        Dim cls As New ClsAudio
        cls.ClickSound()
        frmEditCallDetails.ShowDialog()
    End Sub

    Private Sub btnRefreshListviews_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshListviews.Click
        ' Play the Click sound
        Dim cls As New ClsAudio
        cls.ClickSound()
        add_CallTypes()
        Add_Locations()
    End Sub

#End Region


End Class