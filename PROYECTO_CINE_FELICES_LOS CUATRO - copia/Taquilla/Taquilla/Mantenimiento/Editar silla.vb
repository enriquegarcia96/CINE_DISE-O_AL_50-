Imports MySql.Data.MySqlClient

Public Class Editar_silla
    Private datos As MySqlDataReader

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        editar()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Sub cargarDatos()
        Dim sql As String = "SELECT * FROM cine.sillas
        INNER JOIN sala ON sillas.id_sala = sala.id_sala 
        WHERE id_silla =" & misfunciones.getId

        datos = mibd.consulta(sql)
        If datos.HasRows Then
            While datos.Read
                txtNombre.Text = datos("nombre_silla")
                cbSala.Text = datos("id_sala")
            End While
        End If
        datos.Close()
    End Sub

    Public Sub editar()
        Dim sql As String = "", registros As MySqlDataReader = Nothing, id_peliculas As Integer = 0

        sql = "UPDATE cine.sillas SET id_sala = '" & cbSala.SelectedItem.value & "', nombre_silla = '" & txtNombre.Text & "' 
        WHERE id_silla = '" & misfunciones.getId & "';"

        mibd.sentencias(sql)
        MessageBox.Show("Se realizo el cambio correctamente", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub Editar_silla_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
        cargarSala()
    End Sub
End Class