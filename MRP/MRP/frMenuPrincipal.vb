Public Class frMenuPrincipal
    Dim frFondo As frFondo

    Private Sub frMenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            frFondo = New frFondo
            frFondo.MdiParent = Me
            frFondo.Width = ClientSize.Width - 4
            frFondo.Height = ClientSize.Height - (msMenuPrincipal.Height + ssBarraEstado.Height + 4)
            frFondo.Show()
            tsEmpresa.Text = csDatos.Empresa
            tsUsuario.Text = csDatos.NombreUsuario
            tsInicioSesion.Text = Date.Now.ToString("dd/MM/yyyy h:mm tt")
            If csDatos.NombreUsuario.ToUpper = "ADMINISTRADOR" Then
                tsOpciones.Visible = True
            Else
                tsOpciones.Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frMenuPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            If tsUsuario.Text <> String.Empty Then Application.Exit()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frMenuPrincipal_ClientSizeChanged(sender As Object, e As EventArgs) Handles Me.ClientSizeChanged
        If Not IsNothing(frFondo) Then
            frFondo.Width = ClientSize.Width - 4
            frFondo.Height = ClientSize.Height - (msMenuPrincipal.Height + ssBarraEstado.Height + 4)
        End If
    End Sub

#Region "Archivo"
    Private Sub miCambiarEmpresa_Click(sender As Object, e As EventArgs) Handles miCambiarEmpresa.Click
        Try
            csDatos.IdEmpresa = 0
            csDatos.Empresa = String.Empty
            tsUsuario.Text = String.Empty
            Owner.ActiveControl.Focus()
            Owner.Show()
            Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub miCerrarSesion_Click(sender As Object, e As EventArgs) Handles miCerrarSesion.Click
        Try
            csDatos.IdUsuario = 0
            csDatos.Usuario = String.Empty
            csDatos.NombreUsuario = String.Empty
            csDatos.IdEmpresa = 0
            csDatos.Empresa = String.Empty
            tsUsuario.Text = String.Empty
            Owner.Owner.ActiveControl.Focus()
            Owner.Owner.Show()
            Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub miSalir_Click(sender As Object, e As EventArgs) Handles miSalir.Click
        Try
            Application.Exit()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "Catálogos"

#End Region

#Region "Procesos"

#End Region

#Region "Reportes"

#End Region

#Region "Opciones"
    Private Sub miEmpresas_Click(sender As Object, e As EventArgs) Handles miEmpresas.Click

    End Sub

    Private Sub miMonedas_Click(sender As Object, e As EventArgs) Handles miMonedas.Click
        Dim frMoneda As New frMoneda
        frMoneda.MdiParent = Me
        frMoneda.Show()
    End Sub

    Private Sub miPaises_Click(sender As Object, e As EventArgs) Handles miPaises.Click

    End Sub

    Private Sub miUsuarios_Click(sender As Object, e As EventArgs) Handles miUsuarios.Click

    End Sub
#End Region

#Region "Ayuda"
    Private Sub miAcercaDeMRP_Click(sender As Object, e As EventArgs) Handles miAcercaDeMRP.Click
        Try
            Dim frAcercaDeMRP As New frAcercaDeMRP
            frAcercaDeMRP.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


#End Region
End Class