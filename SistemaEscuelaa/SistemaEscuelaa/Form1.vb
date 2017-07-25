Imports System.IO
Imports System.Drawing.Imaging
Imports System.Text.RegularExpressions

Public Class Form1
    Private con As New Conexion_
    Dim nuevo As Boolean

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load    
        consultaDatos()
        DataGridView1.DataSource = dtsvdatos
        'con.Conecta()
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim conexion As New ClaseInsertarD
        Dim datos As New ClaseDatos

        'Dim atributos As New Collection
        'Dim valores As New Collection
        'Dim tipos As New Collection

        'With atributos
        '.Add("matricula")
        '.Add("nombre_completo")
        '.Add("direccion")
        'End With
        'With valores
        ' .Add(TextBox1.Text)
        '  .Add(TextBox2.Text)
        '   .Add(TextBox3.Text)
        'End With
        'With tipos
        ' .Add(Conexion_.ENTERO)
        '  .Add(Conexion_.CADENA)
        '   .Add(Conexion_.CADENA)
        'End With

        'con.Conecta()
        'con.Insertar("alumnos", atributos, valores, tipos)


        dtsdatos.Reset()


        datos.colUno = TextBox1.Text
        datos.colDos = TextBox2.Text
        datos.colTres = TextBox3.Text
        datos.colCuatro = TextBox4.Text
        datos.colCinco = ComboBox1.SelectedItem
        'datos.colSeis = TextBox5.Text
        datos.colSiete = TextBox6.Text
        datos.colOcho = TextBox7.Text
        datos.colNueve = TextBox8.Text
        datos.colDiez = TextBox9.Text

        If conexion.insertarDatos(datos) Then
            MessageBox.Show("Datos Guardados")
            consultaDatos()
            DataGridView1.DataSource = dtsvdatos
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
            'TextBox10.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(4).Value
            'TextBox5.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(5).Value
            TextBox6.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(6).Value
            TextBox7.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(7).Value
            TextBox8.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(8).Value
            TextBox9.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(9).Value
            consultaImagen(DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value)
        Catch ex As NullReferenceException

        End Try
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        nuevo = True
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        'TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        'TextBox10.Text = ""
        PictureBox1.Image = Nothing
        dtsdatos.Reset()
        dtsdatosI.Reset()
        consultaDatos()
        DataGridView1.DataSource = dtsvdatos

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        nuevo = False
        Dim conexion As New ClaseInsertarD
        Dim datos As New ClaseDatos

        dtsdatos.Reset()


        datos.colUno = TextBox1.Text
        datos.colDos = TextBox2.Text
        datos.colTres = TextBox3.Text
        datos.colCuatro = TextBox4.Text
        datos.colCinco = ComboBox1.SelectedItem
        'datos.colSeis = TextBox5.Text
        datos.colSiete = TextBox6.Text
        datos.colOcho = TextBox7.Text
        datos.colNueve = TextBox8.Text
        datos.colDiez = TextBox9.Text


        If conexion.actualizaDatos(datos) Then
            MessageBox.Show("Datos Actualizados")
            consultaDatos()
            DataGridView1.DataSource = dtsvdatos
        Else
            MessageBox.Show("Datos No Actualizados")
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim conexion As New ClaseInsertarD
        Dim datos As New ClaseDatos

        dtsdatos.Reset()

        datos.colUno = TextBox1.Text
        If conexion.eliminarDatos(datos) Then
            MessageBox.Show("Datos Eliminados")
            consultaDatos()
            DataGridView1.DataSource = dtsvdatos
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            'TextBox5.Text = ""
            TextBox6.Text = ""
            TextBox7.Text = ""
            TextBox8.Text = ""
            TextBox9.Text = ""
            PictureBox1.Image = Nothing

        Else
            MessageBox.Show("Datos No Eliminados")
        End If
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        dtsdatos.Reset()
        dtsdatosI.Reset()
        consultaDatosIndividual(TextBox1.Text)
        DataGridView1.DataSource = dtsvdatosI
        consultaImagen(TextBox1.Text)
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click       
        Dim conexionClase As New ClaseInsertarD

        conexionClase.abrir_inventario_existente()
    End Sub

    'VALIDACIONES DE CAMPOS DE TEXTO

    

    Private Sub TextBox_KeyPressNumerico(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress, TextBox4.KeyPress, TextBox8.KeyPress
        'NUMERICO
        If Char.IsNumber(e.KeyChar) = False Then
            If e.KeyChar = CChar(ChrW(Keys.Back)) Or e.KeyChar = CChar(ChrW(Keys.Space)) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox_KeyPressLetras(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress, TextBox6.KeyPress
        'LETRAS
        If Char.IsLetter(e.KeyChar) = False Then
            If e.KeyChar = CChar(ChrW(Keys.Back)) Or e.KeyChar = CChar(ChrW(Keys.Space)) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox_KeyPressNumerosLetras(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress, TextBox7.KeyPress
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

    Private Sub TextBox9_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox9.Leave
        If validar_Mail(LCase(TextBox9.Text)) = False Then
            MessageBox.Show("Dirección de correo electronico no valida,el correo debe tener el formato: nombre@dominio.com, " & " por favor seleccione un correo valido", "Validación de   correo electronico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TextBox9.Focus()
            TextBox9.SelectAll()
        End If
    End Sub

    
End Class
