<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frMenuPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frMenuPrincipal))
        Me.msMenuPrincipal = New System.Windows.Forms.MenuStrip()
        Me.tsArchivo = New System.Windows.Forms.ToolStripMenuItem()
        Me.miCambiarEmpresa = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsSeparador1 = New System.Windows.Forms.ToolStripSeparator()
        Me.miCerrarSesion = New System.Windows.Forms.ToolStripMenuItem()
        Me.miSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsCatalogos = New System.Windows.Forms.ToolStripMenuItem()
        Me.miBodegas = New System.Windows.Forms.ToolStripMenuItem()
        Me.miDepartamentos = New System.Windows.Forms.ToolStripMenuItem()
        Me.miEmpleados = New System.Windows.Forms.ToolStripMenuItem()
        Me.miEmpleadosNomina = New System.Windows.Forms.ToolStripMenuItem()
        Me.miGastos = New System.Windows.Forms.ToolStripMenuItem()
        Me.miGastosPeriodo = New System.Windows.Forms.ToolStripMenuItem()
        Me.miInventarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.miMedidas = New System.Windows.Forms.ToolStripMenuItem()
        Me.miNominas = New System.Windows.Forms.ToolStripMenuItem()
        Me.miPuestos = New System.Windows.Forms.ToolStripMenuItem()
        Me.miRecetario = New System.Windows.Forms.ToolStripMenuItem()
        Me.miStatus = New System.Windows.Forms.ToolStripMenuItem()
        Me.miTareas = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsSeparador2 = New System.Windows.Forms.ToolStripSeparator()
        Me.miPeriodosNominas = New System.Windows.Forms.ToolStripMenuItem()
        Me.miTiposGastos = New System.Windows.Forms.ToolStripMenuItem()
        Me.miTiposInventarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.miTiposMovimientos = New System.Windows.Forms.ToolStripMenuItem()
        Me.miTiposTareas = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsProcesos = New System.Windows.Forms.ToolStripMenuItem()
        Me.miMovimientos = New System.Windows.Forms.ToolStripMenuItem()
        Me.miSolicitudes = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsSeparador3 = New System.Windows.Forms.ToolStripSeparator()
        Me.miOrdenesProduccion = New System.Windows.Forms.ToolStripMenuItem()
        Me.miProcesosProduccion = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsReportes = New System.Windows.Forms.ToolStripMenuItem()
        Me.miRExistenciasInventarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.miROrdenesProduccion = New System.Windows.Forms.ToolStripMenuItem()
        Me.miRProcesosProduccion = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsOpciones = New System.Windows.Forms.ToolStripMenuItem()
        Me.miEmpresas = New System.Windows.Forms.ToolStripMenuItem()
        Me.miMonedas = New System.Windows.Forms.ToolStripMenuItem()
        Me.miPaises = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsSeparador4 = New System.Windows.Forms.ToolStripSeparator()
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
        Me.msMenuPrincipal.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.msMenuPrincipal.GripMargin = New System.Windows.Forms.Padding(2)
        Me.msMenuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsArchivo, Me.tsCatalogos, Me.tsProcesos, Me.tsReportes, Me.tsOpciones, Me.tsAyuda})
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
        Me.miCambiarEmpresa.Text = "Cambiar &Empresa"
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
        'tsCatalogos
        '
        Me.tsCatalogos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miBodegas, Me.miDepartamentos, Me.miEmpleados, Me.miEmpleadosNomina, Me.miGastos, Me.miGastosPeriodo, Me.miInventarios, Me.miMedidas, Me.miNominas, Me.miPuestos, Me.miRecetario, Me.miStatus, Me.miTareas, Me.tsSeparador2, Me.miPeriodosNominas, Me.miTiposGastos, Me.miTiposInventarios, Me.miTiposMovimientos, Me.miTiposTareas})
        Me.tsCatalogos.Name = "tsCatalogos"
        Me.tsCatalogos.Size = New System.Drawing.Size(72, 20)
        Me.tsCatalogos.Text = "&Catálogos"
        '
        'miBodegas
        '
        Me.miBodegas.Name = "miBodegas"
        Me.miBodegas.Size = New System.Drawing.Size(192, 22)
        Me.miBodegas.Text = "&Bodegas"
        '
        'miDepartamentos
        '
        Me.miDepartamentos.Name = "miDepartamentos"
        Me.miDepartamentos.Size = New System.Drawing.Size(192, 22)
        Me.miDepartamentos.Text = "&Departamentos"
        '
        'miEmpleados
        '
        Me.miEmpleados.Name = "miEmpleados"
        Me.miEmpleados.Size = New System.Drawing.Size(192, 22)
        Me.miEmpleados.Text = "&Empleados"
        '
        'miEmpleadosNomina
        '
        Me.miEmpleadosNomina.Name = "miEmpleadosNomina"
        Me.miEmpleadosNomina.Size = New System.Drawing.Size(192, 22)
        Me.miEmpleadosNomina.Text = "Empleados Nómina"
        '
        'miGastos
        '
        Me.miGastos.Name = "miGastos"
        Me.miGastos.Size = New System.Drawing.Size(192, 22)
        Me.miGastos.Text = "&Gastos"
        '
        'miGastosPeriodo
        '
        Me.miGastosPeriodo.Name = "miGastosPeriodo"
        Me.miGastosPeriodo.Size = New System.Drawing.Size(192, 22)
        Me.miGastosPeriodo.Text = "G&astos por Periodo"
        '
        'miInventarios
        '
        Me.miInventarios.Name = "miInventarios"
        Me.miInventarios.Size = New System.Drawing.Size(192, 22)
        Me.miInventarios.Text = "&Inventarios"
        '
        'miMedidas
        '
        Me.miMedidas.Name = "miMedidas"
        Me.miMedidas.Size = New System.Drawing.Size(192, 22)
        Me.miMedidas.Text = "&Medidas"
        '
        'miNominas
        '
        Me.miNominas.Name = "miNominas"
        Me.miNominas.Size = New System.Drawing.Size(192, 22)
        Me.miNominas.Text = "&Nómina"
        '
        'miPuestos
        '
        Me.miPuestos.Name = "miPuestos"
        Me.miPuestos.Size = New System.Drawing.Size(192, 22)
        Me.miPuestos.Text = "&Puestos"
        '
        'miRecetario
        '
        Me.miRecetario.Name = "miRecetario"
        Me.miRecetario.Size = New System.Drawing.Size(192, 22)
        Me.miRecetario.Text = "&Recetario"
        '
        'miStatus
        '
        Me.miStatus.Name = "miStatus"
        Me.miStatus.Size = New System.Drawing.Size(192, 22)
        Me.miStatus.Text = "&Status"
        '
        'miTareas
        '
        Me.miTareas.Name = "miTareas"
        Me.miTareas.Size = New System.Drawing.Size(192, 22)
        Me.miTareas.Text = "&Tareas"
        '
        'tsSeparador2
        '
        Me.tsSeparador2.Name = "tsSeparador2"
        Me.tsSeparador2.Size = New System.Drawing.Size(189, 6)
        '
        'miPeriodosNominas
        '
        Me.miPeriodosNominas.Name = "miPeriodosNominas"
        Me.miPeriodosNominas.Size = New System.Drawing.Size(192, 22)
        Me.miPeriodosNominas.Text = "Periodos de Nóminas"
        '
        'miTiposGastos
        '
        Me.miTiposGastos.Name = "miTiposGastos"
        Me.miTiposGastos.Size = New System.Drawing.Size(192, 22)
        Me.miTiposGastos.Text = "Tipos de Gastos"
        '
        'miTiposInventarios
        '
        Me.miTiposInventarios.Name = "miTiposInventarios"
        Me.miTiposInventarios.Size = New System.Drawing.Size(192, 22)
        Me.miTiposInventarios.Text = "Tipos de Inventarios"
        '
        'miTiposMovimientos
        '
        Me.miTiposMovimientos.Name = "miTiposMovimientos"
        Me.miTiposMovimientos.Size = New System.Drawing.Size(192, 22)
        Me.miTiposMovimientos.Text = "Tipos de Movimientos"
        '
        'miTiposTareas
        '
        Me.miTiposTareas.Name = "miTiposTareas"
        Me.miTiposTareas.Size = New System.Drawing.Size(192, 22)
        Me.miTiposTareas.Text = "Tipos de Tareas"
        '
        'tsProcesos
        '
        Me.tsProcesos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miMovimientos, Me.miSolicitudes, Me.tsSeparador3, Me.miOrdenesProduccion, Me.miProcesosProduccion})
        Me.tsProcesos.Name = "tsProcesos"
        Me.tsProcesos.Size = New System.Drawing.Size(66, 20)
        Me.tsProcesos.Text = "&Procesos"
        '
        'miMovimientos
        '
        Me.miMovimientos.Name = "miMovimientos"
        Me.miMovimientos.Size = New System.Drawing.Size(201, 22)
        Me.miMovimientos.Text = "&Movimientos"
        '
        'miSolicitudes
        '
        Me.miSolicitudes.Name = "miSolicitudes"
        Me.miSolicitudes.Size = New System.Drawing.Size(201, 22)
        Me.miSolicitudes.Text = "&Solicitudes"
        '
        'tsSeparador3
        '
        Me.tsSeparador3.Name = "tsSeparador3"
        Me.tsSeparador3.Size = New System.Drawing.Size(198, 6)
        '
        'miOrdenesProduccion
        '
        Me.miOrdenesProduccion.Name = "miOrdenesProduccion"
        Me.miOrdenesProduccion.Size = New System.Drawing.Size(201, 22)
        Me.miOrdenesProduccion.Text = "&Órdenes de Producción"
        '
        'miProcesosProduccion
        '
        Me.miProcesosProduccion.Name = "miProcesosProduccion"
        Me.miProcesosProduccion.Size = New System.Drawing.Size(201, 22)
        Me.miProcesosProduccion.Text = "&Procesos de Producción"
        '
        'tsReportes
        '
        Me.tsReportes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miRExistenciasInventarios, Me.miROrdenesProduccion, Me.miRProcesosProduccion})
        Me.tsReportes.Name = "tsReportes"
        Me.tsReportes.Size = New System.Drawing.Size(65, 20)
        Me.tsReportes.Text = "&Reportes"
        '
        'miRExistenciasInventarios
        '
        Me.miRExistenciasInventarios.Name = "miRExistenciasInventarios"
        Me.miRExistenciasInventarios.Size = New System.Drawing.Size(207, 22)
        Me.miRExistenciasInventarios.Text = "Existencias de Inventarios"
        '
        'miROrdenesProduccion
        '
        Me.miROrdenesProduccion.Name = "miROrdenesProduccion"
        Me.miROrdenesProduccion.Size = New System.Drawing.Size(207, 22)
        Me.miROrdenesProduccion.Text = "Órdenes de Producción"
        '
        'miRProcesosProduccion
        '
        Me.miRProcesosProduccion.Name = "miRProcesosProduccion"
        Me.miRProcesosProduccion.Size = New System.Drawing.Size(207, 22)
        Me.miRProcesosProduccion.Text = "Procesos de Producción"
        '
        'tsOpciones
        '
        Me.tsOpciones.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miEmpresas, Me.miMonedas, Me.miPaises, Me.tsSeparador4, Me.miUsuarios})
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
        'tsSeparador4
        '
        Me.tsSeparador4.Name = "tsSeparador4"
        Me.tsSeparador4.Size = New System.Drawing.Size(121, 6)
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
        Me.ssBarraEstado.BackColor = System.Drawing.SystemColors.ButtonHighlight
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
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
    Friend WithEvents tsCatalogos As ToolStripMenuItem
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
    Friend WithEvents tsSeparador4 As ToolStripSeparator
    Friend WithEvents miUsuarios As ToolStripMenuItem
    Friend WithEvents miTiposMovimientos As ToolStripMenuItem
    Friend WithEvents miBodegas As ToolStripMenuItem
    Friend WithEvents miStatus As ToolStripMenuItem
    Friend WithEvents miTiposInventarios As ToolStripMenuItem
    Friend WithEvents miInventarios As ToolStripMenuItem
    Friend WithEvents miMedidas As ToolStripMenuItem
    Friend WithEvents miTareas As ToolStripMenuItem
    Friend WithEvents miRecetario As ToolStripMenuItem
    Friend WithEvents miTiposTareas As ToolStripMenuItem
    Friend WithEvents miSolicitudes As ToolStripMenuItem
    Friend WithEvents miOrdenesProduccion As ToolStripMenuItem
    Friend WithEvents tsSeparador2 As ToolStripSeparator
    Friend WithEvents miMovimientos As ToolStripMenuItem
    Friend WithEvents tsSeparador3 As ToolStripSeparator
    Friend WithEvents miDepartamentos As ToolStripMenuItem
    Friend WithEvents miEmpleados As ToolStripMenuItem
    Friend WithEvents miEmpleadosNomina As ToolStripMenuItem
    Friend WithEvents miNominas As ToolStripMenuItem
    Friend WithEvents miPeriodosNominas As ToolStripMenuItem
    Friend WithEvents miPuestos As ToolStripMenuItem
    Friend WithEvents miGastos As ToolStripMenuItem
    Friend WithEvents miProcesosProduccion As ToolStripMenuItem
    Friend WithEvents miRExistenciasInventarios As ToolStripMenuItem
    Friend WithEvents miROrdenesProduccion As ToolStripMenuItem
    Friend WithEvents miRProcesosProduccion As ToolStripMenuItem
    Friend WithEvents miTiposGastos As ToolStripMenuItem
    Friend WithEvents miGastosPeriodo As ToolStripMenuItem
End Class
