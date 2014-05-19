Option Explicit On
Option Compare Text

Module modGestIncidencias

    'Constante que guarda el nombre del mudolu
    Const mc_strNombre_Modulo As String = "modGestIncidencias"

    '<CABECERA>-----------------------------------------------
    'Nombre...........: CargarIncidencias
    'Descripcion......: Carga las incidencias en el DataGridView
    'Fecha............: 26/03/2014
    'Autor............: Borja Escudero
    'Parametros.......: dgvTabla = DataGridView a cargar
    '                   lngTipoCarga = Variable que determina la forma en la que actua la funcion
    '<FIN CABECERA>-------------------------------------------
    Public Sub CargarIncidencias(ByRef dgvTabla As DataGridView, Optional ByVal lngTipoCarga As udtTipoDeCarga = udtTipoDeCarga.CargarAjustar)

        Const strNombre_Funcion As String = "CargarFacturasClientes"
        Dim lngError As Long
        Dim strError As String

        On Error GoTo TratarError

        Select Case lngTipoCarga
            Case udtTipoDeCarga.CargarAjustar
                dgvTabla.DataSource = Inci_dttObtenerIncidencias().DefaultView
                ConfigurarDataGridView(dgvTabla)
                Inci_AjustarColumnas(dgvTabla)
            Case udtTipoDeCarga.SoloCargar
                dgvTabla.DataSource = Inci_dttObtenerIncidencias().DefaultView
            Case udtTipoDeCarga.SoloAjustar
                ConfigurarDataGridView(dgvTabla)
                Inci_AjustarColumnas(dgvTabla)
        End Select

Terminar:

        'Anulamos el control de errores
        On Error GoTo 0
        Exit Sub

