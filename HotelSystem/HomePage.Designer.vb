<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomePage
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
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.ResButton = New System.Windows.Forms.Button()
        Me.CheckInButton = New System.Windows.Forms.Button()
        Me.CheckOutButton = New System.Windows.Forms.Button()
        Me.MaintenanceButton = New System.Windows.Forms.Button()
        Me.EmployeeButton = New System.Windows.Forms.Button()
        Me.LogoutButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'HomeButton
        '
        Me.HomeButton.Location = New System.Drawing.Point(12, 12)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(75, 23)
        Me.HomeButton.TabIndex = 0
        Me.HomeButton.Text = "Home"
        Me.HomeButton.UseVisualStyleBackColor = True
        '
        'ResButton
        '
        Me.ResButton.Location = New System.Drawing.Point(93, 12)
        Me.ResButton.Name = "ResButton"
        Me.ResButton.Size = New System.Drawing.Size(80, 23)
        Me.ResButton.TabIndex = 1
        Me.ResButton.Text = "Reservations"
        Me.ResButton.UseVisualStyleBackColor = True
        '
        'CheckInButton
        '
        Me.CheckInButton.Location = New System.Drawing.Point(179, 12)
        Me.CheckInButton.Name = "CheckInButton"
        Me.CheckInButton.Size = New System.Drawing.Size(75, 23)
        Me.CheckInButton.TabIndex = 2
        Me.CheckInButton.Text = "Check-ins"
        Me.CheckInButton.UseVisualStyleBackColor = True
        '
        'CheckOutButton
        '
        Me.CheckOutButton.Location = New System.Drawing.Point(260, 12)
        Me.CheckOutButton.Name = "CheckOutButton"
        Me.CheckOutButton.Size = New System.Drawing.Size(75, 23)
        Me.CheckOutButton.TabIndex = 3
        Me.CheckOutButton.Text = "Check-outs"
        Me.CheckOutButton.UseVisualStyleBackColor = True
        '
        'MaintenanceButton
        '
        Me.MaintenanceButton.Location = New System.Drawing.Point(341, 12)
        Me.MaintenanceButton.Name = "MaintenanceButton"
        Me.MaintenanceButton.Size = New System.Drawing.Size(84, 23)
        Me.MaintenanceButton.TabIndex = 4
        Me.MaintenanceButton.Text = "Maintenance"
        Me.MaintenanceButton.UseVisualStyleBackColor = True
        '
        'EmployeeButton
        '
        Me.EmployeeButton.Location = New System.Drawing.Point(431, 12)
        Me.EmployeeButton.Name = "EmployeeButton"
        Me.EmployeeButton.Size = New System.Drawing.Size(75, 23)
        Me.EmployeeButton.TabIndex = 5
        Me.EmployeeButton.Text = "Employee"
        Me.EmployeeButton.UseVisualStyleBackColor = True
        '
        'LogoutButton
        '
        Me.LogoutButton.Location = New System.Drawing.Point(512, 12)
        Me.LogoutButton.Name = "LogoutButton"
        Me.LogoutButton.Size = New System.Drawing.Size(75, 23)
        Me.LogoutButton.TabIndex = 6
        Me.LogoutButton.Text = "Log out"
        Me.LogoutButton.UseVisualStyleBackColor = True
        '
        'HomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LogoutButton)
        Me.Controls.Add(Me.EmployeeButton)
        Me.Controls.Add(Me.MaintenanceButton)
        Me.Controls.Add(Me.CheckOutButton)
        Me.Controls.Add(Me.CheckInButton)
        Me.Controls.Add(Me.ResButton)
        Me.Controls.Add(Me.HomeButton)
        Me.Name = "HomePage"
        Me.Text = "Home"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HomeButton As Button
    Friend WithEvents ResButton As Button
    Friend WithEvents CheckInButton As Button
    Friend WithEvents CheckOutButton As Button
    Friend WithEvents MaintenanceButton As Button
    Friend WithEvents EmployeeButton As Button
    Friend WithEvents LogoutButton As Button
End Class
