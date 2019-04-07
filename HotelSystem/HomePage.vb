Imports System.Data.OleDb

Public Class HomePage
    Private Sub RefreshHomeInfo_Click(sender As Object, e As EventArgs) Handles RefreshHomeInfo.Click

        DateLabel.Text = System.DateTime.Now.ToString("dd MMMM yyyy")
    End Sub

    Private Sub ResButton_Click(sender As Object, e As EventArgs) Handles ResButton.Click
        HomePanel.Visible = False
        ReservationPanel.Visible = True
    End Sub

    Private Sub LogoutButton_Click(sender As Object, e As EventArgs) Handles LogoutButton.Click
        Dim form As New LoginPage
        form.Show()
        Me.Close()
    End Sub

    Private Sub EmployeeButton_Click(sender As Object, e As EventArgs) Handles EmployeeButton.Click
        'Turn off all other panels
        HomePanel.Visible = False
        MaintenancePanel.Visible = False
        ChkOutPanel.Visible = False
        ChkInPanel.Visible = False
        ReservationPanel.Visible = False

        'Make the Home panel visible to user
        EmployeePanel.Visible = True




    End Sub

    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HOTEL_DBDataSet.CUSTOMER' table. You can move, or remove it, as needed.
        Me.CUSTOMERTableAdapter.Fill(Me.HOTEL_DBDataSet.CUSTOMER)
        'TODO: This line of code loads data into the 'HOTEL_DBDataSet.CUSTOMER' table. You can move, or remove it, as needed.
        Me.CUSTOMERTableAdapter.Fill(Me.HOTEL_DBDataSet.CUSTOMER)
        'TODO: This line of code loads data into the 'HOTEL_DBDataSet.EMPLOYEE' table. You can move, or remove it, as needed.
        '  Me.EMPLOYEETableAdapter.Fill(Me.HOTEL_DBDataSet.EMPLOYEE)
        'Turn off all other panels
        EmployeePanel.Visible = False
        MaintenancePanel.Visible = False
        ChkOutPanel.Visible = False
        ChkInPanel.Visible = False
        ReservationPanel.Visible = False

        'Make the employee panel visible to user
        HomePanel.Visible = True
    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        'Turn off all other panels
        EmployeePanel.Visible = False
        MaintenancePanel.Visible = False
        ChkOutPanel.Visible = False
        ChkInPanel.Visible = False
        ReservationPanel.Visible = False

        'Make the Home panel visible to user
        HomePanel.Visible = True
    End Sub

    Private Sub CheckInButton_Click(sender As Object, e As EventArgs)
        'Turn off all other panels
        HomePanel.Visible = False
        EmployeePanel.Visible = False
        MaintenancePanel.Visible = False
        ChkOutPanel.Visible = False
        ReservationPanel.Visible = False

        'Make the Check In panel visible to user
        ChkInPanel.Visible = True

    End Sub

    Private Sub CheckOutButton_Click(sender As Object, e As EventArgs) Handles CheckOutButton.Click
        'Turn off all other panels
        HomePanel.Visible = False
        EmployeePanel.Visible = False
        MaintenancePanel.Visible = False
        ChkInPanel.Visible = False
        ReservationPanel.Visible = False

        'Make the Check Out panel visible to user
        ChkOutPanel.Visible = True

    End Sub

    Private Sub MaintenanceButton_Click(sender As Object, e As EventArgs) Handles MaintenanceButton.Click
        'Turn off all other panels
        HomePanel.Visible = False
        EmployeePanel.Visible = False
        ChkInPanel.Visible = False
        ChkOutPanel.Visible = False
        ReservationPanel.Visible = False

        'Make the Maintenance panel visible to user
        MaintenancePanel.Visible = True

    End Sub
End Class