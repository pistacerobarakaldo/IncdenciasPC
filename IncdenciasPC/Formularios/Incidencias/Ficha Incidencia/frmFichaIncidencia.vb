Public Class frmFichaIncidencia
    Const mc_strNombre_Modulo As String = "frmFichaIncidencia"

    'Incidencia
    Private m_objIncidencia As clsIncidencia

    Enum ActualForm
        Detalles
        Historial
        Presupuesto
    End Enum

    Public Function blnCargarIncidencia(Optional ByVal dtrIncidencia As DataGridViewRow = Nothing, Optional ByVal lngId As Long = -1) As Boolean

        Const strNombre_Funcion As String = "frmIncidencia_Load"
        Dim blnError As Boolean

        Dim blnResultado As Boolean

        Try
            'En caso de ser necesario se limpiara el formulario
            If Not dtrIncidencia Is Nothing Then
                m_objIncidencia = New clsIncidencia(dtrIncidencia)
            Else
                If lngId > 0 Then
                    m_objIncidencia = New clsIncidencia(, lngId)
                Else
                    m_objIncidencia = New clsIncidencia
                End If
            End If
            blnResultado = frmDetallesIncidencia.blnCargarDetalles(m_objIncidencia)
            If blnResultado Then
                blnResultado = frmHistorialActuacion.blnCargarHistorial(m_objIncidencia)
                If blnResultado Then
                    blnResultado = frmPresupuesto.blnCargarPresupuesto(m_objIncidencia)
                End If
            End If
            If m_objIncidencia.Id = 0 Then
                'Nueva incidencia
                'Se añade una linea al historico para que quede constancia de la apertura
                frmHistorialActuacion.NuevoEvento(1, "Apertura de la incidencia")
            Else
                'Editar incidencia
            End If
        Catch ex As Exception
            blnError = True
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        Finally
            If blnError Then
                blnResultado = False
            End If
            blnCargarIncidencia = blnResultado
        End Try
    End Function

    Private Sub frmIncidencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Const strNombre_Funcion As String = "frmIncidencia_Load"

        Try
            HabilitarClienteLineas(ActualForm.Detalles)
            frmDetallesIncidencia.MdiParent = Me
            frmDetallesIncidencia.Show()
            frmDetallesIncidencia.WindowState = FormWindowState.Minimized
            frmDetallesIncidencia.WindowState = FormWindowState.Maximized
            btnDetalles.Checked = True
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Private Sub btnDetalles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetalles.Click

        Const strNombre_Funcion As String = "btnDetalles_Click"

        Try
            If btnDetalles.Checked = False Then
                If frmHistorialActuacion.Visible Then
                    frmHistorialActuacion.Hide()
                    btnHistorial.Checked = False
                End If
                If frmPresupuesto.Visible Then
                    frmPresupuesto.Hide()
                    btnPresupuesto.Checked = False
                End If
                HabilitarClienteLineas(ActualForm.Detalles)
                frmDetallesIncidencia.MdiParent = Me
                frmDetallesIncidencia.Show()
                frmDetallesIncidencia.WindowState = FormWindowState.Minimized
                frmDetallesIncidencia.WindowState = FormWindowState.Maximized

                btnDetalles.Checked = True
            End If
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Private Sub btnHistorial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHistorial.Click

        Const strNombre_Funcion As String = "btnHistorial_Click"

        Try
            If btnHistorial.Checked = False Then
                If frmDetallesIncidencia.Visible Then
                    frmDetallesIncidencia.Hide()
                    btnDetalles.Checked = False
                End If
                If frmPresupuesto.Visible Then
                    frmPresupuesto.Hide()
                    btnPresupuesto.Checked = False
                End If
                HabilitarClienteLineas(ActualForm.Historial)
                frmHistorialActuacion.MdiParent = Me
                frmHistorialActuacion.Show()
                frmHistorialActuacion.WindowState = FormWindowState.Minimized
                frmHistorialActuacion.WindowState = FormWindowState.Maximized

                btnHistorial.Checked = True
            End If
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Private Sub btnPresupuesto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPresupuesto.Click

        Const strNombre_Funcion As String = "btnPresupuesto_Click"

        Try
            If btnPresupuesto.Checked = False Then
                If frmDetallesIncidencia.Visible Then
                    frmDetallesIncidencia.Hide()
                    btnDetalles.Checked = False
                End If
                If frmHistorialActuacion.Visible Then
                    frmHistorialActuacion.Hide()
                    btnHistorial.Checked = False
                End If
                HabilitarClienteLineas(ActualForm.Presupuesto)
                frmPresupuesto.MdiParent = Me
                frmPresupuesto.Show()
                frmPresupuesto.WindowState = FormWindowState.Minimized
                frmPresupuesto.WindowState = FormWindowState.Maximized

                btnPresupuesto.Checked = True
            End If
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Private Sub HabilitarClienteLineas(ByVal evlFormulario As ActualForm)

        Const strNombre_Funcion As String = "HabilitarClienteLineas"

        Try
            Select Case evlFormulario
                Case ActualForm.Detalles
                    tspLin1.Items(0).Enabled = False
                    tspLin2.Items(0).Enabled = False
                    tspLin2.Items(1).Enabled = False
                    tspLin2.Items(2).Enabled = False
                    tspCli1.Items(0).Enabled = True
                    If frmDetallesIncidencia.ObtenerCliente <> 0 Then
                        tspCli2.Items(0).Enabled = True
                    Else
                        tspCli2.Items(0).Enabled = False
                    End If
                    tspCli2.Items(1).Enabled = True
                Case ActualForm.Historial
                    tspLin1.Items(0).Enabled = True
                    tspLin2.Items(0).Enabled = True
                    tspLin2.Items(1).Enabled = True
                    tspLin2.Items(2).Enabled = True
                    tspCli1.Items(0).Enabled = False
                    tspCli2.Items(0).Enabled = False
                    tspCli2.Items(1).Enabled = False
                Case ActualForm.Presupuesto
                    tspLin1.Items(0).Enabled = True
                    tspLin2.Items(0).Enabled = True
                    tspLin2.Items(1).Enabled = False
                    tspLin2.Items(2).Enabled = True
                    tspCli1.Items(0).Enabled = False
                    tspCli2.Items(0).Enabled = False
                    tspCli2.Items(1).Enabled = False
            End Select
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Friend WriteOnly Property Presupuesto As String
        Set(ByVal value As String)
            lblPresupuesto.Text = value
        End Set
    End Property

    Private Sub Mantenimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click, btnGuardaryCerrar.Click, btnImprimir.Click

        Const strNombre_Funcion As String = "Mantenimiento_Click"

        Dim objBoton As ToolStripButton

        Try
            objBoton = sender
            Select Case objBoton.Name
                Case btnGuardar.Name
                    GuardarIncidencia(False, False)
                Case btnGuardaryCerrar.Name
                    GuardarIncidencia(True, False)
                Case btnImprimir.Name
                    'Imprimir la incidencia en la impresora de tickets
                    If MsgBox("La incidencia debe guardarse antes de imprimir ¿Desea guardar la incidencia ahora?", _
                           MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Faltan datos") = vbOK Then
                        GuardarIncidencia(False, True)
                        If frmImprimirIncidencia.CargarFormulario(m_objIncidencia.Id, gv_lngTipoImpresoIncidencia) Then
                            frmImprimirIncidencia.ShowDialog()
                        End If
                    End If
            End Select
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Private Sub GuardarIncidencia(ByVal blnCerrar As Boolean, ByVal blnDesdeImprimir As Boolean)

        Const strNombre_Funcion As String = "GuardarIncidencia"

        Dim objIncidencia As New clsIncidencia
        Dim lngEstado As Long
        Dim strResolucion As String

        Try
            If frmDetallesIncidencia.GuardarIncidencia(objIncidencia) Then
                If objIncidencia.Estado >= 3 And objIncidencia.Resolucion = "" Then
                    MsgBox("El campo Resolucion no puede estar vacio si la incidencia se guarda como terminada, avisado, cerrada o En garantia", _
                           MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Faltan datos")
                ElseIf objIncidencia.IdCliente = 0 Then
                    MsgBox("Debe seleccionar un cliente o crear uno nuevo", _
                           MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Faltan datos")
                Else
                    lngEstado = m_objIncidencia.Estado
                    strResolucion = m_objIncidencia.Resolucion
                    If lngEstado <> objIncidencia.Estado Then
                        'Crear evento de cambio de estado
                        frmHistorialActuacion.NuevoEvento(objIncidencia.Estado, "La incidencia pasa al estado: " & ObtenerEstado(objIncidencia.Estado))
                    End If
                    If Not String.Equals(strResolucion, objIncidencia.Resolucion) Then
                        'Crear evento de cambio de resolucion
                        frmHistorialActuacion.NuevoEvento(objIncidencia.Estado, "La resolucion de la incidencia es: " & objIncidencia.Resolucion)
                    End If
                    objIncidencia.Historial = frmHistorialActuacion.GuardarHistorial()
                    objIncidencia.Presupuesto = frmPresupuesto.GuardarPresupuesto()

                    If Inci_GuardarIncidencia(objIncidencia) Then
                        m_objIncidencia = objIncidencia
                        If Not blnDesdeImprimir Then
                            MsgBox("Se ha guardado la incidencia", _
                           MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Salvado de datos")
                        End If
                        If blnCerrar Then
                            frmDetallesIncidencia.Close()
                            frmHistorialActuacion.Close()
                            frmPresupuesto.Close()
                            Me.Close()
                        End If
                    Else
                        MsgBox("Error al guardar la incidencia", _
                           MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Salvado de datos")
                    End If
                End If
            Else
                MsgBox("Error al recuperar los datos de la incidencia para su guardado", _
                           MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Salvado de datos")
            End If
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Private Sub Cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click, btnVerCliente.Click, btnNuevoCliente.Click

        Const strNombre_Funcion As String = "Cliente_Click"

        Dim objBoton As ToolStripButton
        Dim objCliente As clsCliente

        Try
            objBoton = sender
            Select Case objBoton.Name
                Case btnBuscar.Name
                    frmBusquedaClientes.ShowDialog()
                    objCliente = frmBusquedaClientes.Cliente
                    If Not objCliente Is Nothing Then
                        frmDetallesIncidencia.AnadirCliente = objCliente
                        HabilitarClienteLineas(ActualForm.Detalles)
                    End If
                Case btnVerCliente.Name
                    objCliente = New clsCliente(, frmDetallesIncidencia.ObtenerCliente)
                    If frmFichaCliente.blnCargarCliente(objCliente) Then
                        frmFichaCliente.ShowDialog()
                        objCliente = frmFichaCliente.Cliente
                        frmDetallesIncidencia.AnadirCliente = objCliente
                    End If
                Case btnNuevoCliente.Name
                    objCliente = New clsCliente
                    If frmFichaCliente.blnCargarCliente(objCliente) Then
                        frmFichaCliente.ShowDialog()
                        objCliente = frmFichaCliente.Cliente
                        frmDetallesIncidencia.AnadirCliente = objCliente
                    End If
            End Select
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Private Sub Lineas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNueva.Click, btnDuplicar.Click, btnModificar.Click, btnEliminar.Click

        Const strNombre_Funcion As String = "Lineas_Click"

        Dim objBoton As ToolStripButton

        Try
            objBoton = sender
            If frmHistorialActuacion.Visible Then
                Select Case objBoton.Name
                    Case btnNueva.Name
                        frmHistorialActuacion.NuevaLinea()
                    Case btnDuplicar.Name
                        frmHistorialActuacion.DuplicarLinea()
                    Case btnModificar.Name
                        frmHistorialActuacion.ModificarLinea()
                    Case btnEliminar.Name
                        frmHistorialActuacion.EliminarLinea()
                End Select
            ElseIf frmPresupuesto.Visible Then
                Select Case objBoton.Name
                    Case btnNueva.Name
                        frmPresupuesto.NuevaLinea()
                    Case btnDuplicar.Name
                        frmPresupuesto.DuplicarLinea()
                    Case btnEliminar.Name
                        frmHistorialActuacion.EliminarLinea()
                End Select
            End If
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Private Sub frmIncidencia_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Const strNombre_Funcion As String = "frmIncidencia_FormClosing"

        Dim objForm As Windows.Forms.Form

        Try
            For Each objForm In Me.MdiChildren
                objForm.Close()
            Next
            btnDetalles.Checked = False
            btnPresupuesto.Checked = False
            btnHistorial.Checked = False
            tspLin1.Items(0).Enabled = True
            tspLin2.Items(0).Enabled = True
            tspLin2.Items(1).Enabled = True
            tspLin2.Items(2).Enabled = True
            tspCli1.Items(0).Enabled = True
            tspCli2.Items(0).Enabled = True
            tspCli2.Items(1).Enabled = True
            lblEstado.Text = ""
            lblPresupuesto.Text = Format(0, "0.00 €")
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub
End Class