Public Class frMovimiento
#Region "Documentación"
    '----------------------------------------------------------------------------------------------------
    'FECHA:         18/07/2016 
    'DESARROLLADOR: Kevin Gutierrez
    'DESCRIPCIÓN:   Proceso de Movimientos
    '----------------------------------------------------------------------------------------------------
#End Region

    Dim ControlesMaestros As New ArrayList
    Dim ControlesDetalles As New ArrayList
    Dim dtTipos As New DataTable
    Dim dtBodegas As New DataTable
    Dim dtInventarios As New DataTable

    Private Sub frMovimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        csNegocio.CargarCombobox(cbTipo, dtTipos, "SELECT id_movimiento_tipo Value, mtp_descripcion Display FROM tbl_mrp_movimiento_tipo ORDER BY id_movimiento_tipo ASC")
        csNegocio.CargarCombobox(cbBodega, dtBodegas, "SELECT id_bodega Value, bdg_nombre Display FROM tbl_mrp_bodega ORDER BY id_bodega ASC")
        ControlesMaestros.Add(tbCodigo)
        ControlesMaestros.Add(tbTipo)
        ControlesMaestros.Add(tbBodega)
        ControlesMaestros.Add(tbNumero)
        ControlesMaestros.Add(tbFecha)
        ControlesMaestros.Add(tbDescripcion)
        ControlesMaestros.Add(tbEmpresa)
        ControlesMaestros.Add(tbEstado)
        ControlesDetalles.Add(dgMovimientoInventario)
        UcNavegador1.ControlesMaestros = ControlesMaestros
        UcNavegador1.ControlesDetalles = ControlesDetalles
        csDatos.ConsultarQuery(dtInventarios, "SELECT id_inventario Value, inv_nombre Display FROM tbl_mrp_inventario WHERE id_empresa=" + csDatos.IdEmpresa.ToString + " ORDER BY id_inventario ASC")
        Dim cbInventario As New DataGridViewComboBoxColumn With {.HeaderText = "Inventario", .Name = "id_inventario", .Tag = "Combobox"}
        cbInventario.DataSource = dtInventarios
        cbInventario.ValueMember = "Value"
        cbInventario.DisplayMember = "Display"
        dgMovimientoInventario.Columns.Insert(0, cbInventario)
        UcNavegador1.NombreTabla = "tbl_mrp_movimiento"
        UcNavegador1.QueryBuscar = "SELECT id_movimiento Código, mtp_descripcion TipoMovimiento, bdg_nombre Bodega, mov_numero Número, CONVERT(DATE,mov_fecha) Fecha, mov_descripcion Descripcion,  CASE a.id_estado WHEN 1 THEN 'Alta' ELSE 'Eliminado' END Estado FROM " + UcNavegador1.NombreTabla + " a JOIN tbl_mrp_movimiento_tipo b ON a.id_movimiento_tipo=b.id_movimiento_tipo JOIN tbl_mrp_bodega c ON a.id_bodega=c.id_bodega WHERE a.id_empresa=" + csDatos.IdEmpresa.ToString + " ORDER BY id_movimiento ASC"
        UcNavegador1.IniciarNavegador()
    End Sub

#Region "Navegador"
    Private Sub Navegador1_posNuevo(sender As Object, e As EventArgs) Handles UcNavegador1.posNuevo
        Try
            csNegocio.CargarCombobox(cbTipo, dtTipos, "SELECT id_movimiento_tipo Value, mtp_descripcion Display FROM tbl_mrp_movimiento_tipo ORDER BY id_movimiento_tipo ASC")
            csNegocio.CargarCombobox(cbBodega, dtBodegas, "SELECT id_bodega Value, bdg_nombre Display FROM tbl_mrp_bodega ORDER BY id_bodega ASC")
            csDatos.ConsultarQuery(dtInventarios, "SELECT id_inventario Value, inv_nombre Display FROM tbl_mrp_inventario WHERE id_empresa=" + csDatos.IdEmpresa.ToString + " ORDER BY id_inventario ASC")
            dgMovimientoInventario.Refresh()
            tbEmpresa.Text = csDatos.IdEmpresa.ToString
            ActiveControl = cbTipo
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

    Private Sub cbTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTipo.SelectedIndexChanged
        If cbTipo.SelectedIndex >= 0 Then
            tbTipo.Text = CStr(CType(cbTipo.DataSource, DataTable).Rows(cbTipo.SelectedIndex)("Value"))
        Else
            tbTipo.Text = String.Empty
        End If
    End Sub

    Private Sub tbTipo_TextChanged(sender As Object, e As EventArgs) Handles tbTipo.TextChanged
        If tbTipo.Text = String.Empty Then
            cbTipo.SelectedIndex = -1
        Else
            cbTipo.SelectedIndex = csNegocio.ObtenerIndexCombobox(cbTipo, tbTipo.Text)
        End If
    End Sub

    Private Sub cbBodega_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBodega.SelectedIndexChanged
        If cbBodega.SelectedIndex >= 0 Then
            tbBodega.Text = CStr(CType(cbBodega.DataSource, DataTable).Rows(cbBodega.SelectedIndex)("Value"))
        Else
            tbBodega.Text = String.Empty
        End If
    End Sub

    Private Sub tbBodega_TextChanged(sender As Object, e As EventArgs) Handles tbBodega.TextChanged
        If tbBodega.Text = String.Empty Then
            cbBodega.SelectedIndex = -1
        Else
            cbBodega.SelectedIndex = csNegocio.ObtenerIndexCombobox(cbTipo, tbBodega.Text)
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
            dgMovimientoInventario.Rows.Add()
            dgMovimientoInventario.CurrentCell = dgMovimientoInventario.Rows(dgMovimientoInventario.Rows.Count - 1).Cells(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btEliminarInventario_Click(sender As Object, e As EventArgs) Handles btEliminarInventario.Click
        Try
            If dgMovimientoInventario.SelectedRows.Count > 0 Then
                If MessageBox.Show("¿Desea eliminar las filas seleccionadas?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    For Each Fila As DataGridViewRow In dgMovimientoInventario.SelectedRows
                        If Fila.Selected Then
                            dgMovimientoInventario.Rows.Remove(Fila)
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