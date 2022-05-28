Option Strict On

Imports System.Net
Public Class frmAbout



    Private Sub frmAbout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = x.centerForm(Me) '  Center Form of FrmMain.
        Me.TopMost = True
        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)
        'Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

        ' Show the user information in on the form. 
        'lblMachineName.Text = System.Environment.MachineName
        'lblUserName.Text = System.Environment.UserName
        'lblOSFullName.Text = My.Computer.Info.OSFullName
        'lblOSPlatform.Text = My.Computer.Info.OSPlatform
        'lblOSVersion.Text = My.Computer.Info.OSVersion
        'lblOSInstalledUICulture.Text = My.Computer.Info.InstalledUICulture.ToString

        '  x.ShowIPAddress()



    End Sub


    Private Sub frmAbout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        ' Close on click, get rid of the close button
        Me.Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ' Fuck it, use the button. 
        Me.Close()
    End Sub
End Class