Public Class frInventario
#Region "Documentación"
    '----------------------------------------------------------------------------------------------------
    'FECHA:         06/07/2016 
    'DESARROLLADOR: Kevin Gutiérrez
    'DESCRIPCIÓN:   Catálogo de inventarios
    '----------------------------------------------------------------------------------------------------
#End Region

    Dim ControlesMaestros As New ArrayList
    Dim dtInventariosTipo As New DataTable
    Dim dtMedidas As New DataTable

    Private Sub frInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        csNegocio.CargarCombobox(cbInventarioTipo, dtInventariosTipo, "SELECT id_inventario_tipo Value, ivt_descripcion Display FROM tbl_mrp_inventario_tipo ORDER BY id_inventario_tipo ASC")
        csNegocio.CargarCombobox(cbMedida, dtMedidas, "SELECT id_medida Value, mdd_descripcion Display FROM tbl_mrp_medida ORDER BY id_medida ASC")
        ControlesMaestros.Add(tbCodigo)
        ControlesMaestros.Add(tbInventarioTipo)
        ControlesMaestros.Add(tbNombre)
        ControlesMaestros.Add(tbDescripcion)
        ControlesMaestros.Add(tbFechaCreacion)
        ControlesMaestros.Add(tbMedida)
        ControlesMaestros.Add(tbPrecio)
        ControlesMaestros.Add(tbEmpresa)
        ControlesMaestros.Add(tbEstado)
        UcNavegador1.ControlesMaestros = ControlesMaestros
        UcNavegador1.NombreTabla = "tbl_mrp_inventario"
        UcNavegador1.QueryBuscar = "SELECT id_inventario Código, ivt_descripcion 'Tipo de Inventario', inv_nombre Nombre, inv_descripcion Descripción, inv_fecha_creacion 'Fecha Creación', mdd_nombre Medida, inv_precio Precio, CASE a.id_estado WHEN 1 THEN 'Alta' ELSE 'Eliminado' END Estado FROM " + UcNavegador1.NombreTabla + " a JOIN tbl_mrp_inventario_tipo b ON a.id_inventario_tipo=b.id_inventario_tipo JOIN tbl_mrp_medida c ON a.id_medida=c.id_medida WHERE a.id_empresa=" + csDatos.IdEmpresa.ToString + " ORDER BY id_inventario ASC"
        UcNavegador1.IniciarNavegador()
    End Sub

#Region "Navegador"
    Private Sub Navegador1_posNuevo(sender As Object, e As EventArgs) Handles UcNavegador1.posNuevo
        Try
            csNegocio.CargarCombobox(cbInventarioTipo, dtInventariosTipo, "SELECT id_inventario_tipo Value, ivt_descripcion Display FROM tbl_mrp_inventario_tipo ORDER BY id_inventario_tipo ASC")
            csNegocio.CargarCombobox(cbMedida, dtMedidas, "SELECT id_medida Value, mdd_descripcion Display FROM tbl_mrp_medida ORDER BY id_medida ASC")
            tbEmpresa.Text = csDatos.IdEmpresa.ToString
            ActiveControl = cbInventarioTipo
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

    Private Sub cbInventarioTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbInventarioTipo.SelectedIndexChanged
        If cbInventarioTipo.SelectedIndex >= 0 Then
            tbInventarioTipo.Text = CStr(CType(cbInventarioTipo.DataSource, DataTable).Rows(cbInventarioTipo.SelectedIndex)("Value"))
        Else
            tbInventarioTipo.Text = String.Empty
        End If
    End Sub

    Private Sub tbInventarioTipo_TextChanged(sender As Object, e As EventArgs) Handles tbInventarioTipo.TextChanged
        If tbInventarioTipo.Text = String.Empty Then
            cbInventarioTipo.SelectedIndex = -1
        Else
            cbInventarioTipo.SelectedIndex = csNegocio.ObtenerIndexCombobox(cbInventarioTipo, tbInventarioTipo.Text)
        End If
    End Sub

    Private Sub cbMedida_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMedida.SelectedIndexChanged
        If cbMedida.SelectedIndex >= 0 Then
            tbMedida.Text = CStr(CType(cbMedida.DataSource, DataTable).Rows(cbMedida.SelectedIndex)("Value"))
        Else
            tbMedida.Text = String.Empty
        End If
    End Sub

    Private Sub tbMedida_TextChanged(sender As Object, e As EventArgs) Handles tbMedida.TextChanged
        If tbMedida.Text = String.Empty Then
            cbMedida.SelectedIndex = -1
        Else
            cbMedida.SelectedIndex = csNegocio.ObtenerIndexCombobox(cbMedida, tbMedida.Text)
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