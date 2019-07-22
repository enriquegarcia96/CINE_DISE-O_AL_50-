<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editar_cartelera
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnClose = New System.Windows.Forms.ToolStripButton()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.gbClientes = New System.Windows.Forms.GroupBox()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFinal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbSala = New System.Windows.Forms.ComboBox()
        Me.txtInicio = New System.Windows.Forms.TextBox()
        Me.lblDuracion = New System.Windows.Forms.Label()
        Me.lblFormato = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.gbClientes.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackgroundImage = Global.Taquilla.My.Resources.Resources.colores
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(48, 48)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnClose, Me.btnGuardar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(274, 48)
        Me.ToolStrip1.TabIndex = 7
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnClose
        '
        Me.btnClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnClose.AutoSize = False
        Me.btnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnClose.Image = Global.Taquilla.My.Resources.Resources.x_button
        Me.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(48, 48)
        Me.btnClose.Text = "Salir"
        '
        'btnGuardar
        '
        Me.btnGuardar.AutoSize = False
        Me.btnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnGuardar.Image = Global.Taquilla.My.Resources.Resources.save
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(48, 48)
        Me.btnGuardar.Text = "Guardar"
        '
        'gbClientes
        '
        Me.gbClientes.BackColor = System.Drawing.Color.SlateGray
        Me.gbClientes.Controls.Add(Me.txtEstado)
        Me.gbClientes.Controls.Add(Me.Label2)
        Me.gbClientes.Controls.Add(Me.txtFinal)
        Me.gbClientes.Controls.Add(Me.Label1)
        Me.gbClientes.Controls.Add(Me.cbSala)
        Me.gbClientes.Controls.Add(Me.txtInicio)
        Me.gbClientes.Controls.Add(Me.lblDuracion)
        Me.gbClientes.Controls.Add(Me.lblFormato)
        Me.gbClientes.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbClientes.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.gbClientes.Location = New System.Drawing.Point(12, 65)
        Me.gbClientes.Name = "gbClientes"
        Me.gbClientes.Size = New System.Drawing.Size(248, 165)
        Me.gbClientes.TabIndex = 8
        Me.gbClientes.TabStop = False
        Me.gbClientes.Text = "Carteleras"
        '
        'txtEstado
        '
        Me.txtEstado.Location = New System.Drawing.Point(104, 115)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(101, 22)
        Me.txtEstado.TabIndex = 39
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(19, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 14)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Estado:"
        '
        'txtFinal
        '
        Me.txtFinal.Location = New System.Drawing.Point(104, 88)
        Me.txtFinal.Name = "txtFinal"
        Me.txtFinal.Size = New System.Drawing.Size(101, 22)
        Me.txtFinal.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(19, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 14)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Hora final:"
        '
        'cbSala
        '
        Me.cbSala.FormattingEnabled = True
        Me.cbSala.Location = New System.Drawing.Point(104, 31)
        Me.cbSala.Name = "cbSala"
        Me.cbSala.Size = New System.Drawing.Size(101, 22)
        Me.cbSala.TabIndex = 35
        '
        'txtInicio
        '
        Me.txtInicio.Location = New System.Drawing.Point(104, 61)
        Me.txtInicio.Name = "txtInicio"
        Me.txtInicio.Size = New System.Drawing.Size(101, 22)
        Me.txtInicio.TabIndex = 34
        '
        'lblDuracion
        '
        Me.lblDuracion.AutoSize = True
        Me.lblDuracion.BackColor = System.Drawing.Color.Transparent
        Me.lblDuracion.Location = New System.Drawing.Point(19, 64)
        Me.lblDuracion.Name = "lblDuracion"
        Me.lblDuracion.Size = New System.Drawing.Size(77, 14)
        Me.lblDuracion.TabIndex = 33
        Me.lblDuracion.Text = "Hora inicial:"
        '
        'lblFormato
        '
        Me.lblFormato.AutoSize = True
        Me.lblFormato.BackColor = System.Drawing.Color.Transparent
        Me.lblFormato.Location = New System.Drawing.Point(19, 34)
        Me.lblFormato.Name = "lblFormato"
        Me.lblFormato.Size = New System.Drawing.Size(36, 14)
        Me.lblFormato.TabIndex = 32
        Me.lblFormato.Text = "Sala:"
        '
        'editar_cartelera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(274, 246)
        Me.Controls.Add(Me.gbClientes)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "editar_cartelera"
        Me.Text = "editar_cartelera"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.gbClientes.ResumeLayout(False)
        Me.gbClientes.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnClose As ToolStripButton
    Friend WithEvents btnGuardar As ToolStripButton
    Friend WithEvents gbClientes As GroupBox
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFinal As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbSala As ComboBox
    Friend WithEvents txtInicio As TextBox
    Friend WithEvents lblDuracion As Label
    Friend WithEvents lblFormato As Label
End Class
