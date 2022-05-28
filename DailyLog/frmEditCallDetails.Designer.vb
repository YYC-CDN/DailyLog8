<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditCallDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditCallDetails))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ColumnCallTypes = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSave_CT = New System.Windows.Forms.Button()
        Me.txtCallTypes = New System.Windows.Forms.TextBox()
        Me.btnAdd_CT = New System.Windows.Forms.Button()
        Me.btnEdit_CT = New System.Windows.Forms.Button()
        Me.btnDel_CT = New System.Windows.Forms.Button()
        Me.ColumnAreaLocations = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.gbAreas = New System.Windows.Forms.GroupBox()
        Me.btnSave_L = New System.Windows.Forms.Button()
        Me.btnDel_L = New System.Windows.Forms.Button()
        Me.btnAdd_L = New System.Windows.Forms.Button()
        Me.btnEdit_L = New System.Windows.Forms.Button()
        Me.txtLocations = New System.Windows.Forms.TextBox()
        Me.gbOptions = New System.Windows.Forms.GroupBox()
        Me.lblOkay = New System.Windows.Forms.Label()
        Me.btnOkay = New System.Windows.Forms.Button()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lvCallTypes = New System.Windows.Forms.ListView()
        Me.lvAreaLocations = New System.Windows.Forms.ListView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.gbAreas.SuspendLayout()
        Me.gbOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 441)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(731, 136)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = resources.GetString("Label1.Text")
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ColumnCallTypes
        '
        Me.ColumnCallTypes.Text = "CALL TYPES"
        Me.ColumnCallTypes.Width = 350
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSave_CT)
        Me.GroupBox1.Controls.Add(Me.txtCallTypes)
        Me.GroupBox1.Controls.Add(Me.btnAdd_CT)
        Me.GroupBox1.Controls.Add(Me.btnEdit_CT)
        Me.GroupBox1.Controls.Add(Me.btnDel_CT)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(375, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(375, 99)
        Me.GroupBox1.TabIndex = 59
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Edit Call Types"
        '
        'btnSave_CT
        '
        Me.btnSave_CT.FlatAppearance.BorderSize = 0
        Me.btnSave_CT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave_CT.Image = Global.DailyLog.My.Resources.Resources.save_small
        Me.btnSave_CT.Location = New System.Drawing.Point(101, 60)
        Me.btnSave_CT.Name = "btnSave_CT"
        Me.btnSave_CT.Size = New System.Drawing.Size(33, 33)
        Me.btnSave_CT.TabIndex = 0
        '
        'txtCallTypes
        '
        Me.txtCallTypes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCallTypes.Location = New System.Drawing.Point(8, 29)
        Me.txtCallTypes.Name = "txtCallTypes"
        Me.txtCallTypes.Size = New System.Drawing.Size(361, 22)
        Me.txtCallTypes.TabIndex = 39
        '
        'btnAdd_CT
        '
        Me.btnAdd_CT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd_CT.FlatAppearance.BorderSize = 0
        Me.btnAdd_CT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd_CT.Image = Global.DailyLog.My.Resources.Resources.Add_32x32
        Me.btnAdd_CT.Location = New System.Drawing.Point(146, 60)
        Me.btnAdd_CT.Name = "btnAdd_CT"
        Me.btnAdd_CT.Size = New System.Drawing.Size(33, 33)
        Me.btnAdd_CT.TabIndex = 43
        Me.btnAdd_CT.UseVisualStyleBackColor = True
        '
        'btnEdit_CT
        '
        Me.btnEdit_CT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit_CT.FlatAppearance.BorderSize = 0
        Me.btnEdit_CT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit_CT.Image = Global.DailyLog.My.Resources.Resources.Edit_32x32
        Me.btnEdit_CT.Location = New System.Drawing.Point(240, 60)
        Me.btnEdit_CT.Name = "btnEdit_CT"
        Me.btnEdit_CT.Size = New System.Drawing.Size(33, 33)
        Me.btnEdit_CT.TabIndex = 44
        Me.btnEdit_CT.UseVisualStyleBackColor = True
        '
        'btnDel_CT
        '
        Me.btnDel_CT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDel_CT.FlatAppearance.BorderSize = 0
        Me.btnDel_CT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDel_CT.Image = Global.DailyLog.My.Resources.Resources.Delete_32x32
        Me.btnDel_CT.Location = New System.Drawing.Point(193, 60)
        Me.btnDel_CT.Name = "btnDel_CT"
        Me.btnDel_CT.Size = New System.Drawing.Size(33, 33)
        Me.btnDel_CT.TabIndex = 45
        Me.btnDel_CT.UseVisualStyleBackColor = True
        '
        'ColumnAreaLocations
        '
        Me.ColumnAreaLocations.Text = "AREA LOCATIONS"
        Me.ColumnAreaLocations.Width = 280
        '
        'gbAreas
        '
        Me.gbAreas.Controls.Add(Me.btnSave_L)
        Me.gbAreas.Controls.Add(Me.btnDel_L)
        Me.gbAreas.Controls.Add(Me.btnAdd_L)
        Me.gbAreas.Controls.Add(Me.btnEdit_L)
        Me.gbAreas.Controls.Add(Me.txtLocations)
        Me.gbAreas.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbAreas.Location = New System.Drawing.Point(13, 5)
        Me.gbAreas.Name = "gbAreas"
        Me.gbAreas.Size = New System.Drawing.Size(302, 99)
        Me.gbAreas.TabIndex = 58
        Me.gbAreas.TabStop = False
        Me.gbAreas.Text = "Edit Areas and Locations"
        '
        'btnSave_L
        '
        Me.btnSave_L.FlatAppearance.BorderSize = 0
        Me.btnSave_L.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave_L.Image = Global.DailyLog.My.Resources.Resources.save_small
        Me.btnSave_L.Location = New System.Drawing.Point(66, 60)
        Me.btnSave_L.Name = "btnSave_L"
        Me.btnSave_L.Size = New System.Drawing.Size(33, 33)
        Me.btnSave_L.TabIndex = 0
        '
        'btnDel_L
        '
        Me.btnDel_L.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDel_L.FlatAppearance.BorderSize = 0
        Me.btnDel_L.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDel_L.Image = Global.DailyLog.My.Resources.Resources.Delete_32x32
        Me.btnDel_L.Location = New System.Drawing.Point(157, 60)
        Me.btnDel_L.Name = "btnDel_L"
        Me.btnDel_L.Size = New System.Drawing.Size(33, 33)
        Me.btnDel_L.TabIndex = 42
        Me.btnDel_L.UseVisualStyleBackColor = True
        '
        'btnAdd_L
        '
        Me.btnAdd_L.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd_L.FlatAppearance.BorderSize = 0
        Me.btnAdd_L.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd_L.Image = Global.DailyLog.My.Resources.Resources.Add_32x32
        Me.btnAdd_L.Location = New System.Drawing.Point(111, 60)
        Me.btnAdd_L.Name = "btnAdd_L"
        Me.btnAdd_L.Size = New System.Drawing.Size(33, 33)
        Me.btnAdd_L.TabIndex = 40
        Me.btnAdd_L.UseVisualStyleBackColor = True
        '
        'btnEdit_L
        '
        Me.btnEdit_L.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit_L.FlatAppearance.BorderSize = 0
        Me.btnEdit_L.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit_L.Image = Global.DailyLog.My.Resources.Resources.Edit_32x32
        Me.btnEdit_L.Location = New System.Drawing.Point(203, 60)
        Me.btnEdit_L.Name = "btnEdit_L"
        Me.btnEdit_L.Size = New System.Drawing.Size(33, 33)
        Me.btnEdit_L.TabIndex = 41
        Me.btnEdit_L.UseVisualStyleBackColor = True
        '
        'txtLocations
        '
        Me.txtLocations.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocations.Location = New System.Drawing.Point(9, 29)
        Me.txtLocations.Name = "txtLocations"
        Me.txtLocations.Size = New System.Drawing.Size(279, 22)
        Me.txtLocations.TabIndex = 38
        '
        'gbOptions
        '
        Me.gbOptions.Controls.Add(Me.lblOkay)
        Me.gbOptions.Controls.Add(Me.btnOkay)
        Me.gbOptions.Controls.Add(Me.lblClose)
        Me.gbOptions.Controls.Add(Me.btnClose)
        Me.gbOptions.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbOptions.Location = New System.Drawing.Point(756, 7)
        Me.gbOptions.Name = "gbOptions"
        Me.gbOptions.Size = New System.Drawing.Size(82, 225)
        Me.gbOptions.TabIndex = 57
        Me.gbOptions.TabStop = False
        '
        'lblOkay
        '
        Me.lblOkay.AutoSize = True
        Me.lblOkay.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOkay.Location = New System.Drawing.Point(12, 70)
        Me.lblOkay.Name = "lblOkay"
        Me.lblOkay.Size = New System.Drawing.Size(61, 34)
        Me.lblOkay.TabIndex = 28
        Me.lblOkay.Text = "Save and" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Close"
        Me.lblOkay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnOkay
        '
        Me.btnOkay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOkay.FlatAppearance.BorderSize = 0
        Me.btnOkay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOkay.Image = Global.DailyLog.My.Resources.Resources.Checkmark
        Me.btnOkay.Location = New System.Drawing.Point(16, 18)
        Me.btnOkay.Name = "btnOkay"
        Me.btnOkay.Size = New System.Drawing.Size(50, 50)
        Me.btnOkay.TabIndex = 27
        Me.btnOkay.UseVisualStyleBackColor = True
        '
        'lblClose
        '
        Me.lblClose.AutoSize = True
        Me.lblClose.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.Location = New System.Drawing.Point(10, 166)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(65, 34)
        Me.lblClose.TabIndex = 26
        Me.lblClose.Text = "Exit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(No Save)"
        Me.lblClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Image = Global.DailyLog.My.Resources.Resources.Exit_Icon
        Me.btnClose.Location = New System.Drawing.Point(16, 111)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(50, 50)
        Me.btnClose.TabIndex = 21
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lvCallTypes
        '
        Me.lvCallTypes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnCallTypes})
        Me.lvCallTypes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lvCallTypes.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvCallTypes.FullRowSelect = True
        Me.lvCallTypes.GridLines = True
        Me.lvCallTypes.HideSelection = False
        Me.lvCallTypes.Location = New System.Drawing.Point(375, 109)
        Me.lvCallTypes.MultiSelect = False
        Me.lvCallTypes.Name = "lvCallTypes"
        Me.lvCallTypes.Size = New System.Drawing.Size(375, 291)
        Me.lvCallTypes.TabIndex = 56
        Me.lvCallTypes.UseCompatibleStateImageBehavior = False
        Me.lvCallTypes.View = System.Windows.Forms.View.Details
        '
        'lvAreaLocations
        '
        Me.lvAreaLocations.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnAreaLocations})
        Me.lvAreaLocations.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lvAreaLocations.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvAreaLocations.FullRowSelect = True
        Me.lvAreaLocations.GridLines = True
        Me.lvAreaLocations.HideSelection = False
        Me.lvAreaLocations.Location = New System.Drawing.Point(12, 109)
        Me.lvAreaLocations.MultiSelect = False
        Me.lvAreaLocations.Name = "lvAreaLocations"
        Me.lvAreaLocations.Size = New System.Drawing.Size(306, 291)
        Me.lvAreaLocations.TabIndex = 55
        Me.lvAreaLocations.UseCompatibleStateImageBehavior = False
        Me.lvAreaLocations.View = System.Windows.Forms.View.Details
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(76, 555)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 17)
        Me.Label2.TabIndex = 63
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnDown
        '
        Me.btnDown.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDown.FlatAppearance.BorderSize = 0
        Me.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDown.Image = Global.DailyLog.My.Resources.Resources.arrow_down
        Me.btnDown.Location = New System.Drawing.Point(328, 253)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(37, 40)
        Me.btnDown.TabIndex = 61
        Me.btnDown.UseVisualStyleBackColor = True
        '
        'btnUp
        '
        Me.btnUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUp.FlatAppearance.BorderSize = 0
        Me.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUp.Image = Global.DailyLog.My.Resources.Resources.arrow_up
        Me.btnUp.Location = New System.Drawing.Point(328, 192)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(37, 40)
        Me.btnUp.TabIndex = 60
        Me.btnUp.UseVisualStyleBackColor = True
        '
        'frmEditCallDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(855, 617)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDown)
        Me.Controls.Add(Me.btnUp)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbAreas)
        Me.Controls.Add(Me.gbOptions)
        Me.Controls.Add(Me.lvCallTypes)
        Me.Controls.Add(Me.lvAreaLocations)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEditCallDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Call Locations and Call Types"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbAreas.ResumeLayout(False)
        Me.gbAreas.PerformLayout()
        Me.gbOptions.ResumeLayout(False)
        Me.gbOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ColumnCallTypes As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnDown As System.Windows.Forms.Button
    Friend WithEvents btnUp As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSave_CT As System.Windows.Forms.Button
    Friend WithEvents txtCallTypes As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd_CT As System.Windows.Forms.Button
    Friend WithEvents btnEdit_CT As System.Windows.Forms.Button
    Friend WithEvents btnDel_CT As System.Windows.Forms.Button
    Friend WithEvents ColumnAreaLocations As System.Windows.Forms.ColumnHeader
    Friend WithEvents gbAreas As System.Windows.Forms.GroupBox
    Friend WithEvents btnSave_L As System.Windows.Forms.Button
    Friend WithEvents btnDel_L As System.Windows.Forms.Button
    Friend WithEvents btnAdd_L As System.Windows.Forms.Button
    Friend WithEvents btnEdit_L As System.Windows.Forms.Button
    Friend WithEvents txtLocations As System.Windows.Forms.TextBox
    Friend WithEvents gbOptions As System.Windows.Forms.GroupBox
    Friend WithEvents lblOkay As System.Windows.Forms.Label
    Friend WithEvents btnOkay As System.Windows.Forms.Button
    Friend WithEvents lblClose As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lvCallTypes As System.Windows.Forms.ListView
    Friend WithEvents lvAreaLocations As System.Windows.Forms.ListView
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
