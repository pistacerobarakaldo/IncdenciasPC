Public Class frmEdicionLineaHistorial
    Const mc_strNombre_Modulo As String = "frmEdicionLineaHistorial"

    Private m_blnAceptado As Boolean

    Public Function blnCargarLinea(ByVal dgvRow As DataGridViewRow) As Boolean

        Const strNombre_Funcion As String = "blnCargarLinea"
        Dim blnError As Boolean

        Try
            'Cargar Combobox
            ConfigurarComboBox(cbxEstado, Inci_dttObtenerEstados(), gc_strDB_I_Estado, gc_strDB_D_Estado)

            lblLinea.Text = dgvRow.Cells(gc_strLP_C_Linea).Value
            lblFecha.Text = dgvRow.Cells(gc_strLP_F_Fecha).Value
            cbxEstado.SelectedValue = dgvRow.Cells(gc_strDB_C_Estado).Value
            txtDescripcion.Text = dgvRow.Cells(gc_strLP_D_Descripcion).Value
        Catch ex As Exception
            blnError = True
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        Finally
            blnCargarLinea = Not blnError
        End Try
    End Function

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        Const strNombre_Funcion As String = "btnAceptar_Click"
        
        Try
            m_blnAceptado = True
            Me.Close()
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub


    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Const strNombre_Funcion As String = "btnCancelar_Click"

        Try
            m_blnAceptado = False
            Me.Close()
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Public Function blnAceptado(ByRef lngEstado As Long, ByRef strEstado As String, ByRef strDescripcion As String) As Boolean

        Const strNombre_Funcion As String = "btnCancelar_Click"
        Dim blnError As Boolean

        Try
            If m_blnAceptado Then
                lngEstado = cbxEstado.SelectedValue
                strEstado = cbxEstado.Text
                strDescripcion = txtDescripcion.Text
            End If
        Catch ex As Exception
            blnError = True
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        Finally
            If blnError Then
                m_blnAceptado = False
            End If
            blnAceptado = m_blnAceptado
        End Try
    End Function
End Class