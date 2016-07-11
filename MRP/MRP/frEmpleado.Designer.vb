<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frEmpleado
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tbEmpresa = New System.Windows.Forms.TextBox()
        Me.lbSegundoNombre = New System.Windows.Forms.Label()
        Me.tbSegundoNombre = New System.Windows.Forms.TextBox()
        Me.tbEstado1 = New System.Windows.Forms.TextBox()
        Me.lbEstado = New System.Windows.Forms.Label()
        Me.tbEstado = New System.Windows.Forms.TextBox()
        Me.lbPrimerNombre = New System.Windows.Forms.Label()
        Me.lbCodigo = New System.Windows.Forms.Label()
        Me.tbPrimerNombre = New System.Windows.Forms.TextBox()
        Me.tbCodigo = New System.Windows.Forms.TextBox()
        Me.lbIdentificacion = New System.Windows.Forms.Label()
        Me.tbIdentificacion = New System.Windows.Forms.TextBox()
        Me.lbPrimerApellido = New System.Windows.Forms.Label()
        Me.tbPrimerApellido = New System.Windows.Forms.TextBox()
        Me.lbSegundoApellido = New System.Windows.Forms.Label()
        Me.tbSegundoApellido = New System.Windows.Forms.TextBox()
        Me.lbIdentificacionTipo = New System.Windows.Forms.Label()
        Me.tbIdentificacionTipo = New System.Windows.Forms.TextBox()
        Me.lbFechaIngreso = New System.Windows.Forms.Label()
        Me.tbFechaIngreso = New System.Windows.Forms.TextBox()
        Me.lbFechaNacimiento = New System.Windows.Forms.Label()
        Me.tbFechaNacimiento = New System.Windows.Forms.TextBox()
        Me.lbDireccion = New System.Windows.Forms.Label()
        Me.tbDireccion = New System.Windows.Forms.TextBox()
        Me.lbCorreo = New System.Windows.Forms.Label()
        Me.tbCorreo = New System.Windows.Forms.TextBox()
        Me.lbTelefono = New System.Windows.Forms.Label()
        Me.tbTelefono = New System.Windows.Forms.TextBox()
        Me.lbProfesion = New System.Windows.Forms.Label()
        Me.tbProfesion = New System.Windows.Forms.TextBox()
        Me.lbGenero = New System.Windows.Forms.Label()
        Me.tbGenero = New System.Windows.Forms.TextBox()
        Me.lbNit = New System.Windows.Forms.Label()
        Me.tbNit = New System.Windows.Forms.TextBox()
        Me.pnlPanelTitulo = New System.Windows.Forms.Panel()
        Me.lbTitulo = New System.Windows.Forms.Label()
        Me.UcNavegador1 = New MRP.ucNavegador()
        Me.lbPais = New System.Windows.Forms.Label()
        Me.cbPais = New System.Windows.Forms.ComboBox()
        Me.tbPais = New System.Windows.Forms.TextBox()
        Me.cbGenero = New System.Windows.Forms.ComboBox()
        Me.dpFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.dpFechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.cbTipoIdentificacion = New System.Windows.Forms.ComboBox()
        Me.pnlPanelTitulo.SuspendLayout()
        Me.SuspendLayout()
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
        'lbSegundoNombre
        '
        Me.lbSegundoNombre.AutoSize = True
        Me.lbSegundoNombre.Location = New System.Drawing.Point(12, 125)
        Me.lbSegundoNombre.Name = "lbSegundoNombre"
        Me.lbSegundoNombre.Size = New System.Drawing.Size(91, 13)
        Me.lbSegundoNombre.TabIndex = 49
        Me.lbSegundoNombre.Text = "Segundo nombre:"
        '
        'tbSegundoNombre
        '
        Me.tbSegundoNombre.Location = New System.Drawing.Point(125, 122)
        Me.tbSegundoNombre.MaxLength = 256
        Me.tbSegundoNombre.Name = "tbSegundoNombre"
        Me.tbSegundoNombre.Size = New System.Drawing.Size(550, 20)
        Me.tbSegundoNombre.TabIndex = 3
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
        'lbEstado
        '
        Me.lbEstado.AutoSize = True
        Me.lbEstado.Location = New System.Drawing.Point(412, 73)
        Me.lbEstado.Name = "lbEstado"
        Me.lbEstado.Size = New System.Drawing.Size(43, 13)
        Me.lbEstado.TabIndex = 47
        Me.lbEstado.Text = "Estado:"
        '
        'tbEstado
        '
        Me.tbEstado.Location = New System.Drawing.Point(499, 70)
        Me.tbEstado.Name = "tbEstado"
        Me.tbEstado.Size = New System.Drawing.Size(20, 20)
        Me.tbEstado.TabIndex = 100
        Me.tbEstado.Visible = False
        '
        'lbPrimerNombre
        '
        Me.lbPrimerNombre.AutoSize = True
        Me.lbPrimerNombre.Location = New System.Drawing.Point(12, 99)
        Me.lbPrimerNombre.Name = "lbPrimerNombre"
        Me.lbPrimerNombre.Size = New System.Drawing.Size(77, 13)
        Me.lbPrimerNombre.TabIndex = 46
        Me.lbPrimerNombre.Text = "Primer nombre:"
        '
        'lbCodigo
        '
        Me.lbCodigo.AutoSize = True
        Me.lbCodigo.Location = New System.Drawing.Point(12, 73)
        Me.lbCodigo.Name = "lbCodigo"
        Me.lbCodigo.Size = New System.Drawing.Size(43, 13)
        Me.lbCodigo.TabIndex = 45
        Me.lbCodigo.Text = "Código:"
        '
        'tbPrimerNombre
        '
        Me.tbPrimerNombre.Location = New System.Drawing.Point(125, 96)
        Me.tbPrimerNombre.MaxLength = 100
        Me.tbPrimerNombre.Name = "tbPrimerNombre"
        Me.tbPrimerNombre.Size = New System.Drawing.Size(550, 20)
        Me.tbPrimerNombre.TabIndex = 2
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
        'lbIdentificacion
        '
        Me.lbIdentificacion.AutoSize = True
        Me.lbIdentificacion.Location = New System.Drawing.Point(412, 203)
        Me.lbIdentificacion.Name = "lbIdentificacion"
        Me.lbIdentificacion.Size = New System.Drawing.Size(73, 13)
        Me.lbIdentificacion.TabIndex = 55
        Me.lbIdentificacion.Text = "Identificacion:"
        '
        'tbIdentificacion
        '
        Me.tbIdentificacion.Location = New System.Drawing.Point(525, 200)
        Me.tbIdentificacion.MaxLength = 256
        Me.tbIdentificacion.Name = "tbIdentificacion"
        Me.tbIdentificacion.Size = New System.Drawing.Size(150, 20)
        Me.tbIdentificacion.TabIndex = 7
        '
        'lbPrimerApellido
        '
        Me.lbPrimerApellido.AutoSize = True
        Me.lbPrimerApellido.Location = New System.Drawing.Point(12, 151)
        Me.lbPrimerApellido.Name = "lbPrimerApellido"
        Me.lbPrimerApellido.Size = New System.Drawing.Size(78, 13)
        Me.lbPrimerApellido.TabIndex = 54
        Me.lbPrimerApellido.Text = "Primer apellido:"
        '
        'tbPrimerApellido
        '
        Me.tbPrimerApellido.Location = New System.Drawing.Point(125, 148)
        Me.tbPrimerApellido.MaxLength = 100
        Me.tbPrimerApellido.Name = "tbPrimerApellido"
        Me.tbPrimerApellido.Size = New System.Drawing.Size(550, 20)
        Me.tbPrimerApellido.TabIndex = 4
        '
        'lbSegundoApellido
        '
        Me.lbSegundoApellido.AutoSize = True
        Me.lbSegundoApellido.Location = New System.Drawing.Point(12, 177)
        Me.lbSegundoApellido.Name = "lbSegundoApellido"
        Me.lbSegundoApellido.Size = New System.Drawing.Size(92, 13)
        Me.lbSegundoApellido.TabIndex = 79
        Me.lbSegundoApellido.Text = "Segundo apellido:"
        '
        'tbSegundoApellido
        '
        Me.tbSegundoApellido.Location = New System.Drawing.Point(125, 174)
        Me.tbSegundoApellido.MaxLength = 256
        Me.tbSegundoApellido.Name = "tbSegundoApellido"
        Me.tbSegundoApellido.Size = New System.Drawing.Size(550, 20)
        Me.tbSegundoApellido.TabIndex = 5
        '
        'lbIdentificacionTipo
        '
        Me.lbIdentificacionTipo.AutoSize = True
        Me.lbIdentificacionTipo.Location = New System.Drawing.Point(12, 203)
        Me.lbIdentificacionTipo.Name = "lbIdentificacionTipo"
        Me.lbIdentificacionTipo.Size = New System.Drawing.Size(96, 13)
        Me.lbIdentificacionTipo.TabIndex = 81
        Me.lbIdentificacionTipo.Text = "Tipo identificación:"
        '
        'tbIdentificacionTipo
        '
        Me.tbIdentificacionTipo.Location = New System.Drawing.Point(281, 200)
        Me.tbIdentificacionTipo.MaxLength = 256
        Me.tbIdentificacionTipo.Name = "tbIdentificacionTipo"
        Me.tbIdentificacionTipo.Size = New System.Drawing.Size(20, 20)
        Me.tbIdentificacionTipo.TabIndex = 6
        Me.tbIdentificacionTipo.Visible = False
        '
        'lbFechaIngreso
        '
        Me.lbFechaIngreso.AutoSize = True
        Me.lbFechaIngreso.Location = New System.Drawing.Point(412, 257)
        Me.lbFechaIngreso.Name = "lbFechaIngreso"
        Me.lbFechaIngreso.Size = New System.Drawing.Size(92, 13)
        Me.lbFechaIngreso.TabIndex = 85
        Me.lbFechaIngreso.Text = "Fecha de ingreso:"
        '
        'tbFechaIngreso
        '
        Me.tbFechaIngreso.Location = New System.Drawing.Point(386, 254)
        Me.tbFechaIngreso.MaxLength = 256
        Me.tbFechaIngreso.Name = "tbFechaIngreso"
        Me.tbFechaIngreso.Size = New System.Drawing.Size(20, 20)
        Me.tbFechaIngreso.TabIndex = 100
        Me.tbFechaIngreso.Visible = False
        '
        'lbFechaNacimiento
        '
        Me.lbFechaNacimiento.AutoSize = True
        Me.lbFechaNacimiento.Location = New System.Drawing.Point(12, 257)
        Me.lbFechaNacimiento.Name = "lbFechaNacimiento"
        Me.lbFechaNacimiento.Size = New System.Drawing.Size(109, 13)
        Me.lbFechaNacimiento.TabIndex = 83
        Me.lbFechaNacimiento.Text = "Fecha de nacimiento:"
        '
        'tbFechaNacimiento
        '
        Me.tbFechaNacimiento.Location = New System.Drawing.Point(281, 254)
        Me.tbFechaNacimiento.MaxLength = 256
        Me.tbFechaNacimiento.Name = "tbFechaNacimiento"
        Me.tbFechaNacimiento.Size = New System.Drawing.Size(20, 20)
        Me.tbFechaNacimiento.TabIndex = 100
        Me.tbFechaNacimiento.Visible = False
        '
        'lbDireccion
        '
        Me.lbDireccion.AutoSize = True
        Me.lbDireccion.Location = New System.Drawing.Point(12, 283)
        Me.lbDireccion.Name = "lbDireccion"
        Me.lbDireccion.Size = New System.Drawing.Size(55, 13)
        Me.lbDireccion.TabIndex = 87
        Me.lbDireccion.Text = "Dirección:"
        '
        'tbDireccion
        '
        Me.tbDireccion.Location = New System.Drawing.Point(125, 280)
        Me.tbDireccion.MaxLength = 256
        Me.tbDireccion.Name = "tbDireccion"
        Me.tbDireccion.Size = New System.Drawing.Size(550, 20)
        Me.tbDireccion.TabIndex = 11
        '
        'lbCorreo
        '
        Me.lbCorreo.AutoSize = True
        Me.lbCorreo.Location = New System.Drawing.Point(12, 335)
        Me.lbCorreo.Name = "lbCorreo"
        Me.lbCorreo.Size = New System.Drawing.Size(35, 13)
        Me.lbCorreo.TabIndex = 91
        Me.lbCorreo.Text = "Email:"
        '
        'tbCorreo
        '
        Me.tbCorreo.Location = New System.Drawing.Point(125, 332)
        Me.tbCorreo.MaxLength = 256
        Me.tbCorreo.Name = "tbCorreo"
        Me.tbCorreo.Size = New System.Drawing.Size(550, 20)
        Me.tbCorreo.TabIndex = 13
        '
        'lbTelefono
        '
        Me.lbTelefono.AutoSize = True
        Me.lbTelefono.Location = New System.Drawing.Point(12, 309)
        Me.lbTelefono.Name = "lbTelefono"
        Me.lbTelefono.Size = New System.Drawing.Size(52, 13)
        Me.lbTelefono.TabIndex = 89
        Me.lbTelefono.Text = "Teléfono:"
        '
        'tbTelefono
        '
        Me.tbTelefono.Location = New System.Drawing.Point(125, 306)
        Me.tbTelefono.MaxLength = 256
        Me.tbTelefono.Name = "tbTelefono"
        Me.tbTelefono.Size = New System.Drawing.Size(550, 20)
        Me.tbTelefono.TabIndex = 12
        '
        'lbProfesion
        '
        Me.lbProfesion.AutoSize = True
        Me.lbProfesion.Location = New System.Drawing.Point(12, 388)
        Me.lbProfesion.Name = "lbProfesion"
        Me.lbProfesion.Size = New System.Drawing.Size(54, 13)
        Me.lbProfesion.TabIndex = 95
        Me.lbProfesion.Text = "Profesión:"
        '
        'tbProfesion
        '
        Me.tbProfesion.Location = New System.Drawing.Point(125, 385)
        Me.tbProfesion.MaxLength = 256
        Me.tbProfesion.Name = "tbProfesion"
        Me.tbProfesion.Size = New System.Drawing.Size(550, 20)
        Me.tbProfesion.TabIndex = 16
        '
        'lbGenero
        '
        Me.lbGenero.AutoSize = True
        Me.lbGenero.Location = New System.Drawing.Point(12, 361)
        Me.lbGenero.Name = "lbGenero"
        Me.lbGenero.Size = New System.Drawing.Size(45, 13)
        Me.lbGenero.TabIndex = 93
        Me.lbGenero.Text = "Género:"
        '
        'tbGenero
        '
        Me.tbGenero.Location = New System.Drawing.Point(99, 358)
        Me.tbGenero.MaxLength = 256
        Me.tbGenero.Name = "tbGenero"
        Me.tbGenero.Size = New System.Drawing.Size(20, 20)
        Me.tbGenero.TabIndex = 100
        Me.tbGenero.Visible = False
        '
        'lbNit
        '
        Me.lbNit.AutoSize = True
        Me.lbNit.Location = New System.Drawing.Point(412, 361)
        Me.lbNit.Name = "lbNit"
        Me.lbNit.Size = New System.Drawing.Size(28, 13)
        Me.lbNit.TabIndex = 97
        Me.lbNit.Text = "NIT:"
        '
        'tbNit
        '
        Me.tbNit.Location = New System.Drawing.Point(525, 358)
        Me.tbNit.MaxLength = 256
        Me.tbNit.Name = "tbNit"
        Me.tbNit.Size = New System.Drawing.Size(150, 20)
        Me.tbNit.TabIndex = 15
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
        Me.lbTitulo.Size = New System.Drawing.Size(158, 31)
        Me.lbTitulo.TabIndex = 41
        Me.lbTitulo.Text = "Empleados"
        '
        'UcNavegador1
        '
        Me.UcNavegador1.AutoSize = True
        Me.UcNavegador1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcNavegador1.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.UcNavegador1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UcNavegador1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcNavegador1.Location = New System.Drawing.Point(0, 420)
        Me.UcNavegador1.MinimumSize = New System.Drawing.Size(0, 56)
        Me.UcNavegador1.Name = "UcNavegador1"
        Me.UcNavegador1.Size = New System.Drawing.Size(689, 60)
        Me.UcNavegador1.TabIndex = 100
        '
        'lbPais
        '
        Me.lbPais.AutoSize = True
        Me.lbPais.Location = New System.Drawing.Point(12, 230)
        Me.lbPais.Name = "lbPais"
        Me.lbPais.Size = New System.Drawing.Size(32, 13)
        Me.lbPais.TabIndex = 102
        Me.lbPais.Text = "País:"
        '
        'cbPais
        '
        Me.cbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPais.FormattingEnabled = True
        Me.cbPais.Location = New System.Drawing.Point(125, 227)
        Me.cbPais.Name = "cbPais"
        Me.cbPais.Size = New System.Drawing.Size(550, 21)
        Me.cbPais.TabIndex = 8
        '
        'tbPais
        '
        Me.tbPais.Location = New System.Drawing.Point(99, 227)
        Me.tbPais.MaxLength = 100
        Me.tbPais.Name = "tbPais"
        Me.tbPais.Size = New System.Drawing.Size(20, 20)
        Me.tbPais.TabIndex = 100
        Me.tbPais.Visible = False
        '
        'cbGenero
        '
        Me.cbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGenero.FormattingEnabled = True
        Me.cbGenero.Location = New System.Drawing.Point(125, 358)
        Me.cbGenero.Name = "cbGenero"
        Me.cbGenero.Size = New System.Drawing.Size(150, 21)
        Me.cbGenero.TabIndex = 14
        '
        'dpFechaNacimiento
        '
        Me.dpFechaNacimiento.CustomFormat = "dd/MM/yyyy"
        Me.dpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpFechaNacimiento.Location = New System.Drawing.Point(125, 254)
        Me.dpFechaNacimiento.Name = "dpFechaNacimiento"
        Me.dpFechaNacimiento.Size = New System.Drawing.Size(150, 20)
        Me.dpFechaNacimiento.TabIndex = 9
        '
        'dpFechaIngreso
        '
        Me.dpFechaIngreso.CustomFormat = "dd/MM/yyyy"
        Me.dpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpFechaIngreso.Location = New System.Drawing.Point(525, 254)
        Me.dpFechaIngreso.Name = "dpFechaIngreso"
        Me.dpFechaIngreso.Size = New System.Drawing.Size(150, 20)
        Me.dpFechaIngreso.TabIndex = 10
        '
        'cbTipoIdentificacion
        '
        Me.cbTipoIdentificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoIdentificacion.FormattingEnabled = True
        Me.cbTipoIdentificacion.Location = New System.Drawing.Point(125, 200)
        Me.cbTipoIdentificacion.Name = "cbTipoIdentificacion"
        Me.cbTipoIdentificacion.Size = New System.Drawing.Size(150, 21)
        Me.cbTipoIdentificacion.TabIndex = 103
        '
        'frEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(689, 480)
        Me.Controls.Add(Me.cbTipoIdentificacion)
        Me.Controls.Add(Me.dpFechaIngreso)
        Me.Controls.Add(Me.dpFechaNacimiento)
        Me.Controls.Add(Me.cbGenero)
        Me.Controls.Add(Me.lbPais)
        Me.Controls.Add(Me.cbPais)
        Me.Controls.Add(Me.tbPais)
        Me.Controls.Add(Me.UcNavegador1)
        Me.Controls.Add(Me.pnlPanelTitulo)
        Me.Controls.Add(Me.lbNit)
        Me.Controls.Add(Me.tbNit)
        Me.Controls.Add(Me.lbProfesion)
        Me.Controls.Add(Me.tbProfesion)
        Me.Controls.Add(Me.lbGenero)
        Me.Controls.Add(Me.tbGenero)
        Me.Controls.Add(Me.lbCorreo)
        Me.Controls.Add(Me.tbCorreo)
        Me.Controls.Add(Me.lbTelefono)
        Me.Controls.Add(Me.tbTelefono)
        Me.Controls.Add(Me.lbDireccion)
        Me.Controls.Add(Me.tbDireccion)
        Me.Controls.Add(Me.lbFechaIngreso)
        Me.Controls.Add(Me.tbFechaIngreso)
        Me.Controls.Add(Me.lbFechaNacimiento)
        Me.Controls.Add(Me.tbFechaNacimiento)
        Me.Controls.Add(Me.lbIdentificacionTipo)
        Me.Controls.Add(Me.tbIdentificacionTipo)
        Me.Controls.Add(Me.lbSegundoApellido)
        Me.Controls.Add(Me.tbSegundoApellido)
        Me.Controls.Add(Me.lbIdentificacion)
        Me.Controls.Add(Me.tbIdentificacion)
        Me.Controls.Add(Me.lbPrimerApellido)
        Me.Controls.Add(Me.tbPrimerApellido)
        Me.Controls.Add(Me.tbEmpresa)
        Me.Controls.Add(Me.lbSegundoNombre)
        Me.Controls.Add(Me.tbSegundoNombre)
        Me.Controls.Add(Me.tbEstado1)
        Me.Controls.Add(Me.lbEstado)
        Me.Controls.Add(Me.tbEstado)
        Me.Controls.Add(Me.lbPrimerNombre)
        Me.Controls.Add(Me.lbCodigo)
        Me.Controls.Add(Me.tbPrimerNombre)
        Me.Controls.Add(Me.tbCodigo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimizeBox = False
        Me.Name = "frEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Empleado"
        Me.pnlPanelTitulo.ResumeLayout(False)
        Me.pnlPanelTitulo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbEmpresa As TextBox
    Friend WithEvents lbSegundoNombre As Label
    Friend WithEvents tbSegundoNombre As TextBox
    Friend WithEvents tbEstado1 As TextBox
    Friend WithEvents lbEstado As Label
    Friend WithEvents tbEstado As TextBox
    Friend WithEvents lbPrimerNombre As Label
    Friend WithEvents lbCodigo As Label
    Friend WithEvents tbPrimerNombre As TextBox
    Friend WithEvents tbCodigo As TextBox
    Friend WithEvents lbIdentificacion As Label
    Friend WithEvents tbIdentificacion As TextBox
    Friend WithEvents lbPrimerApellido As Label
    Friend WithEvents tbPrimerApellido As TextBox
    Friend WithEvents lbSegundoApellido As Label
    Friend WithEvents tbSegundoApellido As TextBox
    Friend WithEvents lbIdentificacionTipo As Label
    Friend WithEvents tbIdentificacionTipo As TextBox
    Friend WithEvents lbFechaIngreso As Label
    Friend WithEvents tbFechaIngreso As TextBox
    Friend WithEvents lbFechaNacimiento As Label
    Friend WithEvents tbFechaNacimiento As TextBox
    Friend WithEvents lbDireccion As Label
    Friend WithEvents tbDireccion As TextBox
    Friend WithEvents lbCorreo As Label
    Friend WithEvents tbCorreo As TextBox
    Friend WithEvents lbTelefono As Label
    Friend WithEvents tbTelefono As TextBox
    Friend WithEvents lbProfesion As Label
    Friend WithEvents tbProfesion As TextBox
    Friend WithEvents lbGenero As Label
    Friend WithEvents tbGenero As TextBox
    Friend WithEvents lbNit As Label
    Friend WithEvents tbNit As TextBox
    Friend WithEvents pnlPanelTitulo As Panel
    Friend WithEvents lbTitulo As Label
    Friend WithEvents UcNavegador1 As ucNavegador
    Friend WithEvents lbPais As Label
    Friend WithEvents cbPais As ComboBox
    Friend WithEvents tbPais As TextBox
    Friend WithEvents cbGenero As ComboBox
    Friend WithEvents dpFechaNacimiento As DateTimePicker
    Friend WithEvents dpFechaIngreso As DateTimePicker
    Friend WithEvents cbTipoIdentificacion As ComboBox
End Class
