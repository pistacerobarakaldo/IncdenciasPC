Public Class clsCliente
    'Constante que guarda el nombre del mudulo
    Const mc_strNombre_Modulo As String = "clsCliente"

    'Propiedades basicas
    Private m_lngId As Long
    Private m_strNIF As String
    Private m_strNomFiscal As String
    Private m_strNomComercial As String
    Private m_strDomicilio As String
    Private m_strCP As String
    Private m_strPoblacion As String
    Private m_strProvincia As String
    Private m_strTelefono As String
    Private m_strMovil As String
    Private m_strFax As String
    Private m_strContacto As String
    Private m_strFormaPago As String '0
    Private m_lngTarifa As Long '1
    Private m_dteFechaAlta As Date
    Private m_strEmail As String
    Private m_strObservaciones As String
    Private m_strPais As String
    Private m_lngTipoDoc As Long '1
    Private m_dteFechaModif As Date

    '<CABECERA>-----------------------------------------------
    'Descripcion......: Inicializa las variables del objeto
    'Fecha............: 29/04/2014
    '<FIN CABECERA>-------------------------------------------
    Public Sub New(Optional ByVal dtrRow As DataGridViewRow = Nothing, Optional ByVal lngId As Long = -1)

        Const strNombre_Funcion As String = "New"

        Dim dttTable As DataTable
        Dim objRegistro As DataRow

        Try
            If Not dtrRow Is Nothing Then
                m_lngId = dtrRow.Cells(gc_strLP_I_Cliente).Value
                m_strNIF = dtrRow.Cells(gc_strLP_D_NIFCliente).Value
                m_strNomFiscal = dtrRow.Cells(gc_strLP_D_NomFiscal).Value
                m_strNomComercial = dtrRow.Cells(gc_strLP_D_NomCliente).Value
                m_strDomicilio = dtrRow.Cells(gc_strLP_D_DomCliente).Value
                m_strCP = dtrRow.Cells(gc_strLP_D_CPCliente).Value
                m_strPoblacion = dtrRow.Cells(gc_strLP_D_PobCliente).Value
                m_strProvincia = dtrRow.Cells(gc_strLP_D_PorvCliente).Value
                m_strPais = dtrRow.Cells(gc_strLP_D_Pais).Value
                m_strTelefono = dtrRow.Cells(gc_strLP_D_Telefono).Value
                m_strMovil = dtrRow.Cells(gc_strLP_D_Movil).Value
                m_strFax = dtrRow.Cells(gc_strLP_D_Fax).Value
                m_strEmail = dtrRow.Cells(gc_strLP_D_Email).Value
                m_strContacto = dtrRow.Cells(gc_strLP_D_ContCliente).Value
                m_strObservaciones = dtrRow.Cells(gc_strLP_D_Observ).Value
                m_dteFechaAlta = dtrRow.Cells(gc_strLP_F_Alta).Value
                m_dteFechaModif = dtrRow.Cells(gc_strLP_F_Modif).Value
                m_lngTipoDoc = dtrRow.Cells(gc_strDB_V_TipoDoc).Value
                m_strFormaPago = dtrRow.Cells(gc_strDB_D_FormaPago).Value
                m_lngTarifa = dtrRow.Cells(gc_strDB_V_Tarifa).Value
            Else
                If lngId <> -1 Then
                    dttTable = Clie_dttObtenerClientes(lngId)
                    If Not dttTable Is Nothing Then
                        If dttTable.Rows.Count > 0 Then
                            objRegistro = dttTable.Rows(0)

                            m_lngId = objRegistro(gc_strLP_I_Cliente)
                            m_strNIF = objRegistro(gc_strLP_D_NIFCliente)
                            m_strNomFiscal = objRegistro(gc_strLP_D_NomFiscal)
                            m_strNomComercial = objRegistro(gc_strLP_D_NomCliente)
                            m_strDomicilio = objRegistro(gc_strLP_D_DomCliente)
                            m_strCP = objRegistro(gc_strLP_D_CPCliente)
                            m_strPoblacion = objRegistro(gc_strLP_D_PobCliente)
                            m_strProvincia = objRegistro(gc_strLP_D_PorvCliente)
                            m_strPais = objRegistro(gc_strLP_D_Pais)
                            m_strTelefono = objRegistro(gc_strLP_D_Telefono)
                            m_strMovil = objRegistro(gc_strLP_D_Movil)
                            m_strFax = objRegistro(gc_strLP_D_Fax)
                            m_strEmail = objRegistro(gc_strLP_D_Email)
                            m_strContacto = objRegistro(gc_strLP_D_ContCliente)
                            m_strObservaciones = objRegistro(gc_strLP_D_Observ)
                            m_dteFechaAlta = Format(Date.Parse(objRegistro(gc_strLP_F_Alta)), "dd/MM/yyyy")
                            m_dteFechaModif = Format(Date.Parse(objRegistro(gc_strLP_F_Modif)), "dd/MM/yyyy")
                            m_lngTipoDoc = objRegistro(gc_strDB_V_TipoDoc)
                            m_strFormaPago = objRegistro(gc_strDB_D_FormaPago)
                            m_lngTarifa = objRegistro(gc_strDB_V_Tarifa)
                        Else
                            m_lngId = 0
                            m_strNIF = ""
                            m_strNomFiscal = ""
                            m_strNomComercial = ""
                            m_strDomicilio = ""
                            m_strCP = ""
                            m_strPoblacion = ""
                            m_strProvincia = ""
                            m_strPais = ""
                            m_strTelefono = ""
                            m_strMovil = ""
                            m_strFax = ""
                            m_strEmail = ""
                            m_strContacto = ""
                            m_strObservaciones = ""
                            m_dteFechaAlta = Date.Today
                            m_dteFechaModif = Date.Today
                            m_lngTipoDoc = 1
                            m_strFormaPago = ""
                            m_lngTarifa = 1
                        End If
                    Else
                        m_lngId = 0
                        m_strNIF = ""
                        m_strNomFiscal = ""
                        m_strNomComercial = ""
                        m_strDomicilio = ""
                        m_strCP = ""
                        m_strPoblacion = ""
                        m_strProvincia = ""
                        m_strPais = ""
                        m_strTelefono = ""
                        m_strMovil = ""
                        m_strFax = ""
                        m_strEmail = ""
                        m_strContacto = ""
                        m_strObservaciones = ""
                        m_dteFechaAlta = Date.Today
                        m_dteFechaModif = Date.Today
                        m_lngTipoDoc = 1
                        m_strFormaPago = ""
                        m_lngTarifa = 1
                    End If
                Else
                    m_lngId = 0
                    m_strNIF = ""
                    m_strNomFiscal = ""
                    m_strNomComercial = ""
                    m_strDomicilio = ""
                    m_strCP = ""
                    m_strPoblacion = ""
                    m_strProvincia = ""
                    m_strPais = ""
                    m_strTelefono = ""
                    m_strMovil = ""
                    m_strFax = ""
                    m_strEmail = ""
                    m_strContacto = ""
                    m_strObservaciones = ""
                    m_dteFechaAlta = Date.Today
                    m_dteFechaModif = Date.Today
                    m_lngTipoDoc = 1
                    m_strFormaPago = ""
                    m_lngTarifa = 1
                End If
            End If
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Public Property Id() As Long
        Get
            Return m_lngId
        End Get
        Set(ByVal value As Long)
            m_lngId = value
        End Set
    End Property

    Public Property NIF() As String
        Get
            Return m_strNIF
        End Get
        Set(ByVal value As String)
            m_strNIF = value
        End Set
    End Property

    Public Property NombreFiscal() As String
        Get
            Return m_strNomFiscal
        End Get
        Set(ByVal value As String)
            m_strNomFiscal = value
        End Set
    End Property

    Public Property NombreComercial() As String
        Get
            Return m_strNomComercial
        End Get
        Set(ByVal value As String)
            m_strNomComercial = value
        End Set
    End Property

    Public Property Domicilio() As String
        Get
            Return m_strDomicilio
        End Get
        Set(ByVal value As String)
            m_strDomicilio = value
        End Set
    End Property

    Public Property CP() As String
        Get
            Return m_strCP
        End Get
        Set(ByVal value As String)
            m_strCP = value
        End Set
    End Property

    Public Property Poblacion() As String
        Get
            Return m_strPoblacion
        End Get
        Set(ByVal value As String)
            m_strPoblacion = value
        End Set
    End Property

    Public Property Provincia() As String
        Get
            Return m_strProvincia
        End Get
        Set(ByVal value As String)
            m_strProvincia = value
        End Set
    End Property

    Public Property Telefono() As String
        Get
            Return m_strTelefono
        End Get
        Set(ByVal value As String)
            m_strTelefono = value
        End Set
    End Property

    Public Property Movil() As String
        Get
            Return m_strMovil
        End Get
        Set(ByVal value As String)
            m_strMovil = value
        End Set
    End Property

    Public Property Fax() As String
        Get
            Return m_strFax
        End Get
        Set(ByVal value As String)
            m_strFax = value
        End Set
    End Property

    Public Property Contacto() As String
        Get
            Return m_strContacto
        End Get
        Set(ByVal value As String)
            m_strContacto = value
        End Set
    End Property

    Public Property FormaPago() As String
        Get
            Return m_strFormaPago
        End Get
        Set(ByVal value As String)
            m_strFormaPago = value
        End Set
    End Property

    Public Property Tarifa() As Long
        Get
            Return m_lngTarifa
        End Get
        Set(ByVal value As Long)
            m_lngTarifa = value
        End Set
    End Property

    Public Property FechaAlta() As Date
        Get
            Return m_dteFechaAlta
        End Get
        Set(ByVal value As Date)
            m_dteFechaAlta = value
        End Set
    End Property

    Public Property eMail() As String
        Get
            Return m_strEmail
        End Get
        Set(ByVal value As String)
            m_strEmail = value
        End Set
    End Property

    Public Property Observaciones() As String
        Get
            Return m_strObservaciones
        End Get
        Set(ByVal value As String)
            m_strObservaciones = value
        End Set
    End Property

    Public Property Pais() As String
        Get
            Return m_strPais
        End Get
        Set(ByVal value As String)
            m_strPais = value
        End Set
    End Property

    Public Property TipoDocumento() As Long
        Get
            Return m_lngTipoDoc
        End Get
        Set(ByVal value As Long)
            m_lngTipoDoc = value
        End Set
    End Property

    Public Property FechaModificacion() As Date
        Get
            Return m_dteFechaModif
        End Get
        Set(ByVal value As Date)
            m_dteFechaModif = value
        End Set
    End Property
End Class
