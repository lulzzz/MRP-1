Public Class frPerfil
#Region "Documentación"
    '----------------------------------------------------------------------------------------------------
    'FECHA:         19/07/2016 
    'DESARROLLADOR: Marlon Aldana
    'DESCRIPCIÓN:   Proceso de perfiles
    '----------------------------------------------------------------------------------------------------
#End Region

    Dim ControlesMaestros As New ArrayList
    Dim ControlesDetalles As New ArrayList
    Dim dtVentanas As New DataTable
    Dim dtHabilitada As New DataTable

    Private Sub frPerfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ControlesMaestros.Add(tbCodigo)
        ControlesMaestros.Add(tbNombre)
        ControlesMaestros.Add(tbDescripcion)
        ControlesMaestros.Add(tbEstado)
        ControlesDetalles.Add(dgPerfilVentana)
        UcNavegador1.ControlesMaestros = ControlesMaestros
        UcNavegador1.ControlesDetalles = ControlesDetalles
        Dim cbVentana As New DataGridViewComboBoxColumn With {.HeaderText = "Ventana", .Name = "id_ventana", .Tag = "Combobox"}
        csDatos.ConsultarQuery(dtVentanas, "SELECT id_ventana Value, vtn_nombre Display FROM tbl_mrp_ventana ORDER BY id_ventana ASC")
        cbVentana.DataSource = dtVentanas
        cbVentana.ValueMember = "Value"
        cbVentana.DisplayMember = "Display"
        dgPerfilVentana.Columns.Insert(0, cbVentana)
        Dim cbHabilitada As New DataGridViewComboBoxColumn With {.HeaderText = "Acceso", .Name = "pfv_habilitado", .Tag = "Combobox"}
        csDatos.ConsultarQuery(dtHabilitada, "SELECT 0 Value, 'Deshabilitado' AS 'Display' UNION SELECT 1 Value, 'Habilitado' AS 'Display'")
        cbHabilitada.DataSource = dtHabilitada
        cbHabilitada.ValueMember = "Value"
        cbHabilitada.DisplayMember = "Display"
        dgPerfilVentana.Columns.Insert(1, cbHabilitada)
        UcNavegador1.NombreTabla = "tbl_mrp_perfil"
        UcNavegador1.QueryBuscar = "SELECT id_perfil Código, pfl_nombre Nombre, pfl_descripcion Descripción, CASE id_estado WHEN 1 THEN 'Alta' ELSE 'Eliminado' END Estado FROM " + UcNavegador1.NombreTabla + " ORDER BY id_perfil ASC"
        UcNavegador1.IniciarNavegador()
    End Sub

#Region "Navegador"
    Private Sub Navegador1_posNuevo(sender As Object, e As EventArgs) Handles UcNavegador1.posNuevo
        Try
            csDatos.ConsultarQuery(dtVentanas, "SELECT id_ventana Value, vtn_nombre Display FROM tbl_mrp_ventana ORDER BY id_ventana ASC")
            csDatos.ConsultarQuery(dtHabilitada, "SELECT 0 Value, 'Deshabilitado' AS 'Display' UNION SELECT 1 Value, 'Habilitado' AS 'Display'")
            dgPerfilVentana.Refresh()
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

    Private Sub btAgregarVentana_Click(sender As Object, e As EventArgs) Handles btAgregarVentana.Click
        dgPerfilVentana.Rows.Add()
    End Sub

    Private Sub btEliminarVentana_Click(sender As Object, e As EventArgs) Handles btEliminarVentana.Click
        If MessageBox.Show("¿Desea eliminar las filas seleccionadas?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If dgPerfilVentana.SelectedRows.Count > 0 Then
                For Each Fila As DataGridViewRow In dgPerfilVentana.SelectedRows
                    If Fila.Selected Then
                        dgPerfilVentana.Rows.Remove(Fila)
                    End If
                Next
            End If
        End If
    End Sub
#End Region
End Class