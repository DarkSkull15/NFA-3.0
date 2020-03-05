<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.txtboxSearch = New System.Windows.Forms.TextBox()
        Me.pnlTab = New System.Windows.Forms.Panel()
        Me.lblBy = New System.Windows.Forms.Label()
        Me.pnlBodyTop = New System.Windows.Forms.Panel()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.lblEmployeeCount = New System.Windows.Forms.Label()
        Me.cboSearch = New System.Windows.Forms.ComboBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pnlBodyLeft = New System.Windows.Forms.Panel()
        Me.btnDlete = New System.Windows.Forms.Button()
        Me.btnEdt = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.picboxOccMin = New System.Windows.Forms.PictureBox()
        Me.picboxNFA = New System.Windows.Forms.PictureBox()
        Me.lblNameOfProject = New System.Windows.Forms.Label()
        Me.lblProvince = New System.Windows.Forms.Label()
        Me.lblNFA = New System.Windows.Forms.Label()
        Me.pnlBottom = New System.Windows.Forms.Panel()
        Me.pnlDateTime = New System.Windows.Forms.Panel()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnPayrol = New System.Windows.Forms.Button()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.pnlSukatan = New System.Windows.Forms.Panel()
        Me.pnlBodyLeft.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        CType(Me.picboxOccMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxNFA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtboxSearch
        '
        Me.txtboxSearch.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxSearch.Location = New System.Drawing.Point(676, 396)
        Me.txtboxSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtboxSearch.Name = "txtboxSearch"
        Me.txtboxSearch.Size = New System.Drawing.Size(298, 44)
        Me.txtboxSearch.TabIndex = 42
        '
        'pnlTab
        '
        Me.pnlTab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlTab.Location = New System.Drawing.Point(275, 717)
        Me.pnlTab.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlTab.Name = "pnlTab"
        Me.pnlTab.Size = New System.Drawing.Size(1539, 85)
        Me.pnlTab.TabIndex = 54
        '
        'lblBy
        '
        Me.lblBy.AutoSize = True
        Me.lblBy.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBy.Location = New System.Drawing.Point(1082, 371)
        Me.lblBy.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBy.Name = "lblBy"
        Me.lblBy.Size = New System.Drawing.Size(35, 24)
        Me.lblBy.TabIndex = 53
        Me.lblBy.Text = "by:"
        '
        'pnlBodyTop
        '
        Me.pnlBodyTop.BackColor = System.Drawing.SystemColors.Control
        Me.pnlBodyTop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlBodyTop.Location = New System.Drawing.Point(277, 202)
        Me.pnlBodyTop.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlBodyTop.Name = "pnlBodyTop"
        Me.pnlBodyTop.Size = New System.Drawing.Size(1536, 75)
        Me.pnlBodyTop.TabIndex = 56
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.Location = New System.Drawing.Point(1065, 322)
        Me.lblSearch.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(67, 24)
        Me.lblSearch.TabIndex = 52
        Me.lblSearch.Text = "Search"
        '
        'lblEmployeeCount
        '
        Me.lblEmployeeCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployeeCount.Font = New System.Drawing.Font("Lucida Sans Typewriter", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeCount.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.lblEmployeeCount.Location = New System.Drawing.Point(283, 320)
        Me.lblEmployeeCount.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblEmployeeCount.Name = "lblEmployeeCount"
        Me.lblEmployeeCount.Size = New System.Drawing.Size(290, 54)
        Me.lblEmployeeCount.TabIndex = 51
        Me.lblEmployeeCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboSearch
        '
        Me.cboSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSearch.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSearch.FormattingEnabled = True
        Me.cboSearch.Items.AddRange(New Object() {"First Name", "Middle Name", "Last Name", "Barangay", "Town", "Province", "Salary Grade"})
        Me.cboSearch.Location = New System.Drawing.Point(676, 448)
        Me.cboSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.cboSearch.Name = "cboSearch"
        Me.cboSearch.Size = New System.Drawing.Size(234, 45)
        Me.cboSearch.TabIndex = 45
        '
        'lblStatus
        '
        Me.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStatus.Font = New System.Drawing.Font("Lucida Sans Typewriter", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.lblStatus.Location = New System.Drawing.Point(676, 322)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(298, 55)
        Me.lblStatus.TabIndex = 50
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(55, 6)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 17)
        Me.Label11.TabIndex = 149
        Me.Label11.Text = "Label11"
        Me.Label11.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(123, 6)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 17)
        Me.Label10.TabIndex = 148
        Me.Label10.Text = "Label10"
        Me.Label10.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(191, 5)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 17)
        Me.Label9.TabIndex = 147
        Me.Label9.Text = "Label9"
        Me.Label9.Visible = False
        '
        'pnlBodyLeft
        '
        Me.pnlBodyLeft.BackColor = System.Drawing.SystemColors.Control
        Me.pnlBodyLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlBodyLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlBodyLeft.Controls.Add(Me.Label11)
        Me.pnlBodyLeft.Controls.Add(Me.Label10)
        Me.pnlBodyLeft.Controls.Add(Me.Label9)
        Me.pnlBodyLeft.Location = New System.Drawing.Point(1, 202)
        Me.pnlBodyLeft.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlBodyLeft.Name = "pnlBodyLeft"
        Me.pnlBodyLeft.Size = New System.Drawing.Size(254, 600)
        Me.pnlBodyLeft.TabIndex = 52
        '
        'btnDlete
        '
        Me.btnDlete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnDlete.BackColor = System.Drawing.Color.AliceBlue
        Me.btnDlete.BackgroundImage = CType(resources.GetObject("btnDlete.BackgroundImage"), System.Drawing.Image)
        Me.btnDlete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDlete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDlete.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDlete.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnDlete.Image = CType(resources.GetObject("btnDlete.Image"), System.Drawing.Image)
        Me.btnDlete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDlete.Location = New System.Drawing.Point(5, 148)
        Me.btnDlete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDlete.Name = "btnDlete"
        Me.btnDlete.Size = New System.Drawing.Size(229, 26)
        Me.btnDlete.TabIndex = 146
        Me.btnDlete.Text = "       Delete"
        Me.btnDlete.UseVisualStyleBackColor = False
        '
        'btnEdt
        '
        Me.btnEdt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnEdt.BackColor = System.Drawing.Color.AliceBlue
        Me.btnEdt.BackgroundImage = CType(resources.GetObject("btnEdt.BackgroundImage"), System.Drawing.Image)
        Me.btnEdt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEdt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdt.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdt.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnEdt.Image = CType(resources.GetObject("btnEdt.Image"), System.Drawing.Image)
        Me.btnEdt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEdt.Location = New System.Drawing.Point(5, 116)
        Me.btnEdt.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEdt.Name = "btnEdt"
        Me.btnEdt.Size = New System.Drawing.Size(229, 26)
        Me.btnEdt.TabIndex = 145
        Me.btnEdt.Text = "       Edit"
        Me.btnEdt.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAdd.BackColor = System.Drawing.Color.AliceBlue
        Me.btnAdd.BackgroundImage = CType(resources.GetObject("btnAdd.BackgroundImage"), System.Drawing.Image)
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(5, 82)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(229, 26)
        Me.btnAdd.TabIndex = 144
        Me.btnAdd.Text = "       Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSearch.BackColor = System.Drawing.Color.AliceBlue
        Me.btnSearch.BackgroundImage = CType(resources.GetObject("btnSearch.BackgroundImage"), System.Drawing.Image)
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(5, 50)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(229, 24)
        Me.btnSearch.TabIndex = 143
        Me.btnSearch.Text = "       Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'pnlTop
        '
        Me.pnlTop.BackgroundImage = CType(resources.GetObject("pnlTop.BackgroundImage"), System.Drawing.Image)
        Me.pnlTop.Controls.Add(Me.picboxOccMin)
        Me.pnlTop.Controls.Add(Me.picboxNFA)
        Me.pnlTop.Controls.Add(Me.lblNameOfProject)
        Me.pnlTop.Controls.Add(Me.lblProvince)
        Me.pnlTop.Controls.Add(Me.lblNFA)
        Me.pnlTop.Location = New System.Drawing.Point(1, 21)
        Me.pnlTop.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(1817, 21)
        Me.pnlTop.TabIndex = 55
        '
        'picboxOccMin
        '
        Me.picboxOccMin.BackColor = System.Drawing.Color.Transparent
        Me.picboxOccMin.BackgroundImage = Global.NFAOccMdo.My.Resources.Resources.NFA_Logo
        Me.picboxOccMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picboxOccMin.Image = Global.NFAOccMdo.My.Resources.Resources.Ph_seal_occidental_mindoro
        Me.picboxOccMin.Location = New System.Drawing.Point(1158, 35)
        Me.picboxOccMin.Name = "picboxOccMin"
        Me.picboxOccMin.Size = New System.Drawing.Size(152, 118)
        Me.picboxOccMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxOccMin.TabIndex = 8
        Me.picboxOccMin.TabStop = False
        '
        'picboxNFA
        '
        Me.picboxNFA.BackColor = System.Drawing.Color.Transparent
        Me.picboxNFA.BackgroundImage = Global.NFAOccMdo.My.Resources.Resources.NFA_Logo
        Me.picboxNFA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picboxNFA.Location = New System.Drawing.Point(490, 35)
        Me.picboxNFA.Name = "picboxNFA"
        Me.picboxNFA.Size = New System.Drawing.Size(152, 118)
        Me.picboxNFA.TabIndex = 7
        Me.picboxNFA.TabStop = False
        '
        'lblNameOfProject
        '
        Me.lblNameOfProject.AutoSize = True
        Me.lblNameOfProject.BackColor = System.Drawing.Color.Transparent
        Me.lblNameOfProject.Font = New System.Drawing.Font("Candara", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameOfProject.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblNameOfProject.Location = New System.Drawing.Point(649, 130)
        Me.lblNameOfProject.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNameOfProject.Name = "lblNameOfProject"
        Me.lblNameOfProject.Size = New System.Drawing.Size(509, 45)
        Me.lblNameOfProject.TabIndex = 3
        Me.lblNameOfProject.Text = "Automated Attendance System"
        '
        'lblProvince
        '
        Me.lblProvince.AutoSize = True
        Me.lblProvince.BackColor = System.Drawing.Color.Transparent
        Me.lblProvince.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProvince.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblProvince.Location = New System.Drawing.Point(692, 84)
        Me.lblProvince.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProvince.Name = "lblProvince"
        Me.lblProvince.Size = New System.Drawing.Size(424, 37)
        Me.lblProvince.TabIndex = 2
        Me.lblProvince.Text = "Province of Occidental Mindoro"
        '
        'lblNFA
        '
        Me.lblNFA.AutoSize = True
        Me.lblNFA.BackColor = System.Drawing.Color.Transparent
        Me.lblNFA.Font = New System.Drawing.Font("Candara", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNFA.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblNFA.Location = New System.Drawing.Point(704, 27)
        Me.lblNFA.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNFA.Name = "lblNFA"
        Me.lblNFA.Size = New System.Drawing.Size(401, 45)
        Me.lblNFA.TabIndex = 1
        Me.lblNFA.Text = "National Food Authority"
        '
        'pnlBottom
        '
        Me.pnlBottom.BackColor = System.Drawing.SystemColors.Control
        Me.pnlBottom.BackgroundImage = CType(resources.GetObject("pnlBottom.BackgroundImage"), System.Drawing.Image)
        Me.pnlBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlBottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlBottom.Location = New System.Drawing.Point(1, 809)
        Me.pnlBottom.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(1816, 131)
        Me.pnlBottom.TabIndex = 53
        '
        'pnlDateTime
        '
        Me.pnlDateTime.BackColor = System.Drawing.Color.Transparent
        Me.pnlDateTime.BackgroundImage = Global.NFAOccMdo.My.Resources.Resources.Background
        Me.pnlDateTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlDateTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlDateTime.Location = New System.Drawing.Point(864, 62)
        Me.pnlDateTime.Margin = New System.Windows.Forms.Padding(13, 12, 13, 12)
        Me.pnlDateTime.Name = "pnlDateTime"
        Me.pnlDateTime.Size = New System.Drawing.Size(452, 99)
        Me.pnlDateTime.TabIndex = 152
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Lucida Sans Typewriter", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(1333, 62)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(123, 34)
        Me.lblTime.TabIndex = 53
        Me.lblTime.Text = "Label3"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Lucida Sans Typewriter", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(1333, 105)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(96, 27)
        Me.lblDate.TabIndex = 52
        Me.lblDate.Text = "Label2"
        '
        'btnReset
        '
        Me.btnReset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnReset.BackColor = System.Drawing.Color.AliceBlue
        Me.btnReset.BackgroundImage = CType(resources.GetObject("btnReset.BackgroundImage"), System.Drawing.Image)
        Me.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReset.Enabled = False
        Me.btnReset.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnReset.Image = CType(resources.GetObject("btnReset.Image"), System.Drawing.Image)
        Me.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReset.Location = New System.Drawing.Point(496, 83)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(229, 35)
        Me.btnReset.TabIndex = 151
        Me.btnReset.Text = "       Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSave.BackColor = System.Drawing.Color.AliceBlue
        Me.btnSave.BackgroundImage = CType(resources.GetObject("btnSave.BackgroundImage"), System.Drawing.Image)
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Enabled = False
        Me.btnSave.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(496, 50)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(229, 35)
        Me.btnSave.TabIndex = 150
        Me.btnSave.Text = "       Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnPrint.BackColor = System.Drawing.Color.AliceBlue
        Me.btnPrint.BackgroundImage = CType(resources.GetObject("btnPrint.BackgroundImage"), System.Drawing.Image)
        Me.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.Location = New System.Drawing.Point(259, 115)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(229, 35)
        Me.btnPrint.TabIndex = 147
        Me.btnPrint.Text = "       Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnPayrol
        '
        Me.btnPayrol.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnPayrol.BackColor = System.Drawing.Color.AliceBlue
        Me.btnPayrol.BackgroundImage = CType(resources.GetObject("btnPayrol.BackgroundImage"), System.Drawing.Image)
        Me.btnPayrol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnPayrol.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPayrol.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayrol.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnPayrol.Image = CType(resources.GetObject("btnPayrol.Image"), System.Drawing.Image)
        Me.btnPayrol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPayrol.Location = New System.Drawing.Point(259, 83)
        Me.btnPayrol.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPayrol.Name = "btnPayrol"
        Me.btnPayrol.Size = New System.Drawing.Size(229, 35)
        Me.btnPayrol.TabIndex = 148
        Me.btnPayrol.Text = "       Summary"
        Me.btnPayrol.UseVisualStyleBackColor = False
        '
        'btnLogOut
        '
        Me.btnLogOut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnLogOut.BackColor = System.Drawing.Color.AliceBlue
        Me.btnLogOut.BackgroundImage = CType(resources.GetObject("btnLogOut.BackgroundImage"), System.Drawing.Image)
        Me.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogOut.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnLogOut.Image = CType(resources.GetObject("btnLogOut.Image"), System.Drawing.Image)
        Me.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogOut.Location = New System.Drawing.Point(259, 50)
        Me.btnLogOut.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(229, 35)
        Me.btnLogOut.TabIndex = 149
        Me.btnLogOut.Text = "       Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'pnlSukatan
        '
        Me.pnlSukatan.BackColor = System.Drawing.SystemColors.Control
        Me.pnlSukatan.Location = New System.Drawing.Point(1, 2)
        Me.pnlSukatan.Name = "pnlSukatan"
        Me.pnlSukatan.Size = New System.Drawing.Size(254, 16)
        Me.pnlSukatan.TabIndex = 61
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.NFAOccMdo.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.txtboxSearch)
        Me.Controls.Add(Me.lblBy)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.cboSearch)
        Me.Controls.Add(Me.lblEmployeeCount)
        Me.Controls.Add(Me.pnlDateTime)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.btnPayrol)
        Me.Controls.Add(Me.btnDlete)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnEdt)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.pnlTab)
        Me.Controls.Add(Me.pnlBodyTop)
        Me.Controls.Add(Me.pnlBodyLeft)
        Me.Controls.Add(Me.pnlSukatan)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MainForm"
        Me.Text = "NFA Occ Min"
        Me.pnlBodyLeft.ResumeLayout(False)
        Me.pnlBodyLeft.PerformLayout()
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        CType(Me.picboxOccMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxNFA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtboxSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblNameOfProject As System.Windows.Forms.Label
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents lblProvince As System.Windows.Forms.Label
    Friend WithEvents lblNFA As System.Windows.Forms.Label
    Friend WithEvents pnlTab As System.Windows.Forms.Panel
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblBy As System.Windows.Forms.Label
    Friend WithEvents pnlBodyTop As System.Windows.Forms.Panel
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents lblEmployeeCount As System.Windows.Forms.Label
    Friend WithEvents cboSearch As System.Windows.Forms.ComboBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents pnlDateTime As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents pnlBottom As System.Windows.Forms.Panel
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnPayrol As System.Windows.Forms.Button
    Friend WithEvents btnLogOut As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnDlete As System.Windows.Forms.Button
    Friend WithEvents btnEdt As System.Windows.Forms.Button
    Friend WithEvents pnlBodyLeft As System.Windows.Forms.Panel
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents pnlSukatan As System.Windows.Forms.Panel
    Friend WithEvents picboxOccMin As PictureBox
    Friend WithEvents picboxNFA As PictureBox
End Class
