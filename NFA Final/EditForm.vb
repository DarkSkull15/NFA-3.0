Imports System.Data.SqlClient

Public Class EditForm
    Dim MyConnq As SQLConnection
    Dim ds As DataSet
    Dim da As SQLDataAdapter
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource


    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim number As Integer = cboSGrade.SelectedItem
        Dim salary, a, b, rate As Integer
        a = 20
        b = 9


        Select Case number
            Case 1
                txtSalary.Text = "9,981"
                salary = 9981
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 2
                txtSalary.Text = "10,667"
                salary = 10667
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 3
                txtSalary.Text = "11,387"
                salary = 11387
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 4
                txtSalary.Text = "12,155"
                salary = 12155
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 5
                txtSalary.Text = "12,975"
                salary = 12975
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 6
                txtSalary.Text = "13,851"
                salary = 13851
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 7
                txtSalary.Text = "14,785"
                salary = 14785
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 8
                txtSalary.Text = "15,818"
                salary = 15818
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 9
                txtSalary.Text = "16,986"
                salary = 16986
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 10
                txtSalary.Text = "18,217"
                salary = 18217
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 11
                txtSalary.Text = "19,620"
                salary = 19620
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 12
                txtSalary.Text = "21,387"
                salary = 21387
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 13
                txtSalary.Text = "23,257"
                salary = 23257
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 14
                txtSalary.Text = "25,290"
                salary = 25290
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 15
                txtSalary.Text = "27,565"
                salary = 27565
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 16
                txtSalary.Text = "30,044"
                salary = 30044
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 17
                txtSalary.Text = "32,747"
                salary = 32747
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 18
                txtSalary.Text = "35,693"
                salary = 35693
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 19
                txtSalary.Text = "39,151"
                salary = 39151
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 20
                txtSalary.Text = "43,250"
                salary = 43250
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 21
                txtSalary.Text = "47,779"
                salary = 47779
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 22
                txtSalary.Text = "52,783"
                salary = 52783
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 23
                txtSalary.Text = "58,310"
                salary = 58310
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 24
                txtSalary.Text = "64,416"
                salary = 64416
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 25
                txtSalary.Text = "71,476"
                salary = 71476
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 26
                txtSalary.Text = "78,960"
                salary = 78960
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 27
                txtSalary.Text = "87,229"
                salary = 87229
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 28
                txtSalary.Text = "96,363"
                salary = 96363
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 29
                txtSalary.Text = "106,454"
                salary = 106454
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 30
                txtSalary.Text = "117,601"
                salary = 117601
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 31
                txtSalary.Text = "152,325"
                salary = 152325
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 32
                txtSalary.Text = "177,929"
                salary = 177929
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 33
                txtSalary.Text = "215,804"
                salary = 215804
                rate = (salary / a) / b
                txtRate.Text = rate

            Case Else
                txtRate.Text = "error!"
                txtSalary.Text = ""
        End Select
        Dim WH, HA, HL, Absentq, RPHq, TS, aa As Integer
        Int32.TryParse(txtboWH.Text, WH)
        Int32.TryParse(txtboHA.Text, HA)
        Int32.TryParse(txtboHL.Text, HL)
        Int32.TryParse(txtRate.Text, RPHq)
        If HL > HA Then
            Absentq = 0
        Else
            Absentq = (HA - HL)
        End If
        aa = (WH - Absentq)
        TS = (RPHq * aa)
        txtboTS.Text = TS
    End Sub

    Private Sub EditForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        MyConnq = New SqlConnection("Data Source=MYDARKPC;Initial Catalog=NFA_Employee;Integrated Security=True")

        'layout
        Me.Width = MainForm.pnlTab.Width
        Me.Height = MainForm.pnlTab.Height
        Me.Left = MainForm.pnlTab.Left
        Me.Top = MainForm.pnlTab.Top

        pnlSukatan.Dock = DockStyle.Fill

        'Edit layout


        lblIDnumber.Left = pnlSukatan.Left + (pnlSukatan.Width / 45)
        lblIDnumber.Top = pnlSukatan.Top + (pnlSukatan.Width / 52)

        txtboID.Left = lblIDnumber.Right + (pnlSukatan.Width / 80)
        txtboID.Top = pnlSukatan.Top + (pnlSukatan.Width / 75)
        txtboID.Width = pnlSukatan.Width / 3

        lblPW.Left = txtboID.Right + (pnlSukatan.Width / 20)
        lblPW.Top = pnlSukatan.Top + (pnlSukatan.Width / 52)

        txtboPS.Left = lblPW.Right + (pnlSukatan.Width / 80)
        txtboPS.Top = pnlSukatan.Top + (pnlSukatan.Width / 75)
        txtboPS.Width = pnlSukatan.Width / 3

        lblName.Left = pnlSukatan.Left + (pnlSukatan.Width / 55)
        lblName.Top = txtboID.Bottom + (pnlSukatan.Width / 37)

        txtboLName.Left = txtboID.Left - (pnlSukatan.Width / 23)
        txtboLName.Top = txtboID.Bottom + (pnlSukatan.Width / 45)
        txtboLName.Width = pnlSukatan.Width / 3.5

        lblLName.Left = txtboLName.Left + (pnlSukatan.Width / 10)
        lblLName.Top = txtboLName.Bottom + (pnlSukatan.Width / 150)

        txtboFName.Left = txtboLName.Right + (pnlSukatan.Width / 80)
        txtboFName.Top = txtboID.Bottom + (pnlSukatan.Width / 45)
        txtboFName.Width = pnlSukatan.Width / 3.5

        lblFName.Left = txtboFName.Left + (pnlSukatan.Width / 10)
        lblFName.Top = txtboLName.Bottom + (pnlSukatan.Width / 150)

        txtboMName.Left = txtboFName.Right + (pnlSukatan.Width / 80)
        txtboMName.Top = txtboID.Bottom + (pnlSukatan.Width / 45)
        txtboMName.Width = pnlSukatan.Width / 3.5

        lblMName.Left = txtboMName.Left + (pnlSukatan.Width / 10)
        lblMName.Top = txtboLName.Bottom + (pnlSukatan.Width / 150)
        '  Adrress Layout-------------------------------------------------------------
        lblAddress.Left = pnlSukatan.Left + (pnlSukatan.Width / 50)
        lblAddress.Top = lblLName.Bottom + (pnlSukatan.Width / 37)

        txtboBarangay.Left = lblAddress.Right + (pnlSukatan.Width / 80)
        txtboBarangay.Top = lblLName.Bottom + (pnlSukatan.Width / 45)
        txtboBarangay.Width = pnlSukatan.Width / 3.6

        lblBrgy.Left = txtboBarangay.Left + (pnlSukatan.Width / 10)
        lblBrgy.Top = txtboBarangay.Bottom + (pnlSukatan.Width / 150)

        txtboTown.Left = txtboBarangay.Right + (pnlSukatan.Width / 80)
        txtboTown.Top = lblFName.Bottom + (pnlSukatan.Width / 45)
        txtboTown.Width = pnlSukatan.Width / 3.6

        lblTown.Left = txtboTown.Left + (pnlSukatan.Width / 10)
        lblTown.Top = txtboTown.Bottom + (pnlSukatan.Width / 150)

        cboProvince.Left = txtboTown.Right + (pnlSukatan.Width / 80)
        cboProvince.Top = lblMName.Bottom + (pnlSukatan.Width / 45)
        cboProvince.Width = pnlSukatan.Width / 3.6

        lblProvince.Left = cboProvince.Left + (pnlSukatan.Width / 10)
        lblProvince.Top = cboProvince.Bottom + (pnlSukatan.Width / 150)

        'Salary Layout---------------------------------------------------------------
        lblSalaryGrade.Left = pnlSukatan.Left + (pnlSukatan.Width / 40)
        lblSalaryGrade.Top = lblBrgy.Bottom + (pnlSukatan.Width / 37)

        cboSGrade.Left = lblSalaryGrade.Right + (pnlSukatan.Width / 80)
        cboSGrade.Top = lblBrgy.Bottom + (pnlSukatan.Width / 45)

        lblPesoSign.Left = cboSGrade.Right + (pnlSukatan.Width / 30)
        lblPesoSign.Top = lblBrgy.Bottom + (pnlSukatan.Width / 37)

        txtSalary.Left = lblPesoSign.Right + (pnlSukatan.Width / 80)
        txtSalary.Top = lblBrgy.Bottom + (pnlSukatan.Width / 45)

        lblRate.Left = txtSalary.Right + (pnlSukatan.Width / 30)
        lblRate.Top = lblBrgy.Bottom + (pnlSukatan.Width / 37)

        txtRate.Left = lblRate.Right + (pnlSukatan.Width / 80)
        txtRate.Top = lblBrgy.Bottom + (pnlSukatan.Width / 45)

        lblbWorkHours.Left = txtRate.Right + (pnlSukatan.Width / 30)
        lblbWorkHours.Top = lblBrgy.Bottom + (pnlSukatan.Width / 37)

        txtboWH.Left = lblbWorkHours.Right + (pnlSukatan.Width / 80)
        txtboWH.Top = lblBrgy.Bottom + (pnlSukatan.Width / 45)
        '--------------------------------------------------------


        lblHrsLeave.Left = pnlSukatan.Left + (pnlSukatan.Width / 15)
        lblHrsLeave.Top = cboSGrade.Bottom + (pnlSukatan.Width / 37)

        txtboHL.Left = lblHrsLeave.Right + (pnlSukatan.Width / 80)
        txtboHL.Top = cboSGrade.Bottom + (pnlSukatan.Width / 45)

        lblHrsAbsent.Left = txtboHL.Right + (pnlSukatan.Width / 25)
        lblHrsAbsent.Top = cboSGrade.Bottom + (pnlSukatan.Width / 37)

        txtboHA.Left = lblHrsAbsent.Right + (pnlSukatan.Width / 80)
        txtboHA.Top = cboSGrade.Bottom + (pnlSukatan.Width / 45)

        lblTotalSalary.Left = txtboHA.Right + (pnlSukatan.Width / 25)
        lblTotalSalary.Top = cboSGrade.Bottom + (pnlSukatan.Width / 37)

        txtboTS.Left = lblTotalSalary.Right + (pnlSukatan.Width / 80)
        txtboTS.Top = cboSGrade.Bottom + (pnlSukatan.Width / 45)
    End Sub

    Public Sub Updateq()
        Dim a As Integer

        If txtboPS.Text = "" Then
            txtboPS.Focus()
        ElseIf txtboLName.Text = "" Then
            txtboLName.Focus()
        ElseIf txtboFName.Text = "" Then
            txtboFName.Focus()
        ElseIf txtboMName.Text = "" Then
            txtboMName.Focus()
        ElseIf txtboBarangay.Text = "" Then
            txtboBarangay.Focus()
        ElseIf txtboTown.Text = "" Then
            txtboTown.Focus()
        ElseIf cboProvince.Text = "" Then
            cboProvince.Focus()
        ElseIf txtboWH.Text = "" Then
            txtboWH.Focus()
        ElseIf Double.TryParse(txtboWH.Text, a) = False Then
            txtboWH.Focus()

        ElseIf Double.TryParse(txtboHA.Text, a) = False Then
            txtboHA.Focus()

        ElseIf Double.TryParse(txtboHL.Text, a) = False Then
            txtboHL.Focus()


        Else
            Dim cmd As New SqlCommand
            If Not MyConnq.State = ConnectionState.Open Then
                MyConnq.Open()
            End If
            cmd.Connection = MyConnq
            cmd.CommandText = "UPDATE Employee_Records SET " &
                            "Employee_Id ='" & txtboID.Text _
                            & "',Employee_Password ='" & txtboPS.Text _
                            & "',LastName ='" & txtboLName.Text _
                            & "',FirstName ='" & txtboFName.Text _
                            & "',MiddleName ='" & txtboMName.Text _
                            & "',Barangay ='" & txtboBarangay.Text _
                            & "',City_Town ='" & txtboTown.Text _
                            & "',Province ='" & cboProvince.Text _
                            & "',Salary_Grade ='" & cboSGrade.Text _
                            & "',Salary_Rate ='" & txtSalary.Text _
                            & "',Rate_Per_Hour ='" & txtRate.Text _
                            & "',Working_Hour ='" & txtboWH.Text _
                            & "',Total_Absent ='" & txtboHA.Text _
                            & "',Total_Leave ='" & txtboHL.Text _
                            & "',Total_Salary ='" & txtboTS.Text &
                            "' WHERE [List] =" & CInt(Form1.DataGridView1.SelectedCells(15).Value)
            cmd.ExecuteNonQuery()



            cmd.CommandText = "UPDATE [LogIn_Records] SET " &
                             "[Employee_Id] ='" & txtboID.Text _
                            & "',[Employee_Password] ='" & txtboPS.Text _
                            & "' WHERE [List] =" & CInt(Form1.DataGridView1.SelectedCells(15).Value)
            cmd.ExecuteNonQuery()


            MyConnq.Close()

            MainForm.Updatetable()

            MainForm.lblStatus.Text = "Record Updated"
            displayform(Form1, MainForm.pnlTab)

            MainForm.btnDlete.Enabled = True
            MainForm.btnEdt.Enabled = True
            MainForm.btnPayrol.Enabled = True
            MainForm.btnPrint.Enabled = True
            MainForm.btnAdd.Enabled = True
            MainForm.btnSave.Enabled = False
            MainForm.btnReset.Enabled = False
        End If

    End Sub

    Private Sub pnlSukatan_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer2_Tick_1(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim number As Integer = cboSGrade.SelectedItem
        Dim salary, a, b, rate As Integer
        a = 20
        b = 9


        Select Case number
            Case 1
                txtSalary.Text = "9,981"
                salary = 9981
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 2
                txtSalary.Text = "10,667"
                salary = 10667
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 3
                txtSalary.Text = "11,387"
                salary = 11387
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 4
                txtSalary.Text = "12,155"
                salary = 12155
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 5
                txtSalary.Text = "12,975"
                salary = 12975
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 6
                txtSalary.Text = "13,851"
                salary = 13851
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 7
                txtSalary.Text = "14,785"
                salary = 14785
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 8
                txtSalary.Text = "15,818"
                salary = 15818
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 9
                txtSalary.Text = "16,986"
                salary = 16986
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 10
                txtSalary.Text = "18,217"
                salary = 18217
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 11
                txtSalary.Text = "19,620"
                salary = 19620
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 12
                txtSalary.Text = "21,387"
                salary = 21387
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 13
                txtSalary.Text = "23,257"
                salary = 23257
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 14
                txtSalary.Text = "25,290"
                salary = 25290
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 15
                txtSalary.Text = "27,565"
                salary = 27565
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 16
                txtSalary.Text = "30,044"
                salary = 30044
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 17
                txtSalary.Text = "32,747"
                salary = 32747
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 18
                txtSalary.Text = "35,693"
                salary = 35693
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 19
                txtSalary.Text = "39,151"
                salary = 39151
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 20
                txtSalary.Text = "43,250"
                salary = 43250
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 21
                txtSalary.Text = "47,779"
                salary = 47779
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 22
                txtSalary.Text = "52,783"
                salary = 52783
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 23
                txtSalary.Text = "58,310"
                salary = 58310
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 24
                txtSalary.Text = "64,416"
                salary = 64416
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 25
                txtSalary.Text = "71,476"
                salary = 71476
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 26
                txtSalary.Text = "78,960"
                salary = 78960
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 27
                txtSalary.Text = "87,229"
                salary = 87229
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 28
                txtSalary.Text = "96,363"
                salary = 96363
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 29
                txtSalary.Text = "106,454"
                salary = 106454
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 30
                txtSalary.Text = "117,601"
                salary = 117601
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 31
                txtSalary.Text = "152,325"
                salary = 152325
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 32
                txtSalary.Text = "177,929"
                salary = 177929
                rate = (salary / a) / b
                txtRate.Text = rate

            Case 33
                txtSalary.Text = "215,804"
                salary = 215804
                rate = (salary / a) / b
                txtRate.Text = rate

            Case Else
                txtRate.Text = "error!"
                txtSalary.Text = ""
        End Select
        Dim WH, HA, HL, Absentq, RPHq, TS, aa As Integer
        Int32.TryParse(txtboWH.Text, WH)
        Int32.TryParse(txtboHA.Text, HA)
        Int32.TryParse(txtboHL.Text, HL)
        Int32.TryParse(txtRate.Text, RPHq)
        If HL > HA Then
            Absentq = 0
        Else
            Absentq = (HA - HL)
        End If
        aa = (WH - Absentq)
        TS = (RPHq * aa)
        txtboTS.Text = TS
    End Sub

End Class