Public Class frBodega
#Region "Documentación"
    '----------------------------------------------------------------------------------------------------
    'FECHA:         02/07/2016 
    'DESARROLLADOR: Kevin Gutiérrez
    'DESCRIPCIÓN:   Catálogo de bodegas
    '----------------------------------------------------------------------------------------------------
#End Region

    Dim ControlesMaestros As New ArrayList

    Private Sub frBodega_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ControlesMaestros.Add(tbCodigo)
        ControlesMaestros.Add(tbNombre)
        ControlesMaestros.Add(tbDescripcion)
        ControlesMaestros.Add(tbFechaCreacion)
        ControlesMaestros.Add(tbEmpresa)
        ControlesMaestros.Add(tbEstado)
        UcNavegador1.ControlesMaestros = ControlesMaestros
        UcNavegador1.NombreTabla = "tbl_mrp_bodega"
        UcNavegador1.QueryBuscar = "SELECT id_bodega Código, bdg_nombre Nombre, bdg_descripcion Descripción, bdg_fecha_creacion 'Fecha de Creación', CASE id_estado WHEN 1 THEN 'Alta' ELSE 'Eliminado' END Estado FROM " + UcNavegador1.NombreTabla + " WHERE id_empresa=" + csDatos.IdEmpresa.ToString + " ORDER BY id_bodega ASC"
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

    Private Sub dpFechaCreacion_ValueChanged(sender As Object, e As EventArgs) Handles dpFechaCreacion.ValueChanged
        tbFechaCreacion.Text = dpFechaCreacion.Value.ToString("yyyy/MM/dd")
    End Sub

    Private Sub tbFechaCreacion_TextChanged(sender As Object, e As EventArgs) Handles tbFechaCreacion.TextChanged
        If tbFechaCreacion.Text = String.Empty Then
            dpFechaCreacion.Value = Date.Now
            tbFechaCreacion.Text = dpFechaCreacion.Value.ToString("yyyy/MM/dd")
        Else
            dpFechaCreacion.Value = CDate(tbFechaCreacion.Text)
        End If
    End Sub
#End Region
End Class