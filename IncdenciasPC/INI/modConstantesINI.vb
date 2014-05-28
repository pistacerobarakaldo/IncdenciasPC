Option Explicit On
Option Compare Text

Module modConstantesINI

    'Constante que guarda el nombre del mudolu
    Const mc_strNombre_Modulo As String = "modConstantesINI"

    'Nombre del fichero
    Public Const gc_strINI_INIFILE As String = "\INI\CONFIG.INI"

    '#####################################################################
    'DBPATH
    Public Const gc_strINIS_DBPATH As String = "DBPATH"
    '---------------------------------------------------------------------
    Public Const gc_strINIK_DBPATH_Principal As String = "DBPATH_Principal"
    Public Const gc_strINIK_DBPATH_Factusol As String = "DBPATH_Factusol"
    '#####################################################################

    '#####################################################################
    'PRINTERS
    Public Const gc_strINIS_PRINTERS As String = "PRINTERS"
    '---------------------------------------------------------------------
    Public Const gc_strINIK_PRINTERS_Incidencias As String = "PRINTERS_Incidencias"
    Public Const gc_strINIK_PRINTERS_Informes As String = "PRINTERS_Informes"
    Public Const gc_strINIK_PRINTERS_TipoImpresoIncidencia As String = "PRINTERS_TipoImpresoIncidencia"
    '#####################################################################

    '#####################################################################
    'FILTERS
    Public Const gc_strINIS_FILTERS As String = "FILTERS"
    '---------------------------------------------------------------------
    'Ayuda
    Public Const gc_strINIK_FILTERS_Abierta As String = "FILTROS_Abierta"
    Public Const gc_strINIK_FILTERS_Proceso As String = "FILTROS_Proceso"
    Public Const gc_strINIK_FILTERS_Terminada As String = "FILTROS_Terminada"
    Public Const gc_strINIK_FILTERS_Avisado As String = "FILTROS_Avisado"
    Public Const gc_strINIK_FILTERS_Cerrada As String = "FILTROS_Cerrada"
    Public Const gc_strINIK_FILTERS_Garantia As String = "FILTROS_Garantia"
    '#####################################################################

End Module
