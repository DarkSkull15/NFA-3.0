<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddingForm
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
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.lblYesNo = New System.Windows.Forms.Label()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.lblSalaryGrade = New System.Windows.Forms.Label()
        Me.cboSGrade = New System.Windows.Forms.ComboBox()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.lblPesoSign = New System.Windows.Forms.Label()
        Me.txtboTown = New System.Windows.Forms.TextBox()
        Me.lblProvince = New System.Windows.Forms.Label()
        Me.lblTown = New System.Windows.Forms.Label()
        Me.lblBrgy = New System.Windows.Forms.Label()
        Me.cboProvince = New System.Windows.Forms.ComboBox()
        Me.lblRate = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtboBarangay = New System.Windows.Forms.TextBox()
        Me.txtboLName = New System.Windows.Forms.TextBox()
        Me.txtboMName = New System.Windows.Forms.TextBox()
        Me.txtboFName = New System.Windows.Forms.TextBox()
        Me.lblMname = New System.Windows.Forms.Label()
        Me.lblFname = New System.Windows.Forms.Label()
        Me.lblLname = New System.Windows.Forms.Label()
        Me.lblPW = New System.Windows.Forms.Label()
        Me.txtboID = New System.Windows.Forms.TextBox()
        Me.txtboPS = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblIDnumber = New System.Windows.Forms.Label()
        Me.pnlSukatan = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 10
        '
        'lblYesNo
        '
        Me.lblYesNo.AutoSize = True
        Me.lblYesNo.BackColor = System.Drawing.Color.SeaShell
        Me.lblYesNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblYesNo.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYesNo.ForeColor = System.Drawing.Color.Black
        Me.lblYesNo.Location = New System.Drawing.Point(1312, 555)
        Me.lblYesNo.Margin = New System.Windows.Forms.Padding(27, 25, 27, 25)
        Me.lblYesNo.Name = "lblYesNo"
        Me.lblYesNo.Size = New System.Drawing.Size(35, 39)
        Me.lblYesNo.TabIndex = 76
        Me.lblYesNo.Text = "0"
        Me.lblYesNo.Visible = False
        '
        'txtSalary
        '
        Me.txtSalary.BackColor = System.Drawing.Color.Snow
        Me.txtSalary.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSalary.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalary.Location = New System.Drawing.Point(751, 279)
        Me.txtSalary.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.ReadOnly = True
        Me.txtSalary.Size = New System.Drawing.Size(163, 40)
        Me.txtSalary.TabIndex = 100
        '
        'lblSalaryGrade
        '
        Me.lblSalaryGrade.AutoSize = True
        Me.lblSalaryGrade.BackColor = System.Drawing.Color.SeaShell
        Me.lblSalaryGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSalaryGrade.Font = New System.Drawing.Font("Candara", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalaryGrade.ForeColor = System.Drawing.Color.Black
        Me.lblSalaryGrade.Location = New System.Drawing.Point(107, 110)
        Me.lblSalaryGrade.Margin = New System.Windows.Forms.Padding(27, 25, 27, 25)
        Me.lblSalaryGrade.Name = "lblSalaryGrade"
        Me.lblSalaryGrade.Size = New System.Drawing.Size(157, 31)
        Me.lblSalaryGrade.TabIndex = 90
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
        Me.cboSGrade.Location = New System.Drawing.Point(335, 279)
        Me.cboSGrade.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.cboSGrade.MaxDropDownItems = 3
        Me.cboSGrade.Name = "cboSGrade"
        Me.cboSGrade.Size = New System.Drawing.Size(100, 40)
        Me.cboSGrade.TabIndex = 91
        '
        'txtRate
        '
        Me.txtRate.BackColor = System.Drawing.Color.Snow
        Me.txtRate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRate.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRate.Location = New System.Drawing.Point(1179, 279)
        Me.txtRate.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(160, 40)
        Me.txtRate.TabIndex = 92
        '
        'lblPesoSign
        '
        Me.lblPesoSign.AutoSize = True
        Me.lblPesoSign.BackColor = System.Drawing.Color.SeaShell
        Me.lblPesoSign.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPesoSign.Font = New System.Drawing.Font("Candara", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPesoSign.ForeColor = System.Drawing.Color.Black
        Me.lblPesoSign.Location = New System.Drawing.Point(751, 99)
        Me.lblPesoSign.Margin = New System.Windows.Forms.Padding(27, 25, 27, 25)
        Me.lblPesoSign.Name = "lblPesoSign"
        Me.lblPesoSign.Size = New System.Drawing.Size(40, 31)
        Me.lblPesoSign.TabIndex = 99
        Me.lblPesoSign.Text = "=P"
        '
        'txtboTown
        '
        Me.txtboTown.BackColor = System.Drawing.Color.Snow
        Me.txtboTown.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboTown.Location = New System.Drawing.Point(681, 264)
        Me.txtboTown.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtboTown.MaxLength = 20
        Me.txtboTown.Name = "txtboTown"
        Me.txtboTown.Size = New System.Drawing.Size(335, 40)
        Me.txtboTown.TabIndex = 86
        '
        'lblProvince
        '
        Me.lblProvince.AutoSize = True
        Me.lblProvince.BackColor = System.Drawing.Color.SeaShell
        Me.lblProvince.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProvince.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProvince.ForeColor = System.Drawing.Color.Black
        Me.lblProvince.Location = New System.Drawing.Point(1240, 320)
        Me.lblProvince.Margin = New System.Windows.Forms.Padding(27, 25, 27, 25)
        Me.lblProvince.Name = "lblProvince"
        Me.lblProvince.Size = New System.Drawing.Size(85, 26)
        Me.lblProvince.TabIndex = 89
        Me.lblProvince.Text = "Province"
        '
        'lblTown
        '
        Me.lblTown.AutoSize = True
        Me.lblTown.BackColor = System.Drawing.Color.SeaShell
        Me.lblTown.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTown.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTown.ForeColor = System.Drawing.Color.Black
        Me.lblTown.Location = New System.Drawing.Point(799, 320)
        Me.lblTown.Margin = New System.Windows.Forms.Padding(27, 25, 27, 25)
        Me.lblTown.Name = "lblTown"
        Me.lblTown.Size = New System.Drawing.Size(94, 26)
        Me.lblTown.TabIndex = 88
        Me.lblTown.Text = "Town/City"
        '
        'lblBrgy
        '
        Me.lblBrgy.AutoSize = True
        Me.lblBrgy.BackColor = System.Drawing.Color.SeaShell
        Me.lblBrgy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBrgy.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBrgy.ForeColor = System.Drawing.Color.Black
        Me.lblBrgy.Location = New System.Drawing.Point(377, 320)
        Me.lblBrgy.Margin = New System.Windows.Forms.Padding(27, 25, 27, 25)
        Me.lblBrgy.Name = "lblBrgy"
        Me.lblBrgy.Size = New System.Drawing.Size(92, 26)
        Me.lblBrgy.TabIndex = 87
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
        Me.cboProvince.Location = New System.Drawing.Point(1109, 263)
        Me.cboProvince.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.cboProvince.MaxLength = 20
        Me.cboProvince.Name = "cboProvince"
        Me.cboProvince.Size = New System.Drawing.Size(335, 40)
        Me.cboProvince.TabIndex = 98
        '
        'lblRate
        '
        Me.lblRate.AutoSize = True
        Me.lblRate.BackColor = System.Drawing.Color.SeaShell
        Me.lblRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRate.Font = New System.Drawing.Font("Candara", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRate.ForeColor = System.Drawing.Color.Black
        Me.lblRate.Location = New System.Drawing.Point(1023, 99)
        Me.lblRate.Margin = New System.Windows.Forms.Padding(27, 25, 27, 25)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(99, 31)
        Me.lblRate.TabIndex = 93
        Me.lblRate.Text = "Rate/Hr:"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.BackColor = System.Drawing.Color.SeaShell
        Me.lblAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAddress.Font = New System.Drawing.Font("Candara", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.Black
        Me.lblAddress.Location = New System.Drawing.Point(93, 190)
        Me.lblAddress.Margin = New System.Windows.Forms.Padding(27, 25, 27, 25)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(103, 31)
        Me.lblAddress.TabIndex = 84
        Me.lblAddress.Text = "Address:"
        '
        'txtboBarangay
        '
        Me.txtboBarangay.BackColor = System.Drawing.Color.Snow
        Me.txtboBarangay.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboBarangay.Location = New System.Drawing.Point(265, 264)
        Me.txtboBarangay.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtboBarangay.MaxLength = 20
        Me.txtboBarangay.Name = "txtboBarangay"
        Me.txtboBarangay.Size = New System.Drawing.Size(335, 40)
        Me.txtboBarangay.TabIndex = 85
        '
        'txtboLName
        '
        Me.txtboLName.BackColor = System.Drawing.Color.Snow
        Me.txtboLName.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboLName.Location = New System.Drawing.Point(279, 262)
        Me.txtboLName.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtboLName.MaxLength = 20
        Me.txtboLName.Name = "txtboLName"
        Me.txtboLName.Size = New System.Drawing.Size(335, 40)
        Me.txtboLName.TabIndex = 81
        '
        'txtboMName
        '
        Me.txtboMName.BackColor = System.Drawing.Color.Snow
        Me.txtboMName.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboMName.Location = New System.Drawing.Point(1123, 262)
        Me.txtboMName.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtboMName.MaxLength = 20
        Me.txtboMName.Name = "txtboMName"
        Me.txtboMName.Size = New System.Drawing.Size(335, 40)
        Me.txtboMName.TabIndex = 83
        '
        'txtboFName
        '
        Me.txtboFName.BackColor = System.Drawing.Color.Snow
        Me.txtboFName.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboFName.Location = New System.Drawing.Point(695, 262)
        Me.txtboFName.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtboFName.MaxLength = 20
        Me.txtboFName.Name = "txtboFName"
        Me.txtboFName.Size = New System.Drawing.Size(335, 40)
        Me.txtboFName.TabIndex = 82
        '
        'lblMname
        '
        Me.lblMname.AutoSize = True
        Me.lblMname.BackColor = System.Drawing.Color.SeaShell
        Me.lblMname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMname.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMname.ForeColor = System.Drawing.Color.Black
        Me.lblMname.Location = New System.Drawing.Point(1223, 316)
        Me.lblMname.Margin = New System.Windows.Forms.Padding(27, 25, 27, 25)
        Me.lblMname.Name = "lblMname"
        Me.lblMname.Size = New System.Drawing.Size(119, 26)
        Me.lblMname.TabIndex = 80
        Me.lblMname.Text = "MiddleName"
        '
        'lblFname
        '
        Me.lblFname.AutoSize = True
        Me.lblFname.BackColor = System.Drawing.Color.SeaShell
        Me.lblFname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFname.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFname.ForeColor = System.Drawing.Color.Black
        Me.lblFname.Location = New System.Drawing.Point(804, 316)
        Me.lblFname.Margin = New System.Windows.Forms.Padding(27, 25, 27, 25)
        Me.lblFname.Name = "lblFname"
        Me.lblFname.Size = New System.Drawing.Size(97, 26)
        Me.lblFname.TabIndex = 79
        Me.lblFname.Text = "FirstName"
        '
        'lblLname
        '
        Me.lblLname.AutoSize = True
        Me.lblLname.BackColor = System.Drawing.Color.SeaShell
        Me.lblLname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLname.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLname.ForeColor = System.Drawing.Color.Black
        Me.lblLname.Location = New System.Drawing.Point(383, 316)
        Me.lblLname.Margin = New System.Windows.Forms.Padding(27, 25, 27, 25)
        Me.lblLname.Name = "lblLname"
        Me.lblLname.Size = New System.Drawing.Size(96, 26)
        Me.lblLname.TabIndex = 78
        Me.lblLname.Text = "LastName"
        '
        'lblPW
        '
        Me.lblPW.AutoSize = True
        Me.lblPW.BackColor = System.Drawing.Color.SeaShell
        Me.lblPW.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPW.Font = New System.Drawing.Font("Candara", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPW.ForeColor = System.Drawing.Color.Black
        Me.lblPW.Location = New System.Drawing.Point(846, 99)
        Me.lblPW.Margin = New System.Windows.Forms.Padding(27, 25, 27, 25)
        Me.lblPW.Name = "lblPW"
        Me.lblPW.Size = New System.Drawing.Size(120, 31)
        Me.lblPW.TabIndex = 97
        Me.lblPW.Text = "Password:"
        '
        'txtboID
        '
        Me.txtboID.BackColor = System.Drawing.Color.Snow
        Me.txtboID.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboID.Location = New System.Drawing.Point(273, 279)
        Me.txtboID.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtboID.Name = "txtboID"
        Me.txtboID.ReadOnly = True
        Me.txtboID.Size = New System.Drawing.Size(456, 40)
        Me.txtboID.TabIndex = 94
        '
        'txtboPS
        '
        Me.txtboPS.BackColor = System.Drawing.Color.Snow
        Me.txtboPS.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboPS.Location = New System.Drawing.Point(1023, 279)
        Me.txtboPS.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtboPS.MaxLength = 20
        Me.txtboPS.Name = "txtboPS"
        Me.txtboPS.Size = New System.Drawing.Size(429, 40)
        Me.txtboPS.TabIndex = 96
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.SeaShell
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblName.Font = New System.Drawing.Font("Candara", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.Black
        Me.lblName.Location = New System.Drawing.Point(265, 190)
        Me.lblName.Margin = New System.Windows.Forms.Padding(27, 25, 27, 25)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(81, 31)
        Me.lblName.TabIndex = 77
        Me.lblName.Text = "Name:"
        '
        'lblIDnumber
        '
        Me.lblIDnumber.AutoSize = True
        Me.lblIDnumber.BackColor = System.Drawing.Color.SeaShell
        Me.lblIDnumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIDnumber.Font = New System.Drawing.Font("Candara", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDnumber.ForeColor = System.Drawing.Color.Black
        Me.lblIDnumber.Location = New System.Drawing.Point(362, 130)
        Me.lblIDnumber.Margin = New System.Windows.Forms.Padding(27, 25, 27, 25)
        Me.lblIDnumber.Name = "lblIDnumber"
        Me.lblIDnumber.Size = New System.Drawing.Size(131, 31)
        Me.lblIDnumber.TabIndex = 95
        Me.lblIDnumber.Text = "ID Number:"
        '
        'pnlSukatan
        '
        Me.pnlSukatan.BackColor = System.Drawing.SystemColors.Control
        Me.pnlSukatan.Location = New System.Drawing.Point(0, 0)
        Me.pnlSukatan.Name = "pnlSukatan"
        Me.pnlSukatan.Size = New System.Drawing.Size(254, 16)
        Me.pnlSukatan.TabIndex = 101
        '
        'AddingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1535, 608)
        Me.Controls.Add(Me.txtSalary)
        Me.Controls.Add(Me.lblSalaryGrade)
        Me.Controls.Add(Me.cboSGrade)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.lblPesoSign)
        Me.Controls.Add(Me.txtboTown)
        Me.Controls.Add(Me.lblProvince)
        Me.Controls.Add(Me.lblTown)
        Me.Controls.Add(Me.lblBrgy)
        Me.Controls.Add(Me.cboProvince)
        Me.Controls.Add(Me.lblRate)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.txtboBarangay)
        Me.Controls.Add(Me.txtboLName)
        Me.Controls.Add(Me.txtboMName)
        Me.Controls.Add(Me.txtboFName)
        Me.Controls.Add(Me.lblMname)
        Me.Controls.Add(Me.lblFname)
        Me.Controls.Add(Me.lblLname)
        Me.Controls.Add(Me.lblPW)
        Me.Controls.Add(Me.txtboID)
        Me.Controls.Add(Me.txtboPS)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblIDnumber)
        Me.Controls.Add(Me.lblYesNo)
        Me.Controls.Add(Me.pnlSukatan)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "AddingForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents lblYesNo As System.Windows.Forms.Label
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents lblSalaryGrade As Label
    Friend WithEvents cboSGrade As ComboBox
    Friend WithEvents txtRate As TextBox
    Friend WithEvents lblPesoSign As Label
    Friend WithEvents txtboTown As TextBox
    Friend WithEvents lblProvince As Label
    Friend WithEvents lblTown As Label
    Friend WithEvents lblBrgy As Label
    Friend WithEvents cboProvince As ComboBox
    Friend WithEvents lblRate As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents txtboBarangay As TextBox
    Friend WithEvents txtboLName As TextBox
    Friend WithEvents txtboMName As TextBox
    Friend WithEvents txtboFName As TextBox
    Friend WithEvents lblMname As Label
    Friend WithEvents lblFname As Label
    Friend WithEvents lblLname As Label
    Friend WithEvents lblPW As Label
    Friend WithEvents txtboID As TextBox
    Friend WithEvents txtboPS As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblIDnumber As Label
    Friend WithEvents pnlSukatan As Panel
End Class
