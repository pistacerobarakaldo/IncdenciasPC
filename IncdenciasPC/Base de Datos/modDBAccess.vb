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
    'Nombre...........: AbrirCerrarConexion
    'Descripcion......: Establece o cierra la conexion con la Base de Datos
    'Fecha............: 07/10/2011
    'Autor............: Borja Escudero
    'Parametros.......: N/A 
    'Retorno..........: N/A
    '<FIN CABECERA>-------------------------------------------
    Private Sub AbrirConexion()

        Const strNombre_Funcion As String = "AbrirConexion"
        Dim lngError As Long
        Dim strError As String

        Dim blnCambioDB As Boolean

        On Error GoTo TratarError

        'If Not m_strDBPath.Equals(gv_objAplicacion.DBEmpresa) Then
        '    m_strDBPath = gv_objAplicacion.DBEmpresa
        '    blnCambioDB = True
        'End If

        m_strDBPath = "C:\Users\Borja\Google Drive\Programacion\Proyectos\IncdenciasPC\IncdenciasPC\bin\Debug\Incidencias.accdb"

        If m_cnxConexion.State <> ConnectionState.Open Then
            m_cnxConexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & m_strDBPath & ";Persist Security Info=False"
            m_cnxConexion.Open()
        ElseIf blnCambioDB Then
            CerrarConexion()
            m_cnxConexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & m_strDBPath & ";Persist Security Info=False"
            m_cnxConexion.Open()
        End If

Terminar:

        'Anulamos el control de errores
        On Error GoTo 0
        Exit Sub

TratarError:

        'Guardamos el error
        lngError = Err.Number
        strError = Err.Description

        AddLog(lngError & " - " & strError, mc_strNombre_Modulo, strNombre_Funcion)

        Resume Terminar
    End Sub

    Public ReadOnly Property ConexionDB As OleDbConnection
        Get
            Return m_cnxConexion
        End Get
    End Property


    '<CABECERA>-----------------------------------------------
    'Nombre...........: CerrarConexion
    'Descripcion......: Cierra la conexion con la Base de Datos
    'Fecha............: 10/01/2012
    'Autor............: Borja Escudero
    'Parametros.......: N/A
    'Retorno..........: N/A
    '<FIN CABECERA>-------------------------------------------
    Public Sub CerrarConexion()

        Const strNombre_Funcion As String = "CerrarConexion"
        Dim lngError As Long
        Dim strError As String

        On Error GoTo TratarError

        If m_cnxConexion.State = ConnectionState.Open Then
            m_cnxConexion.Close()
        End If

Terminar:

        'Anulamos el control de errores
        On Error GoTo 0
        Exit Sub

TratarError:

        'Guardamos el error
        lngError = Err.Number
        strError = Err.Description

        AddLog(lngError & " - " & strError, mc_strNombre_Modulo, strNombre_Funcion)

        Resume Terminar
    End Sub

    '<CABECERA>-----------------------------------------------
    'Nombre...........: dtsObtenerDataSet
    'Descripcion......: Devuelve un DataSet con la tabla que contiene 
    '                   los registros obtenidos de la SQL recibida
    'Fecha............: 10/10/2011
    'Autor............: Borja Escudero
    'Parametros.......: strSQL = Sentencia SQL que se quiere aplicar a la base de datos 
    'Retorno..........: N/A
    '<FIN CABECERA>-------------------------------------------
    Public Function dtsObtenerDataSet(ByVal strSQL As String) As DataSet

        Const strNombre_Funcion As String = "dtsObtenerDataSet"
        Dim lngError As Long
        Dim strError As String

        Dim dtaDataAdapter As New OleDbDataAdapter
        Dim dtsDataSet As New DataSet

        On Error GoTo TratarError

        'Se abre la conexion con la base de datos
        AbrirConexion()
        'Se obtiene el dataset
        dtaDataAdapter.SelectCommand = New OleDbCommand(strSQL, m_cnxConexion)
        dtaDataAdapter.Fill(dtsDataSet)
        dtaDataAdapter.Dispose()

Terminar:

        'Si se genera algun error se retorna el valor Nothing, si no el DataSet
        If lngError <> 0 Then
            dtsObtenerDataSet = Nothing
        Else
            dtsObtenerDataSet = dtsDataSet
        End If

        'Anulamos el control de errores
        On Error GoTo 0
        Exit Function

TratarError:

        'Guardamos el error
        lngError = Err.Number
        strError = Err.Description

        AddLog(lngError & " - " & strError, mc_strNombre_Modulo, strNombre_Funcion)

        Resume Next
    End Function

    '<CABECERA>-----------------------------------------------
    'Nombre...........: blnEjecutarQuery
    'Descripcion......: Devuelve un DataSet con la tabla que contiene 
    '                   los registros obtenidos de la SQL recibida
    'Fecha............: 10/10/2011
    'Autor............: Borja Escudero
    'Parametros.......: strSQL = Sentencia SQL que se quiere aplicar a la base de datos 
    'Retorno..........: True si todo ha ido correctamente
    '<FIN CABECERA>-------------------------------------------
    Public Function blnEjecutarQuery(ByVal strSQL As String) As Boolean

        Const strNombre_Funcion As String = "blnEjecutarQuery"
        Dim lngError As Long
        Dim strError As String

        Dim cmdCommand As New OleDbCommand
        Dim blnResultado As Boolean

        On Error GoTo TratarError

        'Se abre la conexion con la base de datos
        AbrirConexion()
        'Se obtiene el dataset
        cmdCommand.Connection = m_cnxConexion
        cmdCommand.CommandText = strSQL
        cmdCommand.ExecuteNonQuery()
        'Se cierra la conexion con la base de datos
        'CerrarConexion()

Terminar:

        If lngError <> 0 Then
            blnResultado = False
        Else
            blnResultado = True
        End If

        blnEjecutarQuery = blnResultado

        'Anulamos el control de errores
        On Error GoTo 0
        Exit Function

TratarError:

        'Guardamos el error
        lngError = Err.Number
        strError = Err.Description

        AddLog(lngError & " - " & strError, mc_strNombre_Modulo, strNombre_Funcion)

        Resume Next
    End Function
End Module
