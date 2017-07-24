Imports System.IO
Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module ModConsulta
    Private adaptador As New MySqlDataAdapter
    Public dtsdatos As New DataSet
    Public dtsvdatos As New DataView
    Public dtsdatosI As New DataSet
    Public dtsvdatosI As New DataView


    Public Sub consultaDatos()
        Try
            conexionGlobal()
            adaptador.SelectCommand = New MySqlCommand("select * from alumnos", conexion)
            adaptador.Fill(dtsdatos)
            dtsvdatos.Table = dtsdatos.Tables(0)
            conexion.Open()
            adaptador.SelectCommand.Connection = conexion
            adaptador.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try

    End Sub

    Public Sub consultaDatosIndividual(ByVal clave As String)
        Try
            conexionGlobal()
            adaptador.SelectCommand = New MySqlCommand("select * from alumnos where matricula=" & clave & "", conexion)
            adaptador.Fill(dtsdatosI)
            dtsvdatosI.Table = dtsdatosI.Tables(0)
            conexion.Open()
            adaptador.SelectCommand.Connection = conexion
            adaptador.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try

    End Sub

    Public Sub consultaImagen(ByVal clave As String)
        Try
            conexionGlobal()
            adaptador.SelectCommand = New MySqlCommand("select * from alumnos where matricula=" & Form1.TextBox1.Text & "", conexion)
            Dim lector As MySqlDataReader

            conexion.Open()
            If conexion.State = ConnectionState.Open Then
                Dim Imag As Byte()
                'Dim comando As New MySqlCommand(Sql, cnn)
                adaptador.SelectCommand.Connection = conexion
                adaptador.SelectCommand.ExecuteNonQuery()

                lector = adaptador.SelectCommand.ExecuteReader()
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
                Form1.PictureBox1.Image = Image.FromStream(Bin, True)
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
