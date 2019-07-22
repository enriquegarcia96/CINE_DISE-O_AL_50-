Imports MySql.Data.MySqlClient

Public Class LoginForm1

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
        MDIParent1.Dispose()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles label3.Click
        Me.Dispose()
        MDIParent1.Dispose()
    End Sub

    Private Sub txtUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUser.KeyPress

        If (Char.IsNumber(e.KeyChar)) Then
            e.Handled = True
            MessageBox.Show("Solo Se Permiten LETRAS", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else
            If (Char.IsControl(e.KeyChar)) Then
                e.Handled = False
            Else e.Handled = False
            End If
        End If

        If Asc(e.KeyChar) = 13 Then
            txtPass.Focus()
        End If

    End Sub

    Private Sub txtPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPass.KeyPress


        If Asc(e.KeyChar) = 13 Then
            OK.Focus()
        End If
    End Sub

    Private Sub txtUser_Enter(sender As Object, e As EventArgs) Handles txtUser.Enter
        If txtUser.Text = "USUARIO" Then
            txtUser.Text = ""
            txtUser.ForeColor = Color.Black

        End If
    End Sub



    Private Sub txtUser_Leave(sender As Object, e As EventArgs) Handles txtUser.Leave
        If txtUser.Text = "" Then
            txtUser.Text = "USUARIO"
            txtUser.ForeColor = Color.Black

        End If
    End Sub

    Private Sub txtPass_Enter(sender As Object, e As EventArgs) Handles txtPass.Enter
        If txtPass.Text = "CONTRASEÑA" Then
            txtPass.Text = ""
            txtPass.ForeColor = Color.Black
            txtPass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txtPass_Leave(sender As Object, e As EventArgs) Handles txtPass.Leave
        If txtPass.Text = "" Then
            txtPass.Text = "CONTRASEÑA"
            txtPass.ForeColor = Color.Black
            txtPass.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub OK_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim registro As MySqlDataReader

        Dim sql As String = "SELECT * FROM cine.usuarios
                            WHERE nombre_usuario='" & Trim(txtUser.Text) & "' AND password='" & txtPass.Text & "'"

        registro = mibd.consulta(sql)

        If registro.HasRows Then
            Me.Dispose()
        Else
            MessageBox.Show("Usario o Contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
        registro.Close()
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Me.Dispose()
        Registro.ShowDialog()
    End Sub
End Class
