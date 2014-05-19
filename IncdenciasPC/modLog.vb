Option Explicit On
Option Compare Text
Imports System.IO

Module modLog
    'Constante que determina el Nombre del modulo
    Const mc_strNombre_Modulo As String = "modLog"

    Private strLogPath As String

    '<CABECERA>-----------------------------------------------
    'Nombre..........: AddLog
    'Descripcion.....: Guarda en el log de errores los errores generados
    'Fecha...........: 22/09/2011
    'Autor...........: Borja Escudero
    'Parametros......: objError: Exception del error generado
    '                  strModulo: Modulo en el que se genero el error
    '                  strFuncion: Funcion en la que se genero el error 
    'Retorno.........:
    '<FIN CABECERA>-------------------------------------------
    Public Sub AddLog(ByVal strMensaje As String, ByVal strModulo As String, ByVal strFuncion As String)

        Dim strCadenaTexto As String

        Try
            If strLogPath = "" Then
                strLogPath = strQuitarPonerExtension(Application.ExecutablePath, True) & ".log"
            End If

            'Crear cadena de texto
            strCadenaTexto = ""
            strCadenaTexto = strCadenaTexto & vbCrLf
            strCadenaTexto = strCadenaTexto & DateTime.Now
            strCadenaTexto = strCadenaTexto & " >> " & strFuncion & " [ " & strModulo & " ]" & vbCrLf
            strCadenaTexto = strCadenaTexto & vbTab & strMensaje & vbCrLf
            strCadenaTexto = strCadenaTexto & "___________________________________________________________________"

            'Se abre el archivo, si este no existe se crea, despues de añade la linea
            File.AppendAllText(strLogPath, strCadenaTexto)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    '<CABECERA>-----------------------------------------------
    'Nombre...........: strQuitarPonerExtension
    'Descripcion......: Quita u Obtiene la extansión del fichero que se pasa como parámetro
    'Fecha............: 15/11/2011
    'Autor............: Borja Escudero
    'Parametros.......: strFichero = Direccion del archivo completa
    '                   blnQuitar = Variable que determina si se debe quitar la extension
    'Retorno..........: Fcihero con o sin extension
    '<FIN CABECERA>-------------------------------------------
    Function strQuitarPonerExtension(ByVal strFichero As String, ByVal blnQuitar As Boolean) As String

        Const strNombre_Funcion As String = "strQuitarPonerExtension"
        Dim lngError As Long
        
        Dim strResultado As String
        Dim intCont As Integer
        Dim intPosPunto As Integer

        On Error GoTo TratarError

        If strFichero <> "" Then
            intPosPunto = Len(strFichero) + 1

            For intCont = 0 To Len(strFichero) - 1
                If Mid$(strFichero, Len(strFichero) - intCont, 1) = "." Then
                    intPosPunto = Len(strFichero) - intCont
                    Exit For
                End If
            Next
            If blnQuitar Then
                strResultado = Left$(strFichero, intPosPunto - 1)
            Else
                strResultado = Right$(strFichero, Len(strFichero) - intPosPunto)
            End If
        Else
            strResultado = ""
        End If

Terminar:

        If lngError <> 0 Then
            strResultado = ""
        End If

        'Reornamos el valor
        strQuitarPonerExtension = strResultado

        'Anulamos el control de errores
        On Error GoTo 0
        Exit Function

TratarError:

        'Guardamos el error
        lngError = Err.Number
        
        Resume Terminar
    End Function
End Module