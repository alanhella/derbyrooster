Option Explicit On
Option Strict On
Imports System.Text.RegularExpressions

Public Class Menu

    ' Definicion de Variables
    Private _partido As Partido
    Private _conexion As New Conexion
    Private lista As IList(Of Partido)
    Private registro As RegistroWindows

    ''' <summary>
    ''' Carga inicial del formulario.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        registro = New RegistroWindows
        If registro.ConfiguracionGet.DataSource = String.Empty Then
            MessageBox.Show(Me, "Es necesario configurar los datos de conexión.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        Else
            _conexion = New Conexion(registro.ConfiguracionGet)
        End If

        InicializaListas()

    End Sub

    ''' <summary>
    ''' Configura y carga las tablas.
    ''' </summary>
    Private Sub InicializaListas()
        _partido = New Partido

        txtPartidos.DataBindings.Clear()
        txtClave.DataBindings.Clear()
        txtPeso.DataBindings.Clear()
        txtAnillo.DataBindings.Clear()

        txtPartidos.DataBindings.Add(New Binding("Text", _partido, "Descripcion"))
        txtClave.DataBindings.Add(New Binding("Text", _partido, "Clave"))
        txtPeso.DataBindings.Add(New Binding("Text", _partido, "Peso"))
        txtAnillo.DataBindings.Add(New Binding("Text", _partido, "Anillo"))

        CargaLista()
    End Sub

    ''' <summary>
    ''' Carga la lista de partidos guardados.
    ''' </summary>
    Private Sub CargaLista()

        Try
            lista = _conexion.GetPartidos()

            ConfiguraTablaAlta()
            GRIDALTA.DataSource = lista

            label9.Text = String.Concat("Gallos: ", lista.Count.ToString)
            label10.Text = String.Concat("Peleas: ", CInt(lista.Count / 2))
        Catch ex As Exception
            MessageBox.Show(Me, "No se puede obtener la información de la base de datos, verifique su configuración.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    ''' <summary>
    ''' Configura la tabla de lista de partidos.
    ''' </summary>
    Private Sub ConfiguraTablaAlta()

        Dim id As New DataGridViewTextBoxColumn
        Dim descripcion As New DataGridViewTextBoxColumn
        Dim clave As New DataGridViewTextBoxColumn
        Dim pesogranmo As New DataGridViewTextBoxColumn
        Dim tipo As New DataGridViewTextBoxColumn
        Dim anillo As New DataGridViewTextBoxColumn
        Dim gana As New DataGridViewCheckBoxColumn
        Dim pierde As New DataGridViewCheckBoxColumn
        Dim ronda As New DataGridViewTextBoxColumn
        Dim tablas As New DataGridViewCheckBoxColumn

        GRIDALTA.AutoGenerateColumns = False
        GRIDALTA.RowHeadersVisible = False
        GRIDALTA.MultiSelect = False

        With id
            .Name = "id"
            .DataPropertyName = "id"
            .HeaderText = "Id"
            .Width = 30
        End With

        With descripcion
            .Name = "Descripcion"
            .DataPropertyName = "Descripcion"
            .HeaderText = "Partido"
            .Width = 150
        End With

        With clave
            .Name = "Clave"
            .DataPropertyName = "Clave"
            .HeaderText = "Clave"
            .Width = 40
        End With

        With pesogranmo
            .Name = "Peso"
            .DataPropertyName = "Peso"
            .HeaderText = "Peso (gr)"
            .Width = 50
        End With

        With tipo
            .Name = "Tipo"
            .DataPropertyName = "Tipo"
            .HeaderText = "Tipo"
            .Width = 40
        End With

        With anillo
            .Name = "Anillo"
            .DataPropertyName = "Anillo"
            .HeaderText = "Anillo"
            .Width = 50
        End With

        With ronda
            .Name = "Ronda"
            .DataPropertyName = "Ronda"
            .HeaderText = "Ronda"
            .Width = 40
        End With

        With gana
            .Name = "Gana"
            .DataPropertyName = "Gana"
            .HeaderText = "Gana"
            .Width = 40
        End With

        With pierde
            .Name = "Pierde"
            .DataPropertyName = "Pierde"
            .HeaderText = "Pierde"
            .Width = 40
        End With

        With tablas
            .Name = "Tablas"
            .DataPropertyName = "Tablas"
            .HeaderText = "Tablas"
            .Width = 40
        End With

        With GRIDALTA.Columns
            .Clear()
            .Add(id)
            .Add(descripcion)
            .Add(clave)
            .Add(pesogranmo)
            .Add(anillo)
            .Add(gana)
            .Add(pierde)
            .Add(tablas)
            .Add(ronda)
            .Add(tipo)
        End With

    End Sub

    ''' <summary>
    ''' Realiza las validaciones necesarias para agregar un nuevo partido.
    ''' </summary>
    Private Function Validaciones() As Boolean

        Dim gallosMaximos As Integer

        Try
            gallosMaximos = CInt(txtNumGallos.Text)
        Catch ex As Exception
            gallosMaximos = 0
        End Try

        If Not gallosMaximos > 0 Then
            MessageBox.Show(Me, Mensajes.requiere_numero_gallos, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Exit Function
        End If

        If IsNothing(_partido.Descripcion) OrElse _partido.Descripcion.Trim = String.Empty Then
            MessageBox.Show(Me, Mensajes.debe_ingresar_descripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Exit Function
        End If

        If IsNothing(_partido.Clave) OrElse _partido.Clave.Trim = String.Empty Then
            MessageBox.Show(Me, Mensajes.debe_ingresar_clave, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Exit Function
        End If

        If IsNothing(_partido.Peso) OrElse _partido.Peso = 0 Then
            MessageBox.Show(Me, Mensajes.debe_ingresar_peso, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Exit Function
        End If

        If IsNothing(_partido.Anillo) OrElse _partido.Anillo = 0 Then
            MessageBox.Show(Me, Mensajes.debe_ingresar_anillo, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Exit Function
        End If

        If (From partido In lista Where partido.Descripcion.Trim = _partido.Descripcion Select partido).ToList.Count > gallosMaximos Then
            MessageBox.Show(Me, String.Format(Mensajes.maximo_gallos_ingresado, gallosMaximos), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Exit Function
        End If

        Return True

    End Function

    ''' <summary>
    ''' Evento agragar partido.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Me.SelectNextControl(Me.ActiveControl, True, False, True, True)
        If Validaciones() Then
            GuardaPartida()
        End If
    End Sub

    ''' <summary>
    ''' Realiza el guardado de un partido.
    ''' </summary>
    Private Sub GuardaPartida()
        _conexion.GuardaPartido(_partido)
        CargaLista()
    End Sub

    ''' <summary>
    ''' Validación solo números al pegar texto.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub txtNumGallos_TextChanged(sender As Object, e As EventArgs) Handles txtNumGallos.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        txtNumGallos.Text = digitsOnly.Replace(txtNumGallos.Text, "")
    End Sub

    ''' <summary>
    ''' Validación solo números.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub txtNumGallos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumGallos.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ''' <summary>
    ''' Validación solo números.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub txtAnillo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAnillo.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ''' <summary>
    ''' Validación solo números al pegar texto.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub txtAnillo_TextChanged(sender As Object, e As EventArgs) Handles txtAnillo.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        txtNumGallos.Text = digitsOnly.Replace(txtNumGallos.Text, "")
    End Sub

    ''' <summary>
    ''' Elimina todos los registros de la base de datos.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnDepurar_Click(sender As Object, e As EventArgs) Handles btnDepurar.Click
        If MessageBox.Show(Mensajes.confirma_borrado, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            _conexion.EliminaPartidos()
        End If
    End Sub

    ''' <summary>
    ''' Acciones al dar clic en una fila de la tabla.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub GRIDALTA_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GRIDALTA.CellContentClick

        'Dim originalValue As Boolean
        'originalValue = CBool(GRIDALTA.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)

        'GRIDALTA.Rows(e.RowIndex).Cells("Gana").Value = False
        'GRIDALTA.Rows(e.RowIndex).Cells("Pierde").Value = False
        'GRIDALTA.Rows(e.RowIndex).Cells("Tablas").Value = False
        'GRIDALTA.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Not originalValue

        GRIDALTA.Refresh()

    End Sub

    ''' <summary>
    ''' Muestra formulario de configuración.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ConexionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConexionToolStripMenuItem.Click
        Dim configuracionForm As New Configuracion
        configuracionForm.ShowDialog()
        configuracionForm.Dispose()
        InicializaListas()
    End Sub

    ''' <summary>
    ''' Muestra la ventana de cnfiguración de la aplicación.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AplicacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AplicacionToolStripMenuItem.Click
        Dim configuracionForm As New ConfiguracionPlazaForm
        configuracionForm.ShowDialog()
        configuracionForm.Dispose()
        InicializaListas()
    End Sub

End Class
