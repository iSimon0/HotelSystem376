﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomePage
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
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.ResButton = New System.Windows.Forms.Button()
        Me.CheckInButton = New System.Windows.Forms.Button()
        Me.CheckOutButton = New System.Windows.Forms.Button()
        Me.MaintenanceButton = New System.Windows.Forms.Button()
        Me.EmployeeButton = New System.Windows.Forms.Button()
        Me.LogoutButton = New System.Windows.Forms.Button()
        Me.HomePanel = New System.Windows.Forms.Panel()
        Me.RefreshHomeInfo = New System.Windows.Forms.Button()
        Me.HomeTablePanel = New System.Windows.Forms.TableLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DateLabel = New System.Windows.Forms.Label()
        Me.NumChkInLabel = New System.Windows.Forms.Label()
        Me.NumChkOutLabel = New System.Windows.Forms.Label()
        Me.RoomRateLabel = New System.Windows.Forms.Label()
        Me.CapacityLabel = New System.Windows.Forms.Label()
        Me.CapacityOOOLabel = New System.Windows.Forms.Label()
        Me.NumDirtyLabel = New System.Windows.Forms.Label()
        Me.CleanLabel = New System.Windows.Forms.Label()
        Me.ReservationPanel = New System.Windows.Forms.Panel()
        Me.DataGridCustoTbl = New System.Windows.Forms.DataGridView()
        Me.FIRSTNAMEDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LASTNAMEDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUSTIDDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DAYSDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GUESTSDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CHECKINDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CHECKOUTDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIMEINDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIMEOUTDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATEOFORDERDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALCOSTDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAIDDataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CUSTOMERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HOTELDBDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HOTEL_DBDataSet = New HotelSystem.HOTEL_DBDataSet()
        Me.ChkInPanel = New System.Windows.Forms.Panel()
        Me.DataGridChkInTbl = New System.Windows.Forms.DataGridView()
        Me.FIRSTNAMEDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LASTNAMEDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUSTIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DAYSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GUESTSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CHECKINDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CHECKOUTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIMEINDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIMEOUTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATEOFORDERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALCOSTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAIDDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ChkOutPanel = New System.Windows.Forms.Panel()
        Me.DataGridChkOutTbl = New System.Windows.Forms.DataGridView()
        Me.FIRSTNAMEDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LASTNAMEDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUSTIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DAYSDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GUESTSDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CHECKINDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CHECKOUTDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIMEINDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIMEOUTDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATEOFORDERDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALCOSTDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAIDDataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MaintenancePanel = New System.Windows.Forms.Panel()
        Me.DataGridMaintenanceTbl = New System.Windows.Forms.DataGridView()
        Me.ROOMDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TYPEDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COSTDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OCCUPIEDDataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DATEOCCUPIEDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIMEOCCUPIEDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OCCUPANTIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ROOMSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeePanel = New System.Windows.Forms.Panel()
        Me.DataGridEmplyTbl = New System.Windows.Forms.DataGridView()
        Me.EMPLOYEEBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EMPLOYEEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ROOMSBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ROOMSBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ROOMSTableAdapter = New HotelSystem.HOTEL_DBDataSetTableAdapters.ROOMSTableAdapter()
        Me.TableAdapterManager = New HotelSystem.HOTEL_DBDataSetTableAdapters.TableAdapterManager()
        Me.EMPLOYEETableAdapter = New HotelSystem.HOTEL_DBDataSetTableAdapters.EMPLOYEETableAdapter()
        Me.CUSTOMERTableAdapter = New HotelSystem.HOTEL_DBDataSetTableAdapters.CUSTOMERTableAdapter()
        Me.EMPLOYEEBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FIRSTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LASTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SSNDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PHONEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TITLEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DEPTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAYHRLYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HomePanel.SuspendLayout()
        Me.HomeTablePanel.SuspendLayout()
        Me.ReservationPanel.SuspendLayout()
        CType(Me.DataGridCustoTbl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CUSTOMERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HOTELDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HOTEL_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ChkInPanel.SuspendLayout()
        CType(Me.DataGridChkInTbl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ChkOutPanel.SuspendLayout()
        CType(Me.DataGridChkOutTbl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MaintenancePanel.SuspendLayout()
        CType(Me.DataGridMaintenanceTbl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ROOMSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EmployeePanel.SuspendLayout()
        CType(Me.DataGridEmplyTbl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPLOYEEBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPLOYEEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ROOMSBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ROOMSBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPLOYEEBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HomeButton
        '
        Me.HomeButton.Location = New System.Drawing.Point(16, 15)
        Me.HomeButton.Margin = New System.Windows.Forms.Padding(4)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(100, 28)
        Me.HomeButton.TabIndex = 0
        Me.HomeButton.Text = "Home"
        Me.HomeButton.UseVisualStyleBackColor = True
        '
        'ResButton
        '
        Me.ResButton.Location = New System.Drawing.Point(124, 15)
        Me.ResButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ResButton.Name = "ResButton"
        Me.ResButton.Size = New System.Drawing.Size(107, 28)
        Me.ResButton.TabIndex = 1
        Me.ResButton.Text = "Reservations"
        Me.ResButton.UseVisualStyleBackColor = True
        '
        'CheckInButton
        '
        Me.CheckInButton.Location = New System.Drawing.Point(239, 15)
        Me.CheckInButton.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckInButton.Name = "CheckInButton"
        Me.CheckInButton.Size = New System.Drawing.Size(100, 28)
        Me.CheckInButton.TabIndex = 2
        Me.CheckInButton.Text = "Check-ins"
        Me.CheckInButton.UseVisualStyleBackColor = True
        '
        'CheckOutButton
        '
        Me.CheckOutButton.Location = New System.Drawing.Point(347, 15)
        Me.CheckOutButton.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckOutButton.Name = "CheckOutButton"
        Me.CheckOutButton.Size = New System.Drawing.Size(100, 28)
        Me.CheckOutButton.TabIndex = 3
        Me.CheckOutButton.Text = "Check-outs"
        Me.CheckOutButton.UseVisualStyleBackColor = True
        '
        'MaintenanceButton
        '
        Me.MaintenanceButton.Location = New System.Drawing.Point(455, 15)
        Me.MaintenanceButton.Margin = New System.Windows.Forms.Padding(4)
        Me.MaintenanceButton.Name = "MaintenanceButton"
        Me.MaintenanceButton.Size = New System.Drawing.Size(112, 28)
        Me.MaintenanceButton.TabIndex = 4
        Me.MaintenanceButton.Text = "Maintenance"
        Me.MaintenanceButton.UseVisualStyleBackColor = True
        '
        'EmployeeButton
        '
        Me.EmployeeButton.Location = New System.Drawing.Point(575, 15)
        Me.EmployeeButton.Margin = New System.Windows.Forms.Padding(4)
        Me.EmployeeButton.Name = "EmployeeButton"
        Me.EmployeeButton.Size = New System.Drawing.Size(100, 28)
        Me.EmployeeButton.TabIndex = 5
        Me.EmployeeButton.Text = "Employee"
        Me.EmployeeButton.UseVisualStyleBackColor = True
        '
        'LogoutButton
        '
        Me.LogoutButton.Location = New System.Drawing.Point(683, 15)
        Me.LogoutButton.Margin = New System.Windows.Forms.Padding(4)
        Me.LogoutButton.Name = "LogoutButton"
        Me.LogoutButton.Size = New System.Drawing.Size(100, 28)
        Me.LogoutButton.TabIndex = 6
        Me.LogoutButton.Text = "Log out"
        Me.LogoutButton.UseVisualStyleBackColor = True
        '
        'HomePanel
        '
        Me.HomePanel.Controls.Add(Me.RefreshHomeInfo)
        Me.HomePanel.Controls.Add(Me.HomeTablePanel)
        Me.HomePanel.Location = New System.Drawing.Point(12, 50)
        Me.HomePanel.Margin = New System.Windows.Forms.Padding(4)
        Me.HomePanel.Name = "HomePanel"
        Me.HomePanel.Size = New System.Drawing.Size(771, 421)
        Me.HomePanel.TabIndex = 7
        Me.HomePanel.Visible = False
        '
        'RefreshHomeInfo
        '
        Me.RefreshHomeInfo.Location = New System.Drawing.Point(391, 318)
        Me.RefreshHomeInfo.Margin = New System.Windows.Forms.Padding(4)
        Me.RefreshHomeInfo.Name = "RefreshHomeInfo"
        Me.RefreshHomeInfo.Size = New System.Drawing.Size(268, 28)
        Me.RefreshHomeInfo.TabIndex = 1
        Me.RefreshHomeInfo.Text = "Get Today's Information"
        Me.RefreshHomeInfo.UseVisualStyleBackColor = True
        '
        'HomeTablePanel
        '
        Me.HomeTablePanel.ColumnCount = 2
        Me.HomeTablePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.HomeTablePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.HomeTablePanel.Controls.Add(Me.Label5, 0, 5)
        Me.HomeTablePanel.Controls.Add(Me.Label4, 0, 4)
        Me.HomeTablePanel.Controls.Add(Me.Label3, 0, 3)
        Me.HomeTablePanel.Controls.Add(Me.Label2, 0, 2)
        Me.HomeTablePanel.Controls.Add(Me.Label1, 0, 1)
        Me.HomeTablePanel.Controls.Add(Me.Label7, 0, 0)
        Me.HomeTablePanel.Controls.Add(Me.Label6, 0, 7)
        Me.HomeTablePanel.Controls.Add(Me.Label8, 0, 6)
        Me.HomeTablePanel.Controls.Add(Me.DateLabel, 1, 0)
        Me.HomeTablePanel.Controls.Add(Me.NumChkInLabel, 1, 1)
        Me.HomeTablePanel.Controls.Add(Me.NumChkOutLabel, 1, 2)
        Me.HomeTablePanel.Controls.Add(Me.RoomRateLabel, 1, 3)
        Me.HomeTablePanel.Controls.Add(Me.CapacityLabel, 1, 4)
        Me.HomeTablePanel.Controls.Add(Me.CapacityOOOLabel, 1, 5)
        Me.HomeTablePanel.Controls.Add(Me.NumDirtyLabel, 1, 6)
        Me.HomeTablePanel.Controls.Add(Me.CleanLabel, 1, 7)
        Me.HomeTablePanel.Location = New System.Drawing.Point(108, 94)
        Me.HomeTablePanel.Margin = New System.Windows.Forms.Padding(4)
        Me.HomeTablePanel.Name = "HomeTablePanel"
        Me.HomeTablePanel.RowCount = 8
        Me.HomeTablePanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.HomeTablePanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.HomeTablePanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.HomeTablePanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.HomeTablePanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.HomeTablePanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.HomeTablePanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.HomeTablePanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.HomeTablePanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.HomeTablePanel.Size = New System.Drawing.Size(551, 201)
        Me.HomeTablePanel.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 125)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(164, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Capacity w/ OOO Rooms"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 100)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Capacity"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 75)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Room Rate"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 50)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Check-outs Remaining"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Check-ins Guaranteed "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(4, 0)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Hotel Statistics"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 175)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Clean Rooms Available"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(4, 150)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Dirty Rooms"
        '
        'DateLabel
        '
        Me.DateLabel.AutoSize = True
        Me.DateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateLabel.Location = New System.Drawing.Point(279, 0)
        Me.DateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DateLabel.Name = "DateLabel"
        Me.DateLabel.Size = New System.Drawing.Size(40, 17)
        Me.DateLabel.TabIndex = 8
        Me.DateLabel.Text = "GET"
        '
        'NumChkInLabel
        '
        Me.NumChkInLabel.AutoSize = True
        Me.NumChkInLabel.Location = New System.Drawing.Point(279, 25)
        Me.NumChkInLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.NumChkInLabel.Name = "NumChkInLabel"
        Me.NumChkInLabel.Size = New System.Drawing.Size(37, 17)
        Me.NumChkInLabel.TabIndex = 9
        Me.NumChkInLabel.Text = "GET"
        '
        'NumChkOutLabel
        '
        Me.NumChkOutLabel.AutoSize = True
        Me.NumChkOutLabel.Location = New System.Drawing.Point(279, 50)
        Me.NumChkOutLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.NumChkOutLabel.Name = "NumChkOutLabel"
        Me.NumChkOutLabel.Size = New System.Drawing.Size(37, 17)
        Me.NumChkOutLabel.TabIndex = 10
        Me.NumChkOutLabel.Text = "GET"
        '
        'RoomRateLabel
        '
        Me.RoomRateLabel.AutoSize = True
        Me.RoomRateLabel.Location = New System.Drawing.Point(279, 75)
        Me.RoomRateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.RoomRateLabel.Name = "RoomRateLabel"
        Me.RoomRateLabel.Size = New System.Drawing.Size(37, 17)
        Me.RoomRateLabel.TabIndex = 11
        Me.RoomRateLabel.Text = "GET"
        '
        'CapacityLabel
        '
        Me.CapacityLabel.AutoSize = True
        Me.CapacityLabel.Location = New System.Drawing.Point(279, 100)
        Me.CapacityLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CapacityLabel.Name = "CapacityLabel"
        Me.CapacityLabel.Size = New System.Drawing.Size(37, 17)
        Me.CapacityLabel.TabIndex = 12
        Me.CapacityLabel.Text = "GET"
        '
        'CapacityOOOLabel
        '
        Me.CapacityOOOLabel.AutoSize = True
        Me.CapacityOOOLabel.Location = New System.Drawing.Point(279, 125)
        Me.CapacityOOOLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CapacityOOOLabel.Name = "CapacityOOOLabel"
        Me.CapacityOOOLabel.Size = New System.Drawing.Size(37, 17)
        Me.CapacityOOOLabel.TabIndex = 13
        Me.CapacityOOOLabel.Text = "GET"
        '
        'NumDirtyLabel
        '
        Me.NumDirtyLabel.AutoSize = True
        Me.NumDirtyLabel.Location = New System.Drawing.Point(279, 150)
        Me.NumDirtyLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.NumDirtyLabel.Name = "NumDirtyLabel"
        Me.NumDirtyLabel.Size = New System.Drawing.Size(37, 17)
        Me.NumDirtyLabel.TabIndex = 14
        Me.NumDirtyLabel.Text = "GET"
        '
        'CleanLabel
        '
        Me.CleanLabel.AutoSize = True
        Me.CleanLabel.Location = New System.Drawing.Point(279, 175)
        Me.CleanLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CleanLabel.Name = "CleanLabel"
        Me.CleanLabel.Size = New System.Drawing.Size(37, 17)
        Me.CleanLabel.TabIndex = 15
        Me.CleanLabel.Text = "GET"
        '
        'ReservationPanel
        '
        Me.ReservationPanel.Controls.Add(Me.DataGridCustoTbl)
        Me.ReservationPanel.Location = New System.Drawing.Point(13, 51)
        Me.ReservationPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.ReservationPanel.Name = "ReservationPanel"
        Me.ReservationPanel.Size = New System.Drawing.Size(770, 420)
        Me.ReservationPanel.TabIndex = 2
        Me.ReservationPanel.Visible = False
        '
        'DataGridCustoTbl
        '
        Me.DataGridCustoTbl.AutoGenerateColumns = False
        Me.DataGridCustoTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridCustoTbl.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FIRSTNAMEDataGridViewTextBoxColumn3, Me.LASTNAMEDataGridViewTextBoxColumn3, Me.CUSTIDDataGridViewTextBoxColumn2, Me.DAYSDataGridViewTextBoxColumn2, Me.GUESTSDataGridViewTextBoxColumn2, Me.CHECKINDataGridViewTextBoxColumn2, Me.CHECKOUTDataGridViewTextBoxColumn2, Me.TIMEINDataGridViewTextBoxColumn2, Me.TIMEOUTDataGridViewTextBoxColumn2, Me.DATEOFORDERDataGridViewTextBoxColumn2, Me.TOTALCOSTDataGridViewTextBoxColumn2, Me.PAIDDataGridViewCheckBoxColumn2})
        Me.DataGridCustoTbl.DataSource = Me.CUSTOMERBindingSource
        Me.DataGridCustoTbl.Location = New System.Drawing.Point(-1, -1)
        Me.DataGridCustoTbl.Name = "DataGridCustoTbl"
        Me.DataGridCustoTbl.RowTemplate.Height = 24
        Me.DataGridCustoTbl.Size = New System.Drawing.Size(771, 411)
        Me.DataGridCustoTbl.TabIndex = 0
        '
        'FIRSTNAMEDataGridViewTextBoxColumn3
        '
        Me.FIRSTNAMEDataGridViewTextBoxColumn3.DataPropertyName = "FIRST_NAME"
        Me.FIRSTNAMEDataGridViewTextBoxColumn3.HeaderText = "FIRST_NAME"
        Me.FIRSTNAMEDataGridViewTextBoxColumn3.Name = "FIRSTNAMEDataGridViewTextBoxColumn3"
        '
        'LASTNAMEDataGridViewTextBoxColumn3
        '
        Me.LASTNAMEDataGridViewTextBoxColumn3.DataPropertyName = "LAST_NAME"
        Me.LASTNAMEDataGridViewTextBoxColumn3.HeaderText = "LAST_NAME"
        Me.LASTNAMEDataGridViewTextBoxColumn3.Name = "LASTNAMEDataGridViewTextBoxColumn3"
        '
        'CUSTIDDataGridViewTextBoxColumn2
        '
        Me.CUSTIDDataGridViewTextBoxColumn2.DataPropertyName = "CUST_ID#"
        Me.CUSTIDDataGridViewTextBoxColumn2.HeaderText = "CUST_ID#"
        Me.CUSTIDDataGridViewTextBoxColumn2.Name = "CUSTIDDataGridViewTextBoxColumn2"
        '
        'DAYSDataGridViewTextBoxColumn2
        '
        Me.DAYSDataGridViewTextBoxColumn2.DataPropertyName = "DAYS"
        Me.DAYSDataGridViewTextBoxColumn2.HeaderText = "DAYS"
        Me.DAYSDataGridViewTextBoxColumn2.Name = "DAYSDataGridViewTextBoxColumn2"
        '
        'GUESTSDataGridViewTextBoxColumn2
        '
        Me.GUESTSDataGridViewTextBoxColumn2.DataPropertyName = "GUESTS"
        Me.GUESTSDataGridViewTextBoxColumn2.HeaderText = "GUESTS"
        Me.GUESTSDataGridViewTextBoxColumn2.Name = "GUESTSDataGridViewTextBoxColumn2"
        '
        'CHECKINDataGridViewTextBoxColumn2
        '
        Me.CHECKINDataGridViewTextBoxColumn2.DataPropertyName = "CHECKIN"
        Me.CHECKINDataGridViewTextBoxColumn2.HeaderText = "CHECKIN"
        Me.CHECKINDataGridViewTextBoxColumn2.Name = "CHECKINDataGridViewTextBoxColumn2"
        '
        'CHECKOUTDataGridViewTextBoxColumn2
        '
        Me.CHECKOUTDataGridViewTextBoxColumn2.DataPropertyName = "CHECKOUT"
        Me.CHECKOUTDataGridViewTextBoxColumn2.HeaderText = "CHECKOUT"
        Me.CHECKOUTDataGridViewTextBoxColumn2.Name = "CHECKOUTDataGridViewTextBoxColumn2"
        '
        'TIMEINDataGridViewTextBoxColumn2
        '
        Me.TIMEINDataGridViewTextBoxColumn2.DataPropertyName = "TIME_IN"
        Me.TIMEINDataGridViewTextBoxColumn2.HeaderText = "TIME_IN"
        Me.TIMEINDataGridViewTextBoxColumn2.Name = "TIMEINDataGridViewTextBoxColumn2"
        '
        'TIMEOUTDataGridViewTextBoxColumn2
        '
        Me.TIMEOUTDataGridViewTextBoxColumn2.DataPropertyName = "TIME_OUT"
        Me.TIMEOUTDataGridViewTextBoxColumn2.HeaderText = "TIME_OUT"
        Me.TIMEOUTDataGridViewTextBoxColumn2.Name = "TIMEOUTDataGridViewTextBoxColumn2"
        '
        'DATEOFORDERDataGridViewTextBoxColumn2
        '
        Me.DATEOFORDERDataGridViewTextBoxColumn2.DataPropertyName = "DATE_OF_ORDER"
        Me.DATEOFORDERDataGridViewTextBoxColumn2.HeaderText = "DATE_OF_ORDER"
        Me.DATEOFORDERDataGridViewTextBoxColumn2.Name = "DATEOFORDERDataGridViewTextBoxColumn2"
        '
        'TOTALCOSTDataGridViewTextBoxColumn2
        '
        Me.TOTALCOSTDataGridViewTextBoxColumn2.DataPropertyName = "TOTAL_COST"
        Me.TOTALCOSTDataGridViewTextBoxColumn2.HeaderText = "TOTAL_COST"
        Me.TOTALCOSTDataGridViewTextBoxColumn2.Name = "TOTALCOSTDataGridViewTextBoxColumn2"
        '
        'PAIDDataGridViewCheckBoxColumn2
        '
        Me.PAIDDataGridViewCheckBoxColumn2.DataPropertyName = "PAID"
        Me.PAIDDataGridViewCheckBoxColumn2.HeaderText = "PAID"
        Me.PAIDDataGridViewCheckBoxColumn2.Name = "PAIDDataGridViewCheckBoxColumn2"
        '
        'CUSTOMERBindingSource
        '
        Me.CUSTOMERBindingSource.DataMember = "CUSTOMER"
        Me.CUSTOMERBindingSource.DataSource = Me.HOTELDBDataSetBindingSource
        '
        'HOTELDBDataSetBindingSource
        '
        Me.HOTELDBDataSetBindingSource.DataSource = Me.HOTEL_DBDataSet
        Me.HOTELDBDataSetBindingSource.Position = 0
        '
        'HOTEL_DBDataSet
        '
        Me.HOTEL_DBDataSet.DataSetName = "HOTEL_DBDataSet"
        Me.HOTEL_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ChkInPanel
        '
        Me.ChkInPanel.Controls.Add(Me.DataGridChkInTbl)
        Me.ChkInPanel.Location = New System.Drawing.Point(1, 1)
        Me.ChkInPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkInPanel.Name = "ChkInPanel"
        Me.ChkInPanel.Size = New System.Drawing.Size(770, 420)
        Me.ChkInPanel.TabIndex = 0
        Me.ChkInPanel.Visible = False
        '
        'DataGridChkInTbl
        '
        Me.DataGridChkInTbl.AutoGenerateColumns = False
        Me.DataGridChkInTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridChkInTbl.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FIRSTNAMEDataGridViewTextBoxColumn1, Me.LASTNAMEDataGridViewTextBoxColumn1, Me.CUSTIDDataGridViewTextBoxColumn, Me.DAYSDataGridViewTextBoxColumn, Me.GUESTSDataGridViewTextBoxColumn, Me.CHECKINDataGridViewTextBoxColumn, Me.CHECKOUTDataGridViewTextBoxColumn, Me.TIMEINDataGridViewTextBoxColumn, Me.TIMEOUTDataGridViewTextBoxColumn, Me.DATEOFORDERDataGridViewTextBoxColumn, Me.TOTALCOSTDataGridViewTextBoxColumn, Me.PAIDDataGridViewCheckBoxColumn})
        Me.DataGridChkInTbl.DataSource = Me.CUSTOMERBindingSource
        Me.DataGridChkInTbl.Location = New System.Drawing.Point(-1, 0)
        Me.DataGridChkInTbl.Name = "DataGridChkInTbl"
        Me.DataGridChkInTbl.RowTemplate.Height = 24
        Me.DataGridChkInTbl.Size = New System.Drawing.Size(771, 410)
        Me.DataGridChkInTbl.TabIndex = 0
        '
        'FIRSTNAMEDataGridViewTextBoxColumn1
        '
        Me.FIRSTNAMEDataGridViewTextBoxColumn1.DataPropertyName = "FIRST_NAME"
        Me.FIRSTNAMEDataGridViewTextBoxColumn1.HeaderText = "FIRST_NAME"
        Me.FIRSTNAMEDataGridViewTextBoxColumn1.Name = "FIRSTNAMEDataGridViewTextBoxColumn1"
        '
        'LASTNAMEDataGridViewTextBoxColumn1
        '
        Me.LASTNAMEDataGridViewTextBoxColumn1.DataPropertyName = "LAST_NAME"
        Me.LASTNAMEDataGridViewTextBoxColumn1.HeaderText = "LAST_NAME"
        Me.LASTNAMEDataGridViewTextBoxColumn1.Name = "LASTNAMEDataGridViewTextBoxColumn1"
        '
        'CUSTIDDataGridViewTextBoxColumn
        '
        Me.CUSTIDDataGridViewTextBoxColumn.DataPropertyName = "CUST_ID#"
        Me.CUSTIDDataGridViewTextBoxColumn.HeaderText = "CUST_ID#"
        Me.CUSTIDDataGridViewTextBoxColumn.Name = "CUSTIDDataGridViewTextBoxColumn"
        '
        'DAYSDataGridViewTextBoxColumn
        '
        Me.DAYSDataGridViewTextBoxColumn.DataPropertyName = "DAYS"
        Me.DAYSDataGridViewTextBoxColumn.HeaderText = "DAYS"
        Me.DAYSDataGridViewTextBoxColumn.Name = "DAYSDataGridViewTextBoxColumn"
        '
        'GUESTSDataGridViewTextBoxColumn
        '
        Me.GUESTSDataGridViewTextBoxColumn.DataPropertyName = "GUESTS"
        Me.GUESTSDataGridViewTextBoxColumn.HeaderText = "GUESTS"
        Me.GUESTSDataGridViewTextBoxColumn.Name = "GUESTSDataGridViewTextBoxColumn"
        '
        'CHECKINDataGridViewTextBoxColumn
        '
        Me.CHECKINDataGridViewTextBoxColumn.DataPropertyName = "CHECKIN"
        Me.CHECKINDataGridViewTextBoxColumn.HeaderText = "CHECKIN"
        Me.CHECKINDataGridViewTextBoxColumn.Name = "CHECKINDataGridViewTextBoxColumn"
        '
        'CHECKOUTDataGridViewTextBoxColumn
        '
        Me.CHECKOUTDataGridViewTextBoxColumn.DataPropertyName = "CHECKOUT"
        Me.CHECKOUTDataGridViewTextBoxColumn.HeaderText = "CHECKOUT"
        Me.CHECKOUTDataGridViewTextBoxColumn.Name = "CHECKOUTDataGridViewTextBoxColumn"
        '
        'TIMEINDataGridViewTextBoxColumn
        '
        Me.TIMEINDataGridViewTextBoxColumn.DataPropertyName = "TIME_IN"
        Me.TIMEINDataGridViewTextBoxColumn.HeaderText = "TIME_IN"
        Me.TIMEINDataGridViewTextBoxColumn.Name = "TIMEINDataGridViewTextBoxColumn"
        '
        'TIMEOUTDataGridViewTextBoxColumn
        '
        Me.TIMEOUTDataGridViewTextBoxColumn.DataPropertyName = "TIME_OUT"
        Me.TIMEOUTDataGridViewTextBoxColumn.HeaderText = "TIME_OUT"
        Me.TIMEOUTDataGridViewTextBoxColumn.Name = "TIMEOUTDataGridViewTextBoxColumn"
        '
        'DATEOFORDERDataGridViewTextBoxColumn
        '
        Me.DATEOFORDERDataGridViewTextBoxColumn.DataPropertyName = "DATE_OF_ORDER"
        Me.DATEOFORDERDataGridViewTextBoxColumn.HeaderText = "DATE_OF_ORDER"
        Me.DATEOFORDERDataGridViewTextBoxColumn.Name = "DATEOFORDERDataGridViewTextBoxColumn"
        '
        'TOTALCOSTDataGridViewTextBoxColumn
        '
        Me.TOTALCOSTDataGridViewTextBoxColumn.DataPropertyName = "TOTAL_COST"
        Me.TOTALCOSTDataGridViewTextBoxColumn.HeaderText = "TOTAL_COST"
        Me.TOTALCOSTDataGridViewTextBoxColumn.Name = "TOTALCOSTDataGridViewTextBoxColumn"
        '
        'PAIDDataGridViewCheckBoxColumn
        '
        Me.PAIDDataGridViewCheckBoxColumn.DataPropertyName = "PAID"
        Me.PAIDDataGridViewCheckBoxColumn.HeaderText = "PAID"
        Me.PAIDDataGridViewCheckBoxColumn.Name = "PAIDDataGridViewCheckBoxColumn"
        '
        'ChkOutPanel
        '
        Me.ChkOutPanel.Controls.Add(Me.ChkInPanel)
        Me.ChkOutPanel.Controls.Add(Me.DataGridChkOutTbl)
        Me.ChkOutPanel.Location = New System.Drawing.Point(12, 50)
        Me.ChkOutPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkOutPanel.Name = "ChkOutPanel"
        Me.ChkOutPanel.Size = New System.Drawing.Size(771, 421)
        Me.ChkOutPanel.TabIndex = 0
        Me.ChkOutPanel.Visible = False
        '
        'DataGridChkOutTbl
        '
        Me.DataGridChkOutTbl.AutoGenerateColumns = False
        Me.DataGridChkOutTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridChkOutTbl.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FIRSTNAMEDataGridViewTextBoxColumn2, Me.LASTNAMEDataGridViewTextBoxColumn2, Me.CUSTIDDataGridViewTextBoxColumn1, Me.DAYSDataGridViewTextBoxColumn1, Me.GUESTSDataGridViewTextBoxColumn1, Me.CHECKINDataGridViewTextBoxColumn1, Me.CHECKOUTDataGridViewTextBoxColumn1, Me.TIMEINDataGridViewTextBoxColumn1, Me.TIMEOUTDataGridViewTextBoxColumn1, Me.DATEOFORDERDataGridViewTextBoxColumn1, Me.TOTALCOSTDataGridViewTextBoxColumn1, Me.PAIDDataGridViewCheckBoxColumn1})
        Me.DataGridChkOutTbl.DataSource = Me.CUSTOMERBindingSource
        Me.DataGridChkOutTbl.Location = New System.Drawing.Point(0, 1)
        Me.DataGridChkOutTbl.Name = "DataGridChkOutTbl"
        Me.DataGridChkOutTbl.RowTemplate.Height = 24
        Me.DataGridChkOutTbl.Size = New System.Drawing.Size(771, 410)
        Me.DataGridChkOutTbl.TabIndex = 0
        '
        'FIRSTNAMEDataGridViewTextBoxColumn2
        '
        Me.FIRSTNAMEDataGridViewTextBoxColumn2.DataPropertyName = "FIRST_NAME"
        Me.FIRSTNAMEDataGridViewTextBoxColumn2.HeaderText = "FIRST_NAME"
        Me.FIRSTNAMEDataGridViewTextBoxColumn2.Name = "FIRSTNAMEDataGridViewTextBoxColumn2"
        '
        'LASTNAMEDataGridViewTextBoxColumn2
        '
        Me.LASTNAMEDataGridViewTextBoxColumn2.DataPropertyName = "LAST_NAME"
        Me.LASTNAMEDataGridViewTextBoxColumn2.HeaderText = "LAST_NAME"
        Me.LASTNAMEDataGridViewTextBoxColumn2.Name = "LASTNAMEDataGridViewTextBoxColumn2"
        '
        'CUSTIDDataGridViewTextBoxColumn1
        '
        Me.CUSTIDDataGridViewTextBoxColumn1.DataPropertyName = "CUST_ID#"
        Me.CUSTIDDataGridViewTextBoxColumn1.HeaderText = "CUST_ID#"
        Me.CUSTIDDataGridViewTextBoxColumn1.Name = "CUSTIDDataGridViewTextBoxColumn1"
        '
        'DAYSDataGridViewTextBoxColumn1
        '
        Me.DAYSDataGridViewTextBoxColumn1.DataPropertyName = "DAYS"
        Me.DAYSDataGridViewTextBoxColumn1.HeaderText = "DAYS"
        Me.DAYSDataGridViewTextBoxColumn1.Name = "DAYSDataGridViewTextBoxColumn1"
        '
        'GUESTSDataGridViewTextBoxColumn1
        '
        Me.GUESTSDataGridViewTextBoxColumn1.DataPropertyName = "GUESTS"
        Me.GUESTSDataGridViewTextBoxColumn1.HeaderText = "GUESTS"
        Me.GUESTSDataGridViewTextBoxColumn1.Name = "GUESTSDataGridViewTextBoxColumn1"
        '
        'CHECKINDataGridViewTextBoxColumn1
        '
        Me.CHECKINDataGridViewTextBoxColumn1.DataPropertyName = "CHECKIN"
        Me.CHECKINDataGridViewTextBoxColumn1.HeaderText = "CHECKIN"
        Me.CHECKINDataGridViewTextBoxColumn1.Name = "CHECKINDataGridViewTextBoxColumn1"
        '
        'CHECKOUTDataGridViewTextBoxColumn1
        '
        Me.CHECKOUTDataGridViewTextBoxColumn1.DataPropertyName = "CHECKOUT"
        Me.CHECKOUTDataGridViewTextBoxColumn1.HeaderText = "CHECKOUT"
        Me.CHECKOUTDataGridViewTextBoxColumn1.Name = "CHECKOUTDataGridViewTextBoxColumn1"
        '
        'TIMEINDataGridViewTextBoxColumn1
        '
        Me.TIMEINDataGridViewTextBoxColumn1.DataPropertyName = "TIME_IN"
        Me.TIMEINDataGridViewTextBoxColumn1.HeaderText = "TIME_IN"
        Me.TIMEINDataGridViewTextBoxColumn1.Name = "TIMEINDataGridViewTextBoxColumn1"
        '
        'TIMEOUTDataGridViewTextBoxColumn1
        '
        Me.TIMEOUTDataGridViewTextBoxColumn1.DataPropertyName = "TIME_OUT"
        Me.TIMEOUTDataGridViewTextBoxColumn1.HeaderText = "TIME_OUT"
        Me.TIMEOUTDataGridViewTextBoxColumn1.Name = "TIMEOUTDataGridViewTextBoxColumn1"
        '
        'DATEOFORDERDataGridViewTextBoxColumn1
        '
        Me.DATEOFORDERDataGridViewTextBoxColumn1.DataPropertyName = "DATE_OF_ORDER"
        Me.DATEOFORDERDataGridViewTextBoxColumn1.HeaderText = "DATE_OF_ORDER"
        Me.DATEOFORDERDataGridViewTextBoxColumn1.Name = "DATEOFORDERDataGridViewTextBoxColumn1"
        '
        'TOTALCOSTDataGridViewTextBoxColumn1
        '
        Me.TOTALCOSTDataGridViewTextBoxColumn1.DataPropertyName = "TOTAL_COST"
        Me.TOTALCOSTDataGridViewTextBoxColumn1.HeaderText = "TOTAL_COST"
        Me.TOTALCOSTDataGridViewTextBoxColumn1.Name = "TOTALCOSTDataGridViewTextBoxColumn1"
        '
        'PAIDDataGridViewCheckBoxColumn1
        '
        Me.PAIDDataGridViewCheckBoxColumn1.DataPropertyName = "PAID"
        Me.PAIDDataGridViewCheckBoxColumn1.HeaderText = "PAID"
        Me.PAIDDataGridViewCheckBoxColumn1.Name = "PAIDDataGridViewCheckBoxColumn1"
        '
        'MaintenancePanel
        '
        Me.MaintenancePanel.Controls.Add(Me.DataGridMaintenanceTbl)
        Me.MaintenancePanel.Location = New System.Drawing.Point(12, 51)
        Me.MaintenancePanel.Margin = New System.Windows.Forms.Padding(4)
        Me.MaintenancePanel.Name = "MaintenancePanel"
        Me.MaintenancePanel.Size = New System.Drawing.Size(771, 416)
        Me.MaintenancePanel.TabIndex = 0
        Me.MaintenancePanel.Visible = False
        '
        'DataGridMaintenanceTbl
        '
        Me.DataGridMaintenanceTbl.AutoGenerateColumns = False
        Me.DataGridMaintenanceTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridMaintenanceTbl.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ROOMDataGridViewTextBoxColumn1, Me.TYPEDataGridViewTextBoxColumn1, Me.COSTDataGridViewTextBoxColumn1, Me.OCCUPIEDDataGridViewCheckBoxColumn1, Me.DATEOCCUPIEDDataGridViewTextBoxColumn1, Me.TIMEOCCUPIEDDataGridViewTextBoxColumn1, Me.OCCUPANTIDDataGridViewTextBoxColumn1})
        Me.DataGridMaintenanceTbl.DataSource = Me.ROOMSBindingSource
        Me.DataGridMaintenanceTbl.Location = New System.Drawing.Point(0, -1)
        Me.DataGridMaintenanceTbl.Name = "DataGridMaintenanceTbl"
        Me.DataGridMaintenanceTbl.RowTemplate.Height = 24
        Me.DataGridMaintenanceTbl.Size = New System.Drawing.Size(771, 411)
        Me.DataGridMaintenanceTbl.TabIndex = 0
        '
        'ROOMDataGridViewTextBoxColumn1
        '
        Me.ROOMDataGridViewTextBoxColumn1.DataPropertyName = "ROOM#"
        Me.ROOMDataGridViewTextBoxColumn1.HeaderText = "ROOM#"
        Me.ROOMDataGridViewTextBoxColumn1.Name = "ROOMDataGridViewTextBoxColumn1"
        '
        'TYPEDataGridViewTextBoxColumn1
        '
        Me.TYPEDataGridViewTextBoxColumn1.DataPropertyName = "TYPE"
        Me.TYPEDataGridViewTextBoxColumn1.HeaderText = "TYPE"
        Me.TYPEDataGridViewTextBoxColumn1.Name = "TYPEDataGridViewTextBoxColumn1"
        '
        'COSTDataGridViewTextBoxColumn1
        '
        Me.COSTDataGridViewTextBoxColumn1.DataPropertyName = "COST"
        Me.COSTDataGridViewTextBoxColumn1.HeaderText = "COST"
        Me.COSTDataGridViewTextBoxColumn1.Name = "COSTDataGridViewTextBoxColumn1"
        '
        'OCCUPIEDDataGridViewCheckBoxColumn1
        '
        Me.OCCUPIEDDataGridViewCheckBoxColumn1.DataPropertyName = "OCCUPIED"
        Me.OCCUPIEDDataGridViewCheckBoxColumn1.HeaderText = "OCCUPIED"
        Me.OCCUPIEDDataGridViewCheckBoxColumn1.Name = "OCCUPIEDDataGridViewCheckBoxColumn1"
        '
        'DATEOCCUPIEDDataGridViewTextBoxColumn1
        '
        Me.DATEOCCUPIEDDataGridViewTextBoxColumn1.DataPropertyName = "DATE_OCCUPIED"
        Me.DATEOCCUPIEDDataGridViewTextBoxColumn1.HeaderText = "DATE_OCCUPIED"
        Me.DATEOCCUPIEDDataGridViewTextBoxColumn1.Name = "DATEOCCUPIEDDataGridViewTextBoxColumn1"
        '
        'TIMEOCCUPIEDDataGridViewTextBoxColumn1
        '
        Me.TIMEOCCUPIEDDataGridViewTextBoxColumn1.DataPropertyName = "TIME_OCCUPIED"
        Me.TIMEOCCUPIEDDataGridViewTextBoxColumn1.HeaderText = "TIME_OCCUPIED"
        Me.TIMEOCCUPIEDDataGridViewTextBoxColumn1.Name = "TIMEOCCUPIEDDataGridViewTextBoxColumn1"
        '
        'OCCUPANTIDDataGridViewTextBoxColumn1
        '
        Me.OCCUPANTIDDataGridViewTextBoxColumn1.DataPropertyName = "OCCUPANT_ID#"
        Me.OCCUPANTIDDataGridViewTextBoxColumn1.HeaderText = "OCCUPANT_ID#"
        Me.OCCUPANTIDDataGridViewTextBoxColumn1.Name = "OCCUPANTIDDataGridViewTextBoxColumn1"
        '
        'ROOMSBindingSource
        '
        Me.ROOMSBindingSource.DataMember = "ROOMS"
        Me.ROOMSBindingSource.DataSource = Me.HOTEL_DBDataSet
        '
        'EmployeePanel
        '
        Me.EmployeePanel.Controls.Add(Me.DataGridEmplyTbl)
        Me.EmployeePanel.Location = New System.Drawing.Point(12, 50)
        Me.EmployeePanel.Margin = New System.Windows.Forms.Padding(4)
        Me.EmployeePanel.Name = "EmployeePanel"
        Me.EmployeePanel.Size = New System.Drawing.Size(771, 421)
        Me.EmployeePanel.TabIndex = 0
        '
        'DataGridEmplyTbl
        '
        Me.DataGridEmplyTbl.AutoGenerateColumns = False
        Me.DataGridEmplyTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridEmplyTbl.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FIRSTNAMEDataGridViewTextBoxColumn, Me.LASTNAMEDataGridViewTextBoxColumn, Me.SSNDataGridViewTextBoxColumn, Me.PHONEDataGridViewTextBoxColumn, Me.TITLEDataGridViewTextBoxColumn, Me.DEPTDataGridViewTextBoxColumn, Me.PAYHRLYDataGridViewTextBoxColumn})
        Me.DataGridEmplyTbl.DataSource = Me.EMPLOYEEBindingSource2
        Me.DataGridEmplyTbl.Location = New System.Drawing.Point(0, 1)
        Me.DataGridEmplyTbl.Name = "DataGridEmplyTbl"
        Me.DataGridEmplyTbl.RowTemplate.Height = 24
        Me.DataGridEmplyTbl.Size = New System.Drawing.Size(771, 410)
        Me.DataGridEmplyTbl.TabIndex = 0
        '
        'EMPLOYEEBindingSource1
        '
        Me.EMPLOYEEBindingSource1.DataMember = "EMPLOYEE"
        Me.EMPLOYEEBindingSource1.DataSource = Me.HOTELDBDataSetBindingSource
        '
        'EMPLOYEEBindingSource
        '
        Me.EMPLOYEEBindingSource.DataMember = "EMPLOYEE"
        Me.EMPLOYEEBindingSource.DataSource = Me.HOTELDBDataSetBindingSource
        '
        'ROOMSBindingSource1
        '
        Me.ROOMSBindingSource1.DataMember = "ROOMS"
        Me.ROOMSBindingSource1.DataSource = Me.HOTELDBDataSetBindingSource
        '
        'ROOMSBindingSource2
        '
        Me.ROOMSBindingSource2.DataMember = "ROOMS"
        Me.ROOMSBindingSource2.DataSource = Me.HOTELDBDataSetBindingSource
        '
        'ROOMSTableAdapter
        '
        Me.ROOMSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CUSTOMERTableAdapter = Nothing
        Me.TableAdapterManager.EMPLOYEETableAdapter = Nothing
        Me.TableAdapterManager.EMPLY_PAY_TABLETableAdapter = Nothing
        Me.TableAdapterManager.MANAGEMENTTableAdapter = Nothing
        Me.TableAdapterManager.ROOMSTableAdapter = Me.ROOMSTableAdapter
        Me.TableAdapterManager.UpdateOrder = HotelSystem.HOTEL_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EMPLOYEETableAdapter
        '
        Me.EMPLOYEETableAdapter.ClearBeforeFill = True
        '
        'CUSTOMERTableAdapter
        '
        Me.CUSTOMERTableAdapter.ClearBeforeFill = True
        '
        'EMPLOYEEBindingSource2
        '
        Me.EMPLOYEEBindingSource2.DataMember = "EMPLOYEE"
        Me.EMPLOYEEBindingSource2.DataSource = Me.HOTELDBDataSetBindingSource
        '
        'FIRSTNAMEDataGridViewTextBoxColumn
        '
        Me.FIRSTNAMEDataGridViewTextBoxColumn.DataPropertyName = "FIRST_NAME"
        Me.FIRSTNAMEDataGridViewTextBoxColumn.HeaderText = "FIRST_NAME"
        Me.FIRSTNAMEDataGridViewTextBoxColumn.Name = "FIRSTNAMEDataGridViewTextBoxColumn"
        '
        'LASTNAMEDataGridViewTextBoxColumn
        '
        Me.LASTNAMEDataGridViewTextBoxColumn.DataPropertyName = "LAST_NAME"
        Me.LASTNAMEDataGridViewTextBoxColumn.HeaderText = "LAST_NAME"
        Me.LASTNAMEDataGridViewTextBoxColumn.Name = "LASTNAMEDataGridViewTextBoxColumn"
        '
        'SSNDataGridViewTextBoxColumn
        '
        Me.SSNDataGridViewTextBoxColumn.DataPropertyName = "SSN"
        Me.SSNDataGridViewTextBoxColumn.HeaderText = "SSN"
        Me.SSNDataGridViewTextBoxColumn.Name = "SSNDataGridViewTextBoxColumn"
        '
        'PHONEDataGridViewTextBoxColumn
        '
        Me.PHONEDataGridViewTextBoxColumn.DataPropertyName = "PHONE#"
        Me.PHONEDataGridViewTextBoxColumn.HeaderText = "PHONE#"
        Me.PHONEDataGridViewTextBoxColumn.Name = "PHONEDataGridViewTextBoxColumn"
        '
        'TITLEDataGridViewTextBoxColumn
        '
        Me.TITLEDataGridViewTextBoxColumn.DataPropertyName = "TITLE"
        Me.TITLEDataGridViewTextBoxColumn.HeaderText = "TITLE"
        Me.TITLEDataGridViewTextBoxColumn.Name = "TITLEDataGridViewTextBoxColumn"
        '
        'DEPTDataGridViewTextBoxColumn
        '
        Me.DEPTDataGridViewTextBoxColumn.DataPropertyName = "DEPT#"
        Me.DEPTDataGridViewTextBoxColumn.HeaderText = "DEPT#"
        Me.DEPTDataGridViewTextBoxColumn.Name = "DEPTDataGridViewTextBoxColumn"
        '
        'PAYHRLYDataGridViewTextBoxColumn
        '
        Me.PAYHRLYDataGridViewTextBoxColumn.DataPropertyName = "PAY_HRLY"
        Me.PAYHRLYDataGridViewTextBoxColumn.HeaderText = "PAY_HRLY"
        Me.PAYHRLYDataGridViewTextBoxColumn.Name = "PAYHRLYDataGridViewTextBoxColumn"
        '
        'HomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1262, 473)
        Me.Controls.Add(Me.EmployeePanel)
        Me.Controls.Add(Me.HomePanel)
        Me.Controls.Add(Me.MaintenancePanel)
        Me.Controls.Add(Me.ChkOutPanel)
        Me.Controls.Add(Me.ReservationPanel)
        Me.Controls.Add(Me.LogoutButton)
        Me.Controls.Add(Me.EmployeeButton)
        Me.Controls.Add(Me.MaintenanceButton)
        Me.Controls.Add(Me.CheckOutButton)
        Me.Controls.Add(Me.CheckInButton)
        Me.Controls.Add(Me.ResButton)
        Me.Controls.Add(Me.HomeButton)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "HomePage"
        Me.Text = "Home"
        Me.HomePanel.ResumeLayout(False)
        Me.HomeTablePanel.ResumeLayout(False)
        Me.HomeTablePanel.PerformLayout()
        Me.ReservationPanel.ResumeLayout(False)
        CType(Me.DataGridCustoTbl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CUSTOMERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HOTELDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HOTEL_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ChkInPanel.ResumeLayout(False)
        CType(Me.DataGridChkInTbl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ChkOutPanel.ResumeLayout(False)
        CType(Me.DataGridChkOutTbl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MaintenancePanel.ResumeLayout(False)
        CType(Me.DataGridMaintenanceTbl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ROOMSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EmployeePanel.ResumeLayout(False)
        CType(Me.DataGridEmplyTbl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPLOYEEBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPLOYEEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ROOMSBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ROOMSBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPLOYEEBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HomeButton As Button
    Friend WithEvents ResButton As Button
    Friend WithEvents CheckInButton As Button
    Friend WithEvents CheckOutButton As Button
    Friend WithEvents MaintenanceButton As Button
    Friend WithEvents EmployeeButton As Button
    Friend WithEvents LogoutButton As Button
    Friend WithEvents HomePanel As Panel
    Friend WithEvents HomeTablePanel As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents DateLabel As Label
    Friend WithEvents RefreshHomeInfo As Button
    Friend WithEvents NumChkInLabel As Label
    Friend WithEvents NumChkOutLabel As Label
    Friend WithEvents RoomRateLabel As Label
    Friend WithEvents CapacityLabel As Label
    Friend WithEvents CapacityOOOLabel As Label
    Friend WithEvents NumDirtyLabel As Label
    Friend WithEvents CleanLabel As Label
    Friend WithEvents ReservationPanel As Panel
    Friend WithEvents HOTEL_DBDataSet As HOTEL_DBDataSet
    Friend WithEvents ROOMSBindingSource As BindingSource
    Friend WithEvents ROOMSTableAdapter As HOTEL_DBDataSetTableAdapters.ROOMSTableAdapter
    Friend WithEvents TableAdapterManager As HOTEL_DBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ChkInPanel As Panel
    Friend WithEvents ChkOutPanel As Panel
    Friend WithEvents MaintenancePanel As Panel
    Friend WithEvents EmployeePanel As Panel
    Friend WithEvents DataGridEmplyTbl As DataGridView
    Friend WithEvents HOTELDBDataSetBindingSource As BindingSource
    Friend WithEvents EMPLOYEEBindingSource As BindingSource
    Friend WithEvents EMPLOYEETableAdapter As HOTEL_DBDataSetTableAdapters.EMPLOYEETableAdapter
    Friend WithEvents ROOMSBindingSource1 As BindingSource
    Friend WithEvents CUSTOMERBindingSource As BindingSource
    Friend WithEvents CUSTOMERTableAdapter As HOTEL_DBDataSetTableAdapters.CUSTOMERTableAdapter
    Friend WithEvents ROOMSBindingSource2 As BindingSource
    Friend WithEvents DataGridMaintenanceTbl As DataGridView
    Friend WithEvents ROOMDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TYPEDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents COSTDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents OCCUPIEDDataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DATEOCCUPIEDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TIMEOCCUPIEDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents OCCUPANTIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridCustoTbl As DataGridView
    Friend WithEvents FIRSTNAMEDataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents LASTNAMEDataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents CUSTIDDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DAYSDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents GUESTSDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents CHECKINDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents CHECKOUTDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents TIMEINDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents TIMEOUTDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DATEOFORDERDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents TOTALCOSTDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents PAIDDataGridViewCheckBoxColumn2 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridChkInTbl As DataGridView
    Friend WithEvents FIRSTNAMEDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents LASTNAMEDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CUSTIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DAYSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GUESTSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CHECKINDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CHECKOUTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TIMEINDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TIMEOUTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DATEOFORDERDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TOTALCOSTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PAIDDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridChkOutTbl As DataGridView
    Friend WithEvents FIRSTNAMEDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents LASTNAMEDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents CUSTIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DAYSDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents GUESTSDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CHECKINDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CHECKOUTDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TIMEINDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TIMEOUTDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DATEOFORDERDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TOTALCOSTDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PAIDDataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents EMPLOYEEBindingSource1 As BindingSource
    Friend WithEvents EMPLOYEEBindingSource2 As BindingSource
    Friend WithEvents FIRSTNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LASTNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SSNDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PHONEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TITLEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DEPTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PAYHRLYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
