<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InicioSesion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InicioSesion))
        Me.TransparentControl2 = New TransControl_src.TransparentControl()
        Me.TransparentControl1 = New TransControl_src.TransparentControl()
        Me.TXT_CONTRASENA = New ZBobb.AlphaBlendTextBox()
        Me.BOTON_MINIMIZAR = New System.Windows.Forms.PictureBox()
        Me.BOTON_CERRAR = New System.Windows.Forms.PictureBox()
        Me.BOTON_ACCEDER = New System.Windows.Forms.Button()
        Me.TXT_USUARIO = New ZBobb.AlphaBlendTextBox()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.TransparentControl2.SuspendLayout()
        Me.TransparentControl1.SuspendLayout()
        CType(Me.BOTON_MINIMIZAR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BOTON_CERRAR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TransparentControl2
        '
        Me.TransparentControl2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TransparentControl2.Controls.Add(Me.TransparentControl1)
        Me.TransparentControl2.Location = New System.Drawing.Point(-1, -2)
        Me.TransparentControl2.MinimumSize = New System.Drawing.Size(100, 75)
        Me.TransparentControl2.Name = "TransparentControl2"
        Me.TransparentControl2.Opacity = 0.3R
        Me.TransparentControl2.Size = New System.Drawing.Size(731, 312)
        Me.TransparentControl2.TabIndex = 8
        Me.TransparentControl2.Text = "TransparentControl2"
        Me.TransparentControl2.Transparent = True
        Me.TransparentControl2.TransparentColor = System.Drawing.SystemColors.InactiveCaptionText
        '
        'TransparentControl1
        '
        Me.TransparentControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TransparentControl1.Controls.Add(Me.TXT_CONTRASENA)
        Me.TransparentControl1.Controls.Add(Me.BOTON_MINIMIZAR)
        Me.TransparentControl1.Controls.Add(Me.BOTON_CERRAR)
        Me.TransparentControl1.Controls.Add(Me.BOTON_ACCEDER)
        Me.TransparentControl1.Controls.Add(Me.TXT_USUARIO)
        Me.TransparentControl1.Controls.Add(Me.ShapeContainer2)
        Me.TransparentControl1.Location = New System.Drawing.Point(358, 0)
        Me.TransparentControl1.MinimumSize = New System.Drawing.Size(100, 75)
        Me.TransparentControl1.Name = "TransparentControl1"
        Me.TransparentControl1.Opacity = 0.5R
        Me.TransparentControl1.Size = New System.Drawing.Size(371, 311)
        Me.TransparentControl1.TabIndex = 4
        Me.TransparentControl1.Text = "TransparentControl1"
        Me.TransparentControl1.Transparent = True
        Me.TransparentControl1.TransparentColor = System.Drawing.SystemColors.MenuText
        '
        'TXT_CONTRASENA
        '
        Me.TXT_CONTRASENA.BackAlpha = 10
        Me.TXT_CONTRASENA.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TXT_CONTRASENA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_CONTRASENA.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CONTRASENA.ForeColor = System.Drawing.Color.White
        Me.TXT_CONTRASENA.Location = New System.Drawing.Point(17, 170)
        Me.TXT_CONTRASENA.Name = "TXT_CONTRASENA"
        Me.TXT_CONTRASENA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXT_CONTRASENA.Size = New System.Drawing.Size(327, 20)
        Me.TXT_CONTRASENA.TabIndex = 2
        Me.TXT_CONTRASENA.Text = "PASS"
        '
        'BOTON_MINIMIZAR
        '
        Me.BOTON_MINIMIZAR.Image = Global.Taquilla.My.Resources.Resources.minimazar
        Me.BOTON_MINIMIZAR.Location = New System.Drawing.Point(327, 3)
        Me.BOTON_MINIMIZAR.Name = "BOTON_MINIMIZAR"
        Me.BOTON_MINIMIZAR.Size = New System.Drawing.Size(16, 16)
        Me.BOTON_MINIMIZAR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BOTON_MINIMIZAR.TabIndex = 7
        Me.BOTON_MINIMIZAR.TabStop = False
        '
        'BOTON_CERRAR
        '
        Me.BOTON_CERRAR.Image = Global.Taquilla.My.Resources.Resources.cerrar
        Me.BOTON_CERRAR.Location = New System.Drawing.Point(350, 3)
        Me.BOTON_CERRAR.Name = "BOTON_CERRAR"
        Me.BOTON_CERRAR.Size = New System.Drawing.Size(16, 16)
        Me.BOTON_CERRAR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BOTON_CERRAR.TabIndex = 6
        Me.BOTON_CERRAR.TabStop = False
        '
        'BOTON_ACCEDER
        '
        Me.BOTON_ACCEDER.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BOTON_ACCEDER.FlatAppearance.BorderSize = 0
        Me.BOTON_ACCEDER.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BOTON_ACCEDER.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BOTON_ACCEDER.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BOTON_ACCEDER.ForeColor = System.Drawing.Color.Gray
        Me.BOTON_ACCEDER.Location = New System.Drawing.Point(17, 251)
        Me.BOTON_ACCEDER.Name = "BOTON_ACCEDER"
        Me.BOTON_ACCEDER.Size = New System.Drawing.Size(326, 33)
        Me.BOTON_ACCEDER.TabIndex = 3
        Me.BOTON_ACCEDER.Text = "&Acceder"
        Me.BOTON_ACCEDER.UseVisualStyleBackColor = False
        '
        'TXT_USUARIO
        '
        Me.TXT_USUARIO.BackAlpha = 10
        Me.TXT_USUARIO.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TXT_USUARIO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_USUARIO.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_USUARIO.ForeColor = System.Drawing.Color.White
        Me.TXT_USUARIO.Location = New System.Drawing.Point(16, 90)
        Me.TXT_USUARIO.Name = "TXT_USUARIO"
        Me.TXT_USUARIO.Size = New System.Drawing.Size(327, 20)
        Me.TXT_USUARIO.TabIndex = 1
        Me.TXT_USUARIO.Text = "USUARIO"
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1, Me.LineShape2})
        Me.ShapeContainer2.Size = New System.Drawing.Size(371, 311)
        Me.ShapeContainer2.TabIndex = 0
        Me.ShapeContainer2.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.LineShape1.Enabled = False
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 342
        Me.LineShape1.X2 = 17
        Me.LineShape1.Y1 = 190
        Me.LineShape1.Y2 = 190
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.LineShape2.Enabled = False
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 17
        Me.LineShape2.X2 = 353
        Me.LineShape2.Y1 = 110
        Me.LineShape2.Y2 = 110
        '
        'InicioSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(728, 310)
        Me.Controls.Add(Me.TransparentControl2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "InicioSesion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema De boleteria"
        Me.TransparentControl2.ResumeLayout(False)
        Me.TransparentControl1.ResumeLayout(False)
        Me.TransparentControl1.PerformLayout()
        CType(Me.BOTON_MINIMIZAR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BOTON_CERRAR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TransparentControl2 As TransControl_src.TransparentControl
    Friend WithEvents LineShape2 As PowerPacks.LineShape
    Friend WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents TransparentControl1 As TransControl_src.TransparentControl
    Friend WithEvents TXT_USUARIO As ZBobb.AlphaBlendTextBox
    Friend WithEvents ShapeContainer2 As PowerPacks.ShapeContainer
    Friend WithEvents BOTON_ACCEDER As Button
    Friend WithEvents BOTON_CERRAR As PictureBox
    Friend WithEvents BOTON_MINIMIZAR As PictureBox
    Friend WithEvents TXT_CONTRASENA As ZBobb.AlphaBlendTextBox
End Class
