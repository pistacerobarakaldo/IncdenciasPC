Option Explicit On
Option Compare Text

Imports System.IO

Module modDLL
    'Constante que guarda el nombre del mudolu
    Const mc_strNombre_Modulo As String = "modDLL"

    'Variable utilizada para guaradar  la ruta en la que se ejecuta la aplicacion
    Private m_strApplicationPath As String

    Public ReadOnly Property ApplicationPath As String
        Get
            Return m_strApplicationPath
        End Get
    End Property

    Public WriteOnly Property SetApplicationPath As String
        Set(ByVal value As String)
            m_strApplicationPath = value
        End Set
    End Property
End Module
