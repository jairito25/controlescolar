<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIParent1
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
        Me.components = New System.ComponentModel.Container
        Me.MenuStrip = New System.Windows.Forms.MenuStrip
        Me.ALumnos = New System.Windows.Forms.ToolStripMenuItem
        Me.EditMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.ViewMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolsMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.AulasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CiclosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GruposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button1 = New System.Windows.Forms.Button
        Me.AlumnosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AlumnosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.EvaluacionaesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AulasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ALumnos, Me.EditMenu, Me.ViewMenu, Me.ToolsMenu, Me.HelpMenu, Me.AulasToolStripMenuItem, Me.CiclosToolStripMenuItem, Me.GruposToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1018, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'ALumnos
        '
        Me.ALumnos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ALumnos.Image = Global.inicio.My.Resources.Resources.alu
        Me.ALumnos.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.ALumnos.Name = "ALumnos"
        Me.ALumnos.Size = New System.Drawing.Size(83, 20)
        Me.ALumnos.Text = "Alumnos"
        Me.ALumnos.ToolTipText = "ola"
        '
        'EditMenu
        '
        Me.EditMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator6, Me.ToolStripSeparator7})
        Me.EditMenu.Image = Global.inicio.My.Resources.Resources.usu
        Me.EditMenu.Name = "EditMenu"
        Me.EditMenu.Size = New System.Drawing.Size(80, 20)
        Me.EditMenu.Text = "Usuarios"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(57, 6)
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(57, 6)
        '
        'ViewMenu
        '
        Me.ViewMenu.Image = Global.inicio.My.Resources.Resources.profesres
        Me.ViewMenu.Name = "ViewMenu"
        Me.ViewMenu.Size = New System.Drawing.Size(90, 20)
        Me.ViewMenu.Text = "profesores"
        '
        'ToolsMenu
        '
        Me.ToolsMenu.Image = Global.inicio.My.Resources.Resources.mate
        Me.ToolsMenu.Name = "ToolsMenu"
        Me.ToolsMenu.Size = New System.Drawing.Size(80, 20)
        Me.ToolsMenu.Text = "Materias"
        '
        'HelpMenu
        '
        Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator8})
        Me.HelpMenu.Image = Global.inicio.My.Resources.Resources.evalua
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(92, 20)
        Me.HelpMenu.Text = "Evaluacion"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(57, 6)
        '
        'AulasToolStripMenuItem
        '
        Me.AulasToolStripMenuItem.Image = Global.inicio.My.Resources.Resources.salon
        Me.AulasToolStripMenuItem.Name = "AulasToolStripMenuItem"
        Me.AulasToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.AulasToolStripMenuItem.Text = "Aulas"
        '
        'CiclosToolStripMenuItem
        '
        Me.CiclosToolStripMenuItem.Image = Global.inicio.My.Resources.Resources.cal
        Me.CiclosToolStripMenuItem.Name = "CiclosToolStripMenuItem"
        Me.CiclosToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.CiclosToolStripMenuItem.Text = "Ciclos"
        '
        'GruposToolStripMenuItem
        '
        Me.GruposToolStripMenuItem.Image = Global.inicio.My.Resources.Resources.grupos
        Me.GruposToolStripMenuItem.Name = "GruposToolStripMenuItem"
        Me.GruposToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.GruposToolStripMenuItem.Text = "Grupos"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuariosToolStripMenuItem, Me.ToolStripMenuItem2, Me.AlumnosToolStripMenuItem, Me.AlumnosToolStripMenuItem1, Me.EvaluacionaesToolStripMenuItem, Me.AulasToolStripMenuItem1})
        Me.ReportesToolStripMenuItem.Image = Global.inicio.My.Resources.Resources.reportes
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.UsuariosToolStripMenuItem.Text = "Const. Estudios"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(155, 22)
        Me.ToolStripMenuItem2.Text = "Usuarios"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 394)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1018, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(42, 17)
        Me.ToolStripStatusLabel.Text = "Estado"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(748, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 24)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "REGRESAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'AlumnosToolStripMenuItem
        '
        Me.AlumnosToolStripMenuItem.Name = "AlumnosToolStripMenuItem"
        Me.AlumnosToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.AlumnosToolStripMenuItem.Text = "Grupos"
        '
        'AlumnosToolStripMenuItem1
        '
        Me.AlumnosToolStripMenuItem1.Name = "AlumnosToolStripMenuItem1"
        Me.AlumnosToolStripMenuItem1.Size = New System.Drawing.Size(155, 22)
        Me.AlumnosToolStripMenuItem1.Text = "Alumnos"
        '
        'EvaluacionaesToolStripMenuItem
        '
        Me.EvaluacionaesToolStripMenuItem.Name = "EvaluacionaesToolStripMenuItem"
        Me.EvaluacionaesToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.EvaluacionaesToolStripMenuItem.Text = "Evaluacionaes"
        '
        'AulasToolStripMenuItem1
        '
        Me.AulasToolStripMenuItem1.Name = "AulasToolStripMenuItem1"
        Me.AulasToolStripMenuItem1.Size = New System.Drawing.Size(155, 22)
        Me.AulasToolStripMenuItem1.Text = "Aulas"
        '
        'MDIParent1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 416)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MDIParent1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HelpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ALumnos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents EditMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ViewMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AulasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CiclosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GruposToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents AlumnosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlumnosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EvaluacionaesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AulasToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class
