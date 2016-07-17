Public Class frRecetario
#Region "Documentación"
    '----------------------------------------------------------------------------------------------------
    'FECHA:         06/07/2016 
    'DESARROLLADOR: Anthony Molineros
    'DESCRIPCIÓN:   Catálogo de recetario
    '----------------------------------------------------------------------------------------------------
#End Region

    Dim ControlesMaestros As New ArrayList
    Dim ControlesDetalles As New ArrayList
    Dim dtInventarios As New DataTable
    Dim dtMateriasPrimas As New DataTable
    Dim dtTareas As New DataTable
    Dim dtGastos As New DataTable

    Private Sub frRecetario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        csNegocio.CargarCombobox(cbInventario, dtInventarios, "SELECT id_inventario Value, inv_nombre Display FROM tbl_mrp_inventario a JOIN tbl_mrp_inventario_tipo b ON a.id_inventario_tipo=b.id_inventario_tipo WHERE b.ivt_descripcion LIKE '%prod%terminado%' OR b.ivt_descripcion LIKE '%prod%producido%' AND id_empresa=" + csDatos.IdEmpresa.ToString + " ORDER BY id_inventario ASC")
        ControlesMaestros.Add(tbCodigo)
        ControlesMaestros.Add(tbInventario)
        ControlesMaestros.Add(tbDescripcion)
        ControlesMaestros.Add(tbFechaCreacion)
        ControlesMaestros.Add(tbEmpresa)
        ControlesMaestros.Add(tbEstado)
        ControlesDetalles.Add(dgRecetarioInventario)
        ControlesDetalles.Add(dgRecetarioTarea)
        ControlesDetalles.Add(dgRecetarioGasto)
        UcNavegador1.ControlesMaestros = ControlesMaestros
        UcNavegador1.ControlesDetalles = ControlesDetalles
        csDatos.ConsultarQuery(dtMateriasPrimas, "SELECT id_inventario Value, inv_nombre Display FROM tbl_mrp_inventario a JOIN tbl_mrp_inventario_tipo b ON a.id_inventario_tipo=b.id_inventario_tipo WHERE b.ivt_descripcion LIKE '%mat%prima%' AND id_empresa=" + csDatos.IdEmpresa.ToString + " ORDER BY id_inventario ASC")
        Dim cbMateriaPrima As New DataGridViewComboBoxColumn With {.HeaderText = "Inventario", .Name = "id_inventario", .Tag = "Combobox"}
        cbMateriaPrima.DataSource = dtMateriasPrimas
        cbMateriaPrima.ValueMember = "Value"
        cbMateriaPrima.DisplayMember = "Display"
        dgRecetarioInventario.Columns.Insert(0, cbMateriaPrima)
        csDatos.ConsultarQuery(dtTareas, "SELECT id_tarea Value, tar_nombre Display FROM tbl_mrp_tarea WHERE id_empresa=" + csDatos.IdEmpresa.ToString + " ORDER BY id_tarea ASC")
        Dim cbTarea As New DataGridViewComboBoxColumn With {.HeaderText = "Tarea", .Name = "id_tarea", .Tag = "Combobox"}
        cbTarea.DataSource = dtTareas
        cbTarea.ValueMember = "Value"
        cbTarea.DisplayMember = "Display"
        dgRecetarioTarea.Columns.Insert(0, cbTarea)
        csDatos.ConsultarQuery(dtGastos, "SELECT id_gasto Value, gst_nombre Display FROM tbl_mrp_gasto WHERE id_empresa=" + csDatos.IdEmpresa.ToString + " ORDER BY id_gasto ASC")
        Dim cbGasto As New DataGridViewComboBoxColumn With {.HeaderText = "Gasto", .Name = "id_gasto", .Tag = "Combobox"}
        cbGasto.DataSource = dtGastos
        cbGasto.ValueMember = "Value"
        cbGasto.DisplayMember = "Display"
        dgRecetarioGasto.Columns.Insert(0, cbGasto)

        UcNavegador1.NombreTabla = "tbl_mrp_recetario"
        UcNavegador1.QueryBuscar = "SELECT id_recetario Código, inv_nombre Inventario, rct_descripcion Descripción, rct_fecha_creacion 'Fecha de Creación', CASE a.id_estado WHEN 1 THEN 'Alta' ELSE 'Eliminado' END Estado FROM " + UcNavegador1.NombreTabla + " a JOIN tbl_mrp_inventario b ON a.id_inventario=b.id_inventario WHERE a.id_empresa=" + csDatos.IdEmpresa.ToString + " ORDER BY id_recetario ASC"
        UcNavegador1.IniciarNavegador()
    End Sub

