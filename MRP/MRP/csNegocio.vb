Public Class csNegocio
    Private Shared Query As String = String.Empty
    Private Shared Campos As New DataTable

#Region "Validaciones"
    Public Shared Function ValidarControles(ByVal Controles As ArrayList) As Boolean
        Dim Vacio As Boolean = False
        Try
            For i As Integer = 1 To Controles.Count - 1
                If CType(Controles(i), TextBox).Text = String.Empty Then
                    Vacio = True
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        If Vacio Then
            MessageBox.Show("Existen campos vacíos", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        Return Not Vacio
    End Function
#End Region

#Region "Navegador"
    Public Shared Function GuardarRegistro(ByVal Nuevo As Boolean, ByVal NombreTabla As String, ByVal DatosEntrada As ArrayList) As Boolean
        Try
            csDatos.ObtenerCamposTabla(Campos, NombreTabla)
            If Nuevo Then
                Query = "INSERT INTO " + NombreTabla + " ("
                For i As Integer = 1 To Campos.Rows.Count - 1
                    If i > 1 Then
                        Query += ","
                    End If
                    Query += CStr(Campos.Rows(i)(0))
                Next
                Query += ") VALUES ("
                For i As Integer = 1 To DatosEntrada.Count - 1
                    If i > 1 Then
                        Query += ","
                    End If
                    Query += "'" + CType(DatosEntrada(i), TextBox).Text + "'"
                Next
                Query += ")"
            Else
                Query = "UPDATE " + NombreTabla + " SET "
                For i As Integer = 1 To Campos.Rows.Count - 1
                    If i > 1 Then
                        Query += ","
                    End If
                    Query += CStr(Campos.Rows(i)(0)) + "=" + "'" + CType(DatosEntrada(i), TextBox).Text + "'"
                Next
                Query += " WHERE " + CStr(Campos.Rows(0)(0)) + "=" + CType(DatosEntrada(0), TextBox).Text
            End If
            Return csDatos.EjecutarQuery(Query)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Shared Function EliminarRegistro(ByVal Eliminar As Boolean, ByVal NombreTabla As String, ByVal DatosEntrada As ArrayList) As Boolean
        Try
            csDatos.ObtenerCamposTabla(Campos, NombreTabla)
            If Eliminar Then
                Query = "UPDATE " + NombreTabla + " SET id_estado=3 WHERE " + CStr(Campos.Rows(0)(0)) + "=" + CType(DatosEntrada(0), TextBox).Text
            Else
                Query = "UPDATE " + NombreTabla + " SET id_estado=1 WHERE " + CStr(Campos.Rows(0)(0)) + "=" + CType(DatosEntrada(0), TextBox).Text
            End If
            Return csDatos.EjecutarQuery(Query)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
#End Region
End Class