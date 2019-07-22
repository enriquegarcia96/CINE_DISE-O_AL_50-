Imports MySql.Data.MySqlClient

Public Class nueva_cartelera
    Private datos As MySqlDataReader

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        accion()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub
    Private Sub accion()
        Dim sql As String = "", registros As MySqlDataReader, id_cartelera As Integer = 0

        If Trim(txtInicio.Text) <> "" And Trim(txtFinal.Text) _
            <> "" Then
            Try
                sql = "SELECT MAX(id_cartelera) as id FROM cine.cartelera;"
                registros = mibd.consulta(sql)

                If registros.HasRows Then
                    While registros.Read
                        id_cartelera = registros("id")
                    End While
                End If
                registros.Close()

                sql = "INSERT INTO cine.cartelera (id_cartelera, id_sala, hora_inicio, hora_final, estado) 
                values ('" & id_cartelera + 1 & "','" & cbSala.SelectedItem.value & "', '" & txtInicio.Text & "' , '" & txtFinal.Text & "','" & txtEstado.Text & "');"

                mibd.sentencias(sql)


            Catch ex As Exception

            End Try
            MessageBox.Show("Se agrego correctamente", "Nueva Cartelera", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            MessageBox.Show("Debe ingresar todos los campos obligatorios")
        End If
        Me.Dispose()
    End Sub


    Private Sub cargarSala()
        cbSala.Items.Clear()
        Dim sql As String = "select * FROM cine.sala "
        datos = mibd.consulta(sql)
        If datos.HasRows Then
            While datos.Read
                cbSala.Items.Add(New Elementos(datos("id_sala"), datos("id_sala")))
            End While
        End If
        datos.Close()
        cbSala.SelectedIndex = 0
    End Sub

    Private Sub nueva_cartelera_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarSala()
    End Sub
End Class