#Region "Navegador"
    Private Sub Navegador1_posNuevo(sender As Object, e As EventArgs) Handles UcNavegador1.posNuevo
        Try
            csNegocio.CargarCombobox(cbInventario, dtInventarios, "SELECT id_inventario Value, inv_nombre Display FROM tbl_mrp_inventario a JOIN tbl_mrp_inventario_tipo b ON a.id_inventario_tipo=b.id_inventario_tipo WHERE b.ivt_descripcion LIKE '%prod%terminado%' OR b.ivt_descripcion LIKE '%prod%producido%' AND id_empresa=" + csDatos.IdEmpresa.ToString + " ORDER BY id_inventario ASC")
            csDatos.ConsultarQuery(dtMateriasPrimas, "SELECT id_inventario Value, inv_nombre Display FROM tbl_mrp_inventario a JOIN tbl_mrp_inventario_tipo b ON a.id_inventario_tipo=b.id_inventario_tipo WHERE b.ivt_descripcion LIKE '%mat%prima%' AND id_empresa=" + csDatos.IdEmpresa.ToString + " ORDER BY id_inventario ASC")
            csDatos.ConsultarQuery(dtTareas, "SELECT id_tarea Value, tar_nombre Display FROM tbl_mrp_tarea WHERE id_empresa=" + csDatos.IdEmpresa.ToString + " ORDER BY id_tarea ASC")
            csDatos.ConsultarQuery(dtGastos, "SELECT id_gasto Value, gst_nombre Display FROM tbl_mrp_gasto WHERE id_empresa=" + csDatos.IdEmpresa.ToString + " ORDER BY id_gasto ASC")
            dgRecetarioInventario.Refresh()
            dgRecetarioTarea.Refresh()
            dgRecetarioGasto.Refresh()
            tbEmpresa.Text = csDatos.IdEmpresa.ToString
            ActiveControl = cbInventario
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

    Private Sub cbInventario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbInventario.SelectedIndexChanged
        If cbInventario.SelectedIndex >= 0 Then
            tbInventario.Text = CStr(CType(cbInventario.DataSource, DataTable).Rows(cbInventario.SelectedIndex)("Value"))
        Else
            tbInventario.Text = String.Empty
        End If
    End Sub

    Private Sub tbInventario_TextChanged(sender As Object, e As EventArgs) Handles tbInventario.TextChanged
        If tbInventario.Text = String.Empty Then
            cbInventario.SelectedIndex = -1
        Else
            cbInventario.SelectedIndex = csNegocio.ObtenerIndexCombobox(cbInventario, tbInventario.Text)
        End If
    End Sub

    Private Sub dpFechaCreacion_ValueChanged(sender As Object, e As EventArgs) Handles dpFechaCreacion.ValueChanged
        tbFechaCreacion.Text = dpFechaCreacion.Value.ToString("yyyy/MM/dd")
    End Sub

    Private Sub tbFechaCreacion_TextChanged(sender As Object, e As EventArgs) Handles tbFechaCreacion.TextChanged
        If tbFechaCreacion.Text = String.Empty Then
            dpFechaCreacion.Value = Date.Now
            tbFechaCreacion.Text = dpFechaCreacion.Value.ToString("yyyy/MM/dd")
        Else
            dpFechaCreacion.Value = CDate(tbFechaCreacion.Text)
        End If
    End Sub

    Private Sub btAgregarInventario_Click(sender As Object, e As EventArgs) Handles btAgregarInventario.Click
        Try
            dgRecetarioInventario.Rows.Add()
            dgRecetarioInventario.CurrentCell = dgRecetarioInventario.Rows(dgRecetarioInventario.Rows.Count - 1).Cells(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btEliminarInventario_Click(sender As Object, e As EventArgs) Handles btEliminarInventario.Click
        Try
            If dgRecetarioInventario.SelectedRows.Count > 0 Then
                If MessageBox.Show("¿Desea eliminar las filas seleccionadas?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    For Each Fila As DataGridViewRow In dgRecetarioInventario.SelectedRows
                        If Fila.Selected Then
                            dgRecetarioInventario.Rows.Remove(Fila)
                        End If
                    Next
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btAgregarTarea_Click(sender As Object, e As EventArgs) Handles btAgregarTarea.Click
        Try
            dgRecetarioTarea.Rows.Add()
            dgRecetarioTarea.CurrentCell = dgRecetarioTarea.Rows(dgRecetarioTarea.Rows.Count - 1).Cells(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btEliminarTarea_Click(sender As Object, e As EventArgs) Handles btEliminarTarea.Click
        Try
            If dgRecetarioTarea.SelectedRows.Count > 0 Then
                If MessageBox.Show("¿Desea eliminar las filas seleccionadas?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    For Each Fila As DataGridViewRow In dgRecetarioTarea.SelectedRows
                        If Fila.Selected Then
                            dgRecetarioTarea.Rows.Remove(Fila)
                        End If
                    Next
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btAgregarGasto_Click(sender As Object, e As EventArgs) Handles btAgregarGasto.Click
        Try
            dgRecetarioGasto.Rows.Add()
            dgRecetarioGasto.CurrentCell = dgRecetarioGasto.Rows(dgRecetarioGasto.Rows.Count - 1).Cells(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btEliminarGasto_Click(sender As Object, e As EventArgs) Handles btEliminarGasto.Click
        Try
            If dgRecetarioGasto.SelectedRows.Count > 0 Then
                If MessageBox.Show("¿Desea eliminar las filas seleccionadas?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    For Each Fila As DataGridViewRow In dgRecetarioGasto.SelectedRows
                        If Fila.Selected Then
                            dgRecetarioGasto.Rows.Remove(Fila)
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