Public Class frGastoPeriodo
#Region "Documentación"
    '----------------------------------------------------------------------------------------------------
    'FECHA:         03/07/2016 
    'DESARROLLADOR: Pablo Zapparoli
    'DESCRIPCIÓN:   Catálogo de gastos por periodo
    '----------------------------------------------------------------------------------------------------
#End Region

    Dim ControlesMaestros As New ArrayList
    Dim dtGastos As New DataTable

    Private Sub frGastoPeriodo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        csNegocio.CargarCombobox(cbGasto, dtGastos, "SELECT id_gasto Value, gst_nombre Display FROM tbl_mrp_gasto ORDER BY id_gasto ASC")
        ControlesMaestros.Add(tbCodigo)
        ControlesMaestros.Add(tbGasto)
        ControlesMaestros.Add(tbAnio)
        ControlesMaestros.Add(tbMes)
        ControlesMaestros.Add(tbCantidad)
        ControlesMaestros.Add(tbEmpresa)
        ControlesMaestros.Add(tbEstado)
        UcNavegador1.ControlesMaestros = ControlesMaestros
        UcNavegador1.NombreTabla = "tbl_mrp_gasto_periodo"
        UcNavegador1.QueryBuscar = "SELECT id_gasto_periodo Código, gst_nombre Gasto, gtp_anio Año, gtp_mes Mes, gtp_valor Valor, CASE a.id_estado WHEN 1 THEN 'Alta' ELSE 'Eliminado' END Estado FROM " + UcNavegador1.NombreTabla + " a JOIN tbl_mrp_gasto b ON a.id_gasto=b.id_gasto WHERE a.id_empresa=" + csDatos.IdEmpresa.ToString + " ORDER BY id_gasto_periodo ASC"
        UcNavegador1.IniciarNavegador()
    End Sub

#Region "Navegador"
    Private Sub Navegador1_posNuevo(sender As Object, e As EventArgs) Handles UcNavegador1.posNuevo
        Try
            csNegocio.CargarCombobox(cbGasto, dtGastos, "SELECT id_gasto Value, gst_nombre Display FROM tbl_mrp_gasto ORDER BY id_gasto ASC")
            tbEmpresa.Text = csDatos.IdEmpresa.ToString
            ActiveControl = tbAnio
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

    Private Sub cbGasto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGasto.SelectedIndexChanged
        If cbGasto.SelectedIndex >= 0 Then
            tbGasto.Text = CStr(CType(cbGasto.DataSource, DataTable).Rows(cbGasto.SelectedIndex)("Value"))
        Else
            tbGasto.Text = String.Empty
        End If
    End Sub

    Private Sub tbGasto_TextChanged(sender As Object, e As EventArgs) Handles tbGasto.TextChanged
        If tbGasto.Text = String.Empty Then
            cbGasto.SelectedIndex = -1
        Else
            cbGasto.SelectedIndex = csNegocio.ObtenerIndexCombobox(cbGasto, tbGasto.Text)
        End If
    End Sub
#End Region
End Class