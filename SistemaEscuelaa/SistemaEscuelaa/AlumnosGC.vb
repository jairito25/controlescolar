Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class AlumnosGC

    Private Sub AlumnosGC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim obj As New CrystalReport2

        obj.SetParameterValue("grupo", TextBox1.Text)
        obj.SetParameterValue("ciclo", TextBox2.text)

        CrystalReportViewer1.ReportSource = obj
        CrystalReportViewer1.Refresh()
    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class