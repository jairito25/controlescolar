Imports System.Windows.Forms

Public Class MDIParent1

    
    Private Sub MDIParent1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With Me
            '.ToolsMenu.Enabled = True
            ' .NuevoToolStripMenuItem1.Enabled = True
        End With
    End Sub

    
    Private Sub EditMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditMenu.Click
        Dim frm As New Aulas()
        frm.MdiParent = Me
        frm.Dock = DockStyle.Fill
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub ALumnos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ALumnos.Click
        Dim frm As New Alumnos()
        frm.MdiParent = Me
        frm.Dock = DockStyle.Fill
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim frm As New Alumnos()
        'frm.MdiParent = Me
        'frm.Dock = DockStyle.Fill
        'frm.WindowState = FormWindowState.Maximized
        'frm.Show()
    End Sub

    'Private Sub NuevoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem1.Click
    ' Dim frm As New Profesores()
    'frm.MdiParent = Me
    'frm.Dock = DockStyle.Fill
    'frm.WindowState = FormWindowState.Maximized
    'frm.Show()
    'End Sub


    Private Sub OptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New Materias()
        frm.MdiParent = Me
        frm.Dock = DockStyle.Fill
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub NuevoToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New Aulas()
        frm.MdiParent = Me
        frm.Dock = DockStyle.Fill
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'im frm As New Profesores()
        'frm.MdiParent = Me
        'frm.Dock = DockStyle.Fill
        'frm.WindowState = FormWindowState.Maximized
        'frm.Show()
    End Sub

    Private Sub ViewMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewMenu.Click
        Dim frm As New Profesores()
        frm.MdiParent = Me
        frm.Dock = DockStyle.Fill
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub ToolsMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolsMenu.Click
        Dim frm As New Materias()
        frm.MdiParent = Me
        frm.Dock = DockStyle.Fill
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub HelpMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpMenu.Click
        'Dim frm As New Evaluacion()
        'frm.MdiParent = Me
        'frm.Dock = DockStyle.Fill
        'frm.WindowState = FormWindowState.Maximized
        'frm.Show()
    End Sub

    Private Sub AulasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AulasToolStripMenuItem.Click
        Dim frm As New Aulas()
        frm.MdiParent = Me
        frm.Dock = DockStyle.Fill
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub GruposToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GruposToolStripMenuItem.Click
        'Dim frm As New Grup()
        'frm.MdiParent = Me
        'frm.Dock = DockStyle.Fill
        'frm.WindowState = FormWindowState.Maximized
        'frm.Show()
    End Sub

    Private Sub CiclosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CiclosToolStripMenuItem.Click
        'Dim frm As New Ciclos()
        'frm.MdiParent = Me
        'frm.Dock = DockStyle.Fill
        'frm.WindowState = FormWindowState.Maximized
        'frm.Show()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuariosToolStripMenuItem.Click

    End Sub

    Private Sub ReportesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportesToolStripMenuItem.Click

    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click

    End Sub
End Class
