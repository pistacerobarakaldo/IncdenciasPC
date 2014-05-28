Option Explicit On
Option Compare Text

Module modGestClientes

    'Constante que guarda el nombre del mudolu
    Const mc_strNombre_Modulo As String = "modGestClientes"

    '<CABECERA>-----------------------------------------------
    'Nombre...........: CargarIncidencias
    'Descripcion......: Carga las incidencias en el DataGridView
    'Fecha............: 26/03/2014
    'Autor............: Borja Escudero
    'Parametros.......: dgvTabla = DataGridView a cargar
    '                   lngTipoCarga = Variable que determina la forma en la que actua la funcion
    '<FIN CABECERA>-------------------------------------------
    Public Sub CargarClientes(ByRef dgvTabla As DataGridView, Optional ByVal lngTipoCarga As udtTipoDeCarga = udtTipoDeCarga.CargarAjustar)

        Const strNombre_Funcion As String = "CargarFacturasClientes"
        Dim lngError As Long
        Dim strError As String

        On Error GoTo TratarError

        Select Case lngTipoCarga
            Case udtTipoDeCarga.CargarAjustar
                dgvTabla.DataSource = Clie_dttObtenerClientes().DefaultView
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
            objDataGridView.Columns(gc_strLP_I_Cliente).Visible = True
            objDataGridView.Columns(gc_strLP_D_NIFCliente).Visible = True
            objDataGridView.Columns(gc_strLP_D_NomFiscal).Visible = True
            objDataGridView.Columns(gc_strLP_D_NomCliente).Visible = True
            objDataGridView.Columns(gc_strLP_D_Telefono).Visible = True
            objDataGridView.Columns(gc_strLP_D_Movil).Visible = True
            objDataGridView.Columns(gc_strLP_D_ContCliente).Visible = True
            objDataGridView.Columns(gc_strLP_D_DomCliente).Visible = True
            objDataGridView.Columns(gc_strLP_D_PobCliente).Visible = True
            objDataGridView.Columns(gc_strLP_D_CPCliente).Visible = False
            objDataGridView.Columns(gc_strLP_D_PorvCliente).Visible = False
            objDataGridView.Columns(gc_strLP_D_Pais).Visible = False
            objDataGridView.Columns(gc_strLP_D_Fax).Visible = False
            objDataGridView.Columns(gc_strLP_D_Email).Visible = False
            objDataGridView.Columns(gc_strLP_D_Observ).Visible = False
            objDataGridView.Columns(gc_strLP_F_Alta).Visible = False
            objDataGridView.Columns(gc_strLP_F_Modif).Visible = False
            objDataGridView.Columns(gc_strDB_D_FormaPago).Visible = False
            objDataGridView.Columns(gc_strDB_V_Tarifa).Visible = False
            objDataGridView.Columns(gc_strDB_V_TipoDoc).Visible = False

            'Establecemos un ancho predefinido para cada columna
            objDataGridView.Columns(gc_strLP_I_Cliente).Width = dblAnchoDisponible * 0.07
            dblSumaTotal = dblSumaTotal + objDataGridView.Columns(gc_strLP_I_Cliente).Width
            objDataGridView.Columns(gc_strLP_D_NIFCliente).Width = dblAnchoDisponible * 0.07
            dblSumaTotal = dblSumaTotal + objDataGridView.Columns(gc_strLP_D_NIFCliente).Width
            objDataGridView.Columns(gc_strLP_D_NomFiscal).Width = dblAnchoDisponible * 0.18
            dblSumaTotal = dblSumaTotal + objDataGridView.Columns(gc_strLP_D_NomFiscal).Width
            objDataGridView.Columns(gc_strLP_D_NomCliente).Width = dblAnchoDisponible * 0.18
            dblSumaTotal = dblSumaTotal + objDataGridView.Columns(gc_strLP_D_NomCliente).Width
            objDataGridView.Columns(gc_strLP_D_Telefono).Width = dblAnchoDisponible * 0.07
            dblSumaTotal = dblSumaTotal + objDataGridView.Columns(gc_strLP_D_Telefono).Width
            objDataGridView.Columns(gc_strLP_D_Movil).Width = dblAnchoDisponible * 0.07
            dblSumaTotal = dblSumaTotal + objDataGridView.Columns(gc_strLP_D_Movil).Width
            objDataGridView.Columns(gc_strLP_D_ContCliente).Width = dblAnchoDisponible * 0.1
            dblSumaTotal = dblSumaTotal + objDataGridView.Columns(gc_strLP_D_ContCliente).Width
            objDataGridView.Columns(gc_strLP_D_DomCliente).Width = dblAnchoDisponible * 0.16
            dblSumaTotal = dblSumaTotal + objDataGridView.Columns(gc_strLP_D_DomCliente).Width
            objDataGridView.Columns(gc_strLP_D_PobCliente).Width = dblAnchoDisponible * 0.1
            dblSumaTotal = dblSumaTotal + objDataGridView.Columns(gc_strLP_D_PobCliente).Width
            If dblSumaTotal > dblAnchoDisponible Then
                objDataGridView.Columns(gc_strLP_I_Cliente).Width = objDataGridView.Columns(gc_strLP_I_Cliente).Width - (dblSumaTotal - dblAnchoDisponible)
            End If
            'Establecemos la alineacion da cada columna
            objDataGridView.Columns(gc_strLP_I_Cliente).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            objDataGridView.Columns(gc_strLP_D_NIFCliente).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            objDataGridView.Columns(gc_strLP_D_NomFiscal).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            objDataGridView.Columns(gc_strLP_D_NomCliente).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            objDataGridView.Columns(gc_strLP_D_Telefono).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            objDataGridView.Columns(gc_strLP_D_Movil).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            objDataGridView.Columns(gc_strLP_D_ContCliente).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            objDataGridView.Columns(gc_strLP_D_DomCliente).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            objDataGridView.Columns(gc_strLP_D_PobCliente).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Catch ex As Exception
            blnError = True
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

End Module

