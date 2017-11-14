Option Strict On
Option Explicit On

Public Class ConfiguracionPlazaForm

    Private _registro As RegistroWindows
    Private _configuracion As ConfiguracionPlaza

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

        _configuracion = _registro.ConfiguracionPlazaGet()

        Me.TextBoxDescripcion.DataBindings.Add(New Binding("Text", _configuracion, "Descripcion"))
        Me.TextBoxNumeroGallos.DataBindings.Add(New Binding("Text", _configuracion, "NumeroGallos"))

    End Sub

    ''' <summary>
    ''' Guarda y cierra.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        _registro = New RegistroWindows
        _registro.ConfiguracionPlazaUpdate(_configuracion)
        MessageBox.Show(Me, "Configuración guardada con éxito.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub
End Class