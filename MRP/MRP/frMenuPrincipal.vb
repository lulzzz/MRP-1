Public Class frMenuPrincipal
    Dim frFondo As frFondo

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
            If csDatos.NombreUsuario.ToUpper = "ADMINISTRADOR" Then
                tsOpciones.Visible = True
            Else
                tsOpciones.Visible = False
            End If
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
            Dim frmValidacion As New Form
            frmValidacion = Application.OpenForms.OfType(Of Form)().Where(Function(pre) pre.Name = NombreFormulario).SingleOrDefault()
            If IsNothing(frmValidacion) Then
                frm.MdiParent = Me
                frm.Show()
            Else
                frm.Dispose()
                frmValidacion.Activate()
            End If
        Catch ex As Exception
            Throw ex
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

    Private Sub miClasificacionInventarios_Click(sender As Object, e As EventArgs) Handles miClasificacionInventarios.Click
        Dim frInventarioClasificacion As New frInventarioClasificacion
        ValidacionFormulario("frInventarioClasificación", frInventarioClasificacion)
    End Sub

    Private Sub miInventarios_Click(sender As Object, e As EventArgs) Handles miInventarios.Click
        Dim frInventario As New frInventario
        ValidacionFormulario("frInventario", frInventario)
    End Sub

    Private Sub miMedidas_Click(sender As Object, e As EventArgs) Handles miMedidas.Click
        Dim frMedida As New frMedida
        ValidacionFormulario("frMedida", frMedida)
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

    Private Sub miTiposMovimientos_Click(sender As Object, e As EventArgs) Handles miTiposMovimientos.Click
        Dim frMovimientoTipo As New frMovimientoTipo
        ValidacionFormulario("frMovimientoTipo", frMovimientoTipo)
    End Sub

    Private Sub miTiposTareas_Click(sender As Object, e As EventArgs) Handles miTiposTareas.Click
        Dim frTareaTipo As New frTareaTipo
        ValidacionFormulario("frTareaTipo", frTareaTipo)
    End Sub

    Private Sub miDepartamento_Click(sender As Object, e As EventArgs) Handles miDepartamento.Click
        Dim frDepartamento As New frDepartamento
        ValidacionFormulario("frDepartamento", frDepartamento)
    End Sub

    Private Sub miEmpleado_Click(sender As Object, e As EventArgs) Handles miEmpleado.Click
        Dim frEmpleado As New frEmpleado
        ValidacionFormulario("frEmpleado", frEmpleado)
    End Sub

    Private Sub miEmpleadoNomina_Click(sender As Object, e As EventArgs) Handles miEmpleadoNomina.Click
        Dim frEmpleadoNomina As New frEmpleadoNomina
        ValidacionFormulario("frEmpleadoNomina", frEmpleadoNomina)
    End Sub

    Private Sub miGastos_Click(sender As Object, e As EventArgs) Handles miGastos.Click
        Dim frGasto As New frGasto
        ValidacionFormulario("frGasto", frGasto)
    End Sub

    Private Sub miNomina_Click(sender As Object, e As EventArgs) Handles miNomina.Click
        Dim frNomina As New frNomina
        ValidacionFormulario("frNomina", frNomina)
    End Sub

    Private Sub miNominaPeriodo_Click(sender As Object, e As EventArgs) Handles miNominaPeriodo.Click
        Dim frNominaPeriodo As New frNominaPeriodo
        ValidacionFormulario("frNominaPeriodo", frNominaPeriodo)
    End Sub

    Private Sub miPuesto_Click(sender As Object, e As EventArgs) Handles miPuesto.Click
        Dim frPuesto As New frPuesto
        ValidacionFormulario("frPuesto", frPuesto)
    End Sub
#End Region

#Region "Procesos"
    Private Sub miMovimientos_Click(sender As Object, e As EventArgs) Handles miMovimientos.Click

    End Sub

    Private Sub miOrdenesProduccion_Click(sender As Object, e As EventArgs) Handles miOrdenesProduccion.Click

    End Sub

    Private Sub miSolicitudes_Click(sender As Object, e As EventArgs) Handles miSolicitudes.Click

    End Sub

    Private Sub miProcesoProduccion_Click(sender As Object, e As EventArgs) Handles miProcesoProduccion.Click
        Dim frProcesoProduccion As New frProcesoProduccion
        ValidacionFormulario("frProcesoProduccion", frProcesoProduccion)
    End Sub
#End Region

#Region "Reportes"

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

    Private Sub miUsuarios_Click(sender As Object, e As EventArgs) Handles miUsuarios.Click
        Dim frUsuario As New frUsuario
        ValidacionFormulario("frUsuario", frUsuario)
    End Sub
#End Region

#Region "Ayuda"
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