Public Class frmCondiguracion
    Const mc_strNombre_Modulo As String = "frmCondiguracion"

    Private m_blnGuardado As Boolean

    '<CABECERA>-----------------------------------------------
    'Descripcion..: Carga el formulario de configuracion
    'Fecha........: 28/05/2014
    '<FIN CABECERA>-------------------------------------------
    Private Sub frmCondiguracion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Const strNombre_Funcion As String = "frmCondiguracion_Load"
        Dim blnError As Boolean

        Try
            'Rutas
            txtDBIncidencias.Text = gv_strDBPrincipal
            txtDBFactusol.Text = gv_strDBFactusol
            chkClientesLocal.Checked = gv_blnDBLocal
            'Impresoras
            txtImpresoraIncidencias.Text = gv_strImpresoraIncidencias
            txtImpresoraInformes.Text = gv_strImpresoraInformes
            Select Case gv_lngTipoImpresoIncidencia
                Case TipoImpreso.Ticket
                    rdbTicket.Checked = True
                Case TipoImpreso.Folio
                    rdbFolio.Checked = True
            End Select
        Catch ex As Exception
            blnError = True
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Private Sub chkClientesLocal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkClientesLocal.CheckedChanged

        Const strNombre_Funcion As String = "chkClientesLocal_CheckedChanged"
        Dim blnError As Boolean

        Try
            txtDBFactusol.Enabled = Not chkClientesLocal.Checked
            btnDBFactusol.Enabled = Not chkClientesLocal.Checked
        Catch ex As Exception
            blnError = True
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        Const strNombre_Funcion As String = "btnAceptar_Click"
        
        Try
            'Rutas
            EscribirINI(gc_strINIS_DBPATH, gc_strINIK_DBPATH_Principal, txtDBIncidencias.Text)
            EscribirINI(gc_strINIS_DBPATH, gc_strINIK_DBPATH_Factusol, txtDBFactusol.Text)
            'Impresoras
            EscribirINI(gc_strINIS_PRINTERS, gc_strINIK_PRINTERS_Incidencias, txtImpresoraIncidencias.Text)
            EscribirINI(gc_strINIS_PRINTERS, gc_strINIK_PRINTERS_Informes, txtImpresoraInformes.Text)
            If rdbTicket.Checked Then
                LeerINI(gc_strINIS_PRINTERS, gc_strINIK_PRINTERS_TipoImpresoIncidencia, TipoImpreso.Ticket)
            ElseIf rdbFolio.Checked Then
                LeerINI(gc_strINIS_PRINTERS, gc_strINIK_PRINTERS_TipoImpresoIncidencia, TipoImpreso.Folio)
            End If
            m_blnGuardado = True
            Me.Close()
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Const strNombre_Funcion As String = "btnCancelar_Click"

        Try
            m_blnGuardado = False
            Me.Close()
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Public ReadOnly Property Guardado As Boolean
        Get
            Return m_blnGuardado
        End Get
    End Property

    Private Sub btnImpresoraIncidencias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImpresoraIncidencias.Click

        Const strNombre_Funcion As String = "btnImpresoraIncidencias_Click"

        Try
            If pdgImpresoras.ShowDialog = DialogResult.OK Then
                txtImpresoraIncidencias.Text = pdgImpresoras.PrinterSettings.PrinterName
            End If
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Private Sub btnImpresoraInformes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImpresoraInformes.Click

        Const strNombre_Funcion As String = "btnImpresoraInformes_Click"

        Try
            If pdgImpresoras.ShowDialog = DialogResult.OK Then
                txtImpresoraInformes.Text = pdgImpresoras.PrinterSettings.PrinterName
            End If
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Private Sub btnDBIncidencias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDBIncidencias.Click

        Const strNombre_Funcion As String = "btnDBIncidencias_Click"

        Try
            ofdRutas.Title = "Selecciona base de datos de incidencias"
            ofdRutas.InitialDirectory = strQuitarFichero(txtDBIncidencias.Text)
            ofdRutas.Filter = "Archivo de Access|*.accdb"
            If ofdRutas.ShowDialog = DialogResult.OK Then
                txtDBIncidencias.Text = ofdRutas.FileName
            End If
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Private Sub btnDBFactusol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDBFactusol.Click

        Const strNombre_Funcion As String = "btnDBFactusol_Click"

        Try
            ofdRutas.Title = "Selecciona base de datos de FactuSOL"
            ofdRutas.InitialDirectory = strQuitarFichero(txtDBFactusol.Text)
            ofdRutas.Filter = "Archivo de Access|*.accdb"
            If ofdRutas.ShowDialog = DialogResult.OK Then
                txtDBFactusol.Text = ofdRutas.FileName
            End If
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub
End Class