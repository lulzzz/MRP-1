Public Class frConfiguracion
    Dim dt As DataTable

    Private Sub frConfiguracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbServer.Text = My.Settings("Server").ToString
        tbDataBase.Text = My.Settings("DataBase").ToString
        tbUser.Text = My.Settings("User").ToString
        tbPassword.Text = My.Settings("Password").ToString
    End Sub

    Private Sub btTest_Click(sender As Object, e As EventArgs) Handles btTest.Click
        If csDatos.TestConexion(tbServer.Text, tbDataBase.Text, tbUser.Text, tbPassword.Text) Then
            MessageBox.Show("Conexión establecida correctamente ", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btAceptar_Click(sender As Object, e As EventArgs) Handles btAceptar.Click
        If MessageBox.Show("¿Está seguro que desea establecer la configuración?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If csDatos.TestConexion(tbServer.Text, tbDataBase.Text, tbUser.Text, tbPassword.Text) Then
                My.Settings("Server") = tbServer.Text
                My.Settings("DataBase") = tbDataBase.Text
                My.Settings("User") = tbUser.Text
                My.Settings("Password") = tbPassword.Text
                Me.Close()
            End If
        End If
    End Sub

    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        Me.Close()
    End Sub
End Class