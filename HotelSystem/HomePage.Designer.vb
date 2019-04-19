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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomePage))
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateLabel = New System.Windows.Forms.Label()
        Me.NumChkInLabel = New System.Windows.Forms.Label()
        Me.NumChkOutLabel = New System.Windows.Forms.Label()
        Me.RoomRateLabel = New System.Windows.Forms.Label()
        Me.CapacityLabel = New System.Windows.Forms.Label()
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
        Me.btnChkInDGV = New System.Windows.Forms.Button()
        Me.CUSTOMERDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CUSTOMERBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ChkOutPanel = New System.Windows.Forms.Panel()
        Me.btnChkOutDGV = New System.Windows.Forms.Button()
        Me.CUSTOMERDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CUSTOMERBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MaintenancePanel = New System.Windows.Forms.Panel()
        Me.btnRoomsDGV = New System.Windows.Forms.Button()
        Me.DataGridMaintenanceTbl = New System.Windows.Forms.DataGridView()
        Me.ROOMDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TYPEDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COSTDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATEOCCUPIEDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIMEOCCUPIEDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OCCUPANTIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ROOMSBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeePanel = New System.Windows.Forms.Panel()
        Me.btnEmplyDGV = New System.Windows.Forms.Button()
        Me.DataGridEmplyTbl = New System.Windows.Forms.DataGridView()
        Me.FIRSTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LASTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SSNDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PHONEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TITLEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DEPTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAYHRLYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMPLOYEEBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EMPLOYEEBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EMPLOYEEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EMPLOYEEBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ROOMSBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ROOMSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ROOMSTableAdapter = New HotelSystem.HOTEL_DBDataSetTableAdapters.ROOMSTableAdapter()
        Me.TableAdapterManager = New HotelSystem.HOTEL_DBDataSetTableAdapters.TableAdapterManager()
        Me.EMPLOYEETableAdapter = New HotelSystem.HOTEL_DBDataSetTableAdapters.EMPLOYEETableAdapter()
        Me.CUSTOMERTableAdapter = New HotelSystem.HOTEL_DBDataSetTableAdapters.CUSTOMERTableAdapter()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.HomePanel.SuspendLayout()
        Me.HomeTablePanel.SuspendLayout()
        Me.ReservationPanel.SuspendLayout()
        CType(Me.DataGridCustoTbl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CUSTOMERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HOTELDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HOTEL_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ChkInPanel.SuspendLayout()
        CType(Me.CUSTOMERDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CUSTOMERBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ChkOutPanel.SuspendLayout()
        CType(Me.CUSTOMERDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CUSTOMERBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MaintenancePanel.SuspendLayout()
        CType(Me.DataGridMaintenanceTbl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ROOMSBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EmployeePanel.SuspendLayout()
        CType(Me.DataGridEmplyTbl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPLOYEEBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPLOYEEBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPLOYEEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPLOYEEBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ROOMSBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ROOMSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HomeButton
        '
        Me.HomeButton.BackgroundImage = Global.HotelSystem.My.Resources.Resources.HomeNew
        Me.HomeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HomeButton.FlatAppearance.BorderSize = 0
        Me.HomeButton.Location = New System.Drawing.Point(37, 117)
        Me.HomeButton.Margin = New System.Windows.Forms.Padding(4)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(140, 75)
        Me.HomeButton.TabIndex = 0
        Me.HomeButton.UseVisualStyleBackColor = True
        '
        'ResButton
        '
        Me.ResButton.BackgroundImage = Global.HotelSystem.My.Resources.Resources.resrv3
        Me.ResButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ResButton.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.ResButton.FlatAppearance.BorderSize = 0
        Me.ResButton.Location = New System.Drawing.Point(37, 198)
        Me.ResButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ResButton.Name = "ResButton"
        Me.ResButton.Size = New System.Drawing.Size(140, 75)
        Me.ResButton.TabIndex = 1
        Me.ResButton.UseVisualStyleBackColor = True
        '
        'CheckInButton
        '
        Me.CheckInButton.BackgroundImage = Global.HotelSystem.My.Resources.Resources.CHEKiNnew
        Me.CheckInButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CheckInButton.Location = New System.Drawing.Point(37, 281)
        Me.CheckInButton.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckInButton.Name = "CheckInButton"
        Me.CheckInButton.Size = New System.Drawing.Size(140, 75)
        Me.CheckInButton.TabIndex = 2
        Me.CheckInButton.UseVisualStyleBackColor = True
        '
        'CheckOutButton
        '
        Me.CheckOutButton.BackgroundImage = Global.HotelSystem.My.Resources.Resources.CHKoUTnew
        Me.CheckOutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CheckOutButton.Location = New System.Drawing.Point(37, 364)
        Me.CheckOutButton.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckOutButton.Name = "CheckOutButton"
        Me.CheckOutButton.Size = New System.Drawing.Size(140, 75)
        Me.CheckOutButton.TabIndex = 3
        Me.CheckOutButton.UseVisualStyleBackColor = True
        '
        'MaintenanceButton
        '
        Me.MaintenanceButton.BackgroundImage = Global.HotelSystem.My.Resources.Resources.MAIN111
        Me.MaintenanceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MaintenanceButton.Location = New System.Drawing.Point(37, 446)
        Me.MaintenanceButton.Margin = New System.Windows.Forms.Padding(4)
        Me.MaintenanceButton.Name = "MaintenanceButton"
        Me.MaintenanceButton.Size = New System.Drawing.Size(140, 75)
        Me.MaintenanceButton.TabIndex = 4
        Me.MaintenanceButton.UseVisualStyleBackColor = True
        '
        'EmployeeButton
        '
        Me.EmployeeButton.BackgroundImage = Global.HotelSystem.My.Resources.Resources.EMPLYbTN
        Me.EmployeeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.EmployeeButton.Location = New System.Drawing.Point(37, 527)
        Me.EmployeeButton.Margin = New System.Windows.Forms.Padding(4)
        Me.EmployeeButton.Name = "EmployeeButton"
        Me.EmployeeButton.Size = New System.Drawing.Size(140, 75)
        Me.EmployeeButton.TabIndex = 5
        Me.EmployeeButton.UseVisualStyleBackColor = True
        '
        'LogoutButton
        '
        Me.LogoutButton.BackgroundImage = Global.HotelSystem.My.Resources.Resources._EXIT
        Me.LogoutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.LogoutButton.Location = New System.Drawing.Point(869, 594)
        Me.LogoutButton.Margin = New System.Windows.Forms.Padding(4)
        Me.LogoutButton.Name = "LogoutButton"
        Me.LogoutButton.Size = New System.Drawing.Size(140, 75)
        Me.LogoutButton.TabIndex = 6
        Me.LogoutButton.UseVisualStyleBackColor = True
        '
        'HomePanel
        '
        Me.HomePanel.Controls.Add(Me.RefreshHomeInfo)
        Me.HomePanel.Controls.Add(Me.HomeTablePanel)
        Me.HomePanel.Location = New System.Drawing.Point(217, 116)
        Me.HomePanel.Margin = New System.Windows.Forms.Padding(4)
        Me.HomePanel.Name = "HomePanel"
        Me.HomePanel.Size = New System.Drawing.Size(771, 462)
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
        Me.HomeTablePanel.Controls.Add(Me.Label4, 0, 4)
        Me.HomeTablePanel.Controls.Add(Me.Label3, 0, 3)
        Me.HomeTablePanel.Controls.Add(Me.Label2, 0, 2)
        Me.HomeTablePanel.Controls.Add(Me.Label1, 0, 1)
        Me.HomeTablePanel.Controls.Add(Me.Label7, 0, 0)
        Me.HomeTablePanel.Controls.Add(Me.DateLabel, 1, 0)
        Me.HomeTablePanel.Controls.Add(Me.NumChkInLabel, 1, 1)
        Me.HomeTablePanel.Controls.Add(Me.NumChkOutLabel, 1, 2)
        Me.HomeTablePanel.Controls.Add(Me.RoomRateLabel, 1, 3)
        Me.HomeTablePanel.Controls.Add(Me.CapacityLabel, 1, 4)
        Me.HomeTablePanel.Location = New System.Drawing.Point(73, 82)
        Me.HomeTablePanel.Margin = New System.Windows.Forms.Padding(4)
        Me.HomeTablePanel.Name = "HomeTablePanel"
        Me.HomeTablePanel.RowCount = 5
        Me.HomeTablePanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.HomeTablePanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.HomeTablePanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.HomeTablePanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.HomeTablePanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.HomeTablePanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.HomeTablePanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.HomeTablePanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.HomeTablePanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.HomeTablePanel.Size = New System.Drawing.Size(615, 201)
        Me.HomeTablePanel.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 160)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Capacity"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 120)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Room Rate"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 80)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Check-outs Remaining"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 40)
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
        'DateLabel
        '
        Me.DateLabel.AutoSize = True
        Me.DateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateLabel.Location = New System.Drawing.Point(311, 0)
        Me.DateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DateLabel.Name = "DateLabel"
        Me.DateLabel.Size = New System.Drawing.Size(40, 17)
        Me.DateLabel.TabIndex = 8
        Me.DateLabel.Text = "GET"
        '
        'NumChkInLabel
        '
        Me.NumChkInLabel.AutoSize = True
        Me.NumChkInLabel.Location = New System.Drawing.Point(311, 40)
        Me.NumChkInLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.NumChkInLabel.Name = "NumChkInLabel"
        Me.NumChkInLabel.Size = New System.Drawing.Size(37, 17)
        Me.NumChkInLabel.TabIndex = 9
        Me.NumChkInLabel.Text = "GET"
        '
        'NumChkOutLabel
        '
        Me.NumChkOutLabel.AutoSize = True
        Me.NumChkOutLabel.Location = New System.Drawing.Point(311, 80)
        Me.NumChkOutLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.NumChkOutLabel.Name = "NumChkOutLabel"
        Me.NumChkOutLabel.Size = New System.Drawing.Size(37, 17)
        Me.NumChkOutLabel.TabIndex = 10
        Me.NumChkOutLabel.Text = "GET"
        '
        'RoomRateLabel
        '
        Me.RoomRateLabel.AutoSize = True
        Me.RoomRateLabel.Location = New System.Drawing.Point(311, 120)
        Me.RoomRateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.RoomRateLabel.Name = "RoomRateLabel"
        Me.RoomRateLabel.Size = New System.Drawing.Size(37, 17)
        Me.RoomRateLabel.TabIndex = 11
        Me.RoomRateLabel.Text = "GET"
        '
        'CapacityLabel
        '
        Me.CapacityLabel.AutoSize = True
        Me.CapacityLabel.Location = New System.Drawing.Point(311, 160)
        Me.CapacityLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CapacityLabel.Name = "CapacityLabel"
        Me.CapacityLabel.Size = New System.Drawing.Size(37, 17)
        Me.CapacityLabel.TabIndex = 12
        Me.CapacityLabel.Text = "GET"
        '
        'ReservationPanel
        '
        Me.ReservationPanel.Controls.Add(Me.DataGridCustoTbl)
        Me.ReservationPanel.Location = New System.Drawing.Point(219, 116)
        Me.ReservationPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.ReservationPanel.Name = "ReservationPanel"
        Me.ReservationPanel.Size = New System.Drawing.Size(771, 462)
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
        Me.DataGridCustoTbl.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
        Me.ChkInPanel.Controls.Add(Me.btnChkInDGV)
        Me.ChkInPanel.Controls.Add(Me.CUSTOMERDataGridView1)
        Me.ChkInPanel.Location = New System.Drawing.Point(216, 117)
        Me.ChkInPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkInPanel.Name = "ChkInPanel"
        Me.ChkInPanel.Size = New System.Drawing.Size(773, 466)
        Me.ChkInPanel.TabIndex = 0
        '
        'btnChkInDGV
        '
        Me.btnChkInDGV.Location = New System.Drawing.Point(0, 391)
        Me.btnChkInDGV.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnChkInDGV.Name = "btnChkInDGV"
        Me.btnChkInDGV.Size = New System.Drawing.Size(768, 39)
        Me.btnChkInDGV.TabIndex = 17
        Me.btnChkInDGV.Text = "Add New Entry"
        Me.btnChkInDGV.UseVisualStyleBackColor = True
        '
        'CUSTOMERDataGridView1
        '
        Me.CUSTOMERDataGridView1.AllowUserToOrderColumns = True
        Me.CUSTOMERDataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CUSTOMERDataGridView1.AutoGenerateColumns = False
        Me.CUSTOMERDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CUSTOMERDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn22, Me.DataGridViewCheckBoxColumn2})
        Me.CUSTOMERDataGridView1.DataSource = Me.CUSTOMERBindingSource2
        Me.CUSTOMERDataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.CUSTOMERDataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.CUSTOMERDataGridView1.Name = "CUSTOMERDataGridView1"
        Me.CUSTOMERDataGridView1.Size = New System.Drawing.Size(768, 386)
        Me.CUSTOMERDataGridView1.TabIndex = 1
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "LAST_NAME"
        Me.DataGridViewTextBoxColumn13.HeaderText = "LAST_NAME"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "CUST_ID#"
        Me.DataGridViewTextBoxColumn14.HeaderText = "CUST_ID#"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "DAYS"
        Me.DataGridViewTextBoxColumn15.HeaderText = "DAYS"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "CHECKIN"
        Me.DataGridViewTextBoxColumn17.HeaderText = "CHECKIN"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "TIME_IN"
        Me.DataGridViewTextBoxColumn19.HeaderText = "TIME_IN"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "TOTAL_COST"
        Me.DataGridViewTextBoxColumn22.HeaderText = "TOTAL_COST"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "PAID"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "PAID"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        '
        'CUSTOMERBindingSource2
        '
        Me.CUSTOMERBindingSource2.DataMember = "CUSTOMER"
        Me.CUSTOMERBindingSource2.DataSource = Me.HOTEL_DBDataSet
        '
        'ChkOutPanel
        '
        Me.ChkOutPanel.Controls.Add(Me.btnChkOutDGV)
        Me.ChkOutPanel.Controls.Add(Me.CUSTOMERDataGridView)
        Me.ChkOutPanel.Location = New System.Drawing.Point(216, 114)
        Me.ChkOutPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkOutPanel.Name = "ChkOutPanel"
        Me.ChkOutPanel.Size = New System.Drawing.Size(793, 473)
        Me.ChkOutPanel.TabIndex = 0
        Me.ChkOutPanel.Visible = False
        '
        'btnChkOutDGV
        '
        Me.btnChkOutDGV.Location = New System.Drawing.Point(3, 412)
        Me.btnChkOutDGV.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnChkOutDGV.Name = "btnChkOutDGV"
        Me.btnChkOutDGV.Size = New System.Drawing.Size(768, 39)
        Me.btnChkOutDGV.TabIndex = 17
        Me.btnChkOutDGV.Text = "Add New Entry"
        Me.btnChkOutDGV.UseVisualStyleBackColor = True
        '
        'CUSTOMERDataGridView
        '
        Me.CUSTOMERDataGridView.AllowUserToOrderColumns = True
        Me.CUSTOMERDataGridView.AutoGenerateColumns = False
        Me.CUSTOMERDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CUSTOMERDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn9, Me.DataGridViewCheckBoxColumn1})
        Me.CUSTOMERDataGridView.DataSource = Me.CUSTOMERBindingSource1
        Me.CUSTOMERDataGridView.Location = New System.Drawing.Point(4, 4)
        Me.CUSTOMERDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.CUSTOMERDataGridView.Name = "CUSTOMERDataGridView"
        Me.CUSTOMERDataGridView.Size = New System.Drawing.Size(769, 404)
        Me.CUSTOMERDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "LAST_NAME"
        Me.DataGridViewTextBoxColumn2.HeaderText = "LAST_NAME"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CUST_ID#"
        Me.DataGridViewTextBoxColumn3.HeaderText = "CUST_ID#"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "DAYS"
        Me.DataGridViewTextBoxColumn4.HeaderText = "DAYS"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "CHECKOUT"
        Me.DataGridViewTextBoxColumn7.HeaderText = "CHECKOUT"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "TIME_OUT"
        Me.DataGridViewTextBoxColumn9.HeaderText = "TIME_OUT"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "PAID"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "PAID"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'CUSTOMERBindingSource1
        '
        Me.CUSTOMERBindingSource1.DataMember = "CUSTOMER"
        Me.CUSTOMERBindingSource1.DataSource = Me.HOTELDBDataSetBindingSource
        '
        'MaintenancePanel
        '
        Me.MaintenancePanel.Controls.Add(Me.btnRoomsDGV)
        Me.MaintenancePanel.Controls.Add(Me.DataGridMaintenanceTbl)
        Me.MaintenancePanel.Location = New System.Drawing.Point(217, 118)
        Me.MaintenancePanel.Margin = New System.Windows.Forms.Padding(4)
        Me.MaintenancePanel.Name = "MaintenancePanel"
        Me.MaintenancePanel.Size = New System.Drawing.Size(772, 460)
        Me.MaintenancePanel.TabIndex = 0
        Me.MaintenancePanel.Visible = False
        '
        'btnRoomsDGV
        '
        Me.btnRoomsDGV.Location = New System.Drawing.Point(3, 407)
        Me.btnRoomsDGV.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRoomsDGV.Name = "btnRoomsDGV"
        Me.btnRoomsDGV.Size = New System.Drawing.Size(768, 39)
        Me.btnRoomsDGV.TabIndex = 17
        Me.btnRoomsDGV.Text = "Add New Entry"
        Me.btnRoomsDGV.UseVisualStyleBackColor = True
        '
        'DataGridMaintenanceTbl
        '
        Me.DataGridMaintenanceTbl.AutoGenerateColumns = False
        Me.DataGridMaintenanceTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridMaintenanceTbl.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ROOMDataGridViewTextBoxColumn1, Me.TYPEDataGridViewTextBoxColumn1, Me.COSTDataGridViewTextBoxColumn1, Me.DATEOCCUPIEDDataGridViewTextBoxColumn1, Me.TIMEOCCUPIEDDataGridViewTextBoxColumn1, Me.OCCUPANTIDDataGridViewTextBoxColumn1})
        Me.DataGridMaintenanceTbl.DataSource = Me.ROOMSBindingSource2
        Me.DataGridMaintenanceTbl.Location = New System.Drawing.Point(0, -1)
        Me.DataGridMaintenanceTbl.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridMaintenanceTbl.Name = "DataGridMaintenanceTbl"
        Me.DataGridMaintenanceTbl.RowTemplate.Height = 24
        Me.DataGridMaintenanceTbl.Size = New System.Drawing.Size(771, 404)
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
        'ROOMSBindingSource2
        '
        Me.ROOMSBindingSource2.DataMember = "ROOMS"
        Me.ROOMSBindingSource2.DataSource = Me.HOTELDBDataSetBindingSource
        '
        'EmployeePanel
        '
        Me.EmployeePanel.Controls.Add(Me.btnEmplyDGV)
        Me.EmployeePanel.Controls.Add(Me.DataGridEmplyTbl)
        Me.EmployeePanel.Location = New System.Drawing.Point(217, 114)
        Me.EmployeePanel.Margin = New System.Windows.Forms.Padding(4)
        Me.EmployeePanel.Name = "EmployeePanel"
        Me.EmployeePanel.Size = New System.Drawing.Size(772, 466)
        Me.EmployeePanel.TabIndex = 0
        '
        'btnEmplyDGV
        '
        Me.btnEmplyDGV.Location = New System.Drawing.Point(3, 415)
        Me.btnEmplyDGV.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEmplyDGV.Name = "btnEmplyDGV"
        Me.btnEmplyDGV.Size = New System.Drawing.Size(768, 39)
        Me.btnEmplyDGV.TabIndex = 16
        Me.btnEmplyDGV.Text = "Add New Entry"
        Me.btnEmplyDGV.UseVisualStyleBackColor = True
        '
        'DataGridEmplyTbl
        '
        Me.DataGridEmplyTbl.AutoGenerateColumns = False
        Me.DataGridEmplyTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridEmplyTbl.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FIRSTNAMEDataGridViewTextBoxColumn, Me.LASTNAMEDataGridViewTextBoxColumn, Me.SSNDataGridViewTextBoxColumn, Me.PHONEDataGridViewTextBoxColumn, Me.TITLEDataGridViewTextBoxColumn, Me.DEPTDataGridViewTextBoxColumn, Me.PAYHRLYDataGridViewTextBoxColumn})
        Me.DataGridEmplyTbl.DataSource = Me.EMPLOYEEBindingSource3
        Me.DataGridEmplyTbl.Location = New System.Drawing.Point(0, 1)
        Me.DataGridEmplyTbl.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridEmplyTbl.Name = "DataGridEmplyTbl"
        Me.DataGridEmplyTbl.RowTemplate.Height = 24
        Me.DataGridEmplyTbl.Size = New System.Drawing.Size(771, 410)
        Me.DataGridEmplyTbl.TabIndex = 0
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
        'EMPLOYEEBindingSource3
        '
        Me.EMPLOYEEBindingSource3.DataMember = "EMPLOYEE"
        Me.EMPLOYEEBindingSource3.DataSource = Me.HOTEL_DBDataSet
        '
        'EMPLOYEEBindingSource2
        '
        Me.EMPLOYEEBindingSource2.DataMember = "EMPLOYEE"
        Me.EMPLOYEEBindingSource2.DataSource = Me.HOTELDBDataSetBindingSource
        '
        'EMPLOYEEBindingSource
        '
        Me.EMPLOYEEBindingSource.DataMember = "EMPLOYEE"
        Me.EMPLOYEEBindingSource.DataSource = Me.HOTELDBDataSetBindingSource
        '
        'EMPLOYEEBindingSource1
        '
        Me.EMPLOYEEBindingSource1.DataMember = "EMPLOYEE"
        Me.EMPLOYEEBindingSource1.DataSource = Me.HOTELDBDataSetBindingSource
        '
        'ROOMSBindingSource1
        '
        Me.ROOMSBindingSource1.DataMember = "ROOMS"
        Me.ROOMSBindingSource1.DataSource = Me.HOTELDBDataSetBindingSource
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
        'EMPLOYEETableAdapter
        '
        Me.EMPLOYEETableAdapter.ClearBeforeFill = True
        '
        'CUSTOMERTableAdapter
        '
        Me.CUSTOMERTableAdapter.ClearBeforeFill = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = Global.HotelSystem.My.Resources.Resources.LogoNEW
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(3, 6)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(303, 66)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Image = Global.HotelSystem.My.Resources.Resources.ximg
        Me.PictureBox2.Location = New System.Drawing.Point(939, 6)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(71, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'HomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1017, 679)
        Me.Controls.Add(Me.MaintenancePanel)
        Me.Controls.Add(Me.HomePanel)
        Me.Controls.Add(Me.ChkOutPanel)
        Me.Controls.Add(Me.ChkInPanel)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.EmployeePanel)
        Me.Controls.Add(Me.ReservationPanel)
        Me.Controls.Add(Me.LogoutButton)
        Me.Controls.Add(Me.EmployeeButton)
        Me.Controls.Add(Me.MaintenanceButton)
        Me.Controls.Add(Me.CheckOutButton)
        Me.Controls.Add(Me.CheckInButton)
        Me.Controls.Add(Me.ResButton)
        Me.Controls.Add(Me.HomeButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
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
        CType(Me.CUSTOMERDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CUSTOMERBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ChkOutPanel.ResumeLayout(False)
        CType(Me.CUSTOMERDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CUSTOMERBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MaintenancePanel.ResumeLayout(False)
        CType(Me.DataGridMaintenanceTbl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ROOMSBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EmployeePanel.ResumeLayout(False)
        CType(Me.DataGridEmplyTbl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPLOYEEBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPLOYEEBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPLOYEEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPLOYEEBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ROOMSBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ROOMSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DateLabel As Label
    Friend WithEvents RefreshHomeInfo As Button
    Friend WithEvents NumChkInLabel As Label
    Friend WithEvents NumChkOutLabel As Label
    Friend WithEvents RoomRateLabel As Label
    Friend WithEvents CapacityLabel As Label
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
    Friend WithEvents EMPLOYEEBindingSource1 As BindingSource
    Friend WithEvents EMPLOYEEBindingSource2 As BindingSource
    Friend WithEvents FIRSTNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LASTNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SSNDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PHONEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TITLEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DEPTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PAYHRLYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CUSTOMERBindingSource1 As BindingSource
    Friend WithEvents CUSTOMERDataGridView As DataGridView
    Friend WithEvents CUSTOMERBindingSource2 As BindingSource
    Friend WithEvents CUSTOMERDataGridView1 As DataGridView
    Friend WithEvents EMPLOYEEBindingSource3 As BindingSource
    Friend WithEvents btnEmplyDGV As Button
    Friend WithEvents btnChkInDGV As Button
    Friend WithEvents btnChkOutDGV As Button
    Friend WithEvents btnRoomsDGV As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
End Class
