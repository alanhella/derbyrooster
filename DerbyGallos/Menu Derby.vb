

Public Class Menu

    Private _partido As Partido
    Private _conexion As New Conexion

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        _partido = New Partido

        txtPartidos.DataBindings.Add(New Binding("Text", _partido, "Descripcion"))
        txtClave.DataBindings.Add(New Binding("Text", _partido, "Clave"))
        txtPeso.DataBindings.Add(New Binding("Text", _partido, "PesoGramo"))
        txtAnillo.DataBindings.Add(New Binding("Text", _partido, "Anillo"))

        CargaLista()

    End Sub

    Private Sub CargaLista()

        Dim lista As IList(Of Partido)

        _conexion = New Conexion()

        lista = _conexion.GetPartidos()

        ConfiguraTablaAlta()
        GRIDALTA.DataSource = lista

        label9.Text = String.Concat("Gallos: ", lista.Count.ToString)
        label10.Text = String.Concat("Peleas: ", CInt(lista.Count / 2))
    End Sub

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

        With id
            .Name = "idpartido"
            .DataPropertyName = "idpartido"
        End With

        With descripcion
            .Name = "descripcion"
            .DataPropertyName = "descripcion"
        End With

        With clave
            .Name = "clave"
            .DataPropertyName = "clave"
        End With

        With pesogranmo
            .Name = "pesogramo"
            .DataPropertyName = "pesogramo"
        End With

        With tipo
            .Name = "tipo"
            .DataPropertyName = "tipo"
        End With

        With anillo
            .Name = "anillo"
            .DataPropertyName = "anillo"
        End With

        With anillo
            .Name = "anillo"
            .DataPropertyName = "anillo"
        End With

        With gana
            .Name = "gana"
            .DataPropertyName = "gana"
        End With

        With pierde
            .Name = "pierde"
            .DataPropertyName = "pierde"
        End With

        With ronda
            .Name = "ronda"
            .DataPropertyName = "ronda"
        End With

        With tablas
            .Name = "tablas"
            .DataPropertyName = "tablas"
        End With

        With GRIDALTA.Columns
            .Clear()
            .Add(id)
            .Add(descripcion)
            .Add(clave)
            .Add(pesogranmo)
            .Add(tipo)
            .Add(anillo)
            .Add(gana)
            .Add(pierde)
            .Add(ronda)
            .Add(tablas)
        End With

    End Sub


    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Me.SelectNextControl(Me.ActiveControl, True, False, True, True)
        GuardaPartida()
    End Sub

    Private Sub GuardaPartida()
        _conexion = New Conexion

        _conexion.GuardaPartida(_partido)

        CargaLista()
    End Sub

End Class
