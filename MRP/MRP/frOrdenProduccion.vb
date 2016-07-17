Public Class frOrdenProduccion
#Region "Documentación"
    '----------------------------------------------------------------------------------------------------
    'FECHA:         12/07/2016
    'DESARROLLADOR: Anthony Molineros
    'DESCRIPCIÓN:   Proceso de Órdenes de Producción
    '----------------------------------------------------------------------------------------------------
#End Region

    Dim ControlesMaestros As New ArrayList
    Dim ControlesDetalles As New ArrayList
    Dim dtProcesosProduccion As New DataTable
    Dim dtInventarios As New DataTable
    Dim dtRecetarios As New DataTable
    Dim dtStatus As New DataTable

    Private Sub frOrdenProduccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        csNegocio.CargarCombobox(cbProcesoProduccion, dtProcesosProduccion, "SELECT id_proceso_produccion Value, ppd_nombre Display FROM tbl_mrp_proceso_produccion ORDER BY id_proceso_produccion ASC")
        csNegocio.CargarCombobox(cbStatus, dtStatus, "SELECT id_status Value, sts_descripcion Display FROM tbl_mrp_status ORDER BY id_status ASC")
        ControlesMaestros.Add(tbCodigo)
        ControlesMaestros.Add(tbFecha)
        ControlesMaestros.Add(tbProcesoProduccion)
        ControlesMaestros.Add(tbStatus)
        ControlesMaestros.Add(tbEmpresa)
        ControlesMaestros.Add(tbEstado)
        ControlesDetalles.Add(dgOrdprodInventario)
        UcNavegador1.ControlesMaestros = ControlesMaestros
        UcNavegador1.ControlesDetalles = ControlesDetalles
        csDatos.ConsultarQuery(dtInventarios, "SELECT id_inventario Value, inv_nombre Display FROM tbl_mrp_inventario a JOIN tbl_mrp_inventario_tipo b ON a.id_inventario_tipo=b.id_inventario_tipo WHERE b.ivt_descripcion LIKE '%prod%terminado%' OR b.ivt_descripcion LIKE '%prod%producido%' ORDER BY id_inventario ASC")
        Dim cbInventario As New DataGridViewComboBoxColumn With {.HeaderText = "Inventario", .Name = "id_inventario", .Tag = "Combobox"}
        cbInventario.DataSource = dtInventarios
        cbInventario.ValueMember = "Value"
        cbInventario.DisplayMember = "Display"
        dgOrdprodInventario.Columns.Insert(0, cbInventario)
        csDatos.ConsultarQuery(dtRecetarios, "SELECT id_recetario Value, rct_descripcion Display FROM tbl_mrp_recetario ORDER BY id_recetario ASC")
        Dim cbRecetario As New DataGridViewComboBoxColumn With {.HeaderText = "Recetario", .Name = "id_recetario", .Tag = "Combobox"}
        cbRecetario.DataSource = dtInventarios
        cbRecetario.ValueMember = "Value"
        cbRecetario.DisplayMember = "Display"
        dgOrdprodInventario.Columns.Insert(1, cbRecetario)
        UcNavegador1.NombreTabla = "tbl_mrp_orden_produccion"
        UcNavegador1.QueryBuscar = "SELECT id_orden_produccion Código, ppd_nombre 'Proceso de Producción', orp_fecha Fecha, sts_descripcion 'Status', CASE a.id_estado WHEN 1 THEN 'Alta' ELSE 'Eliminado' END Estado FROM " + UcNavegador1.NombreTabla + " a JOIN tbl_mrp_proceso_produccion b ON a.id_proceso_produccion=b.id_proceso_produccion JOIN tbl_mrp_status c ON a.id_status=c.id_status WHERE a.id_empresa=" + csDatos.IdEmpresa.ToString + " ORDER BY id_orden_produccion ASC"
        UcNavegador1.IniciarNavegador()
    End Sub

