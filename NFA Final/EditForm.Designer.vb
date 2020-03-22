<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditForm
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
        Me.pnlSukatan = New System.Windows.Forms.Panel()
        Me.txtboTown = New System.Windows.Forms.TextBox()
        Me.lblProvince = New System.Windows.Forms.Label()
        Me.lblTown = New System.Windows.Forms.Label()
        Me.lblBrgy = New System.Windows.Forms.Label()
        Me.cboProvince = New System.Windows.Forms.ComboBox()
        Me.txtboBarangay = New System.Windows.Forms.TextBox()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.lblSalaryGrade = New System.Windows.Forms.Label()
        Me.cboSGrade = New System.Windows.Forms.ComboBox()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.lblPesoSign = New System.Windows.Forms.Label()
        Me.lblRate = New System.Windows.Forms.Label()
        Me.txtboWH = New System.Windows.Forms.TextBox()
        Me.lblTotalSalary = New System.Windows.Forms.Label()
        Me.lblbWorkHours = New System.Windows.Forms.Label()
        Me.txtboTS = New System.Windows.Forms.TextBox()
        Me.txtboHL = New System.Windows.Forms.TextBox()
        Me.lblHrsLeave = New System.Windows.Forms.Label()
        Me.txtboHA = New System.Windows.Forms.TextBox()
        Me.lblHrsAbsent = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtboLName = New System.Windows.Forms.TextBox()
        Me.txtboMName = New System.Windows.Forms.TextBox()
        Me.txtboFName = New System.Windows.Forms.TextBox()
        Me.lblMName = New System.Windows.Forms.Label()
        Me.lblFName = New System.Windows.Forms.Label()
        Me.lblLName = New System.Windows.Forms.Label()
        Me.txtboID = New System.Windows.Forms.TextBox()
        Me.lblIDnumber = New System.Windows.Forms.Label()
        Me.txtboPS = New System.Windows.Forms.TextBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblPW = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'pnlSukatan
        '
        Me.pnlSukatan.BackColor = System.Drawing.SystemColors.Control
        Me.pnlSukatan.Location = New System.Drawing.Point(0, 1)
        Me.pnlSukatan.Name = "pnlSukatan"
        Me.pnlSukatan.Size = New System.Drawing.Size(254, 16)
        Me.pnlSukatan.TabIndex = 86
        '
        'txtboTown
        '
        Me.txtboTown.BackColor = System.Drawing.Color.Snow
        Me.txtboTown.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboTown.Location = New System.Drawing.Point(312, 33)
        Me.txtboTown.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtboTown.MaxLength = 20
        Me.txtboTown.Name = "txtboTown"
        Me.txtboTown.Size = New System.Drawing.Size(46, 40)
        Me.txtboTown.TabIndex = 5
        '
        'lblProvince
        '
        Me.lblProvince.AutoSize = True
        Me.lblProvince.BackColor = System.Drawing.Color.SeaShell
        Me.lblProvince.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProvince.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProvince.ForeColor = System.Drawing.Color.Black
        Me.lblProvince.Location = New System.Drawing.Point(1018, 309)
        Me.lblProvince.Margin = New System.Windows.Forms.Padding(27, 25, 27, 25)
        Me.lblProvince.Name = "lblProvince"
        Me.lblProvince.Size = New System.Drawing.Size(85, 26)
        Me.lblProvince.TabIndex = 97
        Me.lblProvince.Text = "Province"
        '
        'lblTown
        '
        Me.lblTown.AutoSize = True
        Me.lblTown.BackColor = System.Drawing.Color.SeaShell
        Me.lblTown.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTown.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTown.ForeColor = System.Drawing.Color.Black
        Me.lblTown.Location = New System.Drawing.Point(569, 322)
        Me.lblTown.Margin = New System.Windows.Forms.Padding(27, 25, 27, 25)
        Me.lblTown.Name = "lblTown"
        Me.lblTown.Size = New System.Drawing.Size(94, 26)
        Me.lblTown.TabIndex = 94
        Me.lblTown.Text = "Town/City"
        '
        'lblBrgy
        '
        Me.lblBrgy.AutoSize = True
        Me.lblBrgy.BackColor = System.Drawing.Color.SeaShell
        Me.lblBrgy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBrgy.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBrgy.ForeColor = System.Drawing.Color.Black
        Me.lblBrgy.Location = New System.Drawing.Point(312, 356)
        Me.lblBrgy.Margin = New System.Windows.Forms.Padding(27, 25, 27, 25)
        Me.lblBrgy.Name = "lblBrgy"
        Me.lblBrgy.Size = New System.Drawing.Size(92, 26)
        Me.lblBrgy.TabIndex = 92
        Me.lblBrgy.Text = "Barangay"
        '
        'cboProvince
        '
        Me.cboProvince.AutoCompleteCustomSource.AddRange(New String() {"Abra", "Agusan del Norte", "Agusan del Sur", "Aklan", "Albay", "Antique", "Apayao", "Aurora", "Basilan", "Bataan", "Batanes", "Batangas", "Benguet", "Biliran", "Bohol", "Bukidnon", "Bulacan", "Cagayan", "Camarines Norte", "Camarines Sur", "Camiguin", "Capiz", "Catanduanes", "Cavite", "Cebu", "Compostela Valley", "Cotabato", "Davao del Norte", "Davao del Sur", "Davao Occidental", "Davao Oriental", "Dinagat Islands", "Eastern Samar", "Guimaras", "Ifugao", "Ilocos Norte", "Ilocos Sur", "Iloilo", "Isabela", "Kalinga", "La Union", "Laguna", "Lanao del Norte", "Lanao del Sur", "Leyte", "Maguindanao", "Marinduque", "Masbate", "Misamis Occidental", "Misamis Oriental", "Mountain Province", "Negros Occidental", "Negros Oriental", "Northern Samar", "Nueva Ecija", "Nueva Vizcaya", "Occidental Mindoro", "Oriental Mindoro", "Palawan", "Pampanga", "Pangasinan", "Quezon", "Quirino", "Rizal", "Romblon", "Samar", "Sarangani", "Siquijor", "Sorsogon", "South Cotabato", "Southern Leyte", "Sultan Kudarat", "Sulu", "Surigao del Norte", "Surigao del Sur", "Tarlac", "Tawi-Tawi", "Zambales", "Zamboanga del Norte", "Zamboanga del Sur", "Zamboanga Sibugay"})
        Me.cboProvince.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboProvince.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cboProvince.BackColor = System.Drawing.Color.Snow
        Me.cboProvince.DropDownWidth = 30
        Me.cboProvince.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboProvince.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProvince.IntegralHeight = False
        Me.cboProvince.Items.AddRange(New Object() {"Abra", "Agusan del Norte", "Agusan del Sur", "Aklan", "Albay", "Antique", "Apayao", "Aurora", "Basilan", "Bataan", "Batanes", "Batangas", "Benguet", "Biliran", "Bohol", "Bukidnon", "Bulacan", "Cagayan", "Camarines Norte", "Camarines Sur", "Camiguin", "Capiz", "Catanduanes", "Cavite", "Cebu", "Compostela Valley", "Cotabato", "Davao del Norte", "Davao del Sur", "Davao Occidental", "Davao Oriental", "Dinagat Islands", "Eastern Samar", "Guimaras", "Ifugao", "Ilocos Norte", "Ilocos Sur", "Iloilo", "Isabela", "Kalinga", "La Union", "Laguna", "Lanao del Norte", "Lanao del Sur", "Leyte", "Maguindanao", "Marinduque", "Masbate", "Misamis Occidental", "Misamis Oriental", "Mountain Province", "Negros Occidental", "Negros Oriental", "Northern Samar", "Nueva Ecija", "Nueva Vizcaya", "Occidental Mindoro", "Oriental Mindoro", "Palawan", "Pampanga", "Pangasinan", "Quezon", "Quirino", "Rizal", "Romblon", "Samar", "Sarangani", "Siquijor", "Sorsogon", "South Cotabato", "Southern Leyte", "Sultan Kudarat", "Sulu", "Surigao del Norte", "Surigao del Sur", "Tarlac", "Tawi-Tawi", "Zambales", "Zamboanga del Norte", "Zamboanga del Sur", "Zamboanga Sibugay"})
        Me.cboProvince.Location = New System.Drawing.Point(377, 33)
        Me.cboProvince.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.cboProvince.MaxLength = 20
        Me.cboProvince.Name = "cboProvince"
        Me.cboProvince.Size = New System.Drawing.Size(50, 40)
        Me.cboProvince.TabIndex = 6
        '
        'txtboBarangay
        '
        Me.txtboBarangay.BackColor = System.Drawing.Color.Snow
        Me.txtboBarangay.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboBarangay.Location = New System.Drawing.Point(273, 33)
        Me.txtboBarangay.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtboBarangay.MaxLength = 20
        Me.txtboBarangay.Name = "txtboBarangay"
        Me.txtboBarangay.Size = New System.Drawing.Size(35, 40)
        Me.txtboBarangay.TabIndex = 4
        '
        'txtSalary
        '
        Me.txtSalary.BackColor = System.Drawing.Color.Snow
        Me.txtSalary.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalary.Location = New System.Drawing.Point(518, 33)
        Me.txtSalary.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.ReadOnly = True
        Me.txtSalary.Size = New System.Drawing.Size(122, 40)
        Me.txtSalary.TabIndex = 8
        '
        'lblSalaryGrade
        '
        Me.lblSalaryGrade.AutoSize = True
        Me.lblSalaryGrade.BackColor = System.Drawing.Color.SeaShell
        Me.lblSalaryGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSalaryGrade.Font = New System.Drawing.Font("Candara", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalaryGrade.ForeColor = System.Drawing.Color.Black
        Me.lblSalaryGrade.Location = New System.Drawing.Point(151, 256)
        Me.lblSalaryGrade.Margin = New System.Windows.Forms.Padding(27, 25, 27, 25)
        Me.lblSalaryGrade.Name = "lblSalaryGrade"
        Me.lblSalaryGrade.Size = New System.Drawing.Size(157, 31)
        Me.lblSalaryGrade.TabIndex = 98
        Me.lblSalaryGrade.Text = "Sallary Grade:"
        '
        'cboSGrade
        '
        Me.cboSGrade.BackColor = System.Drawing.Color.Snow
        Me.cboSGrade.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboSGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSGrade.DropDownWidth = 10
        Me.cboSGrade.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSGrade.IntegralHeight = False
        Me.cboSGrade.ItemHeight = 32
        Me.cboSGrade.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33"})
        Me.cboSGrade.Location = New System.Drawing.Point(443, 33)
        Me.cboSGrade.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.cboSGrade.MaxDropDownItems = 3
        Me.cboSGrade.Name = "cboSGrade"
        Me.cboSGrade.Size = New System.Drawing.Size(59, 40)
        Me.cboSGrade.TabIndex = 7
        '
        'txtRate
        '
        Me.txtRate.BackColor = System.Drawing.Color.Snow
        Me.txtRate.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRate.Location = New System.Drawing.Point(518, 87)
        Me.txtRate.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(83, 40)
        Me.txtRate.TabIndex = 9
        '
        'lblPesoSign
        '
        Me.lblPesoSign.AutoSize = True
        Me.lblPesoSign.BackColor = System.Drawing.Color.SeaShell
        Me.lblPesoSign.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPesoSign.Font = New System.Drawing.Font("Candara", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPesoSign.ForeColor = System.Drawing.Color.Black
        Me.lblPesoSign.Location = New System.Drawing.Point(540, 233)
        Me.lblPesoSign.Margin = New System.Windows.Forms.Padding(27, 25, 27, 25)
        Me.lblPesoSign.Name = "lblPesoSign"
        Me.lblPesoSign.Size = New System.Drawing.Size(40, 31)
        Me.lblPesoSign.TabIndex = 112
        Me.lblPesoSign.Text = "=P"
        '
        'lblRate
        '
        Me.lblRate.AutoSize = True
        Me.lblRate.BackColor = System.Drawing.Color.SeaShell
        Me.lblRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRate.Font = New System.Drawing.Font("Candara", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRate.ForeColor = System.Drawing.Color.Black
        Me.lblRate.Location = New System.Drawing.Point(984, 256)
        Me.lblRate.Margin = New System.Windows.Forms.Padding(27, 25, 27, 25)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(99, 31)
        Me.lblRate.TabIndex = 104
        Me.lblRate.Text = "Rate/Hr:"
        '
        'txtboWH
        '
        Me.txtboWH.BackColor = System.Drawing.Color.Snow
        Me.txtboWH.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboWH.Location = New System.Drawing.Point(652, 33)
        Me.txtboWH.Margin = New System.Windows.Forms.Padding(4)
        Me.txtboWH.MaxLength = 3
        Me.txtboWH.Name = "txtboWH"
        Me.txtboWH.Size = New System.Drawing.Size(103, 40)
        Me.txtboWH.TabIndex = 10
        '
        'lblTotalSalary
        '
        Me.lblTotalSalary.AutoSize = True
        Me.lblTotalSalary.BackColor = System.Drawing.Color.SeaShell
        Me.lblTotalSalary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalSalary.Font = New System.Drawing.Font("Candara", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalSalary.ForeColor = System.Drawing.Color.Black
        Me.lblTotalSalary.Location = New System.Drawing.Point(1174, 33)
        Me.lblTotalSalary.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalSalary.Name = "lblTotalSalary"
        Me.lblTotalSalary.Size = New System.Drawing.Size(142, 31)
        Me.lblTotalSalary.TabIndex = 100
        Me.lblTotalSalary.Text = "Total Salary:"
        '
        'lblbWorkHours
        '
        Me.lblbWorkHours.AutoSize = True
        Me.lblbWorkHours.BackColor = System.Drawing.Color.SeaShell
        Me.lblbWorkHours.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblbWorkHours.Font = New System.Drawing.Font("Candara", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbWorkHours.ForeColor = System.Drawing.Color.Black
        Me.lblbWorkHours.Location = New System.Drawing.Point(166, 140)
        Me.lblbWorkHours.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblbWorkHours.Name = "lblbWorkHours"
        Me.lblbWorkHours.Size = New System.Drawing.Size(142, 31)
        Me.lblbWorkHours.TabIndex = 91
        Me.lblbWorkHours.Text = "Work Hours:"
        '
        'txtboTS
        '
        Me.txtboTS.BackColor = System.Drawing.Color.Snow
        Me.txtboTS.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboTS.Location = New System.Drawing.Point(785, 81)
        Me.txtboTS.Margin = New System.Windows.Forms.Padding(4)
        Me.txtboTS.Name = "txtboTS"
        Me.txtboTS.ReadOnly = True
        Me.txtboTS.Size = New System.Drawing.Size(131, 40)
        Me.txtboTS.TabIndex = 13
        '
        'txtboHL
        '
        Me.txtboHL.BackColor = System.Drawing.Color.Snow
        Me.txtboHL.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboHL.Location = New System.Drawing.Point(649, 87)
        Me.txtboHL.Margin = New System.Windows.Forms.Padding(4)
        Me.txtboHL.MaxLength = 3
        Me.txtboHL.Name = "txtboHL"
        Me.txtboHL.Size = New System.Drawing.Size(106, 40)
        Me.txtboHL.TabIndex = 11
        '
        'lblHrsLeave
        '
        Me.lblHrsLeave.AutoSize = True
        Me.lblHrsLeave.BackColor = System.Drawing.Color.SeaShell
        Me.lblHrsLeave.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHrsLeave.Font = New System.Drawing.Font("Candara", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHrsLeave.ForeColor = System.Drawing.Color.Black
        Me.lblHrsLeave.Location = New System.Drawing.Point(417, 200)
        Me.lblHrsLeave.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHrsLeave.Name = "lblHrsLeave"
        Me.lblHrsLeave.Size = New System.Drawing.Size(147, 31)
        Me.lblHrsLeave.TabIndex = 99
        Me.lblHrsLeave.Text = "Hours Leave:"
        '
        'txtboHA
        '
        Me.txtboHA.BackColor = System.Drawing.Color.Snow
        Me.txtboHA.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboHA.Location = New System.Drawing.Point(786, 33)
        Me.txtboHA.Margin = New System.Windows.Forms.Padding(4)
        Me.txtboHA.MaxLength = 3
        Me.txtboHA.Name = "txtboHA"
        Me.txtboHA.Size = New System.Drawing.Size(130, 40)
        Me.txtboHA.TabIndex = 12
        '
        'lblHrsAbsent
        '
        Me.lblHrsAbsent.AutoSize = True
        Me.lblHrsAbsent.BackColor = System.Drawing.Color.SeaShell
        Me.lblHrsAbsent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHrsAbsent.Font = New System.Drawing.Font("Candara", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHrsAbsent.ForeColor = System.Drawing.Color.Black
        Me.lblHrsAbsent.Location = New System.Drawing.Point(553, 134)
        Me.lblHrsAbsent.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHrsAbsent.Name = "lblHrsAbsent"
        Me.lblHrsAbsent.Size = New System.Drawing.Size(159, 31)
        Me.lblHrsAbsent.TabIndex = 95
        Me.lblHrsAbsent.Text = "Hours Absent:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.SeaShell
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblName.Font = New System.Drawing.Font("Candara", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.Black
        Me.lblName.Location = New System.Drawing.Point(76, 273)
        Me.lblName.Margin = New System.Windows.Forms.Padding(27, 25, 27, 25)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(81, 31)
        Me.lblName.TabIndex = 109
        Me.lblName.Text = "Name:"
        '
        'txtboLName
        '
        Me.txtboLName.BackColor = System.Drawing.Color.Snow
        Me.txtboLName.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboLName.Location = New System.Drawing.Point(168, 33)
        Me.txtboLName.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtboLName.MaxLength = 20
        Me.txtboLName.Name = "txtboLName"
        Me.txtboLName.Size = New System.Drawing.Size(34, 40)
        Me.txtboLName.TabIndex = 1
        '
        'txtboMName
        '
        Me.txtboMName.BackColor = System.Drawing.Color.Snow
        Me.txtboMName.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboMName.Location = New System.Drawing.Point(218, 33)
        Me.txtboMName.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtboMName.MaxLength = 20
        Me.txtboMName.Name = "txtboMName"
        Me.txtboMName.Size = New System.Drawing.Size(46, 40)
        Me.txtboMName.TabIndex = 3
        '
        'txtboFName
        '
        Me.txtboFName.BackColor = System.Drawing.Color.Snow
        Me.txtboFName.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboFName.Location = New System.Drawing.Point(111, 33)
        Me.txtboFName.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtboFName.MaxLength = 20
        Me.txtboFName.Name = "txtboFName"
        Me.txtboFName.Size = New System.Drawing.Size(41, 40)
        Me.txtboFName.TabIndex = 2
        '
        'lblMName
        '
        Me.lblMName.AutoSize = True
        Me.lblMName.BackColor = System.Drawing.Color.SeaShell
        Me.lblMName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMName.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMName.ForeColor = System.Drawing.Color.Black
        Me.lblMName.Location = New System.Drawing.Point(1215, 278)
        Me.lblMName.Margin = New System.Windows.Forms.Padding(27, 25, 27, 25)
        Me.lblMName.Name = "lblMName"
        Me.lblMName.Size = New System.Drawing.Size(119, 26)
        Me.lblMName.TabIndex = 115
        Me.lblMName.Text = "MiddleName"
        '
        'lblFName
        '
        Me.lblFName.AutoSize = True
        Me.lblFName.BackColor = System.Drawing.Color.SeaShell
        Me.lblFName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFName.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFName.ForeColor = System.Drawing.Color.Black
        Me.lblFName.Location = New System.Drawing.Point(796, 278)
        Me.lblFName.Margin = New System.Windows.Forms.Padding(27, 25, 27, 25)
        Me.lblFName.Name = "lblFName"
        Me.lblFName.Size = New System.Drawing.Size(97, 26)
        Me.lblFName.TabIndex = 113
        Me.lblFName.Text = "FirstName"
        '
        'lblLName
        '
        Me.lblLName.AutoSize = True
        Me.lblLName.BackColor = System.Drawing.Color.SeaShell
        Me.lblLName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLName.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLName.ForeColor = System.Drawing.Color.Black
        Me.lblLName.Location = New System.Drawing.Point(375, 278)
        Me.lblLName.Margin = New System.Windows.Forms.Padding(27, 25, 27, 25)
        Me.lblLName.Name = "lblLName"
        Me.lblLName.Size = New System.Drawing.Size(96, 26)
        Me.lblLName.TabIndex = 111
        Me.lblLName.Text = "LastName"
        '
        'txtboID
        '
        Me.txtboID.BackColor = System.Drawing.Color.Snow
        Me.txtboID.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboID.Location = New System.Drawing.Point(956, 367)
        Me.txtboID.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtboID.Name = "txtboID"
        Me.txtboID.ReadOnly = True
        Me.txtboID.Size = New System.Drawing.Size(196, 40)
        Me.txtboID.TabIndex = 105
        '
        'lblIDnumber
        '
        Me.lblIDnumber.AutoSize = True
        Me.lblIDnumber.BackColor = System.Drawing.Color.SeaShell
        Me.lblIDnumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIDnumber.Font = New System.Drawing.Font("Candara", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDnumber.ForeColor = System.Drawing.Color.Black
        Me.lblIDnumber.Location = New System.Drawing.Point(273, 202)
        Me.lblIDnumber.Margin = New System.Windows.Forms.Padding(27, 25, 27, 25)
        Me.lblIDnumber.Name = "lblIDnumber"
        Me.lblIDnumber.Size = New System.Drawing.Size(131, 31)
        Me.lblIDnumber.TabIndex = 106
        Me.lblIDnumber.Text = "ID Number:"
        '
        'txtboPS
        '
        Me.txtboPS.BackColor = System.Drawing.Color.Snow
        Me.txtboPS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtboPS.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboPS.Location = New System.Drawing.Point(36, 33)
        Me.txtboPS.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtboPS.MaxLength = 20
        Me.txtboPS.Name = "txtboPS"
        Me.txtboPS.Size = New System.Drawing.Size(59, 40)
        Me.txtboPS.TabIndex = 0
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 10
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.BackColor = System.Drawing.Color.SeaShell
        Me.lblAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAddress.Font = New System.Drawing.Font("Candara", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.Black
        Me.lblAddress.Location = New System.Drawing.Point(36, 331)
        Me.lblAddress.Margin = New System.Windows.Forms.Padding(27, 25, 27, 25)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(103, 31)
        Me.lblAddress.TabIndex = 87
        Me.lblAddress.Text = "Address:"
        '
        'lblPW
        '
        Me.lblPW.AutoSize = True
        Me.lblPW.BackColor = System.Drawing.Color.SeaShell
        Me.lblPW.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPW.Font = New System.Drawing.Font("Candara", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPW.ForeColor = System.Drawing.Color.Black
        Me.lblPW.Location = New System.Drawing.Point(814, 193)
        Me.lblPW.Margin = New System.Windows.Forms.Padding(27, 25, 27, 25)
        Me.lblPW.Name = "lblPW"
        Me.lblPW.Size = New System.Drawing.Size(120, 31)
        Me.lblPW.TabIndex = 108
        Me.lblPW.Text = "Password:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.SeaShell
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Candara", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(786, 473)
        Me.Label1.Margin = New System.Windows.Forms.Padding(27, 25, 27, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 31)
        Me.Label1.TabIndex = 116
        Me.Label1.Text = "="
        Me.Label1.Visible = False
        '
        'EditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1527, 538)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtboTown)
        Me.Controls.Add(Me.lblProvince)
        Me.Controls.Add(Me.lblTown)
        Me.Controls.Add(Me.lblBrgy)
        Me.Controls.Add(Me.cboProvince)
        Me.Controls.Add(Me.txtboBarangay)
        Me.Controls.Add(Me.txtSalary)
        Me.Controls.Add(Me.lblSalaryGrade)
        Me.Controls.Add(Me.cboSGrade)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.lblPesoSign)
        Me.Controls.Add(Me.lblRate)
        Me.Controls.Add(Me.txtboWH)
        Me.Controls.Add(Me.lblTotalSalary)
        Me.Controls.Add(Me.lblbWorkHours)
        Me.Controls.Add(Me.txtboTS)
        Me.Controls.Add(Me.txtboHL)
        Me.Controls.Add(Me.lblHrsLeave)
        Me.Controls.Add(Me.txtboHA)
        Me.Controls.Add(Me.lblHrsAbsent)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtboLName)
        Me.Controls.Add(Me.txtboMName)
        Me.Controls.Add(Me.txtboFName)
        Me.Controls.Add(Me.lblMName)
        Me.Controls.Add(Me.lblFName)
        Me.Controls.Add(Me.lblLName)
        Me.Controls.Add(Me.txtboID)
        Me.Controls.Add(Me.lblIDnumber)
        Me.Controls.Add(Me.txtboPS)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblPW)
        Me.Controls.Add(Me.pnlSukatan)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "EditForm"
        Me.Text = "EditForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlSukatan As Panel
    Friend WithEvents txtboTown As TextBox
    Friend WithEvents lblProvince As Label
    Friend WithEvents lblTown As Label
    Friend WithEvents lblBrgy As Label
    Friend WithEvents cboProvince As ComboBox
    Friend WithEvents txtboBarangay As TextBox
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents lblSalaryGrade As Label
    Friend WithEvents cboSGrade As ComboBox
    Friend WithEvents txtRate As TextBox
    Friend WithEvents lblPesoSign As Label
    Friend WithEvents lblRate As Label
    Friend WithEvents txtboWH As TextBox
    Friend WithEvents lblTotalSalary As Label
    Friend WithEvents lblbWorkHours As Label
    Friend WithEvents txtboTS As TextBox
    Friend WithEvents txtboHL As TextBox
    Friend WithEvents lblHrsLeave As Label
    Friend WithEvents txtboHA As TextBox
    Friend WithEvents lblHrsAbsent As Label
    Friend WithEvents lblName As Label
    Friend WithEvents txtboLName As TextBox
    Friend WithEvents txtboMName As TextBox
    Friend WithEvents txtboFName As TextBox
    Friend WithEvents lblMName As Label
    Friend WithEvents lblFName As Label
    Friend WithEvents lblLName As Label
    Friend WithEvents txtboID As TextBox
    Friend WithEvents lblIDnumber As Label
    Friend WithEvents txtboPS As TextBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblPW As Label
    Friend WithEvents Label1 As Label
End Class
