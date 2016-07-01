<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucNavegador
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucNavegador))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btNuevo = New System.Windows.Forms.Button()
        Me.btGuardar = New System.Windows.Forms.Button()
        Me.btEliminar = New System.Windows.Forms.Button()
        Me.btPrimero = New System.Windows.Forms.Button()
        Me.btAnterior = New System.Windows.Forms.Button()
        Me.btSiguiente = New System.Windows.Forms.Button()
        Me.btUltimo = New System.Windows.Forms.Button()
        Me.btBuscar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btNuevo
        '
        Me.btNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btNuevo.Image = CType(resources.GetObject("btNuevo.Image"), System.Drawing.Image)
        Me.btNuevo.Location = New System.Drawing.Point(3, 3)
        Me.btNuevo.Name = "btNuevo"
        Me.btNuevo.Size = New System.Drawing.Size(35, 35)
        Me.btNuevo.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.btNuevo, "Nuevo")
        Me.btNuevo.UseVisualStyleBackColor = True
        '
        'btGuardar
        '
        Me.btGuardar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btGuardar.Image = CType(resources.GetObject("btGuardar.Image"), System.Drawing.Image)
        Me.btGuardar.Location = New System.Drawing.Point(40, 3)
        Me.btGuardar.Name = "btGuardar"
        Me.btGuardar.Size = New System.Drawing.Size(35, 35)
        Me.btGuardar.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.btGuardar, "Guardar")
        Me.btGuardar.UseVisualStyleBackColor = False
        '
        'btEliminar
        '
        Me.btEliminar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEliminar.Image = CType(resources.GetObject("btEliminar.Image"), System.Drawing.Image)
        Me.btEliminar.Location = New System.Drawing.Point(77, 3)
        Me.btEliminar.Name = "btEliminar"
        Me.btEliminar.Size = New System.Drawing.Size(35, 35)
        Me.btEliminar.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.btEliminar, "Eliminar")
        Me.btEliminar.UseVisualStyleBackColor = False
        '
        'btPrimero
        '
        Me.btPrimero.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btPrimero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btPrimero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btPrimero.Image = CType(resources.GetObject("btPrimero.Image"), System.Drawing.Image)
        Me.btPrimero.Location = New System.Drawing.Point(114, 3)
        Me.btPrimero.Name = "btPrimero"
        Me.btPrimero.Size = New System.Drawing.Size(35, 35)
        Me.btPrimero.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.btPrimero, "Primero")
        Me.btPrimero.UseVisualStyleBackColor = False
        '
        'btAnterior
        '
        Me.btAnterior.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAnterior.Image = CType(resources.GetObject("btAnterior.Image"), System.Drawing.Image)
        Me.btAnterior.Location = New System.Drawing.Point(151, 3)
        Me.btAnterior.Name = "btAnterior"
        Me.btAnterior.Size = New System.Drawing.Size(35, 35)
        Me.btAnterior.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.btAnterior, "Anterior")
        Me.btAnterior.UseVisualStyleBackColor = False
        '
        'btSiguiente
        '
        Me.btSiguiente.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSiguiente.Image = CType(resources.GetObject("btSiguiente.Image"), System.Drawing.Image)
        Me.btSiguiente.Location = New System.Drawing.Point(188, 3)
        Me.btSiguiente.Name = "btSiguiente"
        Me.btSiguiente.Size = New System.Drawing.Size(35, 35)
        Me.btSiguiente.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.btSiguiente, "Siguiente")
        Me.btSiguiente.UseVisualStyleBackColor = False
        '
        'btUltimo
        '
        Me.btUltimo.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btUltimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btUltimo.Image = CType(resources.GetObject("btUltimo.Image"), System.Drawing.Image)
        Me.btUltimo.Location = New System.Drawing.Point(225, 3)
        Me.btUltimo.Name = "btUltimo"
        Me.btUltimo.Size = New System.Drawing.Size(35, 35)
        Me.btUltimo.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.btUltimo, "Último")
        Me.btUltimo.UseVisualStyleBackColor = False
        '
        'btBuscar
        '
        Me.btBuscar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btBuscar.Image = CType(resources.GetObject("btBuscar.Image"), System.Drawing.Image)
        Me.btBuscar.Location = New System.Drawing.Point(262, 3)
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(35, 35)
        Me.btBuscar.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.btBuscar, "Buscar")
        Me.btBuscar.UseVisualStyleBackColor = False
        '
        'ucNavegador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Controls.Add(Me.btBuscar)
        Me.Controls.Add(Me.btUltimo)
        Me.Controls.Add(Me.btSiguiente)
        Me.Controls.Add(Me.btAnterior)
        Me.Controls.Add(Me.btPrimero)
        Me.Controls.Add(Me.btEliminar)
        Me.Controls.Add(Me.btGuardar)
        Me.Controls.Add(Me.btNuevo)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "ucNavegador"
        Me.Size = New System.Drawing.Size(300, 41)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Private WithEvents btNuevo As Button
    Private WithEvents btGuardar As Button
    Private WithEvents btEliminar As Button
    Private WithEvents btPrimero As Button
    Private WithEvents btAnterior As Button
    Private WithEvents btSiguiente As Button
    Private WithEvents btUltimo As Button
    Private WithEvents btBuscar As Button
End Class
