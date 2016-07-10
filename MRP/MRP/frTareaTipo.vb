Public Class frTareaTipo
#Region "Documentación"
    '----------------------------------------------------------------------------------------------------
    'FECHA:         06/07/2016 
    'DESARROLLADOR: Anthony Molineros
    'DESCRIPCIÓN:   Catálogo de tipos de tareas
    '----------------------------------------------------------------------------------------------------
#End Region

    Dim ControlesMaestros As New ArrayList

    Private Sub frTareaTipo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ControlesMaestros.Add(tbCodigo)
        ControlesMaestros.Add(tbDescripcion)
        ControlesMaestros.Add(tbEstado)
        UcNavegador1.ControlesMaestros = ControlesMaestros
        UcNavegador1.NombreTabla = "tbl_mrp_tarea_tipo"
        UcNavegador1.QueryBuscar = "SELECT id_tarea_tipo Código, ttp_descripcion Descripción, CASE id_estado WHEN 1 THEN 'Alta' ELSE 'Eliminado' END Estado FROM " + UcNavegador1.NombreTabla + " ORDER BY id_tarea_tipo ASC"
        UcNavegador1.IniciarNavegador()
    End Sub

#Region "Navegador"
    Private Sub Navegador1_posNuevo(sender As Object, e As EventArgs) Handles UcNavegador1.posNuevo
        Try
            ActiveControl = tbDescripcion
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
#End Region
End Class