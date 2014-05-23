Public Class clsIncidencia
    'Constante que guarda el nombre del mudulo
    Const mc_strNombre_Modulo As String = "clsIncidencia"

    'Propiedades basicas
    Private m_lngId As Long
    Private m_dteFecha As Date
    Private m_lngIdCLiente As Long
    Private m_strCliente As String
    Private m_strContacto As String
    Private m_strTelefono1 As String
    Private m_strTelefono2 As String
    Private m_lngTipoEquipo As Long
    Private m_strMarca As String
    Private m_strModelo As String
    Private m_strNSerie As String
    Private m_strObservaciones As String
    Private m_blnMaletin As Boolean
    Private m_blnCargador As Boolean
    Private m_strAveria As String
    Private m_strResolucion As String
    Private m_lngEstado As Long
    Private m_dblImporte As Double
    Private m_blnGarantia As Boolean

    'Lineas de actuacion
    Dim m_dttHistorialActuacion As DataTable

    'Lineas de presupuesto
    Dim m_dttLineasPresupuesto As DataTable

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
                m_lngId = dtrRow.Cells(gc_strLP_I_Incidencia).Value
                m_dteFecha = Format(Date.Parse(dtrRow.Cells(gc_strLP_F_Entrada).Value), "dd/MM/yyyy")
                m_lngIdCLiente = dtrRow.Cells(gc_strLP_C_Cliente).Value
                m_strCliente = dtrRow.Cells(gc_strLP_D_Cliente).Value
                m_strContacto = dtrRow.Cells(gc_strLP_D_Contacto).Value
                m_strTelefono1 = dtrRow.Cells(gc_strLP_D_Telefono1).Value
                m_strTelefono2 = dtrRow.Cells(gc_strLP_D_Telefono2).Value
                m_lngTipoEquipo = dtrRow.Cells(gc_strDB_C_Tipo).Value
                m_strMarca = dtrRow.Cells(gc_strLP_D_Marca).Value
                m_strModelo = dtrRow.Cells(gc_strLP_D_Modelo).Value
                m_strNSerie = dtrRow.Cells(gc_strLP_D_NSerie).Value
                m_strObservaciones = dtrRow.Cells(gc_strLP_D_Obser).Value
                m_blnMaletin = dtrRow.Cells(gc_strLP_B_Maletin).Value
                m_blnCargador = dtrRow.Cells(gc_strLP_B_Cargador).Value
                m_strAveria = dtrRow.Cells(gc_strLP_D_Averia).Value
                m_strResolucion = dtrRow.Cells(gc_strLP_D_Resolucion).Value
                m_lngEstado = dtrRow.Cells(gc_strDB_C_Estado).Value
                m_dblImporte = dtrRow.Cells(gc_strLP_V_Importe).Value
                m_blnGarantia = dtrRow.Cells(gc_strLP_B_Garantia).Value

                m_dttHistorialActuacion = Inci_dttObtenerLineasActuacion(m_lngId)
                m_dttLineasPresupuesto = Inci_dttObtenerLineasPresupuesto(m_lngId)
            Else
                If lngId <> -1 Then
                    dttTable = Inci_dttObtenerIncidencias(lngId)
                    If Not dttTable Is Nothing Then
                        objRegistro = dttTable.Rows(0)

                        m_lngId = objRegistro(gc_strLP_I_Incidencia).ToString
                        m_dteFecha = Format(Date.Parse(objRegistro(gc_strLP_F_Entrada).ToString), "dd/MM/yyyy")
                        m_lngIdCLiente = objRegistro(gc_strLP_C_Cliente).ToString
                        m_strCliente = objRegistro(gc_strLP_D_Cliente).ToString
                        m_strContacto = objRegistro(gc_strLP_D_Contacto).ToString
                        m_strTelefono1 = objRegistro(gc_strLP_D_Telefono1).ToString
                        m_strTelefono2 = objRegistro(gc_strLP_D_Telefono2).ToString
                        m_lngTipoEquipo = objRegistro(gc_strDB_C_Tipo).ToString
                        m_strMarca = objRegistro(gc_strLP_D_Marca).ToString
                        m_strModelo = objRegistro(gc_strLP_D_Modelo).ToString
                        m_strNSerie = objRegistro(gc_strLP_D_NSerie).ToString
                        m_strObservaciones = objRegistro(gc_strLP_D_Obser).ToString
                        m_blnMaletin = objRegistro(gc_strLP_B_Maletin).ToString
                        m_blnCargador = objRegistro(gc_strLP_B_Cargador).ToString
                        m_strAveria = objRegistro(gc_strLP_D_Averia).ToString
                        m_strResolucion = objRegistro(gc_strLP_D_Resolucion).ToString
                        m_lngEstado = objRegistro(gc_strDB_C_Estado).ToString
                        m_dblImporte = objRegistro(gc_strLP_V_Importe).ToString
                        m_blnGarantia = objRegistro(gc_strLP_B_Garantia).ToString

                        m_dttHistorialActuacion = Inci_dttObtenerLineasActuacion(m_lngId)
                        m_dttLineasPresupuesto = Inci_dttObtenerLineasPresupuesto(m_lngId)
                    Else
                        m_lngId = 0
                        m_dteFecha = Date.Today
                        m_lngIdCLiente = 0
                        m_strCliente = ""
                        m_strContacto = ""
                        m_strTelefono1 = ""
                        m_strTelefono2 = ""
                        m_lngTipoEquipo = 0
                        m_strMarca = ""
                        m_strModelo = ""
                        m_strNSerie = ""
                        m_strObservaciones = ""
                        m_blnMaletin = False
                        m_blnCargador = False
                        m_strAveria = ""
                        m_strResolucion = ""
                        m_lngEstado = 1
                        m_dblImporte = 0
                        m_blnGarantia = False

                        m_dttHistorialActuacion = Inci_dttObtenerLineasActuacion(m_lngId)
                        m_dttLineasPresupuesto = Inci_dttObtenerLineasPresupuesto(m_lngId)
                    End If
                Else
                    m_lngId = 0
                    m_dteFecha = Date.Today
                    m_lngIdCLiente = 0
                    m_strCliente = ""
                    m_strContacto = ""
                    m_strTelefono1 = ""
                    m_strTelefono2 = ""
                    m_lngTipoEquipo = 0
                    m_strMarca = ""
                    m_strModelo = ""
                    m_strNSerie = ""
                    m_strObservaciones = ""
                    m_blnMaletin = False
                    m_blnCargador = False
                    m_strAveria = ""
                    m_strResolucion = ""
                    m_lngEstado = 1
                    m_dblImporte = 0
                    m_blnGarantia = False

                    m_dttHistorialActuacion = Inci_dttObtenerLineasActuacion(m_lngId)
                    m_dttLineasPresupuesto = Inci_dttObtenerLineasPresupuesto(m_lngId)
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

    Public Property Fecha() As Date
        Get
            Return m_dteFecha
        End Get
        Set(ByVal value As Date)
            m_dteFecha = value
        End Set
    End Property

    Public Property IdCliente() As Long
        Get
            Return m_lngIdCLiente
        End Get
        Set(ByVal value As Long)
            m_lngIdCLiente = value
        End Set
    End Property

    Public Property Cliente() As String
        Get
            Return m_strCLiente
        End Get
        Set(ByVal value As String)
            m_strCLiente = value
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

    Public Property Telefono1() As String
        Get
            Return m_strTelefono1
        End Get
        Set(ByVal value As String)
            m_strTelefono1 = value
        End Set
    End Property

    Public Property Telefono2() As String
        Get
            Return m_strTelefono2
        End Get
        Set(ByVal value As String)
            m_strTelefono2 = value
        End Set
    End Property

    Public Property TipoEquipo() As Long
        Get
            Return m_lngTipoEquipo
        End Get
        Set(ByVal value As Long)
            m_lngTipoEquipo = value
        End Set
    End Property

    Public Property Marca() As String
        Get
            Return m_strMarca
        End Get
        Set(ByVal value As String)
            m_strMarca = value
        End Set
    End Property

    Public Property Modelo() As String
        Get
            Return m_strModelo
        End Get
        Set(ByVal value As String)
            m_strModelo = value
        End Set
    End Property

    Public Property NumeroSerie() As String
        Get
            Return m_strNSerie
        End Get
        Set(ByVal value As String)
            m_strNSerie = value
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

    Public Property Maletin() As Boolean
        Get
            Return m_blnMaletin
        End Get
        Set(ByVal value As Boolean)
            m_blnMaletin = value
        End Set
    End Property

    Public Property Cargador() As Boolean
        Get
            Return m_blnCargador
        End Get
        Set(ByVal value As Boolean)
            m_blnCargador = value
        End Set
    End Property

    Public Property Averia() As String
        Get
            Return m_strAveria
        End Get
        Set(ByVal value As String)
            m_strAveria = value
        End Set
    End Property

    Public Property Resolucion() As String
        Get
            Return m_strResolucion
        End Get
        Set(ByVal value As String)
            m_strResolucion = value
        End Set
    End Property

    Public Property Estado() As Long
        Get
            Return m_lngEstado
        End Get
        Set(ByVal value As Long)
            m_lngEstado = value
        End Set
    End Property

    Public Property Importe() As Double
        Get
            Return m_dblImporte
        End Get
        Set(ByVal value As Double)
            m_dblImporte = value
        End Set
    End Property

    Public Property Garantia() As Boolean
        Get
            Return m_blnGarantia
        End Get
        Set(ByVal value As Boolean)
            m_blnGarantia = value
        End Set
    End Property

    Public Property Historial() As DataTable
        Get
            Return m_dttHistorialActuacion
        End Get
        Set(ByVal value As DataTable)
            m_dttHistorialActuacion = value
        End Set
    End Property

    Public Property Presupuesto() As DataTable
        Get
            Return m_dttLineasPresupuesto
        End Get
        Set(ByVal value As DataTable)
            m_dttLineasPresupuesto = value
        End Set
    End Property
End Class