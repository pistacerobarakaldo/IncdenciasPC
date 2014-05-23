Option Explicit On
Option Compare Text

Module modGestionINI
    'Constante que guarda el nombre del mudulo
    Const mc_strNombre_Modulo As String = "modGestionINI"

    ' Leer una clave de un fichero INI
    Private Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    Private Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As Integer, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Integer, ByVal lpFileName As String) As Integer

    ' Escribir una clave de un fichero INI
    Private Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer
    Private Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As Integer, ByVal lpFileName As String) As Integer
    Private Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As Integer, ByVal lpString As Integer, ByVal lpFileName As String) As Integer

    '<CABECERA>-----------------------------------------------
    'Descripcion......: Devuelve el valor de una clave de un fichero INI
    'Fecha............: 13/10/2011
    '<FIN CABECERA>-------------------------------------------
    Public Function LeerINI(ByVal strSection As String, ByVal strClave As String, Optional ByVal strDefecto As String = "") As String

        Const strNombre_Funcion As String = "LeerINI"
        Dim blnError As Boolean

        Dim strResultado As String = ""
        Dim intRetorno As Integer
        Dim strValor As String
        Dim strFichero As String

        Try
            strFichero = Application.StartupPath & gc_strINI_INIFILE

            strValor = New String(Chr(0), 255)

            intRetorno = GetPrivateProfileString(strSection, strClave, strDefecto, strValor, Len(strValor), strFichero)
            If intRetorno = 0 Then
                strResultado = strDefecto
            Else
                strResultado = Left(strValor, intRetorno)
            End If
        Catch ex As Exception
            blnError = True
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        Finally
            If blnError Then
                strResultado = ""
            End If
            LeerINI = strResultado
        End Try
    End Function

    '<CABECERA>-----------------------------------------------
    'Descripcion......: Escribe el valor de una clave de un fichero INI
    'Fecha............: 13/10/2011
    '<FIN CABECERA>-------------------------------------------
    Public Sub EscribirINI(ByVal strSection As String, ByVal strClave As String, ByVal strValor As String)

        Const strNombre_Funcion As String = "EscribirINI"
        
        Dim strFichero As String

        Try
            strFichero = Application.StartupPath & gc_strINI_INIFILE
            Call WritePrivateProfileString(strSection, strClave, strValor, strFichero)
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub
End Module
