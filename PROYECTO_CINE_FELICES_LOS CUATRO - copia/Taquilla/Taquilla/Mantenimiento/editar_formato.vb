Imports MySql.Data.MySqlClient

Public Class editar_formato
    Private datos As MySqlDataReader

    Private Sub btnGuardar_Click_1(sender As Object, e As EventArgs) Handles btnGuardar.Click
        editar()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub editar_formato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
    End Sub

    Sub cargarDatos()
        Dim sql As String = "SELECT * FROM cine.formato
        WHERE id_formato =" & misfunciones.getId

        datos = mibd.consulta(sql)
        If datos.HasRows Then
            While datos.Read
                txtNombre.Text = datos("nombre_formato")
                txtPrecio.Text = datos("precio_formato")
            End While
        End If
        datos.Close()
    End Sub

    Public Sub editar()
        Dim sql As String = "", registros As MySqlDataReader = Nothing, id_formato As Integer = 0

        sql = "UPDATE cine.formato SET nombre_formato = '" & txtNombre.Text & "', precio_formato = '" & Val(txtPrecio.Text) &
        "'WHERE id_formato = '" & misfunciones.getId & "';"

        mibd.sentencias(sql)
        MessageBox.Show("Se realizo el cambio correctamente", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Dispose()

    End Sub


End Class