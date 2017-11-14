Option Strict On
Option Explicit On

Public Class Configuracion
    Private _registro As RegistroWindows
    Private _configuracion As ConfiguracionConexion

    ''' <summary>
    ''' Carga inical del formulario.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Configuracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaConfiguracion()
    End Sub

    ''' <summary>
    ''' Obtiene y asigna la configuracion de la base de datos.
    ''' </summary>
    Private Sub CargaConfiguracion()

        _registro = New RegistroWindows

        _configuracion = _registro.ConfiguracionGet()

        Me.TextBoxServidor.DataBindings.Add(New Binding("Text", _configuracion, "DataSource"))
        Me.TextBoxBaseDatos.DataBindings.Add(New Binding("Text", _configuracion, "Catalog"))
        Me.TextBoxUsuario.DataBindings.Add(New Binding("Text", _configuracion, "User"))
        Me.TextBoxPassword.DataBindings.Add(New Binding("Text", _configuracion, "Password"))

    End Sub

    ''' <summary>
    ''' Actualiza la informacion de conexión en el registro de Windows.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        _registro = New RegistroWindows
        _registro.ConfiguracionUpdate(_configuracion)
        MessageBox.Show(Me, "Configuración guardada con éxito.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub
End Class