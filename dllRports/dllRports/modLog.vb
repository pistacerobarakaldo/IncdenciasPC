Option Explicit On
Option Compare Text

Imports System.IO

Module modLog
    'Constante que determina el Nombre del modulo
    Const gc_strNombre_Modulo As String = "modLog"

    Private strLogPath As String

    '<CABECERA>-----------------------------------------------
    'Descripcion.....: Guarda en el log de errores los errores generados
    'Fecha...........: 22/09/2011
    '<FIN CABECERA>-------------------------------------------
    Public Sub AddLog(ByVal strMensaje As String, ByVal strModulo As String, ByVal strFuncion As String)

        Dim strCadenaTexto As String

        Try
            If strLogPath = "" Then
                strLogPath = strQuitarPonerExtension(ApplicationPath, True) & ".log"
            End If

            'Crear cadena de texto
            strCadenaTexto = ""
            strCadenaTexto = strCadenaTexto & vbCrLf
            strCadenaTexto = strCadenaTexto & DateTime.Now
            strCadenaTexto = strCadenaTexto & " >> [ " & strModulo & " / " & strFuncion & " ]" & vbCrLf
            strCadenaTexto = strCadenaTexto & vbTab & strMensaje & vbCrLf
            strCadenaTexto = strCadenaTexto & "___________________________________________________________________"

            'Se abre el archivo, si este no existe se crea, despues de añade la linea
            File.AppendAllText(strLogPath, strCadenaTexto)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Module
