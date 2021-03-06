﻿Public Class frMenuPrincipal
    Dim frFondo As frFondo
    Dim dtVentanas As New DataTable
    Dim tsMenu As ToolStripMenuItem
    Dim tsItem As ToolStripMenuItem
    Dim obObjeto As Object

    Private Sub frMenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            frFondo = New frFondo
            frFondo.MdiParent = Me
            frFondo.Width = ClientSize.Width - 4
            frFondo.Height = ClientSize.Height - (msMenuPrincipal.Height + ssBarraEstado.Height + 4)
            frFondo.Show()
            tsEmpresa.Text = csDatos.Empresa
            tsUsuario.Text = csDatos.NombreUsuario
            tsInicioSesion.Text = Date.Now.ToString("dd/MM/yyyy h:mm tt")
            RestriccionPerfiles()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#Region "Receptores"
    Private Sub frMenuPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            If tsUsuario.Text <> String.Empty Then Application.Exit()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frMenuPrincipal_ClientSizeChanged(sender As Object, e As EventArgs) Handles Me.ClientSizeChanged
        If Not IsNothing(frFondo) Then
            frFondo.Width = ClientSize.Width - 4
            frFondo.Height = ClientSize.Height - (msMenuPrincipal.Height + ssBarraEstado.Height + 4)
        End If
    End Sub

    Private Sub ValidacionFormulario(ByVal NombreFormulario As String, ByRef frm As Form)
        Try
            For Each form As Form In MdiChildren
                If form.Name <> "frFondo" Then
                    form.Visible = False
                    form.Dispose()
                End If
            Next
            frm.MdiParent = Me
            frm.MinimizeBox = False
            frm.MaximizeBox = False
            frm.ControlBox = False
            frm.Show()
            frm.WindowState = FormWindowState.Maximized
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub RestriccionPerfiles()
        Try
            csNegocio.ObtenerVentanas(dtVentanas)
            For i As Integer = 0 To msMenuPrincipal.Items.Count - 1
                tsMenu = CType(msMenuPrincipal.Items(i), ToolStripMenuItem)
                For j As Integer = 0 To tsMenu.DropDownItems.Count - 1
                    obObjeto = tsMenu.DropDownItems(j)
                    If obObjeto.GetType = GetType(ToolStripMenuItem) Then
                        CType(obObjeto, ToolStripMenuItem).Enabled = False
                    End If
                Next
            Next
            For i As Integer = 0 To msMenuPrincipal.Items.Count - 1
                tsMenu = CType(msMenuPrincipal.Items(i), ToolStripMenuItem)
                For j As Integer = 0 To tsMenu.DropDownItems.Count - 1
                    obObjeto = tsMenu.DropDownItems(j)
                    If obObjeto.GetType = GetType(ToolStripMenuItem) Then
                        tsItem = CType(obObjeto, ToolStripMenuItem)
                        If tsItem.Tag.ToString <> "NO" Then
                            For k As Integer = 0 To dtVentanas.Rows.Count - 1
                                If tsItem.Tag.ToString = CStr(dtVentanas.Rows(k)("Ventana")) AndAlso CInt(dtVentanas.Rows(k)("Acceso")) = 1 Then
                                    tsItem.Enabled = True
                                    Exit For
                                End If
                            Next
                        Else
                            tsItem.Enabled = True
                        End If
                    End If
                Next
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "Archivo"
    Private Sub miCambiarEmpresa_Click(sender As Object, e As EventArgs) Handles miCambiarEmpresa.Click
        Try
            csDatos.IdEmpresa = 0
            csDatos.Empresa = String.Empty
            tsUsuario.Text = String.Empty
            Owner.ActiveControl.Focus()
            Owner.Show()
            Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub miCerrarSesion_Click(sender As Object, e As EventArgs) Handles miCerrarSesion.Click
        Try
            csDatos.IdUsuario = 0
            csDatos.Usuario = String.Empty
            csDatos.NombreUsuario = String.Empty
            csDatos.IdEmpresa = 0
            csDatos.Empresa = String.Empty
            tsUsuario.Text = String.Empty
            Owner.Owner.ActiveControl.Focus()
            Owner.Owner.Show()
            Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub miSalir_Click(sender As Object, e As EventArgs) Handles miSalir.Click
        Try
            Application.Exit()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "Catálogos"
    Private Sub miBodegas_Click(sender As Object, e As EventArgs) Handles miBodegas.Click
        Dim frBodega As New frBodega
        ValidacionFormulario("frBodega", frBodega)
    End Sub

    Private Sub miDepartamentos_Click(sender As Object, e As EventArgs) Handles miDepartamentos.Click
        Dim frDepartamento As New frDepartamento
        ValidacionFormulario("frDepartamento", frDepartamento)
    End Sub

    Private Sub miEmpleados_Click(sender As Object, e As EventArgs) Handles miEmpleados.Click
        Dim frEmpleado As New frEmpleado
        ValidacionFormulario("frEmpleado", frEmpleado)
    End Sub

    Private Sub miEmpleadosNomina_Click(sender As Object, e As EventArgs) Handles miEmpleadosNomina.Click
        Dim frEmpleadoNomina As New frEmpleadoNomina
        ValidacionFormulario("frEmpleadoNomina", frEmpleadoNomina)
    End Sub

    Private Sub miGastos_Click(sender As Object, e As EventArgs) Handles miGastos.Click
        Dim frGasto As New frGasto
        ValidacionFormulario("frGasto", frGasto)
    End Sub

    Private Sub miGastosPeriodo_Click(sender As Object, e As EventArgs) Handles miGastosPeriodo.Click
        Dim frGastoPeriodo As New frGastoPeriodo
        ValidacionFormulario("frGastoPeriodo", frGastoPeriodo)
    End Sub

    Private Sub miInventarios_Click(sender As Object, e As EventArgs) Handles miInventarios.Click
        Dim frInventario As New frInventario
        ValidacionFormulario("frInventario", frInventario)
    End Sub

    Private Sub miMedidas_Click(sender As Object, e As EventArgs) Handles miMedidas.Click
        Dim frMedida As New frMedida
        ValidacionFormulario("frMedida", frMedida)
    End Sub

    Private Sub miNominas_Click(sender As Object, e As EventArgs) Handles miNominas.Click
        Dim frNomina As New frNomina
        ValidacionFormulario("frNomina", frNomina)
    End Sub

    Private Sub miPuestos_Click(sender As Object, e As EventArgs) Handles miPuestos.Click
        Dim frPuesto As New frPuesto
        ValidacionFormulario("frPuesto", frPuesto)
    End Sub

    Private Sub miRecetario_Click(sender As Object, e As EventArgs) Handles miRecetario.Click
        Dim frRecetario As New frRecetario
        ValidacionFormulario("frRecetario", frRecetario)
    End Sub

    Private Sub miStatus_Click(sender As Object, e As EventArgs) Handles miStatus.Click
        Dim frStatus As New frStatus
        ValidacionFormulario("frStatus", frStatus)
    End Sub

    Private Sub miTareas_Click(sender As Object, e As EventArgs) Handles miTareas.Click
        Dim frTarea As New frTarea
        ValidacionFormulario("frTarea", frTarea)
    End Sub

    Private Sub miPeriodosNominas_Click(sender As Object, e As EventArgs) Handles miPeriodosNominas.Click
        Dim frNominaPeriodo As New frNominaPeriodo
        ValidacionFormulario("frNominaPeriodo", frNominaPeriodo)
    End Sub

    Private Sub miTiposGastos_Click(sender As Object, e As EventArgs) Handles miTiposGastos.Click
        Dim frGastoTipo As New frGastoTipo
        ValidacionFormulario("frGastoTipo", frGastoTipo)
    End Sub

    Private Sub miTiposInventarios_Click(sender As Object, e As EventArgs) Handles miTiposInventarios.Click
        Dim frInventarioTipo As New frInventarioTipo
        ValidacionFormulario("frInventarioTipo", frInventarioTipo)
    End Sub

    Private Sub miTiposMovimientos_Click(sender As Object, e As EventArgs) Handles miTiposMovimientos.Click
        Dim frMovimientoTipo As New frMovimientoTipo
        ValidacionFormulario("frMovimientoTipo", frMovimientoTipo)
    End Sub

    Private Sub miTiposTareas_Click(sender As Object, e As EventArgs) Handles miTiposTareas.Click
        Dim frTareaTipo As New frTareaTipo
        ValidacionFormulario("frTareaTipo", frTareaTipo)
    End Sub
