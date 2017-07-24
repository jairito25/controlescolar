Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Public Class ClaseInsertarAu
    Private adaptador As New MySqlDataAdapter

    Public Function insertarDatosAu(ByVal datos As ClaseDatosAu) As Boolean
        Dim estado As Boolean = True


        Try

            conexionGlobal()
            adaptador.InsertCommand = New MySqlCommand("insert into aula values(@clave,@nombre,@capacidad)", conexion)
            adaptador.InsertCommand.Parameters.Add("@clave", MySqlDbType.Int32).Value = datos.clave
            adaptador.InsertCommand.Parameters.Add("@nombre", MySqlDbType.VarChar, 45).Value = datos.nombre
            adaptador.InsertCommand.Parameters.Add("@capacidad", MySqlDbType.Int32).Value = datos.capacidad
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

    Public Function actualizaDatosAu(ByVal datos As ClaseDatosAu) As Boolean
        Dim estado As Boolean = True
        Try
            conexionGlobal()
            adaptador.UpdateCommand = New MySqlCommand("update aula set nom_au=@nombre,capacidad=@capacidad where cve_au=@clave", conexion)
            adaptador.UpdateCommand.Parameters.Add("@clave", MySqlDbType.Int32).Value = datos.clave
            adaptador.UpdateCommand.Parameters.Add("@nombre", MySqlDbType.VarChar, 50).Value = datos.nombre
            adaptador.UpdateCommand.Parameters.Add("@capacidad", MySqlDbType.Int32).Value = datos.capacidad
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

    Public Function eliminarDatosAu(ByVal datos As ClaseDatosAu) As Boolean
        Dim estado As Boolean = True
        Try
            adaptador.DeleteCommand = New MySqlCommand("delete from aula where cve_au=@clave", conexion)
            adaptador.DeleteCommand.Parameters.Add("@clave", MySqlDbType.Int32).Value = datos.clave
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

    Public Function consultaIndividual(ByVal datos As ClaseDatosAu) As Boolean
        Dim estado As Boolean = True

        Try
            conexionGlobal()
            adaptador.SelectCommand = New MySqlCommand("select * from aula where clave=@clave", conexion)
            adaptador.SelectCommand.Parameters.Add("@clave", MySqlDbType.Int32).Value = datos.clave
            adaptador.Fill(dtsdatos)
            dtsvdatosAu.Table = dtsdatosAu.Tables(0)
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

End Class
