Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module ModConsultaAu
    Private adaptador As New MySqlDataAdapter
    Public dtsdatosAu As New DataSet
    Public dtsvdatosAu As New DataView

    Public dtsdatosIAu As New DataSet
    Public dtsvdatosIAu As New DataView


    Public Sub consultaDatosAu()
        Try
            conexionGlobal()
            adaptador.SelectCommand = New MySqlCommand("select * from aula", conexion)
            adaptador.Fill(dtsdatosAu)
            dtsvdatosAu.Table = dtsdatosAu.Tables(0)
            conexion.Open()
            adaptador.SelectCommand.Connection = conexion
            adaptador.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try

    End Sub

    Public Sub consultaDatosIndividualAu(ByVal clave As String)
        Try
            conexionGlobal()
            adaptador.SelectCommand = New MySqlCommand("select * from aula where cve_au=" & clave & "", conexion)
            adaptador.Fill(dtsdatosIAu)
            dtsvdatosIAu.Table = dtsdatosIAu.Tables(0)
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
