Option Explicit On
Option Compare Text

Module modUtilidades
    'Constante que guarda el nombre del mudolu
    Const mc_strNombre_Modulo As String = "frmCodigoValidacion"

    '<CABECERA>-----------------------------------------------
    'Descripcion......: Quita u Obtiene la extansión del fichero que se pasa como parámetro
    'Fecha............: 15/11/2011
    '<FIN CABECERA>-------------------------------------------
    Function strQuitarPonerExtension(ByVal strFichero As String, ByVal blnQuitar As Boolean) As String

        Const strNombre_Funcion As String = "frmCodigoValidacion_Load"
        Dim blnError As Boolean

        Dim strResultado As String = ""
        Dim intCont As Integer
        Dim intPosPunto As Integer

        Try
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
        Catch ex As Exception
            'Agregamos el error
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
            blnError = True
        Finally
            If blnError Then
                strQuitarPonerExtension = ""
            Else
                strQuitarPonerExtension = strResultado
            End If
        End Try
    End Function
End Module