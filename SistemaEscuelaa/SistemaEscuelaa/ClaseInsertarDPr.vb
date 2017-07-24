Imports System.IO
Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Public Class ClaseInsertarDPr
    Private adaptador As New MySqlDataAdapter

    Public Function insertarDatosPr(ByVal datos As ClaseDatosPr) As Boolean
        Dim estado As Boolean = True


        Try

            conexionGlobal()
            adaptador.InsertCommand = New MySqlCommand("insert into profesores values(@clave,@nombre,@direccion,@telefono,@sexo,@correo,?imagen,@profesion,@fecha)", conexion)
            adaptador.InsertCommand.Parameters.Add("@clave", MySqlDbType.VarChar, 50).Value = datos.clave
            adaptador.InsertCommand.Parameters.Add("@nombre", MySqlDbType.VarChar, 50).Value = datos.nombre
            adaptador.InsertCommand.Parameters.Add("@direccion", MySqlDbType.VarChar, 50).Value = datos.direccion
            adaptador.InsertCommand.Parameters.Add("@telefono", MySqlDbType.VarChar, 50).Value = datos.telefono
            adaptador.InsertCommand.Parameters.Add("@sexo", MySqlDbType.VarChar, 2).Value = datos.sexo
            adaptador.InsertCommand.Parameters.Add("@correo", MySqlDbType.VarChar, 50).Value = datos.correo
            'adaptador.InsertCommand.Parameters.Add("@foto", MySqlDbType.VarChar, 50).Value = datos.foto

            Dim Imag As Byte()
            Imag = Imagen_Bytes(Form2.PictureBox1.Image)
            adaptador.InsertCommand.Parameters.AddWithValue("?imagen", Imag)

            adaptador.InsertCommand.Parameters.Add("@profesion", MySqlDbType.VarChar, 50).Value = datos.profesion
            adaptador.InsertCommand.Parameters.Add("@fecha", MySqlDbType.Date).Value = datos.fecha
            conexion.Open()
            adaptador.InsertCommand.Connection = conexion
            adaptador.InsertCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            cerrar()
        End Try
        Return estado
    End Function

    Public Function actualizaDatosPr(ByVal datos As ClaseDatosPr) As Boolean
        Dim estado As Boolean = True
        Try
            conexionGlobal()
            adaptador.UpdateCommand = New MySqlCommand("update profesores set nombre=@nombre,direccion=@direccion,telefono=@telefono,sexo=@sexo,correo=@correo,foto=?imagen,profesion=@profesion,fecha=@fecha where clave=@clave", conexion)
            adaptador.UpdateCommand.Parameters.Add("@clave", MySqlDbType.VarChar, 50).Value = datos.clave
            adaptador.UpdateCommand.Parameters.Add("@nombre", MySqlDbType.VarChar, 50).Value = datos.nombre
            adaptador.UpdateCommand.Parameters.Add("@direccion", MySqlDbType.VarChar, 50).Value = datos.direccion
            adaptador.UpdateCommand.Parameters.Add("@telefono", MySqlDbType.VarChar, 50).Value = datos.telefono
            adaptador.UpdateCommand.Parameters.Add("@sexo", MySqlDbType.VarChar, 2).Value = datos.sexo
            adaptador.UpdateCommand.Parameters.Add("@correo", MySqlDbType.VarChar, 50).Value = datos.correo
            'adaptador.UpdateCommand.Parameters.Add("@foto", MySqlDbType.VarChar, 50).Value = datos.foto

            Dim Imag As Byte()
            Imag = Imagen_Bytes(Form2.PictureBox1.Image)
            adaptador.UpdateCommand.Parameters.AddWithValue("?imagen", Imag)


            adaptador.UpdateCommand.Parameters.Add("@profesion", MySqlDbType.VarChar, 50).Value = datos.profesion
            adaptador.UpdateCommand.Parameters.Add("@fecha", MySqlDbType.Date).Value = datos.fecha
            conexion.Open()
            adaptador.UpdateCommand.Connection = conexion
            adaptador.UpdateCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            cerrar()
        End Try
        Return estado
    End Function

    Public Function eliminarDatosPr(ByVal datos As ClaseDatosPr) As Boolean
        Dim estado As Boolean = True
        Try
            adaptador.DeleteCommand = New MySqlCommand("delete from profesores where clave=@clave", conexion)
            adaptador.DeleteCommand.Parameters.Add("@clave", MySqlDbType.VarChar, 50).Value = datos.clave
            conexion.Open()
            adaptador.DeleteCommand.Connection = conexion
            adaptador.DeleteCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            cerrar()
        End Try
        Return estado
    End Function

    Public Sub abrir_inventario_existente()
        Dim filename As String
        Dim openfiler As New OpenFileDialog
        'Definiendo propiedades al openfiledialog
        With openfiler
            'directorio inicial
            .InitialDirectory = "C:\"
            'archivos que se pueden abrir
            .Filter = "Archivos de imágen(*.jpg)|*.jpg|All Files (*.*)|*.*"
            'indice del archivo de lectura por defecto
            .FilterIndex = 1
            'restaurar el directorio al cerrar el dialogo
            .RestoreDirectory = True
        End With
        '
        If openfiler.ShowDialog = Windows.Forms.DialogResult.OK Then  'Evalua si el usuario hace click en el boton abrir
            'Obteniendo la ruta completa del archivo xml
            filename = openfiler.FileName
            Form2.PictureBox1.Image = Image.FromFile(filename)
        End If
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

    'convertir imagen a binario
    Public Function Imagen_Bytes(ByVal Imagen As Image) As Byte()
        'si hay imagen
        If Not Imagen Is Nothing Then
            'variable de datos binarios en stream(flujo)
            Dim Bin As New MemoryStream
            'convertir a bytes
            Imagen.Save(Bin, Imaging.ImageFormat.Jpeg)
            'retorna binario
            Return Bin.GetBuffer
        Else
            Return Nothing
        End If
    End Function
End Class
