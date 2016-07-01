<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frMenuPrincipal
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
        Me.msMenuPrincipal = New System.Windows.Forms.MenuStrip()
        Me.tsArchivo = New System.Windows.Forms.ToolStripMenuItem()
        Me.miCambiarEmpresa = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsSeparador1 = New System.Windows.Forms.ToolStripSeparator()
        Me.miCerrarSesion = New System.Windows.Forms.ToolStripMenuItem()
        Me.miSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsCatálogos = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsProcesos = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsReportes = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsOpciones = New System.Windows.Forms.ToolStripMenuItem()
        Me.miEmpresas = New System.Windows.Forms.ToolStripMenuItem()
        Me.miMonedas = New System.Windows.Forms.ToolStripMenuItem()
        Me.miPaises = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsSeparador2 = New System.Windows.Forms.ToolStripSeparator()
        Me.miUsuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsAyuda = New System.Windows.Forms.ToolStripMenuItem()
        Me.miAcercaDeMRP = New System.Windows.Forms.ToolStripMenuItem()
        Me.ssBarraEstado = New System.Windows.Forms.StatusStrip()
        Me.slEmpresa = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsEmpresa = New System.Windows.Forms.ToolStripStatusLabel()
        Me.slUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.slInicioSesion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsInicioSesion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.msMenuPrincipal.SuspendLayout()
        Me.ssBarraEstado.SuspendLayout()
        Me.SuspendLayout()
        '
        'msMenuPrincipal
        '
        Me.msMenuPrincipal.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.msMenuPrincipal.GripMargin = New System.Windows.Forms.Padding(2)
        Me.msMenuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsArchivo, Me.tsCatálogos, Me.tsProcesos, Me.tsReportes, Me.tsOpciones, Me.tsAyuda})
        Me.msMenuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.msMenuPrincipal.Name = "msMenuPrincipal"
        Me.msMenuPrincipal.Size = New System.Drawing.Size(784, 24)
        Me.msMenuPrincipal.TabIndex = 5
        Me.msMenuPrincipal.Text = "MenuStrip"
        '
        'tsArchivo
        '
        Me.tsArchivo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miCambiarEmpresa, Me.tsSeparador1, Me.miCerrarSesion, Me.miSalir})
        Me.tsArchivo.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.tsArchivo.Name = "tsArchivo"
        Me.tsArchivo.Size = New System.Drawing.Size(60, 20)
        Me.tsArchivo.Text = "&Archivo"
        '
        'miCambiarEmpresa
        '
        Me.miCambiarEmpresa.Name = "miCambiarEmpresa"
        Me.miCambiarEmpresa.Size = New System.Drawing.Size(167, 22)
        Me.miCambiarEmpresa.Text = "Cambiar Empresa"
        '
        'tsSeparador1
        '
        Me.tsSeparador1.Name = "tsSeparador1"
        Me.tsSeparador1.Size = New System.Drawing.Size(164, 6)
        '
        'miCerrarSesion
        '
        Me.miCerrarSesion.Name = "miCerrarSesion"
        Me.miCerrarSesion.Size = New System.Drawing.Size(167, 22)
        Me.miCerrarSesion.Text = "&Cerrar Sesión"
        '
        'miSalir
        '
        Me.miSalir.Name = "miSalir"
        Me.miSalir.Size = New System.Drawing.Size(167, 22)
        Me.miSalir.Text = "&Salir"
        '
        'tsCatálogos
        '
        Me.tsCatálogos.Name = "tsCatálogos"
        Me.tsCatálogos.Size = New System.Drawing.Size(72, 20)
        Me.tsCatálogos.Text = "&Catálogos"
        '
        'tsProcesos
        '
        Me.tsProcesos.Name = "tsProcesos"
        Me.tsProcesos.Size = New System.Drawing.Size(66, 20)
        Me.tsProcesos.Text = "&Procesos"
        '
        'tsReportes
        '
        Me.tsReportes.Name = "tsReportes"
        Me.tsReportes.Size = New System.Drawing.Size(65, 20)
        Me.tsReportes.Text = "&Reportes"
        '
        'tsOpciones
        '
        Me.tsOpciones.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miEmpresas, Me.miMonedas, Me.miPaises, Me.tsSeparador2, Me.miUsuarios})
        Me.tsOpciones.Name = "tsOpciones"
        Me.tsOpciones.Size = New System.Drawing.Size(69, 20)
        Me.tsOpciones.Text = "&Opciones"
        '
        'miEmpresas
        '
        Me.miEmpresas.Name = "miEmpresas"
        Me.miEmpresas.Size = New System.Drawing.Size(124, 22)
        Me.miEmpresas.Text = "&Empresas"
        '
        'miMonedas
        '
        Me.miMonedas.Name = "miMonedas"
        Me.miMonedas.Size = New System.Drawing.Size(124, 22)
        Me.miMonedas.Text = "&Monedas"
        '
        'miPaises
        '
        Me.miPaises.Name = "miPaises"
        Me.miPaises.Size = New System.Drawing.Size(124, 22)
        Me.miPaises.Text = "&Países"
        '
        'tsSeparador2
        '
        Me.tsSeparador2.Name = "tsSeparador2"
        Me.tsSeparador2.Size = New System.Drawing.Size(121, 6)
        '
        'miUsuarios
        '
        Me.miUsuarios.Name = "miUsuarios"
        Me.miUsuarios.Size = New System.Drawing.Size(124, 22)
        Me.miUsuarios.Text = "&Usuarios"
        '
        'tsAyuda
        '
        Me.tsAyuda.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miAcercaDeMRP})
        Me.tsAyuda.Name = "tsAyuda"
        Me.tsAyuda.Size = New System.Drawing.Size(53, 20)
        Me.tsAyuda.Text = "Ay&uda"
        '
        'miAcercaDeMRP
        '
        Me.miAcercaDeMRP.Name = "miAcercaDeMRP"
        Me.miAcercaDeMRP.Size = New System.Drawing.Size(154, 22)
        Me.miAcercaDeMRP.Text = "&Acerca de MRP"
        '
        'ssBarraEstado
        '
        Me.ssBarraEstado.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ssBarraEstado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.slEmpresa, Me.tsEmpresa, Me.slUsuario, Me.tsUsuario, Me.slInicioSesion, Me.tsInicioSesion})
        Me.ssBarraEstado.Location = New System.Drawing.Point(0, 539)
        Me.ssBarraEstado.Name = "ssBarraEstado"
        Me.ssBarraEstado.Size = New System.Drawing.Size(784, 22)
        Me.ssBarraEstado.SizingGrip = False
        Me.ssBarraEstado.TabIndex = 9
        Me.ssBarraEstado.Text = "StatusStrip1"
        '
        'slEmpresa
        '
        Me.slEmpresa.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.slEmpresa.Name = "slEmpresa"
        Me.slEmpresa.Size = New System.Drawing.Size(57, 17)
        Me.slEmpresa.Text = "Empresa:"
        '
        'tsEmpresa
        '
        Me.tsEmpresa.Name = "tsEmpresa"
        Me.tsEmpresa.Size = New System.Drawing.Size(188, 17)
        Me.tsEmpresa.Spring = True
        Me.tsEmpresa.Text = "Empresa"
        Me.tsEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'slUsuario
        '
        Me.slUsuario.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.slUsuario.Name = "slUsuario"
        Me.slUsuario.Size = New System.Drawing.Size(52, 17)
        Me.slUsuario.Text = "Usuario:"
        '
        'tsUsuario
        '
        Me.tsUsuario.Name = "tsUsuario"
        Me.tsUsuario.Size = New System.Drawing.Size(188, 17)
        Me.tsUsuario.Spring = True
        Me.tsUsuario.Text = "Usuario"
        Me.tsUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'slInicioSesion
        '
        Me.slInicioSesion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.slInicioSesion.Name = "slInicioSesion"
        Me.slInicioSesion.Size = New System.Drawing.Size(96, 17)
        Me.slInicioSesion.Text = "Inicio de Sesión:"
        '
        'tsInicioSesion
        '
        Me.tsInicioSesion.Name = "tsInicioSesion"
        Me.tsInicioSesion.Size = New System.Drawing.Size(188, 17)
        Me.tsInicioSesion.Spring = True
        Me.tsInicioSesion.Text = "InicioSesion"
        Me.tsInicioSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.ssBarraEstado)
        Me.Controls.Add(Me.msMenuPrincipal)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.msMenuPrincipal
        Me.Name = "frMenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MRP - Menú Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.msMenuPrincipal.ResumeLayout(False)
        Me.msMenuPrincipal.PerformLayout()
        Me.ssBarraEstado.ResumeLayout(False)
        Me.ssBarraEstado.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsAyuda As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miAcercaDeMRP As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsArchivo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents msMenuPrincipal As System.Windows.Forms.MenuStrip
    Friend WithEvents tsCatálogos As ToolStripMenuItem
    Friend WithEvents tsProcesos As ToolStripMenuItem
    Friend WithEvents tsReportes As ToolStripMenuItem
    Friend WithEvents tsSeparador1 As ToolStripSeparator
    Friend WithEvents miCerrarSesion As ToolStripMenuItem
    Friend WithEvents miCambiarEmpresa As ToolStripMenuItem
    Friend WithEvents ssBarraEstado As StatusStrip
    Friend WithEvents slUsuario As ToolStripStatusLabel
    Friend WithEvents tsUsuario As ToolStripStatusLabel
    Friend WithEvents slInicioSesion As ToolStripStatusLabel
    Friend WithEvents slEmpresa As ToolStripStatusLabel
    Friend WithEvents tsEmpresa As ToolStripStatusLabel
    Friend WithEvents tsInicioSesion As ToolStripStatusLabel
    Friend WithEvents tsOpciones As ToolStripMenuItem
    Friend WithEvents miEmpresas As ToolStripMenuItem
    Friend WithEvents miMonedas As ToolStripMenuItem
    Friend WithEvents miPaises As ToolStripMenuItem
    Friend WithEvents tsSeparador2 As ToolStripSeparator
    Friend WithEvents miUsuarios As ToolStripMenuItem
End Class
