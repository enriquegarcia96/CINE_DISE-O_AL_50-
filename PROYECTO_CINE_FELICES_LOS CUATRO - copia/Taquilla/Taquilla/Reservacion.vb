Imports MySql.Data.MySqlClient

Public Class reservacion
    Private datos As MySqlDataReader

    Private Sub btnReservar_Click(sender As Object, e As EventArgs) Handles btnReservar.Click
        accion()
    End Sub

    Private Sub accion()
        Dim sql As String = "", sql2 As String = "", sql3 As String = "", sql4 As String = "", registros As MySqlDataReader, registros2 As MySqlDataReader, registros3 As MySqlDataReader, registros4 As MySqlDataReader, id_reservacion As Integer = 0, id_boleto As Integer = 0, id_pago As Integer = 0, reservacion_boleto As Integer = 0

        If Trim(txtNombre.Text) <> "" And Trim(txtRtn.Text) <> "" Then
            Try
                sql = "SELECT MAX(id_reservacion) as id FROM cine.reservacion;"
                sql2 = "SELECT MAX(idboleto) as id2 FROM cine.boleto;"
                sql3 = "SELECT MAX(id_pago) as id3 FROM cine.historico_pagos;"
                sql4 = "SELECT MAX(reservacion_boleto) as id4 FROM cine.reservacion_boleto;"

                registros = mibd.consulta(sql)

                If registros.HasRows Then
                    While registros.Read
                        id_reservacion = registros("id")
                    End While
                End If
                registros.Close()

                sql = "INSERT INTO cine.reservacion (id_reservacion, id_pelicula, nombre_cliente, rtn_cliente) values ('" & id_reservacion + 1 & "','" & cbPeliculas.SelectedItem.Value & "','" & txtNombre.Text & "', '" & txtRtn.Text & "');"
                mibd.sentencias(sql)


                registros2 = mibd.consulta(sql2)

                If registros2.HasRows Then
                    While registros2.Read
                        id_boleto = registros2("id2")
                    End While
                End If
                registros2.Close()

                sql2 = "INSERT INTO cine.boleto (idboleto, id_cartelera, id_silla, fecha_compra) values ('" & id_boleto + 1 & "','" & cbcartelera.SelectedItem.value & "', '" & cbsilla.SelectedItem.value & "','" & txtFechaHora.Text & "');"
                mibd.sentencias(sql2)

                registros3 = mibd.consulta(sql3)

                If registros3.HasRows Then
                    While registros3.Read
                        id_pago = registros3("id3")
                    End While
                End If
                registros3.Close()

                sql3 = "INSERT INTO cine.historico_pagos (id_pago, id_reservacion, id_formato) values ('" & id_pago + 1 & "','" & id_reservacion + 1 & "', '" & cbformato.SelectedItem.value & "');"
                mibd.sentencias(sql3)

                registros4 = mibd.consulta(sql4)

                If registros4.HasRows Then
                    While registros4.Read
                        reservacion_boleto = registros4("id4")
                    End While
                End If
                registros4.Close()

                sql4 = "INSERT INTO cine.reservacion_boleto (reservacion_boleto, id_reservacion, id_boleto) values ('" & reservacion_boleto + 1 & "','" & id_reservacion + 1 & "', '" & id_boleto + 1 & "');"
                mibd.sentencias(sql4)

            Catch ex As Exception

            End Try
            MessageBox.Show("Se agrego correctamente", "Nueva reservacion", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Else
            MessageBox.Show("Debe ingresar todos los campos obligatorios")
        End If

    End Sub

    Private Sub cargarFormato()
        cbformato.Items.Clear()
        Dim sql As String = "SELECT * FROM cine.formato "
        datos = mibd.consulta(sql)
        If datos.HasRows Then
            While datos.Read
                cbformato.Items.Add(New Elementos(datos("nombre_formato"), datos("id_formato")))
            End While
        End If
        datos.Close()
        cbformato.SelectedIndex = 0
    End Sub

    Private Sub cargarCartelera()
        cbcartelera.Items.Clear()
        Dim sql As String = "SELECT * FROM cine.cartelera
                                WHERE estado = 'activo';"
        datos = mibd.consulta(sql)
        If datos.HasRows Then
            While datos.Read
                cbcartelera.Items.Add(New Elementos(datos("hora_inicio"), datos("id_cartelera")))
            End While
        End If
        datos.Close()
        cbcartelera.SelectedIndex = 0


    End Sub

    Private Sub cargarpelicula()
        cbPeliculas.Items.Clear()
        Dim sql As String = "SELECT * FROM cine.peliculas
                               WHERE estado = 'activo'; "
        datos = mibd.consulta(sql)
        If datos.HasRows Then
            While datos.Read
                cbPeliculas.Items.Add(New Elementos(datos("nombre_pelicula"), datos("id_peliculas")))
            End While
        End If
        datos.Close()
        cbPeliculas.SelectedIndex = 0
    End Sub

    Private Sub cargarSilla()
        cbsilla.Items.Clear()
        Dim sql As String = "SELECT * FROM cine.sillas "
        datos = mibd.consulta(sql)
        If datos.HasRows Then
            While datos.Read
                cbsilla.Items.Add(New Elementos(datos("nombre_silla"), datos("id_silla")))
            End While
        End If
        datos.Close()
        cbsilla.SelectedIndex = 0
    End Sub


    Private Sub reservacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCartelera()
        cargarpelicula()
        cargarFormato()
        cargarSilla()
        txtprecio.Enabled = False
        txtFechaHora.Enabled = False
        txtFechaHora.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")

    End Sub



    Private Sub cbformato_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbformato.SelectedIndexChanged
        If cbformato.SelectedIndex = 0 Then
            txtprecio.Text = 65.5
        ElseIf cbformato.SelectedIndex = 1 Then
            txtprecio.Text = 120.5
        ElseIf cbformato.SelectedIndex = 2 Then
            txtprecio.Text = 150.5
        End If
    End Sub


End Class
