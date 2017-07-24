Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module modConexion
    Public cadena As String
    Public conexion As New MySqlConnection

    Public Function conexionGlobal() As Boolean
        Dim estado As Boolean = True
        Try
            cadena = ("server=localhost;database=escuela;user id=root;password=root;")
            conexion = New MySqlConnection(cadena)            
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        End Try
        Return estado
    End Function


    Public Sub cerrar()
        conexion.Close()
    End Sub
End Module


