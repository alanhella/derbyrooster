Public Class Partido

    Private _IdPartido As Integer
    Private _descripcion As String
    Private _clave As String
    Private _PesoGramo As Integer
    Private _tipo As String
    Private _anillo As Integer
    Private _ronda As Integer

    Private _gana As Boolean
    Private _pierde As Boolean
    Private _tablas As Boolean


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
            _pierde = Not value
            _tablas = Not value
        End Set
    End Property

    Public Property Pierde As Boolean
        Get
            Return _pierde
        End Get
        Set(value As Boolean)
            _pierde = value
            _gana = Not value
            _tablas = Not value
        End Set
    End Property

    Public Property Tablas As Boolean
        Get
            Return _tablas
        End Get
        Set(value As Boolean)
            _tablas = value
            _gana = Not value
            _pierde = Not value
        End Set
    End Property
End Class
