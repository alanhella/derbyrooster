Option Explicit On
Option Strict On

Imports System.Data.SqlClient


Public Class Conexion

    Dim cadena As String = "Data Source=LAPVICENTE\SQLSERVER2016 ;Initial Catalog=DERBYGALLOS;User ID=sa;Password=a"
    Dim conexion As New SqlConnection(cadena)
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Dim dset As New DataSet

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

    Private Function EjecutaSP(ByVal NombreSP As String) As DataSet

        cmd.Connection = conexion
        cmd.CommandText = NombreSP
        conexion.Open()
        dr = cmd.ExecuteReader()
        dset.Load(dr, LoadOption.PreserveChanges, ("Catalago_Partidos"))

        Return dset

        conexion.Close()

    End Function

    ''' <summary>
    ''' Obtiene los partidos registrados
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetPartidos() As List(Of Partido)

        Dim ds As DataSet
        ds = EjecutaSP("sp_GetPartidos")

        Return GetPartidoList(ds)

    End Function

    Private Function GetPartidoList(ByVal ds As DataSet) As List(Of Partido)

        Dim list As New List(Of Partido)
        Dim partido As Partido


        If ds Is Nothing Then

            Return list

        Else
            For Each row As DataRow In ds.Tables(0).Rows

                partido = New Partido
                partido.IdPartido = CInt(row("Idpartido"))
                partido.descripcion = CStr(row("descripcion"))
                partido.clave = CStr(row("clave"))
                partido.PesoGramo = CInt(row("pesogramo"))
                partido.tipo = CStr(row("tipo"))
                partido.Anillo = CInt(row("Anillo"))
                list.Add(partido)

            Next

        End If

        Return list

    End Function

    Public Sub GuardaPartida(ByVal partido As Partido)
        cmd.Connection = conexion
        conexion.Open()

        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_Partidoinsert"
        cmd.Parameters.Clear()
        cmd.Parameters.Add("@Descripcion", partido.Descripcion)
        cmd.Parameters.Add("@Clave", partido.clave)
        cmd.Parameters.Add("@Peso", partido.PesoGramo)
        cmd.Parameters.Add("@Anillo", partido.Anillo)
        cmd.Parameters.Add("@Tipo", "G")
        cmd.ExecuteNonQuery()

        conexion.Close()

    End Sub



End Class