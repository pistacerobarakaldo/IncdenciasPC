Public Class frmDetallesIncidencia
    Const mc_strNombre_Modulo As String = "frmDetallesIncidencia"

    Private m_dblPresupuesto As Double

    Public Function blnCargarDetalles(ByVal objIncidencia As clsIncidencia) As Boolean

        Const strNombre_Funcion As String = "blnCargarDetalles"
        Dim blnError As Boolean

        Try
            ConfigurarComboBox(cbxEstado, Inci_dttObtenerEstados(), gc_strDB_I_Estado, gc_strDB_D_Estado)
            ConfigurarComboBox(cbxTipoEquipo, Inci_dttObtenerTiposEquipo(), gc_strDB_I_TipoEquipo, gc_strDB_D_TipoEquipo)

            txtIncidencia.Text = IIf(objIncidencia.Id > 0, objIncidencia.Id, "")
            txtIdCliente.Text = objIncidencia.IdCliente
            txtNomCliente.Text = objIncidencia.Cliente
            dtpFecha.Value = objIncidencia.Fecha
            cbxEstado.SelectedValue = objIncidencia.Estado
            txtContacto.Text = objIncidencia.Contacto
            txtTelefono1.Text = objIncidencia.Telefono1
            txtTelefono2.Text = objIncidencia.Telefono2
            cbxTipoEquipo.SelectedValue = objIncidencia.TipoEquipo
            txtNSerie.Text = objIncidencia.NumeroSerie
            chbMaletin.Checked = objIncidencia.Maletin
            chbCargador.Checked = objIncidencia.Cargador
            txtMarca.Text = objIncidencia.Marca
            txtModelo.Text = objIncidencia.Modelo
            txtObservaciones.Text = objIncidencia.Observaciones
            chbGarantia.Checked = objIncidencia.Garantia
            txtAveria.Text = objIncidencia.Averia
            txtResolucion.Text = objIncidencia.Resolucion
        Catch ex As Exception
            blnError = True
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        Finally
            blnCargarDetalles = Not blnError
        End Try
    End Function

    Private Sub LimpiarFormulario()
        txtIncidencia.Text = ""
        txtIdCliente.Text = ""
        txtNomCliente.Text = ""
        dtpFecha.Value = Date.Today
        cbxEstado.SelectedValue = 1
        txtContacto.Text = ""
        txtTelefono1.Text = ""
        txtTelefono2.Text = ""
        cbxTipoEquipo.SelectedValue = 0
        txtNSerie.Text = ""
        chbMaletin.Checked = False
        chbCargador.Checked = False
        txtMarca.Text = ""
        txtModelo.Text = ""
        txtObservaciones.Text = ""
        chbGarantia.Checked = False
        txtAveria.Text = ""
        txtResolucion.Text = ""
    End Sub

    Public Function GuardarIncidencia(ByRef objIncidencia As clsIncidencia) As Boolean

        Const strNombre_Funcion As String = "GuardarIncidencia"
        Dim blnError As Boolean

        Try
            'Reasignamos los valores a la incidencia y la devolvemos al formulario para que la guarde
            objIncidencia.IdCliente = txtIdCliente.Text
            objIncidencia.Cliente = txtNomCliente.Text
            objIncidencia.Fecha = dtpFecha.Value
            objIncidencia.Estado = cbxEstado.SelectedValue
            objIncidencia.Contacto = txtContacto.Text
            objIncidencia.Telefono1 = txtTelefono1.Text
            objIncidencia.Telefono2 = txtTelefono2.Text
            objIncidencia.TipoEquipo = cbxTipoEquipo.SelectedValue
            objIncidencia.NumeroSerie = txtNSerie.Text
            objIncidencia.Maletin = chbMaletin.Checked
            objIncidencia.Cargador = chbCargador.Checked
            objIncidencia.Marca = txtMarca.Text
            objIncidencia.Modelo = txtModelo.Text
            objIncidencia.Observaciones = txtObservaciones.Text
            objIncidencia.Garantia = chbGarantia.Checked
            objIncidencia.Importe = m_dblPresupuesto
            objIncidencia.Averia = txtAveria.Text
            objIncidencia.Resolucion = txtResolucion.Text
        Catch ex As Exception
            blnError = True
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        Finally
            GuardarIncidencia = Not blnError
        End Try
    End Function

    Public Property Presupuesto As Double
        Get
            Presupuesto = m_dblPresupuesto
        End Get
        Set(ByVal value As Double)
            m_dblPresupuesto = value
        End Set
    End Property
End Class