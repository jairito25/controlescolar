<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reportes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.GolaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GenerarReporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReporteDeGruposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GenerarReporteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ReporteProfesoresPorGrupoYCicloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GenerarReporteToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GolaToolStripMenuItem, Me.ReporteDeGruposToolStripMenuItem, Me.ReporteProfesoresPorGrupoYCicloToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1039, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GolaToolStripMenuItem
        '
        Me.GolaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerarReporteToolStripMenuItem})
        Me.GolaToolStripMenuItem.Name = "GolaToolStripMenuItem"
        Me.GolaToolStripMenuItem.Size = New System.Drawing.Size(110, 20)
        Me.GolaToolStripMenuItem.Text = "Reporte usuarios "
        '
        'GenerarReporteToolStripMenuItem
        '
        Me.GenerarReporteToolStripMenuItem.Name = "GenerarReporteToolStripMenuItem"
        Me.GenerarReporteToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.GenerarReporteToolStripMenuItem.Text = "generar reporte "
        '
        'ReporteDeGruposToolStripMenuItem
        '
        Me.ReporteDeGruposToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerarReporteToolStripMenuItem1})
        Me.ReporteDeGruposToolStripMenuItem.Name = "ReporteDeGruposToolStripMenuItem"
        Me.ReporteDeGruposToolStripMenuItem.Size = New System.Drawing.Size(205, 20)
        Me.ReporteDeGruposToolStripMenuItem.Text = "Reporte alumnos por grupo y ciclo "
        '
        'GenerarReporteToolStripMenuItem1
        '
        Me.GenerarReporteToolStripMenuItem1.Name = "GenerarReporteToolStripMenuItem1"
        Me.GenerarReporteToolStripMenuItem1.Size = New System.Drawing.Size(155, 22)
        Me.GenerarReporteToolStripMenuItem1.Text = "generar reporte"
        '
        'ReporteProfesoresPorGrupoYCicloToolStripMenuItem
        '
        Me.ReporteProfesoresPorGrupoYCicloToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerarReporteToolStripMenuItem2})
        Me.ReporteProfesoresPorGrupoYCicloToolStripMenuItem.Name = "ReporteProfesoresPorGrupoYCicloToolStripMenuItem"
        Me.ReporteProfesoresPorGrupoYCicloToolStripMenuItem.Size = New System.Drawing.Size(211, 20)
        Me.ReporteProfesoresPorGrupoYCicloToolStripMenuItem.Text = "Reporte profesores por grupo y ciclo"
        '
        'GenerarReporteToolStripMenuItem2
        '
        Me.GenerarReporteToolStripMenuItem2.Name = "GenerarReporteToolStripMenuItem2"
        Me.GenerarReporteToolStripMenuItem2.Size = New System.Drawing.Size(155, 22)
        Me.GenerarReporteToolStripMenuItem2.Text = "generar reporte"
        '
        'Reportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1039, 316)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Reportes"
        Me.Text = "Reportes"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents GolaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarReporteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReporteDeGruposToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarReporteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReporteProfesoresPorGrupoYCicloToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarReporteToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
End Class
