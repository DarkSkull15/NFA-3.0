<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogInForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LogInForm))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.pnlSukatan = New System.Windows.Forms.Panel()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.InputPW = New System.Windows.Forms.TextBox()
        Me.cboID = New System.Windows.Forms.ComboBox()
        Me.pnlLogIn = New System.Windows.Forms.Panel()
        Me.picboxPWord = New System.Windows.Forms.PictureBox()
        Me.PicBoxWarning = New System.Windows.Forms.PictureBox()
        Me.picboxUser = New System.Windows.Forms.PictureBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.picboxFront = New System.Windows.Forms.PictureBox()
        Me.picboxVision = New System.Windows.Forms.PictureBox()
        Me.picboxMandate = New System.Windows.Forms.PictureBox()
        Me.picboxRight = New System.Windows.Forms.PictureBox()
        Me.picboxLeft = New System.Windows.Forms.PictureBox()
        Me.picboxMission = New System.Windows.Forms.PictureBox()
        Me.pnlNFABanner = New System.Windows.Forms.Panel()
        Me.picboxSara = New System.Windows.Forms.PictureBox()
        Me.picboxOccMin = New System.Windows.Forms.PictureBox()
        Me.picboxNFA = New System.Windows.Forms.PictureBox()
        Me.lblNFA = New System.Windows.Forms.Label()
        Me.lblNameOfProject = New System.Windows.Forms.Label()
        Me.lblProvince = New System.Windows.Forms.Label()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.pnlBottom = New System.Windows.Forms.Panel()
        CType(Me.picboxPWord, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBoxWarning, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxFront, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxVision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxMandate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxMission, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlNFABanner.SuspendLayout()
        CType(Me.picboxSara, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxOccMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxNFA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Interval = 8000
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        '
        'Timer4
        '
        Me.Timer4.Interval = 2000
        '
        'pnlSukatan
        '
        Me.pnlSukatan.BackColor = System.Drawing.Color.DarkOrange
        Me.pnlSukatan.Location = New System.Drawing.Point(1, 0)
        Me.pnlSukatan.Name = "pnlSukatan"
        Me.pnlSukatan.Size = New System.Drawing.Size(254, 108)
        Me.pnlSukatan.TabIndex = 60
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(1242, 177)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(283, 12)
        Me.ProgressBar1.TabIndex = 26
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStatus.Font = New System.Drawing.Font("Lucida Sans Typewriter", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.LimeGreen
        Me.lblStatus.Location = New System.Drawing.Point(1042, 193)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(400, 55)
        Me.lblStatus.TabIndex = 54
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'InputPW
        '
        Me.InputPW.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputPW.Location = New System.Drawing.Point(389, 336)
        Me.InputPW.Margin = New System.Windows.Forms.Padding(4)
        Me.InputPW.Name = "InputPW"
        Me.InputPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.InputPW.Size = New System.Drawing.Size(453, 44)
        Me.InputPW.TabIndex = 23
        '
        'cboID
        '
        Me.cboID.DropDownHeight = 100
        Me.cboID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboID.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboID.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboID.IntegralHeight = False
        Me.cboID.ItemHeight = 37
        Me.cboID.Location = New System.Drawing.Point(389, 266)
        Me.cboID.Margin = New System.Windows.Forms.Padding(4)
        Me.cboID.Name = "cboID"
        Me.cboID.Size = New System.Drawing.Size(453, 45)
        Me.cboID.TabIndex = 30
        '
        'pnlLogIn
        '
        Me.pnlLogIn.BackColor = System.Drawing.Color.Transparent
        Me.pnlLogIn.BackgroundImage = CType(resources.GetObject("pnlLogIn.BackgroundImage"), System.Drawing.Image)
        Me.pnlLogIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlLogIn.Location = New System.Drawing.Point(1027, 252)
        Me.pnlLogIn.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlLogIn.Name = "pnlLogIn"
        Me.pnlLogIn.Size = New System.Drawing.Size(423, 189)
        Me.pnlLogIn.TabIndex = 59
        '
        'picboxPWord
        '
        Me.picboxPWord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picboxPWord.Image = CType(resources.GetObject("picboxPWord.Image"), System.Drawing.Image)
        Me.picboxPWord.InitialImage = Nothing
        Me.picboxPWord.Location = New System.Drawing.Point(300, 323)
        Me.picboxPWord.Margin = New System.Windows.Forms.Padding(4)
        Me.picboxPWord.Name = "picboxPWord"
        Me.picboxPWord.Size = New System.Drawing.Size(81, 64)
        Me.picboxPWord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxPWord.TabIndex = 58
        Me.picboxPWord.TabStop = False
        '
        'PicBoxWarning
        '
        Me.PicBoxWarning.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PicBoxWarning.Image = CType(resources.GetObject("PicBoxWarning.Image"), System.Drawing.Image)
        Me.PicBoxWarning.Location = New System.Drawing.Point(852, 331)
        Me.PicBoxWarning.Margin = New System.Windows.Forms.Padding(4)
        Me.PicBoxWarning.Name = "PicBoxWarning"
        Me.PicBoxWarning.Size = New System.Drawing.Size(47, 50)
        Me.PicBoxWarning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBoxWarning.TabIndex = 28
        Me.PicBoxWarning.TabStop = False
        '
        'picboxUser
        '
        Me.picboxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picboxUser.Image = CType(resources.GetObject("picboxUser.Image"), System.Drawing.Image)
        Me.picboxUser.InitialImage = Nothing
        Me.picboxUser.Location = New System.Drawing.Point(300, 252)
        Me.picboxUser.Margin = New System.Windows.Forms.Padding(4)
        Me.picboxUser.Name = "picboxUser"
        Me.picboxUser.Size = New System.Drawing.Size(81, 64)
        Me.picboxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxUser.TabIndex = 54
        Me.picboxUser.TabStop = False
        '
        'btnLogin
        '
        Me.btnLogin.BackgroundImage = CType(resources.GetObject("btnLogin.BackgroundImage"), System.Drawing.Image)
        Me.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnLogin.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.Blue
        Me.btnLogin.Location = New System.Drawing.Point(464, 396)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(289, 58)
        Me.btnLogin.TabIndex = 24
        Me.btnLogin.Text = "               Log In"
        Me.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'picboxFront
        '
        Me.picboxFront.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picboxFront.Image = Global.NFAOccMdo.My.Resources.Resources.Banner1
        Me.picboxFront.InitialImage = Nothing
        Me.picboxFront.Location = New System.Drawing.Point(1497, 213)
        Me.picboxFront.Margin = New System.Windows.Forms.Padding(4)
        Me.picboxFront.Name = "picboxFront"
        Me.picboxFront.Size = New System.Drawing.Size(337, 128)
        Me.picboxFront.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxFront.TabIndex = 57
        Me.picboxFront.TabStop = False
        '
        'picboxVision
        '
        Me.picboxVision.Image = CType(resources.GetObject("picboxVision.Image"), System.Drawing.Image)
        Me.picboxVision.Location = New System.Drawing.Point(579, -13)
        Me.picboxVision.Name = "picboxVision"
        Me.picboxVision.Size = New System.Drawing.Size(310, 110)
        Me.picboxVision.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxVision.TabIndex = 62
        Me.picboxVision.TabStop = False
        '
        'picboxMandate
        '
        Me.picboxMandate.Image = CType(resources.GetObject("picboxMandate.Image"), System.Drawing.Image)
        Me.picboxMandate.Location = New System.Drawing.Point(536, 29)
        Me.picboxMandate.Name = "picboxMandate"
        Me.picboxMandate.Size = New System.Drawing.Size(310, 110)
        Me.picboxMandate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxMandate.TabIndex = 60
        Me.picboxMandate.TabStop = False
        '
        'picboxRight
        '
        Me.picboxRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picboxRight.Image = Global.NFAOccMdo.My.Resources.Resources.Banner3
        Me.picboxRight.InitialImage = Nothing
        Me.picboxRight.Location = New System.Drawing.Point(1267, 29)
        Me.picboxRight.Margin = New System.Windows.Forms.Padding(4)
        Me.picboxRight.Name = "picboxRight"
        Me.picboxRight.Size = New System.Drawing.Size(155, 52)
        Me.picboxRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxRight.TabIndex = 58
        Me.picboxRight.TabStop = False
        '
        'picboxLeft
        '
        Me.picboxLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picboxLeft.Image = Global.NFAOccMdo.My.Resources.Resources.Banner2
        Me.picboxLeft.InitialImage = Nothing
        Me.picboxLeft.Location = New System.Drawing.Point(1527, 97)
        Me.picboxLeft.Margin = New System.Windows.Forms.Padding(4)
        Me.picboxLeft.Name = "picboxLeft"
        Me.picboxLeft.Size = New System.Drawing.Size(155, 52)
        Me.picboxLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxLeft.TabIndex = 52
        Me.picboxLeft.TabStop = False
        '
        'picboxMission
        '
        Me.picboxMission.Image = CType(resources.GetObject("picboxMission.Image"), System.Drawing.Image)
        Me.picboxMission.Location = New System.Drawing.Point(607, 39)
        Me.picboxMission.Name = "picboxMission"
        Me.picboxMission.Size = New System.Drawing.Size(310, 110)
        Me.picboxMission.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxMission.TabIndex = 61
        Me.picboxMission.TabStop = False
        '
        'pnlNFABanner
        '
        Me.pnlNFABanner.BackgroundImage = CType(resources.GetObject("pnlNFABanner.BackgroundImage"), System.Drawing.Image)
        Me.pnlNFABanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlNFABanner.Controls.Add(Me.picboxSara)
        Me.pnlNFABanner.Controls.Add(Me.picboxOccMin)
        Me.pnlNFABanner.Controls.Add(Me.picboxNFA)
        Me.pnlNFABanner.Controls.Add(Me.lblNFA)
        Me.pnlNFABanner.Controls.Add(Me.lblNameOfProject)
        Me.pnlNFABanner.Controls.Add(Me.lblProvince)
        Me.pnlNFABanner.Location = New System.Drawing.Point(4, 471)
        Me.pnlNFABanner.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlNFABanner.Name = "pnlNFABanner"
        Me.pnlNFABanner.Size = New System.Drawing.Size(1896, 428)
        Me.pnlNFABanner.TabIndex = 55
        '
        'picboxSara
        '
        Me.picboxSara.BackColor = System.Drawing.Color.Transparent
        Me.picboxSara.BackgroundImage = CType(resources.GetObject("picboxSara.BackgroundImage"), System.Drawing.Image)
        Me.picboxSara.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picboxSara.Image = CType(resources.GetObject("picboxSara.Image"), System.Drawing.Image)
        Me.picboxSara.Location = New System.Drawing.Point(748, 262)
        Me.picboxSara.Name = "picboxSara"
        Me.picboxSara.Size = New System.Drawing.Size(165, 78)
        Me.picboxSara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxSara.TabIndex = 7
        Me.picboxSara.TabStop = False
        '
        'picboxOccMin
        '
        Me.picboxOccMin.BackColor = System.Drawing.Color.Transparent
        Me.picboxOccMin.BackgroundImage = CType(resources.GetObject("picboxOccMin.BackgroundImage"), System.Drawing.Image)
        Me.picboxOccMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picboxOccMin.Image = CType(resources.GetObject("picboxOccMin.Image"), System.Drawing.Image)
        Me.picboxOccMin.Location = New System.Drawing.Point(860, 102)
        Me.picboxOccMin.Name = "picboxOccMin"
        Me.picboxOccMin.Size = New System.Drawing.Size(152, 118)
        Me.picboxOccMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxOccMin.TabIndex = 6
        Me.picboxOccMin.TabStop = False
        '
        'picboxNFA
        '
        Me.picboxNFA.BackColor = System.Drawing.Color.Transparent
        Me.picboxNFA.BackgroundImage = CType(resources.GetObject("picboxNFA.BackgroundImage"), System.Drawing.Image)
        Me.picboxNFA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picboxNFA.Location = New System.Drawing.Point(530, 262)
        Me.picboxNFA.Name = "picboxNFA"
        Me.picboxNFA.Size = New System.Drawing.Size(152, 118)
        Me.picboxNFA.TabIndex = 5
        Me.picboxNFA.TabStop = False
        '
        'lblNFA
        '
        Me.lblNFA.AutoSize = True
        Me.lblNFA.BackColor = System.Drawing.Color.Transparent
        Me.lblNFA.Font = New System.Drawing.Font("Candara", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNFA.ForeColor = System.Drawing.Color.LightCyan
        Me.lblNFA.Location = New System.Drawing.Point(333, 25)
        Me.lblNFA.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNFA.Name = "lblNFA"
        Me.lblNFA.Size = New System.Drawing.Size(438, 49)
        Me.lblNFA.TabIndex = 1
        Me.lblNFA.Text = "National Food Authority"
        '
        'lblNameOfProject
        '
        Me.lblNameOfProject.AutoSize = True
        Me.lblNameOfProject.BackColor = System.Drawing.Color.Transparent
        Me.lblNameOfProject.Font = New System.Drawing.Font("Candara", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameOfProject.ForeColor = System.Drawing.Color.LightCyan
        Me.lblNameOfProject.Location = New System.Drawing.Point(293, 133)
        Me.lblNameOfProject.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNameOfProject.Name = "lblNameOfProject"
        Me.lblNameOfProject.Size = New System.Drawing.Size(511, 45)
        Me.lblNameOfProject.TabIndex = 4
        Me.lblNameOfProject.Text = "Automated Attendance System"
        '
        'lblProvince
        '
        Me.lblProvince.AutoSize = True
        Me.lblProvince.BackColor = System.Drawing.Color.Transparent
        Me.lblProvince.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProvince.ForeColor = System.Drawing.Color.LightCyan
        Me.lblProvince.Location = New System.Drawing.Point(341, 83)
        Me.lblProvince.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProvince.Name = "lblProvince"
        Me.lblProvince.Size = New System.Drawing.Size(429, 37)
        Me.lblProvince.TabIndex = 2
        Me.lblProvince.Text = "Province of Occidental Mindoro"
        '
        'pnlTop
        '
        Me.pnlTop.BackgroundImage = CType(resources.GetObject("pnlTop.BackgroundImage"), System.Drawing.Image)
        Me.pnlTop.Location = New System.Drawing.Point(25, 115)
        Me.pnlTop.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(495, 19)
        Me.pnlTop.TabIndex = 56
        '
        'pnlBottom
        '
        Me.pnlBottom.BackgroundImage = CType(resources.GetObject("pnlBottom.BackgroundImage"), System.Drawing.Image)
        Me.pnlBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlBottom.Location = New System.Drawing.Point(4, 958)
        Me.pnlBottom.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(1919, 105)
        Me.pnlBottom.TabIndex = 54
        '
        'LogInForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.pnlNFABanner)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.PicBoxWarning)
        Me.Controls.Add(Me.InputPW)
        Me.Controls.Add(Me.cboID)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.picboxPWord)
        Me.Controls.Add(Me.picboxUser)
        Me.Controls.Add(Me.pnlLogIn)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.picboxFront)
        Me.Controls.Add(Me.picboxVision)
        Me.Controls.Add(Me.picboxMandate)
        Me.Controls.Add(Me.picboxRight)
        Me.Controls.Add(Me.picboxLeft)
        Me.Controls.Add(Me.picboxMission)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.pnlSukatan)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "LogInForm"
        Me.Text = "NFA Occ Min"
        CType(Me.picboxPWord, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBoxWarning, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxFront, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxVision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxMandate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxMission, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlNFABanner.ResumeLayout(False)
        Me.pnlNFABanner.PerformLayout()
        CType(Me.picboxSara, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxOccMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxNFA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents picboxRight As System.Windows.Forms.PictureBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents picboxLeft As System.Windows.Forms.PictureBox
    Friend WithEvents picboxFront As System.Windows.Forms.PictureBox
    Friend WithEvents InputPW As System.Windows.Forms.TextBox
    Friend WithEvents cboID As System.Windows.Forms.ComboBox
    Friend WithEvents pnlNFABanner As System.Windows.Forms.Panel
    Friend WithEvents lblNFA As System.Windows.Forms.Label
    Friend WithEvents lblNameOfProject As System.Windows.Forms.Label
    Friend WithEvents lblProvince As System.Windows.Forms.Label
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents picboxPWord As System.Windows.Forms.PictureBox
    Friend WithEvents PicBoxWarning As System.Windows.Forms.PictureBox
    Friend WithEvents picboxUser As System.Windows.Forms.PictureBox
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents pnlLogIn As System.Windows.Forms.Panel
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents pnlBottom As System.Windows.Forms.Panel
    Friend WithEvents pnlSukatan As System.Windows.Forms.Panel
    Friend WithEvents picboxMandate As System.Windows.Forms.PictureBox
    Friend WithEvents picboxVision As System.Windows.Forms.PictureBox
    Friend WithEvents picboxMission As System.Windows.Forms.PictureBox
    Friend WithEvents picboxNFA As PictureBox
    Friend WithEvents picboxSara As PictureBox
    Friend WithEvents picboxOccMin As PictureBox
End Class
