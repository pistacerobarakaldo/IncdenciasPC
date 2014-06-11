Option Explicit On
Option Compare Text

Imports tsbRports

Public Enum AperturaFormulario
    Nuevo
    Editar
End Enum

Public Enum udtTipoDeCarga
    CargarAjustar
    SoloCargar
    SoloAjustar
End Enum

Module modAplicacion
    'Constante que guarda el nombre del mudulo
    Const mc_strNombre_Modulo As String = "modAplicacion"

    'Constante que contiene el codigo ASCII del caracter coma (,)
    Private Const gc_intComa As Integer = 44

    'Constante que contiene el codigo ASCII del caracter punto (.)
    Private Const gc_intPunto As Integer = 46

    'Constante que determina de que base de datos se obtendran los datos de los clientes
    '   True = Los tados se obtendran de la base de datos de incidencias
    '   False = Los datos se obtendran de la base de datos de FactuSOL
    Public gv_blnDBLocal As Boolean

    'Variables globales en las que se guarda la ubicacion de la base de datos principal y de Factusol que se estan utilizando
    Public gv_strDBPrincipal As String
    Public gv_strDBFactusol As String

    'Impresoras
    Public gv_strImpresoraIncidencias As String
    Public gv_strImpresoraInformes As String
    Public gv_lngTipoImpresoIncidencia As Long

    'Filtros de estados de las incidencias
    Public gv_blnAbierta As Boolean
    Public gv_blnEnproceso As Boolean
    Public gv_blnTerminada As Boolean
    Public gv_blnAvisado As Boolean
    Public gv_blnCerrada As Boolean
    Public gv_blnEngarantia As Boolean

    'Variable que contiene todos los informes
    Public gv_objReports As New clsReport(Application.ExecutablePath)

    '<CABECERA>-----------------------------------------------
    'Descripcion......: Comprueba que los datos de la aplicacion sean correctos
    'Fecha............: 29/05/2014
    '<FIN CABECERA>-------------------------------------------
    Public Function ComprobarDatosAplicacion() As Boolean

        Const strNombre_Funcion As String = "ComprobarDatosAplicacion"
        Dim blnError As Boolean

        Dim blnResultado As Boolean
        Dim blnImpresora As Boolean
        Dim strImpresora As String

        Try
            blnResultado = True = False
            'Comprobar si en la base de datos de incidencias hay una tabla "Incidencias" para comprobar que sea una base de datos valida
            If blnExisteTabla(gv_strDBPrincipal, gc_strDB_TABLA_Incidencias) Then
                If Not gv_blnDBLocal Then
                    'Si se utiliza la base de datos de factusol para los clientes, comprobar que exista la tabla "F_CLI" para comprobar que sea una base de datos valida
                    If blnExisteTabla(gv_strDBFactusol, gc_strDB_TABLA_Clientes) Then
                        'Comprobar que los nombres de las impresroras coicidan con alguna de las impresoras instaladas en el sistema
                        If gv_strImpresoraIncidencias <> "" Then
                            For Each strImpresora In Printing.PrinterSettings.InstalledPrinters
                                If strImpresora.Equals(gv_strImpresoraIncidencias) Then
                                    blnImpresora = True
                                    Exit For
                                Else
                                    blnImpresora = False
                                End If
                            Next
                            If Not blnImpresora Then
                                gv_strImpresoraIncidencias = ""
                            End If
                        End If

                        If gv_strImpresoraInformes <> "" Then
                            For Each strImpresora In Printing.PrinterSettings.InstalledPrinters
                                If strImpresora.Equals(gv_strImpresoraInformes) Then
                                    blnImpresora = True
                                    Exit For
                                Else
                                    blnImpresora = False
                                End If
                            Next
                            If Not blnImpresora Then
                                gv_strImpresoraInformes = ""
                            End If
                            blnResultado = True
                        Else
                            blnResultado = True
                        End If
                    Else
                        blnResultado = False
                    End If
                Else
                    'Comprobar que los nombres de las impresroras coicidan con alguna de las impresoras instaladas en el sistema
                    If gv_strImpresoraIncidencias <> "" Then
                        For Each strImpresora In Printing.PrinterSettings.InstalledPrinters
                            If strImpresora.Equals(gv_strImpresoraIncidencias) Then
                                blnImpresora = True
                                Exit For
                            Else
                                blnImpresora = False
                            End If
                        Next
                        If Not blnImpresora Then
                            gv_strImpresoraIncidencias = ""
                        End If
                    End If

                    If gv_strImpresoraInformes <> "" Then
                        For Each strImpresora In Printing.PrinterSettings.InstalledPrinters
                            If strImpresora.Equals(gv_strImpresoraInformes) Then
                                blnImpresora = True
                                Exit For
                            Else
                                blnImpresora = False
                            End If
                        Next
                        If Not blnImpresora Then
                            gv_strImpresoraInformes = ""
                        End If
                        blnResultado = True
                    Else
                        blnResultado = True
                    End If
                End If
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
            ComprobarDatosAplicacion = blnResultado
        End Try
    End Function

    '<CABECERA>-----------------------------------------------
    'Descripcion......: Carga el archivo de configuracion INI
    'Fecha............: 25/05/2014
    '<FIN CABECERA>-------------------------------------------
    Public Sub CargarConfiguracionINI()

        Const strNombre_Funcion As String = "CargarConfiguracionINI"
        
        Try
            'Rutas
            gv_strDBPrincipal = LeerINI(gc_strINIS_DBPATH, gc_strINIK_DBPATH_Principal, "")
            gv_strDBFactusol = LeerINI(gc_strINIS_DBPATH, gc_strINIK_DBPATH_Factusol, "")
            gv_blnDBLocal = LeerINI(gc_strINIS_DBPATH, gc_strINIK_DBPATH_Local, False)

            'Impresoras
            gv_strImpresoraIncidencias = LeerINI(gc_strINIS_PRINTERS, gc_strINIK_PRINTERS_Incidencias, "")
            gv_strImpresoraInformes = LeerINI(gc_strINIS_PRINTERS, gc_strINIK_PRINTERS_Informes, "")
            gv_lngTipoImpresoIncidencia = LeerINI(gc_strINIS_PRINTERS, gc_strINIK_PRINTERS_TipoImpresoIncidencia, 0)

            'Filtros
            gv_blnAbierta = LeerINI(gc_strINIS_FILTERS, gc_strINIK_FILTERS_Abierta, True)
            gv_blnEnproceso = LeerINI(gc_strINIS_FILTERS, gc_strINIK_FILTERS_Proceso, True)
            gv_blnTerminada = LeerINI(gc_strINIS_FILTERS, gc_strINIK_FILTERS_Terminada, True)
            gv_blnAvisado = LeerINI(gc_strINIS_FILTERS, gc_strINIK_FILTERS_Avisado, True)
            gv_blnCerrada = LeerINI(gc_strINIS_FILTERS, gc_strINIK_FILTERS_Cerrada, True)
            gv_blnEngarantia = LeerINI(gc_strINIS_FILTERS, gc_strINIK_FILTERS_Garantia, True)
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    '<CABECERA>-----------------------------------------------
    'Descripcion......: Guarda el archivo de configuracion INI
    'Fecha............: 25/05/2014
    '<FIN CABECERA>-------------------------------------------
    Public Sub GuardarConfiguracionINI()

        Const strNombre_Funcion As String = "GuardarConfiguracionINI"

        Try
            'Rutas
            EscribirINI(gc_strINIS_DBPATH, gc_strINIK_DBPATH_Principal, gv_strDBPrincipal)
            EscribirINI(gc_strINIS_DBPATH, gc_strINIK_DBPATH_Factusol, gv_strDBFactusol)
            EscribirINI(gc_strINIS_DBPATH, gc_strINIK_DBPATH_Local, gv_blnDBLocal)
            'Impresoras
            EscribirINI(gc_strINIS_PRINTERS, gc_strINIK_PRINTERS_Incidencias, gv_strImpresoraIncidencias)
            EscribirINI(gc_strINIS_PRINTERS, gc_strINIK_PRINTERS_Informes, gv_strImpresoraInformes)
            EscribirINI(gc_strINIS_PRINTERS, gc_strINIK_PRINTERS_TipoImpresoIncidencia, gv_lngTipoImpresoIncidencia)
            'Filtros
            EscribirINI(gc_strINIS_FILTERS, gc_strINIK_FILTERS_Abierta, gv_blnAbierta)
            EscribirINI(gc_strINIS_FILTERS, gc_strINIK_FILTERS_Proceso, gv_blnEnproceso)
            EscribirINI(gc_strINIS_FILTERS, gc_strINIK_FILTERS_Terminada, gv_blnTerminada)
            EscribirINI(gc_strINIS_FILTERS, gc_strINIK_FILTERS_Avisado, gv_blnAvisado)
            EscribirINI(gc_strINIS_FILTERS, gc_strINIK_FILTERS_Cerrada, gv_blnCerrada)
            EscribirINI(gc_strINIS_FILTERS, gc_strINIK_FILTERS_Garantia, gv_blnEngarantia)
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    '<CABECERA>-----------------------------------------------
    'Descripcion......: Añade corchetes a ambos lados de la cadena pasada, esta funcion se utiliza
    '                   para crear los alias de la Base de Datos
    'Fecha............: 11/10/2011
    '<FIN CABECERA>-------------------------------------------
    Public Function strPonerCorchetes(ByRef strCadena As String, Optional ByVal blnLlaves As Boolean = False) As String

        Const strNombre_Funcion As String = "strPonerCorchetes"
        Dim blnError As Boolean

        Dim strResultado As String = ""

        Try
            If blnLlaves Then
                strResultado = "{" & strCadena & "}"
            Else
                strResultado = "[" & strCadena & "]"
            End If
        Catch ex As Exception
            blnError = True
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        Finally
            If blnError Then
                strResultado = ""
            End If

            'Reornamos el valor
            strPonerCorchetes = strResultado
        End Try
    End Function

    '<CABECERA>-----------------------------------------------
    'Descripcion......: Obtiene el estado recibiendo el ID
    'Fecha............: 15/05/2014
    '<FIN CABECERA>-------------------------------------------
    Public Function ObtenerEstado(ByVal lngId As Long) As String

        Const strNombre_Funcion As String = "ObtenerEstado"
        Dim blnError As Boolean

        Dim strResultado As String = ""
        Dim strEstados As String() = {"", "Abierta", "En proceso", "Terminada", "Avisado", "Cerrada", "En garantia"}

        Try
            strResultado = strEstados(lngId)
        Catch ex As Exception
            blnError = True
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        Finally
            If blnError Then
                strResultado = ""
            End If
            ObtenerEstado = strResultado
        End Try
    End Function

    '<CABECERA>-----------------------------------------------
    'Descripcion......: Cambia la coma por el punto
    'Fecha............: 15/05/2014
    '<FIN CABECERA>-------------------------------------------
    Public Function strComaPunto(ByVal dblNumero As Double, Optional ByVal blnDecimales As Boolean = False) As String

        Const strNombre_Funcion As String = "strComaPunto"
        Dim blnError As Boolean

        Dim strResultado As String = ""
        Dim strNumero As String
        Dim strUnidad As String
        Dim intCont As Integer
        Dim blnHayComa As Boolean

        Try
            strNumero = dblNumero
            strResultado = ""

            For intCont = 0 To Len(strNumero) - 1
                strUnidad = Mid(strNumero, intCont + 1, 1)
                If Asc(strUnidad) <> gc_intComa Then
                    strResultado = strResultado & strUnidad
                Else
                    blnHayComa = True
                    strResultado = strResultado & Convert.ToChar(gc_intPunto)
                End If
            Next

            If Not blnHayComa And blnDecimales Then
                strResultado = strResultado & ",00"
            End If
        Catch ex As Exception
            blnError = True
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        Finally
            If blnError Then
                strResultado = ""
            End If
            strComaPunto = strResultado
        End Try
    End Function

    '<CABECERA>-----------------------------------------------
    'Descripcion......: Comprueba que todos los caracteres de la cadena de texto sean numeros
    'Fecha............: 22/05/2014
    '<FIN CABECERA>-------------------------------------------
    Function blnSoloNumeros(ByVal txtTexto As String) As Boolean

        Const strNombre_Funcion As String = "strComaPunto"
        Dim blnError As Boolean

        Const txtListaNumeros As String = "0123456789"
        Dim blnResultado As Boolean
        Dim cadenaTemporal As String
        Dim i As Integer

        Try
            txtTexto = Trim$(txtTexto)
            If Len(txtTexto) = 0 Then
                blnResultado = False
            Else
                cadenaTemporal = ""

                For i = 1 To Len(txtTexto)
                    If Not InStr(txtListaNumeros, Mid$(txtTexto, i, 1)) Then
                        blnResultado = False
                        Exit For
                    Else
                        blnResultado = True
                    End If
                Next
            End If
        Catch ex As Exception
            blnError = True
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        Finally
            If blnError Then
                blnResultado = False
            End If
            blnSoloNumeros = blnResultado
        End Try
    End Function

    '<CABECERA>-----------------------------------------------
    'Descripcion......: Quita el path y devuelve el nombre del fichero
    'Fecha............: 15/11/2011
    '<FIN CABECERA>-------------------------------------------
    Public Function strQuitarPath(ByVal strPath As String) As String

        Const strNombre_Funcion As String = "strQuitarPath"
        Dim blnError As Boolean
        
        Dim strResultado As String = ""
        Dim intPosi As Integer
        Dim intPosf As Integer

        Try
            intPosf = 0
            Do
                intPosi = intPosf + 1
                intPosf = InStr(intPosi, strPath, "\")
            Loop While intPosf <> 0

            If intPosi = 1 Then
                strResultado = strPath
            Else
                strResultado = Right$(strPath, Len(strPath) - intPosi + 1)
            End If
        Catch ex As Exception
            blnError = True
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        Finally
            If blnError Then
                strResultado = ""
            End If
            strQuitarPath = strResultado
        End Try
    End Function

    '<CABECERA>-----------------------------------------------
    'Descripcion......: Quita el nombre del fichero, devolviendo sólo el path
    'Fecha............: 15/11/2011
    '<FIN CABECERA>-------------------------------------------
    Function strQuitarFichero(ByVal strPath As String, Optional ByVal blnSinBarra As Boolean = False) As String

        Const strNombre_Funcion As String = "strQuitarFichero"
        Dim blnError As Boolean

        Dim strResultado As String = ""

        Try
            If blnSinBarra Then
                strResultado = Left$(strPath, Len(strPath) - (Len(strQuitarPath(strPath)) + 1))
            Else
                strResultado = Left$(strPath, Len(strPath) - Len(strQuitarPath(strPath)))
            End If
        Catch ex As Exception
            blnError = True
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        Finally
            If blnError Then
                strResultado = ""
            End If
            strQuitarFichero = strResultado
        End Try
    End Function
End Module
