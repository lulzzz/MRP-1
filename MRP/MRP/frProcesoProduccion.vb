Public Class frProcesoProduccion
#Region "Documentación"
    '----------------------------------------------------------------------------------------------------
    'FECHA:         06/07/2016 
    'DESARROLLADOR: Pablo Zapparoli
    'DESCRIPCIÓN:   Proceso de Producción
    '----------------------------------------------------------------------------------------------------
#End Region

    Dim ControlesMaestros As New ArrayList
    Dim ControlesDetalles As New ArrayList
    Dim dtInventarios As New DataTable

    Private Sub frProcesoProduccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ControlesMaestros.Add(tbCodigo)
        ControlesMaestros.Add(tbNombre)
        ControlesMaestros.Add(tbDescripcion)
        ControlesMaestros.Add(tbDestinatario)
        ControlesMaestros.Add(tbFechaSolicitud)
        ControlesMaestros.Add(tbFechaInicio)
        ControlesMaestros.Add(tbFechaFinal)
        ControlesMaestros.Add(tbFechaEntrega)
        ControlesMaestros.Add(tbTotal)
        ControlesMaestros.Add(tbEmpresa)
        ControlesMaestros.Add(tbEstado)
        ControlesDetalles.Add(dgProprodInventario)
        UcNavegador1.ControlesMaestros = ControlesMaestros
        UcNavegador1.ControlesDetalles = ControlesDetalles
        csDatos.ConsultarQuery(dtInventarios, "SELECT id_inventario Value, inv_nombre Display FROM tbl_mrp_inventario a JOIN tbl_mrp_inventario_tipo b ON a.id_inventario_tipo=b.id_inventario_tipo WHERE b.ivt_descripcion LIKE '%prod%terminado%' OR b.ivt_descripcion LIKE '%prod%producido%' AND id_empresa=" + csDatos.IdEmpresa.ToString + " ORDER BY id_inventario ASC")
        Dim cbInventario As New DataGridViewComboBoxColumn With {.HeaderText = "Inventario", .Name = "id_inventario", .Tag = "Combobox"}
        cbInventario.DataSource = dtInventarios
        cbInventario.ValueMember = "Value"
        cbInventario.DisplayMember = "Display"
        dgProprodInventario.Columns.Insert(0, cbInventario)
        UcNavegador1.NombreTabla = "tbl_mrp_proceso_produccion"
        UcNavegador1.QueryBuscar = "SELECT id_proceso_produccion Código, ppd_nombre Nombre, ppd_descripcion Descripción, ppd_destinatario Destinatario, ppd_fecha_solicitud 'Fecha de Solicitud', ppd_fecha_inicio 'Fecha de Inicio', ppd_fecha_final 'Fecha Final', ppd_fecha_entrega 'Fecha de Entrega', ppd_total Total, CASE id_estado WHEN 1 THEN 'Alta' ELSE 'Eliminado' END Estado FROM " + UcNavegador1.NombreTabla + " WHERE id_empresa=" + csDatos.IdEmpresa.ToString + " ORDER BY id_proceso_produccion ASC"
        UcNavegador1.IniciarNavegador()
    End Sub

