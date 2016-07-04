<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frUsuario
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
        Me.tbEstado1 = New System.Windows.Forms.TextBox()
        Me.lbEstado = New System.Windows.Forms.Label()
        Me.tbEstado = New System.Windows.Forms.TextBox()
        Me.lbUsuario = New System.Windows.Forms.Label()
        Me.tbUsuario = New System.Windows.Forms.TextBox()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.lbCodigo = New System.Windows.Forms.Label()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.tbCodigo = New System.Windows.Forms.TextBox()
        Me.lbContrasena = New System.Windows.Forms.Label()
        Me.tbContrasena = New System.Windows.Forms.TextBox()
        Me.dgUsuarioEmpresa = New System.Windows.Forms.DataGridView()
        Me.btAgregarEmpresa = New System.Windows.Forms.Button()
        Me.btEliminarEmpresa = New System.Windows.Forms.Button()
        Me.UcNavegador1 = New MRP.ucNavegador()
        Me.lbEmpresasAsociadas = New System.Windows.Forms.Label()
        CType(Me.dgUsuarioEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lbEstado.TabIndex = 16
        Me.lbEstado.Text = "Estado:"
        '
        'tbEstado
        '
        Me.tbEstado.Location = New System.Drawing.Point(499, 70)
        Me.tbEstado.Name = "tbEstado"
        Me.tbEstado.Size = New System.Drawing.Size(20, 20)
        Me.tbEstado.TabIndex = 10
        Me.tbEstado.Visible = False
        '
        'lbUsuario
        '
        Me.lbUsuario.AutoSize = True
        Me.lbUsuario.Location = New System.Drawing.Point(12, 125)
        Me.lbUsuario.Name = "lbUsuario"
        Me.lbUsuario.Size = New System.Drawing.Size(46, 13)
        Me.lbUsuario.TabIndex = 15
        Me.lbUsuario.Text = "Usuario:"
        '
        'tbUsuario
        '
        Me.tbUsuario.Location = New System.Drawing.Point(125, 122)
        Me.tbUsuario.MaxLength = 32
        Me.tbUsuario.Name = "tbUsuario"
        Me.tbUsuario.Size = New System.Drawing.Size(550, 20)
        Me.tbUsuario.TabIndex = 3
        '
        'lbNombre
        '
        Me.lbNombre.AutoSize = True
        Me.lbNombre.Location = New System.Drawing.Point(12, 99)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(47, 13)
        Me.lbNombre.TabIndex = 14
        Me.lbNombre.Text = "Nombre:"
        '
        'lbCodigo
        '
        Me.lbCodigo.AutoSize = True
        Me.lbCodigo.Location = New System.Drawing.Point(12, 73)
        Me.lbCodigo.Name = "lbCodigo"
        Me.lbCodigo.Size = New System.Drawing.Size(43, 13)
        Me.lbCodigo.TabIndex = 11
        Me.lbCodigo.Text = "Código:"
        '
        'tbNombre
        '
        Me.tbNombre.Location = New System.Drawing.Point(125, 96)
        Me.tbNombre.MaxLength = 100
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
        'lbContrasena
        '
        Me.lbContrasena.AutoSize = True
        Me.lbContrasena.Location = New System.Drawing.Point(12, 151)
        Me.lbContrasena.Name = "lbContrasena"
        Me.lbContrasena.Size = New System.Drawing.Size(64, 13)
        Me.lbContrasena.TabIndex = 18
        Me.lbContrasena.Text = "Contraseña:"
        '
        'tbContrasena
        '
        Me.tbContrasena.Location = New System.Drawing.Point(125, 148)
        Me.tbContrasena.MaxLength = 100
        Me.tbContrasena.Name = "tbContrasena"
        Me.tbContrasena.Size = New System.Drawing.Size(550, 20)
        Me.tbContrasena.TabIndex = 4
        Me.tbContrasena.UseSystemPasswordChar = True
        '
        'dgUsuarioEmpresa
        '
        Me.dgUsuarioEmpresa.AllowDrop = True
        Me.dgUsuarioEmpresa.AllowUserToAddRows = False
        Me.dgUsuarioEmpresa.AllowUserToDeleteRows = False
        Me.dgUsuarioEmpresa.AllowUserToResizeColumns = False
        Me.dgUsuarioEmpresa.AllowUserToResizeRows = False
        Me.dgUsuarioEmpresa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgUsuarioEmpresa.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgUsuarioEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgUsuarioEmpresa.GridColor = System.Drawing.SystemColors.Window
        Me.dgUsuarioEmpresa.Location = New System.Drawing.Point(125, 174)
        Me.dgUsuarioEmpresa.Name = "dgUsuarioEmpresa"
        Me.dgUsuarioEmpresa.RowHeadersVisible = False
        Me.dgUsuarioEmpresa.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgUsuarioEmpresa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgUsuarioEmpresa.Size = New System.Drawing.Size(360, 150)
        Me.dgUsuarioEmpresa.TabIndex = 5
        Me.dgUsuarioEmpresa.Tag = "tbl_mrp_usuario_empresa"
        '
        'btAgregarEmpresa
        '
        Me.btAgregarEmpresa.Location = New System.Drawing.Point(491, 177)
        Me.btAgregarEmpresa.Name = "btAgregarEmpresa"
        Me.btAgregarEmpresa.Size = New System.Drawing.Size(125, 23)
        Me.btAgregarEmpresa.TabIndex = 19
        Me.btAgregarEmpresa.Text = "Agregar Empresa"
        Me.btAgregarEmpresa.UseVisualStyleBackColor = True
        '
        'btEliminarEmpresa
        '
        Me.btEliminarEmpresa.Location = New System.Drawing.Point(491, 206)
        Me.btEliminarEmpresa.Name = "btEliminarEmpresa"
        Me.btEliminarEmpresa.Size = New System.Drawing.Size(125, 23)
        Me.btEliminarEmpresa.TabIndex = 20
        Me.btEliminarEmpresa.Text = "Eliminar Empresa"
        Me.btEliminarEmpresa.UseVisualStyleBackColor = True
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
        Me.UcNavegador1.TabIndex = 7
        '
        'lbEmpresasAsociadas
        '
        Me.lbEmpresasAsociadas.AutoSize = True
        Me.lbEmpresasAsociadas.Location = New System.Drawing.Point(12, 177)
        Me.lbEmpresasAsociadas.Name = "lbEmpresasAsociadas"
        Me.lbEmpresasAsociadas.Size = New System.Drawing.Size(107, 13)
        Me.lbEmpresasAsociadas.TabIndex = 22
        Me.lbEmpresasAsociadas.Text = "Empresas asociadas:"
        '
        'frUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(689, 336)
        Me.Controls.Add(Me.lbEmpresasAsociadas)
        Me.Controls.Add(Me.btEliminarEmpresa)
        Me.Controls.Add(Me.btAgregarEmpresa)
        Me.Controls.Add(Me.dgUsuarioEmpresa)
        Me.Controls.Add(Me.lbContrasena)
        Me.Controls.Add(Me.tbContrasena)
        Me.Controls.Add(Me.tbEstado1)
        Me.Controls.Add(Me.lbEstado)
        Me.Controls.Add(Me.tbEstado)
        Me.Controls.Add(Me.lbUsuario)
        Me.Controls.Add(Me.tbUsuario)
        Me.Controls.Add(Me.lbNombre)
        Me.Controls.Add(Me.lbCodigo)
        Me.Controls.Add(Me.tbNombre)
        Me.Controls.Add(Me.tbCodigo)
        Me.Controls.Add(Me.UcNavegador1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimizeBox = False
        Me.Name = "frUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Usuarios"
        CType(Me.dgUsuarioEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UcNavegador1 As ucNavegador
    Friend WithEvents tbEstado1 As TextBox
    Friend WithEvents lbEstado As Label
    Friend WithEvents tbEstado As TextBox
    Friend WithEvents lbUsuario As Label
    Friend WithEvents tbUsuario As TextBox
    Friend WithEvents lbNombre As Label
    Friend WithEvents lbCodigo As Label
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents tbCodigo As TextBox
    Friend WithEvents lbContrasena As Label
    Friend WithEvents tbContrasena As TextBox
    Friend WithEvents dgUsuarioEmpresa As DataGridView
    Friend WithEvents btAgregarEmpresa As Button
    Friend WithEvents btEliminarEmpresa As Button
    Friend WithEvents lbEmpresasAsociadas As Label
End Class
