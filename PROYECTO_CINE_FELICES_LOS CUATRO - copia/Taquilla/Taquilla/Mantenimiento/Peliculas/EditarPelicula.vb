Imports MySql.Data.MySqlClient

Public Class EditarPelicula
    Private datos As MySqlDataReader

    Private Sub frmClienteEditar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        editar()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    ''' <summary>
    ''' funcion para cargar los datos de la pelicula a cambiar
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

    Public Sub editar()
        Dim sql As String = "", registros As MySqlDataReader = Nothing, id_peliculas As Integer = 0

        sql = "UPDATE cine.peliculas SET nombre_pelicula = '" & txtNombre.Text & "', Descripcion = '" & txtDescripcion.Text &
        "', duracion_pelicula = '" & txtDuracion.Text & "', estado = '" & txtEstado.Text & "'  
        WHERE id_peliculas = '" & misfunciones.getId & "';"

        mibd.sentencias(sql)
        MessageBox.Show("Se realizo el cambio correctamente", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Dispose()

    End Sub


End Class





