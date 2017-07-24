Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module ModConsultaMa
    Private adaptador As New MySqlDataAdapter
    Public dtsdatosMa As New DataSet
    Public dtsvdatosMa As New DataView

    Public dtsdatosIMa As New DataSet
    Public dtsvdatosIMa As New DataView


    Public Sub consultaDatosMa()
        Try
            conexionGlobal()
            adaptador.SelectCommand = New MySqlCommand("select * from materias", conexion)
            adaptador.Fill(dtsdatosMa)
            dtsvdatosMa.Table = dtsdatosMa.Tables(0)
            conexion.Open()
            adaptador.SelectCommand.Connection = conexion
            adaptador.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try

    End Sub

    Public Sub consultaDatosIndividualMa(ByVal clave As String)
        Try
            conexionGlobal()
            adaptador.SelectCommand = New MySqlCommand("select * from materia where cve_mat=" & clave & "", conexion)
            adaptador.Fill(dtsdatosIMa)
            dtsvdatosIMa.Table = dtsdatosIMa.Tables(0)
            conexion.Open()
            adaptador.SelectCommand.Connection = conexion
            adaptador.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try

    End Sub
End Module
