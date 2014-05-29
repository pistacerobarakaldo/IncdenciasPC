<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAcercade
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAcercade))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblWeb = New System.Windows.Forms.Label()
        Me.ptbFacebook = New System.Windows.Forms.PictureBox()
        Me.ptbTwitter = New System.Windows.Forms.PictureBox()
        Me.lblCerrar = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbFacebook, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbTwitter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(195, 195)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(213, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(270, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pista Cero Barakaldo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(216, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 64)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "C/ Gipuzkoa 4, lonja 1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "48901 - Barakaldo (Bizkaia)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "946 420 002 - 670 820 915"
        '
        'lblWeb
        '
        Me.lblWeb.AutoSize = True
        Me.lblWeb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeb.ForeColor = System.Drawing.Color.Blue
        Me.lblWeb.Location = New System.Drawing.Point(216, 122)
        Me.lblWeb.Name = "lblWeb"
        Me.lblWeb.Size = New System.Drawing.Size(174, 16)
        Me.lblWeb.TabIndex = 3
        Me.lblWeb.Text = "www.pistacerobarakaldo.es"
        '
        'ptbFacebook
        '
        Me.ptbFacebook.Image = CType(resources.GetObject("ptbFacebook.Image"), System.Drawing.Image)
        Me.ptbFacebook.Location = New System.Drawing.Point(219, 157)
        Me.ptbFacebook.Name = "ptbFacebook"
        Me.ptbFacebook.Size = New System.Drawing.Size(50, 50)
        Me.ptbFacebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbFacebook.TabIndex = 5
        Me.ptbFacebook.TabStop = False
        '
        'ptbTwitter
        '
        Me.ptbTwitter.Image = CType(resources.GetObject("ptbTwitter.Image"), System.Drawing.Image)
        Me.ptbTwitter.Location = New System.Drawing.Point(275, 157)
        Me.ptbTwitter.Name = "ptbTwitter"
        Me.ptbTwitter.Size = New System.Drawing.Size(50, 50)
        Me.ptbTwitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbTwitter.TabIndex = 6
        Me.ptbTwitter.TabStop = False
        '
        'lblCerrar
        '
        Me.lblCerrar.AutoSize = True
        Me.lblCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCerrar.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblCerrar.Location = New System.Drawing.Point(508, -3)
        Me.lblCerrar.Name = "lblCerrar"
        Me.lblCerrar.Size = New System.Drawing.Size(20, 24)
        Me.lblCerrar.TabIndex = 7
        Me.lblCerrar.Text = "x"
        '
        'frmAcercade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(528, 220)
        Me.Controls.Add(Me.lblCerrar)
        Me.Controls.Add(Me.ptbTwitter)
        Me.Controls.Add(Me.ptbFacebook)
        Me.Controls.Add(Me.lblWeb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAcercade"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pista Cero Barakaldo"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbFacebook, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbTwitter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblWeb As System.Windows.Forms.Label
    Friend WithEvents ptbFacebook As System.Windows.Forms.PictureBox
    Friend WithEvents ptbTwitter As System.Windows.Forms.PictureBox
    Friend WithEvents lblCerrar As System.Windows.Forms.Label
End Class
