Imports MySql.Data.MySqlClient
Public Class EliminarPelicula
    Private datos As MySqlDataReader

    Private Sub EliminarPelicula_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        eliminar()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    ''' <summary>
    ''' funcion para cargar los datos a eliminar
    ''' </summary>
    Sub cargarDatos()
        Dim sql As String = "SELECT * FROM cine.peliculas
          WHERE id_peliculas =" & misfunciones.getId

        datos = mibd.consulta(sql)
        If datos.HasRows Then
            While datos.Read
                txtNombre.Text = datos("nombre_pelicula")
                txtDescripcion.Text = datos("descripcion")
                txtDuracion.Text = datos("duracion_pelicula")
                txtEstado.Text = datos("estado")
            End While
        End If
        datos.Close()
    End Sub

    Public Sub eliminar()
        Dim sql As String = "", registros As MySqlDataReader = Nothing, id_peliculas As Integer = 0

        sql = "DELETE FROM cine.peliculas 
        WHERE id_peliculas = '" & misfunciones.getId & "';"

        mibd.sentencias(sql)

        MessageBox.Show("Se elimino correctamente", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Dispose()
    End Sub


End Class