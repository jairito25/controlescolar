Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class UsuariosR

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub

    Private Sub UsuariosR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub j_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles j.Click
        Dim obj As New CrystalReport1


        CrystalReportViewer1.ReportSource = obj
        CrystalReportViewer1.Refresh()
    End Sub
End Class