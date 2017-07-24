Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Public Class Conexion_
    Private con As MySqlConnection = New MySqlConnection
    Private adaptador As New MySqlDataAdapter
    Private sqlCommmand As New MySqlCommand
    Private user As String = "root"
    Private password As String = "root"
    Private host As String = "localhost"
    Private database As String = "escuela"

    Public Const ENTERO As Integer = 0
    Public Const CADENA As Integer = 1
    Public Const FECHA As Integer = 2

    Public Function Conecta() As Boolean
        Dim estado As Boolean = True
        Dim cadena As String
        Try
            cadena = "server=" & host & ";database=" & database & ";user id=" & user & ";password=" & password & ";"

            con = New MySqlConnection
            con.ConnectionString = cadena
            'con = New MySqlConnection("server=" & host & ";database=" & database & ";user id=" & user & ";password=" & password & ";")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
        Return True
    End Function

    Public Sub Cerrar()
        con.Close()
    End Sub

    Public Function Insertar(ByVal tabla As String, ByVal atributos As Collection, _
                             ByVal valores As Collection, ByVal tipos As Collection) As Boolean
        Dim query As String
        Dim i As Integer
        'Dim estado As Boolean = True
        query = "INSERT INTO " & tabla & "("

        If Not (atributos.Count = valores.Count And atributos.Count = tipos.Count) Then
            Return False
        End If

        For i = 1 To atributos.Count
            query = query & atributos.Item(i).ToString
            If i + 1 <= atributos.Count Then
                query = query & ", "
            End If
        Next
        query = query & ") VALUES("

        For i = 1 To valores.Count
            If CInt(tipos.Item(i)) = Conexion_.ENTERO Then
                query = query & valores.Item(i).ToString
            ElseIf CInt(tipos.Item(i)) = Conexion_.CADENA Then
                query = query & "'" & valores.Item(i).ToString & "'"
            End If
            If i + 1 <= valores.Count Then
                query = query & ", "
            End If
        Next
        query = query & ")"
        MsgBox(query)
        'Print(query)
        Try
            sqlCommmand.Connection = con
            sqlCommmand.CommandText = query
            sqlCommmand.ExecuteNonQuery()


            'conexionGlobal()
            'adaptador.InsertCommand = New MySqlCommand("insert into alumnos values(@colUno,@colDos,@colTres,@colCuatro,@colCinco,@colSeis,@colSiete,@colOcho,@colNueve,@colDiez)", conexion)
            'adaptador.InsertCommand.Parameters.Add("@colUno", MySqlDbType.VarChar, 50).Value = datos.colUno
            'adaptador.InsertCommand.Parameters.Add("@colDos", MySqlDbType.VarChar, 50).Value = datos.colDos
            'adaptador.InsertCommand.Parameters.Add("@colTres", MySqlDbType.VarChar, 50).Value = datos.colTres
            'adaptador.InsertCommand.Parameters.Add("@colCuatro", MySqlDbType.VarChar, 50).Value = datos.colCuatro
            'adaptador.InsertCommand.Parameters.Add("@colCinco", MySqlDbType.VarChar, 2).Value = datos.colCinco
            'adaptador.InsertCommand.Parameters.Add("@colSeis", MySqlDbType.VarChar, 50).Value = datos.colSeis
            'adaptador.InsertCommand.Parameters.Add("@colSiete", MySqlDbType.VarChar, 50).Value = datos.colSiete
            'adaptador.InsertCommand.Parameters.Add("@colOcho", MySqlDbType.VarChar, 50).Value = datos.colOcho
            'adaptador.InsertCommand.Parameters.Add("@colNueve", MySqlDbType.VarChar, 50).Value = datos.colNueve
            'adaptador.InsertCommand.Parameters.Add("@colDiez", MySqlDbType.VarChar, 50).Value = datos.colDiez
            'conexion.Open()
            'adaptador.InsertCommand.Connection = conexion
            'adaptador.InsertCommand.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        Finally
            'Cerrar()
        End Try
        Return True
    End Function

End Class
