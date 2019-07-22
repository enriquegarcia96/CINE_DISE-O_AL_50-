<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class boletos
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
        Me.btnclose = New System.Windows.Forms.ToolStripButton()
        Me.lvSillas = New System.Windows.Forms.ListView()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(48, 48)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnclose})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 48)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnclose
        '
        Me.btnclose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnclose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnclose.Image = Global.Taquilla.My.Resources.Resources.x_button
        Me.btnclose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(52, 45)
        Me.btnclose.Text = "ToolStripButton4"
        '
        'lvSillas
        '
        Me.lvSillas.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvSillas.BackColor = System.Drawing.SystemColors.Window
        Me.lvSillas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvSillas.FullRowSelect = True
        Me.lvSillas.GridLines = True
        Me.lvSillas.HideSelection = False
        Me.lvSillas.Location = New System.Drawing.Point(0, 48)
        Me.lvSillas.MultiSelect = False
        Me.lvSillas.Name = "lvSillas"
        Me.lvSillas.Size = New System.Drawing.Size(800, 402)
        Me.lvSillas.TabIndex = 7
        Me.lvSillas.UseCompatibleStateImageBehavior = False
        Me.lvSillas.View = System.Windows.Forms.View.Details
        '
        'boletos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lvSillas)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "boletos"
        Me.Text = "boletos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnclose As ToolStripButton
    Friend WithEvents lvSillas As ListView
End Class
