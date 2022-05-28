<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.Version = New System.Windows.Forms.Label()
        Me.tmrRefreshOfficerID = New System.Windows.Forms.Timer(Me.components)
        Me.LoginProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'Version
        '
        Me.Version.BackColor = System.Drawing.Color.Transparent
        Me.Version.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Version.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.Version.Location = New System.Drawing.Point(61, 32)
        Me.Version.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Version.Name = "Version"
        Me.Version.Size = New System.Drawing.Size(342, 81)
        Me.Version.TabIndex = 7
        Me.Version.Text = "Version {0}.{1} Revision {2:00}"
        Me.Version.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrRefreshOfficerID
        '
        Me.tmrRefreshOfficerID.Enabled = True
        Me.tmrRefreshOfficerID.Interval = 10
        '
        'LoginProgressBar1
        '
        Me.LoginProgressBar1.Location = New System.Drawing.Point(35, 176)
        Me.LoginProgressBar1.Margin = New System.Windows.Forms.Padding(4)
        Me.LoginProgressBar1.Name = "LoginProgressBar1"
        Me.LoginProgressBar1.Size = New System.Drawing.Size(390, 22)
        Me.LoginProgressBar1.TabIndex = 24
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(461, 223)
        Me.Controls.Add(Me.LoginProgressBar1)
        Me.Controls.Add(Me.Version)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLogin"
        Me.TransparencyKey = System.Drawing.Color.WhiteSmoke
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Version As System.Windows.Forms.Label
    Friend WithEvents tmrRefreshOfficerID As System.Windows.Forms.Timer
    Friend WithEvents LoginProgressBar1 As System.Windows.Forms.ProgressBar

End Class
