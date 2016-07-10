Public Class frUsuario
#Region "Documentación"
    '----------------------------------------------------------------------------------------------------
    'FECHA:         01/07/2016 
    'DESARROLLADOR: Anthony Molineros
    'DESCRIPCIÓN:   Catálogo de usuarios
    '----------------------------------------------------------------------------------------------------
#End Region

    Dim ControlesMaestros As New ArrayList
    Dim ControlesDetalles As New ArrayList
    Dim dtEmpresas As New DataTable

    Private Sub frUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ControlesMaestros.Add(tbCodigo)
        ControlesMaestros.Add(tbNombre)
        ControlesMaestros.Add(tbUsuario)
        ControlesMaestros.Add(tbContrasena)
        ControlesMaestros.Add(tbEstado)
        ControlesDetalles.Add(dgUsuarioEmpresa)
        UcNavegador1.ControlesMaestros = ControlesMaestros
        UcNavegador1.ControlesDetalles = ControlesDetalles
        Dim cbEmpresa As New DataGridViewComboBoxColumn With {.HeaderText = "Empresa", .Name = "id_empresa", .Tag = "Combobox"}
        csDatos.ConsultarQuery(dtEmpresas, "SELECT id_empresa IdEmpresa, emp_nombre Nombre FROM tbl_mrp_empresa ORDER BY emp_nombre ASC")
        cbEmpresa.DataSource = dtEmpresas
        cbEmpresa.ValueMember = "IdEmpresa"
        cbEmpresa.DisplayMember = "Nombre"
        dgUsuarioEmpresa.Columns.Insert(0, cbEmpresa)
        UcNavegador1.NombreTabla = "tbl_mrp_usuario"
        UcNavegador1.QueryBuscar = "SELECT id_usuario Código, usr_nombre Nombre, usr_usuario Usuario, CASE id_estado WHEN 1 THEN 'Alta' ELSE 'Eliminado' END Estado FROM " + UcNavegador1.NombreTabla + " ORDER BY id_usuario ASC"
        UcNavegador1.IniciarNavegador()
    End Sub

#Region "Navegador"
    Private Sub Navegador1_posNuevo(sender As Object, e As EventArgs) Handles UcNavegador1.posNuevo
        Try
            ActiveControl = tbNombre
            ActiveControl.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Navegador1_preGuardar(sender As Object, e As EventArgs) Handles UcNavegador1.preGuardar
        Try
            If tbCodigo.Text = String.Empty Then tbContrasena.Text = csDatos.CifrarCadena(tbContrasena.Text)
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

    Private Sub btAgregarEmpresa_Click(sender As Object, e As EventArgs) Handles btAgregarEmpresa.Click
        dgUsuarioEmpresa.Rows.Add()
    End Sub

    Private Sub btEliminarEmpresa_Click(sender As Object, e As EventArgs) Handles btEliminarEmpresa.Click
        If MessageBox.Show("¿Desea eliminar las filas seleccionadas?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If dgUsuarioEmpresa.SelectedRows.Count > 0 Then
                For Each Fila As DataGridViewRow In dgUsuarioEmpresa.SelectedRows
                    If Fila.Selected Then
                        dgUsuarioEmpresa.Rows.Remove(Fila)
                    End If
                Next
            End If
        End If
    End Sub
#End Region
End Class