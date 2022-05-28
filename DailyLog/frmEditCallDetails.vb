'  Started in November 2010

'Option Strict On

Public Class frmEditCallDetails

#Region "//------ Strings and Stuff --------"
    Private sListViewSelected As String = "" '  used to determine ListView selected for Up/Down.
#End Region

#Region "//------ FORM CLOSING AND FORM OPENING------"

    Private Sub frmEditCallDetails_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        '       If MessageBox.Show("Any unsaved changes will be lost.  Continue?", "Daily Log", MessageBoxButtons.OK, MessageBoxIcon.Question) _
        '= Windows.Forms.DialogResult.OK Then
        '           Me.Close()
        '       End If
        '       End
    End Sub

    Private Sub frmEditCallDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MinimizeBox = False : Me.MaximizeBox = False : Me.Location = x.centerForm(Me) '  Center Form of FrmMain.

        txtLocations.Text = "" : txtCallTypes.Text = ""
        btnAdd_L.Enabled = False : btnEdit_L.Enabled = False : btnSave_L.Enabled = False : btnDel_L.Enabled = False
        btnAdd_CT.Enabled = False : btnEdit_CT.Enabled = False : btnSave_CT.Enabled = False : btnDel_CT.Enabled = False

        Add_Locations()
    End Sub

#End Region

#Region "//-------ADD LOCATIONS--------"
    Private Sub Add_Locations()
        lvAreaLocations.Items.Clear() '  clear.
        If IO.File.Exists(x.myLocationsAndCallTypesFile) Then '  check if file exists.
            Dim myFileLines() As String = IO.File.ReadAllLines(x.myLocationsAndCallTypesFile)
            ' MsgBox(myFileLines.Length)
            If Not myFileLines.Length = 0 Then
                For i As Integer = 0 To myFileLines.Length - 1
                    If myFileLines(i).Contains("~") Then
                        Dim ar() As String = myFileLines(i).Split("~"c)
                        Dim newItem As New ListViewItem(ar(0))
                        newItem.Font = New Font("Eras ITC", 12, FontStyle.Regular)
                        For i2 As Integer = 1 To ar.Length - 1
                            newItem.Tag &= "~" & ar(i2) '  add Call Types.
                        Next
                        lvAreaLocations.Items.Add(newItem) '  load only the Locations.
                    End If
                Next
            End If
        End If
    End Sub

#End Region

#Region "//-------LISTVIEWS OPTIONS --------"

    Private Sub ListViews_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
                   Handles lvAreaLocations.Click, lvCallTypes.Click
        Dim selectedListView As ListView = CType(sender, ListView) '  get sender.
        If Not selectedListView.SelectedItems.Count = 0 Then '  check if sender has an item selected to not crash the app.
            For Each itm As ListViewItem In selectedListView.Items '  loop thru all items to reset BackColor and ForeColor to original state.
                itm.BackColor = x.colBg1 : itm.ForeColor = x.colFc1
            Next
            With selectedListView.SelectedItems(0) '  set only the selected item's BackColor and ForeColor for LostFocus of selected ListView.
                .BackColor = Color.SteelBlue : .ForeColor = Color.White
            End With
            Select Case selectedListView.Name
                Case "lvAreaLocations"
                    If Not selectedListView.SelectedItems.Count = 0 Then
                        txtLocations.Text = selectedListView.SelectedItems(0).Text
                        btnEdit_L.Enabled = True : btnDel_L.Enabled = True
                        If btnSave_L.Enabled = True Then btnSave_L.Enabled = False
                        lvCallTypes.Columns(0).Text = lvAreaLocations.SelectedItems(0).Text & " - CALL TYPES"
                    ElseIf selectedListView.SelectedItems.Count = 0 Then
                        btnAdd_L.Enabled = False : btnEdit_L.Enabled = False : btnSave_L.Enabled = False : btnDel_L.Enabled = False
                        lvCallTypes.Columns(0).Text = "CALL TYPES"
                        If Not lvCallTypes.Items.Count = 0 Then lvCallTypes.Items.Clear()
                    End If
                    If lvCallTypes.Items.Count = 0 AndAlso Not txtCallTypes.Text = "" Then btnAdd_CT.Enabled = True
                    lvCallTypes.Items.Clear()
                    Try
                        Dim ar() As String = selectedListView.SelectedItems(0).Tag.ToString.Split("~"c)
                        For i2 As Integer = 1 To ar.Length - 1
                            Dim newItem As New ListViewItem(ar(i2))
                            newItem.Font = New Font("Eras ITC", 12, FontStyle.Regular)
                            lvCallTypes.Items.Add(newItem) '  add Call Types.
                        Next
                        enable_disable_btnAdd_CT()
                    Catch ex As Exception
                    End Try
                Case "lvCallTypes"
                    If Not selectedListView.SelectedItems.Count = 0 Then
                        txtCallTypes.Text = selectedListView.SelectedItems(0).Text
                        btnEdit_CT.Enabled = True : btnDel_CT.Enabled = True
                        If btnSave_CT.Enabled = True Then btnSave_CT.Enabled = False
                    Else
                        btnAdd_CT.Enabled = False : btnEdit_CT.Enabled = False : btnSave_CT.Enabled = False : btnDel_CT.Enabled = False
                    End If
            End Select
            '  option for Up/Down buttons.
            sListViewSelected = selectedListView.Name
        End If
    End Sub

    '  select ListView.
    Private Sub ListViews_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) _
                                                 Handles lvAreaLocations.MouseEnter, lvCallTypes.MouseEnter
        Dim selectedListView As ListView = CType(sender, ListView) '  get sender.
        selectedListView.Select() '  select.
    End Sub

