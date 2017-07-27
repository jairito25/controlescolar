Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class ProfesoresGC

    Private Sub ProfesoresGC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim obj As New CrystalReport3

        obj.SetParameterValue("grupo", TextBox1.Text)
        obj.SetParameterValue("ciclo", TextBox2.Text)

        CrystalReportViewer1.ReportSource = obj
        CrystalReportViewer1.Refresh()
    End Sub
End Class