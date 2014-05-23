Public Class frmListadoIncidencias
    Const mc_strNombre_Modulo As String = "frmListadoIncidencias"

    '<CABECERA>-----------------------------------------------
    'Descripcion..: Carga las incidencias en al DataGridView
    'Fecha........: 29/04/2014
    '<FIN CABECERA>-------------------------------------------
    Private Sub frmIncidencias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Const strNombre_Funcion As String = "frmArticulos_Load"
        Dim blnError As Boolean

        Try
            CargarIncidencias(dgvIncidencias)
            CargarFiltrosComboBox(cbxCampos, dgvIncidencias)
        Catch ex As Exception
            blnError = True
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    '<CABECERA>-----------------------------------------------
    'Descripcion..: Aplica el filtro a los resultados del DataGridView
    'Fecha........: 29/04/2014
    '<FIN CABECERA>-------------------------------------------
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        Const strNombre_Funcion As String = "frmArticulos_Load"
        Dim blnError As Boolean

        Dim objView As DataView
        Dim strFiltro As String

        Try
            strFiltro = Config_strGenerarFiltroDataGridView(txtCampo.Text, cbxCampos.SelectedItem)
            objView = dgvIncidencias.DataSource
            objView.RowFilter = strFiltro
            CargarIncidencias(dgvIncidencias, udtTipoDeCarga.SoloAjustar)
        Catch ex As Exception
            blnError = True
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Private Sub dgvIncidencias_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvIncidencias.CellDoubleClick

        Const strNombre_Funcion As String = "dgvFacturas_CellDoubleClick"
        Dim blnError As Boolean

        Dim blnResultado As Boolean

        Try
            blnResultado = frmFichaIncidencia.blnCargarIncidencia(dgvIncidencias.SelectedRows(0))
            If blnResultado Then
                frmFichaIncidencia.ShowDialog()
            End If
        Catch ex As Exception
            blnError = True
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    '<CABECERA>-----------------------------------------------
    'Descripcion..: Crea una nueva incidencia
    'Fecha........: 07/05/2014
    '<FIN CABECERA>-------------------------------------------
    Private Sub btnNueva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Const strNombre_Funcion As String = "btnNueva_Click"

        Dim blnResultado As Boolean

        Try
            blnResultado = frmFichaIncidencia.blnCargarIncidencia()
            If blnResultado Then
                frmFichaIncidencia.ShowDialog()
            End If
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    '<CABECERA>-----------------------------------------------
    'Descripcion..: Abre la incidencia para su edicion
    'Fecha........: 30/04/2014
    '<FIN CABECERA>-------------------------------------------
    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Const strNombre_Funcion As String = "frmArticulos_Load"

        Dim blnResultado As Boolean

        Try
            blnResultado = frmFichaIncidencia.blnCargarIncidencia(dgvIncidencias.SelectedRows(0))
            If blnResultado Then
                frmFichaIncidencia.ShowDialog()
            End If
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    
End Class
