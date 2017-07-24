Public Class ClaseDatosPrueba
    Private _imagen As Byte()

    Public Property imagen() As Byte()
        Get
            Return _imagen
        End Get
        Set(ByVal value As Byte())
            _imagen = value
        End Set
    End Property
End Class
