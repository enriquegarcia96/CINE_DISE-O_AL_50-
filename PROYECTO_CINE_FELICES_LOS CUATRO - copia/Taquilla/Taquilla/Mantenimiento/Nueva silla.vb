Imports MySql.Data.MySqlClient
Public Class Nueva_silla

    Private datos As MySqlDataReader

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        accion()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub accion()
        Dim sql As String = "", registros As MySqlDataReader, id_silla As Integer = 0

        If Trim(txtNombre.Text) <> "" Then
            Try
                sql = "SELECT MAX(id_silla) as id FROM cine.sillas;"
                registros = mibd.consulta(sql)

                If registros.HasRows Then
                    While registros.Read
                        id_silla = registros("id")
                    End While
                End If
                registros.Close()

                sql = "INSERT INTO cine.sillas (id_silla, id_sala, nombre_silla) values ('" &
                id_silla + 1 & "','" & cbSala.SelectedItem.value & "','" & txtNombre.Text & "');"

                mibd.sentencias(sql)


            Catch ex As Exception

            End Try
            MessageBox.Show("Se agrego correctamente", "Nueva silla", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            MessageBox.Show("Debe ingresar todos los campos obligatorios")
        End If
        Me.Dispose()
    End Sub

    Private Sub cargarSala()
        cbSala.Items.Clear()
        Dim sql As String = "SELECT * FROM cine.sala "
        datos = mibd.consulta(sql)
        If datos.HasRows Then
            While datos.Read
                cbSala.Items.Add(New Elementos(datos("id_sala"), datos("id_sala")))
            End While
        End If
        datos.Close()
        cbSala.SelectedIndex = 0
    End Sub

    Private Sub Nueva_silla_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarSala()
    End Sub
End Class