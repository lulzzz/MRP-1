Public Class frLogin
    Dim frLoginEmpresa As frLoginEmpresa

    Private Sub frLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ActiveControl = tbUsuario
            ActiveControl.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btAceptar_Click(sender As Object, e As EventArgs) Handles btAceptar.Click
        Try
            If csDatos.TestConexion("", "", "", "") Then
                If csDatos.ValidarCredenciales(tbUsuario.Text, tbContrasena.Text) Then
                    tbUsuario.Text = String.Empty
                    tbContrasena.Text = String.Empty
                    frLoginEmpresa = New frLoginEmpresa
                    frLoginEmpresa.Owner = Me
                    ActiveControl = tbUsuario
                    ActiveControl.Focus()
                    frLoginEmpresa.Show()
                    Hide()
                Else
                    tbUsuario.Text = String.Empty
                    tbContrasena.Text = String.Empty
                    MessageBox.Show("Usuario y/o contaseña inválida", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ActiveControl = tbUsuario
                    ActiveControl.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        Try
            Application.Exit()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btConfiguracion_Click(sender As Object, e As EventArgs) Handles btConfiguracion.Click
        ActiveControl = tbUsuario
        ActiveControl.Focus()
        Dim frConfiguracion As New frConfiguracion
        frConfiguracion.ShowDialog()
    End Sub
End Class
