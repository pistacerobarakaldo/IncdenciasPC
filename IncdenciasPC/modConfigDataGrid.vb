Option Explicit On
Option Compare Text

Module modConfigDataGrid
    'Constante que guarda el nombre del mudolu
    Const mc_strNombre_Modulo As String = "modConfigDataGrid"

    'Constante utilizada para almacenar el ancho de la cabecera de columna en caso de que NO se visualice la barra de scroll
    Public Const gc_intAnchCabeFila_N As Integer = 40
    'Constante utilizada para almacenar el ancho de la cabecera de columna en caso de que SI se visualice la barra de scroll
    Public Const gc_intAnchCabeFila_S As Integer = 23

    '<CABECERA>-----------------------------------------------
    'Nombre...........: ConfigurarDataGridView
    'Descripcion......: Configura el DataGridView recibido como parametro
    '                   Parte de la configuracion es estandar para todos 
    '                   pero habra parte que será propia de cada DataGridView
    'Fecha............: 14/11/2011
    'Autor............: Borja Escudero
    'Parametros.......: objDataGridView = Objeto DataGridView que se desea configurar
    'Retorno..........: N/A
    '<FIN CABECERA>-------------------------------------------
    Public Sub ConfigurarDataGridView(ByRef objDataGridView As DataGridView, Optional ByVal intAnchCabeFila_N As Integer = -1, Optional ByVal intAnchCabeFila_S As Integer = -1)

        Const strNombre_Funcion As String = "ConfigurarDataGridView"
        Dim blnError As Boolean

        Dim intCabeceraBig As Integer
        Dim intCabeceraSmall As Integer

        Try
            'Establecemos las propiedades del DataGridView
            objDataGridView.AllowUserToAddRows = False
            objDataGridView.AllowUserToDeleteRows = False
            objDataGridView.AllowUserToOrderColumns = False
            objDataGridView.AllowUserToResizeRows = False
            objDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically
            objDataGridView.MultiSelect = False
            objDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect

            'Establecemos el color para las filas alternas
            objDataGridView.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.GradientInactiveCaption

            'Establecemos la alineacion y el formato de las cabeceras
            objDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            objDataGridView.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font(objDataGridView.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold)

            'Pasamos a variables locales la anchura de las cabeceras de las filas
            If intAnchCabeFila_N <> -1 Then
                intCabeceraBig = intAnchCabeFila_N
            Else
                intCabeceraBig = gc_intAnchCabeFila_N
            End If
            If intAnchCabeFila_S <> -1 Then
                intCabeceraSmall = intAnchCabeFila_S
            Else
                intCabeceraSmall = gc_intAnchCabeFila_S
            End If

            If objDataGridView.RowCount > 0 Then
                If objDataGridView.Rows(0).Displayed And objDataGridView.Rows(objDataGridView.Rows.Count - 1).Displayed Then
                    objDataGridView.RowHeadersWidth = intCabeceraBig
                Else
                    If objDataGridView.DisplayedRowCount(True) = 0 Then
                        objDataGridView.RowHeadersWidth = intCabeceraBig
                    Else
                        objDataGridView.RowHeadersWidth = intCabeceraSmall
                    End If
                End If
            Else
                objDataGridView.RowHeadersWidth = intCabeceraBig
            End If
        Catch ex As Exception
            blnError = True
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    '<CABECERA>-----------------------------------------------
    'Nombre...........: Config_strGenerarFiltroDataGridView
    'Descripcion......: General el filtro para filtrar un DataGridView
    'Fecha............: 20/03/2012
    'Autor............: Borja Escudero
    'Parametros.......: strTexto = Texto por el que filtrar
    '                   strCampo = Campo por el que filtrar el texto recibido
    'Retorno..........: Devuelve el filtro generado
    '<FIN CABECERA>-------------------------------------------
    Public Function Config_strGenerarFiltroDataGridView(ByVal strTexto As String, ByVal objCampo As clsElementoCombo) As String

        Const strNombre_Funcion As String = "Config_strGenerarFiltroDataGridView"
        Dim blnError As Boolean
        
        Dim strFiltro As String = ""
        Dim strCampo As String
        Dim strAux As String = ""
        Dim blnDateOk As Boolean
        Dim objDate As Date

        Try
            strCampo = strPonerCorchetes(objCampo.Descripcion)

            'Filtrado por nombre
            If strTexto <> "" And strCampo <> "" Then
                Select Case objCampo.TipoElemento
                    Case udtTiposCampos.Fecha
                        If strTexto.Length = 8 Then
                            strAux = Mid(strTexto, 1, 2)
                            strAux = strAux & "/" & Mid(strTexto, 3, 2)
                            strAux = strAux & "/" & Mid(strTexto, 5, 4)
                            blnDateOk = Date.TryParse(strAux, objDate)
                            If blnDateOk Then
                                'Se obtiene el filtro
                                strFiltro = strCampo & " = #" & Format(objDate, "MM/dd/yyyy") & "#"
                            Else
                                strFiltro = ""
                            End If
                        Else
                            strFiltro = ""
                        End If
                    Case udtTiposCampos.Numerico
                        strFiltro = "Convert(" & strCampo & ",System.String) like '" & strTexto & "*'"
                    Case udtTiposCampos.SiNo
                        If strTexto = "S" Or strTexto = "s" Then
                            strFiltro = strCampo & " = True"
                        ElseIf strTexto = "N" Or strTexto = "n" Then
                            strFiltro = strCampo & " = False"
                        End If
                    Case udtTiposCampos.Texto
                        strFiltro = strCampo & " like '" & strTexto & "*'"
                End Select
            End If
        Catch ex As Exception
            blnError = True
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        Finally
            If blnError Then
                strFiltro = ""
            End If

            'Retornamos el error
            Config_strGenerarFiltroDataGridView = strFiltro
        End Try
    End Function
End Module
