Option Explicit On
Option Compare Text

Module modLPConstantes
    'Constante que guarda el nombre del mudolu
    Const mc_strNombre_Modulo As String = "modLPConstantes"

    '######################################################
    'Incidencias
    '------------------------------------------------------
    Public Const gc_strLP_I_Incidencia As String = "Id Incidencia"
    Public Const gc_strLP_C_Cliente As String = "Id Cliente"
    Public Const gc_strLP_D_Cliente As String = "Cliente"
    Public Const gc_strLP_D_Contacto As String = "Contacto"
    Public Const gc_strLP_D_Telefono1 As String = "Num 1"
    Public Const gc_strLP_D_Telefono2 As String = "Num 2"
    Public Const gc_strLP_F_Entrada As String = "Entrada"
    Public Const gc_strLP_C_Tipo As String = "Tipo"
    Public Const gc_strLP_D_Marca As String = "Marca"
    Public Const gc_strLP_D_Modelo As String = "Modelo"
    Public Const gc_strLP_D_NSerie As String = "N Serie"
    Public Const gc_strLP_D_Obser As String = "Observaciones"
    Public Const gc_strLP_B_Maletin As String = "Maletin"
    Public Const gc_strLP_B_Cargador As String = "Cargador"
    Public Const gc_strLP_D_Averia As String = "Averia"
    Public Const gc_strLP_D_Resolucion As String = "Resolucion"
    Public Const gc_strLP_V_Importe As String = "Importe"
    Public Const gc_strLP_C_Estado As String = "Estado"
    Public Const gc_strLP_B_Garantia As String = "Garantia"
    '######################################################

    '######################################################
    'LineasPresupuesto
    '------------------------------------------------------
    Public Const gc_strLP_C_Incidencia As String = "Incidencia"
    Public Const gc_strLP_C_Linea As String = "Linea"
    Public Const gc_strLP_D_Concepto As String = "Concepto"
    'Public Const gc_strLP_V_Importe As String = "Importe"
    Public Const gc_strLP_V_Cantidad As String = "Cant"
    Public Const gc_strLP_V_Base As String = "Base"
    Public Const gc_strLP_V_PIVA As String = "% IVA"
    Public Const gc_strLP_V_IVA As String = "IVA"
    Public Const gc_strLP_V_Total As String = "Total"
    '######################################################

    '######################################################
    'LineasActuacion
    '------------------------------------------------------
    'Public Const gc_strLP_C_Incidencia As String = "Incidencia"
    'Public Const gc_strLP_C_Linea As String = "Linea"
    'Public Const gc_strLP_C_Estado As String = "Estado"
    Public Const gc_strLP_F_Fecha As String = "Fecha"
    Public Const gc_strLP_D_Descripcion As String = "Descripcion"
    '######################################################

    '######################################################
    'TEquipos
    '------------------------------------------------------
    Public Const gc_strLP_I_Tipo As String = "Id Tipo"
    Public Const gc_strLP_D_Tipo As String = "Tipo"
    '######################################################

    '######################################################
    'Estados
    '------------------------------------------------------
    Public Const gc_strLP_I_Estado As String = "Id Estado"
    Public Const gc_strLP_D_Estado As String = "Estado"
    '######################################################

    '######################################################
    'Clientes (FactuSOL)
    '------------------------------------------------------
    Public Const gc_strLP_I_Cliente As String = "Id Cliente"
    Public Const gc_strLP_D_NIFCliente As String = "NIF"
    Public Const gc_strLP_D_NomFiscal As String = "Nombre fiscal"
    Public Const gc_strLP_D_NomCliente As String = "Nombre comercial"
    Public Const gc_strLP_D_DomCliente As String = "Domicilio"
    Public Const gc_strLP_D_PobCliente As String = "Poblacion"
    Public Const gc_strLP_D_CPCliente As String = "CP"
    Public Const gc_strLP_D_PorvCliente As String = "Provincia"
    Public Const gc_strLP_D_Telefono As String = "Telefono"
    Public Const gc_strLP_D_Fax As String = "Fax"
    Public Const gc_strLP_D_Movil As String = "Movil"
    Public Const gc_strLP_D_ContCliente As String = "Contacto"
    Public Const gc_strLP_D_FormaPago As String = "F Pago"
    Public Const gc_strLP_V_Tarifa As String = "Tarifa"
    Public Const gc_strLP_F_Alta As String = "F Alta"
    Public Const gc_strLP_D_Email As String = "Email"
    Public Const gc_strLP_D_Observ As String = "Observaciones"
    Public Const gc_strLP_D_Pais As String = "Pais"
    Public Const gc_strLP_V_TipoDoc As String = "Tipo Doc"
    Public Const gc_strLP_F_Modif As String = "F Modificacion"
    '######################################################

    '######################################################
    'Empresas (FactuSOL)
    '------------------------------------------------------
    Public Const gc_strLP_I_Empresa As String = "Id Empresa"
    Public Const gc_strLP_D_NIFEmpresa As String = "NIF"
    Public Const gc_strLP_D_DenFiscal As String = "Denominacio fiscal"
    Public Const gc_strLP_D_NomEmpresa As String = "Nombre"
    Public Const gc_strLP_D_DomEmpresa As String = "Domicilio"
    Public Const gc_strLP_D_PobEmpresa As String = "Poblacion"
    Public Const gc_strLP_D_CPEmpresa As String = "CP"
    Public Const gc_strLP_D_ProvEmpresa As String = "Provincia"
    Public Const gc_strLP_D_Ejercicio As String = "Ejercicio"
    '######################################################
End Module
