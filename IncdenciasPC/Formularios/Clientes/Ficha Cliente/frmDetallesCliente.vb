Public Class frmDetallesCliente
    Const mc_strNombre_Modulo As String = "frmDetallesCliente"

    Private m_dblPresupuesto As Double

    Public Function blnCargarCliente(ByVal objCliente As clsCliente) As Boolean

        Const strNombre_Funcion As String = "blnCargarCliente"
        Dim blnError As Boolean

        Try
            txtId.Text = IIf(objCliente.Id > 0, objCliente.Id, "")
            txtFechaAlta.Text = objCliente.FechaAlta
            txtNIF.Text = objCliente.NIF
            txtFechaModificacion.Text = objCliente.FechaModificacion
            txtNombreFiscal.Text = objCliente.NombreFiscal
            txtNombreComercial.Text = objCliente.NombreComercial
            txtDomicilio.Text = objCliente.Domicilio
            txtCP.Text = objCliente.CP
            txtPoblacion.Text = objCliente.Poblacion
            txtProvincia.Text = objCliente.Provincia
            txtPais.Text = objCliente.Pais
            txtContacto.Text = objCliente.Contacto
            txtTelefono.Text = objCliente.Telefono
            txtMovil.Text = objCliente.Movil
            txtFax.Text = objCliente.Fax
            txtMail.Text = objCliente.eMail
            txtObservaciones.Text = objCliente.Observaciones
        Catch ex As Exception
            blnError = True
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        Finally
            blnCargarCliente = Not blnError
        End Try
    End Function

    Private Sub LimpiarFormulario()

        Const strNombre_Funcion As String = "LimpiarFormulario"

        Try
            txtId.Text = ""
            txtFechaAlta.Text = ""
            txtNIF.Text = ""
            txtFechaModificacion.Text = ""
            txtNombreFiscal.Text = ""
            txtNombreComercial.Text = ""
            txtDomicilio.Text = ""
            txtCP.Text = ""
            txtPoblacion.Text = ""
            txtProvincia.Text = ""
            txtPais.Text = ""
            txtContacto.Text = ""
            txtTelefono.Text = ""
            txtMovil.Text = ""
            txtFax.Text = ""
            txtMail.Text = ""
            txtObservaciones.Text = ""
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    '<CABECERA>-----------------------------------------------
    'Descripcion......: Controla que el texto introducido sean solo numeros 
    'Fecha............: 22/05/2014
    '<FIN CABECERA>-------------------------------------------
    Private Sub Telefonos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefono.KeyPress, _
                                                                                                                      txtMovil.KeyPress, _
                                                                                                                      txtFax.KeyPress

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
    Private Sub Telefonos_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTelefono.Validated, _
                                                                                                 txtMovil.Validated, _
                                                                                                 txtFax.Validated

        Const strNombre_Funcion As String = "Telefonos_Validated"

        Dim lngNumero As Long
        Dim objTextBox As TextBox

        Try
            objTextBox = sender

            If objTextBox.Text <> "" Then
                Select Case objTextBox.Name
                    Case txtTelefono.Name
                        If txtTelefono.Text <> "" Then
                            lngNumero = CLng(txtTelefono.Text)
                            txtTelefono.Text = Format(lngNumero, "### ### ###")
                        End If
                    Case txtMovil.Name
                        If txtMovil.Text <> "" Then
                            lngNumero = CLng(txtMovil.Text)
                            txtMovil.Text = Format(lngNumero, "### ### ###")
                        End If
                    Case txtFax.Name
                        If txtFax.Text <> "" Then
                            lngNumero = CLng(txtFax.Text)
                            txtFax.Text = Format(lngNumero, "### ### ###")
                        End If
                End Select
            End If
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Private Sub txtNombreFiscal_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombreFiscal.Validated

        Const strNombre_Funcion As String = "txtNombreFiscal_Validated"

        Try
            If txtNombreComercial.Text = "" Then
                txtNombreComercial.Text = txtNombreFiscal.Text
            End If
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Public Function GuardarCliente(ByRef objCliente As clsCliente) As Boolean

        Const strNombre_Funcion As String = "GuardarIncidencia"
        Dim blnError As Boolean

        Try
            'Reasignamos los valores a la incidencia y la devolvemos al formulario para que la guarde
            objCliente.Id = IIf(txtId.Text <> "", txtId.Text, 0)
            objCliente.NIF = txtNIF.Text
            objCliente.NombreFiscal = txtNombreFiscal.Text
            objCliente.NombreComercial = txtNombreComercial.Text
            objCliente.Domicilio = txtDomicilio.Text
            objCliente.CP = txtCP.Text
            objCliente.Poblacion = txtPoblacion.Text
            objCliente.Provincia = txtProvincia.Text
            objCliente.Pais = txtPais.Text
            objCliente.Contacto = txtContacto.Text
            objCliente.Telefono = txtTelefono.Text
            objCliente.Movil = txtMovil.Text
            objCliente.Fax = txtFax.Text
            objCliente.eMail = txtMail.Text
            objCliente.Observaciones = txtObservaciones.Text
        Catch ex As Exception
            blnError = True
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        Finally
            GuardarCliente = Not blnError
        End Try
    End Function

    
End Class