Imports System.IO
Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module ModPrueba
    Private adaptador As New MySqlDataAdapter

    Public cnn As MySqlConnection
    Public conexionClase As ClasePrueba
    
    Public dtsdatosIPru As New DataSet
    Public dtsvdatosIPru As New DataView
    Public dt As New DataTable

    Public Sub consultaImagen1(ByVal clave As String)
        Try
            conexionGlobal()
            adaptador.SelectCommand = New MySqlCommand("select * from prueba where clave=" & prueba.TextBox1.Text & "", conexion)
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

                    Imag = lector("imagen")
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
                prueba.PictureBox1.Image = Image.FromStream(Bin, True)
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
