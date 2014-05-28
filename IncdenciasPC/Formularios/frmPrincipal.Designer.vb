<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tbcPrincipal = New System.Windows.Forms.TabControl()
        Me.tbpIncidencias = New System.Windows.Forms.TabPage()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.tspLin2 = New System.Windows.Forms.ToolStrip()
        Me.btnModificarI = New System.Windows.Forms.ToolStripButton()
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton()
        Me.tspLin1 = New System.Windows.Forms.ToolStrip()
        Me.btnNueva = New System.Windows.Forms.ToolStripButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.btnBuscarIncidencia = New System.Windows.Forms.ToolStripButton()
        Me.tspMos2 = New System.Windows.Forms.ToolStrip()
        Me.txtFiltroI = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cbxCamposI = New System.Windows.Forms.ToolStripComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.chbEngarantia = New System.Windows.Forms.CheckBox()
        Me.chbCerrada = New System.Windows.Forms.CheckBox()
        Me.chbAvisado = New System.Windows.Forms.CheckBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.chbTerminada = New System.Windows.Forms.CheckBox()
        Me.chbEnproceso = New System.Windows.Forms.CheckBox()
        Me.chbAbierta = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbpClientes = New System.Windows.Forms.TabPage()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.ToolStrip4 = New System.Windows.Forms.ToolStrip()
        Me.btnBuscarC = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip5 = New System.Windows.Forms.ToolStrip()
        Me.txtFiltroC = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cbxCamposC = New System.Windows.Forms.ToolStripComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnModificarC = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.Panel1.SuspendLayout()
        Me.tbcPrincipal.SuspendLayout()
        Me.tbpIncidencias.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.tspLin2.SuspendLayout()
        Me.tspLin1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        Me.tspMos2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.tbpClientes.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.ToolStrip4.SuspendLayout()
        Me.ToolStrip5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel1.Controls.Add(Me.tbcPrincipal)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(974, 124)
        Me.Panel1.TabIndex = 1
        '
        'tbcPrincipal
        '
        Me.tbcPrincipal.Controls.Add(Me.tbpIncidencias)
        Me.tbcPrincipal.Controls.Add(Me.tbpClientes)
        Me.tbcPrincipal.Dock = System.Windows.Forms.DockStyle.Top
        Me.tbcPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbcPrincipal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.tbcPrincipal.ItemSize = New System.Drawing.Size(150, 20)
        Me.tbcPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.tbcPrincipal.Name = "tbcPrincipal"
        Me.tbcPrincipal.SelectedIndex = 0
        Me.tbcPrincipal.Size = New System.Drawing.Size(974, 128)
        Me.tbcPrincipal.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.tbcPrincipal.TabIndex = 8
        '
        'tbpIncidencias
        '
        Me.tbpIncidencias.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.tbpIncidencias.Controls.Add(Me.Panel6)
        Me.tbpIncidencias.Controls.Add(Me.Panel2)
        Me.tbpIncidencias.Controls.Add(Me.Panel3)
        Me.tbpIncidencias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbpIncidencias.Location = New System.Drawing.Point(4, 24)
        Me.tbpIncidencias.Name = "tbpIncidencias"
        Me.tbpIncidencias.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpIncidencias.Size = New System.Drawing.Size(966, 100)
        Me.tbpIncidencias.TabIndex = 0
        Me.tbpIncidencias.Text = "Incidencias"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.tspLin2)
        Me.Panel6.Controls.Add(Me.tspLin1)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(138, 100)
        Me.Panel6.TabIndex = 7
        '
        'tspLin2
        '
        Me.tspLin2.AutoSize = False
        Me.tspLin2.BackColor = System.Drawing.Color.Transparent
        Me.tspLin2.Dock = System.Windows.Forms.DockStyle.Left
        Me.tspLin2.GripMargin = New System.Windows.Forms.Padding(0)
        Me.tspLin2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tspLin2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnModificarI, Me.btnEliminar, Me.btnImprimir})
        Me.tspLin2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.tspLin2.Location = New System.Drawing.Point(48, 0)
        Me.tspLin2.Name = "tspLin2"
        Me.tspLin2.Padding = New System.Windows.Forms.Padding(0)
        Me.tspLin2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tspLin2.Size = New System.Drawing.Size(88, 79)
        Me.tspLin2.TabIndex = 3
        Me.tspLin2.Text = "ToolStrip2"
        '
        'btnModificarI
        '
        Me.btnModificarI.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnModificarI.Image = CType(resources.GetObject("btnModificarI.Image"), System.Drawing.Image)
        Me.btnModificarI.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificarI.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnModificarI.Name = "btnModificarI"
        Me.btnModificarI.Size = New System.Drawing.Size(87, 20)
        Me.btnModificarI.Text = "Modificar"
        Me.btnModificarI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnEliminar
        '
        Me.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(87, 20)
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnImprimir
        '
        Me.btnImprimir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(87, 20)
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tspLin1
        '
        Me.tspLin1.BackColor = System.Drawing.Color.Transparent
        Me.tspLin1.Dock = System.Windows.Forms.DockStyle.Left
        Me.tspLin1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tspLin1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tspLin1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNueva})
        Me.tspLin1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.tspLin1.Location = New System.Drawing.Point(0, 0)
        Me.tspLin1.Name = "tspLin1"
        Me.tspLin1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tspLin1.Size = New System.Drawing.Size(48, 79)
        Me.tspLin1.TabIndex = 2
        Me.tspLin1.Text = "ToolStrip1"
        '
        'btnNueva
        '
        Me.btnNueva.Image = CType(resources.GetObject("btnNueva.Image"), System.Drawing.Image)
        Me.btnNueva.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNueva.Name = "btnNueva"
        Me.btnNueva.Size = New System.Drawing.Size(45, 76)
        Me.btnNueva.Text = "Nueva"
        Me.btnNueva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(0, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 19)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Incidencias"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.ToolStrip3)
        Me.Panel2.Controls.Add(Me.tspMos2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(142, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(227, 100)
        Me.Panel2.TabIndex = 4
        '
        'ToolStrip3
        '
        Me.ToolStrip3.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip3.Dock = System.Windows.Forms.DockStyle.Left
        Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip3.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscarIncidencia})
        Me.ToolStrip3.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.ToolStrip3.Location = New System.Drawing.Point(176, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip3.Size = New System.Drawing.Size(49, 79)
        Me.ToolStrip3.TabIndex = 4
        Me.ToolStrip3.Text = "ToolStrip1"
        '
        'btnBuscarIncidencia
        '
        Me.btnBuscarIncidencia.Image = CType(resources.GetObject("btnBuscarIncidencia.Image"), System.Drawing.Image)
        Me.btnBuscarIncidencia.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscarIncidencia.Name = "btnBuscarIncidencia"
        Me.btnBuscarIncidencia.Size = New System.Drawing.Size(46, 76)
        Me.btnBuscarIncidencia.Text = "Buscar"
        Me.btnBuscarIncidencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tspMos2
        '
        Me.tspMos2.AutoSize = False
        Me.tspMos2.BackColor = System.Drawing.Color.Transparent
        Me.tspMos2.Dock = System.Windows.Forms.DockStyle.Left
        Me.tspMos2.GripMargin = New System.Windows.Forms.Padding(0)
        Me.tspMos2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tspMos2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtFiltroI, Me.ToolStripSeparator1, Me.cbxCamposI})
        Me.tspMos2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.tspMos2.Location = New System.Drawing.Point(0, 0)
        Me.tspMos2.Name = "tspMos2"
        Me.tspMos2.Padding = New System.Windows.Forms.Padding(0)
        Me.tspMos2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tspMos2.Size = New System.Drawing.Size(176, 79)
        Me.tspMos2.TabIndex = 3
        Me.tspMos2.Text = "ToolStrip2"
        '
        'txtFiltroI
        '
        Me.txtFiltroI.Name = "txtFiltroI"
        Me.txtFiltroI.Size = New System.Drawing.Size(173, 23)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(175, 6)
        '
        'cbxCamposI
        '
        Me.cbxCamposI.Name = "cbxCamposI"
        Me.cbxCamposI.Size = New System.Drawing.Size(173, 23)
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(0, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Filtrar"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Panel8)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(374, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(221, 100)
        Me.Panel3.TabIndex = 5
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.chbEngarantia)
        Me.Panel8.Controls.Add(Me.chbCerrada)
        Me.Panel8.Controls.Add(Me.chbAvisado)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel8.Location = New System.Drawing.Point(114, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(106, 79)
        Me.Panel8.TabIndex = 6
        '
        'chbEngarantia
        '
        Me.chbEngarantia.AutoSize = True
        Me.chbEngarantia.Dock = System.Windows.Forms.DockStyle.Top
        Me.chbEngarantia.ForeColor = System.Drawing.Color.Magenta
        Me.chbEngarantia.Location = New System.Drawing.Point(0, 40)
        Me.chbEngarantia.Name = "chbEngarantia"
        Me.chbEngarantia.Size = New System.Drawing.Size(106, 20)
        Me.chbEngarantia.TabIndex = 5
        Me.chbEngarantia.Text = "En garantia"
        Me.chbEngarantia.UseVisualStyleBackColor = True
        '
        'chbCerrada
        '
        Me.chbCerrada.AutoSize = True
        Me.chbCerrada.Dock = System.Windows.Forms.DockStyle.Top
        Me.chbCerrada.ForeColor = System.Drawing.Color.Black
        Me.chbCerrada.Location = New System.Drawing.Point(0, 20)
        Me.chbCerrada.Name = "chbCerrada"
        Me.chbCerrada.Size = New System.Drawing.Size(106, 20)
        Me.chbCerrada.TabIndex = 4
        Me.chbCerrada.Text = "Cerrada"
        Me.chbCerrada.UseVisualStyleBackColor = True
        '
        'chbAvisado
        '
        Me.chbAvisado.AutoSize = True
        Me.chbAvisado.Dock = System.Windows.Forms.DockStyle.Top
        Me.chbAvisado.ForeColor = System.Drawing.Color.Blue
        Me.chbAvisado.Location = New System.Drawing.Point(0, 0)
        Me.chbAvisado.Name = "chbAvisado"
        Me.chbAvisado.Size = New System.Drawing.Size(106, 20)
        Me.chbAvisado.TabIndex = 3
        Me.chbAvisado.Text = "Avisado"
        Me.chbAvisado.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.chbTerminada)
        Me.Panel5.Controls.Add(Me.chbEnproceso)
        Me.Panel5.Controls.Add(Me.chbAbierta)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(114, 79)
        Me.Panel5.TabIndex = 5
        '
        'chbTerminada
        '
        Me.chbTerminada.AutoSize = True
        Me.chbTerminada.Dock = System.Windows.Forms.DockStyle.Top
        Me.chbTerminada.ForeColor = System.Drawing.Color.Red
        Me.chbTerminada.Location = New System.Drawing.Point(0, 40)
        Me.chbTerminada.Name = "chbTerminada"
        Me.chbTerminada.Size = New System.Drawing.Size(114, 20)
        Me.chbTerminada.TabIndex = 5
        Me.chbTerminada.Text = "Terminada"
        Me.chbTerminada.UseVisualStyleBackColor = True
        '
        'chbEnproceso
        '
        Me.chbEnproceso.AutoSize = True
        Me.chbEnproceso.Dock = System.Windows.Forms.DockStyle.Top
        Me.chbEnproceso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chbEnproceso.Location = New System.Drawing.Point(0, 20)
        Me.chbEnproceso.Name = "chbEnproceso"
        Me.chbEnproceso.Size = New System.Drawing.Size(114, 20)
        Me.chbEnproceso.TabIndex = 4
        Me.chbEnproceso.Text = "En proceso"
        Me.chbEnproceso.UseVisualStyleBackColor = True
        '
        'chbAbierta
        '
        Me.chbAbierta.AutoSize = True
        Me.chbAbierta.Dock = System.Windows.Forms.DockStyle.Top
        Me.chbAbierta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chbAbierta.Location = New System.Drawing.Point(0, 0)
        Me.chbAbierta.Name = "chbAbierta"
        Me.chbAbierta.Size = New System.Drawing.Size(114, 20)
        Me.chbAbierta.TabIndex = 3
        Me.chbAbierta.Text = "Abierta"
        Me.chbAbierta.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(0, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Estados"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tbpClientes
        '
        Me.tbpClientes.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.tbpClientes.Controls.Add(Me.Panel9)
        Me.tbpClientes.Controls.Add(Me.Panel4)
        Me.tbpClientes.Location = New System.Drawing.Point(4, 24)
        Me.tbpClientes.Name = "tbpClientes"
        Me.tbpClientes.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpClientes.Size = New System.Drawing.Size(966, 100)
        Me.tbpClientes.TabIndex = 1
        Me.tbpClientes.Text = "Clientes"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.ToolStrip4)
        Me.Panel9.Controls.Add(Me.ToolStrip5)
        Me.Panel9.Controls.Add(Me.Label4)
        Me.Panel9.Location = New System.Drawing.Point(142, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(227, 100)
        Me.Panel9.TabIndex = 9
        '
        'ToolStrip4
        '
        Me.ToolStrip4.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip4.Dock = System.Windows.Forms.DockStyle.Left
        Me.ToolStrip4.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip4.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscarC})
        Me.ToolStrip4.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.ToolStrip4.Location = New System.Drawing.Point(176, 0)
        Me.ToolStrip4.Name = "ToolStrip4"
        Me.ToolStrip4.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip4.Size = New System.Drawing.Size(49, 79)
        Me.ToolStrip4.TabIndex = 4
        Me.ToolStrip4.Text = "ToolStrip1"
        '
        'btnBuscarC
        '
        Me.btnBuscarC.Image = CType(resources.GetObject("btnBuscarC.Image"), System.Drawing.Image)
        Me.btnBuscarC.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscarC.Name = "btnBuscarC"
        Me.btnBuscarC.Size = New System.Drawing.Size(46, 76)
        Me.btnBuscarC.Text = "Buscar"
        Me.btnBuscarC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStrip5
        '
        Me.ToolStrip5.AutoSize = False
        Me.ToolStrip5.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip5.Dock = System.Windows.Forms.DockStyle.Left
        Me.ToolStrip5.GripMargin = New System.Windows.Forms.Padding(0)
        Me.ToolStrip5.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip5.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtFiltroC, Me.ToolStripSeparator2, Me.cbxCamposC})
        Me.ToolStrip5.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip5.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip5.Name = "ToolStrip5"
        Me.ToolStrip5.Padding = New System.Windows.Forms.Padding(0)
        Me.ToolStrip5.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip5.Size = New System.Drawing.Size(176, 79)
        Me.ToolStrip5.TabIndex = 3
        Me.ToolStrip5.Text = "ToolStrip2"
        '
        'txtFiltroC
        '
        Me.txtFiltroC.Name = "txtFiltroC"
        Me.txtFiltroC.Size = New System.Drawing.Size(173, 23)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(175, 6)
        '
        'cbxCamposC
        '
        Me.cbxCamposC.Name = "cbxCamposC"
        Me.cbxCamposC.Size = New System.Drawing.Size(173, 23)
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(0, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(225, 19)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Filtrar"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.ToolStrip1)
        Me.Panel4.Controls.Add(Me.ToolStrip2)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(138, 100)
        Me.Panel4.TabIndex = 8
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ToolStrip1.GripMargin = New System.Windows.Forms.Padding(0)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnModificarC})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(49, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0)
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(88, 79)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip2"
        '
        'btnModificarC
        '
        Me.btnModificarC.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnModificarC.Image = CType(resources.GetObject("btnModificarC.Image"), System.Drawing.Image)
        Me.btnModificarC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificarC.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnModificarC.Name = "btnModificarC"
        Me.btnModificarC.Size = New System.Drawing.Size(87, 20)
        Me.btnModificarC.Text = "Modificar"
        Me.btnModificarC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Left
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo})
        Me.ToolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip2.Size = New System.Drawing.Size(49, 79)
        Me.ToolStrip2.TabIndex = 2
        Me.ToolStrip2.Text = "ToolStrip1"
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(46, 76)
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(0, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Clientes"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(974, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel7.Controls.Add(Me.Label5)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel7.Location = New System.Drawing.Point(774, 124)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(200, 567)
        Me.Panel7.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(200, 19)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Notificaciones"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(974, 691)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion de incidencias y mantenimiento"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.tbcPrincipal.ResumeLayout(False)
        Me.tbpIncidencias.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.tspLin2.ResumeLayout(False)
        Me.tspLin2.PerformLayout()
        Me.tspLin1.ResumeLayout(False)
        Me.tspLin1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.tspMos2.ResumeLayout(False)
        Me.tspMos2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.tbpClientes.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.ToolStrip4.ResumeLayout(False)
        Me.ToolStrip4.PerformLayout()
        Me.ToolStrip5.ResumeLayout(False)
        Me.ToolStrip5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents tspMos2 As System.Windows.Forms.ToolStrip
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents tspLin2 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnModificarI As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tspLin1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNueva As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbcPrincipal As System.Windows.Forms.TabControl
    Friend WithEvents tbpIncidencias As System.Windows.Forms.TabPage
    Friend WithEvents tbpClientes As System.Windows.Forms.TabPage
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnBuscarIncidencia As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtFiltroI As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cbxCamposI As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents chbEngarantia As System.Windows.Forms.CheckBox
    Friend WithEvents chbCerrada As System.Windows.Forms.CheckBox
    Friend WithEvents chbAvisado As System.Windows.Forms.CheckBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents chbTerminada As System.Windows.Forms.CheckBox
    Friend WithEvents chbEnproceso As System.Windows.Forms.CheckBox
    Friend WithEvents chbAbierta As System.Windows.Forms.CheckBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnModificarC As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip4 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnBuscarC As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip5 As System.Windows.Forms.ToolStrip
    Friend WithEvents txtFiltroC As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cbxCamposC As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
End Class
