<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frMoneda
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
        Me.tbCodigo = New System.Windows.Forms.TextBox()
        Me.tbDescripcion = New System.Windows.Forms.TextBox()
        Me.lbCodigo = New System.Windows.Forms.Label()
        Me.lbDescripcion = New System.Windows.Forms.Label()
        Me.lbSimbolo = New System.Windows.Forms.Label()
        Me.tbSimbolo = New System.Windows.Forms.TextBox()
        Me.UcNavegador1 = New MRP.ucNavegador()
        Me.tbEstado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbEstado1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'tbCodigo
        '
        Me.tbCodigo.Location = New System.Drawing.Point(125, 60)
        Me.tbCodigo.Name = "tbCodigo"
        Me.tbCodigo.ReadOnly = True
        Me.tbCodigo.Size = New System.Drawing.Size(150, 20)
        Me.tbCodigo.TabIndex = 0
        '
        'tbDescripcion
        '
        Me.tbDescripcion.Location = New System.Drawing.Point(125, 86)
        Me.tbDescripcion.Name = "tbDescripcion"
        Me.tbDescripcion.Size = New System.Drawing.Size(150, 20)
        Me.tbDescripcion.TabIndex = 2
        '
        'lbCodigo
        '
        Me.lbCodigo.AutoSize = True
        Me.lbCodigo.Location = New System.Drawing.Point(12, 63)
        Me.lbCodigo.Name = "lbCodigo"
        Me.lbCodigo.Size = New System.Drawing.Size(43, 13)
        Me.lbCodigo.TabIndex = 2
        Me.lbCodigo.Text = "Código:"
        '
        'lbDescripcion
        '
        Me.lbDescripcion.AutoSize = True
        Me.lbDescripcion.Location = New System.Drawing.Point(12, 89)
        Me.lbDescripcion.Name = "lbDescripcion"
        Me.lbDescripcion.Size = New System.Drawing.Size(66, 13)
        Me.lbDescripcion.TabIndex = 3
        Me.lbDescripcion.Text = "Descripción:"
        '
        'lbSimbolo
        '
        Me.lbSimbolo.AutoSize = True
        Me.lbSimbolo.Location = New System.Drawing.Point(353, 89)
        Me.lbSimbolo.Name = "lbSimbolo"
        Me.lbSimbolo.Size = New System.Drawing.Size(49, 13)
        Me.lbSimbolo.TabIndex = 5
        Me.lbSimbolo.Text = "Símbolo:"
        '
        'tbSimbolo
        '
        Me.tbSimbolo.Location = New System.Drawing.Point(466, 86)
        Me.tbSimbolo.Name = "tbSimbolo"
        Me.tbSimbolo.Size = New System.Drawing.Size(150, 20)
        Me.tbSimbolo.TabIndex = 3
        '
        'UcNavegador1
        '
        Me.UcNavegador1.AutoSize = True
        Me.UcNavegador1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.UcNavegador1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UcNavegador1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcNavegador1.Location = New System.Drawing.Point(0, 0)
        Me.UcNavegador1.Name = "UcNavegador1"
        Me.UcNavegador1.Size = New System.Drawing.Size(629, 41)
        Me.UcNavegador1.TabIndex = 6
        '
        'tbEstado
        '
        Me.tbEstado.Location = New System.Drawing.Point(440, 60)
        Me.tbEstado.Name = "tbEstado"
        Me.tbEstado.Size = New System.Drawing.Size(20, 20)
        Me.tbEstado.TabIndex = 1
        Me.tbEstado.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(353, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Estado:"
        '
        'tbEstado1
        '
        Me.tbEstado1.Location = New System.Drawing.Point(466, 60)
        Me.tbEstado1.Name = "tbEstado1"
        Me.tbEstado1.ReadOnly = True
        Me.tbEstado1.Size = New System.Drawing.Size(150, 20)
        Me.tbEstado1.TabIndex = 1
        '
        'frMoneda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(629, 121)
        Me.Controls.Add(Me.tbEstado1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbEstado)
        Me.Controls.Add(Me.UcNavegador1)
        Me.Controls.Add(Me.lbSimbolo)
        Me.Controls.Add(Me.tbSimbolo)
        Me.Controls.Add(Me.lbDescripcion)
        Me.Controls.Add(Me.lbCodigo)
        Me.Controls.Add(Me.tbDescripcion)
        Me.Controls.Add(Me.tbCodigo)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frMoneda"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Monedas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbCodigo As TextBox
    Friend WithEvents tbDescripcion As TextBox
    Friend WithEvents lbCodigo As Label
    Friend WithEvents lbDescripcion As Label
    Friend WithEvents lbSimbolo As Label
    Friend WithEvents tbSimbolo As TextBox
    Friend WithEvents UcNavegador1 As ucNavegador
    Friend WithEvents tbEstado As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbEstado1 As TextBox
End Class
