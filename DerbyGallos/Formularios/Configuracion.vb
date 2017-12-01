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
        Me.TextBoxRutaReportes.DataBindings.Add(New Binding("Text", _configuracion, "RutaReportes"))

    End Sub

    ''' <summary>
    ''' Actualiza la informacion de conexión en el registro de Windows.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.SelectNextControl(Me.ActiveControl, True, False, True, True)

        If Validaciones() Then
            _registro = New RegistroWindows
            _registro.ConfiguracionUpdate(_configuracion)
            MessageBox.Show(Me, "Configuración guardada con éxito.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If

    End Sub

    ''' <summary>
    ''' Determinan si se puede guardar la configuracion.
    ''' </summary>
    ''' <returns></returns>
    Private Function Validaciones() As Boolean

        If IsNothing(_configuracion.DataSource) OrElse _configuracion.DataSource = String.Empty Then
            MessageBox.Show(Me, "Debe ingresar el nombre del servidor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If IsNothing(_configuracion.Catalog) OrElse _configuracion.Catalog = String.Empty Then
            MessageBox.Show(Me, "Debe ingresar el nombre de la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If IsNothing(_configuracion.User) OrElse _configuracion.User = String.Empty Then
            MessageBox.Show(Me, "Debe ingresar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If IsNothing(_configuracion.Password) OrElse _configuracion.Password = String.Empty Then
            MessageBox.Show(Me, "Debe ingresar la contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If IsNothing(_configuracion.RutaReportes) OrElse _configuracion.RutaReportes = String.Empty Then
            MessageBox.Show(Me, "Debe ingresar la ruta de los reportes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True

    End Function
End Class