<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStats
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStats))
        Me.rbBoth = New System.Windows.Forms.RadioButton()
        Me.rbCountyStats = New System.Windows.Forms.RadioButton()
        Me.gbCommands = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.rbCityStats = New System.Windows.Forms.RadioButton()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.lblChooseTo1 = New System.Windows.Forms.Label()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.lblChooseTo3 = New System.Windows.Forms.Label()
        Me.gbDatePicker = New System.Windows.Forms.GroupBox()
        Me.lblChooseTo2 = New System.Windows.Forms.Label()
        Me.gbOptions = New System.Windows.Forms.GroupBox()
        Me.lblChooseFrom3 = New System.Windows.Forms.Label()
        Me.lblChooseFrom2 = New System.Windows.Forms.Label()
        Me.lblChooseFrom1 = New System.Windows.Forms.Label()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.gbCommands.SuspendLayout()
        Me.gbDatePicker.SuspendLayout()
        Me.gbOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'rbBoth
        '
        Me.rbBoth.AutoSize = True
        Me.rbBoth.BackColor = System.Drawing.Color.Transparent
        Me.rbBoth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbBoth.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rbBoth.Location = New System.Drawing.Point(12, 73)
        Me.rbBoth.Name = "rbBoth"
        Me.rbBoth.Size = New System.Drawing.Size(256, 20)
        Me.rbBoth.TabIndex = 1019
        Me.rbBoth.TabStop = True
        Me.rbBoth.Text = "Generate City and County (same page)"
        Me.rbBoth.UseVisualStyleBackColor = False
        '
        'rbCountyStats
        '
        Me.rbCountyStats.AutoSize = True
        Me.rbCountyStats.BackColor = System.Drawing.Color.Transparent
        Me.rbCountyStats.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCountyStats.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rbCountyStats.Location = New System.Drawing.Point(12, 50)
        Me.rbCountyStats.Name = "rbCountyStats"
        Me.rbCountyStats.Size = New System.Drawing.Size(158, 20)
        Me.rbCountyStats.TabIndex = 1018
        Me.rbCountyStats.Text = "Generate County Stats"
        Me.rbCountyStats.UseVisualStyleBackColor = False
        '
        'gbCommands
        '
        Me.gbCommands.Controls.Add(Me.Label3)
        Me.gbCommands.Controls.Add(Me.Label2)
        Me.gbCommands.Controls.Add(Me.btnClose)
        Me.gbCommands.Controls.Add(Me.btnSave)
        Me.gbCommands.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbCommands.Location = New System.Drawing.Point(278, 68)
        Me.gbCommands.Name = "gbCommands"
        Me.gbCommands.Size = New System.Drawing.Size(122, 135)
        Me.gbCommands.TabIndex = 1018
        Me.gbCommands.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(61, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 32)
        Me.Label3.TabIndex = 1013
        Me.Label3.Text = "Exit And" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Close"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(3, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 48)
        Me.Label2.TabIndex = 1012
        Me.Label2.Text = "Open In" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Default" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Browser"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Image = Global.DailyLog.My.Resources.Resources.Exit_Icon
        Me.btnClose.Location = New System.Drawing.Point(63, 20)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(50, 50)
        Me.btnClose.TabIndex = 1011
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Image = Global.DailyLog.My.Resources.Resources.Default_Browser
        Me.btnSave.Location = New System.Drawing.Point(5, 20)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(50, 50)
        Me.btnSave.TabIndex = 14
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'rbCityStats
        '
        Me.rbCityStats.AutoSize = True
        Me.rbCityStats.BackColor = System.Drawing.Color.Transparent
        Me.rbCityStats.Checked = True
        Me.rbCityStats.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCityStats.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rbCityStats.Location = New System.Drawing.Point(12, 27)
        Me.rbCityStats.Name = "rbCityStats"
        Me.rbCityStats.Size = New System.Drawing.Size(139, 20)
        Me.rbCityStats.TabIndex = 1017
        Me.rbCityStats.TabStop = True
        Me.rbCityStats.Text = "Generate City Stats"
        Me.rbCityStats.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(25, 221)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(391, 23)
        Me.ProgressBar1.TabIndex = 1027
        '
        'lblChooseTo1
        '
        Me.lblChooseTo1.AutoSize = True
        Me.lblChooseTo1.BackColor = System.Drawing.Color.Transparent
        Me.lblChooseTo1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChooseTo1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblChooseTo1.Location = New System.Drawing.Point(23, 49)
        Me.lblChooseTo1.Name = "lblChooseTo1"
        Me.lblChooseTo1.Size = New System.Drawing.Size(55, 13)
        Me.lblChooseTo1.TabIndex = 3
        Me.lblChooseTo1.Text = "Choose a"
        '
        'dtpTo
        '
        Me.dtpTo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpTo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTo.Location = New System.Drawing.Point(125, 45)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(230, 22)
        Me.dtpTo.TabIndex = 1010
        '
        'dtpFrom
        '
        Me.dtpFrom.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFrom.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFrom.Location = New System.Drawing.Point(125, 20)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(230, 22)
        Me.dtpFrom.TabIndex = 1009
        '
        'lblChooseTo3
        '
        Me.lblChooseTo3.AutoSize = True
        Me.lblChooseTo3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChooseTo3.ForeColor = System.Drawing.SystemColors.Control
        Me.lblChooseTo3.Location = New System.Drawing.Point(93, 49)
        Me.lblChooseTo3.Name = "lblChooseTo3"
        Me.lblChooseTo3.Size = New System.Drawing.Size(30, 13)
        Me.lblChooseTo3.TabIndex = 4
        Me.lblChooseTo3.Text = "date"
        '
        'gbDatePicker
        '
        Me.gbDatePicker.BackColor = System.Drawing.Color.Transparent
        Me.gbDatePicker.Controls.Add(Me.lblChooseTo1)
        Me.gbDatePicker.Controls.Add(Me.gbCommands)
        Me.gbDatePicker.Controls.Add(Me.dtpTo)
        Me.gbDatePicker.Controls.Add(Me.lblChooseTo3)
        Me.gbDatePicker.Controls.Add(Me.dtpFrom)
        Me.gbDatePicker.Controls.Add(Me.lblChooseTo2)
        Me.gbDatePicker.Controls.Add(Me.gbOptions)
        Me.gbDatePicker.Controls.Add(Me.lblChooseFrom3)
        Me.gbDatePicker.Controls.Add(Me.lblChooseFrom2)
        Me.gbDatePicker.Controls.Add(Me.lblChooseFrom1)
        Me.gbDatePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDatePicker.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.gbDatePicker.Location = New System.Drawing.Point(18, 9)
        Me.gbDatePicker.Name = "gbDatePicker"
        Me.gbDatePicker.Size = New System.Drawing.Size(414, 246)
        Me.gbDatePicker.TabIndex = 1026
        Me.gbDatePicker.TabStop = False
        Me.gbDatePicker.Text = "Choose Your Dates"
        '
        'lblChooseTo2
        '
        Me.lblChooseTo2.AutoSize = True
        Me.lblChooseTo2.BackColor = System.Drawing.Color.Transparent
        Me.lblChooseTo2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChooseTo2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblChooseTo2.Location = New System.Drawing.Point(74, 49)
        Me.lblChooseTo2.Name = "lblChooseTo2"
        Me.lblChooseTo2.Size = New System.Drawing.Size(21, 13)
        Me.lblChooseTo2.TabIndex = 3
        Me.lblChooseTo2.Text = "TO"
        '
        'gbOptions
        '
        Me.gbOptions.Controls.Add(Me.rbBoth)
        Me.gbOptions.Controls.Add(Me.rbCountyStats)
        Me.gbOptions.Controls.Add(Me.rbCityStats)
        Me.gbOptions.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbOptions.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.gbOptions.Location = New System.Drawing.Point(7, 69)
        Me.gbOptions.Name = "gbOptions"
        Me.gbOptions.Size = New System.Drawing.Size(265, 134)
        Me.gbOptions.TabIndex = 1021
        Me.gbOptions.TabStop = False
        Me.gbOptions.Text = "Report Options"
        '
        'lblChooseFrom3
        '
        Me.lblChooseFrom3.AutoSize = True
        Me.lblChooseFrom3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChooseFrom3.ForeColor = System.Drawing.SystemColors.Control
        Me.lblChooseFrom3.Location = New System.Drawing.Point(93, 25)
        Me.lblChooseFrom3.Name = "lblChooseFrom3"
        Me.lblChooseFrom3.Size = New System.Drawing.Size(30, 13)
        Me.lblChooseFrom3.TabIndex = 1
        Me.lblChooseFrom3.Text = "date"
        '
        'lblChooseFrom2
        '
        Me.lblChooseFrom2.AutoSize = True
        Me.lblChooseFrom2.BackColor = System.Drawing.Color.Transparent
        Me.lblChooseFrom2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChooseFrom2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblChooseFrom2.Location = New System.Drawing.Point(59, 25)
        Me.lblChooseFrom2.Name = "lblChooseFrom2"
        Me.lblChooseFrom2.Size = New System.Drawing.Size(39, 13)
        Me.lblChooseFrom2.TabIndex = 0
        Me.lblChooseFrom2.Text = "FROM"
        '
        'lblChooseFrom1
        '
        Me.lblChooseFrom1.AutoSize = True
        Me.lblChooseFrom1.BackColor = System.Drawing.Color.Transparent
        Me.lblChooseFrom1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChooseFrom1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblChooseFrom1.Location = New System.Drawing.Point(9, 25)
        Me.lblChooseFrom1.Name = "lblChooseFrom1"
        Me.lblChooseFrom1.Size = New System.Drawing.Size(55, 13)
        Me.lblChooseFrom1.TabIndex = 2
        Me.lblChooseFrom1.Text = "Choose a"
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblInstructions.Location = New System.Drawing.Point(63, 68)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(0, 15)
        Me.lblInstructions.TabIndex = 1024
        '
        'frmStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(450, 264)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.gbDatePicker)
        Me.Controls.Add(Me.lblInstructions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStats"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DailyLog Statistics Generator"
        Me.gbCommands.ResumeLayout(False)
        Me.gbCommands.PerformLayout()
        Me.gbDatePicker.ResumeLayout(False)
        Me.gbDatePicker.PerformLayout()
        Me.gbOptions.ResumeLayout(False)
        Me.gbOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rbBoth As System.Windows.Forms.RadioButton
    Friend WithEvents rbCountyStats As System.Windows.Forms.RadioButton
    Friend WithEvents gbCommands As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents rbCityStats As System.Windows.Forms.RadioButton
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents lblChooseTo1 As System.Windows.Forms.Label
    Friend WithEvents dtpTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblChooseTo3 As System.Windows.Forms.Label
    Friend WithEvents gbDatePicker As System.Windows.Forms.GroupBox
    Friend WithEvents lblChooseTo2 As System.Windows.Forms.Label
    Friend WithEvents gbOptions As System.Windows.Forms.GroupBox
    Friend WithEvents lblChooseFrom3 As System.Windows.Forms.Label
    Friend WithEvents lblChooseFrom2 As System.Windows.Forms.Label
    Friend WithEvents lblChooseFrom1 As System.Windows.Forms.Label
    Friend WithEvents lblInstructions As System.Windows.Forms.Label
End Class
