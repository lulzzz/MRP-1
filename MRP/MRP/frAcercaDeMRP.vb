Public NotInheritable Class frAcercaDeMRP
    Private Sub btAceptar_Click(sender As Object, e As EventArgs) Handles btAceptar.Click
        Close()
    End Sub

    Private Sub frAcercaDeMRP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbVersion.Text = "Versión " + My.Application.Info.Version.ToString
    End Sub
End Class