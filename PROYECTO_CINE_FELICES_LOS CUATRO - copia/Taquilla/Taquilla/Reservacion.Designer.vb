<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class reservacion
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFechaHora = New System.Windows.Forms.TextBox()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.cbsilla = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbformato = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbcartelera = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbPeliculas = New System.Windows.Forms.ComboBox()
        Me.btnReservar = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtRtn = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 244)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "Fecha"
        '
        'txtFechaHora
        '
        Me.txtFechaHora.Location = New System.Drawing.Point(139, 241)
        Me.txtFechaHora.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFechaHora.Multiline = True
        Me.txtFechaHora.Name = "txtFechaHora"
        Me.txtFechaHora.Size = New System.Drawing.Size(86, 19)
        Me.txtFechaHora.TabIndex = 70
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(620, 264)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 69
        '
        'txtprecio
        '
        Me.txtprecio.Location = New System.Drawing.Point(138, 175)
        Me.txtprecio.Margin = New System.Windows.Forms.Padding(2)
        Me.txtprecio.Multiline = True
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(86, 19)
        Me.txtprecio.TabIndex = 68
        '
        'cbsilla
        '
        Me.cbsilla.FormattingEnabled = True
        Me.cbsilla.Items.AddRange(New Object() {"Captain Marvel", "Child's Play", "Hellboy", "Men In Black: International"})
        Me.cbsilla.Location = New System.Drawing.Point(139, 204)
        Me.cbsilla.Margin = New System.Windows.Forms.Padding(2)
        Me.cbsilla.Name = "cbsilla"
        Me.cbsilla.Size = New System.Drawing.Size(86, 21)
        Me.cbsilla.TabIndex = 67
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 207)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(26, 13)
        Me.Label11.TabIndex = 66
        Me.Label11.Text = "Silla"
        '
        'cbformato
        '
        Me.cbformato.FormattingEnabled = True
        Me.cbformato.Items.AddRange(New Object() {"Captain Marvel", "Child's Play", "Hellboy", "Men In Black: International"})
        Me.cbformato.Location = New System.Drawing.Point(138, 146)
        Me.cbformato.Margin = New System.Windows.Forms.Padding(2)
        Me.cbformato.Name = "cbformato"
        Me.cbformato.Size = New System.Drawing.Size(86, 21)
        Me.cbformato.TabIndex = 65
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 149)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 64
        Me.Label10.Text = "Formato"
        '
        'cbcartelera
        '
        Me.cbcartelera.FormattingEnabled = True
        Me.cbcartelera.Items.AddRange(New Object() {"Captain Marvel", "Child's Play", "Hellboy", "Men In Black: International"})
        Me.cbcartelera.Location = New System.Drawing.Point(138, 82)
        Me.cbcartelera.Margin = New System.Windows.Forms.Padding(2)
        Me.cbcartelera.Name = "cbcartelera"
        Me.cbcartelera.Size = New System.Drawing.Size(86, 21)
        Me.cbcartelera.TabIndex = 63
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 117)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "Pelicula"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 85)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "Hora"
        '
        'cbPeliculas
        '
        Me.cbPeliculas.FormattingEnabled = True
        Me.cbPeliculas.Items.AddRange(New Object() {"Captain Marvel", "Child's Play", "Hellboy", "Men In Black: International"})
        Me.cbPeliculas.Location = New System.Drawing.Point(138, 114)
        Me.cbPeliculas.Margin = New System.Windows.Forms.Padding(2)
        Me.cbPeliculas.Name = "cbPeliculas"
        Me.cbPeliculas.Size = New System.Drawing.Size(212, 21)
        Me.cbPeliculas.TabIndex = 60
        '
        'btnReservar
        '
        Me.btnReservar.Location = New System.Drawing.Point(3, 288)
        Me.btnReservar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReservar.Name = "btnReservar"
        Me.btnReservar.Size = New System.Drawing.Size(105, 47)
        Me.btnReservar.TabIndex = 59
        Me.btnReservar.Text = "Reservar"
        Me.btnReservar.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(138, 26)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombre.Multiline = True
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(242, 19)
        Me.txtNombre.TabIndex = 55
        '
        'txtRtn
        '
        Me.txtRtn.Location = New System.Drawing.Point(138, 56)
        Me.txtRtn.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRtn.Multiline = True
        Me.txtRtn.Name = "txtRtn"
        Me.txtRtn.Size = New System.Drawing.Size(242, 19)
        Me.txtRtn.TabIndex = 56
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 59)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "RTN"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 26)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 13)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Nombre Del Cliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 178)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Precio"
        '
        'reservacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(945, 453)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFechaHora)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.txtprecio)
        Me.Controls.Add(Me.cbsilla)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cbformato)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cbcartelera)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbPeliculas)
        Me.Controls.Add(Me.btnReservar)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtRtn)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "reservacion"
        Me.Text = "Reservacion"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents txtFechaHora As TextBox
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents cbsilla As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cbformato As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cbcartelera As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cbPeliculas As ComboBox
    Friend WithEvents btnReservar As Button
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtRtn As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
End Class
