Public Class frBuscar
    Public NombreFormulario As String
    Public QueryBuscar As String
    Public EjecutarBusqueda As Boolean
    Public Contador As Integer
    Private dtDatos As DataTable

    Private Sub Buscar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            csDatos.ConsultarQuery(dtDatos, QueryBuscar)
            dgvDatos.DataSource = dtDatos
            dgvDatos.Refresh()
            dgvDatos.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvDatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellDoubleClick
        Try
            If e.RowIndex >= 0 Then
                For i As Integer = 0 To dtDatos.Rows.Count - 1
                    If CInt(dtDatos.Rows(i)(0)) = CInt(dgvDatos.Rows(e.RowIndex).Cells(0).Value.ToString()) Then
                        Contador = i
                        EjecutarBusqueda = True
                        Close()
                    End If
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Close()
    End Sub
End Class