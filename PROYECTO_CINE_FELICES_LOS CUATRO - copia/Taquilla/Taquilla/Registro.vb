Imports MySql.Data.MySqlClient

Public Class Registro

    Private Sub Registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress

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
            txtPassword.Focus()
        End If

    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress

        If Asc(e.KeyChar) = 13 Then
            btnRegistrar.Focus()
        End If
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        accion()
    End Sub

    Private Sub accion()
        Dim sql As String = "", registros As MySqlDataReader, id_usuarios As Integer = 0

        If Trim(txtPassword.Text) = Trim(txtVerificar.Text) Then

            If Trim(txtNombre.Text) <> "" And Trim(txtEmail.Text) <> "" And Trim(txtPassword.Text) _
            <> "" Then
                Try
                    sql = "SELECT MAX(id_usuarios) as id FROM cine.usuarios;"
                    registros = mibd.consulta(sql)

                    If registros.HasRows Then
                        While registros.Read
                            id_usuarios = registros("id")
                        End While
                    End If
                    registros.Close()

                    sql = "INSERT INTO cine.usuarios (id_usuarios, nombre_usuario, correo_electronico, password) values ('" &
                id_usuarios + 1 & "','" & txtNombre.Text & "','" & txtEmail.Text & "', '" & txtPassword.Text & "');"

                    mibd.sentencias(sql)

                Catch ex As Exception

                End Try
                MessageBox.Show("Se agrego correctamente", "Nueva Pelicula", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("Debe ingresar todos los campos obligatorios")
            End If
        Else
            MessageBox.Show("Las contraseñas no coinciden")
        End If
        Me.Dispose()
        LoginForm1.ShowDialog()
    End Sub

End Class