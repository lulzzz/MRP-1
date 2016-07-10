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
        Me.UcNavegador1 = New MRP.ucNavegador()
        Me.pnlPanelTitulo.SuspendLayout()
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
        'UcNavegador1
        '
        Me.UcNavegador1.AutoSize = True
        Me.UcNavegador1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcNavegador1.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.UcNavegador1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UcNavegador1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcNavegador1.Location = New System.Drawing.Point(0, 187)
        Me.UcNavegador1.MinimumSize = New System.Drawing.Size(0, 56)
        Me.UcNavegador1.Name = "UcNavegador1"
        Me.UcNavegador1.Size = New System.Drawing.Size(689, 58)
        Me.UcNavegador1.TabIndex = 103
        '
        'frRecetario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(689, 245)
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
End Class
