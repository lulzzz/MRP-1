Public Class frGasto
#Region "Documentación"
    '----------------------------------------------------------------------------------------------------
    'FECHA:         02/07/2016 
    'DESARROLLADOR: Pablo Zapparoli
    'DESCRIPCIÓN:   Catálogo de gastos
    '----------------------------------------------------------------------------------------------------
#End Region

    Dim ControlesMaestros As New ArrayList
    Dim dtGastosTipo As New DataTable

    Private Sub frGasto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        csNegocio.CargarCombobox(cbGastoTipo, dtGastosTipo, "SELECT id_gasto_tipo Value, gtt_descripcion Display FROM tbl_mrp_gasto_tipo ORDER BY id_gasto_tipo ASC")
        ControlesMaestros.Add(tbCodigo)
        ControlesMaestros.Add(tbGastoTipo)
        ControlesMaestros.Add(tbNombre)
        ControlesMaestros.Add(tbDescripcion)
        ControlesMaestros.Add(tbFactor)
        ControlesMaestros.Add(tbEmpresa)
        ControlesMaestros.Add(tbEstado)
        UcNavegador1.ControlesMaestros = ControlesMaestros
        UcNavegador1.NombreTabla = "tbl_mrp_gasto"
        UcNavegador1.QueryBuscar = "SELECT id_gasto Código, gtt_descripcion 'Tipo de Gasto', gst_nombre Nombre, gst_descripcion Descripción, gst_factor Factor, CASE a.id_estado WHEN 1 THEN 'Alta' ELSE 'Eliminado' END Estado FROM " + UcNavegador1.NombreTabla + " a JOIN tbl_mrp_gasto_tipo b ON a.id_gasto_tipo=b.id_gasto_tipo WHERE id_empresa=" + csDatos.IdEmpresa.ToString + " ORDER BY id_gasto ASC"
        UcNavegador1.IniciarNavegador()
    End Sub

#Region "Navegador"
    Private Sub Navegador1_posNuevo(sender As Object, e As EventArgs) Handles UcNavegador1.posNuevo
        Try
            csNegocio.CargarCombobox(cbGastoTipo, dtGastosTipo, "SELECT id_gasto_tipo Value, gtt_descripcion Display FROM tbl_mrp_gasto_tipo ORDER BY id_gasto_tipo ASC")
            tbEmpresa.Text = csDatos.IdEmpresa.ToString
            ActiveControl = cbGastoTipo
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

    Private Sub cbGastoTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGastoTipo.SelectedIndexChanged
        If cbGastoTipo.SelectedIndex >= 0 Then
            tbGastoTipo.Text = CStr(CType(cbGastoTipo.DataSource, DataTable).Rows(cbGastoTipo.SelectedIndex)("Value"))
        Else
            tbGastoTipo.Text = String.Empty
        End If
    End Sub

    Private Sub tbGastoTipo_TextChanged(sender As Object, e As EventArgs) Handles tbGastoTipo.TextChanged
        If tbGastoTipo.Text = String.Empty Then
            cbGastoTipo.SelectedIndex = -1
        Else
            cbGastoTipo.SelectedIndex = csNegocio.ObtenerIndexCombobox(cbGastoTipo, tbGastoTipo.Text)
        End If
    End Sub
#End Region
End Class