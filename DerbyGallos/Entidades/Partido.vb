Public Class Partido

    Private _IdPartido As Integer
    Private _descripcion As String
    Private _clave As String
    Private _PesoGramo As Integer
    Private _tipo As String
    Private _anillo As Integer
    Private _ronda As Integer

    'Datos de resultados de pelea
    Private _gana As Boolean
    Private _pierde As Boolean
    Private _tablas As Boolean
    Private _fecha As DateTime

    'Datos de sorteo
    Private _pelea As Integer
    Private _diferencia As Integer

    Public Property Id() As Integer
        Get
            Return _IdPartido
        End Get
        Set(value As Integer)
            _IdPartido = value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property
    Public Property Clave() As String
        Get
            Return _clave
        End Get
        Set(value As String)
            _clave = value
        End Set
    End Property
    Public Property Peso() As Integer
        Get
            Return _PesoGramo
        End Get
        Set(value As Integer)
            _PesoGramo = value
        End Set
    End Property

    Public Property Tipo As String
        Get
            Return _tipo
        End Get
        Set(value As String)
            _tipo = value
        End Set
    End Property

    Public Property Anillo() As Integer
        Get
            Return _anillo
        End Get
        Set(value As Integer)
            _anillo = value
        End Set
    End Property

    Public Property Ronda As Integer
        Get
            Return _ronda
        End Get
        Set(value As Integer)
            _ronda = value
        End Set
    End Property

    Public Property Gana As Boolean
        Get
            Return _gana
        End Get
        Set(value As Boolean)
            _gana = value
        End Set
    End Property

    Public Property Pierde As Boolean
        Get
            Return _pierde
        End Get
        Set(value As Boolean)
            _pierde = value
        End Set
    End Property

    Public Property Tablas As Boolean
        Get
            Return _tablas
        End Get
        Set(value As Boolean)
            _tablas = value
        End Set
    End Property

    Public Property Pelea As Integer
        Get
            Return _pelea
        End Get
        Set(value As Integer)
            _pelea = value
        End Set
    End Property

    Public Property Diferencia As Integer
        Get
            Return _diferencia
        End Get
        Set(value As Integer)
            _diferencia = value
        End Set
    End Property

    Public Property Fecha As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            _fecha = value
        End Set
    End Property
End Class
