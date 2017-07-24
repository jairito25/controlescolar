Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Public Class ClaseInsertarDMa
    Private adaptador As New MySqlDataAdapter

    Public Function insertarDatosMa(ByVal datos As ClaseDatosMa) As Boolean
        Dim estado As Boolean = True


        Try

            conexionGlobal()
            adaptador.InsertCommand = New MySqlCommand("insert into materias values(@clave,@nombre,@grado)", conexion)
            adaptador.InsertCommand.Parameters.Add("@clave", MySqlDbType.Int32).Value = datos.clave
            adaptador.InsertCommand.Parameters.Add("@nombre", MySqlDbType.VarChar, 50).Value = datos.nombre
            adaptador.InsertCommand.Parameters.Add("@grado", MySqlDbType.VarChar, 50).Value = datos.grado
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

    Public Function actualizaDatosMa(ByVal datos As ClaseDatosMa) As Boolean
        Dim estado As Boolean = True
        Try
            conexionGlobal()
            adaptador.UpdateCommand = New MySqlCommand("update materias set nom_mat=@nombre,grado_mat=@grado where cve_mat=@clave", conexion)
            adaptador.UpdateCommand.Parameters.Add("@clave", MySqlDbType.Int32).Value = datos.clave
            adaptador.UpdateCommand.Parameters.Add("@nombre", MySqlDbType.VarChar, 50).Value = datos.nombre
            adaptador.UpdateCommand.Parameters.Add("@grado", MySqlDbType.VarChar, 50).Value = datos.grado
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

    Public Function eliminarDatosMa(ByVal datos As ClaseDatosMa) As Boolean
        Dim estado As Boolean = True
        Try
            adaptador.DeleteCommand = New MySqlCommand("delete from materias where cve_mat=@clave", conexion)
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
End Class
