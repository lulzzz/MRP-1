<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frGasto
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
        Me.tbEmpresa = New System.Windows.Forms.TextBox()
        Me.lbGastoTipo = New System.Windows.Forms.Label()
        Me.cbGastoTipo = New System.Windows.Forms.ComboBox()
        Me.lbDescripcion = New System.Windows.Forms.Label()
        Me.tbDescripcion = New System.Windows.Forms.TextBox()
        Me.tbGastoTipo = New System.Windows.Forms.TextBox()
        Me.tbEstado1 = New System.Windows.Forms.TextBox()
        Me.lbEstado = New System.Windows.Forms.Label()
        Me.tbEstado = New System.Windows.Forms.TextBox()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.lbCodigo = New System.Windows.Forms.Label()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.tbCodigo = New System.Windows.Forms.TextBox()
        Me.lbFactor = New System.Windows.Forms.Label()
        Me.tbFactor = New System.Windows.Forms.TextBox()
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
        Me.UcNavegador1.TabIndex = 100
        '
        'tbEmpresa
        '
        Me.tbEmpresa.Location = New System.Drawing.Point(281, 70)
        Me.tbEmpresa.MaxLength = 100
        Me.tbEmpresa.Name = "tbEmpresa"
        Me.tbEmpresa.Size = New System.Drawing.Size(20, 20)
        Me.tbEmpresa.TabIndex = 113
        Me.tbEmpresa.Visible = False
        '
        'lbGastoTipo
        '
        Me.lbGastoTipo.AutoSize = True
        Me.lbGastoTipo.Location = New System.Drawing.Point(12, 99)
        Me.lbGastoTipo.Name = "lbGastoTipo"
        Me.lbGastoTipo.Size = New System.Drawing.Size(77, 13)
        Me.lbGastoTipo.TabIndex = 112
        Me.lbGastoTipo.Text = "Tipo de Gasto:"
        '
        'cbGastoTipo
        '
        Me.cbGastoTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGastoTipo.FormattingEnabled = True
        Me.cbGastoTipo.Location = New System.Drawing.Point(125, 96)
        Me.cbGastoTipo.Name = "cbGastoTipo"
        Me.cbGastoTipo.Size = New System.Drawing.Size(550, 21)
        Me.cbGastoTipo.TabIndex = 103
        '
        'lbDescripcion
        '
        Me.lbDescripcion.AutoSize = True
        Me.lbDescripcion.Location = New System.Drawing.Point(12, 152)
        Me.lbDescripcion.Name = "lbDescripcion"
        Me.lbDescripcion.Size = New System.Drawing.Size(66, 13)
        Me.lbDescripcion.TabIndex = 111
        Me.lbDescripcion.Text = "Descripción:"
        '
        'tbDescripcion
        '
        Me.tbDescripcion.Location = New System.Drawing.Point(125, 149)
        Me.tbDescripcion.MaxLength = 256
        Me.tbDescripcion.Name = "tbDescripcion"
        Me.tbDescripcion.Size = New System.Drawing.Size(550, 20)
        Me.tbDescripcion.TabIndex = 105
        '
        'tbGastoTipo
        '
        Me.tbGastoTipo.Location = New System.Drawing.Point(99, 96)
        Me.tbGastoTipo.MaxLength = 100
        Me.tbGastoTipo.Name = "tbGastoTipo"
        Me.tbGastoTipo.Size = New System.Drawing.Size(20, 20)
        Me.tbGastoTipo.TabIndex = 110
        Me.tbGastoTipo.Visible = False
        '
        'tbEstado1
        '
        Me.tbEstado1.Location = New System.Drawing.Point(525, 70)
        Me.tbEstado1.Name = "tbEstado1"
        Me.tbEstado1.ReadOnly = True
        Me.tbEstado1.Size = New System.Drawing.Size(150, 20)
        Me.tbEstado1.TabIndex = 102
        '
        'lbEstado
        '
        Me.lbEstado.AutoSize = True
        Me.lbEstado.Location = New System.Drawing.Point(412, 73)
        Me.lbEstado.Name = "lbEstado"
        Me.lbEstado.Size = New System.Drawing.Size(43, 13)
        Me.lbEstado.TabIndex = 109
        Me.lbEstado.Text = "Estado:"
        '
        'tbEstado
        '
        Me.tbEstado.Location = New System.Drawing.Point(499, 70)
        Me.tbEstado.Name = "tbEstado"
        Me.tbEstado.Size = New System.Drawing.Size(20, 20)
        Me.tbEstado.TabIndex = 106
        Me.tbEstado.Visible = False
        '
        'lbNombre
        '
        Me.lbNombre.AutoSize = True
        Me.lbNombre.Location = New System.Drawing.Point(12, 126)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(47, 13)
        Me.lbNombre.TabIndex = 108
        Me.lbNombre.Text = "Nombre:"
        '
        'lbCodigo
        '
        Me.lbCodigo.AutoSize = True
        Me.lbCodigo.Location = New System.Drawing.Point(12, 73)
        Me.lbCodigo.Name = "lbCodigo"
        Me.lbCodigo.Size = New System.Drawing.Size(43, 13)
        Me.lbCodigo.TabIndex = 107
        Me.lbCodigo.Text = "Código:"
        '
        'tbNombre
        '
        Me.tbNombre.Location = New System.Drawing.Point(125, 123)
        Me.tbNombre.MaxLength = 100
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(550, 20)
        Me.tbNombre.TabIndex = 104
        '
        'tbCodigo
        '
        Me.tbCodigo.Location = New System.Drawing.Point(125, 70)
        Me.tbCodigo.Name = "tbCodigo"
        Me.tbCodigo.ReadOnly = True
        Me.tbCodigo.Size = New System.Drawing.Size(150, 20)
        Me.tbCodigo.TabIndex = 101
        '
        'lbFactor
        '
        Me.lbFactor.AutoSize = True
        Me.lbFactor.Location = New System.Drawing.Point(12, 178)
        Me.lbFactor.Name = "lbFactor"
        Me.lbFactor.Size = New System.Drawing.Size(40, 13)
        Me.lbFactor.TabIndex = 115
        Me.lbFactor.Text = "Factor:"
        '
        'tbFactor
        '
        Me.tbFactor.Location = New System.Drawing.Point(125, 175)
        Me.tbFactor.MaxLength = 256
        Me.tbFactor.Name = "tbFactor"
        Me.tbFactor.Size = New System.Drawing.Size(550, 20)
        Me.tbFactor.TabIndex = 114
        '
        'frGasto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(689, 211)
        Me.Controls.Add(Me.lbFactor)
        Me.Controls.Add(Me.tbFactor)
        Me.Controls.Add(Me.tbEmpresa)
        Me.Controls.Add(Me.lbGastoTipo)
        Me.Controls.Add(Me.cbGastoTipo)
        Me.Controls.Add(Me.lbDescripcion)
        Me.Controls.Add(Me.tbDescripcion)
        Me.Controls.Add(Me.tbGastoTipo)
        Me.Controls.Add(Me.tbEstado1)
        Me.Controls.Add(Me.lbEstado)
        Me.Controls.Add(Me.tbEstado)
        Me.Controls.Add(Me.lbNombre)
        Me.Controls.Add(Me.lbCodigo)
        Me.Controls.Add(Me.tbNombre)
        Me.Controls.Add(Me.tbCodigo)
        Me.Controls.Add(Me.UcNavegador1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimizeBox = False
        Me.Name = "frGasto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Gastos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UcNavegador1 As ucNavegador
    Friend WithEvents tbEmpresa As TextBox
    Friend WithEvents lbGastoTipo As Label
    Friend WithEvents cbGastoTipo As ComboBox
    Friend WithEvents lbDescripcion As Label
    Friend WithEvents tbDescripcion As TextBox
    Friend WithEvents tbGastoTipo As TextBox
    Friend WithEvents tbEstado1 As TextBox
    Friend WithEvents lbEstado As Label
    Friend WithEvents tbEstado As TextBox
    Friend WithEvents lbNombre As Label
    Friend WithEvents lbCodigo As Label
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents tbCodigo As TextBox
    Friend WithEvents lbFactor As Label
    Friend WithEvents tbFactor As TextBox
End Class
