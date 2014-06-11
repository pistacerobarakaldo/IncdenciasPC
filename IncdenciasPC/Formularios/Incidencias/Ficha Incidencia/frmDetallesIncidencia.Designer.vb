<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetallesIncidencia
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIncidencia = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbxEstado = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNomCliente = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtContacto = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTelefono2 = New System.Windows.Forms.TextBox()
        Me.txtTelefono1 = New System.Windows.Forms.TextBox()
        Me.txtIdCliente = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbxTipoEquipo = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtNSerie = New System.Windows.Forms.TextBox()
        Me.chbMaletin = New System.Windows.Forms.CheckBox()
        Me.chbCargador = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.chbGarantia = New System.Windows.Forms.CheckBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtAveria = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtResolucion = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Número"
        '
        'txtIncidencia
        '
        Me.txtIncidencia.BackColor = System.Drawing.SystemColors.Window
        Me.txtIncidencia.Location = New System.Drawing.Point(70, 27)
        Me.txtIncidencia.Name = "txtIncidencia"
        Me.txtIncidencia.ReadOnly = True
        Me.txtIncidencia.Size = New System.Drawing.Size(100, 21)
        Me.txtIncidencia.TabIndex = 16
        Me.txtIncidencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(251, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(345, 25)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(108, 21)
        Me.dtpFecha.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(722, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Estado"
        '
        'cbxEstado
        '
        Me.cbxEstado.FormattingEnabled = True
        Me.cbxEstado.Location = New System.Drawing.Point(789, 27)
        Me.cbxEstado.Name = "cbxEstado"
        Me.cbxEstado.Size = New System.Drawing.Size(170, 23)
        Me.cbxEstado.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Cliente"
        '
        'txtNomCliente
        '
        Me.txtNomCliente.BackColor = System.Drawing.SystemColors.Window
        Me.txtNomCliente.Location = New System.Drawing.Point(140, 54)
        Me.txtNomCliente.Name = "txtNomCliente"
        Me.txtNomCliente.ReadOnly = True
        Me.txtNomCliente.Size = New System.Drawing.Size(313, 21)
        Me.txtNomCliente.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(459, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 15)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Contacto"
        '
        'txtContacto
        '
        Me.txtContacto.Location = New System.Drawing.Point(529, 54)
        Me.txtContacto.Name = "txtContacto"
        Me.txtContacto.Size = New System.Drawing.Size(186, 21)
        Me.txtContacto.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(722, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 15)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Teléfonos"
        '
        'txtTelefono2
        '
        Me.txtTelefono2.Location = New System.Drawing.Point(877, 54)
        Me.txtTelefono2.Name = "txtTelefono2"
        Me.txtTelefono2.Size = New System.Drawing.Size(82, 21)
        Me.txtTelefono2.TabIndex = 5
        Me.txtTelefono2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTelefono1
        '
        Me.txtTelefono1.Location = New System.Drawing.Point(789, 54)
        Me.txtTelefono1.Name = "txtTelefono1"
        Me.txtTelefono1.Size = New System.Drawing.Size(82, 21)
        Me.txtTelefono1.TabIndex = 4
        Me.txtTelefono1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtIdCliente
        '
        Me.txtIdCliente.BackColor = System.Drawing.SystemColors.Window
        Me.txtIdCliente.Location = New System.Drawing.Point(70, 54)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(64, 21)
        Me.txtIdCliente.TabIndex = 17
        Me.txtIdCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 108)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 15)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Tipo de equipo"
        '
        'cbxTipoEquipo
        '
        Me.cbxTipoEquipo.FormattingEnabled = True
        Me.cbxTipoEquipo.Location = New System.Drawing.Point(107, 105)
        Me.cbxTipoEquipo.Name = "cbxTipoEquipo"
        Me.cbxTipoEquipo.Size = New System.Drawing.Size(121, 23)
        Me.cbxTipoEquipo.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 137)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 15)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Marca"
        '
        'txtMarca
        '
        Me.txtMarca.Location = New System.Drawing.Point(107, 134)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(121, 21)
        Me.txtMarca.TabIndex = 7
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(107, 161)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(121, 21)
        Me.txtModelo.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 164)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 15)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Modelo"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(251, 108)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 15)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Nª Serie"
        '
        'txtNSerie
        '
        Me.txtNSerie.Location = New System.Drawing.Point(345, 105)
        Me.txtNSerie.Name = "txtNSerie"
        Me.txtNSerie.Size = New System.Drawing.Size(401, 21)
        Me.txtNSerie.TabIndex = 9
        '
        'chbMaletin
        '
        Me.chbMaletin.AutoSize = True
        Me.chbMaletin.Location = New System.Drawing.Point(764, 107)
        Me.chbMaletin.Name = "chbMaletin"
        Me.chbMaletin.Size = New System.Drawing.Size(107, 19)
        Me.chbMaletin.TabIndex = 10
        Me.chbMaletin.Text = "Bolsa / Maletin"
        Me.chbMaletin.UseVisualStyleBackColor = True
        '
        'chbCargador
        '
        Me.chbCargador.AutoSize = True
        Me.chbCargador.Location = New System.Drawing.Point(882, 107)
        Me.chbCargador.Name = "chbCargador"
        Me.chbCargador.Size = New System.Drawing.Size(77, 19)
        Me.chbCargador.TabIndex = 11
        Me.chbCargador.Text = "Cargador"
        Me.chbCargador.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(251, 137)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 15)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Observaciones"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(345, 134)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(614, 48)
        Me.txtObservaciones.TabIndex = 12
        '
        'chbGarantia
        '
        Me.chbGarantia.AutoSize = True
        Me.chbGarantia.Location = New System.Drawing.Point(15, 215)
        Me.chbGarantia.Name = "chbGarantia"
        Me.chbGarantia.Size = New System.Drawing.Size(155, 19)
        Me.chbGarantia.TabIndex = 13
        Me.chbGarantia.Text = "Reparación en garantía"
        Me.chbGarantia.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 269)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 15)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Averia"
        '
        'txtAveria
        '
        Me.txtAveria.Location = New System.Drawing.Point(12, 287)
        Me.txtAveria.Multiline = True
        Me.txtAveria.Name = "txtAveria"
        Me.txtAveria.Size = New System.Drawing.Size(947, 109)
        Me.txtAveria.TabIndex = 14
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 445)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 15)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Resolucion"
        '
        'txtResolucion
        '
        Me.txtResolucion.Location = New System.Drawing.Point(12, 463)
        Me.txtResolucion.Multiline = True
        Me.txtResolucion.Name = "txtResolucion"
        Me.txtResolucion.Size = New System.Drawing.Size(947, 109)
        Me.txtResolucion.TabIndex = 15
        '
        'frmDetallesIncidencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(974, 585)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtResolucion)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtAveria)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.chbGarantia)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.chbCargador)
        Me.Controls.Add(Me.chbMaletin)
        Me.Controls.Add(Me.txtNSerie)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtModelo)
        Me.Controls.Add(Me.txtMarca)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbxTipoEquipo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtIdCliente)
        Me.Controls.Add(Me.txtTelefono1)
        Me.Controls.Add(Me.txtTelefono2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtContacto)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtNomCliente)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbxEstado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtIncidencia)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDetallesIncidencia"
        Me.Text = "Detalle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtIncidencia As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbxEstado As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNomCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtContacto As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTelefono2 As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono1 As System.Windows.Forms.TextBox
    Friend WithEvents txtIdCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbxTipoEquipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtMarca As System.Windows.Forms.TextBox
    Friend WithEvents txtModelo As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtNSerie As System.Windows.Forms.TextBox
    Friend WithEvents chbMaletin As System.Windows.Forms.CheckBox
    Friend WithEvents chbCargador As System.Windows.Forms.CheckBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents chbGarantia As System.Windows.Forms.CheckBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtAveria As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtResolucion As System.Windows.Forms.TextBox
End Class
