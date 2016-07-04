Public Class frEmpresa
    Dim ControlesMaestros As New ArrayList

    Private Sub frEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ControlesMaestros.Add(tbCodigo)
        ControlesMaestros.Add(tbNombre)
        ControlesMaestros.Add(tbRazonSocial)
        ControlesMaestros.Add(tbDescripcion)
        ControlesMaestros.Add(tbPais)
        ControlesMaestros.Add(tbMoneda)
        ControlesMaestros.Add(tbIdentificacionTributaria)
        ControlesMaestros.Add(tbDireccion)
        ControlesMaestros.Add(tbTelefono)
        ControlesMaestros.Add(tbEstado)
        UcNavegador1.ControlesMaestros = ControlesMaestros
        UcNavegador1.NombreTabla = "tbl_mrp_empresa"
        UcNavegador1.QueryBuscar = "SELECT id_empresa Código, emp_nombre Nombre, emp_razon_social 'Razón Social', emp_descripcion Descripción, pas_descripcion País, mnd_descripcion Moneda, emp_identificacion_tributaria 'Identificación Tributaria', emp_direccion Dirección, emp_telefono Teléfono, CASE a.id_estado WHEN 1 THEN 'Alta' ELSE 'Eliminado' END Estado FROM " + UcNavegador1.NombreTabla + " a JOIN tbl_mrp_pais b ON a.id_pais=b.id_pais JOIN tbl_mrp_moneda c ON a.id_moneda=c.id_moneda ORDER BY id_empresa ASC"
        UcNavegador1.IniciarNavegador()
    End Sub

#Region "Navegador"
    Private Sub Navegador1_preNuevo(sender As Object, e As EventArgs) Handles UcNavegador1.preNuevo
        Try

        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

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
            UcNavegador1.EjecutarEvento = csNegocio.ValidarControlesMaestros(ControlesMaestros)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Navegador1_posGuardar(sender As Object, e As EventArgs) Handles UcNavegador1.posGuardar
        Try

        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Navegador1_preEliminar(sender As Object, e As EventArgs) Handles UcNavegador1.preEliminar
        Try

        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Navegador1_posEliminar(sender As Object, e As EventArgs) Handles UcNavegador1.posEliminar
        Try

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

    Private Sub cbPais_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPais.SelectedIndexChanged

    End Sub

    Private Sub tbPais_TextChanged(sender As Object, e As EventArgs) Handles tbPais.TextChanged

    End Sub

    Private Sub cbMoneda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMoneda.SelectedIndexChanged

    End Sub

    Private Sub tbMoneda_TextChanged(sender As Object, e As EventArgs) Handles tbMoneda.TextChanged

    End Sub
#End Region
End Class