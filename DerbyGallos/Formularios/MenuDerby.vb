Option Explicit On
Option Strict On

Imports System.Text.RegularExpressions

Public Class Menu

    ' Definicion de Variables
    Private _partido As Partido
    Private _conexion As Conexion
    Private _lista As IList(Of Partido)
    Private _configuracionRegistro As RegistroWindows
    Private _configPlaza As ConfiguracionPlaza

    Private notifiacionController As New ToastNotifications.ToastController

    ''' <summary>
    ''' Carga inicial del formulario.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        pictureBox1.Visible = False
        labelPalenqueDescripcion.Visible = False

        BtnGuardaPelas.Enabled = False

        _configuracionRegistro = New RegistroWindows

        GetConfiguracionPlaza()

        SetConexion()

        ConfiguraTablaAlta()

        ConfiguraTablaSorteo()

        InicializaListas()

    End Sub

    ''' <summary>
    ''' Crea la conexion a la base de datos.
    ''' </summary>
    Private Sub SetConexion()
        _conexion = New Conexion(_configuracionRegistro.ConfiguracionGet)
        If Not _conexion.CheckConnection Then
            MessageBox.Show(Me, Mensajes.configurar_conexion, Mensajes.msg_error, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    ''' <summary>
    ''' Obtiene la configuración de la plaza.
    ''' </summary>
    Private Sub GetConfiguracionPlaza()

        _configPlaza = _configuracionRegistro.ConfiguracionPlazaGet

        txtPlaza.DataBindings.Clear()
        txtNumGallos.DataBindings.Clear()
        labelPalenqueDescripcion.DataBindings.Clear()

        txtPlaza.DataBindings.Add(New Binding("Text", _configPlaza, "Descripcion"))
        txtNumGallos.DataBindings.Add(New Binding("Text", _configPlaza, "NumeroGallos"))
        labelPalenqueDescripcion.DataBindings.Add(New Binding("Text", _configPlaza, "PalenqueDescripcion"))

    End Sub

    ''' <summary>
    ''' Configura y carga las tablas.
    ''' </summary>
    Private Sub InicializaListas()
        If _conexion.CheckConnection Then

            _partido = New Partido

            txtPartidos.DataBindings.Clear()
            txtClave.DataBindings.Clear()
            txtPeso.DataBindings.Clear()
            txtAnillo.DataBindings.Clear()

            txtPartidos.DataBindings.Add(New Binding("Text", _partido, "Descripcion"))
            txtClave.DataBindings.Add(New Binding("Text", _partido, "Clave"))
            txtPeso.DataBindings.Add(New Binding("Text", _partido, "Peso"))
            txtAnillo.DataBindings.Add(New Binding("Text", _partido, "Anillo"))

            CargaListaPartidos()

        End If
    End Sub

    ''' <summary>
    ''' Carga la lista de partidos guardados.
    ''' </summary>
    Private Sub CargaListaPartidos()

        Dim partidos As Integer

        _lista = New List(Of Partido)
        GRIDALTA.DataSource = Nothing

        _lista = _conexion.GetPartidos()
        GRIDALTA.DataSource = _lista

        partidos = (From partido In _lista Select partido.Descripcion).ToList.Distinct.Count

        LabelPartidos.Text = String.Concat("Partidos: ", partidos.ToString)
        LabelGallos.Text = String.Concat("Gallos: ", _lista.Count.ToString)
        LabelPeleas.Text = String.Concat("Peleas: ", CInt(_lista.Count / 2))

    End Sub

    ''' <summary>
    ''' Configura la tabla de sorteos.
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
        GRIDALTA.AllowUserToResizeRows = False

        With id
            .Name = "id"
            .DataPropertyName = "id"
            .HeaderText = "Id"
            .Width = 30
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
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
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With

        With pesogranmo
            .Name = "Peso"
            .DataPropertyName = "Peso"
            .HeaderText = "Peso"
            .Width = 50
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With

        With tipo
            .Name = "Tipo"
            .DataPropertyName = "Tipo"
            .HeaderText = "Tipo"
            .Width = 40
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
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
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With

        With gana
            .Name = "Gana"
            .DataPropertyName = "Gana"
            .HeaderText = "Gana"
            .Width = 40
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With

        With pierde
            .Name = "Pierde"
            .DataPropertyName = "Pierde"
            .HeaderText = "Pierde"
            .Width = 40
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With

        With tablas
            .Name = "Tablas"
            .DataPropertyName = "Tablas"
            .HeaderText = "Tablas"
            .Width = 40
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
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
    ''' Configura la tabla de lista de partidos.
    ''' </summary>
    Private Sub ConfiguraTablaSorteo()

        Dim pelea As New DataGridViewTextBoxColumn
        Dim ronda As New DataGridViewTextBoxColumn
        'ToDo: hay una columna con números que no son clave.
        Dim descripcion As New DataGridViewTextBoxColumn
        Dim clave As New DataGridViewTextBoxColumn
        Dim peso As New DataGridViewTextBoxColumn
        Dim anillo As New DataGridViewTextBoxColumn
        Dim diferencia As New DataGridViewTextBoxColumn

        DGVSorteo.AutoGenerateColumns = False
        DGVSorteo.RowHeadersVisible = False
        ''DGVSorteo.MultiSelect = False
        DGVSorteo.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGVSorteo.AllowUserToResizeRows = False

        With pelea
            .Name = "Pelea"
            .DataPropertyName = "Pelea"
            .HeaderText = "Pelea"
            .Width = 60
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With

        With ronda
            .Name = "Ronda"
            .DataPropertyName = "Ronda"
            .HeaderText = "Ronda"
            .Width = 60
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With

        With descripcion
            .Name = "Descripcion"
            .DataPropertyName = "Descripcion"
            .HeaderText = "Partido"
            .Width = 160
        End With

        With clave
            .Name = "Clave"
            .DataPropertyName = "Clave"
            .HeaderText = "Clave"
            .Width = 60
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With

        With peso
            .Name = "Peso"
            .DataPropertyName = "Peso"
            .HeaderText = "Peso"
            .Width = 60
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With

        With anillo
            .Name = "Anillo"
            .DataPropertyName = "Anillo"
            .HeaderText = "Anillo"
            .Width = 60
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With

        With diferencia
            .Name = "Diferencia"
            .DataPropertyName = "Diferencia"
            .HeaderText = "Diferencia"
            .Width = 50
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        End With

        With DGVSorteo.Columns
            .Clear()
            .Add(pelea)
            .Add(ronda)
            .Add(descripcion)
            .Add(clave)
            .Add(peso)
            .Add(anillo)
            .Add(diferencia)
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
            MessageBox.Show(Me, Mensajes.requiere_numero_gallos, Mensajes.msg_error, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Exit Function
        End If

        If IsNothing(_partido.Descripcion) OrElse _partido.Descripcion.Trim = String.Empty Then
            MessageBox.Show(Me, Mensajes.debe_ingresar_descripcion, Mensajes.msg_error, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Exit Function
        End If

        If IsNothing(_partido.Clave) OrElse _partido.Clave.Trim = String.Empty Then
            MessageBox.Show(Me, Mensajes.debe_ingresar_clave, Mensajes.msg_error, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Exit Function
        End If

        If IsNothing(_partido.Peso) OrElse _partido.Peso = 0 Then
            MessageBox.Show(Me, Mensajes.debe_ingresar_peso, Mensajes.msg_error, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Exit Function
        End If

        If IsNothing(_partido.Anillo) OrElse _partido.Anillo = 0 Then
            MessageBox.Show(Me, Mensajes.debe_ingresar_anillo, Mensajes.msg_error, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Exit Function
        End If

        If (From partido In _lista Where partido.Descripcion.Trim = _partido.Descripcion Select partido).ToList.Count >= gallosMaximos Then
            MessageBox.Show(Me, String.Format(Mensajes.maximo_gallos_ingresado, gallosMaximos), Mensajes.msg_error, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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

        Me.Cursor = Cursors.WaitCursor

        Me.SelectNextControl(Me.ActiveControl, True, False, True, True)

        ' se limpia la tabla de sorteos
        DGVSorteo.DataSource = Nothing

        ' Se realizana las validaciones y se agraga el partido.
        If Validaciones() Then
            GuardaPartida()
            notifiacionController.NotificationMessage(Me, Mensajes.guardado, "Partido guardado.")
            CargaListaPartidos()
        End If

        Me.Cursor = Cursors.WaitCursor

    End Sub

    ''' <summary>
    ''' Elimina un partido.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If MessageBox.Show("¿Borrar el partido seleccionado?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim partido As Partido
            Dim index As Integer

            Me.Cursor = Cursors.WaitCursor

            index = GRIDALTA.SelectedCells(0).RowIndex

            partido = CType(GRIDALTA.Rows(index).DataBoundItem, Partido)

            _conexion.EliminaPartido(partido)

            CargaListaPartidos()

            notifiacionController.NotificationMessage(Me, "Borrado!", "Se eliminó el partido")

            Me.Cursor = Cursors.Default

        End If
    End Sub

    ''' <summary>
    ''' Realiza el guardado de un partido.
    ''' </summary>
    Private Sub GuardaPartida()
        _conexion.GuardaPartido(_partido)
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
            Me.Cursor = Cursors.WaitCursor
            _conexion.EliminaPartidos()
            Me.Cursor = Cursors.Default
        End If
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
        GetConfiguracionPlaza()
        InicializaListas()
    End Sub

    ''' <summary>
    ''' Genera sorteo.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnSorteo_Click(sender As Object, e As EventArgs) Handles btnSorteo.Click

        Dim rondas As List(Of Integer)
        Dim listaPartidoSorteo As New List(Of Partido)
        Dim listaPorRonda As List(Of Partido)
        Dim random As New Random

        Me.Cursor = Cursors.WaitCursor

        DGVSorteo.DataSource = Nothing

        ' obtiene el número de rondas
        If _configPlaza.NumeroGallos > 0 Then
            rondas = New List(Of Integer)
            For i As Integer = 1 To _configPlaza.NumeroGallos
                rondas.Add(i)
            Next
        Else
            rondas = (From ronda In _lista Select ronda.Ronda).ToList
            rondas = rondas.Distinct.ToList
            rondas.Sort()
        End If

        For Each item In _lista
            item.Diferencia = 0
        Next

        ' genera la lista aleatoria de partidos por rondas.
        For Each ronda In rondas

            listaPorRonda = New List(Of Partido)
            listaPorRonda = (From partido In _lista Where partido.Ronda = ronda Select partido).ToList

            Dim listaLenght As Integer
            Dim index As Integer

            listaLenght = listaPorRonda.Count

            For x As Integer = 0 To listaLenght - 1
                index = random.Next(0, listaPorRonda.Count - 1)
                listaPartidoSorteo.Add(listaPorRonda(index))
                listaPorRonda.RemoveAt(index)
            Next

        Next

        DGVSorteo.DataSource = listaPartidoSorteo

        BtnGuardaPelas.Enabled = True

        CalculaSorteo()

        Me.Cursor = Cursors.Default

    End Sub

    ''' <summary>
    ''' Calcula la diferencia de pesos entre contrincantes.
    ''' </summary>
    Private Sub CalculaSorteo()

        Dim contador As Integer = 1

        For Each row As DataGridViewRow In DGVSorteo.Rows

            If (row.Index + 1) Mod 2 = 0 Then 'Es fila Par
                row.Cells("Pelea").Value = ((row.Index + 1) / 2)
                row.Cells("Diferencia").Value = Math.Abs(CInt(row.Cells("Peso").Value) - CInt(DGVSorteo.Rows(row.Index - 1).Cells("Peso").Value))
                DGVSorteo.Rows(row.Index - 1).Cells("Pelea").Value = row.Cells("Pelea").Value

                If contador Mod 2 = 0 Then
                    row.DefaultCellStyle.BackColor = Color.WhiteSmoke
                    DGVSorteo.Rows(row.Index - 1).Cells("Diferencia").Style.ForeColor = row.DefaultCellStyle.BackColor
                    DGVSorteo.Rows(row.Index - 1).Cells("Pelea").Style.ForeColor = row.DefaultCellStyle.BackColor
                    DGVSorteo.Rows(row.Index - 1).DefaultCellStyle.BackColor = row.DefaultCellStyle.BackColor
                Else
                    DGVSorteo.Rows(row.Index - 1).Cells("Diferencia").Style.ForeColor = Color.White
                    DGVSorteo.Rows(row.Index - 1).Cells("Pelea").Style.ForeColor = Color.White
                End If

                If CInt(row.Cells("Diferencia").Value) > 80 Then 'ToDo la diferencia a pintar es configurable.
                    row.DefaultCellStyle.ForeColor = Color.Red
                Else
                    row.DefaultCellStyle.ForeColor = Color.Black
                End If

                contador += 1

            End If

        Next

        DGVSorteo.Refresh()
    End Sub

    Private Sub GRIDALTA_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles GRIDALTA.CellBeginEdit
        GRIDALTA.Refresh()
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DGVSorteo_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles DGVSorteo.CellPainting
        If e.RowIndex >= 0 AndAlso Not ((e.RowIndex + 1) Mod 2 = 0) Then

            DGVSorteo.Rows(e.RowIndex).Cells("Pelea").Style.SelectionForeColor = e.CellStyle.SelectionBackColor
            DGVSorteo.Rows(e.RowIndex).Cells("Diferencia").Style.SelectionForeColor = e.CellStyle.SelectionBackColor

        End If
    End Sub

    ''' <summary>
    ''' Guardar Sorteo
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnGuardaPelas_Click(sender As Object, e As EventArgs) Handles BtnGuardaPelas.Click
        Dim lista As New List(Of SorteoClass)
        Dim sorteo As SorteoClass
        Dim fecha As DateTime
        Dim partido_1 As Partido
        Dim partido_2 As Partido

        Me.Cursor = Cursors.WaitCursor

        If Not DGVSorteo.Rows.Count > 0 Then
            notifiacionController.ErrorMessage(Me, "Error.", "Debe generar un sorteo primero.")
            Exit Sub
        ElseIf BtnGuardaPelas.Enabled = False Then
            Exit Sub
        End If

        fecha = Date.Now

        For Each row As DataGridViewRow In DGVSorteo.Rows

            If (row.Index + 1) Mod 2 = 0 Then
                partido_2 = CType(row.DataBoundItem, Partido)
                partido_1 = CType(DGVSorteo.Rows(row.Index - 1).DataBoundItem, Partido)

                sorteo = New SorteoClass

                With sorteo
                    .Nomplaza = _configPlaza.Descripcion
                    .Fechaderby = fecha
                    .Numronda = partido_2.Ronda

                    .Idpartido_1 = partido_1.Id
                    .Nompartido_1 = partido_1.Descripcion
                    .Clavepartido_1 = partido_1.Clave
                    .Pesogallo_1 = partido_1.Peso
                    .Anillogallo_1 = partido_1.Anillo

                    .Idpartido_2 = partido_2.Id
                    .Nompartido_2 = partido_2.Descripcion
                    .Clavepartido_2 = partido_2.Clave
                    .Pesogallo_2 = partido_2.Peso
                    .Anillogallo_2 = partido_2.Anillo

                    .Diferencia = partido_2.Diferencia
                    .NumeroPelea = partido_2.Pelea
                End With

                lista.Add(sorteo)

            End If

        Next

        If lista.Count > 0 Then
            _conexion.GuardaPartidoSorteo(lista)
        End If

        BtnGuardaPelas.Enabled = False

        notifiacionController.NotificationMessage(Me, Mensajes.guardado, Mensajes.guardado_exitoso)

        Me.Cursor = Cursors.Default

    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ButtonCambiaPartidos_Click(sender As Object, e As EventArgs) Handles ButtonCambiaPartidos.Click
        If DGVSorteo.Rows.Count >= 0 AndAlso DGVSorteo.SelectedRows.Count = 2 Then

        ElseIf DGVSorteo.Rows.Count <= 0 Then
            notifiacionController.ErrorMessage(Me, "Error.", "Debe generar un sorteo primero.")
        Else
            notifiacionController.ErrorMessage(Me, "Error.", "Debe seleccionar solo dos filas.")
        End If
    End Sub

    ''' <summary>
    ''' Guarda el resultado del las peleas.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim partido As Partido
            Dim listaPartidos As New List(Of Partido)
            Dim fechaResultado As DateTime
            Dim partidoResultado As Partido

            fechaResultado = Date.Now

            'Validaciones

            If Not DGVSorteo.Rows.Count > 0 Then
                MessageBox.Show(Me, "Debe realizar un sorteo primero.", Mensajes.msg_error, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            For Each row As DataGridViewRow In GRIDALTA.Rows
                Dim resultadoSeleccionado As Integer = 0
                partidoResultado = CType(row.DataBoundItem, Partido)

                If partidoResultado.Gana = False AndAlso partidoResultado.Pierde = False AndAlso partidoResultado.Tablas = False Then
                    'notifiacionController.ErrorMessage(Me, "Error", String.Format("Debe seleccionar un resultado para el partido: {0} (Clave: {1} | Peso: {2} | Anillo: {3}; )", partidoResultado.Descripcion, partidoResultado.Clave, partidoResultado.Peso, partidoResultado.Anillo))
                    MessageBox.Show(Me, String.Format("Debe seleccionar un resultado para el partido: {0} [Clave: {1} | Peso: {2} | Anillo: {3}]", partidoResultado.Descripcion, partidoResultado.Clave, partidoResultado.Peso, partidoResultado.Anillo), Mensajes.msg_error, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If

                If partidoResultado.Gana Then
                    resultadoSeleccionado += 1
                End If
                If partidoResultado.Pierde Then
                    resultadoSeleccionado += 1
                End If
                If partidoResultado.Tablas Then
                    resultadoSeleccionado += 1
                End If

                If resultadoSeleccionado > 1 Then
                    'notifiacionController.ErrorMessage(Me, "Error", String.Format("Debe seleccionar solo un resultado para el partido: {0} (Clave: {1} | Peso: {2} | Anillo: {3}; )", partidoResultado.Descripcion, partidoResultado.Clave, partidoResultado.Peso, partidoResultado.Anillo))
                    MessageBox.Show(Me, String.Format("Debe seleccionar un solo un resultado para el partido: {0} [Clave: {1} | Peso: {2} | Anillo: {3}]", partidoResultado.Descripcion, partidoResultado.Clave, partidoResultado.Peso, partidoResultado.Anillo), Mensajes.msg_error, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If

            Next

            partidoResultado = Nothing

            For Each row As DataGridViewRow In DGVSorteo.Rows
                partido = New Partido

                partido = CType(row.DataBoundItem, Partido)

                partidoResultado = (From partidoResult In _lista
                                    Where partidoResult.Descripcion = partido.Descripcion _
                                        And partidoResult.Clave = partido.Clave _
                                        And partidoResult.Anillo = partido.Anillo _
                                        And partidoResult.Peso = partido.Peso
                                    Select partidoResult).ToList(0)

                With partido
                    .Fecha = fechaResultado
                    .Gana = partidoResultado.Gana
                    .Pierde = partidoResultado.Pierde
                    .Tablas = partidoResultado.Tablas
                End With

                listaPartidos.Add(partido)

            Next

        If listaPartidos.Count > 0 Then
            _conexion.GuardaSorteoResultado(listaPartidos)
            notifiacionController.NotificationMessage(Me, "¡Guardado!.", "Resultado guardado..")
        End If

    End Sub

    ''' <summary>
    ''' Imprime talo de pelea.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnImprime_Click(sender As Object, e As EventArgs) Handles btnImprime.Click

        Dim partido As Partido
        Dim reporteSorteo As New ReporteForm
        Dim parametros As New Dictionary(Of String, String)

        Me.Cursor = Cursors.WaitCursor

        If DGVSorteo.Rows.Count > 0 Then
            partido = CType(DGVSorteo.SelectedRows(0).DataBoundItem, Partido)

            With parametros
                .Add("@Pelea", partido.Pelea.ToString)
                .Add("@Descripcion", partido.Descripcion.ToString)
                .Add("@Peso", partido.Peso.ToString)
            End With

            With reporteSorteo
                .NombreReporte = "ReporteSorteo.rpt"
                .Parametros = parametros
            End With

            reporteSorteo.Show()

        End If

        Me.Cursor = Cursors.Default

    End Sub


    ''' <summary>
    ''' Muestra todos los sorteos.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub sorteoXHojaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles sorteoXHojaToolStripMenuItem.Click

        'Application.UseWaitCursor = True
        Me.Cursor = Cursors.WaitCursor

        Dim reporteSorteo As New ReporteForm

        With reporteSorteo
            .NombreReporte = "SorteoHoja.rpt"
            .Parametros = New Dictionary(Of String, String)
        End With

        reporteSorteo.Show()

        'Application.UseWaitCursor = False
        Me.Cursor = Cursors.Default

    End Sub

    ''' <summary>
    ''' Reporte de ronda 1
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ronda1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ronda1ToolStripMenuItem.Click
        Dim reporteSorteo As New ReporteForm
        Dim parametros As New Dictionary(Of String, String)

        Me.Cursor = Cursors.WaitCursor

        With parametros
            .Add("@Ronda", CStr(1))
        End With

        With reporteSorteo
            .NombreReporte = "ReporteSorteo.rpt"
            .Parametros = parametros
        End With

        reporteSorteo.Show()

        Me.Cursor = Cursors.WaitCursor

    End Sub

End Class

