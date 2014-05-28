Public Class frmListadoClientes

    Const mc_strNombre_Modulo As String = "frmListadoClientes"

    '<CABECERA>-----------------------------------------------
    'Descripcion..: Carga las incidencias en al DataGridView
    'Fecha........: 29/04/2014
    '<FIN CABECERA>-------------------------------------------
    Private Sub frmListadoClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Const strNombre_Funcion As String = "frmIncidencias_Load"
        Dim blnError As Boolean

        Try
            CargarClientes(dgvClientes)
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
            objView = dgvClientes.DataSource
            objView.RowFilter = strFiltro
            CargarClientes(dgvClientes, udtTipoDeCarga.SoloAjustar)
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
            CargarClientes(dgvClientes, udtTipoDeCarga.CargarAjustar)
            objView = dgvClientes.DataSource
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
            CargarClientes(dgvClientes, udtTipoDeCarga.SoloAjustar)
        Catch ex As Exception
            blnError = True
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Public Sub dgvClientes_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvClientes.CellDoubleClick

        Const strNombre_Funcion As String = "dgvClientes_CellDoubleClick"
        Dim blnError As Boolean

        Dim blnResultado As Boolean
        Dim objCliente As clsCliente

        Try
            objCliente = New clsCliente(dgvClientes.SelectedRows(0))
            blnResultado = frmFichaCliente.blnCargarCliente(objCliente)
            If blnResultado Then
                frmFichaCliente.ShowDialog()
                Actualizar(frmPrincipal.FiltroClientes)
            End If
        Catch ex As Exception
            blnError = True
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Public ReadOnly Property LineaSeleccionada As DataGridViewRow
        Get
            Return dgvClientes.SelectedRows(0)
        End Get
    End Property

    Public ReadOnly Property DataGridClientes As DataGridView
        Get
            Return dgvClientes
        End Get
    End Property

End Class
