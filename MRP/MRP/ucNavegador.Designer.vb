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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucNavegador))
        Me.btNuevo = New System.Windows.Forms.Button()
        Me.btGuardar = New System.Windows.Forms.Button()
        Me.btEliminar = New System.Windows.Forms.Button()
        Me.btPrimero = New System.Windows.Forms.Button()
        Me.btAnterior = New System.Windows.Forms.Button()
        Me.btSiguiente = New System.Windows.Forms.Button()
        Me.btUltimo = New System.Windows.Forms.Button()
        Me.btBuscar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.lbNuevo = New System.Windows.Forms.Label()
        Me.lbGuardar = New System.Windows.Forms.Label()
        Me.lbEliminar = New System.Windows.Forms.Label()
        Me.lbPrimero = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btNuevo
        '
        Me.btNuevo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btNuevo.FlatAppearance.BorderSize = 0
        Me.btNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.btNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btNuevo.Image = CType(resources.GetObject("btNuevo.Image"), System.Drawing.Image)
        Me.btNuevo.Location = New System.Drawing.Point(10, 5)
        Me.btNuevo.Name = "btNuevo"
        Me.btNuevo.Size = New System.Drawing.Size(35, 35)
        Me.btNuevo.TabIndex = 101
        Me.btNuevo.TabStop = False
        Me.btNuevo.UseVisualStyleBackColor = False
        '
        'btGuardar
        '
        Me.btGuardar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btGuardar.FlatAppearance.BorderSize = 0
        Me.btGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.btGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btGuardar.Image = CType(resources.GetObject("btGuardar.Image"), System.Drawing.Image)
        Me.btGuardar.Location = New System.Drawing.Point(56, 5)
        Me.btGuardar.Name = "btGuardar"
        Me.btGuardar.Size = New System.Drawing.Size(35, 35)
        Me.btGuardar.TabIndex = 102
        Me.btGuardar.TabStop = False
        Me.btGuardar.UseVisualStyleBackColor = False
        '
        'btEliminar
        '
        Me.btEliminar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btEliminar.FlatAppearance.BorderSize = 0
        Me.btEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.btEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEliminar.Image = CType(resources.GetObject("btEliminar.Image"), System.Drawing.Image)
        Me.btEliminar.Location = New System.Drawing.Point(102, 5)
        Me.btEliminar.Name = "btEliminar"
        Me.btEliminar.Size = New System.Drawing.Size(36, 36)
        Me.btEliminar.TabIndex = 103
        Me.btEliminar.TabStop = False
        Me.btEliminar.UseVisualStyleBackColor = False
        '
        'btPrimero
        '
        Me.btPrimero.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btPrimero.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btPrimero.FlatAppearance.BorderSize = 0
        Me.btPrimero.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.btPrimero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btPrimero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btPrimero.Image = CType(resources.GetObject("btPrimero.Image"), System.Drawing.Image)
        Me.btPrimero.Location = New System.Drawing.Point(148, 5)
        Me.btPrimero.Name = "btPrimero"
        Me.btPrimero.Size = New System.Drawing.Size(36, 36)
        Me.btPrimero.TabIndex = 104
        Me.btPrimero.TabStop = False
        Me.btPrimero.UseVisualStyleBackColor = False
        '
        'btAnterior
        '
        Me.btAnterior.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btAnterior.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btAnterior.FlatAppearance.BorderSize = 0
        Me.btAnterior.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.btAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAnterior.Image = CType(resources.GetObject("btAnterior.Image"), System.Drawing.Image)
        Me.btAnterior.Location = New System.Drawing.Point(194, 5)
        Me.btAnterior.Name = "btAnterior"
        Me.btAnterior.Size = New System.Drawing.Size(36, 36)
        Me.btAnterior.TabIndex = 105
        Me.btAnterior.TabStop = False
        Me.btAnterior.UseVisualStyleBackColor = False
        '
        'btSiguiente
        '
        Me.btSiguiente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSiguiente.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btSiguiente.FlatAppearance.BorderSize = 0
        Me.btSiguiente.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.btSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSiguiente.Image = CType(resources.GetObject("btSiguiente.Image"), System.Drawing.Image)
        Me.btSiguiente.Location = New System.Drawing.Point(240, 5)
        Me.btSiguiente.Name = "btSiguiente"
        Me.btSiguiente.Size = New System.Drawing.Size(36, 36)
        Me.btSiguiente.TabIndex = 106
        Me.btSiguiente.TabStop = False
        Me.btSiguiente.UseVisualStyleBackColor = False
        '
        'btUltimo
        '
        Me.btUltimo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btUltimo.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btUltimo.FlatAppearance.BorderSize = 0
        Me.btUltimo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.btUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btUltimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btUltimo.Image = CType(resources.GetObject("btUltimo.Image"), System.Drawing.Image)
        Me.btUltimo.Location = New System.Drawing.Point(286, 5)
        Me.btUltimo.Name = "btUltimo"
        Me.btUltimo.Size = New System.Drawing.Size(36, 36)
        Me.btUltimo.TabIndex = 107
        Me.btUltimo.TabStop = False
        Me.btUltimo.UseVisualStyleBackColor = False
        '
        'btBuscar
        '
        Me.btBuscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btBuscar.FlatAppearance.BorderSize = 0
        Me.btBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.btBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btBuscar.Image = CType(resources.GetObject("btBuscar.Image"), System.Drawing.Image)
        Me.btBuscar.Location = New System.Drawing.Point(331, 5)
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(36, 36)
        Me.btBuscar.TabIndex = 108
        Me.btBuscar.TabStop = False
        Me.btBuscar.UseVisualStyleBackColor = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(384, 5)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(36, 36)
        Me.btnCerrar.TabIndex = 109
        Me.btnCerrar.TabStop = False
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'lbNuevo
        '
        Me.lbNuevo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbNuevo.AutoSize = True
        Me.lbNuevo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbNuevo.Location = New System.Drawing.Point(9, 44)
        Me.lbNuevo.Name = "lbNuevo"
        Me.lbNuevo.Size = New System.Drawing.Size(39, 13)
        Me.lbNuevo.TabIndex = 110
        Me.lbNuevo.Text = "Nuevo"
        '
        'lbGuardar
        '
        Me.lbGuardar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbGuardar.AutoSize = True
        Me.lbGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbGuardar.Location = New System.Drawing.Point(53, 44)
        Me.lbGuardar.Name = "lbGuardar"
        Me.lbGuardar.Size = New System.Drawing.Size(45, 13)
        Me.lbGuardar.TabIndex = 111
        Me.lbGuardar.Text = "Guardar"
        '
        'lbEliminar
        '
        Me.lbEliminar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbEliminar.AutoSize = True
        Me.lbEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbEliminar.Location = New System.Drawing.Point(99, 44)
        Me.lbEliminar.Name = "lbEliminar"
        Me.lbEliminar.Size = New System.Drawing.Size(43, 13)
        Me.lbEliminar.TabIndex = 112
        Me.lbEliminar.Text = "Eliminar"
        '
        'lbPrimero
        '
        Me.lbPrimero.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbPrimero.AutoSize = True
        Me.lbPrimero.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbPrimero.Location = New System.Drawing.Point(146, 44)
        Me.lbPrimero.Name = "lbPrimero"
        Me.lbPrimero.Size = New System.Drawing.Size(42, 13)
        Me.lbPrimero.TabIndex = 113
        Me.lbPrimero.Text = "Primero"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(192, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 114
        Me.Label1.Text = "Anterior"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(235, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 115
        Me.Label2.Text = "Siguiente"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(287, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 116
        Me.Label3.Text = "Último"
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(331, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 117
        Me.Label4.Text = "Buscar"
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(386, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 118
        Me.Label5.Text = "Cerrar"
        '
        'ucNavegador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbPrimero)
        Me.Controls.Add(Me.lbEliminar)
        Me.Controls.Add(Me.lbGuardar)
        Me.Controls.Add(Me.lbNuevo)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btBuscar)
        Me.Controls.Add(Me.btUltimo)
        Me.Controls.Add(Me.btSiguiente)
        Me.Controls.Add(Me.btAnterior)
        Me.Controls.Add(Me.btPrimero)
        Me.Controls.Add(Me.btEliminar)
        Me.Controls.Add(Me.btGuardar)
        Me.Controls.Add(Me.btNuevo)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinimumSize = New System.Drawing.Size(0, 60)
        Me.Name = "ucNavegador"
        Me.Size = New System.Drawing.Size(430, 60)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btNuevo As Button
    Private WithEvents btGuardar As Button
    Private WithEvents btEliminar As Button
    Private WithEvents btPrimero As Button
    Private WithEvents btAnterior As Button
    Private WithEvents btSiguiente As Button
    Private WithEvents btUltimo As Button
    Private WithEvents btBuscar As Button
    Private WithEvents btnCerrar As Button
    Friend WithEvents lbNuevo As Label
    Friend WithEvents lbGuardar As Label
    Friend WithEvents lbEliminar As Label
    Friend WithEvents lbPrimero As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
