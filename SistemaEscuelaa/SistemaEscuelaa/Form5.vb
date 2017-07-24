Imports System.Data
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Form5
    Public cnn As MySqlConnection
    Dim StrConexion As String = "server=localhost;uid=root;password=root;database=escuela"

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    Private Sub abrir_inventario_existente()
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
            Me.PictureBox1.Image = Image.FromFile(filename)
        End If
    End Sub

    'convertir binario a imágen
    Private Function Bytes_Imagen(ByVal Imagen As Byte()) As Image

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

    'convertir imagen a binario
    Private Function Imagen_Bytes(ByVal Imagen As Image) As Byte()
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

    
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        abrir_inventario_existente()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim sql As String = "insert into prueba values(null,?imagen)"
            cnn = New MySqlConnection(StrConexion)
            Dim Comando As New MySqlCommand(sql, cnn)
            Dim Imag As Byte()
            Imag = Imagen_Bytes(Me.PictureBox1.Image)

            Comando.Parameters.AddWithValue("?imagen", Imag)

            cnn.Open()
            If cnn.State = ConnectionState.Open Then
                Comando.ExecuteNonQuery()
            End If
            cnn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Try
            Dim Sql As String = "select * from prueba where clave=" & TextBox1.Text & ""
            Dim lector As MySqlDataReader
            cnn = New MySqlConnection(StrConexion)
            cnn.Open()

            If cnn.State = ConnectionState.Open Then
                Dim Imag As Byte()
                Dim Comando As New MySqlCommand(Sql, cnn)
                lector = Comando.ExecuteReader
                MessageBox.Show("hola")
                While lector.Read

                    Imag = lector("imagen")
                    PictureBox1.Image = Bytes_Imagen(Imag)
                End While

            End If        
            cnn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class