Public Class frSolicitud
#Region "Documentación"
    '----------------------------------------------------------------------------------------------------
    'FECHA:         18/07/2016 
    'DESARROLLADOR: Kevin Gutierrez
    'DESCRIPCIÓN:   Transaccion de Solicitudes
    '----------------------------------------------------------------------------------------------------
#End Region
    Dim ControlesMaestros As New ArrayList
    Dim dtStatus As New DataTable

    Private Sub frSolicitud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        csNegocio.CargarCombobox(cbStatus, dtStatus, "SELECT id_status Value, sts_descripcion Display FROM tbl_mrp_status ORDER BY id_status ASC")
        ControlesMaestros.Add(tbCodigo)
        ControlesMaestros.Add(tbNombre)
        ControlesMaestros.Add(tbDescripcion)
        ControlesMaestros.Add(tbFechaSolicitud)
        ControlesMaestros.Add(tbFechaEntrega)
        ControlesMaestros.Add(tbStatus)
        ControlesMaestros.Add(tbEstado)
        UcNavegador1.ControlesMaestros = ControlesMaestros
        UcNavegador1.NombreTabla = "tbl_mrp_solicitud"
        UcNavegador1.QueryBuscar = "SELECT id_solicitud Código, sol_nombre NombreSolicitud, sol_descripcion Descripcion, sol_fecha_solicitud FechaSolicitud, sol_fecha_entrega FechaEntrega, id_status Estatus,  CASE id_estado WHEN 1 THEN 'Alta' ELSE 'Eliminado' END Estado FROM " +
                                    UcNavegador1.NombreTabla + "INNER JOIN tbl_mrp_status ON" + UcNavegador1.NombreTabla + ".id_status = tbl_mrp_status.id_status ORDER BY id_solicitud ASC"
        UcNavegador1.IniciarNavegador()
    End Sub
End Class