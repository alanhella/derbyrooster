Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class ReporteCrystal

    Private Sub ReporteCrystal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim _registro As RegistroWindows
        Dim configReportes As New ConfiguracionConexion

        _registro = New RegistroWindows
        configReportes = _registro.ConfiguracionGet()

        ' ---------------------------By CesarL--------------
        ' SETEANDO CONEXION PARA CR
        Dim oConexInfo As ConnectionInfo
        Dim oListaTablas As Tables
        Dim oTabla As Table
        Dim oTablaConexInfo As TableLogOnInfo
        ' instanciar objeto para guardar datos de conexión
        oConexInfo = New ConnectionInfo()
        oConexInfo.ServerName = configReportes.DataSource
        oConexInfo.DatabaseName = configReportes.Catalog
        oConexInfo.UserID = configReportes.User
        oConexInfo.Password = configReportes.Password

        Dim rpt_id As New ReportDocument
        ' Comprobamos la existencia del reporte, si el reporte no existe abortamos si no continuamos
        Dim Reporte As String = "C:\Reportes\SorteoRonda.rpt"
        'Application.StartupPath & "Pruebas.rpt"
        If Not IO.File.Exists(Reporte) Then
            MessageBox.Show("No se encontro reporte:" & vbCrLf & _
            Reporte, "Report Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Exit Sub
        End If
        'Una vez verificado el reporte procedemos a cargarlo
        rpt_id.Load(Reporte)
        oListaTablas = rpt_id.Database.Tables
        For Each oTabla In oListaTablas
            oTablaConexInfo = oTabla.LogOnInfo
            oTablaConexInfo.ConnectionInfo = oConexInfo
            oTabla.ApplyLogOnInfo(oTablaConexInfo)
        Next
        'ENVIANDO VARIABLE A CR
        'rpt_id.SetParameterValue("@id", 1)
        Me.CrystalReportViewer1.ReportSource = rpt_id
    End Sub


End Class



