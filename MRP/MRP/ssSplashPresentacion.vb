Public NotInheritable Class ssSplashPresentacion
    Private Sub ssSplashPresentacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbVersion.Text = "Versión " + My.Application.Info.Version.ToString
    End Sub
End Class