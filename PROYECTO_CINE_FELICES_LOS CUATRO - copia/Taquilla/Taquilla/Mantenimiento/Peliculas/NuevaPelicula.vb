Imports MySql.Data.MySqlClient
Public Class NuevaPelicula
    Private datos As MySqlDataReader

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        accion()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub accion()
        Dim sql As String = "", registros As MySqlDataReader, id_peliculas As Integer = 0

        If Trim(txtNombre.Text) <> "" And Trim(txtDescripcion.Text) <> "" And Trim(txtDuracion.Text) _
            <> "" Then
            Try
                sql = "SELECT MAX(id_peliculas) as id FROM cine.peliculas;"
                registros = mibd.consulta(sql)

                If registros.HasRows Then
                    While registros.Read
                        id_peliculas = registros("id")
                    End While
                End If
                registros.Close()

                sql = "INSERT INTO cine.peliculas (id_peliculas, nombre_pelicula, descripcion, duracion_pelicula, estado) values ('" &
                id_peliculas + 1 & "','" & txtNombre.Text & "','" & txtDescripcion.Text & "', '" & txtDuracion.Text & "', '" & txtEstado.Text & "');"

                mibd.sentencias(sql)


            Catch ex As Exception

            End Try
            MessageBox.Show("Se agrego correctamente", "Nueva Pelicula", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            MessageBox.Show("Debe ingresar todos los campos obligatorios")
        End If
        Me.Dispose()
    End Sub



    Private Sub NuevaPelicula_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub gbClientes_Enter(sender As Object, e As EventArgs) Handles gbClientes.Enter

    End Sub
End Class