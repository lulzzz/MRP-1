﻿Public Class frGastoPeriodo
    Dim ControlesMaestros As New ArrayList

    Private Sub frGastoPeriodo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ControlesMaestros.Add(tbCodigo)
        ControlesMaestros.Add(tbTareaTipo)
        ControlesMaestros.Add(tbAnio)
        ControlesMaestros.Add(tbMes)
        ControlesMaestros.Add(tbCantidad)
        ControlesMaestros.Add(tbEmpresa)
        ControlesMaestros.Add(tbEstado)
        UcNavegador1.ControlesMaestros = ControlesMaestros
        UcNavegador1.NombreTabla = "tbl_mrp_gasto_periodo"
        UcNavegador1.QueryBuscar = "SELECT id_tarea Código, ttp_descripcion 'Tipo de Tarea', tar_nombre Nombre, tar_descripcion Descripción, CASE a.id_estado WHEN 1 THEN 'Alta' ELSE 'Eliminado' END Estado FROM " + UcNavegador1.NombreTabla + " a JOIN tbl_mrp_tarea_tipo b ON a.id_tarea_tipo=b.id_tarea_tipo WHERE id_empresa=" + csDatos.IdEmpresa.ToString + " ORDER BY id_tarea ASC"
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