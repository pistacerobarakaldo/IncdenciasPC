Imports CrystalDecisions.CrystalReports.Engine

Public Class frmPrincipal
    Const mc_strNombre_Modulo As String = "frmPrincipal"

    'Incidencia
    Private m_objIncidencia As clsIncidencia

    Enum ActualForm
        Detalles
        Historial
        Presupuesto
    End Enum

    Private Sub frmIncidencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Const strNombre_Funcion As String = "frmIncidencia_Load"

        Try
            'CARGAR ARCHIVO DE CONFIGURACION
            CargarConfiguracionINI()
            EstablecerFiltrosEstados()
            frmListadoIncidencias.MdiParent = Me
            frmListadoIncidencias.Show()
            frmListadoIncidencias.WindowState = FormWindowState.Minimized
            frmListadoIncidencias.WindowState = FormWindowState.Maximized
            CargarFiltrosToolStripComboBox(cbxCamposI, frmListadoIncidencias.DataGridIncidencias)
            AplicarFiltro()
            HabilitarBotones()
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Private Sub HabilitarBotones()

        Const strNombre_Funcion As String = "HabilitarBotones"

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

    Private Sub Lineas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNueva.Click, btnModificarI.Click, btnEliminar.Click, btnImprimir.Click

        Const strNombre_Funcion As String = "Lineas_Click"

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
                    AplicarFiltro()
                Case btnModificarI.Name
                    blnResultado = frmFichaIncidencia.blnCargarIncidencia(frmListadoIncidencias.LineaSeleccionada)
                    If blnResultado Then
                        frmFichaIncidencia.ShowDialog()
                    End If
                    AplicarFiltro()
                Case btnEliminar.Name
                    lngIncidencia = frmListadoIncidencias.DataGridIncidencias.SelectedRows(0).Cells(gc_strLP_I_Incidencia).Value
                    If MsgBox("¿Estas seguro de eliminar la incidencia " & lngIncidencia & "?" & vbCrLf & _
                               "No se podrán volver a recuperar los datos asociados a esta incidencia", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Eliminar incidencia") = MsgBoxResult.Ok Then
                        If Not Inci_EliminarIncidencia(lngIncidencia) Then
                            MsgBox("Ha ocurrido un error durante la eliminacion de la incidencia. Por favor, intentelo de nuevo", MsgBoxStyle.Critical, "Eliminar incidencia")
                        End If
                    End If
                    AplicarFiltro()
                Case btnImprimir.Name
                    lngIncidencia = frmListadoIncidencias.DataGridIncidencias.SelectedRows(0).Cells(gc_strLP_I_Incidencia).Value
                    ImprimirIncidencia(lngIncidencia)

            End Select
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    '<CABECERA>-----------------------------------------------
    'Descripcion......: Imprime el reporte de la incidencia
    'Fecha............: 25/05/2014
    '<FIN CABECERA>-------------------------------------------
    Private Sub ImprimirIncidencia(ByVal lngIncidencia As Long)

        Const strNombre_Funcion As String = "ImprimirIncidencia"

        Dim objReporte As New ReportDocument
        Dim lngCopias As Long

        Try
            frmImprimirIncidencia.ShowDialog()
            lngCopias = frmImprimirIncidencia.Copias
            If lngCopias > 0 Then
                objReporte = New IncidenciaRPT
                objReporte.SetParameterValue("IdIncidencia", lngIncidencia)
                For intcont = 1 To lngCopias
                    objReporte.PrintToPrinter(1, False, 1, 1)
                Next
            End If
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Private Sub frmIncidencia_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Const strNombre_Funcion As String = "frmIncidencia_FormClosing"

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

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarIncidencia.Click

        Const strNombre_Funcion As String = "btnBuscar_Click"

        Try
            AplicarFiltro()
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Private Sub Estados_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbAbierta.CheckedChanged, chbEnproceso.CheckedChanged, _
                                                                                                           chbTerminada.CheckedChanged, chbAvisado.CheckedChanged, _
                                                                                                           chbCerrada.CheckedChanged, chbEngarantia.CheckedChanged

        Const strNombre_Funcion As String = "Estados_CheckedChanged"

        Try
            AplicarFiltro()
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Private Sub AplicarFiltro()

        Const strNombre_Funcion As String = "AplicarFiltro"

        Dim strFiltro As String

        Try
            strFiltro = Config_strGenerarFiltroDataGridView(txtFiltroI.Text, cbxCamposI.SelectedItem)
            GenerarFiltroEstados(strFiltro)
            frmListadoIncidencias.AplicarFiltro(strFiltro)
            HabilitarBotones()
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
End Class