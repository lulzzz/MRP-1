Public Class frMoneda
    Dim DatosEnviados As New ArrayList
    Dim dtEstados As New DataTable

    Private Sub frMoneda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DatosEnviados.Add(tbCodigo)
        DatosEnviados.Add(tbDescripcion)
        DatosEnviados.Add(tbSimbolo)
        DatosEnviados.Add(tbEstado)
        UcNavegador1.DatosEntrada = DatosEnviados
        UcNavegador1.NombreTabla = "tbl_mrp_moneda"
        UcNavegador1.QueryBuscar = "SELECT id_moneda Código, mnd_descripcion Descripción, mnd_simbolo Símbolo, CASE id_estado WHEN 1 THEN 'Alta' ELSE 'Eliminado' END Estado FROM " + UcNavegador1.NombreTabla
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
            ActiveControl = tbDescripcion
            ActiveControl.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Navegador1_preGuardar(sender As Object, e As EventArgs) Handles UcNavegador1.preGuardar
        Try
            UcNavegador1.EjecutarEvento = csNegocio.ValidarControles(DatosEnviados)
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
#End Region
End Class