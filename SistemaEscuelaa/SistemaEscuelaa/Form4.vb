Imports System.Text.RegularExpressions
Public Class Form4
    Dim nuevo As Boolean

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        consultaDatosMa()
        DataGridView1.DataSource = dtsvdatosMa
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim conexion As New ClaseInsertarDMa
        Dim datos As New ClaseDatosMa

        dtsdatosMa.Reset()


        datos.clave = TextBox1.Text
        datos.nombre = TextBox2.Text
        datos.grado = TextBox3.Text

        If conexion.insertarDatosMa(datos) Then
            MessageBox.Show("Datos Guardados")
            consultaDatosMa()
            DataGridView1.DataSource = dtsvdatosMa
        Else
            MessageBox.Show("Datos no guardados")
        End If
    End Sub


    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        Try
            TextBox1.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value
            TextBox2.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(1).Value
            TextBox3.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(2).Value

        Catch ex As NullReferenceException

        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        nuevo = True
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        dtsdatosMa.Reset()
        dtsdatosIMa.Reset()
        consultaDatosMa()
        DataGridView1.DataSource = dtsvdatosMa
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        nuevo = False
        Dim conexion As New ClaseInsertarDMa
        Dim datos As New ClaseDatosMa

        dtsdatosMa.Reset()

        datos.clave = TextBox1.Text
        datos.nombre = TextBox2.Text
        datos.grado = TextBox3.Text

        If conexion.actualizaDatosMa(datos) Then
            MessageBox.Show("Datos Actualizados")
            consultaDatosMa()
            DataGridView1.DataSource = dtsvdatosMa
        Else
            MessageBox.Show("Datos No Actualizados")
        End If
    End Sub


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim conexion As New ClaseInsertarDMa
        Dim datos As New ClaseDatosMa

        dtsdatosMa.Reset()

        datos.clave = TextBox1.Text
        If conexion.eliminarDatosMa(datos) Then
            MessageBox.Show("Datos Eliminados")
            consultaDatosMa()
            DataGridView1.DataSource = dtsvdatosMa
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
        Else
            MessageBox.Show("Datos No Eliminados")
        End If
    End Sub

    'VALIDACIONES DE CAMPOS DE TEXTO



    Private Sub TextBox_KeyPressNumerico(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        'NUMERICO
        If Char.IsNumber(e.KeyChar) = False Then
            If e.KeyChar = CChar(ChrW(Keys.Back)) Or e.KeyChar = CChar(ChrW(Keys.Space)) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox_KeyPressNumerosLetras(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress, TextBox3.KeyPress
        'ALFANUMERICO
        If Char.IsLetterOrDigit(e.KeyChar) = False Then
            If e.KeyChar = CChar(ChrW(Keys.Back)) Or e.KeyChar = CChar(ChrW(Keys.Space)) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        dtsdatosMa.Reset()
        dtsdatosIMa.Reset()
        consultaDatosIndividualMa(TextBox1.Text)
        DataGridView1.DataSource = dtsvdatosIMa
    End Sub
End Class