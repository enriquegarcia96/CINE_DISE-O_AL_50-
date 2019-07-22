<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sillas
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.lvSillas = New System.Windows.Forms.ListView()
        Me.btnnew = New System.Windows.Forms.ToolStripButton()
        Me.btnedit = New System.Windows.Forms.ToolStripButton()
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
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnnew, Me.btnedit, Me.btndelete, Me.btnclose})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 68)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'lvSillas
        '
        Me.lvSillas.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvSillas.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.lvSillas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvSillas.FullRowSelect = True
        Me.lvSillas.GridLines = True
        Me.lvSillas.HideSelection = False
        Me.lvSillas.Location = New System.Drawing.Point(0, 68)
        Me.lvSillas.MultiSelect = False
        Me.lvSillas.Name = "lvSillas"
        Me.lvSillas.Size = New System.Drawing.Size(800, 382)
        Me.lvSillas.TabIndex = 4
        Me.lvSillas.UseCompatibleStateImageBehavior = False
        Me.lvSillas.View = System.Windows.Forms.View.Details
        '
        'btnnew
        '
        Me.btnnew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnnew.Image = Global.Taquilla.My.Resources.Resources.script__2_
        Me.btnnew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(52, 65)
        Me.btnnew.Text = "Agregar"
        '
        'btnedit
        '
        Me.btnedit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnedit.Image = Global.Taquilla.My.Resources.Resources.cogwheel
        Me.btnedit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(52, 65)
        Me.btnedit.Text = "Editar"
        '
        'btndelete
        '
        Me.btndelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btndelete.Image = Global.Taquilla.My.Resources.Resources.delete__3_
        Me.btndelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(52, 65)
        Me.btndelete.Text = "Eliminar"
        '
        'btnclose
        '
        Me.btnclose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnclose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnclose.Image = Global.Taquilla.My.Resources.Resources.cancel__1_
        Me.btnclose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(52, 65)
        Me.btnclose.Text = "ToolStripButton4"
        '
        'sillas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lvSillas)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sillas"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "sillas"
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
    Friend WithEvents lvSillas As ListView
End Class
