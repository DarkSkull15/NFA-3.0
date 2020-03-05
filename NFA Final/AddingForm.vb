Imports System.Data.SqlClient
Public Class AddingForm

    Dim MyConnq As SqlConnection
    Dim ds As DataSet
    Dim da As SqlDataAdapter
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource


    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
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
    End Sub

    Private Sub AddingForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MyConnq = New SqlConnection("Data Source=MYDARKPC;Initial Catalog=NFA_Employee;Integrated Security=True")
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        'cboSGrade.SelectedIndex = 0

        'layout
        Me.Width = MainForm.pnlTab.Width
        Me.Height = MainForm.pnlTab.Height
        Me.Left = MainForm.pnlTab.Left
        Me.Top = MainForm.pnlTab.Top

        pnlSukatan.Dock = DockStyle.Fill

        'Edit layout


        lblIDnumber.Left = pnlSukatan.Left + (pnlSukatan.Width / 55)
        lblIDnumber.Top = pnlSukatan.Top + (pnlSukatan.Width / 22.5)

        txtboID.Left = lblIDnumber.Right + (pnlSukatan.Width / 80)
        txtboID.Top = pnlSukatan.Top + (pnlSukatan.Width / 25)
        txtboID.Width = pnlSukatan.Width / 3

        lblPW.Left = txtboID.Right + (pnlSukatan.Width / 20)
        lblPW.Top = pnlSukatan.Top + (pnlSukatan.Width / 22.5)

        txtboPS.Left = lblPW.Right + (pnlSukatan.Width / 80)
        txtboPS.Top = pnlSukatan.Top + (pnlSukatan.Width / 25)
        txtboPS.Width = pnlSukatan.Width / 3

        lblName.Left = pnlSukatan.Left + (pnlSukatan.Width / 55)
        lblName.Top = txtboID.Bottom + (pnlSukatan.Width / 31)

        txtboLName.Left = txtboID.Left - (pnlSukatan.Width / 23)
        txtboLName.Top = txtboID.Bottom + (pnlSukatan.Width / 35)
        txtboLName.Width = pnlSukatan.Width / 3.5

        lblLname.Left = txtboLName.Left + (pnlSukatan.Width / 10)
        lblLname.Top = txtboLName.Bottom + (pnlSukatan.Width / 150)

        txtboFName.Left = txtboLName.Right + (pnlSukatan.Width / 80)
        txtboFName.Top = txtboID.Bottom + (pnlSukatan.Width / 35)
        txtboFName.Width = pnlSukatan.Width / 3.5

        lblFname.Left = txtboFName.Left + (pnlSukatan.Width / 10)
        lblFname.Top = txtboLName.Bottom + (pnlSukatan.Width / 150)

        txtboMName.Left = txtboFName.Right + (pnlSukatan.Width / 80)
        txtboMName.Top = txtboID.Bottom + (pnlSukatan.Width / 35)
        txtboMName.Width = pnlSukatan.Width / 3.5

        lblMname.Left = txtboMName.Left + (pnlSukatan.Width / 10)
        lblMname.Top = txtboLName.Bottom + (pnlSukatan.Width / 150)
        '  Adrress Layout-------------------------------------------------------------

        lblAddress.Left = pnlSukatan.Left + (pnlSukatan.Width / 55)
        lblAddress.Top = lblLname.Bottom + (pnlSukatan.Width / 31)

        txtboBarangay.Left = lblAddress.Right + (pnlSukatan.Width / 90)
        txtboBarangay.Top = lblLname.Bottom + (pnlSukatan.Width / 35)
        txtboBarangay.Width = pnlSukatan.Width / 3.6

        lblBrgy.Left = txtboBarangay.Left + (pnlSukatan.Width / 10)
        lblBrgy.Top = txtboBarangay.Bottom + (pnlSukatan.Width / 150)

        txtboTown.Left = txtboBarangay.Right + (pnlSukatan.Width / 80)
        txtboTown.Top = lblFname.Bottom + (pnlSukatan.Width / 35)
        txtboTown.Width = pnlSukatan.Width / 3.6

        lblTown.Left = txtboTown.Left + (pnlSukatan.Width / 10)
        lblTown.Top = txtboTown.Bottom + (pnlSukatan.Width / 150)

        cboProvince.Left = txtboTown.Right + (pnlSukatan.Width / 80)
        cboProvince.Top = lblMname.Bottom + (pnlSukatan.Width / 35)
        cboProvince.Width = pnlSukatan.Width / 3.6

        lblProvince.Left = cboProvince.Left + (pnlSukatan.Width / 10)
        lblProvince.Top = cboProvince.Bottom + (pnlSukatan.Width / 150)

        'Salary Layout---------------------------------------------------------------
        lblSalaryGrade.Left = pnlSukatan.Left + (pnlSukatan.Width / 10)
        lblSalaryGrade.Top = lblBrgy.Bottom + (pnlSukatan.Width / 31)

        cboSGrade.Left = lblSalaryGrade.Right + (pnlSukatan.Width / 80)
        cboSGrade.Top = lblBrgy.Bottom + (pnlSukatan.Width / 35)

        lblPesoSign.Left = cboSGrade.Right + (pnlSukatan.Width / 10)
        lblPesoSign.Top = lblBrgy.Bottom + (pnlSukatan.Width / 31)

        txtSalary.Left = lblPesoSign.Right + (pnlSukatan.Width / 80)
        txtSalary.Top = lblBrgy.Bottom + (pnlSukatan.Width / 35)

        lblRate.Left = txtSalary.Right + (pnlSukatan.Width / 10)
        lblRate.Top = lblBrgy.Bottom + (pnlSukatan.Width / 31)

        txtRate.Left = lblRate.Right + (pnlSukatan.Width / 80)
        txtRate.Top = lblBrgy.Bottom + (pnlSukatan.Width / 35)
    End Sub
    Public Sub Saveq()


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
        Else

            Dim cmd As New SqlCommand
            If Not MyConnq.State = ConnectionState.Open Then
                MyConnq.Open()
            End If
            cmd.Connection = MyConnq

            cmd.CommandText = "INSERT INTO Employee_Records (Employee_Id,Employee_Password,LastName,FirstName,MiddleName,Barangay,City_Town,Province,Salary_Grade,Salary_Rate,Rate_Per_hour)" &
               "VALUES('" & Me.txtboID.Text _
               & "','" & Me.txtboPS.Text _
               & "','" & Me.txtboLName.Text _
                & "','" & Me.txtboFName.Text _
                & "','" & Me.txtboMName.Text _
               & "','" & Me.txtboBarangay.Text _
                & "','" & Me.txtboTown.Text _
                & "','" & Me.cboProvince.Text _
                & "','" & Me.cboSGrade.Text _
                 & "','" & Me.txtSalary.Text _
                & "','" & Me.txtRate.Text & "')"
            cmd.ExecuteNonQuery()

            cmd.CommandText = "INSERT INTO [LogIn_Records] ([Employee_Id],[Employee_Password], [YesNo])" &
              "VALUES('" & Me.txtboID.Text _
              & "','" & Me.txtboPS.Text _
             & "','" & Me.lblYesNo.Text & "')"
            cmd.ExecuteNonQuery()
            MainForm.lblStatus.Text = "Record Added"




            MyConnq.Close()
            MainForm.Updatetable()

            displayform(Form1, MainForm.pnlTab)
            MainForm.reset()

            MainForm.btnDlete.Enabled = True
            MainForm.btnEdt.Enabled = True
            MainForm.btnPayrol.Enabled = True
            MainForm.btnPrint.Enabled = True
            MainForm.btnAdd.Enabled = True
            MainForm.btnSave.Enabled = False
            MainForm.btnReset.Enabled = False
        End If


    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub
    Private Sub cboProvince_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub


    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtboID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class