Imports System.Data.OleDb
Imports System.Data
Imports System.Configuration

Public Class HomePage

    'DBControl 
    Private Access As New DBControl


    Private Sub RefreshHomeInfo_Click(sender As Object, e As EventArgs) Handles RefreshHomeInfo.Click, PictureBox1.MouseHover

        DateLabel.Text = System.DateTime.Now.ToString("dd MMMM yyyy")
    End Sub

    Private Sub ResButton_Click(sender As Object, e As EventArgs) Handles ResButton.Click
        EmployeePanel.Visible = False
        MaintenancePanel.Visible = False
        ChkOutPanel.Visible = False
        ChkInPanel.Visible = False
        HomePanel.Visible = False

        ReservationPanel.Visible = True
    End Sub

    Private Sub LogoutButton_Click(sender As Object, e As EventArgs) Handles LogoutButton.Click
        Dim form As New LoginPage
        form.Show()
        Me.Close()
    End Sub

    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HOTEL_DBDataSet.EMPLOYEE' table. You can move, or remove it, as needed.
        Me.EMPLOYEETableAdapter.Fill(Me.HOTEL_DBDataSet.EMPLOYEE)
        'TODO: This line of code loads data into the 'HOTEL_DBDataSet.CUSTOMER' table. You can move, or remove it, as needed.
        Me.CUSTOMERTableAdapter.Fill(Me.HOTEL_DBDataSet.CUSTOMER)
        Me.ROOMSTableAdapter.Fill(Me.HOTEL_DBDataSet.ROOMS)


        'Turn off all other panels
        EmployeePanel.Visible = False
        MaintenancePanel.Visible = False
        ChkOutPanel.Visible = False
        ChkInPanel.Visible = False
        ReservationPanel.Visible = False

        'Make the employee panel visible to user
        HomePanel.Visible = True

    End Sub

    Private Sub EmployeeButton_Click(sender As Object, e As EventArgs) Handles EmployeeButton.Click


        Access.ExecQuery("SELECT * FROM EMPLOYEE")
        If Not String.IsNullOrEmpty(Access.Exception) Then
            MsgBox(Access.Exception) : Exit Sub
        End If



        'Turn off all other panels
        HomePanel.Visible = False
        MaintenancePanel.Visible = False
        ChkOutPanel.Visible = False
        ChkInPanel.Visible = False
        ReservationPanel.Visible = False

        'Make the EMPLY panel visible to user
        EmployeePanel.Visible = True

    End Sub

    Private Sub bttnUpdateEmplyTbl_Click(sender As Object, e As EventArgs)

        Me.EMPLOYEEBindingSource3.EndEdit()
        Me.EMPLOYEETableAdapter.Fill(Me.HOTEL_DBDataSet.EMPLOYEE)

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


    Private Sub CheckInButton_Click(sender As Object, e As EventArgs) Handles CheckInButton.Click

        'Turn off all other panels
        HomePanel.Visible = False
        EmployeePanel.Visible = False
        MaintenancePanel.Visible = False
        ChkOutPanel.Visible = False
        ReservationPanel.Visible = False

        'Make the Check In panel visible to user
        ChkInPanel.Visible = True
    End Sub

    Private Sub btnEmplyDGV_Click(sender As Object, e As EventArgs) Handles btnEmplyDGV.Click
        EMPLOYEEBindingSource3.AddNew()
    End Sub

    Private Sub btnRoomsDGV_Click(sender As Object, e As EventArgs) Handles btnRoomsDGV.Click
        ROOMSBindingSource2.AddNew()

    End Sub

    Private Sub btnChkOutDGV_Click(sender As Object, e As EventArgs) Handles btnChkOutDGV.Click
        CUSTOMERBindingSource1.AddNew()

    End Sub

    Private Sub btnChkInDGV_Click(sender As Object, e As EventArgs) Handles btnChkInDGV.Click
        CUSTOMERBindingSource2.AddNew()

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.CUSTOMERTableAdapter.FillBy(Me.HOTEL_DBDataSet.CUSTOMER)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub


End Class