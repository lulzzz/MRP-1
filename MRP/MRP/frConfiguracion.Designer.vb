<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frConfiguracion
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
        Me.tbServer = New System.Windows.Forms.TextBox()
        Me.tbDataBase = New System.Windows.Forms.TextBox()
        Me.tbUser = New System.Windows.Forms.TextBox()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btCancelar = New System.Windows.Forms.Button()
        Me.btAceptar = New System.Windows.Forms.Button()
        Me.btTest = New System.Windows.Forms.Button()
        Me.pnlPanelOpciones = New System.Windows.Forms.Panel()
        Me.pnlPanelOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbServer
        '
        Me.tbServer.Location = New System.Drawing.Point(100, 64)
        Me.tbServer.Name = "tbServer"
        Me.tbServer.Size = New System.Drawing.Size(307, 20)
        Me.tbServer.TabIndex = 0
        '
        'tbDataBase
        '
        Me.tbDataBase.Location = New System.Drawing.Point(100, 90)
        Me.tbDataBase.Name = "tbDataBase"
        Me.tbDataBase.Size = New System.Drawing.Size(307, 20)
        Me.tbDataBase.TabIndex = 1
        '
        'tbUser
        '
        Me.tbUser.Location = New System.Drawing.Point(100, 116)
        Me.tbUser.Name = "tbUser"
        Me.tbUser.Size = New System.Drawing.Size(307, 20)
        Me.tbUser.TabIndex = 2
        '
        'tbPassword
        '
        Me.tbPassword.Location = New System.Drawing.Point(100, 142)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.Size = New System.Drawing.Size(307, 20)
        Me.tbPassword.TabIndex = 3
        Me.tbPassword.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Servidor:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Base de Datos:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Usuario:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Contraseña:"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(17, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(386, 36)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Bienvenido al formulario de configuración, por favor complete todos los campos pa" &
    "ra establecer conexión con el servidor de base de datos SQL Server."
        '
        'btCancelar
        '
        Me.btCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btCancelar.Location = New System.Drawing.Point(313, 13)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(94, 23)
        Me.btCancelar.TabIndex = 6
        Me.btCancelar.Text = "&Cancelar"
        Me.btCancelar.UseVisualStyleBackColor = False
        '
        'btAceptar
        '
        Me.btAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.btAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btAceptar.Location = New System.Drawing.Point(210, 13)
        Me.btAceptar.Name = "btAceptar"
        Me.btAceptar.Size = New System.Drawing.Size(94, 23)
        Me.btAceptar.TabIndex = 5
        Me.btAceptar.Text = "&Aceptar"
        Me.btAceptar.UseVisualStyleBackColor = False
        '
        'btTest
        '
        Me.btTest.BackColor = System.Drawing.SystemColors.Control
        Me.btTest.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btTest.Location = New System.Drawing.Point(17, 13)
        Me.btTest.Name = "btTest"
        Me.btTest.Size = New System.Drawing.Size(61, 23)
        Me.btTest.TabIndex = 4
        Me.btTest.Text = "&Test"
        Me.btTest.UseVisualStyleBackColor = False
        '
        'pnlPanelOpciones
        '
        Me.pnlPanelOpciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.pnlPanelOpciones.Controls.Add(Me.btCancelar)
        Me.pnlPanelOpciones.Controls.Add(Me.btTest)
        Me.pnlPanelOpciones.Controls.Add(Me.btAceptar)
        Me.pnlPanelOpciones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlPanelOpciones.Location = New System.Drawing.Point(0, 174)
        Me.pnlPanelOpciones.Name = "pnlPanelOpciones"
        Me.pnlPanelOpciones.Size = New System.Drawing.Size(419, 48)
        Me.pnlPanelOpciones.TabIndex = 101
        '
        'frConfiguracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(419, 222)
        Me.Controls.Add(Me.pnlPanelOpciones)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbPassword)
        Me.Controls.Add(Me.tbUser)
        Me.Controls.Add(Me.tbDataBase)
        Me.Controls.Add(Me.tbServer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frConfiguracion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MRP - Configuración"
        Me.pnlPanelOpciones.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbServer As TextBox
    Friend WithEvents tbDataBase As TextBox
    Friend WithEvents tbUser As TextBox
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btCancelar As Button
    Friend WithEvents btAceptar As Button
    Friend WithEvents btTest As Button
    Friend WithEvents pnlPanelOpciones As Panel
End Class
