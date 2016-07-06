<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frEmpresa
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
        Me.lbEstado = New System.Windows.Forms.Label()
        Me.tbEstado = New System.Windows.Forms.TextBox()
        Me.lbRazonSocial = New System.Windows.Forms.Label()
        Me.tbRazonSocial = New System.Windows.Forms.TextBox()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.lbCodigo = New System.Windows.Forms.Label()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.tbCodigo = New System.Windows.Forms.TextBox()
        Me.lbDescripcion = New System.Windows.Forms.Label()
        Me.tbDescripcion = New System.Windows.Forms.TextBox()
        Me.cbPais = New System.Windows.Forms.ComboBox()
        Me.cbMoneda = New System.Windows.Forms.ComboBox()
        Me.lbPais = New System.Windows.Forms.Label()
        Me.lbMoneda = New System.Windows.Forms.Label()
        Me.lbDireccion = New System.Windows.Forms.Label()
        Me.tbDireccion = New System.Windows.Forms.TextBox()
        Me.lbTelefono = New System.Windows.Forms.Label()
        Me.tbTelefono = New System.Windows.Forms.TextBox()
        Me.lbIdentificacionTributaria = New System.Windows.Forms.Label()
        Me.tbIdentificacionTributaria = New System.Windows.Forms.TextBox()
        Me.tbPais = New System.Windows.Forms.TextBox()
        Me.tbMoneda = New System.Windows.Forms.TextBox()
        Me.UcNavegador1 = New MRP.ucNavegador()
        Me.SuspendLayout()
        '
        'tbEstado1
        '
        Me.tbEstado1.Location = New System.Drawing.Point(525, 70)
        Me.tbEstado1.Name = "tbEstado1"
        Me.tbEstado1.ReadOnly = True
        Me.tbEstado1.Size = New System.Drawing.Size(150, 20)
        Me.tbEstado1.TabIndex = 1
        '
        'lbEstado
        '
        Me.lbEstado.AutoSize = True
        Me.lbEstado.Location = New System.Drawing.Point(412, 73)
        Me.lbEstado.Name = "lbEstado"
        Me.lbEstado.Size = New System.Drawing.Size(43, 13)
        Me.lbEstado.TabIndex = 25
        Me.lbEstado.Text = "Estado:"
        '
        'tbEstado
        '
        Me.tbEstado.Location = New System.Drawing.Point(499, 70)
        Me.tbEstado.Name = "tbEstado"
        Me.tbEstado.Size = New System.Drawing.Size(20, 20)
        Me.tbEstado.TabIndex = 21
        Me.tbEstado.Visible = False
        '
        'lbRazonSocial
        '
        Me.lbRazonSocial.AutoSize = True
        Me.lbRazonSocial.Location = New System.Drawing.Point(12, 125)
        Me.lbRazonSocial.Name = "lbRazonSocial"
        Me.lbRazonSocial.Size = New System.Drawing.Size(73, 13)
        Me.lbRazonSocial.TabIndex = 24
        Me.lbRazonSocial.Text = "Razón Social:"
        '
        'tbRazonSocial
        '
        Me.tbRazonSocial.Location = New System.Drawing.Point(125, 122)
        Me.tbRazonSocial.MaxLength = 256
        Me.tbRazonSocial.Name = "tbRazonSocial"
        Me.tbRazonSocial.Size = New System.Drawing.Size(550, 20)
        Me.tbRazonSocial.TabIndex = 3
        '
        'lbNombre
        '
        Me.lbNombre.AutoSize = True
        Me.lbNombre.Location = New System.Drawing.Point(12, 99)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(47, 13)
        Me.lbNombre.TabIndex = 23
        Me.lbNombre.Text = "Nombre:"
        '
        'lbCodigo
        '
        Me.lbCodigo.AutoSize = True
        Me.lbCodigo.Location = New System.Drawing.Point(12, 73)
        Me.lbCodigo.Name = "lbCodigo"
        Me.lbCodigo.Size = New System.Drawing.Size(43, 13)
        Me.lbCodigo.TabIndex = 22
        Me.lbCodigo.Text = "Código:"
        '
        'tbNombre
        '
        Me.tbNombre.Location = New System.Drawing.Point(125, 96)
        Me.tbNombre.MaxLength = 256
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(550, 20)
        Me.tbNombre.TabIndex = 2
        '
        'tbCodigo
        '
        Me.tbCodigo.Location = New System.Drawing.Point(125, 70)
        Me.tbCodigo.Name = "tbCodigo"
        Me.tbCodigo.ReadOnly = True
        Me.tbCodigo.Size = New System.Drawing.Size(150, 20)
        Me.tbCodigo.TabIndex = 0
        '
        'lbDescripcion
        '
        Me.lbDescripcion.AutoSize = True
        Me.lbDescripcion.Location = New System.Drawing.Point(12, 151)
        Me.lbDescripcion.Name = "lbDescripcion"
        Me.lbDescripcion.Size = New System.Drawing.Size(66, 13)
        Me.lbDescripcion.TabIndex = 27
        Me.lbDescripcion.Text = "Descripción:"
        '
        'tbDescripcion
        '
        Me.tbDescripcion.Location = New System.Drawing.Point(125, 148)
        Me.tbDescripcion.MaxLength = 256
        Me.tbDescripcion.Name = "tbDescripcion"
        Me.tbDescripcion.Size = New System.Drawing.Size(550, 20)
        Me.tbDescripcion.TabIndex = 4
        '
        'cbPais
        '
        Me.cbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPais.FormattingEnabled = True
        Me.cbPais.Location = New System.Drawing.Point(125, 174)
        Me.cbPais.Name = "cbPais"
        Me.cbPais.Size = New System.Drawing.Size(550, 21)
        Me.cbPais.TabIndex = 5
        '
        'cbMoneda
        '
        Me.cbMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMoneda.FormattingEnabled = True
        Me.cbMoneda.Location = New System.Drawing.Point(125, 201)
        Me.cbMoneda.Name = "cbMoneda"
        Me.cbMoneda.Size = New System.Drawing.Size(550, 21)
        Me.cbMoneda.TabIndex = 6
        '
        'lbPais
        '
        Me.lbPais.AutoSize = True
        Me.lbPais.Location = New System.Drawing.Point(12, 177)
        Me.lbPais.Name = "lbPais"
        Me.lbPais.Size = New System.Drawing.Size(32, 13)
        Me.lbPais.TabIndex = 30
        Me.lbPais.Text = "País:"
        '
        'lbMoneda
        '
        Me.lbMoneda.AutoSize = True
        Me.lbMoneda.Location = New System.Drawing.Point(12, 204)
        Me.lbMoneda.Name = "lbMoneda"
        Me.lbMoneda.Size = New System.Drawing.Size(49, 13)
        Me.lbMoneda.TabIndex = 31
        Me.lbMoneda.Text = "Moneda:"
        '
        'lbDireccion
        '
        Me.lbDireccion.AutoSize = True
        Me.lbDireccion.Location = New System.Drawing.Point(12, 231)
        Me.lbDireccion.Name = "lbDireccion"
        Me.lbDireccion.Size = New System.Drawing.Size(55, 13)
        Me.lbDireccion.TabIndex = 33
        Me.lbDireccion.Text = "Dirección:"
        '
        'tbDireccion
        '
        Me.tbDireccion.Location = New System.Drawing.Point(125, 228)
        Me.tbDireccion.MaxLength = 256
        Me.tbDireccion.Name = "tbDireccion"
        Me.tbDireccion.Size = New System.Drawing.Size(550, 20)
        Me.tbDireccion.TabIndex = 7
        '
        'lbTelefono
        '
        Me.lbTelefono.AutoSize = True
        Me.lbTelefono.Location = New System.Drawing.Point(12, 257)
        Me.lbTelefono.Name = "lbTelefono"
        Me.lbTelefono.Size = New System.Drawing.Size(52, 13)
        Me.lbTelefono.TabIndex = 35
        Me.lbTelefono.Text = "Teléfono:"
        '
        'tbTelefono
        '
        Me.tbTelefono.Location = New System.Drawing.Point(125, 254)
        Me.tbTelefono.MaxLength = 256
        Me.tbTelefono.Name = "tbTelefono"
        Me.tbTelefono.Size = New System.Drawing.Size(150, 20)
        Me.tbTelefono.TabIndex = 8
        '
        'lbIdentificacionTributaria
        '
        Me.lbIdentificacionTributaria.AutoSize = True
        Me.lbIdentificacionTributaria.Location = New System.Drawing.Point(399, 257)
        Me.lbIdentificacionTributaria.Name = "lbIdentificacionTributaria"
        Me.lbIdentificacionTributaria.Size = New System.Drawing.Size(120, 13)
        Me.lbIdentificacionTributaria.TabIndex = 37
        Me.lbIdentificacionTributaria.Text = "Identificación Tributaria:"
        '
        'tbIdentificacionTributaria
        '
        Me.tbIdentificacionTributaria.Location = New System.Drawing.Point(525, 254)
        Me.tbIdentificacionTributaria.MaxLength = 256
        Me.tbIdentificacionTributaria.Name = "tbIdentificacionTributaria"
        Me.tbIdentificacionTributaria.Size = New System.Drawing.Size(150, 20)
        Me.tbIdentificacionTributaria.TabIndex = 9
        '
        'tbPais
        '
        Me.tbPais.Location = New System.Drawing.Point(99, 174)
        Me.tbPais.Name = "tbPais"
        Me.tbPais.Size = New System.Drawing.Size(20, 20)
        Me.tbPais.TabIndex = 38
        Me.tbPais.Visible = False
        '
        'tbMoneda
        '
        Me.tbMoneda.Location = New System.Drawing.Point(99, 201)
        Me.tbMoneda.Name = "tbMoneda"
        Me.tbMoneda.Size = New System.Drawing.Size(20, 20)
        Me.tbMoneda.TabIndex = 39
        Me.tbMoneda.Visible = False
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
        'frEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(689, 286)
        Me.Controls.Add(Me.tbMoneda)
        Me.Controls.Add(Me.tbPais)
        Me.Controls.Add(Me.lbIdentificacionTributaria)
        Me.Controls.Add(Me.tbIdentificacionTributaria)
        Me.Controls.Add(Me.lbTelefono)
        Me.Controls.Add(Me.tbTelefono)
        Me.Controls.Add(Me.lbDireccion)
        Me.Controls.Add(Me.tbDireccion)
        Me.Controls.Add(Me.lbMoneda)
        Me.Controls.Add(Me.lbPais)
        Me.Controls.Add(Me.cbMoneda)
        Me.Controls.Add(Me.cbPais)
        Me.Controls.Add(Me.lbDescripcion)
        Me.Controls.Add(Me.tbDescripcion)
        Me.Controls.Add(Me.tbEstado1)
        Me.Controls.Add(Me.lbEstado)
        Me.Controls.Add(Me.tbEstado)
        Me.Controls.Add(Me.lbRazonSocial)
        Me.Controls.Add(Me.tbRazonSocial)
        Me.Controls.Add(Me.lbNombre)
        Me.Controls.Add(Me.lbCodigo)
        Me.Controls.Add(Me.tbNombre)
        Me.Controls.Add(Me.tbCodigo)
        Me.Controls.Add(Me.UcNavegador1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimizeBox = False
        Me.Name = "frEmpresa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Empresas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UcNavegador1 As ucNavegador
    Friend WithEvents tbEstado1 As TextBox
    Friend WithEvents lbEstado As Label
    Friend WithEvents tbEstado As TextBox
    Friend WithEvents lbRazonSocial As Label
    Friend WithEvents tbRazonSocial As TextBox
    Friend WithEvents lbNombre As Label
    Friend WithEvents lbCodigo As Label
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents tbCodigo As TextBox
    Friend WithEvents lbDescripcion As Label
    Friend WithEvents tbDescripcion As TextBox
    Friend WithEvents cbPais As ComboBox
    Friend WithEvents cbMoneda As ComboBox
    Friend WithEvents lbPais As Label
    Friend WithEvents lbMoneda As Label
    Friend WithEvents lbDireccion As Label
    Friend WithEvents tbDireccion As TextBox
    Friend WithEvents lbTelefono As Label
    Friend WithEvents tbTelefono As TextBox
    Friend WithEvents lbIdentificacionTributaria As Label
    Friend WithEvents tbIdentificacionTributaria As TextBox
    Friend WithEvents tbPais As TextBox
    Friend WithEvents tbMoneda As TextBox
End Class