TratarError:

        'Guardamos el error
        lngError = Err.Number
        strError = Err.Description

        AddLog(lngError & " - " & strError, mc_strNombre_Modulo, strNombre_Funcion)

        Resume Terminar
    End Sub

    '<CABECERA>-----------------------------------------------
    'Descripcion......: Ajusta el ancho de las columnas para adaptarlo al tamaño del DataGridView
    'Fecha............: 29/04/2014
    '<FIN CABECERA>-------------------------------------------
    Public Sub Inci_AjustarColumnas(ByRef objDataGridView As DataGridView)

        Const strNombre_Funcion As String = "Inci_AjustarColumnas"
        Dim blnError As Boolean
        
        Dim dblAnchoDisponible As Double
        Dim dblSumaTotal As Double

        Try
            dblAnchoDisponible = objDataGridView.Width - gc_intAnchCabeFila_N

            'Ocultamos las filas que no deseamos que sean visualizadas
            objDataGridView.Columns(gc_strLP_I_Incidencia).Visible = True
            objDataGridView.Columns(gc_strLP_F_Entrada).Visible = True
            objDataGridView.Columns(gc_strLP_C_Cliente).Visible = True
            objDataGridView.Columns(gc_strLP_D_Cliente).Visible = True
            objDataGridView.Columns(gc_strLP_D_Contacto).Visible = True
            objDataGridView.Columns(gc_strLP_D_Telefono1).Visible = True
            objDataGridView.Columns(gc_strLP_D_Telefono2).Visible = True
            objDataGridView.Columns(gc_strDB_C_Tipo).Visible = False
            objDataGridView.Columns(gc_strLP_C_Tipo).Visible = True
            objDataGridView.Columns(gc_strLP_D_Marca).Visible = True
            objDataGridView.Columns(gc_strLP_D_Modelo).Visible = True
            objDataGridView.Columns(gc_strLP_D_NSerie).Visible = False
            objDataGridView.Columns(gc_strLP_D_Obser).Visible = False
            objDataGridView.Columns(gc_strLP_B_Maletin).Visible = False
            objDataGridView.Columns(gc_strLP_B_Cargador).Visible = False
            objDataGridView.Columns(gc_strLP_D_Averia).Visible = False
            objDataGridView.Columns(gc_strLP_D_Resolucion).Visible = False
            objDataGridView.Columns(gc_strLP_V_Importe).Visible = True
            objDataGridView.Columns(gc_strDB_C_Estado).Visible = False
            objDataGridView.Columns(gc_strLP_C_Estado).Visible = True
            objDataGridView.Columns(gc_strLP_B_Garantia).Visible = True

            'Establecemos un ancho predefinido para cada columna
            objDataGridView.Columns(gc_strLP_I_Incidencia).Width = dblAnchoDisponible * 0.08
            dblSumaTotal = dblSumaTotal + objDataGridView.Columns(gc_strLP_I_Incidencia).Width
            objDataGridView.Columns(gc_strLP_F_Entrada).Width = dblAnchoDisponible * 0.06
            dblSumaTotal = dblSumaTotal + objDataGridView.Columns(gc_strLP_F_Entrada).Width
            objDataGridView.Columns(gc_strLP_C_Cliente).Width = dblAnchoDisponible * 0.07
            dblSumaTotal = dblSumaTotal + objDataGridView.Columns(gc_strLP_C_Cliente).Width
            objDataGridView.Columns(gc_strLP_D_Cliente).Width = dblAnchoDisponible * 0.2
            dblSumaTotal = dblSumaTotal + objDataGridView.Columns(gc_strLP_D_Cliente).Width
            objDataGridView.Columns(gc_strLP_D_Contacto).Width = dblAnchoDisponible * 0.1
            dblSumaTotal = dblSumaTotal + objDataGridView.Columns(gc_strLP_D_Contacto).Width
            objDataGridView.Columns(gc_strLP_D_Telefono1).Width = dblAnchoDisponible * 0.06
            dblSumaTotal = dblSumaTotal + objDataGridView.Columns(gc_strLP_D_Telefono1).Width
            objDataGridView.Columns(gc_strLP_D_Telefono2).Width = dblAnchoDisponible * 0.06
            dblSumaTotal = dblSumaTotal + objDataGridView.Columns(gc_strLP_D_Telefono2).Width
            objDataGridView.Columns(gc_strLP_C_Tipo).Width = dblAnchoDisponible * 0.07
            dblSumaTotal = dblSumaTotal + objDataGridView.Columns(gc_strLP_C_Tipo).Width
            objDataGridView.Columns(gc_strLP_D_Marca).Width = dblAnchoDisponible * 0.06
            dblSumaTotal = dblSumaTotal + objDataGridView.Columns(gc_strLP_D_Marca).Width
            objDataGridView.Columns(gc_strLP_D_Modelo).Width = dblAnchoDisponible * 0.06
            dblSumaTotal = dblSumaTotal + objDataGridView.Columns(gc_strLP_D_Modelo).Width
            objDataGridView.Columns(gc_strLP_V_Importe).Width = dblAnchoDisponible * 0.06
            dblSumaTotal = dblSumaTotal + objDataGridView.Columns(gc_strLP_V_Importe).Width
            objDataGridView.Columns(gc_strLP_C_Estado).Width = dblAnchoDisponible * 0.06
            dblSumaTotal = dblSumaTotal + objDataGridView.Columns(gc_strLP_C_Estado).Width
            objDataGridView.Columns(gc_strLP_B_Garantia).Width = dblAnchoDisponible * 0.06
            dblSumaTotal = dblSumaTotal + objDataGridView.Columns(gc_strLP_B_Garantia).Width
            If dblSumaTotal > dblAnchoDisponible Then
                objDataGridView.Columns(gc_strLP_I_Incidencia).Width = objDataGridView.Columns(gc_strLP_I_Incidencia).Width - (dblSumaTotal - dblAnchoDisponible)
            End If
            'Establecemos la alineacion da cada columna
            objDataGridView.Columns(gc_strLP_I_Incidencia).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            objDataGridView.Columns(gc_strLP_F_Entrada).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            objDataGridView.Columns(gc_strLP_C_Cliente).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            objDataGridView.Columns(gc_strLP_D_Cliente).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            objDataGridView.Columns(gc_strLP_D_Contacto).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            objDataGridView.Columns(gc_strLP_D_Telefono1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            objDataGridView.Columns(gc_strLP_D_Telefono2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            objDataGridView.Columns(gc_strLP_C_Tipo).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            objDataGridView.Columns(gc_strLP_D_Marca).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            objDataGridView.Columns(gc_strLP_D_Modelo).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            objDataGridView.Columns(gc_strLP_V_Importe).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            objDataGridView.Columns(gc_strLP_V_Importe).DefaultCellStyle.Format = "0.00 €"
            objDataGridView.Columns(gc_strLP_C_Estado).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            objDataGridView.Columns(gc_strLP_B_Garantia).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Catch ex As Exception
            blnError = True
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

End Module

