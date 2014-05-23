Public Class frmHistorialActuacion
    Const mc_strNombre_Modulo As String = "frmHistorialActuacion"

    Private m_lngIdIncidencia As Long

    Public Function blnCargarHistorial(ByVal objIncidencia As clsIncidencia) As Boolean

        Const strNombre_Funcion As String = "blnCargarDetalles"
        Dim blnError As Boolean

        Try
            m_lngIdIncidencia = objIncidencia.Id
            dgvHistorial.DataSource = objIncidencia.Historial
            ConfigurarDataGridView(dgvHistorial)
            AjustarColumnas()
        Catch ex As Exception
            blnError = True
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        Finally
            blnCargarHistorial = Not blnError
        End Try
    End Function

    Private Sub frmLineasPresupuesto_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged

        Const strNombre_Funcion As String = "frmLineasPresupuesto_VisibleChanged"

        Try
            If Me.Visible Then
                ConfigurarDataGridView(dgvHistorial)
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
        Dim blnError As Boolean

        Dim dblAnchoDisponible As Double
        Dim dblSumaTotal As Double

        Try
            dblAnchoDisponible = dgvHistorial.Width - gc_intAnchCabeFila_N - 7

            'Ocultamos las filas que no deseamos que sean visualizadas
            dgvHistorial.Columns(gc_strLP_C_Incidencia).Visible = False
            dgvHistorial.Columns(gc_strLP_C_Linea).Visible = True
            dgvHistorial.Columns(gc_strDB_C_Estado).Visible = False
            dgvHistorial.Columns(gc_strLP_C_Estado).Visible = True
            dgvHistorial.Columns(gc_strLP_F_Fecha).Visible = True
            dgvHistorial.Columns(gc_strLP_D_Descripcion).Visible = True
            
            'Establecemos un ancho predefinido para cada columna
            dgvHistorial.Columns(gc_strLP_C_Linea).Width = dblAnchoDisponible * 0.14
            dblSumaTotal = dblSumaTotal + dgvHistorial.Columns(gc_strLP_C_Linea).Width
            dgvHistorial.Columns(gc_strLP_C_Estado).Width = dblAnchoDisponible * 0.13
            dblSumaTotal = dblSumaTotal + dgvHistorial.Columns(gc_strLP_C_Estado).Width
            dgvHistorial.Columns(gc_strLP_F_Fecha).Width = dblAnchoDisponible * 0.13
            dblSumaTotal = dblSumaTotal + dgvHistorial.Columns(gc_strLP_F_Fecha).Width
            dgvHistorial.Columns(gc_strLP_D_Descripcion).Width = dblAnchoDisponible * 0.6
            dblSumaTotal = dblSumaTotal + dgvHistorial.Columns(gc_strLP_D_Descripcion).Width
            If dblSumaTotal > dblAnchoDisponible Then
                dgvHistorial.Columns(gc_strLP_C_Linea).Width = dgvHistorial.Columns(gc_strLP_C_Linea).Width - (dblSumaTotal - dblAnchoDisponible)
            End If
            'Establecemos la alineacion da cada columna
            dgvHistorial.Columns(gc_strLP_C_Linea).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvHistorial.Columns(gc_strLP_C_Estado).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvHistorial.Columns(gc_strLP_F_Fecha).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvHistorial.Columns(gc_strLP_D_Descripcion).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Catch ex As Exception
            blnError = True
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
            dttTabla = TryCast(dgvHistorial.DataSource, DataTable)

            'Añadimos una nueva fila
            dttTabla.Rows.Add()
            intFila = dgvHistorial.Rows.Count - 1
            dgvHistorial.Rows(intFila).Cells(gc_strLP_C_Incidencia).Value = m_lngIdIncidencia
            dgvHistorial.Rows(intFila).Cells(gc_strLP_C_Linea).Value = dgvHistorial.Rows.Count
            dgvHistorial.Rows(intFila).Cells(gc_strDB_C_Estado).Value = 1
            dgvHistorial.Rows(intFila).Cells(gc_strLP_C_Estado).Value = ObtenerEstado(1)
            dgvHistorial.Rows(intFila).Cells(gc_strLP_F_Fecha).Value = Date.Today
            dgvHistorial.Rows(intFila).Cells(gc_strLP_D_Descripcion).Value = ""

            'Reajustamos las columnas del DataGridView
            ConfigurarDataGridView(dgvHistorial)
            AjustarColumnas()
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
            dttTabla = TryCast(dgvHistorial.DataSource, DataTable)

            'Añadimos una nueva fila
            dttTabla.Rows.Add()
            intFila = dgvHistorial.Rows.Count - 1
            dgvHistorial.Rows(intFila).Cells(gc_strLP_C_Incidencia).Value = m_lngIdIncidencia
            dgvHistorial.Rows(intFila).Cells(gc_strLP_C_Linea).Value = dgvHistorial.Rows.Count
            dgvHistorial.Rows(intFila).Cells(gc_strDB_C_Estado).Value = dgvHistorial.Rows(dgvHistorial.SelectedRows(0).Index).Cells(gc_strDB_C_Estado).Value
            dgvHistorial.Rows(intFila).Cells(gc_strLP_C_Estado).Value = dgvHistorial.Rows(dgvHistorial.SelectedRows(0).Index).Cells(gc_strLP_C_Estado).Value
            dgvHistorial.Rows(intFila).Cells(gc_strLP_F_Fecha).Value = dgvHistorial.Rows(dgvHistorial.SelectedRows(0).Index).Cells(gc_strLP_F_Fecha).Value
            dgvHistorial.Rows(intFila).Cells(gc_strLP_D_Descripcion).Value = dgvHistorial.Rows(dgvHistorial.SelectedRows(0).Index).Cells(gc_strLP_D_Descripcion).Value

            'Reajustamos las columnas del DataGridView
            ConfigurarDataGridView(dgvHistorial)
            AjustarColumnas()
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    '<CABECERA>-----------------------------------------------
    'Descripcion......: Modificar una linea del DataGridView
    'Fecha............: 06/05/2014
    '<FIN CABECERA>-------------------------------------------
    Public Sub ModificarLinea()

        Const strNombre_Funcion As String = "ModificarLinea"

        Dim lngX As Long
        Dim lngY As Long
        Dim objRectangulo As Rectangle
        Dim lngEstado As Long
        Dim strEstado As String = ""
        Dim strDescripcion As String = ""

        Try
            objRectangulo = dgvHistorial.GetCellDisplayRectangle(dgvHistorial.SelectedRows(0).Cells(1).ColumnIndex, dgvHistorial.SelectedRows(0).Index, False)

            lngX = Me.PointToScreen(objRectangulo.Location).X
            lngY = Me.PointToScreen(objRectangulo.Location).Y

            frmEdicionLineaHistorial.Location = New Point(lngX, lngY)
            frmEdicionLineaHistorial.blnCargarLinea(dgvHistorial.SelectedRows(0))
            frmEdicionLineaHistorial.ShowDialog()
            If frmEdicionLineaHistorial.blnAceptado(lngEstado, strEstado, strDescripcion) Then
                dgvHistorial.SelectedRows(0).Cells(gc_strDB_C_Estado).Value = lngEstado
                dgvHistorial.SelectedRows(0).Cells(gc_strLP_C_Estado).Value = strEstado
                dgvHistorial.SelectedRows(0).Cells(gc_strLP_D_Descripcion).Value = strDescripcion
            End If

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
            dttTabla = TryCast(dgvHistorial.DataSource, DataTable)

            'Añadimos una nueva fila
            dttTabla.Rows(dgvHistorial.SelectedRows(0).Index).Delete()

            'Reajustamos las columnas del DataGridView
            ConfigurarDataGridView(dgvHistorial)
            AjustarColumnas()
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    '<CABECERA>-----------------------------------------------
    'Descripcion......: Elimina una linea del DataGridView
    'Fecha............: 06/05/2014
    '<FIN CABECERA>-------------------------------------------
    Public Sub NuevoEvento(ByVal lngEstado As Long, ByVal strDescripcion As String)

        Const strNombre_Funcion As String = "NuevoEvento"

        Dim dttTabla As DataTable
        Dim intFila As Integer

        Try
            'Referenciamos el objeto DataTable enlazado al control DataGridView.
            dttTabla = TryCast(dgvHistorial.DataSource, DataTable)

            'Añadimos una nueva fila
            dttTabla.Rows.Add()
            intFila = dgvHistorial.Rows.Count - 1
            dgvHistorial.Rows(intFila).Cells(gc_strLP_C_Incidencia).Value = m_lngIdIncidencia
            dgvHistorial.Rows(intFila).Cells(gc_strLP_C_Linea).Value = dgvHistorial.Rows.Count
            dgvHistorial.Rows(intFila).Cells(gc_strDB_C_Estado).Value = lngEstado
            dgvHistorial.Rows(intFila).Cells(gc_strLP_C_Estado).Value = ObtenerEstado(lngEstado)
            dgvHistorial.Rows(intFila).Cells(gc_strLP_F_Fecha).Value = Date.Today
            dgvHistorial.Rows(intFila).Cells(gc_strLP_D_Descripcion).Value = strDescripcion

            'Reajustamos las columnas del DataGridView
            ConfigurarDataGridView(dgvHistorial)
            AjustarColumnas()
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    '<CABECERA>-----------------------------------------------
    'Descripcion......: Devuelve la tabla actual 
    'Fecha............: 06/05/2014
    '<FIN CABECERA>-------------------------------------------
    Public Function GuardarHistorial() As DataTable

        Const strNombre_Funcion As String = "GuardarHistorial"
        Dim blnError As Boolean

        Dim dttTabla As DataTable = Nothing

        Try
            'Referenciamos el objeto DataTable enlazado al control DataGridView.
            dttTabla = TryCast(dgvHistorial.DataSource, DataTable)
        Catch ex As Exception
            blnError = True
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        Finally
            If Not blnError Then
                GuardarHistorial = dttTabla
            Else
                GuardarHistorial = Nothing
            End If
        End Try
    End Function
End Class