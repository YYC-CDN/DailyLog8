'  Started July 11 2011, in Calgary Alberta
'  http://www.youtube.com/watch?v=MAnlhHOUc3Y
'  http://www.youtube.com/watch?v=CzBPaM098GQ


Imports System
Imports System.IO

Public NotInheritable Class frmLogin



    Public Sub frmLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Try

            'Application.DoEvents()
            Me.Text = "DailyLog Login Screen"
            'Application.DoEvents()
            '  Me.Icon = x.myIcon
            'Application.DoEvents()
            Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)
            'Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)
            'Application.DoEvents()
            'Threading.Thread.Sleep(15000)

            Dim load As New ClsLocationsCallTypes
            load.CreateProgramFiles86()

            'Create the CRITICAL folder. No longer included with the installer
            Dim load0 As New ClsLocationsCallTypes
            load0.CreateCriticalFolder()

            ' Create the Locations and Call Types file
            Dim load1 As New ClsLocationsCallTypes
            ClsLocationsCallTypes.CreateLocationsAndCallTypes()

            ' Create the Locations and Call Types Quick Picks file
            Dim load2 As New ClsLocationsCallTypes
            ClsLocationsCallTypes.CreateQuickPickLocationsAndCallTypes()

            ' Create the Global Data and Settingsfile
            'Dim load2 As New ClsLocationsCallTypes
            'ClsLocationsCallTypes.CreateGlobalDataAndSettings()

            Try ' In a Try/Catch becasue on first run, it's trying to load data that isn't there yet.
                x.loadSettingsAndDataFile() '// Load officer ID and Password from the config file
            Catch ex As Exception
            End Try

            ' A couple of installed in the past have been missing the favicon.ico for some reason
            ' Lets put this try-catch in here and prompt the user to reinstall
            ' and shut the app down
        Catch ex As Exception
            If MsgBox("An exception occurred- please re-install DailyLog" & vbCrLf & ex.Message) Then
                Application.Exit()
            End If

        End Try

    End Sub

    Public Sub frmLogin_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing


    End Sub
End Class
