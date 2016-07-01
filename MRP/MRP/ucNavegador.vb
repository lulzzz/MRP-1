Public Class ucNavegador
    Public Event preNuevo As EventHandler
    Public Event preGuardar As EventHandler
    Public Event preEliminar As EventHandler
    Public Event posNuevo As EventHandler
    Public Event posGuardar As EventHandler
    Public Event posEliminar As EventHandler
    Public DatosEntrada As New ArrayList
    Public EjecutarEvento As Boolean = False
    Public NombreTabla As String = String.Empty
    Public QueryBuscar As String = String.Empty
    Private DatosSalida As New DataTable
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
            csDatos.ConsultarQuery(DatosSalida, "SELECT * FROM " + NombreTabla)
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
                For i As Integer = 0 To DatosEntrada.Count - 1
                    If DatosSalida.Rows.Count > 0 Then
                        CType(DatosEntrada(i), TextBox).Text = CStr(DatosSalida.Rows(Contador)(i))
                    Else
                        CType(DatosEntrada(i), TextBox).Text = String.Empty
                    End If
                Next
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
                For i As Integer = 0 To DatosEntrada.Count - 1
                    CType(DatosEntrada.Item(i), TextBox).Text = String.Empty
                Next
                CType(DatosEntrada.Item(DatosEntrada.Count - 1), TextBox).Text = "1"
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
                If CType(DatosEntrada.Item(0), TextBox).Text = String.Empty Then
                    Nuevo = True
                End If
                If csNegocio.GuardarRegistro(Nuevo, NombreTabla, DatosEntrada) Then
                    MessageBox.Show("Registro guardado correctamente")
                    RecargarNavegador()
                    LanzarEvento("PosGuardar")
                    If Nuevo Then btNuevo_Click(Me, e)
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
            If CType(DatosEntrada.Item(DatosEntrada.Count - 1), TextBox).Text = "1" Then
                If MessageBox.Show("Desea eleminar el registro?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    LanzarEvento("PreEliminar")
                    If EjecutarEvento Then
                        If csNegocio.EliminarRegistro(True, NombreTabla, DatosEntrada) Then
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
                        If csNegocio.EliminarRegistro(False, NombreTabla, DatosEntrada) Then
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

    Private Sub btBuscar_Click(sender As Object, e As EventArgs)
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
End Class
