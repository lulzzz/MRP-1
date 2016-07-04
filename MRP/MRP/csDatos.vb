Imports System.Text
Imports System.Security.Cryptography
Imports System.Data.SqlClient

Public Class csDatos
    Private Shared stConexion As String = "Data Source=" + My.Settings("Server").ToString + ";Initial Catalog=" + My.Settings("DataBase").ToString + ";User ID=" + My.Settings("User").ToString + ";Password=" + My.Settings("Password").ToString + ";Connection Timeout=50;"
    Private Shared stDNS As String = "DSN=MRP"
    Private Shared stDB As String = "DB6"
    Private Shared stCadena As String = String.Empty
    Private Shared stClave As String = "%#MRPDB62016#%"
    Private Shared btResultado As Byte()
    Private Shared btArreglo As Byte()
    Private Shared btLlave As Byte()
    Private Shared prIdEmpresa As Integer
    Private Shared prEmpresa As String
    Private Shared prIdUsuario As Integer
    Private Shared prUsuario As String
    Private Shared prNombreUsuario As String
    Private Shared cnConexion As SqlConnection
    Private Shared cmComando As SqlCommand
    Private Shared ctTransaccion As SqlTransaction

#Region "Entorno"
    Public Shared Property IdEmpresa As Integer
        Get
            Return prIdEmpresa
        End Get
        Set(value As Integer)
            prIdEmpresa = value
        End Set
    End Property

    Public Shared Property Empresa As String
        Get
            Return prEmpresa
        End Get
        Set(value As String)
            prEmpresa = value
        End Set
    End Property

    Public Shared Property IdUsuario As Integer
        Get
            Return prIdUsuario
        End Get
        Set(value As Integer)
            prIdUsuario = value
        End Set
    End Property

    Public Shared Property Usuario As String
        Get
            Return prUsuario
        End Get
        Set(value As String)
            prUsuario = value
        End Set
    End Property

    Public Shared Property NombreUsuario As String
        Get
            Return prNombreUsuario
        End Get
        Set(value As String)
            prNombreUsuario = value
        End Set
    End Property
#End Region

#Region "IteraccionDB"
    Public Shared Sub IniciarTransaccion()
        Try
            cnConexion = New SqlConnection(stConexion)
            cnConexion.Open()
            cmComando = cnConexion.CreateCommand()
            ctTransaccion = cnConexion.BeginTransaction(IsolationLevel.ReadCommitted)
            cmComando.Transaction = ctTransaccion
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Shared Sub FinalizarTransaccion(ByVal Exito As Boolean)
        Try
            If Exito Then
                ctTransaccion.Commit()
            Else
                ctTransaccion.Rollback()
            End If
            cnConexion.Close()
            If Not IsNothing(ctTransaccion) Then ctTransaccion.Dispose()
            If Not IsNothing(cmComando) Then cmComando.Dispose()
            If Not IsNothing(cnConexion) Then cnConexion.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Shared Function EjecutarQuery(ByVal Query As String, Optional ByVal Transaccion As Boolean = True) As Boolean
        Try
            If Transaccion Then
                Using connection As New SqlConnection(stConexion)
                    connection.Open()
                    Dim command As SqlCommand = connection.CreateCommand()
                    Dim transaction As SqlTransaction
                    transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted)
                    command.Transaction = transaction
                    Try
                        command.CommandText = Query
                        command.ExecuteNonQuery()
                        transaction.Commit()
                        connection.Close()
                        Return True
                    Catch ex As Exception
                        transaction.Rollback()
                        Return False
                    Finally
                        If Not IsNothing(transaction) Then transaction.Dispose()
                        If Not IsNothing(command) Then command.Dispose()
                        If Not IsNothing(connection) Then connection.Dispose()
                    End Try
                End Using
            Else
                Try
                    cmComando.CommandText = Query
                    cmComando.ExecuteNonQuery()
                    Return True
                Catch ex As Exception
                    Return False
                End Try
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Shared Function ConsultarQuery(ByRef dt As DataTable, ByVal Query As String) As Boolean
        dt = New DataTable
        Try
            Using connection As New SqlConnection(stConexion)
                connection.Open()
                Dim command As SqlCommand = connection.CreateCommand()
                Try
                    command.CommandText = Query
                    dt.Load(command.ExecuteReader())
                    connection.Close()
                    Return dt.Rows.Count > 0
                Catch ex As SqlException
                    Return False
                Finally
                    If Not IsNothing(command) Then command.Dispose()
                    If Not IsNothing(connection) Then connection.Dispose()
                End Try
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Shared Function ObtenerCamposTabla(ByRef dt As DataTable, ByVal Tabla As String) As Boolean
        Try
            Return csDatos.ConsultarQuery(dt, "SELECT COLUMN_NAME Campo FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_CATALOG = '" + stDB + "' AND TABLE_NAME = '" + Tabla + "'")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
