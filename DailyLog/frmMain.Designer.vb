<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim lblStartMiles As System.Windows.Forms.Label
        Dim lblEndMiles As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.lblTime = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabDailyLog = New System.Windows.Forms.TabPage()
        Me.gbShiftNotes = New System.Windows.Forms.GroupBox()
        Me.txtShiftNotes = New System.Windows.Forms.TextBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnToday = New System.Windows.Forms.Button()
        Me.btnTheme = New System.Windows.Forms.Button()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnOptions = New System.Windows.Forms.Button()
        Me.lvMain = New System.Windows.Forms.ListView()
        Me.lvColumnNumber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvColumnStart = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvColumnEnd = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvColumnTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvColumnLocCallType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvColumnDescriptionNotes = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvColumnCase = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.gbRadar = New System.Windows.Forms.GroupBox()
        Me.cbRadarVer = New System.Windows.Forms.CheckBox()
        Me.gbMileage = New System.Windows.Forms.GroupBox()
        Me.txtEndMiles = New System.Windows.Forms.TextBox()
        Me.txtStartMiles = New System.Windows.Forms.TextBox()
        Me.gbShiftStats = New System.Windows.Forms.GroupBox()
        Me.cmbStat14County = New System.Windows.Forms.ComboBox()
        Me.cmbStat13County = New System.Windows.Forms.ComboBox()
        Me.cmbStat12County = New System.Windows.Forms.ComboBox()
        Me.cmbStat11County = New System.Windows.Forms.ComboBox()
        Me.cmbStat10County = New System.Windows.Forms.ComboBox()
        Me.cmbStat9County = New System.Windows.Forms.ComboBox()
        Me.cmbStat8County = New System.Windows.Forms.ComboBox()
        Me.cmbStat7County = New System.Windows.Forms.ComboBox()
        Me.cmbStat6County = New System.Windows.Forms.ComboBox()
        Me.cmbStat5County = New System.Windows.Forms.ComboBox()
        Me.cmbStat4County = New System.Windows.Forms.ComboBox()
        Me.cmbStat3County = New System.Windows.Forms.ComboBox()
        Me.cmbStat2County = New System.Windows.Forms.ComboBox()
        Me.cmbStat1County = New System.Windows.Forms.ComboBox()
        Me.cmbStat14City = New System.Windows.Forms.ComboBox()
        Me.cmbStat13City = New System.Windows.Forms.ComboBox()
        Me.cmbStat12City = New System.Windows.Forms.ComboBox()
        Me.cmbStat11City = New System.Windows.Forms.ComboBox()
        Me.cmbStat10City = New System.Windows.Forms.ComboBox()
        Me.cmbStat9City = New System.Windows.Forms.ComboBox()
        Me.cmbStat8City = New System.Windows.Forms.ComboBox()
        Me.cmbStat7City = New System.Windows.Forms.ComboBox()
        Me.cmbStat6City = New System.Windows.Forms.ComboBox()
        Me.cmbStat5City = New System.Windows.Forms.ComboBox()
        Me.cmbStat4City = New System.Windows.Forms.ComboBox()
        Me.cmbStat3City = New System.Windows.Forms.ComboBox()
        Me.cmbStat2City = New System.Windows.Forms.ComboBox()
        Me.cmbStat1City = New System.Windows.Forms.ComboBox()
        Me.cmbStat16County = New System.Windows.Forms.ComboBox()
        Me.cmbStat15County = New System.Windows.Forms.ComboBox()
        Me.cmbStat15City = New System.Windows.Forms.ComboBox()
        Me.cmbObligatedCounty = New System.Windows.Forms.ComboBox()
        Me.cmbNonObligatedCounty = New System.Windows.Forms.ComboBox()
        Me.cmbNonObligatedCity = New System.Windows.Forms.ComboBox()
        Me.cmbObligatedCity = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblTotalCountyTime = New System.Windows.Forms.Label()
        Me.lblTotalStats = New System.Windows.Forms.Label()
        Me.lblTotalHours = New System.Windows.Forms.Label()
        Me.lblTotalCityTime = New System.Windows.Forms.Label()
        Me.lblTotalTimes = New System.Windows.Forms.Label()
        Me.txtStat16 = New System.Windows.Forms.Label()
        Me.txtStat15 = New System.Windows.Forms.Label()
        Me.lblObligated = New System.Windows.Forms.Label()
        Me.lblNonObligated = New System.Windows.Forms.Label()
        Me.txtStat14 = New System.Windows.Forms.Label()
        Me.txtStat13 = New System.Windows.Forms.Label()
        Me.txtStat12 = New System.Windows.Forms.Label()
        Me.txtStat11 = New System.Windows.Forms.Label()
        Me.txtStat10 = New System.Windows.Forms.Label()
        Me.txtStat9 = New System.Windows.Forms.Label()
        Me.txtStat8 = New System.Windows.Forms.Label()
        Me.txtStat7 = New System.Windows.Forms.Label()
        Me.txtStat6 = New System.Windows.Forms.Label()
        Me.txtStat5 = New System.Windows.Forms.Label()
        Me.txtStat4 = New System.Windows.Forms.Label()
        Me.txtStat3 = New System.Windows.Forms.Label()
        Me.txtStat2 = New System.Windows.Forms.Label()
        Me.txtStat1 = New System.Windows.Forms.Label()
        Me.lblCity1 = New System.Windows.Forms.Label()
        Me.lblCounty1 = New System.Windows.Forms.Label()
        Me.lblCity2 = New System.Windows.Forms.Label()
        Me.lblCounty2 = New System.Windows.Forms.Label()
        Me.m_Menu = New System.Windows.Forms.MenuStrip()
        Me.mFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mNew_File = New System.Windows.Forms.ToolStripMenuItem()
        Me.mNew_Patrol = New System.Windows.Forms.ToolStripMenuItem()
        Me.mNewLogEntryOnPreviousDate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mSave_File = New System.Windows.Forms.ToolStripMenuItem()
        Me.mOpen_File = New System.Windows.Forms.ToolStripMenuItem()
        Me.mSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.mExit_File = New System.Windows.Forms.ToolStripMenuItem()
        Me.mTools = New System.Windows.Forms.ToolStripMenuItem()
        Me.mOptions_Tools = New System.Windows.Forms.ToolStripMenuItem()
        Me.mStats_Tools = New System.Windows.Forms.ToolStripMenuItem()
        Me.mEditCallTypes_Tools = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.mDayNight_Tools = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mViewLogsHTML_Tools = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mDeleteSingleEntry_Tools = New System.Windows.Forms.ToolStripMenuItem()
        Me.mClearEntireLog_Tools = New System.Windows.Forms.ToolStripMenuItem()
        Me.mHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mAbout_Help = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_AppDataFolder = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblAgency = New System.Windows.Forms.Label()
        Me.lblOfficer = New System.Windows.Forms.Label()
        Me.lblExplanation = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblCounty = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.lblSupervisor = New System.Windows.Forms.Label()
        Me.TabReporting = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Narrative = New System.Windows.Forms.TabControl()
        Me.TabCaseDetails = New System.Windows.Forms.TabPage()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtPrimaryID2_ = New System.Windows.Forms.TextBox()
        Me.CbNoVideo2_ = New System.Windows.Forms.CheckBox()
        Me.CbVideoAttached2_ = New System.Windows.Forms.CheckBox()
        Me.TxtSecondaryOfficer1_ = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtPrimaryID1_ = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CbNoVideo1_ = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CbCivilWarrant_ = New System.Windows.Forms.CheckBox()
        Me.TxtCounts3_ = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtCounts2_ = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtCounts1_ = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CbCrimWarrant_ = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LblLawCode1_ = New System.Windows.Forms.Label()
        Me.TxtLawCode2_ = New System.Windows.Forms.TextBox()
        Me.TxtLawCode3_ = New System.Windows.Forms.TextBox()
        Me.TxtLawCode1_ = New System.Windows.Forms.TextBox()
        Me.CbDocumentation_ = New System.Windows.Forms.CheckBox()
        Me.CbNonCrim_ = New System.Windows.Forms.CheckBox()
        Me.CbInfraction_ = New System.Windows.Forms.CheckBox()
        Me.CbMisd_ = New System.Windows.Forms.CheckBox()
        Me.CbFelony_ = New System.Windows.Forms.CheckBox()
        Me.TxtOffence3_ = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtOffence2_ = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtOffence1_ = New System.Windows.Forms.TextBox()
        Me.LblCharges = New System.Windows.Forms.Label()
        Me.CbVideoAttached1_ = New System.Windows.Forms.CheckBox()
        Me.CmbAdditionalReports = New System.Windows.Forms.ComboBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.TxtOffence_Date = New System.Windows.Forms.TextBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.TxtIncidentAddress = New System.Windows.Forms.TextBox()
        Me.TxtPrimaryOfficer_ = New System.Windows.Forms.TextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Txt_Incident_time = New System.Windows.Forms.TextBox()
        Me.LblDateTimeReporting = New System.Windows.Forms.Label()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.Txt_Case = New System.Windows.Forms.TextBox()
        Me.lblCase = New System.Windows.Forms.Label()
        Me.TabPerson1 = New System.Windows.Forms.TabPage()
        Me.TxtScarsTats1_ = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TxtOccupation1_ = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TxtPhone1_ = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxtCitizenship1_ = New System.Windows.Forms.TextBox()
        Me.TxtPlaceofBirth1_ = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblAge1_ = New System.Windows.Forms.Label()
        Me.TxtAge1_ = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.CmbDrugAlcohol1_ = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.CmbEyes1_ = New System.Windows.Forms.ComboBox()
        Me.lblEyes1_ = New System.Windows.Forms.Label()
        Me.CmbHair1_ = New System.Windows.Forms.ComboBox()
        Me.CmbState1_ = New System.Windows.Forms.ComboBox()
        Me.CmbHeight1_ = New System.Windows.Forms.ComboBox()
        Me.CmbSex1_ = New System.Windows.Forms.ComboBox()
        Me.CmbRace1_ = New System.Windows.Forms.ComboBox()
        Me.RbOther1_ = New System.Windows.Forms.RadioButton()
        Me.RbSuspect1_ = New System.Windows.Forms.RadioButton()
        Me.RbWitness1_ = New System.Windows.Forms.RadioButton()
        Me.RbVictim1_ = New System.Windows.Forms.RadioButton()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Txtname1_ = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.TxtPersonAddress1_ = New System.Windows.Forms.TextBox()
        Me.LblWeight1 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TxtDOB1_ = New System.Windows.Forms.TextBox()
        Me.TxtID1_ = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtWeight1 = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TxtAlias1_ = New System.Windows.Forms.TextBox()
        Me.TabPerson2 = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.ComboBox7 = New System.Windows.Forms.ComboBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TabVehicle1 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TxtVehicle2VIN_ = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.RbVehicle2Other_ = New System.Windows.Forms.RadioButton()
        Me.RbVehicle2Suspect_ = New System.Windows.Forms.RadioButton()
        Me.RbVehicle2Witness_ = New System.Windows.Forms.RadioButton()
        Me.RbVehicle2Victim_ = New System.Windows.Forms.RadioButton()
        Me.TxtVehicle2Identifying_ = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.CmbV2Color_ = New System.Windows.Forms.ComboBox()
        Me.CmbStyle2_ = New System.Windows.Forms.ComboBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.TxtV2Year_ = New System.Windows.Forms.TextBox()
        Me.CmbVeh2Disposition_ = New System.Windows.Forms.ComboBox()
        Me.CmbV2Make_ = New System.Windows.Forms.ComboBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.V2model_ = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtVehicle1VIN_ = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.RbVehicle1Other_ = New System.Windows.Forms.RadioButton()
        Me.RbVehicle1Suspect_ = New System.Windows.Forms.RadioButton()
        Me.RbVehicle1Witness_ = New System.Windows.Forms.RadioButton()
        Me.RbVehicle1Victim_ = New System.Windows.Forms.RadioButton()
        Me.TxtVehicle1Identifying_ = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.CmbV1Color_ = New System.Windows.Forms.ComboBox()
        Me.CmbStyle1_ = New System.Windows.Forms.ComboBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.TxtV1Year_ = New System.Windows.Forms.TextBox()
        Me.CmbVeh1Disposition_ = New System.Windows.Forms.ComboBox()
        Me.CmbV1Make_ = New System.Windows.Forms.ComboBox()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.V1model_ = New System.Windows.Forms.TextBox()
        Me.TabVehicle2 = New System.Windows.Forms.TabPage()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.TabNarrative = New System.Windows.Forms.TabPage()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblFileDate = New System.Windows.Forms.Label()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.tmrStats = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnFwd = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        lblStartMiles = New System.Windows.Forms.Label()
        lblEndMiles = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.tabDailyLog.SuspendLayout()
        Me.gbShiftNotes.SuspendLayout()
        Me.gbRadar.SuspendLayout()
        Me.gbMileage.SuspendLayout()
        Me.gbShiftStats.SuspendLayout()
        Me.m_Menu.SuspendLayout()
        Me.TabReporting.SuspendLayout()
        Me.Narrative.SuspendLayout()
        Me.TabCaseDetails.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPerson1.SuspendLayout()
        Me.TabPerson2.SuspendLayout()
        Me.TabVehicle1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabVehicle2.SuspendLayout()
        Me.TabNarrative.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblStartMiles
        '
        lblStartMiles.AutoSize = True
        lblStartMiles.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblStartMiles.Location = New System.Drawing.Point(16, 21)
        lblStartMiles.Name = "lblStartMiles"
        lblStartMiles.Size = New System.Drawing.Size(82, 20)
        lblStartMiles.TabIndex = 0
        lblStartMiles.Text = "Start Miles:"
        '
        'lblEndMiles
        '
        lblEndMiles.AutoSize = True
        lblEndMiles.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblEndMiles.Location = New System.Drawing.Point(186, 21)
        lblEndMiles.Name = "lblEndMiles"
        lblEndMiles.Size = New System.Drawing.Size(76, 20)
        lblEndMiles.TabIndex = 2
        lblEndMiles.Text = "End Miles:"
        '
        'lblTime
        '
        Me.lblTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(996, 2)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(120, 25)
        Me.lblTime.TabIndex = 1012
        Me.lblTime.Text = "00:00:00"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tabDailyLog)
        Me.TabControl1.Controls.Add(Me.TabReporting)
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.HotTrack = True
        Me.TabControl1.Location = New System.Drawing.Point(3, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1118, 578)
        Me.TabControl1.TabIndex = 1013
        '
        'tabDailyLog
        '
        Me.tabDailyLog.AutoScroll = True
        Me.tabDailyLog.BackColor = System.Drawing.Color.White
        Me.tabDailyLog.Controls.Add(Me.gbShiftNotes)
        Me.tabDailyLog.Controls.Add(Me.btnNew)
        Me.tabDailyLog.Controls.Add(Me.btnSave)
        Me.tabDailyLog.Controls.Add(Me.btnPrint)
        Me.tabDailyLog.Controls.Add(Me.btnToday)
        Me.tabDailyLog.Controls.Add(Me.btnTheme)
        Me.tabDailyLog.Controls.Add(Me.btnOpen)
        Me.tabDailyLog.Controls.Add(Me.btnClose)
        Me.tabDailyLog.Controls.Add(Me.btnOptions)
        Me.tabDailyLog.Controls.Add(Me.lvMain)
        Me.tabDailyLog.Controls.Add(Me.gbRadar)
        Me.tabDailyLog.Controls.Add(Me.gbMileage)
        Me.tabDailyLog.Controls.Add(Me.gbShiftStats)
        Me.tabDailyLog.Controls.Add(Me.m_Menu)
        Me.tabDailyLog.Controls.Add(Me.lblPassword)
        Me.tabDailyLog.Controls.Add(Me.lblID)
        Me.tabDailyLog.Controls.Add(Me.lblVersion)
        Me.tabDailyLog.Controls.Add(Me.lblAgency)
        Me.tabDailyLog.Controls.Add(Me.lblOfficer)
        Me.tabDailyLog.Controls.Add(Me.lblExplanation)
        Me.tabDailyLog.Controls.Add(Me.lblState)
        Me.tabDailyLog.Controls.Add(Me.lblCounty)
        Me.tabDailyLog.Controls.Add(Me.lblPhone)
        Me.tabDailyLog.Controls.Add(Me.lblArea)
        Me.tabDailyLog.Controls.Add(Me.lblSupervisor)
        Me.tabDailyLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabDailyLog.Location = New System.Drawing.Point(4, 30)
        Me.tabDailyLog.Name = "tabDailyLog"
        Me.tabDailyLog.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDailyLog.Size = New System.Drawing.Size(1110, 544)
        Me.tabDailyLog.TabIndex = 0
        Me.tabDailyLog.Text = "DAILYLOG"
        '
        'gbShiftNotes
        '
        Me.gbShiftNotes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbShiftNotes.Controls.Add(Me.txtShiftNotes)
        Me.gbShiftNotes.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.gbShiftNotes.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbShiftNotes.Location = New System.Drawing.Point(79, 186)
        Me.gbShiftNotes.Name = "gbShiftNotes"
        Me.gbShiftNotes.Size = New System.Drawing.Size(500, 294)
        Me.gbShiftNotes.TabIndex = 112
        Me.gbShiftNotes.TabStop = False
        Me.gbShiftNotes.Text = "Misc Notes"
        '
        'txtShiftNotes
        '
        Me.txtShiftNotes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtShiftNotes.BackColor = System.Drawing.SystemColors.Window
        Me.txtShiftNotes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtShiftNotes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtShiftNotes.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShiftNotes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtShiftNotes.Location = New System.Drawing.Point(14, 21)
        Me.txtShiftNotes.Multiline = True
        Me.txtShiftNotes.Name = "txtShiftNotes"
        Me.txtShiftNotes.Size = New System.Drawing.Size(477, 263)
        Me.txtShiftNotes.TabIndex = 25
        '
        'btnNew
        '
        Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNew.FlatAppearance.BorderSize = 0
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Image = Global.DailyLog.My.Resources.Resources.Add_file
        Me.btnNew.Location = New System.Drawing.Point(16, 32)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(50, 50)
        Me.btnNew.TabIndex = 22
        Me.ToolTip2.SetToolTip(Me.btnNew, "Open Call Details Screen")
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Image = Global.DailyLog.My.Resources.Resources.btnSave
        Me.btnSave.Location = New System.Drawing.Point(16, 89)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(50, 50)
        Me.btnSave.TabIndex = 14
        Me.ToolTip2.SetToolTip(Me.btnSave, "Save Log File")
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.FlatAppearance.BorderSize = 0
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Image = Global.DailyLog.My.Resources.Resources.btnPrint
        Me.btnPrint.Location = New System.Drawing.Point(16, 145)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(50, 50)
        Me.btnPrint.TabIndex = 15
        Me.ToolTip2.SetToolTip(Me.btnPrint, "Print Log File")
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnToday
        '
        Me.btnToday.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnToday.FlatAppearance.BorderSize = 0
        Me.btnToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnToday.Image = Global.DailyLog.My.Resources.Resources.Today1
        Me.btnToday.Location = New System.Drawing.Point(16, 257)
        Me.btnToday.Name = "btnToday"
        Me.btnToday.Size = New System.Drawing.Size(50, 50)
        Me.btnToday.TabIndex = 24
        Me.ToolTip2.SetToolTip(Me.btnToday, "Go to Todays Log")
        Me.btnToday.UseVisualStyleBackColor = True
        '
        'btnTheme
        '
        Me.btnTheme.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTheme.FlatAppearance.BorderSize = 0
        Me.btnTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTheme.Image = Global.DailyLog.My.Resources.Resources.Night_Theme_Icon
        Me.btnTheme.Location = New System.Drawing.Point(16, 313)
        Me.btnTheme.Name = "btnTheme"
        Me.btnTheme.Size = New System.Drawing.Size(50, 50)
        Me.btnTheme.TabIndex = 18
        Me.ToolTip2.SetToolTip(Me.btnTheme, "Change Theme")
        Me.btnTheme.UseVisualStyleBackColor = True
        '
        'btnOpen
        '
        Me.btnOpen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOpen.FlatAppearance.BorderSize = 0
        Me.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpen.Image = Global.DailyLog.My.Resources.Resources.Open41
        Me.btnOpen.Location = New System.Drawing.Point(16, 201)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(50, 50)
        Me.btnOpen.TabIndex = 16
        Me.ToolTip2.SetToolTip(Me.btnOpen, "Open Log File")
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Image = Global.DailyLog.My.Resources.Resources.btnClose
        Me.btnClose.Location = New System.Drawing.Point(16, 425)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(50, 50)
        Me.btnClose.TabIndex = 17
        Me.ToolTip2.SetToolTip(Me.btnClose, "Save and Close DailyLog")
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnOptions
        '
        Me.btnOptions.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOptions.FlatAppearance.BorderSize = 0
        Me.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOptions.Image = Global.DailyLog.My.Resources.Resources.Settings
        Me.btnOptions.Location = New System.Drawing.Point(16, 369)
        Me.btnOptions.Name = "btnOptions"
        Me.btnOptions.Size = New System.Drawing.Size(50, 50)
        Me.btnOptions.TabIndex = 20
        Me.ToolTip2.SetToolTip(Me.btnOptions, "Open Program Options")
        Me.btnOptions.UseVisualStyleBackColor = True
        '
        'lvMain
        '
        Me.lvMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvMain.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lvColumnNumber, Me.lvColumnStart, Me.lvColumnEnd, Me.lvColumnTime, Me.lvColumnLocCallType, Me.lvColumnDescriptionNotes, Me.lvColumnCase})
        Me.lvMain.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvMain.FullRowSelect = True
        Me.lvMain.GridLines = True
        Me.lvMain.HideSelection = False
        Me.lvMain.Location = New System.Drawing.Point(77, 32)
        Me.lvMain.MultiSelect = False
        Me.lvMain.Name = "lvMain"
        Me.lvMain.Size = New System.Drawing.Size(1027, 150)
        Me.lvMain.TabIndex = 246
        Me.lvMain.UseCompatibleStateImageBehavior = False
        Me.lvMain.View = System.Windows.Forms.View.Details
        '
        'lvColumnNumber
        '
        Me.lvColumnNumber.Text = "#"
        Me.lvColumnNumber.Width = 35
        '
        'lvColumnStart
        '
        Me.lvColumnStart.Text = "Start"
        Me.lvColumnStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.lvColumnStart.Width = 62
        '
        'lvColumnEnd
        '
        Me.lvColumnEnd.Text = "End"
        Me.lvColumnEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.lvColumnEnd.Width = 62
        '
        'lvColumnTime
        '
        Me.lvColumnTime.Text = "Time"
        Me.lvColumnTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.lvColumnTime.Width = 62
        '
        'lvColumnLocCallType
        '
        Me.lvColumnLocCallType.Text = "Details"
        Me.lvColumnLocCallType.Width = 241
        '
        'lvColumnDescriptionNotes
        '
        Me.lvColumnDescriptionNotes.Text = "Notes"
        Me.lvColumnDescriptionNotes.Width = 397
        '
        'lvColumnCase
        '
        Me.lvColumnCase.Text = "Reference #"
        Me.lvColumnCase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.lvColumnCase.Width = 145
        '
        'gbRadar
        '
        Me.gbRadar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbRadar.Controls.Add(Me.cbRadarVer)
        Me.gbRadar.Location = New System.Drawing.Point(90, 488)
        Me.gbRadar.Name = "gbRadar"
        Me.gbRadar.Size = New System.Drawing.Size(145, 50)
        Me.gbRadar.TabIndex = 245
        Me.gbRadar.TabStop = False
        '
        'cbRadarVer
        '
        Me.cbRadarVer.AutoSize = True
        Me.cbRadarVer.BackColor = System.Drawing.Color.Transparent
        Me.cbRadarVer.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRadarVer.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbRadarVer.Location = New System.Drawing.Point(7, 19)
        Me.cbRadarVer.Name = "cbRadarVer"
        Me.cbRadarVer.Size = New System.Drawing.Size(131, 24)
        Me.cbRadarVer.TabIndex = 10005
        Me.cbRadarVer.Text = "Equip. Verified?"
        Me.ToolTip2.SetToolTip(Me.cbRadarVer, "Check if your equipment  was verified at the start of shift")
        Me.cbRadarVer.UseVisualStyleBackColor = False
        '
        'gbMileage
        '
        Me.gbMileage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbMileage.Controls.Add(Me.txtEndMiles)
        Me.gbMileage.Controls.Add(lblStartMiles)
        Me.gbMileage.Controls.Add(Me.txtStartMiles)
        Me.gbMileage.Controls.Add(lblEndMiles)
        Me.gbMileage.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbMileage.Location = New System.Drawing.Point(241, 488)
        Me.gbMileage.Name = "gbMileage"
        Me.gbMileage.Size = New System.Drawing.Size(341, 50)
        Me.gbMileage.TabIndex = 244
        Me.gbMileage.TabStop = False
        Me.gbMileage.Text = "Mileage"
        '
        'txtEndMiles
        '
        Me.txtEndMiles.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndMiles.Location = New System.Drawing.Point(261, 17)
        Me.txtEndMiles.MaxLength = 6
        Me.txtEndMiles.Name = "txtEndMiles"
        Me.txtEndMiles.Size = New System.Drawing.Size(68, 27)
        Me.txtEndMiles.TabIndex = 5
        Me.txtEndMiles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtStartMiles
        '
        Me.txtStartMiles.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStartMiles.Location = New System.Drawing.Point(98, 17)
        Me.txtStartMiles.MaxLength = 6
        Me.txtStartMiles.Name = "txtStartMiles"
        Me.txtStartMiles.Size = New System.Drawing.Size(68, 27)
        Me.txtStartMiles.TabIndex = 1
        Me.txtStartMiles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gbShiftStats
        '
        Me.gbShiftStats.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbShiftStats.Controls.Add(Me.cmbStat14County)
        Me.gbShiftStats.Controls.Add(Me.cmbStat13County)
        Me.gbShiftStats.Controls.Add(Me.cmbStat12County)
        Me.gbShiftStats.Controls.Add(Me.cmbStat11County)
        Me.gbShiftStats.Controls.Add(Me.cmbStat10County)
        Me.gbShiftStats.Controls.Add(Me.cmbStat9County)
        Me.gbShiftStats.Controls.Add(Me.cmbStat8County)
        Me.gbShiftStats.Controls.Add(Me.cmbStat7County)
        Me.gbShiftStats.Controls.Add(Me.cmbStat6County)
        Me.gbShiftStats.Controls.Add(Me.cmbStat5County)
        Me.gbShiftStats.Controls.Add(Me.cmbStat4County)
        Me.gbShiftStats.Controls.Add(Me.cmbStat3County)
        Me.gbShiftStats.Controls.Add(Me.cmbStat2County)
        Me.gbShiftStats.Controls.Add(Me.cmbStat1County)
        Me.gbShiftStats.Controls.Add(Me.cmbStat14City)
        Me.gbShiftStats.Controls.Add(Me.cmbStat13City)
        Me.gbShiftStats.Controls.Add(Me.cmbStat12City)
        Me.gbShiftStats.Controls.Add(Me.cmbStat11City)
        Me.gbShiftStats.Controls.Add(Me.cmbStat10City)
        Me.gbShiftStats.Controls.Add(Me.cmbStat9City)
        Me.gbShiftStats.Controls.Add(Me.cmbStat8City)
        Me.gbShiftStats.Controls.Add(Me.cmbStat7City)
        Me.gbShiftStats.Controls.Add(Me.cmbStat6City)
        Me.gbShiftStats.Controls.Add(Me.cmbStat5City)
        Me.gbShiftStats.Controls.Add(Me.cmbStat4City)
        Me.gbShiftStats.Controls.Add(Me.cmbStat3City)
        Me.gbShiftStats.Controls.Add(Me.cmbStat2City)
        Me.gbShiftStats.Controls.Add(Me.cmbStat1City)
        Me.gbShiftStats.Controls.Add(Me.cmbStat16County)
        Me.gbShiftStats.Controls.Add(Me.cmbStat15County)
        Me.gbShiftStats.Controls.Add(Me.cmbStat15City)
        Me.gbShiftStats.Controls.Add(Me.cmbObligatedCounty)
        Me.gbShiftStats.Controls.Add(Me.cmbNonObligatedCounty)
        Me.gbShiftStats.Controls.Add(Me.cmbNonObligatedCity)
        Me.gbShiftStats.Controls.Add(Me.cmbObligatedCity)
        Me.gbShiftStats.Controls.Add(Me.Label12)
        Me.gbShiftStats.Controls.Add(Me.lblTotalCountyTime)
        Me.gbShiftStats.Controls.Add(Me.lblTotalStats)
        Me.gbShiftStats.Controls.Add(Me.lblTotalHours)
        Me.gbShiftStats.Controls.Add(Me.lblTotalCityTime)
        Me.gbShiftStats.Controls.Add(Me.lblTotalTimes)
        Me.gbShiftStats.Controls.Add(Me.txtStat16)
        Me.gbShiftStats.Controls.Add(Me.txtStat15)
        Me.gbShiftStats.Controls.Add(Me.lblObligated)
        Me.gbShiftStats.Controls.Add(Me.lblNonObligated)
        Me.gbShiftStats.Controls.Add(Me.txtStat14)
        Me.gbShiftStats.Controls.Add(Me.txtStat13)
        Me.gbShiftStats.Controls.Add(Me.txtStat12)
        Me.gbShiftStats.Controls.Add(Me.txtStat11)
        Me.gbShiftStats.Controls.Add(Me.txtStat10)
        Me.gbShiftStats.Controls.Add(Me.txtStat9)
        Me.gbShiftStats.Controls.Add(Me.txtStat8)
        Me.gbShiftStats.Controls.Add(Me.txtStat7)
        Me.gbShiftStats.Controls.Add(Me.txtStat6)
        Me.gbShiftStats.Controls.Add(Me.txtStat5)
        Me.gbShiftStats.Controls.Add(Me.txtStat4)
        Me.gbShiftStats.Controls.Add(Me.txtStat3)
        Me.gbShiftStats.Controls.Add(Me.txtStat2)
        Me.gbShiftStats.Controls.Add(Me.txtStat1)
        Me.gbShiftStats.Controls.Add(Me.lblCity1)
        Me.gbShiftStats.Controls.Add(Me.lblCounty1)
        Me.gbShiftStats.Controls.Add(Me.lblCity2)
        Me.gbShiftStats.Controls.Add(Me.lblCounty2)
        Me.gbShiftStats.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbShiftStats.Location = New System.Drawing.Point(585, 186)
        Me.gbShiftStats.Name = "gbShiftStats"
        Me.gbShiftStats.Size = New System.Drawing.Size(520, 352)
        Me.gbShiftStats.TabIndex = 126
        Me.gbShiftStats.TabStop = False
        Me.gbShiftStats.Text = "Numbers"
        Me.ToolTip2.SetToolTip(Me.gbShiftStats, "Due to complexities in code, times are rounded to 15 minutes")
        '
        'cmbStat14County
        '
        Me.cmbStat14County.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbStat14County.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStat14County.FormattingEnabled = True
        Me.cmbStat14County.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbStat14County.Location = New System.Drawing.Point(434, 207)
        Me.cmbStat14County.Name = "cmbStat14County"
        Me.cmbStat14County.Size = New System.Drawing.Size(49, 24)
        Me.cmbStat14County.TabIndex = 243
        '
        'cmbStat13County
        '
        Me.cmbStat13County.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbStat13County.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStat13County.FormattingEnabled = True
        Me.cmbStat13County.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbStat13County.Location = New System.Drawing.Point(434, 179)
        Me.cmbStat13County.Name = "cmbStat13County"
        Me.cmbStat13County.Size = New System.Drawing.Size(49, 24)
        Me.cmbStat13County.TabIndex = 242
        '
        'cmbStat12County
        '
        Me.cmbStat12County.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbStat12County.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStat12County.FormattingEnabled = True
        Me.cmbStat12County.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbStat12County.Location = New System.Drawing.Point(434, 148)
        Me.cmbStat12County.Name = "cmbStat12County"
        Me.cmbStat12County.Size = New System.Drawing.Size(49, 24)
        Me.cmbStat12County.TabIndex = 241
        '
        'cmbStat11County
        '
        Me.cmbStat11County.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbStat11County.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStat11County.FormattingEnabled = True
        Me.cmbStat11County.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbStat11County.Location = New System.Drawing.Point(434, 120)
        Me.cmbStat11County.Name = "cmbStat11County"
        Me.cmbStat11County.Size = New System.Drawing.Size(49, 24)
        Me.cmbStat11County.TabIndex = 240
        '
        'cmbStat10County
        '
        Me.cmbStat10County.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbStat10County.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStat10County.FormattingEnabled = True
        Me.cmbStat10County.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbStat10County.Location = New System.Drawing.Point(434, 91)
        Me.cmbStat10County.Name = "cmbStat10County"
        Me.cmbStat10County.Size = New System.Drawing.Size(49, 24)
        Me.cmbStat10County.TabIndex = 239
        '
        'cmbStat9County
        '
        Me.cmbStat9County.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbStat9County.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStat9County.FormattingEnabled = True
        Me.cmbStat9County.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbStat9County.Location = New System.Drawing.Point(434, 64)
        Me.cmbStat9County.Name = "cmbStat9County"
        Me.cmbStat9County.Size = New System.Drawing.Size(49, 24)
        Me.cmbStat9County.TabIndex = 238
        '
        'cmbStat8County
        '
        Me.cmbStat8County.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbStat8County.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStat8County.FormattingEnabled = True
        Me.cmbStat8County.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbStat8County.Location = New System.Drawing.Point(434, 35)
        Me.cmbStat8County.Name = "cmbStat8County"
        Me.cmbStat8County.Size = New System.Drawing.Size(49, 24)
        Me.cmbStat8County.TabIndex = 237
        '
        'cmbStat7County
        '
        Me.cmbStat7County.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbStat7County.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStat7County.FormattingEnabled = True
        Me.cmbStat7County.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbStat7County.Location = New System.Drawing.Point(193, 207)
        Me.cmbStat7County.Name = "cmbStat7County"
        Me.cmbStat7County.Size = New System.Drawing.Size(49, 24)
        Me.cmbStat7County.TabIndex = 236
        '
        'cmbStat6County
        '
        Me.cmbStat6County.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbStat6County.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStat6County.FormattingEnabled = True
        Me.cmbStat6County.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbStat6County.Location = New System.Drawing.Point(193, 179)
        Me.cmbStat6County.Name = "cmbStat6County"
        Me.cmbStat6County.Size = New System.Drawing.Size(49, 24)
        Me.cmbStat6County.TabIndex = 235
        '
        'cmbStat5County
        '
        Me.cmbStat5County.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbStat5County.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStat5County.FormattingEnabled = True
        Me.cmbStat5County.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbStat5County.Location = New System.Drawing.Point(193, 148)
        Me.cmbStat5County.Name = "cmbStat5County"
        Me.cmbStat5County.Size = New System.Drawing.Size(49, 24)
        Me.cmbStat5County.TabIndex = 234
        '
        'cmbStat4County
        '
        Me.cmbStat4County.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbStat4County.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStat4County.FormattingEnabled = True
        Me.cmbStat4County.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbStat4County.Location = New System.Drawing.Point(193, 120)
        Me.cmbStat4County.Name = "cmbStat4County"
        Me.cmbStat4County.Size = New System.Drawing.Size(49, 24)
        Me.cmbStat4County.TabIndex = 233
        '
        'cmbStat3County
        '
        Me.cmbStat3County.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbStat3County.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStat3County.FormattingEnabled = True
        Me.cmbStat3County.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbStat3County.Location = New System.Drawing.Point(193, 91)
        Me.cmbStat3County.Name = "cmbStat3County"
        Me.cmbStat3County.Size = New System.Drawing.Size(49, 24)
        Me.cmbStat3County.TabIndex = 232
        '
        'cmbStat2County
        '
        Me.cmbStat2County.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbStat2County.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStat2County.FormattingEnabled = True
        Me.cmbStat2County.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbStat2County.Location = New System.Drawing.Point(193, 64)
        Me.cmbStat2County.Name = "cmbStat2County"
        Me.cmbStat2County.Size = New System.Drawing.Size(49, 24)
        Me.cmbStat2County.TabIndex = 231
        '
        'cmbStat1County
        '
        Me.cmbStat1County.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbStat1County.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStat1County.FormattingEnabled = True
        Me.cmbStat1County.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbStat1County.Location = New System.Drawing.Point(193, 35)
        Me.cmbStat1County.Name = "cmbStat1County"
        Me.cmbStat1County.Size = New System.Drawing.Size(49, 24)
        Me.cmbStat1County.TabIndex = 230
        '
        'cmbStat14City
        '
        Me.cmbStat14City.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbStat14City.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStat14City.FormattingEnabled = True
        Me.cmbStat14City.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbStat14City.Location = New System.Drawing.Point(380, 207)
        Me.cmbStat14City.Name = "cmbStat14City"
        Me.cmbStat14City.Size = New System.Drawing.Size(49, 24)
        Me.cmbStat14City.TabIndex = 229
        '
        'cmbStat13City
        '
        Me.cmbStat13City.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbStat13City.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStat13City.FormattingEnabled = True
        Me.cmbStat13City.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbStat13City.Location = New System.Drawing.Point(380, 179)
        Me.cmbStat13City.Name = "cmbStat13City"
        Me.cmbStat13City.Size = New System.Drawing.Size(49, 24)
        Me.cmbStat13City.TabIndex = 228
        '
        'cmbStat12City
        '
        Me.cmbStat12City.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbStat12City.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStat12City.FormattingEnabled = True
        Me.cmbStat12City.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbStat12City.Location = New System.Drawing.Point(380, 148)
        Me.cmbStat12City.Name = "cmbStat12City"
        Me.cmbStat12City.Size = New System.Drawing.Size(49, 24)
        Me.cmbStat12City.TabIndex = 227
        '
        'cmbStat11City
        '
        Me.cmbStat11City.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbStat11City.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStat11City.FormattingEnabled = True
        Me.cmbStat11City.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbStat11City.Location = New System.Drawing.Point(380, 120)
        Me.cmbStat11City.Name = "cmbStat11City"
        Me.cmbStat11City.Size = New System.Drawing.Size(49, 24)
        Me.cmbStat11City.TabIndex = 226
        '
        'cmbStat10City
        '
        Me.cmbStat10City.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbStat10City.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStat10City.FormattingEnabled = True
        Me.cmbStat10City.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbStat10City.Location = New System.Drawing.Point(380, 91)
        Me.cmbStat10City.Name = "cmbStat10City"
        Me.cmbStat10City.Size = New System.Drawing.Size(49, 24)
        Me.cmbStat10City.TabIndex = 225
        '
        'cmbStat9City
        '
        Me.cmbStat9City.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbStat9City.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStat9City.FormattingEnabled = True
        Me.cmbStat9City.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbStat9City.Location = New System.Drawing.Point(380, 64)
        Me.cmbStat9City.Name = "cmbStat9City"
        Me.cmbStat9City.Size = New System.Drawing.Size(49, 24)
        Me.cmbStat9City.TabIndex = 224
        '
        'cmbStat8City
        '
        Me.cmbStat8City.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbStat8City.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStat8City.FormattingEnabled = True
        Me.cmbStat8City.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbStat8City.Location = New System.Drawing.Point(380, 35)
        Me.cmbStat8City.Name = "cmbStat8City"
        Me.cmbStat8City.Size = New System.Drawing.Size(49, 24)
        Me.cmbStat8City.TabIndex = 223
        '
        'cmbStat7City
        '
        Me.cmbStat7City.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbStat7City.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStat7City.FormattingEnabled = True
        Me.cmbStat7City.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbStat7City.Location = New System.Drawing.Point(140, 207)
        Me.cmbStat7City.Name = "cmbStat7City"
        Me.cmbStat7City.Size = New System.Drawing.Size(49, 24)
        Me.cmbStat7City.TabIndex = 222
        '
        'cmbStat6City
        '
        Me.cmbStat6City.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbStat6City.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStat6City.FormattingEnabled = True
        Me.cmbStat6City.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbStat6City.Location = New System.Drawing.Point(140, 179)
        Me.cmbStat6City.Name = "cmbStat6City"
        Me.cmbStat6City.Size = New System.Drawing.Size(49, 24)
        Me.cmbStat6City.TabIndex = 221
        '
        'cmbStat5City
        '
        Me.cmbStat5City.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbStat5City.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStat5City.FormattingEnabled = True
        Me.cmbStat5City.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbStat5City.Location = New System.Drawing.Point(140, 148)
        Me.cmbStat5City.Name = "cmbStat5City"
        Me.cmbStat5City.Size = New System.Drawing.Size(49, 24)
        Me.cmbStat5City.TabIndex = 220
        '
        'cmbStat4City
        '
        Me.cmbStat4City.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbStat4City.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStat4City.FormattingEnabled = True
        Me.cmbStat4City.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbStat4City.Location = New System.Drawing.Point(140, 120)
        Me.cmbStat4City.Name = "cmbStat4City"
        Me.cmbStat4City.Size = New System.Drawing.Size(49, 24)
        Me.cmbStat4City.TabIndex = 219
        '
        'cmbStat3City
        '
        Me.cmbStat3City.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbStat3City.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStat3City.FormattingEnabled = True
        Me.cmbStat3City.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbStat3City.Location = New System.Drawing.Point(140, 91)
        Me.cmbStat3City.Name = "cmbStat3City"
        Me.cmbStat3City.Size = New System.Drawing.Size(49, 24)
        Me.cmbStat3City.TabIndex = 218
        '
        'cmbStat2City
        '
        Me.cmbStat2City.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbStat2City.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStat2City.FormattingEnabled = True
        Me.cmbStat2City.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbStat2City.Location = New System.Drawing.Point(140, 64)
        Me.cmbStat2City.Name = "cmbStat2City"
        Me.cmbStat2City.Size = New System.Drawing.Size(49, 24)
        Me.cmbStat2City.TabIndex = 217
        '
        'cmbStat1City
        '
        Me.cmbStat1City.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbStat1City.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStat1City.FormattingEnabled = True
        Me.cmbStat1City.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbStat1City.Location = New System.Drawing.Point(140, 35)
        Me.cmbStat1City.Name = "cmbStat1City"
        Me.cmbStat1City.Size = New System.Drawing.Size(49, 24)
        Me.cmbStat1City.TabIndex = 216
        '
        'cmbStat16County
        '
        Me.cmbStat16County.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbStat16County.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStat16County.FormattingEnabled = True
        Me.cmbStat16County.Items.AddRange(New Object() {":00", ":15", ":30", ":45", "1:00", "1:15", "1:30", "1:45", "2:00", "2:15", "2:30", "2:45", "3:00", "3:15", "3:30", "3:45", "4:00", "4:15", "4:30", "4:45", "5:00", "5:15", "5:30", "5:45", "6:00", "6:15", "6:30", "6:45", "7:00", "7:15", "7:30", "7:45", "8:00", "8:15", "8:30", "8:45", "9:00", "9:15", "9:30", "9:45", "10:00"})
        Me.cmbStat16County.Location = New System.Drawing.Point(434, 288)
        Me.cmbStat16County.Name = "cmbStat16County"
        Me.cmbStat16County.Size = New System.Drawing.Size(49, 24)
        Me.cmbStat16County.TabIndex = 215
        Me.ToolTip2.SetToolTip(Me.cmbStat16County, "All times are rounded to 15 minutes")
        '
        'cmbStat15County
        '
        Me.cmbStat15County.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbStat15County.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStat15County.FormattingEnabled = True
        Me.cmbStat15County.Items.AddRange(New Object() {":00", ":15", ":30", ":45", "1:00", "1:15", "1:30", "1:45", "2:00", "2:15", "2:30", "2:45", "3:00", "3:15", "3:30", "3:45", "4:00", "4:15", "4:30", "4:45", "5:00", "5:15", "5:30", "5:45", "6:00", "6:15", "6:30", "6:45", "7:00", "7:15", "7:30", "7:45", "8:00", "8:15", "8:30", "8:45", "9:00", "9:15", "9:30", "9:45", "10:00"})
        Me.cmbStat15County.Location = New System.Drawing.Point(434, 262)
        Me.cmbStat15County.Name = "cmbStat15County"
        Me.cmbStat15County.Size = New System.Drawing.Size(49, 24)
        Me.cmbStat15County.TabIndex = 214
        Me.ToolTip2.SetToolTip(Me.cmbStat15County, "All times are rounded to 15 minutes")
        '
        'cmbStat15City
        '
        Me.cmbStat15City.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbStat15City.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStat15City.FormattingEnabled = True
        Me.cmbStat15City.Items.AddRange(New Object() {":00", ":15", ":30", ":45", "1:00", "1:15", "1:30", "1:45", "2:00", "2:15", "2:30", "2:45", "3:00", "3:15", "3:30", "3:45", "4:00", "4:15", "4:30", "4:45", "5:00", "5:15", "5:30", "5:45", "6:00", "6:15", "6:30", "6:45", "7:00", "7:15", "7:30", "7:45", "8:00", "8:15", "8:30", "8:45", "9:00", "9:15", "9:30", "9:45", "10:00"})
        Me.cmbStat15City.Location = New System.Drawing.Point(380, 262)
        Me.cmbStat15City.Name = "cmbStat15City"
        Me.cmbStat15City.Size = New System.Drawing.Size(49, 24)
        Me.cmbStat15City.TabIndex = 213
        Me.ToolTip2.SetToolTip(Me.cmbStat15City, "All times are rounded to 15 minutes")
        '
        'cmbObligatedCounty
        '
        Me.cmbObligatedCounty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbObligatedCounty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbObligatedCounty.FormattingEnabled = True
        Me.cmbObligatedCounty.Items.AddRange(New Object() {":00", ":15", ":30", ":45", "1:00", "1:15", "1:30", "1:45", "2:00", "2:15", "2:30", "2:45", "3:00", "3:15", "3:30", "3:45", "4:00", "4:15", "4:30", "4:45", "5:00", "5:15", "5:30", "5:45", "6:00", "6:15", "6:30", "6:45", "7:00", "7:15", "7:30", "7:45", "8:00", "8:15", "8:30", "8:45", "9:00", "9:15", "9:30", "9:45", "10:00"})
        Me.cmbObligatedCounty.Location = New System.Drawing.Point(192, 262)
        Me.cmbObligatedCounty.Name = "cmbObligatedCounty"
        Me.cmbObligatedCounty.Size = New System.Drawing.Size(49, 24)
        Me.cmbObligatedCounty.TabIndex = 212
        Me.ToolTip2.SetToolTip(Me.cmbObligatedCounty, "All times are rounded to 15 minutes")
        '
        'cmbNonObligatedCounty
        '
        Me.cmbNonObligatedCounty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbNonObligatedCounty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNonObligatedCounty.FormattingEnabled = True
        Me.cmbNonObligatedCounty.Items.AddRange(New Object() {":00", ":15", ":30", ":45", "1:00", "1:15", "1:30", "1:45", "2:00", "2:15", "2:30", "2:45", "3:00", "3:15", "3:30", "3:45", "4:00", "4:15", "4:30", "4:45", "5:00", "5:15", "5:30", "5:45", "6:00", "6:15", "6:30", "6:45", "7:00", "7:15", "7:30", "7:45", "8:00", "8:15", "8:30", "8:45", "9:00", "9:15", "9:30", "9:45", "10:00"})
        Me.cmbNonObligatedCounty.Location = New System.Drawing.Point(192, 288)
        Me.cmbNonObligatedCounty.Name = "cmbNonObligatedCounty"
        Me.cmbNonObligatedCounty.Size = New System.Drawing.Size(49, 24)
        Me.cmbNonObligatedCounty.TabIndex = 211
        Me.ToolTip2.SetToolTip(Me.cmbNonObligatedCounty, "All times are rounded to 15 minutes")
        '
        'cmbNonObligatedCity
        '
        Me.cmbNonObligatedCity.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbNonObligatedCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNonObligatedCity.FormattingEnabled = True
        Me.cmbNonObligatedCity.Items.AddRange(New Object() {":00", ":15", ":30", ":45", "1:00", "1:15", "1:30", "1:45", "2:00", "2:15", "2:30", "2:45", "3:00", "3:15", "3:30", "3:45", "4:00", "4:15", "4:30", "4:45", "5:00", "5:15", "5:30", "5:45", "6:00", "6:15", "6:30", "6:45", "7:00", "7:15", "7:30", "7:45", "8:00", "8:15", "8:30", "8:45", "9:00", "9:15", "9:30", "9:45", "10:00"})
        Me.cmbNonObligatedCity.Location = New System.Drawing.Point(139, 288)
        Me.cmbNonObligatedCity.Name = "cmbNonObligatedCity"
        Me.cmbNonObligatedCity.Size = New System.Drawing.Size(49, 24)
        Me.cmbNonObligatedCity.TabIndex = 210
        Me.ToolTip2.SetToolTip(Me.cmbNonObligatedCity, "All times are rounded to 15 minutes")
        '
        'cmbObligatedCity
        '
        Me.cmbObligatedCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbObligatedCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbObligatedCity.FormattingEnabled = True
        Me.cmbObligatedCity.Items.AddRange(New Object() {":00", ":15", ":30", ":45", "1:00", "1:15", "1:30", "1:45", "2:00", "2:15", "2:30", "2:45", "3:00", "3:15", "3:30", "3:45", "4:00", "4:15", "4:30", "4:45", "5:00", "5:15", "5:30", "5:45", "6:00", "6:15", "6:30", "6:45", "7:00", "7:15", "7:30", "7:45", "8:00", "8:15", "8:30", "8:45", "9:00", "9:15", "9:30", "9:45", "10:00"})
        Me.cmbObligatedCity.Location = New System.Drawing.Point(139, 262)
        Me.cmbObligatedCity.Name = "cmbObligatedCity"
        Me.cmbObligatedCity.Size = New System.Drawing.Size(49, 24)
        Me.cmbObligatedCity.TabIndex = 209
        Me.ToolTip2.SetToolTip(Me.cmbObligatedCity, "All times are rounded to 15 minutes")
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(5, 238)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(208, 20)
        Me.Label12.TabIndex = 208
        Me.Label12.Text = "Shift Times (nearest 1/4 hour) "
        Me.ToolTip2.SetToolTip(Me.Label12, "All times are rounded to 15 minutes")
        '
        'lblTotalCountyTime
        '
        Me.lblTotalCountyTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalCountyTime.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCountyTime.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTotalCountyTime.Location = New System.Drawing.Point(190, 320)
        Me.lblTotalCountyTime.Name = "lblTotalCountyTime"
        Me.lblTotalCountyTime.Size = New System.Drawing.Size(63, 25)
        Me.lblTotalCountyTime.TabIndex = 194
        Me.lblTotalCountyTime.Text = "0"
        Me.lblTotalCountyTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip2.SetToolTip(Me.lblTotalCountyTime, "All times are rounded to 15 minutes")
        '
        'lblTotalStats
        '
        Me.lblTotalStats.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalStats.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalStats.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTotalStats.Location = New System.Drawing.Point(377, 320)
        Me.lblTotalStats.Name = "lblTotalStats"
        Me.lblTotalStats.Size = New System.Drawing.Size(63, 25)
        Me.lblTotalStats.TabIndex = 196
        Me.lblTotalStats.Text = "0"
        Me.lblTotalStats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip2.SetToolTip(Me.lblTotalStats, "All times are rounded to 15 minutes")
        '
        'lblTotalHours
        '
        Me.lblTotalHours.AutoSize = True
        Me.lblTotalHours.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalHours.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalHours.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTotalHours.Location = New System.Drawing.Point(259, 323)
        Me.lblTotalHours.Name = "lblTotalHours"
        Me.lblTotalHours.Size = New System.Drawing.Size(106, 20)
        Me.lblTotalHours.TabIndex = 193
        Me.lblTotalHours.Text = "TOTAL HOURS:"
        Me.lblTotalHours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip2.SetToolTip(Me.lblTotalHours, "All times are rounded to 15 minutes")
        '
        'lblTotalCityTime
        '
        Me.lblTotalCityTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalCityTime.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCityTime.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTotalCityTime.Location = New System.Drawing.Point(134, 320)
        Me.lblTotalCityTime.Name = "lblTotalCityTime"
        Me.lblTotalCityTime.Size = New System.Drawing.Size(63, 25)
        Me.lblTotalCityTime.TabIndex = 195
        Me.lblTotalCityTime.Text = "0"
        Me.lblTotalCityTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip2.SetToolTip(Me.lblTotalCityTime, "All times are rounded to 15 minutes")
        '
        'lblTotalTimes
        '
        Me.lblTotalTimes.AutoSize = True
        Me.lblTotalTimes.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalTimes.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalTimes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTotalTimes.Location = New System.Drawing.Point(28, 323)
        Me.lblTotalTimes.Name = "lblTotalTimes"
        Me.lblTotalTimes.Size = New System.Drawing.Size(98, 20)
        Me.lblTotalTimes.TabIndex = 192
        Me.lblTotalTimes.Text = "TOTAL TIMES:"
        Me.lblTotalTimes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip2.SetToolTip(Me.lblTotalTimes, "All times are rounded to 15 minutes")
        '
        'txtStat16
        '
        Me.txtStat16.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStat16.Location = New System.Drawing.Point(247, 291)
        Me.txtStat16.Name = "txtStat16"
        Me.txtStat16.Size = New System.Drawing.Size(130, 18)
        Me.txtStat16.TabIndex = 200
        Me.txtStat16.Text = "bibendum"
        '
        'txtStat15
        '
        Me.txtStat15.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStat15.Location = New System.Drawing.Point(247, 265)
        Me.txtStat15.Name = "txtStat15"
        Me.txtStat15.Size = New System.Drawing.Size(130, 18)
        Me.txtStat15.TabIndex = 199
        Me.txtStat15.Text = "vulputate"
        '
        'lblObligated
        '
        Me.lblObligated.AutoSize = True
        Me.lblObligated.BackColor = System.Drawing.Color.Transparent
        Me.lblObligated.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObligated.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblObligated.Location = New System.Drawing.Point(27, 266)
        Me.lblObligated.Name = "lblObligated"
        Me.lblObligated.Size = New System.Drawing.Size(105, 17)
        Me.lblObligated.TabIndex = 197
        Me.lblObligated.Text = "Obligated Hours"
        Me.ToolTip2.SetToolTip(Me.lblObligated, "All times are rounded to 15 minutes")
        '
        'lblNonObligated
        '
        Me.lblNonObligated.AutoSize = True
        Me.lblNonObligated.BackColor = System.Drawing.Color.Transparent
        Me.lblNonObligated.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNonObligated.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNonObligated.Location = New System.Drawing.Point(3, 292)
        Me.lblNonObligated.Name = "lblNonObligated"
        Me.lblNonObligated.Size = New System.Drawing.Size(134, 17)
        Me.lblNonObligated.TabIndex = 198
        Me.lblNonObligated.Text = "Non Obligated Hours"
        Me.ToolTip2.SetToolTip(Me.lblNonObligated, "All times are rounded to 15 minutes")
        '
        'txtStat14
        '
        Me.txtStat14.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStat14.Location = New System.Drawing.Point(247, 210)
        Me.txtStat14.Name = "txtStat14"
        Me.txtStat14.Size = New System.Drawing.Size(130, 18)
        Me.txtStat14.TabIndex = 162
        Me.txtStat14.Text = "blandit purus"
        '
        'txtStat13
        '
        Me.txtStat13.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStat13.Location = New System.Drawing.Point(247, 182)
        Me.txtStat13.Name = "txtStat13"
        Me.txtStat13.Size = New System.Drawing.Size(130, 18)
        Me.txtStat13.TabIndex = 161
        Me.txtStat13.Text = "ex tempus "
        '
        'txtStat12
        '
        Me.txtStat12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStat12.Location = New System.Drawing.Point(247, 151)
        Me.txtStat12.Name = "txtStat12"
        Me.txtStat12.Size = New System.Drawing.Size(130, 18)
        Me.txtStat12.TabIndex = 160
        Me.txtStat12.Text = "scelerisque"
        '
        'txtStat11
        '
        Me.txtStat11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStat11.Location = New System.Drawing.Point(247, 123)
        Me.txtStat11.Name = "txtStat11"
        Me.txtStat11.Size = New System.Drawing.Size(130, 18)
        Me.txtStat11.TabIndex = 159
        Me.txtStat11.Text = "venenatis"
        '
        'txtStat10
        '
        Me.txtStat10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStat10.Location = New System.Drawing.Point(247, 94)
        Me.txtStat10.Name = "txtStat10"
        Me.txtStat10.Size = New System.Drawing.Size(130, 18)
        Me.txtStat10.TabIndex = 158
        Me.txtStat10.Text = "mattis purus"
        '
        'txtStat9
        '
        Me.txtStat9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStat9.Location = New System.Drawing.Point(247, 67)
        Me.txtStat9.Name = "txtStat9"
        Me.txtStat9.Size = New System.Drawing.Size(130, 18)
        Me.txtStat9.TabIndex = 157
        Me.txtStat9.Text = "pharetra"
        '
        'txtStat8
        '
        Me.txtStat8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStat8.Location = New System.Drawing.Point(247, 38)
        Me.txtStat8.Name = "txtStat8"
        Me.txtStat8.Size = New System.Drawing.Size(130, 18)
        Me.txtStat8.TabIndex = 156
        Me.txtStat8.Text = "malesuada"
        '
        'txtStat7
        '
        Me.txtStat7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStat7.Location = New System.Drawing.Point(7, 210)
        Me.txtStat7.Name = "txtStat7"
        Me.txtStat7.Size = New System.Drawing.Size(130, 18)
        Me.txtStat7.TabIndex = 155
        Me.txtStat7.Text = "scelerisque"
        '
        'txtStat6
        '
        Me.txtStat6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStat6.Location = New System.Drawing.Point(7, 182)
        Me.txtStat6.Name = "txtStat6"
        Me.txtStat6.Size = New System.Drawing.Size(130, 18)
        Me.txtStat6.TabIndex = 154
        Me.txtStat6.Text = "tincidunt"
        '
        'txtStat5
        '
        Me.txtStat5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStat5.Location = New System.Drawing.Point(7, 151)
        Me.txtStat5.Name = "txtStat5"
        Me.txtStat5.Size = New System.Drawing.Size(130, 18)
        Me.txtStat5.TabIndex = 153
        Me.txtStat5.Text = "ultricies"
        '
        'txtStat4
        '
        Me.txtStat4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStat4.Location = New System.Drawing.Point(7, 123)
        Me.txtStat4.Name = "txtStat4"
        Me.txtStat4.Size = New System.Drawing.Size(130, 18)
        Me.txtStat4.TabIndex = 152
        Me.txtStat4.Text = "tempus"
        '
        'txtStat3
        '
        Me.txtStat3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStat3.Location = New System.Drawing.Point(7, 94)
        Me.txtStat3.Name = "txtStat3"
        Me.txtStat3.Size = New System.Drawing.Size(130, 18)
        Me.txtStat3.TabIndex = 151
        Me.txtStat3.Text = "dignissim"
        '
        'txtStat2
        '
        Me.txtStat2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStat2.Location = New System.Drawing.Point(7, 67)
        Me.txtStat2.Name = "txtStat2"
        Me.txtStat2.Size = New System.Drawing.Size(130, 18)
        Me.txtStat2.TabIndex = 150
        Me.txtStat2.Text = "scelerisque"
        '
        'txtStat1
        '
        Me.txtStat1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStat1.Location = New System.Drawing.Point(7, 38)
        Me.txtStat1.Name = "txtStat1"
        Me.txtStat1.Size = New System.Drawing.Size(130, 18)
        Me.txtStat1.TabIndex = 149
        Me.txtStat1.Text = "imperdiet"
        '
        'lblCity1
        '
        Me.lblCity1.BackColor = System.Drawing.Color.Transparent
        Me.lblCity1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCity1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCity1.Location = New System.Drawing.Point(147, 12)
        Me.lblCity1.Name = "lblCity1"
        Me.lblCity1.Size = New System.Drawing.Size(28, 13)
        Me.lblCity1.TabIndex = 91
        Me.lblCity1.Text = "City"
        Me.lblCity1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCounty1
        '
        Me.lblCounty1.BackColor = System.Drawing.Color.Transparent
        Me.lblCounty1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCounty1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCounty1.Location = New System.Drawing.Point(183, 13)
        Me.lblCounty1.Name = "lblCounty1"
        Me.lblCounty1.Size = New System.Drawing.Size(63, 13)
        Me.lblCounty1.TabIndex = 92
        Me.lblCounty1.Text = "County"
        Me.lblCounty1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCity2
        '
        Me.lblCity2.AutoSize = True
        Me.lblCity2.BackColor = System.Drawing.Color.Transparent
        Me.lblCity2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCity2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCity2.Location = New System.Drawing.Point(389, 13)
        Me.lblCity2.Name = "lblCity2"
        Me.lblCity2.Size = New System.Drawing.Size(26, 13)
        Me.lblCity2.TabIndex = 89
        Me.lblCity2.Text = "City"
        Me.lblCity2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCounty2
        '
        Me.lblCounty2.AutoSize = True
        Me.lblCounty2.BackColor = System.Drawing.Color.Transparent
        Me.lblCounty2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCounty2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCounty2.Location = New System.Drawing.Point(433, 13)
        Me.lblCounty2.Name = "lblCounty2"
        Me.lblCounty2.Size = New System.Drawing.Size(44, 13)
        Me.lblCounty2.TabIndex = 90
        Me.lblCounty2.Text = "County"
        Me.lblCounty2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'm_Menu
        '
        Me.m_Menu.AutoSize = False
        Me.m_Menu.BackColor = System.Drawing.Color.White
        Me.m_Menu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.m_Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mFile, Me.mTools, Me.mHelp})
        Me.m_Menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.m_Menu.Location = New System.Drawing.Point(3, 3)
        Me.m_Menu.Name = "m_Menu"
        Me.m_Menu.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.m_Menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.m_Menu.ShowItemToolTips = True
        Me.m_Menu.Size = New System.Drawing.Size(1104, 26)
        Me.m_Menu.TabIndex = 110
        Me.m_Menu.Text = "MenuStrip1"
        '
        'mFile
        '
        Me.mFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mNew_File, Me.mNew_Patrol, Me.mNewLogEntryOnPreviousDate, Me.mSave_File, Me.mOpen_File, Me.mSeparator, Me.mExit_File})
        Me.mFile.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mFile.Name = "mFile"
        Me.mFile.Size = New System.Drawing.Size(47, 24)
        Me.mFile.Text = "&FILE"
        Me.mFile.ToolTipText = "These are the standard program options"
        '
        'mNew_File
        '
        Me.mNew_File.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mNew_File.Name = "mNew_File"
        Me.mNew_File.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.mNew_File.Size = New System.Drawing.Size(394, 24)
        Me.mNew_File.Text = "&New Log Entry"
        '
        'mNew_Patrol
        '
        Me.mNew_Patrol.Name = "mNew_Patrol"
        Me.mNew_Patrol.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.mNew_Patrol.Size = New System.Drawing.Size(394, 24)
        Me.mNew_Patrol.Text = "Quick Patrol Entry"
        '
        'mNewLogEntryOnPreviousDate
        '
        Me.mNewLogEntryOnPreviousDate.Name = "mNewLogEntryOnPreviousDate"
        Me.mNewLogEntryOnPreviousDate.Size = New System.Drawing.Size(394, 24)
        Me.mNewLogEntryOnPreviousDate.Text = "Create new log file from previous or future date"
        '
        'mSave_File
        '
        Me.mSave_File.Name = "mSave_File"
        Me.mSave_File.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mSave_File.Size = New System.Drawing.Size(394, 24)
        Me.mSave_File.Text = "Save"
        '
        'mOpen_File
        '
        Me.mOpen_File.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mOpen_File.Name = "mOpen_File"
        Me.mOpen_File.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mOpen_File.Size = New System.Drawing.Size(394, 24)
        Me.mOpen_File.Text = "&Open Previous Day's Log"
        '
        'mSeparator
        '
        Me.mSeparator.Name = "mSeparator"
        Me.mSeparator.Size = New System.Drawing.Size(391, 6)
        '
        'mExit_File
        '
        Me.mExit_File.Name = "mExit_File"
        Me.mExit_File.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mExit_File.Size = New System.Drawing.Size(394, 24)
        Me.mExit_File.Text = "E&xit"
        '
        'mTools
        '
        Me.mTools.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mOptions_Tools, Me.mStats_Tools, Me.mEditCallTypes_Tools, Me.ToolStripSeparator8, Me.mDayNight_Tools, Me.ToolStripSeparator3, Me.mViewLogsHTML_Tools, Me.ToolStripSeparator1, Me.mDeleteSingleEntry_Tools, Me.mClearEntireLog_Tools})
        Me.mTools.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mTools.Name = "mTools"
        Me.mTools.Size = New System.Drawing.Size(65, 24)
        Me.mTools.Text = "&TOOLS"
        '
        'mOptions_Tools
        '
        Me.mOptions_Tools.Name = "mOptions_Tools"
        Me.mOptions_Tools.Size = New System.Drawing.Size(334, 24)
        Me.mOptions_Tools.Text = "DailyLog Options"
        Me.mOptions_Tools.ToolTipText = "Opens DailyLog Options"
        '
        'mStats_Tools
        '
        Me.mStats_Tools.Name = "mStats_Tools"
        Me.mStats_Tools.Size = New System.Drawing.Size(334, 24)
        Me.mStats_Tools.Text = "Generate Stats Report"
        '
        'mEditCallTypes_Tools
        '
        Me.mEditCallTypes_Tools.DoubleClickEnabled = True
        Me.mEditCallTypes_Tools.Name = "mEditCallTypes_Tools"
        Me.mEditCallTypes_Tools.Size = New System.Drawing.Size(334, 24)
        Me.mEditCallTypes_Tools.Text = "Edit Locations/Call Types"
        Me.mEditCallTypes_Tools.ToolTipText = "Edit your call locations and add or remove call types"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(331, 6)
        '
        'mDayNight_Tools
        '
        Me.mDayNight_Tools.Name = "mDayNight_Tools"
        Me.mDayNight_Tools.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.mDayNight_Tools.Size = New System.Drawing.Size(334, 24)
        Me.mDayNight_Tools.Text = "Quick Toggle Day/Night Colors"
        Me.mDayNight_Tools.ToolTipText = "Switch to Day or Night colours"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(331, 6)
        '
        'mViewLogsHTML_Tools
        '
        Me.mViewLogsHTML_Tools.Name = "mViewLogsHTML_Tools"
        Me.mViewLogsHTML_Tools.Size = New System.Drawing.Size(334, 24)
        Me.mViewLogsHTML_Tools.Text = "Reprint a Specific Log"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(331, 6)
        '
        'mDeleteSingleEntry_Tools
        '
        Me.mDeleteSingleEntry_Tools.Image = Global.DailyLog.My.Resources.Resources.Delete_32x321
        Me.mDeleteSingleEntry_Tools.Name = "mDeleteSingleEntry_Tools"
        Me.mDeleteSingleEntry_Tools.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.mDeleteSingleEntry_Tools.Size = New System.Drawing.Size(334, 24)
        Me.mDeleteSingleEntry_Tools.Text = "Delete a Single Log Entry"
        Me.mDeleteSingleEntry_Tools.ToolTipText = "Delete a simgle log entry if needed"
        '
        'mClearEntireLog_Tools
        '
        Me.mClearEntireLog_Tools.Image = Global.DailyLog.My.Resources.Resources.danger_warning1
        Me.mClearEntireLog_Tools.Name = "mClearEntireLog_Tools"
        Me.mClearEntireLog_Tools.Size = New System.Drawing.Size(334, 24)
        Me.mClearEntireLog_Tools.Text = "Clear ENTIRE Log"
        Me.mClearEntireLog_Tools.ToolTipText = "Clears the ENTIRE log- USE WITH CAUTION"
        '
        'mHelp
        '
        Me.mHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mAbout_Help})
        Me.mHelp.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mHelp.Name = "mHelp"
        Me.mHelp.Size = New System.Drawing.Size(55, 24)
        Me.mHelp.Text = "&HELP"
        '
        'mAbout_Help
        '
        Me.mAbout_Help.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_AppDataFolder})
        Me.mAbout_Help.Image = Global.DailyLog.My.Resources.Resources.badge_48X48
        Me.mAbout_Help.Name = "mAbout_Help"
        Me.mAbout_Help.Size = New System.Drawing.Size(220, 24)
        Me.mAbout_Help.Text = "&About DailyLog Basic"
        Me.mAbout_Help.ToolTipText = "About DailyLog and copyright information"
        '
        'm_AppDataFolder
        '
        Me.m_AppDataFolder.Name = "m_AppDataFolder"
        Me.m_AppDataFolder.Size = New System.Drawing.Size(220, 24)
        Me.m_AppDataFolder.Text = "View AppData Folder"
        '
        'lblPassword
        '
        Me.lblPassword.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(235, 343)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(42, 10)
        Me.lblPassword.TabIndex = 115
        Me.lblPassword.Text = "lblPassword"
        Me.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblID
        '
        Me.lblID.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Segoe UI", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(235, 375)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(20, 10)
        Me.lblID.TabIndex = 113
        Me.lblID.Text = "lblID"
        Me.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblVersion
        '
        Me.lblVersion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Font = New System.Drawing.Font("Segoe UI", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.Location = New System.Drawing.Point(205, 343)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(36, 10)
        Me.lblVersion.TabIndex = 116
        Me.lblVersion.Text = "lblVersion"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAgency
        '
        Me.lblAgency.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblAgency.AutoSize = True
        Me.lblAgency.Font = New System.Drawing.Font("Segoe UI", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgency.Location = New System.Drawing.Point(157, 329)
        Me.lblAgency.Name = "lblAgency"
        Me.lblAgency.Size = New System.Drawing.Size(36, 10)
        Me.lblAgency.TabIndex = 118
        Me.lblAgency.Text = "lblAgency"
        Me.lblAgency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOfficer
        '
        Me.lblOfficer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblOfficer.AutoSize = True
        Me.lblOfficer.Font = New System.Drawing.Font("Segoe UI", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOfficer.Location = New System.Drawing.Point(157, 344)
        Me.lblOfficer.Name = "lblOfficer"
        Me.lblOfficer.Size = New System.Drawing.Size(33, 10)
        Me.lblOfficer.TabIndex = 117
        Me.lblOfficer.Text = "lblOfficer"
        Me.lblOfficer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblExplanation
        '
        Me.lblExplanation.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblExplanation.AutoSize = True
        Me.lblExplanation.Font = New System.Drawing.Font("Segoe UI", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExplanation.Location = New System.Drawing.Point(152, 313)
        Me.lblExplanation.Name = "lblExplanation"
        Me.lblExplanation.Size = New System.Drawing.Size(163, 10)
        Me.lblExplanation.TabIndex = 119
        Me.lblExplanation.Text = "These are needed to pass values on to other forms"
        '
        'lblState
        '
        Me.lblState.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblState.AutoSize = True
        Me.lblState.Font = New System.Drawing.Font("Segoe UI", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.Location = New System.Drawing.Point(235, 359)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(29, 10)
        Me.lblState.TabIndex = 122
        Me.lblState.Text = "lblState"
        '
        'lblCounty
        '
        Me.lblCounty.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCounty.AutoSize = True
        Me.lblCounty.Font = New System.Drawing.Font("Segoe UI", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCounty.Location = New System.Drawing.Point(205, 359)
        Me.lblCounty.Name = "lblCounty"
        Me.lblCounty.Size = New System.Drawing.Size(34, 10)
        Me.lblCounty.TabIndex = 121
        Me.lblCounty.Text = "lblCounty"
        '
        'lblPhone
        '
        Me.lblPhone.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Segoe UI", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.Location = New System.Drawing.Point(157, 359)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(33, 10)
        Me.lblPhone.TabIndex = 120
        Me.lblPhone.Text = "lblPhone"
        '
        'lblArea
        '
        Me.lblArea.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblArea.AutoSize = True
        Me.lblArea.Font = New System.Drawing.Font("Segoe UI", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArea.Location = New System.Drawing.Point(205, 375)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(28, 10)
        Me.lblArea.TabIndex = 125
        Me.lblArea.Text = "lblArea"
        Me.lblArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSupervisor
        '
        Me.lblSupervisor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSupervisor.AutoSize = True
        Me.lblSupervisor.Font = New System.Drawing.Font("Segoe UI", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSupervisor.Location = New System.Drawing.Point(157, 374)
        Me.lblSupervisor.Name = "lblSupervisor"
        Me.lblSupervisor.Size = New System.Drawing.Size(45, 10)
        Me.lblSupervisor.TabIndex = 124
        Me.lblSupervisor.Text = "lblSupervisor"
        Me.lblSupervisor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabReporting
        '
        Me.TabReporting.Controls.Add(Me.Button2)
        Me.TabReporting.Controls.Add(Me.Label42)
        Me.TabReporting.Controls.Add(Me.Narrative)
        Me.TabReporting.Controls.Add(Me.Button1)
        Me.TabReporting.Location = New System.Drawing.Point(4, 30)
        Me.TabReporting.Margin = New System.Windows.Forms.Padding(2)
        Me.TabReporting.Name = "TabReporting"
        Me.TabReporting.Size = New System.Drawing.Size(1110, 544)
        Me.TabReporting.TabIndex = 1
        Me.TabReporting.Text = "REPORTING"
        Me.TabReporting.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(496, 503)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(98, 28)
        Me.Button2.TabIndex = 50
        Me.Button2.Text = "Blank"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Segoe UI", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(10, 497)
        Me.Label42.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(369, 41)
        Me.Label42.TabIndex = 49
        Me.Label42.Text = "GENERAL REPORT FORM"
        '
        'Narrative
        '
        Me.Narrative.Controls.Add(Me.TabCaseDetails)
        Me.Narrative.Controls.Add(Me.TabPerson1)
        Me.Narrative.Controls.Add(Me.TabPerson2)
        Me.Narrative.Controls.Add(Me.TabVehicle1)
        Me.Narrative.Controls.Add(Me.TabVehicle2)
        Me.Narrative.Controls.Add(Me.TabNarrative)
        Me.Narrative.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Narrative.Location = New System.Drawing.Point(6, 6)
        Me.Narrative.Margin = New System.Windows.Forms.Padding(2)
        Me.Narrative.Name = "Narrative"
        Me.Narrative.SelectedIndex = 0
        Me.Narrative.Size = New System.Drawing.Size(1184, 488)
        Me.Narrative.TabIndex = 48
        '
        'TabCaseDetails
        '
        Me.TabCaseDetails.Controls.Add(Me.Label11)
        Me.TabCaseDetails.Controls.Add(Me.TxtPrimaryID2_)
        Me.TabCaseDetails.Controls.Add(Me.CbNoVideo2_)
        Me.TabCaseDetails.Controls.Add(Me.CbVideoAttached2_)
        Me.TabCaseDetails.Controls.Add(Me.TxtSecondaryOfficer1_)
        Me.TabCaseDetails.Controls.Add(Me.Label13)
        Me.TabCaseDetails.Controls.Add(Me.Label10)
        Me.TabCaseDetails.Controls.Add(Me.TxtPrimaryID1_)
        Me.TabCaseDetails.Controls.Add(Me.Label9)
        Me.TabCaseDetails.Controls.Add(Me.CbNoVideo1_)
        Me.TabCaseDetails.Controls.Add(Me.GroupBox1)
        Me.TabCaseDetails.Controls.Add(Me.CbVideoAttached1_)
        Me.TabCaseDetails.Controls.Add(Me.CmbAdditionalReports)
        Me.TabCaseDetails.Controls.Add(Me.Label47)
        Me.TabCaseDetails.Controls.Add(Me.TxtOffence_Date)
        Me.TabCaseDetails.Controls.Add(Me.Label45)
        Me.TabCaseDetails.Controls.Add(Me.Label46)
        Me.TabCaseDetails.Controls.Add(Me.TxtIncidentAddress)
        Me.TabCaseDetails.Controls.Add(Me.TxtPrimaryOfficer_)
        Me.TabCaseDetails.Controls.Add(Me.Label44)
        Me.TabCaseDetails.Controls.Add(Me.Label43)
        Me.TabCaseDetails.Controls.Add(Me.Txt_Incident_time)
        Me.TabCaseDetails.Controls.Add(Me.LblDateTimeReporting)
        Me.TabCaseDetails.Controls.Add(Me.lblDateTime)
        Me.TabCaseDetails.Controls.Add(Me.Txt_Case)
        Me.TabCaseDetails.Controls.Add(Me.lblCase)
        Me.TabCaseDetails.Location = New System.Drawing.Point(4, 29)
        Me.TabCaseDetails.Margin = New System.Windows.Forms.Padding(2)
        Me.TabCaseDetails.Name = "TabCaseDetails"
        Me.TabCaseDetails.Size = New System.Drawing.Size(1176, 455)
        Me.TabCaseDetails.TabIndex = 2
        Me.TabCaseDetails.Text = "Case Details"
        Me.TabCaseDetails.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(400, 141)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(103, 20)
        Me.Label11.TabIndex = 80
        Me.Label11.Text = "Primary 2 ID"
        '
        'TxtPrimaryID2_
        '
        Me.TxtPrimaryID2_.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtPrimaryID2_.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrimaryID2_.Location = New System.Drawing.Point(506, 139)
        Me.TxtPrimaryID2_.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPrimaryID2_.Name = "TxtPrimaryID2_"
        Me.TxtPrimaryID2_.Size = New System.Drawing.Size(95, 28)
        Me.TxtPrimaryID2_.TabIndex = 11
        '
        'CbNoVideo2_
        '
        Me.CbNoVideo2_.AutoSize = True
        Me.CbNoVideo2_.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbNoVideo2_.Location = New System.Drawing.Point(847, 140)
        Me.CbNoVideo2_.Margin = New System.Windows.Forms.Padding(2)
        Me.CbNoVideo2_.Name = "CbNoVideo2_"
        Me.CbNoVideo2_.Size = New System.Drawing.Size(238, 24)
        Me.CbNoVideo2_.TabIndex = 13
        Me.CbNoVideo2_.Text = "Audio/Video NOT Attached"
        Me.ToolTip2.SetToolTip(Me.CbNoVideo2_, "If no video of this Incident is available, an explanation why must be in the repo" &
        "rt.")
        Me.CbNoVideo2_.UseVisualStyleBackColor = True
        '
        'CbVideoAttached2_
        '
        Me.CbVideoAttached2_.AutoSize = True
        Me.CbVideoAttached2_.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbVideoAttached2_.Location = New System.Drawing.Point(632, 140)
        Me.CbVideoAttached2_.Margin = New System.Windows.Forms.Padding(2)
        Me.CbVideoAttached2_.Name = "CbVideoAttached2_"
        Me.CbVideoAttached2_.Size = New System.Drawing.Size(199, 24)
        Me.CbVideoAttached2_.TabIndex = 12
        Me.CbVideoAttached2_.Text = "Audio/Video Attached"
        Me.CbVideoAttached2_.UseVisualStyleBackColor = True
        '
        'TxtSecondaryOfficer1_
        '
        Me.TxtSecondaryOfficer1_.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSecondaryOfficer1_.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSecondaryOfficer1_.Location = New System.Drawing.Point(157, 139)
        Me.TxtSecondaryOfficer1_.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtSecondaryOfficer1_.Name = "TxtSecondaryOfficer1_"
        Me.TxtSecondaryOfficer1_.Size = New System.Drawing.Size(226, 28)
        Me.TxtSecondaryOfficer1_.TabIndex = 10
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(13, 141)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(145, 20)
        Me.Label13.TabIndex = 75
        Me.Label13.Text = "Secondary Officer"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(400, 105)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(103, 20)
        Me.Label10.TabIndex = 74
        Me.Label10.Text = "Primary 1 ID"
        '
        'TxtPrimaryID1_
        '
        Me.TxtPrimaryID1_.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtPrimaryID1_.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrimaryID1_.Location = New System.Drawing.Point(506, 102)
        Me.TxtPrimaryID1_.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPrimaryID1_.Name = "TxtPrimaryID1_"
        Me.TxtPrimaryID1_.Size = New System.Drawing.Size(95, 28)
        Me.TxtPrimaryID1_.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(604, 141)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 20)
        Me.Label9.TabIndex = 72
        Me.ToolTip2.SetToolTip(Me.Label9, "If none, just type NONE")
        '
        'CbNoVideo1_
        '
        Me.CbNoVideo1_.AutoSize = True
        Me.CbNoVideo1_.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbNoVideo1_.Location = New System.Drawing.Point(845, 103)
        Me.CbNoVideo1_.Margin = New System.Windows.Forms.Padding(2)
        Me.CbNoVideo1_.Name = "CbNoVideo1_"
        Me.CbNoVideo1_.Size = New System.Drawing.Size(238, 24)
        Me.CbNoVideo1_.TabIndex = 9
        Me.CbNoVideo1_.Text = "Audio/Video NOT Attached"
        Me.ToolTip2.SetToolTip(Me.CbNoVideo1_, "If no video of this Incident is available, an explanation why must be in the repo" &
        "rt.")
        Me.CbNoVideo1_.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CbCivilWarrant_)
        Me.GroupBox1.Controls.Add(Me.TxtCounts3_)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TxtCounts2_)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TxtCounts1_)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.CbCrimWarrant_)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.LblLawCode1_)
        Me.GroupBox1.Controls.Add(Me.TxtLawCode2_)
        Me.GroupBox1.Controls.Add(Me.TxtLawCode3_)
        Me.GroupBox1.Controls.Add(Me.TxtLawCode1_)
        Me.GroupBox1.Controls.Add(Me.CbDocumentation_)
        Me.GroupBox1.Controls.Add(Me.CbNonCrim_)
        Me.GroupBox1.Controls.Add(Me.CbInfraction_)
        Me.GroupBox1.Controls.Add(Me.CbMisd_)
        Me.GroupBox1.Controls.Add(Me.CbFelony_)
        Me.GroupBox1.Controls.Add(Me.TxtOffence3_)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtOffence2_)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtOffence1_)
        Me.GroupBox1.Controls.Add(Me.LblCharges)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(22, 180)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(1053, 235)
        Me.GroupBox1.TabIndex = 71
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List Most Serious Offence First. If More Than 3, Add To Narrative"
        '
        'CbCivilWarrant_
        '
        Me.CbCivilWarrant_.AutoSize = True
        Me.CbCivilWarrant_.Location = New System.Drawing.Point(551, 180)
        Me.CbCivilWarrant_.Margin = New System.Windows.Forms.Padding(2)
        Me.CbCivilWarrant_.Name = "CbCivilWarrant_"
        Me.CbCivilWarrant_.Size = New System.Drawing.Size(127, 24)
        Me.CbCivilWarrant_.TabIndex = 27
        Me.CbCivilWarrant_.Text = "Civil Warrant"
        Me.CbCivilWarrant_.UseVisualStyleBackColor = True
        '
        'TxtCounts3_
        '
        Me.TxtCounts3_.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCounts3_.Location = New System.Drawing.Point(953, 128)
        Me.TxtCounts3_.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtCounts3_.Name = "TxtCounts3_"
        Me.TxtCounts3_.Size = New System.Drawing.Size(76, 28)
        Me.TxtCounts3_.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(886, 131)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 20)
        Me.Label8.TabIndex = 93
        Me.Label8.Text = "Counts"
        '
        'TxtCounts2_
        '
        Me.TxtCounts2_.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCounts2_.Location = New System.Drawing.Point(953, 84)
        Me.TxtCounts2_.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtCounts2_.Name = "TxtCounts2_"
        Me.TxtCounts2_.Size = New System.Drawing.Size(76, 28)
        Me.TxtCounts2_.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(886, 88)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 20)
        Me.Label7.TabIndex = 91
        Me.Label7.Text = "Counts"
        '
        'TxtCounts1_
        '
        Me.TxtCounts1_.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCounts1_.Location = New System.Drawing.Point(953, 41)
        Me.TxtCounts1_.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtCounts1_.Name = "TxtCounts1_"
        Me.TxtCounts1_.Size = New System.Drawing.Size(76, 28)
        Me.TxtCounts1_.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(886, 43)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 20)
        Me.Label6.TabIndex = 89
        Me.Label6.Text = "Counts"
        '
        'CbCrimWarrant_
        '
        Me.CbCrimWarrant_.AutoSize = True
        Me.CbCrimWarrant_.Location = New System.Drawing.Point(385, 180)
        Me.CbCrimWarrant_.Margin = New System.Windows.Forms.Padding(2)
        Me.CbCrimWarrant_.Name = "CbCrimWarrant_"
        Me.CbCrimWarrant_.Size = New System.Drawing.Size(158, 24)
        Me.CbCrimWarrant_.TabIndex = 26
        Me.CbCrimWarrant_.Text = "Criminal Warrant"
        Me.CbCrimWarrant_.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(590, 130)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 20)
        Me.Label5.TabIndex = 87
        Me.Label5.Text = "Law Code"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(590, 87)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 20)
        Me.Label4.TabIndex = 86
        Me.Label4.Text = "Law Code"
        '
        'LblLawCode1_
        '
        Me.LblLawCode1_.AutoSize = True
        Me.LblLawCode1_.Location = New System.Drawing.Point(590, 41)
        Me.LblLawCode1_.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblLawCode1_.Name = "LblLawCode1_"
        Me.LblLawCode1_.Size = New System.Drawing.Size(83, 20)
        Me.LblLawCode1_.TabIndex = 85
        Me.LblLawCode1_.Text = "Law Code"
        '
        'TxtLawCode2_
        '
        Me.TxtLawCode2_.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtLawCode2_.Location = New System.Drawing.Point(675, 82)
        Me.TxtLawCode2_.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtLawCode2_.Name = "TxtLawCode2_"
        Me.TxtLawCode2_.Size = New System.Drawing.Size(187, 28)
        Me.TxtLawCode2_.TabIndex = 18
        '
        'TxtLawCode3_
        '
        Me.TxtLawCode3_.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtLawCode3_.Location = New System.Drawing.Point(675, 128)
        Me.TxtLawCode3_.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtLawCode3_.Name = "TxtLawCode3_"
        Me.TxtLawCode3_.Size = New System.Drawing.Size(187, 28)
        Me.TxtLawCode3_.TabIndex = 21
        '
        'TxtLawCode1_
        '
        Me.TxtLawCode1_.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtLawCode1_.Location = New System.Drawing.Point(675, 41)
        Me.TxtLawCode1_.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtLawCode1_.Name = "TxtLawCode1_"
        Me.TxtLawCode1_.Size = New System.Drawing.Size(187, 28)
        Me.TxtLawCode1_.TabIndex = 15
        '
        'CbDocumentation_
        '
        Me.CbDocumentation_.AutoSize = True
        Me.CbDocumentation_.Location = New System.Drawing.Point(826, 180)
        Me.CbDocumentation_.Margin = New System.Windows.Forms.Padding(2)
        Me.CbDocumentation_.Name = "CbDocumentation_"
        Me.CbDocumentation_.Size = New System.Drawing.Size(187, 24)
        Me.CbDocumentation_.TabIndex = 29
        Me.CbDocumentation_.Text = "Documentation Only"
        Me.CbDocumentation_.UseVisualStyleBackColor = True
        '
        'CbNonCrim_
        '
        Me.CbNonCrim_.AutoSize = True
        Me.CbNonCrim_.Location = New System.Drawing.Point(688, 180)
        Me.CbNonCrim_.Margin = New System.Windows.Forms.Padding(2)
        Me.CbNonCrim_.Name = "CbNonCrim_"
        Me.CbNonCrim_.Size = New System.Drawing.Size(128, 24)
        Me.CbNonCrim_.TabIndex = 28
        Me.CbNonCrim_.Text = "Non Criminal"
        Me.CbNonCrim_.UseVisualStyleBackColor = True
        '
        'CbInfraction_
        '
        Me.CbInfraction_.AutoSize = True
        Me.CbInfraction_.Location = New System.Drawing.Point(275, 180)
        Me.CbInfraction_.Margin = New System.Windows.Forms.Padding(2)
        Me.CbInfraction_.Name = "CbInfraction_"
        Me.CbInfraction_.Size = New System.Drawing.Size(102, 24)
        Me.CbInfraction_.TabIndex = 25
        Me.CbInfraction_.Text = "Infraction"
        Me.CbInfraction_.UseVisualStyleBackColor = True
        '
        'CbMisd_
        '
        Me.CbMisd_.AutoSize = True
        Me.CbMisd_.Location = New System.Drawing.Point(134, 180)
        Me.CbMisd_.Margin = New System.Windows.Forms.Padding(2)
        Me.CbMisd_.Name = "CbMisd_"
        Me.CbMisd_.Size = New System.Drawing.Size(134, 24)
        Me.CbMisd_.TabIndex = 24
        Me.CbMisd_.Text = "Misdemeanor"
        Me.CbMisd_.UseVisualStyleBackColor = True
        '
        'CbFelony_
        '
        Me.CbFelony_.AutoSize = True
        Me.CbFelony_.Location = New System.Drawing.Point(47, 180)
        Me.CbFelony_.Margin = New System.Windows.Forms.Padding(2)
        Me.CbFelony_.Name = "CbFelony_"
        Me.CbFelony_.Size = New System.Drawing.Size(79, 24)
        Me.CbFelony_.TabIndex = 23
        Me.CbFelony_.Text = "Felony"
        Me.CbFelony_.UseVisualStyleBackColor = True
        '
        'TxtOffence3_
        '
        Me.TxtOffence3_.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtOffence3_.Location = New System.Drawing.Point(112, 128)
        Me.TxtOffence3_.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtOffence3_.Name = "TxtOffence3_"
        Me.TxtOffence3_.Size = New System.Drawing.Size(458, 28)
        Me.TxtOffence3_.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 128)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 20)
        Me.Label3.TabIndex = 75
        Me.Label3.Text = "Offence #3"
        '
        'TxtOffence2_
        '
        Me.TxtOffence2_.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtOffence2_.Location = New System.Drawing.Point(112, 82)
        Me.TxtOffence2_.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtOffence2_.Name = "TxtOffence2_"
        Me.TxtOffence2_.Size = New System.Drawing.Size(458, 28)
        Me.TxtOffence2_.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 82)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 20)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "Offence #2"
        '
        'TxtOffence1_
        '
        Me.TxtOffence1_.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtOffence1_.Location = New System.Drawing.Point(112, 38)
        Me.TxtOffence1_.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtOffence1_.Name = "TxtOffence1_"
        Me.TxtOffence1_.Size = New System.Drawing.Size(458, 28)
        Me.TxtOffence1_.TabIndex = 14
        '
        'LblCharges
        '
        Me.LblCharges.AutoSize = True
        Me.LblCharges.Location = New System.Drawing.Point(13, 38)
        Me.LblCharges.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblCharges.Name = "LblCharges"
        Me.LblCharges.Size = New System.Drawing.Size(94, 20)
        Me.LblCharges.TabIndex = 71
        Me.LblCharges.Text = "Offence #1"
        '
        'CbVideoAttached1_
        '
        Me.CbVideoAttached1_.AutoSize = True
        Me.CbVideoAttached1_.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbVideoAttached1_.Location = New System.Drawing.Point(632, 103)
        Me.CbVideoAttached1_.Margin = New System.Windows.Forms.Padding(2)
        Me.CbVideoAttached1_.Name = "CbVideoAttached1_"
        Me.CbVideoAttached1_.Size = New System.Drawing.Size(199, 24)
        Me.CbVideoAttached1_.TabIndex = 8
        Me.CbVideoAttached1_.Text = "Audio/Video Attached"
        Me.CbVideoAttached1_.UseVisualStyleBackColor = True
        '
        'CmbAdditionalReports
        '
        Me.CmbAdditionalReports.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbAdditionalReports.FormattingEnabled = True
        Me.CmbAdditionalReports.Items.AddRange(New Object() {"None", "Citation", "DUI", "Domestic", "Property Damage", "Missing/Runaway", "Witness Statement", "Impound Record", "Probable Cause Statement", "Other"})
        Me.CmbAdditionalReports.Location = New System.Drawing.Point(861, 64)
        Me.CmbAdditionalReports.Margin = New System.Windows.Forms.Padding(2)
        Me.CmbAdditionalReports.Name = "CmbAdditionalReports"
        Me.CmbAdditionalReports.Size = New System.Drawing.Size(201, 28)
        Me.CmbAdditionalReports.TabIndex = 5
        Me.CmbAdditionalReports.Text = "Select"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(697, 67)
        Me.Label47.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(152, 20)
        Me.Label47.TabIndex = 61
        Me.Label47.Text = "Additional Reports"
        '
        'TxtOffence_Date
        '
        Me.TxtOffence_Date.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtOffence_Date.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOffence_Date.Location = New System.Drawing.Point(701, 28)
        Me.TxtOffence_Date.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtOffence_Date.Name = "TxtOffence_Date"
        Me.TxtOffence_Date.Size = New System.Drawing.Size(131, 28)
        Me.TxtOffence_Date.TabIndex = 2
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(13, 67)
        Me.Label45.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(178, 20)
        Me.Label45.TabIndex = 57
        Me.Label45.Text = "Incident (full) Address"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(565, 30)
        Me.Label46.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(131, 20)
        Me.Label46.TabIndex = 59
        Me.Label46.Text = "Date of Incident"
        '
        'TxtIncidentAddress
        '
        Me.TxtIncidentAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtIncidentAddress.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIncidentAddress.Location = New System.Drawing.Point(194, 65)
        Me.TxtIncidentAddress.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtIncidentAddress.Name = "TxtIncidentAddress"
        Me.TxtIncidentAddress.Size = New System.Drawing.Size(480, 28)
        Me.TxtIncidentAddress.TabIndex = 4
        '
        'TxtPrimaryOfficer_
        '
        Me.TxtPrimaryOfficer_.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtPrimaryOfficer_.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrimaryOfficer_.Location = New System.Drawing.Point(141, 102)
        Me.TxtPrimaryOfficer_.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPrimaryOfficer_.Name = "TxtPrimaryOfficer_"
        Me.TxtPrimaryOfficer_.Size = New System.Drawing.Size(242, 28)
        Me.TxtPrimaryOfficer_.TabIndex = 6
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(13, 105)
        Me.Label44.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(124, 20)
        Me.Label44.TabIndex = 55
        Me.Label44.Text = "Primary Officer"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(857, 30)
        Me.Label43.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(112, 20)
        Me.Label43.TabIndex = 54
        Me.Label43.Text = "Incident Time"
        '
        'Txt_Incident_time
        '
        Me.Txt_Incident_time.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Incident_time.Location = New System.Drawing.Point(977, 28)
        Me.Txt_Incident_time.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_Incident_time.Name = "Txt_Incident_time"
        Me.Txt_Incident_time.Size = New System.Drawing.Size(85, 28)
        Me.Txt_Incident_time.TabIndex = 3
        Me.Txt_Incident_time.Text = "00:00H"
        '
        'LblDateTimeReporting
        '
        Me.LblDateTimeReporting.AutoSize = True
        Me.LblDateTimeReporting.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDateTimeReporting.Location = New System.Drawing.Point(454, 29)
        Me.LblDateTimeReporting.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblDateTimeReporting.Name = "LblDateTimeReporting"
        Me.LblDateTimeReporting.Size = New System.Drawing.Size(97, 20)
        Me.LblDateTimeReporting.TabIndex = 52
        Me.LblDateTimeReporting.Text = "00.00.0000"
        '
        'lblDateTime
        '
        Me.lblDateTime.AutoSize = True
        Me.lblDateTime.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateTime.Location = New System.Drawing.Point(305, 30)
        Me.lblDateTime.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(145, 20)
        Me.lblDateTime.TabIndex = 51
        Me.lblDateTime.Text = "Report Date/Time"
        '
        'Txt_Case
        '
        Me.Txt_Case.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Case.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Case.Location = New System.Drawing.Point(108, 28)
        Me.Txt_Case.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_Case.Name = "Txt_Case"
        Me.Txt_Case.Size = New System.Drawing.Size(185, 28)
        Me.Txt_Case.TabIndex = 1
        '
        'lblCase
        '
        Me.lblCase.AutoSize = True
        Me.lblCase.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCase.Location = New System.Drawing.Point(13, 30)
        Me.lblCase.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCase.Name = "lblCase"
        Me.lblCase.Size = New System.Drawing.Size(93, 20)
        Me.lblCase.TabIndex = 50
        Me.lblCase.Text = "Case/File #"
        '
        'TabPerson1
        '
        Me.TabPerson1.Controls.Add(Me.TxtScarsTats1_)
        Me.TabPerson1.Controls.Add(Me.Label24)
        Me.TabPerson1.Controls.Add(Me.TxtOccupation1_)
        Me.TabPerson1.Controls.Add(Me.Label23)
        Me.TabPerson1.Controls.Add(Me.TxtPhone1_)
        Me.TabPerson1.Controls.Add(Me.Label20)
        Me.TabPerson1.Controls.Add(Me.Label17)
        Me.TabPerson1.Controls.Add(Me.TxtCitizenship1_)
        Me.TabPerson1.Controls.Add(Me.TxtPlaceofBirth1_)
        Me.TabPerson1.Controls.Add(Me.Label16)
        Me.TabPerson1.Controls.Add(Me.lblAge1_)
        Me.TabPerson1.Controls.Add(Me.TxtAge1_)
        Me.TabPerson1.Controls.Add(Me.Label15)
        Me.TabPerson1.Controls.Add(Me.CmbDrugAlcohol1_)
        Me.TabPerson1.Controls.Add(Me.Label14)
        Me.TabPerson1.Controls.Add(Me.CmbEyes1_)
        Me.TabPerson1.Controls.Add(Me.lblEyes1_)
        Me.TabPerson1.Controls.Add(Me.CmbHair1_)
        Me.TabPerson1.Controls.Add(Me.CmbState1_)
        Me.TabPerson1.Controls.Add(Me.CmbHeight1_)
        Me.TabPerson1.Controls.Add(Me.CmbSex1_)
        Me.TabPerson1.Controls.Add(Me.CmbRace1_)
        Me.TabPerson1.Controls.Add(Me.RbOther1_)
        Me.TabPerson1.Controls.Add(Me.RbSuspect1_)
        Me.TabPerson1.Controls.Add(Me.RbWitness1_)
        Me.TabPerson1.Controls.Add(Me.RbVictim1_)
        Me.TabPerson1.Controls.Add(Me.Label38)
        Me.TabPerson1.Controls.Add(Me.Txtname1_)
        Me.TabPerson1.Controls.Add(Me.Label40)
        Me.TabPerson1.Controls.Add(Me.Label18)
        Me.TabPerson1.Controls.Add(Me.Label34)
        Me.TabPerson1.Controls.Add(Me.Label21)
        Me.TabPerson1.Controls.Add(Me.Label39)
        Me.TabPerson1.Controls.Add(Me.TxtPersonAddress1_)
        Me.TabPerson1.Controls.Add(Me.LblWeight1)
        Me.TabPerson1.Controls.Add(Me.Label19)
        Me.TabPerson1.Controls.Add(Me.TxtDOB1_)
        Me.TabPerson1.Controls.Add(Me.TxtID1_)
        Me.TabPerson1.Controls.Add(Me.Label1)
        Me.TabPerson1.Controls.Add(Me.TxtWeight1)
        Me.TabPerson1.Controls.Add(Me.Label22)
        Me.TabPerson1.Controls.Add(Me.TxtAlias1_)
        Me.TabPerson1.Location = New System.Drawing.Point(4, 29)
        Me.TabPerson1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPerson1.Name = "TabPerson1"
        Me.TabPerson1.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPerson1.Size = New System.Drawing.Size(1176, 455)
        Me.TabPerson1.TabIndex = 0
        Me.TabPerson1.Text = "Person 1"
        Me.TabPerson1.UseVisualStyleBackColor = True
        '
        'TxtScarsTats1_
        '
        Me.TxtScarsTats1_.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtScarsTats1_.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtScarsTats1_.Location = New System.Drawing.Point(200, 349)
        Me.TxtScarsTats1_.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtScarsTats1_.Name = "TxtScarsTats1_"
        Me.TxtScarsTats1_.Size = New System.Drawing.Size(872, 28)
        Me.TxtScarsTats1_.TabIndex = 21
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(14, 351)
        Me.Label24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(179, 20)
        Me.Label24.TabIndex = 74
        Me.Label24.Text = "Scars, Marks or Tattoos"
        '
        'TxtOccupation1_
        '
        Me.TxtOccupation1_.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtOccupation1_.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOccupation1_.Location = New System.Drawing.Point(776, 249)
        Me.TxtOccupation1_.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtOccupation1_.Name = "TxtOccupation1_"
        Me.TxtOccupation1_.Size = New System.Drawing.Size(296, 28)
        Me.TxtOccupation1_.TabIndex = 14
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(666, 255)
        Me.Label23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(93, 20)
        Me.Label23.TabIndex = 72
        Me.Label23.Text = "Occupation"
        '
        'TxtPhone1_
        '
        Me.TxtPhone1_.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtPhone1_.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPhone1_.Location = New System.Drawing.Point(844, 145)
        Me.TxtPhone1_.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPhone1_.Name = "TxtPhone1_"
        Me.TxtPhone1_.Size = New System.Drawing.Size(228, 28)
        Me.TxtPhone1_.TabIndex = 13
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(784, 148)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(55, 20)
        Me.Label20.TabIndex = 70
        Me.Label20.Text = "Phone"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(395, 148)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(169, 20)
        Me.Label17.TabIndex = 69
        Me.Label17.Text = "Country of Citizenship"
        '
        'TxtCitizenship1_
        '
        Me.TxtCitizenship1_.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCitizenship1_.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCitizenship1_.Location = New System.Drawing.Point(566, 145)
        Me.TxtCitizenship1_.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtCitizenship1_.Name = "TxtCitizenship1_"
        Me.TxtCitizenship1_.Size = New System.Drawing.Size(194, 28)
        Me.TxtCitizenship1_.TabIndex = 11
        '
        'TxtPlaceofBirth1_
        '
        Me.TxtPlaceofBirth1_.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtPlaceofBirth1_.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPlaceofBirth1_.Location = New System.Drawing.Point(254, 145)
        Me.TxtPlaceofBirth1_.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPlaceofBirth1_.Name = "TxtPlaceofBirth1_"
        Me.TxtPlaceofBirth1_.Size = New System.Drawing.Size(127, 28)
        Me.TxtPlaceofBirth1_.TabIndex = 10
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(142, 148)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(104, 20)
        Me.Label16.TabIndex = 66
        Me.Label16.Text = "Place of Birth"
        '
        'lblAge1_
        '
        Me.lblAge1_.AutoSize = True
        Me.lblAge1_.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge1_.Location = New System.Drawing.Point(658, 96)
        Me.lblAge1_.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAge1_.Name = "lblAge1_"
        Me.lblAge1_.Size = New System.Drawing.Size(39, 20)
        Me.lblAge1_.TabIndex = 65
        Me.lblAge1_.Text = "Age"
        '
        'TxtAge1_
        '
        Me.TxtAge1_.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtAge1_.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAge1_.Location = New System.Drawing.Point(702, 93)
        Me.TxtAge1_.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtAge1_.Name = "TxtAge1_"
        Me.TxtAge1_.Size = New System.Drawing.Size(76, 28)
        Me.TxtAge1_.TabIndex = 7
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(14, 251)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(217, 20)
        Me.Label15.TabIndex = 63
        Me.Label15.Text = "Alias/Maiden or Other Name"
        '
        'CmbDrugAlcohol1_
        '
        Me.CmbDrugAlcohol1_.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbDrugAlcohol1_.FormattingEnabled = True
        Me.CmbDrugAlcohol1_.Items.AddRange(New Object() {"Yes", "No", "Unknown"})
        Me.CmbDrugAlcohol1_.Location = New System.Drawing.Point(958, 298)
        Me.CmbDrugAlcohol1_.Margin = New System.Windows.Forms.Padding(2)
        Me.CmbDrugAlcohol1_.Name = "CmbDrugAlcohol1_"
        Me.CmbDrugAlcohol1_.Size = New System.Drawing.Size(114, 28)
        Me.CmbDrugAlcohol1_.TabIndex = 20
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(770, 301)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(189, 20)
        Me.Label14.TabIndex = 61
        Me.Label14.Text = "Consumed Drug/Alcohol"
        '
        'CmbEyes1_
        '
        Me.CmbEyes1_.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbEyes1_.FormattingEnabled = True
        Me.CmbEyes1_.Items.AddRange(New Object() {"BLK", "GRN", "BLU", "GRY", "BRO", "HZL", "XXX"})
        Me.CmbEyes1_.Location = New System.Drawing.Point(550, 298)
        Me.CmbEyes1_.Margin = New System.Windows.Forms.Padding(2)
        Me.CmbEyes1_.Name = "CmbEyes1_"
        Me.CmbEyes1_.Size = New System.Drawing.Size(124, 28)
        Me.CmbEyes1_.TabIndex = 17
        Me.ToolTip2.SetToolTip(Me.CmbEyes1_, "BLK – Black" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "GRN – Green" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "BLU – Blue" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "GRY – Gray" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "BRO – Brown" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "HZL – Hazel")
        '
        'lblEyes1_
        '
        Me.lblEyes1_.AutoSize = True
        Me.lblEyes1_.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEyes1_.Location = New System.Drawing.Point(504, 301)
        Me.lblEyes1_.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEyes1_.Name = "lblEyes1_"
        Me.lblEyes1_.Size = New System.Drawing.Size(41, 20)
        Me.lblEyes1_.TabIndex = 59
        Me.lblEyes1_.Text = "Eyes"
        '
        'CmbHair1_
        '
        Me.CmbHair1_.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbHair1_.FormattingEnabled = True
        Me.CmbHair1_.Items.AddRange(New Object() {"BLK", "GRY", "RED", "BLD", "WHI", "BAL", "BRO", "XXX"})
        Me.CmbHair1_.Location = New System.Drawing.Point(372, 298)
        Me.CmbHair1_.Margin = New System.Windows.Forms.Padding(2)
        Me.CmbHair1_.Name = "CmbHair1_"
        Me.CmbHair1_.Size = New System.Drawing.Size(120, 28)
        Me.CmbHair1_.TabIndex = 16
        Me.ToolTip2.SetToolTip(Me.CmbHair1_, "BLK – Black " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "GRY – Grey/partially grey" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "RED – Red " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "BLD – Blonde" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHI – White " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) &
        "BAL – Bald" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "BRO – Brown")
        '
        'CmbState1_
        '
        Me.CmbState1_.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbState1_.FormattingEnabled = True
        Me.CmbState1_.Items.AddRange(New Object() {"Alabama", "Alaska", "American Samoa", "Arizona", "Arkansas", "California", "Colorado" & Global.Microsoft.VisualBasic.ChrW(9), "Connecticut", "Delaware" & Global.Microsoft.VisualBasic.ChrW(9), "District of Columbia", "Federated States of Micronesia", "Florida", "Georgia", "Guam", "Hawaii", "Idaho", "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky", "Louisiana" & Global.Microsoft.VisualBasic.ChrW(9), "Maine", "Marshall Islands", "Maryland" & Global.Microsoft.VisualBasic.ChrW(9), "Massachusetts", "Michigan", "Minnesota", "Mississippi", "Missouri", "Montana", "Nebraska" & Global.Microsoft.VisualBasic.ChrW(9), "Nevada", "New Hampshire", "New Jersey", "New Mexico", "New York" & Global.Microsoft.VisualBasic.ChrW(9), "North Carolina", "North Dakota", "Northern Mariana Islands", "Ohio", "Oklahoma", "Oregon", "Palau", "Pennsylvania", "Puerto Rico", "Rhode Island", "South Carolina", "South Dakota", "Tennessee", "Texas", "Utah", "Vermont", "Virgin Islands", "Virginia", "Washington", "West Virginia", "Wisconsin", "Wyoming", "CANADA", "Alberta", "British Columbia", "Manitoba", "New Brunswick", "Newfoundland and Labrador" & Global.Microsoft.VisualBasic.ChrW(9), "Northwest Territories", "Nova Scotia", "Nunavut", "Ontario", "Prince Edward Island", "Quebec", "Saskatchewan", "Yukon"})
        Me.CmbState1_.Location = New System.Drawing.Point(681, 196)
        Me.CmbState1_.Margin = New System.Windows.Forms.Padding(2)
        Me.CmbState1_.Name = "CmbState1_"
        Me.CmbState1_.Size = New System.Drawing.Size(162, 28)
        Me.CmbState1_.TabIndex = 19
        '
        'CmbHeight1_
        '
        Me.CmbHeight1_.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbHeight1_.FormattingEnabled = True
        Me.CmbHeight1_.Items.AddRange(New Object() {"6'5""", "6'4""", "6'3""", "6'2""", "6'1""", "6'0""", "5'11""", "5'10""", "5'9""", "5'8""", "5'7""", "5'6""", "5'5""", "5'4""", "5'3""", "5'2""", "5'1""", "5'0""", "4'9""", "4'8""", "4'7""", "4'6""", "4'5'", "Other"})
        Me.CmbHeight1_.Location = New System.Drawing.Point(89, 298)
        Me.CmbHeight1_.Margin = New System.Windows.Forms.Padding(2)
        Me.CmbHeight1_.Name = "CmbHeight1_"
        Me.CmbHeight1_.Size = New System.Drawing.Size(77, 28)
        Me.CmbHeight1_.TabIndex = 16
        '
        'CmbSex1_
        '
        Me.CmbSex1_.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSex1_.FormattingEnabled = True
        Me.CmbSex1_.Items.AddRange(New Object() {"M", "F"})
        Me.CmbSex1_.Location = New System.Drawing.Point(56, 145)
        Me.CmbSex1_.Margin = New System.Windows.Forms.Padding(2)
        Me.CmbSex1_.Name = "CmbSex1_"
        Me.CmbSex1_.Size = New System.Drawing.Size(68, 28)
        Me.CmbSex1_.TabIndex = 9
        '
        'CmbRace1_
        '
        Me.CmbRace1_.Font = New System.Drawing.Font("Microsoft JhengHei UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbRace1_.FormattingEnabled = True
        Me.CmbRace1_.Items.AddRange(New Object() {"Black or African American", "White", "American Indian or Alaska Native", "Asian", "Native Hawaiian or Other Pacific Islander", "Unknown"})
        Me.CmbRace1_.Location = New System.Drawing.Point(841, 93)
        Me.CmbRace1_.Margin = New System.Windows.Forms.Padding(2)
        Me.CmbRace1_.Name = "CmbRace1_"
        Me.CmbRace1_.Size = New System.Drawing.Size(231, 26)
        Me.CmbRace1_.TabIndex = 8
        Me.ToolTip2.SetToolTip(Me.CmbRace1_, "AI- American Indian or Alaska Native" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "A- Asian" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "B- Black or African American" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "H- " &
        "Hispanic or Latino" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "N- Native Hawaiian or Other Pacific Islander" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "W- White")
        '
        'RbOther1_
        '
        Me.RbOther1_.AutoSize = True
        Me.RbOther1_.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbOther1_.Location = New System.Drawing.Point(292, 40)
        Me.RbOther1_.Margin = New System.Windows.Forms.Padding(2)
        Me.RbOther1_.Name = "RbOther1_"
        Me.RbOther1_.Size = New System.Drawing.Size(71, 24)
        Me.RbOther1_.TabIndex = 4
        Me.RbOther1_.TabStop = True
        Me.RbOther1_.Text = "Other"
        Me.RbOther1_.UseVisualStyleBackColor = True
        '
        'RbSuspect1_
        '
        Me.RbSuspect1_.AutoSize = True
        Me.RbSuspect1_.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbSuspect1_.Location = New System.Drawing.Point(193, 40)
        Me.RbSuspect1_.Margin = New System.Windows.Forms.Padding(2)
        Me.RbSuspect1_.Name = "RbSuspect1_"
        Me.RbSuspect1_.Size = New System.Drawing.Size(87, 24)
        Me.RbSuspect1_.TabIndex = 3
        Me.RbSuspect1_.TabStop = True
        Me.RbSuspect1_.Text = "Suspect"
        Me.RbSuspect1_.UseVisualStyleBackColor = True
        '
        'RbWitness1_
        '
        Me.RbWitness1_.AutoSize = True
        Me.RbWitness1_.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbWitness1_.Location = New System.Drawing.Point(98, 40)
        Me.RbWitness1_.Margin = New System.Windows.Forms.Padding(2)
        Me.RbWitness1_.Name = "RbWitness1_"
        Me.RbWitness1_.Size = New System.Drawing.Size(89, 24)
        Me.RbWitness1_.TabIndex = 2
        Me.RbWitness1_.TabStop = True
        Me.RbWitness1_.Text = "Witness"
        Me.RbWitness1_.UseVisualStyleBackColor = True
        '
        'RbVictim1_
        '
        Me.RbVictim1_.AutoSize = True
        Me.RbVictim1_.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbVictim1_.Location = New System.Drawing.Point(14, 40)
        Me.RbVictim1_.Margin = New System.Windows.Forms.Padding(2)
        Me.RbVictim1_.Name = "RbVictim1_"
        Me.RbVictim1_.Size = New System.Drawing.Size(75, 24)
        Me.RbVictim1_.TabIndex = 1
        Me.RbVictim1_.TabStop = True
        Me.RbVictim1_.Text = "Victim"
        Me.RbVictim1_.UseVisualStyleBackColor = True
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(14, 199)
        Me.Label38.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(128, 20)
        Me.Label38.TabIndex = 44
        Me.Label38.Text = "Current Address"
        '
        'Txtname1_
        '
        Me.Txtname1_.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txtname1_.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtname1_.Location = New System.Drawing.Point(204, 93)
        Me.Txtname1_.Margin = New System.Windows.Forms.Padding(2)
        Me.Txtname1_.Name = "Txtname1_"
        Me.Txtname1_.Size = New System.Drawing.Size(283, 28)
        Me.Txtname1_.TabIndex = 5
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(14, 301)
        Me.Label40.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(59, 20)
        Me.Label40.TabIndex = 46
        Me.Label40.Text = "Height"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(329, 301)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(39, 20)
        Me.Label18.TabIndex = 44
        Me.Label18.Text = "Hair"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(493, 96)
        Me.Label34.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(41, 20)
        Me.Label34.TabIndex = 40
        Me.Label34.Text = "DOB"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(14, 96)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(194, 20)
        Me.Label21.TabIndex = 47
        Me.Label21.Text = "Name (Last, First, Middle)"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(862, 199)
        Me.Label39.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(34, 20)
        Me.Label39.TabIndex = 45
        Me.Label39.Text = "ID#"
        '
        'TxtPersonAddress1_
        '
        Me.TxtPersonAddress1_.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtPersonAddress1_.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPersonAddress1_.Location = New System.Drawing.Point(146, 196)
        Me.TxtPersonAddress1_.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPersonAddress1_.Name = "TxtPersonAddress1_"
        Me.TxtPersonAddress1_.Size = New System.Drawing.Size(388, 28)
        Me.TxtPersonAddress1_.TabIndex = 12
        '
        'LblWeight1
        '
        Me.LblWeight1.AutoSize = True
        Me.LblWeight1.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWeight1.Location = New System.Drawing.Point(184, 301)
        Me.LblWeight1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblWeight1.Name = "LblWeight1"
        Me.LblWeight1.Size = New System.Drawing.Size(62, 20)
        Me.LblWeight1.TabIndex = 46
        Me.LblWeight1.Text = "Weight"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(565, 199)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(116, 20)
        Me.Label19.TabIndex = 45
        Me.Label19.Text = "State/Province"
        '
        'TxtDOB1_
        '
        Me.TxtDOB1_.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDOB1_.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDOB1_.Location = New System.Drawing.Point(543, 93)
        Me.TxtDOB1_.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtDOB1_.Name = "TxtDOB1_"
        Me.TxtDOB1_.Size = New System.Drawing.Size(108, 28)
        Me.TxtDOB1_.TabIndex = 6
        '
        'TxtID1_
        '
        Me.TxtID1_.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtID1_.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtID1_.Location = New System.Drawing.Point(901, 196)
        Me.TxtID1_.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtID1_.Name = "TxtID1_"
        Me.TxtID1_.Size = New System.Drawing.Size(171, 28)
        Me.TxtID1_.TabIndex = 18
        Me.ToolTip2.SetToolTip(Me.TxtID1_, "Drfivers Licence or OLN")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(785, 96)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 20)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Race"
        '
        'TxtWeight1
        '
        Me.TxtWeight1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtWeight1.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtWeight1.Location = New System.Drawing.Point(248, 298)
        Me.TxtWeight1.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtWeight1.Name = "TxtWeight1"
        Me.TxtWeight1.Size = New System.Drawing.Size(76, 28)
        Me.TxtWeight1.TabIndex = 15
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(14, 148)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(35, 20)
        Me.Label22.TabIndex = 28
        Me.Label22.Text = "Sex"
        '
        'TxtAlias1_
        '
        Me.TxtAlias1_.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtAlias1_.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAlias1_.Location = New System.Drawing.Point(237, 249)
        Me.TxtAlias1_.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtAlias1_.Name = "TxtAlias1_"
        Me.TxtAlias1_.Size = New System.Drawing.Size(414, 28)
        Me.TxtAlias1_.TabIndex = 15
        '
        'TabPerson2
        '
        Me.TabPerson2.Controls.Add(Me.TextBox1)
        Me.TabPerson2.Controls.Add(Me.Label48)
        Me.TabPerson2.Controls.Add(Me.TextBox2)
        Me.TabPerson2.Controls.Add(Me.Label51)
        Me.TabPerson2.Controls.Add(Me.TextBox3)
        Me.TabPerson2.Controls.Add(Me.Label52)
        Me.TabPerson2.Controls.Add(Me.Label54)
        Me.TabPerson2.Controls.Add(Me.TextBox4)
        Me.TabPerson2.Controls.Add(Me.TextBox5)
        Me.TabPerson2.Controls.Add(Me.Label57)
        Me.TabPerson2.Controls.Add(Me.Label58)
        Me.TabPerson2.Controls.Add(Me.TextBox6)
        Me.TabPerson2.Controls.Add(Me.Label59)
        Me.TabPerson2.Controls.Add(Me.ComboBox1)
        Me.TabPerson2.Controls.Add(Me.Label60)
        Me.TabPerson2.Controls.Add(Me.ComboBox2)
        Me.TabPerson2.Controls.Add(Me.Label61)
        Me.TabPerson2.Controls.Add(Me.ComboBox3)
        Me.TabPerson2.Controls.Add(Me.ComboBox4)
        Me.TabPerson2.Controls.Add(Me.ComboBox5)
        Me.TabPerson2.Controls.Add(Me.ComboBox6)
        Me.TabPerson2.Controls.Add(Me.ComboBox7)
        Me.TabPerson2.Controls.Add(Me.RadioButton1)
        Me.TabPerson2.Controls.Add(Me.RadioButton2)
        Me.TabPerson2.Controls.Add(Me.RadioButton3)
        Me.TabPerson2.Controls.Add(Me.RadioButton4)
        Me.TabPerson2.Controls.Add(Me.Label62)
        Me.TabPerson2.Controls.Add(Me.TextBox7)
        Me.TabPerson2.Controls.Add(Me.Label63)
        Me.TabPerson2.Controls.Add(Me.Label64)
        Me.TabPerson2.Controls.Add(Me.Label65)
        Me.TabPerson2.Controls.Add(Me.Label66)
        Me.TabPerson2.Controls.Add(Me.Label67)
        Me.TabPerson2.Controls.Add(Me.TextBox8)
        Me.TabPerson2.Controls.Add(Me.Label68)
        Me.TabPerson2.Controls.Add(Me.Label69)
        Me.TabPerson2.Controls.Add(Me.TextBox9)
        Me.TabPerson2.Controls.Add(Me.TextBox10)
        Me.TabPerson2.Controls.Add(Me.Label70)
        Me.TabPerson2.Controls.Add(Me.TextBox11)
        Me.TabPerson2.Controls.Add(Me.Label71)
        Me.TabPerson2.Controls.Add(Me.TextBox12)
        Me.TabPerson2.Location = New System.Drawing.Point(4, 29)
        Me.TabPerson2.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPerson2.Name = "TabPerson2"
        Me.TabPerson2.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPerson2.Size = New System.Drawing.Size(1176, 455)
        Me.TabPerson2.TabIndex = 1
        Me.TabPerson2.Text = "Person 2"
        Me.TabPerson2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(200, 349)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(872, 28)
        Me.TextBox1.TabIndex = 97
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(14, 351)
        Me.Label48.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(179, 20)
        Me.Label48.TabIndex = 116
        Me.Label48.Text = "Scars, Marks or Tattoos"
        '
        'TextBox2
        '
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(776, 249)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(296, 28)
        Me.TextBox2.TabIndex = 88
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.Location = New System.Drawing.Point(666, 255)
        Me.Label51.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(93, 20)
        Me.Label51.TabIndex = 115
        Me.Label51.Text = "Occupation"
        '
        'TextBox3
        '
        Me.TextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(844, 145)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(228, 28)
        Me.TextBox3.TabIndex = 87
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.Location = New System.Drawing.Point(784, 148)
        Me.Label52.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(55, 20)
        Me.Label52.TabIndex = 114
        Me.Label52.Text = "Phone"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.Location = New System.Drawing.Point(395, 148)
        Me.Label54.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(169, 20)
        Me.Label54.TabIndex = 113
        Me.Label54.Text = "Country of Citizenship"
        '
        'TextBox4
        '
        Me.TextBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(566, 145)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(194, 28)
        Me.TextBox4.TabIndex = 85
        '
        'TextBox5
        '
        Me.TextBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(254, 145)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(127, 28)
        Me.TextBox5.TabIndex = 84
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.Location = New System.Drawing.Point(142, 148)
        Me.Label57.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(104, 20)
        Me.Label57.TabIndex = 112
        Me.Label57.Text = "Place of Birth"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.Location = New System.Drawing.Point(658, 96)
        Me.Label58.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(39, 20)
        Me.Label58.TabIndex = 111
        Me.Label58.Text = "Age"
        '
        'TextBox6
        '
        Me.TextBox6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(702, 93)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(76, 28)
        Me.TextBox6.TabIndex = 81
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.Location = New System.Drawing.Point(14, 251)
        Me.Label59.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(217, 20)
        Me.Label59.TabIndex = 110
        Me.Label59.Text = "Alias/Maiden or Other Name"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Yes", "No", "Unknown"})
        Me.ComboBox1.Location = New System.Drawing.Point(958, 298)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(114, 28)
        Me.ComboBox1.TabIndex = 96
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.Location = New System.Drawing.Point(770, 301)
        Me.Label60.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(189, 20)
        Me.Label60.TabIndex = 109
        Me.Label60.Text = "Consumed Drug/Alcohol"
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"BLK", "GRN", "BLU", "GRY", "BRO", "HZL", "XXX"})
        Me.ComboBox2.Location = New System.Drawing.Point(550, 298)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(124, 28)
        Me.ComboBox2.TabIndex = 93
        Me.ToolTip2.SetToolTip(Me.ComboBox2, "BLK – Black" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "GRN – Green" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "BLU – Blue" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "GRY – Gray" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "BRO – Brown" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "HZL – Hazel")
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.Location = New System.Drawing.Point(504, 301)
        Me.Label61.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(41, 20)
        Me.Label61.TabIndex = 108
        Me.Label61.Text = "Eyes"
        '
        'ComboBox3
        '
        Me.ComboBox3.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"BLK", "GRY", "RED", "BLD", "WHI", "BAL", "BRO", "XXX"})
        Me.ComboBox3.Location = New System.Drawing.Point(372, 298)
        Me.ComboBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(120, 28)
        Me.ComboBox3.TabIndex = 91
        Me.ToolTip2.SetToolTip(Me.ComboBox3, "BLK – Black " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "GRY – Grey/partially grey" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "RED – Red " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "BLD – Blonde" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHI – White " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) &
        "BAL – Bald" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "BRO – Brown")
        '
        'ComboBox4
        '
        Me.ComboBox4.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"Alabama", "Alaska", "American Samoa", "Arizona", "Arkansas", "California", "Colorado" & Global.Microsoft.VisualBasic.ChrW(9), "Connecticut", "Delaware" & Global.Microsoft.VisualBasic.ChrW(9), "District of Columbia", "Federated States of Micronesia", "Florida", "Georgia", "Guam", "Hawaii", "Idaho", "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky", "Louisiana" & Global.Microsoft.VisualBasic.ChrW(9), "Maine", "Marshall Islands", "Maryland" & Global.Microsoft.VisualBasic.ChrW(9), "Massachusetts", "Michigan", "Minnesota", "Mississippi", "Missouri", "Montana", "Nebraska" & Global.Microsoft.VisualBasic.ChrW(9), "Nevada", "New Hampshire", "New Jersey", "New Mexico", "New York" & Global.Microsoft.VisualBasic.ChrW(9), "North Carolina", "North Dakota", "Northern Mariana Islands", "Ohio", "Oklahoma", "Oregon", "Palau", "Pennsylvania", "Puerto Rico", "Rhode Island", "South Carolina", "South Dakota", "Tennessee", "Texas", "Utah", "Vermont", "Virgin Islands", "Virginia", "Washington", "West Virginia", "Wisconsin", "Wyoming", "CANADA", "Alberta", "British Columbia", "Manitoba", "New Brunswick", "Newfoundland and Labrador" & Global.Microsoft.VisualBasic.ChrW(9), "Northwest Territories", "Nova Scotia", "Nunavut", "Ontario", "Prince Edward Island", "Quebec", "Saskatchewan", "Yukon"})
        Me.ComboBox4.Location = New System.Drawing.Point(681, 196)
        Me.ComboBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(162, 28)
        Me.ComboBox4.TabIndex = 95
        '
        'ComboBox5
        '
        Me.ComboBox5.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Items.AddRange(New Object() {"6'5""", "6'4""", "6'3""", "6'2""", "6'1""", "6'0""", "5'11""", "5'10""", "5'9""", "5'8""", "5'7""", "5'6""", "5'5""", "5'4""", "5'3""", "5'2""", "5'1""", "5'0""", "4'9""", "4'8""", "4'7""", "4'6""", "4'5'", "Other"})
        Me.ComboBox5.Location = New System.Drawing.Point(89, 298)
        Me.ComboBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(77, 28)
        Me.ComboBox5.TabIndex = 92
        '
        'ComboBox6
        '
        Me.ComboBox6.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Items.AddRange(New Object() {"M", "F"})
        Me.ComboBox6.Location = New System.Drawing.Point(56, 145)
        Me.ComboBox6.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(68, 28)
        Me.ComboBox6.TabIndex = 83
        '
        'ComboBox7
        '
        Me.ComboBox7.Font = New System.Drawing.Font("Microsoft JhengHei UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox7.FormattingEnabled = True
        Me.ComboBox7.Items.AddRange(New Object() {"Black or African American", "White", "American Indian or Alaska Native", "Asian", "Native Hawaiian or Other Pacific Islander", "Unknown"})
        Me.ComboBox7.Location = New System.Drawing.Point(841, 93)
        Me.ComboBox7.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox7.Name = "ComboBox7"
        Me.ComboBox7.Size = New System.Drawing.Size(231, 26)
        Me.ComboBox7.TabIndex = 82
        Me.ToolTip2.SetToolTip(Me.ComboBox7, "AI- American Indian or Alaska Native" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "A- Asian" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "B- Black or African American" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "H- " &
        "Hispanic or Latino" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "N- Native Hawaiian or Other Pacific Islander" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "W- White")
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(292, 40)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(71, 24)
        Me.RadioButton1.TabIndex = 78
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Other"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(193, 40)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(87, 24)
        Me.RadioButton2.TabIndex = 77
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Suspect"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.Location = New System.Drawing.Point(98, 40)
        Me.RadioButton3.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(89, 24)
        Me.RadioButton3.TabIndex = 76
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Witness"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton4.Location = New System.Drawing.Point(14, 40)
        Me.RadioButton4.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(75, 24)
        Me.RadioButton4.TabIndex = 75
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Victim"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.Location = New System.Drawing.Point(14, 199)
        Me.Label62.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(128, 20)
        Me.Label62.TabIndex = 101
        Me.Label62.Text = "Current Address"
        '
        'TextBox7
        '
        Me.TextBox7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox7.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(204, 93)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(283, 28)
        Me.TextBox7.TabIndex = 79
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.Location = New System.Drawing.Point(14, 301)
        Me.Label63.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(59, 20)
        Me.Label63.TabIndex = 106
        Me.Label63.Text = "Height"
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.Location = New System.Drawing.Point(329, 301)
        Me.Label64.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(39, 20)
        Me.Label64.TabIndex = 102
        Me.Label64.Text = "Hair"
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.Location = New System.Drawing.Point(493, 96)
        Me.Label65.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(41, 20)
        Me.Label65.TabIndex = 100
        Me.Label65.Text = "DOB"
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.Location = New System.Drawing.Point(14, 96)
        Me.Label66.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(194, 20)
        Me.Label66.TabIndex = 107
        Me.Label66.Text = "Name (Last, First, Middle)"
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.Location = New System.Drawing.Point(862, 199)
        Me.Label67.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(34, 20)
        Me.Label67.TabIndex = 104
        Me.Label67.Text = "ID#"
        '
        'TextBox8
        '
        Me.TextBox8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox8.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(146, 196)
        Me.TextBox8.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(388, 28)
        Me.TextBox8.TabIndex = 86
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.Location = New System.Drawing.Point(184, 301)
        Me.Label68.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(62, 20)
        Me.Label68.TabIndex = 105
        Me.Label68.Text = "Weight"
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.Location = New System.Drawing.Point(565, 199)
        Me.Label69.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(116, 20)
        Me.Label69.TabIndex = 103
        Me.Label69.Text = "State/Province"
        '
        'TextBox9
        '
        Me.TextBox9.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox9.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9.Location = New System.Drawing.Point(543, 93)
        Me.TextBox9.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(108, 28)
        Me.TextBox9.TabIndex = 80
        '
        'TextBox10
        '
        Me.TextBox10.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox10.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox10.Location = New System.Drawing.Point(901, 196)
        Me.TextBox10.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(171, 28)
        Me.TextBox10.TabIndex = 94
        Me.ToolTip2.SetToolTip(Me.TextBox10, "Drfivers Licence or OLN")
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label70.Location = New System.Drawing.Point(785, 96)
        Me.Label70.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(44, 20)
        Me.Label70.TabIndex = 99
        Me.Label70.Text = "Race"
        '
        'TextBox11
        '
        Me.TextBox11.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox11.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox11.Location = New System.Drawing.Point(248, 298)
        Me.TextBox11.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(76, 28)
        Me.TextBox11.TabIndex = 89
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label71.Location = New System.Drawing.Point(14, 148)
        Me.Label71.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(35, 20)
        Me.Label71.TabIndex = 98
        Me.Label71.Text = "Sex"
        '
        'TextBox12
        '
        Me.TextBox12.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox12.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox12.Location = New System.Drawing.Point(237, 249)
        Me.TextBox12.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(414, 28)
        Me.TextBox12.TabIndex = 90
        '
        'TabVehicle1
        '
        Me.TabVehicle1.Controls.Add(Me.GroupBox3)
        Me.TabVehicle1.Controls.Add(Me.GroupBox2)
        Me.TabVehicle1.Location = New System.Drawing.Point(4, 29)
        Me.TabVehicle1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabVehicle1.Name = "TabVehicle1"
        Me.TabVehicle1.Size = New System.Drawing.Size(1176, 455)
        Me.TabVehicle1.TabIndex = 3
        Me.TabVehicle1.Text = "Vehicle 1, 2"
        Me.TabVehicle1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TxtVehicle2VIN_)
        Me.GroupBox3.Controls.Add(Me.Label28)
        Me.GroupBox3.Controls.Add(Me.RbVehicle2Other_)
        Me.GroupBox3.Controls.Add(Me.RbVehicle2Suspect_)
        Me.GroupBox3.Controls.Add(Me.RbVehicle2Witness_)
        Me.GroupBox3.Controls.Add(Me.RbVehicle2Victim_)
        Me.GroupBox3.Controls.Add(Me.TxtVehicle2Identifying_)
        Me.GroupBox3.Controls.Add(Me.Label29)
        Me.GroupBox3.Controls.Add(Me.CmbV2Color_)
        Me.GroupBox3.Controls.Add(Me.CmbStyle2_)
        Me.GroupBox3.Controls.Add(Me.Label30)
        Me.GroupBox3.Controls.Add(Me.Label31)
        Me.GroupBox3.Controls.Add(Me.Label32)
        Me.GroupBox3.Controls.Add(Me.Label33)
        Me.GroupBox3.Controls.Add(Me.TxtV2Year_)
        Me.GroupBox3.Controls.Add(Me.CmbVeh2Disposition_)
        Me.GroupBox3.Controls.Add(Me.CmbV2Make_)
        Me.GroupBox3.Controls.Add(Me.Label35)
        Me.GroupBox3.Controls.Add(Me.Label36)
        Me.GroupBox3.Controls.Add(Me.V2model_)
        Me.GroupBox3.Location = New System.Drawing.Point(18, 246)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(1067, 209)
        Me.GroupBox3.TabIndex = 29
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Vehicle 2"
        '
        'TxtVehicle2VIN_
        '
        Me.TxtVehicle2VIN_.Location = New System.Drawing.Point(750, 110)
        Me.TxtVehicle2VIN_.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtVehicle2VIN_.MaxLength = 17
        Me.TxtVehicle2VIN_.Name = "TxtVehicle2VIN_"
        Me.TxtVehicle2VIN_.Size = New System.Drawing.Size(264, 28)
        Me.TxtVehicle2VIN_.TabIndex = 35
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(710, 114)
        Me.Label28.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(38, 20)
        Me.Label28.TabIndex = 34
        Me.Label28.Text = "VIN"
        '
        'RbVehicle2Other_
        '
        Me.RbVehicle2Other_.AutoSize = True
        Me.RbVehicle2Other_.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbVehicle2Other_.Location = New System.Drawing.Point(266, 32)
        Me.RbVehicle2Other_.Margin = New System.Windows.Forms.Padding(2)
        Me.RbVehicle2Other_.Name = "RbVehicle2Other_"
        Me.RbVehicle2Other_.Size = New System.Drawing.Size(71, 24)
        Me.RbVehicle2Other_.TabIndex = 33
        Me.RbVehicle2Other_.TabStop = True
        Me.RbVehicle2Other_.Text = "Other"
        Me.RbVehicle2Other_.UseVisualStyleBackColor = True
        '
        'RbVehicle2Suspect_
        '
        Me.RbVehicle2Suspect_.AutoSize = True
        Me.RbVehicle2Suspect_.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbVehicle2Suspect_.Location = New System.Drawing.Point(175, 32)
        Me.RbVehicle2Suspect_.Margin = New System.Windows.Forms.Padding(2)
        Me.RbVehicle2Suspect_.Name = "RbVehicle2Suspect_"
        Me.RbVehicle2Suspect_.Size = New System.Drawing.Size(87, 24)
        Me.RbVehicle2Suspect_.TabIndex = 32
        Me.RbVehicle2Suspect_.TabStop = True
        Me.RbVehicle2Suspect_.Text = "Suspect"
        Me.RbVehicle2Suspect_.UseVisualStyleBackColor = True
        '
        'RbVehicle2Witness_
        '
        Me.RbVehicle2Witness_.AutoSize = True
        Me.RbVehicle2Witness_.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbVehicle2Witness_.Location = New System.Drawing.Point(90, 32)
        Me.RbVehicle2Witness_.Margin = New System.Windows.Forms.Padding(2)
        Me.RbVehicle2Witness_.Name = "RbVehicle2Witness_"
        Me.RbVehicle2Witness_.Size = New System.Drawing.Size(89, 24)
        Me.RbVehicle2Witness_.TabIndex = 31
        Me.RbVehicle2Witness_.TabStop = True
        Me.RbVehicle2Witness_.Text = "Witness"
        Me.RbVehicle2Witness_.UseVisualStyleBackColor = True
        '
        'RbVehicle2Victim_
        '
        Me.RbVehicle2Victim_.AutoSize = True
        Me.RbVehicle2Victim_.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbVehicle2Victim_.Location = New System.Drawing.Point(15, 32)
        Me.RbVehicle2Victim_.Margin = New System.Windows.Forms.Padding(2)
        Me.RbVehicle2Victim_.Name = "RbVehicle2Victim_"
        Me.RbVehicle2Victim_.Size = New System.Drawing.Size(75, 24)
        Me.RbVehicle2Victim_.TabIndex = 30
        Me.RbVehicle2Victim_.TabStop = True
        Me.RbVehicle2Victim_.Text = "Victim"
        Me.RbVehicle2Victim_.UseVisualStyleBackColor = True
        '
        'TxtVehicle2Identifying_
        '
        Me.TxtVehicle2Identifying_.Location = New System.Drawing.Point(239, 151)
        Me.TxtVehicle2Identifying_.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtVehicle2Identifying_.Name = "TxtVehicle2Identifying_"
        Me.TxtVehicle2Identifying_.Size = New System.Drawing.Size(365, 28)
        Me.TxtVehicle2Identifying_.TabIndex = 29
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(10, 154)
        Me.Label29.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(200, 20)
        Me.Label29.TabIndex = 28
        Me.Label29.Text = "Identifying Characteritics"
        '
        'CmbV2Color_
        '
        Me.CmbV2Color_.FormattingEnabled = True
        Me.CmbV2Color_.Items.AddRange(New Object() {"Red", "Orange", "Yellow", "Green", "Blue", "Purple", "Brown", "Magenta", "Tan", "Cyan", "Olive", "Maroon", "Navy", "Aquamarine", "Turquoise", "Silver", "Lime", "Teal", "Indigo", "Violet", "Pink", "Black", "White", "Gray"})
        Me.CmbV2Color_.Location = New System.Drawing.Point(890, 71)
        Me.CmbV2Color_.Margin = New System.Windows.Forms.Padding(2)
        Me.CmbV2Color_.Name = "CmbV2Color_"
        Me.CmbV2Color_.Size = New System.Drawing.Size(124, 28)
        Me.CmbV2Color_.TabIndex = 16
        '
        'CmbStyle2_
        '
        Me.CmbStyle2_.FormattingEnabled = True
        Me.CmbStyle2_.Items.AddRange(New Object() {"Sedan", "Sedan 2 Dr", "Sedan 4 Dr", "Special", "Station Wagon 2 Dr", "Station Wagon 4 Dr", "Station Wagon 5 Dr", "Convertible 2 Dr", "Convertible 3 Dr", "Convertible 4 Dr", "Coupe", "Hardtop 2 Dr", "Hardtop 4 Dr", "Hatchback", "Hatchback 2 Dr", "Hatchback 4 Dr", "Hearse", "Jeep", "Limousine", "Motorized Home", "Pickup", "Pickup 1/2 Ton", "Pickup 3/4 Ton", "Recreational Vehicle", "Recreational Van", "Roadster", "Van 1/2 Ton", "Van 3/4 Ton", "Motorcycle", "All Terrain Vehicle", "Golf Cart", "Ambulance", "Special Service Vehicle"})
        Me.CmbStyle2_.Location = New System.Drawing.Point(434, 110)
        Me.CmbStyle2_.Margin = New System.Windows.Forms.Padding(2)
        Me.CmbStyle2_.Name = "CmbStyle2_"
        Me.CmbStyle2_.Size = New System.Drawing.Size(259, 28)
        Me.CmbStyle2_.TabIndex = 27
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(770, 74)
        Me.Label30.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(109, 20)
        Me.Label30.TabIndex = 17
        Me.Label30.Text = "Vehicle Color"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(381, 114)
        Me.Label31.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(46, 20)
        Me.Label31.TabIndex = 26
        Me.Label31.Text = "Style"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(10, 74)
        Me.Label32.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(102, 20)
        Me.Label32.TabIndex = 18
        Me.Label32.Text = "Vehicle Year"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(10, 114)
        Me.Label33.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(154, 20)
        Me.Label33.TabIndex = 25
        Me.Label33.Text = "Vehicle Disposition"
        '
        'TxtV2Year_
        '
        Me.TxtV2Year_.Location = New System.Drawing.Point(126, 71)
        Me.TxtV2Year_.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtV2Year_.Name = "TxtV2Year_"
        Me.TxtV2Year_.Size = New System.Drawing.Size(84, 28)
        Me.TxtV2Year_.TabIndex = 19
        '
        'CmbVeh2Disposition_
        '
        Me.CmbVeh2Disposition_.FormattingEnabled = True
        Me.CmbVeh2Disposition_.Items.AddRange(New Object() {"None", "Impounded", "Stolen", "Damaged", "Witness", "Left Scene", "Towed from Scene"})
        Me.CmbVeh2Disposition_.Location = New System.Drawing.Point(176, 110)
        Me.CmbVeh2Disposition_.Margin = New System.Windows.Forms.Padding(2)
        Me.CmbVeh2Disposition_.Name = "CmbVeh2Disposition_"
        Me.CmbVeh2Disposition_.Size = New System.Drawing.Size(194, 28)
        Me.CmbVeh2Disposition_.TabIndex = 24
        '
        'CmbV2Make_
        '
        Me.CmbV2Make_.FormattingEnabled = True
        Me.CmbV2Make_.Items.AddRange(New Object() {"Alfa Romeo", "Alpina", "Aston Martin", "Audi", "Bentley", "BMW", "Citroen", "Dacia", "DS", "Ferrari", "Fiat", "Ford", "Honda", "Hyundai", "Infiniti", "Jaguar", "Jeep", "Kia", "Lamborghini", "Land Rover", "Lexus", "Lotus", "Maserati", "Mazda", "McLaren", "Mercedes-Benz", "MG", "Mini", "Mitsubishi", "Morgan", "Nissan", "Peugeot", "Porsche", "Renault", "Rolls-Royce", "Seat", "Skoda", "Smart", "SsangYong", "Subaru", "Suzuki", "Tesla", "Toyota", "Vauxhall", "Volkswagen", "Volvo"})
        Me.CmbV2Make_.Location = New System.Drawing.Point(336, 71)
        Me.CmbV2Make_.Margin = New System.Windows.Forms.Padding(2)
        Me.CmbV2Make_.Name = "CmbV2Make_"
        Me.CmbV2Make_.Size = New System.Drawing.Size(129, 28)
        Me.CmbV2Make_.TabIndex = 20
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(480, 74)
        Me.Label35.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(117, 20)
        Me.Label35.TabIndex = 23
        Me.Label35.Text = "Vehicle Model"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(220, 74)
        Me.Label36.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(111, 20)
        Me.Label36.TabIndex = 21
        Me.Label36.Text = "Vehicle Make"
        '
        'V2model_
        '
        Me.V2model_.Location = New System.Drawing.Point(607, 71)
        Me.V2model_.Margin = New System.Windows.Forms.Padding(2)
        Me.V2model_.Name = "V2model_"
        Me.V2model_.Size = New System.Drawing.Size(143, 28)
        Me.V2model_.TabIndex = 22
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtVehicle1VIN_)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.RbVehicle1Other_)
        Me.GroupBox2.Controls.Add(Me.RbVehicle1Suspect_)
        Me.GroupBox2.Controls.Add(Me.RbVehicle1Witness_)
        Me.GroupBox2.Controls.Add(Me.RbVehicle1Victim_)
        Me.GroupBox2.Controls.Add(Me.TxtVehicle1Identifying_)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.CmbV1Color_)
        Me.GroupBox2.Controls.Add(Me.CmbStyle1_)
        Me.GroupBox2.Controls.Add(Me.Label49)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.Label50)
        Me.GroupBox2.Controls.Add(Me.Label56)
        Me.GroupBox2.Controls.Add(Me.TxtV1Year_)
        Me.GroupBox2.Controls.Add(Me.CmbVeh1Disposition_)
        Me.GroupBox2.Controls.Add(Me.CmbV1Make_)
        Me.GroupBox2.Controls.Add(Me.Label55)
        Me.GroupBox2.Controls.Add(Me.Label53)
        Me.GroupBox2.Controls.Add(Me.V1model_)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 21)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(1067, 209)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Vehicle 1"
        '
        'TxtVehicle1VIN_
        '
        Me.TxtVehicle1VIN_.Location = New System.Drawing.Point(751, 110)
        Me.TxtVehicle1VIN_.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtVehicle1VIN_.MaxLength = 17
        Me.TxtVehicle1VIN_.Name = "TxtVehicle1VIN_"
        Me.TxtVehicle1VIN_.Size = New System.Drawing.Size(264, 28)
        Me.TxtVehicle1VIN_.TabIndex = 35
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(710, 114)
        Me.Label27.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(38, 20)
        Me.Label27.TabIndex = 34
        Me.Label27.Text = "VIN"
        '
        'RbVehicle1Other_
        '
        Me.RbVehicle1Other_.AutoSize = True
        Me.RbVehicle1Other_.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbVehicle1Other_.Location = New System.Drawing.Point(266, 32)
        Me.RbVehicle1Other_.Margin = New System.Windows.Forms.Padding(2)
        Me.RbVehicle1Other_.Name = "RbVehicle1Other_"
        Me.RbVehicle1Other_.Size = New System.Drawing.Size(71, 24)
        Me.RbVehicle1Other_.TabIndex = 33
        Me.RbVehicle1Other_.TabStop = True
        Me.RbVehicle1Other_.Text = "Other"
        Me.RbVehicle1Other_.UseVisualStyleBackColor = True
        '
        'RbVehicle1Suspect_
        '
        Me.RbVehicle1Suspect_.AutoSize = True
        Me.RbVehicle1Suspect_.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbVehicle1Suspect_.Location = New System.Drawing.Point(175, 32)
        Me.RbVehicle1Suspect_.Margin = New System.Windows.Forms.Padding(2)
        Me.RbVehicle1Suspect_.Name = "RbVehicle1Suspect_"
        Me.RbVehicle1Suspect_.Size = New System.Drawing.Size(87, 24)
        Me.RbVehicle1Suspect_.TabIndex = 32
        Me.RbVehicle1Suspect_.TabStop = True
        Me.RbVehicle1Suspect_.Text = "Suspect"
        Me.RbVehicle1Suspect_.UseVisualStyleBackColor = True
        '
        'RbVehicle1Witness_
        '
        Me.RbVehicle1Witness_.AutoSize = True
        Me.RbVehicle1Witness_.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbVehicle1Witness_.Location = New System.Drawing.Point(90, 32)
        Me.RbVehicle1Witness_.Margin = New System.Windows.Forms.Padding(2)
        Me.RbVehicle1Witness_.Name = "RbVehicle1Witness_"
        Me.RbVehicle1Witness_.Size = New System.Drawing.Size(89, 24)
        Me.RbVehicle1Witness_.TabIndex = 31
        Me.RbVehicle1Witness_.TabStop = True
        Me.RbVehicle1Witness_.Text = "Witness"
        Me.RbVehicle1Witness_.UseVisualStyleBackColor = True
        '
        'RbVehicle1Victim_
        '
        Me.RbVehicle1Victim_.AutoSize = True
        Me.RbVehicle1Victim_.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbVehicle1Victim_.Location = New System.Drawing.Point(15, 32)
        Me.RbVehicle1Victim_.Margin = New System.Windows.Forms.Padding(2)
        Me.RbVehicle1Victim_.Name = "RbVehicle1Victim_"
        Me.RbVehicle1Victim_.Size = New System.Drawing.Size(75, 24)
        Me.RbVehicle1Victim_.TabIndex = 30
        Me.RbVehicle1Victim_.TabStop = True
        Me.RbVehicle1Victim_.Text = "Victim"
        Me.RbVehicle1Victim_.UseVisualStyleBackColor = True
        '
        'TxtVehicle1Identifying_
        '
        Me.TxtVehicle1Identifying_.Location = New System.Drawing.Point(239, 151)
        Me.TxtVehicle1Identifying_.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtVehicle1Identifying_.Name = "TxtVehicle1Identifying_"
        Me.TxtVehicle1Identifying_.Size = New System.Drawing.Size(365, 28)
        Me.TxtVehicle1Identifying_.TabIndex = 29
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(10, 154)
        Me.Label26.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(200, 20)
        Me.Label26.TabIndex = 28
        Me.Label26.Text = "Identifying Characteritics"
        '
        'CmbV1Color_
        '
        Me.CmbV1Color_.FormattingEnabled = True
        Me.CmbV1Color_.Items.AddRange(New Object() {"Red", "Orange", "Yellow", "Green", "Blue", "Purple", "Brown", "Magenta", "Tan", "Cyan", "Olive", "Maroon", "Navy", "Aquamarine", "Turquoise", "Silver", "Lime", "Teal", "Indigo", "Violet", "Pink", "Black", "White", "Gray"})
        Me.CmbV1Color_.Location = New System.Drawing.Point(890, 71)
        Me.CmbV1Color_.Margin = New System.Windows.Forms.Padding(2)
        Me.CmbV1Color_.Name = "CmbV1Color_"
        Me.CmbV1Color_.Size = New System.Drawing.Size(124, 28)
        Me.CmbV1Color_.TabIndex = 16
        '
        'CmbStyle1_
        '
        Me.CmbStyle1_.FormattingEnabled = True
        Me.CmbStyle1_.Items.AddRange(New Object() {"Sedan", "Sedan 2 Dr", "Sedan 4 Dr", "Special", "Station Wagon 2 Dr", "Station Wagon 4 Dr", "Station Wagon 5 Dr", "Convertible 2 Dr", "Convertible 3 Dr", "Convertible 4 Dr", "Coupe", "Hardtop 2 Dr", "Hardtop 4 Dr", "Hatchback", "Hatchback 2 Dr", "Hatchback 4 Dr", "Hearse", "Jeep", "Limousine", "Motorized Home", "Pickup", "Pickup 1/2 Ton", "Pickup 3/4 Ton", "Recreational Vehicle", "Recreational Van", "Roadster", "Van 1/2 Ton", "Van 3/4 Ton", "Motorcycle", "All Terrain Vehicle", "Golf Cart", "Ambulance", "Special Service Vehicle"})
        Me.CmbStyle1_.Location = New System.Drawing.Point(435, 110)
        Me.CmbStyle1_.Margin = New System.Windows.Forms.Padding(2)
        Me.CmbStyle1_.Name = "CmbStyle1_"
        Me.CmbStyle1_.Size = New System.Drawing.Size(259, 28)
        Me.CmbStyle1_.TabIndex = 27
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(770, 74)
        Me.Label49.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(109, 20)
        Me.Label49.TabIndex = 17
        Me.Label49.Text = "Vehicle Color"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(381, 114)
        Me.Label25.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(46, 20)
        Me.Label25.TabIndex = 26
        Me.Label25.Text = "Style"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(10, 74)
        Me.Label50.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(102, 20)
        Me.Label50.TabIndex = 18
        Me.Label50.Text = "Vehicle Year"
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Location = New System.Drawing.Point(10, 114)
        Me.Label56.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(154, 20)
        Me.Label56.TabIndex = 25
        Me.Label56.Text = "Vehicle Disposition"
        '
        'TxtV1Year_
        '
        Me.TxtV1Year_.Location = New System.Drawing.Point(126, 71)
        Me.TxtV1Year_.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtV1Year_.Name = "TxtV1Year_"
        Me.TxtV1Year_.Size = New System.Drawing.Size(84, 28)
        Me.TxtV1Year_.TabIndex = 19
        '
        'CmbVeh1Disposition_
        '
        Me.CmbVeh1Disposition_.FormattingEnabled = True
        Me.CmbVeh1Disposition_.Items.AddRange(New Object() {"None", "Impounded", "Stolen", "Damaged", "Witness", "Left Scene", "Towed from Scene"})
        Me.CmbVeh1Disposition_.Location = New System.Drawing.Point(176, 110)
        Me.CmbVeh1Disposition_.Margin = New System.Windows.Forms.Padding(2)
        Me.CmbVeh1Disposition_.Name = "CmbVeh1Disposition_"
        Me.CmbVeh1Disposition_.Size = New System.Drawing.Size(194, 28)
        Me.CmbVeh1Disposition_.TabIndex = 24
        '
        'CmbV1Make_
        '
        Me.CmbV1Make_.FormattingEnabled = True
        Me.CmbV1Make_.Items.AddRange(New Object() {"Alfa Romeo", "Alpina", "Aston Martin", "Audi", "Bentley", "BMW", "Citroen", "Dacia", "DS", "Ferrari", "Fiat", "Ford", "Honda", "Hyundai", "Infiniti", "Jaguar", "Jeep", "Kia", "Lamborghini", "Land Rover", "Lexus", "Lotus", "Maserati", "Mazda", "McLaren", "Mercedes-Benz", "MG", "Mini", "Mitsubishi", "Morgan", "Nissan", "Peugeot", "Porsche", "Renault", "Rolls-Royce", "Seat", "Skoda", "Smart", "SsangYong", "Subaru", "Suzuki", "Tesla", "Toyota", "Vauxhall", "Volkswagen", "Volvo"})
        Me.CmbV1Make_.Location = New System.Drawing.Point(336, 71)
        Me.CmbV1Make_.Margin = New System.Windows.Forms.Padding(2)
        Me.CmbV1Make_.Name = "CmbV1Make_"
        Me.CmbV1Make_.Size = New System.Drawing.Size(129, 28)
        Me.CmbV1Make_.TabIndex = 20
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Location = New System.Drawing.Point(480, 74)
        Me.Label55.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(117, 20)
        Me.Label55.TabIndex = 23
        Me.Label55.Text = "Vehicle Model"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Location = New System.Drawing.Point(220, 74)
        Me.Label53.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(111, 20)
        Me.Label53.TabIndex = 21
        Me.Label53.Text = "Vehicle Make"
        '
        'V1model_
        '
        Me.V1model_.Location = New System.Drawing.Point(607, 71)
        Me.V1model_.Margin = New System.Windows.Forms.Padding(2)
        Me.V1model_.Name = "V1model_"
        Me.V1model_.Size = New System.Drawing.Size(143, 28)
        Me.V1model_.TabIndex = 22
        '
        'TabVehicle2
        '
        Me.TabVehicle2.Controls.Add(Me.Label41)
        Me.TabVehicle2.Location = New System.Drawing.Point(4, 29)
        Me.TabVehicle2.Margin = New System.Windows.Forms.Padding(2)
        Me.TabVehicle2.Name = "TabVehicle2"
        Me.TabVehicle2.Size = New System.Drawing.Size(1176, 455)
        Me.TabVehicle2.TabIndex = 4
        Me.TabVehicle2.Text = "Vehicle 3,4"
        Me.TabVehicle2.UseVisualStyleBackColor = True
        '
        'Label41
        '
        Me.Label41.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(512, 210)
        Me.Label41.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(116, 20)
        Me.Label41.TabIndex = 0
        Me.Label41.Text = "Coming Soon."
        '
        'TabNarrative
        '
        Me.TabNarrative.Controls.Add(Me.RichTextBox1)
        Me.TabNarrative.Controls.Add(Me.Label37)
        Me.TabNarrative.Location = New System.Drawing.Point(4, 29)
        Me.TabNarrative.Margin = New System.Windows.Forms.Padding(2)
        Me.TabNarrative.Name = "TabNarrative"
        Me.TabNarrative.Size = New System.Drawing.Size(1176, 455)
        Me.TabNarrative.TabIndex = 5
        Me.TabNarrative.Text = "Narrative"
        Me.TabNarrative.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(16, 45)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(983, 370)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = ""
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(12, 13)
        Me.Label37.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(239, 20)
        Me.Label37.TabIndex = 0
        Me.Label37.Text = "Case Narrative. Be descriptive."
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(387, 503)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 28)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "View"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblFileDate
        '
        Me.lblFileDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFileDate.BackColor = System.Drawing.Color.Transparent
        Me.lblFileDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFileDate.ForeColor = System.Drawing.Color.Black
        Me.lblFileDate.Location = New System.Drawing.Point(855, 1)
        Me.lblFileDate.Name = "lblFileDate"
        Me.lblFileDate.Size = New System.Drawing.Size(126, 27)
        Me.lblFileDate.TabIndex = 20
        Me.lblFileDate.Text = "00.00.0000"
        Me.lblFileDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'tmrStats
        '
        Me.tmrStats.Enabled = True
        '
        'btnFwd
        '
        Me.btnFwd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFwd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFwd.FlatAppearance.BorderSize = 0
        Me.btnFwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFwd.Image = Global.DailyLog.My.Resources.Resources.arrow_right
        Me.btnFwd.Location = New System.Drawing.Point(976, -3)
        Me.btnFwd.Name = "btnFwd"
        Me.btnFwd.Size = New System.Drawing.Size(35, 35)
        Me.btnFwd.TabIndex = 19
        Me.btnFwd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFwd.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Image = Global.DailyLog.My.Resources.Resources.arrow_left
        Me.btnBack.Location = New System.Drawing.Point(839, -3)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(35, 35)
        Me.btnBack.TabIndex = 18
        Me.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1124, 582)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblFileDate)
        Me.Controls.Add(Me.btnFwd)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.TabControl1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.m_Menu
        Me.MinimumSize = New System.Drawing.Size(1010, 566)
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.tabDailyLog.ResumeLayout(False)
        Me.tabDailyLog.PerformLayout()
        Me.gbShiftNotes.ResumeLayout(False)
        Me.gbShiftNotes.PerformLayout()
        Me.gbRadar.ResumeLayout(False)
        Me.gbRadar.PerformLayout()
        Me.gbMileage.ResumeLayout(False)
        Me.gbMileage.PerformLayout()
        Me.gbShiftStats.ResumeLayout(False)
        Me.gbShiftStats.PerformLayout()
        Me.m_Menu.ResumeLayout(False)
        Me.m_Menu.PerformLayout()
        Me.TabReporting.ResumeLayout(False)
        Me.TabReporting.PerformLayout()
        Me.Narrative.ResumeLayout(False)
        Me.TabCaseDetails.ResumeLayout(False)
        Me.TabCaseDetails.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPerson1.ResumeLayout(False)
        Me.TabPerson1.PerformLayout()
        Me.TabPerson2.ResumeLayout(False)
        Me.TabPerson2.PerformLayout()
        Me.TabVehicle1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabVehicle2.ResumeLayout(False)
        Me.TabVehicle2.PerformLayout()
        Me.TabNarrative.ResumeLayout(False)
        Me.TabNarrative.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents toolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabDailyLog As System.Windows.Forms.TabPage
    Friend WithEvents m_Menu As System.Windows.Forms.MenuStrip
    Friend WithEvents mFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mNew_File As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mNew_Patrol As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mNewLogEntryOnPreviousDate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mOpen_File As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mExit_File As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mTools As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mOptions_Tools As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mStats_Tools As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mEditCallTypes_Tools As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mDayNight_Tools As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mDeleteSingleEntry_Tools As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mClearEntireLog_Tools As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mAbout_Help As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents gbShiftNotes As System.Windows.Forms.GroupBox
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents mViewLogsHTML_Tools As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblAgency As System.Windows.Forms.Label
    Friend WithEvents lblOfficer As System.Windows.Forms.Label
    Friend WithEvents lblExplanation As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents lblCounty As System.Windows.Forms.Label
    Friend WithEvents lblArea As System.Windows.Forms.Label
    Friend WithEvents lblSupervisor As System.Windows.Forms.Label
    Friend WithEvents m_AppDataFolder As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents tmrStats As System.Windows.Forms.Timer
    Friend WithEvents tmrUploadLogFiles As System.Windows.Forms.Timer
    Friend WithEvents tmrPauseBeforeUpdating As System.Windows.Forms.Timer
    Friend WithEvents mSave_File As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lvMain As System.Windows.Forms.ListView
    Friend WithEvents lvColumnNumber As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvColumnStart As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvColumnEnd As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvColumnTime As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvColumnLocCallType As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvColumnDescriptionNotes As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvColumnCase As System.Windows.Forms.ColumnHeader
    Friend WithEvents gbRadar As System.Windows.Forms.GroupBox
    Friend WithEvents cbRadarVer As System.Windows.Forms.CheckBox
    Friend WithEvents gbMileage As System.Windows.Forms.GroupBox
    Friend WithEvents txtEndMiles As System.Windows.Forms.TextBox
    Friend WithEvents txtStartMiles As System.Windows.Forms.TextBox
    Friend WithEvents gbShiftStats As System.Windows.Forms.GroupBox
    Friend WithEvents cmbStat14County As System.Windows.Forms.ComboBox
    Friend WithEvents cmbStat13County As System.Windows.Forms.ComboBox
    Friend WithEvents cmbStat12County As System.Windows.Forms.ComboBox
    Friend WithEvents cmbStat11County As System.Windows.Forms.ComboBox
    Friend WithEvents cmbStat10County As System.Windows.Forms.ComboBox
    Friend WithEvents cmbStat9County As System.Windows.Forms.ComboBox
    Friend WithEvents cmbStat8County As System.Windows.Forms.ComboBox
    Friend WithEvents cmbStat7County As System.Windows.Forms.ComboBox
    Friend WithEvents cmbStat6County As System.Windows.Forms.ComboBox
    Friend WithEvents cmbStat5County As System.Windows.Forms.ComboBox
    Friend WithEvents cmbStat4County As System.Windows.Forms.ComboBox
    Friend WithEvents cmbStat3County As System.Windows.Forms.ComboBox
    Friend WithEvents cmbStat2County As System.Windows.Forms.ComboBox
    Friend WithEvents cmbStat1County As System.Windows.Forms.ComboBox
    Friend WithEvents cmbStat14City As System.Windows.Forms.ComboBox
    Friend WithEvents cmbStat13City As System.Windows.Forms.ComboBox
    Friend WithEvents cmbStat12City As System.Windows.Forms.ComboBox
    Friend WithEvents cmbStat11City As System.Windows.Forms.ComboBox
    Friend WithEvents cmbStat10City As System.Windows.Forms.ComboBox
    Friend WithEvents cmbStat9City As System.Windows.Forms.ComboBox
    Friend WithEvents cmbStat8City As System.Windows.Forms.ComboBox
    Friend WithEvents cmbStat7City As System.Windows.Forms.ComboBox
    Friend WithEvents cmbStat6City As System.Windows.Forms.ComboBox
    Friend WithEvents cmbStat5City As System.Windows.Forms.ComboBox
    Friend WithEvents cmbStat4City As System.Windows.Forms.ComboBox
    Friend WithEvents cmbStat3City As System.Windows.Forms.ComboBox
    Friend WithEvents cmbStat2City As System.Windows.Forms.ComboBox
    Friend WithEvents cmbStat1City As System.Windows.Forms.ComboBox
    Friend WithEvents cmbStat16County As System.Windows.Forms.ComboBox
    Friend WithEvents cmbStat15County As System.Windows.Forms.ComboBox
    Friend WithEvents cmbStat15City As System.Windows.Forms.ComboBox
    Friend WithEvents cmbObligatedCounty As System.Windows.Forms.ComboBox
    Friend WithEvents cmbNonObligatedCounty As System.Windows.Forms.ComboBox
    Friend WithEvents cmbNonObligatedCity As System.Windows.Forms.ComboBox
    Friend WithEvents cmbObligatedCity As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblTotalCountyTime As System.Windows.Forms.Label
    Friend WithEvents lblTotalStats As System.Windows.Forms.Label
    Friend WithEvents lblTotalHours As System.Windows.Forms.Label
    Friend WithEvents lblTotalCityTime As System.Windows.Forms.Label
    Friend WithEvents lblTotalTimes As System.Windows.Forms.Label
    Friend WithEvents txtStat16 As System.Windows.Forms.Label
    Friend WithEvents txtStat15 As System.Windows.Forms.Label
    Friend WithEvents lblObligated As System.Windows.Forms.Label
    Friend WithEvents lblNonObligated As System.Windows.Forms.Label
    Friend WithEvents txtStat14 As System.Windows.Forms.Label
    Friend WithEvents txtStat13 As System.Windows.Forms.Label
    Friend WithEvents txtStat12 As System.Windows.Forms.Label
    Friend WithEvents txtStat11 As System.Windows.Forms.Label
    Friend WithEvents txtStat10 As System.Windows.Forms.Label
    Friend WithEvents txtStat9 As System.Windows.Forms.Label
    Friend WithEvents txtStat8 As System.Windows.Forms.Label
    Friend WithEvents txtStat7 As System.Windows.Forms.Label
    Friend WithEvents txtStat6 As System.Windows.Forms.Label
    Friend WithEvents txtStat5 As System.Windows.Forms.Label
    Friend WithEvents txtStat4 As System.Windows.Forms.Label
    Friend WithEvents txtStat3 As System.Windows.Forms.Label
    Friend WithEvents txtStat2 As System.Windows.Forms.Label
    Friend WithEvents txtStat1 As System.Windows.Forms.Label
    Friend WithEvents lblCity1 As System.Windows.Forms.Label
    Friend WithEvents lblCounty1 As System.Windows.Forms.Label
    Friend WithEvents lblCity2 As System.Windows.Forms.Label
    Friend WithEvents lblCounty2 As System.Windows.Forms.Label
    Friend WithEvents txtShiftNotes As System.Windows.Forms.TextBox
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnToday As System.Windows.Forms.Button
    Friend WithEvents lblFileDate As System.Windows.Forms.Label
    Friend WithEvents btnFwd As System.Windows.Forms.Button
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnTheme As System.Windows.Forms.Button
    Friend WithEvents btnOptions As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Friend WithEvents TabReporting As TabPage
    Friend WithEvents Label42 As Label
    Friend WithEvents Narrative As TabControl
    Friend WithEvents TabCaseDetails As TabPage
    Friend WithEvents TabPerson1 As TabPage
    Friend WithEvents Label38 As Label
    Friend WithEvents Txtname1_ As TextBox
    Friend WithEvents Label40 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents TxtPersonAddress1_ As TextBox
    Friend WithEvents LblWeight1 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents TxtDOB1_ As TextBox
    Friend WithEvents TxtID1_ As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtWeight1 As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents TxtAlias1_ As TextBox
    Friend WithEvents TabPerson2 As TabPage
    Friend WithEvents TabVehicle1 As TabPage
    Friend WithEvents TabVehicle2 As TabPage
    Friend WithEvents TabNarrative As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents lblDateTime As Label
    Friend WithEvents Txt_Case As TextBox
    Friend WithEvents lblCase As Label
    Friend WithEvents LblDateTimeReporting As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents Txt_Incident_time As TextBox
    Friend WithEvents TxtIncidentAddress As TextBox
    Friend WithEvents Label45 As Label
    Friend WithEvents TxtPrimaryOfficer_ As TextBox
    Friend WithEvents Label44 As Label
    Friend WithEvents TxtOffence_Date As TextBox
    Friend WithEvents Label46 As Label
    Friend WithEvents CmbAdditionalReports As ComboBox
    Friend WithEvents Label47 As Label
    Friend WithEvents RbOther1_ As RadioButton
    Friend WithEvents RbSuspect1_ As RadioButton
    Friend WithEvents RbWitness1_ As RadioButton
    Friend WithEvents RbVictim1_ As RadioButton
    Friend WithEvents CmbSex1_ As ComboBox
    Friend WithEvents CmbRace1_ As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CbNoVideo1_ As CheckBox
    Friend WithEvents CbVideoAttached1_ As CheckBox
    Friend WithEvents TxtOffence3_ As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtOffence2_ As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtOffence1_ As TextBox
    Friend WithEvents LblCharges As Label
    Friend WithEvents CbDocumentation_ As CheckBox
    Friend WithEvents CbNonCrim_ As CheckBox
    Friend WithEvents CbInfraction_ As CheckBox
    Friend WithEvents CbMisd_ As CheckBox
    Friend WithEvents CbFelony_ As CheckBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LblLawCode1_ As Label
    Friend WithEvents TxtLawCode2_ As TextBox
    Friend WithEvents TxtLawCode3_ As TextBox
    Friend WithEvents TxtLawCode1_ As TextBox
    Friend WithEvents CbCrimWarrant_ As CheckBox
    Friend WithEvents TxtCounts3_ As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtCounts2_ As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtCounts1_ As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CbCivilWarrant_ As CheckBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtPrimaryID2_ As TextBox
    Friend WithEvents CbNoVideo2_ As CheckBox
    Friend WithEvents CbVideoAttached2_ As CheckBox
    Friend WithEvents TxtSecondaryOfficer1_ As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtPrimaryID1_ As TextBox
    Friend WithEvents CmbState1_ As ComboBox
    Friend WithEvents CmbHeight1_ As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents CmbDrugAlcohol1_ As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents CmbEyes1_ As ComboBox
    Friend WithEvents lblEyes1_ As Label
    Friend WithEvents CmbHair1_ As ComboBox
    Friend WithEvents lblAge1_ As Label
    Friend WithEvents TxtAge1_ As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TxtCitizenship1_ As TextBox
    Friend WithEvents TxtPlaceofBirth1_ As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TxtOccupation1_ As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents TxtPhone1_ As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents TxtScarsTats1_ As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label56 As Label
    Friend WithEvents CmbVeh1Disposition_ As ComboBox
    Friend WithEvents Label55 As Label
    Friend WithEvents V1model_ As TextBox
    Friend WithEvents Label53 As Label
    Friend WithEvents CmbV1Make_ As ComboBox
    Friend WithEvents TxtV1Year_ As TextBox
    Friend WithEvents Label50 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents CmbV1Color_ As ComboBox
    Friend WithEvents CmbStyle1_ As ComboBox
    Friend WithEvents Label25 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtVehicle1Identifying_ As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents RbVehicle1Other_ As RadioButton
    Friend WithEvents RbVehicle1Suspect_ As RadioButton
    Friend WithEvents RbVehicle1Witness_ As RadioButton
    Friend WithEvents RbVehicle1Victim_ As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TxtVehicle2VIN_ As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents RbVehicle2Other_ As RadioButton
    Friend WithEvents RbVehicle2Suspect_ As RadioButton
    Friend WithEvents RbVehicle2Witness_ As RadioButton
    Friend WithEvents RbVehicle2Victim_ As RadioButton
    Friend WithEvents TxtVehicle2Identifying_ As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents CmbV2Color_ As ComboBox
    Friend WithEvents CmbStyle2_ As ComboBox
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents TxtV2Year_ As TextBox
    Friend WithEvents CmbVeh2Disposition_ As ComboBox
    Friend WithEvents CmbV2Make_ As ComboBox
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents V2model_ As TextBox
    Friend WithEvents TxtVehicle1VIN_ As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label37 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label48 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label51 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label52 As Label
    Friend WithEvents Label54 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label57 As Label
    Friend WithEvents Label58 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label59 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label60 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label61 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents ComboBox7 As ComboBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents Label62 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label63 As Label
    Friend WithEvents Label64 As Label
    Friend WithEvents Label65 As Label
    Friend WithEvents Label66 As Label
    Friend WithEvents Label67 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label68 As Label
    Friend WithEvents Label69 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label70 As Label
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Label71 As Label
    Friend WithEvents TextBox12 As TextBox
End Class
