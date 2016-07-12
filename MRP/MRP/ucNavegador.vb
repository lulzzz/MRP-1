Public Class ucNavegador
    Public Event preNuevo As EventHandler
    Public Event preGuardar As EventHandler
    Public Event preEliminar As EventHandler
    Public Event preCerrar As EventHandler
    Public Event posNuevo As EventHandler
    Public Event posGuardar As EventHandler
    Public Event posEliminar As EventHandler
    Public ControlesMaestros As New ArrayList
    Public ControlesDetalles As New ArrayList
    Public EjecutarEvento As Boolean = False
    Public NombreTabla As String = String.Empty
    Public QueryBuscar As String = String.Empty
    Private DatosSalida As New DataTable
    Private Guardado As Boolean = False
    Private Nuevo As Boolean = False
    Private Contador As Integer = 0

    Public Sub IniciarNavegador()
        Try
            Contador = 0
            RecargarNavegador()
            Dim e As New EventArgs
            btNuevo_Click(Me, e)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub RecargarNavegador()
        Try
            Dim Query As String
            Query = "SELECT * FROM " + NombreTabla
            If NombreTabla <> "tbl_mrp_empresa" AndAlso csNegocio.ValidarTablaEmpresa(NombreTabla) Then
                Query += " WHERE id_empresa=" + csDatos.IdEmpresa.ToString
            End If
            csDatos.ConsultarQuery(DatosSalida, Query)
            MostrarDatos()
            RestriccionesBotones(True)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Protected Overridable Sub LanzarEvento(Evento As String)
        Try
            Dim e As EventArgs = New EventArgs()
            Select Case Evento
                Case "PreNuevo"
                    RaiseEvent preNuevo(Me, e)
                Case "PosNuevo"
                    RaiseEvent posNuevo(Me, e)
                Case "PreGuardar"
                    RaiseEvent preGuardar(Me, e)
                Case "PosGuardar"
                    RaiseEvent posGuardar(Me, e)
                Case "PreEliminar"
                    RaiseEvent preEliminar(Me, e)
                Case "PosEliminar"
                    RaiseEvent posEliminar(Me, e)
                Case "PreCerrar"
                    RaiseEvent preCerrar(Me, e)
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub RestriccionesBotones(ByVal Activado As Boolean)
        Try
            btNuevo.Enabled = Activado
            btEliminar.Enabled = Activado
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MostrarDatos()
        Try
            If Not IsNothing(DatosSalida) Then
                For i As Integer = 0 To ControlesMaestros.Count - 1
                    If DatosSalida.Rows.Count > 0 Then
                        CType(ControlesMaestros(i), TextBox).Text = CStr(DatosSalida.Rows(Contador)(i))
                    Else
                        CType(ControlesMaestros(i), TextBox).Text = String.Empty
                    End If
                Next
                If Not IsNothing(ControlesDetalles) AndAlso CType(ControlesMaestros(0), TextBox).Text <> String.Empty Then
                    For j As Integer = 0 To ControlesDetalles.Count - 1
                        csNegocio.ConsultarRegistroDetalle(CType(ControlesDetalles(j), DataGridView), NombreTabla, CType(ControlesMaestros(0), TextBox).Text)
                    Next
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btNuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        Try
            EjecutarEvento = True
            LanzarEvento("PreNuevo")
            If EjecutarEvento Then
                For i As Integer = 0 To ControlesMaestros.Count - 1
                    CType(ControlesMaestros.Item(i), TextBox).Text = String.Empty
                Next
                If Not IsNothing(ControlesDetalles) Then
                    For j As Integer = 0 To ControlesDetalles.Count - 1
                        CType(ControlesDetalles(j), DataGridView).Rows.Clear()
                    Next
                End If
                CType(ControlesMaestros.Item(ControlesMaestros.Count - 1), TextBox).Text = "1"
                LanzarEvento("PosNuevo")
                RestriccionesBotones(False)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        Try
            EjecutarEvento = True
            LanzarEvento("PreGuardar")
            If EjecutarEvento Then
                Nuevo = False
                If CType(ControlesMaestros.Item(0), TextBox).Text = String.Empty Then
                    Nuevo = True
                End If
                csDatos.IniciarTransaccion()
                If csNegocio.GuardarRegistroMaestro(Nuevo, NombreTabla, ControlesMaestros, False) Then
                    Guardado = True
                    If Not IsNothing(ControlesDetalles) Then
                        If CType(ControlesMaestros(0), TextBox).Text = String.Empty Then CType(ControlesMaestros(0), TextBox).Text = csNegocio.ObtenerUltimoIdporTabla(NombreTabla)
                        For j As Integer = 0 To ControlesDetalles.Count - 1
                            If Not csNegocio.GuardarRegistroDetalle(CType(ControlesDetalles(j), DataGridView), NombreTabla, CType(ControlesMaestros(0), TextBox).Text, False) Then
                                Guardado = False
                            End If
                        Next
                    End If
                    If Guardado Then
                        csDatos.FinalizarTransaccion(True)
                        MessageBox.Show("Registro guardado correctamente")
                        RecargarNavegador()
                        LanzarEvento("PosGuardar")
                        If Nuevo Then btNuevo_Click(Me, e)
                    Else
                        csDatos.FinalizarTransaccion(False)
                        MessageBox.Show("Hubo un error al realizar el proceso", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Hubo un error al realizar el proceso", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btEliminar_Click(sender As Object, e As EventArgs) Handles btEliminar.Click
        Try
            If CType(ControlesMaestros.Item(ControlesMaestros.Count - 1), TextBox).Text = "1" Then
                If MessageBox.Show("Desea eleminar el registro?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    LanzarEvento("PreEliminar")
                    If EjecutarEvento Then
                        If csNegocio.EliminarRegistroMaestro(True, NombreTabla, ControlesMaestros) Then
                            MessageBox.Show("Registro eliminado correctamente")
                            RecargarNavegador()
                            MostrarDatos()
                            LanzarEvento("PosEliminar")
                        Else
                            MessageBox.Show("Hubo un error al realizar el proceso", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End If
                End If
            Else
                If csDatos.NombreUsuario.ToUpper = "ADMINISTRADOR" Then
                    If MessageBox.Show("Desea dar de alta el registro?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        If csNegocio.EliminarRegistroMaestro(False, NombreTabla, ControlesMaestros) Then
                            MessageBox.Show("Registro dado de alta correctamente")
                            RecargarNavegador()
                            MostrarDatos()
                        Else
                            MessageBox.Show("Hubo un error al realizar el proceso", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        Try
            Dim frBuscar As frBuscar = New frBuscar()
            frBuscar.QueryBuscar = QueryBuscar
            frBuscar.ShowDialog()
            If frBuscar.EjecutarBusqueda Then
                Contador = frBuscar.Contador
                MostrarDatos()
                RestriccionesBotones(True)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btPrimero_Click(sender As Object, e As EventArgs) Handles btPrimero.Click
        Try
            Contador = 0
            MostrarDatos()
            RestriccionesBotones(True)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btAnterior_Click(sender As Object, e As EventArgs) Handles btAnterior.Click
        Try
            If Contador >= 0 Then
                If Contador > 0 Then
                    Contador -= 1
                End If
                MostrarDatos()
                RestriccionesBotones(True)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btSiguiente_Click(sender As Object, e As EventArgs) Handles btSiguiente.Click
        Try
            If Contador <= DatosSalida.Rows.Count - 1 Then
                If Contador < DatosSalida.Rows.Count - 1 Then
                    Contador += 1
                End If
                MostrarDatos()
                RestriccionesBotones(True)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btUltimo_Click(sender As Object, e As EventArgs) Handles btUltimo.Click
        Try
            Contador = DatosSalida.Rows.Count - 1
            MostrarDatos()
            RestriccionesBotones(True)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Try
            LanzarEvento("PreCerrar")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
