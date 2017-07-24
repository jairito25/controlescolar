Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Imports System.IO

Public Class ClaseInsertarD
    Private adaptador As New MySqlDataAdapter

    Public Function insertarDatos(ByVal datos As ClaseDatos) As Boolean
        Dim estado As Boolean = True


        Try

            conexionGlobal()
            adaptador.InsertCommand = New MySqlCommand("insert into alumnos values(@colUno,@colDos,@colTres,@colCuatro,@colCinco,?imagen,@colSiete,@colOcho,@colNueve,@colDiez)", conexion)
            adaptador.InsertCommand.Parameters.Add("@colUno", MySqlDbType.VarChar, 50).Value = datos.colUno
            adaptador.InsertCommand.Parameters.Add("@colDos", MySqlDbType.VarChar, 50).Value = datos.colDos
            adaptador.InsertCommand.Parameters.Add("@colTres", MySqlDbType.VarChar, 50).Value = datos.colTres
            adaptador.InsertCommand.Parameters.Add("@colCuatro", MySqlDbType.VarChar, 50).Value = datos.colCuatro
            adaptador.InsertCommand.Parameters.Add("@colCinco", MySqlDbType.VarChar, 2).Value = datos.colCinco
            'adaptador.InsertCommand.Parameters.Add("@colSeisimagen", MySqlDbType.VarChar, 50).Value = datos.colSeis
            Dim Imag As Byte()
            Imag = Imagen_Bytes(Form1.PictureBox1.Image)
            adaptador.InsertCommand.Parameters.AddWithValue("?imagen", Imag)

            adaptador.InsertCommand.Parameters.Add("@colSiete", MySqlDbType.VarChar, 50).Value = datos.colSiete
            adaptador.InsertCommand.Parameters.Add("@colOcho", MySqlDbType.VarChar, 50).Value = datos.colOcho
            adaptador.InsertCommand.Parameters.Add("@colNueve", MySqlDbType.VarChar, 50).Value = datos.colNueve
            adaptador.InsertCommand.Parameters.Add("@colDiez", MySqlDbType.VarChar, 50).Value = datos.colDiez

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

    Public Function actualizaDatos(ByVal datos As ClaseDatos) As Boolean
        Dim estado As Boolean = True
        Try
            conexionGlobal()
            adaptador.UpdateCommand = New MySqlCommand("update alumnos set nombre=@colDos,direccion=@colTres,telefono=@colCuatro,sexo=@colCinco,foto=?imagen,nombreTutor=@colSiete,direccionTutor=@colOcho,telefonoTutor=@colNueve,correoTutor=@colDiez where matricula=@colUno", conexion)
            adaptador.UpdateCommand.Parameters.Add("@colUno", MySqlDbType.VarChar, 50).Value = datos.colUno
            adaptador.UpdateCommand.Parameters.Add("@colDos", MySqlDbType.VarChar, 50).Value = datos.colDos
            adaptador.UpdateCommand.Parameters.Add("@colTres", MySqlDbType.VarChar, 50).Value = datos.colTres
            adaptador.UpdateCommand.Parameters.Add("@colCuatro", MySqlDbType.VarChar, 50).Value = datos.colCuatro
            adaptador.UpdateCommand.Parameters.Add("@colCinco", MySqlDbType.VarChar, 2).Value = datos.colCinco
            'adaptador.UpdateCommand.Parameters.Add("@colSeis", MySqlDbType.VarChar, 50).Value = datos.colSeis

            Dim Imag As Byte()
            Imag = Imagen_Bytes(Form1.PictureBox1.Image)
            adaptador.UpdateCommand.Parameters.AddWithValue("?imagen", Imag)

            adaptador.UpdateCommand.Parameters.Add("@colSiete", MySqlDbType.VarChar, 50).Value = datos.colSiete
            adaptador.UpdateCommand.Parameters.Add("@colOcho", MySqlDbType.VarChar, 50).Value = datos.colOcho
            adaptador.UpdateCommand.Parameters.Add("@colNueve", MySqlDbType.VarChar, 50).Value = datos.colNueve
            adaptador.UpdateCommand.Parameters.Add("@colDiez", MySqlDbType.VarChar, 50).Value = datos.colDiez
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

    Public Function eliminarDatos(ByVal datos As ClaseDatos) As Boolean
        Dim estado As Boolean = True
        Try
            adaptador.DeleteCommand = New MySqlCommand("delete from alumnos where matricula=@colUno", conexion)
            adaptador.DeleteCommand.Parameters.Add("@colUno", MySqlDbType.VarChar, 50).Value = datos.colUno
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

    Public Function consultaIndividual(ByVal datos As ClaseDatos) As Boolean
        Dim estado As Boolean = True

        Try
            conexionGlobal()
            adaptador.SelectCommand = New MySqlCommand("select * from alumnos where matricula=@colUno", conexion)
            adaptador.SelectCommand.Parameters.Add("@colUno", MySqlDbType.VarChar, 50).Value = datos.colUno
            adaptador.Fill(dtsdatos)
            dtsvdatos.Table = dtsdatos.Tables(0)
            conexion.Open()
            adaptador.SelectCommand.Connection = conexion
            adaptador.SelectCommand.ExecuteNonQuery()
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
            MsgBox()

        End With
        '
        If openfiler.ShowDialog = Windows.Forms.DialogResult.OK Then  'Evalua si el usuario hace click en el boton abrir
            'Obteniendo la ruta completa del archivo xml
            filename = openfiler.FileName
            Form1.PictureBox1.Image = Image.FromFile(filename)
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

