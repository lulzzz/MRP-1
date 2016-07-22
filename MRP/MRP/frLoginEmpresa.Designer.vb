<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class frLoginEmpresa
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
    Friend WithEvents pbLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lbEmpresa As System.Windows.Forms.Label
    Friend WithEvents btAceptar As System.Windows.Forms.Button
    Friend WithEvents btCancelar As System.Windows.Forms.Button

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frLoginEmpresa))
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.lbEmpresa = New System.Windows.Forms.Label()
        Me.btAceptar = New System.Windows.Forms.Button()
        Me.btCancelar = New System.Windows.Forms.Button()
        Me.cbEmpresa = New System.Windows.Forms.ComboBox()
        Me.pnlPanelOpciones = New System.Windows.Forms.Panel()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPanelOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbLogo
        '
        Me.pbLogo.Image = CType(resources.GetObject("pbLogo.Image"), System.Drawing.Image)
        Me.pbLogo.Location = New System.Drawing.Point(0, 0)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(165, 193)
        Me.pbLogo.TabIndex = 0
        Me.pbLogo.TabStop = False
        '
        'lbEmpresa
        '
        Me.lbEmpresa.Location = New System.Drawing.Point(177, 67)
        Me.lbEmpresa.Name = "lbEmpresa"
        Me.lbEmpresa.Size = New System.Drawing.Size(220, 23)
        Me.lbEmpresa.TabIndex = 0
        Me.lbEmpresa.Text = "Empresa"
        Me.lbEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btAceptar
        '
        Me.btAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.btAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btAceptar.Location = New System.Drawing.Point(200, 13)
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
        Me.btCancelar.Location = New System.Drawing.Point(303, 13)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(94, 23)
        Me.btCancelar.TabIndex = 3
        Me.btCancelar.Text = "&Cancelar"
        Me.btCancelar.UseVisualStyleBackColor = False
        '
        'cbEmpresa
        '
        Me.cbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEmpresa.FormattingEnabled = True
        Me.cbEmpresa.Location = New System.Drawing.Point(177, 93)
        Me.cbEmpresa.Name = "cbEmpresa"
        Me.cbEmpresa.Size = New System.Drawing.Size(220, 21)
        Me.cbEmpresa.TabIndex = 1
        '
        'pnlPanelOpciones
        '
        Me.pnlPanelOpciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.pnlPanelOpciones.Controls.Add(Me.btCancelar)
        Me.pnlPanelOpciones.Controls.Add(Me.btAceptar)
        Me.pnlPanelOpciones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlPanelOpciones.Location = New System.Drawing.Point(0, 187)
        Me.pnlPanelOpciones.Name = "pnlPanelOpciones"
        Me.pnlPanelOpciones.Size = New System.Drawing.Size(409, 48)
        Me.pnlPanelOpciones.TabIndex = 100
        '
        'frLoginEmpresa
        '
        Me.AcceptButton = Me.btAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.btCancelar
        Me.ClientSize = New System.Drawing.Size(409, 235)
        Me.Controls.Add(Me.pnlPanelOpciones)
        Me.Controls.Add(Me.cbEmpresa)
        Me.Controls.Add(Me.lbEmpresa)
        Me.Controls.Add(Me.pbLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frLoginEmpresa"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MRP - Login"
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPanelOpciones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cbEmpresa As ComboBox
    Friend WithEvents pnlPanelOpciones As Panel
End Class
