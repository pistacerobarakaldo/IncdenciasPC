Option Explicit On
Option Compare Text

Module modBDConstantes
    'Constante que guarda el nombre del mudolu
    Const mc_strNombre_Modulo As String = "modBDConstantes"

    '######################################################
    'Equipos
    '------------------------------------------------------
    'TABLA
    '------------------------------------------------------
    Public Const gc_strDB_TABLA_Equipos As String = "Equipos"
    '------------------------------------------------------
    'CAMPOS
    '------------------------------------------------------
    Public Const gc_strDB_I_Equipo As String = "I_Equipo"
    Public Const gc_strDB_D_NSerie As String = "D_NSerie"
    Public Const gc_strDB_D_Equipo As String = "D_Equipo"
    Public Const gc_strDB_D_CPU As String = "D_CPU"
    Public Const gc_strDB_D_Grafica As String = "D_Grafica"
    Public Const gc_strDB_D_Memoria As String = "D_Memoria"
    Public Const gc_strDB_D_SO As String = "D_SO"
    Public Const gc_strDB_B_Activo As String = "B_Activo"
    '######################################################

    '######################################################
    'Estados
    '------------------------------------------------------
    'TABLA
    '------------------------------------------------------
    Public Const gc_strDB_TABLA_Estados As String = "Estados"
    '------------------------------------------------------
    'CAMPOS
    '------------------------------------------------------
    Public Const gc_strDB_I_Estado As String = "I_Estado"
    Public Const gc_strDB_D_Estado As String = "D_estado"
    '######################################################

    '######################################################
    'Impresoras
    '------------------------------------------------------
    'TABLA
    '------------------------------------------------------
    Public Const gc_strDB_TABLA_Impresoras As String = "Impresoras"
    '------------------------------------------------------
    'CAMPOS
    '------------------------------------------------------
    Public Const gc_strDB_I_Impresora As String = "I_Impresora"
    'Public Const gc_strDB_D_NSerie As String = "D_NSerie"
    Public Const gc_strDB_D_Impresora As String = "D_Impresora"
    Public Const gc_strDB_D_Marca As String = "D_Marca"
    Public Const gc_strDB_D_Modelo As String = "D_Modelo"
    Public Const gc_strDB_B_Color As String = "B_Color"
    Public Const gc_strDB_B_Multifuncion As String = "B_Multifuncion"
    Public Const gc_strDB_B_Fax As String = "B_Fax"
    Public Const gc_strDB_B_Red As String = "B_Red"
    'Public Const gc_strDB_B_Activo As String = "B_Activo"
    '######################################################

    '######################################################
    'Incidencias
    '------------------------------------------------------
    'TABLA
    '------------------------------------------------------
    Public Const gc_strDB_TABLA_Incidencias As String = "Incidencias"
    '------------------------------------------------------
    'CAMPOS
    '------------------------------------------------------
    Public Const gc_strDB_I_Incidencia As String = "I_Incidencia"
    Public Const gc_strDB_C_Cliente As String = "C_Cliente"
    Public Const gc_strDB_D_Cliente As String = "D_Cliente"
    Public Const gc_strDB_D_Contacto As String = "D_Contacto"
    Public Const gc_strDB_D_Telefono1 As String = "D_Telefono1"
    Public Const gc_strDB_D_Telefono2 As String = "D_Telefono2"
    Public Const gc_strDB_F_Entrada As String = "F_Entrada"
    Public Const gc_strDB_C_Tipo As String = "C_Tipo"
    'Public Const gc_strDB_D_Marca As String = "D_Marca"
    'Public Const gc_strDB_D_Modelo As String = "D_Modelo"
    'Public Const gc_strDB_D_NSerie As String = "D_NSerie"
    Public Const gc_strDB_D_Obser As String = "D_Obser"
    Public Const gc_strDB_B_Maletin As String = "B_Maletin"
    Public Const gc_strDB_B_Cargador As String = "B_Cargador"
    Public Const gc_strDB_D_Averia As String = "D_Averia"
    Public Const gc_strDB_D_Resolucion As String = "D_Resolucion"
    Public Const gc_strDB_V_Importe As String = "V_Importe"
    Public Const gc_strDB_C_Estado As String = "C_Estado"
    Public Const gc_strDB_B_Garantia As String = "B_Garantia"
    '######################################################

    '######################################################
    'LineasPresupuesto
    '------------------------------------------------------
    'TABLA
    '------------------------------------------------------
    Public Const gc_strDB_TABLA_LineasPresupuesto As String = "LineasPresupuesto"
    '------------------------------------------------------
    'CAMPOS
    '------------------------------------------------------
    Public Const gc_strDB_C_Incidencia As String = "C_Incidencia"
    Public Const gc_strDB_C_Linea As String = "C_Linea"
    Public Const gc_strDB_D_Concepto As String = "D_Concepto"
    'Public Const gc_strDB_V_Importe As String = "V_Importe"
    Public Const gc_strDB_V_Cantidad As String = "V_Cantidad"
    Public Const gc_strDB_V_Base As String = "V_Base"
    Public Const gc_strDB_V_PIVA As String = "V_PIVA"
    Public Const gc_strDB_V_IVA As String = "V_IVA"
    Public Const gc_strDB_V_Total As String = "V_Total"
    '######################################################

    '######################################################
    'LineasActuacion
    '------------------------------------------------------
    'TABLA
    '------------------------------------------------------
    Public Const gc_strDB_TABLA_LineasActuacion As String = "LineasActuacion"
    '------------------------------------------------------
    'CAMPOS
    '------------------------------------------------------
    'Public Const gc_strDB_C_Incidencia As String = "C_Incidencia"
    'Public Const gc_strDB_C_Linea As String = "C_Linea"
    'Public Const gc_strDB_C_Estado As String = "C_Estado"
    Public Const gc_strDB_F_Fecha As String = "F_Fecha"
    Public Const gc_strDB_D_Descripcion As String = "D_Descripcion"
    '######################################################

    '######################################################
    'LicenciasSDELSOL
    '------------------------------------------------------
    'TABLA
    '------------------------------------------------------
    Public Const gc_strDB_TABLA_LicenciasSDELSOL As String = "LicenciasSDELSOL"
    '------------------------------------------------------
    'CAMPOS
    '------------------------------------------------------
    Public Const gc_strDB_I_Licencia As String = "I_Licencia"
    Public Const gc_strDB_D_Licencia As String = "D_Licencia"
    '######################################################

    '######################################################
    'M_Backup
    '------------------------------------------------------
    'TABLA
    '------------------------------------------------------
    Public Const gc_strDB_TABLA_M_Backup As String = "M_Backup"
    '------------------------------------------------------
    'CAMPOS
    '------------------------------------------------------
    Public Const gc_strDB_I_Backup As String = "I_Backup"
    Public Const gc_strDB_F_Inicio As String = "F_Inicio"
    Public Const gc_strDB_F_Fin As String = "F_Fin"
    Public Const gc_strDB_D_User As String = "D_User"
    Public Const gc_strDB_D_Password As String = "D_Password"
    Public Const gc_strDB_C_TipoBackup As String = "C_TipoBackup"
    Public Const gc_strDB_V_Precio As String = "V_Precio"
    '######################################################

    '######################################################
    'M_Dominios
    '------------------------------------------------------
    'TABLA
    '------------------------------------------------------
    Public Const gc_strDB_TABLA_M_Dominios As String = "M_Dominios"
    '------------------------------------------------------
    'CAMPOS
    '------------------------------------------------------
    Public Const gc_strDB_I_Dominio As String = "I_Dominio"
    Public Const gc_strDB_D_Dominio As String = "D_Dominio"
    'Public Const gc_strDB_F_Inicio As String = "F_Inicio"
    'Public Const gc_strDB_F_Fin As String = "F_Fin"
    'Public Const gc_strDB_V_Precio As String = "V_Precio"
    '######################################################

    '######################################################
    'M_Hardware
    '------------------------------------------------------
    'TABLA
    '------------------------------------------------------
    Public Const gc_strDB_TABLA_M_Hardware As String = "M_Hardware"
    '------------------------------------------------------
    'CAMPOS
    '------------------------------------------------------
    Public Const gc_strDB_I_Hardware As String = "I_Hardware"
    'Public Const gc_strDB_F_Inicio As String = "F_Inicio"
    'Public Const gc_strDB_F_Fin As String = "F_Fin"
    'Public Const gc_strDB_V_Precio As String = "V_Precio"
    '######################################################

    '######################################################
    'M_Software
    '------------------------------------------------------
    'TABLA
    '------------------------------------------------------
    Public Const gc_strDB_TABLA_M_Software As String = "M_Software"
    '------------------------------------------------------
    'CAMPOS
    '------------------------------------------------------
    Public Const gc_strDB_I_Software As String = "I_Software"
    'Public Const gc_strDB_F_Inicio As String = "F_Inicio"
    'Public Const gc_strDB_F_Fin As String = "F_Fin"
    Public Const gc_strDB_C_Programa As String = "C_Programa"
    Public Const gc_strDB_C_LicenciaSDELSOL As String = "C_LicenciaSDELSOL"
    Public Const gc_strDB_D_UserSDELSOL As String = "D_UserSDELSOL"
    Public Const gc_strDB_D_PassSDELSOL As String = "D_PassSDELSOL"
    Public Const gc_strDB_V_Puestos As String = "V_Puestos"
    'Public Const gc_strDB_V_Precio As String = "V_Precio"
    '######################################################

    '######################################################
    'M_Web
    '------------------------------------------------------
    'TABLA
    '------------------------------------------------------
    Public Const gc_strDB_TABLA_M_Web As String = "M_Web"
    '------------------------------------------------------
    'CAMPOS
    '------------------------------------------------------
    Public Const gc_strDB_I_Web As String = "I_Web"
    'Public Const gc_strDB_F_Inicio As String = "F_Inicio"
    'Public Const gc_strDB_F_Fin As String = "F_Fin"
    Public Const gc_strDB_D_TipoHosting As String = "D_TipoHosting"
    Public Const gc_strDB_F_InicioHosting As String = "F_InicioHosting"
    Public Const gc_strDB_F_FinHosting As String = "F_FinHosting"
    Public Const gc_strDB_B_MantWeb As String = "B_MantWeb"
    Public Const gc_strDB_B_SEO As String = "B_SEO"
    Public Const gc_strDB_B_SEM As String = "B_SEM"
    Public Const gc_strDB_B_RedesSociales As String = "B_RedesSociales"
    'Public Const gc_strDB_D_Obser As String = "D_Obser"
    'Public Const gc_strDB_V_Precio As String = "V_Precio"
    '######################################################

    '######################################################
    'Mantenimientos
    '------------------------------------------------------
    'TABLA
    '------------------------------------------------------
    Public Const gc_strDB_TABLA_Mantenimientos As String = "Mantenimientos"
    '------------------------------------------------------
    'CAMPOS
    '------------------------------------------------------
    Public Const gc_strDB_I_Mantenimiento As String = "I_Mantenimiento"
    'Public Const gc_strDB_C_Cliente As String = "C_Cliente"
    'Public Const gc_strDB_D_Cliente As String = "D_Cliente"
    Public Const gc_strDB_C_Hardware As String = "C_Hardware"
    Public Const gc_strDB_C_Software As String = "C_Software"
    Public Const gc_strDB_C_Web As String = "C_Web"
    Public Const gc_strDB_C_Backup As String = "C_Backup"
    '######################################################

    '######################################################
    'Programas
    '------------------------------------------------------
    'TABLA
    '------------------------------------------------------
    Public Const gc_strDB_TABLA_Programas As String = "Programas"
    '------------------------------------------------------
    'CAMPOS
    '------------------------------------------------------
    Public Const gc_strDB_I_Programa As String = "I_Programa"
    Public Const gc_strDB_D_Programa As String = "D_Programa"
    '######################################################

    '######################################################
    'R_Hardware_Equipos
    '------------------------------------------------------
    'TABLA
    '------------------------------------------------------
    Public Const gc_strDB_TABLA_R_Hardware_Equipos As String = "R_Hardware_Equipos"
    '------------------------------------------------------
    'CAMPOS
    '------------------------------------------------------
    Public Const gc_strDB_I_Relacion As String = "I_Relacion"
    'Public Const gc_strDB_C_Hardware As String = "C_Hardware"
    Public Const gc_strDB_C_Equipo As String = "C_Equipo"
    '######################################################

    '######################################################
    'R_Hardware_Impresoras
    '------------------------------------------------------
    'TABLA
    '------------------------------------------------------
    Public Const gc_strDB_TABLA_R_Hardware_Impresoras As String = "R_Hardware_Impresoras"
    '------------------------------------------------------
    'CAMPOS
    '------------------------------------------------------
    'Public Const gc_strDB_I_Relacion As String = "I_Relacion"
    'Public Const gc_strDB_C_Hardware As String = "C_Hardware"
    Public Const gc_strDB_C_Impresora As String = "C_Impresora"
    '######################################################

    '######################################################
    'R_Web_Dominio
    '------------------------------------------------------
    'TABLA
    '------------------------------------------------------
    Public Const gc_strDB_TABLA_R_Web_Dominio As String = "R_Web_Dominio"
    '------------------------------------------------------
    'CAMPOS
    '------------------------------------------------------
    'Public Const gc_strDB_I_Relacion As String = "I_Relacion"
    'Public Const gc_strDB_C_Web As String = "C_Web"
    Public Const gc_strDB_C_Dominio As String = "C_Dominio"
    '######################################################

    '######################################################
    'TiposBackup
    '------------------------------------------------------
    'TABLA
    '------------------------------------------------------
    Public Const gc_strDB_TABLA_TiposBackup As String = "TiposBackup"
    '------------------------------------------------------
    'CAMPOS
    '------------------------------------------------------
    Public Const gc_strDB_I_TipoBackup As String = "I_TipoBackup"
    Public Const gc_strDB_D_TipoBackup As String = "D_TipoBackup"

    '######################################################
    'TiposEquipos
    '------------------------------------------------------
    'TABLA
    '------------------------------------------------------
    Public Const gc_strDB_TABLA_TiposEquipos As String = "TiposEquipos"
    '------------------------------------------------------
    'CAMPOS
    '------------------------------------------------------
    Public Const gc_strDB_I_TipoEquipo As String = "I_TipoEquipo"
    Public Const gc_strDB_D_TipoEquipo As String = "D_TipoEquipo"
    '######################################################

    '############################################################################################################
    '######################################## * * * FactuSOL * * * ##############################################
    '############################################################################################################

    '######################################################
    'Clientes
    '------------------------------------------------------
    'TABLA
    '------------------------------------------------------
    Public Const gc_strDB_TABLA_Clientes As String = "F_CLI"
    '------------------------------------------------------
    'CAMPOS
    '------------------------------------------------------
    Public Const gc_strDB_I_Cliente As String = "CODCLI"
    Public Const gc_strDB_D_NIFCliente As String = "NIFCLI"
    Public Const gc_strDB_D_NomFiscal As String = "NOFCLI"
    Public Const gc_strDB_D_NomCliente As String = "NOCCLI"
    Public Const gc_strDB_D_DomCliente As String = "DOMCLI"
    Public Const gc_strDB_D_PobCliente As String = "POBCLI"
    Public Const gc_strDB_D_CPCliente As String = "CPOCLI"
    Public Const gc_strDB_D_PorvCliente As String = "PROCLI"
    Public Const gc_strDB_D_Telefono As String = "TELCLI"
    Public Const gc_strDB_D_Fax As String = "FAXCLI"
    Public Const gc_strDB_D_Movil As String = "MOVCLI"
    Public Const gc_strDB_D_ContCliente As String = "PCOCLI"
    Public Const gc_strDB_D_FormaPago As String = "FPACLI"
    Public Const gc_strDB_V_Tarifa As String = "TARCLI"
    Public Const gc_strDB_F_Alta As String = "FALCLI"
    Public Const gc_strDB_D_Email As String = "EMACLI"
    Public Const gc_strDB_D_Observ As String = "OBSCLI"
    Public Const gc_strDB_D_Pais As String = "PAICLI"
    Public Const gc_strDB_V_TipoDoc As String = "IFICLI"
    Public Const gc_strDB_F_Modif As String = "FUMCLI"
    '######################################################

    '######################################################
    'Empresas
    '------------------------------------------------------
    'TABLA
    '------------------------------------------------------
    Public Const gc_strDB_TABLA_Empresas As String = "F_EMP"
    '------------------------------------------------------
    'CAMPOS
    '------------------------------------------------------
    Public Const gc_strDB_I_Empresa As String = "CODEMP"
    Public Const gc_strDB_D_NIFEmpresa As String = "NIFEMP"
    Public Const gc_strDB_D_DenFiscal As String = "DENEMP"
    Public Const gc_strDB_D_NomEmpresa As String = "NOMEMP"
    Public Const gc_strDB_D_DomEmpresa As String = "DOMEMP"
    Public Const gc_strDB_D_PobEmpresa As String = "POBEMP"
    Public Const gc_strDB_D_CPEmpresa As String = "CPOEMP"
    Public Const gc_strDB_D_ProvEmpresa As String = "PROEMP"
    Public Const gc_strDB_D_Ejercicio As String = "EJEMP"
    '######################################################
End Module

