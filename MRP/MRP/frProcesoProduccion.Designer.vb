<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frProcesoProduccion
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
        Me.UcNavegador1 = New MRP.ucNavegador()
        Me.pnlPanelTitulo = New System.Windows.Forms.Panel()
        Me.lbTitulo = New System.Windows.Forms.Label()
        Me.tbFechaSolicitud = New System.Windows.Forms.TextBox()
        Me.lbFechaSolicitud = New System.Windows.Forms.Label()
        Me.dpFechaSolicitud = New System.Windows.Forms.DateTimePicker()
        Me.tbEmpresa = New System.Windows.Forms.TextBox()
        Me.tbEstado1 = New System.Windows.Forms.TextBox()
        Me.lbEstado = New System.Windows.Forms.Label()
        Me.tbEstado = New System.Windows.Forms.TextBox()
        Me.lbCodigo = New System.Windows.Forms.Label()
        Me.tbCodigo = New System.Windows.Forms.TextBox()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.tbDescripcion = New System.Windows.Forms.TextBox()
        Me.lbDescripcion = New System.Windows.Forms.Label()
        Me.tbFechaEntrega = New System.Windows.Forms.TextBox()
        Me.lbFechaEntrega = New System.Windows.Forms.Label()
        Me.dpFechaEntrega = New System.Windows.Forms.DateTimePicker()
        Me.tbFechaFinal = New System.Windows.Forms.TextBox()
        Me.lbFechaFinal = New System.Windows.Forms.Label()
        Me.dpFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.tbFechaInicio = New System.Windows.Forms.TextBox()
        Me.lbFechaInicio = New System.Windows.Forms.Label()
        Me.dpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.lbTotal = New System.Windows.Forms.Label()
        Me.tbTotal = New System.Windows.Forms.TextBox()
        Me.lbDestinatario = New System.Windows.Forms.Label()
        Me.tbDestinatario = New System.Windows.Forms.TextBox()
        Me.pnlPanelTitulo.SuspendLayout()
        Me.SuspendLayout()
        '
        'UcNavegador1
        '
        Me.UcNavegador1.AutoSize = True
        Me.UcNavegador1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcNavegador1.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.UcNavegador1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UcNavegador1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcNavegador1.Location = New System.Drawing.Point(0, 260)
        Me.UcNavegador1.MinimumSize = New System.Drawing.Size(0, 56)
        Me.UcNavegador1.Name = "UcNavegador1"
        Me.UcNavegador1.Size = New System.Drawing.Size(689, 60)
        Me.UcNavegador1.TabIndex = 100
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
        Me.lbTitulo.Size = New System.Drawing.Size(315, 31)
        Me.lbTitulo.TabIndex = 41
        Me.lbTitulo.Text = "Proceso de Producción" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'tbFechaSolicitud
        '
        Me.tbFechaSolicitud.Location = New System.Drawing.Point(281, 174)
        Me.tbFechaSolicitud.MaxLength = 100
        Me.tbFechaSolicitud.Name = "tbFechaSolicitud"
        Me.tbFechaSolicitud.Size = New System.Drawing.Size(20, 20)
        Me.tbFechaSolicitud.TabIndex = 100
        Me.tbFechaSolicitud.Visible = False
        '
        'lbFechaSolicitud
        '
        Me.lbFechaSolicitud.AutoSize = True
        Me.lbFechaSolicitud.Location = New System.Drawing.Point(12, 180)
        Me.lbFechaSolicitud.Name = "lbFechaSolicitud"
        Me.lbFechaSolicitud.Size = New System.Drawing.Size(96, 13)
        Me.lbFechaSolicitud.TabIndex = 118
        Me.lbFechaSolicitud.Text = "Fecha de solicitud:"
        '
        'dpFechaSolicitud
        '
        Me.dpFechaSolicitud.CustomFormat = "dd/MM/yyyy"
        Me.dpFechaSolicitud.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpFechaSolicitud.Location = New System.Drawing.Point(125, 174)
        Me.dpFechaSolicitud.Name = "dpFechaSolicitud"
        Me.dpFechaSolicitud.Size = New System.Drawing.Size(150, 20)
        Me.dpFechaSolicitud.TabIndex = 5
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
        Me.lbEstado.TabIndex = 113
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
        'lbCodigo
        '
        Me.lbCodigo.AutoSize = True
        Me.lbCodigo.Location = New System.Drawing.Point(12, 73)
        Me.lbCodigo.Name = "lbCodigo"
        Me.lbCodigo.Size = New System.Drawing.Size(43, 13)
        Me.lbCodigo.TabIndex = 112
        Me.lbCodigo.Text = "Código:"
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
        Me.lbNombre.Location = New System.Drawing.Point(12, 99)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(47, 13)
        Me.lbNombre.TabIndex = 125
        Me.lbNombre.Text = "Nombre:"
        '
        'tbNombre
        '
        Me.tbNombre.Location = New System.Drawing.Point(125, 96)
        Me.tbNombre.MaxLength = 256
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(550, 20)
        Me.tbNombre.TabIndex = 2
        '
        'tbDescripcion
        '
        Me.tbDescripcion.Location = New System.Drawing.Point(125, 122)
        Me.tbDescripcion.MaxLength = 256
        Me.tbDescripcion.Name = "tbDescripcion"
        Me.tbDescripcion.Size = New System.Drawing.Size(550, 20)
        Me.tbDescripcion.TabIndex = 3
        '
        'lbDescripcion
        '
        Me.lbDescripcion.AutoSize = True
        Me.lbDescripcion.Location = New System.Drawing.Point(12, 125)
        Me.lbDescripcion.Name = "lbDescripcion"
        Me.lbDescripcion.Size = New System.Drawing.Size(66, 13)
        Me.lbDescripcion.TabIndex = 115
        Me.lbDescripcion.Text = "Descripción:"
        '
        'tbFechaEntrega
        '
        Me.tbFechaEntrega.Location = New System.Drawing.Point(386, 174)
        Me.tbFechaEntrega.MaxLength = 100
        Me.tbFechaEntrega.Name = "tbFechaEntrega"
        Me.tbFechaEntrega.Size = New System.Drawing.Size(20, 20)
        Me.tbFechaEntrega.TabIndex = 100
        Me.tbFechaEntrega.Visible = False
        '
        'lbFechaEntrega
        '
        Me.lbFechaEntrega.AutoSize = True
        Me.lbFechaEntrega.Location = New System.Drawing.Point(412, 178)
        Me.lbFechaEntrega.Name = "lbFechaEntrega"
        Me.lbFechaEntrega.Size = New System.Drawing.Size(94, 13)
        Me.lbFechaEntrega.TabIndex = 127
        Me.lbFechaEntrega.Text = "Fecha de entrega:"
        '
        'dpFechaEntrega
        '
        Me.dpFechaEntrega.CustomFormat = "dd/MM/yyyy"
        Me.dpFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpFechaEntrega.Location = New System.Drawing.Point(525, 174)
        Me.dpFechaEntrega.Name = "dpFechaEntrega"
        Me.dpFechaEntrega.Size = New System.Drawing.Size(150, 20)
        Me.dpFechaEntrega.TabIndex = 6
        '
        'tbFechaFinal
        '
        Me.tbFechaFinal.Location = New System.Drawing.Point(386, 200)
        Me.tbFechaFinal.MaxLength = 100
        Me.tbFechaFinal.Name = "tbFechaFinal"
        Me.tbFechaFinal.Size = New System.Drawing.Size(20, 20)
        Me.tbFechaFinal.TabIndex = 100
        Me.tbFechaFinal.Visible = False
        '
        'lbFechaFinal
        '
        Me.lbFechaFinal.AutoSize = True
        Me.lbFechaFinal.Location = New System.Drawing.Point(412, 203)
        Me.lbFechaFinal.Name = "lbFechaFinal"
        Me.lbFechaFinal.Size = New System.Drawing.Size(110, 13)
        Me.lbFechaFinal.TabIndex = 133
        Me.lbFechaFinal.Text = "Fecha de finalización:"
        '
        'dpFechaFinal
        '
        Me.dpFechaFinal.CustomFormat = "dd/MM/yyyy"
        Me.dpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpFechaFinal.Location = New System.Drawing.Point(525, 200)
        Me.dpFechaFinal.Name = "dpFechaFinal"
        Me.dpFechaFinal.Size = New System.Drawing.Size(150, 20)
        Me.dpFechaFinal.TabIndex = 8
        '
        'tbFechaInicio
        '
        Me.tbFechaInicio.Location = New System.Drawing.Point(281, 200)
        Me.tbFechaInicio.MaxLength = 100
        Me.tbFechaInicio.Name = "tbFechaInicio"
        Me.tbFechaInicio.Size = New System.Drawing.Size(20, 20)
        Me.tbFechaInicio.TabIndex = 100
        Me.tbFechaInicio.Visible = False
        '
        'lbFechaInicio
        '
        Me.lbFechaInicio.AutoSize = True
        Me.lbFechaInicio.Location = New System.Drawing.Point(12, 203)
        Me.lbFechaInicio.Name = "lbFechaInicio"
        Me.lbFechaInicio.Size = New System.Drawing.Size(82, 13)
        Me.lbFechaInicio.TabIndex = 130
        Me.lbFechaInicio.Text = "Fecha de inicio:"
        '
        'dpFechaInicio
        '
        Me.dpFechaInicio.CustomFormat = "dd/MM/yyyy"
        Me.dpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpFechaInicio.Location = New System.Drawing.Point(125, 200)
        Me.dpFechaInicio.Name = "dpFechaInicio"
        Me.dpFechaInicio.Size = New System.Drawing.Size(150, 20)
        Me.dpFechaInicio.TabIndex = 7
        '
        'lbTotal
        '
        Me.lbTotal.AutoSize = True
        Me.lbTotal.Location = New System.Drawing.Point(12, 229)
        Me.lbTotal.Name = "lbTotal"
        Me.lbTotal.Size = New System.Drawing.Size(34, 13)
        Me.lbTotal.TabIndex = 136
        Me.lbTotal.Text = "Total:"
        '
        'tbTotal
        '
        Me.tbTotal.Location = New System.Drawing.Point(125, 226)
        Me.tbTotal.MaxLength = 256
        Me.tbTotal.Name = "tbTotal"
        Me.tbTotal.Size = New System.Drawing.Size(150, 20)
        Me.tbTotal.TabIndex = 9
        '
        'lbDestinatario
        '
        Me.lbDestinatario.AutoSize = True
        Me.lbDestinatario.Location = New System.Drawing.Point(12, 151)
        Me.lbDestinatario.Name = "lbDestinatario"
        Me.lbDestinatario.Size = New System.Drawing.Size(66, 13)
        Me.lbDestinatario.TabIndex = 138
        Me.lbDestinatario.Text = "Destinatario:"
        '
        'tbDestinatario
        '
        Me.tbDestinatario.Location = New System.Drawing.Point(125, 148)
        Me.tbDestinatario.MaxLength = 256
        Me.tbDestinatario.Name = "tbDestinatario"
        Me.tbDestinatario.Size = New System.Drawing.Size(550, 20)
        Me.tbDestinatario.TabIndex = 4
        '
        'frProcesoProduccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(689, 320)
        Me.Controls.Add(Me.lbDestinatario)
        Me.Controls.Add(Me.tbDestinatario)
        Me.Controls.Add(Me.lbTotal)
        Me.Controls.Add(Me.tbTotal)
        Me.Controls.Add(Me.tbFechaFinal)
        Me.Controls.Add(Me.lbFechaFinal)
        Me.Controls.Add(Me.dpFechaFinal)
        Me.Controls.Add(Me.tbFechaInicio)
        Me.Controls.Add(Me.lbFechaInicio)
        Me.Controls.Add(Me.dpFechaInicio)
        Me.Controls.Add(Me.tbFechaEntrega)
        Me.Controls.Add(Me.lbFechaEntrega)
        Me.Controls.Add(Me.dpFechaEntrega)
        Me.Controls.Add(Me.lbNombre)
        Me.Controls.Add(Me.tbNombre)
        Me.Controls.Add(Me.tbFechaSolicitud)
        Me.Controls.Add(Me.lbFechaSolicitud)
        Me.Controls.Add(Me.dpFechaSolicitud)
        Me.Controls.Add(Me.tbEmpresa)
        Me.Controls.Add(Me.lbDescripcion)
        Me.Controls.Add(Me.tbDescripcion)
        Me.Controls.Add(Me.tbEstado1)
        Me.Controls.Add(Me.lbEstado)
        Me.Controls.Add(Me.tbEstado)
        Me.Controls.Add(Me.lbCodigo)
        Me.Controls.Add(Me.tbCodigo)
        Me.Controls.Add(Me.pnlPanelTitulo)
        Me.Controls.Add(Me.UcNavegador1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimizeBox = False
        Me.Name = "frProcesoProduccion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Proceso de Producción"
        Me.pnlPanelTitulo.ResumeLayout(False)
        Me.pnlPanelTitulo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UcNavegador1 As ucNavegador
    Friend WithEvents pnlPanelTitulo As Panel
    Friend WithEvents lbTitulo As Label
    Friend WithEvents tbFechaSolicitud As TextBox
    Friend WithEvents lbFechaSolicitud As Label
    Friend WithEvents dpFechaSolicitud As DateTimePicker
    Friend WithEvents tbEmpresa As TextBox
    Friend WithEvents tbEstado1 As TextBox
    Friend WithEvents lbEstado As Label
    Friend WithEvents tbEstado As TextBox
    Friend WithEvents lbCodigo As Label
    Friend WithEvents tbCodigo As TextBox
    Friend WithEvents lbNombre As Label
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents tbDescripcion As TextBox
    Friend WithEvents lbDescripcion As Label
    Friend WithEvents tbFechaEntrega As TextBox
    Friend WithEvents lbFechaEntrega As Label
    Friend WithEvents dpFechaEntrega As DateTimePicker
    Friend WithEvents tbFechaFinal As TextBox
    Friend WithEvents lbFechaFinal As Label
    Friend WithEvents dpFechaFinal As DateTimePicker
    Friend WithEvents tbFechaInicio As TextBox
    Friend WithEvents lbFechaInicio As Label
    Friend WithEvents dpFechaInicio As DateTimePicker
    Friend WithEvents lbTotal As Label
    Friend WithEvents tbTotal As TextBox
    Friend WithEvents lbDestinatario As Label
    Friend WithEvents tbDestinatario As TextBox
End Class