#End Region

#Region "//------ ALL BUTTONS --------"
    Private Sub btns_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles btnAdd_L.Click, btnEdit_L.Click, btnSave_L.Click, btnDel_L.Click, btnAdd_CT.Click, btnEdit_CT.Click, btnSave_CT.Click, btnDel_CT.Click
        Try
            Dim btn As Button = CType(sender, Button)
            With lvAreaLocations
                Select Case btn.Name
                    Case "btnAdd_L"
                        If Not .Items.Count = 0 Then
                            If Not .SelectedItems.Count = 0 Then
                                If Not .SelectedItems(0).Index = .Items.Count - 1 Then
                                    .Items.Insert(.SelectedItems(0).Index, txtLocations.Text)
                                    .Items(.SelectedItems(0).Index - 1).Selected = True
                                Else
                                    .Items.Add(txtLocations.Text)
                                End If
                            Else
                                .Items.Add(txtLocations.Text)
                            End If
                        Else
                            .Items.Add(txtLocations.Text)
                        End If
                        enable_disable_btnAdd_L()
                    Case "btnEdit_L"
                        If Not .SelectedItems.Count = 0 Then
                            btnEdit_L.Enabled = False : btnSave_L.Enabled = True
                        End If
                    Case "btnSave_L"

                        ''  First the edit portion
                        'If Not .SelectedItems.Count = 0 Then
                        '    btnEdit_L.Enabled = False : btnSave_L.Enabled = True
                        'End If

                        '  Now the SAVE portion
                        If Not .SelectedItems.Count = 0 Then
                            .SelectedItems(0).Text = txtLocations.Text
                            lvCallTypes.Columns(0).Text = .SelectedItems(0).Text & " - CALL TYPES"
                            enable_disable_btnAdd_L()
                            Me.Cursor = Cursors.WaitCursor : Threading.Thread.Sleep(250) : Me.Cursor = Cursors.Default
                        End If
                    Case "btnDel_L"
                        If Not .SelectedItems.Count = 0 Then
                            If MsgBox("Delete selected Location?" & vbNewLine & " - " & .SelectedItems(0).Text, MsgBoxStyle.OkCancel, "Delete Location?") = MsgBoxResult.Ok Then
                                .Items.Remove(.SelectedItems(0))
                                If lvCallTypes.SelectedItems.Count = 0 Then btnDel_L.Enabled = False
                                enable_disable_btnAdd_L()
                                lvCallTypes.Items.Clear()
                                txtCallTypes.Text = ""
                                btnAdd_CT.Enabled = False : btnEdit_CT.Enabled = False : btnSave_CT.Enabled = False : btnDel_CT.Enabled = False
                                lvCallTypes.Columns(0).Text = "CALL TYPES"
                                If .SelectedItems.Count = 0 Then
                                    If btnEdit_L.Enabled = True Then btnEdit_L.Enabled = False
                                    If btnSave_L.Enabled = True Then btnSave_L.Enabled = False
                                End If
                            End If
                        End If
                End Select
            End With
            With lvCallTypes
                Select Case btn.Name
                    Case "btnAdd_CT"
                        If Not .Items.Count = 0 Then
                            If Not .SelectedItems.Count = 0 Then
                                If Not .SelectedItems(0).Index = .Items.Count - 1 Then
                                    .Items.Insert(.SelectedItems(0).Index, txtCallTypes.Text)
                                    .Items(.SelectedItems(0).Index - 1).Selected = True
                                Else
                                    .Items.Add(txtCallTypes.Text)
                                End If
                            Else
                                .Items.Add(txtCallTypes.Text)
                            End If
                        Else
                            .Items.Add(txtCallTypes.Text)
                        End If
                        saveCallTypes()
                        enable_disable_btnAdd_CT()
                    Case "btnEdit_CT"
                        If Not lvAreaLocations.SelectedItems.Count = 0 Then
                            btnEdit_CT.Enabled = False : btnSave_CT.Enabled = True
                        End If
                    Case "btnSave_CT"
                        If Not lvAreaLocations.SelectedItems.Count = 0 Then
                            .SelectedItems(0).Text = txtCallTypes.Text
                            saveCallTypes()
                            enable_disable_btnAdd_CT()
                            Me.Cursor = Cursors.WaitCursor : Threading.Thread.Sleep(250) : Me.Cursor = Cursors.Default
                        End If
                    Case "btnDel_CT"
                        If Not .SelectedItems.Count = 0 Then
                            If MsgBox("Delete selected Call Type for " & lvAreaLocations.SelectedItems(0).Text & "?" & vbNewLine & " - " & .SelectedItems(0).Text, MsgBoxStyle.OkCancel, "Delete Call Type?") = MsgBoxResult.Ok Then
                                .Items.Remove(.SelectedItems(0))
                                If .SelectedItems.Count = 0 Then btnDel_CT.Enabled = False
                                saveCallTypes()
                                enable_disable_btnAdd_CT()
                                If .SelectedItems.Count = 0 Then
                                    If btnEdit_CT.Enabled = True Then btnEdit_CT.Enabled = False
                                    If btnSave_CT.Enabled = True Then btnSave_CT.Enabled = False
                                End If
                            End If
                        End If
                End Select
            End With
        Catch ex As Exception
        End Try
    End Sub

    ' ---------- SAVE to File, M'Kay????

    Private Sub btnOkay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOkay.Click
        Try
            If Not lvAreaLocations.Items.Count = 0 Then
                Dim myWriter As New IO.StreamWriter(x.myLocationsAndCallTypesFile)
                For Each itm As ListViewItem In lvAreaLocations.Items
                    myWriter.WriteLine(itm.Text & itm.Tag.ToString) ' See Note #1 below
                Next
                myWriter.Close()
                MsgBox("New location or call type saved.", MsgBoxStyle.Information)
                'Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
        End Try
        ' End

        ' Note #1- January 28th 2013
        ' System.NullReferenceException: Object reference not set to an instance of an object.
        ' at DailyLog.frmEditCallDetails.btnOkay_Click(Object sender, EventArgs e) in 
        ' C:\Users\rtaylor\Desktop\DailyLog 4.5.1020 ENTERPRISE\DailyLog\frmEditCallDetails.vb:line 231
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '  Get help using the Edit stuff
        Process.Start(urlSupport)
    End Sub

