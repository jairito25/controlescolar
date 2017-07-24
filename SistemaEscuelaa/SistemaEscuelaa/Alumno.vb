Public Class Alumno
    Private Matricula As String
    Private Nombre As String
    Private Direccion As String

    public Sub New(ByVal Matricula_ As String, ByVal Nombre_ As String, ByVal Direccion_ As String)
        Matricula = Matricula_
        Nombre = Nombre_
        Direccion = Direccion_
    End Sub

    Public Sub SetMatricula(ByVal Matricula_ As String)
        Matricula = Matricula_
    End Sub

    Public Function GetMatricula() As String
        Return Matricula
    End Function

    Public Sub SetNombre(ByVal Nombre_ As String)
        Nombre = Nombre_
    End Sub

    Public Function GetNombre() As String
        Return Nombre
    End Function

    Public Sub SetDireccion(ByVal Direccion_ As String)
        Direccion = Direccion_
    End Sub

    Public Function GetDireccion() As String
        Return Direccion
    End Function

End Class
