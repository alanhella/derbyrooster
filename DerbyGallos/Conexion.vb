Option Explicit On
Option Strict On

Imports System.Data.SqlClient
Imports System.Text
Imports DerbyGallos

Public Class Conexion

    Dim cadena As String
    Dim conexion As SqlConnection
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Dim dset As DataSet

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
    ''' Especifica si se ha podido realizar la conexión a la base de datos.
    ''' </summary>
    ''' <returns></returns>
    Public Function CheckConnection() As Boolean

        Try
            conexion.Open()

            If conexion.State = ConnectionState.Open Then
                conexion.Close()
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Return False
        End Try

    End Function

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
        dset = New DataSet
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
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Clear()
        cmd.CommandText = NombreSP
        conexion.Open()
        dr = cmd.ExecuteReader()
        dset = New DataSet
        dset.Load(dr, LoadOption.PreserveChanges, ("Catalago_Partidos"))
        conexion.Close()

        Return dset

    End Function

    ''' <summary>
    ''' Ejecuta un Stored Procedure dado y devuelve un DataSet
    ''' </summary>
    ''' <param name="NombreSP"></param>
    ''' <param name="parameters"></param>
    Private Sub EjecutaSPyParametros(ByVal NombreSP As String, ByVal parameters As Dictionary(Of String, String))

        Dim filasAfectadas As Integer

        cmd.Connection = conexion
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Clear()
        For Each parameter As KeyValuePair(Of String, String) In parameters
            cmd.Parameters.Add(parameter.Key, parameter.Value)
        Next

        cmd.CommandText = NombreSP
        conexion.Open()
        filasAfectadas = cmd.ExecuteNonQuery()
        conexion.Close()

    End Sub

    ''' <summary>
    ''' Obtiene los partidos registrados
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetPartidos() As List(Of Partido)

        Dim ds As New DataSet
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
                partido.Descripcion = CStr(row("descripcion"))
                partido.Clave = CStr(row("clave"))
                partido.Peso = CInt(row("pesogramo"))
                partido.Tipo = CStr(row("tipo"))
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

        Dim parameters As New Dictionary(Of String, String)

        With parameters
            .Add(Parametros.parametro_descripcion, partido.Descripcion)
            .Add(Parametros.parametro_clave, partido.Clave)
            .Add(Parametros.parametro_peso, partido.Peso.ToString)
            .Add(Parametros.parametro_anillo, partido.Anillo.ToString)
            .Add(Parametros.parametro_tipo, "G")
        End With

        EjecutaSPyParametros(StoredProcedures.partido_insert, parameters)

    End Sub

    ''' <summary>
    ''' Actualiza la informacion de un partido.
    ''' </summary>
    ''' <param name="partido"></param>
    Public Sub ActualizaPartido(ByVal partido As Partido)

        Dim parameters As New Dictionary(Of String, String)

        With parameters
            .Add(Parametros.parametro_descripcion, partido.Descripcion)
            .Add(Parametros.parametro_clave, partido.Clave)
            .Add(Parametros.parametro_peso, partido.Peso.ToString)
            .Add(Parametros.parametro_anillo, partido.Anillo.ToString)
            .Add(Parametros.parametro_tipo, "G")
        End With

        EjecutaSPyParametros(StoredProcedures.partido_update, parameters)

    End Sub

    ''' <summary>
    ''' Actualiza la informacion de un partido.
    ''' </summary>
    ''' <param name="partido"></param>
    Public Sub EliminaPartido(ByVal partido As Partido)

        Dim parameters As New Dictionary(Of String, String)

        With parameters
            .Clear()
            .Add(Parametros.parametro_id, partido.Id.ToString)
            .Add(Parametros.parametro_descripcion, partido.Descripcion)
            .Add(Parametros.parametro_clave, partido.Clave)
            .Add(Parametros.parametro_peso, partido.Peso.ToString)
        End With

        EjecutaSPyParametros(StoredProcedures.partido_delete, parameters)

    End Sub

    ''' <summary>
    ''' Actualiza la informacion de un partido.
    ''' </summary>
    Public Sub EliminaPartidos()

        EjecutaSP(StoredProcedures.partido_delete_all)

    End Sub

    ''' <summary>
    ''' Guarda el sorteo de partidos.
    ''' </summary>
    ''' <param name="lista"></param>
    Public Sub GuardaPartidoSorteo(ByVal lista As List(Of SorteoClass))

        Dim xml As New StringBuilder
        Dim xml_head As String = "<SorteoXML>{0}</SorteoXML>"
        Dim xml_value As String = "<Sorteo nomplaza=""{0}"" fechaderby=""{1}"" numronda=""{2}"" idpartido_1=""{3}"" nompartido_1=""{4}"" clavepartido_1=""{5}"" pesogallo_1=""{6}"" anillogallo_1=""{7}"" idpartido_2=""{8}"" nompartido_2=""{9}"" clavepartido_2=""{10}"" pesogallo_2=""{11}"" anillogallo_2=""{12}"" diferencia=""{13}"" numeroPelea=""{14}"" />"

        For Each sorteo As SorteoClass In lista
            '2017-11-28 22:13:58.383
            xml.Append(String.Format(xml_value, sorteo.Nomplaza, sorteo.Fechaderby.ToString("yyyy-MM-dd HH:mm:ss"), sorteo.Numronda _
                                     , sorteo.Idpartido_1, sorteo.Nompartido_1, sorteo.Clavepartido_1, sorteo.Pesogallo_1, sorteo.Anillogallo_1 _
                                     , sorteo.Idpartido_2, sorteo.Nompartido_2, sorteo.Clavepartido_2, sorteo.Pesogallo_2, sorteo.Anillogallo_2 _
                                     , sorteo.Diferencia, sorteo.NumeroPelea))

        Next

        Dim xmlToSave As String

        xmlToSave = String.Format(xml_head, xml)

        Dim paramaters As New Dictionary(Of String, String)

        paramaters.Add("@Xml", xmlToSave)

        EjecutaSPyParametros("spSorteoInsert", paramaters)

    End Sub

    ''' <summary>
    ''' Guarda los resultados del sorteo.
    ''' </summary>
    ''' <param name="listaPartidos"></param>
    Friend Sub GuardaSorteoResultado(ByVal listaPartidos As List(Of Partido))

        Dim xml As New StringBuilder
        Dim xml_head As String
        Dim xml_value As String

        xml_head = "<Resultado>{0}</Resultado>"
        xml_value = "<Resultado Fecha=""{0}"" Id=""{1}"" Pelea=""{2}"" Ronda=""{3}"" Partido=""{4}"" Clave=""{5}"" Tipo=""{6}"" Peso=""{7}"" Anillo=""{8}"" Gana=""{9}"" Pierde=""{10}"" Tablas=""{11}"" />"

        For Each partido As Partido In listaPartidos
            xml.Append(String.Format(xml_value, partido.Fecha.ToString("yyyy-MM-dd HH:mm:ss"), partido.Id, partido.Pelea, partido.Ronda, partido.Descripcion _
                                     , partido.Clave, partido.Tipo, partido.Peso, partido.Anillo, IIf(partido.Gana, 1, 0), IIf(partido.Pierde, 1, 0), IIf(partido.Tablas, 1, 0)))
        Next

        Dim xmlToSave As String

        xmlToSave = String.Format(xml_head, xml)

        Dim paramaters As New Dictionary(Of String, String)

        paramaters.Add("@Xml", xmlToSave)

        EjecutaSPyParametros("sp_SorteoResultadoInsert", paramaters)

    End Sub
End Class