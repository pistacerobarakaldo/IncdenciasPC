Option Explicit On
Option Compare Text

Module modBDQIncidencias

    'Constante que guarda el nombre del mudolu
    Const mc_strNombre_Modulo As String = "modBDQIncidencias"

    '<CABECERA>-----------------------------------------------
    'Descripcion......: Genera la query para obtener las incidencias
    'Fecha............: 29/04/2014
    '<FIN CABECERA>-------------------------------------------
    Public Function Inci_strQueryObtenerIncidencias(Optional ByVal lngIdIncidencia As Long = -1, Optional ByVal strWhere As String = "") As String

        Const strNombre_Funcion As String = "Inci_strQueryObtenerIncidencias"
        Dim blnError As Boolean
        
        Dim strQuery As String = ""

        Try
            'SELECT
            strQuery = "SELECT " & gc_strDB_TABLA_Incidencias & "." & gc_strDB_I_Incidencia
            strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_I_Incidencia)
            strQuery = strQuery & ", " & gc_strDB_TABLA_Incidencias & "." & gc_strDB_F_Entrada
            strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_F_Entrada)
            strQuery = strQuery & ", " & gc_strDB_TABLA_Incidencias & "." & gc_strDB_C_Cliente
            strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_c_Cliente)
            strQuery = strQuery & ", " & gc_strDB_TABLA_Incidencias & "." & gc_strDB_D_Cliente
            strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_D_Cliente)
            strQuery = strQuery & ", " & gc_strDB_TABLA_Incidencias & "." & gc_strDB_D_Contacto
            strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_D_Contacto)
            strQuery = strQuery & ", " & gc_strDB_TABLA_Incidencias & "." & gc_strDB_D_Telefono1
            strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_D_Telefono1)
            strQuery = strQuery & ", " & gc_strDB_TABLA_Incidencias & "." & gc_strDB_D_Telefono2
            strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_D_Telefono2)
            strQuery = strQuery & ", " & gc_strDB_TABLA_Incidencias & "." & gc_strDB_C_Tipo
            strQuery = strQuery & ", " & gc_strDB_TABLA_TiposEquipos & "." & gc_strDB_D_TipoEquipo
            strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_C_Tipo)
            strQuery = strQuery & ", " & gc_strDB_TABLA_Incidencias & "." & gc_strDB_D_Marca
            strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_D_Marca)
            strQuery = strQuery & ", " & gc_strDB_TABLA_Incidencias & "." & gc_strDB_D_Modelo
            strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_D_Modelo)
            strQuery = strQuery & ", " & gc_strDB_TABLA_Incidencias & "." & gc_strDB_D_NSerie
            strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_D_NSerie)
            strQuery = strQuery & ", " & gc_strDB_TABLA_Incidencias & "." & gc_strDB_D_Obser
            strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_D_Obser)
            strQuery = strQuery & ", " & gc_strDB_TABLA_Incidencias & "." & gc_strDB_B_Maletin
            strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_B_Maletin)
            strQuery = strQuery & ", " & gc_strDB_TABLA_Incidencias & "." & gc_strDB_B_Cargador
            strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_B_Cargador)
            strQuery = strQuery & ", " & gc_strDB_TABLA_Incidencias & "." & gc_strDB_D_Averia
            strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_D_Averia)
            strQuery = strQuery & ", " & gc_strDB_TABLA_Incidencias & "." & gc_strDB_D_Resolucion
            strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_D_Resolucion)
            strQuery = strQuery & ", " & gc_strDB_TABLA_Incidencias & "." & gc_strDB_V_Importe
            strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_V_Importe)
            strQuery = strQuery & ", " & gc_strDB_TABLA_Incidencias & "." & gc_strDB_C_Estado
            strQuery = strQuery & ", " & gc_strDB_TABLA_Estados & "." & gc_strDB_D_Estado
            strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_C_Estado)
            strQuery = strQuery & ", " & gc_strDB_TABLA_Incidencias & "." & gc_strDB_B_Garantia
            strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_B_Garantia)
            strQuery = strQuery & vbCrLf

            'FROM
            strQuery = strQuery & "FROM " & gc_strDB_TABLA_TiposEquipos & " RIGHT JOIN ("
            strQuery = strQuery & gc_strDB_TABLA_Estados & " RIGHT JOIN " & gc_strDB_TABLA_Incidencias
            strQuery = strQuery & " ON " & gc_strDB_TABLA_Estados & "." & gc_strDB_I_Estado
            strQuery = strQuery & " = " & gc_strDB_TABLA_Incidencias & "." & gc_strDB_C_Estado & ")"
            strQuery = strQuery & " ON " & gc_strDB_TABLA_TiposEquipos & "." & gc_strDB_I_TipoEquipo
            strQuery = strQuery & " = " & gc_strDB_TABLA_Incidencias & "." & gc_strDB_C_Tipo
            strQuery = strQuery & vbCrLf

            'WHERE
            If strWhere <> "" Then
                strQuery = strQuery & strWhere
            Else
                If lngIdIncidencia <> -1 Then
                    strQuery = strQuery & "WHERE " & gc_strDB_TABLA_Incidencias & "." & gc_strDB_I_Incidencia & " = " & lngIdIncidencia
                    strQuery = strQuery & vbCrLf
                End If
            End If

            'ORDER BY
            strQuery = strQuery & "ORDER BY " & gc_strDB_TABLA_Incidencias & "." & gc_strDB_I_Incidencia
        Catch ex As Exception
            blnError = True
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        Finally
            If blnError Then
                Inci_strQueryObtenerIncidencias = ""
            Else
                Inci_strQueryObtenerIncidencias = strQuery
            End If
        End Try
    End Function

    '<CABECERA>-----------------------------------------------
    'Descripcion......: Genera la query para obtener las incidencias
    'Fecha............: 29/04/2014
    '<FIN CABECERA>-------------------------------------------
    Public Function Inci_strQueryNuevaIncidencia(ByVal objIncidencia As clsIncidencia) As String

        Const strNombre_Funcion As String = "Inci_strQueryNuevaIncidencia"
        Dim blnError As Boolean

        Dim strQuery As String = ""

        Try
            'SELECT
            strQuery = "INSERT INTO " & gc_strDB_TABLA_Incidencias & " ("
            strQuery = strQuery & gc_strDB_I_Incidencia
            strQuery = strQuery & ", " & gc_strDB_F_Entrada
            strQuery = strQuery & ", " & gc_strDB_C_Cliente
            strQuery = strQuery & ", " & gc_strDB_D_Cliente
            strQuery = strQuery & ", " & gc_strDB_D_Contacto
            strQuery = strQuery & ", " & gc_strDB_D_Telefono1
            strQuery = strQuery & ", " & gc_strDB_D_Telefono2
            strQuery = strQuery & ", " & gc_strDB_C_Tipo
            strQuery = strQuery & ", " & gc_strDB_D_Marca
            strQuery = strQuery & ", " & gc_strDB_D_Modelo
            strQuery = strQuery & ", " & gc_strDB_D_NSerie
            strQuery = strQuery & ", " & gc_strDB_D_Obser
            strQuery = strQuery & ", " & gc_strDB_B_Maletin
            strQuery = strQuery & ", " & gc_strDB_B_Cargador
            strQuery = strQuery & ", " & gc_strDB_D_Averia
            strQuery = strQuery & ", " & gc_strDB_D_Resolucion
            strQuery = strQuery & ", " & gc_strDB_V_Importe
            strQuery = strQuery & ", " & gc_strDB_C_Estado
            strQuery = strQuery & ", " & gc_strDB_B_Garantia
            strQuery = strQuery & ")"
            strQuery = strQuery & vbCrLf

            'VALUES
            strQuery = strQuery & "VALUES ("
            strQuery = strQuery & ", " & objIncidencia.Id
            strQuery = strQuery & ", #" & Format(objIncidencia.Fecha, "MM/dd/yyyy") & "#"
            strQuery = strQuery & ", " & objIncidencia.IdCliente
            strQuery = strQuery & ", '" & objIncidencia.Cliente & "'"
            strQuery = strQuery & ", '" & objIncidencia.Contacto & "'"
            strQuery = strQuery & ", '" & objIncidencia.Telefono1 & "'"
            strQuery = strQuery & ", '" & objIncidencia.Telefono2 & "'"
            strQuery = strQuery & ", " & objIncidencia.TipoEquipo
            strQuery = strQuery & ", '" & objIncidencia.Marca & "'"
            strQuery = strQuery & ", '" & objIncidencia.Modelo & "'"
            strQuery = strQuery & ", '" & objIncidencia.NumeroSerie & "'"
            strQuery = strQuery & ", '" & objIncidencia.Observaciones & "'"
            strQuery = strQuery & ", " & objIncidencia.Maletin
            strQuery = strQuery & ", " & objIncidencia.Cargador
            strQuery = strQuery & ", '" & objIncidencia.Averia & "'"
            strQuery = strQuery & ", '" & objIncidencia.Resolucion & "'"
            strQuery = strQuery & ", " & strComaPunto(objIncidencia.Importe)
            strQuery = strQuery & ", " & objIncidencia.Estado
            strQuery = strQuery & ", " & objIncidencia.Garantia
            strQuery = strQuery & ")"
            strQuery = strQuery & vbCrLf
        Catch ex As Exception
            blnError = True
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        Finally
            If blnError Then
                Inci_strQueryNuevaIncidencia = ""
            Else
                Inci_strQueryNuevaIncidencia = strQuery
            End If
        End Try
    End Function

    '<CABECERA>-----------------------------------------------
    'Descripcion......: Genera la query para modificar una incidencia
    'Fecha............: 15/05/2014
    '<FIN CABECERA>-------------------------------------------
    Public Function Inci_strQueryModificarIncidencia(ByVal objIncidencia As clsIncidencia) As String

        Const strNombre_Funcion As String = "Inci_strQueryModificarIncidencia"
        Dim blnError As Boolean

        Dim strQuery As String = ""

        Try
            'SELECT
            strQuery = "UPDATE " & gc_strDB_TABLA_Incidencias
            strQuery = strQuery & vbCrLf

            'SET
            strQuery = strQuery & "SET " & gc_strDB_F_Entrada
            strQuery = strQuery & " = #" & Format(objIncidencia.Fecha, "MM/dd/yyyy") & "#"
            strQuery = strQuery & ", " & gc_strDB_C_Cliente
            strQuery = strQuery & " = " & objIncidencia.IdCliente
            strQuery = strQuery & ", " & gc_strDB_D_Cliente
            strQuery = strQuery & " = '" & objIncidencia.Cliente & "'"
            strQuery = strQuery & ", " & gc_strDB_D_Contacto
            strQuery = strQuery & " = '" & objIncidencia.Contacto & "'"
            strQuery = strQuery & ", " & gc_strDB_D_Telefono1
            strQuery = strQuery & " = '" & objIncidencia.Telefono1 & "'"
            strQuery = strQuery & ", " & gc_strDB_D_Telefono2
            strQuery = strQuery & " = '" & objIncidencia.Telefono2 & "'"
            strQuery = strQuery & ", " & gc_strDB_C_Tipo
            strQuery = strQuery & " = " & objIncidencia.TipoEquipo
            strQuery = strQuery & ", " & gc_strDB_D_Marca
            strQuery = strQuery & " = '" & objIncidencia.Marca & "'"
            strQuery = strQuery & ", " & gc_strDB_D_Modelo
            strQuery = strQuery & " = '" & objIncidencia.Modelo & "'"
            strQuery = strQuery & ", " & gc_strDB_D_NSerie
            strQuery = strQuery & " = '" & objIncidencia.NumeroSerie & "'"
            strQuery = strQuery & ", " & gc_strDB_D_Obser
            strQuery = strQuery & " = '" & objIncidencia.Observaciones & "'"
            strQuery = strQuery & ", " & gc_strDB_B_Maletin
            strQuery = strQuery & " = " & objIncidencia.Maletin
            strQuery = strQuery & ", " & gc_strDB_B_Cargador
            strQuery = strQuery & " = " & objIncidencia.Cargador
            strQuery = strQuery & ", " & gc_strDB_D_Averia
            strQuery = strQuery & " = '" & objIncidencia.Averia & "'"
            strQuery = strQuery & ", " & gc_strDB_D_Resolucion
            strQuery = strQuery & " = '" & objIncidencia.Resolucion & "'"
            strQuery = strQuery & ", " & gc_strDB_V_Importe
            strQuery = strQuery & " = " & strComaPunto(objIncidencia.Importe)
            strQuery = strQuery & ", " & gc_strDB_C_Estado
            strQuery = strQuery & " = " & objIncidencia.Estado
            strQuery = strQuery & ", " & gc_strDB_B_Garantia
            strQuery = strQuery & " = " & objIncidencia.Garantia
            strQuery = strQuery & vbCrLf

            'VALUES
            strQuery = strQuery & "WHERE " & gc_strDB_I_Incidencia & " = " & objIncidencia.Id
        Catch ex As Exception
            blnError = True
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        Finally
            If blnError Then
                Inci_strQueryModificarIncidencia = ""
            Else
                Inci_strQueryModificarIncidencia = strQuery
            End If
        End Try
    End Function

    '<CABECERA>-----------------------------------------------
    'Descripcion......: Genera la query para obtener las lineas de actuacion de una incidencia
    'Fecha............: 30/04/2014
    '<FIN CABECERA>-------------------------------------------
    Public Function Inci_strQueryObtenerLineasActuacion(ByVal lngIdIncidencia As Long) As String

        Const strNombre_Funcion As String = "Inci_strQueryObtenerLineasActuacion"
        Dim blnError As Boolean

        Dim strQuery As String = ""

        Try
            'SELECT
            strQuery = "SELECT " & gc_strDB_TABLA_LineasActuacion & "." & gc_strDB_C_Incidencia
            strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_C_Incidencia)
            strQuery = strQuery & ", " & gc_strDB_TABLA_LineasActuacion & "." & gc_strDB_C_Linea
            strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_C_Linea)
            strQuery = strQuery & ", " & gc_strDB_TABLA_LineasActuacion & "." & gc_strDB_C_Estado
            strQuery = strQuery & ", " & gc_strDB_TABLA_Estados & "." & gc_strDB_D_Estado
            strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_C_Estado)
            strQuery = strQuery & ", " & gc_strDB_TABLA_LineasActuacion & "." & gc_strDB_F_Fecha
            strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_F_fecha)
            strQuery = strQuery & ", " & gc_strDB_TABLA_LineasActuacion & "." & gc_strDB_D_Descripcion
            strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_d_descripcion)
            strQuery = strQuery & vbCrLf

            'FROM
            strQuery = strQuery & "FROM " & gc_strDB_TABLA_Estados & " RIGHT JOIN " & gc_strDB_TABLA_LineasActuacion
            strQuery = strQuery & " ON " & gc_strDB_TABLA_Estados & "." & gc_strDB_I_Estado
            strQuery = strQuery & " = " & gc_strDB_TABLA_LineasActuacion & "." & gc_strDB_C_Estado
            strQuery = strQuery & vbCrLf

            'WHERE
            strQuery = strQuery & "WHERE " & gc_strDB_TABLA_LineasActuacion & "." & gc_strDB_C_Incidencia & " = " & lngIdIncidencia
            strQuery = strQuery & vbCrLf

            'ORDER BY
            strQuery = strQuery & "ORDER BY " & gc_strDB_TABLA_LineasActuacion & "." & gc_strDB_C_Linea
        Catch ex As Exception
            blnError = True
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        Finally
            If blnError Then
                Inci_strQueryObtenerLineasActuacion = ""
            Else
                Inci_strQueryObtenerLineasActuacion = strQuery
            End If
        End Try
    End Function

    '<CABECERA>-----------------------------------------------
    'Descripcion......: Genera la query para obtener las lineas de actuacion de una incidencia
    'Fecha............: 30/04/2014
    '<FIN CABECERA>-------------------------------------------
    Public Function Inci_strQueryNuevaLineaActuacion(ByVal objRow As DataRow) As String

        Const strNombre_Funcion As String = "Inci_strQueryObtenerLineasActuacion"
        Dim blnError As Boolean

        Dim strQuery As String = ""

        Try
            'INSERT INTO
            strQuery = "INSERT INTO " & gc_strDB_TABLA_LineasActuacion
            strQuery = strQuery & " (" & gc_strDB_C_Incidencia
            strQuery = strQuery & ", " & gc_strDB_C_Linea
            strQuery = strQuery & ", " & gc_strDB_C_Estado
            strQuery = strQuery & ", " & gc_strDB_F_Fecha
            strQuery = strQuery & ", " & gc_strDB_D_Descripcion
            strQuery = strQuery & ")"
            strQuery = strQuery & vbCrLf

            'VALUES
            strQuery = strQuery & "VALUES ("
            strQuery = strQuery & objRow(gc_strLP_C_Incidencia)
            strQuery = strQuery & ", " & objRow(gc_strLP_C_Linea)
            strQuery = strQuery & ", " & objRow(gc_strDB_C_Estado)
            strQuery = strQuery & ", #" & Format(objRow(gc_strLP_F_Fecha), "MM/dd/yyyy") & "#"
            strQuery = strQuery & ", '" & objRow(gc_strLP_C_Linea) & "'"
            strQuery = strQuery & ")"
        Catch ex As Exception
            blnError = True
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        Finally
            If blnError Then
                Inci_strQueryNuevaLineaActuacion = ""
            Else
                Inci_strQueryNuevaLineaActuacion = strQuery
            End If
        End Try
    End Function

    '<CABECERA>-----------------------------------------------
    'Descripcion......: Genera la query para eliminar el historial de una incidencia
    'Fecha............: 15/05/2014
    '<FIN CABECERA>-------------------------------------------
    Public Function Inci_strQueryEliminarLineasActuacion(ByVal lngIdIncidencia As Long) As String

        Const strNombre_Funcion As String = "Inci_strQueryEliminarLineasActuacion"
        Dim blnError As Boolean

        Dim strQuery As String = ""

        Try
            'DELETE
            strQuery = "DELETE *"
            strQuery = strQuery & vbCrLf

            'FROM
            strQuery = strQuery & "FROM " & gc_strDB_TABLA_LineasActuacion
            strQuery = strQuery & vbCrLf

            'WHERE
            strQuery = strQuery & "WHERE " & gc_strDB_C_Incidencia & " = " & lngIdIncidencia
        Catch ex As Exception
            blnError = True
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        Finally
            If blnError Then
                Inci_strQueryEliminarLineasActuacion = ""
            Else
                Inci_strQueryEliminarLineasActuacion = strQuery
            End If
        End Try
    End Function

    '<CABECERA>-----------------------------------------------
    'Descripcion......: Genera la query para obtener las lineas de presupuesto de una incidencia
    'Fecha............: 30/04/2014
    '<FIN CABECERA>-------------------------------------------
    Public Function Inci_strQueryObtenerLineasPresupuesto(ByVal lngIdIncidencia As Long) As String

        Const strNombre_Funcion As String = "Inci_strQueryObtenerLineasPresupuesto"
        Dim blnError As Boolean

        Dim strQuery As String = ""

        Try
            'SELECT
            strQuery = "SELECT " & gc_strDB_TABLA_LineasPresupuesto & "." & gc_strDB_C_Incidencia
            strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_C_Incidencia)
            strQuery = strQuery & ", " & gc_strDB_TABLA_LineasPresupuesto & "." & gc_strDB_C_Linea
            strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_C_Linea)
            strQuery = strQuery & ", " & gc_strDB_TABLA_LineasPresupuesto & "." & gc_strDB_D_Concepto
            strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_D_Concepto)
            strQuery = strQuery & ", " & gc_strDB_TABLA_LineasPresupuesto & "." & gc_strDB_V_Importe
            strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_V_Importe)
            strQuery = strQuery & ", " & gc_strDB_TABLA_LineasPresupuesto & "." & gc_strDB_V_Cantidad
            strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_V_Cantidad)
            strQuery = strQuery & ", " & gc_strDB_TABLA_LineasPresupuesto & "." & gc_strDB_V_Base
            strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_V_Base)
            strQuery = strQuery & ", " & gc_strDB_TABLA_LineasPresupuesto & "." & gc_strDB_V_PIVA
            strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_V_PIVA)
            strQuery = strQuery & ", " & gc_strDB_TABLA_LineasPresupuesto & "." & gc_strDB_V_IVA
            strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_V_IVA)
            strQuery = strQuery & ", " & gc_strDB_TABLA_LineasPresupuesto & "." & gc_strDB_V_Total
            strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_V_Total)
            strQuery = strQuery & vbCrLf

            'FROM
            strQuery = strQuery & "FROM " & gc_strDB_TABLA_LineasPresupuesto
            strQuery = strQuery & vbCrLf

            'WHERE
            strQuery = strQuery & "WHERE " & gc_strDB_TABLA_LineasPresupuesto & "." & gc_strDB_C_Incidencia & " = " & lngIdIncidencia
            strQuery = strQuery & vbCrLf

            'ORDER BY
            strQuery = strQuery & "ORDER BY " & gc_strDB_TABLA_LineasPresupuesto & "." & gc_strDB_C_Linea
        Catch ex As Exception
            blnError = True
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        Finally
            If blnError Then
                Inci_strQueryObtenerLineasPresupuesto = ""
            Else
                Inci_strQueryObtenerLineasPresupuesto = strQuery
            End If
        End Try
    End Function

    '<CABECERA>-----------------------------------------------
    'Descripcion......: Genera la query para obtener las lineas de actuacion de una incidencia
    'Fecha............: 30/04/2014
    '<FIN CABECERA>-------------------------------------------
    Public Function Inci_strQueryNuevaLineaPresupuesto(ByVal objRow As DataRow) As String

        Const strNombre_Funcion As String = "Inci_strQueryNuevaLineaPresupuesto"
        Dim blnError As Boolean

        Dim strQuery As String = ""

        Try
            'INSERT INTO
            strQuery = "INSERT INTO " & gc_strDB_TABLA_LineasPresupuesto
            strQuery = strQuery & " (" & gc_strDB_C_Incidencia
            strQuery = strQuery & ", " & gc_strDB_C_Linea
            strQuery = strQuery & ", " & gc_strDB_D_Concepto
            strQuery = strQuery & ", " & gc_strDB_V_Importe
            strQuery = strQuery & ", " & gc_strDB_V_Cantidad
            strQuery = strQuery & ", " & gc_strDB_V_Base
            strQuery = strQuery & ", " & gc_strDB_V_PIVA
            strQuery = strQuery & ", " & gc_strDB_V_IVA
            strQuery = strQuery & ", " & gc_strDB_V_Total
            strQuery = strQuery & ")"
            strQuery = strQuery & vbCrLf

            'VALUES
            strQuery = strQuery & "VALUES ("
            strQuery = strQuery & objRow(gc_strLP_C_Incidencia)
            strQuery = strQuery & ", " & objRow(gc_strLP_C_Linea)
            strQuery = strQuery & ", '" & objRow(gc_strLP_D_Concepto) & "'"
            strQuery = strQuery & ", " & strComaPunto(objRow(gc_strLP_V_Importe))
            strQuery = strQuery & ", " & strComaPunto(objRow(gc_strLP_V_Cantidad))
            strQuery = strQuery & ", " & strComaPunto(objRow(gc_strLP_V_Base))
            strQuery = strQuery & ", " & strComaPunto(objRow(gc_strLP_V_PIVA))
            strQuery = strQuery & ", " & strComaPunto(objRow(gc_strLP_V_IVA))
            strQuery = strQuery & ", " & strComaPunto(objRow(gc_strLP_V_Total))
            strQuery = strQuery & ")"
        Catch ex As Exception
            blnError = True
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        Finally
            If blnError Then
                Inci_strQueryNuevaLineaPresupuesto = ""
            Else
                Inci_strQueryNuevaLineaPresupuesto = strQuery
            End If
        End Try
    End Function

    '<CABECERA>-----------------------------------------------
    'Descripcion......: Genera la query para eliminar el historial de una incidencia
    'Fecha............: 15/05/2014
    '<FIN CABECERA>-------------------------------------------
    Public Function Inci_strQueryEliminarLineasPresupuesto(ByVal lngIdIncidencia As Long) As String

        Const strNombre_Funcion As String = "Inci_strQueryEliminarLineasPresupuesto"
        Dim blnError As Boolean

        Dim strQuery As String = ""

        Try
            'DELETE
            strQuery = "DELETE *"
            strQuery = strQuery & vbCrLf

            'FROM
            strQuery = strQuery & "FROM " & gc_strDB_TABLA_LineasPresupuesto
            strQuery = strQuery & vbCrLf

            'WHERE
            strQuery = strQuery & "WHERE " & gc_strDB_C_Incidencia & " = " & lngIdIncidencia
        Catch ex As Exception
            blnError = True
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        Finally
            If blnError Then
                Inci_strQueryEliminarLineasPresupuesto = ""
            Else
                Inci_strQueryEliminarLineasPresupuesto = strQuery
            End If
        End Try
    End Function

    '<CABECERA>-----------------------------------------------
    'Descripcion......: Genera la query para obtener los estados
    'Fecha............: 30/04/2014
    '<FIN CABECERA>-------------------------------------------
    Public Function Inci_strQueryObtenerEstados() As String

        Const strNombre_Funcion As String = "Inci_strQueryObtenerEstados"
        Dim blnError As Boolean

        Dim strQuery As String = ""

        Try
            'SELECT
            strQuery = "SELECT " & gc_strDB_TABLA_Estados & "." & gc_strDB_I_Estado
            strQuery = strQuery & ", " & gc_strDB_TABLA_Estados & "." & gc_strDB_D_Estado
            strQuery = strQuery & vbCrLf

            'FROM
            strQuery = strQuery & "FROM " & gc_strDB_TABLA_Estados
            strQuery = strQuery & vbCrLf

            'ORDER BY
            strQuery = strQuery & "ORDER BY " & gc_strDB_TABLA_Estados & "." & gc_strDB_I_Estado
        Catch ex As Exception
            blnError = True
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        Finally
            If blnError Then
                Inci_strQueryObtenerEstados = ""
            Else
                Inci_strQueryObtenerEstados = strQuery
            End If
        End Try
    End Function

    '<CABECERA>-----------------------------------------------
    'Descripcion......: Genera la query para obtener los tipos de equipo
    'Fecha............: 30/04/2014
    '<FIN CABECERA>-------------------------------------------
    Public Function Inci_strQueryObtenerTiposEquipo() As String

        Const strNombre_Funcion As String = "Inci_strQueryObtenerTiposEquipo"
        Dim blnError As Boolean

        Dim strQuery As String = ""

        Try
            'SELECT
            strQuery = "SELECT " & gc_strDB_TABLA_TiposEquipos & "." & gc_strDB_I_TipoEquipo
            strQuery = strQuery & ", " & gc_strDB_TABLA_TiposEquipos & "." & gc_strDB_D_TipoEquipo
            strQuery = strQuery & vbCrLf

            'FROM
            strQuery = strQuery & "FROM " & gc_strDB_TABLA_TiposEquipos
            strQuery = strQuery & vbCrLf

            'ORDER BY
            strQuery = strQuery & "ORDER BY " & gc_strDB_TABLA_TiposEquipos & "." & gc_strDB_I_TipoEquipo
        Catch ex As Exception
            blnError = True
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        Finally
            If blnError Then
                Inci_strQueryObtenerTiposEquipo = ""
            Else
                Inci_strQueryObtenerTiposEquipo = strQuery
            End If
        End Try
    End Function

    '    '<CABECERA>-----------------------------------------------
    '    'Nombre...........: FacClie_strQueryAnadirFactura
    '    'Descripcion......: Obtiene la query para añadir una nueva factura
    '    'Fecha............: 07/03/2012
    '    'Autor............: Borja Escudero
    '    'Parametros.......: objFactura = Objeto de tipo factura con los datos del nuevo factura
    '    'Retorno..........: Query para añadir un nuevo factura
    '    '<FIN CABECERA>-------------------------------------------
    '    Public Function FacClie_strQueryAnadirFactura(ByVal objFactura As clsFacturaCliente) As String

    '        Const strNombre_Funcion As String = "FacClie_strQueryAnadirFactura"
    '        Dim lngError As Long
    '        Dim strError As String

    '        Dim strQuery As String

    '        On Error GoTo TratarError

    '        'SELECT
    '        strQuery = "INSERT INTO " & gc_strDB_TABLA_FACTURAS_CLIENTES
    '        strQuery = strQuery & "(" & gc_strDB_ID_FACTURA
    '        strQuery = strQuery & ", " & gc_strDB_COD_CLIENTE
    '        strQuery = strQuery & ", " & gc_strDB_COD_CANAL
    '        strQuery = strQuery & ", " & gc_strDB_FCH_FACTURA
    '        strQuery = strQuery & ", " & gc_strDB_FCH_MODIFICACION
    '        strQuery = strQuery & ", " & gc_strDB_COD_FORMA_PAGO
    '        strQuery = strQuery & ", " & gc_strDB_VAL_BRUTO
    '        strQuery = strQuery & ", " & gc_strDB_VAL_BASE_IMPONIBLE
    '        strQuery = strQuery & ", " & gc_strDB_VAL_TRANSPORTE
    '        strQuery = strQuery & ", " & gc_strDB_COD_TIPO_IVA_TRANSPORTE
    '        strQuery = strQuery & ", " & gc_strDB_VAL_IMPORTE_IVA_TRANS
    '        strQuery = strQuery & ", " & gc_strDB_VAL_IMPORTE_RE_TRANS
    '        strQuery = strQuery & ", " & gc_strDB_NUM_DESC_GENERAL
    '        strQuery = strQuery & ", " & gc_strDB_VAL_IMPORTE_DESC_GNRL
    '        strQuery = strQuery & ", " & gc_strDB_NUM_DESC_ADICIONAL
    '        strQuery = strQuery & ", " & gc_strDB_VAL_IMPORTE_DESC_ADIC
    '        strQuery = strQuery & ", " & gc_strDB_NUM_CARGO_GENERAL
    '        strQuery = strQuery & ", " & gc_strDB_VAL_IMPORTE_CARG_GNRL
    '        strQuery = strQuery & ", " & gc_strDB_NUM_CARGO_EXEIVA
    '        strQuery = strQuery & ", " & gc_strDB_VAL_IMPORTE_CARG_EXEIVA
    '        strQuery = strQuery & ", " & gc_strDB_VAL_IMPORTE_TOTAL_IVA
    '        strQuery = strQuery & ", " & gc_strDB_VAL_IMPORTE_TOTAL_RE
    '        strQuery = strQuery & ", " & gc_strDB_VAL_IMPORTE_FACTURA
    '        strQuery = strQuery & ", " & gc_strDB_COD_EXENTO_IVA
    '        strQuery = strQuery & ", " & gc_strDB_COD_EXENTO_RE
    '        strQuery = strQuery & ", " & gc_strDB_COD_COMERCIAL
    '        strQuery = strQuery & ", " & gc_strDB_COD_IVA_GENERAL
    '        strQuery = strQuery & ", " & gc_strDB_COD_IVA_REDUCIDO
    '        strQuery = strQuery & ", " & gc_strDB_COD_IVA_SUPREDUCIDO
    '        strQuery = strQuery & ", " & gc_strDB_COD_RE_GENERAL
    '        strQuery = strQuery & ", " & gc_strDB_COD_RE_REDUCIDO
    '        strQuery = strQuery & ", " & gc_strDB_COD_RE_SUPREDUCIDO
    '        strQuery = strQuery & ", " & gc_strDB_COD_PUESTO
    '        strQuery = strQuery & ")"
    '        strQuery = strQuery & vbCrLf

    '        'VALUES
    '        strQuery = strQuery & "VALUES (" & objFactura.Id
    '        strQuery = strQuery & ", " & objFactura.Cliente
    '        strQuery = strQuery & ", " & objFactura.Canal
    '        strQuery = strQuery & ", #" & Format(Date.Today, "MM/dd/yyyy") & "#"
    '        strQuery = strQuery & ", #" & Format(Date.Today, "MM/dd/yyyy") & "#"
    '        strQuery = strQuery & ", " & objFactura.FormaPago
    '        strQuery = strQuery & ", " & strComaPunto(objFactura.Bruto)
    '        strQuery = strQuery & ", " & strComaPunto(objFactura.BaseImponible)
    '        strQuery = strQuery & ", " & strComaPunto(objFactura.ImporteTransporte)
    '        strQuery = strQuery & ", " & objFactura.TipoIVATransporte
    '        strQuery = strQuery & ", " & strComaPunto(objFactura.ImporteIVATransporte)
    '        strQuery = strQuery & ", " & strComaPunto(objFactura.ImporteRETransporte)
    '        strQuery = strQuery & ", " & strComaPunto(objFactura.DescuentoGeneral)
    '        strQuery = strQuery & ", " & strComaPunto(objFactura.ImporteDescuentoGeneral)
    '        strQuery = strQuery & ", " & strComaPunto(objFactura.DescuentoProntoPago)
    '        strQuery = strQuery & ", " & strComaPunto(objFactura.ImporteDescuentoProntoPago)
    '        strQuery = strQuery & ", " & strComaPunto(objFactura.CargoGeneral)
    '        strQuery = strQuery & ", " & strComaPunto(objFactura.ImporteCargoGeneral)
    '        strQuery = strQuery & ", " & strComaPunto(objFactura.CargoExeIVA)
    '        strQuery = strQuery & ", " & strComaPunto(objFactura.ImporteCargoExeIVA)
    '        strQuery = strQuery & ", " & strComaPunto(objFactura.ImporteIVA)
    '        strQuery = strQuery & ", " & strComaPunto(objFactura.ImporteRE)
    '        strQuery = strQuery & ", " & strComaPunto(objFactura.ImporteFactura)
    '        strQuery = strQuery & ", " & objFactura.ExentoIVA
    '        strQuery = strQuery & ", " & objFactura.ExentoRE
    '        strQuery = strQuery & ", " & objFactura.Comercial
    '        strQuery = strQuery & ", " & objFactura.IdIVAGeneral
    '        strQuery = strQuery & ", " & objFactura.IdIVAReducido
    '        strQuery = strQuery & ", " & objFactura.IdIVASReducido
    '        strQuery = strQuery & ", " & objFactura.IdREGeneral
    '        strQuery = strQuery & ", " & objFactura.IdREReducido
    '        strQuery = strQuery & ", " & objFactura.IdRESReducido
    '        strQuery = strQuery & ", " & objFactura.Puesto
    '        strQuery = strQuery & ") "

    'Terminar:

    '        If lngError <> 0 Then
    '            FacClie_strQueryAnadirFactura = ""
    '        Else
    '            FacClie_strQueryAnadirFactura = strQuery
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
    '    'Nombre...........: FacClie_strQueryEditarFactura
    '    'Descripcion......: Obtiene la query para editar un Factura
    '    'Fecha............: 07/03/2012
    '    'Autor............: Borja Escudero
    '    'Parametros.......: objFactura = Objeto de tipo Factura con los datos del Factura
    '    'Retorno..........: Query para editar un Factura
    '    '<FIN CABECERA>-------------------------------------------
    '    Public Function FacClie_strQueryEditarFactura(ByVal objFactura As clsFacturaCliente) As String

    '        Const strNombre_Funcion As String = "FacClie_strQueryEditarFactura"
    '        Dim lngError As Long
    '        Dim strError As String

    '        Dim strQuery As String
    '        Dim objDate As Date

    '        On Error GoTo TratarError

    '        'UPDATE
    '        strQuery = "UPDATE " & gc_strDB_TABLA_FACTURAS_CLIENTES
    '        strQuery = strQuery & vbCrLf

    '        'SET
    '        strQuery = strQuery & "SET " & gc_strDB_COD_CLIENTE
    '        strQuery = strQuery & " = " & objFactura.Cliente
    '        strQuery = strQuery & ", " & gc_strDB_COD_CANAL
    '        strQuery = strQuery & " = " & objFactura.Canal
    '        strQuery = strQuery & ", " & gc_strDB_FCH_MODIFICACION
    '        strQuery = strQuery & " = #" & Format(Date.Today, "MM/dd/yyyy") & "#"
    '        strQuery = strQuery & ", " & gc_strDB_COD_FORMA_PAGO
    '        strQuery = strQuery & " = " & objFactura.FormaPago
    '        strQuery = strQuery & ", " & gc_strDB_VAL_BRUTO
    '        strQuery = strQuery & " = " & strComaPunto(objFactura.Bruto)
    '        strQuery = strQuery & ", " & gc_strDB_VAL_BASE_IMPONIBLE
    '        strQuery = strQuery & " = " & strComaPunto(objFactura.BaseImponible)
    '        strQuery = strQuery & ", " & gc_strDB_VAL_TRANSPORTE
    '        strQuery = strQuery & " = " & strComaPunto(objFactura.ImporteTransporte)
    '        strQuery = strQuery & ", " & gc_strDB_COD_TIPO_IVA_TRANSPORTE
    '        strQuery = strQuery & " = " & objFactura.TipoIVATransporte
    '        strQuery = strQuery & ", " & gc_strDB_VAL_IMPORTE_IVA_TRANS
    '        strQuery = strQuery & " = " & strComaPunto(objFactura.ImporteIVATransporte)
    '        strQuery = strQuery & ", " & gc_strDB_VAL_IMPORTE_RE_TRANS
    '        strQuery = strQuery & " = " & strComaPunto(objFactura.ImporteRETransporte)
    '        strQuery = strQuery & ", " & gc_strDB_NUM_DESC_GENERAL
    '        strQuery = strQuery & " = " & strComaPunto(objFactura.DescuentoGeneral)
    '        strQuery = strQuery & ", " & gc_strDB_VAL_IMPORTE_DESC_GNRL
    '        strQuery = strQuery & " = " & strComaPunto(objFactura.ImporteDescuentoGeneral)
    '        strQuery = strQuery & ", " & gc_strDB_NUM_DESC_ADICIONAL
    '        strQuery = strQuery & " = " & strComaPunto(objFactura.DescuentoProntoPago)
    '        strQuery = strQuery & ", " & gc_strDB_VAL_IMPORTE_DESC_ADIC
    '        strQuery = strQuery & " = " & strComaPunto(objFactura.ImporteDescuentoProntoPago)
    '        strQuery = strQuery & ", " & gc_strDB_NUM_CARGO_GENERAL
    '        strQuery = strQuery & " = " & strComaPunto(objFactura.CargoGeneral)
    '        strQuery = strQuery & ", " & gc_strDB_VAL_IMPORTE_CARG_GNRL
    '        strQuery = strQuery & " = " & strComaPunto(objFactura.ImporteCargoGeneral)
    '        strQuery = strQuery & ", " & gc_strDB_NUM_CARGO_EXEIVA
    '        strQuery = strQuery & " = " & strComaPunto(objFactura.CargoExeIVA)
    '        strQuery = strQuery & ", " & gc_strDB_VAL_IMPORTE_CARG_EXEIVA
    '        strQuery = strQuery & " = " & strComaPunto(objFactura.ImporteCargoExeIVA)
    '        strQuery = strQuery & ", " & gc_strDB_VAL_IMPORTE_TOTAL_IVA
    '        strQuery = strQuery & " = " & strComaPunto(objFactura.ImporteIVA)
    '        strQuery = strQuery & ", " & gc_strDB_VAL_IMPORTE_TOTAL_RE
    '        strQuery = strQuery & " = " & strComaPunto(objFactura.ImporteRE)
    '        strQuery = strQuery & ", " & gc_strDB_VAL_IMPORTE_FACTURA
    '        strQuery = strQuery & " = " & strComaPunto(objFactura.ImporteFactura)
    '        strQuery = strQuery & ", " & gc_strDB_COD_EXENTO_IVA
    '        strQuery = strQuery & " = " & objFactura.ExentoIVA
    '        strQuery = strQuery & ", " & gc_strDB_COD_EXENTO_RE
    '        strQuery = strQuery & " = " & objFactura.ExentoRE
    '        strQuery = strQuery & ", " & gc_strDB_COD_COMERCIAL
    '        strQuery = strQuery & " = " & objFactura.Comercial
    '        strQuery = strQuery & ", " & gc_strDB_COD_IVA_GENERAL
    '        strQuery = strQuery & " = " & objFactura.IdIVAGeneral
    '        strQuery = strQuery & ", " & gc_strDB_COD_IVA_REDUCIDO
    '        strQuery = strQuery & " = " & objFactura.IdIVAReducido
    '        strQuery = strQuery & ", " & gc_strDB_COD_IVA_SUPREDUCIDO
    '        strQuery = strQuery & " = " & objFactura.IdIVASReducido
    '        strQuery = strQuery & ", " & gc_strDB_COD_RE_GENERAL
    '        strQuery = strQuery & " = " & objFactura.IdREGeneral
    '        strQuery = strQuery & ", " & gc_strDB_COD_RE_REDUCIDO
    '        strQuery = strQuery & " = " & objFactura.IdREReducido
    '        strQuery = strQuery & ", " & gc_strDB_COD_RE_SUPREDUCIDO
    '        strQuery = strQuery & " = " & objFactura.IdRESReducido
    '        strQuery = strQuery & ", " & gc_strDB_COD_PUESTO
    '        strQuery = strQuery & " = " & objFactura.Puesto
    '        strQuery = strQuery & vbCrLf

    '        'WHERE
    '        strQuery = strQuery & "WHERE " & gc_strDB_ID_FACTURA & " = " & objFactura.Id

    'Terminar:

    '        If lngError <> 0 Then
    '            FacClie_strQueryEditarFactura = ""
    '        Else
    '            FacClie_strQueryEditarFactura = strQuery
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
    '    'Nombre...........: FacClie_strQueryEliminarFactura
    '    'Descripcion......: Obtiene la query para eliminar un Factura
    '    'Fecha............: 07/03/2012
    '    'Autor............: Borja Escudero
    '    'Parametros.......: lngIdFactura = Id del Factura que se debe eliminar
    '    'Retorno..........: Query para eliminar un pedido
    '    '<FIN CABECERA>-------------------------------------------
    '    Public Function FacClie_strQueryEliminarFactura(ByVal lngIdFactura As Long) As String

    '        Const strNombre_Funcion As String = "FacClie_strQueryEliminarFactura"
    '        Dim lngError As Long
    '        Dim strError As String

    '        Dim strQuery As String

    '        On Error GoTo TratarError

    '        'DELETE 
    '        strQuery = "DELETE *"
    '        strQuery = strQuery & vbCrLf

    '        'FROM
    '        strQuery = strQuery & "FROM " & gc_strDB_TABLA_FACTURAS_CLIENTES
    '        strQuery = strQuery & vbCrLf

    '        'WHERE
    '        strQuery = strQuery & "WHERE " & gc_strDB_ID_FACTURA & " = " & lngIdFactura

    'Terminar:

    '        If lngError <> 0 Then
    '            FacClie_strQueryEliminarFactura = ""
    '        Else
    '            FacClie_strQueryEliminarFactura = strQuery
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
    '    'Nombre...........: FacClie_strQueryObtenerControlFactura
    '    'Descripcion......: Obtiene la query para obtener el Id correspondiente al control de Factura
    '    'Fecha............: 31/01/2012
    '    'Autor............: Borja Escudero
    '    'Parametros.......: lngIdControl = Identificador del control de Factura
    '    'Retorno..........: Query para obtener el Id correspondiente al control
    '    '<FIN CABECERA>-------------------------------------------
    '    Public Function FacClie_strQueryObtenerControlFactura(Optional ByVal lngIdControl As Long = -1, _
    '                                                          Optional ByVal lngNumFactura As Long = -1, _
    '                                                          Optional ByVal blnAbajo As Boolean = False, _
    '                                                          Optional ByVal blnA As Boolean = True) As String

    '        Const strNombre_Funcion As String = "FacClie_strQueryObtenerControlFactura"
    '        Dim lngError As Long
    '        Dim strError As String

    '        Dim strQuery As String

    '        On Error GoTo TratarError

    '        'INSERT INTO
    '        strQuery = "SELECT " & gc_strDB_ID_CONTROL
    '        strQuery = strQuery & ", " & gc_strDB_NUM_FACTURA_CLIENTE & " AS " & strPonerCorchetes(gc_strLP_NUM_FACTURA_CLIENTE)
    '        strQuery = strQuery & vbCrLf

    '        'VALUES
    '        If blnA Then
    '            strQuery = strQuery & "FROM " & gc_strDB_TABLA_CONTROL_FACTURAS_CLIENTES_A
    '        Else
    '            strQuery = strQuery & "FROM " & gc_strDB_TABLA_CONTROL_FACTURAS_CLIENTES_B
    '        End If
    '        strQuery = strQuery & vbCrLf

    '        'WHERE
    '        If lngIdControl <> -1 Then
    '            strQuery = strQuery & "WHERE " & gc_strDB_ID_CONTROL
    '            strQuery = strQuery & " = " & lngIdControl
    '        Else
    '            If lngNumFactura <> -1 Then
    '                strQuery = strQuery & "WHERE " & gc_strDB_NUM_FACTURA_CLIENTE
    '                If blnAbajo Then
    '                    strQuery = strQuery & " < " & lngNumFactura
    '                Else
    '                    strQuery = strQuery & " > " & lngNumFactura
    '                End If
    '            End If
    '        End If

    'Terminar:

    '        If lngError <> 0 Then
    '            FacClie_strQueryObtenerControlFactura = ""
    '        Else
    '            FacClie_strQueryObtenerControlFactura = strQuery
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
    '    'Nombre...........: FacClie_strQueryAnadirControlFactura
    '    'Descripcion......: Obtiene la query para añadir una linea al control de Factura
    '    'Fecha............: 31/01/2012
    '    'Autor............: Borja Escudero
    '    'Parametros.......: lngNumFactura = Identificador del Factura
    '    'Retorno..........: Query para añadir una linea de control
    '    '<FIN CABECERA>-------------------------------------------
    '    Public Function FacClie_strQueryAnadirControlFactura(ByVal lngNumFactura As Long, ByVal blnA As Boolean) As String

    '        Const strNombre_Funcion As String = "FacClie_strQueryAnadirControlFactura"
    '        Dim lngError As Long
    '        Dim strError As String

    '        Dim strQuery As String

    '        On Error GoTo TratarError

    '        'INSERT INTO
    '        If blnA Then
    '            strQuery = "INSERT INTO " & gc_strDB_TABLA_CONTROL_FACTURAS_CLIENTES_A
    '        Else
    '            strQuery = "INSERT INTO " & gc_strDB_TABLA_CONTROL_FACTURAS_CLIENTES_B
    '        End If
    '        strQuery = strQuery & vbCrLf

    '        'VALUES
    '        strQuery = strQuery & "VALUES (" & lngNumFactura
    '        strQuery = strQuery & ", " & lngNumFactura
    '        strQuery = strQuery & ", " & gv_objAplicacion.Puesto & ")"

    'Terminar:

    '        If lngError <> 0 Then
    '            FacClie_strQueryAnadirControlFactura = ""
    '        Else
    '            FacClie_strQueryAnadirControlFactura = strQuery
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
    '    'Nombre...........: FacClie_strQueryModificarControlFactura
    '    'Descripcion......: Obtiene la query para modificar una linea al control de Factura
    '    'Fecha............: 31/01/2012
    '    'Autor............: Borja Escudero
    '    'Parametros.......: lngIdControl = Identificador del control
    '    '                   lngNumFactura = Nuevo numero de Factura
    '    'Retorno..........: Query para modificar una linea de control
    '    '<FIN CABECERA>-------------------------------------------
    '    Public Function FacClie_strQueryModificarControlFactura(ByVal lngIdControl As Long, ByVal lngNumFactura As Long, ByVal blnA As Boolean) As String

    '        Const strNombre_Funcion As String = "FacClie_strQueryModificarControlFactura"
    '        Dim lngError As Long
    '        Dim strError As String

    '        Dim strQuery As String

    '        On Error GoTo TratarError

    '        'UPDATE
    '        If blnA Then
    '            strQuery = "UPDATE " & gc_strDB_TABLA_CONTROL_FACTURAS_CLIENTES_A
    '        Else
    '            strQuery = "UPDATE " & gc_strDB_TABLA_CONTROL_FACTURAS_CLIENTES_B
    '        End If
    '        strQuery = strQuery & vbCrLf

    '        'SET
    '        strQuery = strQuery & "SET " & gc_strDB_NUM_FACTURA_CLIENTE
    '        strQuery = strQuery & " = " & lngNumFactura
    '        strQuery = strQuery & vbCrLf

    '        'WHERE
    '        strQuery = strQuery & "WHERE " & gc_strDB_ID_CONTROL
    '        strQuery = strQuery & " = " & lngIdControl

    'Terminar:

    '        If lngError <> 0 Then
    '            FacClie_strQueryModificarControlFactura = ""
    '        Else
    '            FacClie_strQueryModificarControlFactura = strQuery
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
    '    'Nombre...........: FacClie_strQueryEliminarControlFactura
    '    'Descripcion......: Obtiene la query para eliminar una linea al control de Factura
    '    'Fecha............: 01/02/2012
    '    'Autor............: Borja Escudero
    '    'Parametros.......: lngIdControl = Identificador del control
    '    'Retorno..........: Query para eliminar una linea de control
    '    '<FIN CABECERA>-------------------------------------------
    '    Public Function FacClie_strQueryEliminarControlFactura(ByVal lngIdControl As Long, ByVal blnA As Boolean, Optional ByVal blnPorPuesto As Boolean = False) As String

    '        Const strNombre_Funcion As String = "FacClie_strQueryEliminarControlFactura"
    '        Dim lngError As Long
    '        Dim strError As String

    '        Dim strQuery As String

    '        On Error GoTo TratarError

    '        'DELETE 
    '        strQuery = "DELETE *"
    '        strQuery = strQuery & vbCrLf

    '        'FROM
    '        If blnA Then
    '            strQuery = strQuery & "FROM " & gc_strDB_TABLA_CONTROL_FACTURAS_CLIENTES_A
    '        Else
    '            strQuery = strQuery & "FROM " & gc_strDB_TABLA_CONTROL_FACTURAS_CLIENTES_B
    '        End If
    '        strQuery = strQuery & vbCrLf

    '        'WHERE
    '        If blnPorPuesto Then
    '            strQuery = strQuery & "WHERE " & gc_strDB_COD_PUESTO
    '            strQuery = strQuery & " = " & gv_objAplicacion.Puesto
    '        Else
    '            strQuery = strQuery & "WHERE " & gc_strDB_ID_CONTROL
    '            strQuery = strQuery & " = " & lngIdControl
    '        End If

    'Terminar:

    '        If lngError <> 0 Then
    '            FacClie_strQueryEliminarControlFactura = ""
    '        Else
    '            FacClie_strQueryEliminarControlFactura = strQuery
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
    '    'Nombre...........: FacClie_strQueryObtenerLineasFactura
    '    'Descripcion......: Obtiene la query para obtener las lineas de un pedido de la base de datos
    '    'Fecha............: 08/03/2012
    '    'Autor............: Borja Escudero
    '    'Parametros.......: lngIdPedido = Identificador del pedido que se quiere consultar
    '    'Retorno..........: Query para obtener los presupuestos
    '    '<FIN CABECERA>-------------------------------------------
    '    Public Function FacClie_strQueryObtenerLineasFactura(ByVal lngIdFactura As Long) As String

    '        Const strNombre_Funcion As String = "FacClie_strQueryObtenerLineasFactura"
    '        Dim lngError As Long
    '        Dim strError As String

    '        Dim strQuery As String

    '        On Error GoTo TratarError

    '        'SELECT
    '        strQuery = "SELECT " & gc_strDB_TABLA_LINEAS_FACTURAS_CLIENTES & "." & gc_strDB_COD_FACTURA
    '        strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_COD_FACTURA)
    '        strQuery = strQuery & ", " & gc_strDB_TABLA_LINEAS_FACTURAS_CLIENTES & "." & gc_strDB_NUM_LINEA
    '        strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_NUM_LINEA)
    '        strQuery = strQuery & ", " & gc_strDB_TABLA_LINEAS_FACTURAS_CLIENTES & "." & gc_strDB_COD_ARTICULO
    '        strQuery = strQuery & ", " & gc_strDB_TABLA_CATALOGO_ARTICULOS & "." & gc_strDB_DES_REFERENCIA_PROVEEDOR
    '        strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_DES_REFERENCIA_PROVEEDOR)
    '        strQuery = strQuery & ", " & gc_strDB_TABLA_LINEAS_FACTURAS_CLIENTES & "." & gc_strDB_DES_ARTICULO
    '        strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_DES_ARTICULO)
    '        strQuery = strQuery & ", " & gc_strDB_TABLA_LINEAS_FACTURAS_CLIENTES & "." & gc_strDB_NUM_TARIFA
    '        strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_NUM_TARIFA)
    '        strQuery = strQuery & ", " & gc_strDB_TABLA_LINEAS_FACTURAS_CLIENTES & "." & gc_strDB_VAL_IMPORTE
    '        strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_VAL_IMPORTE)
    '        strQuery = strQuery & ", " & gc_strDB_TABLA_LINEAS_FACTURAS_CLIENTES & "." & gc_strDB_NUM_CANTIDAD
    '        strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_NUM_CANTIDAD)
    '        strQuery = strQuery & ", " & gc_strDB_TABLA_LINEAS_FACTURAS_CLIENTES & "." & gc_strDB_COD_TIPO_IVA
    '        strQuery = strQuery & ", " & gc_strDB_TABLA_TIPOS_IVA & "." & gc_strDB_DES_TIPO_IVA
    '        strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_DES_TIPO_IVA)
    '        strQuery = strQuery & ", " & gc_strDB_TABLA_LINEAS_FACTURAS_CLIENTES & "." & gc_strDB_COD_IVA
    '        strQuery = strQuery & ", " & gc_strDB_TABLA_IVAS & "." & gc_strDB_NUM_IVA
    '        strQuery = strQuery & ", " & gc_strDB_TABLA_IVAS & "." & gc_strDB_DES_IVA
    '        strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_DES_IVA)
    '        strQuery = strQuery & ", " & gc_strDB_TABLA_LINEAS_FACTURAS_CLIENTES & "." & gc_strDB_COD_RE
    '        strQuery = strQuery & ", " & gc_strDB_TABLA_RES & "." & gc_strDB_NUM_RE
    '        strQuery = strQuery & ", " & gc_strDB_TABLA_RES & "." & gc_strDB_DES_RE
    '        strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_DES_RE)
    '        strQuery = strQuery & ", " & gc_strDB_TABLA_LINEAS_FACTURAS_CLIENTES & "." & gc_strDB_NUM_DESCUENTO
    '        strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_NUM_DESCUENTO)
    '        strQuery = strQuery & ", " & gc_strDB_TABLA_LINEAS_FACTURAS_CLIENTES & "." & gc_strDB_VAL_IMPORTE_TOTAL
    '        strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_VAL_IMPORTE_TOTAL)
    '        strQuery = strQuery & ", " & gc_strDB_TABLA_LINEAS_FACTURAS_CLIENTES & "." & gc_strDB_VAL_IMPORTE_DESCUENTO
    '        strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_VAL_IMPORTE_DESCUENTO)
    '        strQuery = strQuery & ", " & gc_strDB_TABLA_LINEAS_FACTURAS_CLIENTES & "." & gc_strDB_VAL_IMPORTE_IVA
    '        strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_VAL_IMPORTE_IVA)
    '        strQuery = strQuery & ", " & gc_strDB_TABLA_LINEAS_FACTURAS_CLIENTES & "." & gc_strDB_VAL_IMPORTE_RE
    '        strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_VAL_IMPORTE_RE)
    '        strQuery = strQuery & ", " & gc_strDB_TABLA_LINEAS_FACTURAS_CLIENTES & "." & gc_strDB_VAL_IMPORTE_FINAL
    '        strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_VAL_IMPORTE_FINAL)
    '        strQuery = strQuery & vbCrLf

    '        'FROM
    '        strQuery = strQuery & "FROM " & gc_strDB_TABLA_CATALOGO_ARTICULOS & " RIGHT JOIN ("
    '        strQuery = strQuery & gc_strDB_TABLA_RES & " RIGHT JOIN ("
    '        strQuery = strQuery & gc_strDB_TABLA_IVAS & " RIGHT JOIN ("
    '        strQuery = strQuery & gc_strDB_TABLA_TIPOS_IVA & " RIGHT JOIN ("
    '        strQuery = strQuery & gc_strDB_TABLA_FACTURAS_CLIENTES & " RIGHT JOIN " & gc_strDB_TABLA_LINEAS_FACTURAS_CLIENTES
    '        strQuery = strQuery & " ON " & gc_strDB_TABLA_FACTURAS_CLIENTES & "." & gc_strDB_ID_FACTURA
    '        strQuery = strQuery & " = " & gc_strDB_TABLA_LINEAS_FACTURAS_CLIENTES & "." & gc_strDB_COD_FACTURA & ")"
    '        strQuery = strQuery & " ON " & gc_strDB_TABLA_TIPOS_IVA & "." & gc_strDB_ID_TIPO_IVA
    '        strQuery = strQuery & " = " & gc_strDB_TABLA_LINEAS_FACTURAS_CLIENTES & "." & gc_strDB_COD_TIPO_IVA & ")"
    '        strQuery = strQuery & " ON " & gc_strDB_TABLA_IVAS & "." & gc_strDB_ID_IVA
    '        strQuery = strQuery & " = " & gc_strDB_TABLA_LINEAS_FACTURAS_CLIENTES & "." & gc_strDB_COD_IVA & ")"
    '        strQuery = strQuery & " ON " & gc_strDB_TABLA_RES & "." & gc_strDB_ID_RE
    '        strQuery = strQuery & " = " & gc_strDB_TABLA_LINEAS_FACTURAS_CLIENTES & "." & gc_strDB_COD_RE & ")"
    '        strQuery = strQuery & " ON " & gc_strDB_TABLA_CATALOGO_ARTICULOS & "." & gc_strDB_ID_ARTICULO
    '        strQuery = strQuery & " = " & gc_strDB_TABLA_LINEAS_FACTURAS_CLIENTES & "." & gc_strDB_COD_ARTICULO
    '        strQuery = strQuery & vbCrLf

    '        'WHERE
    '        strQuery = strQuery & "WHERE " & gc_strDB_TABLA_LINEAS_FACTURAS_CLIENTES & "." & gc_strDB_COD_FACTURA & " = " & lngIdFactura
    '        strQuery = strQuery & vbCrLf

    '        'ORDER BY
    '        strQuery = strQuery & "ORDER BY " & gc_strDB_TABLA_LINEAS_FACTURAS_CLIENTES & "." & gc_strDB_NUM_LINEA

    'Terminar:

    '        If lngError <> 0 Then
    '            FacClie_strQueryObtenerLineasFactura = ""
    '        Else
    '            FacClie_strQueryObtenerLineasFactura = strQuery
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
    '    'Nombre...........: FacClie_strQueryAnadirLineaFactura
    '    'Descripcion......: Obtiene la query para añadir una nueva linea de Factura
    '    'Fecha............: 31/05/2012
    '    'Autor............: Borja Escudero
    '    'Parametros.......: objRow = Linea a añadir
    '    'Retorno..........: Query para añadir una nueva linea de Factura
    '    '<FIN CABECERA>-------------------------------------------
    '    Public Function FacClie_strQueryAnadirLineaFactura(ByVal objRow As DataRow, ByVal lngNumLinea As Long, ByVal lngIdFactura As Long) As String

    '        Const strNombre_Funcion As String = "FacClie_strQueryAnadirLineaFactura"
    '        Dim lngError As Long
    '        Dim strError As String

    '        Dim strQuery As String

    '        On Error GoTo TratarError

    '        'SELECT
    '        strQuery = "INSERT INTO " & gc_strDB_TABLA_LINEAS_FACTURAS_CLIENTES
    '        strQuery = strQuery & "(" & gc_strDB_COD_FACTURA
    '        strQuery = strQuery & ", " & gc_strDB_NUM_LINEA
    '        strQuery = strQuery & ", " & gc_strDB_COD_ARTICULO
    '        strQuery = strQuery & ", " & gc_strDB_DES_ARTICULO
    '        strQuery = strQuery & ", " & gc_strDB_NUM_TARIFA
    '        strQuery = strQuery & ", " & gc_strDB_VAL_IMPORTE
    '        strQuery = strQuery & ", " & gc_strDB_NUM_CANTIDAD
    '        strQuery = strQuery & ", " & gc_strDB_NUM_DESCUENTO
    '        strQuery = strQuery & ", " & gc_strDB_VAL_IMPORTE_DESCUENTO
    '        strQuery = strQuery & ", " & gc_strDB_COD_TIPO_IVA
    '        strQuery = strQuery & ", " & gc_strDB_COD_IVA
    '        strQuery = strQuery & ", " & gc_strDB_COD_RE
    '        strQuery = strQuery & ", " & gc_strDB_VAL_IMPORTE_TOTAL
    '        strQuery = strQuery & ", " & gc_strDB_VAL_IMPORTE_IVA
    '        strQuery = strQuery & ", " & gc_strDB_VAL_IMPORTE_RE
    '        strQuery = strQuery & ", " & gc_strDB_VAL_IMPORTE_FINAL
    '        strQuery = strQuery & ")"
    '        strQuery = strQuery & vbCrLf

    '        'VALUES
    '        strQuery = strQuery & "VALUES (" & lngIdFactura
    '        strQuery = strQuery & ", " & lngNumLinea
    '        If IsDBNull(objRow(gc_strDB_COD_ARTICULO).ToString) Then
    '            strQuery = strQuery & ", 0"
    '        Else
    '            If objRow(gc_strDB_COD_ARTICULO).ToString <> "" Then
    '                strQuery = strQuery & ", " & objRow(gc_strDB_COD_ARTICULO).ToString
    '            Else
    '                strQuery = strQuery & ", 0"
    '            End If
    '        End If
    '        strQuery = strQuery & ", '" & objRow(gc_strLP_DES_ARTICULO).ToString & "'"
    '        If IsDBNull(objRow(gc_strLP_NUM_TARIFA).ToString) Then
    '            strQuery = strQuery & ", 0"
    '        Else
    '            If objRow(gc_strLP_NUM_TARIFA).ToString <> "" Then
    '                strQuery = strQuery & ", " & objRow(gc_strLP_NUM_TARIFA).ToString
    '            Else
    '                strQuery = strQuery & ", 0"
    '            End If
    '        End If
    '        If IsDBNull(objRow(gc_strLP_VAL_IMPORTE).ToString) Then
    '            strQuery = strQuery & ", 0"
    '        Else
    '            If objRow(gc_strLP_VAL_IMPORTE).ToString <> "" Then
    '                strQuery = strQuery & ", " & strComaPunto(objRow(gc_strLP_VAL_IMPORTE).ToString)
    '            Else
    '                strQuery = strQuery & ", 0"
    '            End If
    '        End If
    '        If IsDBNull(objRow(gc_strLP_NUM_CANTIDAD).ToString) Then
    '            strQuery = strQuery & ", 0"
    '        Else
    '            If objRow(gc_strLP_NUM_CANTIDAD).ToString <> "" Then
    '                strQuery = strQuery & ", " & strComaPunto(objRow(gc_strLP_NUM_CANTIDAD).ToString)
    '            Else
    '                strQuery = strQuery & ", 0"
    '            End If
    '        End If
    '        If IsDBNull(objRow(gc_strLP_NUM_DESCUENTO).ToString) Then
    '            strQuery = strQuery & ", 0"
    '        Else
    '            If objRow(gc_strLP_NUM_DESCUENTO).ToString <> "" Then
    '                strQuery = strQuery & ", " & strComaPunto(objRow(gc_strLP_NUM_DESCUENTO).ToString)
    '            Else
    '                strQuery = strQuery & ", 0"
    '            End If
    '        End If
    '        If IsDBNull(objRow(gc_strLP_VAL_IMPORTE_DESCUENTO).ToString) Then
    '            strQuery = strQuery & ", 0"
    '        Else
    '            If objRow(gc_strLP_VAL_IMPORTE_DESCUENTO).ToString <> "" Then
    '                strQuery = strQuery & ", " & strComaPunto(objRow(gc_strLP_VAL_IMPORTE_DESCUENTO).ToString)
    '            Else
    '                strQuery = strQuery & ", 0"
    '            End If
    '        End If
    '        If IsDBNull(objRow(gc_strDB_COD_TIPO_IVA).ToString) Then
    '            strQuery = strQuery & ", 0"
    '        Else
    '            If objRow(gc_strDB_COD_TIPO_IVA).ToString <> "" Then
    '                strQuery = strQuery & ", " & objRow(gc_strDB_COD_TIPO_IVA).ToString
    '            Else
    '                strQuery = strQuery & ", 0"
    '            End If
    '        End If
    '        If IsDBNull(objRow(gc_strDB_COD_IVA).ToString) Then
    '            strQuery = strQuery & ", 0"
    '        Else
    '            If objRow(gc_strDB_COD_IVA).ToString <> "" Then
    '                strQuery = strQuery & ", " & objRow(gc_strDB_COD_IVA).ToString
    '            Else
    '                strQuery = strQuery & ", 0"
    '            End If
    '        End If
    '        If IsDBNull(objRow(gc_strDB_COD_RE).ToString) Then
    '            strQuery = strQuery & ", 0"
    '        Else
    '            If objRow(gc_strDB_COD_RE).ToString <> "" Then
    '                strQuery = strQuery & ", " & objRow(gc_strDB_COD_RE).ToString
    '            Else
    '                strQuery = strQuery & ", 0"
    '            End If
    '        End If
    '        If IsDBNull(objRow(gc_strLP_VAL_IMPORTE_TOTAL).ToString) Then
    '            strQuery = strQuery & ", 0"
    '        Else
    '            If objRow(gc_strLP_VAL_IMPORTE_TOTAL).ToString <> "" Then
    '                strQuery = strQuery & ", " & strComaPunto(objRow(gc_strLP_VAL_IMPORTE_TOTAL).ToString)
    '            Else
    '                strQuery = strQuery & ", 0"
    '            End If
    '        End If
    '        If IsDBNull(objRow(gc_strLP_VAL_IMPORTE_IVA).ToString) Then
    '            strQuery = strQuery & ", 0"
    '        Else
    '            If objRow(gc_strLP_VAL_IMPORTE_IVA).ToString <> "" Then
    '                strQuery = strQuery & ", " & strComaPunto(objRow(gc_strLP_VAL_IMPORTE_IVA).ToString)
    '            Else
    '                strQuery = strQuery & ", 0"
    '            End If
    '        End If
    '        If IsDBNull(objRow(gc_strLP_VAL_IMPORTE_RE).ToString) Then
    '            strQuery = strQuery & ", 0"
    '        Else
    '            If objRow(gc_strLP_VAL_IMPORTE_RE).ToString <> "" Then
    '                strQuery = strQuery & ", " & strComaPunto(objRow(gc_strLP_VAL_IMPORTE_RE).ToString)
    '            Else
    '                strQuery = strQuery & ", 0"
    '            End If
    '        End If
    '        If IsDBNull(objRow(gc_strLP_VAL_IMPORTE_FINAL).ToString) Then
    '            strQuery = strQuery & ", 0"
    '        Else
    '            If objRow(gc_strLP_VAL_IMPORTE_FINAL).ToString <> "" Then
    '                strQuery = strQuery & ", " & strComaPunto(objRow(gc_strLP_VAL_IMPORTE_FINAL).ToString)
    '            Else
    '                strQuery = strQuery & ", 0"
    '            End If
    '        End If
    '        strQuery = strQuery & ") "

    'Terminar:

    '        If lngError <> 0 Then
    '            FacClie_strQueryAnadirLineaFactura = ""
    '        Else
    '            FacClie_strQueryAnadirLineaFactura = strQuery
    '        End If

    '        'Anulamos el control de errores
    '        On Error GoTo 0
    '        Exit Function

    'TratarError:

    '        'Guardamos el error
    '        lngError = Err.Number
    '        strError = Err.Description

    '        AddLog(lngError & " - " & strError, mc_strNombre_Modulo, strNombre_Funcion)

    '        Resume Next
    '    End Function

    '    '<CABECERA>-----------------------------------------------
    '    'Nombre...........: FacClie_strQueryEliminarLineasFactura
    '    'Descripcion......: Obtiene la query para eliminar las lineas del Factura
    '    'Fecha............: 31/05/2012
    '    'Autor............: Borja Escudero
    '    'Parametros.......: lngIdFactura = Identificador del Factura
    '    'Retorno..........: Query para eliminar las lineas del Factura
    '    '<FIN CABECERA>-------------------------------------------
    '    Public Function FacClie_strQueryEliminarLineasFactura(ByVal lngIdFactura As Long) As String

    '        Const strNombre_Funcion As String = "FacClie_strQueryEliminarLineasFactura"
    '        Dim lngError As Long
    '        Dim strError As String

    '        Dim strQuery As String

    '        On Error GoTo TratarError

    '        'DELETE 
    '        strQuery = "DELETE *"
    '        strQuery = strQuery & vbCrLf

    '        'FROM
    '        strQuery = strQuery & "FROM " & gc_strDB_TABLA_LINEAS_FACTURAS_CLIENTES
    '        strQuery = strQuery & vbCrLf

    '        'WHERE
    '        strQuery = strQuery & "WHERE " & gc_strDB_COD_FACTURA
    '        strQuery = strQuery & " = " & lngIdFactura

    'Terminar:

    '        If lngError <> 0 Then
    '            FacClie_strQueryEliminarLineasFactura = ""
    '        Else
    '            FacClie_strQueryEliminarLineasFactura = strQuery
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
    '    'Nombre...........: FacClie_strQueryBloqDesbloqFactura
    '    'Descripcion......: Obtiene la query para bloquear un Factura
    '    'Fecha............: 12/03/2012
    '    'Autor............: Borja Escudero
    '    'Parametros.......: lngIdFactura = Id del Factura
    '    '                   blnBloquear = Variable que determina si se bloquea o desbloquea el Factura
    '    'Retorno..........: Query para bloquear el Factura
    '    '<FIN CABECERA>-------------------------------------------
    '    Public Function FacClie_strQueryBloqDesbloqFactura(ByRef lngIdFactura As Long, ByVal blnBloquear As Boolean, Optional ByVal blnTodos As Boolean = False) As String

    '        Const strNombre_Funcion As String = "FacClie_strQueryBloqDesbloqFactura"
    '        Dim lngError As Long
    '        Dim strError As String

    '        Dim strQuery As String

    '        On Error GoTo TratarError

    '        'UPDATE
    '        strQuery = "UPDATE " & gc_strDB_TABLA_FACTURAS_CLIENTES
    '        strQuery = strQuery & vbCrLf

    '        'SET
    '        strQuery = strQuery & "SET " & gc_strDB_COD_PUESTO
    '        If blnBloquear Then
    '            strQuery = strQuery & " = " & gv_objAplicacion.Puesto
    '        Else
    '            strQuery = strQuery & " = 0"
    '        End If
    '        strQuery = strQuery & vbCrLf

    '        'WHERE
    '        If blnTodos Then
    '            strQuery = strQuery & "WHERE " & gc_strDB_COD_PUESTO & " = " & gv_objAplicacion.Puesto
    '        Else
    '            strQuery = strQuery & "WHERE " & gc_strDB_ID_FACTURA & " = " & lngIdFactura
    '        End If

    'Terminar:

    '        If lngError <> 0 Then
    '            FacClie_strQueryBloqDesbloqFactura = ""
    '        Else
    '            FacClie_strQueryBloqDesbloqFactura = strQuery
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
    '    'Nombre...........: FacClie_strQueryObtenerCobros
    '    'Descripcion......: Obtiene los cobros de la factura
    '    'Fecha............: 12/03/2012
    '    'Autor............: Borja Escudero
    '    'Parametros.......: lngIdFactura = Id del Factura
    '    'Retorno..........: Query para obtener los cobros de la  factura
    '    '<FIN CABECERA>-------------------------------------------
    '    Public Function FacClie_strQueryObtenerCobros(Optional ByRef lngIdFactura As Long = -1, Optional ByVal lngNumCobro As Long = -1) As String

    '        Const strNombre_Funcion As String = "FacClie_strQueryObtenerCobros"
    '        Dim lngError As Long
    '        Dim strError As String

    '        Dim strQuery As String

    '        On Error GoTo TratarError

    '        'SELECT
    '        strQuery = "SELECT " & gc_strDB_TABLA_COBROS_CLIENTES & "." & gc_strDB_COD_FACTURA
    '        strQuery = strQuery & ", " & gc_strDB_TABLA_COBROS_CLIENTES & "." & gc_strDB_NUM_COBRO
    '        strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_NUM_COBRO)
    '        strQuery = strQuery & ", " & gc_strDB_TABLA_CLIENTES & "." & gc_strDB_DES_NOMBRE
    '        strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_COD_CLIENTE)
    '        strQuery = strQuery & ", " & gc_strDB_TABLA_COBROS_CLIENTES & "." & gc_strDB_VAL_IMPORTE
    '        strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_VAL_IMPORTE)
    '        strQuery = strQuery & ", " & gc_strDB_TABLA_COBROS_CLIENTES & "." & gc_strDB_FCH_COBRO
    '        strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_FCH_COBRO)
    '        strQuery = strQuery & ", " & gc_strDB_TABLA_COBROS_CLIENTES & "." & gc_strDB_COD_COBRADO
    '        strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_COD_COBRADO)
    '        strQuery = strQuery & ", " & gc_strDB_TABLA_COBROS_CLIENTES & "." & gc_strDB_DES_REMESA
    '        strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_DES_REMESA)
    '        strQuery = strQuery & ", " & gc_strDB_TABLA_COBROS_CLIENTES & "." & gc_strDB_FCH_REMESA
    '        strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_FCH_REMESA)
    '        strQuery = strQuery & ", " & gc_strDB_TABLA_COBROS_CLIENTES & "." & gc_strDB_COD_CUENTA_CLIENTE
    '        strQuery = strQuery & ", " & gc_strDB_TABLA_CUENTAS_BANCARIAS & "." & gc_strDB_DES_DESCRIPCION
    '        strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_COD_CUENTA_CLIENTE)
    '        strQuery = strQuery & ", " & gc_strDB_TABLA_CUENTAS_BANCARIAS & "." & gc_strDB_DES_NOMBRE
    '        strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_COD_ENTIDAD)
    '        strQuery = strQuery & vbCrLf

    '        'FROM
    '        strQuery = strQuery & "FROM " & gc_strDB_TABLA_CUENTAS_BANCARIAS & " RIGHT JOIN ("
    '        strQuery = strQuery & gc_strDB_TABLA_CLIENTES & " RIGHT JOIN ("
    '        strQuery = strQuery & gc_strDB_TABLA_FACTURAS_CLIENTES & " RIGHT JOIN " & gc_strDB_TABLA_COBROS_CLIENTES
    '        strQuery = strQuery & " ON " & gc_strDB_TABLA_COBROS_CLIENTES & "." & gc_strDB_COD_FACTURA
    '        strQuery = strQuery & " = " & gc_strDB_TABLA_FACTURAS_CLIENTES & "." & gc_strDB_ID_FACTURA & ")"
    '        strQuery = strQuery & " ON " & gc_strDB_TABLA_CLIENTES & "." & gc_strDB_ID_CLIENTE
    '        strQuery = strQuery & " = " & gc_strDB_TABLA_FACTURAS_CLIENTES & "." & gc_strDB_COD_CLIENTE & ")"
    '        strQuery = strQuery & " ON " & gc_strDB_TABLA_CUENTAS_BANCARIAS & "." & gc_strDB_ID_CUENTA
    '        strQuery = strQuery & " = " & gc_strDB_TABLA_COBROS_CLIENTES & "." & gc_strDB_COD_CUENTA_CLIENTE
    '        strQuery = strQuery & vbCrLf

    '        'WHERE
    '        If lngIdFactura <> -1 Then
    '            strQuery = strQuery & "WHERE " & gc_strDB_TABLA_COBROS_CLIENTES & "." & gc_strDB_COD_FACTURA & " = " & lngIdFactura
    '            If lngNumCobro <> -1 Then
    '                strQuery = strQuery & " AND " & gc_strDB_TABLA_COBROS_CLIENTES & "." & gc_strDB_NUM_COBRO & " = " & lngNumCobro
    '            End If
    '            strQuery = strQuery & vbCrLf
    '        End If

    '        'ORDER BY
    '        strQuery = strQuery & "ORDER BY " & gc_strDB_TABLA_COBROS_CLIENTES & "." & gc_strDB_FCH_COBRO & " ASC"

    'Terminar:

    '        If lngError <> 0 Then
    '            FacClie_strQueryObtenerCobros = ""
    '        Else
    '            FacClie_strQueryObtenerCobros = strQuery
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
    '    'Nombre...........: FacClie_strQueryAnadirRecibo
    '    'Descripcion......: Obtiene los recibos de la factura
    '    'Fecha............: 12/03/2012
    '    'Autor............: Borja Escudero
    '    'Parametros.......: lngIdFactura = Id del Factura
    '    'Retorno..........: Query para obtener los recibos de la  factura
    '    '<FIN CABECERA>-------------------------------------------
    '    Public Function FacClie_strQueryAnadirCobro(ByRef objCobro As clsCobro) As String

    '        Const strNombre_Funcion As String = "FacClie_strQueryAnadirRecibo"
    '        Dim lngError As Long
    '        Dim strError As String

    '        Dim strQuery As String
    '        Dim objDate As Date

    '        On Error GoTo TratarError

    '        'INSERT INTO
    '        strQuery = "INSERT INTO " & gc_strDB_TABLA_COBROS_CLIENTES
    '        strQuery = strQuery & " (" & gc_strDB_COD_FACTURA
    '        strQuery = strQuery & ", " & gc_strDB_NUM_COBRO
    '        strQuery = strQuery & ", " & gc_strDB_COD_CUENTA_CLIENTE
    '        strQuery = strQuery & ", " & gc_strDB_DES_REMESA
    '        strQuery = strQuery & ", " & gc_strDB_FCH_REMESA
    '        strQuery = strQuery & ", " & gc_strDB_FCH_COBRO
    '        strQuery = strQuery & ", " & gc_strDB_VAL_IMPORTE
    '        strQuery = strQuery & ", " & gc_strDB_COD_COBRADO
    '        strQuery = strQuery & ")"
    '        strQuery = strQuery & vbCrLf

    '        'VALUES
    '        strQuery = strQuery & "VALUES " & "("
    '        strQuery = strQuery & objCobro.Factura
    '        strQuery = strQuery & ", " & objCobro.Id
    '        strQuery = strQuery & ", " & objCobro.CuentaCliente
    '        strQuery = strQuery & ", '" & objCobro.Remesa & "'"
    '        If objCobro.FechaRemesa <> "" Then
    '            objDate = Date.Parse(objCobro.FechaRemesa)
    '            strQuery = strQuery & ", #" & Format(objDate.Date, "MM/dd/yyyy") & "#"
    '        Else
    '            strQuery = strQuery & ", null"
    '        End If
    '        objDate = Date.Parse(objCobro.FechaCobro)
    '        strQuery = strQuery & ", #" & Format(objDate.Date, "MM/dd/yyyy") & "#"
    '        strQuery = strQuery & ", " & strComaPunto(objCobro.Importe)
    '        strQuery = strQuery & ", " & objCobro.Cobrado
    '        strQuery = strQuery & ")"
    '        strQuery = strQuery & vbCrLf

    'Terminar:

    '        If lngError <> 0 Then
    '            FacClie_strQueryAnadirCobro = ""
    '        Else
    '            FacClie_strQueryAnadirCobro = strQuery
    '        End If

    '        'Anulamos el control de errores
    '        On Error GoTo 0
    '        Exit Function

    'TratarError:

    '        'Guardamos el error
    '        lngError = Err.Number
    '        strError = Err.Description

    '        AddLog(lngError & " - " & strError, mc_strNombre_Modulo, strNombre_Funcion)

    '        Resume Next
    '    End Function

    '    '<CABECERA>-----------------------------------------------
    '    'Nombre...........: FacClie_strQueryEditarCobro
    '    'Descripcion......: Devuelve la query para editar un cobro
    '    'Fecha............: 12/03/2012
    '    'Autor............: Borja Escudero
    '    'Parametros.......: lngIdFactura = Id del Factura
    '    'Retorno..........: Query para obtener los recibos de la  factura
    '    '<FIN CABECERA>-------------------------------------------
    '    Public Function FacClie_strQueryEditarCobro(ByRef objCobro As clsCobro) As String

    '        Const strNombre_Funcion As String = "FacClie_strQueryEditarCobro"
    '        Dim lngError As Long
    '        Dim strError As String

    '        Dim strQuery As String
    '        Dim objDate As Date

    '        On Error GoTo TratarError

    '        'INSERT INTO
    '        strQuery = "UPDATE " & gc_strDB_TABLA_COBROS_CLIENTES
    '        strQuery = strQuery & vbCrLf

    '        'SET
    '        strQuery = strQuery & "SET " & gc_strDB_COD_FACTURA
    '        strQuery = strQuery & " = " & objCobro.Factura
    '        strQuery = strQuery & ", " & gc_strDB_COD_CUENTA_CLIENTE
    '        strQuery = strQuery & " = " & objCobro.CuentaCliente
    '        strQuery = strQuery & ", " & gc_strDB_DES_REMESA
    '        strQuery = strQuery & " = '" & objCobro.Remesa & "'"
    '        strQuery = strQuery & ", " & gc_strDB_FCH_REMESA
    '        If objCobro.FechaRemesa <> "" Then
    '            objDate = Date.Parse(objCobro.FechaRemesa)
    '            strQuery = strQuery & " = #" & Format(objDate.Date, "MM/dd/yyyy") & "#"
    '        Else
    '            strQuery = strQuery & " = null"
    '        End If
    '        strQuery = strQuery & ", " & gc_strDB_FCH_COBRO
    '        objDate = Date.Parse(objCobro.FechaCobro)
    '        strQuery = strQuery & " = #" & Format(objDate.Date, "MM/dd/yyyy") & "#"
    '        strQuery = strQuery & ", " & gc_strDB_VAL_IMPORTE
    '        strQuery = strQuery & " = " & strComaPunto(objCobro.Importe)
    '        strQuery = strQuery & ", " & gc_strDB_COD_COBRADO
    '        strQuery = strQuery & " = " & objCobro.Cobrado
    '        strQuery = strQuery & vbCrLf

    '        'WHERE
    '        strQuery = strQuery & "WHERE " & gc_strDB_NUM_COBRO & " = " & objCobro.Id

    'Terminar:

    '        If lngError <> 0 Then
    '            FacClie_strQueryEditarCobro = ""
    '        Else
    '            FacClie_strQueryEditarCobro = strQuery
    '        End If

    '        'Anulamos el control de errores
    '        On Error GoTo 0
    '        Exit Function

    'TratarError:

    '        'Guardamos el error
    '        lngError = Err.Number
    '        strError = Err.Description

    '        AddLog(lngError & " - " & strError, mc_strNombre_Modulo, strNombre_Funcion)

    '        Resume Next
    '    End Function

    '    '<CABECERA>-----------------------------------------------
    '    'Nombre...........: FacClie_strQueryEliminarRecibos
    '    'Descripcion......: Obtiene la query para eliminar los recibos de una factura
    '    'Fecha............: 31/05/2012
    '    'Autor............: Borja Escudero
    '    'Parametros.......: lngIdFactura = Identificador del Factura
    '    'Retorno..........: Query para eliminar los recibos de una Factura
    '    '<FIN CABECERA>-------------------------------------------
    '    Public Function FacClie_strQueryEliminarCobros(ByVal lngIdCobro As Long, Optional ByVal lngIdFactura As Long = -1) As String

    '        Const strNombre_Funcion As String = "FacClie_strQueryEliminarCobros"
    '        Dim lngError As Long
    '        Dim strError As String

    '        Dim strQuery As String

    '        On Error GoTo TratarError

    '        'DELETE 
    '        strQuery = "DELETE *"
    '        strQuery = strQuery & vbCrLf

    '        'FROM
    '        strQuery = strQuery & "FROM " & gc_strDB_TABLA_COBROS_CLIENTES
    '        strQuery = strQuery & vbCrLf

    '        'WHERE
    '        If lngIdFactura <> -1 Then
    '            strQuery = strQuery & "WHERE " & gc_strDB_COD_FACTURA
    '            strQuery = strQuery & " = " & lngIdFactura
    '        Else
    '            strQuery = strQuery & "WHERE " & gc_strDB_NUM_COBRO
    '            strQuery = strQuery & " = " & lngIdCobro
    '        End If

    'Terminar:

    '        If lngError <> 0 Then
    '            FacClie_strQueryEliminarCobros = ""
    '        Else
    '            FacClie_strQueryEliminarCobros = strQuery
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
End Module
