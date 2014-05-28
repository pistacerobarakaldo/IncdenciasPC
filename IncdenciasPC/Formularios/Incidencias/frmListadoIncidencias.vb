Public Class frmListadoIncidencias
    Const mc_strNombre_Modulo As String = "frmListadoIncidencias"

    '<CABECERA>-----------------------------------------------
    'Descripcion..: Carga las incidencias en al DataGridView
    'Fecha........: 29/04/2014
    '<FIN CABECERA>-------------------------------------------
    Private Sub frmIncidencias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Const strNombre_Funcion As String = "frmIncidencias_Load"
        Dim blnError As Boolean

        Try
            CargarIncidencias(dgvIncidencias)
        Catch ex As Exception
            blnError = True
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    '<CABECERA>-----------------------------------------------
    'Descripcion..: Aplica el filtro a los resultados del DataGridView
    'Fecha........: 29/04/2014
    '<FIN CABECERA>-------------------------------------------
    Public Sub AplicarFiltro(ByVal strFiltro As String)

        Const strNombre_Funcion As String = "AplicarFiltro"
        Dim blnError As Boolean

        Dim objView As DataView
        
        Try
            objView = dgvIncidencias.DataSource
            objView.RowFilter = strFiltro
            CargarIncidencias(dgvIncidencias, udtTipoDeCarga.SoloAjustar)
        Catch ex As Exception
            blnError = True
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    '<CABECERA>-----------------------------------------------
    'Descripcion..: Actualiza los datos del DataGridView y aplica el filtro a los resultados 
    'Fecha........: 28/05/2014
    '<FIN CABECERA>-------------------------------------------
    Public Sub Actualizar(ByVal strFiltro As String)

        Const strNombre_Funcion As String = "Actualizar"
        Dim blnError As Boolean

        Dim objView As DataView

        Try
            CargarIncidencias(dgvIncidencias, udtTipoDeCarga.CargarAjustar)
            objView = dgvIncidencias.DataSource
            objView.RowFilter = strFiltro
        Catch ex As Exception
            blnError = True
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    '<CABECERA>-----------------------------------------------
    'Descripcion..: Actualiza los datos del DataGridView y aplica el filtro a los resultados 
    'Fecha........: 28/05/2014
    '<FIN CABECERA>-------------------------------------------
    Public Sub Ajustar()

        Const strNombre_Funcion As String = "Ajustar"
        Dim blnError As Boolean

        Try
            CargarIncidencias(dgvIncidencias, udtTipoDeCarga.SoloAjustar)
        Catch ex As Exception
            blnError = True
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Private Sub dgvIncidencias_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

        Const strNombre_Funcion As String = "dgvFacturas_CellDoubleClick"
        Dim blnError As Boolean

        Dim blnResultado As Boolean

        Try
            blnResultado = frmFichaIncidencia.blnCargarIncidencia(dgvIncidencias.SelectedRows(0))
            If blnResultado Then
                frmFichaIncidencia.ShowDialog()
                Actualizar(frmPrincipal.FiltroIncidencias)
            End If
        Catch ex As Exception
            blnError = True
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Public ReadOnly Property LineaSeleccionada As DataGridViewRow
        Get
            Return dgvIncidencias.SelectedRows(0)
        End Get
    End Property

    Public ReadOnly Property DataGridIncidencias As DataGridView
        Get
            Return dgvIncidencias
        End Get
    End Property

    Private Sub dgvIncidencias_RowStateChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowStateChangedEventArgs)

        Const strNombre_Funcion As String = "dgvIncidencias_RowStateChanged"

        Try
            txtAveria.Text = dgvIncidencias.SelectedRows(0).Cells(gc_strLP_D_Averia).Value
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

End Class
