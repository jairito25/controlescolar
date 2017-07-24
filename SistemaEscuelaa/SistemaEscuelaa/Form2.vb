Imports System.Text.RegularExpressions
Public Class Form2
    Dim nuevo As Boolean


    Private Sub Form2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        consultaDatosPr()
        DataGridView1.DataSource = dtsvdatosPr
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim conexion As New ClaseInsertarDPr
        Dim datos As New ClaseDatosPr

        dtsdatosPr.Reset()


        datos.clave = TextBox1.Text
        datos.nombre = TextBox2.Text
        datos.direccion = TextBox3.Text
        datos.telefono = TextBox4.Text
        datos.sexo = ComboBox1.SelectedItem
        datos.correo = TextBox6.Text
        'datos.foto = TextBox8.Text
        datos.profesion = TextBox7.Text
        datos.fecha = MonthCalendar1.SelectionRange.End.ToShortDateString()

        If conexion.insertarDatosPr(datos) Then
            MessageBox.Show("Datos Guardados")
            consultaDatosPr()
            DataGridView1.DataSource = dtsvdatosPr
        Else
            MessageBox.Show("Datos no guardados")
        End If
    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        Try
            TextBox1.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value
            TextBox2.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(1).Value
            TextBox3.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(2).Value
            TextBox4.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(3).Value
            'TextBox5.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(4).Value
            TextBox6.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(5).Value
            TextBox7.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(7).Value
            'MonthCalendar1 = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(7).Value
            ' TextBox8.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(6).Value
            consultaImagenPr(DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value)

        Catch ex As NullReferenceException
        End Try
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        nuevo = True
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        'TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        'TextBox8.Text = ""
        PictureBox1.Image = Nothing
        dtsdatosPr.Reset()
        dtsdatosIPr.Reset()
        consultaDatosPr()
        DataGridView1.DataSource = dtsvdatosPr
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        nuevo = False
        Dim conexion As New ClaseInsertarDPr
        Dim datos As New ClaseDatosPr

        dtsdatosPr.Reset()

        datos.clave = TextBox1.Text
        datos.nombre = TextBox2.Text
        datos.direccion = TextBox3.Text
        datos.telefono = TextBox4.Text
        datos.sexo = ComboBox1.SelectedItem
        datos.correo = TextBox6.Text
        'datos.foto = TextBox8.Text
        datos.profesion = TextBox7.Text
        datos.fecha = MonthCalendar1.SelectionRange.End.ToShortDateString()


        If conexion.actualizaDatosPr(datos) Then
            MessageBox.Show("Datos Actualizados")
            consultaDatosPr()
            DataGridView1.DataSource = dtsvdatosPr
        Else
            MessageBox.Show("Datos No Actualizados")
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim conexion As New ClaseInsertarDPr
        Dim datos As New ClaseDatosPr

        dtsdatosPr.Reset()

        datos.clave = TextBox1.Text
        If conexion.eliminarDatosPr(datos) Then
            MessageBox.Show("Datos Eliminados")
            consultaDatosPr()
            DataGridView1.DataSource = dtsvdatosPr
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            ' TextBox5.Text = ""
            TextBox6.Text = ""
            TextBox7.Text = ""
            'TextBox8.Text = ""
            PictureBox1.Image = Nothing
        Else
            MessageBox.Show("Datos No Eliminados")
        End If
    End Sub

    'VALIDACIONES DE CAMPOS DE TEXTO



    Private Sub TextBox_KeyPressNumerico(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress, TextBox4.KeyPress
        'NUMERICO
        If Char.IsNumber(e.KeyChar) = False Then
            If e.KeyChar = CChar(ChrW(Keys.Back)) Or e.KeyChar = CChar(ChrW(Keys.Space)) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox_KeyPressLetras(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress, TextBox7.KeyPress
        'LETRAS
        If Char.IsLetter(e.KeyChar) = False Then
            If e.KeyChar = CChar(ChrW(Keys.Back)) Or e.KeyChar = CChar(ChrW(Keys.Space)) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox_KeyPressNumerosLetras(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        'ALFANUMERICO
        If Char.IsLetterOrDigit(e.KeyChar) = False Then
            If e.KeyChar = CChar(ChrW(Keys.Back)) Or e.KeyChar = CChar(ChrW(Keys.Space)) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Public Function validar_Mail(ByVal sMail As String) As Boolean
        ' retorna true o false   
        Return Regex.IsMatch(sMail, _
                  "^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$")
    End Function

    Private Sub TextBox9_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox6.Leave
        If validar_Mail(LCase(TextBox6.Text)) = False Then
            MessageBox.Show("Dirección de correo electronico no valida,el correo debe tener el formato: nombre@dominio.com, " & " por favor seleccione un correo valido", "Validación de   correo electronico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TextBox6.Focus()
            TextBox6.SelectAll()
        End If
    End Sub

   
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        dtsdatosPr.Reset()
        dtsdatosIPr.Reset()
        consultaDatosIndividualPr(TextBox1.Text)
        DataGridView1.DataSource = dtsvdatosIPr
        consultaImagenPr(TextBox1.Text)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim conexionClase As New ClaseInsertarDPr

        conexionClase.abrir_inventario_existente()
    End Sub
End Class