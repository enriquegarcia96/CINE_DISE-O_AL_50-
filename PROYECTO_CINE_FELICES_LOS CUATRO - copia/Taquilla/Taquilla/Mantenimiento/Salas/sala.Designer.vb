<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sala
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sala))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.lvPeliculas = New System.Windows.Forms.ListView()
        Me.btnedit = New System.Windows.Forms.ToolStripButton()
        Me.btnnew = New System.Windows.Forms.ToolStripButton()
        Me.btndelete = New System.Windows.Forms.ToolStripButton()
        Me.btnclose = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(48, 48)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnedit, Me.btnnew, Me.btndelete, Me.btnclose})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(792, 57)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'lvPeliculas
        '
        Me.lvPeliculas.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvPeliculas.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.lvPeliculas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvPeliculas.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvPeliculas.FullRowSelect = True
        Me.lvPeliculas.GridLines = True
        Me.lvPeliculas.HideSelection = False
        Me.lvPeliculas.Location = New System.Drawing.Point(0, 57)
        Me.lvPeliculas.MultiSelect = False
        Me.lvPeliculas.Name = "lvPeliculas"
        Me.lvPeliculas.Size = New System.Drawing.Size(792, 385)
        Me.lvPeliculas.TabIndex = 4
        Me.lvPeliculas.UseCompatibleStateImageBehavior = False
        Me.lvPeliculas.View = System.Windows.Forms.View.Details
        '
        'btnedit
        '
        Me.btnedit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnedit.Image = CType(resources.GetObject("btnedit.Image"), System.Drawing.Image)
        Me.btnedit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(52, 54)
        Me.btnedit.Text = "Editar"
        '
        'btnnew
        '
        Me.btnnew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnnew.Image = CType(resources.GetObject("btnnew.Image"), System.Drawing.Image)
        Me.btnnew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(52, 54)
        Me.btnnew.Text = "Agregar"
        '
        'btndelete
        '
        Me.btndelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btndelete.Image = CType(resources.GetObject("btndelete.Image"), System.Drawing.Image)
        Me.btndelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(52, 54)
        Me.btndelete.Text = "Eliminar"
        '
        'btnclose
        '
        Me.btnclose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnclose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnclose.Image = CType(resources.GetObject("btnclose.Image"), System.Drawing.Image)
        Me.btnclose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(52, 54)
        Me.btnclose.Text = "Cerrar"
        '
        'sala
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 442)
        Me.ControlBox = False
        Me.Controls.Add(Me.lvPeliculas)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sala"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "sala"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnnew As ToolStripButton
    Friend WithEvents btnedit As ToolStripButton
    Friend WithEvents btndelete As ToolStripButton
    Friend WithEvents btnclose As ToolStripButton
    Friend WithEvents lvPeliculas As ListView
End Class
