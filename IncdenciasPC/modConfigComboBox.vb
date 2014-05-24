Option Explicit On
Option Compare Text

Module modConfigComboBox
    'Constante que guarda el nombre del mudolu
    Const mc_strNombre_Modulo As String = "modConfigComboBox"

    '<CABECERA>-----------------------------------------------
    'Nombre...........: Catalog_strQueryObtenerCatalogo
    'Descripcion......: Obtiene la query para obtener los Articulos del catalogo
    'Fecha............: 17/11/2011
    'Autor............: Borja Escudero
    'Parametros.......: cbxComboBox = ComboBox a llenar
    '                   dttRegistros = DataTable con los registros a introducir en el ComboBox
    '                   strClave = Campo del DataTable que se utilizara como clave del ComboBox
    '                   strValor = Campo del DataTable que se utilizara como valor del ComboBox
    '                   blnVacio = Variable que indica si se debe generar un campo vacio o no
    'Retorno..........: N/A
    '<FIN CABECERA>-------------------------------------------
    Public Sub ConfigurarComboBox(ByRef cbxComboBox As ComboBox, ByVal dttRegistros As DataTable, ByVal strClave As String, _
                                  ByVal strValor As String, Optional ByVal blnVacio As Boolean = False, Optional ByVal strTextoVacio As String = "")

        Const strNombre_Funcion As String = "ConfigurarComboBox"
        Dim blnError As Boolean

        Dim objRow As DataRow

        Try
            If blnVacio Then
                objRow = dttRegistros.NewRow
                objRow(strClave) = "0" 'Ninguna tabla tiene un ID 0 salvo la de subconceptos con los subconceptos de SI/NO
                objRow(strValor) = strTextoVacio
                dttRegistros.Rows.Add(objRow)
            End If

            cbxComboBox.DataSource = dttRegistros
            cbxComboBox.DisplayMember = strValor
            cbxComboBox.ValueMember = strClave
        Catch ex As Exception
            'Agregamos el error
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
            blnError = True
        Finally
            If blnError Then

            End If
        End Try
    End Sub

    '<CABECERA>-----------------------------------------------
    'Nombre...........: CargarFiltrosComboBox
    'Descripcion......: Se cargan los filtros del DataGridView en el Combo Box
    'Fecha............: 02/06/2012
    'Autor............: Borja Escudero
    '<FIN CABECERA>-------------------------------------------
    Public Sub CargarFiltrosComboBox(ByRef cbxFiltro As ComboBox, ByRef dgvRegistros As DataGridView, Optional ByVal colExceptions As Collection = Nothing)

        Const strNombre_Funcion As String = "CargarFiltrosComboBox"
        Dim blnError As Boolean

        Dim objCoumn As DataGridViewColumn
        Dim objItem As clsElementoCombo
        Dim intTipoDato As udtTiposCampos
        Dim intContador As Integer

        Try
            'Vacio
            objItem = New clsElementoCombo
            cbxFiltro.Items.Add(objItem)

            intContador = 0

            For Each objCoumn In dgvRegistros.Columns
                If objCoumn.Visible Then
                    If colExceptions Is Nothing Then colExceptions = New Collection
                    If Not colExceptions.Contains(objCoumn.Name) Then
                        'Creamos el elemento
                        objItem = New clsElementoCombo
                        intContador = intContador + 1
                        objItem.Clave = intContador
                        objItem.Descripcion = objCoumn.Name
                        'Definimos el tipo
                        Select Case objCoumn.ValueType.Name
                            Case "Int32" 'Numero entero largo
                                intTipoDato = udtTiposCampos.Numerico
                            Case "Double" 'Double
                                intTipoDato = udtTiposCampos.NumComa
                            Case "String" 'Texto
                                intTipoDato = udtTiposCampos.Texto
                            Case "DateTime" 'Fecha/Hora
                                intTipoDato = udtTiposCampos.Fecha
                            Case "Boolean" 'Si/No
                                intTipoDato = udtTiposCampos.SiNo
                        End Select
                        objItem.TipoElemento = intTipoDato
                        cbxFiltro.Items.Add(objItem)
                    End If
                End If
            Next
        Catch ex As Exception
            'Agregamos el error
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
            blnError = True
        Finally
            If blnError Then

            End If
        End Try
    End Sub

    '<CABECERA>-----------------------------------------------
    'Nombre...........: CargarFiltrosComboBox
    'Descripcion......: Se cargan los filtros del DataGridView en el Combo Box
    'Fecha............: 02/06/2012
    'Autor............: Borja Escudero
    '<FIN CABECERA>-------------------------------------------
    Public Sub CargarFiltrosToolStripComboBox(ByRef cbxFiltro As ToolStripComboBox, ByRef dgvRegistros As DataGridView, Optional ByVal colExceptions As Collection = Nothing)

        Const strNombre_Funcion As String = "CargarFiltrosComboBox"
        Dim blnError As Boolean

        Dim objCoumn As DataGridViewColumn
        Dim objItem As clsElementoCombo
        Dim intTipoDato As udtTiposCampos
        Dim intContador As Integer

        Try
            'Vacio
            objItem = New clsElementoCombo
            cbxFiltro.Items.Add(objItem)

            intContador = 0

            For Each objCoumn In dgvRegistros.Columns
                If objCoumn.Visible Then
                    If colExceptions Is Nothing Then colExceptions = New Collection
                    If Not colExceptions.Contains(objCoumn.Name) Then
                        'Creamos el elemento
                        objItem = New clsElementoCombo
                        intContador = intContador + 1
                        objItem.Clave = intContador
                        objItem.Descripcion = objCoumn.Name
                        'Definimos el tipo
                        Select Case objCoumn.ValueType.Name
                            Case "Int32" 'Numero entero largo
                                intTipoDato = udtTiposCampos.Numerico
                            Case "Double" 'Double
                                intTipoDato = udtTiposCampos.NumComa
                            Case "String" 'Texto
                                intTipoDato = udtTiposCampos.Texto
                            Case "DateTime" 'Fecha/Hora
                                intTipoDato = udtTiposCampos.Fecha
                            Case "Boolean" 'Si/No
                                intTipoDato = udtTiposCampos.SiNo
                        End Select
                        objItem.TipoElemento = intTipoDato
                        cbxFiltro.Items.Add(objItem)
                    End If
                End If
            Next
        Catch ex As Exception
            'Agregamos el error
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
            blnError = True
        Finally
            If blnError Then

            End If
        End Try
    End Sub

End Module
