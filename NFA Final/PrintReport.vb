Imports CrystalDecisions.Windows.Forms
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class PrintReport
    Private Sub PrintReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized



    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        Dim CurrenntReport As New Payrollq

        CurrenntReport.SetParameterValue("ID", "")
        CurrenntReport.SetParameterValue("Name", "")
        CurrenntReport.SetParameterValue("Address", "")
        CurrenntReport.SetParameterValue("SGrade", "")
        CurrenntReport.SetParameterValue("RpHour", "")
        CurrenntReport.SetParameterValue("TWHours", "")
        CurrenntReport.SetParameterValue("THAbsent", "")
        CurrenntReport.SetParameterValue("THLeave", "")
        CurrenntReport.SetParameterValue("TotalSalary", "")
        ' CurrenntReport.Refresh()
        CrystalReportViewer1.ReportSource = CurrenntReport
        ' CrystalReportViewer1.RefreshReport()
    End Sub

    Private Sub CrystalReportViewer1_ReportRefresh(source As Object, e As ViewerEventArgs) Handles CrystalReportViewer1.ReportRefresh
        'Dim CurrenntReportq As New Payrollq

        'CurrenntReportq.SetParameterValue("ID", EditForm.txtboID.Text)
        'CurrenntReportq.SetParameterValue("Name", MainForm.Label9.Text)
        'CurrenntReportq.SetParameterValue("Address", MainForm.Label10.Text)
        'CurrenntReportq.SetParameterValue("SGrade", EditForm.cboSGrade.Text)
        'CurrenntReportq.SetParameterValue("RpHour", MainForm.Label11.Text)
        'CurrenntReportq.SetParameterValue("TWHours", EditForm.txtboWH.Text)
        'CurrenntReportq.SetParameterValue("THAbsent", EditForm.txtboHA.Text)
        'CurrenntReportq.SetParameterValue("THLeave", EditForm.txtboHL.Text)
        'CurrenntReportq.SetParameterValue("TotalSalary", EditForm.txtboTS.Text)

        'CrystalReportViewer1.ReportSource = CurrenntReportq
    End Sub
End Class