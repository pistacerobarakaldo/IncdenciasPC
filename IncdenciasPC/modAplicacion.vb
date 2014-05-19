Option Explicit On
Option Compare Text

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

    '<CABECERA>-----------------------------------------------
    'Nombre...........: strPonerCorchetes
    'Descripcion......: Añade corchetes a ambos lados de la cadena pasada, esta funcion se utiliza
    '                   para crear los alias de la Base de Datos
    'Fecha............: 11/10/2011
    'Autor............: Borja Escudero
    'Parametros.......: strCadena = Cadena que se pasa para ponerle los corchetes
    '                   blnLlaves = Variable que determia el caracter a añadir
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

End Module
