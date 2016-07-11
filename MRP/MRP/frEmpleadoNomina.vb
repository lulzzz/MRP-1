Public Class frEmpleadoNomina
#Region "Documentación"
    '----------------------------------------------------------------------------------------------------
    'FECHA:         10/07/2016 
    'DESARROLLADOR: Marlon Aldana
    'DESCRIPCIÓN:   Catálogo de empleados nómina
    '----------------------------------------------------------------------------------------------------
#End Region

    Dim ControlesMaestros As New ArrayList
    Dim dtEmpleados As New DataTable
    Dim dtNominas As New DataTable
    Dim dtDepartamentos As New DataTable
    Dim dtPuestos As New DataTable

    Private Sub frEmpleadoNomina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        csNegocio.CargarCombobox(cbEmpleado, dtEmpleados, "SELECT id_empleado Value, emp_primer_nombre+' '+emp_segundo_nombre+' '+emp_primer_apellido+' '+emp_segundo_apellido Display FROM tbl_mrp_empleado ORDER BY id_empleado ASC")
        csNegocio.CargarCombobox(cbNomina, dtNominas, "SELECT id_nomina Value, nmn_descripcion Display FROM tbl_mrp_nomina ORDER BY id_nomina ASC")
        csNegocio.CargarCombobox(cbDepartamento, dtDepartamentos, "SELECT id_departamento Value, dpt_descripcion Display FROM tbl_mrp_departamento ORDER BY id_departamento ASC")
        csNegocio.CargarCombobox(cbPuesto, dtPuestos, "SELECT id_puesto Value, pst_nombre Display FROM tbl_mrp_puesto ORDER BY id_puesto ASC")
        ControlesMaestros.Add(tbCodigo)
        ControlesMaestros.Add(tbEmpleado)
        ControlesMaestros.Add(tbNomina)
        ControlesMaestros.Add(tbDepartamento)
        ControlesMaestros.Add(tbPuesto)
        ControlesMaestros.Add(tbFechaIngreso)
        ControlesMaestros.Add(tbSalarioOrdinario)
        ControlesMaestros.Add(tbValorHoraOrdinaria)
        ControlesMaestros.Add(tbValorHoraExtraordinaria)
        ControlesMaestros.Add(tbEmpresa)
        ControlesMaestros.Add(tbEstado)
        UcNavegador1.ControlesMaestros = ControlesMaestros
        UcNavegador1.NombreTabla = "tbl_mrp_empleado_nomina"
        UcNavegador1.QueryBuscar = "SELECT id_empleado_nomina Código, emp_primer_nombre+' '+emp_primer_apellido Empleado, nmn_descripcion Nómina, dpt_nombre Departamento, pst_nombre Puesto, emn_fecha_ingreso 'Fecha de Ingreso', emn_salario_ordinario 'Salario Ordinario', emn_valor_hora_ordinaria 'Hora Ordinaria', enm_valor_hora_extraordinaria 'Hora Extraordinaria', CASE a.id_estado WHEN 1 THEN 'Alta' ELSE 'Eliminado' END Estado FROM " + UcNavegador1.NombreTabla + "  a JOIN tbl_mrp_empleado b ON a.id_empleado=b.id_empleado JOIN tbl_mrp_nomina c ON a.id_nomina=c.id_nomina JOIN tbl_mrp_departamento d ON a.id_departamento=d.id_departamento JOIN tbl_mrp_puesto e ON a.id_puesto=e.id_puesto WHERE a.id_empresa=" + csDatos.IdEmpresa.ToString + " ORDER BY id_empleado_nomina ASC"
        UcNavegador1.IniciarNavegador()
    End Sub

