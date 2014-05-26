Option Explicit On
Option Compare Text
Imports System.IO
Imports System.Data.OleDb

Module modDBAccessSOL

    'Constante que guarda el nombre del mudolu
    Const mc_strNombre_Modulo As String = "modDBAccessSOL"

    'Se declara la variable de la conexion a la base de datos
    Private m_cnxConexion As New OleDbConnection

    'Se guarda la ruta de la base de datos para saber cuando cambia
    Private m_strDBPath As String = ""

    '<CABECERA>-----------------------------------------------
    'Descripcion......: Establece o cierra la conexion con la Base de Datos
    'Fecha............: 07/10/2011
    '<FIN CABECERA>-------------------------------------------
    Private Sub AbrirConexion()

        Const strNombre_Funcion As String = "AbrirConexion"
        
        Dim blnCambioDB As Boolean

        Try
            If Not m_strDBPath.Equals(gv_strDBFactusol) Then
                m_strDBPath = gv_strDBFactusol
                blnCambioDB = True
            End If

            m_strDBPath = "Z:\Datos\0022014.mdb"

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

    Public ReadOnly Property ConexionDBSOL As OleDbConnection
        Get
            Return m_cnxConexion
        End Get
    End Property


    '<CABECERA>-----------------------------------------------
    'Descripcion......: Cierra la conexion con la Base de Datos
    'Fecha............: 10/01/2012
    '<FIN CABECERA>-------------------------------------------
    Public Sub CerrarConexionSOL()

        Const strNombre_Funcion As String = "CerrarConexionSOL"
        
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
    Public Function dtsObtenerDataSetSOL(ByVal strSQL As String) As DataSet

        Const strNombre_Funcion As String = "dtsObtenerDataSetSOL"
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
                dtsObtenerDataSetSOL = Nothing
            Else
                dtsObtenerDataSetSOL = dtsDataSet
            End If
        End Try
    End Function

    '<CABECERA>-----------------------------------------------
    'Descripcion......: Devuelve un DataSet con la tabla que contiene 
    '                   los registros obtenidos de la SQL recibida
    'Fecha............: 10/10/2011
    '<FIN CABECERA>-------------------------------------------
    Public Function blnEjecutarQuerySOL(ByVal strSQL As String) As Boolean

        Const strNombre_Funcion As String = "blnEjecutarQuerySOL"
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
            'Se cierra la conexion con la base de datos
            'CerrarConexion()
        Catch ex As Exception
            blnError = True
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        Finally
            If blnError Then
                blnResultado = False
            Else
                blnResultado = True
            End If

            blnEjecutarQuerySOL = blnResultado
        End Try
    End Function
End Module