#End Region

#Region "Procesos"
    Private Sub miMovimientos_Click(sender As Object, e As EventArgs) Handles miMovimientos.Click
        Dim frMovimiento As New frMovimiento
        ValidacionFormulario("frMovimiento", frMovimiento)
    End Sub

    Private Sub miSolicitudes_Click(sender As Object, e As EventArgs) Handles miSolicitudes.Click
        Dim frSolicitud As New frSolicitud
        ValidacionFormulario("frSolicitud", frSolicitud)
    End Sub

    Private Sub miOrdenesProduccion_Click(sender As Object, e As EventArgs) Handles miOrdenesProduccion.Click
        Dim frOrdenProduccion As New frOrdenProduccion
        ValidacionFormulario("frOrdenProduccion", frOrdenProduccion)
    End Sub

    Private Sub miProcesosProduccion_Click(sender As Object, e As EventArgs) Handles miProcesosProduccion.Click
        Dim frProcesoProduccion As New frProcesoProduccion
        ValidacionFormulario("frProcesoProduccion", frProcesoProduccion)
    End Sub
#End Region

#Region "Reportes"
    Private Sub miRExistenciasInventarios_Click(sender As Object, e As EventArgs) Handles miRExistenciasInventarios.Click
        Dim frReporteador As New frReporteador
        frReporteador.ConfigurarReporteador(1)
        frReporteador.ShowDialog()
    End Sub

    Private Sub miROrdenesProduccion_Click(sender As Object, e As EventArgs) Handles miROrdenesProduccion.Click
        Dim frReporteador As New frReporteador
        frReporteador.ConfigurarReporteador(2)
        frReporteador.ShowDialog()
    End Sub

    Private Sub miRProcesosProduccion_Click(sender As Object, e As EventArgs) Handles miRProcesosProduccion.Click
        Dim frReporteador As New frReporteador
        frReporteador.ConfigurarReporteador(3)
        frReporteador.ShowDialog()
    End Sub
