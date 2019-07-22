Public Class InicioSesion
    Dim Usuario As String = "cine"
    Dim Pass As String = "hola"



    Private Sub BOTON_CERRAR_Click(sender As Object, e As EventArgs) Handles BOTON_CERRAR.Click
        Me.Dispose()
        Menu2.Dispose()

    End Sub

    Private Sub TXT_USUARIO_Enter(sender As Object, e As EventArgs) Handles TXT_USUARIO.Enter
        If TXT_USUARIO.Text = "USUARIO" Then
            TXT_USUARIO.Text = ""
            TXT_USUARIO.ForeColor = Color.LightGreen

        End If
    End Sub

    Private Sub TXT_USUARIO_Leave(sender As Object, e As EventArgs) Handles TXT_USUARIO.Leave
        If TXT_USUARIO.Text = "" Then
            TXT_USUARIO.Text = "USUARIO"
            TXT_USUARIO.ForeColor = Color.LightGreen
        End If
    End Sub

    Private Sub TXT_CONTRASENA_Enter(sender As Object, e As EventArgs) Handles TXT_CONTRASENA.Enter
        If TXT_CONTRASENA.Text = "PASS" Then
            TXT_CONTRASENA.Text = ""
            TXT_CONTRASENA.ForeColor = Color.LightGreen
            '  TXT_CONTRASENA.UseSystemPasswordChar = True

        End If

    End Sub

    Private Sub TXT_CONTRASENA_Leave(sender As Object, e As EventArgs) Handles TXT_CONTRASENA.Leave
        If TXT_CONTRASENA.Text = "" Then
            TXT_CONTRASENA.Text = "PASS"
            TXT_CONTRASENA.ForeColor = Color.LightGreen
            ' TXT_CONTRASENA.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub TXT_USUARIO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_USUARIO.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TXT_CONTRASENA.Focus()
        End If

    End Sub

    Private Sub TXT_CONTRASENA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_CONTRASENA.KeyPress
        If Asc(e.KeyChar) = 13 Then
            BOTON_ACCEDER.Focus()
        End If

    End Sub

    Private Sub BOTON_ACCEDER_Click(sender As Object, e As EventArgs) Handles BOTON_ACCEDER.Click



        If Usuario = TXT_USUARIO.Text And Pass = TXT_CONTRASENA.Text Then
            Me.Dispose()
        Else
            MessageBox.Show("Contraseña Incorrecta ", "Advertencia ¡ PAPU !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)


        End If

    End Sub

    Private Sub BOTON_MINIMIZAR_Click(sender As Object, e As EventArgs) Handles BOTON_MINIMIZAR.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub InicioSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class
