Imports System.Data.OleDb
Imports System.Data
Imports System.Configuration

Public Class HomePage

    'Con String used to hold source for connection to DB
    Const Con As String = "Provider=Microsoft.ACE.OLEDB.12.0;" &
            "Data Source=C:\Users\alsay\Documents\GitHub\HotelSystem376\HOTEL_DB.accdb"
    Dim ds As New DataSet
    Dim dt As New DataTable
    Dim da As New OleDbDataAdapter


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

    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HOTEL_DBDataSet.EMPLOYEE' table. You can move, or remove it, as needed.
        Me.EMPLOYEETableAdapter.Fill(Me.HOTEL_DBDataSet.EMPLOYEE)
        'TODO: This line of code loads data into the 'HOTEL_DBDataSet.CUSTOMER' table. You can move, or remove it, as needed.
        Me.CUSTOMERTableAdapter.Fill(Me.HOTEL_DBDataSet.CUSTOMER)
        'TODO: This line of code loads data into the 'HOTEL_DBDataSet.CUSTOMER' table. You can move, or remove it, as needed.
        Me.CUSTOMERTableAdapter.Fill(Me.HOTEL_DBDataSet.CUSTOMER)
        'TODO: This line of code loads data into the 'HOTEL_DBDataSet.EMPLOYEE' table. You can move, or remove it, as needed.
        Me.EMPLOYEETableAdapter.Fill(Me.HOTEL_DBDataSet.EMPLOYEE)



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
        'Which table data will be pulled from
        Const SQLExpression As String = "SELECT * FROM EMPLOYEE;"

        '*** CONNECTION
        Dim cn As New OleDbConnection(Con)
        cn.Open()
        da = New OleDbDataAdapter(SQLExpression, cn)

        'Dim ds As New DataSet
        da.Fill(ds, "EMPLOYEE")
        cn.Close()

        With Me.DataGridEmplyTbl
            .DataSource = ds
            'Here we control which table the DataGridView should display.
            .DataMember = "EMPLOYEE"
        End With

        ds = Nothing
        da.Dispose()
        cn = Nothing
        '*** CONNECTION



        'Turn off all other panels
        HomePanel.Visible = False
        MaintenancePanel.Visible = False
        ChkOutPanel.Visible = False
        ChkInPanel.Visible = False
        ReservationPanel.Visible = False

        'Make the EMPLY panel visible to user
        EmployeePanel.Visible = True

    End Sub

    Private Sub bttnUpdateEmplyTbl_Click(sender As Object, e As EventArgs) Handles bttnUpdateEmplyTbl.Click
        Dim cn As New OleDbConnection(Con)
        cn.Open()
        ds.Tables.Add(dt)
        da = New OleDbDataAdapter("Select * from EMPLOYEE", cn)
        da.Update(dt)
        cn.Close()

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

        'Which table data will be pulled from
        Const SQLExpression As String = "SELECT * FROM CUSTOMER;"

        '*** CONNECTION
        Dim cn As New OleDbConnection(Con)
        cn.Open()
        Dim da As New OleDbDataAdapter(SQLExpression, cn)

        Dim ds As New DataSet
        da.Fill(ds, "CUSTOMER")
        cn.Close()

        With Me.CUSTOMERDataGridView
            .DataSource = ds
            'Here we control which table the DataGridView should display.
            .DataMember = "CUSTOMER"
        End With

        ds = Nothing
        da.Dispose()
        cn = Nothing
        '*** CONNECTION

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

        'Which table data will be pulled from
        Const SQLExpression As String = "SELECT * FROM ROOMS;"

        '*** CONNECTION
        Dim cn As New OleDbConnection(Con)
        cn.Open()
        Dim da As New OleDbDataAdapter(SQLExpression, cn)

        Dim ds As New DataSet
        da.Fill(ds, "ROOMS")
        cn.Close()

        With Me.DataGridMaintenanceTbl

            .DataSource = ds
            'Here we control which table the DataGridView should display.
            .DataMember = "ROOMS"
        End With

        ds = Nothing
        da.Dispose()
        cn = Nothing
        '*** CONNECTION


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
        'Which table data will be pulled from
        Const SQLExpression As String = "SELECT * FROM CUSTOMER;"

        '*** CONNECTION
        Dim cn As New OleDbConnection(Con)
        cn.Open()
        Dim da As New OleDbDataAdapter(SQLExpression, cn)

        Dim ds As New DataSet
        da.Fill(ds, "CUSTOMER")
        cn.Close()

        With Me.CUSTOMERDataGridView1
            .DataSource = ds
            'Here we control which table the DataGridView should display.
            .DataMember = "CUSTOMER"
        End With

        ds = Nothing
        da.Dispose()
        cn = Nothing
        '*** CONNECTION

        'Turn off all other panels
        HomePanel.Visible = False
        EmployeePanel.Visible = False
        MaintenancePanel.Visible = False
        ChkOutPanel.Visible = False
        ReservationPanel.Visible = False

        'Make the Check In panel visible to user
        ChkInPanel.Visible = True
    End Sub


End Class