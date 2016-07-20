<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frReporteador
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frReporteador))
        Me.rvVisor = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.rptOrdenProduccion1 = New MRP.rptOrdenProduccion()
        Me.rptProcesoProduccion1 = New MRP.rptProcesoProduccion()
        Me.rptExistenciaInventarios1 = New MRP.rptExistenciaInventarios()
        Me.SuspendLayout()
        '
        'rvVisor
        '
        Me.rvVisor.ActiveViewIndex = -1
        Me.rvVisor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rvVisor.Cursor = System.Windows.Forms.Cursors.Default
        Me.rvVisor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rvVisor.Location = New System.Drawing.Point(0, 0)
        Me.rvVisor.Name = "rvVisor"
        Me.rvVisor.PrintMode = CrystalDecisions.Windows.Forms.PrintMode.PrintOutputController
        Me.rvVisor.ShowCloseButton = False
        Me.rvVisor.ShowGroupTreeButton = False
        Me.rvVisor.Size = New System.Drawing.Size(784, 561)
        Me.rvVisor.TabIndex = 0
        Me.rvVisor.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frReporteador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.rvVisor)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frReporteador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporteador"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rvVisor As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents rptProcesoProduccion1 As rptProcesoProduccion
    Friend WithEvents rptOrdenProduccion1 As rptOrdenProduccion
    Friend WithEvents rptExistenciaInventarios1 As rptExistenciaInventarios
End Class
