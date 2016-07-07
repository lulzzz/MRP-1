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
        Me.UcNavegador1 = New MRP.ucNavegador()
        Me.tbEstado1 = New System.Windows.Forms.TextBox()
        Me.lbIdInvClasificacion = New System.Windows.Forms.Label()
        Me.tbEstado = New System.Windows.Forms.TextBox()
        Me.lbDescripcion = New System.Windows.Forms.Label()
        Me.lbCodigo = New System.Windows.Forms.Label()
        Me.tbDescripcion = New System.Windows.Forms.TextBox()
        Me.tbCodigo = New System.Windows.Forms.TextBox()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.lbFecha = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lbMedida = New System.Windows.Forms.Label()
        Me.tbMedida = New System.Windows.Forms.TextBox()
        Me.lbEstado = New System.Windows.Forms.Label()
        Me.tbStatus1 = New System.Windows.Forms.TextBox()
        Me.tbStatus = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'UcNavegador1
        '
        Me.UcNavegador1.AutoSize = True
        Me.UcNavegador1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.UcNavegador1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UcNavegador1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcNavegador1.Location = New System.Drawing.Point(0, 0)
        Me.UcNavegador1.Name = "UcNavegador1"
        Me.UcNavegador1.Size = New System.Drawing.Size(689, 41)
        Me.UcNavegador1.TabIndex = 9
        '
        'tbEstado1
        '
        Me.tbEstado1.Location = New System.Drawing.Point(525, 70)
        Me.tbEstado1.Name = "tbEstado1"
        Me.tbEstado1.ReadOnly = True
        Me.tbEstado1.Size = New System.Drawing.Size(150, 20)
        Me.tbEstado1.TabIndex = 34
        '
        'lbIdInvClasificacion
        '
        Me.lbIdInvClasificacion.AutoSize = True
        Me.lbIdInvClasificacion.Location = New System.Drawing.Point(412, 73)
        Me.lbIdInvClasificacion.Name = "lbIdInvClasificacion"
        Me.lbIdInvClasificacion.Size = New System.Drawing.Size(57, 13)
        Me.lbIdInvClasificacion.TabIndex = 39
        Me.lbIdInvClasificacion.Text = "Inventario:"
        '
        'tbEstado
        '
        Me.tbEstado.Location = New System.Drawing.Point(499, 70)
        Me.tbEstado.Name = "tbEstado"
        Me.tbEstado.Size = New System.Drawing.Size(20, 20)
        Me.tbEstado.TabIndex = 36
        Me.tbEstado.Visible = False
        '
        'lbDescripcion
        '
        Me.lbDescripcion.AutoSize = True
        Me.lbDescripcion.Location = New System.Drawing.Point(12, 125)
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
        Me.tbDescripcion.Location = New System.Drawing.Point(125, 122)
        Me.tbDescripcion.MaxLength = 100
        Me.tbDescripcion.Name = "tbDescripcion"
        Me.tbDescripcion.Size = New System.Drawing.Size(550, 20)
        Me.tbDescripcion.TabIndex = 35
        '
        'tbCodigo
        '
        Me.tbCodigo.Location = New System.Drawing.Point(125, 70)
        Me.tbCodigo.Name = "tbCodigo"
        Me.tbCodigo.ReadOnly = True
        Me.tbCodigo.Size = New System.Drawing.Size(150, 20)
        Me.tbCodigo.TabIndex = 33
        '
        'lbNombre
        '
        Me.lbNombre.AutoSize = True
        Me.lbNombre.Location = New System.Drawing.Point(12, 99)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(47, 13)
        Me.lbNombre.TabIndex = 41
        Me.lbNombre.Text = "Nombre:"
        '
        'tbNombre
        '
        Me.tbNombre.Location = New System.Drawing.Point(125, 96)
        Me.tbNombre.MaxLength = 100
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(550, 20)
        Me.tbNombre.TabIndex = 40
        '
        'lbFecha
        '
        Me.lbFecha.AutoSize = True
        Me.lbFecha.Location = New System.Drawing.Point(12, 155)
        Me.lbFecha.Name = "lbFecha"
        Me.lbFecha.Size = New System.Drawing.Size(40, 13)
        Me.lbFecha.TabIndex = 42
        Me.lbFecha.Text = "Fecha:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(125, 149)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 43
        '
        'lbMedida
        '
        Me.lbMedida.AutoSize = True
        Me.lbMedida.Location = New System.Drawing.Point(412, 156)
        Me.lbMedida.Name = "lbMedida"
        Me.lbMedida.Size = New System.Drawing.Size(45, 13)
        Me.lbMedida.TabIndex = 44
        Me.lbMedida.Text = "Medida:"
        '
        'tbMedida
        '
        Me.tbMedida.Location = New System.Drawing.Point(499, 152)
        Me.tbMedida.Name = "tbMedida"
        Me.tbMedida.Size = New System.Drawing.Size(20, 20)
        Me.tbMedida.TabIndex = 45
        Me.tbMedida.Visible = False
        '
        'lbEstado
        '
        Me.lbEstado.AutoSize = True
        Me.lbEstado.Location = New System.Drawing.Point(12, 178)
        Me.lbEstado.Name = "lbEstado"
        Me.lbEstado.Size = New System.Drawing.Size(43, 13)
        Me.lbEstado.TabIndex = 46
        Me.lbEstado.Text = "Estado:"
        '
        'tbStatus1
        '
        Me.tbStatus1.Location = New System.Drawing.Point(150, 175)
        Me.tbStatus1.Name = "tbStatus1"
        Me.tbStatus1.ReadOnly = True
        Me.tbStatus1.Size = New System.Drawing.Size(150, 20)
        Me.tbStatus1.TabIndex = 47
        '
        'tbStatus
        '
        Me.tbStatus.Location = New System.Drawing.Point(124, 175)
        Me.tbStatus.Name = "tbStatus"
        Me.tbStatus.Size = New System.Drawing.Size(20, 20)
        Me.tbStatus.TabIndex = 48
        Me.tbStatus.Visible = False
        '
        'frInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(689, 203)
        Me.Controls.Add(Me.tbStatus1)
        Me.Controls.Add(Me.tbStatus)
        Me.Controls.Add(Me.lbEstado)
        Me.Controls.Add(Me.tbMedida)
        Me.Controls.Add(Me.lbMedida)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lbFecha)
        Me.Controls.Add(Me.lbNombre)
        Me.Controls.Add(Me.tbNombre)
        Me.Controls.Add(Me.tbEstado1)
        Me.Controls.Add(Me.lbIdInvClasificacion)
        Me.Controls.Add(Me.tbEstado)
        Me.Controls.Add(Me.lbDescripcion)
        Me.Controls.Add(Me.lbCodigo)
        Me.Controls.Add(Me.tbDescripcion)
        Me.Controls.Add(Me.tbCodigo)
        Me.Controls.Add(Me.UcNavegador1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frInventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Inventario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents UcNavegador1 As ucNavegador
    Friend WithEvents tbEstado1 As TextBox
    Friend WithEvents lbIdInvClasificacion As Label
    Friend WithEvents tbEstado As TextBox
    Friend WithEvents lbDescripcion As Label
    Friend WithEvents lbCodigo As Label
    Friend WithEvents tbDescripcion As TextBox
    Friend WithEvents tbCodigo As TextBox
    Friend WithEvents lbNombre As Label
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents lbFecha As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents lbMedida As Label
    Friend WithEvents tbMedida As TextBox
    Friend WithEvents lbEstado As Label
    Friend WithEvents tbStatus1 As TextBox
    Friend WithEvents tbStatus As TextBox
End Class
