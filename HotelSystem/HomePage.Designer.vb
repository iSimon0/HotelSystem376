<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.HOTEL_DBDataSet = New HotelSystem.HOTEL_DBDataSet()
        Me.ROOMSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ROOMSTableAdapter = New HotelSystem.HOTEL_DBDataSetTableAdapters.ROOMSTableAdapter()
        Me.TableAdapterManager = New HotelSystem.HOTEL_DBDataSetTableAdapters.TableAdapterManager()
        Me.ChkInPanel = New System.Windows.Forms.Panel()
        Me.ChkOutPanel = New System.Windows.Forms.Panel()
        Me.MaintenancePanel = New System.Windows.Forms.Panel()
        Me.EmployeePanel = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.HOTELDBDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EMPLOYEEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EMPLOYEETableAdapter = New HotelSystem.HOTEL_DBDataSetTableAdapters.EMPLOYEETableAdapter()
        Me.FIRSTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LASTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SSNDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PHONEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TITLEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DEPTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAYHRLYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HomePanel.SuspendLayout()
        Me.HomeTablePanel.SuspendLayout()
        CType(Me.HOTEL_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ROOMSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EmployeePanel.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HOTELDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPLOYEEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.HomePanel.Location = New System.Drawing.Point(13, 51)
        Me.HomePanel.Margin = New System.Windows.Forms.Padding(4)
        Me.HomePanel.Name = "HomePanel"
        Me.HomePanel.Size = New System.Drawing.Size(770, 409)
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
        Me.ReservationPanel.Location = New System.Drawing.Point(861, 292)
        Me.ReservationPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.ReservationPanel.Name = "ReservationPanel"
        Me.ReservationPanel.Size = New System.Drawing.Size(159, 98)
        Me.ReservationPanel.TabIndex = 2
        Me.ReservationPanel.Visible = False
        '
        'HOTEL_DBDataSet
        '
        Me.HOTEL_DBDataSet.DataSetName = "HOTEL_DBDataSet"
        Me.HOTEL_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ROOMSBindingSource
        '
        Me.ROOMSBindingSource.DataMember = "ROOMS"
        Me.ROOMSBindingSource.DataSource = Me.HOTEL_DBDataSet
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
        'ChkInPanel
        '
        Me.ChkInPanel.Location = New System.Drawing.Point(1148, 345)
        Me.ChkInPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkInPanel.Name = "ChkInPanel"
        Me.ChkInPanel.Size = New System.Drawing.Size(77, 93)
        Me.ChkInPanel.TabIndex = 0
        Me.ChkInPanel.Visible = False
        '
        'ChkOutPanel
        '
        Me.ChkOutPanel.Location = New System.Drawing.Point(900, 146)
        Me.ChkOutPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkOutPanel.Name = "ChkOutPanel"
        Me.ChkOutPanel.Size = New System.Drawing.Size(112, 98)
        Me.ChkOutPanel.TabIndex = 0
        Me.ChkOutPanel.Visible = False
        '
        'MaintenancePanel
        '
        Me.MaintenancePanel.Location = New System.Drawing.Point(1138, 236)
        Me.MaintenancePanel.Margin = New System.Windows.Forms.Padding(4)
        Me.MaintenancePanel.Name = "MaintenancePanel"
        Me.MaintenancePanel.Size = New System.Drawing.Size(87, 66)
        Me.MaintenancePanel.TabIndex = 0
        Me.MaintenancePanel.Visible = False
        '
        'EmployeePanel
        '
        Me.EmployeePanel.Controls.Add(Me.DataGridView1)
        Me.EmployeePanel.Location = New System.Drawing.Point(13, 52)
        Me.EmployeePanel.Margin = New System.Windows.Forms.Padding(4)
        Me.EmployeePanel.Name = "EmployeePanel"
        Me.EmployeePanel.Size = New System.Drawing.Size(770, 408)
        Me.EmployeePanel.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FIRSTNAMEDataGridViewTextBoxColumn, Me.LASTNAMEDataGridViewTextBoxColumn, Me.SSNDataGridViewTextBoxColumn, Me.PHONEDataGridViewTextBoxColumn, Me.TITLEDataGridViewTextBoxColumn, Me.DEPTDataGridViewTextBoxColumn, Me.PAYHRLYDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EMPLOYEEBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(764, 402)
        Me.DataGridView1.TabIndex = 0
        '
        'HOTELDBDataSetBindingSource
        '
        Me.HOTELDBDataSetBindingSource.DataSource = Me.HOTEL_DBDataSet
        Me.HOTELDBDataSetBindingSource.Position = 0
        '
        'EMPLOYEEBindingSource
        '
        Me.EMPLOYEEBindingSource.DataMember = "EMPLOYEE"
        Me.EMPLOYEEBindingSource.DataSource = Me.HOTELDBDataSetBindingSource
        '
        'EMPLOYEETableAdapter
        '
        Me.EMPLOYEETableAdapter.ClearBeforeFill = True
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
        Me.Controls.Add(Me.HomePanel)
        Me.Controls.Add(Me.MaintenancePanel)
        Me.Controls.Add(Me.EmployeePanel)
        Me.Controls.Add(Me.ChkOutPanel)
        Me.Controls.Add(Me.ChkInPanel)
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
        CType(Me.HOTEL_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ROOMSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EmployeePanel.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HOTELDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPLOYEEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents HOTELDBDataSetBindingSource As BindingSource
    Friend WithEvents EMPLOYEEBindingSource As BindingSource
    Friend WithEvents EMPLOYEETableAdapter As HOTEL_DBDataSetTableAdapters.EMPLOYEETableAdapter
    Friend WithEvents FIRSTNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LASTNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SSNDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PHONEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TITLEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DEPTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PAYHRLYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