#Region "Navegador"
    Private Sub Navegador1_posNuevo(sender As Object, e As EventArgs) Handles UcNavegador1.posNuevo
        Try
            csNegocio.CargarCombobox(cbProcesoProduccion, dtProcesosProduccion, "SELECT id_proceso_produccion Value, ppd_nombre Display FROM tbl_mrp_proceso_produccion ORDER BY id_proceso_produccion ASC")
            csNegocio.CargarCombobox(cbStatus, dtStatus, "SELECT id_status Value, sts_descripcion Display FROM tbl_mrp_status ORDER BY id_status ASC")
            csDatos.ConsultarQuery(dtInventarios, "SELECT id_inventario Value, inv_nombre Display FROM tbl_mrp_inventario a JOIN tbl_mrp_inventario_tipo b ON a.id_inventario_tipo=b.id_inventario_tipo WHERE b.ivt_descripcion LIKE '%prod%terminado%' OR b.ivt_descripcion LIKE '%prod%producido%' ORDER BY id_inventario ASC")
            csDatos.ConsultarQuery(dtRecetarios, "SELECT id_recetario Value, rct_descripcion Display FROM tbl_mrp_recetario ORDER BY id_recetario ASC")
            dgOrdprodInventario.Refresh()
            tbEmpresa.Text = csDatos.IdEmpresa.ToString
            ActiveControl = cbProcesoProduccion
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

    Private Sub cbProcesoProduccion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProcesoProduccion.SelectedIndexChanged
        If cbProcesoProduccion.SelectedIndex >= 0 Then
            tbProcesoProduccion.Text = CStr(CType(cbProcesoProduccion.DataSource, DataTable).Rows(cbProcesoProduccion.SelectedIndex)("Value"))
        Else
            tbProcesoProduccion.Text = String.Empty
        End If
    End Sub

    Private Sub tbProcesoProduccion_TextChanged(sender As Object, e As EventArgs) Handles tbProcesoProduccion.TextChanged
        If tbProcesoProduccion.Text = String.Empty Then
            cbProcesoProduccion.SelectedIndex = -1
        Else
            cbProcesoProduccion.SelectedIndex = csNegocio.ObtenerIndexCombobox(cbProcesoProduccion, tbProcesoProduccion.Text)
        End If
    End Sub

    Private Sub cbStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbStatus.SelectedIndexChanged
        If cbStatus.SelectedIndex >= 0 Then
            tbStatus.Text = CStr(CType(cbStatus.DataSource, DataTable).Rows(cbStatus.SelectedIndex)("Value"))
        Else
            tbStatus.Text = String.Empty
        End If
    End Sub

    Private Sub tbStatus_TextChanged(sender As Object, e As EventArgs) Handles tbStatus.TextChanged
        If tbStatus.Text = String.Empty Then
            cbStatus.SelectedIndex = -1
        Else
            cbStatus.SelectedIndex = csNegocio.ObtenerIndexCombobox(cbStatus, tbStatus.Text)
        End If
    End Sub

    Private Sub dpFecha_ValueChanged(sender As Object, e As EventArgs) Handles dpFecha.ValueChanged
        tbFecha.Text = dpFecha.Value.ToString("yyyy/MM/dd")
    End Sub

    Private Sub tbFecha_TextChanged(sender As Object, e As EventArgs) Handles tbFecha.TextChanged
        If tbFecha.Text = String.Empty Then
            dpFecha.Value = Date.Now
            tbFecha.Text = dpFecha.Value.ToString("yyyy/MM/dd")
        Else
            dpFecha.Value = CDate(tbFecha.Text)
        End If
    End Sub

    Private Sub btAgregarInventario_Click(sender As Object, e As EventArgs) Handles btAgregarInventario.Click
        Try
            dgOrdprodInventario.Rows.Add()
            dgOrdprodInventario.CurrentCell = dgOrdprodInventario.Rows(dgOrdprodInventario.Rows.Count - 1).Cells(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btEliminarInventario_Click(sender As Object, e As EventArgs) Handles btEliminarInventario.Click
        Try
            If dgOrdprodInventario.SelectedRows.Count > 0 Then
                If MessageBox.Show("¿Desea eliminar las filas seleccionadas?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    For Each Fila As DataGridViewRow In dgOrdprodInventario.SelectedRows
                        If Fila.Selected Then
                            dgOrdprodInventario.Rows.Remove(Fila)
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