﻿Public Class frmBusquedaClientes
    Const mc_strNombre_Modulo As String = "frmBusquedaClientes"

    Private m_objCliente As clsCliente

    '<CABECERA>-----------------------------------------------
    'Descripcion..: Carga las incidencias en al DataGridView
    'Fecha........: 29/04/2014
    '<FIN CABECERA>-------------------------------------------
    Private Sub frmBusquedaClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Const strNombre_Funcion As String = "frmBusquedaClientes_Load"
        Dim blnError As Boolean

        Try
            CargarClientes(dgvClientes)
            CargarFiltrosComboBox(cbxCampos, dgvClientes)
            cbxCampos.SelectedItem = objObtenerCampoCombo(gc_strLP_D_NomFiscal)

            If dgvClientes.Rows.Count > 0 Then
                dgvClientes.Rows(0).Selected = True
            End If
        Catch ex As Exception
            blnError = True
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    '<CABECERA>-----------------------------------------------
    'Descripcion..: Selecciona el campo de un combo
    'Fecha........: 11/06/2014
    '<FIN CABECERA>-------------------------------------------
    Private Function objObtenerCampoCombo(ByVal strColumna As String) As clsElementoCombo

        Const strNombre_Funcion As String = "objObtenerCampoCombo"
        Dim blnError As Boolean

        Dim objCampo As clsElementoCombo
        Dim objRetorno As New clsElementoCombo

        Try
            For Each objCampo In cbxCampos.Items
                If objCampo.Descripcion.Equals(strColumna) Then
                    objRetorno = objCampo
                End If
            Next
        Catch ex As Exception
            blnError = True
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        Finally
            If blnError Then
                objRetorno = Nothing
            End If
            objObtenerCampoCombo = objRetorno
        End Try
    End Function

    '<CABECERA>-----------------------------------------------
    'Descripcion..: Aplica el filtro a los resultados del DataGridView
    'Fecha........: 29/04/2014
    '<FIN CABECERA>-------------------------------------------
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        Const strNombre_Funcion As String = "frmArticulos_Load"
        
        Try
            AplicarFiltro
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Private Sub txtCampo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCampo.KeyDown

        Const strNombre_Funcion As String = "txtCampo_KeyDown"
        
        Try
            If e.KeyCode = Keys.Enter Then
                AplicarFiltro()
            End If
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Private Sub AplicarFiltro()

        Const strNombre_Funcion As String = "AplicarFiltro"
        Dim blnError As Boolean

        Dim objView As DataView
        Dim strFiltro As String

        Try
            strFiltro = Config_strGenerarFiltroDataGridView(txtCampo.Text, cbxCampos.SelectedItem)
            objView = dgvClientes.DataSource
            If Not objView Is Nothing Then
                objView.RowFilter = strFiltro
                CargarClientes(dgvClientes, udtTipoDeCarga.SoloAjustar)
            End If
        Catch ex As Exception
            blnError = True
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Private Sub dgvClientes_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvClientes.CellDoubleClick

        Const strNombre_Funcion As String = "dgvFacturas_CellDoubleClick"
        Dim blnError As Boolean

        Try
            m_objCliente = New clsCliente(dgvClientes.SelectedRows(0))
            Me.Close()
        Catch ex As Exception
            blnError = True
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    '<CABECERA>-----------------------------------------------
    'Descripcion..: Crea una nueva incidencia
    'Fecha........: 07/05/2014
    '<FIN CABECERA>-------------------------------------------
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        Const strNombre_Funcion As String = "btnAceptar_Click"

        Try
            m_objCliente = New clsCliente(dgvClientes.SelectedRows(0))
            Me.Close()
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    '<CABECERA>-----------------------------------------------
    'Descripcion..: Abre la incidencia para su edicion
    'Fecha........: 30/04/2014
    '<FIN CABECERA>-------------------------------------------
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Const strNombre_Funcion As String = "btnCancelar_Click"

        Try
            m_objCliente = Nothing
            Me.Close()
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Public ReadOnly Property Cliente
        Get
            Return m_objCliente
        End Get
    End Property

    

End Class