#Region "Navegador"
    Private Sub Navegador1_posNuevo(sender As Object, e As EventArgs) Handles UcNavegador1.posNuevo
        Try
            csNegocio.CargarCombobox(cbEmpleado, dtEmpleados, "SELECT id_empleado Value, emp_primer_nombre+' '+emp_segundo_nombre+' '+emp_primer_apellido+' '+emp_segundo_apellido Display FROM tbl_mrp_empleado ORDER BY id_empleado ASC")
            csNegocio.CargarCombobox(cbNomina, dtNominas, "SELECT id_nomina Value, nmn_descripcion Display FROM tbl_mrp_nomina ORDER BY id_nomina ASC")
            csNegocio.CargarCombobox(cbDepartamento, dtDepartamentos, "SELECT id_departamento Value, dpt_descripcion Display FROM tbl_mrp_departamento ORDER BY id_departamento ASC")
            csNegocio.CargarCombobox(cbPuesto, dtPuestos, "SELECT id_puesto Value, pst_nombre Display FROM tbl_mrp_puesto ORDER BY id_puesto ASC")
            tbEmpresa.Text = csDatos.IdEmpresa.ToString
            ActiveControl = cbEmpleado
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

    Private Sub cbEmpleado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEmpleado.SelectedIndexChanged
        If cbEmpleado.SelectedIndex >= 0 Then
            tbEmpleado.Text = CStr(CType(cbEmpleado.DataSource, DataTable).Rows(cbEmpleado.SelectedIndex)("Value"))
        Else
            tbEmpleado.Text = String.Empty
        End If
    End Sub

    Private Sub tbEmpleado_TextChanged(sender As Object, e As EventArgs) Handles tbEmpleado.TextChanged
        If tbEmpleado.Text = String.Empty Then
            cbEmpleado.SelectedIndex = -1
        Else
            cbEmpleado.SelectedIndex = csNegocio.ObtenerIndexCombobox(cbEmpleado, tbEmpleado.Text)
        End If
    End Sub

    Private Sub cbNomina_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbNomina.SelectedIndexChanged
        If cbNomina.SelectedIndex >= 0 Then
            tbNomina.Text = CStr(CType(cbNomina.DataSource, DataTable).Rows(cbNomina.SelectedIndex)("Value"))
        Else
            tbNomina.Text = String.Empty
        End If
    End Sub

    Private Sub tbNomina_TextChanged(sender As Object, e As EventArgs) Handles tbNomina.TextChanged
        If tbNomina.Text = String.Empty Then
            cbNomina.SelectedIndex = -1
        Else
            cbNomina.SelectedIndex = csNegocio.ObtenerIndexCombobox(cbNomina, tbNomina.Text)
        End If
    End Sub

    Private Sub cbDepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDepartamento.SelectedIndexChanged
        If cbDepartamento.SelectedIndex >= 0 Then
            tbDepartamento.Text = CStr(CType(cbDepartamento.DataSource, DataTable).Rows(cbDepartamento.SelectedIndex)("Value"))
        Else
            tbDepartamento.Text = String.Empty
        End If
    End Sub

    Private Sub tbDepartamento_TextChanged(sender As Object, e As EventArgs) Handles tbDepartamento.TextChanged
        If tbDepartamento.Text = String.Empty Then
            cbDepartamento.SelectedIndex = -1
        Else
            cbDepartamento.SelectedIndex = csNegocio.ObtenerIndexCombobox(cbDepartamento, tbDepartamento.Text)
        End If
    End Sub

    Private Sub cbPuesto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPuesto.SelectedIndexChanged
        If cbPuesto.SelectedIndex >= 0 Then
            tbPuesto.Text = CStr(CType(cbPuesto.DataSource, DataTable).Rows(cbPuesto.SelectedIndex)("Value"))
        Else
            tbPuesto.Text = String.Empty
        End If
    End Sub

    Private Sub tbPuesto_TextChanged(sender As Object, e As EventArgs) Handles tbPuesto.TextChanged
        If tbPuesto.Text = String.Empty Then
            cbPuesto.SelectedIndex = -1
        Else
            cbPuesto.SelectedIndex = csNegocio.ObtenerIndexCombobox(cbPuesto, tbPuesto.Text)
        End If
    End Sub

    Private Sub dpFechaIngreso_ValueChanged(sender As Object, e As EventArgs) Handles dpFechaIngreso.ValueChanged
        tbFechaIngreso.Text = dpFechaIngreso.Value.ToString("yyyy/MM/dd")
    End Sub

    Private Sub tbFechaIngreso_TextChanged(sender As Object, e As EventArgs) Handles tbFechaIngreso.TextChanged
        If tbFechaIngreso.Text = String.Empty Then
            dpFechaIngreso.Value = Date.Now
            tbFechaIngreso.Text = dpFechaIngreso.Value.ToString("yyyy/MM/dd")
        Else
            dpFechaIngreso.Value = CDate(tbFechaIngreso.Text)
        End If
    End Sub
#End Region
End Class