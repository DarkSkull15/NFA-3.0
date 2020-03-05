Imports System.Data.SqlClient

Imports Word = Microsoft.Office.Interop.Word
Public Class MainForm
    Dim IDInt As Integer

    Dim connString As String = "Data Source=MYDARKPC;Initial Catalog=NFA_Employee;Integrated Security=True"
    Dim MyConn As SqlConnection
    Dim da As SqlDataAdapter
    Dim ds As DataSet

    Dim tables As DataTableCollection
    Dim source1 As New BindingSource

    Public Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        'Me.WindowState = FormWindowState.Maximized

        'Layout
        pnlSukatan.Dock = DockStyle.Fill

        'Top Layout
        pnlTop.Width = pnlSukatan.Width
        pnlTop.Height = pnlSukatan.Height / 4.3
        pnlTop.Left = pnlSukatan.Left
        pnlTop.Top = pnlSukatan.Top

        picboxOccMin.Width = pnlSukatan.Width / 10
        picboxOccMin.Height = pnlSukatan.Width / 10
        picboxOccMin.Left = pnlSukatan.Left + pnlSukatan.Width / 5
        picboxOccMin.Top = pnlSukatan.Top + pnlSukatan.Height / 30

        picboxNFA.Width = pnlSukatan.Width / 10
        picboxNFA.Height = pnlSukatan.Width / 10
        picboxNFA.Left = pnlSukatan.Left + pnlSukatan.Width / 1.43
        picboxNFA.Top = pnlSukatan.Top + pnlSukatan.Height / 30

        lblNFA.Left = pnlSukatan.Left + pnlSukatan.Width / 2.8
        lblNFA.Top = pnlTop.Top + pnlSukatan.Height / 40

        lblProvince.Left = pnlSukatan.Left + pnlSukatan.Width / 2.77
        lblProvince.Top = lblNFA.Bottom + pnlSukatan.Height / 80

        lblNameOfProject.Left = pnlSukatan.Left + pnlSukatan.Width / 3.03
        lblNameOfProject.Top = lblProvince.Bottom + pnlSukatan.Height / 80

        ' Body left Layout
        pnlBodyLeft.Width = pnlSukatan.Width / 5.9
        pnlBodyLeft.Height = pnlSukatan.Height / 1.68
        pnlBodyLeft.Left = pnlSukatan.Left + pnlSukatan.Width / 400
        pnlBodyLeft.Top = pnlTop.Bottom + pnlSukatan.Width / 400

        btnSearch.Width = pnlSukatan.Width / 7
        btnSearch.Height = pnlSukatan.Height / 8
        btnSearch.Left = pnlBodyLeft.Left + pnlSukatan.Width / 73
        btnSearch.Top = pnlBodyLeft.Top + pnlSukatan.Width / 80

        btnAdd.Width = pnlSukatan.Width / 7
        btnAdd.Height = pnlSukatan.Height / 8
        btnAdd.Left = pnlBodyLeft.Left + pnlSukatan.Width / 73
        btnAdd.Top = btnSearch.Bottom + pnlSukatan.Width / 80

        btnEdt.Width = pnlSukatan.Width / 7
        btnEdt.Height = pnlSukatan.Height / 8
        btnEdt.Left = pnlBodyLeft.Left + pnlSukatan.Width / 73
        btnEdt.Top = btnAdd.Bottom + pnlSukatan.Width / 80

        btnDlete.Width = pnlSukatan.Width / 7
        btnDlete.Height = pnlSukatan.Height / 8
        btnDlete.Left = pnlBodyLeft.Left + pnlSukatan.Width / 73
        btnDlete.Top = btnEdt.Bottom + pnlSukatan.Width / 80

        'Bottom Layout
        pnlBottom.Width = pnlSukatan.Width
        pnlBottom.Height = pnlSukatan.Height / 5.9
        pnlBottom.Left = pnlSukatan.Left
        pnlBottom.Top = pnlBodyLeft.Bottom + pnlSukatan.Width / 400

        btnLogOut.Width = pnlSukatan.Width / 7
        btnLogOut.Height = pnlSukatan.Height / 8
        btnLogOut.Left = pnlBottom.Left + pnlSukatan.Width / 73
        btnLogOut.Top = pnlBottom.Top + pnlSukatan.Width / 80

        btnPayrol.Width = pnlSukatan.Width / 7
        btnPayrol.Height = pnlSukatan.Height / 8
        btnPayrol.Left = btnLogOut.Right + pnlSukatan.Width / 73
        btnPayrol.Top = pnlBottom.Top + pnlSukatan.Width / 80

        btnPrint.Width = pnlSukatan.Width / 7
        btnPrint.Height = pnlSukatan.Height / 8
        btnPrint.Left = btnPayrol.Right + pnlSukatan.Width / 73
        btnPrint.Top = pnlBottom.Top + pnlSukatan.Width / 80

        btnSave.Width = pnlSukatan.Width / 7
        btnSave.Height = pnlSukatan.Height / 8
        btnSave.Left = btnPrint.Right + pnlSukatan.Width / 73
        btnSave.Top = pnlBottom.Top + pnlSukatan.Width / 80

        btnReset.Width = pnlSukatan.Width / 7
        btnReset.Height = pnlSukatan.Height / 8
        btnReset.Left = btnSave.Right + pnlSukatan.Width / 73
        btnReset.Top = pnlBottom.Top + pnlSukatan.Width / 80

        pnlDateTime.Width = pnlSukatan.Width / 5.4
        pnlDateTime.Height = pnlSukatan.Height / 8
        pnlDateTime.Left = btnReset.Right + pnlSukatan.Width / 73
        pnlDateTime.Top = pnlBottom.Top + pnlSukatan.Width / 80

        lblTime.Left = pnlDateTime.Left + pnlSukatan.Width / 40
        lblTime.Top = pnlDateTime.Top + pnlSukatan.Width / 80

        lblDate.Left = pnlDateTime.Left + pnlSukatan.Width / 73
        lblDate.Top = lblTime.Bottom + pnlSukatan.Width / 80


        ' Body top Layout
        pnlBodyTop.Width = pnlSukatan.Width - (pnlBodyLeft.Width + (pnlSukatan.Width / 400) + (pnlSukatan.Width / 400) + (pnlSukatan.Width / 400))
        pnlBodyTop.Height = pnlSukatan.Height / 10
        pnlBodyTop.Left = pnlBodyLeft.Right + pnlSukatan.Width / 400
        pnlBodyTop.Top = pnlTop.Bottom + pnlSukatan.Width / 400

        lblEmployeeCount.Left = pnlBodyTop.Left + pnlSukatan.Width / 120
        lblEmployeeCount.Top = pnlBodyTop.Top + pnlSukatan.Width / 80

        lblStatus.Left = lblEmployeeCount.Right + pnlSukatan.Width / 120
        lblStatus.Top = pnlBodyTop.Top + pnlSukatan.Width / 80

        lblSearch.Left = lblStatus.Right + pnlSukatan.Width / 120
        lblSearch.Top = pnlBodyTop.Top + pnlSukatan.Width / 80

        lblBy.Left = lblStatus.Right + pnlSukatan.Width / 29
        lblBy.Top = lblSearch.Bottom + pnlSukatan.Width / 290

        cboSearch.Left = lblSearch.Right + pnlSukatan.Width / 250
        cboSearch.Top = pnlBodyTop.Top + pnlSukatan.Width / 80

        txtboxSearch.Left = cboSearch.Right + pnlSukatan.Width / 120
        txtboxSearch.Top = pnlBodyTop.Top + pnlSukatan.Width / 80

        ' Body Tab Layout
        pnlTab.Width = pnlSukatan.Width - (pnlBodyLeft.Width + (pnlSukatan.Width / 400) + (pnlSukatan.Width / 400) + (pnlSukatan.Width / 400))
        pnlTab.Height = pnlBodyLeft.Height - (pnlBodyTop.Height + (pnlSukatan.Width / 400))
        pnlTab.Left = pnlBodyLeft.Right + pnlSukatan.Width / 400
        pnlTab.Top = pnlBodyTop.Bottom + pnlSukatan.Width / 400

        cboSearch.SelectedIndex = 0
        displayform(Form1, pnlTab)
        MyConn = New SqlConnection
        MyConn.ConnectionString = connString

        Form1.DataGridView1.MultiSelect = False
        Form1.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Updatetable()
        lblStatus.Text = "Status"

    End Sub

    Public Sub Updatetable()
        If Not MyConn.State = ConnectionState.Open Then
            MyConn.Open()
        End If

        ds = New DataSet
        tables = ds.Tables
        da = New SqlDataAdapter("Select * from [Employee_Records]", MyConn) 'Change items to your database name
        da.Fill(ds, "Employee_Records") 'Change items to your database name

        Dim view As New DataView(tables(0))
        source1.DataSource = view
        Form1.DataGridView1.DataSource = view
        Form1.DataGridView1.Columns(0).Width = 200
        Form1.DataGridView1.Columns(1).Width = 150
        Form1.DataGridView1.Columns(2).Width = 150
        Form1.DataGridView1.Columns(3).Width = 150
        Form1.DataGridView1.Columns(4).Width = 150
        Form1.DataGridView1.Columns(5).Width = 150
        Form1.DataGridView1.Columns(6).Width = 150
        Form1.DataGridView1.Columns(7).Width = 150
        Form1.DataGridView1.Columns(8).Width = 150
        Form1.DataGridView1.Columns(9).Width = 100
        Form1.DataGridView1.Columns(10).Width = 150
        Form1.DataGridView1.Columns(11).Width = 100
        Form1.DataGridView1.Columns(12).Width = 100
        Form1.DataGridView1.Columns(13).Width = 100
        'Form1.DataGridView1.Columns(14).Width = 100
        'Form1.DataGridView1.Columns(15).Width = 150



        Form1.DataGridView1.Font = New Font("Lucida Sans Typewriter", 12)
        Form1.DataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Form1.DataGridView1.Columns("List").Visible = False
        Form1.DataGridView1.Columns("Employee_Id").HeaderText = "ID"
        Form1.DataGridView1.Columns("Employee_Password").HeaderText = "Password"
        Form1.DataGridView1.Columns("LastName").HeaderText = "Last Name"
        Form1.DataGridView1.Columns("FirstName").HeaderText = "First Name"
        Form1.DataGridView1.Columns("MiddleName").HeaderText = "Middle Name"
        Form1.DataGridView1.Columns("Barangay").HeaderText = "Baranggay"
        Form1.DataGridView1.Columns("City_Town").HeaderText = "City"
        Form1.DataGridView1.Columns("Province").HeaderText = "Province"
        Form1.DataGridView1.Columns("Salary_Grade").HeaderText = "Salary Grade"
        Form1.DataGridView1.Columns("Salary_Rate").HeaderText = "Salary Rate"
        Form1.DataGridView1.Columns("Rate_Per_Hour").HeaderText = "Rate per Hour"
        Form1.DataGridView1.Columns("Working_Hour").HeaderText = "Work Hours"
        Form1.DataGridView1.Columns("Total_Absent").HeaderText = "Total Hours Absent"
        Form1.DataGridView1.Columns("Total_Leave").HeaderText = "Total Hours Leave"
        Form1.DataGridView1.Columns("Total_Salary").HeaderText = "Total Salary"

        MyConn.Close()

        lblEmployeeCount.Text = ds.Tables(0).Rows.Count & " Employees "
        IDInt = ds.Tables(0).Rows.Count
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Public Sub reset()
        If btnSave.Text = "       Save" Then
            AddingForm.txtboPS.Text = ""
            AddingForm.txtboLName.Text = ""
            AddingForm.txtboFName.Text = ""
            AddingForm.txtboMName.Text = ""
            AddingForm.txtboBarangay.Text = ""
            AddingForm.txtboTown.Text = ""
            AddingForm.txtSalary.Text = ""
            AddingForm.txtRate.Text = ""
            AddingForm.cboSGrade.SelectedIndex = 0
            AddingForm.cboProvince.SelectedIndex = 0
        ElseIf btnSave.Text = "       Update" Then
            EditForm.txtboPS.Text = ""
            EditForm.txtboLName.Text = ""
            EditForm.txtboFName.Text = ""
            EditForm.txtboMName.Text = ""
            EditForm.txtboBarangay.Text = ""
            EditForm.txtboTown.Text = ""
            EditForm.txtSalary.Text = ""
            EditForm.txtRate.Text = ""
            EditForm.cboSGrade.SelectedIndex = 0
            EditForm.cboProvince.SelectedIndex = 0
            EditForm.txtboWH.Text = ""
            EditForm.txtboHA.Text = ""
            EditForm.txtboHL.Text = ""
            EditForm.txtboTS.Text = ""
        End If
    End Sub
    Private Function checkrecord()
        If Not MyConn.State = ConnectionState.Open Then
            MyConn.Open()
        End If
        Dim datactn As New SqlDataAdapter("Select * from [Employee_Records]", MyConn)
        Dim table As New DataTable
        datactn.Fill(table)
        Dim TotalRecord
        TotalRecord = table.Rows.Count
        Return (TotalRecord)
        MyConn.Close()
    End Function
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtboxSearch.TextChanged

        If Not MyConn.State = ConnectionState.Open Then
            MyConn.Open()
        End If
        If cboSearch.Text = "First Name" Then
            Dim da As New SqlDataAdapter("SELECT * from [Employee_Records] WHERE FirstName like " & "'%" & txtboxSearch.Text & "%'", MyConn)
            Dim dt As New DataTable
            da.Fill(dt)
            Form1.DataGridView1.DataSource = dt
            Form1.DataGridView1.Font = New Font("Times New Roman", 11)
            Form1.DataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            lblEmployeeCount.Text = dt.Rows.Count & " Employees "
        ElseIf cboSearch.Text = "Middle Name" Then
            Dim da As New SqlDataAdapter("SELECT * from [Employee_Records] WHERE MiddleName like " & "'%" & txtboxSearch.Text & "%'", MyConn)
            Dim dt As New DataTable
            da.Fill(dt)
            Form1.DataGridView1.DataSource = dt
            Form1.DataGridView1.Font = New Font("Times New Roman", 11)
            Form1.DataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            lblEmployeeCount.Text = dt.Rows.Count & " Employees "
        ElseIf cboSearch.Text = "Last Name" Then
            Dim da As New SqlDataAdapter("SELECT * from [Employee_Records] WHERE LastName like " & "'%" & txtboxSearch.Text & "%'", MyConn)
            Dim dt As New DataTable
            da.Fill(dt)
            Form1.DataGridView1.DataSource = dt
            Form1.DataGridView1.Font = New Font("Times New Roman", 11)
            Form1.DataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            lblEmployeeCount.Text = dt.Rows.Count & " Employees "
        ElseIf cboSearch.Text = "Barangay" Then
            Dim da As New SqlDataAdapter("SELECT * from [Employee_Records] WHERE Barangay like " & "'%" & txtboxSearch.Text & "%'", MyConn)
            Dim dt As New DataTable
            da.Fill(dt)
            Form1.DataGridView1.DataSource = dt
            Form1.DataGridView1.Font = New Font("Times New Roman", 11)
            Form1.DataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            lblEmployeeCount.Text = dt.Rows.Count & " Employees "
        ElseIf cboSearch.Text = "Town" Then
            Dim da As New SqlDataAdapter("SELECT * from [Employee_Records] WHERE City_Town like " & "'%" & txtboxSearch.Text & "%'", MyConn)
            Dim dt As New DataTable
            da.Fill(dt)
            Form1.DataGridView1.DataSource = dt
            Form1.DataGridView1.Font = New Font("Times New Roman", 11)
            Form1.DataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            lblEmployeeCount.Text = dt.Rows.Count & " Employees "
        ElseIf cboSearch.Text = "Province" Then
            Dim da As New SqlDataAdapter("SELECT * from [Employee_Records] WHERE Province like " & "'%" & txtboxSearch.Text & "%'", MyConn)
            Dim dt As New DataTable
            da.Fill(dt)
            Form1.DataGridView1.DataSource = dt
            Form1.DataGridView1.Font = New Font("Times New Roman", 11)
            Form1.DataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            lblEmployeeCount.Text = dt.Rows.Count & " Employees "
        ElseIf cboSearch.Text = "Salary Grade" Then
            Dim da As New SqlDataAdapter("SELECT * from [Employee_Records] WHERE Salary_Grade like " & "'%" & txtboxSearch.Text & "%'", MyConn)
            Dim dt As New DataTable
            da.Fill(dt)
            Form1.DataGridView1.DataSource = dt
            Form1.DataGridView1.Font = New Font("Times New Roman", 11)
            Form1.DataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            lblEmployeeCount.Text = dt.Rows.Count & " Employees "
        Else
            Updatetable()
        End If


    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click


        btnSave.Text = "       Save"
        AddingForm.txtboID.Text = "NFA-OCC-1010" & IDInt + 1
        AddingForm.Saveq()
        reset()
        displayform(AddingForm, pnlTab)
        btnDlete.Enabled = False
        btnEdt.Enabled = False
        btnPayrol.Enabled = False
        btnPrint.Enabled = False
        btnAdd.Enabled = False
        txtboxSearch.Enabled = False
        btnSave.Enabled = True
        btnReset.Enabled = True
    End Sub

    Private Sub btnEdt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdt.Click
        Dim record = checkrecord()
        Dim Salary_Grade As String
        Dim sgInt As Integer

        If Not record = 0 Then


            If Not MyConn.State = ConnectionState.Open Then
                MyConn.Open()
            End If
            EditForm.txtboID.Text = Form1.DataGridView1.SelectedCells(0).Value.ToString()
            EditForm.txtboPS.Text = Form1.DataGridView1.SelectedCells(1).Value.ToString()
            EditForm.txtboLName.Text = Form1.DataGridView1.SelectedCells(2).Value.ToString()
            EditForm.txtboFName.Text = Form1.DataGridView1.SelectedCells(3).Value.ToString()
            EditForm.txtboMName.Text = Form1.DataGridView1.SelectedCells(4).Value.ToString()
            EditForm.txtboBarangay.Text = Form1.DataGridView1.SelectedCells(5).Value.ToString()
            EditForm.txtboTown.Text = Form1.DataGridView1.SelectedCells(6).Value.ToString()
            EditForm.cboProvince.Text = Form1.DataGridView1.SelectedCells(7).Value.ToString()
            Salary_Grade = Form1.DataGridView1.SelectedCells(8).Value.ToString()
            EditForm.txtboWH.Text = Form1.DataGridView1.SelectedCells(11).Value.ToString()
            EditForm.txtboHA.Text = Form1.DataGridView1.SelectedCells(12).Value.ToString()
            EditForm.txtboHL.Text = Form1.DataGridView1.SelectedCells(13).Value.ToString()
            EditForm.txtboTS.Text = Form1.DataGridView1.SelectedCells(14).Value.ToString()
            Int32.TryParse(Salary_Grade, sgInt)
            EditForm.cboSGrade.SelectedIndex = sgInt - 1
            MyConn.Close()
        End If
        displayform(EditForm, pnlTab)
        btnSave.Text = "       Update"

        btnDlete.Enabled = False
        btnEdt.Enabled = False
        btnPayrol.Enabled = False
        btnPrint.Enabled = False
        btnAdd.Enabled = False
        txtboxSearch.Enabled = False
        btnSave.Enabled = True
        btnReset.Enabled = True
    End Sub

    Private Sub btnDlete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDlete.Click
        Form2.TextBox1.Text = ""

        Form2.ShowDialog()
    End Sub
    Public Sub Deleteq2()
        Dim record = checkrecord()
        If Not record = 0 Then
            If Not MyConn.State = ConnectionState.Open Then
                MyConn.Open()
            End If
            Dim newctn As New SqlCommand
            newctn.Connection = MyConn



            newctn.CommandText = "Delete from Employee_Records where List = " & CInt(Form1.DataGridView1.SelectedCells(15).Value)
            newctn.ExecuteNonQuery()
            newctn.CommandText = "Delete from [LogIn_Records] where List = " & CInt(Form1.DataGridView1.SelectedCells(15).Value)
            newctn.ExecuteNonQuery()
            MyConn.Close()
            reset()
            Updatetable()
            lblStatus.Text = ("Record Deleted")

        Else
            lblStatus.Text = "Table Empty!"
        End If
    End Sub
    Private Sub btnLogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogOut.Click
        LogInForm.refreshlogin()
        LogInForm.InputPW.Text = ""
        LogInForm.ProgressBar1.Value = 0
        LogInForm.ProgressBar1.Hide()

        Me.Hide()
        LogInForm.Show()
        LogInForm.PicBoxWarning.Hide()
        LogInForm.InputPW.Text = ""

    End Sub

    Private Sub Panel4_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlTop.Paint

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblDate.Text = Date.Now.ToString("MMMM dd,yyyy")
        lblTime.Text = TimeOfDay '.Now.ToString("hh:mm tt")
    End Sub


    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        reset()
    End Sub

    Private Sub btnSave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If btnSave.Text = "       Save" Then
            AddingForm.Saveq()
        ElseIf btnSave.Text = "       Update" Then
            EditForm.Updateq()
        End If
    End Sub

    Private Sub btnSearch_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        displayform(Form1, pnlTab)
        lblStatus.Text = "Status"

        txtboxSearch.Enabled = True
        Form1.DataGridView1.Columns("Employee_Id").Visible = True
        Form1.DataGridView1.Columns("Employee_Password").Visible = True
        Form1.DataGridView1.Columns("MiddleName").Visible = True
        Form1.DataGridView1.Columns("Barangay").Visible = True
        Form1.DataGridView1.Columns("City_Town").Visible = True
        Form1.DataGridView1.Columns("Province").Visible = True
        Form1.DataGridView1.Columns("Salary_Grade").Visible = True
        Form1.DataGridView1.Columns("Salary_Rate").Visible = True

        btnDlete.Enabled = True
        btnEdt.Enabled = True
        btnPayrol.Enabled = True
        btnPrint.Enabled = True
        btnAdd.Enabled = True
        btnSave.Enabled = False
        btnReset.Enabled = False
    End Sub

    Private Sub Panel6_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlBottom.Paint

    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim Salary_Grade As String
        Dim sgInt As Integer
        If Not MyConn.State = ConnectionState.Open Then
            MyConn.Open()
        End If
        EditForm.txtboID.Text = Form1.DataGridView1.SelectedCells(0).Value.ToString()
        EditForm.txtboPS.Text = Form1.DataGridView1.SelectedCells(1).Value.ToString()
        EditForm.txtboLName.Text = Form1.DataGridView1.SelectedCells(2).Value.ToString()
        EditForm.txtboFName.Text = Form1.DataGridView1.SelectedCells(3).Value.ToString()
        EditForm.txtboMName.Text = Form1.DataGridView1.SelectedCells(4).Value.ToString()
        EditForm.txtboBarangay.Text = Form1.DataGridView1.SelectedCells(5).Value.ToString()
        EditForm.txtboTown.Text = Form1.DataGridView1.SelectedCells(6).Value.ToString()
        EditForm.cboProvince.Text = Form1.DataGridView1.SelectedCells(7).Value.ToString()
        Salary_Grade = Form1.DataGridView1.SelectedCells(8).Value.ToString()
        Label11.Text = Form1.DataGridView1.SelectedCells(10).Value.ToString()
        EditForm.txtboWH.Text = Form1.DataGridView1.SelectedCells(11).Value.ToString()
        EditForm.txtboHA.Text = Form1.DataGridView1.SelectedCells(12).Value.ToString()
        EditForm.txtboHL.Text = Form1.DataGridView1.SelectedCells(13).Value.ToString()
        EditForm.txtboTS.Text = Form1.DataGridView1.SelectedCells(14).Value.ToString()
        Int32.TryParse(Salary_Grade, sgInt)
        EditForm.cboSGrade.SelectedIndex = sgInt - 1
        MyConn.Close()
        Label9.Text = EditForm.txtboLName.Text & ", " & EditForm.txtboFName.Text & " " & EditForm.txtboMName.Text
        Label10.Text = EditForm.txtboBarangay.Text & ", " & EditForm.txtboTown.Text & ", " & EditForm.cboProvince.Text

        Dim oWord As Word.Application
        Dim oDoc As Word.Document
        oWord = CreateObject("Word.Application")
        oWord.Visible = True
        'wd1 = New Word.Application
        'wd1.Visible = True
        'wd1Doc = wd1.Documents.Add(Application.StartupPath & "\NFA_Employee.dotx") 'example: "D:\profile.dot"
        oDoc = oWord.Documents.Add(Application.StartupPath & "\NFA_Employee.dotx")
        'wd1Doc = wd1.Documents.Add(Application.StartupPath & "\NFA_Employee.dotx") 'example: "D:\profile.dot"



        With oDoc
            .FormFields("w_date").Result = lblDate.Text  'In VS2010, property `Range` is Readonly. 
            .FormFields("w_ID").Result = EditForm.txtboID.Text 'You need to use `Result`
            .FormFields("w_name").Result = Label9.Text
            .FormFields("w_ADD").Result = Label10.Text
            .FormFields("w_sg").Result = EditForm.cboSGrade.Text
            .FormFields("w_RP").Result = Label11.Text
            .FormFields("w_THW").Result = EditForm.txtboWH.Text
            .FormFields("w_HA").Result = EditForm.txtboHA.Text
            .FormFields("w_HL").Result = EditForm.txtboHL.Text
            .FormFields("w_TS").Result = EditForm.txtboTS.Text

        End With
        ' wd1Doc.SaveAs("D:\Employees\" & txtLastName.Text & "" & txtFirstName.Text & ".DOC") 'Saves the Document

        'wd1 = Nothing 'Releasing References to Variable
        'wd1Doc = Nothing
        '---------------------------------------------------------------------
        EditForm.txtboPS.Text = ""
        EditForm.txtboLName.Text = ""
        EditForm.txtboFName.Text = ""
        EditForm.txtboMName.Text = ""
        EditForm.txtboBarangay.Text = ""
        EditForm.txtboTown.Text = ""
        EditForm.txtSalary.Text = ""
        EditForm.txtRate.Text = ""
        EditForm.cboSGrade.SelectedIndex = 0
        EditForm.cboProvince.SelectedIndex = 0
        EditForm.txtboWH.Text = ""
        EditForm.txtboHA.Text = ""
        EditForm.txtboHL.Text = ""
        EditForm.txtboTS.Text = ""
    End Sub

    Private Sub btnPayrol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPayrol.Click
        'Form1.DataGridView1.Columns("List").Visible = False
        Form1.DataGridView1.Columns("Employee_Id").Visible = False
        Form1.DataGridView1.Columns("Employee_Password").Visible = False
        Form1.DataGridView1.Columns("Barangay").Visible = False
        Form1.DataGridView1.Columns("City_Town").Visible = False
        Form1.DataGridView1.Columns("Province").Visible = False
        Form1.DataGridView1.Columns("Salary_Rate").Visible = False

        txtboxSearch.Enabled = False
        btnDlete.Enabled = False
        btnEdt.Enabled = False
        btnPayrol.Enabled = False
        'btnPrint.Enabled = False
        btnAdd.Enabled = False
    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlTab.Paint

    End Sub
End Class
