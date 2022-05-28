<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCallDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCallDetails))
        Me.btnEditTime = New System.Windows.Forms.Button()
        Me.txtCallNotes = New System.Windows.Forms.TextBox()
        Me.txtTotalTime = New System.Windows.Forms.TextBox()
        Me.txtEnd = New System.Windows.Forms.TextBox()
        Me.txtCase = New System.Windows.Forms.TextBox()
        Me.txtStart = New System.Windows.Forms.TextBox()
        Me.cbCallNotesPrefills = New System.Windows.Forms.ComboBox()
        Me.lblStartTime = New System.Windows.Forms.Label()
        Me.ColumnAreaLocations = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.gbOptions = New System.Windows.Forms.GroupBox()
        Me.btnRefreshListviews = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblTotalTime = New System.Windows.Forms.Label()
        Me.ColumnCallTypes = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblEndTime = New System.Windows.Forms.Label()
        Me.lvCallTypes = New System.Windows.Forms.ListView()
        Me.lvAreaLocations = New System.Windows.Forms.ListView()
        Me.lblDescriptionNotes = New System.Windows.Forms.Label()
        Me.lblCase = New System.Windows.Forms.Label()
        Me.tmrRefreshNotesText = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.gbOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnEditTime
        '
        Me.btnEditTime.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditTime.Location = New System.Drawing.Point(589, 139)
        Me.btnEditTime.Name = "btnEditTime"
        Me.btnEditTime.Size = New System.Drawing.Size(146, 63)
        Me.btnEditTime.TabIndex = 67
        Me.btnEditTime.Text = "Edit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Time(HIDDEN)"
        Me.btnEditTime.UseVisualStyleBackColor = True
        Me.btnEditTime.Visible = False
        '
        'txtCallNotes
        '
        Me.txtCallNotes.AcceptsTab = True
        Me.txtCallNotes.AllowDrop = True
        Me.txtCallNotes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCallNotes.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCallNotes.Location = New System.Drawing.Point(7, 82)
        Me.txtCallNotes.MaxLength = 500
        Me.txtCallNotes.Multiline = True
        Me.txtCallNotes.Name = "txtCallNotes"
        Me.txtCallNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCallNotes.Size = New System.Drawing.Size(817, 137)
        Me.txtCallNotes.TabIndex = 3
        '
        'txtTotalTime
        '
        Me.txtTotalTime.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalTime.Location = New System.Drawing.Point(502, 6)
        Me.txtTotalTime.Name = "txtTotalTime"
        Me.txtTotalTime.Size = New System.Drawing.Size(75, 29)
        Me.txtTotalTime.TabIndex = 3
        Me.txtTotalTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEnd
        '
        Me.txtEnd.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnd.Location = New System.Drawing.Point(304, 6)
        Me.txtEnd.Name = "txtEnd"
        Me.txtEnd.Size = New System.Drawing.Size(75, 29)
        Me.txtEnd.TabIndex = 2
        Me.txtEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCase
        '
        Me.txtCase.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCase.Location = New System.Drawing.Point(667, 6)
        Me.txtCase.Name = "txtCase"
        Me.txtCase.Size = New System.Drawing.Size(157, 29)
        Me.txtCase.TabIndex = 5
        Me.txtCase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtStart
        '
        Me.txtStart.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStart.Location = New System.Drawing.Point(121, 6)
        Me.txtStart.Name = "txtStart"
        Me.txtStart.Size = New System.Drawing.Size(75, 29)
        Me.txtStart.TabIndex = 1
        Me.txtStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbCallNotesPrefills
        '
        Me.cbCallNotesPrefills.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCallNotesPrefills.FormattingEnabled = True
        Me.cbCallNotesPrefills.Location = New System.Drawing.Point(502, 47)
        Me.cbCallNotesPrefills.Name = "cbCallNotesPrefills"
        Me.cbCallNotesPrefills.Size = New System.Drawing.Size(322, 29)
        Me.cbCallNotesPrefills.TabIndex = 4
        Me.cbCallNotesPrefills.Text = "Select Quicknotes Here"
        '
        'lblStartTime
        '
        Me.lblStartTime.AutoSize = True
        Me.lblStartTime.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartTime.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblStartTime.Location = New System.Drawing.Point(8, 10)
        Me.lblStartTime.Name = "lblStartTime"
        Me.lblStartTime.Size = New System.Drawing.Size(94, 21)
        Me.lblStartTime.TabIndex = 52
        Me.lblStartTime.Text = "START TIME:"
        '
        'ColumnAreaLocations
        '
        Me.ColumnAreaLocations.Text = "AREA LOCATIONS"
        Me.ColumnAreaLocations.Width = 315
        '
        'gbOptions
        '
        Me.gbOptions.Controls.Add(Me.btnRefreshListviews)
        Me.gbOptions.Controls.Add(Me.btnEdit)
        Me.gbOptions.Controls.Add(Me.btnClose)
        Me.gbOptions.Controls.Add(Me.btnSubmit)
        Me.gbOptions.Location = New System.Drawing.Point(830, 6)
        Me.gbOptions.Name = "gbOptions"
        Me.gbOptions.Size = New System.Drawing.Size(67, 294)
        Me.gbOptions.TabIndex = 64
        Me.gbOptions.TabStop = False
        '
        'btnRefreshListviews
        '
        Me.btnRefreshListviews.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefreshListviews.FlatAppearance.BorderSize = 0
        Me.btnRefreshListviews.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefreshListviews.Image = Global.DailyLog.My.Resources.Resources.RefreshCallDetails
        Me.btnRefreshListviews.Location = New System.Drawing.Point(9, 214)
        Me.btnRefreshListviews.Name = "btnRefreshListviews"
        Me.btnRefreshListviews.Size = New System.Drawing.Size(50, 50)
        Me.btnRefreshListviews.TabIndex = 24
        Me.ToolTip1.SetToolTip(Me.btnRefreshListviews, "Click this to refresh Locations and Call Types or other changes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "you've made. ")
        Me.btnRefreshListviews.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Image = Global.DailyLog.My.Resources.Resources.EditCallDetails
        Me.btnEdit.Location = New System.Drawing.Point(8, 151)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(50, 50)
        Me.btnEdit.TabIndex = 23
        Me.ToolTip1.SetToolTip(Me.btnEdit, "Edit Call Details- Add/Delete Locations and Call Types or make changes")
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Image = Global.DailyLog.My.Resources.Resources.btnClose
        Me.btnClose.Location = New System.Drawing.Point(4, 83)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(58, 54)
        Me.btnClose.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.btnClose, "Close Call Details")
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubmit.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnSubmit.FlatAppearance.BorderSize = 0
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Image = Global.DailyLog.My.Resources.Resources.New1
        Me.btnSubmit.Location = New System.Drawing.Point(4, 22)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(58, 54)
        Me.btnSubmit.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.btnSubmit, "Add to Log File")
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lblTotalTime
        '
        Me.lblTotalTime.AutoSize = True
        Me.lblTotalTime.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalTime.Location = New System.Drawing.Point(391, 10)
        Me.lblTotalTime.Name = "lblTotalTime"
        Me.lblTotalTime.Size = New System.Drawing.Size(94, 21)
        Me.lblTotalTime.TabIndex = 63
        Me.lblTotalTime.Text = "TOTAL TIME:"
        '
        'ColumnCallTypes
        '
        Me.ColumnCallTypes.Text = "CALL TYPES"
        Me.ColumnCallTypes.Width = 417
        '
        'lblEndTime
        '
        Me.lblEndTime.AutoSize = True
        Me.lblEndTime.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndTime.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblEndTime.Location = New System.Drawing.Point(207, 10)
        Me.lblEndTime.Name = "lblEndTime"
        Me.lblEndTime.Size = New System.Drawing.Size(82, 21)
        Me.lblEndTime.TabIndex = 62
        Me.lblEndTime.Text = "END TIME:"
        '
        'lvCallTypes
        '
        Me.lvCallTypes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnCallTypes})
        Me.lvCallTypes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lvCallTypes.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvCallTypes.FullRowSelect = True
        Me.lvCallTypes.GridLines = True
        Me.lvCallTypes.HideSelection = False
        Me.lvCallTypes.Location = New System.Drawing.Point(371, 225)
        Me.lvCallTypes.MultiSelect = False
        Me.lvCallTypes.Name = "lvCallTypes"
        Me.lvCallTypes.Size = New System.Drawing.Size(453, 390)
        Me.lvCallTypes.TabIndex = 8
        Me.lvCallTypes.UseCompatibleStateImageBehavior = False
        Me.lvCallTypes.View = System.Windows.Forms.View.Details
        '
        'lvAreaLocations
        '
        Me.lvAreaLocations.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnAreaLocations})
        Me.lvAreaLocations.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lvAreaLocations.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvAreaLocations.FullRowSelect = True
        Me.lvAreaLocations.GridLines = True
        Me.lvAreaLocations.HideSelection = False
        Me.lvAreaLocations.Location = New System.Drawing.Point(8, 225)
        Me.lvAreaLocations.MultiSelect = False
        Me.lvAreaLocations.Name = "lvAreaLocations"
        Me.lvAreaLocations.Size = New System.Drawing.Size(355, 390)
        Me.lvAreaLocations.TabIndex = 7
        Me.lvAreaLocations.UseCompatibleStateImageBehavior = False
        Me.lvAreaLocations.View = System.Windows.Forms.View.Details
        '
        'lblDescriptionNotes
        '
        Me.lblDescriptionNotes.AutoSize = True
        Me.lblDescriptionNotes.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescriptionNotes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDescriptionNotes.Location = New System.Drawing.Point(10, 52)
        Me.lblDescriptionNotes.Name = "lblDescriptionNotes"
        Me.lblDescriptionNotes.Size = New System.Drawing.Size(343, 21)
        Me.lblDescriptionNotes.TabIndex = 59
        Me.lblDescriptionNotes.Text = "LOCATION / BRIEF DESCRIPTION / CALL NOTES:"
        '
        'lblCase
        '
        Me.lblCase.AutoSize = True
        Me.lblCase.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCase.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCase.Location = New System.Drawing.Point(591, 10)
        Me.lblCase.Name = "lblCase"
        Me.lblCase.Size = New System.Drawing.Size(63, 21)
        Me.lblCase.TabIndex = 53
        Me.lblCase.Text = "CASE #:"
        '
        'tmrRefreshNotesText
        '
        Me.tmrRefreshNotesText.Enabled = True
        '
        'FrmCallDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 645)
        Me.Controls.Add(Me.cbCallNotesPrefills)
        Me.Controls.Add(Me.txtCase)
        Me.Controls.Add(Me.txtTotalTime)
        Me.Controls.Add(Me.txtEnd)
        Me.Controls.Add(Me.txtStart)
        Me.Controls.Add(Me.gbOptions)
        Me.Controls.Add(Me.lvCallTypes)
        Me.Controls.Add(Me.lvAreaLocations)
        Me.Controls.Add(Me.txtCallNotes)
        Me.Controls.Add(Me.lblDescriptionNotes)
        Me.Controls.Add(Me.lblStartTime)
        Me.Controls.Add(Me.lblEndTime)
        Me.Controls.Add(Me.lblTotalTime)
        Me.Controls.Add(Me.lblCase)
        Me.Controls.Add(Me.btnEditTime)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmCallDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Call Details"
        Me.gbOptions.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEditTime As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents txtTotalTime As System.Windows.Forms.TextBox
    Friend WithEvents lblStartTime As System.Windows.Forms.Label
    Friend WithEvents ColumnAreaLocations As System.Windows.Forms.ColumnHeader
    Friend WithEvents gbOptions As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotalTime As System.Windows.Forms.Label
    Friend WithEvents txtEnd As System.Windows.Forms.TextBox
    Friend WithEvents ColumnCallTypes As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblEndTime As System.Windows.Forms.Label
    Friend WithEvents lvCallTypes As System.Windows.Forms.ListView
    Friend WithEvents lvAreaLocations As System.Windows.Forms.ListView
    Friend WithEvents txtCallNotes As System.Windows.Forms.TextBox
    Friend WithEvents lblDescriptionNotes As System.Windows.Forms.Label
    Friend WithEvents txtCase As System.Windows.Forms.TextBox
    Friend WithEvents lblCase As System.Windows.Forms.Label
    Friend WithEvents txtStart As System.Windows.Forms.TextBox
    Friend WithEvents cbCallNotesPrefills As System.Windows.Forms.ComboBox
    Friend WithEvents tmrRefreshNotesText As System.Windows.Forms.Timer
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnRefreshListviews As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
End Class