#End Region

#Region "Seguridad"
    Public Shared Function TestConexion(ByVal Server As String, ByVal DataBase As String, ByVal User As String, ByVal Password As String) As Boolean
        If Server = String.Empty Then Server = My.Settings("Server").ToString
        If DataBase = String.Empty Then DataBase = My.Settings("DataBase").ToString
        If User = String.Empty Then User = My.Settings("User").ToString
        If Password = String.Empty Then Password = My.Settings("Password").ToString
        Try
            Using connection As New SqlConnection("Data Source=" + Server + ";Initial Catalog=" + DataBase + ";User ID=" + User + ";Password=" + Password + ";Connection Timeout=50;")
                connection.Open()
                connection.Close()
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("No se ha podido establecer conexión con el servidor", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Shared Function CifrarCadena(cadena As String) As String
        Try
            btArreglo = Encoding.UTF8.GetBytes(cadena)
            Dim mD5CryptoServiceProvider As MD5CryptoServiceProvider = New MD5CryptoServiceProvider()
            btLlave = mD5CryptoServiceProvider.ComputeHash(Encoding.UTF8.GetBytes(stClave))
            mD5CryptoServiceProvider.Clear()
            Dim tripleDESCryptoServiceProvider As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider()
            tripleDESCryptoServiceProvider.Key = btLlave
            tripleDESCryptoServiceProvider.Mode = CipherMode.ECB
            tripleDESCryptoServiceProvider.Padding = PaddingMode.PKCS7
            Dim cryptoTransform As ICryptoTransform = tripleDESCryptoServiceProvider.CreateEncryptor()
            btResultado = cryptoTransform.TransformFinalBlock(btArreglo, 0, btArreglo.Length)
            tripleDESCryptoServiceProvider.Clear()
            Return Convert.ToBase64String(btResultado, 0, btResultado.Length)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Shared Function ValidarCredenciales(ByVal User As String, ByVal Password As String) As Boolean
        Dim dt As New DataTable
        IdUsuario = 0
        Usuario = String.Empty
        NombreUsuario = String.Empty
        IdEmpresa = 0
        Empresa = String.Empty
        If ConsultarQuery(dt, "Select id_usuario IdUsuario, usr_usuario Usuario, usr_nombre NombreUsuario FROM tbl_mrp_usuario WHERE id_estado=1 And usr_usuario='" + User + "' AND usr_contrasena='" + CifrarCadena(Password) + "'") Then
                IdUsuario = CInt(dt.Rows(0)("IdUsuario"))
            Usuario = CStr(dt.Rows(0)("Usuario"))
            NombreUsuario = CStr(dt.Rows(0)("NombreUsuario"))
        End If
        Return dt.Rows.Count > 0
    End Function

    Public Shared Function ObtenerEmpresasAsociadas(ByRef dt As DataTable) As Boolean
        IdEmpresa = 0
        Empresa = String.Empty
        Return ConsultarQuery(dt, "SELECT a.id_empresa IdEmpresa, a.emp_nombre Empresa FROM tbl_mrp_empresa a JOIN tbl_mrp_usuario_empresa b ON a.id_empresa=b.id_empresa WHERE a.id_estado=1 AND b.id_usuario=" + IdUsuario.ToString)
    End Function
#End Region
End Class