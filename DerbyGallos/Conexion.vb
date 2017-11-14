Option Explicit On
Option Strict On

Imports System.Data.SqlClient

Public Class Conexion

    Dim cadena As String
    Dim conexion As SqlConnection
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Dim dset As New DataSet

    ''' <summary>
    ''' Constructor por defecto con configuracion de base de datos.
    ''' </summary>
    Sub New()
        cadena = "Data Source=LAPVICENTE\SQLSERVER2016 ;Initial Catalog=DERBYGALLOS;User ID=sa;Password=a"
        conexion = New SqlConnection(cadena)
    End Sub

    ''' <summary>
    ''' Constructor con configuracion de base de datos.
    ''' </summary>
    ''' <param name="config"></param>
    Sub New(ByVal config As ConfiguracionConexion)
        cadena = String.Format(Parametros.cadena_conexion, config.DataSource, config.Catalog, config.User, config.Password)
        conexion = New SqlConnection(cadena)
    End Sub

    ''' <summary>
    ''' Prueba
    ''' </summary>
    ''' <param name="codigoSql"></param>
    ''' <param name="tablas"></param>
    ''' <param name="formulario"></param>
    Public Sub ComandoSQL(ByVal codigoSql As String, ByVal tablas As String, ByVal formulario As Integer)
        cmd.Connection = conexion
        cmd.CommandText = codigoSql
        conexion.Open()
        dr = cmd.ExecuteReader()
        dset.Load(dr, LoadOption.PreserveChanges, (tablas))

        Select Case (formulario)
            Case 1

        End Select

    End Sub

    ''' <summary>
    ''' Ejecuta un Stored Procedure dado y devuelve un DataSet
    ''' </summary>
    ''' <param name="NombreSP"></param>
    ''' <returns></returns>
    Private Function EjecutaSP(ByVal NombreSP As String) As DataSet

        cmd.Connection = conexion
        cmd.CommandText = NombreSP
        conexion.Open()
        dr = cmd.ExecuteReader()
        dset.Load(dr, LoadOption.PreserveChanges, ("Catalago_Partidos"))
        conexion.Close()

        Return dset

    End Function

    ''' <summary>
    ''' Obtiene los partidos registrados
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetPartidos() As List(Of Partido)

        Dim ds As DataSet
        ds = EjecutaSP(StoredProcedures.partido_get)

        Return GetPartidoList(ds)

    End Function

    ''' <summary>
    ''' Obtiene la lista de partidos registrados de un DataSet.
    ''' </summary>
    ''' <param name="ds"></param>
    ''' <returns></returns>
    Private Function GetPartidoList(ByVal ds As DataSet) As List(Of Partido)

        Dim list As New List(Of Partido)
        Dim partido As Partido


        If ds Is Nothing Then

            Return list

        Else
            For Each row As DataRow In ds.Tables(0).Rows

                partido = New Partido
                partido.Id = CInt(row("Idpartido"))
                partido.descripcion = CStr(row("descripcion"))
                partido.clave = CStr(row("clave"))
                partido.Peso = CInt(row("pesogramo"))
                partido.tipo = CStr(row("tipo"))
                partido.Anillo = CInt(row("Anillo"))
                partido.Ronda = CInt(row("Ronda"))
                list.Add(partido)

            Next

        End If

        Return list

    End Function

    ''' <summary>
    ''' Guarda una partida en la base de datos.
    ''' </summary>
    ''' <param name="partido"></param>
    Public Sub GuardaPartido(ByVal partido As Partido)
        cmd.Connection = conexion
        conexion.Open()

        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = StoredProcedures.partido_insert

        With cmd.Parameters
            .Clear()
            .Add(Parametros.parametro_descripcion, partido.Descripcion)
            .Add(Parametros.parametro_clave, partido.clave)
            .Add(Parametros.parametro_peso, partido.Peso)
            .Add(Parametros.parametro_anillo, partido.Anillo)
            .Add(Parametros.parametro_tipo, "G")
        End With

        cmd.ExecuteNonQuery()
        conexion.Close()

    End Sub

    ''' <summary>
    ''' Actualiza la informacion de un partido.
    ''' </summary>
    ''' <param name="partido"></param>
    Public Sub ActualizaPartido(ByVal partido As Partido)
        cmd.Connection = conexion
        conexion.Open()

        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = StoredProcedures.partido_update

        With cmd.Parameters
            .Clear()
            .Add(Parametros.parametro_descripcion, partido.Descripcion)
            .Add(Parametros.parametro_clave, partido.clave)
            .Add(Parametros.parametro_peso, partido.Peso)
            .Add(Parametros.parametro_anillo, partido.Anillo)
            .Add(Parametros.parametro_tipo, "G")
        End With

        cmd.ExecuteNonQuery()
        conexion.Close()
    End Sub

    ''' <summary>
    ''' Actualiza la informacion de un partido.
    ''' </summary>
    ''' <param name="partido"></param>
    Public Sub EliminaPartido(ByVal partido As Partido)
        cmd.Connection = conexion
        conexion.Open()

        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = StoredProcedures.partido_delete

        With cmd.Parameters
            .Clear()
            .Add(Parametros.parametro_id, partido.Id)
        End With

        cmd.ExecuteNonQuery()
        conexion.Close()
    End Sub

    ''' <summary>
    ''' Actualiza la informacion de un partido.
    ''' </summary>
    Public Sub EliminaPartidos()

        cmd.Connection = conexion
        conexion.Open()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = StoredProcedures.partido_delete_all
        cmd.ExecuteNonQuery()
        conexion.Close()

    End Sub


End Class