#End Region

    Private Sub txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles txtLocations.TextChanged, txtCallTypes.TextChanged


        Dim txt As TextBox = CType(sender, TextBox)
        Select Case txt.Name
            Case "txtLocations" : enable_disable_btnAdd_L()
            Case "txtCallTypes" : enable_disable_btnAdd_CT()
        End Select
    End Sub

#Region "//------ btnAdd Enabled/Disabled / save Call Types to Location.Tag --------"

    Private Sub enable_disable_btnAdd_L()
        If Not lvAreaLocations.Items.Count = 0 Then
            For Each itm As ListViewItem In lvAreaLocations.Items
                If Not itm.Text = txtLocations.Text Then
                    btnAdd_L.Enabled = True
                Else
                    btnAdd_L.Enabled = False
                    Exit For
                End If
            Next
        End If
        If lvAreaLocations.Items.Count = 0 AndAlso Not txtLocations.Text = "" Then btnAdd_L.Enabled = True
    End Sub

    Private Sub enable_disable_btnAdd_CT()
        If Not lvCallTypes.Items.Count = 0 Then
            For Each itm As ListViewItem In lvCallTypes.Items
                If Not itm.Text = txtCallTypes.Text Then
                    btnAdd_CT.Enabled = True
                Else
                    btnAdd_CT.Enabled = False
                    Exit For
                End If
            Next
        End If
        If Not lvAreaLocations.SelectedItems.Count = 0 AndAlso lvCallTypes.Items.Count = 0 AndAlso Not txtLocations.Text = "" Then btnAdd_L.Enabled = True
    End Sub

    Private Sub saveCallTypes()
        If Not lvAreaLocations.SelectedItems.Count = 0 Then
            lvAreaLocations.SelectedItems(0).Tag = ""
            For Each itm As ListViewItem In lvCallTypes.Items
                lvAreaLocations.SelectedItems(0).Tag &= "~" & itm.Text
            Next
        End If
    End Sub

#End Region

#Region "//------ btns Up/Down --------"

    Private Sub btnUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUp.Click
        Dim iSelectedIndex As Integer = 0 '  get selected item's Index.
        Select Case sListViewSelected '  select listview clicked.  option is set in ListViews_Click.
            Case "lvAreaLocations"
                With lvAreaLocations
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
                    End If
                End With
            Case "lvCallTypes"
                With lvCallTypes
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
                        '  save all Call Types back to preset Location's .Tag.
                        saveCallTypes()
                    End If
                End With
        End Select
    End Sub

    Private Sub btnDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDown.Click
        Dim iSelectedIndex As Integer = 0 '  get selected item's Index.
        Select Case sListViewSelected '  select listview clicked.  option is set in ListViews_Click.
            Case "lvAreaLocations"
                With lvAreaLocations
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
                    End If
                End With
            Case "lvCallTypes"
                With lvCallTypes
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
                        saveCallTypes()
                    End If
                End With
        End Select
    End Sub


#End Region


End Class