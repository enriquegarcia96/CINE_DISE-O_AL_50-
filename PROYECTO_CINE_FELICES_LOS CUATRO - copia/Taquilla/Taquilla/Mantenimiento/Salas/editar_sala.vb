Imports MySql.Data.MySqlClient

Public Class editar_sala
    Private datos As MySqlDataReader

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        editar()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub editar_sala_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
    End Sub

    Sub cargarDatos()
        Dim sql As String = "SELECT * FROM cine.sala
        WHERE id_sala =" & misfunciones.getId

        datos = mibd.consulta(sql)
        If datos.HasRows Then
            While datos.Read
                txtCapacidad.Text = datos("capacidad")
            End While
        End If
        datos.Close()
    End Sub

    Public Sub editar()
        Dim sql As String = "", registros As MySqlDataReader = Nothing, id_sala As Integer = 0

        sql = "UPDATE cine.sala SET capacidad = '" & Val(txtCapacidad.Text) & "' 
        WHERE id_sala = '" & misfunciones.getId & "';"

        mibd.sentencias(sql)
        MessageBox.Show("Se realizo el cambio correctamente", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Dispose()

    End Sub

End Class