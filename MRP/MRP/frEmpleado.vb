Public Class frEmpleado
#Region "Documentación"
    '----------------------------------------------------------------------------------------------------
    'FECHA:         02/07/2016 
    'DESARROLLADOR: Marlon Aldana
    'DESCRIPCIÓN:   Catálogo de empleados
    '----------------------------------------------------------------------------------------------------
#End Region

    Dim ControlesMaestros As New ArrayList
    Dim dtPaises As New DataTable
    Dim dtGeneros As New DataTable

    Private Sub frEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        csNegocio.CargarCombobox(cbPais, dtPaises, "SELECT id_pais Value, pas_descripcion Display FROM tbl_mrp_pais ORDER BY id_pais ASC")
        cbGenero.Items.Add("Masculino")
        cbGenero.Items.Add("Femenino")
        cbTipoIdentificacion.Items.Add("DPI")
        cbTipoIdentificacion.Items.Add("Pasaporte")
        cbTipoIdentificacion.Items.Add("Cédula")
        ControlesMaestros.Add(tbCodigo)
        ControlesMaestros.Add(tbPrimerNombre)
        ControlesMaestros.Add(tbSegundoNombre)
        ControlesMaestros.Add(tbPrimerApellido)
        ControlesMaestros.Add(tbSegundoApellido)
        ControlesMaestros.Add(tbIdentificacionTipo)
        ControlesMaestros.Add(tbIdentificacion)
        ControlesMaestros.Add(tbPais)
        ControlesMaestros.Add(tbFechaNacimiento)
        ControlesMaestros.Add(tbFechaIngreso)
        ControlesMaestros.Add(tbDireccion)
        ControlesMaestros.Add(tbTelefono)
        ControlesMaestros.Add(tbCorreo)
        ControlesMaestros.Add(tbGenero)
        ControlesMaestros.Add(tbProfesion)
        ControlesMaestros.Add(tbNit)
        ControlesMaestros.Add(tbEmpresa)
        ControlesMaestros.Add(tbEstado)
        UcNavegador1.ControlesMaestros = ControlesMaestros
        UcNavegador1.NombreTabla = "tbl_mrp_empleado"
        UcNavegador1.QueryBuscar = "Select id_empleado Código, emp_primer_nombre 'Primer nombre', emp_segundo_nombre 'Segundo Nombre', emp_primer_apellido 'Primer Apellido', emp_segundo_apellido 'Segundo Apellido', emp_identificacion_tipo 'Tipo de Identificación', emp_identificacion Identificación, emp_fecha_nacimiento 'Fecha de Nacimiento', emp_telefono Teléfono, emp_identificacion_tributaria Nit, CASE a.id_estado WHEN 1 THEN 'Alta' ELSE 'Eliminado' END Estado FROM " + UcNavegador1.NombreTabla + " a JOIN tbl_mrp_pais b ON a.id_pais=b.id_pais WHERE id_empresa=" + csDatos.IdEmpresa.ToString + " ORDER BY id_empleado ASC"
        UcNavegador1.IniciarNavegador()
    End Sub

#Region "Navegador"
    Private Sub Navegador1_posNuevo(sender As Object, e As EventArgs) Handles UcNavegador1.posNuevo
        Try
            csNegocio.CargarCombobox(cbPais, dtPaises, "SELECT id_pais Value, pas_descripcion Display FROM tbl_mrp_pais ORDER BY id_pais ASC")
            cbGenero.SelectedIndex = 0
            cbTipoIdentificacion.SelectedIndex = 0
            tbEmpresa.Text = csDatos.IdEmpresa.ToString
            ActiveControl = tbPrimerNombre
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

    Private Sub cbTipoIdentificacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTipoIdentificacion.SelectedIndexChanged
        Select Case cbTipoIdentificacion.SelectedIndex
            Case 0 : tbIdentificacionTipo.Text = "DPI"
            Case 1 : tbIdentificacionTipo.Text = "Pasaporte"
            Case 2 : tbIdentificacionTipo.Text = "Cédula"
            Case Else : tbIdentificacionTipo.Text = String.Empty
        End Select
    End Sub

    Private Sub tbIdentificacionTipo_TextChanged(sender As Object, e As EventArgs) Handles tbIdentificacionTipo.TextChanged
        Select Case tbIdentificacionTipo.Text
            Case "DPI" : cbTipoIdentificacion.SelectedIndex = 0
            Case "Pasaporte" : cbTipoIdentificacion.SelectedIndex = 1
            Case "Cédula" : cbTipoIdentificacion.SelectedIndex = 2
            Case Else : cbTipoIdentificacion.SelectedIndex = -1
        End Select
    End Sub

    Private Sub cbPais_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPais.SelectedIndexChanged
        If cbPais.SelectedIndex >= 0 Then
            tbPais.Text = CStr(CType(cbPais.DataSource, DataTable).Rows(cbPais.SelectedIndex)("Value"))
        Else
            tbPais.Text = String.Empty
        End If
    End Sub

    Private Sub tbPais_TextChanged(sender As Object, e As EventArgs) Handles tbPais.TextChanged
        If tbPais.Text = String.Empty Then
            cbPais.SelectedIndex = -1
        Else
            cbPais.SelectedIndex = csNegocio.ObtenerIndexCombobox(cbPais, tbPais.Text)
        End If
    End Sub

    Private Sub cbGenero_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGenero.SelectedIndexChanged
        Select Case cbGenero.SelectedIndex
            Case 0 : tbGenero.Text = "M"
            Case 1 : tbGenero.Text = "F"
            Case Else : tbGenero.Text = String.Empty
        End Select
    End Sub

    Private Sub tbGenero_TextChanged(sender As Object, e As EventArgs) Handles tbGenero.TextChanged
        Select Case tbGenero.Text
            Case "M" : cbGenero.SelectedIndex = 0
            Case "F" : cbGenero.SelectedIndex = 1
            Case Else : cbGenero.SelectedIndex = -1
        End Select
    End Sub

    Private Sub dpFechaNacimiento_ValueChanged(sender As Object, e As EventArgs) Handles dpFechaNacimiento.ValueChanged
        tbFechaNacimiento.Text = dpFechaNacimiento.Value.ToString("yyyy/MM/dd")
    End Sub

    Private Sub tbFechaNacimiento_TextChanged(sender As Object, e As EventArgs) Handles tbFechaNacimiento.TextChanged
        If tbFechaNacimiento.Text = String.Empty Then
            dpFechaNacimiento.Value = Date.Now
            tbFechaNacimiento.Text = dpFechaNacimiento.Value.ToString("yyyy/MM/dd")
        Else
            dpFechaNacimiento.Value = CDate(tbFechaNacimiento.Text)
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