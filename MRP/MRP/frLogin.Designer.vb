<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class frLogin
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
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents lbUsuario As System.Windows.Forms.Label
    Friend WithEvents lbContrasena As System.Windows.Forms.Label
    Friend WithEvents tbUsuario As System.Windows.Forms.TextBox
    Friend WithEvents tbContrasena As System.Windows.Forms.TextBox
    Friend WithEvents btAceptar As System.Windows.Forms.Button
    Friend WithEvents btCancelar As System.Windows.Forms.Button

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frLogin))
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.lbUsuario = New System.Windows.Forms.Label()
        Me.lbContrasena = New System.Windows.Forms.Label()
        Me.tbUsuario = New System.Windows.Forms.TextBox()
        Me.tbContrasena = New System.Windows.Forms.TextBox()
        Me.btAceptar = New System.Windows.Forms.Button()
        Me.btCancelar = New System.Windows.Forms.Button()
        Me.btConfiguracion = New System.Windows.Forms.Button()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(165, 193)
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'lbUsuario
        '
        Me.lbUsuario.Location = New System.Drawing.Point(177, 37)
        Me.lbUsuario.Name = "lbUsuario"
        Me.lbUsuario.Size = New System.Drawing.Size(220, 23)
        Me.lbUsuario.TabIndex = 5
        Me.lbUsuario.Text = "Nombre de usuario"
        Me.lbUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbContrasena
        '
        Me.lbContrasena.Location = New System.Drawing.Point(177, 94)
        Me.lbContrasena.Name = "lbContrasena"
        Me.lbContrasena.Size = New System.Drawing.Size(220, 23)
        Me.lbContrasena.TabIndex = 6
        Me.lbContrasena.Text = "Contraseña"
        Me.lbContrasena.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbUsuario
        '
        Me.tbUsuario.Location = New System.Drawing.Point(177, 63)
        Me.tbUsuario.Name = "tbUsuario"
        Me.tbUsuario.Size = New System.Drawing.Size(220, 20)
        Me.tbUsuario.TabIndex = 0
        '
        'tbContrasena
        '
        Me.tbContrasena.Location = New System.Drawing.Point(177, 120)
        Me.tbContrasena.Name = "tbContrasena"
        Me.tbContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbContrasena.Size = New System.Drawing.Size(220, 20)
        Me.tbContrasena.TabIndex = 1
        '
        'btAceptar
        '
        Me.btAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.btAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btAceptar.Location = New System.Drawing.Point(200, 156)
        Me.btAceptar.Name = "btAceptar"
        Me.btAceptar.Size = New System.Drawing.Size(94, 23)
        Me.btAceptar.TabIndex = 2
        Me.btAceptar.Text = "&Aceptar"
        Me.btAceptar.UseVisualStyleBackColor = False
        '
        'btCancelar
        '
        Me.btCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btCancelar.Location = New System.Drawing.Point(303, 156)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(94, 23)
        Me.btCancelar.TabIndex = 3
        Me.btCancelar.Text = "&Cancelar"
        Me.btCancelar.UseVisualStyleBackColor = False
        '
        'btConfiguracion
        '
        Me.btConfiguracion.BackColor = System.Drawing.SystemColors.Control
        Me.btConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btConfiguracion.Image = CType(resources.GetObject("btConfiguracion.Image"), System.Drawing.Image)
        Me.btConfiguracion.Location = New System.Drawing.Point(361, 12)
        Me.btConfiguracion.Name = "btConfiguracion"
        Me.btConfiguracion.Size = New System.Drawing.Size(36, 36)
        Me.btConfiguracion.TabIndex = 4
        Me.btConfiguracion.Text = "C"
        Me.btConfiguracion.UseVisualStyleBackColor = False
        '
        'frLogin
        '
        Me.AcceptButton = Me.btAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.CancelButton = Me.btCancelar
        Me.ClientSize = New System.Drawing.Size(409, 191)
        Me.Controls.Add(Me.btConfiguracion)
        Me.Controls.Add(Me.btCancelar)
        Me.Controls.Add(Me.btAceptar)
        Me.Controls.Add(Me.tbContrasena)
        Me.Controls.Add(Me.tbUsuario)
        Me.Controls.Add(Me.lbContrasena)
        Me.Controls.Add(Me.lbUsuario)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frLogin"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MRP - Login"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btConfiguracion As Button
End Class
