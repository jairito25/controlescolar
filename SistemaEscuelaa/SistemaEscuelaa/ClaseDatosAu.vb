Public Class ClaseDatosAu
    Private _clave As Integer
    Private _nombre As String
    Private _capacidad As Integer

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
    Public Property capacidad() As Integer
        Get
            Return _capacidad
        End Get
        Set(ByVal value As Integer)
            _capacidad = value
        End Set
    End Property
End Class
