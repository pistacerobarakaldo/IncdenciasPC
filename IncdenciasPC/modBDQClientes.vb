Option Explicit On
Option Compare Text

Module modBDQClientes

    'Constante que guarda el nombre del mudolu
    Const mc_strNombre_Modulo As String = "modBDQClientes"

    '<CABECERA>-----------------------------------------------
    'Descripcion......: Genera la query para obtener los clientes
    'Fecha............: 22/05/2014
    '<FIN CABECERA>-------------------------------------------
    Public Function Clie_strQueryObtenerClientes(Optional ByVal lngIdCliente As Long = -1, Optional ByVal strWhere As String = "") As String

        Const strNombre_Funcion As String = "Clie_strQueryObtenerClientes"
        Dim blnError As Boolean

        Dim strQuery As String = ""

        Try
            'SELECT
            strQuery = "SELECT " & gc_strDB_TABLA_Clientes & "." & gc_strDB_I_Cliente
            strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_I_Cliente)
            strQuery = strQuery & ", " & gc_strDB_TABLA_Clientes & "." & gc_strDB_D_NIFCliente
            strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_D_NIFCliente)
            strQuery = strQuery & ", " & gc_strDB_TABLA_Clientes & "." & gc_strDB_D_NomFiscal
            strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_D_NomFiscal)
            strQuery = strQuery & ", " & gc_strDB_TABLA_Clientes & "." & gc_strDB_D_NomCliente
            strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_D_NomCliente)
            strQuery = strQuery & ", " & gc_strDB_TABLA_Clientes & "." & gc_strDB_D_Telefono
            strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_D_Telefono)
            strQuery = strQuery & ", " & gc_strDB_TABLA_Clientes & "." & gc_strDB_D_Movil
            strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_D_Movil)
            strQuery = strQuery & ", " & gc_strDB_TABLA_Clientes & "." & gc_strDB_D_ContCliente
            strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_D_ContCliente)
            strQuery = strQuery & ", " & gc_strDB_TABLA_Clientes & "." & gc_strDB_D_DomCliente
            strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_D_DomCliente)
            strQuery = strQuery & ", " & gc_strDB_TABLA_Clientes & "." & gc_strDB_D_PobCliente
            strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_D_PobCliente)
            strQuery = strQuery & ", " & gc_strDB_TABLA_Clientes & "." & gc_strDB_D_CPCliente
            strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_D_CPCliente)
            strQuery = strQuery & ", " & gc_strDB_TABLA_Clientes & "." & gc_strDB_D_PorvCliente
            strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_D_PorvCliente)
            strQuery = strQuery & ", " & gc_strDB_TABLA_Clientes & "." & gc_strDB_D_Pais
            strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_D_Pais)
            strQuery = strQuery & ", " & gc_strDB_TABLA_Clientes & "." & gc_strDB_D_Fax
            strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_D_Fax)
            strQuery = strQuery & ", " & gc_strDB_TABLA_Clientes & "." & gc_strDB_D_Email
            strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_D_Email)
            strQuery = strQuery & ", " & gc_strDB_TABLA_Clientes & "." & gc_strDB_D_Observ
            strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_D_Observ)
            strQuery = strQuery & ", " & gc_strDB_TABLA_Clientes & "." & gc_strDB_F_Alta
            strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_F_Alta)
            strQuery = strQuery & ", " & gc_strDB_TABLA_Clientes & "." & gc_strDB_F_Modif
            strQuery = strQuery & " AS " & strPonerCorchetes(gc_strLP_F_Modif)
            strQuery = strQuery & ", " & gc_strDB_TABLA_Clientes & "." & gc_strDB_D_FormaPago
            strQuery = strQuery & ", " & gc_strDB_TABLA_Clientes & "." & gc_strDB_V_Tarifa
            strQuery = strQuery & ", " & gc_strDB_TABLA_Clientes & "." & gc_strDB_V_TipoDoc
            strQuery = strQuery & vbCrLf

            'FROM
            strQuery = strQuery & "FROM " & gc_strDB_TABLA_Clientes
            strQuery = strQuery & vbCrLf

            'WHERE
            If strWhere <> "" Then
                strQuery = strQuery & strWhere
            Else
                If lngIdCliente <> -1 Then
                    strQuery = strQuery & "WHERE " & gc_strDB_TABLA_Clientes & "." & gc_strDB_I_Cliente & " = " & lngIdCliente
                    strQuery = strQuery & vbCrLf
                End If
            End If

            'ORDER BY
            strQuery = strQuery & "ORDER BY " & gc_strDB_TABLA_Clientes & "." & gc_strDB_D_NomFiscal
        Catch ex As Exception
            blnError = True
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        Finally
            If blnError Then
                Clie_strQueryObtenerClientes = ""
            Else
                Clie_strQueryObtenerClientes = strQuery
            End If
        End Try
    End Function

    '<CABECERA>-----------------------------------------------
    'Descripcion......: Genera la query para añadir un nuevo cliente
    'Fecha............: 22/05/2014
    '<FIN CABECERA>-------------------------------------------
    Public Function Clie_strQueryNuevoCliente(ByVal objCliente As clsCliente) As String

        Const strNombre_Funcion As String = "Clie_strQueryNuevoCliente"
        Dim blnError As Boolean

        Dim strQuery As String = ""

        Try
            'INSERT INTO
            strQuery = "INSERT INTO " & gc_strDB_TABLA_Clientes & " ("
            strQuery = strQuery & gc_strDB_I_Cliente
            strQuery = strQuery & ", " & gc_strDB_D_NIFCliente
            strQuery = strQuery & ", " & gc_strDB_D_NomFiscal
            strQuery = strQuery & ", " & gc_strDB_D_NomCliente
            strQuery = strQuery & ", " & gc_strDB_D_Telefono
            strQuery = strQuery & ", " & gc_strDB_D_Movil
            strQuery = strQuery & ", " & gc_strDB_D_ContCliente
            strQuery = strQuery & ", " & gc_strDB_D_DomCliente
            strQuery = strQuery & ", " & gc_strDB_D_PobCliente
            strQuery = strQuery & ", " & gc_strDB_D_CPCliente
            strQuery = strQuery & ", " & gc_strDB_D_PorvCliente
            strQuery = strQuery & ", " & gc_strDB_D_Pais
            strQuery = strQuery & ", " & gc_strDB_D_Fax
            strQuery = strQuery & ", " & gc_strDB_D_Email
            strQuery = strQuery & ", " & gc_strDB_D_Observ
            strQuery = strQuery & ", " & gc_strDB_F_Alta
            strQuery = strQuery & ", " & gc_strDB_F_Modif
            strQuery = strQuery & ", " & gc_strDB_D_FormaPago
            strQuery = strQuery & ", " & gc_strDB_V_Tarifa
            strQuery = strQuery & ", " & gc_strDB_V_TipoDoc
            strQuery = strQuery & ")"
            strQuery = strQuery & vbCrLf

            'VALUES
            strQuery = strQuery & "VALUES ("
            strQuery = strQuery & objCliente.Id
            strQuery = strQuery & ", '" & objCliente.NIF & "'"
            strQuery = strQuery & ", '" & objCliente.NombreFiscal & "'"
            strQuery = strQuery & ", '" & objCliente.NombreComercial & "'"
            strQuery = strQuery & ", '" & objCliente.Telefono & "'"
            strQuery = strQuery & ", '" & objCliente.Movil & "'"
            strQuery = strQuery & ", '" & objCliente.Contacto & "'"
            strQuery = strQuery & ", '" & objCliente.Domicilio & "'"
            strQuery = strQuery & ", '" & objCliente.Poblacion & "'"
            strQuery = strQuery & ", '" & objCliente.CP & "'"
            strQuery = strQuery & ", '" & objCliente.Provincia & "'"
            strQuery = strQuery & ", '" & objCliente.Pais & "'"
            strQuery = strQuery & ", '" & objCliente.Fax & "'"
            strQuery = strQuery & ", '" & objCliente.eMail & "'"
            strQuery = strQuery & ", '" & objCliente.Observaciones & "'"
            strQuery = strQuery & ", #" & Format(objCliente.FechaAlta, "MM/dd/yyyy") & "#"
            strQuery = strQuery & ", #" & Format(objCliente.FechaModificacion, "MM/dd/yyyy") & "#"
            strQuery = strQuery & ", " & objCliente.FormaPago
            strQuery = strQuery & ", " & objCliente.Tarifa
            strQuery = strQuery & ", " & objCliente.TipoDocumento
            strQuery = strQuery & ")"
            strQuery = strQuery & vbCrLf
        Catch ex As Exception
            blnError = True
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        Finally
            If blnError Then
                Clie_strQueryNuevoCliente = ""
            Else
                Clie_strQueryNuevoCliente = strQuery
            End If
        End Try
    End Function

    '<CABECERA>-----------------------------------------------
    'Descripcion......: Genera la query para modificar un cliente
    'Fecha............: 22/05/2014
    '<FIN CABECERA>-------------------------------------------
    Public Function Clie_strQueryModificarCliente(ByVal objCliente As clsCliente) As String

        Const strNombre_Funcion As String = "Clie_strQueryModificarCliente"
        Dim blnError As Boolean

        Dim strQuery As String = ""

        Try
            'SELECT
            strQuery = "UPDATE " & gc_strDB_TABLA_Clientes
            strQuery = strQuery & vbCrLf

            'SET
            strQuery = strQuery & "SET " & gc_strDB_D_NIFCliente
            strQuery = strQuery & " = '" & objCliente.NIF & "'"
            strQuery = strQuery & ", " & gc_strDB_D_NomFiscal
            strQuery = strQuery & " = '" & objCliente.NombreFiscal & "'"
            strQuery = strQuery & ", " & gc_strDB_D_NomCliente
            strQuery = strQuery & " = '" & objCliente.NombreComercial & "'"
            strQuery = strQuery & ", " & gc_strDB_D_Telefono
            strQuery = strQuery & " = '" & objCliente.Telefono & "'"
            strQuery = strQuery & ", " & gc_strDB_D_Movil
            strQuery = strQuery & " = '" & objCliente.Movil & "'"
            strQuery = strQuery & ", " & gc_strDB_D_ContCliente
            strQuery = strQuery & " = '" & objCliente.Contacto & "'"
            strQuery = strQuery & ", " & gc_strDB_D_DomCliente
            strQuery = strQuery & " = '" & objCliente.Domicilio & "'"
            strQuery = strQuery & ", " & gc_strDB_D_PobCliente
            strQuery = strQuery & " = '" & objCliente.Poblacion & "'"
            strQuery = strQuery & ", " & gc_strDB_D_CPCliente
            strQuery = strQuery & " = '" & objCliente.CP & "'"
            strQuery = strQuery & ", " & gc_strDB_D_PorvCliente
            strQuery = strQuery & " = '" & objCliente.Provincia & "'"
            strQuery = strQuery & ", " & gc_strDB_D_Pais
            strQuery = strQuery & " = '" & objCliente.Pais & "'"
            strQuery = strQuery & ", " & gc_strDB_D_Fax
            strQuery = strQuery & " = '" & objCliente.Fax & "'"
            strQuery = strQuery & ", " & gc_strDB_D_Email
            strQuery = strQuery & " = '" & objCliente.eMail & "'"
            strQuery = strQuery & ", " & gc_strDB_D_Observ
            strQuery = strQuery & " = '" & objCliente.Observaciones & "'"
            strQuery = strQuery & ", " & gc_strDB_F_Modif
            strQuery = strQuery & " = #" & Format(Date.Today, "MM/dd/yyyy") & "#"
            strQuery = strQuery & vbCrLf

            'WHERE
            strQuery = strQuery & "WHERE " & gc_strDB_I_Cliente & " = " & objCliente.Id
        Catch ex As Exception
            blnError = True
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        Finally
            If blnError Then
                Clie_strQueryModificarCliente = ""
            Else
                Clie_strQueryModificarCliente = strQuery
            End If
        End Try
    End Function
End Module
