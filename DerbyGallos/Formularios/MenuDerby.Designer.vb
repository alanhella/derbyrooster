<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        Me.label10 = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.dataGridView2 = New System.Windows.Forms.DataGridView()
        Me.GRIDALTA = New System.Windows.Forms.DataGridView()
        Me.BtnGuardaPelas = New System.Windows.Forms.Button()
        Me.btnImprime = New System.Windows.Forms.Button()
        Me.BtnPizarraP = New System.Windows.Forms.Button()
        Me.BtnPizarraG = New System.Windows.Forms.Button()
        Me.btnSorteo = New System.Windows.Forms.Button()
        Me.btnDepurar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtAnillo = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.txtPartidos = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txtNumGallos = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtPlaza = New System.Windows.Forms.TextBox()
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.sorteosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.sorteoXHojaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ronda1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ronda2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ronda3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ronda4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ronda5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ronda6ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ronda7ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pelasXPartidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pizarrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pizarraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pizarraR1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pizarraR2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pizarraR3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pizarraR4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pizarraR5AlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pizarraR6Ctrl6ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pizarraR7Ctrl7ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConexionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AplicacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GRIDALTA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuStrip1.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.Location = New System.Drawing.Point(398, 537)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(82, 24)
        Me.label10.TabIndex = 58
        Me.label10.Text = "Peleas"
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.Location = New System.Drawing.Point(199, 537)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(82, 24)
        Me.label9.TabIndex = 57
        Me.label9.Text = "Gallos"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.Location = New System.Drawing.Point(10, 537)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(106, 24)
        Me.label8.TabIndex = 56
        Me.label8.Text = "Partidos"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Consolas", 21.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.Location = New System.Drawing.Point(797, 16)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(335, 34)
        Me.label7.TabIndex = 54
        Me.label7.Text = "Palenque Dos Estados"
        '
        'dataGridView2
        '
        Me.dataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView2.Location = New System.Drawing.Point(588, 134)
        Me.dataGridView2.Name = "dataGridView2"
        Me.dataGridView2.Size = New System.Drawing.Size(550, 383)
        Me.dataGridView2.TabIndex = 22
        '
        'GRIDALTA
        '
        Me.GRIDALTA.BackgroundColor = System.Drawing.Color.White
        Me.GRIDALTA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GRIDALTA.Location = New System.Drawing.Point(14, 134)
        Me.GRIDALTA.Name = "GRIDALTA"
        Me.GRIDALTA.Size = New System.Drawing.Size(550, 383)
        Me.GRIDALTA.TabIndex = 16
        '
        'BtnGuardaPelas
        '
        Me.BtnGuardaPelas.BackColor = System.Drawing.Color.White
        Me.BtnGuardaPelas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardaPelas.Location = New System.Drawing.Point(1060, 90)
        Me.BtnGuardaPelas.Name = "BtnGuardaPelas"
        Me.BtnGuardaPelas.Size = New System.Drawing.Size(78, 26)
        Me.BtnGuardaPelas.TabIndex = 21
        Me.BtnGuardaPelas.Text = "&Guardar"
        Me.BtnGuardaPelas.UseVisualStyleBackColor = False
        '
        'btnImprime
        '
        Me.btnImprime.BackColor = System.Drawing.Color.White
        Me.btnImprime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprime.Location = New System.Drawing.Point(965, 90)
        Me.btnImprime.Name = "btnImprime"
        Me.btnImprime.Size = New System.Drawing.Size(89, 26)
        Me.btnImprime.TabIndex = 20
        Me.btnImprime.Text = "&Imprime &Talon"
        Me.btnImprime.UseVisualStyleBackColor = False
        '
        'BtnPizarraP
        '
        Me.BtnPizarraP.BackColor = System.Drawing.Color.White
        Me.BtnPizarraP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPizarraP.Location = New System.Drawing.Point(881, 90)
        Me.BtnPizarraP.Name = "BtnPizarraP"
        Me.BtnPizarraP.Size = New System.Drawing.Size(78, 26)
        Me.BtnPizarraP.TabIndex = 19
        Me.BtnPizarraP.Text = "&Pizarra &P"
        Me.BtnPizarraP.UseVisualStyleBackColor = False
        '
        'BtnPizarraG
        '
        Me.BtnPizarraG.BackColor = System.Drawing.Color.White
        Me.BtnPizarraG.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPizarraG.Location = New System.Drawing.Point(797, 90)
        Me.BtnPizarraG.Name = "BtnPizarraG"
        Me.BtnPizarraG.Size = New System.Drawing.Size(78, 26)
        Me.BtnPizarraG.TabIndex = 18
        Me.BtnPizarraG.Text = "&Pizarra &G"
        Me.BtnPizarraG.UseVisualStyleBackColor = False
        '
        'btnSorteo
        '
        Me.btnSorteo.BackColor = System.Drawing.Color.White
        Me.btnSorteo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSorteo.Location = New System.Drawing.Point(588, 90)
        Me.btnSorteo.Name = "btnSorteo"
        Me.btnSorteo.Size = New System.Drawing.Size(78, 26)
        Me.btnSorteo.TabIndex = 17
        Me.btnSorteo.Text = "&Sorteo"
        Me.btnSorteo.UseVisualStyleBackColor = False
        '
        'btnDepurar
        '
        Me.btnDepurar.BackColor = System.Drawing.Color.White
        Me.btnDepurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDepurar.Location = New System.Drawing.Point(486, 90)
        Me.btnDepurar.Name = "btnDepurar"
        Me.btnDepurar.Size = New System.Drawing.Size(78, 26)
        Me.btnDepurar.TabIndex = 23
        Me.btnDepurar.Text = "&Depurar"
        Me.btnDepurar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.White
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Location = New System.Drawing.Point(182, 90)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(78, 26)
        Me.btnGuardar.TabIndex = 15
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.White
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Location = New System.Drawing.Point(98, 90)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(78, 26)
        Me.btnEliminar.TabIndex = 14
        Me.btnEliminar.Text = "&Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.White
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Location = New System.Drawing.Point(14, 90)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(78, 26)
        Me.btnAgregar.TabIndex = 13
        Me.btnAgregar.Text = "&Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'txtAnillo
        '
        Me.txtAnillo.Location = New System.Drawing.Point(588, 54)
        Me.txtAnillo.Name = "txtAnillo"
        Me.txtAnillo.Size = New System.Drawing.Size(56, 20)
        Me.txtAnillo.TabIndex = 12
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(550, 57)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(35, 13)
        Me.label6.TabIndex = 11
        Me.label6.Text = "Anillo:"
        '
        'txtPeso
        '
        Me.txtPeso.Location = New System.Drawing.Point(486, 54)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(56, 20)
        Me.txtPeso.TabIndex = 10
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(449, 57)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(34, 13)
        Me.label5.TabIndex = 9
        Me.label5.Text = "Peso:"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(347, 57)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(37, 13)
        Me.label4.TabIndex = 7
        Me.label4.Text = "Clave:"
        '
        'txtClave
        '
        Me.txtClave.Location = New System.Drawing.Point(387, 54)
        Me.txtClave.MaxLength = 3
        Me.txtClave.Name = "txtClave"
        Me.txtClave.Size = New System.Drawing.Size(56, 20)
        Me.txtClave.TabIndex = 8
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(11, 57)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(43, 13)
        Me.label3.TabIndex = 5
        Me.label3.Text = "Partido:"
        '
        'txtPartidos
        '
        Me.txtPartidos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPartidos.Location = New System.Drawing.Point(57, 54)
        Me.txtPartidos.Name = "txtPartidos"
        Me.txtPartidos.Size = New System.Drawing.Size(275, 20)
        Me.txtPartidos.TabIndex = 6
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(287, 31)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(94, 13)
        Me.label2.TabIndex = 3
        Me.label2.Text = "Número de Gallos:"
        '
        'txtNumGallos
        '
        Me.txtNumGallos.Location = New System.Drawing.Point(387, 27)
        Me.txtNumGallos.MaxLength = 2
        Me.txtNumGallos.Name = "txtNumGallos"
        Me.txtNumGallos.Size = New System.Drawing.Size(56, 20)
        Me.txtNumGallos.TabIndex = 4
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(18, 31)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(36, 13)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Plaza:"
        '
        'txtPlaza
        '
        Me.txtPlaza.Location = New System.Drawing.Point(57, 28)
        Me.txtPlaza.Name = "txtPlaza"
        Me.txtPlaza.Size = New System.Drawing.Size(209, 20)
        Me.txtPlaza.TabIndex = 2
        '
        'menuStrip1
        '
        Me.menuStrip1.BackColor = System.Drawing.Color.White
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sorteosToolStripMenuItem, Me.pizarrasToolStripMenuItem, Me.ConfiguraciónToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(1166, 24)
        Me.menuStrip1.TabIndex = 0
        Me.menuStrip1.Text = "menuStrip1"
        '
        'sorteosToolStripMenuItem
        '
        Me.sorteosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sorteoXHojaToolStripMenuItem, Me.ronda1ToolStripMenuItem, Me.ronda2ToolStripMenuItem, Me.ronda3ToolStripMenuItem, Me.ronda4ToolStripMenuItem, Me.ronda5ToolStripMenuItem, Me.ronda6ToolStripMenuItem, Me.ronda7ToolStripMenuItem, Me.pelasXPartidoToolStripMenuItem})
        Me.sorteosToolStripMenuItem.Name = "sorteosToolStripMenuItem"
        Me.sorteosToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.sorteosToolStripMenuItem.Text = "Sorteos"
        '
        'sorteoXHojaToolStripMenuItem
        '
        Me.sorteoXHojaToolStripMenuItem.Name = "sorteoXHojaToolStripMenuItem"
        Me.sorteoXHojaToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.sorteoXHojaToolStripMenuItem.Text = "Sorteo x Hoja   Alt+8   "
        '
        'ronda1ToolStripMenuItem
        '
        Me.ronda1ToolStripMenuItem.Name = "ronda1ToolStripMenuItem"
        Me.ronda1ToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ronda1ToolStripMenuItem.Text = "Ronda 1            Alt+1"
        '
        'ronda2ToolStripMenuItem
        '
        Me.ronda2ToolStripMenuItem.Name = "ronda2ToolStripMenuItem"
        Me.ronda2ToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ronda2ToolStripMenuItem.Text = "Ronda 2            Alt+2"
        '
        'ronda3ToolStripMenuItem
        '
        Me.ronda3ToolStripMenuItem.Name = "ronda3ToolStripMenuItem"
        Me.ronda3ToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ronda3ToolStripMenuItem.Text = "Ronda 3            Alt+3"
        '
        'ronda4ToolStripMenuItem
        '
        Me.ronda4ToolStripMenuItem.Name = "ronda4ToolStripMenuItem"
        Me.ronda4ToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ronda4ToolStripMenuItem.Text = "Ronda 4            Alt+4"
        '
        'ronda5ToolStripMenuItem
        '
        Me.ronda5ToolStripMenuItem.Name = "ronda5ToolStripMenuItem"
        Me.ronda5ToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ronda5ToolStripMenuItem.Text = "Ronda 5            Alt+5"
        '
        'ronda6ToolStripMenuItem
        '
        Me.ronda6ToolStripMenuItem.Name = "ronda6ToolStripMenuItem"
        Me.ronda6ToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ronda6ToolStripMenuItem.Text = "Ronda 6            Alt+6"
        '
        'ronda7ToolStripMenuItem
        '
        Me.ronda7ToolStripMenuItem.Name = "ronda7ToolStripMenuItem"
        Me.ronda7ToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ronda7ToolStripMenuItem.Text = "Ronda 7            Alt+7"
        '
        'pelasXPartidoToolStripMenuItem
        '
        Me.pelasXPartidoToolStripMenuItem.Name = "pelasXPartidoToolStripMenuItem"
        Me.pelasXPartidoToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.pelasXPartidoToolStripMenuItem.Text = "Pelas x Partido"
        '
        'pizarrasToolStripMenuItem
        '
        Me.pizarrasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.pizarraToolStripMenuItem, Me.pizarraR1ToolStripMenuItem, Me.pizarraR2ToolStripMenuItem, Me.pizarraR3ToolStripMenuItem, Me.pizarraR4ToolStripMenuItem, Me.pizarraR5AlToolStripMenuItem, Me.pizarraR6Ctrl6ToolStripMenuItem, Me.pizarraR7Ctrl7ToolStripMenuItem})
        Me.pizarrasToolStripMenuItem.Name = "pizarrasToolStripMenuItem"
        Me.pizarrasToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.pizarrasToolStripMenuItem.Text = "Pizarras"
        '
        'pizarraToolStripMenuItem
        '
        Me.pizarraToolStripMenuItem.Name = "pizarraToolStripMenuItem"
        Me.pizarraToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.pizarraToolStripMenuItem.Text = "Pizarra           Ctrl+Z"
        '
        'pizarraR1ToolStripMenuItem
        '
        Me.pizarraR1ToolStripMenuItem.Name = "pizarraR1ToolStripMenuItem"
        Me.pizarraR1ToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.pizarraR1ToolStripMenuItem.Text = "Pizarra R1      Ctrl+1"
        '
        'pizarraR2ToolStripMenuItem
        '
        Me.pizarraR2ToolStripMenuItem.Name = "pizarraR2ToolStripMenuItem"
        Me.pizarraR2ToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.pizarraR2ToolStripMenuItem.Text = "Pizarra R2      Ctrl+2"
        '
        'pizarraR3ToolStripMenuItem
        '
        Me.pizarraR3ToolStripMenuItem.Name = "pizarraR3ToolStripMenuItem"
        Me.pizarraR3ToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.pizarraR3ToolStripMenuItem.Text = "Pizarra R3      Ctrl+3"
        '
        'pizarraR4ToolStripMenuItem
        '
        Me.pizarraR4ToolStripMenuItem.Name = "pizarraR4ToolStripMenuItem"
        Me.pizarraR4ToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.pizarraR4ToolStripMenuItem.Text = "Pizarra R4      Ctrl+4"
        '
        'pizarraR5AlToolStripMenuItem
        '
        Me.pizarraR5AlToolStripMenuItem.Name = "pizarraR5AlToolStripMenuItem"
        Me.pizarraR5AlToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.pizarraR5AlToolStripMenuItem.Text = "Pizarra R5      Ctrl+5"
        '
        'pizarraR6Ctrl6ToolStripMenuItem
        '
        Me.pizarraR6Ctrl6ToolStripMenuItem.Name = "pizarraR6Ctrl6ToolStripMenuItem"
        Me.pizarraR6Ctrl6ToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.pizarraR6Ctrl6ToolStripMenuItem.Text = "Pizarra R6      Ctrl+6"
        '
        'pizarraR7Ctrl7ToolStripMenuItem
        '
        Me.pizarraR7Ctrl7ToolStripMenuItem.Name = "pizarraR7Ctrl7ToolStripMenuItem"
        Me.pizarraR7Ctrl7ToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.pizarraR7Ctrl7ToolStripMenuItem.Text = "Pizarra R7      Ctrl+7"
        '
        'ConfiguraciónToolStripMenuItem
        '
        Me.ConfiguraciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConexionToolStripMenuItem, Me.AplicacionToolStripMenuItem})
        Me.ConfiguraciónToolStripMenuItem.Name = "ConfiguraciónToolStripMenuItem"
        Me.ConfiguraciónToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.ConfiguraciónToolStripMenuItem.Text = "Configuración"
        '
        'ConexionToolStripMenuItem
        '
        Me.ConexionToolStripMenuItem.Name = "ConexionToolStripMenuItem"
        Me.ConexionToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.F11), System.Windows.Forms.Keys)
        Me.ConexionToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.ConexionToolStripMenuItem.Text = "Conexión"
        Me.ConexionToolStripMenuItem.Visible = False
        '
        'AplicacionToolStripMenuItem
        '
        Me.AplicacionToolStripMenuItem.Name = "AplicacionToolStripMenuItem"
        Me.AplicacionToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.AplicacionToolStripMenuItem.Text = "Aplicación"
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = Global.DerbyGallos.My.Resources.Resources.icono_gallo
        Me.pictureBox1.Location = New System.Drawing.Point(691, 16)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 55
        Me.pictureBox1.TabStop = False
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1166, 580)
        Me.Controls.Add(Me.label10)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.dataGridView2)
        Me.Controls.Add(Me.GRIDALTA)
        Me.Controls.Add(Me.BtnGuardaPelas)
        Me.Controls.Add(Me.btnImprime)
        Me.Controls.Add(Me.BtnPizarraP)
        Me.Controls.Add(Me.BtnPizarraG)
        Me.Controls.Add(Me.btnSorteo)
        Me.Controls.Add(Me.btnDepurar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtAnillo)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.txtPeso)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.txtPartidos)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.txtNumGallos)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.txtPlaza)
        Me.Controls.Add(Me.menuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Derby Gallos"
        CType(Me.dataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GRIDALTA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label10 As System.Windows.Forms.Label
    Private WithEvents label9 As System.Windows.Forms.Label
    Private WithEvents label8 As System.Windows.Forms.Label
    Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents dataGridView2 As System.Windows.Forms.DataGridView
    Private WithEvents GRIDALTA As System.Windows.Forms.DataGridView
    Private WithEvents BtnGuardaPelas As System.Windows.Forms.Button
    Private WithEvents btnImprime As System.Windows.Forms.Button
    Private WithEvents BtnPizarraP As System.Windows.Forms.Button
    Private WithEvents BtnPizarraG As System.Windows.Forms.Button
    Private WithEvents btnSorteo As System.Windows.Forms.Button
    Private WithEvents btnDepurar As System.Windows.Forms.Button
    Private WithEvents btnGuardar As System.Windows.Forms.Button
    Private WithEvents btnEliminar As System.Windows.Forms.Button
    Private WithEvents btnAgregar As System.Windows.Forms.Button
    Private WithEvents txtAnillo As System.Windows.Forms.TextBox
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents txtPeso As System.Windows.Forms.TextBox
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents txtClave As System.Windows.Forms.TextBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents txtPartidos As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents txtNumGallos As System.Windows.Forms.TextBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents txtPlaza As System.Windows.Forms.TextBox
    Private WithEvents menuStrip1 As System.Windows.Forms.MenuStrip
    Private WithEvents sorteosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents sorteoXHojaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ronda1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ronda2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ronda3ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ronda4ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ronda5ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ronda6ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ronda7ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents pelasXPartidoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents pizarrasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents pizarraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents pizarraR1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents pizarraR2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents pizarraR3ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents pizarraR4ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents pizarraR5AlToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents pizarraR6Ctrl6ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents pizarraR7Ctrl7ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguraciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConexionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AplicacionToolStripMenuItem As ToolStripMenuItem
End Class
