Option Explicit On
Option Strict On

Public Class SorteoClass

    Private _nomplaza As String
    Private _fechaderby As DateTime
    Private _numronda As Integer
    Private _idpartido_1 As Integer
    Private _nompartido_1 As String
    Private _clavepartido_1 As String
    Private _pesogallo_1 As Integer
    Private _anillogallo_1 As Integer
    Private _idpartido_2 As Integer
    Private _nompartido_2 As String
    Private _clavepartido_2 As String
    Private _pesogallo_2 As Integer
    Private _anillogallo_2 As Integer
    Private _diferencia As Integer
    Private _numeroPelea As Integer

    Public Property Nomplaza As String
        Get
            Return _nomplaza
        End Get
        Set(value As String)
            _nomplaza = value
        End Set
    End Property

    Public Property Fechaderby As Date
        Get
            Return _fechaderby
        End Get
        Set(value As Date)
            _fechaderby = value
        End Set
    End Property

    Public Property Numronda As Integer
        Get
            Return _numronda
        End Get
        Set(value As Integer)
            _numronda = value
        End Set
    End Property

    Public Property Idpartido_1 As Integer
        Get
            Return _idpartido_1
        End Get
        Set(value As Integer)
            _idpartido_1 = value
        End Set
    End Property

    Public Property Nompartido_1 As String
        Get
            Return _nompartido_1
        End Get
        Set(value As String)
            _nompartido_1 = value
        End Set
    End Property

    Public Property Clavepartido_1 As String
        Get
            Return _clavepartido_1
        End Get
        Set(value As String)
            _clavepartido_1 = value
        End Set
    End Property

    Public Property Pesogallo_1 As Integer
        Get
            Return _pesogallo_1
        End Get
        Set(value As Integer)
            _pesogallo_1 = value
        End Set
    End Property

    Public Property Anillogallo_1 As Integer
        Get
            Return _anillogallo_1
        End Get
        Set(value As Integer)
            _anillogallo_1 = value
        End Set
    End Property

    Public Property Idpartido_2 As Integer
        Get
            Return _idpartido_2
        End Get
        Set(value As Integer)
            _idpartido_2 = value
        End Set
    End Property

    Public Property Nompartido_2 As String
        Get
            Return _nompartido_2
        End Get
        Set(value As String)
            _nompartido_2 = value
        End Set
    End Property

    Public Property Clavepartido_2 As String
        Get
            Return _clavepartido_2
        End Get
        Set(value As String)
            _clavepartido_2 = value
        End Set
    End Property

    Public Property Pesogallo_2 As Integer
        Get
            Return _pesogallo_2
        End Get
        Set(value As Integer)
            _pesogallo_2 = value
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

    Public Property Anillogallo_2 As Integer
        Get
            Return _anillogallo_2
        End Get
        Set(value As Integer)
            _anillogallo_2 = value
        End Set
    End Property

    Public Property NumeroPelea As Integer
        Get
            Return _numeroPelea
        End Get
        Set(value As Integer)
            _numeroPelea = value
        End Set
    End Property
End Class
