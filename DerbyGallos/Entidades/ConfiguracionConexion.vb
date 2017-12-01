Public Class ConfiguracionConexion

    Private _dataSource As String
    Private _catalog As String
    Private _user As String
    Private _password As String

    Private _rutaReportes As String

    Public Property DataSource As String
        Get
            Return _dataSource
        End Get
        Set(value As String)
            _dataSource = value
        End Set
    End Property

    Public Property Catalog As String
        Get
            Return _catalog
        End Get
        Set(value As String)
            _catalog = value
        End Set
    End Property

    Public Property User As String
        Get
            Return _user
        End Get
        Set(value As String)
            _user = value
        End Set
    End Property

    Public Property Password As String
        Get
            Return _password
        End Get
        Set(value As String)
            _password = value
        End Set
    End Property

    Public Property RutaReportes As String
        Get
            Return _rutaReportes
        End Get
        Set(value As String)
            _rutaReportes = value
        End Set
    End Property

End Class
