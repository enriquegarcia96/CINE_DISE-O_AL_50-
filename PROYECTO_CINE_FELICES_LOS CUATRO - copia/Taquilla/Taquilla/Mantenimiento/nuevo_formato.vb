Imports MySql.Data.MySqlClient

Public Class nuevo_formato
    Private datos As MySqlDataReader

    Private Sub btnGuardar_Click_1(sender As Object, e As EventArgs) Handles btnGuardar.Click
        accion()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub accion()
        Dim sql As String = "", registros As MySqlDataReader, id_formato As Integer = 0

        If Trim(txtNombre.Text) <> "" And Trim(txtPrecio.Text) Then
            Try
                sql = "SELECT MAX(id_formato) as id FROM cine.formato;"
                registros = mibd.consulta(sql)

                If registros.HasRows Then
                    While registros.Read
                        id_formato = registros("id")
                    End While
                End If
                registros.Close()

                sql = "INSERT INTO cine.formato (id_formato, nombre_formato, precio_formato) values ('" &
                id_formato + 1 & "','" & txtNombre.Text & "','" & Val(txtPrecio.Text) & "');"

                mibd.sentencias(sql)


            Catch ex As Exception

            End Try
            MessageBox.Show("Se agrego correctamente", "Nueva Pelicula", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            MessageBox.Show("Debe ingresar todos los campos obligatorios")
        End If
        Me.Dispose()
    End Sub


End Class