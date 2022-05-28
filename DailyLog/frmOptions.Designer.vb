<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOptions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOptions))
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Agency Information")
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Global Options")
        Dim TreeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Backup/Restore")
        Dim TreeNode28 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Theme Preferences")
        Dim TreeNode29 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Shift Stats")
        Dim TreeNode30 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Edit Quick Picks")
        Me.tcMain = New System.Windows.Forms.TabControl()
        Me.tbAgency = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPOSTID = New System.Windows.Forms.TextBox()
        Me.lblPOSTID = New System.Windows.Forms.Label()
        Me.txtAddURL = New System.Windows.Forms.MaskedTextBox()
        Me.txtAddFax = New System.Windows.Forms.MaskedTextBox()
        Me.txtAddPhone = New System.Windows.Forms.MaskedTextBox()
        Me.txtAddCounty = New System.Windows.Forms.TextBox()
        Me.lblCounty = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.txtAddState = New System.Windows.Forms.TextBox()
        Me.lblURL = New System.Windows.Forms.Label()
        Me.lblFax = New System.Windows.Forms.Label()
        Me.lblORI = New System.Windows.Forms.Label()
        Me.txtAddORI = New System.Windows.Forms.TextBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblZip = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtAddZip = New System.Windows.Forms.TextBox()
        Me.txtAddCity = New System.Windows.Forms.TextBox()
        Me.txtAddAddress = New System.Windows.Forms.TextBox()
        Me.txtAgency = New System.Windows.Forms.Label()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.txtAddAgency = New System.Windows.Forms.TextBox()
        Me.txtAddSupervisor = New System.Windows.Forms.TextBox()
        Me.txtAddArea = New System.Windows.Forms.TextBox()
        Me.lblSupervisor = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtAddID = New System.Windows.Forms.TextBox()
        Me.txtAddOfficer = New System.Windows.Forms.TextBox()
        Me.lblOfficer = New System.Windows.Forms.Label()
        Me.tbOptions = New System.Windows.Forms.TabPage()
        Me.gbGeneralOptions = New System.Windows.Forms.GroupBox()
        Me.cbNightMode = New System.Windows.Forms.CheckBox()
        Me.cbShowTotalMileage = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbBackup = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.gb3 = New System.Windows.Forms.GroupBox()
        Me.lblRestore = New System.Windows.Forms.Label()
        Me.lblBackup = New System.Windows.Forms.Label()
        Me.btnRestoreFiles = New System.Windows.Forms.Button()
        Me.btnBackupFiles = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.tbTheme = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbBackgroundColor = New System.Windows.Forms.GroupBox()
        Me.rbDarkRedBackground = New System.Windows.Forms.RadioButton()
        Me.rbLightBlueBackground = New System.Windows.Forms.RadioButton()
        Me.rbGreyBackground = New System.Windows.Forms.RadioButton()
        Me.rbWhiteBackground = New System.Windows.Forms.RadioButton()
        Me.rbRedBackground = New System.Windows.Forms.RadioButton()
        Me.rbBlueBackground = New System.Windows.Forms.RadioButton()
        Me.rbOrangeBackground = New System.Windows.Forms.RadioButton()
        Me.rbOliveGreenBackground = New System.Windows.Forms.RadioButton()
        Me.rbBlackBackground = New System.Windows.Forms.RadioButton()
        Me.gbColors = New System.Windows.Forms.GroupBox()
        Me.rbBlackText = New System.Windows.Forms.RadioButton()
        Me.rbOrangeText = New System.Windows.Forms.RadioButton()
        Me.rbGreenText = New System.Windows.Forms.RadioButton()
        Me.rbYellowText = New System.Windows.Forms.RadioButton()
        Me.rbWhiteText = New System.Windows.Forms.RadioButton()
        Me.rbRedText = New System.Windows.Forms.RadioButton()
        Me.tbShiftStats = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtStat15 = New System.Windows.Forms.TextBox()
        Me.txtStat16 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnStatsClearAll = New System.Windows.Forms.Button()
        Me.txtStat14 = New System.Windows.Forms.TextBox()
        Me.txtStat13 = New System.Windows.Forms.TextBox()
        Me.txtStat12 = New System.Windows.Forms.TextBox()
        Me.txtStat10 = New System.Windows.Forms.TextBox()
        Me.txtStat11 = New System.Windows.Forms.TextBox()
        Me.txtStat9 = New System.Windows.Forms.TextBox()
        Me.txtStat8 = New System.Windows.Forms.TextBox()
        Me.txtStat7 = New System.Windows.Forms.TextBox()
        Me.txtStat6 = New System.Windows.Forms.TextBox()
        Me.txtStat5 = New System.Windows.Forms.TextBox()
        Me.txtStat3 = New System.Windows.Forms.TextBox()
        Me.txtStat4 = New System.Windows.Forms.TextBox()
        Me.txtStat2 = New System.Windows.Forms.TextBox()
        Me.txtStat1 = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbQuickPicks = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnQuickPickDown = New System.Windows.Forms.Button()
        Me.btnQuickPickUp = New System.Windows.Forms.Button()
        Me.lvCallQuickPick = New System.Windows.Forms.ListView()
        Me.txtCallQuickNotes = New System.Windows.Forms.TextBox()
        Me.btnDeleteCallQuickNotes = New System.Windows.Forms.Button()
        Me.btnAddCallQuickNotes = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.tvMain = New System.Windows.Forms.TreeView()
        Me.OptionsBackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.tmrChangeBackgroundTheme = New System.Windows.Forms.Timer(Me.components)
        Me.btnApply = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.tcMain.SuspendLayout()
        Me.tbAgency.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tbOptions.SuspendLayout()
        Me.gbGeneralOptions.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.tbBackup.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.gb3.SuspendLayout()
        Me.tbTheme.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.gbBackgroundColor.SuspendLayout()
        Me.gbColors.SuspendLayout()
        Me.tbShiftStats.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.tbQuickPicks.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'tcMain
        '
        Me.tcMain.AccessibleName = ""
        Me.tcMain.Controls.Add(Me.tbAgency)
        Me.tcMain.Controls.Add(Me.tbOptions)
        Me.tcMain.Controls.Add(Me.tbBackup)
        Me.tcMain.Controls.Add(Me.tbTheme)
        Me.tcMain.Controls.Add(Me.tbShiftStats)
        Me.tcMain.Controls.Add(Me.tbQuickPicks)
        Me.tcMain.Location = New System.Drawing.Point(187, -22)
        Me.tcMain.Name = "tcMain"
        Me.tcMain.SelectedIndex = 0
        Me.tcMain.Size = New System.Drawing.Size(701, 346)
        Me.tcMain.TabIndex = 5
        '
        'tbAgency
        '
        Me.tbAgency.AutoScroll = True
        Me.tbAgency.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.tbAgency.Controls.Add(Me.Panel1)
        Me.tbAgency.Controls.Add(Me.GroupBox1)
        Me.tbAgency.Location = New System.Drawing.Point(4, 22)
        Me.tbAgency.Name = "tbAgency"
        Me.tbAgency.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tbAgency.Size = New System.Drawing.Size(693, 320)
        Me.tbAgency.TabIndex = 0
        Me.tbAgency.Text = "Agency Information"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.DailyLog.My.Resources.Resources.Options_background_2018
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(690, 75)
        Me.Panel1.TabIndex = 53
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(35, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(314, 37)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Agency/User Information"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtPOSTID)
        Me.GroupBox1.Controls.Add(Me.lblPOSTID)
        Me.GroupBox1.Controls.Add(Me.txtAddURL)
        Me.GroupBox1.Controls.Add(Me.txtAddFax)
        Me.GroupBox1.Controls.Add(Me.txtAddPhone)
        Me.GroupBox1.Controls.Add(Me.txtAddCounty)
        Me.GroupBox1.Controls.Add(Me.lblCounty)
        Me.GroupBox1.Controls.Add(Me.lblState)
        Me.GroupBox1.Controls.Add(Me.txtAddState)
        Me.GroupBox1.Controls.Add(Me.lblURL)
        Me.GroupBox1.Controls.Add(Me.lblFax)
        Me.GroupBox1.Controls.Add(Me.lblORI)
        Me.GroupBox1.Controls.Add(Me.txtAddORI)
        Me.GroupBox1.Controls.Add(Me.lblPhone)
        Me.GroupBox1.Controls.Add(Me.lblZip)
        Me.GroupBox1.Controls.Add(Me.lblCity)
        Me.GroupBox1.Controls.Add(Me.lblAddress)
        Me.GroupBox1.Controls.Add(Me.txtAddZip)
        Me.GroupBox1.Controls.Add(Me.txtAddCity)
        Me.GroupBox1.Controls.Add(Me.txtAddAddress)
        Me.GroupBox1.Controls.Add(Me.txtAgency)
        Me.GroupBox1.Controls.Add(Me.lblArea)
        Me.GroupBox1.Controls.Add(Me.txtAddAgency)
        Me.GroupBox1.Controls.Add(Me.txtAddSupervisor)
        Me.GroupBox1.Controls.Add(Me.txtAddArea)
        Me.GroupBox1.Controls.Add(Me.lblSupervisor)
        Me.GroupBox1.Controls.Add(Me.lblID)
        Me.GroupBox1.Controls.Add(Me.txtAddID)
        Me.GroupBox1.Controls.Add(Me.txtAddOfficer)
        Me.GroupBox1.Controls.Add(Me.lblOfficer)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(671, 207)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(269, 30)
        Me.Label5.TabIndex = 113
        Me.Label5.Text = "Items in RED are required for the daily activity log." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "A restart is required on f" &
    "irst run."
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPOSTID
        '
        Me.txtPOSTID.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPOSTID.Location = New System.Drawing.Point(405, 40)
        Me.txtPOSTID.Name = "txtPOSTID"
        Me.txtPOSTID.Size = New System.Drawing.Size(176, 23)
        Me.txtPOSTID.TabIndex = 90
        '
        'lblPOSTID
        '
        Me.lblPOSTID.AutoSize = True
        Me.lblPOSTID.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPOSTID.Location = New System.Drawing.Point(334, 42)
        Me.lblPOSTID.Name = "lblPOSTID"
        Me.lblPOSTID.Size = New System.Drawing.Size(56, 15)
        Me.lblPOSTID.TabIndex = 112
        Me.lblPOSTID.Text = "POST ID#"
        '
        'txtAddURL
        '
        Me.txtAddURL.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddURL.Location = New System.Drawing.Point(120, 112)
        Me.txtAddURL.Name = "txtAddURL"
        Me.txtAddURL.Size = New System.Drawing.Size(201, 23)
        Me.txtAddURL.TabIndex = 87
        '
        'txtAddFax
        '
        Me.txtAddFax.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddFax.Location = New System.Drawing.Point(540, 161)
        Me.txtAddFax.Mask = "(000)000-0000"
        Me.txtAddFax.Name = "txtAddFax"
        Me.txtAddFax.Size = New System.Drawing.Size(99, 23)
        Me.txtAddFax.TabIndex = 97
        '
        'txtAddPhone
        '
        Me.txtAddPhone.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddPhone.Location = New System.Drawing.Point(405, 159)
        Me.txtAddPhone.Mask = "(000)000-0000"
        Me.txtAddPhone.Name = "txtAddPhone"
        Me.txtAddPhone.Size = New System.Drawing.Size(99, 23)
        Me.txtAddPhone.TabIndex = 96
        '
        'txtAddCounty
        '
        Me.txtAddCounty.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAddCounty.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddCounty.Location = New System.Drawing.Point(405, 111)
        Me.txtAddCounty.MaxLength = 45
        Me.txtAddCounty.Name = "txtAddCounty"
        Me.txtAddCounty.Size = New System.Drawing.Size(206, 23)
        Me.txtAddCounty.TabIndex = 93
        '
        'lblCounty
        '
        Me.lblCounty.AutoSize = True
        Me.lblCounty.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCounty.Location = New System.Drawing.Point(345, 114)
        Me.lblCounty.Name = "lblCounty"
        Me.lblCounty.Size = New System.Drawing.Size(46, 15)
        Me.lblCounty.TabIndex = 111
        Me.lblCounty.Text = "County"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.Location = New System.Drawing.Point(358, 138)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(33, 15)
        Me.lblState.TabIndex = 110
        Me.lblState.Text = "State"
        '
        'txtAddState
        '
        Me.txtAddState.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAddState.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddState.Location = New System.Drawing.Point(405, 135)
        Me.txtAddState.MaxLength = 10
        Me.txtAddState.Name = "txtAddState"
        Me.txtAddState.Size = New System.Drawing.Size(73, 23)
        Me.txtAddState.TabIndex = 94
        '
        'lblURL
        '
        Me.lblURL.AutoSize = True
        Me.lblURL.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblURL.Location = New System.Drawing.Point(81, 115)
        Me.lblURL.Name = "lblURL"
        Me.lblURL.Size = New System.Drawing.Size(28, 15)
        Me.lblURL.TabIndex = 109
        Me.lblURL.Text = "URL"
        '
        'lblFax
        '
        Me.lblFax.AutoSize = True
        Me.lblFax.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFax.Location = New System.Drawing.Point(508, 163)
        Me.lblFax.Name = "lblFax"
        Me.lblFax.Size = New System.Drawing.Size(25, 15)
        Me.lblFax.TabIndex = 108
        Me.lblFax.Text = "Fax"
        '
        'lblORI
        '
        Me.lblORI.AutoSize = True
        Me.lblORI.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblORI.Location = New System.Drawing.Point(83, 139)
        Me.lblORI.Name = "lblORI"
        Me.lblORI.Size = New System.Drawing.Size(26, 15)
        Me.lblORI.TabIndex = 107
        Me.lblORI.Text = "ORI"
        '
        'txtAddORI
        '
        Me.txtAddORI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAddORI.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddORI.Location = New System.Drawing.Point(120, 136)
        Me.txtAddORI.Name = "txtAddORI"
        Me.txtAddORI.Size = New System.Drawing.Size(201, 23)
        Me.txtAddORI.TabIndex = 88
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.Location = New System.Drawing.Point(350, 162)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(41, 15)
        Me.lblPhone.TabIndex = 106
        Me.lblPhone.Text = "Phone"
        '
        'lblZip
        '
        Me.lblZip.AutoSize = True
        Me.lblZip.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZip.Location = New System.Drawing.Point(483, 138)
        Me.lblZip.Name = "lblZip"
        Me.lblZip.Size = New System.Drawing.Size(55, 15)
        Me.lblZip.TabIndex = 105
        Me.lblZip.Text = "Zip Code"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCity.Location = New System.Drawing.Point(363, 90)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(28, 15)
        Me.lblCity.TabIndex = 104
        Me.lblCity.Text = "City"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(342, 67)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(49, 15)
        Me.lblAddress.TabIndex = 103
        Me.lblAddress.Text = "Address"
        '
        'txtAddZip
        '
        Me.txtAddZip.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAddZip.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddZip.Location = New System.Drawing.Point(548, 135)
        Me.txtAddZip.MaxLength = 10
        Me.txtAddZip.Name = "txtAddZip"
        Me.txtAddZip.Size = New System.Drawing.Size(73, 23)
        Me.txtAddZip.TabIndex = 95
        '
        'txtAddCity
        '
        Me.txtAddCity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAddCity.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddCity.Location = New System.Drawing.Point(405, 87)
        Me.txtAddCity.Name = "txtAddCity"
        Me.txtAddCity.Size = New System.Drawing.Size(206, 23)
        Me.txtAddCity.TabIndex = 92
        '
        'txtAddAddress
        '
        Me.txtAddAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAddAddress.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddAddress.Location = New System.Drawing.Point(405, 63)
        Me.txtAddAddress.Name = "txtAddAddress"
        Me.txtAddAddress.Size = New System.Drawing.Size(206, 23)
        Me.txtAddAddress.TabIndex = 91
        '
        'txtAgency
        '
        Me.txtAgency.AutoSize = True
        Me.txtAgency.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAgency.ForeColor = System.Drawing.Color.Red
        Me.txtAgency.Location = New System.Drawing.Point(51, 42)
        Me.txtAgency.Name = "txtAgency"
        Me.txtAgency.Size = New System.Drawing.Size(57, 15)
        Me.txtAgency.TabIndex = 102
        Me.txtAgency.Text = "Employer"
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArea.ForeColor = System.Drawing.Color.Red
        Me.lblArea.Location = New System.Drawing.Point(34, 90)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(75, 15)
        Me.lblArea.TabIndex = 101
        Me.lblArea.Text = "Area Worked"
        '
        'txtAddAgency
        '
        Me.txtAddAgency.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAddAgency.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddAgency.Location = New System.Drawing.Point(120, 40)
        Me.txtAddAgency.Name = "txtAddAgency"
        Me.txtAddAgency.Size = New System.Drawing.Size(201, 23)
        Me.txtAddAgency.TabIndex = 84
        '
        'txtAddSupervisor
        '
        Me.txtAddSupervisor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAddSupervisor.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddSupervisor.Location = New System.Drawing.Point(120, 64)
        Me.txtAddSupervisor.Name = "txtAddSupervisor"
        Me.txtAddSupervisor.Size = New System.Drawing.Size(201, 23)
        Me.txtAddSupervisor.TabIndex = 85
        '
        'txtAddArea
        '
        Me.txtAddArea.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAddArea.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddArea.Location = New System.Drawing.Point(120, 88)
        Me.txtAddArea.Name = "txtAddArea"
        Me.txtAddArea.Size = New System.Drawing.Size(201, 23)
        Me.txtAddArea.TabIndex = 86
        '
        'lblSupervisor
        '
        Me.lblSupervisor.AutoSize = True
        Me.lblSupervisor.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSupervisor.ForeColor = System.Drawing.Color.Red
        Me.lblSupervisor.Location = New System.Drawing.Point(47, 65)
        Me.lblSupervisor.Name = "lblSupervisor"
        Me.lblSupervisor.Size = New System.Drawing.Size(62, 15)
        Me.lblSupervisor.TabIndex = 100
        Me.lblSupervisor.Text = "Supervisor"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.ForeColor = System.Drawing.Color.Red
        Me.lblID.Location = New System.Drawing.Point(325, 19)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(66, 15)
        Me.lblID.TabIndex = 99
        Me.lblID.Text = "ID/Badge #"
        '
        'txtAddID
        '
        Me.txtAddID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAddID.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddID.Location = New System.Drawing.Point(405, 16)
        Me.txtAddID.MaxLength = 20
        Me.txtAddID.Name = "txtAddID"
        Me.txtAddID.Size = New System.Drawing.Size(176, 23)
        Me.txtAddID.TabIndex = 89
        '
        'txtAddOfficer
        '
        Me.txtAddOfficer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAddOfficer.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddOfficer.Location = New System.Drawing.Point(120, 16)
        Me.txtAddOfficer.Name = "txtAddOfficer"
        Me.txtAddOfficer.Size = New System.Drawing.Size(201, 23)
        Me.txtAddOfficer.TabIndex = 83
        '
        'lblOfficer
        '
        Me.lblOfficer.AutoSize = True
        Me.lblOfficer.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOfficer.ForeColor = System.Drawing.Color.Red
        Me.lblOfficer.Location = New System.Drawing.Point(66, 20)
        Me.lblOfficer.Name = "lblOfficer"
        Me.lblOfficer.Size = New System.Drawing.Size(39, 15)
        Me.lblOfficer.TabIndex = 98
        Me.lblOfficer.Text = "Name"
        '
        'tbOptions
        '
        Me.tbOptions.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.tbOptions.Controls.Add(Me.gbGeneralOptions)
        Me.tbOptions.Controls.Add(Me.Label6)
        Me.tbOptions.Controls.Add(Me.Panel2)
        Me.tbOptions.Location = New System.Drawing.Point(4, 22)
        Me.tbOptions.Name = "tbOptions"
        Me.tbOptions.Size = New System.Drawing.Size(693, 320)
        Me.tbOptions.TabIndex = 4
        Me.tbOptions.Text = "Global Options"
        '
        'gbGeneralOptions
        '
        Me.gbGeneralOptions.Controls.Add(Me.cbNightMode)
        Me.gbGeneralOptions.Controls.Add(Me.cbShowTotalMileage)
        Me.gbGeneralOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbGeneralOptions.Location = New System.Drawing.Point(72, 87)
        Me.gbGeneralOptions.Name = "gbGeneralOptions"
        Me.gbGeneralOptions.Size = New System.Drawing.Size(309, 202)
        Me.gbGeneralOptions.TabIndex = 55
        Me.gbGeneralOptions.TabStop = False
        Me.gbGeneralOptions.Text = "General Settings"
        '
        'cbNightMode
        '
        Me.cbNightMode.AutoSize = True
        Me.cbNightMode.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNightMode.Location = New System.Drawing.Point(16, 34)
        Me.cbNightMode.Name = "cbNightMode"
        Me.cbNightMode.Size = New System.Drawing.Size(197, 21)
        Me.cbNightMode.TabIndex = 26
        Me.cbNightMode.Text = "Start DailyLog in Night Mode"
        Me.cbNightMode.UseVisualStyleBackColor = True
        '
        'cbShowTotalMileage
        '
        Me.cbShowTotalMileage.AutoSize = True
        Me.cbShowTotalMileage.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbShowTotalMileage.Location = New System.Drawing.Point(16, 62)
        Me.cbShowTotalMileage.Name = "cbShowTotalMileage"
        Me.cbShowTotalMileage.Size = New System.Drawing.Size(217, 21)
        Me.cbShowTotalMileage.TabIndex = 23
        Me.cbShowTotalMileage.Text = "Show total mileage on shutdown"
        Me.cbShowTotalMileage.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(451, 355)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(242, 16)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Some options take effect on next startup"
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.DailyLog.My.Resources.Resources.Options_background_20181
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(690, 75)
        Me.Panel2.TabIndex = 54
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(35, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(210, 37)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "General Options"
        '
        'tbBackup
        '
        Me.tbBackup.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.tbBackup.Controls.Add(Me.Panel3)
        Me.tbBackup.Controls.Add(Me.gb3)
        Me.tbBackup.Location = New System.Drawing.Point(4, 22)
        Me.tbBackup.Name = "tbBackup"
        Me.tbBackup.Size = New System.Drawing.Size(693, 320)
        Me.tbBackup.TabIndex = 3
        Me.tbBackup.Text = "Backup/Restore"
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.DailyLog.My.Resources.Resources.Options_background_20181
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(690, 75)
        Me.Panel3.TabIndex = 55
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(35, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(312, 37)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Backup/Restore Log Files"
        '
        'gb3
        '
        Me.gb3.Controls.Add(Me.lblRestore)
        Me.gb3.Controls.Add(Me.lblBackup)
        Me.gb3.Controls.Add(Me.btnRestoreFiles)
        Me.gb3.Controls.Add(Me.btnBackupFiles)
        Me.gb3.Controls.Add(Me.ProgressBar1)
        Me.gb3.Controls.Add(Me.lblInstructions)
        Me.gb3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb3.Location = New System.Drawing.Point(84, 77)
        Me.gb3.Name = "gb3"
        Me.gb3.Size = New System.Drawing.Size(498, 231)
        Me.gb3.TabIndex = 0
        Me.gb3.TabStop = False
        '
        'lblRestore
        '
        Me.lblRestore.AutoSize = True
        Me.lblRestore.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRestore.Location = New System.Drawing.Point(270, 161)
        Me.lblRestore.Name = "lblRestore"
        Me.lblRestore.Size = New System.Drawing.Size(108, 17)
        Me.lblRestore.TabIndex = 8
        Me.lblRestore.Text = "Restore Log Files"
        '
        'lblBackup
        '
        Me.lblBackup.AutoSize = True
        Me.lblBackup.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBackup.Location = New System.Drawing.Point(123, 161)
        Me.lblBackup.Name = "lblBackup"
        Me.lblBackup.Size = New System.Drawing.Size(104, 17)
        Me.lblBackup.TabIndex = 7
        Me.lblBackup.Text = "Backup Log Files"
        '
        'btnRestoreFiles
        '
        Me.btnRestoreFiles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnRestoreFiles.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRestoreFiles.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestoreFiles.Image = Global.DailyLog.My.Resources.Resources.restore_icon
        Me.btnRestoreFiles.Location = New System.Drawing.Point(255, 79)
        Me.btnRestoreFiles.Name = "btnRestoreFiles"
        Me.btnRestoreFiles.Size = New System.Drawing.Size(130, 80)
        Me.btnRestoreFiles.TabIndex = 5
        Me.btnRestoreFiles.UseVisualStyleBackColor = True
        '
        'btnBackupFiles
        '
        Me.btnBackupFiles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBackupFiles.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBackupFiles.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackupFiles.Image = Global.DailyLog.My.Resources.Resources.backup_icon
        Me.btnBackupFiles.Location = New System.Drawing.Point(110, 79)
        Me.btnBackupFiles.Name = "btnBackupFiles"
        Me.btnBackupFiles.Size = New System.Drawing.Size(130, 80)
        Me.btnBackupFiles.TabIndex = 2
        Me.btnBackupFiles.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(65, 189)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(369, 23)
        Me.ProgressBar1.TabIndex = 6
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(68, 4)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(387, 102)
        Me.lblInstructions.TabIndex = 3
        Me.lblInstructions.Text = resources.GetString("lblInstructions.Text")
        Me.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbTheme
        '
        Me.tbTheme.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.tbTheme.Controls.Add(Me.Panel4)
        Me.tbTheme.Controls.Add(Me.Label3)
        Me.tbTheme.Controls.Add(Me.Label2)
        Me.tbTheme.Controls.Add(Me.gbBackgroundColor)
        Me.tbTheme.Controls.Add(Me.gbColors)
        Me.tbTheme.Location = New System.Drawing.Point(4, 22)
        Me.tbTheme.Name = "tbTheme"
        Me.tbTheme.Size = New System.Drawing.Size(693, 320)
        Me.tbTheme.TabIndex = 5
        Me.tbTheme.Text = "Theme Preferences"
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = Global.DailyLog.My.Resources.Resources.Options_background_2018
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(690, 75)
        Me.Panel4.TabIndex = 56
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(35, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(330, 37)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Theme/Colour Preferences"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(474, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(197, 21)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "When Setting Your Theme-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(468, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(216, 102)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "1: Change Theme on Main Window " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2: Choose Background Color" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3: Choose Text Color" &
    "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You may need to toggle the theme" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to see changes"
        '
        'gbBackgroundColor
        '
        Me.gbBackgroundColor.Controls.Add(Me.rbDarkRedBackground)
        Me.gbBackgroundColor.Controls.Add(Me.rbLightBlueBackground)
        Me.gbBackgroundColor.Controls.Add(Me.rbGreyBackground)
        Me.gbBackgroundColor.Controls.Add(Me.rbWhiteBackground)
        Me.gbBackgroundColor.Controls.Add(Me.rbRedBackground)
        Me.gbBackgroundColor.Controls.Add(Me.rbBlueBackground)
        Me.gbBackgroundColor.Controls.Add(Me.rbOrangeBackground)
        Me.gbBackgroundColor.Controls.Add(Me.rbOliveGreenBackground)
        Me.gbBackgroundColor.Controls.Add(Me.rbBlackBackground)
        Me.gbBackgroundColor.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbBackgroundColor.Location = New System.Drawing.Point(7, 79)
        Me.gbBackgroundColor.Name = "gbBackgroundColor"
        Me.gbBackgroundColor.Size = New System.Drawing.Size(252, 235)
        Me.gbBackgroundColor.TabIndex = 21
        Me.gbBackgroundColor.TabStop = False
        Me.gbBackgroundColor.Text = "Background Color Options"
        '
        'rbDarkRedBackground
        '
        Me.rbDarkRedBackground.AutoSize = True
        Me.rbDarkRedBackground.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDarkRedBackground.ForeColor = System.Drawing.Color.DarkRed
        Me.rbDarkRedBackground.Location = New System.Drawing.Point(18, 207)
        Me.rbDarkRedBackground.Name = "rbDarkRedBackground"
        Me.rbDarkRedBackground.Size = New System.Drawing.Size(153, 21)
        Me.rbDarkRedBackground.TabIndex = 8
        Me.rbDarkRedBackground.Text = "Dark Red Background"
        Me.rbDarkRedBackground.UseVisualStyleBackColor = True
        '
        'rbLightBlueBackground
        '
        Me.rbLightBlueBackground.AutoSize = True
        Me.rbLightBlueBackground.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbLightBlueBackground.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.rbLightBlueBackground.Location = New System.Drawing.Point(18, 184)
        Me.rbLightBlueBackground.Name = "rbLightBlueBackground"
        Me.rbLightBlueBackground.Size = New System.Drawing.Size(155, 21)
        Me.rbLightBlueBackground.TabIndex = 7
        Me.rbLightBlueBackground.Text = "Light Blue Background"
        Me.rbLightBlueBackground.UseVisualStyleBackColor = True
        '
        'rbGreyBackground
        '
        Me.rbGreyBackground.AutoSize = True
        Me.rbGreyBackground.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbGreyBackground.ForeColor = System.Drawing.Color.DimGray
        Me.rbGreyBackground.Location = New System.Drawing.Point(18, 161)
        Me.rbGreyBackground.Name = "rbGreyBackground"
        Me.rbGreyBackground.Size = New System.Drawing.Size(126, 21)
        Me.rbGreyBackground.TabIndex = 6
        Me.rbGreyBackground.Text = "Grey Background"
        Me.rbGreyBackground.UseVisualStyleBackColor = True
        '
        'rbWhiteBackground
        '
        Me.rbWhiteBackground.AutoSize = True
        Me.rbWhiteBackground.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbWhiteBackground.Location = New System.Drawing.Point(18, 138)
        Me.rbWhiteBackground.Name = "rbWhiteBackground"
        Me.rbWhiteBackground.Size = New System.Drawing.Size(224, 21)
        Me.rbWhiteBackground.TabIndex = 5
        Me.rbWhiteBackground.Text = "White Background (High Contrast)"
        Me.rbWhiteBackground.UseVisualStyleBackColor = True
        '
        'rbRedBackground
        '
        Me.rbRedBackground.AutoSize = True
        Me.rbRedBackground.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbRedBackground.ForeColor = System.Drawing.Color.Crimson
        Me.rbRedBackground.Location = New System.Drawing.Point(18, 115)
        Me.rbRedBackground.Name = "rbRedBackground"
        Me.rbRedBackground.Size = New System.Drawing.Size(122, 21)
        Me.rbRedBackground.TabIndex = 4
        Me.rbRedBackground.Text = "Red Background"
        Me.rbRedBackground.UseVisualStyleBackColor = True
        '
        'rbBlueBackground
        '
        Me.rbBlueBackground.AutoSize = True
        Me.rbBlueBackground.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbBlueBackground.ForeColor = System.Drawing.Color.MidnightBlue
        Me.rbBlueBackground.Location = New System.Drawing.Point(18, 92)
        Me.rbBlueBackground.Name = "rbBlueBackground"
        Me.rbBlueBackground.Size = New System.Drawing.Size(123, 21)
        Me.rbBlueBackground.TabIndex = 3
        Me.rbBlueBackground.Text = "Blue Background"
        Me.rbBlueBackground.UseVisualStyleBackColor = True
        '
        'rbOrangeBackground
        '
        Me.rbOrangeBackground.AutoSize = True
        Me.rbOrangeBackground.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbOrangeBackground.ForeColor = System.Drawing.Color.DarkOrange
        Me.rbOrangeBackground.Location = New System.Drawing.Point(18, 69)
        Me.rbOrangeBackground.Name = "rbOrangeBackground"
        Me.rbOrangeBackground.Size = New System.Drawing.Size(143, 21)
        Me.rbOrangeBackground.TabIndex = 2
        Me.rbOrangeBackground.Text = "Orange Background"
        Me.rbOrangeBackground.UseVisualStyleBackColor = True
        '
        'rbOliveGreenBackground
        '
        Me.rbOliveGreenBackground.AutoSize = True
        Me.rbOliveGreenBackground.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbOliveGreenBackground.ForeColor = System.Drawing.Color.OliveDrab
        Me.rbOliveGreenBackground.Location = New System.Drawing.Point(18, 46)
        Me.rbOliveGreenBackground.Name = "rbOliveGreenBackground"
        Me.rbOliveGreenBackground.Size = New System.Drawing.Size(167, 21)
        Me.rbOliveGreenBackground.TabIndex = 1
        Me.rbOliveGreenBackground.Text = "Olive Green Background"
        Me.rbOliveGreenBackground.UseVisualStyleBackColor = True
        '
        'rbBlackBackground
        '
        Me.rbBlackBackground.AutoSize = True
        Me.rbBlackBackground.Checked = True
        Me.rbBlackBackground.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbBlackBackground.Location = New System.Drawing.Point(18, 23)
        Me.rbBlackBackground.Name = "rbBlackBackground"
        Me.rbBlackBackground.Size = New System.Drawing.Size(181, 21)
        Me.rbBlackBackground.TabIndex = 0
        Me.rbBlackBackground.TabStop = True
        Me.rbBlackBackground.Text = "Black Background (Default)"
        Me.rbBlackBackground.UseVisualStyleBackColor = True
        '
        'gbColors
        '
        Me.gbColors.Controls.Add(Me.rbBlackText)
        Me.gbColors.Controls.Add(Me.rbOrangeText)
        Me.gbColors.Controls.Add(Me.rbGreenText)
        Me.gbColors.Controls.Add(Me.rbYellowText)
        Me.gbColors.Controls.Add(Me.rbWhiteText)
        Me.gbColors.Controls.Add(Me.rbRedText)
        Me.gbColors.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbColors.Location = New System.Drawing.Point(264, 79)
        Me.gbColors.Name = "gbColors"
        Me.gbColors.Size = New System.Drawing.Size(199, 170)
        Me.gbColors.TabIndex = 20
        Me.gbColors.TabStop = False
        Me.gbColors.Text = "Text Color Options"
        '
        'rbBlackText
        '
        Me.rbBlackText.AutoSize = True
        Me.rbBlackText.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbBlackText.Location = New System.Drawing.Point(8, 139)
        Me.rbBlackText.Name = "rbBlackText"
        Me.rbBlackText.Size = New System.Drawing.Size(82, 21)
        Me.rbBlackText.TabIndex = 13
        Me.rbBlackText.TabStop = True
        Me.rbBlackText.Text = "Black Text"
        Me.rbBlackText.UseVisualStyleBackColor = True
        '
        'rbOrangeText
        '
        Me.rbOrangeText.AutoSize = True
        Me.rbOrangeText.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbOrangeText.ForeColor = System.Drawing.Color.Orange
        Me.rbOrangeText.Location = New System.Drawing.Point(8, 116)
        Me.rbOrangeText.Name = "rbOrangeText"
        Me.rbOrangeText.Size = New System.Drawing.Size(97, 21)
        Me.rbOrangeText.TabIndex = 12
        Me.rbOrangeText.TabStop = True
        Me.rbOrangeText.Text = "Orange Text"
        Me.rbOrangeText.UseVisualStyleBackColor = True
        '
        'rbGreenText
        '
        Me.rbGreenText.AutoSize = True
        Me.rbGreenText.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbGreenText.ForeColor = System.Drawing.Color.Green
        Me.rbGreenText.Location = New System.Drawing.Point(8, 93)
        Me.rbGreenText.Name = "rbGreenText"
        Me.rbGreenText.Size = New System.Drawing.Size(88, 21)
        Me.rbGreenText.TabIndex = 11
        Me.rbGreenText.TabStop = True
        Me.rbGreenText.Text = "Green Text"
        Me.rbGreenText.UseVisualStyleBackColor = True
        '
        'rbYellowText
        '
        Me.rbYellowText.AutoSize = True
        Me.rbYellowText.Checked = True
        Me.rbYellowText.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbYellowText.ForeColor = System.Drawing.Color.Gold
        Me.rbYellowText.Location = New System.Drawing.Point(8, 24)
        Me.rbYellowText.Name = "rbYellowText"
        Me.rbYellowText.Size = New System.Drawing.Size(146, 21)
        Me.rbYellowText.TabIndex = 10
        Me.rbYellowText.TabStop = True
        Me.rbYellowText.Text = "Yellow Text  (Default)"
        Me.rbYellowText.UseVisualStyleBackColor = True
        '
        'rbWhiteText
        '
        Me.rbWhiteText.AutoSize = True
        Me.rbWhiteText.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbWhiteText.Location = New System.Drawing.Point(8, 70)
        Me.rbWhiteText.Name = "rbWhiteText"
        Me.rbWhiteText.Size = New System.Drawing.Size(86, 21)
        Me.rbWhiteText.TabIndex = 9
        Me.rbWhiteText.TabStop = True
        Me.rbWhiteText.Text = "White Text"
        Me.rbWhiteText.UseVisualStyleBackColor = True
        '
        'rbRedText
        '
        Me.rbRedText.AutoSize = True
        Me.rbRedText.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbRedText.ForeColor = System.Drawing.Color.Red
        Me.rbRedText.Location = New System.Drawing.Point(8, 47)
        Me.rbRedText.Name = "rbRedText"
        Me.rbRedText.Size = New System.Drawing.Size(76, 21)
        Me.rbRedText.TabIndex = 8
        Me.rbRedText.TabStop = True
        Me.rbRedText.Text = "Red Text"
        Me.rbRedText.UseVisualStyleBackColor = True
        '
        'tbShiftStats
        '
        Me.tbShiftStats.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.tbShiftStats.Controls.Add(Me.GroupBox2)
        Me.tbShiftStats.Controls.Add(Me.Label16)
        Me.tbShiftStats.Controls.Add(Me.Label17)
        Me.tbShiftStats.Controls.Add(Me.Label18)
        Me.tbShiftStats.Controls.Add(Me.btnStatsClearAll)
        Me.tbShiftStats.Controls.Add(Me.txtStat14)
        Me.tbShiftStats.Controls.Add(Me.txtStat13)
        Me.tbShiftStats.Controls.Add(Me.txtStat12)
        Me.tbShiftStats.Controls.Add(Me.txtStat10)
        Me.tbShiftStats.Controls.Add(Me.txtStat11)
        Me.tbShiftStats.Controls.Add(Me.txtStat9)
        Me.tbShiftStats.Controls.Add(Me.txtStat8)
        Me.tbShiftStats.Controls.Add(Me.txtStat7)
        Me.tbShiftStats.Controls.Add(Me.txtStat6)
        Me.tbShiftStats.Controls.Add(Me.txtStat5)
        Me.tbShiftStats.Controls.Add(Me.txtStat3)
        Me.tbShiftStats.Controls.Add(Me.txtStat4)
        Me.tbShiftStats.Controls.Add(Me.txtStat2)
        Me.tbShiftStats.Controls.Add(Me.txtStat1)
        Me.tbShiftStats.Controls.Add(Me.Panel5)
        Me.tbShiftStats.Location = New System.Drawing.Point(4, 22)
        Me.tbShiftStats.Name = "tbShiftStats"
        Me.tbShiftStats.Size = New System.Drawing.Size(693, 320)
        Me.tbShiftStats.TabIndex = 6
        Me.tbShiftStats.Text = "Shift Stats"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtStat15)
        Me.GroupBox2.Controls.Add(Me.txtStat16)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(164, 219)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(162, 76)
        Me.GroupBox2.TabIndex = 74
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Courts"
        '
        'txtStat15
        '
        Me.txtStat15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStat15.Location = New System.Drawing.Point(14, 19)
        Me.txtStat15.Name = "txtStat15"
        Me.txtStat15.Size = New System.Drawing.Size(135, 22)
        Me.txtStat15.TabIndex = 72
        '
        'txtStat16
        '
        Me.txtStat16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStat16.Location = New System.Drawing.Point(14, 45)
        Me.txtStat16.Name = "txtStat16"
        Me.txtStat16.Size = New System.Drawing.Size(135, 22)
        Me.txtStat16.TabIndex = 73
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label16.Location = New System.Drawing.Point(417, 198)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(196, 42)
        Me.Label16.TabIndex = 71
        Me.Label16.Text = "Please restart DailyLog for " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "changes to take effect."
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(359, 154)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(310, 42)
        Me.Label17.TabIndex = 70
        Me.Label17.Text = "Contact your supervisor before making any" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "changes to these collected stats."
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(337, 98)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(348, 51)
        Me.Label18.TabIndex = 69
        Me.Label18.Text = "Shift Activities here will be your selections on the main log," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "daily printout an" &
    "d monthly stats. These are the statistics" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "your agency collects."
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnStatsClearAll
        '
        Me.btnStatsClearAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStatsClearAll.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStatsClearAll.Location = New System.Drawing.Point(446, 250)
        Me.btnStatsClearAll.Name = "btnStatsClearAll"
        Me.btnStatsClearAll.Size = New System.Drawing.Size(120, 36)
        Me.btnStatsClearAll.TabIndex = 66
        Me.btnStatsClearAll.Text = "Clear All"
        Me.btnStatsClearAll.UseVisualStyleBackColor = True
        '
        'txtStat14
        '
        Me.txtStat14.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStat14.Location = New System.Drawing.Point(179, 185)
        Me.txtStat14.Name = "txtStat14"
        Me.txtStat14.Size = New System.Drawing.Size(135, 25)
        Me.txtStat14.TabIndex = 65
        '
        'txtStat13
        '
        Me.txtStat13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStat13.Location = New System.Drawing.Point(179, 159)
        Me.txtStat13.Name = "txtStat13"
        Me.txtStat13.Size = New System.Drawing.Size(135, 25)
        Me.txtStat13.TabIndex = 64
        '
        'txtStat12
        '
        Me.txtStat12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStat12.Location = New System.Drawing.Point(179, 133)
        Me.txtStat12.Name = "txtStat12"
        Me.txtStat12.Size = New System.Drawing.Size(135, 25)
        Me.txtStat12.TabIndex = 63
        '
        'txtStat10
        '
        Me.txtStat10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStat10.Location = New System.Drawing.Point(179, 81)
        Me.txtStat10.Name = "txtStat10"
        Me.txtStat10.Size = New System.Drawing.Size(135, 25)
        Me.txtStat10.TabIndex = 61
        '
        'txtStat11
        '
        Me.txtStat11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStat11.Location = New System.Drawing.Point(179, 107)
        Me.txtStat11.Name = "txtStat11"
        Me.txtStat11.Size = New System.Drawing.Size(135, 25)
        Me.txtStat11.TabIndex = 62
        '
        'txtStat9
        '
        Me.txtStat9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStat9.Location = New System.Drawing.Point(23, 292)
        Me.txtStat9.Name = "txtStat9"
        Me.txtStat9.Size = New System.Drawing.Size(135, 25)
        Me.txtStat9.TabIndex = 60
        '
        'txtStat8
        '
        Me.txtStat8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStat8.Location = New System.Drawing.Point(23, 264)
        Me.txtStat8.Name = "txtStat8"
        Me.txtStat8.Size = New System.Drawing.Size(135, 25)
        Me.txtStat8.TabIndex = 59
        '
        'txtStat7
        '
        Me.txtStat7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStat7.Location = New System.Drawing.Point(23, 236)
        Me.txtStat7.Name = "txtStat7"
        Me.txtStat7.Size = New System.Drawing.Size(135, 25)
        Me.txtStat7.TabIndex = 58
        '
        'txtStat6
        '
        Me.txtStat6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStat6.Location = New System.Drawing.Point(23, 210)
        Me.txtStat6.Name = "txtStat6"
        Me.txtStat6.Size = New System.Drawing.Size(135, 25)
        Me.txtStat6.TabIndex = 57
        '
        'txtStat5
        '
        Me.txtStat5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStat5.Location = New System.Drawing.Point(23, 184)
        Me.txtStat5.Name = "txtStat5"
        Me.txtStat5.Size = New System.Drawing.Size(135, 25)
        Me.txtStat5.TabIndex = 56
        '
        'txtStat3
        '
        Me.txtStat3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStat3.Location = New System.Drawing.Point(23, 132)
        Me.txtStat3.Name = "txtStat3"
        Me.txtStat3.Size = New System.Drawing.Size(135, 25)
        Me.txtStat3.TabIndex = 54
        '
        'txtStat4
        '
        Me.txtStat4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStat4.Location = New System.Drawing.Point(23, 158)
        Me.txtStat4.Name = "txtStat4"
        Me.txtStat4.Size = New System.Drawing.Size(135, 25)
        Me.txtStat4.TabIndex = 55
        '
        'txtStat2
        '
        Me.txtStat2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStat2.Location = New System.Drawing.Point(23, 106)
        Me.txtStat2.Name = "txtStat2"
        Me.txtStat2.Size = New System.Drawing.Size(135, 25)
        Me.txtStat2.TabIndex = 53
        '
        'txtStat1
        '
        Me.txtStat1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStat1.Location = New System.Drawing.Point(23, 80)
        Me.txtStat1.Name = "txtStat1"
        Me.txtStat1.Size = New System.Drawing.Size(135, 25)
        Me.txtStat1.TabIndex = 52
        '
        'Panel5
        '
        Me.Panel5.BackgroundImage = Global.DailyLog.My.Resources.Resources.Options_background_2018
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(690, 75)
        Me.Panel5.TabIndex = 67
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 37)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Shift Stats"
        '
        'tbQuickPicks
        '
        Me.tbQuickPicks.Controls.Add(Me.GroupBox4)
        Me.tbQuickPicks.Controls.Add(Me.Label7)
        Me.tbQuickPicks.Controls.Add(Me.Panel6)
        Me.tbQuickPicks.Location = New System.Drawing.Point(4, 22)
        Me.tbQuickPicks.Name = "tbQuickPicks"
        Me.tbQuickPicks.Size = New System.Drawing.Size(693, 320)
        Me.tbQuickPicks.TabIndex = 7
        Me.tbQuickPicks.Text = "Quick Picks"
        Me.tbQuickPicks.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.btnQuickPickDown)
        Me.GroupBox4.Controls.Add(Me.btnQuickPickUp)
        Me.GroupBox4.Controls.Add(Me.lvCallQuickPick)
        Me.GroupBox4.Controls.Add(Me.txtCallQuickNotes)
        Me.GroupBox4.Controls.Add(Me.btnDeleteCallQuickNotes)
        Me.GroupBox4.Controls.Add(Me.btnAddCallQuickNotes)
        Me.GroupBox4.Location = New System.Drawing.Point(33, 97)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(627, 214)
        Me.GroupBox4.TabIndex = 70
        Me.GroupBox4.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(502, 142)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 17)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "Move item DOWN"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(502, 104)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 17)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "Move item UP"
        '
        'btnQuickPickDown
        '
        Me.btnQuickPickDown.FlatAppearance.BorderSize = 0
        Me.btnQuickPickDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuickPickDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnQuickPickDown.Image = Global.DailyLog.My.Resources.Resources.arrow_down
        Me.btnQuickPickDown.Location = New System.Drawing.Point(470, 133)
        Me.btnQuickPickDown.Name = "btnQuickPickDown"
        Me.btnQuickPickDown.Size = New System.Drawing.Size(32, 32)
        Me.btnQuickPickDown.TabIndex = 4
        Me.btnQuickPickDown.UseVisualStyleBackColor = True
        '
        'btnQuickPickUp
        '
        Me.btnQuickPickUp.FlatAppearance.BorderSize = 0
        Me.btnQuickPickUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuickPickUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnQuickPickUp.Image = Global.DailyLog.My.Resources.Resources.arrow_up
        Me.btnQuickPickUp.Location = New System.Drawing.Point(470, 95)
        Me.btnQuickPickUp.Name = "btnQuickPickUp"
        Me.btnQuickPickUp.Size = New System.Drawing.Size(32, 32)
        Me.btnQuickPickUp.TabIndex = 3
        Me.btnQuickPickUp.UseVisualStyleBackColor = True
        '
        'lvCallQuickPick
        '
        Me.lvCallQuickPick.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvCallQuickPick.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lvCallQuickPick.HideSelection = False
        Me.lvCallQuickPick.Location = New System.Drawing.Point(15, 47)
        Me.lvCallQuickPick.Name = "lvCallQuickPick"
        Me.lvCallQuickPick.Size = New System.Drawing.Size(435, 143)
        Me.lvCallQuickPick.TabIndex = 50
        Me.lvCallQuickPick.UseCompatibleStateImageBehavior = False
        '
        'txtCallQuickNotes
        '
        Me.txtCallQuickNotes.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCallQuickNotes.Location = New System.Drawing.Point(15, 19)
        Me.txtCallQuickNotes.Name = "txtCallQuickNotes"
        Me.txtCallQuickNotes.Size = New System.Drawing.Size(435, 25)
        Me.txtCallQuickNotes.TabIndex = 0
        '
        'btnDeleteCallQuickNotes
        '
        Me.btnDeleteCallQuickNotes.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteCallQuickNotes.Location = New System.Drawing.Point(470, 48)
        Me.btnDeleteCallQuickNotes.Name = "btnDeleteCallQuickNotes"
        Me.btnDeleteCallQuickNotes.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteCallQuickNotes.TabIndex = 2
        Me.btnDeleteCallQuickNotes.Text = "Delete"
        Me.btnDeleteCallQuickNotes.UseVisualStyleBackColor = True
        '
        'btnAddCallQuickNotes
        '
        Me.btnAddCallQuickNotes.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCallQuickNotes.Location = New System.Drawing.Point(470, 19)
        Me.btnAddCallQuickNotes.Name = "btnAddCallQuickNotes"
        Me.btnAddCallQuickNotes.Size = New System.Drawing.Size(75, 23)
        Me.btnAddCallQuickNotes.TabIndex = 1
        Me.btnAddCallQuickNotes.Text = "Add"
        Me.btnAddCallQuickNotes.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(58, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(578, 17)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "Quick Picks are the items in the dropdown box in the Call Details screen. You can" &
    " edit the list here."
        '
        'Panel6
        '
        Me.Panel6.BackgroundImage = Global.DailyLog.My.Resources.Resources.Options_background_2018
        Me.Panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(690, 75)
        Me.Panel6.TabIndex = 68
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(35, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(339, 37)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Call Details Quick Selection"
        '
        'btnCancel
        '
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(611, 333)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(120, 25)
        Me.btnCancel.TabIndex = 34
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOK.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Location = New System.Drawing.Point(484, 333)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(120, 25)
        Me.btnOK.TabIndex = 33
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'tvMain
        '
        Me.tvMain.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tvMain.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tvMain.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvMain.HotTracking = True
        Me.tvMain.Indent = 25
        Me.tvMain.LabelEdit = True
        Me.tvMain.Location = New System.Drawing.Point(1, 16)
        Me.tvMain.Name = "tvMain"
        TreeNode25.Name = "Node0"
        TreeNode25.Text = "Agency Information"
        TreeNode26.Name = "Node1"
        TreeNode26.Text = "Global Options"
        TreeNode27.Name = "Node2"
        TreeNode27.Text = "Backup/Restore"
        TreeNode28.Name = "Node3"
        TreeNode28.Text = "Theme Preferences"
        TreeNode29.Name = "Node4"
        TreeNode29.Text = "Shift Stats"
        TreeNode30.Name = "Node5"
        TreeNode30.Text = "Edit Quick Picks"
        Me.tvMain.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode25, TreeNode26, TreeNode27, TreeNode28, TreeNode29, TreeNode30})
        Me.tvMain.ShowNodeToolTips = True
        Me.tvMain.Size = New System.Drawing.Size(181, 168)
        Me.tvMain.TabIndex = 38
        '
        'tmrChangeBackgroundTheme
        '
        Me.tmrChangeBackgroundTheme.Enabled = True
        Me.tmrChangeBackgroundTheme.Interval = 100000000
        '
        'btnApply
        '
        Me.btnApply.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnApply.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApply.Location = New System.Drawing.Point(737, 333)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(120, 25)
        Me.btnApply.TabIndex = 35
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'frmOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(878, 368)
        Me.Controls.Add(Me.tvMain)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.tcMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmOptions"
        Me.TopMost = True
        Me.tcMain.ResumeLayout(False)
        Me.tbAgency.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tbOptions.ResumeLayout(False)
        Me.tbOptions.PerformLayout()
        Me.gbGeneralOptions.ResumeLayout(False)
        Me.gbGeneralOptions.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.tbBackup.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.gb3.ResumeLayout(False)
        Me.gb3.PerformLayout()
        Me.tbTheme.ResumeLayout(False)
        Me.tbTheme.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.gbBackgroundColor.ResumeLayout(False)
        Me.gbBackgroundColor.PerformLayout()
        Me.gbColors.ResumeLayout(False)
        Me.gbColors.PerformLayout()
        Me.tbShiftStats.ResumeLayout(False)
        Me.tbShiftStats.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.tbQuickPicks.ResumeLayout(False)
        Me.tbQuickPicks.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tcMain As System.Windows.Forms.TabControl
    Friend WithEvents tbAgency As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tbOptions As System.Windows.Forms.TabPage
    Friend WithEvents tbBackup As System.Windows.Forms.TabPage
    Friend WithEvents gb3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblRestore As System.Windows.Forms.Label
    Friend WithEvents lblBackup As System.Windows.Forms.Label
    Friend WithEvents btnRestoreFiles As System.Windows.Forms.Button
    Friend WithEvents btnBackupFiles As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents lblInstructions As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents tvMain As System.Windows.Forms.TreeView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents OptionsBackgroundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents tbTheme As System.Windows.Forms.TabPage
    Friend WithEvents gbBackgroundColor As System.Windows.Forms.GroupBox
    Friend WithEvents rbRedBackground As System.Windows.Forms.RadioButton
    Friend WithEvents rbBlueBackground As System.Windows.Forms.RadioButton
    Friend WithEvents rbOrangeBackground As System.Windows.Forms.RadioButton
    Friend WithEvents rbOliveGreenBackground As System.Windows.Forms.RadioButton
    Friend WithEvents rbBlackBackground As System.Windows.Forms.RadioButton
    Friend WithEvents gbColors As System.Windows.Forms.GroupBox
    Friend WithEvents rbBlackText As System.Windows.Forms.RadioButton
    Friend WithEvents rbOrangeText As System.Windows.Forms.RadioButton
    Friend WithEvents rbGreenText As System.Windows.Forms.RadioButton
    Friend WithEvents rbYellowText As System.Windows.Forms.RadioButton
    Friend WithEvents rbWhiteText As System.Windows.Forms.RadioButton
    Friend WithEvents rbRedText As System.Windows.Forms.RadioButton
    Friend WithEvents rbWhiteBackground As System.Windows.Forms.RadioButton
    Friend WithEvents tmrChangeBackgroundTheme As System.Windows.Forms.Timer
    Friend WithEvents rbGreyBackground As System.Windows.Forms.RadioButton
    Friend WithEvents rbLightBlueBackground As System.Windows.Forms.RadioButton
    Friend WithEvents rbDarkRedBackground As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPOSTID As System.Windows.Forms.TextBox
    Friend WithEvents lblPOSTID As System.Windows.Forms.Label
    Friend WithEvents txtAddURL As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtAddFax As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtAddPhone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtAddCounty As System.Windows.Forms.TextBox
    Friend WithEvents lblCounty As System.Windows.Forms.Label
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents txtAddState As System.Windows.Forms.TextBox
    Friend WithEvents lblURL As System.Windows.Forms.Label
    Friend WithEvents lblFax As System.Windows.Forms.Label
    Friend WithEvents lblORI As System.Windows.Forms.Label
    Friend WithEvents txtAddORI As System.Windows.Forms.TextBox
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents lblZip As System.Windows.Forms.Label
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents txtAddZip As System.Windows.Forms.TextBox
    Friend WithEvents txtAddCity As System.Windows.Forms.TextBox
    Friend WithEvents txtAddAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtAgency As System.Windows.Forms.Label
    Friend WithEvents lblArea As System.Windows.Forms.Label
    Friend WithEvents txtAddAgency As System.Windows.Forms.TextBox
    Friend WithEvents txtAddSupervisor As System.Windows.Forms.TextBox
    Friend WithEvents txtAddArea As System.Windows.Forms.TextBox
    Friend WithEvents lblSupervisor As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents txtAddID As System.Windows.Forms.TextBox
    Friend WithEvents txtAddOfficer As System.Windows.Forms.TextBox
    Friend WithEvents lblOfficer As System.Windows.Forms.Label
    Friend WithEvents tbShiftStats As System.Windows.Forms.TabPage
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents btnStatsClearAll As System.Windows.Forms.Button
    Friend WithEvents txtStat14 As System.Windows.Forms.TextBox
    Friend WithEvents txtStat13 As System.Windows.Forms.TextBox
    Friend WithEvents txtStat12 As System.Windows.Forms.TextBox
    Friend WithEvents txtStat10 As System.Windows.Forms.TextBox
    Friend WithEvents txtStat11 As System.Windows.Forms.TextBox
    Friend WithEvents txtStat9 As System.Windows.Forms.TextBox
    Friend WithEvents txtStat8 As System.Windows.Forms.TextBox
    Friend WithEvents txtStat7 As System.Windows.Forms.TextBox
    Friend WithEvents txtStat6 As System.Windows.Forms.TextBox
    Friend WithEvents txtStat5 As System.Windows.Forms.TextBox
    Friend WithEvents txtStat3 As System.Windows.Forms.TextBox
    Friend WithEvents txtStat4 As System.Windows.Forms.TextBox
    Friend WithEvents txtStat2 As System.Windows.Forms.TextBox
    Friend WithEvents txtStat1 As System.Windows.Forms.TextBox
    Friend WithEvents txtStat16 As System.Windows.Forms.TextBox
    Friend WithEvents txtStat15 As System.Windows.Forms.TextBox
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents gbGeneralOptions As System.Windows.Forms.GroupBox
    Friend WithEvents cbNightMode As System.Windows.Forms.CheckBox
    Friend WithEvents cbShowTotalMileage As System.Windows.Forms.CheckBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents tbQuickPicks As System.Windows.Forms.TabPage
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnQuickPickDown As System.Windows.Forms.Button
    Friend WithEvents btnQuickPickUp As System.Windows.Forms.Button
    Friend WithEvents lvCallQuickPick As System.Windows.Forms.ListView
    Friend WithEvents txtCallQuickNotes As System.Windows.Forms.TextBox
    Friend WithEvents btnDeleteCallQuickNotes As System.Windows.Forms.Button
    Friend WithEvents btnAddCallQuickNotes As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
