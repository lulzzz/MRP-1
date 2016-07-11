<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frGastoPeriodo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tbEmpresa = New System.Windows.Forms.TextBox()
        Me.lbCodigoGasto = New System.Windows.Forms.Label()
        Me.cbGasto = New System.Windows.Forms.ComboBox()
        Me.lbMes = New System.Windows.Forms.Label()
        Me.tbMes = New System.Windows.Forms.TextBox()
        Me.tbGasto = New System.Windows.Forms.TextBox()
        Me.tbEstado1 = New System.Windows.Forms.TextBox()
        Me.lbEstado = New System.Windows.Forms.Label()
        Me.tbEstado = New System.Windows.Forms.TextBox()
        Me.lbAnio = New System.Windows.Forms.Label()
        Me.lbCodigo = New System.Windows.Forms.Label()
        Me.tbAnio = New System.Windows.Forms.TextBox()
        Me.tbCodigo = New System.Windows.Forms.TextBox()
        Me.lbCantidad = New System.Windows.Forms.Label()
        Me.tbCantidad = New System.Windows.Forms.TextBox()
        Me.pnlPanelTitulo = New System.Windows.Forms.Panel()
        Me.lbTitulo = New System.Windows.Forms.Label()
        Me.UcNavegador1 = New MRP.ucNavegador()
        Me.pnlPanelTitulo.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbEmpresa
        '
        Me.tbEmpresa.Location = New System.Drawing.Point(281, 70)
        Me.tbEmpresa.MaxLength = 100
        Me.tbEmpresa.Name = "tbEmpresa"
        Me.tbEmpresa.Size = New System.Drawing.Size(20, 20)
        Me.tbEmpresa.TabIndex = 100
        Me.tbEmpresa.Visible = False
        '
        'lbCodigoGasto
        '
        Me.lbCodigoGasto.AutoSize = True
        Me.lbCodigoGasto.Location = New System.Drawing.Point(12, 99)
        Me.lbCodigoGasto.Name = "lbCodigoGasto"
        Me.lbCodigoGasto.Size = New System.Drawing.Size(38, 13)
        Me.lbCodigoGasto.TabIndex = 113
        Me.lbCodigoGasto.Text = "Gasto:"
        '
        'cbGasto
        '
        Me.cbGasto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGasto.FormattingEnabled = True
        Me.cbGasto.Location = New System.Drawing.Point(125, 96)
        Me.cbGasto.Name = "cbGasto"
        Me.cbGasto.Size = New System.Drawing.Size(550, 21)
        Me.cbGasto.TabIndex = 2
        '
        'lbMes
        '
        Me.lbMes.AutoSize = True
        Me.lbMes.Location = New System.Drawing.Point(12, 152)
        Me.lbMes.Name = "lbMes"
        Me.lbMes.Size = New System.Drawing.Size(30, 13)
        Me.lbMes.TabIndex = 112
        Me.lbMes.Text = "Mes:"
        '
        'tbMes
        '
        Me.tbMes.Location = New System.Drawing.Point(125, 149)
        Me.tbMes.MaxLength = 256
        Me.tbMes.Name = "tbMes"
        Me.tbMes.Size = New System.Drawing.Size(550, 20)
        Me.tbMes.TabIndex = 4
        '
        'tbGasto
        '
        Me.tbGasto.Location = New System.Drawing.Point(99, 96)
        Me.tbGasto.MaxLength = 100
        Me.tbGasto.Name = "tbGasto"
        Me.tbGasto.Size = New System.Drawing.Size(20, 20)
        Me.tbGasto.TabIndex = 100
        Me.tbGasto.Visible = False
        '
        'tbEstado1
        '
        Me.tbEstado1.Location = New System.Drawing.Point(525, 70)
        Me.tbEstado1.Name = "tbEstado1"
        Me.tbEstado1.ReadOnly = True
        Me.tbEstado1.Size = New System.Drawing.Size(150, 20)
        Me.tbEstado1.TabIndex = 1
        Me.tbEstado1.TabStop = False
        '
        'lbEstado
        '
        Me.lbEstado.AutoSize = True
        Me.lbEstado.Location = New System.Drawing.Point(412, 73)
        Me.lbEstado.Name = "lbEstado"
        Me.lbEstado.Size = New System.Drawing.Size(43, 13)
        Me.lbEstado.TabIndex = 110
        Me.lbEstado.Text = "Estado:"
        '
        'tbEstado
        '
        Me.tbEstado.Location = New System.Drawing.Point(499, 70)
        Me.tbEstado.Name = "tbEstado"
        Me.tbEstado.Size = New System.Drawing.Size(20, 20)
        Me.tbEstado.TabIndex = 100
        Me.tbEstado.Visible = False
        '
        'lbAnio
        '
        Me.lbAnio.AutoSize = True
        Me.lbAnio.Location = New System.Drawing.Point(12, 126)
        Me.lbAnio.Name = "lbAnio"
        Me.lbAnio.Size = New System.Drawing.Size(29, 13)
        Me.lbAnio.TabIndex = 109
        Me.lbAnio.Text = "Año:"
        '
        'lbCodigo
        '
        Me.lbCodigo.AutoSize = True
        Me.lbCodigo.Location = New System.Drawing.Point(12, 73)
        Me.lbCodigo.Name = "lbCodigo"
        Me.lbCodigo.Size = New System.Drawing.Size(43, 13)
        Me.lbCodigo.TabIndex = 108
        Me.lbCodigo.Text = "Código:"
        '
        'tbAnio
        '
        Me.tbAnio.Location = New System.Drawing.Point(125, 123)
        Me.tbAnio.MaxLength = 100
        Me.tbAnio.Name = "tbAnio"
        Me.tbAnio.Size = New System.Drawing.Size(550, 20)
        Me.tbAnio.TabIndex = 3
        '
        'tbCodigo
        '
        Me.tbCodigo.Location = New System.Drawing.Point(125, 70)
        Me.tbCodigo.Name = "tbCodigo"
        Me.tbCodigo.ReadOnly = True
        Me.tbCodigo.Size = New System.Drawing.Size(150, 20)
        Me.tbCodigo.TabIndex = 0
        Me.tbCodigo.TabStop = False
        '
        'lbCantidad
        '
        Me.lbCantidad.AutoSize = True
        Me.lbCantidad.Location = New System.Drawing.Point(12, 178)
        Me.lbCantidad.Name = "lbCantidad"
        Me.lbCantidad.Size = New System.Drawing.Size(34, 13)
        Me.lbCantidad.TabIndex = 116
        Me.lbCantidad.Text = "Valor:"
        '
        'tbCantidad
        '
        Me.tbCantidad.Location = New System.Drawing.Point(125, 175)
        Me.tbCantidad.MaxLength = 256
        Me.tbCantidad.Name = "tbCantidad"
        Me.tbCantidad.Size = New System.Drawing.Size(550, 20)
        Me.tbCantidad.TabIndex = 5
        '
        'pnlPanelTitulo
        '
        Me.pnlPanelTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPanelTitulo.Controls.Add(Me.lbTitulo)
        Me.pnlPanelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlPanelTitulo.Location = New System.Drawing.Point(0, 0)
        Me.pnlPanelTitulo.Name = "pnlPanelTitulo"
        Me.pnlPanelTitulo.Size = New System.Drawing.Size(689, 50)
        Me.pnlPanelTitulo.TabIndex = 100
        '
        'lbTitulo
        '
        Me.lbTitulo.AutoSize = True
        Me.lbTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTitulo.Location = New System.Drawing.Point(12, 9)
        Me.lbTitulo.Name = "lbTitulo"
        Me.lbTitulo.Size = New System.Drawing.Size(265, 31)
        Me.lbTitulo.TabIndex = 41
        Me.lbTitulo.Text = "Gastos por Periodo"
        '
        'UcNavegador1
        '
        Me.UcNavegador1.AutoSize = True
        Me.UcNavegador1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcNavegador1.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.UcNavegador1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UcNavegador1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcNavegador1.Location = New System.Drawing.Point(0, 210)
        Me.UcNavegador1.MinimumSize = New System.Drawing.Size(0, 56)
        Me.UcNavegador1.Name = "UcNavegador1"
        Me.UcNavegador1.Size = New System.Drawing.Size(689, 60)
        Me.UcNavegador1.TabIndex = 100
        '
        'frGastoPeriodo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(689, 270)
        Me.Controls.Add(Me.UcNavegador1)
        Me.Controls.Add(Me.pnlPanelTitulo)
        Me.Controls.Add(Me.lbCantidad)
        Me.Controls.Add(Me.tbCantidad)
        Me.Controls.Add(Me.tbEmpresa)
        Me.Controls.Add(Me.lbCodigoGasto)
        Me.Controls.Add(Me.cbGasto)
        Me.Controls.Add(Me.lbMes)
        Me.Controls.Add(Me.tbMes)
        Me.Controls.Add(Me.tbGasto)
        Me.Controls.Add(Me.tbEstado1)
        Me.Controls.Add(Me.lbEstado)
        Me.Controls.Add(Me.tbEstado)
        Me.Controls.Add(Me.lbAnio)
        Me.Controls.Add(Me.lbCodigo)
        Me.Controls.Add(Me.tbAnio)
        Me.Controls.Add(Me.tbCodigo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimizeBox = False
        Me.Name = "frGastoPeriodo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Gasto Periodo"
        Me.pnlPanelTitulo.ResumeLayout(False)
        Me.pnlPanelTitulo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbEmpresa As TextBox
    Friend WithEvents lbCodigoGasto As Label
    Friend WithEvents cbGasto As ComboBox
    Friend WithEvents lbMes As Label
    Friend WithEvents tbMes As TextBox
    Friend WithEvents tbGasto As TextBox
    Friend WithEvents tbEstado1 As TextBox
    Friend WithEvents lbEstado As Label
    Friend WithEvents tbEstado As TextBox
    Friend WithEvents lbAnio As Label
    Friend WithEvents lbCodigo As Label
    Friend WithEvents tbAnio As TextBox
    Friend WithEvents tbCodigo As TextBox
    Friend WithEvents lbCantidad As Label
    Friend WithEvents tbCantidad As TextBox
    Friend WithEvents pnlPanelTitulo As Panel
    Friend WithEvents lbTitulo As Label
    Friend WithEvents UcNavegador1 As ucNavegador
End Class
