Imports MySql.Data.MySqlClient

Public Class nueva_sala
    Private datos As MySqlDataReader

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        accion()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub accion()
        Dim sql As String = "", registros As MySqlDataReader, id_sala As Integer = 0

        If Trim(txtCapacidad.Text) Then
            Try
                sql = "SELECT MAX(id_sala) as id FROM cine.sala;"
                registros = mibd.consulta(sql)

                If registros.HasRows Then
                    While registros.Read
                        id_sala = registros("id")
                    End While
                End If
                registros.Close()

                sql = "INSERT INTO cine.sala (id_sala, capacidad) values ('" &
                id_sala + 1 & "','" & txtCapacidad.Text & "');"

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