
Public Class frmPrincipal
    Const mc_strNombre_Modulo As String = "frmPrincipal"

    Enum ActualForm
        Detalles
        Historial
        Presupuesto
    End Enum

    Private Sub frmIncidencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Const strNombre_Funcion As String = "frmIncidencia_Load"

        Try
            CargarAplicacion()
            frmListadoIncidencias.WindowState = FormWindowState.Minimized
            frmListadoIncidencias.WindowState = FormWindowState.Maximized
            frmListadoIncidencias.Ajustar()
            HabilitarBotonesIncidencias()
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Private Sub CargarAplicacion()

        Const strNombre_Funcion As String = "CargarAplicacion"

        Try
            'CARGAR ARCHIVO DE CONFIGURACION
            CargarConfiguracionINI()
            EstablecerFiltrosEstados()
            If ComprobarDatosAplicacion() Then
                CargarFormularios()
            Else
                MsgBox("Alguna de las bases de datos seleccionada no es correcta. Por favor revise su configuración", MsgBoxStyle.Exclamation + vbOKOnly, "Error de acceso")
                CargarFormularioConfiguracion()
            End If
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Private Sub CargarFormularios()

        Const strNombre_Funcion As String = "CargarFormularios"

        Try
            frmListadoClientes.MdiParent = Me
            frmListadoClientes.Show()
            CargarFiltrosToolStripComboBox(cbxCamposC, frmListadoClientes.DataGridClientes)
            frmListadoClientes.Ajustar()

            frmListadoIncidencias.MdiParent = Me
            frmListadoIncidencias.Show()
            CargarFiltrosToolStripComboBox(cbxCamposI, frmListadoIncidencias.DataGridIncidencias)
            frmListadoIncidencias.Ajustar()
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Private Sub HabilitarBotonesIncidencias()

        Const strNombre_Funcion As String = "HabilitarBotonesIncidencias"

        Try
            If frmListadoIncidencias.DataGridIncidencias.Rows.Count > 0 Then
                frmListadoIncidencias.DataGridIncidencias.Rows(0).Selected = True
                btnModificarI.Enabled = True
                btnEliminar.Enabled = True
                btnImprimir.Enabled = True
            Else
                btnModificarI.Enabled = False
                btnEliminar.Enabled = False
                btnImprimir.Enabled = False
            End If
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Private Sub HabilitarBotonesClientes()

        Const strNombre_Funcion As String = "HabilitarBotonesClientes"

        Try
            If frmListadoClientes.DataGridClientes.Rows.Count > 0 Then
                frmListadoClientes.DataGridClientes.Rows(0).Selected = True
                btnModificarC.Enabled = True
            Else
                btnModificarC.Enabled = False
            End If
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Private Sub EstablecerFiltrosEstados()

        Const strNombre_Funcion As String = "EstablecerFiltrosEstados"

        Try
            chbAbierta.Checked = gv_blnAbierta
            chbEnproceso.Checked = gv_blnEnproceso
            chbTerminada.Checked = gv_blnTerminada
            chbAvisado.Checked = gv_blnAvisado
            chbCerrada.Checked = gv_blnCerrada
            chbEngarantia.Checked = gv_blnEngarantia
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Private Sub GuardarFiltrosEstados()

        Const strNombre_Funcion As String = "GuardarFiltrosEstados"

        Try
            gv_blnAbierta = chbAbierta.Checked
            gv_blnEnproceso = chbEnproceso.Checked
            gv_blnTerminada = chbTerminada.Checked
            gv_blnAvisado = chbAvisado.Checked
            gv_blnCerrada = chbCerrada.Checked
            gv_blnEngarantia = chbEngarantia.Checked
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Private Sub Incidencias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNueva.Click, btnModificarI.Click, btnEliminar.Click, btnImprimir.Click, btnBuscarIncidencia.Click, btnActualizarI.Click

        Const strNombre_Funcion As String = "Incidencias_Click"

        Dim objBoton As ToolStripButton
        Dim blnResultado As Boolean
        Dim lngIncidencia As Long

        Try
            objBoton = sender
            Select Case objBoton.Name
                Case btnNueva.Name
                    blnResultado = frmFichaIncidencia.blnCargarIncidencia()
                    If blnResultado Then
                        frmFichaIncidencia.ShowDialog()
                    End If
                    ActualizarIncidencias()
                Case btnModificarI.Name
                    blnResultado = frmFichaIncidencia.blnCargarIncidencia(frmListadoIncidencias.LineaSeleccionada)
                    If blnResultado Then
                        frmFichaIncidencia.ShowDialog()
                    End If
                    ActualizarIncidencias()
                Case btnEliminar.Name
                    lngIncidencia = frmListadoIncidencias.DataGridIncidencias.SelectedRows(0).Cells(gc_strLP_I_Incidencia).Value
                    If MsgBox("¿Estas seguro de eliminar la incidencia " & lngIncidencia & "?" & vbCrLf & _
                               "No se podrán volver a recuperar los datos asociados a esta incidencia", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Eliminar incidencia") = MsgBoxResult.Ok Then
                        If Not Inci_EliminarIncidencia(lngIncidencia) Then
                            MsgBox("Ha ocurrido un error durante la eliminacion de la incidencia. Por favor, intentelo de nuevo", MsgBoxStyle.Critical, "Eliminar incidencia")
                        End If
                    End If
                    ActualizarIncidencias()
                Case btnImprimir.Name
                    lngIncidencia = frmListadoIncidencias.DataGridIncidencias.SelectedRows(0).Cells(gc_strLP_I_Incidencia).Value
                    If frmImprimirIncidencia.CargarFormulario(lngIncidencia, gv_lngTipoImpresoIncidencia) Then
                        frmImprimirIncidencia.ShowDialog()
                    End If
                Case btnBuscarIncidencia.Name
                    AplicarFiltroIncidencias()
                Case btnActualizarI.Name
                    ActualizarIncidencias()
            End Select
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Private Sub Clientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click, btnModificarC.Click, btnBuscarC.Click, btnActualizarC.Click

        Const strNombre_Funcion As String = "Clientes_Click"

        Dim objBoton As ToolStripButton
        Dim blnResultado As Boolean
        Dim objCliente As clsCliente

        Try
            objBoton = sender
            Select Case objBoton.Name
                Case btnNuevo.Name
                    objCliente = New clsCliente
                    blnResultado = frmFichaCliente.blnCargarCliente(objCliente)
                    If blnResultado Then
                        frmFichaCliente.ShowDialog()
                    End If
                    ActualizarClientes()
                Case btnModificarC.Name
                    objCliente = New clsCliente(frmListadoClientes.LineaSeleccionada)
                    blnResultado = frmFichaCliente.blnCargarCliente(objCliente)
                    If blnResultado Then
                        frmFichaCliente.ShowDialog()
                    End If
                    ActualizarClientes()
                Case btnBuscarC.Name
                    AplicarFiltroClientes()
                Case btnActualizarC.Name
                    ActualizarClientes()
            End Select
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Private Sub Estados_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbAbierta.CheckedChanged, chbEnproceso.CheckedChanged, _
                                                                                                           chbTerminada.CheckedChanged, chbAvisado.CheckedChanged, _
                                                                                                           chbCerrada.CheckedChanged, chbEngarantia.CheckedChanged

        Const strNombre_Funcion As String = "Estados_CheckedChanged"

        Try
            AplicarFiltroIncidencias()
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Private Sub AplicarFiltroIncidencias()

        Const strNombre_Funcion As String = "AplicarFiltroIncidencias"

        Dim strFiltro As String

        Try
            strFiltro = Config_strGenerarFiltroDataGridView(txtFiltroI.Text, cbxCamposI.SelectedItem)
            GenerarFiltroEstados(strFiltro)
            frmListadoIncidencias.AplicarFiltro(strFiltro)
            HabilitarBotonesIncidencias()
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Private Sub AplicarFiltroClientes()

        Const strNombre_Funcion As String = "AplicarFiltroClientes"

        Dim strFiltro As String

        Try
            strFiltro = Config_strGenerarFiltroDataGridView(txtFiltroC.Text, cbxCamposC.SelectedItem)
            frmListadoClientes.AplicarFiltro(strFiltro)
            HabilitarBotonesClientes()
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    '<CABECERA>-----------------------------------------------
    'Nombre...........: GenerarFiltroEstados
    'Descripcion......: Filtra el DataGridView por los estados de las incidencias
    'Fecha............: 24/05/2014
    '<FIN CABECERA>-------------------------------------------
    Public Sub GenerarFiltroEstados(ByRef strFiltro As String)

        Const strNombre_Funcion As String = "GenerarFiltroEstados"
        Dim blnError As Boolean

        Dim strFiltroOriginal As String = ""
        Dim strListaEstados As String = ""
        Dim strFiltroLocal As String = ""

        Try
            strFiltroOriginal = strFiltro

            strListaEstados = "0"

            If chbAbierta.Checked Then
                If strListaEstados <> "" Then
                    strListaEstados &= ", "
                End If
                strListaEstados = "1"
            End If
            If chbEnproceso.Checked Then
                If strListaEstados <> "" Then
                    strListaEstados &= ", "
                End If
                strListaEstados &= "2"
            End If
            If chbTerminada.Checked Then
                If strListaEstados <> "" Then
                    strListaEstados &= ", "
                End If
                strListaEstados &= "3"
            End If
            If chbAvisado.Checked Then
                If strListaEstados <> "" Then
                    strListaEstados &= ", "
                End If
                strListaEstados &= "4"
            End If
            If chbCerrada.Checked Then
                If strListaEstados <> "" Then
                    strListaEstados &= ", "
                End If
                strListaEstados &= "5"
            End If
            If chbEngarantia.Checked Then
                If strListaEstados <> "" Then
                    strListaEstados &= ", "
                End If
                strListaEstados &= "6"
            End If
            If strListaEstados <> "" Then
                strFiltroLocal = gc_strDB_C_Estado & " IN (" & strListaEstados & ")"
                If strFiltro <> "" Then
                    strFiltroLocal = " AND " & strFiltroLocal
                End If
                strFiltro &= strFiltroLocal
            End If
        Catch ex As Exception
            blnError = True
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        Finally
            If blnError Then
                strFiltro = strFiltroOriginal
            End If
        End Try
    End Sub

    '<CABECERA>-----------------------------------------------
    'Descripcion......: Configura el cambio de pestaña
    'Fecha............: 27/05/2014
    '<FIN CABECERA>-------------------------------------------
    Private Sub tbcPrincipal_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbcPrincipal.SelectedIndexChanged

        Const strNombre_Funcion As String = "tbcPrincipal_SelectedIndexChanged"

        Try
            Select Case tbcPrincipal.SelectedTab.Name
                Case tbpIncidencias.Name
                    frmListadoIncidencias.BringToFront()
                    frmListadoIncidencias.Ajustar()
                Case tbpClientes.Name
                    frmListadoClientes.BringToFront()
                    frmListadoClientes.Ajustar()
            End Select
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Private Sub ActualizarClientes()

        Const strNombre_Funcion As String = "ActualizarClientes"

        Dim strFiltro As String

        Try
            strFiltro = Config_strGenerarFiltroDataGridView(txtFiltroC.Text, cbxCamposC.SelectedItem)
            frmListadoClientes.Actualizar(strFiltro)
            HabilitarBotonesClientes()
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Private Sub ActualizarIncidencias()

        Const strNombre_Funcion As String = "ActualizarIncidencias"

        Dim strFiltro As String

        Try
            strFiltro = Config_strGenerarFiltroDataGridView(txtFiltroI.Text, cbxCamposI.SelectedItem)
            GenerarFiltroEstados(strFiltro)
            frmListadoIncidencias.Actualizar(strFiltro)
            HabilitarBotonesIncidencias()
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Private Sub btnConfigC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigI.Click, btnConfigC.Click

        Const strNombre_Funcion As String = "btnConfigC_Click"

        Try
            CargarFormularioConfiguracion()
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Private Sub CargarFormularioConfiguracion()

        Const strNombre_Funcion As String = "CargarFormularioConfiguracion"

        Try
            frmCondiguracion.ShowDialog()
            If frmCondiguracion.Guardado Then
                CerrarAplicacion()
                CargarAplicacion()
            End If
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Private Sub Acercade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAcercade1.Click, btnAcercade2.Click

        Const strNombre_Funcion As String = "Acercade_Click"

        Try
            frmAcercade.ShowDialog()
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub


    Private Sub frmPrincipal_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Const strNombre_Funcion As String = "frmPrincipal_FormClosing"

        Try
            CerrarAplicacion
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Private Sub CerrarAplicacion()

        Const strNombre_Funcion As String = "CerrarAplicacion"

        Dim objForm As Windows.Forms.Form

        Try
            GuardarFiltrosEstados()
            GuardarConfiguracionINI()
            For Each objForm In Me.MdiChildren
                objForm.Close()
            Next
            tspLin1.Items(0).Enabled = True
            tspLin2.Items(0).Enabled = True
            tspLin2.Items(1).Enabled = True
            tspLin2.Items(2).Enabled = True
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Public ReadOnly Property FiltroClientes As String
        Get
            Return Config_strGenerarFiltroDataGridView(txtFiltroC.Text, cbxCamposC.SelectedItem)
        End Get
    End Property

    Public ReadOnly Property FiltroIncidencias As String
        Get
            Return Config_strGenerarFiltroDataGridView(txtFiltroI.Text, cbxCamposI.SelectedItem)
        End Get
    End Property

    
End Class