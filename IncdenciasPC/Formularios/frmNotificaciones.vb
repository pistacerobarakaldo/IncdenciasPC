Public Class frmNotificaciones

    Private Sub frmNotificaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim objLabel = New System.Windows.Forms.Label()

        objLabel.Name = "Notificacion" 'nombre imagen
        objLabel.AutoSize = True
        objLabel.TabIndex = 0
        objLabel.TabStop = False
        objLabel.Text = "Renovación"
        objLabel.Dock = Left
        objLabel.BackColor = Color.Transparent
        objLabel.Font = New Font(objLabel.Font.FontFamily.Name, 10, FontStyle.Bold)
        objLabel.Padding = New Padding(0, 2, 0, 0)
        objLabel.Margin = New Padding(0)

        Dim objBoton = New System.Windows.Forms.Button()

        objBoton.Name = "Borrar" 'nombre imagen
        objBoton.TabIndex = 0
        objBoton.TabStop = False
        objBoton.Text = "Borrar"
        objBoton.Dock = Right
        objBoton.FlatAppearance.BorderSize = 0
        objBoton.FlatAppearance.MouseOverBackColor = SystemColors.HotTrack
        objBoton.FlatStyle = FlatStyle.Flat
        objBoton.BackColor = Color.Transparent
        objLabel.Font = New Font(objLabel.Font.FontFamily.Name, 8, FontStyle.Bold)
        objLabel.ForeColor = Color.White
        objBoton.Padding = New Padding(0)
        objBoton.Margin = New Padding(0)
        objBoton.Size = New Size(50, 20)

        Dim objNotificacion = New System.Windows.Forms.Panel()

        objNotificacion.Name = "Notificacion" 'nombre imagen
        objNotificacion.Size = New Size(flpNotificaciones.Width, 100)
        objNotificacion.TabIndex = 0
        objNotificacion.TabStop = False
        objNotificacion.Text = "Renovación"
        objNotificacion.Margin = New Padding(0)

        flpNotificaciones.Controls.Add(objNotificacion) 'Con esta instrucción se agrega un control al panel

    End Sub
End Class