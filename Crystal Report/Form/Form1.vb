Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim report1 As New ReportDocument
        Dim str As String = "E:\VB.NET Functions Collection\Crystal Report\Crystal Report\Report Structure\CrystalReport1.rpt"
        report1.Load(str)
        report1.SetParameterValue("candidate", txt1.Text)
        report1.SetParameterValue("father", txt2.Text)
        report1.SetParameterValue("regno", txt3.Text)
        report1.SetParameterValue("roll", txt4.Text)
        report1.SetParameterValue("sem", txt5.Text)
        report1.SetParameterValue("session", txt6.Text)
        report1.SetParameterValue("year", txt7.Text)
        report1.SetParameterValue("in", txt9.Text)
        report1.SetParameterValue("exam", txt8.Text)
        Form2.CrystalReportViewer1.ReportSource = report1
        Form2.Show()
        txt1.Clear()
        txt2.Clear()
        txt3.Clear()
        txt4.Clear()
        txt5.Clear()
        txt6.Clear()
        txt7.Clear()
        txt8.Clear()
        txt9.Clear()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
