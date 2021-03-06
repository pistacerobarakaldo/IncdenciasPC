﻿Option Explicit On
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
            If gv_blnDBLocal Then
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
                If gv_blnDBLocal Then
                    dttTabla = dtsObtenerDataSet(strQuery).Tables(0)
                Else
                    dttTabla = dtsObtenerDataSetSOL(strQuery).Tables(0)
                End If

                If dttTabla(0)(0).ToString <> "" Then
                    objCliente.Id = CLng(dttTabla(0)(0).ToString) + 1
                Else
                    objCliente.Id = 40001
                End If
                strQuery = Clie_strQueryNuevoCliente(objCliente)
            End If

            If gv_blnDBLocal Then
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

    '<CABECERA>-----------------------------------------------
    'Descripcion......: Elimina una incidencia de la base de datos
    'Fecha............: 25/05/2014
    '<FIN CABECERA>-------------------------------------------
    Public Function Clie_EliminarCliente(ByVal lngCliente As Long) As Boolean

        Const strNombre_Funcion As String = "Inci_EliminarIncidencia"
        Dim blnError As Boolean

        Dim blnResultado As Boolean
        Dim lngIncidencia As Long
        Dim strQuery As String
        Dim strWhere As String
        Dim dttIncidencias As DataTable
        Dim objRow As DataRow

        Try
            strQuery = Clie_strQueryEliminarCliente(lngCliente)
            If blnEjecutarQuery(strQuery) Then
                'Eliminarmos las incidencias asociadas al cliente
                strWhere = "WHERE " & gc_strDB_TABLA_Incidencias & "." & gc_strDB_C_Cliente & " = " & lngCliente
                dttIncidencias = Inci_dttObtenerIncidencias(, strWhere)
                For Each objRow In dttIncidencias.Rows
                    lngIncidencia = objRow(gc_strLP_I_Incidencia)
                    If Not Inci_EliminarIncidencia(lngIncidencia) Then
                        blnResultado = False
                        Exit For
                    Else
                        blnResultado = True
                    End If
                Next
            Else
                blnResultado = False
            End If
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
            blnError = True
        Finally
            If blnError Then
                blnResultado = False
            End If
            Clie_EliminarCliente = blnResultado
        End Try
    End Function

End Module
