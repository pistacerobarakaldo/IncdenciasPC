Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO
Imports System.Data.OleDb

Public Enum TipoImpreso
    Ticket
    Folio
End Enum

Public Class frmImprimirIncidencia
    Const mc_strNombre_Modulo As String = "frmImprimirIncidencia"

    Private m_objReporte As ReportDocument

    '<CABECERA>-----------------------------------------------
    'Descripcion......: Carga el formulario
    'Fecha............: 25/05/2014
    '<FIN CABECERA>-------------------------------------------
    Public Function CargarFormulario(ByVal lngIncidencia As Long, ByVal udtTipoDoc As TipoImpreso) As Boolean

        Const strNombre_Funcion As String = "CargarFormulario"
        Dim blnError As Boolean

        Dim blnResultado As Boolean
        Dim strSQL As String
        Dim dtsDataSet As New DataSet
        Dim dtaDataAdapter As New OleDbDataAdapter

        Try
            Select Case udtTipoDoc
                Case TipoImpreso.Ticket
                    m_objReporte = gv_objReports.IncidenciaTicket
                Case TipoImpreso.Folio
                    'Aqui deberia ir otro tipo
                    m_objReporte = gv_objReports.IncidenciaTicket
            End Select

            'Se obtiene el dataset
            strSQL = "SELECT * FROM " & gc_strDB_TABLA_Incidencias
            dtaDataAdapter.SelectCommand = New OleDbCommand(strSQL, ConexionDB)
            dtaDataAdapter.Fill(dtsDataSet, gc_strDB_TABLA_Incidencias)

            strSQL = "SELECT * FROM " & gc_strDB_TABLA_TiposEquipos
            dtaDataAdapter.SelectCommand = New OleDbCommand(strSQL, ConexionDB)
            dtaDataAdapter.Fill(dtsDataSet, gc_strDB_TABLA_TiposEquipos)
            
            m_objReporte.SetDataSource(dtsDataSet)

            m_objReporte.SetParameterValue("IdIncidencia", lngIncidencia)
            m_objReporte.PrintOptions.PrinterName = gv_strImpresoraIncidencias
            nudCopias.Value = 2
            blnResultado = True
        Catch ex As Exception
            blnError = True
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        Finally
            If blnError Then
                blnResultado = False
            End If
            CargarFormulario = blnResultado
        End Try
    End Function

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        ImprimirIncidencia()
        Me.Close()
    End Sub

    '<CABECERA>-----------------------------------------------
    'Descripcion......: Imprime el reporte de la incidencia
    'Fecha............: 25/05/2014
    '<FIN CABECERA>-------------------------------------------
    Private Sub ImprimirIncidencia()

        Const strNombre_Funcion As String = "ImprimirIncidencia"

        Dim lngCopias As Long

        Try
            lngCopias = nudCopias.Value
            If lngCopias > 0 Then
                For intcont = 1 To lngCopias
                    m_objReporte.PrintToPrinter(1, False, 1, 1)
                Next
            End If
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub
End Class