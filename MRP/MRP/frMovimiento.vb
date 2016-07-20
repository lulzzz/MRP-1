Public Class frMovimiento
#Region "Documentación"
    '----------------------------------------------------------------------------------------------------
    'FECHA:         18/07/2016 
    'DESARROLLADOR: Kevin Gutierrez
    'DESCRIPCIÓN:   Transaccion de Movimientos
    '----------------------------------------------------------------------------------------------------
#End Region
    Dim ControlesMaestros As New ArrayList
    Dim dtTipo As New DataTable
    Dim dtBodega As New DataTable

    Private Sub frMovimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        csNegocio.CargarCombobox(cbTipo, dtTipo, "SELECT id_movimiento_tipo Value, mtp_descripcion Display FROM tbl_mrp_movimiento_tipo ORDER BY id_movimiento_tipo ASC")
        csNegocio.CargarCombobox(cbBodega, dtBodega, "SELECT id_bodega Value, bdg_nombre Display FROM tbl_mrp_bodega ORDER BY id_bodega ASC")
        ControlesMaestros.Add(tbCodigo)
        ControlesMaestros.Add(tbTipo)
        ControlesMaestros.Add(tbBodega)
        ControlesMaestros.Add(tbCantidad)
        ControlesMaestros.Add(tbFecha)
        ControlesMaestros.Add(tbDescripcion)
        ControlesMaestros.Add(tbEstado)
        UcNavegador1.ControlesMaestros = ControlesMaestros
        UcNavegador1.NombreTabla = "tbl_mrp_movimiento"
        UcNavegador1.QueryBuscar = "SELECT id_movimiento Código, id_movimiento_tipo TipoMovimiento, id_bodega Bodega, mov_numero Cantidad, mov_fecha Fecha, mov_descripcion Descripcion,  CASE id_estado WHEN 1 THEN 'Alta' ELSE 'Eliminado' END Estado FROM " +
                                    UcNavegador1.NombreTabla + "INNER JOIN tbl_mrp_movimiento_tipo ON" + UcNavegador1.NombreTabla + ".id_movimiento_tipo = tbl_mrp_movimiento_tipo.id_movimiento_tipo" +
                                    "INNER JOIN tbl_mrp_bodega ON" + UcNavegador1.NombreTabla + ".id_bodega = tbl_mrp_bodega.id_bodega" + " ORDER BY id_movimiento ASC"
        UcNavegador1.IniciarNavegador()

    End Sub
End Class