#End Region

#Region "Opciones"
    Private Sub miEmpresas_Click(sender As Object, e As EventArgs) Handles miEmpresas.Click
        Dim frEmpresa As New frEmpresa
        ValidacionFormulario("frEmpresa", frEmpresa)
    End Sub

    Private Sub miMonedas_Click(sender As Object, e As EventArgs) Handles miMonedas.Click
        Dim frMoneda As New frMoneda
        ValidacionFormulario("frMoneda", frMoneda)
    End Sub

    Private Sub miPaises_Click(sender As Object, e As EventArgs) Handles miPaises.Click
        Dim frPais As New frPais
        ValidacionFormulario("frPais", frPais)
    End Sub

    Private Sub miPerfiles_Click(sender As Object, e As EventArgs) Handles miPerfiles.Click
        Dim frPerfil As New frPerfil
        ValidacionFormulario("frPerfil", frPerfil)
    End Sub

    Private Sub miUsuarios_Click(sender As Object, e As EventArgs) Handles miUsuarios.Click
        Dim frUsuario As New frUsuario
        ValidacionFormulario("frUsuario", frUsuario)
    End Sub
#End Region

#Region "Ayuda"
    Private Sub miManualTécnico_Click(sender As Object, e As EventArgs) Handles miManualTécnico.Click
        Try
            Process.Start(My.Computer.FileSystem.CurrentDirectory + "\Manual_Tecnico.pdf")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub miManualDeUsuario_Click(sender As Object, e As EventArgs) Handles miManualDeUsuario.Click
        Try
            Process.Start(My.Computer.FileSystem.CurrentDirectory + "\Manual_Usuario.pdf")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub miAcercaDeMRP_Click(sender As Object, e As EventArgs) Handles miAcercaDeMRP.Click
        Try
            Dim frAcercaDeMRP As New frAcercaDeMRP
            frAcercaDeMRP.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
End Class