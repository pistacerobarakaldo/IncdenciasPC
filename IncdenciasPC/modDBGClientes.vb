Option Explicit On
Option Compare Text

Module modDBGClientes

    'Constante que guarda el nombre del mudolu
    Const mc_strNombre_Modulo As String = "modDBGClientes"

    '<CABECERA>-----------------------------------------------
    'Descripcion......: Obtiene la tabla con las incidencias
    'Fecha............: 29/04/2014
    '<FIN CABECERA>-------------------------------------------
    Public Function Clie_dttObtenerClientes(Optional ByVal lngIdCliente As Long = -1, Optional ByVal strWhere As String = "") As DataTable

        Const strNombre_Funcion As String = "Inci_dttObtenerIncidencias"
        Dim blnError As Boolean

        Dim dtsDataSet As DataSet = Nothing
        Dim strQuery As String

        Try
            strQuery = Clie_strQueryObtenerClientes(lngIdCliente, strWhere)
            If gc_blnDBLocal Then
                dtsDataSet = dtsObtenerDataSet(strQuery)
            Else
                dtsDataSet = dtsObtenerDataSetSOL(strQuery)
            End If
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
            blnError = True
        Finally
            If blnError Then
                Clie_dttObtenerClientes = Nothing
            Else
                If Not dtsDataSet Is Nothing Then
                    Clie_dttObtenerClientes = dtsDataSet.Tables(0)
                Else
                    Clie_dttObtenerClientes = Nothing
                End If
            End If
        End Try
    End Function

    '<CABECERA>-----------------------------------------------
    'Descripcion......: Modifica o añade un cliente de la base de datos
    'Fecha............: 22/05/2014
    '<FIN CABECERA>-------------------------------------------
    Public Function Clie_GuardarCliente(ByVal objCliente As clsCliente) As Boolean

        Const strNombre_Funcion As String = "Clie_GuardarCliente"
        Dim blnError As Boolean

        Dim blnResultado As Boolean
        Dim dttTabla As DataTable
        Dim strQuery As String

        Try
            If objCliente.Id > 0 Then
                'Modificar la incidencia
                strQuery = Clie_strQueryModificarCliente(objCliente)
            Else
                'Crear una nueva incidencia
                strQuery = Config_strQueryIndiceMaximo(gc_strDB_TABLA_Clientes, gc_strDB_I_Cliente)
                If gc_blnDBLocal Then
                    dttTabla = dtsObtenerDataSet(strQuery).Tables(0)
                Else
                    dttTabla = dtsObtenerDataSetSOL(strQuery).Tables(0)
                End If

                objCliente.Id = CLng(dttTabla(0)(0).ToString) + 1
                strQuery = Clie_strQueryNuevoCliente(objCliente)
            End If

            If gc_blnDBLocal Then
                blnResultado = blnEjecutarQuery(strQuery)
            Else
                blnResultado = blnEjecutarQuerySOL(strQuery)
            End If
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
            blnError = True
        Finally
            If blnError Then
                blnResultado = False
            End If
            Clie_GuardarCliente = blnResultado
        End Try
    End Function
End Module
