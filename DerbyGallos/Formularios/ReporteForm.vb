Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class ReporteForm

    Private _nombreReporte As String
    Private _parametros As Dictionary(Of String, String)

    Private _registro As RegistroWindows
    Private configReportes As New ConfiguracionConexion

    Private oConexInfo As ConnectionInfo
    Private oListaTablas As Tables
    Private oTabla As Table
    Private oTablaConexInfo As TableLogOnInfo

    ''' <summary>
    ''' Nombre del reporte.
    ''' </summary>
    ''' <returns></returns>
    Public Property NombreReporte As String
        Get
            Return _nombreReporte
        End Get
        Set(value As String)
            _nombreReporte = value
        End Set
    End Property

    ''' <summary>
    ''' Parametros para el reporte.
    ''' </summary>
    ''' <returns></returns>
    Public Property Parametros As Dictionary(Of String, String)
        Get
            Return _parametros
        End Get
        Set(value As Dictionary(Of String, String))
            _parametros = value
        End Set
    End Property

    ''' <summary>
    ''' Carga inicial del formulario.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ReporteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim rpt_id As New ReportDocument
        Dim reporteRuta As String

        Me.Text = _nombreReporte

        _registro = New RegistroWindows
        configReportes = _registro.ConfiguracionGet()
        reporteRuta = String.Concat(configReportes.RutaReportes, _nombreReporte)

        ' instanciar objeto para guardar datos de conexión
        oConexInfo = New ConnectionInfo()
        oConexInfo.ServerName = configReportes.DataSource
        oConexInfo.DatabaseName = configReportes.Catalog
        oConexInfo.UserID = configReportes.User
        oConexInfo.Password = configReportes.Password

        ' Comprobamos la existencia del reporte, si el reporte no existe abortamos si no continuamos
        ' Application.StartupPath & "Pruebas.rpt"
        If Not IO.File.Exists(reporteRuta) Then
            MessageBox.Show("No se encontro reporte:" & vbCrLf & reporteRuta, "Report Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Exit Sub
        End If

        'Una vez verificado el reporte procedemos a cargarlo
        rpt_id.Load(reporteRuta)
        oListaTablas = rpt_id.Database.Tables
        For Each oTabla In oListaTablas
            oTablaConexInfo = oTabla.LogOnInfo
            oTablaConexInfo.ConnectionInfo = oConexInfo
            oTabla.ApplyLogOnInfo(oTablaConexInfo)
        Next

        ' Si tiene parámetros los agrega
        If _parametros.Count > 0 Then
            For Each parametro As KeyValuePair(Of String, String) In _parametros
                rpt_id.SetParameterValue(parametro.Key, parametro.Value)
            Next
        End If

        Me.CrystalReportViewer1.ReportSource = rpt_id

    End Sub

End Class