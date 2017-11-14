Option Explicit On
Option Strict On

Public Class RegistroWindows

    Private Const key_principal As String = "DerbyGallosApp"
    Private Const registry_key_principal As String = "HKEY_CURRENT_USER\DerbyGallosApp"
    Private Const registry_sub_key_datasourse As String = "derby_datasourse"
    Private Const registry_sub_key_catalog As String = "derby_catalog"
    Private Const registry_sub_key_user As String = "derby_user"
    Private Const registry_sub_key_password As String = "derby_password"

    Private Const registry_sub_key_plaza_descripcion As String = "plaza_descripcion"
    Private Const registry_sub_key_numero_gallos As String = "numero_gallos"

    Private Const _key As String = "a83dfbb3-fde3-40e9-8dda-74327ba9aa1f"

    Dim encriptador As MyEncrypt.Encryptor

    ''' <summary>
    ''' Guarda la configuracion de la base de datos.
    ''' </summary>
    Public Sub ConfiguracionSave()

        If My.Computer.Registry.CurrentUser.OpenSubKey(key_principal) Is Nothing Then
            My.Computer.Registry.CurrentUser.CreateSubKey(key_principal)
        End If

    End Sub

    ''' <summary>
    ''' Guarda la configuracion de la base de datos.
    ''' </summary>
    ''' <param name="configuracion"></param>
    Public Sub ConfiguracionUpdate(ByVal configuracion As ConfiguracionConexion)

        ConfiguracionSave()

        encriptador = New MyEncrypt.Encryptor

        Dim passwordEncrypt As String
        passwordEncrypt = encriptador.Encrypt(_key, configuracion.Password)

        My.Computer.Registry.SetValue(registry_key_principal, registry_sub_key_datasourse, configuracion.DataSource)
        My.Computer.Registry.SetValue(registry_key_principal, registry_sub_key_catalog, configuracion.Catalog)
        My.Computer.Registry.SetValue(registry_key_principal, registry_sub_key_user, configuracion.User)
        My.Computer.Registry.SetValue(registry_key_principal, registry_sub_key_password, passwordEncrypt)

    End Sub

    ''' <summary>
    ''' Guarda la configuracion de la plaza.
    ''' </summary>
    ''' <param name="configuracion"></param>
    Public Sub ConfiguracionPlazaUpdate(ByVal configuracion As ConfiguracionPlaza)

        ConfiguracionSave()

        My.Computer.Registry.SetValue(registry_key_principal, registry_sub_key_plaza_descripcion, configuracion.Descripcion)
        My.Computer.Registry.SetValue(registry_key_principal, registry_sub_key_numero_gallos, configuracion.NumeroGallos)

    End Sub

    ''' <summary>
    ''' Obtiene la configuración de Base de datos del registro de Windows.
    ''' </summary>
    ''' <returns></returns>
    Public Function ConfiguracionGet() As ConfiguracionConexion

        Dim config As New ConfiguracionConexion
        Dim passwordDesencriptado As String
        encriptador = New MyEncrypt.Encryptor

        If My.Computer.Registry.GetValue(registry_key_principal, registry_sub_key_datasourse, Nothing) Is Nothing Then
            config.DataSource = String.Empty
        Else
            config.DataSource = My.Computer.Registry.GetValue(registry_key_principal, registry_sub_key_datasourse, Nothing).ToString
        End If

        If My.Computer.Registry.GetValue(registry_key_principal, registry_sub_key_catalog, Nothing) Is Nothing Then
            config.Catalog = String.Empty
        Else
            config.Catalog = My.Computer.Registry.GetValue(registry_key_principal, registry_sub_key_catalog, Nothing).ToString
        End If

        If My.Computer.Registry.GetValue(registry_key_principal, registry_sub_key_user, Nothing) Is Nothing Then
            config.User = String.Empty
        Else
            config.User = My.Computer.Registry.GetValue(registry_key_principal, registry_sub_key_user, Nothing).ToString
        End If

        If My.Computer.Registry.GetValue(registry_key_principal, registry_sub_key_password, Nothing) Is Nothing Then
            config.Password = String.Empty
        Else
            passwordDesencriptado = encriptador.Decrypt(_key, My.Computer.Registry.GetValue(registry_key_principal, registry_sub_key_password, Nothing).ToString)
            config.Password = passwordDesencriptado
        End If

        Return config

    End Function

    ''' <summary>
    ''' Obtiene la configuración de la plaza.
    ''' </summary>
    ''' <returns></returns>
    Public Function ConfiguracionPlazaGet() As ConfiguracionPlaza
        Dim config As New ConfiguracionPlaza

        If My.Computer.Registry.GetValue(registry_key_principal, registry_sub_key_datasourse, Nothing) Is Nothing Then
            config.Descripcion = String.Empty
        Else
            config.Descripcion = My.Computer.Registry.GetValue(registry_key_principal, registry_sub_key_plaza_descripcion, Nothing).ToString
        End If

        If My.Computer.Registry.GetValue(registry_key_principal, registry_sub_key_datasourse, Nothing) Is Nothing Then
            config.NumeroGallos = 0
        Else
            config.NumeroGallos = CInt(My.Computer.Registry.GetValue(registry_key_principal, registry_sub_key_numero_gallos, Nothing).ToString)
        End If

        Return config
    End Function

End Class
