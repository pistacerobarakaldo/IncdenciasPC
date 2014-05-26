Public Class frmImprimirIncidencia

    Private m_lngCopias As Long

    Private Sub frmImprimirIncidencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        NumericUpDown1.Value = 2
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        m_lngCopias = -1
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        m_lngCopias = NumericUpDown1.Value
        Me.Close()
    End Sub

    Public ReadOnly Property Copias As Long
        Get
            Return m_lngCopias
        End Get
    End Property
End Class