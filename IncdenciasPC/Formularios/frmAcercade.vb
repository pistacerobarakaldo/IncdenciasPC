Public Class frmAcercade
    Const mc_strNombre_Modulo As String = "frmAcercade"

    Private Sub lblWeb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblWeb.Click

        Const strNombre_Funcion As String = "lblWeb_Click"
        
        Try
            System.Diagnostics.Process.Start("http://www.pistacerobarakaldo.es/")
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Private Sub ptbFacebook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ptbFacebook.Click

        Const strNombre_Funcion As String = "ptbFacebook_Click"

        Try
            System.Diagnostics.Process.Start("https://www.facebook.com/PistaCeroBarakaldo")
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Private Sub ptbTwitter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ptbTwitter.Click

        Const strNombre_Funcion As String = "ptbTwitter_Click"

        Try
            System.Diagnostics.Process.Start("https://twitter.com/pcbarakaldo")
        Catch ex As Exception
            AddLog(ex.Message, mc_strNombre_Modulo, strNombre_Funcion)
        End Try
    End Sub

    Private Sub Vinculos_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblWeb.MouseEnter, ptbFacebook.MouseEnter, _
                                                                                                 ptbTwitter.MouseEnter, lblCerrar.MouseEnter
        Cursor = Cursors.Hand
    End Sub

    Private Sub Vinculos_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblWeb.MouseLeave, ptbFacebook.MouseLeave, _
                                                                                                 ptbTwitter.MouseLeave, lblCerrar.MouseLeave
        Cursor = Cursors.Arrow
    End Sub

    Private Sub lblCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCerrar.Click
        Me.Close()
    End Sub
End Class