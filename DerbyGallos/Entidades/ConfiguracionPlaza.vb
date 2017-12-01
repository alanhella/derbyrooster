Public Class ConfiguracionPlaza

    Private _descripcion As String
    Private _numeroGallos As Integer
    Private _diferenciaMaxima As Integer
    Private _palenqueDescripcion As String

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

    Public Property DiferenciaMaxima As Integer
        Get
            Return _diferenciaMaxima
        End Get
        Set(value As Integer)
            _diferenciaMaxima = value
        End Set
    End Property

    Public Property PalenqueDescripcion As String
        Get
            Return _palenqueDescripcion
        End Get
        Set(value As String)
            _palenqueDescripcion = value
        End Set
    End Property
End Class
