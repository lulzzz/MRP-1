﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frSolicitud
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.UcNavegador1 = New MRP.ucNavegador()
        Me.pnlPanelTitulo = New System.Windows.Forms.Panel()
        Me.lbTitulo = New System.Windows.Forms.Label()
        Me.tbFechaSolicitud = New System.Windows.Forms.TextBox()
        Me.dpFechaSolicitud = New System.Windows.Forms.DateTimePicker()
        Me.lbFechaSolicitud = New System.Windows.Forms.Label()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.lbStatus = New System.Windows.Forms.Label()
        Me.lbCodigo = New System.Windows.Forms.Label()
        Me.tbStatus = New System.Windows.Forms.TextBox()
        Me.tbCodigo = New System.Windows.Forms.TextBox()
        Me.lbEstado = New System.Windows.Forms.Label()
        Me.tbEstado1 = New System.Windows.Forms.TextBox()
        Me.tbEstado = New System.Windows.Forms.TextBox()
        Me.lbDescripcion = New System.Windows.Forms.Label()
        Me.tbDescripcion = New System.Windows.Forms.TextBox()
        Me.tbFechaEntrega = New System.Windows.Forms.TextBox()
        Me.dpFechaEntrega = New System.Windows.Forms.DateTimePicker()
        Me.lbFechaEntrega = New System.Windows.Forms.Label()
        Me.tbEmpresa = New System.Windows.Forms.TextBox()
        Me.lbInventarios = New System.Windows.Forms.Label()
        Me.btEliminarInventario = New System.Windows.Forms.Button()
        Me.btAgregarInventario = New System.Windows.Forms.Button()
        Me.dgSolicitudInventario = New System.Windows.Forms.DataGridView()
        Me.siv_cantidad_solicitada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.siv_cantidad_entregada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlPanelTitulo.SuspendLayout()
        CType(Me.dgSolicitudInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.lbTitulo.Size = New System.Drawing.Size(157, 31)
        Me.lbTitulo.TabIndex = 41
        Me.lbTitulo.Text = "Solicitudes"
        '
        'tbFechaSolicitud
        '
        Me.tbFechaSolicitud.Location = New System.Drawing.Point(99, 148)
        Me.tbFechaSolicitud.Name = "tbFechaSolicitud"
        Me.tbFechaSolicitud.Size = New System.Drawing.Size(20, 20)
        Me.tbFechaSolicitud.TabIndex = 100
        Me.tbFechaSolicitud.Visible = False
        '
        'dpFechaSolicitud
        '
        Me.dpFechaSolicitud.CustomFormat = "dd/MM/yyyy"
        Me.dpFechaSolicitud.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpFechaSolicitud.Location = New System.Drawing.Point(125, 148)
        Me.dpFechaSolicitud.Name = "dpFechaSolicitud"
        Me.dpFechaSolicitud.Size = New System.Drawing.Size(150, 20)
        Me.dpFechaSolicitud.TabIndex = 4
        '
        'lbFechaSolicitud
        '
        Me.lbFechaSolicitud.AutoSize = True
        Me.lbFechaSolicitud.Location = New System.Drawing.Point(12, 154)
        Me.lbFechaSolicitud.Name = "lbFechaSolicitud"
        Me.lbFechaSolicitud.Size = New System.Drawing.Size(83, 13)
        Me.lbFechaSolicitud.TabIndex = 140
        Me.lbFechaSolicitud.Text = "Fecha Solicitud:"
        '
        'cbStatus
        '
        Me.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Location = New System.Drawing.Point(125, 174)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(150, 21)
        Me.cbStatus.TabIndex = 6
        '
        'lbNombre
        '
        Me.lbNombre.AutoSize = True
        Me.lbNombre.Location = New System.Drawing.Point(12, 99)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(47, 13)
        Me.lbNombre.TabIndex = 135
        Me.lbNombre.Text = "Nombre:"
        '
        'tbNombre
        '
        Me.tbNombre.Location = New System.Drawing.Point(125, 96)
        Me.tbNombre.MaxLength = 100
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(550, 20)
        Me.tbNombre.TabIndex = 2
        '
        'lbStatus
        '
        Me.lbStatus.AutoSize = True
        Me.lbStatus.Location = New System.Drawing.Point(12, 178)
        Me.lbStatus.Name = "lbStatus"
        Me.lbStatus.Size = New System.Drawing.Size(40, 13)
        Me.lbStatus.TabIndex = 132
        Me.lbStatus.Text = "Status:"
        '
        'lbCodigo
        '
        Me.lbCodigo.AutoSize = True
        Me.lbCodigo.Location = New System.Drawing.Point(12, 73)
        Me.lbCodigo.Name = "lbCodigo"
        Me.lbCodigo.Size = New System.Drawing.Size(43, 13)
        Me.lbCodigo.TabIndex = 131
        Me.lbCodigo.Text = "Código:"
        '
        'tbStatus
        '
        Me.tbStatus.Location = New System.Drawing.Point(99, 175)
        Me.tbStatus.MaxLength = 100
        Me.tbStatus.Name = "tbStatus"
        Me.tbStatus.Size = New System.Drawing.Size(20, 20)
        Me.tbStatus.TabIndex = 100
        Me.tbStatus.Visible = False
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
        'lbEstado
        '
        Me.lbEstado.AutoSize = True
        Me.lbEstado.Location = New System.Drawing.Point(412, 73)
        Me.lbEstado.Name = "lbEstado"
        Me.lbEstado.Size = New System.Drawing.Size(43, 13)
        Me.lbEstado.TabIndex = 134
        Me.lbEstado.Text = "Estado:"
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
        Me.lbDescripcion.Location = New System.Drawing.Point(12, 125)
        Me.lbDescripcion.Name = "lbDescripcion"
        Me.lbDescripcion.Size = New System.Drawing.Size(66, 13)
        Me.lbDescripcion.TabIndex = 144
        Me.lbDescripcion.Text = "Descripción:"
        '
        'tbDescripcion
        '
        Me.tbDescripcion.Location = New System.Drawing.Point(125, 122)
        Me.tbDescripcion.MaxLength = 100
        Me.tbDescripcion.Name = "tbDescripcion"
        Me.tbDescripcion.Size = New System.Drawing.Size(550, 20)
        Me.tbDescripcion.TabIndex = 3
        '
        'tbFechaEntrega
        '
        Me.tbFechaEntrega.Location = New System.Drawing.Point(499, 148)
        Me.tbFechaEntrega.Name = "tbFechaEntrega"
        Me.tbFechaEntrega.Size = New System.Drawing.Size(20, 20)
        Me.tbFechaEntrega.TabIndex = 100
        Me.tbFechaEntrega.Visible = False
        '
        'dpFechaEntrega
        '
        Me.dpFechaEntrega.CustomFormat = "dd/MM/yyyy"
        Me.dpFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpFechaEntrega.Location = New System.Drawing.Point(525, 148)
        Me.dpFechaEntrega.Name = "dpFechaEntrega"
        Me.dpFechaEntrega.Size = New System.Drawing.Size(150, 20)
        Me.dpFechaEntrega.TabIndex = 5
        '
        'lbFechaEntrega
        '
        Me.lbFechaEntrega.AutoSize = True
        Me.lbFechaEntrega.Location = New System.Drawing.Point(412, 151)
        Me.lbFechaEntrega.Name = "lbFechaEntrega"
        Me.lbFechaEntrega.Size = New System.Drawing.Size(80, 13)
        Me.lbFechaEntrega.TabIndex = 145
        Me.lbFechaEntrega.Text = "Fecha Entrega:"
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
        Me.lbInventarios.Location = New System.Drawing.Point(12, 204)
        Me.lbInventarios.Name = "lbInventarios"
        Me.lbInventarios.Size = New System.Drawing.Size(62, 13)
        Me.lbInventarios.TabIndex = 150
        Me.lbInventarios.Text = "Inventarios:"
        '
        'btEliminarInventario
        '
        Me.btEliminarInventario.Location = New System.Drawing.Point(256, 357)
        Me.btEliminarInventario.Name = "btEliminarInventario"
        Me.btEliminarInventario.Size = New System.Drawing.Size(125, 23)
        Me.btEliminarInventario.TabIndex = 9
        Me.btEliminarInventario.Text = "Eliminar Inventario"
        Me.btEliminarInventario.UseVisualStyleBackColor = True
        '
        'btAgregarInventario
        '
        Me.btAgregarInventario.Location = New System.Drawing.Point(125, 357)
        Me.btAgregarInventario.Name = "btAgregarInventario"
        Me.btAgregarInventario.Size = New System.Drawing.Size(125, 23)
        Me.btAgregarInventario.TabIndex = 8
        Me.btAgregarInventario.Text = "Agregar Inventario"
        Me.btAgregarInventario.UseVisualStyleBackColor = True
        '
        'dgSolicitudInventario
        '
        Me.dgSolicitudInventario.AllowDrop = True
        Me.dgSolicitudInventario.AllowUserToAddRows = False
        Me.dgSolicitudInventario.AllowUserToDeleteRows = False
        Me.dgSolicitudInventario.AllowUserToResizeColumns = False
        Me.dgSolicitudInventario.AllowUserToResizeRows = False
        Me.dgSolicitudInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgSolicitudInventario.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgSolicitudInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSolicitudInventario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.siv_cantidad_solicitada, Me.siv_cantidad_entregada})
        Me.dgSolicitudInventario.GridColor = System.Drawing.SystemColors.Window
        Me.dgSolicitudInventario.Location = New System.Drawing.Point(125, 201)
        Me.dgSolicitudInventario.Name = "dgSolicitudInventario"
        Me.dgSolicitudInventario.RowHeadersVisible = False
        Me.dgSolicitudInventario.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgSolicitudInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgSolicitudInventario.Size = New System.Drawing.Size(550, 150)
        Me.dgSolicitudInventario.TabIndex = 7
        Me.dgSolicitudInventario.Tag = "tbl_mrp_solicitud_inventario"
        '
        'siv_cantidad_solicitada
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N6"
        Me.siv_cantidad_solicitada.DefaultCellStyle = DataGridViewCellStyle1
        Me.siv_cantidad_solicitada.HeaderText = "Cantidad Solicitada"
        Me.siv_cantidad_solicitada.Name = "siv_cantidad_solicitada"
        '
        'siv_cantidad_entregada
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N6"
        Me.siv_cantidad_entregada.DefaultCellStyle = DataGridViewCellStyle2
        Me.siv_cantidad_entregada.HeaderText = "Cantidad Entregada"
        Me.siv_cantidad_entregada.Name = "siv_cantidad_entregada"
        '
        'frSolicitud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 455)
        Me.Controls.Add(Me.lbInventarios)
        Me.Controls.Add(Me.btEliminarInventario)
        Me.Controls.Add(Me.btAgregarInventario)
        Me.Controls.Add(Me.dgSolicitudInventario)
        Me.Controls.Add(Me.tbEmpresa)
        Me.Controls.Add(Me.tbFechaEntrega)
        Me.Controls.Add(Me.dpFechaEntrega)
        Me.Controls.Add(Me.lbFechaEntrega)
        Me.Controls.Add(Me.lbDescripcion)
        Me.Controls.Add(Me.tbDescripcion)
        Me.Controls.Add(Me.tbFechaSolicitud)
        Me.Controls.Add(Me.dpFechaSolicitud)
        Me.Controls.Add(Me.lbFechaSolicitud)
        Me.Controls.Add(Me.cbStatus)
        Me.Controls.Add(Me.lbNombre)
        Me.Controls.Add(Me.tbNombre)
        Me.Controls.Add(Me.tbEstado1)
        Me.Controls.Add(Me.lbEstado)
        Me.Controls.Add(Me.tbEstado)
        Me.Controls.Add(Me.lbStatus)
        Me.Controls.Add(Me.lbCodigo)
        Me.Controls.Add(Me.tbStatus)
        Me.Controls.Add(Me.tbCodigo)
        Me.Controls.Add(Me.pnlPanelTitulo)
        Me.Controls.Add(Me.UcNavegador1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frSolicitud"
        Me.Text = "Solicitudes"
        Me.pnlPanelTitulo.ResumeLayout(False)
        Me.pnlPanelTitulo.PerformLayout()
        CType(Me.dgSolicitudInventario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UcNavegador1 As ucNavegador
    Friend WithEvents pnlPanelTitulo As Panel
    Friend WithEvents lbTitulo As Label
    Friend WithEvents tbFechaSolicitud As TextBox
    Friend WithEvents dpFechaSolicitud As DateTimePicker
    Friend WithEvents lbFechaSolicitud As Label
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents lbNombre As Label
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents lbStatus As Label
    Friend WithEvents lbCodigo As Label
    Friend WithEvents tbStatus As TextBox
    Friend WithEvents tbCodigo As TextBox
    Friend WithEvents lbEstado As Label
    Friend WithEvents tbEstado1 As TextBox
    Friend WithEvents tbEstado As TextBox
    Friend WithEvents lbDescripcion As Label
    Friend WithEvents tbDescripcion As TextBox
    Friend WithEvents tbFechaEntrega As TextBox
    Friend WithEvents dpFechaEntrega As DateTimePicker
    Friend WithEvents lbFechaEntrega As Label
    Friend WithEvents tbEmpresa As TextBox
    Friend WithEvents lbInventarios As Label
    Friend WithEvents btEliminarInventario As Button
    Friend WithEvents btAgregarInventario As Button
    Friend WithEvents dgSolicitudInventario As DataGridView
    Friend WithEvents siv_cantidad_solicitada As DataGridViewTextBoxColumn
    Friend WithEvents siv_cantidad_entregada As DataGridViewTextBoxColumn
End Class
