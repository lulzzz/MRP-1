<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frOrdenProduccion
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
        Me.pnlPanelTitulo = New System.Windows.Forms.Panel()
        Me.lbTitulo = New System.Windows.Forms.Label()
        Me.UcNavegador1 = New MRP.ucNavegador()
        Me.tbEmpresa = New System.Windows.Forms.TextBox()
        Me.tbEstado1 = New System.Windows.Forms.TextBox()
        Me.lbEstado = New System.Windows.Forms.Label()
        Me.tbEstado = New System.Windows.Forms.TextBox()
        Me.lbCodigo = New System.Windows.Forms.Label()
        Me.tbCodigo = New System.Windows.Forms.TextBox()
        Me.tbFecha = New System.Windows.Forms.TextBox()
        Me.lbFechaSolicitud = New System.Windows.Forms.Label()
        Me.dpFecha = New System.Windows.Forms.DateTimePicker()
        Me.lbTareaTipo = New System.Windows.Forms.Label()
        Me.cbProcesoProduccion = New System.Windows.Forms.ComboBox()
        Me.tbProcesoProduccion = New System.Windows.Forms.TextBox()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.lbStatus = New System.Windows.Forms.Label()
        Me.tbStatus = New System.Windows.Forms.TextBox()
        Me.pnlPanelTitulo.SuspendLayout()
        Me.SuspendLayout()
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
        Me.lbTitulo.Size = New System.Drawing.Size(319, 31)
        Me.lbTitulo.TabIndex = 41
        Me.lbTitulo.Text = "Órdenes de Producción"
        '
        'UcNavegador1
        '
        Me.UcNavegador1.AutoSize = True
        Me.UcNavegador1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcNavegador1.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.UcNavegador1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UcNavegador1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcNavegador1.Location = New System.Drawing.Point(0, 160)
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
        Me.tbEmpresa.TabIndex = 106
        Me.tbEmpresa.Visible = False
        '
        'tbEstado1
        '
        Me.tbEstado1.Location = New System.Drawing.Point(525, 70)
        Me.tbEstado1.Name = "tbEstado1"
        Me.tbEstado1.ReadOnly = True
        Me.tbEstado1.Size = New System.Drawing.Size(150, 20)
        Me.tbEstado1.TabIndex = 102
        Me.tbEstado1.TabStop = False
        '
        'lbEstado
        '
        Me.lbEstado.AutoSize = True
        Me.lbEstado.Location = New System.Drawing.Point(412, 73)
        Me.lbEstado.Name = "lbEstado"
        Me.lbEstado.Size = New System.Drawing.Size(43, 13)
        Me.lbEstado.TabIndex = 105
        Me.lbEstado.Text = "Estado:"
        '
        'tbEstado
        '
        Me.tbEstado.Location = New System.Drawing.Point(499, 70)
        Me.tbEstado.Name = "tbEstado"
        Me.tbEstado.Size = New System.Drawing.Size(20, 20)
        Me.tbEstado.TabIndex = 103
        Me.tbEstado.Visible = False
        '
        'lbCodigo
        '
        Me.lbCodigo.AutoSize = True
        Me.lbCodigo.Location = New System.Drawing.Point(12, 73)
        Me.lbCodigo.Name = "lbCodigo"
        Me.lbCodigo.Size = New System.Drawing.Size(43, 13)
        Me.lbCodigo.TabIndex = 104
        Me.lbCodigo.Text = "Código:"
        '
        'tbCodigo
        '
        Me.tbCodigo.Location = New System.Drawing.Point(125, 70)
        Me.tbCodigo.Name = "tbCodigo"
        Me.tbCodigo.ReadOnly = True
        Me.tbCodigo.Size = New System.Drawing.Size(150, 20)
        Me.tbCodigo.TabIndex = 101
        Me.tbCodigo.TabStop = False
        '
        'tbFecha
        '
        Me.tbFecha.Location = New System.Drawing.Point(281, 123)
        Me.tbFecha.MaxLength = 100
        Me.tbFecha.Name = "tbFecha"
        Me.tbFecha.Size = New System.Drawing.Size(20, 20)
        Me.tbFecha.TabIndex = 120
        Me.tbFecha.Visible = False
        '
        'lbFechaSolicitud
        '
        Me.lbFechaSolicitud.AutoSize = True
        Me.lbFechaSolicitud.Location = New System.Drawing.Point(12, 129)
        Me.lbFechaSolicitud.Name = "lbFechaSolicitud"
        Me.lbFechaSolicitud.Size = New System.Drawing.Size(40, 13)
        Me.lbFechaSolicitud.TabIndex = 121
        Me.lbFechaSolicitud.Text = "Fecha:"
        '
        'dpFecha
        '
        Me.dpFecha.CustomFormat = "dd/MM/yyyy"
        Me.dpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpFecha.Location = New System.Drawing.Point(125, 123)
        Me.dpFecha.Name = "dpFecha"
        Me.dpFecha.Size = New System.Drawing.Size(150, 20)
        Me.dpFecha.TabIndex = 119
        '
        'lbTareaTipo
        '
        Me.lbTareaTipo.AutoSize = True
        Me.lbTareaTipo.Location = New System.Drawing.Point(12, 99)
        Me.lbTareaTipo.Name = "lbTareaTipo"
        Me.lbTareaTipo.Size = New System.Drawing.Size(106, 13)
        Me.lbTareaTipo.TabIndex = 124
        Me.lbTareaTipo.Text = "Proceso Producción:"
        '
        'cbProcesoProduccion
        '
        Me.cbProcesoProduccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProcesoProduccion.FormattingEnabled = True
        Me.cbProcesoProduccion.Location = New System.Drawing.Point(125, 96)
        Me.cbProcesoProduccion.Name = "cbProcesoProduccion"
        Me.cbProcesoProduccion.Size = New System.Drawing.Size(550, 21)
        Me.cbProcesoProduccion.TabIndex = 122
        '
        'tbProcesoProduccion
        '
        Me.tbProcesoProduccion.Location = New System.Drawing.Point(307, 123)
        Me.tbProcesoProduccion.MaxLength = 100
        Me.tbProcesoProduccion.Name = "tbProcesoProduccion"
        Me.tbProcesoProduccion.Size = New System.Drawing.Size(20, 20)
        Me.tbProcesoProduccion.TabIndex = 123
        Me.tbProcesoProduccion.Visible = False
        '
        'cbStatus
        '
        Me.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Location = New System.Drawing.Point(525, 123)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(150, 21)
        Me.cbStatus.TabIndex = 125
        '
        'lbStatus
        '
        Me.lbStatus.AutoSize = True
        Me.lbStatus.Location = New System.Drawing.Point(412, 126)
        Me.lbStatus.Name = "lbStatus"
        Me.lbStatus.Size = New System.Drawing.Size(40, 13)
        Me.lbStatus.TabIndex = 126
        Me.lbStatus.Text = "Status:"
        '
        'tbStatus
        '
        Me.tbStatus.Location = New System.Drawing.Point(499, 123)
        Me.tbStatus.MaxLength = 256
        Me.tbStatus.Name = "tbStatus"
        Me.tbStatus.Size = New System.Drawing.Size(20, 20)
        Me.tbStatus.TabIndex = 127
        Me.tbStatus.Visible = False
        '
        'frOrdenProduccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 220)
        Me.Controls.Add(Me.cbStatus)
        Me.Controls.Add(Me.lbStatus)
        Me.Controls.Add(Me.tbStatus)
        Me.Controls.Add(Me.lbTareaTipo)
        Me.Controls.Add(Me.cbProcesoProduccion)
        Me.Controls.Add(Me.tbProcesoProduccion)
        Me.Controls.Add(Me.tbFecha)
        Me.Controls.Add(Me.lbFechaSolicitud)
        Me.Controls.Add(Me.dpFecha)
        Me.Controls.Add(Me.tbEmpresa)
        Me.Controls.Add(Me.tbEstado1)
        Me.Controls.Add(Me.lbEstado)
        Me.Controls.Add(Me.tbEstado)
        Me.Controls.Add(Me.lbCodigo)
        Me.Controls.Add(Me.tbCodigo)
        Me.Controls.Add(Me.UcNavegador1)
        Me.Controls.Add(Me.pnlPanelTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frOrdenProduccion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Órdenes de Producción"
        Me.pnlPanelTitulo.ResumeLayout(False)
        Me.pnlPanelTitulo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlPanelTitulo As Panel
    Friend WithEvents lbTitulo As Label
    Friend WithEvents UcNavegador1 As ucNavegador
    Friend WithEvents tbEmpresa As TextBox
    Friend WithEvents tbEstado1 As TextBox
    Friend WithEvents lbEstado As Label
    Friend WithEvents tbEstado As TextBox
    Friend WithEvents lbCodigo As Label
    Friend WithEvents tbCodigo As TextBox
    Friend WithEvents tbFecha As TextBox
    Friend WithEvents lbFechaSolicitud As Label
    Friend WithEvents dpFecha As DateTimePicker
    Friend WithEvents lbTareaTipo As Label
    Friend WithEvents cbProcesoProduccion As ComboBox
    Friend WithEvents tbProcesoProduccion As TextBox
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents lbStatus As Label
    Friend WithEvents tbStatus As TextBox
End Class
