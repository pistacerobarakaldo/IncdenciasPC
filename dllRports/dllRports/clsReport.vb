Option Explicit On
Option Compare Text

Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine

Public Class clsReport
    'Constante que guarda el nombre del mudolu
    Const mc_strNombre_Modulo As String = "clsReport"

    '<CABECERA>-----------------------------------------------
    'Descripcion......: Inicializa la dll
    'Fecha............: 24/04/2013
    '<FIN CABECERA>-------------------------------------------
    Public Sub New(ByVal strOrigen As String)

        Const strNombre_Funcion As String = "New"
        Dim blnError As Boolean

        Try
            SetApplicationPath = strOrigen
        Catch ex As Exception
            'Agregamos el error
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
            blnError = True
        Finally

        End Try
    End Sub

    Public Property IncidenciaTicket As ReportDocument
        Get
            Return New IncidenciaRPT
        End Get
        Set(ByVal value As ReportDocument)

        End Set
    End Property

End Class
