<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoMantenimientos
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
        Me.dgvMantenimientos = New System.Windows.Forms.DataGridView()
        CType(Me.dgvMantenimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvMantenimientos
        '
        Me.dgvMantenimientos.AllowUserToAddRows = False
        Me.dgvMantenimientos.AllowUserToDeleteRows = False
        Me.dgvMantenimientos.BackgroundColor = System.Drawing.Color.White
        Me.dgvMantenimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMantenimientos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMantenimientos.Location = New System.Drawing.Point(0, 0)
        Me.dgvMantenimientos.Name = "dgvMantenimientos"
        Me.dgvMantenimientos.ReadOnly = True
        Me.dgvMantenimientos.Size = New System.Drawing.Size(1181, 619)
        Me.dgvMantenimientos.TabIndex = 5
        '
        'frmListadoMantenimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1181, 619)
        Me.Controls.Add(Me.dgvMantenimientos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmListadoMantenimientos"
        Me.Text = "Mantenimientos"
        CType(Me.dgvMantenimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvMantenimientos As System.Windows.Forms.DataGridView

End Class
