<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIncidencia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIncidencia))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.tspLin2 = New System.Windows.Forms.ToolStrip()
        Me.btnDuplicar = New System.Windows.Forms.ToolStripButton()
        Me.btnModificar = New System.Windows.Forms.ToolStripButton()
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.tspLin1 = New System.Windows.Forms.ToolStrip()
        Me.btnNueva = New System.Windows.Forms.ToolStripButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblPresupuesto = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.tspCli2 = New System.Windows.Forms.ToolStrip()
        Me.btnVerCliente = New System.Windows.Forms.ToolStripButton()
        Me.btnNuevoCliente = New System.Windows.Forms.ToolStripButton()
        Me.tspCli1 = New System.Windows.Forms.ToolStrip()
        Me.btnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tspMos2 = New System.Windows.Forms.ToolStrip()
        Me.btnHistorial = New System.Windows.Forms.ToolStripButton()
        Me.btnPresupuesto = New System.Windows.Forms.ToolStripButton()
        Me.tspMos1 = New System.Windows.Forms.ToolStrip()
        Me.btnDetalles = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.tspMant2 = New System.Windows.Forms.ToolStrip()
        Me.btnGuardaryCerrar = New System.Windows.Forms.ToolStripButton()
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton()
        Me.tspMant1 = New System.Windows.Forms.ToolStrip()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.tspLin2.SuspendLayout()
        Me.tspLin1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.tspCli2.SuspendLayout()
        Me.tspCli1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.tspMos2.SuspendLayout()
        Me.tspMos1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.tspMant2.SuspendLayout()
        Me.tspMant1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(974, 105)
        Me.Panel1.TabIndex = 1
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.tspLin2)
        Me.Panel6.Controls.Add(Me.tspLin1)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Location = New System.Drawing.Point(598, 3)
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
        Me.tspLin2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnDuplicar, Me.btnModificar, Me.btnEliminar})
        Me.tspLin2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.tspLin2.Location = New System.Drawing.Point(48, 0)
        Me.tspLin2.Name = "tspLin2"
        Me.tspLin2.Padding = New System.Windows.Forms.Padding(0)
        Me.tspLin2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tspLin2.Size = New System.Drawing.Size(88, 79)
        Me.tspLin2.TabIndex = 3
        Me.tspLin2.Text = "ToolStrip2"
        '
        'btnDuplicar
        '
        Me.btnDuplicar.Image = CType(resources.GetObject("btnDuplicar.Image"), System.Drawing.Image)
        Me.btnDuplicar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDuplicar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDuplicar.Name = "btnDuplicar"
        Me.btnDuplicar.Size = New System.Drawing.Size(87, 20)
        Me.btnDuplicar.Text = "Duplicar"
        Me.btnDuplicar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnModificar
        '
        Me.btnModificar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(87, 20)
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnEliminar
        '
        Me.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(70, 20)
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.Label6.Text = "Lineas"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.lblPresupuesto)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.lblEstado)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Location = New System.Drawing.Point(739, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(230, 100)
        Me.Panel4.TabIndex = 6
        '
        'lblPresupuesto
        '
        Me.lblPresupuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPresupuesto.Location = New System.Drawing.Point(107, 46)
        Me.lblPresupuesto.Name = "lblPresupuesto"
        Me.lblPresupuesto.Size = New System.Drawing.Size(113, 18)
        Me.lblPresupuesto.TabIndex = 4
        Me.lblPresupuesto.Text = "100,00 €"
        Me.lblPresupuesto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 18)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Presupuesto:"
        '
        'lblEstado
        '
        Me.lblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.Location = New System.Drawing.Point(4, 5)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(221, 21)
        Me.lblEstado.TabIndex = 2
        Me.lblEstado.Text = "Abierta"
        Me.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(0, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(228, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Resumen"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.tspCli2)
        Me.Panel3.Controls.Add(Me.tspCli1)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(421, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(174, 100)
        Me.Panel3.TabIndex = 5
        '
        'tspCli2
        '
        Me.tspCli2.AutoSize = False
        Me.tspCli2.BackColor = System.Drawing.Color.Transparent
        Me.tspCli2.Dock = System.Windows.Forms.DockStyle.Left
        Me.tspCli2.GripMargin = New System.Windows.Forms.Padding(0)
        Me.tspCli2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tspCli2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnVerCliente, Me.btnNuevoCliente})
        Me.tspCli2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.tspCli2.Location = New System.Drawing.Point(49, 0)
        Me.tspCli2.Name = "tspCli2"
        Me.tspCli2.Padding = New System.Windows.Forms.Padding(0)
        Me.tspCli2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tspCli2.Size = New System.Drawing.Size(122, 79)
        Me.tspCli2.TabIndex = 3
        Me.tspCli2.Text = "ToolStrip2"
        '
        'btnVerCliente
        '
        Me.btnVerCliente.Image = CType(resources.GetObject("btnVerCliente.Image"), System.Drawing.Image)
        Me.btnVerCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVerCliente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnVerCliente.Name = "btnVerCliente"
        Me.btnVerCliente.Size = New System.Drawing.Size(121, 20)
        Me.btnVerCliente.Text = "Ver cliente"
        Me.btnVerCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnNuevoCliente
        '
        Me.btnNuevoCliente.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnNuevoCliente.Image = CType(resources.GetObject("btnNuevoCliente.Image"), System.Drawing.Image)
        Me.btnNuevoCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevoCliente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevoCliente.Name = "btnNuevoCliente"
        Me.btnNuevoCliente.Size = New System.Drawing.Size(121, 20)
        Me.btnNuevoCliente.Text = "Nuevo cliente"
        Me.btnNuevoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tspCli1
        '
        Me.tspCli1.BackColor = System.Drawing.Color.Transparent
        Me.tspCli1.Dock = System.Windows.Forms.DockStyle.Left
        Me.tspCli1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tspCli1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tspCli1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscar})
        Me.tspCli1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.tspCli1.Location = New System.Drawing.Point(0, 0)
        Me.tspCli1.Name = "tspCli1"
        Me.tspCli1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tspCli1.Size = New System.Drawing.Size(49, 79)
        Me.tspCli1.TabIndex = 2
        Me.tspCli1.Text = "ToolStrip1"
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(46, 76)
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(0, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cliente"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.tspMos2)
        Me.Panel2.Controls.Add(Me.tspMos1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(185, 3)
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
        Me.tspMos2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnHistorial, Me.btnPresupuesto})
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
        Me.btnHistorial.Image = CType(resources.GetObject("btnHistorial.Image"), System.Drawing.Image)
        Me.btnHistorial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHistorial.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnHistorial.Name = "btnHistorial"
        Me.btnHistorial.Size = New System.Drawing.Size(175, 20)
        Me.btnHistorial.Text = "Historial de actuacion"
        Me.btnHistorial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnPresupuesto
        '
        Me.btnPresupuesto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPresupuesto.Image = CType(resources.GetObject("btnPresupuesto.Image"), System.Drawing.Image)
        Me.btnPresupuesto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPresupuesto.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPresupuesto.Name = "btnPresupuesto"
        Me.btnPresupuesto.Size = New System.Drawing.Size(175, 20)
        Me.btnPresupuesto.Text = "Presupuesto de reaparación"
        Me.btnPresupuesto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.Panel5.Controls.Add(Me.tspMant2)
        Me.Panel5.Controls.Add(Me.tspMant1)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Location = New System.Drawing.Point(3, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(179, 100)
        Me.Panel5.TabIndex = 3
        '
        'tspMant2
        '
        Me.tspMant2.AutoSize = False
        Me.tspMant2.BackColor = System.Drawing.Color.Transparent
        Me.tspMant2.Dock = System.Windows.Forms.DockStyle.Left
        Me.tspMant2.GripMargin = New System.Windows.Forms.Padding(0)
        Me.tspMant2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tspMant2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnGuardaryCerrar, Me.btnImprimir})
        Me.tspMant2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.tspMant2.Location = New System.Drawing.Point(56, 0)
        Me.tspMant2.Name = "tspMant2"
        Me.tspMant2.Padding = New System.Windows.Forms.Padding(0)
        Me.tspMant2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tspMant2.Size = New System.Drawing.Size(122, 79)
        Me.tspMant2.TabIndex = 3
        Me.tspMant2.Text = "ToolStrip2"
        '
        'btnGuardaryCerrar
        '
        Me.btnGuardaryCerrar.Image = CType(resources.GetObject("btnGuardaryCerrar.Image"), System.Drawing.Image)
        Me.btnGuardaryCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardaryCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardaryCerrar.Name = "btnGuardaryCerrar"
        Me.btnGuardaryCerrar.Size = New System.Drawing.Size(121, 20)
        Me.btnGuardaryCerrar.Text = "Guardar y cerrar"
        Me.btnGuardaryCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnImprimir
        '
        Me.btnImprimir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(121, 20)
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.Label4.Size = New System.Drawing.Size(177, 19)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Mantenimiento"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(979, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'frmIncidencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(974, 691)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmIncidencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Incidencia"
        Me.Panel1.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.tspLin2.ResumeLayout(False)
        Me.tspLin2.PerformLayout()
        Me.tspLin1.ResumeLayout(False)
        Me.tspLin1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.tspCli2.ResumeLayout(False)
        Me.tspCli2.PerformLayout()
        Me.tspCli1.ResumeLayout(False)
        Me.tspCli1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.tspMos2.ResumeLayout(False)
        Me.tspMos2.PerformLayout()
        Me.tspMos1.ResumeLayout(False)
        Me.tspMos1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.tspMant2.ResumeLayout(False)
        Me.tspMant2.PerformLayout()
        Me.tspMant1.ResumeLayout(False)
        Me.tspMant1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents btnGuardaryCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents tspMant1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tspMant2 As System.Windows.Forms.ToolStrip
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents tspCli2 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnVerCliente As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnNuevoCliente As System.Windows.Forms.ToolStripButton
    Friend WithEvents tspCli1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents tspMos2 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnHistorial As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPresupuesto As System.Windows.Forms.ToolStripButton
    Friend WithEvents tspMos1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnDetalles As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents lblPresupuesto As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents tspLin2 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnDuplicar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tspLin1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNueva As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
