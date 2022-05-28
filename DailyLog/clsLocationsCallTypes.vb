' ©2023. DailyLog. Less Paperwork, More Patrol, name, logo and slogan is TM 2013-2023. 
' Welcome to DailyLog
' Created by R. Taylor
' This form started January 18th 2013
' Code reference http://msdn.microsoft.com/en-us/library/system.io.file.createtext%28v=vs.100%29.aspx?cs-save-lang=1&cs-lang=vb#code-snippet-1

Imports System
Imports System.IO
Imports System.Text

Public Class ClsLocationsCallTypes


    ' Create the Program Files 86 folder if needed- this is for 32 bit Installs. 
    Sub CreateProgramFiles86()
        Try
            If (Directory.Exists(x.myFolder)) Then
                'MsgBox("Critical Folder Already Exists ")
            Else
                Directory.CreateDirectory(x.myFolder)
            End If
            'Console.WriteLine("Directories created")
        Catch E As Exception
            MsgBox("Error creating directory")
            MsgBox("Error: {0}", E.Message)
        End Try
    End Sub


    Sub CreateCriticalFolder()
        Try
            If (Directory.Exists(x.myCriticalFolder)) Then
                'MsgBox("Critical Folder Already Exists ")
            Else
                Directory.CreateDirectory(x.myCriticalFolder)
            End If
            'Console.WriteLine("Directories created")
        Catch E As Exception
            MsgBox("Error creating directory")
            MsgBox("Error: {0}", E.Message)
        End Try
    End Sub


    Public Shared Sub CreateLocationsAndCallTypes()

        Dim path As String = myCriticalFolder & "\" & "Locations and Call Types.txt"
        If File.Exists(path) = False Then
            ' Create a file to write to.
            Dim sw As StreamWriter = File.CreateText(path)
            sw.WriteLine("Quisque~Condimentum lobortis~Ex Vestibulum posuere~Congue Vonvallis")
            sw.WriteLine("Augue~Condimentum lobortis~Ex Vestibulum posuere~Congue Vonvallis")
            sw.WriteLine("Imperdiet City~Condimentum lobortis~Ex Vestibulum posuere~Congue Vonvallis")
            sw.WriteLine("Vivamus~Condimentum lobortis~Ex Vestibulum posuere~Congue Vonvallis")
            sw.WriteLine("Aliquam Terrace~Condimentum lobortis~Ex Vestibulum posuere~Congue Vonvallis")
            ' sw.WriteLine("Area 1~Unobligated Patrol~Traffic Stop~Premise/Business Checks~Radar/Traffic Enforcement~City Court~County Justice Court~County District Court~Suspicious Person/Vehicle~Breaks~Theft Investigation~Fraud Investigation~DUI~Assist Other Unit~Assist Other Jurisdiction~Impound/Inventory~Warrant Arrest~Paper Service~Public Assist~Phone Detail~Domestic Dispute~Car/Deer Accident~Non Reportable~Reportable Accident~Report Writing~Meetings~VIN Inspection~Assault Investigation~Death~Burglary~Welfare Check~Assist Fire Dept.~Assist EMS~Civil Dispute~Animal Control~Audible/Silent Alarm~County Fair~Trespassing~S&R~Child Abuse~Sexual Offences~Prisioner Transport~Abandoned Vehicle~Office Detail~Office Computer Repair~Criminal Mischief~Keep the Peace~Missing Person~Lost Property~Traffic Hazzard~At High School~Sex Offender Registry~Video Review~Report Review~Admin~Vehicle Burglary~Residential Burglary~Case Follow Up~911 Hangup~Parking Problem~Vehicle Maintenance~Juvenile Problem~K9 Assist~K9 Tracking~K9 Training~K9 Search~Reckless Driver~Mental Subject~Ungovernable Juvenile~Suicide~Suicide Threat/Attempt~Public Intoxication~Minor in Possession~Training~Drivers Ed Presentation~Community Policing Detail~Extra Patrol")
            sw.Flush()
            sw.Close()
        End If
    End Sub

    Public Shared Sub CreateQuickPickLocationsAndCallTypes()

        Dim path As String = myCriticalFolder & "\" & "Call Details Quick Pick.txt"
        If File.Exists(path) = False Then
            ' Create a file to write to.
            Dim sw As StreamWriter = File.CreateText(path)
            sw.WriteLine("Fusce aliquet eros efficitur")
            sw.WriteLine("Aliquam a elit non arcu")
            sw.WriteLine("Mauris vel nisi maximus")
            sw.WriteLine("In id ante eu nibh")
            sw.WriteLine("Quisque vel metus volutpat")
            sw.WriteLine("Mauris nec eros tristique")
            sw.Flush()
            sw.Close()
        End If
    End Sub

    'Public Shared Sub CreateGlobalDataAndSettings()
    '    Dim path As String = myCriticalFolder & "Global Data and Settings.ini"
    '    If File.Exists(path) = False Then
    '        ' Create a file to write to. 
    '        Dim sw As StreamWriter = File.CreateText(path)
    '    End If
    'End Sub

End Class
