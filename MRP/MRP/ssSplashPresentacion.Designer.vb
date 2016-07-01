<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ssSplashPresentacion
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
    Friend WithEvents lbTitulo As System.Windows.Forms.Label
    Friend WithEvents Version As System.Windows.Forms.Label
    Friend WithEvents Copyright As System.Windows.Forms.Label
    Friend WithEvents lpPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lpPanel2 As System.Windows.Forms.TableLayoutPanel

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ssSplashPresentacion))
        Me.lpPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lpPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Version = New System.Windows.Forms.Label()
        Me.Copyright = New System.Windows.Forms.Label()
        Me.lbTitulo = New System.Windows.Forms.Label()
        Me.lpPanel1.SuspendLayout()
        Me.lpPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lpPanel1
        '
        Me.lpPanel1.BackgroundImage = CType(resources.GetObject("lpPanel1.BackgroundImage"), System.Drawing.Image)
        Me.lpPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.lpPanel1.ColumnCount = 2
        Me.lpPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 243.0!))
        Me.lpPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.lpPanel1.Controls.Add(Me.lpPanel2, 1, 1)
        Me.lpPanel1.Controls.Add(Me.lbTitulo, 1, 0)
        Me.lpPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lpPanel1.Location = New System.Drawing.Point(0, 0)
        Me.lpPanel1.Name = "lpPanel1"
        Me.lpPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 218.0!))
        Me.lpPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.lpPanel1.Size = New System.Drawing.Size(496, 303)
        Me.lpPanel1.TabIndex = 0
        '
        'lpPanel2
        '
        Me.lpPanel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lpPanel2.BackColor = System.Drawing.Color.Transparent
        Me.lpPanel2.ColumnCount = 1
        Me.lpPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 247.0!))
        Me.lpPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142.0!))
        Me.lpPanel2.Controls.Add(Me.Version, 0, 0)
        Me.lpPanel2.Controls.Add(Me.Copyright, 0, 1)
        Me.lpPanel2.Location = New System.Drawing.Point(246, 221)
        Me.lpPanel2.Name = "lpPanel2"
        Me.lpPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.lpPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.lpPanel2.Size = New System.Drawing.Size(247, 79)
        Me.lpPanel2.TabIndex = 1
        '
        'Version
        '
        Me.Version.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Version.BackColor = System.Drawing.Color.Transparent
        Me.Version.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Version.Location = New System.Drawing.Point(3, 9)
        Me.Version.Name = "Version"
        Me.Version.Size = New System.Drawing.Size(241, 20)
        Me.Version.TabIndex = 1
        Me.Version.Text = "Versión 1.0.0"
        '
        'Copyright
        '
        Me.Copyright.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Copyright.BackColor = System.Drawing.Color.Transparent
        Me.Copyright.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Copyright.Location = New System.Drawing.Point(3, 39)
        Me.Copyright.Name = "Copyright"
        Me.Copyright.Size = New System.Drawing.Size(241, 40)
        Me.Copyright.TabIndex = 2
        Me.Copyright.Text = "EBRICenter, Inc."
        '
        'lbTitulo
        '
        Me.lbTitulo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lbTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTitulo.Location = New System.Drawing.Point(246, 3)
        Me.lbTitulo.Name = "lbTitulo"
        Me.lbTitulo.Size = New System.Drawing.Size(247, 212)
        Me.lbTitulo.TabIndex = 0
        Me.lbTitulo.Text = "Manufacturing Resource Planning"
        Me.lbTitulo.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'ssSplashPresentacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 303)
        Me.ControlBox = False
        Me.Controls.Add(Me.lpPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ssSplashPresentacion"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.lpPanel1.ResumeLayout(False)
        Me.lpPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

End Class
