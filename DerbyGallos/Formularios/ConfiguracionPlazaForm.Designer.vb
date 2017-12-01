<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConfiguracionPlazaForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConfiguracionPlazaForm))
        Me.TextBoxDescripcion = New System.Windows.Forms.TextBox()
        Me.TextBoxNumeroGallos = New System.Windows.Forms.TextBox()
        Me.LabelServidor = New System.Windows.Forms.Label()
        Me.LabelBaseDatos = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxNombrePalenque = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelDiferenciaPeso = New System.Windows.Forms.Label()
        Me.TextBoxDiferenciaPeso = New System.Windows.Forms.TextBox()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxDescripcion
        '
        Me.TextBoxDescripcion.Location = New System.Drawing.Point(254, 69)
        Me.TextBoxDescripcion.Name = "TextBoxDescripcion"
        Me.TextBoxDescripcion.Size = New System.Drawing.Size(164, 22)
        Me.TextBoxDescripcion.TabIndex = 0
        '
        'TextBoxNumeroGallos
        '
        Me.TextBoxNumeroGallos.Location = New System.Drawing.Point(254, 95)
        Me.TextBoxNumeroGallos.Name = "TextBoxNumeroGallos"
        Me.TextBoxNumeroGallos.Size = New System.Drawing.Size(164, 22)
        Me.TextBoxNumeroGallos.TabIndex = 1
        '
        'LabelServidor
        '
        Me.LabelServidor.AutoSize = True
        Me.LabelServidor.Location = New System.Drawing.Point(140, 72)
        Me.LabelServidor.Name = "LabelServidor"
        Me.LabelServidor.Size = New System.Drawing.Size(108, 13)
        Me.LabelServidor.TabIndex = 2
        Me.LabelServidor.Text = "Nombre de la Plaza:"
        '
        'LabelBaseDatos
        '
        Me.LabelBaseDatos.AutoSize = True
        Me.LabelBaseDatos.Location = New System.Drawing.Point(146, 98)
        Me.LabelBaseDatos.Name = "LabelBaseDatos"
        Me.LabelBaseDatos.Size = New System.Drawing.Size(102, 13)
        Me.LabelBaseDatos.TabIndex = 3
        Me.LabelBaseDatos.Text = "Número de Gallos:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(438, 25)
        Me.ToolStrip1.TabIndex = 9
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(127, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Nombre del Palenque:"
        '
        'TextBoxNombrePalenque
        '
        Me.TextBoxNombrePalenque.Location = New System.Drawing.Point(254, 41)
        Me.TextBoxNombrePalenque.Name = "TextBoxNombrePalenque"
        Me.TextBoxNombrePalenque.Size = New System.Drawing.Size(164, 22)
        Me.TextBoxNombrePalenque.TabIndex = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(21, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'LabelDiferenciaPeso
        '
        Me.LabelDiferenciaPeso.AutoSize = True
        Me.LabelDiferenciaPeso.Location = New System.Drawing.Point(142, 126)
        Me.LabelDiferenciaPeso.Name = "LabelDiferenciaPeso"
        Me.LabelDiferenciaPeso.Size = New System.Drawing.Size(106, 13)
        Me.LabelDiferenciaPeso.TabIndex = 14
        Me.LabelDiferenciaPeso.Text = "Diferencia de peso:"
        '
        'TextBoxDiferenciaPeso
        '
        Me.TextBoxDiferenciaPeso.Location = New System.Drawing.Point(254, 123)
        Me.TextBoxDiferenciaPeso.Name = "TextBoxDiferenciaPeso"
        Me.TextBoxDiferenciaPeso.Size = New System.Drawing.Size(164, 22)
        Me.TextBoxDiferenciaPeso.TabIndex = 13
        '
        'ConfiguracionPlazaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 174)
        Me.Controls.Add(Me.LabelDiferenciaPeso)
        Me.Controls.Add(Me.TextBoxDiferenciaPeso)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxNombrePalenque)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.LabelBaseDatos)
        Me.Controls.Add(Me.LabelServidor)
        Me.Controls.Add(Me.TextBoxNumeroGallos)
        Me.Controls.Add(Me.TextBoxDescripcion)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ConfiguracionPlazaForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuración"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxDescripcion As TextBox
    Friend WithEvents TextBoxNumeroGallos As TextBox
    Friend WithEvents LabelServidor As Label
    Friend WithEvents LabelBaseDatos As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxNombrePalenque As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabelDiferenciaPeso As Label
    Friend WithEvents TextBoxDiferenciaPeso As TextBox
End Class
