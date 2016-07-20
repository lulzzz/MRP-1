Imports CrystalDecisions.Shared

Public Class frReporteador

#Region "Configuracion"
    Public Sub ConfigurarReporteador(ByVal Reporte As Integer)
        Try
            Select Case Reporte
                Case 1 : rvVisor.ReportSource = rptExistenciaInventarios1
                Case 2 : rvVisor.ReportSource = rptOrdenProduccion1
                Case 3 : rvVisor.ReportSource = rptProcesoProduccion1
                Case Else : rvVisor.ReportSource = Nothing
            End Select
            Dim conn As ConnectionInfo = New ConnectionInfo()
            conn.ServerName = My.Settings("Server").ToString
            conn.DatabaseName = My.Settings("DataBase").ToString
            conn.UserID = My.Settings("User").ToString
            conn.Password = My.Settings("Password").ToString
            conn.Type = ConnectionInfoType.Query
            conn.IntegratedSecurity = False
            Dim mytableloginfos As New TableLogOnInfos()
            mytableloginfos = rvVisor.LogOnInfo
            For Each myTableLogOnInfo As TableLogOnInfo In mytableloginfos
                myTableLogOnInfo.ConnectionInfo = conn
            Next
            rvVisor.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
End Class