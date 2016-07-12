<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frRecetario
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tbEmpresa = New System.Windows.Forms.TextBox()
        Me.lbInventario = New System.Windows.Forms.Label()
        Me.cbInventario = New System.Windows.Forms.ComboBox()
        Me.lbDescripcion = New System.Windows.Forms.Label()
        Me.tbDescripcion = New System.Windows.Forms.TextBox()
        Me.tbInventario = New System.Windows.Forms.TextBox()
        Me.tbEstado1 = New System.Windows.Forms.TextBox()
        Me.lbEstado = New System.Windows.Forms.Label()
        Me.tbEstado = New System.Windows.Forms.TextBox()
        Me.lbCodigo = New System.Windows.Forms.Label()
        Me.tbCodigo = New System.Windows.Forms.TextBox()
        Me.dpFechaCreacion = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbFechaCreacion = New System.Windows.Forms.TextBox()
        Me.pnlPanelTitulo = New System.Windows.Forms.Panel()
        Me.lbTitulo = New System.Windows.Forms.Label()
        Me.lbInventarios = New System.Windows.Forms.Label()
        Me.btEliminarInventario = New System.Windows.Forms.Button()
        Me.btAgregarInventario = New System.Windows.Forms.Button()
        Me.dgRecetarioInventario = New System.Windows.Forms.DataGridView()
        Me.btEliminarTarea = New System.Windows.Forms.Button()
        Me.btAgregarTarea = New System.Windows.Forms.Button()
        Me.lbTarea = New System.Windows.Forms.Label()
        Me.dgRecetarioTarea = New System.Windows.Forms.DataGridView()
        Me.UcNavegador1 = New MRP.ucNavegador()
        Me.rta_duracion_horas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.riv_cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.riv_precio_unitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.riv_precio_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlPanelTitulo.SuspendLayout()
        CType(Me.dgRecetarioInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgRecetarioTarea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbEmpresa
        '
        Me.tbEmpresa.Location = New System.Drawing.Point(281, 70)
        Me.tbEmpresa.MaxLength = 100
        Me.tbEmpresa.Name = "tbEmpresa"
        Me.tbEmpresa.Size = New System.Drawing.Size(20, 20)
        Me.tbEmpresa.TabIndex = 51
        Me.tbEmpresa.Visible = False
        '
        'lbInventario
        '
        Me.lbInventario.AutoSize = True
        Me.lbInventario.Location = New System.Drawing.Point(12, 99)
        Me.lbInventario.Name = "lbInventario"
        Me.lbInventario.Size = New System.Drawing.Size(57, 13)
        Me.lbInventario.TabIndex = 50
        Me.lbInventario.Text = "Inventario:"
        '
        'cbInventario
        '
        Me.cbInventario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbInventario.FormattingEnabled = True
        Me.cbInventario.Location = New System.Drawing.Point(125, 96)
        Me.cbInventario.Name = "cbInventario"
        Me.cbInventario.Size = New System.Drawing.Size(550, 21)
        Me.cbInventario.TabIndex = 2
        '
        'lbDescripcion
        '
        Me.lbDescripcion.AutoSize = True
        Me.lbDescripcion.Location = New System.Drawing.Point(12, 126)
        Me.lbDescripcion.Name = "lbDescripcion"
        Me.lbDescripcion.Size = New System.Drawing.Size(66, 13)
        Me.lbDescripcion.TabIndex = 49
        Me.lbDescripcion.Text = "Descripción:"
        '
        'tbDescripcion
        '
        Me.tbDescripcion.Location = New System.Drawing.Point(125, 123)
        Me.tbDescripcion.MaxLength = 256
        Me.tbDescripcion.Name = "tbDescripcion"
        Me.tbDescripcion.Size = New System.Drawing.Size(550, 20)
        Me.tbDescripcion.TabIndex = 3
        '
        'tbInventario
        '
        Me.tbInventario.Location = New System.Drawing.Point(99, 96)
        Me.tbInventario.MaxLength = 100
        Me.tbInventario.Name = "tbInventario"
        Me.tbInventario.Size = New System.Drawing.Size(20, 20)
        Me.tbInventario.TabIndex = 48
        Me.tbInventario.Visible = False
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
        Me.tbEstado.TabIndex = 44
        Me.tbEstado.Visible = False
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
        'tbCodigo
        '
        Me.tbCodigo.Location = New System.Drawing.Point(125, 70)
        Me.tbCodigo.Name = "tbCodigo"
        Me.tbCodigo.ReadOnly = True
        Me.tbCodigo.Size = New System.Drawing.Size(150, 20)
        Me.tbCodigo.TabIndex = 0
        Me.tbCodigo.TabStop = False
        '
        'dpFechaCreacion
        '
        Me.dpFechaCreacion.CustomFormat = "dd/MM/yyyy"
        Me.dpFechaCreacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpFechaCreacion.Location = New System.Drawing.Point(125, 149)
        Me.dpFechaCreacion.Name = "dpFechaCreacion"
        Me.dpFechaCreacion.Size = New System.Drawing.Size(150, 20)
        Me.dpFechaCreacion.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Fecha de creación:"
        '
        'tbFechaCreacion
        '
        Me.tbFechaCreacion.Location = New System.Drawing.Point(281, 149)
        Me.tbFechaCreacion.MaxLength = 100
        Me.tbFechaCreacion.Name = "tbFechaCreacion"
        Me.tbFechaCreacion.Size = New System.Drawing.Size(20, 20)
        Me.tbFechaCreacion.TabIndex = 54
        Me.tbFechaCreacion.Visible = False
        '
        'pnlPanelTitulo
        '
        Me.pnlPanelTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPanelTitulo.Controls.Add(Me.lbTitulo)
        Me.pnlPanelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlPanelTitulo.Location = New System.Drawing.Point(0, 0)
        Me.pnlPanelTitulo.Name = "pnlPanelTitulo"
        Me.pnlPanelTitulo.Size = New System.Drawing.Size(689, 50)
        Me.pnlPanelTitulo.TabIndex = 102
        '
        'lbTitulo
        '
        Me.lbTitulo.AutoSize = True
        Me.lbTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTitulo.Location = New System.Drawing.Point(12, 9)
        Me.lbTitulo.Name = "lbTitulo"
        Me.lbTitulo.Size = New System.Drawing.Size(140, 31)
        Me.lbTitulo.TabIndex = 41
        Me.lbTitulo.Text = "Recetario"
        '
        'lbInventarios
        '
        Me.lbInventarios.AutoSize = True
        Me.lbInventarios.Location = New System.Drawing.Point(12, 178)
        Me.lbInventarios.Name = "lbInventarios"
        Me.lbInventarios.Size = New System.Drawing.Size(62, 13)
        Me.lbInventarios.TabIndex = 107
        Me.lbInventarios.Text = "Inventarios:"
        '
        'btEliminarInventario
        '
        Me.btEliminarInventario.Location = New System.Drawing.Point(256, 331)
        Me.btEliminarInventario.Name = "btEliminarInventario"
        Me.btEliminarInventario.Size = New System.Drawing.Size(125, 23)
        Me.btEliminarInventario.TabIndex = 106
        Me.btEliminarInventario.Text = "Eliminar Inventario"
        Me.btEliminarInventario.UseVisualStyleBackColor = True
        '
        'btAgregarInventario
        '
        Me.btAgregarInventario.Location = New System.Drawing.Point(125, 331)
        Me.btAgregarInventario.Name = "btAgregarInventario"
        Me.btAgregarInventario.Size = New System.Drawing.Size(125, 23)
        Me.btAgregarInventario.TabIndex = 105
        Me.btAgregarInventario.Text = "Agregar Inventario"
        Me.btAgregarInventario.UseVisualStyleBackColor = True
        '
        'dgRecetarioInventario
        '
        Me.dgRecetarioInventario.AllowDrop = True
        Me.dgRecetarioInventario.AllowUserToAddRows = False
        Me.dgRecetarioInventario.AllowUserToDeleteRows = False
        Me.dgRecetarioInventario.AllowUserToResizeColumns = False
        Me.dgRecetarioInventario.AllowUserToResizeRows = False
        Me.dgRecetarioInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgRecetarioInventario.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgRecetarioInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgRecetarioInventario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.riv_cantidad, Me.riv_precio_unitario, Me.riv_precio_total})
        Me.dgRecetarioInventario.GridColor = System.Drawing.SystemColors.Window
        Me.dgRecetarioInventario.Location = New System.Drawing.Point(125, 175)
        Me.dgRecetarioInventario.Name = "dgRecetarioInventario"
        Me.dgRecetarioInventario.RowHeadersVisible = False
        Me.dgRecetarioInventario.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgRecetarioInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgRecetarioInventario.Size = New System.Drawing.Size(550, 150)
        Me.dgRecetarioInventario.TabIndex = 104
        Me.dgRecetarioInventario.Tag = "tbl_mrp_recetario_inventario"
        '
        'btEliminarTarea
        '
        Me.btEliminarTarea.Location = New System.Drawing.Point(256, 516)
        Me.btEliminarTarea.Name = "btEliminarTarea"
        Me.btEliminarTarea.Size = New System.Drawing.Size(125, 23)
        Me.btEliminarTarea.TabIndex = 110
        Me.btEliminarTarea.Text = "Eliminar Tarea"
        Me.btEliminarTarea.UseVisualStyleBackColor = True
        '
        'btAgregarTarea
        '
        Me.btAgregarTarea.Location = New System.Drawing.Point(125, 516)
        Me.btAgregarTarea.Name = "btAgregarTarea"
        Me.btAgregarTarea.Size = New System.Drawing.Size(125, 23)
        Me.btAgregarTarea.TabIndex = 109
        Me.btAgregarTarea.Text = "Agregar Tarea"
        Me.btAgregarTarea.UseVisualStyleBackColor = True
        '
        'lbTarea
        '
        Me.lbTarea.AutoSize = True
        Me.lbTarea.Location = New System.Drawing.Point(12, 363)
        Me.lbTarea.Name = "lbTarea"
        Me.lbTarea.Size = New System.Drawing.Size(43, 13)
        Me.lbTarea.TabIndex = 112
        Me.lbTarea.Text = "Tareas:"
        '
        'dgRecetarioTarea
        '
        Me.dgRecetarioTarea.AllowDrop = True
        Me.dgRecetarioTarea.AllowUserToAddRows = False
        Me.dgRecetarioTarea.AllowUserToDeleteRows = False
        Me.dgRecetarioTarea.AllowUserToResizeColumns = False
        Me.dgRecetarioTarea.AllowUserToResizeRows = False
        Me.dgRecetarioTarea.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgRecetarioTarea.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgRecetarioTarea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgRecetarioTarea.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.rta_duracion_horas})
        Me.dgRecetarioTarea.GridColor = System.Drawing.SystemColors.Window
        Me.dgRecetarioTarea.Location = New System.Drawing.Point(125, 360)
        Me.dgRecetarioTarea.Name = "dgRecetarioTarea"
        Me.dgRecetarioTarea.RowHeadersVisible = False
        Me.dgRecetarioTarea.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgRecetarioTarea.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgRecetarioTarea.Size = New System.Drawing.Size(550, 150)
        Me.dgRecetarioTarea.TabIndex = 111
        Me.dgRecetarioTarea.Tag = "tbl_mrp_recetario_tarea"
        '
        'UcNavegador1
        '
        Me.UcNavegador1.AutoSize = True
        Me.UcNavegador1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcNavegador1.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.UcNavegador1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UcNavegador1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcNavegador1.Location = New System.Drawing.Point(0, 552)
        Me.UcNavegador1.MinimumSize = New System.Drawing.Size(0, 56)
        Me.UcNavegador1.Name = "UcNavegador1"
        Me.UcNavegador1.Size = New System.Drawing.Size(689, 58)
        Me.UcNavegador1.TabIndex = 103
        '
        'rta_duracion_horas
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0.00"
        Me.rta_duracion_horas.DefaultCellStyle = DataGridViewCellStyle4
        Me.rta_duracion_horas.HeaderText = "Duración (Horas)"
        Me.rta_duracion_horas.Name = "rta_duracion_horas"
        '
        'riv_cantidad
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N6"
        DataGridViewCellStyle1.NullValue = "0.00"
        Me.riv_cantidad.DefaultCellStyle = DataGridViewCellStyle1
        Me.riv_cantidad.HeaderText = "Cantidad"
        Me.riv_cantidad.Name = "riv_cantidad"
        '
        'riv_precio_unitario
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N6"
        DataGridViewCellStyle2.NullValue = "0.00"
        Me.riv_precio_unitario.DefaultCellStyle = DataGridViewCellStyle2
        Me.riv_precio_unitario.HeaderText = "Precio Unitario"
        Me.riv_precio_unitario.Name = "riv_precio_unitario"
        '
        'riv_precio_total
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0.00"
        Me.riv_precio_total.DefaultCellStyle = DataGridViewCellStyle3
        Me.riv_precio_total.HeaderText = "Total"
        Me.riv_precio_total.Name = "riv_precio_total"
        '
        'frRecetario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(689, 610)
        Me.Controls.Add(Me.lbTarea)
        Me.Controls.Add(Me.dgRecetarioTarea)
        Me.Controls.Add(Me.btEliminarTarea)
        Me.Controls.Add(Me.btAgregarTarea)
        Me.Controls.Add(Me.lbInventarios)
        Me.Controls.Add(Me.btEliminarInventario)
        Me.Controls.Add(Me.btAgregarInventario)
        Me.Controls.Add(Me.dgRecetarioInventario)
        Me.Controls.Add(Me.UcNavegador1)
        Me.Controls.Add(Me.pnlPanelTitulo)
        Me.Controls.Add(Me.tbFechaCreacion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dpFechaCreacion)
        Me.Controls.Add(Me.tbEmpresa)
        Me.Controls.Add(Me.lbInventario)
        Me.Controls.Add(Me.cbInventario)
        Me.Controls.Add(Me.lbDescripcion)
        Me.Controls.Add(Me.tbDescripcion)
        Me.Controls.Add(Me.tbInventario)
        Me.Controls.Add(Me.tbEstado1)
        Me.Controls.Add(Me.lbEstado)
        Me.Controls.Add(Me.tbEstado)
        Me.Controls.Add(Me.lbCodigo)
        Me.Controls.Add(Me.tbCodigo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimizeBox = False
        Me.Name = "frRecetario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Recetario"
        Me.pnlPanelTitulo.ResumeLayout(False)
        Me.pnlPanelTitulo.PerformLayout()
        CType(Me.dgRecetarioInventario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgRecetarioTarea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbEmpresa As TextBox
    Friend WithEvents lbInventario As Label
    Friend WithEvents cbInventario As ComboBox
    Friend WithEvents lbDescripcion As Label
    Friend WithEvents tbDescripcion As TextBox
    Friend WithEvents tbInventario As TextBox
    Friend WithEvents tbEstado1 As TextBox
    Friend WithEvents lbEstado As Label
    Friend WithEvents tbEstado As TextBox
    Friend WithEvents lbCodigo As Label
    Friend WithEvents tbCodigo As TextBox
    Friend WithEvents dpFechaCreacion As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents tbFechaCreacion As TextBox
    Friend WithEvents pnlPanelTitulo As Panel
    Friend WithEvents lbTitulo As Label
    Friend WithEvents UcNavegador1 As ucNavegador
    Friend WithEvents lbInventarios As Label
    Friend WithEvents btEliminarInventario As Button
    Friend WithEvents btAgregarInventario As Button
    Friend WithEvents dgRecetarioInventario As DataGridView
    Friend WithEvents btEliminarTarea As Button
    Friend WithEvents btAgregarTarea As Button
    Friend WithEvents lbTarea As Label
    Friend WithEvents dgRecetarioTarea As DataGridView
    Friend WithEvents riv_cantidad As DataGridViewTextBoxColumn
    Friend WithEvents riv_precio_unitario As DataGridViewTextBoxColumn
    Friend WithEvents riv_precio_total As DataGridViewTextBoxColumn
    Friend WithEvents rta_duracion_horas As DataGridViewTextBoxColumn
End Class
