<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frEmpleadoNomina
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
        Me.pnlPanelTitulo = New System.Windows.Forms.Panel()
        Me.lbTitulo = New System.Windows.Forms.Label()
        Me.tbFechaIngreso = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dpFechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.tbEmpresa = New System.Windows.Forms.TextBox()
        Me.lbCodigoEmpleado = New System.Windows.Forms.Label()
        Me.cbEmpleado = New System.Windows.Forms.ComboBox()
        Me.lbValorHoraOrdinaria = New System.Windows.Forms.Label()
        Me.tbValorHoraOrdinaria = New System.Windows.Forms.TextBox()
        Me.tbEmpleado = New System.Windows.Forms.TextBox()
        Me.tbEstado1 = New System.Windows.Forms.TextBox()
        Me.lbEstado = New System.Windows.Forms.Label()
        Me.tbEstado = New System.Windows.Forms.TextBox()
        Me.lbCodigo = New System.Windows.Forms.Label()
        Me.tbCodigo = New System.Windows.Forms.TextBox()
        Me.UcNavegador1 = New MRP.ucNavegador()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbNomina = New System.Windows.Forms.ComboBox()
        Me.tbNomina = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbDepartamento = New System.Windows.Forms.ComboBox()
        Me.tbDepartamento = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbPuesto = New System.Windows.Forms.ComboBox()
        Me.tbPuesto = New System.Windows.Forms.TextBox()
        Me.lbSalarioOrdinario = New System.Windows.Forms.Label()
        Me.tbSalarioOrdinario = New System.Windows.Forms.TextBox()
        Me.lbValorHoraExtraordinaria = New System.Windows.Forms.Label()
        Me.tbValorHoraExtraordinaria = New System.Windows.Forms.TextBox()
        Me.pnlPanelTitulo.SuspendLayout()
        Me.SuspendLayout()
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
        Me.lbTitulo.Text = "Empleados Nómina"
        '
        'tbFechaIngreso
        '
        Me.tbFechaIngreso.Location = New System.Drawing.Point(281, 204)
        Me.tbFechaIngreso.MaxLength = 100
        Me.tbFechaIngreso.Name = "tbFechaIngreso"
        Me.tbFechaIngreso.Size = New System.Drawing.Size(20, 20)
        Me.tbFechaIngreso.TabIndex = 100
        Me.tbFechaIngreso.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 207)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 117
        Me.Label1.Text = "Fecha de ingreso:"
        '
        'dpFechaIngreso
        '
        Me.dpFechaIngreso.CustomFormat = "dd/MM/yyyy"
        Me.dpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpFechaIngreso.Location = New System.Drawing.Point(125, 204)
        Me.dpFechaIngreso.Name = "dpFechaIngreso"
        Me.dpFechaIngreso.Size = New System.Drawing.Size(150, 20)
        Me.dpFechaIngreso.TabIndex = 6
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
        'lbCodigoEmpleado
        '
        Me.lbCodigoEmpleado.AutoSize = True
        Me.lbCodigoEmpleado.Location = New System.Drawing.Point(12, 99)
        Me.lbCodigoEmpleado.Name = "lbCodigoEmpleado"
        Me.lbCodigoEmpleado.Size = New System.Drawing.Size(57, 13)
        Me.lbCodigoEmpleado.TabIndex = 115
        Me.lbCodigoEmpleado.Text = "Empleado:"
        '
        'cbEmpleado
        '
        Me.cbEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEmpleado.FormattingEnabled = True
        Me.cbEmpleado.Location = New System.Drawing.Point(125, 96)
        Me.cbEmpleado.Name = "cbEmpleado"
        Me.cbEmpleado.Size = New System.Drawing.Size(550, 21)
        Me.cbEmpleado.TabIndex = 2
        '
        'lbValorHoraOrdinaria
        '
        Me.lbValorHoraOrdinaria.AutoSize = True
        Me.lbValorHoraOrdinaria.Location = New System.Drawing.Point(12, 233)
        Me.lbValorHoraOrdinaria.Name = "lbValorHoraOrdinaria"
        Me.lbValorHoraOrdinaria.Size = New System.Drawing.Size(76, 13)
        Me.lbValorHoraOrdinaria.TabIndex = 114
        Me.lbValorHoraOrdinaria.Text = "Valor por hora:"
        '
        'tbValorHoraOrdinaria
        '
        Me.tbValorHoraOrdinaria.Location = New System.Drawing.Point(125, 230)
        Me.tbValorHoraOrdinaria.MaxLength = 256
        Me.tbValorHoraOrdinaria.Name = "tbValorHoraOrdinaria"
        Me.tbValorHoraOrdinaria.Size = New System.Drawing.Size(150, 20)
        Me.tbValorHoraOrdinaria.TabIndex = 8
        '
        'tbEmpleado
        '
        Me.tbEmpleado.Location = New System.Drawing.Point(99, 96)
        Me.tbEmpleado.MaxLength = 100
        Me.tbEmpleado.Name = "tbEmpleado"
        Me.tbEmpleado.Size = New System.Drawing.Size(20, 20)
        Me.tbEmpleado.TabIndex = 100
        Me.tbEmpleado.Visible = False
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
        Me.lbEstado.TabIndex = 112
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
        'lbCodigo
        '
        Me.lbCodigo.AutoSize = True
        Me.lbCodigo.Location = New System.Drawing.Point(12, 73)
        Me.lbCodigo.Name = "lbCodigo"
        Me.lbCodigo.Size = New System.Drawing.Size(43, 13)
        Me.lbCodigo.TabIndex = 111
        Me.lbCodigo.Text = "Código:"
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
        'UcNavegador1
        '
        Me.UcNavegador1.AutoSize = True
        Me.UcNavegador1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcNavegador1.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.UcNavegador1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UcNavegador1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcNavegador1.Location = New System.Drawing.Point(0, 265)
        Me.UcNavegador1.MinimumSize = New System.Drawing.Size(0, 56)
        Me.UcNavegador1.Name = "UcNavegador1"
        Me.UcNavegador1.Size = New System.Drawing.Size(689, 60)
        Me.UcNavegador1.TabIndex = 100
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 122
        Me.Label2.Text = "Nomina:"
        '
        'cbNomina
        '
        Me.cbNomina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNomina.FormattingEnabled = True
        Me.cbNomina.Location = New System.Drawing.Point(125, 123)
        Me.cbNomina.Name = "cbNomina"
        Me.cbNomina.Size = New System.Drawing.Size(550, 21)
        Me.cbNomina.TabIndex = 3
        '
        'tbNomina
        '
        Me.tbNomina.Location = New System.Drawing.Point(99, 123)
        Me.tbNomina.MaxLength = 100
        Me.tbNomina.Name = "tbNomina"
        Me.tbNomina.Size = New System.Drawing.Size(20, 20)
        Me.tbNomina.TabIndex = 100
        Me.tbNomina.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 125
        Me.Label3.Text = "Departamento:"
        '
        'cbDepartamento
        '
        Me.cbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDepartamento.FormattingEnabled = True
        Me.cbDepartamento.Location = New System.Drawing.Point(125, 150)
        Me.cbDepartamento.Name = "cbDepartamento"
        Me.cbDepartamento.Size = New System.Drawing.Size(550, 21)
        Me.cbDepartamento.TabIndex = 4
        '
        'tbDepartamento
        '
        Me.tbDepartamento.Location = New System.Drawing.Point(99, 150)
        Me.tbDepartamento.MaxLength = 100
        Me.tbDepartamento.Name = "tbDepartamento"
        Me.tbDepartamento.Size = New System.Drawing.Size(20, 20)
        Me.tbDepartamento.TabIndex = 100
        Me.tbDepartamento.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 128
        Me.Label4.Text = "Puesto:"
        '
        'cbPuesto
        '
        Me.cbPuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPuesto.FormattingEnabled = True
        Me.cbPuesto.Location = New System.Drawing.Point(125, 177)
        Me.cbPuesto.Name = "cbPuesto"
        Me.cbPuesto.Size = New System.Drawing.Size(550, 21)
        Me.cbPuesto.TabIndex = 5
        '
        'tbPuesto
        '
        Me.tbPuesto.Location = New System.Drawing.Point(99, 177)
        Me.tbPuesto.MaxLength = 100
        Me.tbPuesto.Name = "tbPuesto"
        Me.tbPuesto.Size = New System.Drawing.Size(20, 20)
        Me.tbPuesto.TabIndex = 100
        Me.tbPuesto.Visible = False
        '
        'lbSalarioOrdinario
        '
        Me.lbSalarioOrdinario.AutoSize = True
        Me.lbSalarioOrdinario.Location = New System.Drawing.Point(412, 207)
        Me.lbSalarioOrdinario.Name = "lbSalarioOrdinario"
        Me.lbSalarioOrdinario.Size = New System.Drawing.Size(42, 13)
        Me.lbSalarioOrdinario.TabIndex = 130
        Me.lbSalarioOrdinario.Text = "Salario:"
        '
        'tbSalarioOrdinario
        '
        Me.tbSalarioOrdinario.Location = New System.Drawing.Point(525, 204)
        Me.tbSalarioOrdinario.MaxLength = 256
        Me.tbSalarioOrdinario.Name = "tbSalarioOrdinario"
        Me.tbSalarioOrdinario.Size = New System.Drawing.Size(150, 20)
        Me.tbSalarioOrdinario.TabIndex = 7
        '
        'lbValorHoraExtraordinaria
        '
        Me.lbValorHoraExtraordinaria.AutoSize = True
        Me.lbValorHoraExtraordinaria.Location = New System.Drawing.Point(412, 233)
        Me.lbValorHoraExtraordinaria.Name = "lbValorHoraExtraordinaria"
        Me.lbValorHoraExtraordinaria.Size = New System.Drawing.Size(102, 13)
        Me.lbValorHoraExtraordinaria.TabIndex = 132
        Me.lbValorHoraExtraordinaria.Text = "Valor por hora extra:"
        '
        'tbValorHoraExtraordinaria
        '
        Me.tbValorHoraExtraordinaria.Location = New System.Drawing.Point(525, 230)
        Me.tbValorHoraExtraordinaria.MaxLength = 256
        Me.tbValorHoraExtraordinaria.Name = "tbValorHoraExtraordinaria"
        Me.tbValorHoraExtraordinaria.Size = New System.Drawing.Size(150, 20)
        Me.tbValorHoraExtraordinaria.TabIndex = 9
        '
        'frEmpleadoNomina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 325)
        Me.Controls.Add(Me.lbValorHoraExtraordinaria)
        Me.Controls.Add(Me.tbValorHoraExtraordinaria)
        Me.Controls.Add(Me.lbSalarioOrdinario)
        Me.Controls.Add(Me.tbSalarioOrdinario)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbPuesto)
        Me.Controls.Add(Me.tbPuesto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbDepartamento)
        Me.Controls.Add(Me.tbDepartamento)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbNomina)
        Me.Controls.Add(Me.tbNomina)
        Me.Controls.Add(Me.UcNavegador1)
        Me.Controls.Add(Me.tbFechaIngreso)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dpFechaIngreso)
        Me.Controls.Add(Me.tbEmpresa)
        Me.Controls.Add(Me.lbCodigoEmpleado)
        Me.Controls.Add(Me.cbEmpleado)
        Me.Controls.Add(Me.lbValorHoraOrdinaria)
        Me.Controls.Add(Me.tbValorHoraOrdinaria)
        Me.Controls.Add(Me.tbEmpleado)
        Me.Controls.Add(Me.tbEstado1)
        Me.Controls.Add(Me.lbEstado)
        Me.Controls.Add(Me.tbEstado)
        Me.Controls.Add(Me.lbCodigo)
        Me.Controls.Add(Me.tbCodigo)
        Me.Controls.Add(Me.pnlPanelTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimizeBox = False
        Me.Name = "frEmpleadoNomina"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frEmpleadoNomina"
        Me.pnlPanelTitulo.ResumeLayout(False)
        Me.pnlPanelTitulo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlPanelTitulo As Panel
    Friend WithEvents lbTitulo As Label
    Friend WithEvents tbFechaIngreso As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dpFechaIngreso As DateTimePicker
    Friend WithEvents tbEmpresa As TextBox
    Friend WithEvents lbCodigoEmpleado As Label
    Friend WithEvents cbEmpleado As ComboBox
    Friend WithEvents lbValorHoraOrdinaria As Label
    Friend WithEvents tbValorHoraOrdinaria As TextBox
    Friend WithEvents tbEmpleado As TextBox
    Friend WithEvents tbEstado1 As TextBox
    Friend WithEvents lbEstado As Label
    Friend WithEvents tbEstado As TextBox
    Friend WithEvents lbCodigo As Label
    Friend WithEvents tbCodigo As TextBox
    Friend WithEvents UcNavegador1 As ucNavegador
    Friend WithEvents Label2 As Label
    Friend WithEvents cbNomina As ComboBox
    Friend WithEvents tbNomina As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbDepartamento As ComboBox
    Friend WithEvents tbDepartamento As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbPuesto As ComboBox
    Friend WithEvents tbPuesto As TextBox
    Friend WithEvents lbSalarioOrdinario As Label
    Friend WithEvents tbSalarioOrdinario As TextBox
    Friend WithEvents lbValorHoraExtraordinaria As Label
    Friend WithEvents tbValorHoraExtraordinaria As TextBox
End Class
