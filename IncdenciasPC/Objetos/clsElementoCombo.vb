Friend Enum udtTiposCampos
    Numerico = 1
    NumComa = 2
    Texto = 3
    Fecha = 4
    SiNo = 5
End Enum

Friend Class clsElementoCombo
    'Constante que guarda el nombre del mudulo
    Const mc_strNombre_Modulo As String = "clsElementoCombo"

    'Identificador del elemento
    Private m_lngClave As Long

    'Descripcion del elemento
    Private m_strDescripcion As String

    'Tipo de elemento (Se utilizará para determinar a que tipo de campo hace referencia el elemento del combo)
    Private m_udtTipo As udtTiposCampos

    '<CABECERA>-----------------------------------------------
    'Nombre...........: New
    'Descripcion......: Inicializa las variables del objeto
    'Fecha............: 30/12/2011
    'Autor............: Borja Escudero
    'Parametros.......: N/A
    'Retorno..........: N/A
    '<FIN CABECERA>-------------------------------------------
    Public Sub New()

        Const strNombre_Funcion As String = "New"
        Dim lngError As Long
        Dim strError As String

        On Error GoTo TratarError

        m_lngClave = 0
        m_strDescripcion = ""
        m_udtTipo = 0

Terminar:

        'Anulamos el control de errores
        On Error GoTo 0
        Exit Sub

TratarError:

        'Guardamos el error
        lngError = Err.Number
        strError = Err.Description

        AddLog(lngError & " - " & strError, mc_strNombre_Modulo, strNombre_Funcion)

        Resume Terminar
    End Sub

    '<CABECERA>-----------------------------------------------
    'Nombre...........: Finalize
    'Descripcion......: Finaliza el objeto
    'Fecha............: 30/12/2011
    'Autor............: Borja Escudero
    'Parametros.......: N/A
    'Retorno..........: N/A
    '<FIN CABECERA>-------------------------------------------
    Protected Overrides Sub Finalize()

        Const strNombre_Funcion As String = "Finalize"
        Dim lngError As Long
        Dim strError As String

        On Error GoTo TratarError

        MyBase.Finalize()

Terminar:

        'Anulamos el control de errores
        On Error GoTo 0
        Exit Sub

TratarError:

        'Guardamos el error
        lngError = Err.Number
        strError = Err.Description

        AddLog(lngError & " - " & strError, mc_strNombre_Modulo, strNombre_Funcion)

        Resume Terminar
    End Sub

    '<CABECERA>-----------------------------------------------
    'Nombre...........: Id
    'Descripcion......: Obtiene o Estable la clave del elemento
    'Fecha............: 30/12/2011
    'Autor............: Borja Escudero
    'Parametros.......: Value = Nuevo identificador
    'Retorno..........: Clave actual del elemento
    '<FIN CABECERA>-------------------------------------------
    Public Property Clave() As Long
        Get
            Return m_lngClave
        End Get
        Set(ByVal Value As Long)
            m_lngClave = Value
        End Set
    End Property

    '<CABECERA>-----------------------------------------------
    'Nombre...........: Descripcion
    'Descripcion......: Obtiene o Estable la descripcion del elemento
    'Fecha............: 30/12/2011
    'Autor............: Borja Escudero
    'Parametros.......: Value = Nueva descripcion
    'Retorno..........: Descripcion actual del elemento
    '<FIN CABECERA>-------------------------------------------
    Public Property Descripcion() As String
        Get
            Return m_strDescripcion
        End Get
        Set(ByVal Value As String)
            m_strDescripcion = Value
        End Set
    End Property

    '<CABECERA>-----------------------------------------------
    'Nombre...........: TipoElemento
    'Descripcion......: Obtiene o Estable el tipo del elemento
    'Fecha............: 30/12/2011
    'Autor............: Borja Escudero
    'Parametros.......: Value = Nuevo tipo
    'Retorno..........: Tipo actual del elemento
    '<FIN CABECERA>-------------------------------------------
    Public Property TipoElemento() As udtTiposCampos
        Get
            Return m_udtTipo
        End Get
        Set(ByVal Value As udtTiposCampos)
            m_udtTipo = Value
        End Set
    End Property

    '<CABECERA>-----------------------------------------------
    'Nombre...........: TipoElemento
    'Descripcion......: Obtiene o Estable el tipo del elemento
    'Fecha............: 30/12/2011
    'Autor............: Borja Escudero
    'Parametros.......: Value = Nuevo tipo
    'Retorno..........: Tipo actual del elemento
    '<FIN CABECERA>-------------------------------------------
    Public Overrides Function ToString() As String
        Return m_strDescripcion
    End Function
End Class
