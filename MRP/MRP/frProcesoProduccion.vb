Public Class frProcesoProduccion
#Region "Documentación"
    '----------------------------------------------------------------------------------------------------
    'FECHA:         06/07/2016 
    'DESARROLLADOR: Pablo Zapparoli
    'DESCRIPCIÓN:   Proceso de Producción
    '----------------------------------------------------------------------------------------------------
#End Region

    Dim ControlesMaestros As New ArrayList

    Private Sub frProcesoProduccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ControlesMaestros.Add(tbCodigo)
        ControlesMaestros.Add(tbNombre)
        ControlesMaestros.Add(tbDescripcion)
        ControlesMaestros.Add(tbDestinatario)
        ControlesMaestros.Add(tbFechaSolicitud)
        ControlesMaestros.Add(tbFechaInicio)
        ControlesMaestros.Add(tbFechaFinal)
        ControlesMaestros.Add(tbFechaEntrega)
        ControlesMaestros.Add(tbTotal)
        ControlesMaestros.Add(tbEmpresa)
        ControlesMaestros.Add(tbEstado)
        UcNavegador1.ControlesMaestros = ControlesMaestros
        UcNavegador1.NombreTabla = "tbl_mrp_proceso_produccion"
        UcNavegador1.QueryBuscar = "SELECT id_proceso_produccion Código, ppd_nombre Nombre, ppd_descripcion Descripción, ppd_destinatario Destinatario, ppd_fecha_solicitud 'Fecha de Solicitud', ppd_fecha_inicio 'Fecha de Inicio', ppd_fecha_final 'Fecha Final', ppd_fecha_entrega 'Fecha de Entrega', ppd_total Total, CASE id_estado WHEN 1 THEN 'Alta' ELSE 'Eliminado' END Estado FROM " + UcNavegador1.NombreTabla + " WHERE id_empresa=" + csDatos.IdEmpresa.ToString + " ORDER BY id_proceso_produccion ASC"
        UcNavegador1.IniciarNavegador()
    End Sub

#Region "Navegador"
    Private Sub Navegador1_posNuevo(sender As Object, e As EventArgs) Handles UcNavegador1.posNuevo
        Try
            tbEmpresa.Text = csDatos.IdEmpresa.ToString
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

    Private Sub dpFechaSolicitud_ValueChanged(sender As Object, e As EventArgs) Handles dpFechaSolicitud.ValueChanged
        tbFechaSolicitud.Text = dpFechaSolicitud.Value.ToString("yyyy/MM/dd")
    End Sub

    Private Sub tbFechaSolicitud_TextChanged(sender As Object, e As EventArgs) Handles tbFechaSolicitud.TextChanged
        If tbFechaSolicitud.Text = String.Empty Then
            dpFechaSolicitud.Value = Date.Now
            tbFechaSolicitud.Text = dpFechaSolicitud.Value.ToString("yyyy/MM/dd")
        Else
            dpFechaSolicitud.Value = CDate(tbFechaSolicitud.Text)
        End If
    End Sub

    Private Sub dpFechaEntrega_ValueChanged(sender As Object, e As EventArgs) Handles dpFechaEntrega.ValueChanged
        tbFechaEntrega.Text = dpFechaEntrega.Value.ToString("yyyy/MM/dd")
    End Sub

    Private Sub tbFechaEntrega_TextChanged(sender As Object, e As EventArgs) Handles tbFechaEntrega.TextChanged
        If tbFechaEntrega.Text = String.Empty Then
            dpFechaEntrega.Value = Date.Now
            tbFechaEntrega.Text = dpFechaEntrega.Value.ToString("yyyy/MM/dd")
        Else
            dpFechaEntrega.Value = CDate(tbFechaEntrega.Text)
        End If
    End Sub

    Private Sub dpFechaInicio_ValueChanged(sender As Object, e As EventArgs) Handles dpFechaInicio.ValueChanged
        tbFechaInicio.Text = dpFechaInicio.Value.ToString("yyyy/MM/dd")
    End Sub

    Private Sub tbFechaInicio_TextChanged(sender As Object, e As EventArgs) Handles tbFechaInicio.TextChanged
        If tbFechaInicio.Text = String.Empty Then
            dpFechaInicio.Value = Date.Now
            tbFechaInicio.Text = dpFechaInicio.Value.ToString("yyyy/MM/dd")
        Else
            dpFechaInicio.Value = CDate(tbFechaInicio.Text)
        End If
    End Sub

    Private Sub dpFechaFinal_ValueChanged(sender As Object, e As EventArgs) Handles dpFechaFinal.ValueChanged
        tbFechaFinal.Text = dpFechaFinal.Value.ToString("yyyy/MM/dd")
    End Sub

    Private Sub tbFechaFinal_TextChanged(sender As Object, e As EventArgs) Handles tbFechaFinal.TextChanged
        If tbFechaFinal.Text = String.Empty Then
            dpFechaFinal.Value = Date.Now
            tbFechaFinal.Text = dpFechaFinal.Value.ToString("yyyy/MM/dd")
        Else
            dpFechaFinal.Value = CDate(tbFechaFinal.Text)
        End If
    End Sub
#End Region
End Class