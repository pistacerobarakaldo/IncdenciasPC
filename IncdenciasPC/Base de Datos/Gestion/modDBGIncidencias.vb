Option Explicit On
Option Compare Text

Module modDBGIncidencias

    'Constante que guarda el nombre del mudolu
    Const mc_strNombre_Modulo As String = "modDBGIncidencias"

    '<CABECERA>-----------------------------------------------
    'Descripcion......: Obtiene la tabla con las incidencias
    'Fecha............: 29/04/2014
    '<FIN CABECERA>-------------------------------------------
    Public Function Inci_dttObtenerIncidencias(Optional ByVal lngIdIncidencia As Long = -1, Optional ByVal strWhere As String = "") As DataTable

        Const strNombre_Funcion As String = "Inci_dttObtenerIncidencias"
        Dim blnError As Boolean

        Dim dtsDataSet As DataSet = Nothing
        Dim strQuery As String

        Try
            strQuery = Inci_strQueryObtenerIncidencias(lngIdIncidencia, strWhere)
            dtsDataSet = dtsObtenerDataSet(strQuery)
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
            blnError = True
        Finally
            If blnError Then
                Inci_dttObtenerIncidencias = Nothing
            Else
                If Not dtsDataSet Is Nothing Then
                    Inci_dttObtenerIncidencias = dtsDataSet.Tables(0)
                Else
                    Inci_dttObtenerIncidencias = Nothing
                End If
            End If
        End Try
    End Function

    '<CABECERA>-----------------------------------------------
    'Descripcion......: Obtiene la tabla con las lineas de actuacion de una incidencia
    'Fecha............: 30/04/2014
    '<FIN CABECERA>-------------------------------------------
    Public Function Inci_dttObtenerLineasActuacion(ByVal lngIdIncidencia As Long) As DataTable

        Const strNombre_Funcion As String = "Inci_dttObtenerLineasActuacion"
        Dim blnError As Boolean

        Dim dtsDataSet As DataSet = Nothing
        Dim strQuery As String

        Try
            strQuery = Inci_strQueryObtenerLineasActuacion(lngIdIncidencia)
            dtsDataSet = dtsObtenerDataSet(strQuery)
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
            blnError = True
        Finally
            If blnError Then
                Inci_dttObtenerLineasActuacion = Nothing
            Else
                If Not dtsDataSet Is Nothing Then
                    Inci_dttObtenerLineasActuacion = dtsDataSet.Tables(0)
                Else
                    Inci_dttObtenerLineasActuacion = Nothing
                End If
            End If
        End Try
    End Function

    '<CABECERA>-----------------------------------------------
    'Descripcion......: Obtiene la tabla con las lineas de presupuesto de una incidencia
    'Fecha............: 30/04/2014
    '<FIN CABECERA>-------------------------------------------
    Public Function Inci_dttObtenerLineasPresupuesto(ByVal lngIdIncidencia As Long) As DataTable

        Const strNombre_Funcion As String = "Inci_dttObtenerLineasPresupuesto"
        Dim blnError As Boolean

        Dim dtsDataSet As DataSet = Nothing
        Dim strQuery As String

        Try
            strQuery = Inci_strQueryObtenerLineasPresupuesto(lngIdIncidencia)
            dtsDataSet = dtsObtenerDataSet(strQuery)
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
            blnError = True
        Finally
            If blnError Then
                Inci_dttObtenerLineasPresupuesto = Nothing
            Else
                If Not dtsDataSet Is Nothing Then
                    Inci_dttObtenerLineasPresupuesto = dtsDataSet.Tables(0)
                Else
                    Inci_dttObtenerLineasPresupuesto = Nothing
                End If
            End If
        End Try
    End Function

    '<CABECERA>-----------------------------------------------
    'Descripcion......: Obtiene la tabla con los estados
    'Fecha............: 30/04/2014
    '<FIN CABECERA>-------------------------------------------
    Public Function Inci_dttObtenerEstados() As DataTable

        Const strNombre_Funcion As String = "Inci_dttObtenerEstados"
        Dim blnError As Boolean

        Dim dtsDataSet As DataSet = Nothing
        Dim strQuery As String

        Try
            strQuery = Inci_strQueryObtenerEstados()
            dtsDataSet = dtsObtenerDataSet(strQuery)
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
            blnError = True
        Finally
            If blnError Then
                Inci_dttObtenerEstados = Nothing
            Else
                If Not dtsDataSet Is Nothing Then
                    Inci_dttObtenerEstados = dtsDataSet.Tables(0)
                Else
                    Inci_dttObtenerEstados = Nothing
                End If
            End If
        End Try
    End Function

    '<CABECERA>-----------------------------------------------
    'Descripcion......: Obtiene la tabla con los tipos de equipo
    'Fecha............: 30/04/2014
    '<FIN CABECERA>-------------------------------------------
    Public Function Inci_dttObtenerTiposEquipo() As DataTable

        Const strNombre_Funcion As String = "Inci_dttObtenerTiposEquipo"
        Dim blnError As Boolean

        Dim dtsDataSet As DataSet = Nothing
        Dim strQuery As String

        Try
            strQuery = Inci_strQueryObtenerTiposEquipo()
            dtsDataSet = dtsObtenerDataSet(strQuery)
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
            blnError = True
        Finally
            If blnError Then
                Inci_dttObtenerTiposEquipo = Nothing
            Else
                If Not dtsDataSet Is Nothing Then
                    Inci_dttObtenerTiposEquipo = dtsDataSet.Tables(0)
                Else
                    Inci_dttObtenerTiposEquipo = Nothing
                End If
            End If
        End Try
    End Function

    '<CABECERA>-----------------------------------------------
    'Nombre...........: FacClie_blnAnadirFactura
    'Descripcion......: Añade un nuevo Factura a la base de datos
    'Fecha............: 31/01/2012
    'Autor............: Borja Escudero
    'Parametros.......: objFactura = Id del Factura que se reservo
    'Retorno..........: TRUE si todo va bien
    '<FIN CABECERA>-------------------------------------------
    Public Function Inci_GuardarIncidencia(ByVal objIncidencia As clsIncidencia) As Boolean

        Const strNombre_Funcion As String = "Inci_GuardarIncidencia"
        Dim blnError As Boolean

        Dim blnResultado As Boolean
        Dim dttTabla As DataTable
        Dim objRow As DataRow
        Dim strQuery As String

        Try
            If objIncidencia.Id > 0 Then
                'Modificar la incidencia
                strQuery = Inci_strQueryModificarIncidencia(objIncidencia)
            Else
                'Crear una nueva incidencia
                strQuery = Config_strQueryIndiceMaximo(gc_strDB_TABLA_Incidencias, gc_strDB_I_Incidencia)
                dttTabla = dtsObtenerDataSet(strQuery).Tables(0)

                objIncidencia.Id = CLng(dttTabla(0)(0).ToString) + 1
                strQuery = Inci_strQueryNuevaIncidencia(objIncidencia)
            End If

            If blnEjecutarQuery(strQuery) Then
                'La adicion a funcionado satisfactoriamente
                blnResultado = True
                'Guardamos el historial
                '   Borramos el Historial que exista con el Id indicado
                strQuery = Inci_strQueryEliminarLineasActuacion(objIncidencia.Id)
                If blnEjecutarQuery(strQuery) Then
                    For Each objRow In objIncidencia.Historial.Rows
                        objRow(gc_strLP_C_Incidencia) = objIncidencia.Id
                        If objRow.RowState <> DataRowState.Deleted Then
                            'Añadimos cada linea activa del Historial
                            strQuery = Inci_strQueryNuevaLineaActuacion(objRow)
                            If Not blnEjecutarQuery(strQuery) Then
                                blnResultado = False
                                Exit For
                            End If
                        End If
                    Next
                End If
                If blnResultado Then
                    'Guardamos el presupuesto
                    '   Borramos las lineas de presupuesto que existan con el Id indicado
                    strQuery = Inci_strQueryEliminarLineasPresupuesto(objIncidencia.Id)
                    If blnEjecutarQuery(strQuery) Then
                        For Each objRow In objIncidencia.Presupuesto.Rows
                            objRow(gc_strLP_C_Incidencia) = objIncidencia.Id
                            If objRow.RowState <> DataRowState.Deleted Then
                                'Añadimos cada linea activa del presupuesto
                                strQuery = Inci_strQueryNuevaLineaPresupuesto(objRow)
                                If Not blnEjecutarQuery(strQuery) Then
                                    blnResultado = False
                                    Exit For
                                End If
                            End If
                        Next
                    End If
                End If
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
            Inci_GuardarIncidencia = blnResultado
        End Try
    End Function

    '    '<CABECERA>-----------------------------------------------
    '    'Nombre...........: FacClie_blnEditarFactura
    '    'Descripcion......: Editar un Factura de la base de datos
    '    'Fecha............: 31/01/2012
    '    'Autor............: Borja Escudero
    '    'Parametros.......: objFactura = Factura a modificar
    '    'Retorno..........: TRUE si todo va bien
    '    '<FIN CABECERA>-------------------------------------------
    '    Public Function FacClie_blnEditarFactura(ByRef objFactura As clsFacturaCliente) As Boolean

    '        Const strNombre_Funcion As String = "FacClie_blnEditarFactura"
    '        Dim lngError As Long
    '        Dim strError As String

    '        Dim blnResultado As Boolean
    '        Dim strQuery As String

    '        On Error GoTo TratarError

    '        'Editar el ticket de la Base de Datos
    '        strQuery = FacClie_strQueryEditarFactura(objFactura)
    '        If blnEjecutarQuery(strQuery) Then
    '            'El guardado a funcionado satisfactoriamente
    '            blnResultado = True
    '        Else
    '            'Ha habido algun tipo de error en el proceso de guardado
    '            blnResultado = False
    '        End If

    'Terminar:

    '        'Retornamos el valor
    '        FacClie_blnEditarFactura = blnResultado

    '        'Anulamos el control de errores
    '        On Error GoTo 0
    '        Exit Function

    'TratarError:

    '        'Guardamos el error
    '        lngError = Err.Number
    '        strError = Err.Description

    '        AddLog(lngError & " - " & strError, mc_strNombre_Modulo, strNombre_Funcion)

    '        Resume Terminar
    '    End Function

    '    '<CABECERA>-----------------------------------------------
    '    'Nombre...........: FacClie_blnEliminarFactura
    '    'Descripcion......: Elimina un Factura de la base de datos
    '    'Fecha............: 11/06/2012
    '    'Autor............: Borja Escudero
    '    'Parametros.......: lngIdFactura = Id del Factura
    '    'Retorno..........: TRUE si la eliminacion ha sido correcta
    '    '<FIN CABECERA>-------------------------------------------
    '    Public Function FacClie_blnEliminarFactura(ByVal lngIdFactura As Long) As Boolean

    '        Const strNombre_Funcion As String = "FacClie_blnEliminarFactura"
    '        Dim lngError As Long
    '        Dim strError As String

    '        Dim blnResultado As Boolean
    '        Dim dttTabla As DataTable
    '        Dim strQuery As String

    '        On Error GoTo TratarError

    '        strQuery = FacClie_strQueryEliminarFactura(lngIdFactura)
    '        If blnEjecutarQuery(strQuery) Then
    '            blnResultado = True
    '        Else
    '            blnResultado = False
    '        End If

    'Terminar:

    '        'Retornamos el valor
    '        FacClie_blnEliminarFactura = blnResultado

    '        'Anulamos el control de errores
    '        On Error GoTo 0
    '        Exit Function

    'TratarError:

    '        'Guardamos el error
    '        lngError = Err.Number
    '        strError = Err.Description

    '        AddLog(lngError & " - " & strError, mc_strNombre_Modulo, strNombre_Funcion)

    '        Resume Terminar
    '    End Function

    '    '<CABECERA>-----------------------------------------------
    '    'Nombre...........: FacClie_dttObtenerLineasFactura
    '    'Descripcion......: Obtiene la tabla con las lineas de un Factura
    '    'Fecha............: 11/06/2012
    '    'Autor............: Borja Escudero
    '    'Parametros.......: lngIdFactura = Id del Factura que se quiere obtener
    '    'Retorno..........: N/A
    '    '<FIN CABECERA>-------------------------------------------
    '    Public Function FacClie_dttObtenerLineasFactura(ByVal lngIdFactura As Long) As DataTable

    '        Const strNombre_Funcion As String = "FacClie_dttObtenerLineasFactura"
    '        Dim lngError As Long
    '        Dim strError As String

    '        Dim dtsDataSet As DataSet
    '        Dim strQuery As String

    '        On Error GoTo TratarError

    '        strQuery = FacClie_strQueryObtenerLineasFactura(lngIdFactura)
    '        dtsDataSet = dtsObtenerDataSet(strQuery)

    'Terminar:

    '        If lngError <> 0 Then
    '            FacClie_dttObtenerLineasFactura = Nothing
    '        Else
    '            If Not dtsDataSet Is Nothing Then
    '                FacClie_dttObtenerLineasFactura = dtsDataSet.Tables(0)
    '            Else
    '                FacClie_dttObtenerLineasFactura = Nothing
    '            End If
    '        End If

    '        'Anulamos el control de errores
    '        On Error GoTo 0
    '        Exit Function

    'TratarError:

    '        'Guardamos el error
    '        lngError = Err.Number
    '        strError = Err.Description

    '        AddLog(lngError & " - " & strError, mc_strNombre_Modulo, strNombre_Funcion)

    '        Resume Terminar
    '    End Function

    '    '<CABECERA>-----------------------------------------------
    '    'Nombre...........: FacClie_blnAnadirLineasFactura
    '    'Descripcion......: Añade las lineas de un Factura a la base de datos
    '    'Fecha............: 31/05/2012
    '    'Autor............: Borja Escudero
    '    'Parametros.......: objFactura = Factura al que pertenecen las lineas
    '    'Retorno..........: TRUE si todo va bien
    '    '<FIN CABECERA>-------------------------------------------
    '    Public Function FacClie_blnAnadirLineasFactura(ByRef objFactura As clsFacturaCliente) As Boolean

    '        Const strNombre_Funcion As String = "FacturaClie_blnAnadirLineasFactura"
    '        Dim lngError As Long
    '        Dim strError As String

    '        Dim blnResultado As Boolean
    '        Dim objrow As DataRow
    '        Dim colQuerys As New Collection
    '        Dim strQuery As String
    '        Dim lngNumLinea As Long

    '        On Error GoTo TratarError

    '        'Previemente se eliminan las lineas del ticket
    '        strQuery = FacClie_strQueryEliminarLineasFactura(objFactura.Id)
    '        blnEjecutarQuery(strQuery)

    '        lngNumLinea = 1
    '        For Each objrow In objFactura.LineasFactura.Rows
    '            If objrow.RowState <> DataRowState.Deleted Then
    '                colQuerys.Add(FacClie_strQueryAnadirLineaFactura(objrow, lngNumLinea, objFactura.Id))
    '                lngNumLinea += 1
    '            End If
    '        Next

    '        For Each strQuery In colQuerys
    '            If blnEjecutarQuery(strQuery) Then
    '                'La adicion a funcionado satisfactoriamente
    '                blnResultado = True
    '            Else
    '                'Ha habido algun tipo de error en el proceso de adicion
    '                blnResultado = False
    '                Exit For
    '            End If
    '        Next

    'Terminar:

    '        'Retornamos el valor
    '        FacClie_blnAnadirLineasFactura = blnResultado

    '        'Anulamos el control de errores
    '        On Error GoTo 0
    '        Exit Function

    'TratarError:

    '        'Guardamos el error
    '        lngError = Err.Number
    '        strError = Err.Description

    '        AddLog(lngError & " - " & strError, mc_strNombre_Modulo, strNombre_Funcion)

    '        Resume Terminar
    '    End Function

End Module
