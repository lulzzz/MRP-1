Public Class frBuscar
    Public NombreFormulario As String
    Public QueryBuscar As String
    Public EjecutarBusqueda As Boolean
    Public Contador As Integer
    Private dtDatos As DataTable

    Private Sub Buscar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            csDatos.ConsultarQuery(dtDatos, Me.QueryBuscar)
            dgvDatos.DataSource = Me.dtDatos
            dgvDatos.Refresh()
            dgvDatos.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvDatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellDoubleClick
        Try
            If e.RowIndex >= 0 Then
                For i As Integer = 0 To Me.dtDatos.Rows.Count - 1
                    If CInt(Me.dtDatos.Rows(i)(0)) = CInt(Me.dgvDatos.Rows(e.RowIndex).Cells(0).Value.ToString()) Then
                        Contador = i
                        EjecutarBusqueda = True
                        Me.Close()
                    End If
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class