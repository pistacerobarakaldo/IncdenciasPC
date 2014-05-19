Module modDBQConfiguracion
    'Constante que guarda el nombre del mudolu
    Const mc_strNombre_Modulo As String = "modDBQConfiguracion"

    '<CABECERA>-----------------------------------------------
    'Descripcion......: Obtiene el indice maximo del campo y tabla indicados
    'Fecha............: 07/05/2014
    '<FIN CABECERA>-------------------------------------------
    Public Function Config_strQueryIndiceMaximo(ByVal strTabla As String, ByVal strCampo As String) As String

        Const strNombre_Funcion As String = "Config_strQueryIndiceMaximo"
        Dim blnError As Boolean

        Dim strQuery As String = ""

        Try
            'SELECT
            strQuery = "SELECT MAX(" & strCampo & ")" '& " AS " & strCampo
            strQuery = strQuery & vbCrLf

            'FROM
            strQuery = strQuery & "FROM " & strTabla
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
            blnError = True
        Finally
            If blnError Then
                strQuery = ""
            End If
            Config_strQueryIndiceMaximo = strQuery
        End Try
    End Function
End Module