#Region "Navegador"
    Private Sub Navegador1_posNuevo(sender As Object, e As EventArgs) Handles UcNavegador1.posNuevo
        Try
            csDatos.ConsultarQuery(dtInventarios, "SELECT id_inventario Value, inv_nombre Display FROM tbl_mrp_inventario a JOIN tbl_mrp_inventario_tipo b ON a.id_inventario_tipo=b.id_inventario_tipo WHERE b.ivt_descripcion LIKE '%prod%terminado%' OR b.ivt_descripcion LIKE '%prod%producido%' AND id_empresa=" + csDatos.IdEmpresa.ToString + " ORDER BY id_inventario ASC")
            dgProprodInventario.Refresh()
            tbEmpresa.Text = csDatos.IdEmpresa.ToString
            ActiveControl = tbNombre
            ActiveControl.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Navegador1_preGuardar(sender As Object, e As EventArgs) Handles UcNavegador1.preGuardar
        Try
            UcNavegador1.EjecutarEvento = csNegocio.ValidarControlesMaestros(ControlesMaestros)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UcNavegador1_posGuardar(sender As Object, e As EventArgs) Handles UcNavegador1.posGuardar
        Try
            If csNegocio.ValidarOrdenProduccion(tbCodigo.Text) Then
                If MessageBox.Show("¿Desea generar la orden de producción automáticamente?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    If csNegocio.GenerarOrdenProduccion(tbCodigo.Text) Then
                        MessageBox.Show("Orden de producción generada correctamente")
                    Else
                        MessageBox.Show("Hubo un error al generar la orden de producción")
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Navegador1_preCerrar(sender As Object, e As EventArgs) Handles UcNavegador1.preCerrar
        Try
            Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "Receptores"
    Private Sub tbEstado_TextChanged(sender As Object, e As EventArgs) Handles tbEstado.TextChanged
        Try
            Select Case tbEstado.Text
                Case "1" : tbEstado1.Text = "Alta"
                Case "2" : tbEstado1.Text = "Baja"
                Case "3" : tbEstado1.Text = "Eliminado"
                Case Else : tbEstado1.Text = String.Empty
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dpFechaSolicitud_ValueChanged(sender As Object, e As EventArgs) Handles dpFechaSolicitud.ValueChanged
        tbFechaSolicitud.Text = dpFechaSolicitud.Value.ToString("yyyy/MM/dd")
    End Sub

    Private Sub tbFechaSolicitud_TextChanged(sender As Object, e As EventArgs) Handles tbFechaSolicitud.TextChanged
        If tbFechaSolicitud.Text = String.Empty Then
            dpFechaSolicitud.Value = Date.Now
            tbFechaSolicitud.Text = dpFechaSolicitud.Value.ToString("yyyy/MM/dd")
        Else
            dpFechaSolicitud.Value = CDate(tbFechaSolicitud.Text)
        End If
    End Sub

    Private Sub dpFechaEntrega_ValueChanged(sender As Object, e As EventArgs) Handles dpFechaEntrega.ValueChanged
        tbFechaEntrega.Text = dpFechaEntrega.Value.ToString("yyyy/MM/dd")
    End Sub

    Private Sub tbFechaEntrega_TextChanged(sender As Object, e As EventArgs) Handles tbFechaEntrega.TextChanged
        If tbFechaEntrega.Text = String.Empty Then
            dpFechaEntrega.Value = Date.Now
            tbFechaEntrega.Text = dpFechaEntrega.Value.ToString("yyyy/MM/dd")
        Else
            dpFechaEntrega.Value = CDate(tbFechaEntrega.Text)
        End If
    End Sub

    Private Sub dpFechaInicio_ValueChanged(sender As Object, e As EventArgs) Handles dpFechaInicio.ValueChanged
        tbFechaInicio.Text = dpFechaInicio.Value.ToString("yyyy/MM/dd")
    End Sub

    Private Sub tbFechaInicio_TextChanged(sender As Object, e As EventArgs) Handles tbFechaInicio.TextChanged
        If tbFechaInicio.Text = String.Empty Then
            dpFechaInicio.Value = Date.Now
            tbFechaInicio.Text = dpFechaInicio.Value.ToString("yyyy/MM/dd")
        Else
            dpFechaInicio.Value = CDate(tbFechaInicio.Text)
        End If
    End Sub

    Private Sub dpFechaFinal_ValueChanged(sender As Object, e As EventArgs) Handles dpFechaFinal.ValueChanged
        tbFechaFinal.Text = dpFechaFinal.Value.ToString("yyyy/MM/dd")
    End Sub

    Private Sub tbFechaFinal_TextChanged(sender As Object, e As EventArgs) Handles tbFechaFinal.TextChanged
        If tbFechaFinal.Text = String.Empty Then
            dpFechaFinal.Value = Date.Now
            tbFechaFinal.Text = dpFechaFinal.Value.ToString("yyyy/MM/dd")
        Else
            dpFechaFinal.Value = CDate(tbFechaFinal.Text)
        End If
    End Sub

    Private Sub btAgregarInventario_Click(sender As Object, e As EventArgs) Handles btAgregarInventario.Click
        Try
            dgProprodInventario.Rows.Add()
            dgProprodInventario.CurrentCell = dgProprodInventario.Rows(dgProprodInventario.Rows.Count - 1).Cells(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btEliminarInventario_Click(sender As Object, e As EventArgs) Handles btEliminarInventario.Click
        Try
            If dgProprodInventario.SelectedRows.Count > 0 Then
                If MessageBox.Show("¿Desea eliminar las filas seleccionadas?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    For Each Fila As DataGridViewRow In dgProprodInventario.SelectedRows
                        If Fila.Selected Then
                            dgProprodInventario.Rows.Remove(Fila)
                        End If
                    Next
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
End Class