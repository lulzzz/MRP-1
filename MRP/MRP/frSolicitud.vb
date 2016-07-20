Public Class frSolicitud
#Region "Documentación"
    '----------------------------------------------------------------------------------------------------
    'FECHA:         18/07/2016 
    'DESARROLLADOR: Kevin Gutierrez
    'DESCRIPCIÓN:   Proceso de Solicitudes
    '----------------------------------------------------------------------------------------------------
#End Region

    Dim ControlesMaestros As New ArrayList
    Dim ControlesDetalles As New ArrayList
    Dim dtStatus As New DataTable
    Dim dtInventarios As New DataTable

    Private Sub frSolicitud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        csNegocio.CargarCombobox(cbStatus, dtStatus, "SELECT id_status Value, sts_descripcion Display FROM tbl_mrp_status ORDER BY id_status ASC")
        ControlesMaestros.Add(tbCodigo)
        ControlesMaestros.Add(tbNombre)
        ControlesMaestros.Add(tbDescripcion)
        ControlesMaestros.Add(tbFechaSolicitud)
        ControlesMaestros.Add(tbFechaEntrega)
        ControlesMaestros.Add(tbStatus)
        ControlesMaestros.Add(tbEmpresa)
        ControlesMaestros.Add(tbEstado)
        ControlesDetalles.Add(dgSolicitudInventario)
        UcNavegador1.ControlesMaestros = ControlesMaestros
        UcNavegador1.ControlesDetalles = ControlesDetalles
        csDatos.ConsultarQuery(dtInventarios, "SELECT id_inventario Value, inv_nombre Display FROM tbl_mrp_inventario WHERE id_empresa=" + csDatos.IdEmpresa.ToString + " ORDER BY id_inventario ASC")
        Dim cbInventario As New DataGridViewComboBoxColumn With {.HeaderText = "Inventario", .Name = "id_inventario", .Tag = "Combobox"}
        cbInventario.DataSource = dtInventarios
        cbInventario.ValueMember = "Value"
        cbInventario.DisplayMember = "Display"
        dgSolicitudInventario.Columns.Insert(0, cbInventario)
        UcNavegador1.NombreTabla = "tbl_mrp_solicitud"
        UcNavegador1.QueryBuscar = "SELECT id_solicitud Código, sol_nombre NombreSolicitud, sol_descripcion Descripcion, CONVERT(DATE,sol_fecha_solicitud) FechaSolicitud, CONVERT(DATE,sol_fecha_entrega) FechaEntrega, sts_descripcion 'Status', CASE a.id_estado WHEN 1 THEN 'Alta' ELSE 'Eliminado' END Estado FROM " + UcNavegador1.NombreTabla + " a JOIN tbl_mrp_status b ON a.id_status=b.id_status ORDER BY id_solicitud ASC"
        UcNavegador1.IniciarNavegador()
    End Sub

#Region "Navegador"
    Private Sub Navegador1_posNuevo(sender As Object, e As EventArgs) Handles UcNavegador1.posNuevo
        Try
            csNegocio.CargarCombobox(cbStatus, dtStatus, "SELECT id_status Value, sts_descripcion Display FROM tbl_mrp_status ORDER BY id_status ASC")
            csDatos.ConsultarQuery(dtInventarios, "SELECT id_inventario Value, inv_nombre Display FROM tbl_mrp_inventario WHERE id_empresa=" + csDatos.IdEmpresa.ToString + " ORDER BY id_inventario ASC")
            dgSolicitudInventario.Refresh()
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

    Private Sub btAgregarInventario_Click(sender As Object, e As EventArgs) Handles btAgregarInventario.Click
        Try
            dgSolicitudInventario.Rows.Add()
            dgSolicitudInventario.CurrentCell = dgSolicitudInventario.Rows(dgSolicitudInventario.Rows.Count - 1).Cells(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btEliminarInventario_Click(sender As Object, e As EventArgs) Handles btEliminarInventario.Click
        Try
            If dgSolicitudInventario.SelectedRows.Count > 0 Then
                If MessageBox.Show("¿Desea eliminar las filas seleccionadas?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    For Each Fila As DataGridViewRow In dgSolicitudInventario.SelectedRows
                        If Fila.Selected Then
                            dgSolicitudInventario.Rows.Remove(Fila)
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