Public Class frTarea
#Region "Documentación"
    '----------------------------------------------------------------------------------------------------
    'FECHA:         06/07/2016 
    'DESARROLLADOR: Anthony Molineros
    'DESCRIPCIÓN:   Catálogo de tareas
    '----------------------------------------------------------------------------------------------------
#End Region

    Dim ControlesMaestros As New ArrayList
    Dim dtTareasTipo As New DataTable

    Private Sub frTarea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        csNegocio.CargarCombobox(cbTareaTipo, dtTareasTipo, "SELECT id_tarea_tipo Value, ttp_descripcion Display FROM tbl_mrp_tarea_tipo ORDER BY id_tarea_tipo ASC")
        ControlesMaestros.Add(tbCodigo)
        ControlesMaestros.Add(tbTareaTipo)
        ControlesMaestros.Add(tbNombre)
        ControlesMaestros.Add(tbDescripcion)
        ControlesMaestros.Add(tbEmpresa)
        ControlesMaestros.Add(tbEstado)
        UcNavegador1.ControlesMaestros = ControlesMaestros
        UcNavegador1.NombreTabla = "tbl_mrp_tarea"
        UcNavegador1.QueryBuscar = "SELECT id_tarea Código, ttp_descripcion 'Tipo de Tarea', tar_nombre Nombre, tar_descripcion Descripción, CASE a.id_estado WHEN 1 THEN 'Alta' ELSE 'Eliminado' END Estado FROM " + UcNavegador1.NombreTabla + " a JOIN tbl_mrp_tarea_tipo b ON a.id_tarea_tipo=b.id_tarea_tipo WHERE id_empresa=" + csDatos.IdEmpresa.ToString + " ORDER BY id_tarea ASC"
        UcNavegador1.IniciarNavegador()
    End Sub

#Region "Navegador"
    Private Sub Navegador1_posNuevo(sender As Object, e As EventArgs) Handles UcNavegador1.posNuevo
        Try
            csNegocio.CargarCombobox(cbTareaTipo, dtTareasTipo, "SELECT id_tarea_tipo Value, ttp_descripcion Display FROM tbl_mrp_tarea_tipo ORDER BY id_tarea_tipo ASC")
            tbEmpresa.Text = csDatos.IdEmpresa.ToString
            ActiveControl = cbTareaTipo
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

    Private Sub cbTareaTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTareaTipo.SelectedIndexChanged
        If cbTareaTipo.SelectedIndex >= 0 Then
            tbTareaTipo.Text = CStr(CType(cbTareaTipo.DataSource, DataTable).Rows(cbTareaTipo.SelectedIndex)("Value"))
        Else
            tbTareaTipo.Text = String.Empty
        End If
    End Sub

    Private Sub tbTareaTipo_TextChanged(sender As Object, e As EventArgs) Handles tbTareaTipo.TextChanged
        If tbTareaTipo.Text = String.Empty Then
            cbTareaTipo.SelectedIndex = -1
        Else
            cbTareaTipo.SelectedIndex = csNegocio.ObtenerIndexCombobox(cbTareaTipo, tbTareaTipo.Text)
        End If
    End Sub
#End Region
End Class