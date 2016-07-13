<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frInventario
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
        Me.tbEstado1 = New System.Windows.Forms.TextBox()
        Me.tbEstado = New System.Windows.Forms.TextBox()
        Me.lbDescripcion = New System.Windows.Forms.Label()
        Me.lbCodigo = New System.Windows.Forms.Label()
        Me.tbDescripcion = New System.Windows.Forms.TextBox()
        Me.tbCodigo = New System.Windows.Forms.TextBox()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.lbFecha = New System.Windows.Forms.Label()
        Me.lbMedida = New System.Windows.Forms.Label()
        Me.tbMedida = New System.Windows.Forms.TextBox()
        Me.lbEstado = New System.Windows.Forms.Label()
        Me.pnlPanelTitulo = New System.Windows.Forms.Panel()
        Me.lbTitulo = New System.Windows.Forms.Label()
        Me.tbFechaCreacion = New System.Windows.Forms.TextBox()
        Me.dpFechaCreacion = New System.Windows.Forms.DateTimePicker()
        Me.lbInventarioTipo = New System.Windows.Forms.Label()
        Me.cbInventarioTipo = New System.Windows.Forms.ComboBox()
        Me.tbInventarioTipo = New System.Windows.Forms.TextBox()
        Me.cbMedida = New System.Windows.Forms.ComboBox()
        Me.tbPrecio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UcNavegador1 = New MRP.ucNavegador()
        Me.tbEmpresa = New System.Windows.Forms.TextBox()
        Me.pnlPanelTitulo.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbEstado1
        '
        Me.tbEstado1.Location = New System.Drawing.Point(525, 70)
        Me.tbEstado1.Name = "tbEstado1"
        Me.tbEstado1.ReadOnly = True
        Me.tbEstado1.Size = New System.Drawing.Size(150, 20)
        Me.tbEstado1.TabIndex = 1
        Me.tbEstado1.TabStop = False
        '
        'tbEstado
        '
        Me.tbEstado.Location = New System.Drawing.Point(499, 70)
        Me.tbEstado.Name = "tbEstado"
        Me.tbEstado.Size = New System.Drawing.Size(20, 20)
        Me.tbEstado.TabIndex = 100
        Me.tbEstado.Visible = False
        '
        'lbDescripcion
        '
        Me.lbDescripcion.AutoSize = True
        Me.lbDescripcion.Location = New System.Drawing.Point(12, 152)
        Me.lbDescripcion.Name = "lbDescripcion"
        Me.lbDescripcion.Size = New System.Drawing.Size(66, 13)
        Me.lbDescripcion.TabIndex = 38
        Me.lbDescripcion.Text = "Descripción:"
        '
        'lbCodigo
        '
        Me.lbCodigo.AutoSize = True
        Me.lbCodigo.Location = New System.Drawing.Point(12, 73)
        Me.lbCodigo.Name = "lbCodigo"
        Me.lbCodigo.Size = New System.Drawing.Size(43, 13)
        Me.lbCodigo.TabIndex = 37
        Me.lbCodigo.Text = "Código:"
        '
        'tbDescripcion
        '
        Me.tbDescripcion.Location = New System.Drawing.Point(125, 149)
        Me.tbDescripcion.MaxLength = 100
        Me.tbDescripcion.Name = "tbDescripcion"
        Me.tbDescripcion.Size = New System.Drawing.Size(550, 20)
        Me.tbDescripcion.TabIndex = 4
        '
        'tbCodigo
        '
        Me.tbCodigo.Location = New System.Drawing.Point(125, 70)
        Me.tbCodigo.Name = "tbCodigo"
        Me.tbCodigo.ReadOnly = True
        Me.tbCodigo.Size = New System.Drawing.Size(150, 20)
        Me.tbCodigo.TabIndex = 0
        Me.tbCodigo.TabStop = False
        '
        'lbNombre
        '
        Me.lbNombre.AutoSize = True
        Me.lbNombre.Location = New System.Drawing.Point(12, 126)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(47, 13)
        Me.lbNombre.TabIndex = 41
        Me.lbNombre.Text = "Nombre:"
        '
        'tbNombre
        '
        Me.tbNombre.Location = New System.Drawing.Point(125, 123)
        Me.tbNombre.MaxLength = 100
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(550, 20)
        Me.tbNombre.TabIndex = 3
        '
        'lbFecha
        '
        Me.lbFecha.AutoSize = True
        Me.lbFecha.Location = New System.Drawing.Point(12, 206)
        Me.lbFecha.Name = "lbFecha"
        Me.lbFecha.Size = New System.Drawing.Size(84, 13)
        Me.lbFecha.TabIndex = 42
        Me.lbFecha.Text = "Fecha creación:"
        '
        'lbMedida
        '
        Me.lbMedida.AutoSize = True
        Me.lbMedida.Location = New System.Drawing.Point(12, 178)
        Me.lbMedida.Name = "lbMedida"
        Me.lbMedida.Size = New System.Drawing.Size(45, 13)
        Me.lbMedida.TabIndex = 44
        Me.lbMedida.Text = "Medida:"
        '
        'tbMedida
        '
        Me.tbMedida.Location = New System.Drawing.Point(99, 175)
        Me.tbMedida.Name = "tbMedida"
        Me.tbMedida.Size = New System.Drawing.Size(20, 20)
        Me.tbMedida.TabIndex = 100
        Me.tbMedida.Visible = False
        '
        'lbEstado
        '
        Me.lbEstado.AutoSize = True
        Me.lbEstado.Location = New System.Drawing.Point(412, 73)
        Me.lbEstado.Name = "lbEstado"
        Me.lbEstado.Size = New System.Drawing.Size(43, 13)
        Me.lbEstado.TabIndex = 46
        Me.lbEstado.Text = "Estado:"
        '
        'pnlPanelTitulo
        '
        Me.pnlPanelTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPanelTitulo.Controls.Add(Me.lbTitulo)
        Me.pnlPanelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlPanelTitulo.Location = New System.Drawing.Point(0, 0)
        Me.pnlPanelTitulo.Name = "pnlPanelTitulo"
        Me.pnlPanelTitulo.Size = New System.Drawing.Size(689, 50)
        Me.pnlPanelTitulo.TabIndex = 100
        '
        'lbTitulo
        '
        Me.lbTitulo.AutoSize = True
        Me.lbTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTitulo.Location = New System.Drawing.Point(12, 9)
        Me.lbTitulo.Name = "lbTitulo"
        Me.lbTitulo.Size = New System.Drawing.Size(159, 31)
        Me.lbTitulo.TabIndex = 41
        Me.lbTitulo.Text = "Inventarios"
        '
        'tbFechaCreacion
        '
        Me.tbFechaCreacion.Location = New System.Drawing.Point(281, 202)
        Me.tbFechaCreacion.MaxLength = 100
        Me.tbFechaCreacion.Name = "tbFechaCreacion"
        Me.tbFechaCreacion.Size = New System.Drawing.Size(20, 20)
        Me.tbFechaCreacion.TabIndex = 100
        Me.tbFechaCreacion.Visible = False
        '
        'dpFechaCreacion
        '
        Me.dpFechaCreacion.CustomFormat = "dd/MM/yyyy"
        Me.dpFechaCreacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpFechaCreacion.Location = New System.Drawing.Point(125, 202)
        Me.dpFechaCreacion.Name = "dpFechaCreacion"
        Me.dpFechaCreacion.Size = New System.Drawing.Size(150, 20)
        Me.dpFechaCreacion.TabIndex = 6
        '
        'lbInventarioTipo
        '
        Me.lbInventarioTipo.AutoSize = True
        Me.lbInventarioTipo.Location = New System.Drawing.Point(12, 99)
        Me.lbInventarioTipo.Name = "lbInventarioTipo"
        Me.lbInventarioTipo.Size = New System.Drawing.Size(95, 13)
        Me.lbInventarioTipo.TabIndex = 117
        Me.lbInventarioTipo.Text = "Tipo de inventario:"
        '
        'cbInventarioTipo
        '
        Me.cbInventarioTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbInventarioTipo.FormattingEnabled = True
        Me.cbInventarioTipo.Location = New System.Drawing.Point(125, 96)
        Me.cbInventarioTipo.Name = "cbInventarioTipo"
        Me.cbInventarioTipo.Size = New System.Drawing.Size(550, 21)
        Me.cbInventarioTipo.TabIndex = 2
        '
        'tbInventarioTipo
        '
        Me.tbInventarioTipo.Location = New System.Drawing.Point(99, 96)
        Me.tbInventarioTipo.MaxLength = 100
        Me.tbInventarioTipo.Name = "tbInventarioTipo"
        Me.tbInventarioTipo.Size = New System.Drawing.Size(20, 20)
        Me.tbInventarioTipo.TabIndex = 100
        Me.tbInventarioTipo.Visible = False
        '
        'cbMedida
        '
        Me.cbMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMedida.FormattingEnabled = True
        Me.cbMedida.Location = New System.Drawing.Point(125, 175)
        Me.cbMedida.Name = "cbMedida"
        Me.cbMedida.Size = New System.Drawing.Size(550, 21)
        Me.cbMedida.TabIndex = 5
        '
        'tbPrecio
        '
        Me.tbPrecio.Location = New System.Drawing.Point(525, 202)
        Me.tbPrecio.MaxLength = 100
        Me.tbPrecio.Name = "tbPrecio"
        Me.tbPrecio.Size = New System.Drawing.Size(150, 20)
        Me.tbPrecio.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(412, 205)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 120
        Me.Label1.Text = "Precio:"
        '
        'UcNavegador1
        '
        Me.UcNavegador1.AutoSize = True
        Me.UcNavegador1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcNavegador1.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.UcNavegador1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UcNavegador1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcNavegador1.Location = New System.Drawing.Point(0, 235)
        Me.UcNavegador1.MinimumSize = New System.Drawing.Size(0, 56)
        Me.UcNavegador1.Name = "UcNavegador1"
        Me.UcNavegador1.Size = New System.Drawing.Size(689, 60)
        Me.UcNavegador1.TabIndex = 100
        '
        'tbEmpresa
        '
        Me.tbEmpresa.Location = New System.Drawing.Point(281, 70)
        Me.tbEmpresa.MaxLength = 100
        Me.tbEmpresa.Name = "tbEmpresa"
        Me.tbEmpresa.Size = New System.Drawing.Size(20, 20)
        Me.tbEmpresa.TabIndex = 100
        Me.tbEmpresa.Visible = False
        '
        'frInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(689, 295)
        Me.Controls.Add(Me.tbEmpresa)
        Me.Controls.Add(Me.UcNavegador1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbPrecio)
        Me.Controls.Add(Me.cbMedida)
        Me.Controls.Add(Me.lbInventarioTipo)
        Me.Controls.Add(Me.cbInventarioTipo)
        Me.Controls.Add(Me.tbInventarioTipo)
        Me.Controls.Add(Me.tbFechaCreacion)
        Me.Controls.Add(Me.dpFechaCreacion)
        Me.Controls.Add(Me.pnlPanelTitulo)
        Me.Controls.Add(Me.lbEstado)
        Me.Controls.Add(Me.tbMedida)
        Me.Controls.Add(Me.lbMedida)
        Me.Controls.Add(Me.lbFecha)
        Me.Controls.Add(Me.lbNombre)
        Me.Controls.Add(Me.tbNombre)
        Me.Controls.Add(Me.tbEstado1)
        Me.Controls.Add(Me.tbEstado)
        Me.Controls.Add(Me.lbDescripcion)
        Me.Controls.Add(Me.lbCodigo)
        Me.Controls.Add(Me.tbDescripcion)
        Me.Controls.Add(Me.tbCodigo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "frInventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Inventario"
        Me.pnlPanelTitulo.ResumeLayout(False)
        Me.pnlPanelTitulo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbEstado1 As TextBox
    Friend WithEvents tbEstado As TextBox
    Friend WithEvents lbDescripcion As Label
    Friend WithEvents lbCodigo As Label
    Friend WithEvents tbDescripcion As TextBox
    Friend WithEvents tbCodigo As TextBox
    Friend WithEvents lbNombre As Label
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents lbFecha As Label
    Friend WithEvents lbMedida As Label
    Friend WithEvents tbMedida As TextBox
    Friend WithEvents lbEstado As Label
    Friend WithEvents pnlPanelTitulo As Panel
    Friend WithEvents lbTitulo As Label
    Friend WithEvents tbFechaCreacion As TextBox
    Friend WithEvents dpFechaCreacion As DateTimePicker
    Friend WithEvents lbInventarioTipo As Label
    Friend WithEvents cbInventarioTipo As ComboBox
    Friend WithEvents tbInventarioTipo As TextBox
    Friend WithEvents cbMedida As ComboBox
    Friend WithEvents tbPrecio As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents UcNavegador1 As ucNavegador
    Friend WithEvents tbEmpresa As TextBox
End Class
