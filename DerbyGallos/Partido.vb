Public Class Partido

    Private _IdPartido As Integer
    Private _descripcion As String
    Private _clave As String
    Private _PesoGramo As Integer
    Private _tipo As String
    Private _anillo As Integer

    Public Property IdPartido() As Integer
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
    Public Property clave() As String
        Get
            Return _clave
        End Get
        Set(value As String)
            _clave = value
        End Set
    End Property
    Public Property PesoGramo() As Integer
        Get
            Return _PesoGramo
        End Get
        Set(value As Integer)
            _PesoGramo = value
        End Set
    End Property

    Public Property tipo As String
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


End Class
