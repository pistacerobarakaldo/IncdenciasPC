Public Class frmHistorialIncidenciasCliente
    Const mc_strNombre_Modulo As String = "frmHistorialIncidenciasCliente"

    Public Function blnCargarHistorial(ByVal lngIdCliente As Long) As Boolean

        Const strNombre_Funcion As String = "blnCargarHistorial"
        Dim blnError As Boolean

        Dim strWhere As String

        Try
            strWhere = "WHERE " & gc_strDB_C_Cliente & " = " & lngIdCliente
            dgvHistorial.DataSource = Inci_dttObtenerIncidencias(, strWhere)
            ConfigurarDataGridView(dgvHistorial)
            AjustarColumnas()
        Catch ex As Exception
            blnError = True
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        Finally
            blnCargarHistorial = Not blnError
        End Try
    End Function

    Private Sub frmHistorialIncidenciasCliente_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged

        Const strNombre_Funcion As String = "frmHistorialIncidenciasCliente_VisibleChanged"

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
            dblAnchoDisponible = dgvHistorial.Width - gc_intAnchCabeFila_N

            'Ocultamos las filas que no deseamos que sean visualizadas
            dgvHistorial.Columns(gc_strLP_I_Incidencia).Visible = True
            dgvHistorial.Columns(gc_strLP_F_Entrada).Visible = True
            dgvHistorial.Columns(gc_strLP_C_Cliente).Visible = False
            dgvHistorial.Columns(gc_strLP_D_Cliente).Visible = False
            dgvHistorial.Columns(gc_strLP_D_Contacto).Visible = True
            dgvHistorial.Columns(gc_strLP_D_Telefono1).Visible = True
            dgvHistorial.Columns(gc_strLP_D_Telefono2).Visible = True
            dgvHistorial.Columns(gc_strDB_C_Tipo).Visible = False
            dgvHistorial.Columns(gc_strLP_C_Tipo).Visible = True
            dgvHistorial.Columns(gc_strLP_D_Marca).Visible = True
            dgvHistorial.Columns(gc_strLP_D_Modelo).Visible = True
            dgvHistorial.Columns(gc_strLP_D_NSerie).Visible = False
            dgvHistorial.Columns(gc_strLP_D_Obser).Visible = False
            dgvHistorial.Columns(gc_strLP_B_Maletin).Visible = False
            dgvHistorial.Columns(gc_strLP_B_Cargador).Visible = False
            dgvHistorial.Columns(gc_strLP_D_Averia).Visible = False
            dgvHistorial.Columns(gc_strLP_D_Resolucion).Visible = False
            dgvHistorial.Columns(gc_strLP_V_Importe).Visible = True
            dgvHistorial.Columns(gc_strDB_C_Estado).Visible = False
            dgvHistorial.Columns(gc_strLP_C_Estado).Visible = True
            dgvHistorial.Columns(gc_strLP_B_Garantia).Visible = True

            'Establecemos un ancho predefinido para cada columna
            dgvHistorial.Columns(gc_strLP_I_Incidencia).Width = dblAnchoDisponible * 0.08
            dblSumaTotal = dblSumaTotal + dgvHistorial.Columns(gc_strLP_I_Incidencia).Width
            dgvHistorial.Columns(gc_strLP_F_Entrada).Width = dblAnchoDisponible * 0.08
            dblSumaTotal = dblSumaTotal + dgvHistorial.Columns(gc_strLP_F_Entrada).Width
            dgvHistorial.Columns(gc_strLP_D_Contacto).Width = dblAnchoDisponible * 0.14
            dblSumaTotal = dblSumaTotal + dgvHistorial.Columns(gc_strLP_D_Contacto).Width
            dgvHistorial.Columns(gc_strLP_D_Telefono1).Width = dblAnchoDisponible * 0.08
            dblSumaTotal = dblSumaTotal + dgvHistorial.Columns(gc_strLP_D_Telefono1).Width
            dgvHistorial.Columns(gc_strLP_D_Telefono2).Width = dblAnchoDisponible * 0.08
            dblSumaTotal = dblSumaTotal + dgvHistorial.Columns(gc_strLP_D_Telefono2).Width
            dgvHistorial.Columns(gc_strLP_C_Tipo).Width = dblAnchoDisponible * 0.09
            dblSumaTotal = dblSumaTotal + dgvHistorial.Columns(gc_strLP_C_Tipo).Width
            dgvHistorial.Columns(gc_strLP_D_Marca).Width = dblAnchoDisponible * 0.09
            dblSumaTotal = dblSumaTotal + dgvHistorial.Columns(gc_strLP_D_Marca).Width
            dgvHistorial.Columns(gc_strLP_D_Modelo).Width = dblAnchoDisponible * 0.09
            dblSumaTotal = dblSumaTotal + dgvHistorial.Columns(gc_strLP_D_Modelo).Width
            dgvHistorial.Columns(gc_strLP_V_Importe).Width = dblAnchoDisponible * 0.08
            dblSumaTotal = dblSumaTotal + dgvHistorial.Columns(gc_strLP_V_Importe).Width
            dgvHistorial.Columns(gc_strLP_C_Estado).Width = dblAnchoDisponible * 0.13
            dblSumaTotal = dblSumaTotal + dgvHistorial.Columns(gc_strLP_C_Estado).Width
            dgvHistorial.Columns(gc_strLP_B_Garantia).Width = dblAnchoDisponible * 0.06
            dblSumaTotal = dblSumaTotal + dgvHistorial.Columns(gc_strLP_B_Garantia).Width
            If dblSumaTotal > dblAnchoDisponible Then
                dgvHistorial.Columns(gc_strLP_I_Incidencia).Width = dgvHistorial.Columns(gc_strLP_I_Incidencia).Width - (dblSumaTotal - dblAnchoDisponible)
            End If
            'Establecemos la alineacion da cada columna
            dgvHistorial.Columns(gc_strLP_I_Incidencia).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvHistorial.Columns(gc_strLP_F_Entrada).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvHistorial.Columns(gc_strLP_D_Contacto).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvHistorial.Columns(gc_strLP_D_Telefono1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvHistorial.Columns(gc_strLP_D_Telefono2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvHistorial.Columns(gc_strLP_C_Tipo).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvHistorial.Columns(gc_strLP_D_Marca).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvHistorial.Columns(gc_strLP_D_Modelo).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvHistorial.Columns(gc_strLP_V_Importe).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvHistorial.Columns(gc_strLP_V_Importe).DefaultCellStyle.Format = "0.00 €"
            dgvHistorial.Columns(gc_strLP_C_Estado).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvHistorial.Columns(gc_strLP_B_Garantia).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Catch ex As Exception
            blnError = True
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub
End Class