<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFichaCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFichaCliente))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tspMos2 = New System.Windows.Forms.ToolStrip()
        Me.btnHistorial = New System.Windows.Forms.ToolStripButton()
        Me.btnMantenimiento = New System.Windows.Forms.ToolStripButton()
        Me.tspMos1 = New System.Windows.Forms.ToolStrip()
        Me.btnDetalles = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.tspMant1 = New System.Windows.Forms.ToolStrip()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.tspMos2.SuspendLayout()
        Me.tspMos1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.tspMant1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(870, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(870, 105)
        Me.Panel1.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.tspMos2)
        Me.Panel2.Controls.Add(Me.tspMos1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(62, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(233, 100)
        Me.Panel2.TabIndex = 4
        '
        'tspMos2
        '
        Me.tspMos2.AutoSize = False
        Me.tspMos2.BackColor = System.Drawing.Color.Transparent
        Me.tspMos2.Dock = System.Windows.Forms.DockStyle.Left
        Me.tspMos2.GripMargin = New System.Windows.Forms.Padding(0)
        Me.tspMos2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tspMos2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnHistorial, Me.btnMantenimiento})
        Me.tspMos2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.tspMos2.Location = New System.Drawing.Point(55, 0)
        Me.tspMos2.Name = "tspMos2"
        Me.tspMos2.Padding = New System.Windows.Forms.Padding(0)
        Me.tspMos2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tspMos2.Size = New System.Drawing.Size(176, 79)
        Me.tspMos2.TabIndex = 3
        Me.tspMos2.Text = "ToolStrip2"
        '
        'btnHistorial
        '
        Me.btnHistorial.Enabled = False
        Me.btnHistorial.Image = CType(resources.GetObject("btnHistorial.Image"), System.Drawing.Image)
        Me.btnHistorial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHistorial.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnHistorial.Name = "btnHistorial"
        Me.btnHistorial.Size = New System.Drawing.Size(175, 20)
        Me.btnHistorial.Text = "Historial de incidencias"
        Me.btnHistorial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnMantenimiento
        '
        Me.btnMantenimiento.Enabled = False
        Me.btnMantenimiento.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnMantenimiento.Image = CType(resources.GetObject("btnMantenimiento.Image"), System.Drawing.Image)
        Me.btnMantenimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMantenimiento.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMantenimiento.Name = "btnMantenimiento"
        Me.btnMantenimiento.Size = New System.Drawing.Size(175, 20)
        Me.btnMantenimiento.Text = "Ficha de mantenimiento"
        Me.btnMantenimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tspMos1
        '
        Me.tspMos1.BackColor = System.Drawing.Color.Transparent
        Me.tspMos1.Dock = System.Windows.Forms.DockStyle.Left
        Me.tspMos1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tspMos1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tspMos1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnDetalles})
        Me.tspMos1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.tspMos1.Location = New System.Drawing.Point(0, 0)
        Me.tspMos1.Name = "tspMos1"
        Me.tspMos1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tspMos1.Size = New System.Drawing.Size(55, 79)
        Me.tspMos1.TabIndex = 2
        Me.tspMos1.Text = "ToolStrip1"
        '
        'btnDetalles
        '
        Me.btnDetalles.Image = CType(resources.GetObject("btnDetalles.Image"), System.Drawing.Image)
        Me.btnDetalles.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDetalles.Name = "btnDetalles"
        Me.btnDetalles.Size = New System.Drawing.Size(52, 76)
        Me.btnDetalles.Text = "Detalles"
        Me.btnDetalles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(0, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mostrar"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.tspMant1)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Location = New System.Drawing.Point(3, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(56, 100)
        Me.Panel5.TabIndex = 3
        '
        'tspMant1
        '
        Me.tspMant1.BackColor = System.Drawing.Color.Transparent
        Me.tspMant1.Dock = System.Windows.Forms.DockStyle.Left
        Me.tspMant1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tspMant1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tspMant1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnGuardar})
        Me.tspMant1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.tspMant1.Location = New System.Drawing.Point(0, 0)
        Me.tspMant1.Name = "tspMant1"
        Me.tspMant1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tspMant1.Size = New System.Drawing.Size(56, 79)
        Me.tspMant1.TabIndex = 2
        Me.tspMant1.Text = "ToolStrip1"
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(53, 76)
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(0, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 19)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Accion"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmFichaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(870, 521)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFichaCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cliente"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.tspMos2.ResumeLayout(False)
        Me.tspMos2.PerformLayout()
        Me.tspMos1.ResumeLayout(False)
        Me.tspMos1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.tspMant1.ResumeLayout(False)
        Me.tspMant1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents tspMos2 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnHistorial As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMantenimiento As System.Windows.Forms.ToolStripButton
    Friend WithEvents tspMos1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnDetalles As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents tspMant1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
