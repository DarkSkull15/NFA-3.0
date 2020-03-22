Imports System.Drawing.Imaging
Imports System.Data.SqlClient

Public Class LogInForm

    Public myConnToAccess As SQLConnection
    Dim mySQLCommand As SQLCommand
    Dim mySQLStrg As String


    Dim da As SQLDataAdapter
    Dim tables As DataTableCollection
    Dim ds As DataSet
    Dim a As Integer
    Dim source1 As New BindingSource

    'To prevent the flicker of screen
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property
    Public Sub LogInForm_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        ' Me.WindowState = FormWindowState.Maximized
        Me.CenterToScreen()



        'Layout
        pnlSukatan.Dock = DockStyle.Fill

        'Top Layout
        pnlTop.Width = pnlSukatan.Width
        pnlTop.Height = pnlSukatan.Height / 3
        pnlTop.Left = pnlSukatan.Left
        pnlTop.Top = pnlSukatan.Top

        pnlNFABanner.Width = pnlSukatan.Width
        pnlNFABanner.Height = pnlSukatan.Height / 4
        pnlNFABanner.Left = pnlSukatan.Left
        pnlNFABanner.Top = pnlSukatan.Top + pnlSukatan.Height / 40

        picboxSara.Width = pnlSukatan.Width / 40
        picboxSara.Height = pnlSukatan.Width / 40
        picboxSara.Left = pnlSukatan.Right - pnlSukatan.Height / 20
        picboxSara.Top = pnlSukatan.Top + pnlSukatan.Height / 100

        picboxOccMin.Width = pnlSukatan.Width / 10
        picboxOccMin.Height = pnlSukatan.Width / 10
        picboxOccMin.Left = pnlSukatan.Left + pnlSukatan.Width / 5
        picboxOccMin.Top = pnlSukatan.Top + pnlSukatan.Height / 30

        picboxNFA.Width = pnlSukatan.Width / 10
        picboxNFA.Height = pnlSukatan.Width / 10
        picboxNFA.Left = pnlSukatan.Left + pnlSukatan.Width / 1.43
        picboxNFA.Top = pnlSukatan.Top + pnlSukatan.Height / 30

        lblNFA.Left = pnlSukatan.Left + pnlSukatan.Width / 2.8
        lblNFA.Top = pnlNFABanner.Top + pnlSukatan.Height / 70

        lblProvince.Left = pnlSukatan.Left + pnlSukatan.Width / 2.77
        lblProvince.Top = lblNFA.Bottom + pnlSukatan.Height / 80

        lblNameOfProject.Left = pnlSukatan.Left + pnlSukatan.Width / 3.03
        lblNameOfProject.Top = lblProvince.Bottom + pnlSukatan.Height / 80

        'Bottom Layout
        pnlBottom.Width = pnlSukatan.Width
        pnlBottom.Height = pnlSukatan.Height - pnlTop.Height
        pnlBottom.Left = pnlSukatan.Left
        pnlBottom.Top = pnlTop.Bottom

        picboxMandate.Width = pnlSukatan.Width / 3.4
        picboxMandate.Height = pnlSukatan.Height / 5
        picboxMandate.Left = pnlSukatan.Left + pnlSukatan.Width / 20
        picboxMandate.Top = pnlNFABanner.Bottom + pnlSukatan.Height / 40

        picboxMission.Width = pnlSukatan.Width / 3
        picboxMission.Height = pnlSukatan.Height / 5
        picboxMission.Left = pnlSukatan.Left + pnlSukatan.Width / 30
        picboxMission.Top = picboxMandate.Bottom + pnlSukatan.Height / 50

        picboxVision.Width = pnlSukatan.Width / 3
        picboxVision.Height = pnlSukatan.Height / 5
        picboxVision.Left = pnlSukatan.Left + pnlSukatan.Width / 30
        picboxVision.Top = picboxMission.Bottom + pnlSukatan.Height / 50

        picboxFront.Width = pnlSukatan.Width / 3
        picboxFront.Height = pnlSukatan.Height / 4
        picboxFront.Left = pnlSukatan.Left + pnlSukatan.Width / 1.9
        picboxFront.Top = pnlNFABanner.Bottom + pnlSukatan.Height / 40

        picboxLeft.Width = pnlSukatan.Width / 5
        picboxLeft.Height = pnlSukatan.Height / 6
        picboxLeft.Left = pnlSukatan.Left + pnlSukatan.Width / 2.3
        picboxLeft.Top = pnlNFABanner.Bottom + pnlSukatan.Height / 10

        picboxRight.Width = pnlSukatan.Width / 5
        picboxRight.Height = pnlSukatan.Height / 6
        picboxRight.Left = pnlSukatan.Left + pnlSukatan.Width / 1.33
        picboxRight.Top = pnlNFABanner.Bottom + pnlSukatan.Height / 10

        pnlLogIn.Width = pnlSukatan.Width / 2.3
        pnlLogIn.Height = pnlSukatan.Height / 2.8
        pnlLogIn.Left = pnlSukatan.Left + pnlSukatan.Width / 2.1
        pnlLogIn.Top = picboxFront.Bottom + pnlSukatan.Height / 25

        lblStatus.Left = pnlLogIn.Left + pnlLogIn.Width / 4.7
        lblStatus.Top = pnlLogIn.Top + pnlLogIn.Height / 25

        picboxUser.Left = pnlLogIn.Left + pnlLogIn.Width / 40
        picboxUser.Top = lblStatus.Bottom + pnlLogIn.Height / 25

        picboxPWord.Left = pnlLogIn.Left + pnlLogIn.Width / 40
        picboxPWord.Top = picboxUser.Bottom + pnlLogIn.Height / 25

        btnLogin.Left = pnlLogIn.Left + pnlLogIn.Width / 3.2
        btnLogin.Top = picboxPWord.Bottom + pnlLogIn.Height / 25

        cboID.Left = picboxUser.Right + pnlLogIn.Width / 30
        cboID.Top = picboxUser.Top + pnlLogIn.Height / 15

        InputPW.Left = picboxPWord.Right + pnlLogIn.Width / 30
        InputPW.Top = picboxUser.Bottom + pnlLogIn.Height / 15

        PicBoxWarning.Left = InputPW.Right + pnlLogIn.Width / 30
        PicBoxWarning.Top = picboxUser.Bottom + pnlLogIn.Height / 15

        lblStatus.Text = "Status"
        picboxFront.Image = New Bitmap(My.Resources.Banner1)
        picboxLeft.Image = New Bitmap(My.Resources.Banner2)
        picboxRight.Image = New Bitmap(My.Resources.Banner3)
        refreshlogin()
        Dim OpacityPercentage As Single
        OpacityPercentage = 0.3
        'To fade out the picturebox's opacity
        picboxLeft.Image = ChangeOpacity(picboxLeft.Image, OpacityPercentage)
        'To fade out the picturebox's opacity
        picboxRight.Image = ChangeOpacity(picboxRight.Image, OpacityPercentage)

        Timer2.Start()


        ProgressBar1.Hide()
        PicBoxWarning.Hide()
    End Sub
    Public Sub refreshlogin()
        myConnToAccess = New SqlConnection("Data Source=MYDARKPC;Initial Catalog=NFA_Employee;Integrated Security=True")
        If Not myConnToAccess.State = ConnectionState.Open Then
            myConnToAccess.Open()
        End If
        ds = New DataSet
        tables = ds.Tables
        da = New SqlDataAdapter("SELECT Employee_Id from LogIn_Records", myConnToAccess)
        da.Fill(ds, "LogIn_Records")
        Dim view1 As New DataView(tables(0))
        With cboID


            .DataSource = ds.Tables("LogIn_Records")
            .DisplayMember = "Employee_Id"
            .ValueMember = "Employee_Id"
            .SelectedIndex = 0
            .AutoCompleteMode = AutoCompleteMode.None
            .AutoCompleteSource = AutoCompleteSource.ListItems

        End With
        myConnToAccess.Close()
    End Sub


    Public Sub SearchYesNO()
        If Not myConnToAccess.State = ConnectionState.Open Then
            myConnToAccess.Open()
        End If

        'the query:
        Dim cmd As SqlCommand = New SqlCommand("SELECT * FROM [LogIn_Records] WHERE [Employee_Id] = '" & cboID.Text & "'", myConnToAccess)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        ' the following variable is hold true if user is found, and false if user is not found ComboBox1.SelectedItem
        Dim userFound As Boolean = False
        ' the following variables will hold the user first and last name if found.
        Dim YesNo As String = ""
        'if found:
        While dr.Read
            userFound = True
            YesNo = dr("YesNo").ToString
        End While

        'checking the result


        If userFound = True Then
            If YesNo = "0" Then
                btnLogin.Text = "               Log In"
            Else
                btnLogin.Text = "               Log Out"
            End If


        Else

        End If
        myConnToAccess.Close()
    End Sub

    Public Shared Function ChangeOpacity(ByVal img As Image, ByVal opacityvalue As Single) As Bitmap

        Dim bmp As New Bitmap(img.Width, img.Height)
        Dim graphics__1 As Graphics = Graphics.FromImage(bmp)
        Dim colormatrix As New ColorMatrix
        colormatrix.Matrix33 = opacityvalue
        Dim imgAttribute As New ImageAttributes
        imgAttribute.SetColorMatrix(colormatrix, ColorMatrixFlag.[Default], ColorAdjustType.Bitmap)
        graphics__1.DrawImage(img, New Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, img.Width, img.Height,
         GraphicsUnit.Pixel, imgAttribute)
        graphics__1.Dispose()
        Return bmp

    End Function

    Public Sub closeq()
        Close()
    End Sub

    Private Sub OvalShape3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Application.Exit()
    End Sub


    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(35)
        Try
            Cursor.Current = Cursors.WaitCursor
            If ProgressBar1.Value = ProgressBar1.Maximum Then

                Timer1.Stop()
                ' MessageBox.Show("LogIn Complete!", "")

                MainForm.Show()

                Me.Close()




            End If
            Cursor.Current = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.ToString & vbCrLf & ex.Message & vbCrLf & ex.StackTrace)
        End Try
    End Sub

    Private Sub Timer2_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Dim OpacityPercentage As Single
        OpacityPercentage = 0.3




        If a = 1 Then
            picboxFront.Image = New Bitmap(My.Resources.Banner2)
            picboxLeft.Image = New Bitmap(My.Resources.Banner3)
            picboxRight.Image = New Bitmap(My.Resources.Banner1)
            a = 2
            'To fade out the picturebox's opacity
            picboxLeft.Image = ChangeOpacity(picboxLeft.Image, OpacityPercentage)
            'To fade out the picturebox's opacity
            picboxRight.Image = ChangeOpacity(picboxRight.Image, OpacityPercentage)
        ElseIf a = 2 Then
            'PictureBox3.Image.Dispose()
            'PictureBox4.Image.Dispose()
            'PictureBox5.Image.Dispose()
            picboxFront.Image = New Bitmap(My.Resources.Banner3)
            picboxLeft.Image = New Bitmap(My.Resources.Banner1)
            picboxRight.Image = New Bitmap(My.Resources.Banner2)
            a = 0
            'To fade out the picturebox's opacity
            picboxLeft.Image = ChangeOpacity(picboxLeft.Image, OpacityPercentage)
            'To fade out the picturebox's opacity
            picboxRight.Image = ChangeOpacity(picboxRight.Image, OpacityPercentage)
        ElseIf a = 0 Then
            'PictureBox3.Image.Dispose()
            'PictureBox4.Image.Dispose()
            'PictureBox5.Image.Dispose()
            picboxFront.Image = New Bitmap(My.Resources.Banner1)
            picboxLeft.Image = New Bitmap(My.Resources.Banner2)
            picboxRight.Image = New Bitmap(My.Resources.Banner3)
            a = 1
            'To fade out the picturebox's opacity
            picboxLeft.Image = ChangeOpacity(picboxLeft.Image, OpacityPercentage)
            'To fade out the picturebox's opacity
            picboxRight.Image = ChangeOpacity(picboxRight.Image, OpacityPercentage)
        End If
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        lblStatus.Text = TimeOfDay
    End Sub

    Private Sub Timer4_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        Timer4.Stop()
        Timer3.Start()
    End Sub



    Private Sub btnLogin_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Try
            Cursor.Current = Cursors.WaitCursor

            If Not myConnToAccess.State = ConnectionState.Open Then
                myConnToAccess.Open()
            End If

            'the query:
            Dim cmd As SqlCommand = New SqlCommand("SELECT * FROM [LogIn_Records] WHERE [Employee_Id] = '" & cboID.Text & "' AND [Employee_Password] = '" & InputPW.Text & "'", myConnToAccess)
            Dim dr As SqlDataReader = cmd.ExecuteReader
            ' the following variable is hold true if user is found, and false if user is not found ComboBox1.SelectedItem
            Dim userFound As Boolean = False
            ' the following variables will hold the user first and last name if found.
            Dim ID As String = ""
            Dim PW As String = ""
            Dim YesNo As String = ""
            'if found:
            While dr.Read
                userFound = True
                ID = dr("Employee_Id").ToString
                PW = dr("Employee_Password").ToString
                YesNo = dr("YesNo").ToString

            End While

            myConnToAccess.Close()
            'checking the result


            If userFound = True Then
                If ID = "Admin" Then
                    Timer1.Start()
                    '    ProgressBar1.Show()
                    lblStatus.Text = "Successfully Loged In"

                Else
                    If YesNo = "0" Then

                        AddingForm.lblYesNo.Text = "1"
                        Dim cmdd As New SqlCommand
                        If Not myConnToAccess.State = ConnectionState.Open Then
                            myConnToAccess.Open()
                        End If
                        cmd.CommandText = "UPDATE [LogIn_Records] SET " &
                             "[YesNo] ='" & AddingForm.lblYesNo.Text _
                            & "' WHERE [Employee_Id] =  '" & cboID.Text & "'"
                        cmd.ExecuteNonQuery()
                        myConnToAccess.Close()
                        lblStatus.Text = "Successfully Loged In"
                        SearchYesNO()
                    ElseIf YesNo = "1" Then

                        AddingForm.lblYesNo.Text = "0"
                        Dim cmdd As New SqlCommand
                        If Not myConnToAccess.State = ConnectionState.Open Then
                            myConnToAccess.Open()
                        End If
                        cmd.CommandText = "UPDATE [LogIn_Records] SET " &
                             "[YesNo] ='" & AddingForm.lblYesNo.Text _
                            & "' WHERE [Employee_Id] =  '" & cboID.Text & "'"
                        cmd.ExecuteNonQuery()
                        myConnToAccess.Close()
                        SearchYesNO()
                        lblStatus.Text = "Successfully Loged Out"
                    End If
                End If
                Timer3.Stop()
                Timer4.Start()
                InputPW.Text = ""
                PicBoxWarning.Hide()

            Else
                InputPW.Focus()
                InputPW.Text = ""
                PicBoxWarning.Show()
                lblStatus.Text = "Invalid Employee_Password!"

                InputPW.ResetText()
                Timer3.Stop()
                Timer4.Start()

            End If

            Cursor.Current = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.ToString & vbCrLf & ex.Message & vbCrLf & ex.StackTrace)
        End Try
    End Sub

    Private Sub cboID_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboID.SelectedIndexChanged
        SearchYesNO()
    End Sub

    Private Sub pnlNFABanner_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub picboxSara_Click(sender As Object, e As EventArgs) Handles picboxSara.Click
        Application.Exit()
    End Sub


End Class