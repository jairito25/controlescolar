Public Class ClaseDatosMa
    Private _clave As Integer
    Private _nombre As String
    Private _grado As String

    Public Property clave() As Integer
        Get
            Return _clave
        End Get
        Set(ByVal value As Integer)
            _clave = value
        End Set
    End Property

    Public Property nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Public Property grado() As String
        Get
            Return _grado
        End Get
        Set(ByVal value As String)
            _grado = value
        End Set
    End Property
End Class
