<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MDIParent1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIParent1))
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ReservacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BoletosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagRealizadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnclose = New System.Windows.Forms.ToolStripButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pro1 = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.pro1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReservacionToolStripMenuItem, Me.BoletosToolStripMenuItem, Me.PagRealizadosToolStripMenuItem, Me.btnclose})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(215, 788)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ReservacionToolStripMenuItem
        '
        Me.ReservacionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.ReservacionToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ReservacionToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.ReservacionToolStripMenuItem.Image = CType(resources.GetObject("ReservacionToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ReservacionToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ReservacionToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White
        Me.ReservacionToolStripMenuItem.Margin = New System.Windows.Forms.Padding(3, 10, 0, 0)
        Me.ReservacionToolStripMenuItem.Name = "ReservacionToolStripMenuItem"
        Me.ReservacionToolStripMenuItem.Padding = New System.Windows.Forms.Padding(10, 10, 10, 5)
        Me.ReservacionToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ReservacionToolStripMenuItem.Size = New System.Drawing.Size(205, 83)
        Me.ReservacionToolStripMenuItem.Text = "Reservacion"
        Me.ReservacionToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.ReservacionToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'BoletosToolStripMenuItem
        '
        Me.BoletosToolStripMenuItem.AutoSize = False
        Me.BoletosToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BoletosToolStripMenuItem.ForeColor = System.Drawing.Color.MidnightBlue
        Me.BoletosToolStripMenuItem.Image = CType(resources.GetObject("BoletosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BoletosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BoletosToolStripMenuItem.Margin = New System.Windows.Forms.Padding(100, 5, -2, -2)
        Me.BoletosToolStripMenuItem.Name = "BoletosToolStripMenuItem"
        Me.BoletosToolStripMenuItem.Padding = New System.Windows.Forms.Padding(20, 20, 20, 5)
        Me.BoletosToolStripMenuItem.Size = New System.Drawing.Size(219, 90)
        Me.BoletosToolStripMenuItem.Text = "Boletos"
        Me.BoletosToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BoletosToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.BoletosToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'PagRealizadosToolStripMenuItem
        '
        Me.PagRealizadosToolStripMenuItem.ForeColor = System.Drawing.Color.MidnightBlue
        Me.PagRealizadosToolStripMenuItem.Image = CType(resources.GetObject("PagRealizadosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PagRealizadosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PagRealizadosToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.PagRealizadosToolStripMenuItem.MergeIndex = -2
        Me.PagRealizadosToolStripMenuItem.Name = "PagRealizadosToolStripMenuItem"
        Me.PagRealizadosToolStripMenuItem.Padding = New System.Windows.Forms.Padding(0, 30, 0, 0)
        Me.PagRealizadosToolStripMenuItem.Size = New System.Drawing.Size(208, 98)
        Me.PagRealizadosToolStripMenuItem.Text = "Pagos Realizados"
        Me.PagRealizadosToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PagRealizadosToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'btnclose
        '
        Me.btnclose.AutoSize = False
        Me.btnclose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnclose.Image = CType(resources.GetObject("btnclose.Image"), System.Drawing.Image)
        Me.btnclose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnclose.ImageTransparentColor = System.Drawing.Color.White
        Me.btnclose.Margin = New System.Windows.Forms.Padding(0, 320, 0, 0)
        Me.btnclose.MergeIndex = -2
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.btnclose.Size = New System.Drawing.Size(90, 63)
        Me.btnclose.Text = "Salir"
        Me.btnclose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(20, 316)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(181, 36)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Mantenimiento"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'pro1
        '
        Me.pro1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.pro1.Controls.Add(Me.Button6)
        Me.pro1.Controls.Add(Me.Button5)
        Me.pro1.Controls.Add(Me.Button2)
        Me.pro1.Controls.Add(Me.Button4)
        Me.pro1.Controls.Add(Me.Button3)
        Me.pro1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pro1.Location = New System.Drawing.Point(22, 351)
        Me.pro1.Name = "pro1"
        Me.pro1.Size = New System.Drawing.Size(180, 252)
        Me.pro1.TabIndex = 22
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(1, 203)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(177, 47)
        Me.Button6.TabIndex = 27
        Me.Button6.Text = "Button6"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(0, 154)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(177, 47)
        Me.Button5.TabIndex = 26
        Me.Button5.Text = "Button5"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(2, 41)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(177, 43)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(2, 90)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(177, 47)
        Me.Button4.TabIndex = 24
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(0, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(178, 36)
        Me.Button3.TabIndex = 23
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'MDIParent1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Taquilla.My.Resources.Resources.ALLANNNN
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(972, 788)
        Me.Controls.Add(Me.pro1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Name = "MDIParent1"
        Me.Text = "Inicio"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.pro1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ReservacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BoletosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PagRealizadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnclose As ToolStripButton
    Friend WithEvents Button1 As Button
    Friend WithEvents pro1 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button6 As Button
End Class
