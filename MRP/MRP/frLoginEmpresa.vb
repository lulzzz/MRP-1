Public Class frLoginEmpresa
    Protected Friend Usuario As String = String.Empty
    Dim frMenuPrincipal As frMenuPrincipal

    Private Sub frLoginEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            csDatos.IdEmpresa = 0
            csDatos.Empresa = String.Empty
            Dim dt As New DataTable
            If csDatos.ObtenerEmpresasAsociadas(dt) Then
                cbEmpresa.DataSource = dt
                cbEmpresa.ValueMember = "IdEmpresa"
                cbEmpresa.DisplayMember = "Empresa"
                cbEmpresa.Refresh()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frLoginEmpresa_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If csDatos.IdEmpresa = 0 Then
            Application.Exit()
        End If
    End Sub

    Private Sub btAceptar_Click(sender As Object, e As EventArgs) Handles btAceptar.Click
        Try
            If cbEmpresa.SelectedIndex >= 0 Then
                csDatos.IdEmpresa = CInt(cbEmpresa.SelectedValue)
                csDatos.Empresa = CStr(cbEmpresa.Text)
                frMenuPrincipal = New frMenuPrincipal
                frMenuPrincipal.Owner = Me
                frMenuPrincipal.Show()
                Me.Hide()
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
End Class