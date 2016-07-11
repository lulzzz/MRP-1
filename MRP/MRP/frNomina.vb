Public Class frNomina
#Region "Documentación"
    '----------------------------------------------------------------------------------------------------
    'FECHA:         06/07/2016 
    'DESARROLLADOR: Marlon Aldana
    'DESCRIPCIÓN:   Catálogo de nóminas
    '----------------------------------------------------------------------------------------------------
#End Region

    Dim ControlesMaestros As New ArrayList
    Dim dtNominaPeriodos As New DataTable

    Private Sub frNomina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        csNegocio.CargarCombobox(cbNominaPeriodo, dtNominaPeriodos, "SELECT id_nomina_periodo Value, nmp_descripcion Display FROM tbl_mrp_nomina_periodo ORDER BY id_nomina_periodo ASC")
        ControlesMaestros.Add(tbCodigo)
        ControlesMaestros.Add(tbNominaPeriodo)
        ControlesMaestros.Add(tbDescripcion)
        ControlesMaestros.Add(tbEmpresa)
        ControlesMaestros.Add(tbEstado)
        UcNavegador1.ControlesMaestros = ControlesMaestros
        UcNavegador1.NombreTabla = "tbl_mrp_nomina"
        UcNavegador1.QueryBuscar = "SELECT id_nomina Código, nmp_descripcion Periodo, nmn_descripcion Descripción, CASE a.id_estado WHEN 1 THEN 'Alta' ELSE 'Eliminado' END Estado FROM " + UcNavegador1.NombreTabla + " a JOIN tbl_mrp_nomina_periodo b ON a.id_nomina_periodo=b.id_nomina_periodo WHERE id_empresa=" + csDatos.IdEmpresa.ToString + " ORDER BY id_nomina ASC"
        UcNavegador1.IniciarNavegador()
    End Sub

#Region "Navegador"
    Private Sub Navegador1_posNuevo(sender As Object, e As EventArgs) Handles UcNavegador1.posNuevo
        Try
            csNegocio.CargarCombobox(cbNominaPeriodo, dtNominaPeriodos, "SELECT id_nomina_periodo Value, nmp_descripcion Display FROM tbl_mrp_nomina_periodo ORDER BY id_nomina_periodo ASC")
            tbEmpresa.Text = csDatos.IdEmpresa.ToString
            ActiveControl = cbNominaPeriodo
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

    Private Sub cbNominaPeriodo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbNominaPeriodo.SelectedIndexChanged
        If cbNominaPeriodo.SelectedIndex >= 0 Then
            tbNominaPeriodo.Text = CStr(CType(cbNominaPeriodo.DataSource, DataTable).Rows(cbNominaPeriodo.SelectedIndex)("Value"))
        Else
            tbNominaPeriodo.Text = String.Empty
        End If
    End Sub

    Private Sub tbNominaPeriodo_TextChanged(sender As Object, e As EventArgs) Handles tbNominaPeriodo.TextChanged
        If tbNominaPeriodo.Text = String.Empty Then
            cbNominaPeriodo.SelectedIndex = -1
        Else
            cbNominaPeriodo.SelectedIndex = csNegocio.ObtenerIndexCombobox(cbNominaPeriodo, tbNominaPeriodo.Text)
        End If
    End Sub
#End Region
End Class