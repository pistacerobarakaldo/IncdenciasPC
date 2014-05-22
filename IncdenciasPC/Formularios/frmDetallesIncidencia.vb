﻿Public Class frmDetallesIncidencia
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

        Const strNombre_Funcion As String = "LimpiarFormulario"

        Try
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
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    '<CABECERA>-----------------------------------------------
    'Descripcion......: Controla que el texto introducido sean solo numeros 
    'Fecha............: 22/05/2014
    '<FIN CABECERA>-------------------------------------------
    Private Sub Telefonos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefono1.KeyPress, _
                                                                                                                      txtTelefono2.KeyPress

        Const strNombre_Funcion As String = "Telefonos_KeyPress"
        
        Try
            'Comprueba si el caracter es un numero o la tecla de retroceso (borrar)
            If Not Char.IsNumber(e.KeyChar) And (e.KeyChar = ChrW(Keys.Back)) = False Then
                e.KeyChar = Chr(0)
            End If
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    '<CABECERA>-----------------------------------------------
    'Descripcion......: Establece el formato telefono
    'Fecha............: 22/05/2014
    '<FIN CABECERA>-------------------------------------------
    Private Sub Telefonos_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTelefono1.Validated, txtTelefono2.Validated

        Const strNombre_Funcion As String = "Telefonos_Validated"
        
        Dim lngNumero As Long
        Dim objTextBox As TextBox

        Try
            objTextBox = sender

            If objTextBox.Text <> "" Then
                Select Case objTextBox.Name
                    Case txtTelefono1.Name
                        lngNumero = CLng(txtTelefono1.Text)
                        txtTelefono1.Text = Format(lngNumero, "### ### ###")
                    Case txtTelefono2.Name
                        lngNumero = CLng(txtTelefono2.Text)
                        txtTelefono2.Text = Format(lngNumero, "### ### ###")
                End Select
            End If
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Public WriteOnly Property AnadirCliente As clsCliente
        Set(ByVal value As clsCliente)
            txtIdCliente.Text = value.Id
            txtNomCliente.Text = value.NombreFiscal
            txtContacto.Text = value.Contacto
            txtTelefono1.Text = value.Telefono
            txtTelefono2.Text = value.Movil
        End Set
    End Property

    Public ReadOnly Property ObtenerCliente As Long
        Get
            If txtIdCliente.Text <> "" Then
                Return CLng(txtIdCliente.Text)
            Else
                Return 0
            End If
        End Get
    End Property

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