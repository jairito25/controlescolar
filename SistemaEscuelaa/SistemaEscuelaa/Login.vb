Imports MySql.Data.MySqlClient

Public Class Login

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar.Click
        If (Existeusuario(ComboBox1.SelectedItem.ToString, TextBox1.Text)) Then
            Me.Close()
            MDIParent1.Show()
        End If
    End Sub

    Function Existeusuario(ByVal usuario As String, ByVal password As String) As Boolean
        Dim oConexion As MySqlConnection

        Dim oDataAdapter As New MySqlDataAdapter
        Dim oDataSet As New DataSet
        Dim aSql As String
        Dim aSql2 As String
        Dim sw As Boolean = False
        Try
            'CONSULTA PARA DIRECTOR
            oConexion = New MySqlConnection()
            oConexion.ConnectionString = "server=localhost;database=escuela;user id=root;password=root;"
            aSql = "select * from usuarios where nombre_usuario='" & usuario & "' and password='" & password & "' "
            'MsgBox("Ha Ingresado como director")

            oConexion.Open()
            oDataAdapter = New MySqlDataAdapter(aSql, oConexion)

            oDataSet.Clear()
            oDataAdapter.Fill(oDataSet, "usuarios")

            'If (oDataSet.Tables("usuarios").Rows.Count() <> 0) Then

            'Else
            '    MessageBox.Show("no se puede", "escuela")
            '    sw = False

            'End If




            '//////////////////////



            If (oDataSet.Tables("usuarios").Rows.Count() <> 0) Then
                Dim menu As New MDIParent1
                If usuario = "Director" Then
                    menu.Show()
                    Me.Close()
                ElseIf usuario = "Profesor" Then
                    menu.EditMenu.Enabled = False
                    menu.Show()
                    Me.Close()

                End If


                If usuario = "Operador" Then
                    menu.ALumnos.Enabled = False
                    menu.EditMenu.Enabled = False
                    menu.ViewMenu.Enabled = False
                    menu.ToolStripMenuItem2.Enabled = False
                    menu.HelpMenu.Enabled = False
                    menu.AulasToolStripMenuItem.Enabled = False
                    menu.CiclosToolStripMenuItem.Enabled = False
                    menu.GruposToolStripMenuItem.Enabled = False
                    menu.Show()
                    Me.Close()
                End If

            Else
                MessageBox.Show("no se puede", "escuela")
                'sw = False

            End If
        Catch ex As Exception

        End Try

        'Try
        '    'CONSULTA PARA pf
        '    oConexion = New MySqlConnection()
        '    oConexion.ConnectionString = "server=localhost;database=escuela;user id=root;password=root;"
        '    aSql2 = "select * from usuarios where nombre_usuario='" & usuario & "' and password='" & password & "' "
        '    MsgBox("Ha Ingresado como fp")

        '    oConexion.Open()
        '    oDataAdapter = New MySqlDataAdapter(aSql2, oConexion)

        '    oDataSet.Clear()
        '    oDataAdapter.Fill(oDataSet, "usuarios")

        '    If (oDataSet.Tables("usuarios").Rows.Count() <> 0) Then

        '    Else
        '        MessageBox.Show("no se puede", "escuela")
        '        sw = False

        '    End If




        '    '//////////////////////



        '    If (oDataSet.Tables("usuarios").Rows.Count() <> 0) Then
        '        MDIParent2.Show()
        '        sw = True

        '    Else
        '        MessageBox.Show("no se puede", "escuela")
        '        sw = False

        '    End If
        'Catch ex As Exception

        'End Try
        'Return 0

        Return 0
    End Function

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click


    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        DateTimePicker1.Visible = False
    End Sub

    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim fecha As String
        fecha = DateTimePicker1.Text
        Label4.Text = fecha
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
End Class