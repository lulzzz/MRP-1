﻿Public Class csNegocio
    Private Shared Campos As New DataTable

#Region "Validaciones"
    Public Shared Function ValidarControlesMaestros(ByVal Controles As ArrayList) As Boolean
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
    Public Shared Function GuardarRegistroMaestro(ByVal Nuevo As Boolean, ByVal NombreTabla As String, ByVal DatosEntrada As ArrayList, Optional ByVal Transaccion As Boolean = True) As Boolean
        Try
            Dim Query As String = String.Empty
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
            Return csDatos.EjecutarQuery(Query, Transaccion)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Shared Function EliminarRegistroMaestro(ByVal Eliminar As Boolean, ByVal NombreTabla As String, ByVal DatosEntrada As ArrayList) As Boolean
        Try
            Dim Query As String = String.Empty
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

    Public Shared Function ConsultarRegistroDetalle(ByRef dg As DataGridView, ByVal NombreTabla As String, ByVal Id As String) As Boolean
        Try
            Dim Query As String = String.Empty
            Dim dt As New DataTable
            csDatos.ObtenerCamposTabla(Campos, NombreTabla)
            Query = "SELECT "
            For i As Integer = 0 To dg.Columns.Count - 1
                If i > 0 Then
                    Query += ","
                End If
                Query += dg.Columns(i).Name + " " + dg.Columns(i).HeaderText
            Next
            Query += " FROM " + dg.Tag.ToString + " WHERE " + CStr(Campos.Rows(0)(0)) + "=" + Id
            If csDatos.ConsultarQuery(dt, Query) Then
                dg.Rows.Clear()
                For i As Integer = 0 To dt.Rows.Count - 1
                    dg.Rows.Add()
                    For j As Integer = 0 To dg.Columns.Count - 1
                        If dg.Columns(j).GetType = GetType(DataGridViewComboBoxColumn) Then
                            dg.Rows(i).Cells(j).Value = CInt(dt.Rows(i)(j))
                        Else
                            dg.Rows(i).Cells(j).Value = CStr(dt.Rows(i)(j))
                        End If
                    Next
                Next
            End If
            Return False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Shared Function GuardarRegistroDetalle(ByRef dg As DataGridView, ByVal NombreTabla As String, ByVal Id As String, Optional ByVal Transaccion As Boolean = True) As Boolean
        Try
            Dim Query As String = String.Empty
            csDatos.ObtenerCamposTabla(Campos, NombreTabla)
            Query = String.Empty
            For x As Integer = 0 To dg.Rows.Count - 1
                Query += " INSERT INTO " + dg.Tag.ToString + " (" + CStr(Campos.Rows(0)(0))
                For i As Integer = 0 To dg.Columns.Count - 1
                    Query += "," + dg.Columns(i).Name
                Next
                Query += ") VALUES (" + Id
                For j As Integer = 0 To dg.Columns.Count - 1
                    Query += "," + dg.Rows(x).Cells(j).Value.ToString
                Next
                Query += ")"
            Next
            If csNegocio.EliminarRegistroDetalle(dg, NombreTabla, Id, Transaccion) Then
                Return csDatos.EjecutarQuery(Query, Transaccion)
            End If
            Return False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Shared Function EliminarRegistroDetalle(ByRef dg As DataGridView, ByVal NombreTabla As String, ByVal Id As String, Optional ByVal Transaccion As Boolean = True) As Boolean
        Try
            Dim Query As String = String.Empty
            csDatos.ObtenerCamposTabla(Campos, NombreTabla)
            Query = "DELETE FROM " + dg.Tag.ToString + " WHERE " + CStr(Campos.Rows(0)(0)) + "=" + Id
            Return csDatos.EjecutarQuery(Query, Transaccion)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
#End Region
End Class