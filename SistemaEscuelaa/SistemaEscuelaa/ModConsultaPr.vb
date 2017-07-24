Imports System.IO
Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module ModConsultaPr
    Private adaptadorPr As New MySqlDataAdapter

    Public dtsdatosPr As New DataSet
    Public dtsvdatosPr As New DataView

    Public dtsdatosIPr As New DataSet
    Public dtsvdatosIPr As New DataView


    Public Sub consultaDatosPr()
        Try
            conexionGlobal()
            adaptadorPr.SelectCommand = New MySqlCommand("select * from profesores", conexion)
            adaptadorPr.Fill(dtsdatosPr)
            dtsvdatosPr.Table = dtsdatosPr.Tables(0)
            conexion.Open()
            adaptadorPr.SelectCommand.Connection = conexion
            adaptadorPr.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try

    End Sub

    Public Sub consultaDatosIndividualPr(ByVal clave As String)
        Try
            conexionGlobal()
            adaptadorPr.SelectCommand = New MySqlCommand("select * from profesores where clave=" & clave & "", conexion)
            adaptadorPr.Fill(dtsdatosIPr)
            dtsvdatosIPr.Table = dtsdatosIPr.Tables(0)
            conexion.Open()
            adaptadorPr.SelectCommand.Connection = conexion
            adaptadorPr.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try

    End Sub
    Public Sub consultaImagenPr(ByVal clave As String)
        Try
            conexionGlobal()
            adaptadorPr.SelectCommand = New MySqlCommand("select * from profesores where clave=" & Form2.TextBox1.Text & "", conexion)
            Dim lector As MySqlDataReader

            conexion.Open()
            If conexion.State = ConnectionState.Open Then
                Dim Imag As Byte()
                'Dim comando As New MySqlCommand(Sql, cnn)
                adaptadorPr.SelectCommand.Connection = conexion
                adaptadorPr.SelectCommand.ExecuteNonQuery()

                lector = adaptadorPr.SelectCommand.ExecuteReader()
                MessageBox.Show("hola")
                While lector.Read

                    Imag = lector("foto")
                    'prueba.PictureBox1.Image = conexionClase.Bytes_Imagen(Imag)
                    Bytes_Imagen(Imag)
                End While

            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub

    'convertir binario a imágen
    Public Function Bytes_Imagen(ByVal Imagen As Byte()) As Image

        Try
            'si hay imagen
            If Not Imagen Is Nothing Then

                'caturar array con memorystream hacia Bin
                Dim Bin As New MemoryStream(Imagen)

                'con el método FroStream de Image obtenemos imagen
                MessageBox.Show(Bin.ToString)
                MessageBox.Show(Imagen.Length)
                Form2.PictureBox1.Image = Image.FromStream(Bin, True)
                Dim resultado As Image = Image.FromStream(Bin)
                'y la retornamos
                MessageBox.Show(Resultado.ToString)

                Return Resultado
            Else
                MessageBox.Show("No hay")
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Module
