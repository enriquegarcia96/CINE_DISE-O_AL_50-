Imports MySql.Data.MySqlClient

Public Class editar_cartelera
    Private datos As MySqlDataReader

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        editar()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub editar_cartelera_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
        cargarSala()
    End Sub

    Sub cargarDatos()
        Dim sql As String = "SELECT * FROM cine.cartelera
               WHERE id_cartelera =" & misfunciones.getId

        datos = mibd.consulta(sql)
        If datos.HasRows Then
            While datos.Read
                cbSala.Text = datos("id_sala")
                txtInicio.Text = datos("hora_inicio")
                txtFinal.Text = datos("hora_final")
                txtEstado.Text = datos("estado")
            End While
        End If
        datos.Close()
    End Sub

    Public Sub editar()
        Dim sql As String = "", registros As MySqlDataReader = Nothing, id_cartelera As Integer = 0

        sql = "UPDATE cine.cartelera SET id_sala = '" & cbSala.SelectedItem.value &
        "',  hora_inicio = '" & txtInicio.Text & "', hora_final = '" & txtFinal.Text & "' , estado = '" & txtEstado.Text & "' 
        WHERE id_cartelera = '" & misfunciones.getId & "';"

        mibd.sentencias(sql)
        MessageBox.Show("Se realizo el cambio correctamente", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information)
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


End Class