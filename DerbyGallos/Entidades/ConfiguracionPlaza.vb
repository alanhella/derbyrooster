Public Class ConfiguracionPlaza

    Private _descripcion As String
    Private _numeroGallos As Integer

    Public Property Descripcion As String
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property

    Public Property NumeroGallos As Integer
        Get
            Return _numeroGallos
        End Get
        Set(value As Integer)
            _numeroGallos = value
        End Set
    End Property

End Class
