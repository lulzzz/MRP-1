<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frMovimiento
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlPanelTitulo = New System.Windows.Forms.Panel()
        Me.lbTitulo = New System.Windows.Forms.Label()
        Me.lbDescripcion = New System.Windows.Forms.Label()
        Me.tbDescripcion = New System.Windows.Forms.TextBox()
        Me.tbEstado1 = New System.Windows.Forms.TextBox()
        Me.lbEstado = New System.Windows.Forms.Label()
        Me.tbEstado = New System.Windows.Forms.TextBox()
        Me.lbNumero = New System.Windows.Forms.Label()
        Me.tbNumero = New System.Windows.Forms.TextBox()
        Me.lbTipo = New System.Windows.Forms.Label()
        Me.lbCodigo = New System.Windows.Forms.Label()
        Me.tbTipo = New System.Windows.Forms.TextBox()
        Me.tbCodigo = New System.Windows.Forms.TextBox()
        Me.cbTipo = New System.Windows.Forms.ComboBox()
        Me.cbBodega = New System.Windows.Forms.ComboBox()
        Me.lbBodega = New System.Windows.Forms.Label()
        Me.tbBodega = New System.Windows.Forms.TextBox()
        Me.lbFecha = New System.Windows.Forms.Label()
        Me.tbFecha = New System.Windows.Forms.TextBox()
        Me.dpFecha = New System.Windows.Forms.DateTimePicker()
        Me.tbEmpresa = New System.Windows.Forms.TextBox()
        Me.lbInventarios = New System.Windows.Forms.Label()
        Me.btEliminarInventario = New System.Windows.Forms.Button()
        Me.btAgregarInventario = New System.Windows.Forms.Button()
        Me.dgMovimientoInventario = New System.Windows.Forms.DataGridView()
        Me.mvi_cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UcNavegador1 = New MRP.ucNavegador()
        Me.pnlPanelTitulo.SuspendLayout()
        CType(Me.dgMovimientoInventario, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lbTitulo.Size = New System.Drawing.Size(177, 31)
        Me.lbTitulo.TabIndex = 41
        Me.lbTitulo.Text = "Movimientos"
        '
        'lbDescripcion
        '
        Me.lbDescripcion.AutoSize = True
        Me.lbDescripcion.Location = New System.Drawing.Point(12, 179)
        Me.lbDescripcion.Name = "lbDescripcion"
        Me.lbDescripcion.Size = New System.Drawing.Size(66, 13)
        Me.lbDescripcion.TabIndex = 117
        Me.lbDescripcion.Text = "Descripción:"
        '
        'tbDescripcion
        '
        Me.tbDescripcion.Location = New System.Drawing.Point(125, 176)
        Me.tbDescripcion.MaxLength = 100
        Me.tbDescripcion.Name = "tbDescripcion"
        Me.tbDescripcion.Size = New System.Drawing.Size(550, 20)
        Me.tbDescripcion.TabIndex = 6
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
        Me.lbEstado.TabIndex = 116
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
        'lbNumero
        '
        Me.lbNumero.AutoSize = True
        Me.lbNumero.Location = New System.Drawing.Point(12, 153)
        Me.lbNumero.Name = "lbNumero"
        Me.lbNumero.Size = New System.Drawing.Size(47, 13)
        Me.lbNumero.TabIndex = 115
        Me.lbNumero.Text = "Número:"
        '
        'tbNumero
        '
        Me.tbNumero.Location = New System.Drawing.Point(125, 150)
        Me.tbNumero.MaxLength = 32
        Me.tbNumero.Name = "tbNumero"
        Me.tbNumero.Size = New System.Drawing.Size(150, 20)
        Me.tbNumero.TabIndex = 4
        '
        'lbTipo
        '
        Me.lbTipo.AutoSize = True
        Me.lbTipo.Location = New System.Drawing.Point(12, 99)
        Me.lbTipo.Name = "lbTipo"
        Me.lbTipo.Size = New System.Drawing.Size(31, 13)
        Me.lbTipo.TabIndex = 114
        Me.lbTipo.Text = "Tipo:"
        '
        'lbCodigo
        '
        Me.lbCodigo.AutoSize = True
        Me.lbCodigo.Location = New System.Drawing.Point(12, 73)
        Me.lbCodigo.Name = "lbCodigo"
        Me.lbCodigo.Size = New System.Drawing.Size(43, 13)
        Me.lbCodigo.TabIndex = 113
        Me.lbCodigo.Text = "Código:"
        '
        'tbTipo
        '
        Me.tbTipo.Location = New System.Drawing.Point(99, 97)
        Me.tbTipo.MaxLength = 100
        Me.tbTipo.Name = "tbTipo"
        Me.tbTipo.Size = New System.Drawing.Size(20, 20)
        Me.tbTipo.TabIndex = 100
        Me.tbTipo.Visible = False
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
        'cbTipo
        '
        Me.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipo.FormattingEnabled = True
        Me.cbTipo.Location = New System.Drawing.Point(125, 96)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(550, 21)
        Me.cbTipo.TabIndex = 2
        '
        'cbBodega
        '
        Me.cbBodega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBodega.FormattingEnabled = True
        Me.cbBodega.Location = New System.Drawing.Point(125, 123)
        Me.cbBodega.Name = "cbBodega"
        Me.cbBodega.Size = New System.Drawing.Size(550, 21)
        Me.cbBodega.TabIndex = 3
        '
        'lbBodega
        '
        Me.lbBodega.AutoSize = True
        Me.lbBodega.Location = New System.Drawing.Point(12, 127)
        Me.lbBodega.Name = "lbBodega"
        Me.lbBodega.Size = New System.Drawing.Size(47, 13)
        Me.lbBodega.TabIndex = 120
        Me.lbBodega.Text = "Bodega:"
        '
        'tbBodega
        '
        Me.tbBodega.Location = New System.Drawing.Point(99, 124)
        Me.tbBodega.MaxLength = 100
        Me.tbBodega.Name = "tbBodega"
        Me.tbBodega.Size = New System.Drawing.Size(20, 20)
        Me.tbBodega.TabIndex = 100
        Me.tbBodega.Visible = False
        '
        'lbFecha
        '
        Me.lbFecha.AutoSize = True
        Me.lbFecha.Location = New System.Drawing.Point(412, 153)
        Me.lbFecha.Name = "lbFecha"
        Me.lbFecha.Size = New System.Drawing.Size(40, 13)
        Me.lbFecha.TabIndex = 122
        Me.lbFecha.Text = "Fecha:"
        '
        'tbFecha
        '
        Me.tbFecha.Location = New System.Drawing.Point(499, 150)
        Me.tbFecha.Name = "tbFecha"
        Me.tbFecha.Size = New System.Drawing.Size(20, 20)
        Me.tbFecha.TabIndex = 100
        Me.tbFecha.Visible = False
        '
        'dpFecha
        '
        Me.dpFecha.CustomFormat = "dd/MM/yyyy"
        Me.dpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpFecha.Location = New System.Drawing.Point(525, 150)
        Me.dpFecha.Name = "dpFecha"
        Me.dpFecha.Size = New System.Drawing.Size(150, 20)
        Me.dpFecha.TabIndex = 5
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
        'lbInventarios
        '
        Me.lbInventarios.AutoSize = True
        Me.lbInventarios.Location = New System.Drawing.Point(12, 205)
        Me.lbInventarios.Name = "lbInventarios"
        Me.lbInventarios.Size = New System.Drawing.Size(62, 13)
        Me.lbInventarios.TabIndex = 146
        Me.lbInventarios.Text = "Inventarios:"
        '
        'btEliminarInventario
        '
        Me.btEliminarInventario.Location = New System.Drawing.Point(256, 358)
        Me.btEliminarInventario.Name = "btEliminarInventario"
        Me.btEliminarInventario.Size = New System.Drawing.Size(125, 23)
        Me.btEliminarInventario.TabIndex = 9
        Me.btEliminarInventario.Text = "Eliminar Inventario"
        Me.btEliminarInventario.UseVisualStyleBackColor = True
        '
        'btAgregarInventario
        '
        Me.btAgregarInventario.Location = New System.Drawing.Point(125, 358)
        Me.btAgregarInventario.Name = "btAgregarInventario"
        Me.btAgregarInventario.Size = New System.Drawing.Size(125, 23)
        Me.btAgregarInventario.TabIndex = 8
        Me.btAgregarInventario.Text = "Agregar Inventario"
        Me.btAgregarInventario.UseVisualStyleBackColor = True
        '
        'dgMovimientoInventario
        '
        Me.dgMovimientoInventario.AllowDrop = True
        Me.dgMovimientoInventario.AllowUserToAddRows = False
        Me.dgMovimientoInventario.AllowUserToDeleteRows = False
        Me.dgMovimientoInventario.AllowUserToResizeColumns = False
        Me.dgMovimientoInventario.AllowUserToResizeRows = False
        Me.dgMovimientoInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgMovimientoInventario.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgMovimientoInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMovimientoInventario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.mvi_cantidad})
        Me.dgMovimientoInventario.GridColor = System.Drawing.SystemColors.Window
        Me.dgMovimientoInventario.Location = New System.Drawing.Point(125, 202)
        Me.dgMovimientoInventario.Name = "dgMovimientoInventario"
        Me.dgMovimientoInventario.RowHeadersVisible = False
        Me.dgMovimientoInventario.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgMovimientoInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMovimientoInventario.Size = New System.Drawing.Size(550, 150)
        Me.dgMovimientoInventario.TabIndex = 7
        Me.dgMovimientoInventario.Tag = "tbl_mrp_movimiento_inventario"
        '
        'mvi_cantidad
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N6"
        Me.mvi_cantidad.DefaultCellStyle = DataGridViewCellStyle1
        Me.mvi_cantidad.HeaderText = "Cantidad"
        Me.mvi_cantidad.Name = "mvi_cantidad"
        '
        'UcNavegador1
        '
        Me.UcNavegador1.AutoSize = True
        Me.UcNavegador1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcNavegador1.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.UcNavegador1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UcNavegador1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcNavegador1.Location = New System.Drawing.Point(0, 395)
        Me.UcNavegador1.MinimumSize = New System.Drawing.Size(0, 56)
        Me.UcNavegador1.Name = "UcNavegador1"
        Me.UcNavegador1.Size = New System.Drawing.Size(689, 60)
        Me.UcNavegador1.TabIndex = 100
        '
        'frMovimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 455)
        Me.Controls.Add(Me.lbInventarios)
        Me.Controls.Add(Me.btEliminarInventario)
        Me.Controls.Add(Me.btAgregarInventario)
        Me.Controls.Add(Me.dgMovimientoInventario)
        Me.Controls.Add(Me.tbEmpresa)
        Me.Controls.Add(Me.dpFecha)
        Me.Controls.Add(Me.tbFecha)
        Me.Controls.Add(Me.lbFecha)
        Me.Controls.Add(Me.cbBodega)
        Me.Controls.Add(Me.lbBodega)
        Me.Controls.Add(Me.tbBodega)
        Me.Controls.Add(Me.cbTipo)
        Me.Controls.Add(Me.lbDescripcion)
        Me.Controls.Add(Me.tbDescripcion)
        Me.Controls.Add(Me.tbEstado1)
        Me.Controls.Add(Me.lbEstado)
        Me.Controls.Add(Me.tbEstado)
        Me.Controls.Add(Me.lbNumero)
        Me.Controls.Add(Me.tbNumero)
        Me.Controls.Add(Me.lbTipo)
        Me.Controls.Add(Me.lbCodigo)
        Me.Controls.Add(Me.tbTipo)
        Me.Controls.Add(Me.tbCodigo)
        Me.Controls.Add(Me.pnlPanelTitulo)
        Me.Controls.Add(Me.UcNavegador1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frMovimiento"
        Me.Text = "Movimientos"
        Me.pnlPanelTitulo.ResumeLayout(False)
        Me.pnlPanelTitulo.PerformLayout()
        CType(Me.dgMovimientoInventario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UcNavegador1 As ucNavegador
    Friend WithEvents pnlPanelTitulo As Panel
    Friend WithEvents lbTitulo As Label
    Friend WithEvents lbDescripcion As Label
    Friend WithEvents tbDescripcion As TextBox
    Friend WithEvents tbEstado1 As TextBox
    Friend WithEvents lbEstado As Label
    Friend WithEvents tbEstado As TextBox
    Friend WithEvents lbNumero As Label
    Friend WithEvents tbNumero As TextBox
    Friend WithEvents lbTipo As Label
    Friend WithEvents lbCodigo As Label
    Friend WithEvents tbTipo As TextBox
    Friend WithEvents tbCodigo As TextBox
    Friend WithEvents cbTipo As ComboBox
    Friend WithEvents cbBodega As ComboBox
    Friend WithEvents lbBodega As Label
    Friend WithEvents tbBodega As TextBox
    Friend WithEvents lbFecha As Label
    Friend WithEvents tbFecha As TextBox
    Friend WithEvents dpFecha As DateTimePicker
    Friend WithEvents tbEmpresa As TextBox
    Friend WithEvents lbInventarios As Label
    Friend WithEvents btEliminarInventario As Button
    Friend WithEvents btAgregarInventario As Button
    Friend WithEvents dgMovimientoInventario As DataGridView
    Friend WithEvents mvi_cantidad As DataGridViewTextBoxColumn
End Class
