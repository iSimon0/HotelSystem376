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

        'Make the employee panel visible to user
        EmployeePanel.Visible = True




    End Sub

    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        'Make the employee panel visible to user
        HomePanel.Visible = True
    End Sub
End Class