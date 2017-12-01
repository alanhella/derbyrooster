<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Configuracion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Configuracion))
        Me.TextBoxServidor = New System.Windows.Forms.TextBox()
        Me.TextBoxBaseDatos = New System.Windows.Forms.TextBox()
        Me.LabelServidor = New System.Windows.Forms.Label()
        Me.LabelBaseDatos = New System.Windows.Forms.Label()
        Me.LabelPassword = New System.Windows.Forms.Label()
        Me.LabelUsuario = New System.Windows.Forms.Label()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.TextBoxUsuario = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.LabelRutaReportes = New System.Windows.Forms.Label()
        Me.TextBoxRutaReportes = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBoxServidor
        '
        Me.TextBoxServidor.Location = New System.Drawing.Point(119, 21)
        Me.TextBoxServidor.Name = "TextBoxServidor"
        Me.TextBoxServidor.Size = New System.Drawing.Size(164, 22)
        Me.TextBoxServidor.TabIndex = 0
        '
        'TextBoxBaseDatos
        '
        Me.TextBoxBaseDatos.Location = New System.Drawing.Point(119, 47)
        Me.TextBoxBaseDatos.Name = "TextBoxBaseDatos"
        Me.TextBoxBaseDatos.Size = New System.Drawing.Size(164, 22)
        Me.TextBoxBaseDatos.TabIndex = 1
        '
        'LabelServidor
        '
        Me.LabelServidor.AutoSize = True
        Me.LabelServidor.Location = New System.Drawing.Point(61, 24)
        Me.LabelServidor.Name = "LabelServidor"
        Me.LabelServidor.Size = New System.Drawing.Size(52, 13)
        Me.LabelServidor.TabIndex = 2
        Me.LabelServidor.Text = "Servidor:"
        '
        'LabelBaseDatos
        '
        Me.LabelBaseDatos.AutoSize = True
        Me.LabelBaseDatos.Location = New System.Drawing.Point(30, 50)
        Me.LabelBaseDatos.Name = "LabelBaseDatos"
        Me.LabelBaseDatos.Size = New System.Drawing.Size(83, 13)
        Me.LabelBaseDatos.TabIndex = 3
        Me.LabelBaseDatos.Text = "Base de Datos:"
        '
        'LabelPassword
        '
        Me.LabelPassword.AutoSize = True
        Me.LabelPassword.Location = New System.Drawing.Point(44, 106)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(69, 13)
        Me.LabelPassword.TabIndex = 7
        Me.LabelPassword.Text = "Contraseña:"
        '
        'LabelUsuario
        '
        Me.LabelUsuario.AutoSize = True
        Me.LabelUsuario.Location = New System.Drawing.Point(63, 78)
        Me.LabelUsuario.Name = "LabelUsuario"
        Me.LabelUsuario.Size = New System.Drawing.Size(50, 13)
        Me.LabelUsuario.TabIndex = 6
        Me.LabelUsuario.Text = "Usuario:"
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Location = New System.Drawing.Point(119, 103)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TextBoxPassword.Size = New System.Drawing.Size(164, 22)
        Me.TextBoxPassword.TabIndex = 5
        '
        'TextBoxUsuario
        '
        Me.TextBoxUsuario.Location = New System.Drawing.Point(119, 75)
        Me.TextBoxUsuario.Name = "TextBoxUsuario"
        Me.TextBoxUsuario.Size = New System.Drawing.Size(164, 22)
        Me.TextBoxUsuario.TabIndex = 4
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(335, 25)
        Me.ToolStrip1.TabIndex = 10
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.DerbyGallos.My.Resources.Resources.diskette
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButtonGuardar"
        '
        'LabelRutaReportes
        '
        Me.LabelRutaReportes.AutoSize = True
        Me.LabelRutaReportes.Location = New System.Drawing.Point(12, 26)
        Me.LabelRutaReportes.Name = "LabelRutaReportes"
        Me.LabelRutaReportes.Size = New System.Drawing.Size(99, 13)
        Me.LabelRutaReportes.TabIndex = 12
        Me.LabelRutaReportes.Text = "Ruta de Reportes:"
        '
        'TextBoxRutaReportes
        '
        Me.TextBoxRutaReportes.Location = New System.Drawing.Point(117, 23)
        Me.TextBoxRutaReportes.Name = "TextBoxRutaReportes"
        Me.TextBoxRutaReportes.Size = New System.Drawing.Size(164, 22)
        Me.TextBoxRutaReportes.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBoxServidor)
        Me.GroupBox1.Controls.Add(Me.TextBoxBaseDatos)
        Me.GroupBox1.Controls.Add(Me.LabelServidor)
        Me.GroupBox1.Controls.Add(Me.LabelBaseDatos)
        Me.GroupBox1.Controls.Add(Me.LabelPassword)
        Me.GroupBox1.Controls.Add(Me.TextBoxUsuario)
        Me.GroupBox1.Controls.Add(Me.LabelUsuario)
        Me.GroupBox1.Controls.Add(Me.TextBoxPassword)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(313, 136)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Conexión"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBoxRutaReportes)
        Me.GroupBox2.Controls.Add(Me.LabelRutaReportes)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 172)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(313, 69)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Reportes"
        '
        'Configuracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 254)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Configuracion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuración"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxServidor As TextBox
    Friend WithEvents TextBoxBaseDatos As TextBox
    Friend WithEvents LabelServidor As Label
    Friend WithEvents LabelBaseDatos As Label
    Friend WithEvents LabelPassword As Label
    Friend WithEvents LabelUsuario As Label
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents TextBoxUsuario As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents LabelRutaReportes As Label
    Friend WithEvents TextBoxRutaReportes As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
