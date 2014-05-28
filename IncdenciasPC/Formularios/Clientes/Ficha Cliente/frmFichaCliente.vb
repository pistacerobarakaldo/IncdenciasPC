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

    Private Sub btnDetalles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetalles.Click

        Const strNombre_Funcion As String = "btnDetalles_Click"

        Try
           If Not frmDetallesCliente.IsMdiChild Then
                frmDetallesCliente.MdiParent = Me
                frmDetallesCliente.Show()
                frmDetallesCliente.WindowState = FormWindowState.Minimized
                frmDetallesCliente.WindowState = FormWindowState.Maximized
            Else
                frmDetallesCliente.BringToFront()
                frmDetallesCliente.WindowState = FormWindowState.Maximized
            End If
            btnDetalles.Checked = True
            btnHistorial.Checked = False
            btnMantenimiento.Checked = False
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Private Sub btnHistorial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHistorial.Click

        Const strNombre_Funcion As String = "btnHistorial_Click"

        Try
            If Not frmHistorialIncidenciasCliente.IsMdiChild Then
                frmHistorialIncidenciasCliente.MdiParent = Me
                frmHistorialIncidenciasCliente.Show()
                frmHistorialIncidenciasCliente.WindowState = FormWindowState.Minimized
                frmHistorialIncidenciasCliente.WindowState = FormWindowState.Maximized
            Else
                frmHistorialIncidenciasCliente.BringToFront()
                frmHistorialIncidenciasCliente.WindowState = FormWindowState.Maximized
            End If
            btnDetalles.Checked = False
            btnHistorial.Checked = True
            btnMantenimiento.Checked = False
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Private Sub btnMantenimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMantenimiento.Click

        Const strNombre_Funcion As String = "btnHistorial_Click"

        Try
            If Not frmMantenimiento.IsMdiChild Then
                frmMantenimiento.MdiParent = Me
                frmMantenimiento.Show()
                frmMantenimiento.WindowState = FormWindowState.Minimized
                frmMantenimiento.WindowState = FormWindowState.Maximized
            Else
                frmMantenimiento.BringToFront()
                frmMantenimiento.WindowState = FormWindowState.Maximized
            End If
            btnDetalles.Checked = False
            btnHistorial.Checked = False
            btnMantenimiento.Checked = True
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

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