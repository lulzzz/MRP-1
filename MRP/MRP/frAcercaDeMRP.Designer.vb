<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frAcercaDeMRP
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

    Friend WithEvents lpPanelGeneral As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pbLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lbProducto As System.Windows.Forms.Label
    Friend WithEvents lbVersion As System.Windows.Forms.Label
    Friend WithEvents lbCompania As System.Windows.Forms.Label
    Friend WithEvents tbDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents btAceptar As System.Windows.Forms.Button
    Friend WithEvents lbCopyright As System.Windows.Forms.Label

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frAcercaDeMRP))
        Me.lpPanelGeneral = New System.Windows.Forms.TableLayoutPanel()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.lbProducto = New System.Windows.Forms.Label()
        Me.lbVersion = New System.Windows.Forms.Label()
        Me.lbCopyright = New System.Windows.Forms.Label()
        Me.lbCompania = New System.Windows.Forms.Label()
        Me.tbDescripcion = New System.Windows.Forms.TextBox()
        Me.btAceptar = New System.Windows.Forms.Button()
        Me.lpPanelGeneral.SuspendLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lpPanelGeneral
        '
        Me.lpPanelGeneral.ColumnCount = 2
        Me.lpPanelGeneral.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.lpPanelGeneral.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.0!))
        Me.lpPanelGeneral.Controls.Add(Me.pbLogo, 0, 0)
        Me.lpPanelGeneral.Controls.Add(Me.lbProducto, 1, 0)
        Me.lpPanelGeneral.Controls.Add(Me.lbVersion, 1, 1)
        Me.lpPanelGeneral.Controls.Add(Me.lbCopyright, 1, 2)
        Me.lpPanelGeneral.Controls.Add(Me.lbCompania, 1, 3)
        Me.lpPanelGeneral.Controls.Add(Me.tbDescripcion, 1, 4)
        Me.lpPanelGeneral.Controls.Add(Me.btAceptar, 1, 5)
        Me.lpPanelGeneral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lpPanelGeneral.Location = New System.Drawing.Point(9, 9)
        Me.lpPanelGeneral.Name = "lpPanelGeneral"
        Me.lpPanelGeneral.RowCount = 6
        Me.lpPanelGeneral.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.lpPanelGeneral.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.lpPanelGeneral.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.lpPanelGeneral.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.lpPanelGeneral.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.lpPanelGeneral.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.lpPanelGeneral.Size = New System.Drawing.Size(396, 258)
        Me.lpPanelGeneral.TabIndex = 0
        '
        'pbLogo
        '
        Me.pbLogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbLogo.Image = CType(resources.GetObject("pbLogo.Image"), System.Drawing.Image)
        Me.pbLogo.Location = New System.Drawing.Point(3, 3)
        Me.pbLogo.Name = "pbLogo"
        Me.lpPanelGeneral.SetRowSpan(Me.pbLogo, 6)
        Me.pbLogo.Size = New System.Drawing.Size(124, 252)
        Me.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLogo.TabIndex = 0
        Me.pbLogo.TabStop = False
        '
        'lbProducto
        '
        Me.lbProducto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbProducto.Location = New System.Drawing.Point(136, 0)
        Me.lbProducto.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.lbProducto.MaximumSize = New System.Drawing.Size(0, 17)
        Me.lbProducto.Name = "lbProducto"
        Me.lbProducto.Size = New System.Drawing.Size(257, 17)
        Me.lbProducto.TabIndex = 0
        Me.lbProducto.Text = "MRP"
        Me.lbProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbVersion
        '
        Me.lbVersion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbVersion.Location = New System.Drawing.Point(136, 25)
        Me.lbVersion.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.lbVersion.MaximumSize = New System.Drawing.Size(0, 17)
        Me.lbVersion.Name = "lbVersion"
        Me.lbVersion.Size = New System.Drawing.Size(257, 17)
        Me.lbVersion.TabIndex = 0
        Me.lbVersion.Text = "Versión 0.0.0"
        Me.lbVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbCopyright
        '
        Me.lbCopyright.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbCopyright.Location = New System.Drawing.Point(136, 50)
        Me.lbCopyright.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.lbCopyright.MaximumSize = New System.Drawing.Size(0, 17)
        Me.lbCopyright.Name = "lbCopyright"
        Me.lbCopyright.Size = New System.Drawing.Size(257, 17)
        Me.lbCopyright.TabIndex = 0
        Me.lbCopyright.Text = "Copyright"
        Me.lbCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbCompania
        '
        Me.lbCompania.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbCompania.Location = New System.Drawing.Point(136, 75)
        Me.lbCompania.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.lbCompania.MaximumSize = New System.Drawing.Size(0, 17)
        Me.lbCompania.Name = "lbCompania"
        Me.lbCompania.Size = New System.Drawing.Size(257, 17)
        Me.lbCompania.TabIndex = 0
        Me.lbCompania.Text = "EBRICenter, Inc."
        Me.lbCompania.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbDescripcion
        '
        Me.tbDescripcion.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tbDescripcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbDescripcion.Location = New System.Drawing.Point(136, 103)
        Me.tbDescripcion.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.tbDescripcion.Multiline = True
        Me.tbDescripcion.Name = "tbDescripcion"
        Me.tbDescripcion.ReadOnly = True
        Me.tbDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tbDescripcion.Size = New System.Drawing.Size(257, 123)
        Me.tbDescripcion.TabIndex = 0
        Me.tbDescripcion.TabStop = False
        Me.tbDescripcion.Text = "Desarrolladores:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Anthony Molineros" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Keving Gutiérrez" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Marlon Aldana" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pablo Zap" &
    "paroli"
        '
        'btAceptar
        '
        Me.btAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.btAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btAceptar.Location = New System.Drawing.Point(318, 232)
        Me.btAceptar.Name = "btAceptar"
        Me.btAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btAceptar.TabIndex = 0
        Me.btAceptar.Text = "&Aceptar"
        Me.btAceptar.UseVisualStyleBackColor = False
        '
        'frAcercaDeMRP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.btAceptar
        Me.ClientSize = New System.Drawing.Size(414, 276)
        Me.Controls.Add(Me.lpPanelGeneral)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frAcercaDeMRP"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acerca de MRP"
        Me.lpPanelGeneral.ResumeLayout(False)
        Me.lpPanelGeneral.PerformLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

End Class
