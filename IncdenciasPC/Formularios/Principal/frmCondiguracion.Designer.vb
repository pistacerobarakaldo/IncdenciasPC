<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCondiguracion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCondiguracion))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDBIncidencias = New System.Windows.Forms.TextBox()
        Me.txtDBFactusol = New System.Windows.Forms.TextBox()
        Me.btnDBIncidencias = New System.Windows.Forms.Button()
        Me.btnDBFactusol = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtImpresoraInformes = New System.Windows.Forms.TextBox()
        Me.txtImpresoraIncidencias = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnImpresoraIncidencias = New System.Windows.Forms.Button()
        Me.btnImpresoraInformes = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.rdbTicket = New System.Windows.Forms.RadioButton()
        Me.rdbFolio = New System.Windows.Forms.RadioButton()
        Me.chkClientesLocal = New System.Windows.Forms.CheckBox()
        Me.pdgImpresoras = New System.Windows.Forms.PrintDialog()
        Me.ofdRutas = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.btnAceptar)
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 214)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(697, 50)
        Me.Panel1.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(9, 15)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(316, 13)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "*  -  La aplicacion se reiniciara para que los cambios surtan efecto"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(610, 15)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 2
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(529, 15)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.HotTrack
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 106
        Me.LineShape1.X2 = 683
        Me.LineShape1.Y1 = 19
        Me.LineShape1.Y2 = 19
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(697, 264)
        Me.ShapeContainer1.TabIndex = 8
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.SystemColors.HotTrack
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 107
        Me.LineShape2.X2 = 683
        Me.LineShape2.Y1 = 123
        Me.LineShape2.Y2 = 123
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label5.Location = New System.Drawing.Point(106, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Rutas de las bases de datos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(124, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Base de datos de incidencias"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(146, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Base de datos de factusol"
        '
        'txtDBIncidencias
        '
        Me.txtDBIncidencias.Location = New System.Drawing.Point(282, 29)
        Me.txtDBIncidencias.Name = "txtDBIncidencias"
        Me.txtDBIncidencias.Size = New System.Drawing.Size(360, 20)
        Me.txtDBIncidencias.TabIndex = 12
        '
        'txtDBFactusol
        '
        Me.txtDBFactusol.Location = New System.Drawing.Point(282, 81)
        Me.txtDBFactusol.Name = "txtDBFactusol"
        Me.txtDBFactusol.Size = New System.Drawing.Size(360, 20)
        Me.txtDBFactusol.TabIndex = 13
        '
        'btnDBIncidencias
        '
        Me.btnDBIncidencias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDBIncidencias.Location = New System.Drawing.Point(648, 27)
        Me.btnDBIncidencias.Name = "btnDBIncidencias"
        Me.btnDBIncidencias.Size = New System.Drawing.Size(36, 23)
        Me.btnDBIncidencias.TabIndex = 14
        Me.btnDBIncidencias.Text = ". . ."
        Me.btnDBIncidencias.UseVisualStyleBackColor = True
        '
        'btnDBFactusol
        '
        Me.btnDBFactusol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDBFactusol.Location = New System.Drawing.Point(648, 79)
        Me.btnDBFactusol.Name = "btnDBFactusol"
        Me.btnDBFactusol.Size = New System.Drawing.Size(36, 23)
        Me.btnDBFactusol.TabIndex = 15
        Me.btnDBFactusol.Text = ". . ."
        Me.btnDBFactusol.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(103, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Impresoras"
        '
        'txtImpresoraInformes
        '
        Me.txtImpresoraInformes.Location = New System.Drawing.Point(282, 159)
        Me.txtImpresoraInformes.Name = "txtImpresoraInformes"
        Me.txtImpresoraInformes.Size = New System.Drawing.Size(360, 20)
        Me.txtImpresoraInformes.TabIndex = 20
        '
        'txtImpresoraIncidencias
        '
        Me.txtImpresoraIncidencias.Location = New System.Drawing.Point(282, 133)
        Me.txtImpresoraIncidencias.Name = "txtImpresoraIncidencias"
        Me.txtImpresoraIncidencias.Size = New System.Drawing.Size(360, 20)
        Me.txtImpresoraIncidencias.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(106, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Impresora de informes"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(106, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Impresora de incidencias"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(106, 187)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(170, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Tipo de documneto de incidencias"
        '
        'btnImpresoraIncidencias
        '
        Me.btnImpresoraIncidencias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImpresoraIncidencias.Location = New System.Drawing.Point(648, 131)
        Me.btnImpresoraIncidencias.Name = "btnImpresoraIncidencias"
        Me.btnImpresoraIncidencias.Size = New System.Drawing.Size(36, 23)
        Me.btnImpresoraIncidencias.TabIndex = 24
        Me.btnImpresoraIncidencias.Text = ". . ."
        Me.btnImpresoraIncidencias.UseVisualStyleBackColor = True
        '
        'btnImpresoraInformes
        '
        Me.btnImpresoraInformes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImpresoraInformes.Location = New System.Drawing.Point(648, 157)
        Me.btnImpresoraInformes.Name = "btnImpresoraInformes"
        Me.btnImpresoraInformes.Size = New System.Drawing.Size(36, 23)
        Me.btnImpresoraInformes.TabIndex = 25
        Me.btnImpresoraInformes.Text = ". . ."
        Me.btnImpresoraInformes.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(106, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(12, 13)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(128, 84)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(12, 13)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "*"
        '
        'rdbTicket
        '
        Me.rdbTicket.AutoSize = True
        Me.rdbTicket.Location = New System.Drawing.Point(282, 185)
        Me.rdbTicket.Name = "rdbTicket"
        Me.rdbTicket.Size = New System.Drawing.Size(55, 17)
        Me.rdbTicket.TabIndex = 35
        Me.rdbTicket.TabStop = True
        Me.rdbTicket.Text = "Ticket"
        Me.rdbTicket.UseVisualStyleBackColor = True
        '
        'rdbFolio
        '
        Me.rdbFolio.AutoSize = True
        Me.rdbFolio.Location = New System.Drawing.Point(343, 185)
        Me.rdbFolio.Name = "rdbFolio"
        Me.rdbFolio.Size = New System.Drawing.Size(47, 17)
        Me.rdbFolio.TabIndex = 36
        Me.rdbFolio.TabStop = True
        Me.rdbFolio.Text = "Folio"
        Me.rdbFolio.UseVisualStyleBackColor = True
        '
        'chkClientesLocal
        '
        Me.chkClientesLocal.AutoSize = True
        Me.chkClientesLocal.Location = New System.Drawing.Point(109, 58)
        Me.chkClientesLocal.Name = "chkClientesLocal"
        Me.chkClientesLocal.Size = New System.Drawing.Size(321, 17)
        Me.chkClientesLocal.TabIndex = 37
        Me.chkClientesLocal.Text = "La base de datos de clientes esta incluida en la de incidencias"
        Me.chkClientesLocal.UseVisualStyleBackColor = True
        '
        'pdgImpresoras
        '
        Me.pdgImpresoras.UseEXDialog = True
        '
        'ofdRutas
        '
        Me.ofdRutas.FileName = "OpenFileDialog1"
        '
        'frmCondiguracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(697, 264)
        Me.Controls.Add(Me.chkClientesLocal)
        Me.Controls.Add(Me.rdbFolio)
        Me.Controls.Add(Me.rdbTicket)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnImpresoraInformes)
        Me.Controls.Add(Me.btnImpresoraIncidencias)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtImpresoraInformes)
        Me.Controls.Add(Me.txtImpresoraIncidencias)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnDBFactusol)
        Me.Controls.Add(Me.btnDBIncidencias)
        Me.Controls.Add(Me.txtDBFactusol)
        Me.Controls.Add(Me.txtDBIncidencias)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCondiguracion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Condiguración"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDBIncidencias As System.Windows.Forms.TextBox
    Friend WithEvents txtDBFactusol As System.Windows.Forms.TextBox
    Friend WithEvents btnDBIncidencias As System.Windows.Forms.Button
    Friend WithEvents btnDBFactusol As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtImpresoraInformes As System.Windows.Forms.TextBox
    Friend WithEvents txtImpresoraIncidencias As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnImpresoraIncidencias As System.Windows.Forms.Button
    Friend WithEvents btnImpresoraInformes As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents rdbTicket As System.Windows.Forms.RadioButton
    Friend WithEvents rdbFolio As System.Windows.Forms.RadioButton
    Friend WithEvents chkClientesLocal As System.Windows.Forms.CheckBox
    Friend WithEvents pdgImpresoras As System.Windows.Forms.PrintDialog
    Friend WithEvents ofdRutas As System.Windows.Forms.OpenFileDialog
End Class
