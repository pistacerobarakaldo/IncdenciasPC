Public Class frmFichaCliente
    Const mc_strNombre_Modulo As String = "frmFichaCliente"

    'Incidencia
    Private m_objCliente As clsCliente

    Enum ActualForm
        Detalles
        Historial
        Presupuesto
    End Enum

    Public Function blnCargarCliente(ByVal objCliente As clsCliente) As Boolean

        Const strNombre_Funcion As String = "blnCargarCliente"
        Dim blnError As Boolean

        Dim blnResultado As Boolean

        Try
            m_objCliente = objCliente
            'En caso de ser necesario se limpiara el formulario
            blnResultado = frmDetallesCliente.blnCargarCliente(m_objCliente)
        Catch ex As Exception
            blnError = True
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        Finally
            If blnError Then
                blnResultado = False
            End If
            blnCargarCliente = blnResultado
        End Try
    End Function

    Private Sub frmFichaCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load

        Const strNombre_Funcion As String = "frmFichaCliente_Load"

        Try
            frmDetallesCliente.MdiParent = Me
            frmDetallesCliente.Show()
            frmDetallesCliente.WindowState = FormWindowState.Minimized
            frmDetallesCliente.WindowState = FormWindowState.Maximized
            btnDetalles.Checked = True
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Private Sub btnDetalles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Const strNombre_Funcion As String = "btnDetalles_Click"

        Try
            If btnDetalles.Checked = False Then
                If frmHistorialIncidenciasCliente.Visible Then
                    frmHistorialIncidenciasCliente.Hide()
                    btnHistorial.Checked = False
                End If
                If frmMantenimiento.Visible Then
                    frmMantenimiento.Hide()
                    btnMantenimiento.Checked = False
                End If
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

    Private Sub btnHistorial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Const strNombre_Funcion As String = "btnHistorial_Click"

        Try
            If btnHistorial.Checked = False Then
                If frmDetallesCliente.Visible Then
                    frmDetallesCliente.Hide()
                    btnDetalles.Checked = False
                End If
                If frmMantenimiento.Visible Then
                    frmMantenimiento.Hide()
                    btnMantenimiento.Checked = False
                End If
                frmHistorialIncidenciasCliente.MdiParent = Me
                frmHistorialIncidenciasCliente.Show()
                frmHistorialIncidenciasCliente.WindowState = FormWindowState.Minimized
                frmHistorialIncidenciasCliente.WindowState = FormWindowState.Maximized

                btnHistorial.Checked = True
            End If
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Private Sub btnMantenimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Const strNombre_Funcion As String = "btnMantenimiento_Click"

        Try
            If btnMantenimiento.Checked = False Then
                If frmDetallesCliente.Visible Then
                    frmDetallesCliente.Hide()
                    btnDetalles.Checked = False
                End If
                If frmHistorialIncidenciasCliente.Visible Then
                    frmHistorialIncidenciasCliente.Hide()
                    btnHistorial.Checked = False
                End If
                frmMantenimiento.MdiParent = Me
                frmMantenimiento.Show()
                frmMantenimiento.WindowState = FormWindowState.Minimized
                frmMantenimiento.WindowState = FormWindowState.Maximized

                btnMantenimiento.Checked = True
            End If
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Const strNombre_Funcion As String = "Mantenimiento_Click"

        Dim objCliente As New clsCliente

        Try
            If frmDetallesCliente.GuardarCliente(objCliente) Then
                If Clie_GuardarCliente(objCliente) Then
                    m_objCliente = objCliente
                    MsgBox("El cliente ha sido guardado", _
                       MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Salvado de datos")
                    Me.Close()
                Else
                    MsgBox("Error en el guardado del cliente", _
                       MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Salvado de datos")
                End If
            Else
                MsgBox("Error en el guardado del cliente", _
                       MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Salvado de datos")
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
            btnMantenimiento.Checked = False
            btnHistorial.Checked = False
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Public ReadOnly Property Cliente As clsCliente
        Get
            Return m_objCliente
        End Get
    End Property
End Class