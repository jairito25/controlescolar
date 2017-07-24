Imports System.Data
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class prueba
    Public cnn As MySqlConnection
    Dim StrConexion As String = "server=localhost;uid=root;password=root;database=escuela"

    Private Sub prueba_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim conexionClase As New ClasePrueba

        conexionClase.abrir_inventario_existente()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim conexion As New ClasePrueba
        Dim datos As New ClaseDatosPrueba

        conexion.insertarDatos()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        consultaImagen1(TextBox1.Text)
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
                PictureBox1.Image = Image.FromStream(Bin, True)
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
End Class