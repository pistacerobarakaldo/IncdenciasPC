Option Explicit On
Option Compare Text
Imports System.IO
Imports System.Data.OleDb

Module modDBAccess

    'Constante que guarda el nombre del mudolu
    Const mc_strNombre_Modulo As String = "modDBAccess"

    'Se declara la variable de la conexion a la base de datos
    Private m_cnxConexion As New OleDbConnection

    'Se guarda la ruta de la base de datos para saber cuando cambia
    Private m_strDBPath As String = ""

    'Guarda la ubicacion de las plantillas de la base de datos
    Public Const gc_strDBTemplatesPath As String = "\DBIT\"

    '<CABECERA>-----------------------------------------------
    'Descripcion......: Establece o cierra la conexion con la Base de Datos
    'Fecha............: 07/10/2011
    '<FIN CABECERA>-------------------------------------------
    Private Sub AbrirConexion()

       Const strNombre_Funcion As String = "AbrirConexion"

        Dim blnCambioDB As Boolean

        Try
            If Not m_strDBPath.Equals(gv_strDBPrincipal) Then
                m_strDBPath = gv_strDBPrincipal
                blnCambioDB = True
            End If

            If m_cnxConexion.State <> ConnectionState.Open Then
                m_cnxConexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & m_strDBPath & ";Persist Security Info=False"
                m_cnxConexion.Open()
            ElseIf blnCambioDB Then
                CerrarConexion()
                m_cnxConexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & m_strDBPath & ";Persist Security Info=False"
                m_cnxConexion.Open()
            End If
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Public ReadOnly Property ConexionDB As OleDbConnection
        Get
            Return m_cnxConexion
        End Get
    End Property


    '<CABECERA>-----------------------------------------------
    'Descripcion......: Cierra la conexion con la Base de Datos
    'Fecha............: 10/01/2012
    '<FIN CABECERA>-------------------------------------------
    Public Sub CerrarConexion()

        Const strNombre_Funcion As String = "CerrarConexion"

        Try
            If m_cnxConexion.State = ConnectionState.Open Then
                m_cnxConexion.Close()
            End If
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    '<CABECERA>-----------------------------------------------
    'Descripcion......: Devuelve un DataSet con la tabla que contiene 
    '                   los registros obtenidos de la SQL recibida
    'Fecha............: 10/10/2011
    '<FIN CABECERA>-------------------------------------------
    Public Function dtsObtenerDataSet(ByVal strSQL As String) As DataSet

        Const strNombre_Funcion As String = "dtsObtenerDataSet"
        Dim blnError As Boolean

        Dim dtaDataAdapter As New OleDbDataAdapter
        Dim dtsDataSet As New DataSet

        Try
            'Se abre la conexion con la base de datos
            AbrirConexion()
            'Se obtiene el dataset
            dtaDataAdapter.SelectCommand = New OleDbCommand(strSQL, m_cnxConexion)
            dtaDataAdapter.Fill(dtsDataSet)
            dtaDataAdapter.Dispose()
        Catch ex As Exception
            blnError = True
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        Finally
            If blnError Then
                dtsObtenerDataSet = Nothing
            Else
                dtsObtenerDataSet = dtsDataSet
            End If
        End Try
    End Function

    '<CABECERA>-----------------------------------------------
    'Descripcion......: Devuelve un DataSet con la tabla que contiene 
    '                   los registros obtenidos de la SQL recibida
    'Fecha............: 10/10/2011
    '<FIN CABECERA>-------------------------------------------
    Public Function blnEjecutarQuery(ByVal strSQL As String) As Boolean

        Const strNombre_Funcion As String = "blnEjecutarQuery"
        Dim blnError As Boolean

        Dim cmdCommand As New OleDbCommand
        Dim blnResultado As Boolean

        Try
            'Se abre la conexion con la base de datos
            AbrirConexion()
            'Se obtiene el dataset
            cmdCommand.Connection = m_cnxConexion
            cmdCommand.CommandText = strSQL
            cmdCommand.ExecuteNonQuery()
            blnResultado = True
        Catch ex As Exception
            blnError = True
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        Finally
            If blnError Then
                blnResultado = False
            End If
            blnEjecutarQuery = blnResultado
        End Try
    End Function

    '<CABECERA>-----------------------------------------------
    'Descripcion......: Averigua si existe una tabla en la base de datos
    'Fecha............: 21/02/2012
    '<FIN CABECERA>-------------------------------------------
    Public Function blnExisteTabla(ByVal strDBPath As String, ByVal strTabla As String) As Boolean

        Const strNombre_Funcion As String = "blnExisteTabla"
        Dim blnError As Boolean

        Dim blnResultado As Boolean
        Dim cnxConexion As OleDbConnection
        Dim dttTabla As DataTable
        Dim objRows() As DataRow
        Dim strCriterio As String

        Try
            If strDBPath <> "" Then
                'Abre la base de datos  
                cnxConexion = New OleDbConnection
                cnxConexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & strDBPath & ";Persist Security Info=False"
                cnxConexion.Open()

                'Declara y abre el recordset  
                dttTabla = cnxConexion.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, New Object() {Nothing, Nothing, Nothing, "TABLE"})

                strCriterio = String.Format("TABLE_NAME = '{0}'", strTabla)

                objRows = dttTabla.Select(strCriterio)

                blnResultado = (objRows.Length > 0)
            Else
                blnResultado = False
            End If
        Catch ex As Exception
            blnError = True
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        Finally
            If blnError Then
                blnResultado = False
            End If
            blnExisteTabla = blnResultado
        End Try
    End Function
End Module
