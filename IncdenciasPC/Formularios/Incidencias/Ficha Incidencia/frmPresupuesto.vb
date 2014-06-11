Public Class frmPresupuesto
    Const mc_strNombre_Modulo As String = "frmPresupuesto"

    Private m_lngIncidencia As Long

    Public Function blnCargarPresupuesto(ByVal objIncidencia As clsIncidencia) As Boolean

        Const strNombre_Funcion As String = "blnCargarPresupuesto"
        Dim blnError As Boolean

        Try
            m_lngIncidencia = objIncidencia.Id
            dgvPresupuesto.DataSource = objIncidencia.Presupuesto
            ConfigurarDataGridView(dgvPresupuesto)
            AjustarColumnas()
            ActualizarImportes()
        Catch ex As Exception
            blnError = True
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        Finally
            blnCargarPresupuesto = Not blnError
        End Try
    End Function

    Private Sub frmLineasPresupuesto_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged

        Const strNombre_Funcion As String = "frmLineasPresupuesto_VisibleChanged"

        Try
            If Me.Visible Then
                ConfigurarDataGridView(dgvPresupuesto)
                AjustarColumnas()
            End If
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    '<CABECERA>-----------------------------------------------
    'Descripcion......: Ajusta el ancho de las columnas para adaptarlo al tamaño del DataGridView
    'Fecha............: 29/04/2014
    '<FIN CABECERA>-------------------------------------------
    Public Sub AjustarColumnas()

        Const strNombre_Funcion As String = "AjustarColumnas"

        Dim dblAnchoDisponible As Double
        Dim dblSumaTotal As Double

        Try
            'Comportamiento especial
            dgvPresupuesto.EditMode = DataGridViewEditMode.EditOnKeystroke
            dgvPresupuesto.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect

            dblAnchoDisponible = dgvPresupuesto.Width - gc_intAnchCabeFila_N - 7

            'Ocultamos las filas que no deseamos que sean visualizadas
            dgvPresupuesto.Columns(gc_strLP_C_Incidencia).Visible = False
            dgvPresupuesto.Columns(gc_strLP_C_Linea).Visible = True
            dgvPresupuesto.Columns(gc_strLP_D_Concepto).Visible = True
            dgvPresupuesto.Columns(gc_strLP_V_Importe).Visible = True
            dgvPresupuesto.Columns(gc_strLP_V_Cantidad).Visible = True
            dgvPresupuesto.Columns(gc_strLP_V_Base).Visible = True
            dgvPresupuesto.Columns(gc_strLP_V_PIVA).Visible = True
            dgvPresupuesto.Columns(gc_strLP_V_IVA).Visible = False
            dgvPresupuesto.Columns(gc_strLP_V_Total).Visible = True

            'Establecemos un ancho predefinido para cada columna
            dgvPresupuesto.Columns(gc_strLP_C_Linea).Width = dblAnchoDisponible * 0.07
            dblSumaTotal = dblSumaTotal + dgvPresupuesto.Columns(gc_strLP_C_Linea).Width
            dgvPresupuesto.Columns(gc_strLP_D_Concepto).Width = dblAnchoDisponible * 0.35
            dblSumaTotal = dblSumaTotal + dgvPresupuesto.Columns(gc_strLP_D_Concepto).Width
            dgvPresupuesto.Columns(gc_strLP_V_Importe).Width = dblAnchoDisponible * 0.15
            dblSumaTotal = dblSumaTotal + dgvPresupuesto.Columns(gc_strLP_V_Importe).Width
            dgvPresupuesto.Columns(gc_strLP_V_Cantidad).Width = dblAnchoDisponible * 0.1
            dblSumaTotal = dblSumaTotal + dgvPresupuesto.Columns(gc_strLP_V_Cantidad).Width
            dgvPresupuesto.Columns(gc_strLP_V_Base).Width = dblAnchoDisponible * 0.1
            dblSumaTotal = dblSumaTotal + dgvPresupuesto.Columns(gc_strLP_V_Base).Width
            dgvPresupuesto.Columns(gc_strLP_V_PIVA).Width = dblAnchoDisponible * 0.08
            dblSumaTotal = dblSumaTotal + dgvPresupuesto.Columns(gc_strLP_V_PIVA).Width
            dgvPresupuesto.Columns(gc_strLP_V_Total).Width = dblAnchoDisponible * 0.15
            dblSumaTotal = dblSumaTotal + dgvPresupuesto.Columns(gc_strLP_V_Total).Width
            If dblSumaTotal > dblAnchoDisponible Then
                dgvPresupuesto.Columns(gc_strLP_C_Linea).Width = dgvPresupuesto.Columns(gc_strLP_C_Linea).Width - (dblSumaTotal - dblAnchoDisponible)
            End If
            'Establecemos la alineacion da cada columna
            dgvPresupuesto.Columns(gc_strLP_C_Linea).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvPresupuesto.Columns(gc_strLP_C_Linea).ReadOnly = True
            dgvPresupuesto.Columns(gc_strLP_D_Concepto).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvPresupuesto.Columns(gc_strLP_V_Importe).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvPresupuesto.Columns(gc_strLP_V_Importe).DefaultCellStyle.Format = "0.00 €"
            dgvPresupuesto.Columns(gc_strLP_V_Cantidad).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvPresupuesto.Columns(gc_strLP_V_Base).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvPresupuesto.Columns(gc_strLP_V_Base).DefaultCellStyle.Format = "0.00 €"
            dgvPresupuesto.Columns(gc_strLP_V_Base).ReadOnly = True
            dgvPresupuesto.Columns(gc_strLP_V_PIVA).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvPresupuesto.Columns(gc_strLP_V_PIVA).DefaultCellStyle.Format = "0.0 %"
            dgvPresupuesto.Columns(gc_strLP_V_PIVA).ReadOnly = True
            dgvPresupuesto.Columns(gc_strLP_V_Total).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvPresupuesto.Columns(gc_strLP_V_Total).DefaultCellStyle.Format = "0.00 €"
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Private Sub dgvPresupuesto_CellValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPresupuesto.CellValidated

        Const strNombre_Funcion As String = "dgvLineasFactura_CellValidated"

        Try
            'Solo afectará a las celdas que esten en modo edicion en ese moemnto
            If dgvPresupuesto.SelectedCells.Count > 0 Then
                If dgvPresupuesto.SelectedCells(0).IsInEditMode Then
                    If blnGestionarLineasArticulos() Then
                        ActualizarImportes()
                    End If
                End If
            End If
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    '<CABECERA>-----------------------------------------------
    'Descripcion......: Controla que en las celdas se escriba lo que se tiene que escribir
    'Fecha............: 06/05/2014
    '<FIN CABECERA>-------------------------------------------
    Private Sub dgvPresupuesto_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvPresupuesto.EditingControlShowing

        Const strNombre_Funcion As String = "dgvLineasFactura_EditingControlShowing"

        Dim vtxtValidar As TextBox

        Try
            'Se genra un textBox virtual para controlar la edicion de la celda
            vtxtValidar = CType(e.Control, TextBox)

            'Se agrega el controlador al evento KeyPress del TextBox virtual
            AddHandler vtxtValidar.KeyPress, AddressOf ValidarValorCelda
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    '<CABECERA>-----------------------------------------------
    'Nombre...........: ValidarValorCelda
    'Descripcion......: Se controla la edicion de la celda para que solo se puedan introducir numeros
    'Fecha............: 29/11/2011
    'Autor............: Borja Escudero
    'Parametros.......: N/A 
    'Retorno..........: N/A
    '<FIN CABECERA>-------------------------------------------
    Private Sub ValidarValorCelda(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        Const strNombre_Funcion As String = "ValidarValorCelda"

        Dim txtBox As TextBox

        Try
            If dgvPresupuesto.Columns(dgvPresupuesto.CurrentCell.ColumnIndex).Name = gc_strLP_V_Cantidad Or _
               dgvPresupuesto.Columns(dgvPresupuesto.CurrentCell.ColumnIndex).Name = gc_strLP_V_Importe Or _
               dgvPresupuesto.Columns(dgvPresupuesto.CurrentCell.ColumnIndex).Name = gc_strLP_V_Base Or _
               dgvPresupuesto.Columns(dgvPresupuesto.CurrentCell.ColumnIndex).Name = gc_strLP_V_Total Then
                'Obtenemos el caracter, si es un punto lo cambiamos por una coma para que funcione indistintamente de como lo escriba el usuario
                If e.KeyChar = "." Then e.KeyChar = ","

                'Hacemos que la variable txtBox haga referencia a la celda que se está editando
                txtBox = CType(sender, TextBox)

                'Comprueba si el caracter es un numero o la tecla de retroceso(borrar)
                If Not Char.IsNumber(e.KeyChar) And (e.KeyChar = ChrW(Keys.Back)) = False Then
                    'Si el caracter es una coma y ya hay una coma se anula el caracter
                    If (e.KeyChar = ",") Then
                        If txtBox.Text.Contains(",") Then
                            e.KeyChar = Chr(0)
                        End If
                    Else
                        e.KeyChar = Chr(0)
                    End If
                End If
            ElseIf dgvPresupuesto.Columns(dgvPresupuesto.CurrentCell.ColumnIndex).Name = gc_strLP_C_Linea Then
                e.KeyChar = Chr(0)
            End If
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    '<CABECERA>-----------------------------------------------
    'Descripcion......: Actualiza los importes de las cajas de texto
    'Fecha............: 30/04/2014
    '<FIN CABECERA>-------------------------------------------
    Private Sub ActualizarImportes()

        Const strNombre_Funcion As String = "ActualizarImportes"

        Dim objRow As DataGridViewRow
        Dim dblBase As Double
        Dim dblIVA As Double
        Dim dblTotal As Double

        Try
            dblBase = 0
            dblIVA = 0
            dblTotal = 0

            For Each objRow In dgvPresupuesto.Rows
                dblBase = dblBase + objRow.Cells(gc_strLP_V_Base).Value
                dblIVA = dblIVA + (objRow.Cells(gc_strLP_V_Total).Value - objRow.Cells(gc_strLP_V_Base).Value)
                dblTotal = dblTotal + objRow.Cells(gc_strLP_V_Total).Value
            Next

            txtBase.Text = Format(dblBase, "0.00 €")
            txtIVA.Text = Format(dblIVA, "0.00 €")
            txtTotal.Text = Format(dblTotal, "0.00 €")
            frmFichaIncidencia.Presupuesto = txtTotal.Text
            frmDetallesIncidencia.Presupuesto = dblTotal
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Public Function blnGestionarLineasArticulos() As Boolean

        Const strNombre_Funcion As String = "blnGestionarLineasArticulos"
        Dim blnError As Boolean

        Dim dblImporte As Double
        Dim dblCantidad As Double
        Dim dblBase As Double
        Dim dblTotal As Double
        Dim dblIVA As Double
        Dim intFila As Integer
        Dim intColumna As Integer

        Try
            intFila = dgvPresupuesto.CurrentCell.RowIndex
            intColumna = dgvPresupuesto.CurrentCell.ColumnIndex

            Select Case dgvPresupuesto.Columns(intColumna).Name
                Case gc_strLP_V_Importe
                    If IsDBNull(dgvPresupuesto.SelectedCells(0).Value) Then
                        dgvPresupuesto.SelectedCells(0).Value = 0
                    End If
                    dblImporte = dgvPresupuesto.SelectedCells(0).Value
                    dblIVA = dgvPresupuesto.Rows(intFila).Cells(gc_strLP_V_PIVA).Value
                    dblCantidad = dgvPresupuesto.Rows(intFila).Cells(gc_strLP_V_Cantidad).Value
                    dblBase = dblImporte * dblCantidad
                    dblTotal = dblBase
                    dblTotal = dblTotal + (dblBase * dblIVA)
                    dgvPresupuesto.Rows(intFila).Cells(gc_strLP_V_Base).Value = dblBase
                    dgvPresupuesto.Rows(intFila).Cells(gc_strLP_V_Total).Value = dblTotal
                Case gc_strLP_V_Cantidad
                    If IsDBNull(dgvPresupuesto.SelectedCells(0).Value) Then
                        dgvPresupuesto.SelectedCells(0).Value = 0
                    End If
                    dblCantidad = dgvPresupuesto.SelectedCells(0).Value
                    dblIVA = dgvPresupuesto.Rows(intFila).Cells(gc_strLP_V_PIVA).Value
                    dblImporte = dgvPresupuesto.Rows(intFila).Cells(gc_strLP_V_Importe).Value
                    dblBase = dblImporte * dblCantidad
                    dblTotal = dblBase
                    dblTotal = dblTotal + (dblBase * dblIVA)
                    dgvPresupuesto.Rows(intFila).Cells(gc_strLP_V_Base).Value = dblBase
                    dgvPresupuesto.Rows(intFila).Cells(gc_strLP_V_Total).Value = dblTotal
                Case gc_strLP_V_Total
                    If IsDBNull(dgvPresupuesto.SelectedCells(0).Value) Then
                        dgvPresupuesto.SelectedCells(0).Value = 0
                    End If
                    dblTotal = dgvPresupuesto.SelectedCells(0).Value
                    dblIVA = dgvPresupuesto.Rows(intFila).Cells(gc_strLP_V_PIVA).Value
                    dblCantidad = dgvPresupuesto.Rows(intFila).Cells(gc_strLP_V_Cantidad).Value
                    dblBase = dblTotal / (dblIVA + 1)
                    dblImporte = dblBase / dblCantidad
                    dgvPresupuesto.Rows(intFila).Cells(gc_strLP_V_Importe).Value = dblImporte
                    dgvPresupuesto.Rows(intFila).Cells(gc_strLP_V_Base).Value = dblBase
            End Select
        Catch ex As Exception
            'Agregamos el error
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
            blnError = True
        Finally
            blnGestionarLineasArticulos = Not blnError
        End Try
    End Function

    Private Sub dgvPresupuesto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvPresupuesto.KeyDown

        Const strNombre_Funcion As String = "dgvPresupuesto_KeyDown"

        Try
            If dgvPresupuesto.Rows.Count > 0 Then
                If dgvPresupuesto.CurrentCell.ColumnIndex = dgvPresupuesto.Columns.Count - 1 Then
                    If Not dgvPresupuesto.CurrentCell.IsInEditMode Then
                        NuevaLinea()
                    End If
                End If
            End If
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    '<CABECERA>-----------------------------------------------
    'Descripcion......: Añade una nueva linea al DataGridView
    'Fecha............: 06/05/2014
    '<FIN CABECERA>-------------------------------------------
    Public Sub NuevaLinea()

        Const strNombre_Funcion As String = "NuevaLinea"

        Dim dttTabla As DataTable
        Dim intFila As Integer

        Try
            'Referenciamos el objeto DataTable enlazado al control DataGridView.
            dttTabla = TryCast(dgvPresupuesto.DataSource, DataTable)

            'Añadimos una nueva fila
            dttTabla.Rows.Add()
            intFila = dgvPresupuesto.Rows.Count - 1
            dgvPresupuesto.Rows(intFila).Cells(gc_strLP_C_Incidencia).Value = m_lngIncidencia
            dgvPresupuesto.Rows(intFila).Cells(gc_strLP_C_Linea).Value = dgvPresupuesto.Rows.Count
            dgvPresupuesto.Rows(intFila).Cells(gc_strLP_D_Concepto).Value = ""
            dgvPresupuesto.Rows(intFila).Cells(gc_strLP_V_Importe).Value = 0
            dgvPresupuesto.Rows(intFila).Cells(gc_strLP_V_Cantidad).Value = 1
            dgvPresupuesto.Rows(intFila).Cells(gc_strLP_V_Base).Value = 0
            dgvPresupuesto.Rows(intFila).Cells(gc_strLP_V_PIVA).Value = 0.21
            dgvPresupuesto.Rows(intFila).Cells(gc_strLP_V_IVA).Value = 0
            dgvPresupuesto.Rows(intFila).Cells(gc_strLP_V_Total).Value = 0

            'Reajustamos las columnas del DataGridView
            ConfigurarDataGridView(dgvPresupuesto)
            AjustarColumnas()

            'Dejamos la fila y celda seleccionadas
            dgvPresupuesto.CurrentCell = dgvPresupuesto.Rows(intFila).Cells(gc_strLP_D_Concepto)
            dgvPresupuesto.CurrentCell.Selected = True
            dgvPresupuesto.CurrentCell.Dispose()
            dgvPresupuesto.BeginEdit(False)

            ActualizarImportes()
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    '<CABECERA>-----------------------------------------------
    'Descripcion......: Añade una nueva linea al DataGridView
    'Fecha............: 06/05/2014
    '<FIN CABECERA>-------------------------------------------
    Public Sub DuplicarLinea()

        Const strNombre_Funcion As String = "DuplicarLinea"

        Dim dttTabla As DataTable
        Dim intFila As Integer

        Try
            'Referenciamos el objeto DataTable enlazado al control DataGridView.
            dttTabla = TryCast(dgvPresupuesto.DataSource, DataTable)

            'Añadimos una nueva fila
            dttTabla.Rows.Add()
            intFila = dgvPresupuesto.Rows.Count - 1
            dgvPresupuesto.Rows(intFila).Cells(gc_strLP_C_Incidencia).Value = m_lngIncidencia
            dgvPresupuesto.Rows(intFila).Cells(gc_strLP_C_Linea).Value = dgvPresupuesto.Rows.Count
            dgvPresupuesto.Rows(intFila).Cells(gc_strLP_D_Concepto).Value = dgvPresupuesto.Rows(dgvPresupuesto.SelectedRows(0).Index).Cells(gc_strLP_D_Concepto).Value
            dgvPresupuesto.Rows(intFila).Cells(gc_strLP_V_Importe).Value = dgvPresupuesto.Rows(dgvPresupuesto.SelectedRows(0).Index).Cells(gc_strLP_V_Importe).Value
            dgvPresupuesto.Rows(intFila).Cells(gc_strLP_V_Cantidad).Value = dgvPresupuesto.Rows(dgvPresupuesto.SelectedRows(0).Index).Cells(gc_strLP_V_Cantidad).Value
            dgvPresupuesto.Rows(intFila).Cells(gc_strLP_V_Base).Value = dgvPresupuesto.Rows(dgvPresupuesto.SelectedRows(0).Index).Cells(gc_strLP_V_Base).Value
            dgvPresupuesto.Rows(intFila).Cells(gc_strLP_V_PIVA).Value = dgvPresupuesto.Rows(dgvPresupuesto.SelectedRows(0).Index).Cells(gc_strLP_V_PIVA).Value
            dgvPresupuesto.Rows(intFila).Cells(gc_strLP_V_IVA).Value = dgvPresupuesto.Rows(dgvPresupuesto.SelectedRows(0).Index).Cells(gc_strLP_V_IVA).Value
            dgvPresupuesto.Rows(intFila).Cells(gc_strLP_V_Total).Value = dgvPresupuesto.Rows(dgvPresupuesto.SelectedRows(0).Index).Cells(gc_strLP_V_Total).Value

            'Reajustamos las columnas del DataGridView
            ConfigurarDataGridView(dgvPresupuesto)
            AjustarColumnas()
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    '<CABECERA>-----------------------------------------------
    'Descripcion......: Elimina una linea del DataGridView
    'Fecha............: 06/05/2014
    '<FIN CABECERA>-------------------------------------------
    Public Sub EliminarLinea()

        Const strNombre_Funcion As String = "EliminarLinea"

        Dim dttTabla As DataTable

        Try
            'Referenciamos el objeto DataTable enlazado al control DataGridView.
            dttTabla = TryCast(dgvPresupuesto.DataSource, DataTable)

            'Añadimos una nueva fila
            dttTabla.Rows(dgvPresupuesto.CurrentCell.RowIndex).Delete()

            'Reajustamos las columnas del DataGridView
            ConfigurarDataGridView(dgvPresupuesto)
            AjustarColumnas()

            ActualizarImportes()
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    '<CABECERA>-----------------------------------------------
    'Descripcion......: Devuelve la tabla actual 
    'Fecha............: 06/05/2014
    '<FIN CABECERA>-------------------------------------------
    Public Function GuardarPresupuesto() As DataTable

        Const strNombre_Funcion As String = "GuardarPresupuesto"
        Dim blnError As Boolean

        Dim dttTabla As DataTable = Nothing

        Try
            'Referenciamos el objeto DataTable enlazado al control DataGridView.
            dttTabla = TryCast(dgvPresupuesto.DataSource, DataTable)
        Catch ex As Exception
            blnError = True
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        Finally
            If Not blnError Then
                GuardarPresupuesto = dttTabla
            Else
                GuardarPresupuesto = Nothing
            End If
        End Try
    End Function

    
End Class