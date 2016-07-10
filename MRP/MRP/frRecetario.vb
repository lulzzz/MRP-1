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

    Private Sub frRecetario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        csNegocio.CargarCombobox(cbInventario, dtInventarios, "SELECT id_inventario Value, inv_nombre Display FROM tbl_mrp_inventario a JOIN tbl_mrp_inventario_clasificacion b ON a.id_inventario_clasificacion=b.id_inventario_clasificacion WHERE b.icl_descripcion LIKE '%prod%%terminado%' OR b.icl_descripcion LIKE '%prod%%producido%' ORDER BY id_inventario ASC")
        ControlesMaestros.Add(tbCodigo)
        ControlesMaestros.Add(tbInventario)
        ControlesMaestros.Add(tbDescripcion)
        ControlesMaestros.Add(tbFechaCreacion)
        ControlesMaestros.Add(tbEmpresa)
        ControlesMaestros.Add(tbEstado)
        'ControlesDetalles.Add(dgRecetarioInventarios)
        'ControlesDetalles.Add(dgRecetarioTareas)
        UcNavegador1.ControlesMaestros = ControlesMaestros
        'UcNavegador1.ControlesDetalles = ControlesDetalles
        UcNavegador1.NombreTabla = "tbl_mrp_recetario"
        UcNavegador1.QueryBuscar = "SELECT id_recetario Código, inv_nombre Inventario, rct_descripcion Descripción, rct_fecha_creacion 'Fecha de Creación', CASE a.id_estado WHEN 1 THEN 'Alta' ELSE 'Eliminado' END Estado FROM " + UcNavegador1.NombreTabla + " a JOIN tbl_mrp_inventario b ON a.id_inventario=b.id_inventario WHERE a.id_empresa=" + csDatos.IdEmpresa.ToString + " ORDER BY id_recetario ASC"
        UcNavegador1.IniciarNavegador()
    End Sub

#Region "Navegador"
    Private Sub Navegador1_posNuevo(sender As Object, e As EventArgs) Handles UcNavegador1.posNuevo
        Try
            csNegocio.CargarCombobox(cbInventario, dtInventarios, "SELECT id_inventario Value, inv_nombre Display FROM tbl_mrp_inventario a JOIN tbl_mrp_inventario_clasificacion b ON a.id_inventario_clasificacion=b.id_inventario_clasificacion WHERE b.icl_descripcion LIKE '%prod%%terminado%' OR b.icl_descripcion LIKE '%prod%%producido%' ORDER BY id_inventario ASC")
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
            Me.Close()
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
#End Region
End Class